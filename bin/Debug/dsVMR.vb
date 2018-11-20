Partial Class dsThroughput
    Partial Public Class dtOutboundMTYDataTable
        Private Sub dtOutboundMTYDataTable_dtOutboundMTYRowChanging(sender As Object, e As dtOutboundMTYRowChangeEvent) Handles Me.dtOutboundMTYRowChanging

        End Sub

    End Class

    Partial Public Class dtVesselDataTable

    End Class

    Partial Public Class dtCMUDataTable


    End Class

    Partial Public Class dtOBThrghptDataTable
    End Class

    Partial Public Class dtInboundFCLDataTable
        Private Sub dtInboundFCLDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.line_opColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
