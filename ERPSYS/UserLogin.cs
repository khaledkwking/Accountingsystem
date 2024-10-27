using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Win32;
using RegClass;

namespace ERPSYS
{
    partial class UserLogin : Form
    {
        private StaticList slInterfaceType = new StaticList(GLibrary.strarrInterfaceType);
        public UserLogin()
        {
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            
        }

        private Boolean  CheckDate()
        {
            if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDate", "0") == "0")
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDate", DateTime.Today.ToShortDateString ());   
            }
                
                string retvkey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDate", "").ToString();
                if (DateTime.Today>=DateTime.Parse(retvkey).AddDays(60))
                {
                    MessageBox.Show("ÇäÊåÊ ÝÊÑÉ ÊÔÛíá ÇáÈÑäÇãÌ", "ÇáÈÑäÇãÌ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    this.DialogResult = DialogResult.Cancel;
                    return false;
                }
                return true;
            
        }
        private void CheckReg()
        {
            Boolean ret=false;

            if (ret)
            {
                this.Show();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }
    
        private void  CheckRuns()
        {
         //if (CheckDate())
         //{
         string retvkey = "";
         string retName = "";
         int retRunCount;
         string strRunCount = "";
         string retflag = "";
        // Boolean ExitFlag = false;

         //ExitFlag = false;ur
         //Registry.SetValue (@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A","RegKey", "khaled");
         //Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "Flag", "0");
         //Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegName", "");
         //Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RunCount", "0");
         RegistryKey myReg = Registry.LocalMachine;
         RegistryKey MyRegKey;
         String MyVal;
         MyRegKey = myReg.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion");
         MyVal = MyRegKey.GetValue("RegisteredOwner").ToString();
         MyVal = MyVal + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();

         if (Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegKey", "0") == null)
         {

             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "Flag", "0");
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegKey", MyVal);
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegName", "rawan9876");
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RunCount", "0");
         }
         retvkey = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegKey", "").ToString();
         retName = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegName", "").ToString();
         strRunCount = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RunCount", "").ToString();
         retflag = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "Flag", "").ToString();
         //GetSetting("MSArabSoft", "A", "RegKey");
         //retName = GetSetting("MSArabSoft", "A", "RegName");
         //strRunCount = GetSetting("MSArabSoft", "A", "RunCount");
         if (strRunCount == "") { strRunCount = "0"; }
         retRunCount = int.Parse(strRunCount) + 1;
         //this.Text = " ÚÏÏ ãÑÇÊ ÊÔÛíá ÇáÈÑäÇãÌ " + retRunCount + "ãä" + "20";
         //retflag = GetSetting("RRSoft", "A", "flag");
         if (retflag == retvkey && retName == "rawan9876")
         {
             //'Dim frm As New UserLogin
             //'Me.DialogResult = Windows.Forms.DialogResult.OK
             this.Show();
         }
         else
         {
             //RegistryKey myReg  = Registry.LocalMachine;
             //RegistryKey MyRegKey;
             //String MyVal;
             //MyRegKey = myReg.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion");
             //MyVal = MyRegKey.GetValue("RegisteredOwner").ToString ();
             //MyVal = MyVal + DateTime.Today.Day.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Year.ToString();
             ////SaveSetting("MSArabSoft", "A", "Flag", "0");
             ////SaveSetting("MSArabSoft", "A", "RegKey", MyVal);
             ////SaveSetting("MSArabSoft", "A", "RegName", "rawan9876");
             ////SaveSetting("MSArabSoft", "A", "RunCount", retRunCount);
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "Flag", "0");
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegKey", MyVal);
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RegName", "rawan9876");
             Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "RunCount", retRunCount);

             int TotalRuns = retRunCount;
             // SaveSetting("MSArabSoft", "A", "RunCount", TotalRuns);
             if (TotalRuns > 150)
             {
                 MessageBox.Show("ÇäÊåÊ ÝÊÑÉ ÊÔÛíá ÇáÈÑäÇãÌ", "ÇáÈÑäÇãÌ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                 this.DialogResult = DialogResult.Cancel;
             }
         }
     //}
 }

