Public Class Rpt_Harian
    Private Sub XtraReport1_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.Sp_PD_ReportProductionDaily_GetDataTableAdapter1.Fill(Me.DataSet1.sp_PD_ReportProductionDaily_GetData, 15)
        Me.Sp_PD_ReportProductionDaily_GetDetailDataTableAdapter.Fill(Me.DataSet1.sp_PD_ReportProductionDaily_GetDetailData, 15)

    End Sub

End Class