using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaundryCard
{
  public partial class EditDateDialog : BaseForm
  {
    public DateTime Date
    {
      get { return cboDate.DateTime.Date; }
      set { cboDate.DateTime = value.Date; }
    }

    public EditDateDialog()
    {
      InitializeComponent();
    }
  }
}
