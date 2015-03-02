using System;
using System.Collections.Generic;
using System.Common.References;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryCard
{
  public partial class EditEntryDialog : BaseForm
  {
    private LaundryCardEntry dataSource;

    public bool AllowAmountEdit
    {
      get { return layoutControlItem2.GetIsVisible(); }
      set { layoutControlItem2.SetIsVisible(value); }
    }

    public bool AllowQuantityEdit
    {
      get { return layoutControlGroup3.GetIsVisible(); }
      set { layoutControlGroup3.SetIsVisible(value); }
    }

    public int Quantity
    {
      get { return (int)numQuantity.Value; }
      set
      {
        numQuantity.Value = Wolfram.Clamp(value,
          numQuantity.Properties.MinValue, 
          numQuantity.Properties.MaxValue);
      }
    }

    public EditEntryDialog()
    {
      InitializeComponent();
    }

    public void BindTo(LaundryCardEntry entry)
    {
      dataSource = entry;

      cboDate.DataBindings.Add("DateTime", dataSource, "Date");
      numAmount.DataBindings.Add("Value", dataSource, "Amount");
      txtNotes.DataBindings.Add("Text", dataSource, "Notes");
    }
  }
}
