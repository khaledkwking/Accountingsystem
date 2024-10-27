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

namespace ERPSYS
{
    public partial class DbList : Form
    {
        public int iunitId;
        public String strUnitDesc;
        private StaticList slAttendanceType = new StaticList(GLibrary.strarrAttendanceType);
        private StaticList slCalSalaryType = new StaticList(GLibrary.strarrCalSalaryType);

        public DbList()
        {
            InitializeComponent();
        }
         
         
         
        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            string ret = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "0").ToString ();
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
                //Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", Messages.BasicDBName);
                string[] str = new string[2];
                ListViewItem itm;
                str[0] = Messages.BasicDBName;
                str[1] = "‰⁄„";
                itm = new ListViewItem(str);
                DBlistView.Items.Add(itm);

                //DBlistView.Items.Add("NEWERP");

            }

        }

       
        private void CmdAdd_Click(object sender, EventArgs e)
        {
           
            SaveCmd.Text = "Õ›Ÿ";         
           
            DelCmd.Enabled = false;

        }

     

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                SqlConnection myConn=null;
                SqlConnection myConn1=null;
                try
                {

                    if (txtDbName.Text != "")
                    {

                        //OpenDiag.ShowDialog();
                        string strFileName = System.Environment.CurrentDirectory + "\\NEWERPDB.sql";
                        //Application.ExecutablePath
                        string ConnectionString = "Data Source=KHALED;Initial Catalog=Master;User ID=sa";

                        string StrSQL = "select * from " + Messages.BasicDBName + ".dbo.DBNames where DBName='" + txtDbName.Text + "'";
                        myConn = new SqlConnection(ConnectionString);
                        SqlCommand myComm = new SqlCommand(StrSQL, myConn);
                        myConn.Open();
                        SqlDataReader dr = myComm.ExecuteReader();

                        if (!dr.HasRows)
                        {
                            dr.Close();
                            StrSQL = "CREATE DATABASE " + txtDbName.Text;
                            myComm.CommandText = StrSQL;
                            myComm.ExecuteNonQuery();
                            //myConn.Close();

                            ConnectionString = "Data Source=KHALED;Initial Catalog=" + txtDbName.Text + ";User ID=sa";
                            myConn1 = new SqlConnection(ConnectionString);
                            //SqlConnection  myConn = new SqlConnection (ConnectionString);
                            //SqlCommand myComm1 = new SqlCommand(CommandTextBox, myConn1);
                            myConn1.Open();

                            if (strFileName != "")
                            {
                                //txtReader = File.OpenText(OpenDiag.FileName);
                                //CommandTextBox = txtReader.ReadToEnd();
                                ExecuteSQLScript(strFileName, myConn1);
                            }

                            //myComm1.ExecuteNonQuery();

                            string SQL = "INSERT INTO " + Messages.BasicDBName + ".dbo.DBNames(DBNAME ,DelFlag) values('" + txtDbName.Text + "',0)";
                            myComm.CommandText = SQL;
                            myComm.ExecuteNonQuery();
                            myConn.Close();

                            myConn1.Close();


                            DBlistView.Items.Add(txtDbName.Text);
                            ImportData(txtDbName.Text);

                            txtDbName.Text = "";
                            ProductschkBox.Checked = false;
                            InvoiceschkBox.Checked = false;
                            AccountchkBox.Checked = false;
                            QidschkBox.Checked = false;

                            MessageBox.Show(Messages.DBNameAddSuccess, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else
                        {
                            MessageBox.Show(Messages.DBFoundError, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            dr.Close();
                            myConn.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Messages.DBNameError, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return;
                    }

                       
                }
                 
                catch (Exception ex)
                {
                    myConn.Close();
                    myConn1.Close();
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    
                }
            }
        }
        private  void ExecuteSQLScript(string Filename , SqlConnection conn )
        {
         SqlCommand cmd =new SqlCommand () ;
         StreamReader  Reader;

        //try
        //{
              cmd.CommandType = CommandType.Text;
              cmd.Connection = conn;

              Reader =new StreamReader(Filename);
              String s   = Reader.ReadToEnd();
              s = s.Replace("GO\r\n", "~");     //Replace GO with a "~". Split only works with char
              char [] delimiter  = "~".ToCharArray();
              String [] SQL    = s.Split(delimiter); //Now split the different SQL statements into an array
              int i;
              for( i=0; i< SQL.Length ;i++)
              {  //Loop through array, executing each statement separately
                cmd.CommandText = SQL[i];
                cmd.ExecuteNonQuery();
              }

              Reader.Close();
              Reader = null;
              cmd = null;
         //}
           //catch (Exception ex)
           //{
           //  int ErrorNo = -1;
           //  MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
           //}
    }

       private void ImportData(string DBName)
       {
           try
           {
               string ConnectionString = "Data Source=KHALED;Initial Catalog=Master;User ID=sa";

               SqlConnection myConn = new SqlConnection(ConnectionString);

               myConn.Open();
               string strFileName = System.Environment.CurrentDirectory + "\\BasicTables.txt";
               ExecuteSQLDataScript(strFileName, myConn, DBName);
               if (ProductschkBox.Checked)
               {
                   strFileName = System.Environment.CurrentDirectory + "\\Products.txt";
                   ExecuteSQLDataScript(strFileName, myConn, DBName);
               }
               if (AccountchkBox.Checked)
               {
                   strFileName = System.Environment.CurrentDirectory + "\\Accounts.txt";
                   ExecuteSQLDataScript(strFileName, myConn, DBName);
               }
               if (QidschkBox.Checked)
               {
                   strFileName = System.Environment.CurrentDirectory + "\\Qids.txt";
                   ExecuteSQLDataScript(strFileName, myConn, DBName);
               }
               if (InvoiceschkBox.Checked)
               {
                   strFileName = System.Environment.CurrentDirectory + "\\Invoices.txt";
                   ExecuteSQLDataScript(strFileName, myConn, DBName);
               }
               myConn.Close();
           }
           catch (Exception ex)
           {
               int ErrorNo = -1;
               MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
           }


       }
        private void ExecuteSQLDataScript(string Filename, SqlConnection conn, string DBName)
        {
            SqlCommand cmd = new SqlCommand();
            StreamReader Reader;

            //try
            //{
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                Reader = new StreamReader(Filename);
                String s = Reader.ReadToEnd();
                s = s.Replace("NEWTemp", DBName);     //Replace GO with a "~". Split only works with char
                char[] delimiter = "~".ToCharArray();
                String[] SQL = s.Split(delimiter); //Now split the different SQL statements into an array
                int i;
                for (i = 0; i < SQL.Length; i++)
                {  //Loop through array, executing each statement separately
                    cmd.CommandText = SQL[i];
                    cmd.ExecuteNonQuery();
                }

                Reader.Close();
                Reader = null;
                cmd = null;
            //}
            //catch (Exception ex)
            //{
            //    int ErrorNo = -1;
            //    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}
        }
        private void DelCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {
                string ConnectionString = "Data Source=KHALED;Initial Catalog=Master;User ID=sa";
                if (DBlistView.SelectedItems.Count > 0)
                {
                    string DbName = DBlistView.SelectedItems[0].Text;
                    //string retvkey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "").ToString();
                    if (DbName.ToUpper() != Messages.BasicDBName.ToUpper())
                    {

                        try
                        {
                            //DbName = DBlistView.SelectedItems[0].Text;
                            string StrSQL = "drop DATABASE " + DbName;
                            SqlConnection myConn = new SqlConnection(ConnectionString);
                            SqlCommand myComm = new SqlCommand(StrSQL, myConn);
                            myConn.Open();
                            myComm.ExecuteNonQuery();

                            string SQL = "delete from " + Messages.BasicDBName + ".dbo.DBNames where DBName='" + DbName+"'";
                            myComm.CommandText = SQL;
                            myComm.ExecuteNonQuery();
                                                    
                            myConn.Close();
                            //string retvalue = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", "").ToString();

                            //int i = retvalue.IndexOf(DbName);
                            //if (i > -1)
                            //{
                            //    retvalue = retvalue.Remove(i, DbName.Length);
                            //}
                            //i = retvalue.IndexOf(";;");
                            //if (i > -1)
                            //{
                            //    retvalue = retvalue.Remove(i, 1);
                            //}
                            //if (retvalue.EndsWith(";"))
                            //{
                            //     i = retvalue.IndexOf(";");
                            //    if (i > -1)
                            //    {
                            //        retvalue = retvalue.Remove(i, 1);
                            //    }
                            //}

                            //Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "DBNAMES", retvalue);
                            DBlistView.SelectedItems[0].Remove();
                            DBlistView.Refresh();
                        }
                        catch (Exception ex)
                        {
                            //int ErrorNo = -1;
                            MessageBox.Show("ﬁ«⁄œ… «·»Ì«‰«  „” Œœ„Â „‰ ﬁ»· ÃÂ«“ «Œ—Ì ·« Ì„ﬂ‰ Õ–›Â« «·« »⁄œ «€·ﬁ «·»—‰«„Ã „‰ ﬁ»· «·ÃÂ«“ «·«Œ—", "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Messages.DBaseDefError, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.DBNameSel, "ﬁÊ«⁄œ «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void QidschkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (QidschkBox.Checked)
            {
                AccountchkBox.Checked = true;
            }
        }

        private void InvoiceschkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InvoiceschkBox.Checked)
            {
                AccountchkBox.Checked = true;
                ProductschkBox.Checked = true;
            }
        }

            
    }
}