Public Class Rpt_InventoryTransaction
    Private Sub Rpt_InventoryTransaction_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_PD_ReportProductionDaily_GetInventoryTransactionDataTableAdapter1.Fill(Me.DataSet1.sp_PD_ReportProductionDaily_GetInventoryTransactionData, 15)

    End Sub
End Class