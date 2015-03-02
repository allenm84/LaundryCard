namespace LaundryCard
{
  partial class EditEntryDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEntryDialog));
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.cboDate = new DevExpress.XtraEditors.DateEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.numAmount = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtNotes = new DevExpress.XtraEditors.MemoEdit();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.numQuantity = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.okCancelButtons1 = new LaundryCard.OKCancelButtons();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQuantity.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.numQuantity);
      this.layoutControl1.Controls.Add(this.txtNotes);
      this.layoutControl1.Controls.Add(this.numAmount);
      this.layoutControl1.Controls.Add(this.cboDate);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(562, 140, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(276, 349);
      this.layoutControl1.TabIndex = 1;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlItem5});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(276, 349);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // cboDate
      // 
      this.cboDate.EditValue = null;
      this.cboDate.Location = new System.Drawing.Point(24, 142);
      this.cboDate.Name = "cboDate";
      this.cboDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboDate.Size = new System.Drawing.Size(228, 20);
      this.cboDate.StyleController = this.layoutControl1;
      this.cboDate.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboDate;
      this.layoutControlItem1.CustomizationFormText = "Date:";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(232, 40);
      this.layoutControlItem1.Text = "Date:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(46, 13);
      // 
      // numAmount
      // 
      this.numAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numAmount.Location = new System.Drawing.Point(24, 182);
      this.numAmount.Name = "numAmount";
      this.numAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numAmount.Size = new System.Drawing.Size(228, 20);
      this.numAmount.StyleController = this.layoutControl1;
      this.numAmount.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numAmount;
      this.layoutControlItem2.CustomizationFormText = "Amount:";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(232, 40);
      this.layoutControlItem2.Text = "Amount:";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(46, 13);
      // 
      // txtNotes
      // 
      this.txtNotes.Location = new System.Drawing.Point(24, 222);
      this.txtNotes.Name = "txtNotes";
      this.txtNotes.Size = new System.Drawing.Size(228, 73);
      this.txtNotes.StyleController = this.layoutControl1;
      this.txtNotes.TabIndex = 6;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.txtNotes;
      this.layoutControlItem3.CustomizationFormText = "Notes:";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(232, 93);
      this.layoutControlItem3.Text = "Notes:";
      this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(46, 13);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Entry settings";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem2});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 83);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(256, 216);
      this.layoutControlGroup2.Text = "Entry settings";
      // 
      // numQuantity
      // 
      this.numQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numQuantity.Location = new System.Drawing.Point(24, 59);
      this.numQuantity.Name = "numQuantity";
      this.numQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numQuantity.Size = new System.Drawing.Size(228, 20);
      this.numQuantity.StyleController = this.layoutControl1;
      this.numQuantity.TabIndex = 7;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.numQuantity;
      this.layoutControlItem4.CustomizationFormText = "Quantity:";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(232, 40);
      this.layoutControlItem4.Text = "Quantity:";
      this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(46, 13);
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Number of entries to create";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(256, 83);
      this.layoutControlGroup3.Text = "Number of entries to create";
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 311);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(252, 26);
      this.okCancelButtons1.TabIndex = 8;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.okCancelButtons1;
      this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 299);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(256, 30);
      this.layoutControlItem5.Text = "layoutControlItem5";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // EditEntryDialog
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(276, 349);
      this.Controls.Add(this.layoutControl1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditEntryDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "EditEntryDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAmount.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numQuantity.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.DateEdit cboDate;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SpinEdit numAmount;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.MemoEdit txtNotes;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.SpinEdit numQuantity;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;

  }
}