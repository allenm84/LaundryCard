using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraLayout;

namespace LaundryCard
{
  public static class DevExpressExtensions
  {
    public static bool GetIsVisible(this BaseLayoutItem item)
    {
      return (item.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Always);
    }

    public static void SetIsVisible(this BaseLayoutItem item, bool visible)
    {
      item.Visibility = visible
        ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
    }

    public static void SetEnabled(this Bar bar, bool enabled)
    {
      ((DockedBarControl)(((IDockableObject)bar).BarControl)).Enabled = enabled;
    }

    public static void SetMinMax(this SpinEdit edit)
    {
      edit.Properties.MinValue = decimal.MinValue + 1;
      edit.Properties.MaxValue = decimal.MaxValue - 1;
    }

    public static void FillWithEnum<T>(this LookUpEdit lookUp, Func<T, string> getText = null)
    {
      lookUp.Properties.FillWithEnum(getText);
    }

    public static void FillWithEnum<T>(this RepositoryItemLookUpEdit lookUp, Func<T, string> getText = null)
    {
      if (getText == null)
      {
        getText = (x) => x.ToString();
      }

      var values = (T[])Enum.GetValues(typeof(T));
      lookUp.DataSource = values
        .Select(v => new { Value = v, Display = getText(v) })
        .ToArray();
      lookUp.DisplayMember = "Display";
      lookUp.ValueMember = "Value";
      lookUp.ShowHeader = false;
      lookUp.Columns.Add(new LookUpColumnInfo("Display")
      {
        Visible = true,
        SortOrder = ColumnSortOrder.Ascending
      });
    }
  }
}
