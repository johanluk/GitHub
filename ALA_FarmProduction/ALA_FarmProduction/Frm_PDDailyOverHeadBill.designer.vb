﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PDDailyOverHeadBill
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PDDailyOverHeadBill))
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
        Me.Sp_PDProductionDailyHeader_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New ALA_FarmProduction.DataSet()
        Me.GV_Header = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionNo_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionDate_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHenHouseID_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyTotal_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightTotal_Header = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription_Header = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPDMDInventoryEggGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Memo_Header = New DevExpress.XtraEditors.MemoEdit()
        Me.LookUpEdit_HenHouse = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPDMDHenHouseGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit_Shift = New DevExpress.XtraEditors.LookUpEdit()
        Me.SpPDMDShiftGetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_PDProductionDailyDetail_GetDataGridControl = New DevExpress.XtraGrid.GridControl()
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvTypeCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvTypeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedUser1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Dt_ProductionDate = New DevExpress.XtraEditors.DateEdit()
        Me.Ed_ProductionNo = New DevExpress.XtraEditors.TextEdit()
        Me.CE_AutoCode = New DevExpress.XtraEditors.CheckEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_GVDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Detail = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_ShiftDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DescDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_QtyDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_Inventory = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_WeightDetail = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCGroup_Data = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LCItem_AutoCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_ProductionNo = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_DescHeader = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_ProductionDate = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LCItem_HenHouse = New DevExpress.XtraLayout.LayoutControlItem()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
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
        Me.Sp_PD_MDInventoryEgg_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDInventoryEgg_GetDataTableAdapter()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        CType(Me.GV_HeaderDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyHeader_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Detail.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDInventoryEggGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Memo_Header.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_HenHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_Shift.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDShiftGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_ProductionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt_ProductionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_ProductionNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_AutoCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_GVDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_ShiftDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DescDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_QtyDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_Inventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_WeightDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCGroup_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_AutoCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_ProductionNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_DescHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_ProductionDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LCItem_HenHouse, System.ComponentModel.ISupportInitialize).BeginInit()
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
        GridLevelNode1.LevelTemplate = Me.GV_HeaderDetail
        GridLevelNode1.RelationName = "sp_PDProductionDailyHeader_GetData_sp_PD_PDProductionDailyDetail_GetData"
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Location = New System.Drawing.Point(7, 33)
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.MainView = Me.GV_Header
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Name = "Sp_PDProductionDailyHeader_GetDataGridControl"
        Me.Sp_PDProductionDailyHeader_GetDataGridControl.Size = New System.Drawing.Size(943, 422)
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
        Me.GV_Header.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID_Header, Me.colProductionNo_Header, Me.colProductionDate_Header, Me.colHenHouseID_Header, Me.colQtyTotal_Header, Me.colWeightTotal_Header, Me.colDescription_Header})
        Me.GV_Header.GridControl = Me.Sp_PDProductionDailyHeader_GetDataGridControl
        Me.GV_Header.Name = "GV_Header"
        '
        'colID_Header
        '
        Me.colID_Header.FieldName = "ID"
        Me.colID_Header.Name = "colID_Header"
        Me.colID_Header.OptionsColumn.AllowEdit = False
        Me.colID_Header.OptionsColumn.AllowFocus = False
        Me.colID_Header.OptionsColumn.ReadOnly = True
        '
        'colProductionNo_Header
        '
        Me.colProductionNo_Header.FieldName = "ProductionNo"
        Me.colProductionNo_Header.Name = "colProductionNo_Header"
        Me.colProductionNo_Header.OptionsColumn.AllowEdit = False
        Me.colProductionNo_Header.OptionsColumn.AllowFocus = False
        Me.colProductionNo_Header.Visible = True
        Me.colProductionNo_Header.VisibleIndex = 0
        '
        'colProductionDate_Header
        '
        Me.colProductionDate_Header.FieldName = "ProductionDate"
        Me.colProductionDate_Header.Name = "colProductionDate_Header"
        Me.colProductionDate_Header.OptionsColumn.AllowEdit = False
        Me.colProductionDate_Header.OptionsColumn.AllowFocus = False
        Me.colProductionDate_Header.Visible = True
        Me.colProductionDate_Header.VisibleIndex = 1
        '
        'colHenHouseID_Header
        '
        Me.colHenHouseID_Header.FieldName = "HenHouseID"
        Me.colHenHouseID_Header.Name = "colHenHouseID_Header"
        Me.colHenHouseID_Header.OptionsColumn.AllowEdit = False
        Me.colHenHouseID_Header.OptionsColumn.AllowFocus = False
        Me.colHenHouseID_Header.Visible = True
        Me.colHenHouseID_Header.VisibleIndex = 2
        '
        'colQtyTotal_Header
        '
        Me.colQtyTotal_Header.FieldName = "QtyTotal"
        Me.colQtyTotal_Header.Name = "colQtyTotal_Header"
        Me.colQtyTotal_Header.OptionsColumn.AllowEdit = False
        Me.colQtyTotal_Header.OptionsColumn.AllowFocus = False
        Me.colQtyTotal_Header.Visible = True
        Me.colQtyTotal_Header.VisibleIndex = 3
        '
        'colWeightTotal_Header
        '
        Me.colWeightTotal_Header.FieldName = "WeightTotal"
        Me.colWeightTotal_Header.Name = "colWeightTotal_Header"
        Me.colWeightTotal_Header.OptionsColumn.AllowEdit = False
        Me.colWeightTotal_Header.OptionsColumn.AllowFocus = False
        Me.colWeightTotal_Header.Visible = True
        Me.colWeightTotal_Header.VisibleIndex = 4
        '
        'colDescription_Header
        '
        Me.colDescription_Header.FieldName = "Description"
        Me.colDescription_Header.Name = "colDescription_Header"
        Me.colDescription_Header.OptionsColumn.AllowEdit = False
        Me.colDescription_Header.OptionsColumn.AllowFocus = False
        Me.colDescription_Header.Visible = True
        Me.colDescription_Header.VisibleIndex = 5
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
        Me.LC_Detail.Controls.Add(Me.LookUpEdit1)
        Me.LC_Detail.Controls.Add(Me.Memo_Header)
        Me.LC_Detail.Controls.Add(Me.LookUpEdit_HenHouse)
        Me.LC_Detail.Controls.Add(Me.MemoEdit1)
        Me.LC_Detail.Controls.Add(Me.TextEdit4)
        Me.LC_Detail.Controls.Add(Me.TextEdit3)
        Me.LC_Detail.Controls.Add(Me.LookUpEdit_Shift)
        Me.LC_Detail.Controls.Add(Me.Sp_PDProductionDailyDetail_GetDataGridControl)
        Me.LC_Detail.Controls.Add(Me.Dt_ProductionDate)
        Me.LC_Detail.Controls.Add(Me.Ed_ProductionNo)
        Me.LC_Detail.Controls.Add(Me.CE_AutoCode)
        Me.LC_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Detail.Location = New System.Drawing.Point(0, 0)
        Me.LC_Detail.Name = "LC_Detail"
        Me.LC_Detail.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(409, 189, 250, 350)
        Me.LC_Detail.Root = Me.LayoutControlGroup1
        Me.LC_Detail.Size = New System.Drawing.Size(957, 462)
        Me.LC_Detail.TabIndex = 2
        Me.LC_Detail.Text = "LayoutControl1"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(724, 224)
        Me.LookUpEdit1.MenuManager = Me.RibbonControl
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.SpPDMDInventoryEggGetDataBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "InventoryName"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "ID"
        Me.LookUpEdit1.Size = New System.Drawing.Size(209, 20)
        Me.LookUpEdit1.StyleController = Me.LC_Detail
        Me.LookUpEdit1.TabIndex = 15
        '
        'SpPDMDInventoryEggGetDataBindingSource
        '
        Me.SpPDMDInventoryEggGetDataBindingSource.DataMember = "sp_PD_MDInventoryEgg_GetData"
        Me.SpPDMDInventoryEggGetDataBindingSource.DataSource = Me.DataSet
        '
        'Memo_Header
        '
        Me.Memo_Header.Location = New System.Drawing.Point(724, 114)
        Me.Memo_Header.MenuManager = Me.RibbonControl
        Me.Memo_Header.Name = "Memo_Header"
        Me.Memo_Header.Size = New System.Drawing.Size(209, 16)
        Me.Memo_Header.StyleController = Me.LC_Detail
        Me.Memo_Header.TabIndex = 14
        '
        'LookUpEdit_HenHouse
        '
        Me.LookUpEdit_HenHouse.Location = New System.Drawing.Point(724, 90)
        Me.LookUpEdit_HenHouse.MenuManager = Me.RibbonControl
        Me.LookUpEdit_HenHouse.Name = "LookUpEdit_HenHouse"
        Me.LookUpEdit_HenHouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_HenHouse.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCode", "Hen House Code", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseTypeID", "Hen House Type ID", 103, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseName", "Hen House Name", 92, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCapacity", "Hen House Capacity", 107, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HenHouseCreated", "Hen House Created", 104, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("isActive", "is Active", 50, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit_HenHouse.Properties.DataSource = Me.SpPDMDHenHouseGetDataBindingSource
        Me.LookUpEdit_HenHouse.Properties.DisplayMember = "HenHouseName"
        Me.LookUpEdit_HenHouse.Properties.NullText = ""
        Me.LookUpEdit_HenHouse.Properties.ValueMember = "ID"
        Me.LookUpEdit_HenHouse.Size = New System.Drawing.Size(209, 20)
        Me.LookUpEdit_HenHouse.StyleController = Me.LC_Detail
        Me.LookUpEdit_HenHouse.TabIndex = 13
        '
        'SpPDMDHenHouseGetDataBindingSource
        '
        Me.SpPDMDHenHouseGetDataBindingSource.DataMember = "sp_PD_MDHenHouse_GetData"
        Me.SpPDMDHenHouseGetDataBindingSource.DataSource = Me.DataSet
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(724, 248)
        Me.MemoEdit1.MenuManager = Me.RibbonControl
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(209, 190)
        Me.MemoEdit1.StyleController = Me.LC_Detail
        Me.MemoEdit1.TabIndex = 12
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(683, 200)
        Me.TextEdit4.MenuManager = Me.RibbonControl
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Mask.EditMask = "n2"
        Me.TextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit4.Size = New System.Drawing.Size(250, 20)
        Me.TextEdit4.StyleController = Me.LC_Detail
        Me.TextEdit4.TabIndex = 11
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(821, 176)
        Me.TextEdit3.MenuManager = Me.RibbonControl
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Mask.EditMask = "n0"
        Me.TextEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit3.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit3.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit3.StyleController = Me.LC_Detail
        Me.TextEdit3.TabIndex = 10
        '
        'LookUpEdit_Shift
        '
        Me.LookUpEdit_Shift.Location = New System.Drawing.Point(724, 176)
        Me.LookUpEdit_Shift.MenuManager = Me.RibbonControl
        Me.LookUpEdit_Shift.Name = "LookUpEdit_Shift"
        Me.LookUpEdit_Shift.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit_Shift.Properties.DataSource = Me.SpPDMDShiftGetDataBindingSource
        Me.LookUpEdit_Shift.Properties.DisplayMember = "ShiftName"
        Me.LookUpEdit_Shift.Properties.NullText = ""
        Me.LookUpEdit_Shift.Properties.ValueMember = "ID"
        Me.LookUpEdit_Shift.Size = New System.Drawing.Size(63, 20)
        Me.LookUpEdit_Shift.StyleController = Me.LC_Detail
        Me.LookUpEdit_Shift.TabIndex = 9
        '
        'SpPDMDShiftGetDataBindingSource
        '
        Me.SpPDMDShiftGetDataBindingSource.DataMember = "sp_PD_MDShift_GetData"
        Me.SpPDMDShiftGetDataBindingSource.DataSource = Me.DataSet
        '
        'Sp_PDProductionDailyDetail_GetDataGridControl
        '
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.DataSource = Me.Sp_PDProductionDailyDetail_GetDataBindingSource
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.Location = New System.Drawing.Point(15, 15)
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.MainView = Me.GV_Detail
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.MenuManager = Me.RibbonControl
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.Name = "Sp_PDProductionDailyDetail_GetDataGridControl"
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.Size = New System.Drawing.Size(603, 432)
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.TabIndex = 8
        Me.Sp_PDProductionDailyDetail_GetDataGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Detail})
        '
        'Sp_PDProductionDailyDetail_GetDataBindingSource
        '
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource.DataMember = "sp_PDProductionDailyDetail_GetData"
        Me.Sp_PDProductionDailyDetail_GetDataBindingSource.DataSource = Me.DataSet
        '
        'GV_Detail
        '
        Me.GV_Detail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colProductionID1, Me.colShiftID1, Me.colInventoryID, Me.colInventoryName, Me.colInvTypeCode, Me.colInvTypeName, Me.colQty, Me.colWeight, Me.colDescription1, Me.colModifiedUser1, Me.colModifiedDate1})
        Me.GV_Detail.GridControl = Me.Sp_PDProductionDailyDetail_GetDataGridControl
        Me.GV_Detail.GroupCount = 1
        Me.GV_Detail.Name = "GV_Detail"
        Me.GV_Detail.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colInvTypeCode, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colInventoryName, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.AllowEdit = False
        Me.colID1.OptionsColumn.AllowFocus = False
        Me.colID1.OptionsColumn.ReadOnly = True
        '
        'colProductionID1
        '
        Me.colProductionID1.FieldName = "ProductionID"
        Me.colProductionID1.Name = "colProductionID1"
        Me.colProductionID1.OptionsColumn.AllowEdit = False
        Me.colProductionID1.OptionsColumn.AllowFocus = False
        '
        'colShiftID1
        '
        Me.colShiftID1.FieldName = "ShiftID"
        Me.colShiftID1.Name = "colShiftID1"
        Me.colShiftID1.OptionsColumn.AllowEdit = False
        Me.colShiftID1.OptionsColumn.AllowFocus = False
        Me.colShiftID1.Visible = True
        Me.colShiftID1.VisibleIndex = 0
        '
        'colInventoryID
        '
        Me.colInventoryID.FieldName = "InventoryID"
        Me.colInventoryID.Name = "colInventoryID"
        Me.colInventoryID.OptionsColumn.AllowEdit = False
        Me.colInventoryID.OptionsColumn.AllowFocus = False
        '
        'colInventoryName
        '
        Me.colInventoryName.FieldName = "InventoryName"
        Me.colInventoryName.Name = "colInventoryName"
        Me.colInventoryName.OptionsColumn.AllowEdit = False
        Me.colInventoryName.OptionsColumn.AllowFocus = False
        Me.colInventoryName.Visible = True
        Me.colInventoryName.VisibleIndex = 1
        '
        'colInvTypeCode
        '
        Me.colInvTypeCode.FieldName = "InvTypeCode"
        Me.colInvTypeCode.Name = "colInvTypeCode"
        Me.colInvTypeCode.OptionsColumn.AllowEdit = False
        Me.colInvTypeCode.OptionsColumn.AllowFocus = False
        Me.colInvTypeCode.Visible = True
        Me.colInvTypeCode.VisibleIndex = 3
        '
        'colInvTypeName
        '
        Me.colInvTypeName.FieldName = "InvTypeName"
        Me.colInvTypeName.Name = "colInvTypeName"
        Me.colInvTypeName.OptionsColumn.AllowEdit = False
        Me.colInvTypeName.OptionsColumn.AllowFocus = False
        Me.colInvTypeName.Visible = True
        Me.colInvTypeName.VisibleIndex = 2
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.AllowFocus = False
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        '
        'colWeight
        '
        Me.colWeight.FieldName = "Weight"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.OptionsColumn.AllowEdit = False
        Me.colWeight.OptionsColumn.AllowFocus = False
        Me.colWeight.Visible = True
        Me.colWeight.VisibleIndex = 4
        '
        'colDescription1
        '
        Me.colDescription1.FieldName = "Description"
        Me.colDescription1.Name = "colDescription1"
        Me.colDescription1.OptionsColumn.AllowEdit = False
        Me.colDescription1.OptionsColumn.AllowFocus = False
        Me.colDescription1.Visible = True
        Me.colDescription1.VisibleIndex = 5
        '
        'colModifiedUser1
        '
        Me.colModifiedUser1.FieldName = "ModifiedUser"
        Me.colModifiedUser1.Name = "colModifiedUser1"
        Me.colModifiedUser1.OptionsColumn.AllowEdit = False
        Me.colModifiedUser1.OptionsColumn.AllowFocus = False
        '
        'colModifiedDate1
        '
        Me.colModifiedDate1.FieldName = "ModifiedDate"
        Me.colModifiedDate1.Name = "colModifiedDate1"
        Me.colModifiedDate1.OptionsColumn.AllowEdit = False
        Me.colModifiedDate1.OptionsColumn.AllowFocus = False
        '
        'Dt_ProductionDate
        '
        Me.Dt_ProductionDate.EditValue = Nothing
        Me.Dt_ProductionDate.Location = New System.Drawing.Point(724, 66)
        Me.Dt_ProductionDate.MenuManager = Me.RibbonControl
        Me.Dt_ProductionDate.Name = "Dt_ProductionDate"
        Me.Dt_ProductionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_ProductionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_ProductionDate.Size = New System.Drawing.Size(209, 20)
        Me.Dt_ProductionDate.StyleController = Me.LC_Detail
        Me.Dt_ProductionDate.TabIndex = 7
        '
        'Ed_ProductionNo
        '
        Me.Ed_ProductionNo.Location = New System.Drawing.Point(724, 42)
        Me.Ed_ProductionNo.MenuManager = Me.RibbonControl
        Me.Ed_ProductionNo.Name = "Ed_ProductionNo"
        Me.Ed_ProductionNo.Size = New System.Drawing.Size(129, 20)
        Me.Ed_ProductionNo.StyleController = Me.LC_Detail
        Me.Ed_ProductionNo.TabIndex = 6
        '
        'CE_AutoCode
        '
        Me.CE_AutoCode.Location = New System.Drawing.Point(868, 42)
        Me.CE_AutoCode.MenuManager = Me.RibbonControl
        Me.CE_AutoCode.Name = "CE_AutoCode"
        Me.CE_AutoCode.Properties.Caption = "Auto No."
        Me.CE_AutoCode.Size = New System.Drawing.Size(65, 19)
        Me.CE_AutoCode.StyleController = Me.LC_Detail
        Me.CE_AutoCode.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_GVDetail, Me.LCGroup_Detail, Me.LCGroup_Data})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(957, 462)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LCItem_GVDetail
        '
        Me.LCItem_GVDetail.Control = Me.Sp_PDProductionDailyDetail_GetDataGridControl
        Me.LCItem_GVDetail.CustomizationFormText = "LCItem_GVDetail"
        Me.LCItem_GVDetail.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_GVDetail.Name = "LCItem_GVDetail"
        Me.LCItem_GVDetail.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LCItem_GVDetail.Size = New System.Drawing.Size(613, 442)
        Me.LCItem_GVDetail.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_GVDetail.TextVisible = False
        '
        'LCGroup_Detail
        '
        Me.LCGroup_Detail.CustomizationFormText = ":: Detail ::"
        Me.LCGroup_Detail.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_ShiftDetail, Me.LCItem_DescDetail, Me.LCItem_QtyDetail, Me.LCItem_Inventory, Me.LCItem_WeightDetail})
        Me.LCGroup_Detail.Location = New System.Drawing.Point(613, 134)
        Me.LCGroup_Detail.Name = "LCGroup_Detail"
        Me.LCGroup_Detail.Size = New System.Drawing.Size(324, 308)
        Me.LCGroup_Detail.Text = ":: Detail ::"
        '
        'LCItem_ShiftDetail
        '
        Me.LCItem_ShiftDetail.Control = Me.LookUpEdit_Shift
        Me.LCItem_ShiftDetail.CustomizationFormText = "Shift :"
        Me.LCItem_ShiftDetail.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_ShiftDetail.Name = "LCItem_ShiftDetail"
        Me.LCItem_ShiftDetail.Size = New System.Drawing.Size(154, 24)
        Me.LCItem_ShiftDetail.Text = "Shift :"
        Me.LCItem_ShiftDetail.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_DescDetail
        '
        Me.LCItem_DescDetail.Control = Me.MemoEdit1
        Me.LCItem_DescDetail.CustomizationFormText = "Description :"
        Me.LCItem_DescDetail.Location = New System.Drawing.Point(0, 72)
        Me.LCItem_DescDetail.Name = "LCItem_DescDetail"
        Me.LCItem_DescDetail.Size = New System.Drawing.Size(300, 194)
        Me.LCItem_DescDetail.Text = "Description :"
        Me.LCItem_DescDetail.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_QtyDetail
        '
        Me.LCItem_QtyDetail.Control = Me.TextEdit3
        Me.LCItem_QtyDetail.CustomizationFormText = "Qty :"
        Me.LCItem_QtyDetail.Location = New System.Drawing.Point(154, 0)
        Me.LCItem_QtyDetail.Name = "LCItem_QtyDetail"
        Me.LCItem_QtyDetail.Size = New System.Drawing.Size(146, 24)
        Me.LCItem_QtyDetail.Text = "Qty :"
        Me.LCItem_QtyDetail.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_QtyDetail.TextSize = New System.Drawing.Size(25, 13)
        Me.LCItem_QtyDetail.TextToControlDistance = 5
        '
        'LCItem_Inventory
        '
        Me.LCItem_Inventory.Control = Me.LookUpEdit1
        Me.LCItem_Inventory.CustomizationFormText = "Jenis Telur :"
        Me.LCItem_Inventory.Location = New System.Drawing.Point(0, 48)
        Me.LCItem_Inventory.Name = "LCItem_Inventory"
        Me.LCItem_Inventory.Size = New System.Drawing.Size(300, 24)
        Me.LCItem_Inventory.Text = "Jenis Telur :"
        Me.LCItem_Inventory.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_WeightDetail
        '
        Me.LCItem_WeightDetail.Control = Me.TextEdit4
        Me.LCItem_WeightDetail.CustomizationFormText = "Weight :"
        Me.LCItem_WeightDetail.Location = New System.Drawing.Point(0, 24)
        Me.LCItem_WeightDetail.Name = "LCItem_WeightDetail"
        Me.LCItem_WeightDetail.Size = New System.Drawing.Size(300, 24)
        Me.LCItem_WeightDetail.Text = "Weight :"
        Me.LCItem_WeightDetail.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_WeightDetail.TextSize = New System.Drawing.Size(41, 13)
        Me.LCItem_WeightDetail.TextToControlDistance = 5
        '
        'LCGroup_Data
        '
        Me.LCGroup_Data.CustomizationFormText = ":: Data ::"
        Me.LCGroup_Data.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_AutoCode, Me.LCItem_ProductionNo, Me.LCItem_DescHeader, Me.LCItem_ProductionDate, Me.LCItem_HenHouse})
        Me.LCGroup_Data.Location = New System.Drawing.Point(613, 0)
        Me.LCGroup_Data.Name = "LCGroup_Data"
        Me.LCGroup_Data.Size = New System.Drawing.Size(324, 134)
        Me.LCGroup_Data.Text = ":: Header ::"
        '
        'LCItem_AutoCode
        '
        Me.LCItem_AutoCode.Control = Me.CE_AutoCode
        Me.LCItem_AutoCode.CustomizationFormText = "  "
        Me.LCItem_AutoCode.Location = New System.Drawing.Point(220, 0)
        Me.LCItem_AutoCode.MaxSize = New System.Drawing.Size(80, 23)
        Me.LCItem_AutoCode.MinSize = New System.Drawing.Size(80, 23)
        Me.LCItem_AutoCode.Name = "LCItem_AutoCode"
        Me.LCItem_AutoCode.Size = New System.Drawing.Size(80, 24)
        Me.LCItem_AutoCode.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LCItem_AutoCode.Text = "  "
        Me.LCItem_AutoCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_AutoCode.TextSize = New System.Drawing.Size(6, 13)
        Me.LCItem_AutoCode.TextToControlDistance = 5
        '
        'LCItem_ProductionNo
        '
        Me.LCItem_ProductionNo.Control = Me.Ed_ProductionNo
        Me.LCItem_ProductionNo.CustomizationFormText = "Production No :"
        Me.LCItem_ProductionNo.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_ProductionNo.Name = "LCItem_ProductionNo"
        Me.LCItem_ProductionNo.Size = New System.Drawing.Size(220, 24)
        Me.LCItem_ProductionNo.Text = "Production No :"
        Me.LCItem_ProductionNo.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_DescHeader
        '
        Me.LCItem_DescHeader.Control = Me.Memo_Header
        Me.LCItem_DescHeader.CustomizationFormText = "Description :"
        Me.LCItem_DescHeader.Location = New System.Drawing.Point(0, 72)
        Me.LCItem_DescHeader.Name = "LCItem_DescHeader"
        Me.LCItem_DescHeader.Size = New System.Drawing.Size(300, 20)
        Me.LCItem_DescHeader.Text = "Description :"
        Me.LCItem_DescHeader.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_ProductionDate
        '
        Me.LCItem_ProductionDate.Control = Me.Dt_ProductionDate
        Me.LCItem_ProductionDate.CustomizationFormText = "Production Date :"
        Me.LCItem_ProductionDate.Location = New System.Drawing.Point(0, 24)
        Me.LCItem_ProductionDate.Name = "LCItem_ProductionDate"
        Me.LCItem_ProductionDate.Size = New System.Drawing.Size(300, 24)
        Me.LCItem_ProductionDate.Text = "Production Date :"
        Me.LCItem_ProductionDate.TextSize = New System.Drawing.Size(84, 13)
        '
        'LCItem_HenHouse
        '
        Me.LCItem_HenHouse.Control = Me.LookUpEdit_HenHouse
        Me.LCItem_HenHouse.CustomizationFormText = "Kandang :"
        Me.LCItem_HenHouse.Location = New System.Drawing.Point(0, 48)
        Me.LCItem_HenHouse.Name = "LCItem_HenHouse"
        Me.LCItem_HenHouse.Size = New System.Drawing.Size(300, 24)
        Me.LCItem_HenHouse.Text = "Kandang :"
        Me.LCItem_HenHouse.TextSize = New System.Drawing.Size(84, 13)
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'LC_Header
        '
        Me.LC_Header.Controls.Add(Me.SB_Search)
        Me.LC_Header.Controls.Add(Me.Dt_End)
        Me.LC_Header.Controls.Add(Me.Dt_Start)
        Me.LC_Header.Controls.Add(Me.Sp_PDProductionDailyHeader_GetDataGridControl)
        Me.LC_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Header.Location = New System.Drawing.Point(0, 0)
        Me.LC_Header.Name = "LC_Header"
        Me.LC_Header.Padding = New System.Windows.Forms.Padding(5)
        Me.LC_Header.Root = Me.LayoutControlGroup2
        Me.LC_Header.Size = New System.Drawing.Size(957, 462)
        Me.LC_Header.TabIndex = 5
        Me.LC_Header.Text = "LayoutControl1"
        '
        'SB_Search
        '
        Me.SB_Search.Location = New System.Drawing.Point(835, 7)
        Me.SB_Search.Name = "SB_Search"
        Me.SB_Search.Size = New System.Drawing.Size(115, 22)
        Me.SB_Search.StyleController = Me.LC_Header
        Me.SB_Search.TabIndex = 7
        Me.SB_Search.Text = "Search"
        '
        'Dt_End
        '
        Me.Dt_End.EditValue = Nothing
        Me.Dt_End.Location = New System.Drawing.Point(255, 7)
        Me.Dt_End.MenuManager = Me.RibbonControl
        Me.Dt_End.Name = "Dt_End"
        Me.Dt_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_End.Size = New System.Drawing.Size(150, 20)
        Me.Dt_End.StyleController = Me.LC_Header
        Me.Dt_End.TabIndex = 6
        '
        'Dt_Start
        '
        Me.Dt_Start.EditValue = Nothing
        Me.Dt_Start.Location = New System.Drawing.Point(69, 7)
        Me.Dt_Start.MenuManager = Me.RibbonControl
        Me.Dt_Start.Name = "Dt_Start"
        Me.Dt_Start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Dt_Start.Size = New System.Drawing.Size(158, 20)
        Me.Dt_Start.StyleController = Me.LC_Header
        Me.Dt_Start.TabIndex = 5
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCItem_GV, Me.EmptySpaceItem2, Me.LCItem_DateStart, Me.LCItem_DateEnd, Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(957, 462)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LCItem_GV
        '
        Me.LCItem_GV.Control = Me.Sp_PDProductionDailyHeader_GetDataGridControl
        Me.LCItem_GV.CustomizationFormText = "LCItem_GV"
        Me.LCItem_GV.Location = New System.Drawing.Point(0, 26)
        Me.LCItem_GV.Name = "LCItem_GV"
        Me.LCItem_GV.Size = New System.Drawing.Size(947, 426)
        Me.LCItem_GV.TextSize = New System.Drawing.Size(0, 0)
        Me.LCItem_GV.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.CustomizationFormText = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(402, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(426, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LCItem_DateStart
        '
        Me.LCItem_DateStart.Control = Me.Dt_Start
        Me.LCItem_DateStart.CustomizationFormText = "Date From :"
        Me.LCItem_DateStart.Location = New System.Drawing.Point(0, 0)
        Me.LCItem_DateStart.Name = "LCItem_DateStart"
        Me.LCItem_DateStart.Size = New System.Drawing.Size(224, 26)
        Me.LCItem_DateStart.Text = "Date From :"
        Me.LCItem_DateStart.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_DateStart.TextSize = New System.Drawing.Size(57, 13)
        Me.LCItem_DateStart.TextToControlDistance = 5
        '
        'LCItem_DateEnd
        '
        Me.LCItem_DateEnd.Control = Me.Dt_End
        Me.LCItem_DateEnd.CustomizationFormText = "To :"
        Me.LCItem_DateEnd.Location = New System.Drawing.Point(224, 0)
        Me.LCItem_DateEnd.Name = "LCItem_DateEnd"
        Me.LCItem_DateEnd.Size = New System.Drawing.Size(178, 26)
        Me.LCItem_DateEnd.Text = "To :"
        Me.LCItem_DateEnd.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LCItem_DateEnd.TextSize = New System.Drawing.Size(19, 13)
        Me.LCItem_DateEnd.TextToControlDistance = 5
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SB_Search
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(828, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(119, 26)
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
        'Sp_PD_MDInventoryEgg_GetDataTableAdapter
        '
        Me.Sp_PD_MDInventoryEgg_GetDataTableAdapter.ClearBeforeFill = True
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
        Me.NavigationFrame1.Size = New System.Drawing.Size(957, 462)
        Me.NavigationFrame1.TabIndex = 8
        Me.NavigationFrame1.Text = "NavigationFrame1"
        Me.NavigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Fade
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.LC_Header)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(957, 462)
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Controls.Add(Me.LC_Detail)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(957, 462)
        '
        'Frm_PDDailyFood
        '
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
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDInventoryEggGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Memo_Header.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_HenHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_Shift.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDShiftGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PDProductionDailyDetail_GetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_ProductionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt_ProductionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_ProductionNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_AutoCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_GVDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_ShiftDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DescDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_QtyDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_Inventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_WeightDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCGroup_Data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_AutoCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_ProductionNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_DescHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_ProductionDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LCItem_HenHouse, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CE_AutoCode As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LCItem_AutoCode As DevExpress.XtraLayout.LayoutControlItem
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
    Friend WithEvents colID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionNo_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionDate_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHenHouseID_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyTotal_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightTotal_Header As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription_Header As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Memo_Header As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LookUpEdit_HenHouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit_Shift As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Sp_PDProductionDailyDetail_GetDataGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvTypeCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvTypeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedUser1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LCItem_GVDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCGroup_Detail As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LCItem_ShiftDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DescDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_QtyDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_WeightDetail As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_Inventory As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_HenHouse As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCItem_DescHeader As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents QueriesTableAdapter As ALA_FarmProduction.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SpPDMDHenHouseGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDHenHouse_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDHenHouse_GetDataTableAdapter
    Friend WithEvents SpPDMDShiftGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDShift_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDShift_GetDataTableAdapter
    Friend WithEvents SpPDMDInventoryEggGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDInventoryEgg_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDInventoryEgg_GetDataTableAdapter
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage

End Class
