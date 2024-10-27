using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ERPSYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            string retvkey = "";
            if (Registry.GetValue(Messages.RegPath, "lang", "0") == null)
            {
                Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang);
                retvkey = Messages.ArabLang;
                Messages.CurLang = Messages.ArabLang;
            }
            else if (Registry.GetValue(Messages.RegPath, "lang", "").ToString() == "")
            {
                Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang);
                retvkey = Messages.ArabLang;
                Messages.CurLang = Messages.ArabLang;
            }
            else
            {
                retvkey = Registry.GetValue(Messages.RegPath, "lang", "").ToString();
                Messages.CurLang = retvkey;

            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(retvkey);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainMenu frm = new MainMenu();
            //CostCentersAdd frm = new CostCentersAdd();
           
           // GLibrary.SetFrm(frm, retvkey);
            //Thread.CurrentThread.CurrentCulture         
            Application.Run(frm);
            
        }
    }
}