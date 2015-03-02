using System;
using System.Collections.Generic;
using System.Common.Extensions;
using System.Common.References;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using LaundryCard.Properties;

namespace LaundryCard
{
  public partial class MainForm : BaseForm, ISingleInstanceApplicationView
  {
    private List<LaundryCardEntry> clipboard;

    private IEnumerable<LaundryCardEntry> SelectedEntries
    {
      get
      {
        return gridViewEntries
                .GetSelectedRows()
                .Select(r => gridViewEntries.GetRow(r))
                .Cast<LaundryCardEntry>();
      }
    }

    public MainForm()
    {
      InitializeComponent();
      FinishGridInit();
    }

    private void FinishGridInit()
    {
      cboEntryTypes.FillWithEnum<LaundryCardEntryType>();
      colDate.SortIndex = 0;
      colDate.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
      colType.SortIndex = 1;
      colType.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
      colID.SortIndex = 2;
      colID.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
    }

    #region ISingleInstanceApplicationView Members

    public Form MainWindow { get { return this; } }

    public void StartupNextInstance(IList<string> commandLine)
    {
      this.BringToForeground();
    }

    public void Startup(IList<string> commandLine)
    {
      // do nothing really...
    }

    #endregion

    public void ShowError(string text)
    {
      MessageBox.Show(this, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void SetIsWorking(bool working)
    {
      bar1.SetEnabled(!working);
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      gridEntries.Enabled = !working;
    }

    private void UpdateCommands()
    {
      tbbEdit.Enabled = gridViewEntries.SelectedRowsCount == 1;
      tbbDate.Enabled = gridViewEntries.SelectedRowsCount > 0;
      tbbCopy.Enabled = gridViewEntries.SelectedRowsCount > 0;
      tbbPaste.Enabled = (clipboard != null) && (clipboard.Count > 0);
    }

    private bool IsEmpty(ApplicationSettings settings)
    {
      return settings.DryerCost == 0m || settings.WasherCost == 0m;
    }

    private bool IsCostSetup(LaundryCardEntryType type)
    {
      if (IsEmpty(SaveFile.Instance.Settings))
      {
        var msg = string.Format(Resources.IsCostSetupMessage, type);
        var result = MessageBox.Show(this, msg, type.ToString(),
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == System.Windows.Forms.DialogResult.No) return false;
      }
      else
      {
        return true;
      }

      // if we get here, it means the cost isn't setup and the user would like to do so
      DoEditSettings();

      // return if we're empty
      return !IsEmpty(SaveFile.Instance.Settings);
    }

    private void AddEntries(LaundryCardEntry entry, int quantity)
    {
      for (int i = 0; i < quantity; ++i)
      {
        var duplicate = entry.Duplicate();
        duplicate.ID = Duid.Next;
        entrySource.Add(duplicate);
      }
    }

    private async void DoLoad()
    {
      SetIsWorking(true);

      await Task.Run(() => LoadApplicationWork());
      LoadApplictionCompleted();

      SetIsWorking(false);
    }

    private void LoadApplicationWork()
    {
      SaveFile.Load();
    }

    private void LoadApplictionCompleted()
    {
      entrySource.DataSource = SaveFile.Instance.Entries;
      UpdateCommands();
    }

    private async void DoSave()
    {
      SetIsWorking(true);
      await Task.Run(() => SaveFile.Save());
      SetIsWorking(false);
    }

    private void DoAddDeposit()
    {
      var deposit = new LaundryCardEntry
      {
        Amount = 0,
        Date = DateTime.Today,
        ID = Duid.Next,
        Notes = "",
        Type = LaundryCardEntryType.Deposit,
      };

      using (EditEntryDialog dlg = new EditEntryDialog())
      {
        dlg.AllowAmountEdit = true;
        dlg.AllowQuantityEdit = false;
        dlg.Text = "Add Deposit";
        dlg.BindTo(deposit);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          entrySource.Add(deposit);
        }
      }
    }

    private void DoAddWithdrawal()
    {
      var deposit = new LaundryCardEntry
      {
        Amount = 0,
        Date = DateTime.Today,
        ID = Duid.Next,
        Notes = "",
        Type = LaundryCardEntryType.Withdrawal,
      };

      using (EditEntryDialog dlg = new EditEntryDialog())
      {
        dlg.AllowAmountEdit = true;
        dlg.AllowQuantityEdit = false;
        dlg.Text = "Add Withdrawal";
        dlg.BindTo(deposit);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          entrySource.Add(deposit);
        }
      }
    }

