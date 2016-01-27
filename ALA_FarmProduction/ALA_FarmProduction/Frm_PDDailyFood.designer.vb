<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PDDailyFood
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PDDailyFood))
        Me.GV_HeaderDetail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colProductionID_HeaderDetail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colShiftID_HeaderDetail = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn7 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn11 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn12 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.BandedGridColumn13 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.BandedGridColumn14 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.Sp_PDProductionDailyHeader_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_PDProductionDailyHeader_GetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.DataSet = New ALA_FarmProduction.DataSet()
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodStartDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BB_New = New DevExpress.XtraBars.BarButtonItem()
        Me.BB_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.BB_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BB_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.BB_Back = New DevExpress.XtraBars.BarButtonItem()
        Me.BB_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageHome = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageProcess = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LC_Detail = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Reset = New DevExpress.XtraEditors.SimpleButton()
        Me.SB_Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.fieldID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShiftID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldShiftName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvTypeCode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInvTypeName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldDescription1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldModifiedUser1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldModifiedDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldMode1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.LookUpEdit_Inventory = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPDMDInventoryFoodGetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.Memo_Header = New DevExpress.XtraEditors.MemoEdit()
        Me.LookUpEdit_HenHouse = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPDMDHenHouseGetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.Memo_DescDet = New DevExpress.XtraEditors.MemoEdit()
        Me.Dt_ProductionDate = New DevExpress.XtraEditors.DateEdit()
        Me.Ed_ProductionNo = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Price = New DevExpress.XtraEditors.SpinEdit()
        Me.Ed_Weight = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCGroup_Detail = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_DescDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_QtyDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_HenHouse = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_Inventory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Data = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_ProductionNo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DescHeader = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_ProductionDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SpPDMDShiftGetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl()
        Me.LC_Header = New DevExpress.XtraLayout.LayoutControl()
        Me.SB_Search = New DevExpress.XtraEditors.SimpleButton()
        Me.Dt_End = New DevExpress.XtraEditors.DateEdit()
        Me.Dt_Start = New DevExpress.XtraEditors.DateEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_GV = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LCItem_DateStart = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DateEnd = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Sp_PDProductionDailyHeader_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PDProductionDailyHeader_GetDataTableAdapter()
        Me.TableAdapterManager = New ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PDProductionDailyDetail_GetDataTableAdapter()
        Me.QueriesTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDHenHouse_GetDataTableAdapter()
        Me.Sp_PD_MDShift_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDShift_GetDataTableAdapter()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.Sp_PD_MDInventoryFood_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDInventoryFood_GetDataTableAdapter()
        CType(Me.GV_HeaderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Detail.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Inventory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDInventoryFoodGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Memo_Header.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_HenHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Memo_DescDet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_ProductionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_ProductionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_ProductionNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DescDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_QtyDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_HenHouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_ProductionNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DescHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_ProductionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDShiftGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Header.SuspendLayout()
        CType(Me.Dt_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_Start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GV_HeaderDetail
        '
        Me.GV_HeaderDetail.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4, Me.gridBand5})
        Me.GV_HeaderDetail.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProductionID_HeaderDetail, Me.colShiftID_HeaderDetail, Me.BandedGridColumn1, Me.BandedGridColumn2, Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn5, Me.BandedGridColumn6, Me.BandedGridColumn7, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn10, Me.BandedGridColumn11, Me.BandedGridColumn12, Me.BandedGridColumn13, Me.BandedGridColumn14})
        Me.GV_HeaderDetail.GridControl = Me.Sp_PDProductionDailyHeader_GetDataGridControl
        Me.GV_HeaderDetail.Name = "GV_HeaderDetail"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colProductionID_HeaderDetail)
        Me.GridBand1.Columns.Add(Me.colShiftID_HeaderDetail)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 75
        '
        'colProductionID_HeaderDetail
        '
        Me.colProductionID_HeaderDetail.FieldName = "ProductionID"
        Me.colProductionID_HeaderDetail.Name = "colProductionID_HeaderDetail"
        Me.colProductionID_HeaderDetail.OptionsColumn.AllowEdit = False
        Me.colProductionID_HeaderDetail.OptionsColumn.AllowFocus = False
        '
        'colShiftID_HeaderDetail
        '
        Me.colShiftID_HeaderDetail.FieldName = "ShiftID"
        Me.colShiftID_HeaderDetail.Name = "colShiftID_HeaderDetail"
        Me.colShiftID_HeaderDetail.OptionsColumn.AllowEdit = False
        Me.colShiftID_HeaderDetail.OptionsColumn.AllowFocus = False
        Me.colShiftID_HeaderDetail.Visible = True
        '
        'gridBand2
        '
        Me.gridBand2.Caption = "gridBand2"
        Me.gridBand2.Columns.Add(Me.BandedGridColumn1)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn2)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn3)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn4)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn5)
        Me.gridBand2.Columns.Add(Me.BandedGridColumn6)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.VisibleIndex = 1
        Me.gridBand2.Width = 450
        '
        'BandedGridColumn1
        '
        Me.BandedGridColumn1.FieldName = "Qty1-1"
        Me.BandedGridColumn1.Name = "BandedGridColumn1"
        Me.BandedGridColumn1.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn1.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn1.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn1.Visible = True
        '
        'BandedGridColumn2
        '
        Me.BandedGridColumn2.FieldName = "Weight1-1"
        Me.BandedGridColumn2.Name = "BandedGridColumn2"
        Me.BandedGridColumn2.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn2.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn2.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn2.Visible = True
        '
        'BandedGridColumn3
        '
        Me.BandedGridColumn3.FieldName = "Qty1-2"
        Me.BandedGridColumn3.Name = "BandedGridColumn3"
        Me.BandedGridColumn3.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn3.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn3.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn3.Visible = True
        '
        'BandedGridColumn4
        '
        Me.BandedGridColumn4.FieldName = "Weight1-2"
        Me.BandedGridColumn4.Name = "BandedGridColumn4"
        Me.BandedGridColumn4.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn4.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn4.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn4.Visible = True
        '
        'BandedGridColumn5
        '
        Me.BandedGridColumn5.FieldName = "Qty1-3"
        Me.BandedGridColumn5.Name = "BandedGridColumn5"
        Me.BandedGridColumn5.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn5.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn5.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn5.Visible = True
        '
        'BandedGridColumn6
        '
        Me.BandedGridColumn6.FieldName = "Weight1-3"
        Me.BandedGridColumn6.Name = "BandedGridColumn6"
        Me.BandedGridColumn6.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn6.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn6.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn6.Visible = True
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "gridBand3"
        Me.gridBand3.Columns.Add(Me.BandedGridColumn7)
        Me.gridBand3.Columns.Add(Me.BandedGridColumn8)
        Me.gridBand3.Columns.Add(Me.BandedGridColumn9)
        Me.gridBand3.Columns.Add(Me.BandedGridColumn10)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 2
        Me.gridBand3.Width = 300
        '
        'BandedGridColumn7
        '
        Me.BandedGridColumn7.FieldName = "Qty2-1"
        Me.BandedGridColumn7.Name = "BandedGridColumn7"
        Me.BandedGridColumn7.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn7.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn7.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn7.Visible = True
        '
        'BandedGridColumn8
        '
        Me.BandedGridColumn8.FieldName = "Weight2-1"
        Me.BandedGridColumn8.Name = "BandedGridColumn8"
        Me.BandedGridColumn8.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn8.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn8.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn8.Visible = True
        '
        'BandedGridColumn9
        '
        Me.BandedGridColumn9.FieldName = "Qty2-2"
        Me.BandedGridColumn9.Name = "BandedGridColumn9"
        Me.BandedGridColumn9.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn9.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn9.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn9.Visible = True
        '
        'BandedGridColumn10
        '
        Me.BandedGridColumn10.FieldName = "Weight2-2"
        Me.BandedGridColumn10.Name = "BandedGridColumn10"
        Me.BandedGridColumn10.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn10.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn10.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn10.Visible = True
        '
        'gridBand4
        '
        Me.gridBand4.Caption = "gridBand4"
        Me.gridBand4.Columns.Add(Me.BandedGridColumn11)
        Me.gridBand4.Columns.Add(Me.BandedGridColumn12)
        Me.gridBand4.Name = "gridBand4"
        Me.gridBand4.VisibleIndex = 3
        Me.gridBand4.Width = 150
        '
        'BandedGridColumn11
        '
        Me.BandedGridColumn11.FieldName = "Qty3-1"
        Me.BandedGridColumn11.Name = "BandedGridColumn11"
        Me.BandedGridColumn11.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn11.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn11.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn11.Visible = True
        '
        'BandedGridColumn12
        '
        Me.BandedGridColumn12.FieldName = "Weight3-1"
        Me.BandedGridColumn12.Name = "BandedGridColumn12"
        Me.BandedGridColumn12.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn12.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn12.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn12.Visible = True
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "gridBand5"
        Me.gridBand5.Columns.Add(Me.BandedGridColumn13)
        Me.gridBand5.Columns.Add(Me.BandedGridColumn14)
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.VisibleIndex = 4
        Me.gridBand5.Width = 150
        '
        'BandedGridColumn13
        '
        Me.BandedGridColumn13.FieldName = "Qty4-1"
        Me.BandedGridColumn13.Name = "BandedGridColumn13"
        Me.BandedGridColumn13.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn13.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn13.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn13.Visible = True
        '
        'BandedGridColumn14
        '
        Me.BandedGridColumn14.FieldName = "Weight4-1"
        Me.BandedGridColumn14.Name = "BandedGridColumn14"
        Me.BandedGridColumn14.OptionsColumn.AllowEdit = False
        Me.BandedGridColumn14.OptionsColumn.AllowFocus = False
        Me.BandedGridColumn14.OptionsColumn.ReadOnly = True
        Me.BandedGridColumn14.Visible = True
        '
        'Sp_PDProductionDailyHeader_GetDataGridControl
        '
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.DataSource = Me.Sp_PDProductionDailyHeader_GetDataBindingSource
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Location = New System.Drawing.Point(7, 39)
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.MainView = Me.GV_Header
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Name = "Sp_PDProductionDailyHeader_GetDataGridControl"
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Size = New System.Drawing.Size(943, 442)
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.TabIndex = 4
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Header, Me.GV_HeaderDetail})
        '
        'Sp_PDProductionDailyHeader_GetDataBindingSource
        '
        Me.Sp_PDProductionDailyHeader_GetDataBindingSource.DataMember = "sp_PDProductionDailyHeader_GetData"
        Me.Sp_PDProductionDailyHeader_GetDataBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GV_Header
        '
        Me.GV_Header.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GV_Header.Appearance.FooterPanel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Header.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Header.Appearance.FooterPanel.Options.UseFont = True
        Me.GV_Header.Appearance.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GV_Header.Appearance.HeaderPanel.Options.UseFont = True
        Me.GV_Header.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GV_Header.Appearance.Row.Options.UseFont = True
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colProductionNo, Me.colProductionDate, Me.colDescription, Me.colPeriodID, Me.colPeriodName, Me.colPeriodStartDate, Me.colAge})
        Me.GV_Header.GridControl = Me.Sp_PDProductionDailyHeader_GetDataGridControl
        Me.GV_Header.Name = "GV_Header"
        Me.GV_Header.OptionsView.ShowFooter = True
        Me.GV_Header.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.AllowFocus = False
        '
        'colProductionNo
        '
        Me.colProductionNo.Caption = "No. Produksi"
        Me.colProductionNo.FieldName = "ProductionNo"
        Me.colProductionNo.MaxWidth = 120
        Me.colProductionNo.MinWidth = 120
        Me.colProductionNo.Name = "colProductionNo"
        Me.colProductionNo.OptionsColumn.AllowEdit = False
        Me.colProductionNo.OptionsColumn.AllowFocus = False
        Me.colProductionNo.Visible = True
        Me.colProductionNo.VisibleIndex = 0
        Me.colProductionNo.Width = 130
        '
        'colProductionDate
        '
        Me.colProductionDate.Caption = "Tgl. Produksi"
        Me.colProductionDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colProductionDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProductionDate.FieldName = "ProductionDate"
        Me.colProductionDate.MaxWidth = 125
        Me.colProductionDate.MinWidth = 125
        Me.colProductionDate.Name = "colProductionDate"
        Me.colProductionDate.OptionsColumn.AllowEdit = False
        Me.colProductionDate.OptionsColumn.AllowFocus = False
        Me.colProductionDate.Visible = True
        Me.colProductionDate.VisibleIndex = 1
        Me.colProductionDate.Width = 125
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.OptionsColumn.AllowFocus = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 5
        Me.colDescription.Width = 178
        '
        'colPeriodID
        '
        Me.colPeriodID.FieldName = "PeriodID"
        Me.colPeriodID.Name = "colPeriodID"
        Me.colPeriodID.OptionsColumn.AllowEdit = False
        Me.colPeriodID.OptionsColumn.AllowFocus = False
        '
        'colPeriodName
        '
        Me.colPeriodName.Caption = "Strain"
        Me.colPeriodName.FieldName = "PeriodName"
        Me.colPeriodName.MinWidth = 10
        Me.colPeriodName.Name = "colPeriodName"
        Me.colPeriodName.OptionsColumn.AllowEdit = False
        Me.colPeriodName.OptionsColumn.AllowFocus = False
        Me.colPeriodName.Visible = True
        Me.colPeriodName.VisibleIndex = 2
        Me.colPeriodName.Width = 200
        '
        'colPeriodStartDate
        '
        Me.colPeriodStartDate.Caption = "Tgl. Ayam Masuk"
        Me.colPeriodStartDate.DisplayFormat.FormatString = "dd MMM yyyy"
        Me.colPeriodStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPeriodStartDate.FieldName = "PeriodStartDate"
        Me.colPeriodStartDate.MaxWidth = 145
        Me.colPeriodStartDate.MinWidth = 145
        Me.colPeriodStartDate.Name = "colPeriodStartDate"
        Me.colPeriodStartDate.OptionsColumn.AllowEdit = False
        Me.colPeriodStartDate.OptionsColumn.AllowFocus = False
        Me.colPeriodStartDate.Visible = True
        Me.colPeriodStartDate.VisibleIndex = 3
        Me.colPeriodStartDate.Width = 145
        '
        'colAge
        '
        Me.colAge.Caption = "Umur"
        Me.colAge.FieldName = "Age"
        Me.colAge.MaxWidth = 150
        Me.colAge.MinWidth = 150
        Me.colAge.Name = "colAge"
        Me.colAge.OptionsColumn.AllowEdit = False
        Me.colAge.OptionsColumn.AllowFocus = False
        Me.colAge.Visible = True
        Me.colAge.VisibleIndex = 4
        Me.colAge.Width = 150
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BB_New, Me.BB_Delete, Me.BB_Refresh, Me.BB_Close, Me.BB_Back, Me.BB_Save})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 7
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPageHome, Me.RibbonPageProcess})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl.Size = New System.Drawing.Size(969, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BB_New
        '
        Me.BB_New.Caption = "New"
        Me.BB_New.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_New.Glyph = CType(resources.GetObject("BB_New.Glyph"), System.Drawing.Image)
        Me.BB_New.Id = 1
        Me.BB_New.LargeGlyph = CType(resources.GetObject("BB_New.LargeGlyph"), System.Drawing.Image)
        Me.BB_New.Name = "BB_New"
        '
        'BB_Delete
        '
        Me.BB_Delete.Caption = "Delete"
        Me.BB_Delete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_Delete.Glyph = CType(resources.GetObject("BB_Delete.Glyph"), System.Drawing.Image)
        Me.BB_Delete.Id = 2
        Me.BB_Delete.LargeGlyph = CType(resources.GetObject("BB_Delete.LargeGlyph"), System.Drawing.Image)
        Me.BB_Delete.Name = "BB_Delete"
        '
        'BB_Refresh
        '
        Me.BB_Refresh.Caption = "Refresh"
        Me.BB_Refresh.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_Refresh.Glyph = CType(resources.GetObject("BB_Refresh.Glyph"), System.Drawing.Image)
        Me.BB_Refresh.Id = 3
        Me.BB_Refresh.LargeGlyph = CType(resources.GetObject("BB_Refresh.LargeGlyph"), System.Drawing.Image)
        Me.BB_Refresh.Name = "BB_Refresh"
        '
        'BB_Close
        '
        Me.BB_Close.Caption = "Close"
        Me.BB_Close.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_Close.Glyph = CType(resources.GetObject("BB_Close.Glyph"), System.Drawing.Image)
        Me.BB_Close.Id = 4
        Me.BB_Close.LargeGlyph = CType(resources.GetObject("BB_Close.LargeGlyph"), System.Drawing.Image)
        Me.BB_Close.Name = "BB_Close"
        '
        'BB_Back
        '
        Me.BB_Back.Caption = "Back"
        Me.BB_Back.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_Back.Glyph = CType(resources.GetObject("BB_Back.Glyph"), System.Drawing.Image)
        Me.BB_Back.Id = 5
        Me.BB_Back.LargeGlyph = CType(resources.GetObject("BB_Back.LargeGlyph"), System.Drawing.Image)
        Me.BB_Back.Name = "BB_Back"
        '
        'BB_Save
        '
        Me.BB_Save.Caption = "Save"
        Me.BB_Save.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BB_Save.Glyph = CType(resources.GetObject("BB_Save.Glyph"), System.Drawing.Image)
        Me.BB_Save.Id = 6
        Me.BB_Save.LargeGlyph = CType(resources.GetObject("BB_Save.LargeGlyph"), System.Drawing.Image)
        Me.BB_Save.Name = "BB_Save"
        '
        'RibbonPageHome
        '
        Me.RibbonPageHome.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPageHome.Name = "RibbonPageHome"
        Me.RibbonPageHome.Text = "Home"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BB_New)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BB_Refresh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BB_Close)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonPageProcess
        '
        Me.RibbonPageProcess.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup5, Me.RibbonPageGroup4})
        Me.RibbonPageProcess.Name = "RibbonPageProcess"
        Me.RibbonPageProcess.Text = "Process"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BB_Back)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BB_Save)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BB_Delete)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BB_Close)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 682)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(969, 31)
        '
        'LC_Detail
        '
        Me.LC_Detail.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LC_Detail.Appearance.Control.Options.UseFont = True
        Me.LC_Detail.Controls.Add(Me.SB_Reset)
        Me.LC_Detail.Controls.Add(Me.SB_Submit)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl1)
        Me.LC_Detail.Controls.Add(Me.LookUpEdit_Inventory)
        Me.LC_Detail.Controls.Add(Me.Memo_Header)
        Me.LC_Detail.Controls.Add(Me.LookUpEdit_HenHouse)
        Me.LC_Detail.Controls.Add(Me.Memo_DescDet)
        Me.LC_Detail.Controls.Add(Me.Dt_ProductionDate)
        Me.LC_Detail.Controls.Add(Me.Ed_ProductionNo)
        Me.LC_Detail.Controls.Add(Me.Ed_Price)
        Me.LC_Detail.Controls.Add(Me.Ed_Weight)
        Me.LC_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Detail.Location = New System.Drawing.Point(0, 0)
        Me.LC_Detail.Name = "LC_Detail"
        Me.LC_Detail.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(409, 189, 250, 350)
        Me.LC_Detail.Root = Me.LayoutControlGroup1
        Me.LC_Detail.Size = New System.Drawing.Size(957, 488)
        Me.LC_Detail.TabIndex = 2
        Me.LC_Detail.Text = "LayoutControl1"
        '
        'SB_Reset
        '
        Me.SB_Reset.Location = New System.Drawing.Point(614, 436)
        Me.SB_Reset.Name = "SB_Reset"
        Me.SB_Reset.Size = New System.Drawing.Size(157, 28)
        Me.SB_Reset.StyleController = Me.LC_Detail
        Me.SB_Reset.TabIndex = 19
        Me.SB_Reset.Text = "Reset"
        '
        'SB_Submit
        '
        Me.SB_Submit.Location = New System.Drawing.Point(775, 436)
        Me.SB_Submit.Name = "SB_Submit"
        Me.SB_Submit.Size = New System.Drawing.Size(158, 28)
        Me.SB_Submit.StyleController = Me.LC_Detail
        Me.SB_Submit.TabIndex = 18
        Me.SB_Submit.Text = "Submit"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Appearance.Cell.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl1.Appearance.Cell.Options.UseFont = True
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl1.Appearance.FieldHeader.Options.UseFont = True
        Me.PivotGridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl1.Appearance.FieldValue.Options.UseFont = True
        Me.PivotGridControl1.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PivotGridControl1.Appearance.HeaderArea.Options.UseFont = True
        Me.PivotGridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PivotGridControl1.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PivotGridControl1.DataSource = Me.Sp_PDProductionDailyDetail_GetDataBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldID1, Me.fieldProductionID1, Me.fieldShiftID1, Me.fieldInventoryID1, Me.fieldShiftName1, Me.fieldInventoryName1, Me.fieldInvTypeCode1, Me.fieldInvTypeName1, Me.fieldQty1, Me.fieldWeight1, Me.fieldDescription1, Me.fieldModifiedUser1, Me.fieldModifiedDate1, Me.fieldHenHouseID1, Me.fieldHenHouseName1, Me.fieldMode1, Me.fieldPrice1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(15, 15)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl1.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl1.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        Me.PivotGridControl1.Size = New System.Drawing.Size(580, 458)
        Me.PivotGridControl1.TabIndex = 17
        '
        'Sp_PDProductionDailyDetail_GetDataBindingSource
        '
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource.DataMember = "sp_PDProductionDailyDetail_GetData"
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource.DataSource = Me.DataSet
        '
        'fieldID1
        '
        Me.fieldID1.AreaIndex = 0
        Me.fieldID1.FieldName = "ID"
        Me.fieldID1.Name = "fieldID1"
        '
        'fieldProductionID1
        '
        Me.fieldProductionID1.AreaIndex = 1
        Me.fieldProductionID1.FieldName = "ProductionID"
        Me.fieldProductionID1.Name = "fieldProductionID1"
        '
        'fieldShiftID1
        '
        Me.fieldShiftID1.AreaIndex = 2
        Me.fieldShiftID1.FieldName = "ShiftID"
        Me.fieldShiftID1.Name = "fieldShiftID1"
        '
        'fieldInventoryID1
        '
        Me.fieldInventoryID1.AreaIndex = 3
        Me.fieldInventoryID1.FieldName = "InventoryID"
        Me.fieldInventoryID1.Name = "fieldInventoryID1"
        '
        'fieldShiftName1
        '
        Me.fieldShiftName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldShiftName1.AreaIndex = 1
        Me.fieldShiftName1.FieldName = "ShiftName"
        Me.fieldShiftName1.Name = "fieldShiftName1"
        '
        'fieldInventoryName1
        '
        Me.fieldInventoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldInventoryName1.AreaIndex = 0
        Me.fieldInventoryName1.FieldName = "InventoryName"
        Me.fieldInventoryName1.Name = "fieldInventoryName1"
        '
        'fieldInvTypeCode1
        '
        Me.fieldInvTypeCode1.AreaIndex = 4
        Me.fieldInvTypeCode1.FieldName = "InvTypeCode"
        Me.fieldInvTypeCode1.Name = "fieldInvTypeCode1"
        '
        'fieldInvTypeName1
        '
        Me.fieldInvTypeName1.AreaIndex = 5
        Me.fieldInvTypeName1.FieldName = "InvTypeName"
        Me.fieldInvTypeName1.Name = "fieldInvTypeName1"
        '
        'fieldQty1
        '
        Me.fieldQty1.AreaIndex = 6
        Me.fieldQty1.FieldName = "Qty"
        Me.fieldQty1.Name = "fieldQty1"
        '
        'fieldWeight1
        '
        Me.fieldWeight1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldWeight1.AreaIndex = 0
        Me.fieldWeight1.CellFormat.FormatString = "n2"
        Me.fieldWeight1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldWeight1.FieldName = "Weight"
        Me.fieldWeight1.Name = "fieldWeight1"
        '
        'fieldDescription1
        '
        Me.fieldDescription1.AreaIndex = 7
        Me.fieldDescription1.FieldName = "Description"
        Me.fieldDescription1.Name = "fieldDescription1"
        '
        'fieldModifiedUser1
        '
        Me.fieldModifiedUser1.AreaIndex = 8
        Me.fieldModifiedUser1.FieldName = "ModifiedUser"
        Me.fieldModifiedUser1.Name = "fieldModifiedUser1"
        '
        'fieldModifiedDate1
        '
        Me.fieldModifiedDate1.AreaIndex = 9
        Me.fieldModifiedDate1.FieldName = "ModifiedDate"
        Me.fieldModifiedDate1.Name = "fieldModifiedDate1"
        '
        'fieldHenHouseID1
        '
        Me.fieldHenHouseID1.AreaIndex = 10
        Me.fieldHenHouseID1.FieldName = "HenHouseID"
        Me.fieldHenHouseID1.Name = "fieldHenHouseID1"
        '
        'fieldHenHouseName1
        '
        Me.fieldHenHouseName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName1.AreaIndex = 0
        Me.fieldHenHouseName1.FieldName = "HenHouseName"
        Me.fieldHenHouseName1.Name = "fieldHenHouseName1"
        Me.fieldHenHouseName1.Width = 150
        '
        'fieldMode1
        '
        Me.fieldMode1.AreaIndex = 11
        Me.fieldMode1.FieldName = "Mode"
        Me.fieldMode1.Name = "fieldMode1"
        '
        'fieldPrice1
        '
        Me.fieldPrice1.AreaIndex = 12
        Me.fieldPrice1.FieldName = "Price"
        Me.fieldPrice1.Name = "fieldPrice1"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'LookUpEdit_Inventory
        '
        Me.LookUpEdit_Inventory.Location = New System.Drawing.Point(724, 270)
        Me.LookUpEdit_Inventory.MenuManager = Me.RibbonControl
        Me.LookUpEdit_Inventory.Name = "LookUpEdit_Inventory"
        Me.LookUpEdit_Inventory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Inventory.Properties.DataSource = Me.SpPDMDInventoryFoodGetDataBindingSource
        Me.LookUpEdit_Inventory.Properties.DisplayMember = "InventoryName"
        Me.LookUpEdit_Inventory.Properties.NullText = ""
        Me.LookUpEdit_Inventory.Properties.ValueMember = "ID"
        Me.LookUpEdit_Inventory.Size = New System.Drawing.Size(209, 28)
        Me.LookUpEdit_Inventory.StyleController = Me.LC_Detail
        Me.LookUpEdit_Inventory.TabIndex = 15
        '
        'SpPDMDInventoryFoodGetDataBindingSource
        '
        Me.SpPDMDInventoryFoodGetDataBindingSource.DataMember = "sp_PD_MDInventoryFood_GetData"
        Me.SpPDMDInventoryFoodGetDataBindingSource.DataSource = Me.DataSet
        '
        'Memo_Header
        '
        Me.Memo_Header.Location = New System.Drawing.Point(724, 121)
        Me.Memo_Header.MenuManager = Me.RibbonControl
        Me.Memo_Header.Name = "Memo_Header"
        Me.Memo_Header.Size = New System.Drawing.Size(209, 56)
        Me.Memo_Header.StyleController = Me.LC_Detail
        Me.Memo_Header.TabIndex = 14
        '
        'LookUpEdit_HenHouse
        '
        Me.LookUpEdit_HenHouse.EditValue = 0
        Me.LookUpEdit_HenHouse.Location = New System.Drawing.Point(724, 238)
        Me.LookUpEdit_HenHouse.MenuManager = Me.RibbonControl
        Me.LookUpEdit_HenHouse.Name = "LookUpEdit_HenHouse"
        Me.LookUpEdit_HenHouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_HenHouse.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCode", "Hen House Code", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseTypeID", "Hen House Type ID", 103, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseName", "Hen House Name", 92, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCapacity", "Hen House Capacity", 107, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCreated", "Hen House Created", 104, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isActive", "is Active", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit_HenHouse.Properties.DataSource = Me.SpPDMDHenHouseGetDataBindingSource
        Me.LookUpEdit_HenHouse.Properties.DisplayMember = "HenHouseName"
        Me.LookUpEdit_HenHouse.Properties.NullText = "0"
        Me.LookUpEdit_HenHouse.Properties.ValueMember = "ID"
        Me.LookUpEdit_HenHouse.Size = New System.Drawing.Size(209, 28)
        Me.LookUpEdit_HenHouse.StyleController = Me.LC_Detail
        Me.LookUpEdit_HenHouse.TabIndex = 13
        '
        'SpPDMDHenHouseGetDataBindingSource
        '
        Me.SpPDMDHenHouseGetDataBindingSource.DataMember = "sp_PD_MDHenHouse_GetData"
        Me.SpPDMDHenHouseGetDataBindingSource.DataSource = Me.DataSet
        '
        'Memo_DescDet
        '
        Me.Memo_DescDet.Location = New System.Drawing.Point(724, 366)
        Me.Memo_DescDet.MenuManager = Me.RibbonControl
        Me.Memo_DescDet.Name = "Memo_DescDet"
        Me.Memo_DescDet.Size = New System.Drawing.Size(209, 66)
        Me.Memo_DescDet.StyleController = Me.LC_Detail
        Me.Memo_DescDet.TabIndex = 12
        '
        'Dt_ProductionDate
        '
        Me.Dt_ProductionDate.EditValue = Nothing
        Me.Dt_ProductionDate.Location = New System.Drawing.Point(724, 89)
        Me.Dt_ProductionDate.MenuManager = Me.RibbonControl
        Me.Dt_ProductionDate.Name = "Dt_ProductionDate"
        Me.Dt_ProductionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_ProductionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_ProductionDate.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.Dt_ProductionDate.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Dt_ProductionDate.Size = New System.Drawing.Size(209, 28)
        Me.Dt_ProductionDate.StyleController = Me.LC_Detail
        Me.Dt_ProductionDate.TabIndex = 7
        '
        'Ed_ProductionNo
        '
        Me.Ed_ProductionNo.Location = New System.Drawing.Point(724, 57)
        Me.Ed_ProductionNo.MenuManager = Me.RibbonControl
        Me.Ed_ProductionNo.Name = "Ed_ProductionNo"
        Me.Ed_ProductionNo.Size = New System.Drawing.Size(209, 28)
        Me.Ed_ProductionNo.StyleController = Me.LC_Detail
        Me.Ed_ProductionNo.TabIndex = 6
        '
        'Ed_Price
        '
        Me.Ed_Price.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Price.Location = New System.Drawing.Point(724, 334)
        Me.Ed_Price.MenuManager = Me.RibbonControl
        Me.Ed_Price.Name = "Ed_Price"
        Me.Ed_Price.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Price.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Ed_Price.Properties.Mask.EditMask = "n2"
        Me.Ed_Price.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Price.Size = New System.Drawing.Size(209, 28)
        Me.Ed_Price.StyleController = Me.LC_Detail
        Me.Ed_Price.TabIndex = 16
        '
        'Ed_Weight
        '
        Me.Ed_Weight.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Ed_Weight.Location = New System.Drawing.Point(724, 302)
        Me.Ed_Weight.MenuManager = Me.RibbonControl
        Me.Ed_Weight.Name = "Ed_Weight"
        Me.Ed_Weight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ed_Weight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.Ed_Weight.Properties.Mask.EditMask = "n2"
        Me.Ed_Weight.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Ed_Weight.Size = New System.Drawing.Size(209, 28)
        Me.Ed_Weight.StyleController = Me.LC_Detail
        Me.Ed_Weight.TabIndex = 10
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCGroup_Detail, Me.LCGroup_Data, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(957, 488)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LCGroup_Detail
        '
        Me.LCGroup_Detail.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LCGroup_Detail.AppearanceGroup.Options.UseFont = True
        Me.LCGroup_Detail.AppearanceGroup.Options.UseTextOptions = True
        Me.LCGroup_Detail.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LCGroup_Detail.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LCGroup_Detail.AppearanceItemCaption.Options.UseFont = True
        Me.LCGroup_Detail.CustomizationFormText = ":: Detail ::"
        Me.LCGroup_Detail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_DescDetail, Me.LCItem_QtyDetail, Me.LCItem_HenHouse, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LCItem_Inventory})
        Me.LCGroup_Detail.Location = New System.Drawing.Point(590, 181)
        Me.LCGroup_Detail.Name = "LCGroup_Detail"
        Me.LCGroup_Detail.Size = New System.Drawing.Size(347, 287)
        Me.LCGroup_Detail.Text = ":: Detail ::"
        '
        'LCItem_DescDetail
        '
        Me.LCItem_DescDetail.Control = Me.Memo_DescDet
        Me.LCItem_DescDetail.CustomizationFormText = "Description :"
        Me.LCItem_DescDetail.Location = New System.Drawing.Point(0, 128)
        Me.LCItem_DescDetail.Name = "LCItem_DescDetail"
        Me.LCItem_DescDetail.Size = New System.Drawing.Size(323, 70)
        Me.LCItem_DescDetail.Text = "Keterangan :"
        Me.LCItem_DescDetail.TextSize = New System.Drawing.Size(107, 21)
        '
        'LCItem_QtyDetail
        '
        Me.LCItem_QtyDetail.Control = Me.Ed_Weight
        Me.LCItem_QtyDetail.CustomizationFormText = "Qty :"
        Me.LCItem_QtyDetail.Location = New System.Drawing.Point(0, 64)
        Me.LCItem_QtyDetail.Name = "LCItem_QtyDetail"
        Me.LCItem_QtyDetail.Size = New System.Drawing.Size(323, 32)
        Me.LCItem_QtyDetail.Text = "Jumlah :"
        Me.LCItem_QtyDetail.TextSize = New System.Drawing.Size(107, 21)
        '
        'LCItem_HenHouse
        '
        Me.LCItem_HenHouse.Control = Me.LookUpEdit_HenHouse
        Me.LCItem_HenHouse.CustomizationFormText = "Kandang :"
        Me.LCItem_HenHouse.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_HenHouse.Name = "LCItem_HenHouse"
        Me.LCItem_HenHouse.Size = New System.Drawing.Size(323, 32)
        Me.LCItem_HenHouse.Text = "Kandang :"
        Me.LCItem_HenHouse.TextSize = New System.Drawing.Size(107, 21)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Ed_Price
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(323, 32)
        Me.LayoutControlItem2.Text = "Harga :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(107, 21)
        Me.LayoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SB_Submit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(161, 198)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(162, 32)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SB_Reset
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 198)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(161, 32)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LCItem_Inventory
        '
        Me.LCItem_Inventory.Control = Me.LookUpEdit_Inventory
        Me.LCItem_Inventory.CustomizationFormText = "Jenis Telur :"
        Me.LCItem_Inventory.Location = New System.Drawing.Point(0, 32)
        Me.LCItem_Inventory.Name = "LCItem_Inventory"
        Me.LCItem_Inventory.Size = New System.Drawing.Size(323, 32)
        Me.LCItem_Inventory.Text = "Jenis Pakan :"
        Me.LCItem_Inventory.TextSize = New System.Drawing.Size(107, 21)
        '
        'LCGroup_Data
        '
        Me.LCGroup_Data.AppearanceGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LCGroup_Data.AppearanceGroup.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LCGroup_Data.AppearanceGroup.Options.UseBackColor = True
        Me.LCGroup_Data.AppearanceGroup.Options.UseFont = True
        Me.LCGroup_Data.AppearanceGroup.Options.UseTextOptions = True
        Me.LCGroup_Data.AppearanceGroup.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LCGroup_Data.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LCGroup_Data.AppearanceItemCaption.Options.UseFont = True
        Me.LCGroup_Data.CustomizationFormText = ":: Data ::"
        Me.LCGroup_Data.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_ProductionNo, Me.LCItem_DescHeader, Me.LCItem_ProductionDate})
        Me.LCGroup_Data.Location = New System.Drawing.Point(590, 0)
        Me.LCGroup_Data.Name = "LCGroup_Data"
        Me.LCGroup_Data.Size = New System.Drawing.Size(347, 181)
        Me.LCGroup_Data.Text = ":: Header ::"
        '
        'LCItem_ProductionNo
        '
        Me.LCItem_ProductionNo.Control = Me.Ed_ProductionNo
        Me.LCItem_ProductionNo.CustomizationFormText = "Production No :"
        Me.LCItem_ProductionNo.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_ProductionNo.Name = "LCItem_ProductionNo"
        Me.LCItem_ProductionNo.Size = New System.Drawing.Size(323, 32)
        Me.LCItem_ProductionNo.Text = "No. Produksi :"
        Me.LCItem_ProductionNo.TextSize = New System.Drawing.Size(107, 21)
        '
        'LCItem_DescHeader
        '
        Me.LCItem_DescHeader.Control = Me.Memo_Header
        Me.LCItem_DescHeader.CustomizationFormText = "Description :"
        Me.LCItem_DescHeader.Location = New System.Drawing.Point(0, 64)
        Me.LCItem_DescHeader.MaxSize = New System.Drawing.Size(323, 60)
        Me.LCItem_DescHeader.MinSize = New System.Drawing.Size(323, 60)
        Me.LCItem_DescHeader.Name = "LCItem_DescHeader"
        Me.LCItem_DescHeader.Size = New System.Drawing.Size(323, 60)
        Me.LCItem_DescHeader.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_DescHeader.Text = "Keterangan :"
        Me.LCItem_DescHeader.TextSize = New System.Drawing.Size(107, 21)
        '
        'LCItem_ProductionDate
        '
        Me.LCItem_ProductionDate.Control = Me.Dt_ProductionDate
        Me.LCItem_ProductionDate.CustomizationFormText = "Production Date :"
        Me.LCItem_ProductionDate.Location = New System.Drawing.Point(0, 32)
        Me.LCItem_ProductionDate.Name = "LCItem_ProductionDate"
        Me.LCItem_ProductionDate.Size = New System.Drawing.Size(323, 32)
        Me.LCItem_ProductionDate.Text = "Tgl. Produksi :"
        Me.LCItem_ProductionDate.TextSize = New System.Drawing.Size(107, 21)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.PivotGridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(590, 468)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SpPDMDShiftGetDataBindingSource
        '
        Me.SpPDMDShiftGetDataBindingSource.DataMember = "sp_PD_MDShift_GetData"
        Me.SpPDMDShiftGetDataBindingSource.DataSource = Me.DataSet
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'AlertControl1
        '
        Me.AlertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight
        '
        'LC_Header
        '
        Me.LC_Header.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LC_Header.Appearance.Control.Options.UseFont = True
        Me.LC_Header.Controls.Add(Me.SB_Search)
        Me.LC_Header.Controls.Add(Me.Dt_End)
        Me.LC_Header.Controls.Add(Me.Dt_Start)
        Me.LC_Header.Controls.Add(Me.Sp_PDProductionDailyHeader_GetDataGridControl)
        Me.LC_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Header.Location = New System.Drawing.Point(0, 0)
        Me.LC_Header.Name = "LC_Header"
        Me.LC_Header.Padding = New System.Windows.Forms.Padding(5)
        Me.LC_Header.Root = Me.LayoutControlGroup2
        Me.LC_Header.Size = New System.Drawing.Size(957, 488)
        Me.LC_Header.TabIndex = 5
        Me.LC_Header.Text = "LayoutControl1"
        '
        'SB_Search
        '
        Me.SB_Search.Location = New System.Drawing.Point(835, 7)
        Me.SB_Search.Name = "SB_Search"
        Me.SB_Search.Size = New System.Drawing.Size(115, 28)
        Me.SB_Search.StyleController = Me.LC_Header
        Me.SB_Search.TabIndex = 7
        Me.SB_Search.Text = "Search"
        '
        'Dt_End
        '
        Me.Dt_End.EditValue = Nothing
        Me.Dt_End.Location = New System.Drawing.Point(263, 7)
        Me.Dt_End.MenuManager = Me.RibbonControl
        Me.Dt_End.Name = "Dt_End"
        Me.Dt_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.Dt_End.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Dt_End.Size = New System.Drawing.Size(142, 28)
        Me.Dt_End.StyleController = Me.LC_Header
        Me.Dt_End.TabIndex = 6
        '
        'Dt_Start
        '
        Me.Dt_Start.EditValue = Nothing
        Me.Dt_Start.Location = New System.Drawing.Point(99, 7)
        Me.Dt_Start.MenuManager = Me.RibbonControl
        Me.Dt_Start.Name = "Dt_Start"
        Me.Dt_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.Mask.EditMask = "dd MMM yyyy"
        Me.Dt_Start.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.Dt_Start.Size = New System.Drawing.Size(128, 28)
        Me.Dt_Start.StyleController = Me.LC_Header
        Me.Dt_Start.TabIndex = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_GV, Me.EmptySpaceItem2, Me.LCItem_DateStart, Me.LCItem_DateEnd, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(957, 488)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LCItem_GV
        '
        Me.LCItem_GV.Control = Me.Sp_PDProductionDailyHeader_GetDataGridControl
        Me.LCItem_GV.CustomizationFormText = "LCItem_GV"
        Me.LCItem_GV.Location = New System.Drawing.Point(0, 32)
        Me.LCItem_GV.Name = "LCItem_GV"
        Me.LCItem_GV.Size = New System.Drawing.Size(947, 446)
        Me.LCItem_GV.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_GV.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(402, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(426, 32)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCItem_DateStart
        '
        Me.LCItem_DateStart.Control = Me.Dt_Start
        Me.LCItem_DateStart.CustomizationFormText = "Date From :"
        Me.LCItem_DateStart.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_DateStart.Name = "LCItem_DateStart"
        Me.LCItem_DateStart.Size = New System.Drawing.Size(224, 32)
        Me.LCItem_DateStart.Text = "Date From :"
        Me.LCItem_DateStart.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_DateStart.TextSize = New System.Drawing.Size(87, 21)
        Me.LCItem_DateStart.TextToControlDistance = 5
        '
        'LCItem_DateEnd
        '
        Me.LCItem_DateEnd.Control = Me.Dt_End
        Me.LCItem_DateEnd.CustomizationFormText = "To :"
        Me.LCItem_DateEnd.Location = New System.Drawing.Point(224, 0)
        Me.LCItem_DateEnd.Name = "LCItem_DateEnd"
        Me.LCItem_DateEnd.Size = New System.Drawing.Size(178, 32)
        Me.LCItem_DateEnd.Text = "To :"
        Me.LCItem_DateEnd.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_DateEnd.TextSize = New System.Drawing.Size(27, 21)
        Me.LCItem_DateEnd.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Search
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(828, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(119, 32)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'Sp_PDProductionDailyHeader_GetDataTableAdapter
        '
        Me.Sp_PDProductionDailyHeader_GetDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_PDProductionDailyDetail_GetDataTableAdapter
        '
        Me.Sp_PDProductionDailyDetail_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_PD_MDHenHouse_GetDataTableAdapter
        '
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Sp_PD_MDShift_GetDataTableAdapter
        '
        Me.Sp_PD_MDShift_GetDataTableAdapter.ClearBeforeFill = True
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 149)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPage() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.SelectedPageIndex = 0
        Me.NavigationFrame1.Size = New System.Drawing.Size(957, 488)
        Me.NavigationFrame1.TabIndex = 8
        Me.NavigationFrame1.Text = "NavigationFrame1"
        Me.NavigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Fade
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LC_Header)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(957, 488)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.LC_Detail)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(957, 488)
        '
        'Sp_PD_MDInventoryFood_GetDataTableAdapter
        '
        Me.Sp_PD_MDInventoryFood_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Frm_PDDailyFood
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 713)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Frm_PDDailyFood"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Transaksi Pakan Harian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GV_HeaderDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_Detail.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Inventory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDInventoryFoodGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Memo_Header.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_HenHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Memo_DescDet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_ProductionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_ProductionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_ProductionNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DescDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_QtyDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_HenHouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_ProductionNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DescHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_ProductionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDShiftGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_Header.ResumeLayout(False)
        CType(Me.Dt_End.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_Start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DateEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationFrame1.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPageHome As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageProcess As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BB_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BB_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BB_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BB_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BB_Back As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BB_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LC_Detail As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents AlertControl1 As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents LCGroup_Data As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LC_Header As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Sp_PDProductionDailyHeader_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet As ALA_FarmProduction.DataSet
    Friend WithEvents Sp_PDProductionDailyHeader_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PDProductionDailyHeader_GetDataTableAdapter
    Friend WithEvents TableAdapterManager As ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_PDProductionDailyHeader_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Header As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LCItem_GV As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GV_HeaderDetail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colProductionID_HeaderDetail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colShiftID_HeaderDetail As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn7 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn11 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn12 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn13 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn14 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SB_Search As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Dt_End As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Dt_Start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LCItem_DateStart As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DateEnd As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Dt_ProductionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Ed_ProductionNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCItem_ProductionNo As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_ProductionDate As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Sp_PDProductionDailyDetail_GetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PDProductionDailyDetail_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PDProductionDailyDetail_GetDataTableAdapter
    Friend WithEvents LookUpEdit_Inventory As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Memo_Header As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LookUpEdit_HenHouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Memo_DescDet As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LCGroup_Detail As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCItem_DescDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_QtyDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_Inventory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_HenHouse As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DescHeader As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter As ALA_FarmProduction.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SpPDMDHenHouseGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDHenHouse_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDHenHouse_GetDataTableAdapter
    Friend WithEvents SpPDMDShiftGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDShift_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDShift_GetDataTableAdapter
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SpPDMDInventoryFoodGetDataBindingSource As BindingSource
    Friend WithEvents Sp_PD_MDInventoryFood_GetDataTableAdapter As DataSetTableAdapters.sp_PD_MDInventoryFood_GetDataTableAdapter
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShiftID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldShiftName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvTypeCode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInvTypeName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldDescription1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldModifiedUser1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldModifiedDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldMode1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents SB_Reset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SB_Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Ed_Price As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Ed_Weight As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodStartDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAge As DevExpress.XtraGrid.Columns.GridColumn
End Class
