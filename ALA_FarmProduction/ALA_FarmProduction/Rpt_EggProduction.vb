Public Class Rpt_EggProduction
    Private Sub XtraReport2_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_PD_ReportProductionDaily_GetSummaryEggDataTableAdapter1.Fill(Me.DataSet1.sp_PD_ReportProductionDaily_GetSummaryEggData, 4)
    End Sub
End Class