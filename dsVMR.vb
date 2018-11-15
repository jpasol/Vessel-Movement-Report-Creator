Partial Class dsThroughput
    Partial Public Class dtVesselDataTable
        Private Sub dtVesselDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RegStafColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtCMUDataTable
        Private Sub dtCMUDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CMUColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtOBThrghptDataTable
    End Class

    Partial Public Class dtInboundDataTable
        Private Sub dtInboundDataTable_dtInboundRowChanging(sender As Object, e As dtInboundRowChangeEvent) Handles Me.dtInboundRowChanging

        End Sub


    End Class
End Class
