<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PD_HPP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PD_HPP))
        Me.DataSet = New ALA_FarmProduction.DataSet()
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
        Me.PivotGridControl7 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.SpPDHPPGetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.fieldHenHouseID7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName7 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHPPAccountName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHPPValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl6 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.Sp_PD_HPP_GetDailyDetailBindingSource = New System.Windows.Forms.BindingSource()
        Me.fieldProductionID6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice6 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl5 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProductionID5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice5 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl4 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProductionID4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice4 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl3 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProductionID3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice3 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl2 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProductionID2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice2 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.fieldProductionID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldHenHouseName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionType1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryID1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldInventoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldTypeName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldUnit1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQty1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldWeight1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.SpPDMDHenHouseGetDataBindingSource = New System.Windows.Forms.BindingSource()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar2 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Me.AlertControl1 = New DevExpress.XtraBars.Alerter.AlertControl()
        Me.LC_Header = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TableAdapterManager = New ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager()
        Me.QueriesTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.QueriesTableAdapter()
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDHenHouse_GetDataTableAdapter()
        Me.NavigationFrame1 = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.Sp_PD_HPP_GetDailyDetailTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_HPP_GetDailyDetailTableAdapter()
        Me.Sp_PD_HPP_GetDataTableAdapter = New ALA_FarmProduction.DataSetTableAdapters.sp_PD_HPP_GetDataTableAdapter()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LC_Detail.SuspendLayout()
        CType(Me.PivotGridControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDHPPGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PD_HPP_GetDailyDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LC_Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationFrame1.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        Me.NavigationPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.LC_Detail.Controls.Add(Me.PivotGridControl7)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl6)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl5)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl4)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl3)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl2)
        Me.LC_Detail.Controls.Add(Me.PivotGridControl1)
        Me.LC_Detail.Controls.Add(Me.TextEdit1)
        Me.LC_Detail.Controls.Add(Me.LookUpEdit1)
        Me.LC_Detail.Controls.Add(Me.DateEdit1)
        Me.LC_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Detail.Location = New System.Drawing.Point(0, 0)
        Me.LC_Detail.Name = "LC_Detail"
        Me.LC_Detail.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(409, 189, 250, 350)
        Me.LC_Detail.Root = Me.LayoutControlGroup1
        Me.LC_Detail.Size = New System.Drawing.Size(957, 462)
        Me.LC_Detail.TabIndex = 2
        Me.LC_Detail.Text = "LayoutControl1"
        '
        'PivotGridControl7
        '
        Me.PivotGridControl7.DataSource = Me.SpPDHPPGetDataBindingSource
        Me.PivotGridControl7.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldHenHouseID7, Me.fieldHenHouseName7, Me.fieldHPPAccountName1, Me.fieldValue1, Me.fieldHPPValue1})
        Me.PivotGridControl7.Location = New System.Drawing.Point(548, 15)
        Me.PivotGridControl7.Name = "PivotGridControl7"
        Me.PivotGridControl7.Size = New System.Drawing.Size(394, 432)
        Me.PivotGridControl7.TabIndex = 15
        '
        'SpPDHPPGetDataBindingSource
        '
        Me.SpPDHPPGetDataBindingSource.DataMember = "sp_PD_HPP_GetData"
        Me.SpPDHPPGetDataBindingSource.DataSource = Me.DataSet
        '
        'fieldHenHouseID7
        '
        Me.fieldHenHouseID7.AreaIndex = 0
        Me.fieldHenHouseID7.FieldName = "HenHouseID"
        Me.fieldHenHouseID7.Name = "fieldHenHouseID7"
        '
        'fieldHenHouseName7
        '
        Me.fieldHenHouseName7.AreaIndex = 1
        Me.fieldHenHouseName7.FieldName = "HenHouseName"
        Me.fieldHenHouseName7.Name = "fieldHenHouseName7"
        '
        'fieldHPPAccountName1
        '
        Me.fieldHPPAccountName1.AreaIndex = 2
        Me.fieldHPPAccountName1.FieldName = "HPPAccountName"
        Me.fieldHPPAccountName1.Name = "fieldHPPAccountName1"
        '
        'fieldValue1
        '
        Me.fieldValue1.AreaIndex = 3
        Me.fieldValue1.FieldName = "Value"
        Me.fieldValue1.Name = "fieldValue1"
        '
        'fieldHPPValue1
        '
        Me.fieldHPPValue1.AreaIndex = 4
        Me.fieldHPPValue1.FieldName = "HPPValue"
        Me.fieldHPPValue1.Name = "fieldHPPValue1"
        '
        'PivotGridControl6
        '
        Me.PivotGridControl6.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl6.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID6, Me.fieldHenHouseID6, Me.fieldHenHouseName6, Me.fieldProductionType6, Me.fieldInventoryID6, Me.fieldInventoryName6, Me.fieldTypeName6, Me.fieldUnit6, Me.fieldQty6, Me.fieldWeight6, Me.fieldPrice6})
        Me.PivotGridControl6.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl6.Name = "PivotGridControl6"
        Me.PivotGridControl6.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl6.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl6.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl6.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl6.Prefilter.CriteriaString = "[fieldProductionType6] = 'Biaya Other'"
        Me.PivotGridControl6.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl6.TabIndex = 14
        '
        'Sp_PD_HPP_GetDailyDetailBindingSource
        '
        Me.Sp_PD_HPP_GetDailyDetailBindingSource.DataMember = "sp_PD_HPP_GetDailyDetail"
        Me.Sp_PD_HPP_GetDailyDetailBindingSource.DataSource = Me.DataSet
        '
        'fieldProductionID6
        '
        Me.fieldProductionID6.AreaIndex = 0
        Me.fieldProductionID6.FieldName = "ProductionID"
        Me.fieldProductionID6.Name = "fieldProductionID6"
        '
        'fieldHenHouseID6
        '
        Me.fieldHenHouseID6.AreaIndex = 1
        Me.fieldHenHouseID6.FieldName = "HenHouseID"
        Me.fieldHenHouseID6.Name = "fieldHenHouseID6"
        '
        'fieldHenHouseName6
        '
        Me.fieldHenHouseName6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName6.AreaIndex = 0
        Me.fieldHenHouseName6.FieldName = "HenHouseName"
        Me.fieldHenHouseName6.Name = "fieldHenHouseName6"
        '
        'fieldProductionType6
        '
        Me.fieldProductionType6.AreaIndex = 2
        Me.fieldProductionType6.FieldName = "ProductionType"
        Me.fieldProductionType6.Name = "fieldProductionType6"
        '
        'fieldInventoryID6
        '
        Me.fieldInventoryID6.AreaIndex = 3
        Me.fieldInventoryID6.FieldName = "InventoryID"
        Me.fieldInventoryID6.Name = "fieldInventoryID6"
        '
        'fieldInventoryName6
        '
        Me.fieldInventoryName6.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName6.AreaIndex = 1
        Me.fieldInventoryName6.FieldName = "InventoryName"
        Me.fieldInventoryName6.Name = "fieldInventoryName6"
        '
        'fieldTypeName6
        '
        Me.fieldTypeName6.AreaIndex = 4
        Me.fieldTypeName6.FieldName = "TypeName"
        Me.fieldTypeName6.Name = "fieldTypeName6"
        '
        'fieldUnit6
        '
        Me.fieldUnit6.AreaIndex = 5
        Me.fieldUnit6.FieldName = "Unit"
        Me.fieldUnit6.Name = "fieldUnit6"
        '
        'fieldQty6
        '
        Me.fieldQty6.AreaIndex = 6
        Me.fieldQty6.FieldName = "Qty"
        Me.fieldQty6.Name = "fieldQty6"
        '
        'fieldWeight6
        '
        Me.fieldWeight6.AreaIndex = 7
        Me.fieldWeight6.FieldName = "Weight"
        Me.fieldWeight6.Name = "fieldWeight6"
        '
        'fieldPrice6
        '
        Me.fieldPrice6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPrice6.AreaIndex = 0
        Me.fieldPrice6.FieldName = "Price"
        Me.fieldPrice6.Name = "fieldPrice6"
        '
        'PivotGridControl5
        '
        Me.PivotGridControl5.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl5.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID5, Me.fieldHenHouseID5, Me.fieldHenHouseName5, Me.fieldProductionType5, Me.fieldInventoryID5, Me.fieldInventoryName5, Me.fieldTypeName5, Me.fieldUnit5, Me.fieldQty5, Me.fieldWeight5, Me.fieldPrice5})
        Me.PivotGridControl5.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl5.Name = "PivotGridControl5"
        Me.PivotGridControl5.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl5.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl5.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl5.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl5.Prefilter.CriteriaString = "[fieldProductionType5] = 'Biaya Over Head'"
        Me.PivotGridControl5.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl5.TabIndex = 13
        '
        'fieldProductionID5
        '
        Me.fieldProductionID5.AreaIndex = 0
        Me.fieldProductionID5.FieldName = "ProductionID"
        Me.fieldProductionID5.Name = "fieldProductionID5"
        '
        'fieldHenHouseID5
        '
        Me.fieldHenHouseID5.AreaIndex = 1
        Me.fieldHenHouseID5.FieldName = "HenHouseID"
        Me.fieldHenHouseID5.Name = "fieldHenHouseID5"
        '
        'fieldHenHouseName5
        '
        Me.fieldHenHouseName5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName5.AreaIndex = 0
        Me.fieldHenHouseName5.FieldName = "HenHouseName"
        Me.fieldHenHouseName5.Name = "fieldHenHouseName5"
        '
        'fieldProductionType5
        '
        Me.fieldProductionType5.AreaIndex = 2
        Me.fieldProductionType5.FieldName = "ProductionType"
        Me.fieldProductionType5.Name = "fieldProductionType5"
        '
        'fieldInventoryID5
        '
        Me.fieldInventoryID5.AreaIndex = 3
        Me.fieldInventoryID5.FieldName = "InventoryID"
        Me.fieldInventoryID5.Name = "fieldInventoryID5"
        '
        'fieldInventoryName5
        '
        Me.fieldInventoryName5.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName5.AreaIndex = 1
        Me.fieldInventoryName5.FieldName = "InventoryName"
        Me.fieldInventoryName5.Name = "fieldInventoryName5"
        '
        'fieldTypeName5
        '
        Me.fieldTypeName5.AreaIndex = 4
        Me.fieldTypeName5.FieldName = "TypeName"
        Me.fieldTypeName5.Name = "fieldTypeName5"
        '
        'fieldUnit5
        '
        Me.fieldUnit5.AreaIndex = 5
        Me.fieldUnit5.FieldName = "Unit"
        Me.fieldUnit5.Name = "fieldUnit5"
        '
        'fieldQty5
        '
        Me.fieldQty5.AreaIndex = 6
        Me.fieldQty5.FieldName = "Qty"
        Me.fieldQty5.Name = "fieldQty5"
        '
        'fieldWeight5
        '
        Me.fieldWeight5.AreaIndex = 7
        Me.fieldWeight5.FieldName = "Weight"
        Me.fieldWeight5.Name = "fieldWeight5"
        '
        'fieldPrice5
        '
        Me.fieldPrice5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPrice5.AreaIndex = 0
        Me.fieldPrice5.FieldName = "Price"
        Me.fieldPrice5.Name = "fieldPrice5"
        '
        'PivotGridControl4
        '
        Me.PivotGridControl4.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl4.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID4, Me.fieldHenHouseID4, Me.fieldHenHouseName4, Me.fieldProductionType4, Me.fieldInventoryID4, Me.fieldInventoryName4, Me.fieldTypeName4, Me.fieldUnit4, Me.fieldQty4, Me.fieldWeight4, Me.fieldPrice4})
        Me.PivotGridControl4.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl4.Name = "PivotGridControl4"
        Me.PivotGridControl4.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl4.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl4.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl4.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl4.Prefilter.CriteriaString = "[fieldProductionType4] = 'Biaya Penyusutan'"
        Me.PivotGridControl4.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl4.TabIndex = 12
        '
        'fieldProductionID4
        '
        Me.fieldProductionID4.AreaIndex = 0
        Me.fieldProductionID4.FieldName = "ProductionID"
        Me.fieldProductionID4.Name = "fieldProductionID4"
        '
        'fieldHenHouseID4
        '
        Me.fieldHenHouseID4.AreaIndex = 2
        Me.fieldHenHouseID4.FieldName = "HenHouseID"
        Me.fieldHenHouseID4.Name = "fieldHenHouseID4"
        '
        'fieldHenHouseName4
        '
        Me.fieldHenHouseName4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName4.AreaIndex = 0
        Me.fieldHenHouseName4.FieldName = "HenHouseName"
        Me.fieldHenHouseName4.Name = "fieldHenHouseName4"
        '
        'fieldProductionType4
        '
        Me.fieldProductionType4.AreaIndex = 3
        Me.fieldProductionType4.FieldName = "ProductionType"
        Me.fieldProductionType4.Name = "fieldProductionType4"
        '
        'fieldInventoryID4
        '
        Me.fieldInventoryID4.AreaIndex = 4
        Me.fieldInventoryID4.FieldName = "InventoryID"
        Me.fieldInventoryID4.Name = "fieldInventoryID4"
        '
        'fieldInventoryName4
        '
        Me.fieldInventoryName4.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName4.AreaIndex = 1
        Me.fieldInventoryName4.FieldName = "InventoryName"
        Me.fieldInventoryName4.Name = "fieldInventoryName4"
        '
        'fieldTypeName4
        '
        Me.fieldTypeName4.AreaIndex = 5
        Me.fieldTypeName4.FieldName = "TypeName"
        Me.fieldTypeName4.Name = "fieldTypeName4"
        '
        'fieldUnit4
        '
        Me.fieldUnit4.AreaIndex = 7
        Me.fieldUnit4.FieldName = "Unit"
        Me.fieldUnit4.Name = "fieldUnit4"
        '
        'fieldQty4
        '
        Me.fieldQty4.AreaIndex = 6
        Me.fieldQty4.FieldName = "Qty"
        Me.fieldQty4.Name = "fieldQty4"
        '
        'fieldWeight4
        '
        Me.fieldWeight4.AreaIndex = 1
        Me.fieldWeight4.FieldName = "Weight"
        Me.fieldWeight4.Name = "fieldWeight4"
        '
        'fieldPrice4
        '
        Me.fieldPrice4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPrice4.AreaIndex = 0
        Me.fieldPrice4.FieldName = "Price"
        Me.fieldPrice4.Name = "fieldPrice4"
        '
        'PivotGridControl3
        '
        Me.PivotGridControl3.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl3.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID3, Me.fieldHenHouseID3, Me.fieldHenHouseName3, Me.fieldProductionType3, Me.fieldInventoryID3, Me.fieldInventoryName3, Me.fieldTypeName3, Me.fieldUnit3, Me.fieldQty3, Me.fieldWeight3, Me.fieldPrice3})
        Me.PivotGridControl3.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl3.Name = "PivotGridControl3"
        Me.PivotGridControl3.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PivotGridControl3.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl3.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl3.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl3.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl3.Prefilter.CriteriaString = "[fieldProductionType3] = 'Biaya VOV'"
        Me.PivotGridControl3.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl3.TabIndex = 11
        '
        'fieldProductionID3
        '
        Me.fieldProductionID3.AreaIndex = 0
        Me.fieldProductionID3.FieldName = "ProductionID"
        Me.fieldProductionID3.Name = "fieldProductionID3"
        '
        'fieldHenHouseID3
        '
        Me.fieldHenHouseID3.AreaIndex = 1
        Me.fieldHenHouseID3.FieldName = "HenHouseID"
        Me.fieldHenHouseID3.Name = "fieldHenHouseID3"
        '
        'fieldHenHouseName3
        '
        Me.fieldHenHouseName3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName3.AreaIndex = 0
        Me.fieldHenHouseName3.FieldName = "HenHouseName"
        Me.fieldHenHouseName3.Name = "fieldHenHouseName3"
        '
        'fieldProductionType3
        '
        Me.fieldProductionType3.AreaIndex = 2
        Me.fieldProductionType3.FieldName = "ProductionType"
        Me.fieldProductionType3.Name = "fieldProductionType3"
        '
        'fieldInventoryID3
        '
        Me.fieldInventoryID3.AreaIndex = 3
        Me.fieldInventoryID3.FieldName = "InventoryID"
        Me.fieldInventoryID3.Name = "fieldInventoryID3"
        '
        'fieldInventoryName3
        '
        Me.fieldInventoryName3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName3.AreaIndex = 1
        Me.fieldInventoryName3.FieldName = "InventoryName"
        Me.fieldInventoryName3.Name = "fieldInventoryName3"
        '
        'fieldTypeName3
        '
        Me.fieldTypeName3.AreaIndex = 4
        Me.fieldTypeName3.FieldName = "TypeName"
        Me.fieldTypeName3.Name = "fieldTypeName3"
        '
        'fieldUnit3
        '
        Me.fieldUnit3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldUnit3.AreaIndex = 0
        Me.fieldUnit3.FieldName = "Unit"
        Me.fieldUnit3.Name = "fieldUnit3"
        '
        'fieldQty3
        '
        Me.fieldQty3.AreaIndex = 5
        Me.fieldQty3.FieldName = "Qty"
        Me.fieldQty3.Name = "fieldQty3"
        '
        'fieldWeight3
        '
        Me.fieldWeight3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldWeight3.AreaIndex = 1
        Me.fieldWeight3.FieldName = "Weight"
        Me.fieldWeight3.Name = "fieldWeight3"
        '
        'fieldPrice3
        '
        Me.fieldPrice3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPrice3.AreaIndex = 2
        Me.fieldPrice3.FieldName = "Price"
        Me.fieldPrice3.Name = "fieldPrice3"
        '
        'PivotGridControl2
        '
        Me.PivotGridControl2.Appearance.Cell.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl2.Appearance.Cell.Options.UseFont = True
        Me.PivotGridControl2.Appearance.ColumnHeaderArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl2.Appearance.ColumnHeaderArea.Options.UseFont = True
        Me.PivotGridControl2.Appearance.DataHeaderArea.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl2.Appearance.DataHeaderArea.Options.UseFont = True
        Me.PivotGridControl2.Appearance.FieldHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.PivotGridControl2.Appearance.FieldHeader.Options.UseFont = True
        Me.PivotGridControl2.Appearance.FieldValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PivotGridControl2.Appearance.FieldValue.Options.UseFont = True
        Me.PivotGridControl2.Appearance.HeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PivotGridControl2.Appearance.HeaderArea.Options.UseFont = True
        Me.PivotGridControl2.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PivotGridControl2.Appearance.RowHeaderArea.Options.UseFont = True
        Me.PivotGridControl2.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl2.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID2, Me.fieldHenHouseID2, Me.fieldHenHouseName2, Me.fieldProductionType2, Me.fieldInventoryID2, Me.fieldInventoryName2, Me.fieldTypeName2, Me.fieldUnit2, Me.fieldQty2, Me.fieldWeight2, Me.fieldPrice2})
        Me.PivotGridControl2.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl2.Name = "PivotGridControl2"
        Me.PivotGridControl2.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PivotGridControl2.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl2.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl2.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl2.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl2.Prefilter.CriteriaString = "[fieldProductionType2] = 'Biaya Pakan'"
        Me.PivotGridControl2.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl2.TabIndex = 10
        '
        'fieldProductionID2
        '
        Me.fieldProductionID2.AreaIndex = 0
        Me.fieldProductionID2.FieldName = "ProductionID"
        Me.fieldProductionID2.Name = "fieldProductionID2"
        '
        'fieldHenHouseID2
        '
        Me.fieldHenHouseID2.AreaIndex = 1
        Me.fieldHenHouseID2.FieldName = "HenHouseID"
        Me.fieldHenHouseID2.Name = "fieldHenHouseID2"
        '
        'fieldHenHouseName2
        '
        Me.fieldHenHouseName2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName2.AreaIndex = 0
        Me.fieldHenHouseName2.FieldName = "HenHouseName"
        Me.fieldHenHouseName2.Name = "fieldHenHouseName2"
        '
        'fieldProductionType2
        '
        Me.fieldProductionType2.AreaIndex = 2
        Me.fieldProductionType2.FieldName = "ProductionType"
        Me.fieldProductionType2.Name = "fieldProductionType2"
        '
        'fieldInventoryID2
        '
        Me.fieldInventoryID2.AreaIndex = 3
        Me.fieldInventoryID2.FieldName = "InventoryID"
        Me.fieldInventoryID2.Name = "fieldInventoryID2"
        '
        'fieldInventoryName2
        '
        Me.fieldInventoryName2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName2.AreaIndex = 1
        Me.fieldInventoryName2.FieldName = "InventoryName"
        Me.fieldInventoryName2.Name = "fieldInventoryName2"
        '
        'fieldTypeName2
        '
        Me.fieldTypeName2.AreaIndex = 4
        Me.fieldTypeName2.FieldName = "TypeName"
        Me.fieldTypeName2.Name = "fieldTypeName2"
        '
        'fieldUnit2
        '
        Me.fieldUnit2.AreaIndex = 5
        Me.fieldUnit2.FieldName = "Unit"
        Me.fieldUnit2.Name = "fieldUnit2"
        '
        'fieldQty2
        '
        Me.fieldQty2.AreaIndex = 6
        Me.fieldQty2.FieldName = "Qty"
        Me.fieldQty2.Name = "fieldQty2"
        '
        'fieldWeight2
        '
        Me.fieldWeight2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldWeight2.AreaIndex = 0
        Me.fieldWeight2.FieldName = "Weight"
        Me.fieldWeight2.Name = "fieldWeight2"
        '
        'fieldPrice2
        '
        Me.fieldPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldPrice2.AreaIndex = 1
        Me.fieldPrice2.FieldName = "Price"
        Me.fieldPrice2.Name = "fieldPrice2"
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
        Me.PivotGridControl1.DataSource = Me.Sp_PD_HPP_GetDailyDetailBindingSource
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductionID1, Me.fieldHenHouseID1, Me.fieldHenHouseName1, Me.fieldProductionType1, Me.fieldInventoryID1, Me.fieldInventoryName1, Me.fieldTypeName1, Me.fieldUnit1, Me.fieldQty1, Me.fieldWeight1, Me.fieldPrice1})
        Me.PivotGridControl1.Location = New System.Drawing.Point(27, 171)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsCustomization.AllowPrefilter = False
        Me.PivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = False
        Me.PivotGridControl1.OptionsView.ShowColumnHeaders = False
        Me.PivotGridControl1.OptionsView.ShowDataHeaders = False
        Me.PivotGridControl1.OptionsView.ShowFilterHeaders = False
        Me.PivotGridControl1.OptionsView.ShowRowHeaders = False
        Me.PivotGridControl1.Prefilter.CriteriaString = "[fieldProductionType1] = 'Produksi Telur'"
        Me.PivotGridControl1.Size = New System.Drawing.Size(499, 264)
        Me.PivotGridControl1.TabIndex = 9
        '
        'fieldProductionID1
        '
        Me.fieldProductionID1.AreaIndex = 0
        Me.fieldProductionID1.FieldName = "ProductionID"
        Me.fieldProductionID1.Name = "fieldProductionID1"
        '
        'fieldHenHouseID1
        '
        Me.fieldHenHouseID1.AreaIndex = 1
        Me.fieldHenHouseID1.FieldName = "HenHouseID"
        Me.fieldHenHouseID1.Name = "fieldHenHouseID1"
        '
        'fieldHenHouseName1
        '
        Me.fieldHenHouseName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldHenHouseName1.AreaIndex = 0
        Me.fieldHenHouseName1.FieldName = "HenHouseName"
        Me.fieldHenHouseName1.Name = "fieldHenHouseName1"
        '
        'fieldProductionType1
        '
        Me.fieldProductionType1.AreaIndex = 2
        Me.fieldProductionType1.FieldName = "ProductionType"
        Me.fieldProductionType1.Name = "fieldProductionType1"
        Me.fieldProductionType1.Options.ShowInPrefilter = False
        '
        'fieldInventoryID1
        '
        Me.fieldInventoryID1.AreaIndex = 3
        Me.fieldInventoryID1.FieldName = "InventoryID"
        Me.fieldInventoryID1.Name = "fieldInventoryID1"
        '
        'fieldInventoryName1
        '
        Me.fieldInventoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldInventoryName1.AreaIndex = 1
        Me.fieldInventoryName1.FieldName = "InventoryName"
        Me.fieldInventoryName1.Name = "fieldInventoryName1"
        '
        'fieldTypeName1
        '
        Me.fieldTypeName1.AreaIndex = 4
        Me.fieldTypeName1.FieldName = "TypeName"
        Me.fieldTypeName1.Name = "fieldTypeName1"
        '
        'fieldUnit1
        '
        Me.fieldUnit1.AreaIndex = 6
        Me.fieldUnit1.FieldName = "Unit"
        Me.fieldUnit1.Name = "fieldUnit1"
        '
        'fieldQty1
        '
        Me.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldQty1.AreaIndex = 0
        Me.fieldQty1.FieldName = "Qty"
        Me.fieldQty1.Name = "fieldQty1"
        '
        'fieldWeight1
        '
        Me.fieldWeight1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldWeight1.AreaIndex = 1
        Me.fieldWeight1.FieldName = "Weight"
        Me.fieldWeight1.Name = "fieldWeight1"
        '
        'fieldPrice1
        '
        Me.fieldPrice1.AreaIndex = 5
        Me.fieldPrice1.FieldName = "Price"
        Me.fieldPrice1.Name = "fieldPrice1"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(122, 12)
        Me.TextEdit1.MenuManager = Me.RibbonControl
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(419, 28)
        Me.TextEdit1.StyleController = Me.LC_Detail
        Me.TextEdit1.TabIndex = 6
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(122, 76)
        Me.LookUpEdit1.MenuManager = Me.RibbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.SpPDMDHenHouseGetDataBindingSource
        Me.LookUpEdit1.Size = New System.Drawing.Size(419, 28)
        Me.LookUpEdit1.StyleController = Me.LC_Detail
        Me.LookUpEdit1.TabIndex = 4
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl1.Size = New System.Drawing.Size(969, 116)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "New"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Delete"
        Me.BarButtonItem2.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Refresh"
        Me.BarButtonItem3.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Close"
        Me.BarButtonItem4.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem4.Glyph = CType(resources.GetObject("BarButtonItem4.Glyph"), System.Drawing.Image)
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.LargeGlyph = CType(resources.GetObject("BarButtonItem4.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Back"
        Me.BarButtonItem5.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem5.Glyph = CType(resources.GetObject("BarButtonItem5.Glyph"), System.Drawing.Image)
        Me.BarButtonItem5.Id = 5
        Me.BarButtonItem5.LargeGlyph = CType(resources.GetObject("BarButtonItem5.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Save"
        Me.BarButtonItem6.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 6
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup7})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.RibbonPageGroup9, Me.RibbonPageGroup10})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Process"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem5)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 686)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(969, 27)
        '
        'SpPDMDHenHouseGetDataBindingSource
        '
        Me.SpPDMDHenHouseGetDataBindingSource.DataMember = "sp_PD_MDHenHouse_GetData"
        Me.SpPDMDHenHouseGetDataBindingSource.DataSource = Me.DataSet
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(122, 44)
        Me.DateEdit1.MenuManager = Me.RibbonControl2
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(419, 28)
        Me.DateEdit1.StyleController = Me.LC_Detail
        Me.DateEdit1.TabIndex = 5
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.BarButtonItem12})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 7
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.RibbonControl2.Size = New System.Drawing.Size(969, 116)
        Me.RibbonControl2.StatusBar = Me.RibbonStatusBar2
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "New"
        Me.BarButtonItem7.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 1
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Delete"
        Me.BarButtonItem8.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 2
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Refresh"
        Me.BarButtonItem9.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem9.Glyph = CType(resources.GetObject("BarButtonItem9.Glyph"), System.Drawing.Image)
        Me.BarButtonItem9.Id = 3
        Me.BarButtonItem9.LargeGlyph = CType(resources.GetObject("BarButtonItem9.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Close"
        Me.BarButtonItem10.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem10.Glyph = CType(resources.GetObject("BarButtonItem10.Glyph"), System.Drawing.Image)
        Me.BarButtonItem10.Id = 4
        Me.BarButtonItem10.LargeGlyph = CType(resources.GetObject("BarButtonItem10.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Back"
        Me.BarButtonItem11.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
        Me.BarButtonItem11.Id = 5
        Me.BarButtonItem11.LargeGlyph = CType(resources.GetObject("BarButtonItem11.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Save"
        Me.BarButtonItem12.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem12.Glyph = CType(resources.GetObject("BarButtonItem12.Glyph"), System.Drawing.Image)
        Me.BarButtonItem12.Id = 6
        Me.BarButtonItem12.LargeGlyph = CType(resources.GetObject("BarButtonItem12.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup11, Me.RibbonPageGroup12})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Home"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.BarButtonItem9)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup13, Me.RibbonPageGroup14, Me.RibbonPageGroup15})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Process"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.BarButtonItem11)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.BarButtonItem12)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.ItemLinks.Add(Me.BarButtonItem8)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.ItemLinks.Add(Me.BarButtonItem10)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        '
        'RibbonStatusBar2
        '
        Me.RibbonStatusBar2.Location = New System.Drawing.Point(0, 686)
        Me.RibbonStatusBar2.Name = "RibbonStatusBar2"
        Me.RibbonStatusBar2.Ribbon = Me.RibbonControl2
        Me.RibbonStatusBar2.Size = New System.Drawing.Size(969, 27)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.TabbedControlGroup1, Me.LayoutControlItem10, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(957, 462)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LookUpEdit1
        Me.LayoutControlItem1.CustomizationFormText = "Kandang :"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(533, 32)
        Me.LayoutControlItem1.Text = "Kandang :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(107, 21)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.DateEdit1
        Me.LayoutControlItem2.CustomizationFormText = "Tgl. Produksi :"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(533, 32)
        Me.LayoutControlItem2.Text = "Tgl. Produksi :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(107, 21)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.TextEdit1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(533, 32)
        Me.LayoutControlItem3.Text = "No. Produksi :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(107, 21)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 122)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup8
        Me.TabbedControlGroup1.SelectedTabPageIndex = 5
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(533, 320)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6, Me.LayoutControlGroup7, Me.LayoutControlGroup8})
        '
        'LayoutControlGroup8
        '
        Me.LayoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem9})
        Me.LayoutControlGroup8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup8.Name = "LayoutControlGroup8"
        Me.LayoutControlGroup8.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup8.Text = "Biaya Lain Lain"
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.PivotGridControl6
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem9.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup3.Text = "Produksi Telur"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.PivotGridControl1
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem6.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup4.Text = "Biaya Pakan"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.PivotGridControl2
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup5.Text = "Biaya VOV"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.PivotGridControl3
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem4.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlGroup6
        '
        Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
        Me.LayoutControlGroup6.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup6.Text = "Biaya Penyusutan"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.PivotGridControl4
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup7
        '
        Me.LayoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8})
        Me.LayoutControlGroup7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup7.Name = "LayoutControlGroup7"
        Me.LayoutControlGroup7.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlGroup7.Text = "Biaya Over Head"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.PivotGridControl5
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem8.Size = New System.Drawing.Size(509, 274)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PivotGridControl7
        Me.LayoutControlItem10.Location = New System.Drawing.Point(533, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem10.Size = New System.Drawing.Size(404, 442)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 96)
        Me.EmptySpaceItem1.MaxSize = New System.Drawing.Size(533, 26)
        Me.EmptySpaceItem1.MinSize = New System.Drawing.Size(533, 26)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(533, 26)
        Me.EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'LC_Header
        '
        Me.LC_Header.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LC_Header.Appearance.Control.Options.UseFont = True
        Me.LC_Header.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LC_Header.Location = New System.Drawing.Point(0, 0)
        Me.LC_Header.Name = "LC_Header"
        Me.LC_Header.Padding = New System.Windows.Forms.Padding(5)
        Me.LC_Header.Root = Me.LayoutControlGroup2
        Me.LC_Header.Size = New System.Drawing.Size(957, 462)
        Me.LC_Header.TabIndex = 5
        Me.LC_Header.Text = "LayoutControl1"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(957, 462)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_PD_MDHenHouse_GetDataTableAdapter
        '
        Me.Sp_PD_MDHenHouse_GetDataTableAdapter.ClearBeforeFill = True
        '
        'NavigationFrame1
        '
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage1)
        Me.NavigationFrame1.Controls.Add(Me.NavigationPage2)
        Me.NavigationFrame1.Location = New System.Drawing.Point(0, 149)
        Me.NavigationFrame1.Name = "NavigationFrame1"
        Me.NavigationFrame1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPage() {Me.NavigationPage1, Me.NavigationPage2})
        Me.NavigationFrame1.SelectedPage = Me.NavigationPage1
        Me.NavigationFrame1.SelectedPageIndex = 1
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
        'Sp_PD_HPP_GetDailyDetailTableAdapter
        '
        Me.Sp_PD_HPP_GetDailyDetailTableAdapter.ClearBeforeFill = True
        '
        'Sp_PD_HPP_GetDataTableAdapter
        '
        Me.Sp_PD_HPP_GetDataTableAdapter.ClearBeforeFill = True
        '
        'Frm_PD_HPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 713)
        Me.Controls.Add(Me.NavigationFrame1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "Frm_PD_HPP"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Transaksi Pakan Harian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LC_Detail.ResumeLayout(False)
        CType(Me.PivotGridControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDHPPGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PD_HPP_GetDailyDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPDMDHenHouseGetDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LC_Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LC_Header As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents DataSet As ALA_FarmProduction.DataSet
    Friend WithEvents TableAdapterManager As ALA_FarmProduction.DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QueriesTableAdapter As ALA_FarmProduction.DataSetTableAdapters.QueriesTableAdapter
    Friend WithEvents SpPDMDHenHouseGetDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sp_PD_MDHenHouse_GetDataTableAdapter As ALA_FarmProduction.DataSetTableAdapters.sp_PD_MDHenHouse_GetDataTableAdapter
    Friend WithEvents NavigationFrame1 As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar2 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents Sp_PD_HPP_GetDailyDetailBindingSource As BindingSource
    Friend WithEvents Sp_PD_HPP_GetDailyDetailTableAdapter As DataSetTableAdapters.sp_PD_HPP_GetDailyDetailTableAdapter
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldProductionID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl2 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents fieldProductionID2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice2 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridControl6 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridControl5 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridControl4 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents PivotGridControl3 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup8 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents fieldProductionID6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice6 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionID5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice5 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionID4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice4 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionID3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseID3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionType3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryID3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldInventoryName3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldTypeName3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldUnit3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQty3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldWeight3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldPrice3 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents PivotGridControl7 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SpPDHPPGetDataBindingSource As BindingSource
    Friend WithEvents fieldHenHouseID7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHenHouseName7 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHPPAccountName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldHPPValue1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents Sp_PD_HPP_GetDataTableAdapter As DataSetTableAdapters.sp_PD_HPP_GetDataTableAdapter
End Class
