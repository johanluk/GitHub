Imports DevExpress.XtraGrid.Views.Grid

Public Class Frm_PDDailyEgg


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
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

    Function ValidationCheck() As Boolean
        Try
            If (Ed_ProductionNo.EditValue = "") Then
                DxErrorProvider1.SetError(Ed_ProductionNo, "Production Code cannot be empty", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            End If

            If (Ed_Qty.EditValue = 0) Then
                DxErrorProvider1.SetError(Ed_Qty, "Qty cannot be 0", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            End If
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

        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, -1, 1, 0)

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


        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID_Header)), 1, 0)

        '     Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue
        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadDataGridHeader(ByVal rowfocus As Integer)
        Ed_ProductionNo.Tag = GV_Header.GetFocusedRowCellValue(colID_Header)
        Ed_ProductionNo.EditValue = GV_Header.GetFocusedRowCellValue(colProductionNo_Header)
        Dt_ProductionDate.EditValue = GV_Header.GetFocusedRowCellValue(colProductionDate_Header)
        Memo_Header.EditValue = GV_Header.GetFocusedRowCellValue(colDescription_Header)
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
        'TODO: This line of code loads data into the 'DataSet.sp_PD_MDInventoryEgg_GetData' table. You can move, or remove it, as needed.
        Me.Sp_PD_MDInventoryEgg_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDInventoryEgg_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_PD_MDShift_GetData' table. You can move, or remove it, as needed.
        Me.Sp_PD_MDShift_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDShift_GetData)
        'TODO: This line of code loads data into the 'DataSet.sp_PD_MDHenHouse_GetData' table. You can move, or remove it, as needed.
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDHenHouse_GetData)
        'TODO: This line of code loads data into the 'DataSet_HenHouse.sp_MDWarehouse_GetData' table. You can move, or remove it, as needed.

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

    Private Sub SaveData()
        Try
            Dim ProductionID As Integer
            Dim ProductionNo As String
            If (LCGroup_Data.Enabled) Then
                If (Ed_ProductionNo.EditValue = "AUTO") Then


                    ProductionNo = Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetNoProduction(Dt_ProductionDate.DateTime, 0, 0, LookUpEdit_HenHouse.EditValue)

                    Me.QueriesTableAdapter.sp_PDProductionDailyHeader_InsData(ProductionNo, Dt_ProductionDate.DateTime, 0,
                                                                     Memo_Header.EditValue,
                                                                     UserModified, Now())

                Else
                    Me.QueriesTableAdapter.sp_PDProductionDailyHeader_UpdData(ProductionNo, Dt_ProductionDate.DateTime, 0,
                                                                    Memo_Header.EditValue,
                                                                    UserModified, Now())
                End If

                ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(ProductionNo))
                Ed_ProductionNo.EditValue = ProductionNo


                DataSet.sp_PDProductionDailyDetail_GetData.Columns("ProductionID").DefaultValue = ProductionID
                '  Me.MasterQueriesTableAdapter.sp_SPMRVCashDetailInsData(MRVID, GVMaterialReceive_Detail.GetFocusedRowCellValue(colisInventory1))
            Else
                ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(Ed_ProductionNo.EditValue).ToString())
                DataSet.sp_PDProductionDailyDetail_GetData.Columns("ProductionID").DefaultValue = ProductionID
            End If

            '    GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colProductionID_Detail, ProductionID)

            ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(ProductionNo))


            '    ValidationCheck()
            Me.Validate()
            Me.Sp_PDProductionDailyDetail_GetDataBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet)
            '  Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue

            Me.QueriesTableAdapter.sp_PDProductionDailyHeader_UpdData(Ed_ProductionNo.EditValue, Dt_ProductionDate.DateTime, LookUpEdit_HenHouse.EditValue,
                                                                     Memo_Header.EditValue, UserModified, Now())
            'If (GVMemo_Detail.RowCount < 1) Then
            '    Me.QueriesTableAdapter.sp_SPMaterialReceiveHeaderDelData(Ed_MRVCode.EditValue, Dt_MRVDate.DateTime)
            'End If
        Catch ex As Exception
            AlertControl1.Show(Me, "Error On Save Data", ex.ToString())
        End Try
    End Sub

    Private Sub BB_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Save.ItemClick
        Try
            AlertParamName = Ed_ProductionNo.EditValue.ToString() + " : " + LookUpEdit_Shift.Text.ToString()

            DxErrorProvider1.ClearErrors()
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            SaveData()

            AlertControl1.Show(Me, "Success on Save Data", AlertParamName)
            BB_Back.PerformClick()
        Catch ex As Exception
            AlertControl1.Show(Me, "Error on Save Data", ex.Message)
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

    Private Sub BB_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Delete.ItemClick
        'If (GVWarehouse.RowCount > 0) Then
        '    GVWarehouse.DeleteSelectedRows()
        '    Dim DeletedVar As String
        '    DeletedVar = WHNameTextEdit.EditValue
        '    If MessageBox.Show("Are you sure you want to delete data?", "Confirmation", MessageBoxButtons.YesNoCancel) = MsgBoxResult.Yes Then

        '        SaveData()

        '        AlertControl1.Show(Me, "Success on Delete Data", DeletedVar)
        '    Else
        '        BB_Refresh.PerformClick()
        '        AlertControl1.Show(Me, "Cancel on Delete Data", DeletedVar)
        '    End If

        'End If
    End Sub

    Private Sub SB_Search_Click(sender As Object, e As EventArgs) Handles SB_Search.Click
        Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyHeader_GetData, Dt_Start.EditValue, Dt_End.EditValue)
    End Sub

    Private Sub GV_Header_DoubleClick(sender As Object, e As EventArgs) Handles GV_Header.DoubleClick
        If (GV_Header.RowCount > 0) Then
            DisplayTransaction()
        End If
    End Sub

    Private Sub GV_Detail_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        'Try
        '    Dim ProductionID As Integer
        '    Dim ProductionNo As String
        '    If (e.RowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle) Then

        '        If (Ed_ProductionNo.EditValue = "AUTO") Then


        '            ProductionNo = Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetNoProduction(Dt_ProductionDate.DateTime, 0, 0, LookUpEdit_HenHouse.EditValue)

        '            Me.QueriesTableAdapter.sp_PDProductionDailyHeader_InsData(ProductionNo, Dt_ProductionDate.DateTime, 0,
        '                                                             Memo_Header.EditValue,
        '                                                             UserModified, Now())

        '            LCGroup_Data.Enabled = False

        '            ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(ProductionNo))
        '            Ed_ProductionNo.EditValue = ProductionNo


        '            DataSet.sp_PDProductionDailyDetail_GetData.Columns("ProductionID").DefaultValue = ProductionID
        '            '  Me.MasterQueriesTableAdapter.sp_SPMRVCashDetailInsData(MRVID, GVMaterialReceive_Detail.GetFocusedRowCellValue(colisInventory1))
        '        Else
        '            ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(Ed_ProductionNo.EditValue).ToString())
        '            DataSet.sp_PDProductionDailyDetail_GetData.Columns("ProductionID").DefaultValue = ProductionID
        '        End If

        '    GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colProductionID_Detail, ProductionID)
        '    '  GV_Detail.SetRowCellValue(DevExpress.XtraGrid.GridControl.NewItemRowHandle, colMemoType_Detail, 0)
        '    Else

        '    ProductionID = CInt(Me.QueriesTableAdapter.sp_PDProductionDailyHeader_GetIDProduction(Ed_ProductionNo.EditValue))
        '    End If

        '    '    ValidationCheck()
        '    Me.Validate()
        '    Me.Sp_PDProductionDailyDetail_GetDataBindingSource.EndEdit()
        '    Me.TableAdapterManager.UpdateAll(Me.DataSet)
        '    Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, ProductionID)
        '    '  Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue

        '    Me.QueriesTableAdapter.sp_PDProductionDailyHeader_UpdData(ProductionNo, Dt_ProductionDate.DateTime, 0,
        '                                                            Memo_Header.EditValue,
        '                                                            UserModified, Now())
        '    'If (GVMemo_Detail.RowCount < 1) Then
        '    '    Me.QueriesTableAdapter.sp_SPMaterialReceiveHeaderDelData(Ed_MRVCode.EditValue, Dt_MRVDate.DateTime)
        '    'End If
        'Catch ex As Exception
        '    AlertControl1.Show(Me, "Error On Save Data", ex.ToString())
        'End Try
    End Sub

    Private Sub Bt_SaveDetail_Click(sender As Object, e As EventArgs) Handles Bt_SaveDetail.Click
        Try
            AlertParamName = Ed_ProductionNo.EditValue.ToString() + " : " + LookUpEdit_Shift.EditValue.ToString()

            DxErrorProvider1.ClearErrors()
            If (ValidationCheck() = False) Then
                Exit Sub
            End If

            Me.QueriesTableAdapter.sp_PDProductionDailyDetail_InsUpdData(1, 0, Ed_ProductionNo.Tag, LookUpEdit_HenHouse.EditValue, LookUpEdit_Shift.EditValue,
                                                                         LookUpEdit1.EditValue, Ed_Qty.EditValue, Ed_Weight.EditValue, 0,
                                                                         Memo_DescDet.EditValue, UserModified, Now)
            Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID_Header)), 1, LookUpEdit_HenHouse.EditValue)

            'SaveData()

            AlertControl1.Show(Me, "Success on Save Data", AlertParamName)
            '   BB_Back.PerformClick()
        Catch ex As Exception
            AlertControl1.Show(Me, "Error on Save Data", ex.Message)
        End Try
    End Sub

    Private Sub LookUpEdit_HenHouse_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit_HenHouse.EditValueChanged
        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID_Header)), 1, LookUpEdit_HenHouse.EditValue)

    End Sub
End Class