    private void DoAddEntries(LaundryCardEntryType type, Func<decimal> cost)
    {
      if (IsCostSetup(type))
      {
        // create the seed item
        var seed = new LaundryCardEntry
        {
          Amount = -cost(),
          Date = DateTime.Today,
          ID = "",
          Notes = "",
          Type = type,
        };

        // retrieve the default quantity
        int? quantity = Math.Max(1, SaveFile.Instance.Settings.DefaultQuantity);

        // if the quick entry hasn't been enabled
        if (!SaveFile.Instance.Settings.EnableQuickEntry)
        {
          using (EditEntryDialog dlg = new EditEntryDialog())
          {
            dlg.Quantity = quantity.Value;
            dlg.AllowAmountEdit = false;
            dlg.AllowQuantityEdit = true;

            dlg.Text = string.Format("Add {0}", type);
            dlg.BindTo(seed);

            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
              quantity = dlg.Quantity;
            }
            else
            {
              quantity = null;
            }
          }
        }

        // if a quantity has been specified
        if (quantity.HasValue)
        {
          AddEntries(seed, quantity.Value);
        }
      }
    }

    private void DoAddWasher()
    {
      DoAddEntries(LaundryCardEntryType.Washer, () => SaveFile.Instance.Settings.WasherCost);
    }

    private void DoAddDryer()
    {
      DoAddEntries(LaundryCardEntryType.Dryer, () => SaveFile.Instance.Settings.DryerCost);
    }

    private void DoEditEntry(LaundryCardEntry entry)
    {
      var copy = entry.Duplicate();
      var index = entrySource.IndexOf(entry);

      using (EditEntryDialog dlg = new EditEntryDialog())
      {
        dlg.AllowAmountEdit = (entry.Type == LaundryCardEntryType.Deposit || entry.Type == LaundryCardEntryType.Withdrawal);
        dlg.AllowQuantityEdit = false;
        dlg.Text = string.Format("Edit {0}", entry.Type);
        dlg.BindTo(copy);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          entrySource[index] = copy;
        }
      }
    }

    private void DoEditDates(IList<LaundryCardEntry> selected)
    {
      using (EditDateDialog dlg = new EditDateDialog())
      {
        var dates = selected.GroupBy(s => s.Date).ToArray();
        var date = DateTime.Today;
        if (dates.Length == 1)
          date = dates[0].Key;

        dlg.Date = date;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridViewEntries.BeginDataUpdate();
          for (int i = 0; i < selected.Count; ++i)
          {
            selected[i].Date = dlg.Date;
          }
          gridViewEntries.EndDataUpdate();
        }
      }
    }

    private void DoEditSettings()
    {
      var settings = SaveFile.Instance.Settings.Duplicate();
      using (EditSettingsDialog dlg = new EditSettingsDialog())
      {
        dlg.BindTo(settings);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SaveFile.Instance.Settings = settings;
        }
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      DoLoad();
    }

    private void tbbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoSave();
    }

    private void tbbCopy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      clipboard = SelectedEntries.ToList();
      UpdateCommands();
    }

    private void tbbPaste_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      gridViewEntries.BeginDataUpdate();
      clipboard.ForEach(c =>
      {
        var value = c.Duplicate();
        value.ID = Duid.Next;
        entrySource.Add(value);
      });
      gridViewEntries.EndDataUpdate();
    }

    private void tbbDeposit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoAddDeposit();
    }

    private void tbbWithdraw_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoAddWithdrawal();
    }

    private void tbbWasher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoAddWasher();
    }

    private void tbbDryer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoAddDryer();
    }

    private void tbbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      var entry = gridViewEntries.GetFocusedRow() as LaundryCardEntry;
      if (entry != null)
      {
        DoEditEntry(entry);
      }
    }

    private void tbbDate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      var selected = SelectedEntries.ToList();
      if (selected.Count < 1) return;
      DoEditDates(selected);
    }

    private void tbbSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      DoEditSettings();
    }

    private void gridEntries_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button.HasFlag(MouseButtons.Left))
      {
        var info = gridViewEntries.CalcHitInfo(e.Location);
        if (info.InRow || info.InRowCell)
        {
          var row = gridViewEntries.GetRow(info.RowHandle);
          var entry = row as LaundryCardEntry;
          if (entry != null)
          {
            DoEditEntry(entry);
          }
        }
      }
    }

    private void gridViewEntries_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      UpdateCommands();
    }

    private void gridViewEntries_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete && gridViewEntries.SelectedRowsCount > 0)
      {
        var result = XtraMessageBox.Show(this, "Are you sure you want to remove the selected entries?", "Delete", 
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == System.Windows.Forms.DialogResult.Yes)
        {
          gridViewEntries.DeleteSelectedRows();
        }
      }
    }
  }
}
