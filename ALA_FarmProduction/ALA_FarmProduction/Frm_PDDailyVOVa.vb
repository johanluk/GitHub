﻿Public Class Frm_PDDailyVOV


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
        ' Add any initialization after the InitializeComponent() call.
    End Sub

#End Region

    Function ValidationCheck() As Boolean
        Try
            If (Ed_ProductionNo.EditValue = "") Then
                DxErrorProvider1.SetError(Ed_ProductionNo, "Production Code cannot be empty", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
            End If
            If (Dt_ProductionDate.EditValue = "") Then
                DxErrorProvider1.SetError(Dt_ProductionDate, "Currency Name cannot be empty", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning)
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

        LCGroup_Data.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization

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

        LC_Header.Visible = False
        LC_Detail.Visible = True
        LC_Detail.Dock = DockStyle.Fill

        LCGroup_Data.Enabled = True
        LCGroup_Detail.Enabled = True
        '        SetSecurityButtonAccess()

        LCGroup_Data.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LCGroup_Detail.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always

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

        LC_Header.Visible = False
        LC_Detail.Visible = True
        LC_Detail.Dock = DockStyle.Fill

        LCGroup_Data.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        LCGroup_Data.Enabled = False
        LCGroup_Detail.Enabled = True

        LoadDataGridHeader(2)

        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, CInt(GV_Header.GetFocusedRowCellValue(colID_Header)), 3)

        '     Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue
        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadDataGridHeader(ByVal rowfocus As Integer)
        Ed_ProductionNo.EditValue = GV_Header.GetFocusedRowCellValue(colID_Header)
        Dt_ProductionDate.EditValue = GV_Header.GetFocusedRowCellValue(colProductionDate_Header)
        LookUpEdit_HenHouse.EditValue = GV_Header.GetFocusedRowCellValue(colHenHouseID_Header)
        Memo_Header.EditValue = GV_Header.GetFocusedRowCellValue(colDescription_Header)
    End Sub

    Private Sub FillDataAdapter()

        Try
            Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyHeader_GetData, Dt_Start.EditValue, Dt_End.EditValue)
            Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyDetail_GetData, 0, 3)

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

        LCGroup_Data.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        FillDataAdapter()
        DxErrorProvider1.ClearErrors()
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

    End Sub

    Private Sub BB_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_New.ItemClick
        Try
            ResetData()
            DisplayProcess()

            CE_AutoCode.Checked = False
            CE_AutoCode.Checked = True
            Dt_ProductionDate.EditValue = Today

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveData()

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


    Private Sub CE_AutoCode_CheckedChanged(sender As Object, e As EventArgs) Handles CE_AutoCode.CheckedChanged
        If (CE_AutoCode.Checked) Then
            Ed_ProductionNo.Properties.ReadOnly = True
            Ed_ProductionNo.EditValue = "AUTO"
            Ed_ProductionNo.Focus()
        Else
            Ed_ProductionNo.Properties.ReadOnly = False
            Ed_ProductionNo.EditValue = ""
            Ed_ProductionNo.Focus()
        End If
    End Sub


    Private Sub SB_Search_Click(sender As Object, e As EventArgs) Handles SB_Search.Click
        Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.Fill(Me.DataSet.sp_PDProductionDailyHeader_GetData, Dt_Start.EditValue, Dt_End.EditValue)
    End Sub

    Private Sub GV_Header_DoubleClick(sender As Object, e As EventArgs) Handles GV_Header.DoubleClick
        If (GV_Header.RowCount > 0) Then
            DisplayTransaction()
        End If
    End Sub
End Class