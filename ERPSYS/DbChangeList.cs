using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Win32;
using System.Xml;
namespace ERPSYS
{
    public partial class DbChangeList : Form
    {
        public int iunitId;
        public String strUnitDesc;
        private StaticList slAttendanceType = new StaticList(GLibrary.strarrAttendanceType);
        private StaticList slCalSalaryType = new StaticList(GLibrary.strarrCalSalaryType);

        public DbChangeList()
        {
            InitializeComponent();
        }
         
         
         
        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            string ret = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "0").ToString ();
            //if (ret!= "0" && ret!="")
            //{
            //    string retvkey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "").ToString();
            //    string CurDbretvalue=Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", "").ToString();

            if (ret!= "0" && ret!="")
            {
                //string retvkey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "").ToString();
                string CurDbretvalue=Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", "").ToString();

                string ConnectionString = "Data Source=KHALED;Initial Catalog=Master;User ID=sa";
                string StrSQL = "select DBNAME ,DelFlag from " + Messages.BasicDBName+  ".dbo.DBNAMES" ;
                SqlConnection myConn = new SqlConnection(ConnectionString);
                SqlCommand myComm = new SqlCommand(StrSQL, myConn);
                myConn.Open();
                SqlDataReader dr = myComm.ExecuteReader();

                //char[] delimiter = ";".ToCharArray();
                //String[] DBNames = retvkey.Split(delimiter); //Now split the different SQL statements into an array
                //int i;
               // DataRow row;
                while (dr.Read())
                {
                    //row = dr[0];
                    string[] str = new string[2];
                    ListViewItem itm;
                    str[0] = dr["DBNAME"].ToString();
                    if (dr["DBNAME"].ToString().ToUpper() == CurDbretvalue)
                    {
                        str[1] = "‰⁄„";
                    }
                    else
                    {
                        str[1] = "";
                    }
                    itm = new ListViewItem(str);
                    DBlistView.Items.Add(itm);
                }

                //char[] delimiter = ";".ToCharArray();
                //String[] DBNames = retvkey.Split(delimiter); //Now split the different SQL statements into an array
                //int i;
                //for (i = 0; i < DBNames.Length; i++)
                //{  //Loop through array, executing each statement separately
                //    string [] str=new string [2] ;
                //    ListViewItem itm;  
                //    str[0] = DBNames[i];
                //    if (DBNames[i] == CurDbretvalue)
                //    {
                //        str[1] = "‰⁄„";
                //    }
                //    else
                //    {
                //        str[1] = "";
                //    }

                //    itm = new ListViewItem(str);
                //    DBlistView.Items.Add(itm);

                //    //DBlistView.Items.Add(DBNames[i]);
                //}


           }
            else
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", Messages.BasicDBName);
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", Messages.BasicDBName);
                string[] str = new string[2];
                ListViewItem itm;
                str[0] = Messages.BasicDBName;
                str[1] = "‰⁄„";
                itm = new ListViewItem(str);
                DBlistView.Items.Add(itm);

                //DBlistView.Items.Add("NEWERP");

            }

        }

        private void ChangeDBName(string NEWDBNAME)
        {
            if (NEWDBNAME != "")
            {
                string strReturn = ConfigurationManager.ConnectionStrings[1].ConnectionString;

                string ConnStr = "Data Source=KHALED;Initial Catalog=" + NEWDBNAME + ";User ID=sa";
                //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //// Add an Application Setting.   
                //config.AppSettings.Settings.Remove("ERPSYS.Properties.Settings.NEWERPConnectionString");
                //config.AppSettings.Settings.Add("ERPSYS.Properties.Settings.NEWERPConnectionString", ConnStr);
                //// Save the configuration file.   
                //config.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection("appSettings");

                AppConfig ac = new AppConfig();
                ac.ConfigType = (int)ConfigFileType.AppConfig;

                // create a new key
                //ac.CreateValue("MyKey", "This is the value");
                // set the value of the ConnString key
                ac.SetValue("ERPSYS.Properties.Settings.NEWERPConnectionString", ConnStr);

              


                
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", NEWDBNAME);

              
            }
        }

        private void CmdChangeDB_Click(object sender, EventArgs e)
        {
            if (DBlistView.SelectedItems.Count > 0)
            {
                string DbName = DBlistView.SelectedItems[0].Text;
                ChangeDBName(DbName);

                MessageBox.Show(Messages.DBaseClose, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show(Messages.DBNameSel, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            
        }           
    }
}