using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Myrtille
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ORg4AjUWIQA/Gnt2VVhhQlFaclhJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxRdkBiWn9acHxRRmdZVUI=;NjM3Mjg3QDMyMzAyZTMxMmUzMEl4Tmhob0NITElaMklPSzVReW95Z2VEYkhDZUgyalppTHVveUorS1ptU2M9");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
