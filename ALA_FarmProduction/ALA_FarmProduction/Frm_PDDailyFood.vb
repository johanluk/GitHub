Public Class Frm_PDDailyFood


#Region "Variables"
    Private isNew As Boolean
    Private UserModified As String

    Dim rowfocus As Integer
    Dim AlertParamName As String
    Dim AlertParamEditName As String
#End Region

#Region "Initial Procedure"

    Private frmParentInfo As DevExpress.XtraEditors.XtraForm
    Private parentribbonx As DevExpress.XtraBars.Ribbon.RibbonControl


    Public Sub New(ByVal parent As DevExpress.XtraEditors.XtraForm, ByVal ConnString As String, ByVal Source As String, ByVal parentribbon As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal ModuleCode As String, ByVal Username As String, ByVal giiDB As String, Optional ByVal GACCDB As String = "", Optional ByVal Warehouse As String = "", Optional ByVal CropYear As String = "")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        frmParentInfo = parent
        parentribbonx = parentribbon
        My.Settings.Item("ConnectionString") = ConnString

    End Sub
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        NavigationFrame1.Dock = DockStyle.Fill
        NavigationFrame1.SelectedPage = NavigationPage1
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

    Function ValidationCheck() As Boolean
        Try
            If (Ed_ProductionNo.EditValue = "") Then
                DxErrorProvider1.SetError(Ed_ProductionNo, "Production Code cannot be empty", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            End If
            'If (Ed_Price.EditValue = 0) Then
            '    DxErrorProvider1.SetError(Ed_Price, "Price cannot be 0", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            'End If
            If (Ed_Weight.EditValue = 0) Then
                DxErrorProvider1.SetError(Ed_Weight, "Weight cannot be 0", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            End If

            If (DxErrorProvider1.HasErrors) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False

        End Try
    End Function

    Sub DisplayHome()


        RibbonPageProcess.Visible = False
        RibbonPageHome.Visible = True
        '        SetSecurityButtonAccess()


        NavigationFrame1.SelectedPage = NavigationPage1

        FillDataAdapter()
        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayProcess()

        RibbonPageProcess.Visible = True
        RibbonPageHome.Visible = False

        NavigationFrame1.SelectedPage = NavigationPage2

        LCGroup_Data.Enabled = True
        LCGroup_Detail.Enabled = True
        '        SetSecurityButtonAccess()


        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub DisplayTransaction()
        RibbonPageProcess.Visible = True
        RibbonPageHome.Visible = False
        '        SetSecurityButtonAccess()


        NavigationFrame1.SelectedPage = NavigationPage2

        LoadDataGridHeader(2)

        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID)), 2, 0)
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDHenHouse_GetData, CInt(GV_Header.GetFocusedRowCellValue(colPeriodID)))

        '     Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue
        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadDataGridHeader(ByVal rowfocus As Integer)
        Ed_ProductionNo.Tag = GV_Header.GetFocusedRowCellValue(colID)
        Ed_ProductionNo.EditValue = GV_Header.GetFocusedRowCellValue(colProductionNo)
        Dt_ProductionDate.EditValue = GV_Header.GetFocusedRowCellValue(colProductionDate)
        Memo_Header.EditValue = GV_Header.GetFocusedRowCellValue(colDescription)
    End Sub

    Private Sub FillDataAdapter()

        Try
            Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyHeader_GetData, Dt_Start.EditValue, Dt_End.EditValue)


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub ResetData()
        Ed_ProductionNo.EditValue = ""
    End Sub

    Private Sub Frm_MDDailyEgg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet.sp_PD_MDInventoryFood_GetData' table. You can move, or remove it, as needed.
        Me.Sp_PD_MDInventoryFood_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDInventoryFood_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_PD_MDShift_GetData' table. You can move, or remove it, as needed.
        Me.Sp_PD_MDShift_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDShift_GetData)

        Dt_Start.EditValue = Today
        Dt_End.EditValue = Today

        DisplayHome()

        FillDataAdapter()
        DxErrorProvider1.ClearErrors()
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

    End Sub

    Private Sub BB_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_New.ItemClick
        Try
            ResetData()
            DisplayProcess()

            Dt_ProductionDate.EditValue = Today

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BB_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Refresh.ItemClick
        FillDataAdapter()
    End Sub

    Private Sub BB_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Close.ItemClick

        Me.Close()
    End Sub

    Private Sub BB_Back_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Back.ItemClick
        DisplayHome()
    End Sub


    Private Sub SB_Search_Click(sender As Object, e As EventArgs) Handles SB_Search.Click
        Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyHeader_GetData, Dt_Start.EditValue, Dt_End.EditValue)
    End Sub

    Private Sub GV_Header_DoubleClick(sender As Object, e As EventArgs) Handles GV_Header.DoubleClick
        If (GV_Header.RowCount > 0) Then
            DisplayTransaction()
        End If
    End Sub

    Private Sub LookUpEdit_HenHouse_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit_HenHouse.EditValueChanged
        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID)), 2, LookUpEdit_HenHouse.EditValue)

    End Sub

    Private Sub SB_Submit_Click(sender As Object, e As EventArgs) Handles SB_Submit.Click
        Try
            AlertParamName = LookUpEdit_Inventory.Text.ToString() + " Berhasil diinput"


            DxErrorProvider1.ClearErrors()
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.QueriesTableAdapter.sp_PDProductionDailyDetail_InsUpdData(2, 0, Ed_ProductionNo.Tag, LookUpEdit_HenHouse.EditValue, 3,
                                                                         LookUpEdit_Inventory.EditValue, 0, Ed_Weight.EditValue, CDbl(Ed_Price.EditValue),
                                                                         Memo_DescDet.EditValue, UserModified, Now)
            Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID)), 2, LookUpEdit_HenHouse.EditValue)

            'SaveData()

            AlertControl1.Show(Me, "Success on Save Data", AlertParamName)
            '   BB_Back.PerformClick()
        Catch ex As Exception
            AlertControl1.Show(Me, "Error on Save Data", ex.Message)
        End Try
    End Sub
End Class