using System;
using System.Collections.Generic;
using System.Common.References;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace LaundryCard
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      SkinManager.EnableFormSkins();
      SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
      UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

      SingleInstanceApplicationController.Run(new MainForm());
    }
  }
}
