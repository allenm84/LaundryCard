using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace LaundryCard
{
  public partial class EditSettingsDialog : BaseForm
  {
    public EditSettingsDialog()
    {
      InitializeComponent();
    }

    public void BindTo(ApplicationSettings settings)
    {
      propertyGridControl1.SelectedObject = settings;
    }
  }
}
