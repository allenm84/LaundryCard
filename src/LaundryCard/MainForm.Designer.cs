namespace LaundryCard
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbCopy = new DevExpress.XtraBars.BarButtonItem();
      this.tbbPaste = new DevExpress.XtraBars.BarButtonItem();
      this.tbbDeposit = new DevExpress.XtraBars.BarButtonItem();
      this.tbbWithdraw = new DevExpress.XtraBars.BarButtonItem();
      this.tbbWasher = new DevExpress.XtraBars.BarButtonItem();
      this.tbbDryer = new DevExpress.XtraBars.BarButtonItem();
      this.tbbEdit = new DevExpress.XtraBars.BarButtonItem();
      this.tbbDate = new DevExpress.XtraBars.BarButtonItem();
      this.tbbSettings = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridEntries = new DevExpress.XtraGrid.GridControl();
      this.entrySource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewEntries = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colExtensionData = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboEntryTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridEntries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entrySource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEntries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboEntryTypes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbCopy,
            this.tbbPaste,
            this.tbbDeposit,
            this.tbbWithdraw,
            this.tbbWasher,
            this.tbbDryer,
            this.tbbEdit,
            this.tbbDate,
            this.tbbSettings});
      this.barManager1.MaxItemId = 10;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tbbSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.tbbCopy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.tbbPaste),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbDeposit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbWithdraw, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbWasher, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbDryer, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbDate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSettings, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableClose = true;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.Glyph")));
      this.tbbSave.Id = 0;
      this.tbbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.LargeGlyph")));
      this.tbbSave.Name = "tbbSave";
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
      // 
      // tbbCopy
      // 
      this.tbbCopy.Caption = "Copy";
      this.tbbCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbCopy.Glyph")));
      this.tbbCopy.Id = 1;
      this.tbbCopy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbCopy.LargeGlyph")));
      this.tbbCopy.Name = "tbbCopy";
      this.tbbCopy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbCopy_ItemClick);
      // 
      // tbbPaste
      // 
      this.tbbPaste.Caption = "Paste";
      this.tbbPaste.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbPaste.Glyph")));
      this.tbbPaste.Id = 2;
      this.tbbPaste.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbPaste.LargeGlyph")));
      this.tbbPaste.Name = "tbbPaste";
      this.tbbPaste.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbPaste_ItemClick);
      // 
      // tbbDeposit
      // 
      this.tbbDeposit.Caption = "Deposit";
      this.tbbDeposit.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbDeposit.Glyph")));
      this.tbbDeposit.Id = 3;
      this.tbbDeposit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbDeposit.LargeGlyph")));
      this.tbbDeposit.Name = "tbbDeposit";
      this.tbbDeposit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbDeposit_ItemClick);
      // 
      // tbbWithdraw
      // 
      this.tbbWithdraw.Caption = "Withdraw";
      this.tbbWithdraw.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbWithdraw.Glyph")));
      this.tbbWithdraw.Id = 4;
      this.tbbWithdraw.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbWithdraw.LargeGlyph")));
      this.tbbWithdraw.Name = "tbbWithdraw";
      this.tbbWithdraw.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbWithdraw_ItemClick);
      // 
      // tbbWasher
      // 
      this.tbbWasher.Caption = "Washer";
      this.tbbWasher.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbWasher.Glyph")));
      this.tbbWasher.Id = 5;
      this.tbbWasher.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbWasher.LargeGlyph")));
      this.tbbWasher.Name = "tbbWasher";
      this.tbbWasher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbWasher_ItemClick);
      // 
      // tbbDryer
      // 
      this.tbbDryer.Caption = "Dryer";
      this.tbbDryer.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbDryer.Glyph")));
      this.tbbDryer.Id = 6;
      this.tbbDryer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbDryer.LargeGlyph")));
      this.tbbDryer.Name = "tbbDryer";
      this.tbbDryer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbDryer_ItemClick);
      // 
      // tbbEdit
      // 
      this.tbbEdit.Caption = "Edit";
      this.tbbEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbEdit.Glyph")));
      this.tbbEdit.Id = 7;
      this.tbbEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbEdit.LargeGlyph")));
      this.tbbEdit.Name = "tbbEdit";
      this.tbbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbEdit_ItemClick);
      // 
      // tbbDate
      // 
      this.tbbDate.Caption = "Date";
      this.tbbDate.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbDate.Glyph")));
      this.tbbDate.Id = 8;
      this.tbbDate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbDate.LargeGlyph")));
      this.tbbDate.Name = "tbbDate";
      this.tbbDate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbDate_ItemClick);
      // 
      // tbbSettings
      // 
      this.tbbSettings.Caption = "Settings";
      this.tbbSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSettings.Glyph")));
      this.tbbSettings.Id = 9;
      this.tbbSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSettings.LargeGlyph")));
      this.tbbSettings.Name = "tbbSettings";
      this.tbbSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSettings_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(599, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 303);
      this.barDockControlBottom.Size = new System.Drawing.Size(599, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 272);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(599, 31);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 272);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridEntries);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(599, 272);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridEntries
      // 
      this.gridEntries.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridEntries.DataSource = this.entrySource;
      this.gridEntries.Location = new System.Drawing.Point(12, 12);
      this.gridEntries.MainView = this.gridViewEntries;
      this.gridEntries.MenuManager = this.barManager1;
      this.gridEntries.Name = "gridEntries";
      this.gridEntries.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboEntryTypes});
      this.gridEntries.Size = new System.Drawing.Size(575, 248);
      this.gridEntries.TabIndex = 4;
      this.gridEntries.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntries});
      this.gridEntries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridEntries_MouseDoubleClick);
      // 
      // entrySource
      // 
      this.entrySource.DataSource = typeof(LaundryCard.LaundryCardEntry);
      // 
      // gridViewEntries
      // 
      this.gridViewEntries.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExtensionData,
            this.colID,
            this.colDate,
            this.colType,
            this.colAmount,
            this.colNotes});
      this.gridViewEntries.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewEntries.GridControl = this.gridEntries;
      this.gridViewEntries.GroupFormat = "[#image]{1} {2}";
      this.gridViewEntries.Name = "gridViewEntries";
      this.gridViewEntries.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewEntries.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewEntries.OptionsBehavior.Editable = false;
      this.gridViewEntries.OptionsBehavior.ReadOnly = true;
      this.gridViewEntries.OptionsMenu.EnableFooterMenu = false;
      this.gridViewEntries.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewEntries.OptionsSelection.MultiSelect = true;
      this.gridViewEntries.OptionsView.ShowColumnHeaders = false;
      this.gridViewEntries.OptionsView.ShowFooter = true;
      this.gridViewEntries.OptionsView.ShowGroupPanel = false;
      this.gridViewEntries.OptionsView.ShowIndicator = false;
      this.gridViewEntries.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewEntries.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewEntries_SelectionChanged);
      this.gridViewEntries.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewEntries_KeyDown);
      // 
      // colExtensionData
      // 
      this.colExtensionData.FieldName = "ExtensionData";
      this.colExtensionData.Name = "colExtensionData";
      // 
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // colDate
      // 
      this.colDate.AppearanceCell.Options.UseTextOptions = true;
      this.colDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.colDate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.colDate.FieldName = "Date";
      this.colDate.Name = "colDate";
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 0;
      this.colDate.Width = 143;
      // 
      // colType
      // 
      this.colType.AppearanceCell.Options.UseTextOptions = true;
      this.colType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colType.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.colType.ColumnEdit = this.cboEntryTypes;
      this.colType.FieldName = "Type";
      this.colType.MaxWidth = 100;
      this.colType.MinWidth = 100;
      this.colType.Name = "colType";
      this.colType.OptionsColumn.AllowSize = false;
      this.colType.Visible = true;
      this.colType.VisibleIndex = 1;
      this.colType.Width = 100;
      // 
      // cboEntryTypes
      // 
      this.cboEntryTypes.AutoHeight = false;
      this.cboEntryTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboEntryTypes.Name = "cboEntryTypes";
      // 
      // colAmount
      // 
      this.colAmount.AppearanceCell.Options.UseTextOptions = true;
      this.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colAmount.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.colAmount.DisplayFormat.FormatString = "c2";
      this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colAmount.FieldName = "Amount";
      this.colAmount.MaxWidth = 80;
      this.colAmount.MinWidth = 80;
      this.colAmount.Name = "colAmount";
      this.colAmount.OptionsColumn.AllowSize = false;
      this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Card Balance: {0:c2}")});
      this.colAmount.Visible = true;
      this.colAmount.VisibleIndex = 2;
      this.colAmount.Width = 80;
      // 
      // colNotes
      // 
      this.colNotes.FieldName = "Notes";
      this.colNotes.Name = "colNotes";
      this.colNotes.Visible = true;
      this.colNotes.VisibleIndex = 3;
      this.colNotes.Width = 207;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(599, 272);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridEntries;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(579, 252);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // MainForm
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(599, 303);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Laundry Card";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridEntries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.entrySource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEntries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboEntryTypes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbCopy;
    private DevExpress.XtraBars.BarButtonItem tbbPaste;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraBars.BarButtonItem tbbDeposit;
    private DevExpress.XtraBars.BarButtonItem tbbWithdraw;
    private DevExpress.XtraBars.BarButtonItem tbbWasher;
    private DevExpress.XtraBars.BarButtonItem tbbDryer;
    private DevExpress.XtraBars.BarButtonItem tbbEdit;
    private DevExpress.XtraBars.BarButtonItem tbbDate;
    private DevExpress.XtraBars.BarButtonItem tbbSettings;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraGrid.GridControl gridEntries;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntries;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource entrySource;
    private DevExpress.XtraGrid.Columns.GridColumn colExtensionData;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colType;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    private DevExpress.XtraGrid.Columns.GridColumn colNotes;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboEntryTypes;
  }
}

