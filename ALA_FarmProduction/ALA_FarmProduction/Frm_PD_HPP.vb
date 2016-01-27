Public Class Frm_PD_HPP


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


        NavigationFrame1.SelectedPage = NavigationPage2

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

        '     Ed_Subtotal.EditValue = colSubtotal_Detail.SummaryItem.SummaryValue
        Try
            parentribbonx.UnMergeRibbon()
            parentribbonx.MergeRibbon(RibbonControl)
        Catch ex As Exception

        End Try
    End Sub

    Sub LoadDataGridHeader(ByVal rowfocus As Integer)

    End Sub

    Private Sub FillDataAdapter()
        Me.Sp_PD_HPP_GetDailyDetailTableAdapter.Fill(Me.DataSet.sp_PD_HPP_GetDailyDetail, 1)
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDHenHouse_GetData, 1)

        Me.Sp_PD_HPP_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_HPP_GetData, 1)


        Try

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub ResetData()
    End Sub

    Private Sub Frm_MDDailyEgg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Sp_PD_HPP_GetDailyDetailTableAdapter.Fill(Me.DataSet.sp_PD_HPP_GetDailyDetail, 3)
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_MDHenHouse_GetData, 1)
        Me.Sp_PD_HPP_GetDataTableAdapter.Fill(Me.DataSet.sp_PD_HPP_GetData, 3)
        'TODO: This line of code loads data into the 'DataSet_HenHouse.sp_MDWarehouse_GetData' table. You can move, or remove it, as needed.

        DisplayHome()

        FillDataAdapter()
        DxErrorProvider1.ClearErrors()
        UserModified = System.Environment.GetEnvironmentVariable("COMPUTERNAME") & "\" & My.Settings.UserName

    End Sub

    Private Sub BB_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_New.ItemClick
        Try
            ResetData()
            DisplayProcess()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveData()

    End Sub

    Private Sub BB_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BB_Save.ItemClick
        Try
            '    AlertParamName = Ed_ProductionNo.EditValue.ToString() + " : " + LookUpEdit_Shift.Text.ToString()

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

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub
End Class