Partial Class StudentData_ChrisDataSet
    Partial Public Class DataTable1DataTable
        Private Sub DataTable1DataTable_DataTable1RowChanging(sender As Object, e As DataTable1RowChangeEvent) Handles Me.DataTable1RowChanging

        End Sub

        Private Sub DataTable1DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.GPA1Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class studentData_ChrisDataTable
        Private Sub studentData_ChrisDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Class_AVGColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace StudentData_ChrisDataSetTableAdapters
    Partial Public Class LoginDatabaseTableAdapter
    End Class

    Partial Public Class DataTable1TableAdapter

    End Class

    Partial Public Class studentData_ChrisTableAdapter

    End Class
End Namespace

Namespace StudentData_ChrisDataSetTableAdapters
    Partial Public Class studentData_ChrisTableAdapter
    End Class
End Namespace

Namespace StudentData_ChrisDataSetTableAdapters
    Partial Public Class DataTable1TableAdapter
    End Class
End Namespace