         private void OK_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "") 
            {
                errorProvider1.SetError(UsernameTextBox, "ÃÏÎá ÇÓã ÇáãÓÊÎÏã ãä ÝÖáß");
                MessageBox.Show("ÎØÃ Ýì ÇÓã ÇáãÓÊÎÏã", "ÇáÈÑäÇãÌ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        
            if (PasswordTextBox.Text == "") 
            {
                errorProvider1.SetError(PasswordTextBox, "ÃÏÎá ßáãÉ ÇáãÑæÑ ãä ÝÖáß");
                MessageBox.Show("ÎØÃ Ýì ßáãÉ ÇáãÑæÑ", "ÇáÈÑäÇãÌ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            this.Cursor = Cursors.WaitCursor;
            if (UsernameTextBox.Text != "" && PasswordTextBox.Text != "") 
            {
                userTableAdapter.FillByUserName(nEWERPDataSet.USER  , UsernameTextBox.Text, PasswordTextBox.Text);
                if (nEWERPDataSet.USER.Rows.Count > 0) 
                {
                    Messages.CurUser = nEWERPDataSet.USER.Rows[0]["USER_NAME"].ToString();
                    Messages.CurUserId = nEWERPDataSet.USER.Rows[0]["Id"].ToString();
                    Messages.CurBranch = nEWERPDataSet.USER.Rows[0]["Branch"].ToString();
                    Messages.CurName = nEWERPDataSet.USER.Rows[0]["Name"].ToString();

                    Messages.Usertype = int.Parse (nEWERPDataSet.USER.Rows[0]["USER_TYPE"].ToString());
                    Messages.BackGround = nEWERPDataSet.USER.Rows[0]["BackGround"].ToString();
                    if (Messages.CurBranch != "")
                    {
                        bRANCHESTableAdapter.FillByID(nEWERPDataSet.BRANCHES , int.Parse (Messages.CurBranch));
                        if (bRANCHESBindingSource.Count > 0)
                        {
                            Messages.CurBranchName = nEWERPDataSet.BRANCHES.Rows[0]["BRANCHNAME"].ToString();



                            if (nEWERPDataSet.BRANCHES.Rows[0]["boxaccid"].ToString() != "")
                            {
                                Messages.PosBoxaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["boxaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["bankaccid"].ToString() != "")
                            {
                                Messages.PosBankaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["bankaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["salesaccid"].ToString() != "")
                            {
                                Messages.PosSalesaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["salesaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["salesAgalaccid"].ToString() != "")
                            {
                                Messages.PosAgalaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["salesAgalaccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["purchaseAgalaaccid"].ToString() != "")
                            {
                                Messages.PosPurAgalaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["purchaseAgalaaccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["purchaseaccid"].ToString() != "")
                            {
                                Messages.PosPruchaseaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["purchaseaccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["Visaaccid"].ToString() != "")
                            {
                                Messages.Visaaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["Visaaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["Masteraccid"].ToString() != "")
                            {
                                Messages.Masteraccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["Masteraccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["KeyNetaccid"].ToString() != "")
                            {
                                Messages.KeyNetaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["KeyNetaccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["Otheraccid"].ToString() != "")
                            {
                                Messages.Otheraccid  = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["Otheraccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["VisaComaccid"].ToString() != "")
                            {
                                Messages.VisaComaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["VisaComaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["MasterComaccid"].ToString() != "")
                            {
                                Messages.MasterComaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["MasterComaccid"].ToString());
                            }
                            if (nEWERPDataSet.BRANCHES.Rows[0]["KeyNetComaccid"].ToString() != "")
                            {
                                Messages.KeyNetComaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["KeyNetComaccid"].ToString());
                            }

                            if (nEWERPDataSet.BRANCHES.Rows[0]["OtherComaccid"].ToString() != "")
                            {
                                Messages.OtherComaccid = int.Parse(nEWERPDataSet.BRANCHES.Rows[0]["OtherComaccid"].ToString());
                            }
                        }
                    }
                
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "UserName", UsernameTextBox.Text);

                    DialogResult = DialogResult.OK;
                   
                }
                else
            {
            
                //errorProvider1.SetError(UsernameTextBox, "ÎØÃ Ýì ÇÓã ÇáãÓÊÎÏã");
                //errorProvider1.SetError(PasswordTextBox, "ÎØÇ Ýì ßáãÉ ÇáãÑæÑ");
                MessageBox.Show("ÎØÃ Ýì ÇÓã ÇáãÓÊÎÏã æßáãÉ ÇáãÑæÑ", "ÇáÈÑäÇãÌ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
               
            }

        }
        this.Cursor = Cursors.Default;
         
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            string CurDbretvalue = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "CurDbase", "").ToString();
            this.Text = this.Text +"    "+ " ÞÇÚÏ ÇáÈíÇäÇÊ ÇáÍÇáíÉ " + CurDbretvalue;

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.users' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.nEWERPDataSet.USER );
            CheckRuns();
            //CheckDate();
            string retUerName = Registry.GetValue(@"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A", "UserName", "").ToString();
            UsernameTextBox.Text = retUerName;

           

            //switch (comboBox1.Text)
            //{
                //case "1": //"800*600":
                //    FixHeight = 800;
                //    FixWidth = 600;
                //    Resolution.CResolution ChangeRes600 = new Resolution.CResolution(FixHeight, FixWidth);
                //    break;

                //case "2": //"1024*768":
                //    FixHeight = 1024;
                //    FixWidth = 768;
                //    Resolution.CResolution ChangeRes768 = new Resolution.CResolution(FixHeight, FixWidth);
                //    break;
                //case "3": //"1280*1024":
                //    FixHeight = 1280;
                //    FixWidth = 1024;
                //    Resolution.CResolution ChangeRes1024 = new Resolution.CResolution(FixHeight, FixWidth);
                //    break;


            //}



        }

        private void UsernameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK.Focus();
            }
        }

        private void UsernameTextBox_Validated(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != "")
            {
                int Pos = uSERBindingSource1.Find("USER_NAME", UsernameTextBox.Text);
                if (Pos > -1)
                {
                    string BranchId = nEWERPDataSet.USER.Rows[Pos]["Branch"].ToString();

                    int bPos = bRANCHESBindingSource.Find("BRANCHCODE", BranchId);
                    if (bPos > -1)
                    {
                        lblBranch.Text = nEWERPDataSet.BRANCHES.Rows[bPos]["BRANCHNAME"].ToString();
                    }

                }
                else
                {
                    lblBranch.Text = "";
                }
                
            }
        }

     
        
        
    }
}
