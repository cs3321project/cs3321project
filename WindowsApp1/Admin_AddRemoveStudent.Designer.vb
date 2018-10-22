<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemove_Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim Student_IDLabel1 As System.Windows.Forms.Label
        Dim Student_NameLabel1 As System.Windows.Forms.Label
        Dim Exam1Label1 As System.Windows.Forms.Label
        Dim Exam2Label1 As System.Windows.Forms.Label
        Dim Exam3Label1 As System.Windows.Forms.Label
        Dim Exam4Label1 As System.Windows.Forms.Label
        Dim Class_AVGLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddRemove_Student))
        Me.StudentData_ChrisDataSet = New WindowsApp1.StudentData_ChrisDataSet()
        Me.StudentData_ChrisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentData_ChrisTableAdapter = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.studentData_ChrisTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New WindowsApp1.StudentData_ChrisDataSetTableAdapters.DataTable1TableAdapter()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.Student_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Student_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Exam1TextBox1 = New System.Windows.Forms.TextBox()
        Me.Exam2TextBox1 = New System.Windows.Forms.TextBox()
        Me.Exam3TextBox1 = New System.Windows.Forms.TextBox()
        Me.Exam4TextBox1 = New System.Windows.Forms.TextBox()
        Me.Class_AVGTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        SubjectLabel = New System.Windows.Forms.Label()
        Student_IDLabel1 = New System.Windows.Forms.Label()
        Student_NameLabel1 = New System.Windows.Forms.Label()
        Exam1Label1 = New System.Windows.Forms.Label()
        Exam2Label1 = New System.Windows.Forms.Label()
        Exam3Label1 = New System.Windows.Forms.Label()
        Exam4Label1 = New System.Windows.Forms.Label()
        Class_AVGLabel1 = New System.Windows.Forms.Label()
        CType(Me.StudentData_ChrisDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentData_ChrisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectLabel.Location = New System.Drawing.Point(36, 289)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(90, 25)
        SubjectLabel.TabIndex = 44
        SubjectLabel.Text = "Subject:"
        '
        'Student_IDLabel1
        '
        Student_IDLabel1.AutoSize = True
        Student_IDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_IDLabel1.Location = New System.Drawing.Point(36, 95)
        Student_IDLabel1.Name = "Student_IDLabel1"
        Student_IDLabel1.Size = New System.Drawing.Size(115, 25)
        Student_IDLabel1.TabIndex = 46
        Student_IDLabel1.Text = "student ID:"
        '
        'Student_NameLabel1
        '
        Student_NameLabel1.AutoSize = True
        Student_NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NameLabel1.Location = New System.Drawing.Point(36, 121)
        Student_NameLabel1.Name = "Student_NameLabel1"
        Student_NameLabel1.Size = New System.Drawing.Size(151, 25)
        Student_NameLabel1.TabIndex = 48
        Student_NameLabel1.Text = "student Name:"
        '
        'Exam1Label1
        '
        Exam1Label1.AutoSize = True
        Exam1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam1Label1.Location = New System.Drawing.Point(36, 147)
        Exam1Label1.Name = "Exam1Label1"
        Exam1Label1.Size = New System.Drawing.Size(84, 25)
        Exam1Label1.TabIndex = 50
        Exam1Label1.Text = "Exam1:"
        '
        'Exam2Label1
        '
        Exam2Label1.AutoSize = True
        Exam2Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam2Label1.Location = New System.Drawing.Point(36, 173)
        Exam2Label1.Name = "Exam2Label1"
        Exam2Label1.Size = New System.Drawing.Size(84, 25)
        Exam2Label1.TabIndex = 52
        Exam2Label1.Text = "Exam2:"
        '
        'Exam3Label1
        '
        Exam3Label1.AutoSize = True
        Exam3Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam3Label1.Location = New System.Drawing.Point(36, 199)
        Exam3Label1.Name = "Exam3Label1"
        Exam3Label1.Size = New System.Drawing.Size(84, 25)
        Exam3Label1.TabIndex = 54
        Exam3Label1.Text = "Exam3:"
        '
        'Exam4Label1
        '
        Exam4Label1.AutoSize = True
        Exam4Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Exam4Label1.Location = New System.Drawing.Point(36, 225)
        Exam4Label1.Name = "Exam4Label1"
        Exam4Label1.Size = New System.Drawing.Size(84, 25)
        Exam4Label1.TabIndex = 56
        Exam4Label1.Text = "Exam4:"
        '
        'Class_AVGLabel1
        '
        Class_AVGLabel1.AutoSize = True
        Class_AVGLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class_AVGLabel1.Location = New System.Drawing.Point(35, 255)
        Class_AVGLabel1.Name = "Class_AVGLabel1"
        Class_AVGLabel1.Size = New System.Drawing.Size(122, 25)
        Class_AVGLabel1.TabIndex = 58
        Class_AVGLabel1.Text = "Class AVG:"
        '
        'StudentData_ChrisDataSet
        '
        Me.StudentData_ChrisDataSet.DataSetName = "StudentData_ChrisDataSet"
        Me.StudentData_ChrisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentData_ChrisBindingSource
        '
        Me.StudentData_ChrisBindingSource.DataMember = "studentData_Chris"
        Me.StudentData_ChrisBindingSource.DataSource = Me.StudentData_ChrisDataSet
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 56)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "NEW"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Previous"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(354, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Next "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Crimson
        Me.Button4.Location = New System.Drawing.Point(103, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 40)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Button5.Location = New System.Drawing.Point(506, 335)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(145, 40)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = False
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(671, 25)
        Me.BindingNavigator1.TabIndex = 24
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.StudentData_ChrisDataSet
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Subject", True))
        Me.SubjectTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(193, 289)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(167, 31)
        Me.SubjectTextBox.TabIndex = 45
        '
        'Student_IDTextBox1
        '
        Me.Student_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "student_ID", True))
        Me.Student_IDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_IDTextBox1.Location = New System.Drawing.Point(193, 89)
        Me.Student_IDTextBox1.Name = "Student_IDTextBox1"
        Me.Student_IDTextBox1.Size = New System.Drawing.Size(166, 31)
        Me.Student_IDTextBox1.TabIndex = 47
        '
        'Student_NameTextBox1
        '
        Me.Student_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "student_Name", True))
        Me.Student_NameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NameTextBox1.Location = New System.Drawing.Point(193, 115)
        Me.Student_NameTextBox1.Name = "Student_NameTextBox1"
        Me.Student_NameTextBox1.Size = New System.Drawing.Size(166, 31)
        Me.Student_NameTextBox1.TabIndex = 49
        '
        'Exam1TextBox1
        '
        Me.Exam1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam1", True))
        Me.Exam1TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam1TextBox1.Location = New System.Drawing.Point(193, 144)
        Me.Exam1TextBox1.Name = "Exam1TextBox1"
        Me.Exam1TextBox1.Size = New System.Drawing.Size(54, 31)
        Me.Exam1TextBox1.TabIndex = 51
        '
        'Exam2TextBox1
        '
        Me.Exam2TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam2", True))
        Me.Exam2TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam2TextBox1.Location = New System.Drawing.Point(193, 170)
        Me.Exam2TextBox1.Name = "Exam2TextBox1"
        Me.Exam2TextBox1.Size = New System.Drawing.Size(54, 31)
        Me.Exam2TextBox1.TabIndex = 53
        '
        'Exam3TextBox1
        '
        Me.Exam3TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam3", True))
        Me.Exam3TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam3TextBox1.Location = New System.Drawing.Point(193, 196)
        Me.Exam3TextBox1.Name = "Exam3TextBox1"
        Me.Exam3TextBox1.Size = New System.Drawing.Size(54, 31)
        Me.Exam3TextBox1.TabIndex = 55
        '
        'Exam4TextBox1
        '
        Me.Exam4TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Exam4", True))
        Me.Exam4TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exam4TextBox1.Location = New System.Drawing.Point(193, 222)
        Me.Exam4TextBox1.Name = "Exam4TextBox1"
        Me.Exam4TextBox1.Size = New System.Drawing.Size(54, 31)
        Me.Exam4TextBox1.TabIndex = 57
        '
        'Class_AVGTextBox1
        '
        Me.Class_AVGTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Class AVG", True))
        Me.Class_AVGTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Class_AVGTextBox1.Location = New System.Drawing.Point(192, 255)
        Me.Class_AVGTextBox1.Name = "Class_AVGTextBox1"
        Me.Class_AVGTextBox1.Size = New System.Drawing.Size(167, 31)
        Me.Class_AVGTextBox1.TabIndex = 59
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataTable1BindingSource
        Me.ComboBox1.DisplayMember = "student_Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(288, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(297, 28)
        Me.ComboBox1.TabIndex = 64
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(13, 335)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 39)
        Me.Button6.TabIndex = 65
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AddRemove_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(671, 407)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(Student_IDLabel1)
        Me.Controls.Add(Me.Student_IDTextBox1)
        Me.Controls.Add(Student_NameLabel1)
        Me.Controls.Add(Me.Student_NameTextBox1)
        Me.Controls.Add(Exam1Label1)
        Me.Controls.Add(Me.Exam1TextBox1)
        Me.Controls.Add(Exam2Label1)
        Me.Controls.Add(Me.Exam2TextBox1)
        Me.Controls.Add(Exam3Label1)
        Me.Controls.Add(Me.Exam3TextBox1)
        Me.Controls.Add(Exam4Label1)
        Me.Controls.Add(Me.Exam4TextBox1)
        Me.Controls.Add(Class_AVGLabel1)
        Me.Controls.Add(Me.Class_AVGTextBox1)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddRemove_Student"
        Me.Text = "AddRemove_Student"
        CType(Me.StudentData_ChrisDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentData_ChrisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentData_ChrisDataSet As StudentData_ChrisDataSet
    Friend WithEvents StudentData_ChrisBindingSource As BindingSource
    Friend WithEvents StudentData_ChrisTableAdapter As StudentData_ChrisDataSetTableAdapters.studentData_ChrisTableAdapter
    Friend WithEvents TableAdapterManager As StudentData_ChrisDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As StudentData_ChrisDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents Student_IDTextBox1 As TextBox
    Friend WithEvents Student_NameTextBox1 As TextBox
    Friend WithEvents Exam1TextBox1 As TextBox
    Friend WithEvents Exam2TextBox1 As TextBox
    Friend WithEvents Exam3TextBox1 As TextBox
    Friend WithEvents Exam4TextBox1 As TextBox
    Friend WithEvents Class_AVGTextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
End Class
