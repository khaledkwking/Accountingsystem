using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class UserSec : DockContent
    {
        public Boolean EditFlag = true;
       
        private TabPage selectedTab; 
        public UserSec()
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
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.nEWERPDataSet.USER);

            // TODO: This line of code loads data into the 'nEWERPDataSet.FUNCTIONS' table. You can move, or remove it, as needed.
            this.fUNCTIONSTableAdapter.Fill(this.nEWERPDataSet.FUNCTIONS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.
            this.uSER_FUNCTIONTableAdapter.Fill(this.nEWERPDataSet.USER_FUNCTION);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
           
            uSERFUNCTIONBindingSourceCard.Filter = "Type=1";
            uSERFUNCTIONBindingSourceAcct.Filter = "Type=2";
            uSERFUNCTIONBindingSourceStores.Filter = "Type=3";
            uSERFUNCTIONBindingSourceSales.Filter = "Type=4";
            uSERFUNCTIONBindingSourcePur.Filter = "Type=5";
            uSERFUNCTIONBindingSourceAcctRpt.Filter = "Type=6";
            uSERFUNCTIONBindingSourceStoreRpt.Filter = "Type=7";
            uSERFUNCTIONBindingSourceTools.Filter = "Type=8";

            selectedTab = this.tabControlUsers.SelectedTab;
           
        }
       
             
        private void AddNew()
        {

            uSERBindingSource.AddNew();
            branchComboBox.SelectedIndex = 0;
            txtuSERTYPE.Text = "2";
            EditFlag = false;
            AddUserBtn.Enabled = false;
            DelUserBtn.Enabled = false;
        }
        private void CmdDel_Click(object sender, EventArgs e)
        {
            
        }

     

        private void uSERFUNCTIONBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (uSERBindingSource.Count > 0 && uSERFUNCTIONBindingSource.Count > 0)
            //{

            //    ((DataRowView)uSERFUNCTIONBindingSource.Current)["USER_ID"] = (int)((DataRowView)uSERBindingSource.Current)["ID"];

            //}
        }

        private void uSERFUNCTIONBindingSource1_PositionChanged(object sender, EventArgs e)
        {
            //if (uSERBindingSource.Count > 0 && uSERFUNCTIONBindingSource1.Count > 0)
            //{

            //    ((DataRowView)uSERFUNCTIONBindingSource1.Current)["USER_ID"] = (int)((DataRowView)uSERBindingSource.Current)["ID"];

            //}
        }

        private void tabControlUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTab != this.tabControlUsers.SelectedTab)
            {
                if (EditFlag && UsersDGView.SelectedRows.Count >= 1)
                {
                    switch (tabControlUsers.SelectedIndex)
                    {
                        case 0:
                            break;
                        case 1:
                            checkUser();
                            break;
                    }
                    selectedTab = tabControlUsers.SelectedTab;
                }
                else
                {
                    MessageBox.Show("ﬁÊ„ »Õ›Ÿ «·„” Œœ„ «Ê·«", "Õ›Ÿ «·„” Œœ„", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    this.tabControlUsers.SelectedTab = selectedTab;
                }
            }
        
          

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddNew();   
        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, nameTextBox, "√œŒ· «·«”„ ", "√·«”„", true) && GLibrary.ValidatetxtBox(errorProvider1, uSER_NAMETextBox, "√œŒ· √”„ «·„” Œœ„ ", "«·„” Œœ„", true) && GLibrary.ValidatetxtBox(errorProvider1, pASSWORDTextBox, "«œŒ· ﬂ·„… «·”—", "ﬂ·„… «·”—", true))
            {
                this.Validate();
                uSERBindingSource.EndEdit();
                //nEWERPDataSet.AcceptChanges();
                uSERTableAdapter.Update(nEWERPDataSet.USER);
                SaveFunction((int)((DataRowView)uSERBindingSource.Current)["ID"]);



                GLibrary.MsgSave();
                AddUserBtn.Enabled = true;
                DelUserBtn.Enabled = true;
                EditFlag = true;
            }
        }
        private void SaveFunction(int UserId)
        {
            for (int i = 0; i < nEWERPDataSet.FUNCTIONS.Rows.Count; i++)
            {
                try
                {
                    int FunId = int.Parse(nEWERPDataSet.FUNCTIONS.Rows[i]["Id"].ToString());
                    int Type = int.Parse(nEWERPDataSet.FUNCTIONS.Rows[i]["Type"].ToString());
                    int count = (int)uSER_FUNCTIONTableAdapter.FillByUserId(UserId, FunId);

                    if (count == 0)
                    {
                        uSERFUNCTIONBindingSource1.AddNew();
                        ((DataRowView)uSERFUNCTIONBindingSource1.Current)["FOpen"] = false;
                        ((DataRowView)uSERFUNCTIONBindingSource1.Current)["FUpdate"] = false;
                        ((DataRowView)uSERFUNCTIONBindingSource1.Current)["FSave"] = false;
                        ((DataRowView)uSERFUNCTIONBindingSource1.Current)["FDel"] = false;
                    }
                    else
                    {
                        uSERFUNCTIONBindingSource.Filter = "FUNCTION_ID=" + FunId.ToString() + " and USER_ID=" + UserId.ToString();
                        if (uSERFUNCTIONBindingSource.Count > 0)
                        {
                            int id = int.Parse(((DataRowView)uSERFUNCTIONBindingSource.Current)["ID"].ToString());
                            int Pos = uSERFUNCTIONBindingSource1.Find("ID", id);
                            if (Pos > -1)
                            {
                                uSERFUNCTIONBindingSource1.Position = Pos;
                            }
                        }
                        uSERFUNCTIONBindingSource.RemoveFilter();

                    }
                    ((DataRowView)uSERFUNCTIONBindingSource1.Current)["USER_ID"] = UserId;
                    ((DataRowView)uSERFUNCTIONBindingSource1.Current)["FUNCTION_ID"] = FunId;
                    ((DataRowView)uSERFUNCTIONBindingSource1.Current)["Type"] = Type;
                  
                    uSERFUNCTIONBindingSource1.EndEdit();
                    uSER_FUNCTIONTableAdapter.Update(nEWERPDataSet.USER_FUNCTION);

                }

                catch (Exception ex)
                {
                    int ErrorNo = -1;

                    MessageBox.Show("·« Ì„ﬂ‰ Õ–› Â–« «·„” Œœ„ „— »ÿ »«·»Ì«‰«  «Œ—Ì", "«·„” Œœ„Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }

            }

        }
        private void uSERBindingSource_PositionChanged(object sender, EventArgs e)
        {
            checkUser();
        }
        private void checkUser()
        {
            if (uSERBindingSource.Count > 0)
            {
                int UserId = int.Parse(((DataRowView)uSERBindingSource.Current)["ID"].ToString());
                uSERFUNCTIONBindingSourceCard.Filter = "USER_ID = " + UserId.ToString() + " and Type=1 ";
                uSERFUNCTIONBindingSourceAcct.Filter = "USER_ID = " + UserId.ToString() + " and Type=2 ";

                uSERFUNCTIONBindingSourceStores.Filter = "USER_ID = " + UserId.ToString() + " and Type=3 ";
                uSERFUNCTIONBindingSourceSales.Filter = "USER_ID = " + UserId.ToString() + " and Type=4 ";
                uSERFUNCTIONBindingSourcePur.Filter = "USER_ID = " + UserId.ToString() + " and Type=5 ";
                uSERFUNCTIONBindingSourceAcctRpt.Filter = "USER_ID = " + UserId.ToString() + " and Type=6 ";
                uSERFUNCTIONBindingSourceStoreRpt.Filter = "USER_ID = " + UserId.ToString() + " and Type=7 ";
                uSERFUNCTIONBindingSourceTools.Filter = "USER_ID = " + UserId.ToString() + " and Type=8 ";

            }
        }
        private void DelUserBtn_Click(object sender, EventArgs e)
        {
            if (uSERBindingSource.Count > 0)
            {
                if (GLibrary.MsgCheckDel())
                {

                    uSERBindingSource.RemoveCurrent();
                    uSERBindingSource.EndEdit();
                    uSERTableAdapter.Update(nEWERPDataSet.USER);


                }
            }
        }

        private void UsersDGView_SelectionChanged(object sender, EventArgs e)
        {
            //uSERBindingSource.CancelEdit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Validate();
                uSERFUNCTIONBindingSourceCard.EndEdit();
                //nEWERPDataSet.AcceptChanges();
                uSER_FUNCTIONTableAdapter.Update(nEWERPDataSet.USER_FUNCTION);
                      
                GLibrary.MsgSave();
            }
           catch 
            {

            }
        }

        private void cmbBoxUserStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBoxUserStatus.SelectedIndex)
            {
                case 0:
                    txtuSERTYPE.Text = "2";
                break;
                case 1:
                    txtuSERTYPE.Text = "1";
                    break;

            }
        }

        private void txtuSERTYPE_TextChanged(object sender, EventArgs e)
        {
            switch (txtuSERTYPE.Text)
            {
                case "2":
                   
                    cmbBoxUserStatus.SelectedIndex = 0;
                    break;
                case "1":
                   
                    cmbBoxUserStatus.SelectedIndex = 1;
                    break;

            }
        }
        private void SelAll()
        {
            for (int i=0;i<dataGridView1.Rows.Count ;i++)
            {
                dataGridView1.Rows[i].Cells ["FOpen"].Value =Boolean.TrueString ;
                dataGridView1.Rows[i].Cells["FUpdate"].Value  = Boolean.TrueString;
                dataGridView1.Rows[i].Cells["FSave"].Value  = Boolean.TrueString;
                dataGridView1.Rows[i].Cells["FDel"].Value  = Boolean.TrueString;

            }
        }
        
       
        private void SelAll2()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells["FOpen1"].Value = Boolean.TrueString;
                dataGridView2.Rows[i].Cells["FUpdate1"].Value = Boolean.TrueString;
                dataGridView2.Rows[i].Cells["FSave1"].Value = Boolean.TrueString;
                dataGridView2.Rows[i].Cells["FDel1"].Value = Boolean.TrueString;

            }
        }

        private void SelAll3()
        {
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                dataGridView3.Rows[i].Cells["FOpen3"].Value = Boolean.TrueString;
                dataGridView3.Rows[i].Cells["FUpdate3"].Value = Boolean.TrueString;
                dataGridView3.Rows[i].Cells["FSave3"].Value = Boolean.TrueString;
                dataGridView3.Rows[i].Cells["FDel3"].Value = Boolean.TrueString;

            }
        }

        private void SelAll4()
        {
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                dataGridView4.Rows[i].Cells["FOpen4"].Value = Boolean.TrueString;
                dataGridView4.Rows[i].Cells["FUpdate4"].Value = Boolean.TrueString;
                dataGridView4.Rows[i].Cells["FSave4"].Value = Boolean.TrueString;
                dataGridView4.Rows[i].Cells["FDel4"].Value = Boolean.TrueString;

            }
        }

          private void SelAll5()
        {
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                dataGridView5.Rows[i].Cells["FOpen5"].Value = Boolean.TrueString;
                dataGridView5.Rows[i].Cells["FUpdate5"].Value = Boolean.TrueString;
                dataGridView5.Rows[i].Cells["FSave5"].Value = Boolean.TrueString;
                dataGridView5.Rows[i].Cells["FDel5"].Value = Boolean.TrueString;

            }
        }
        
          private void SelAll6()
        {
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {
                dataGridView6.Rows[i].Cells["FOpen6"].Value = Boolean.TrueString;
                dataGridView6.Rows[i].Cells["FUpdate6"].Value = Boolean.TrueString;
                dataGridView6.Rows[i].Cells["FSave6"].Value = Boolean.TrueString;
                dataGridView6.Rows[i].Cells["FDel6"].Value = Boolean.TrueString;

            }
        }

        private void SelAll7()
        {
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                dataGridView7.Rows[i].Cells["FOpen7"].Value = Boolean.TrueString;
                dataGridView7.Rows[i].Cells["FUpdate7"].Value = Boolean.TrueString;
                dataGridView7.Rows[i].Cells["FSave7"].Value = Boolean.TrueString;
                dataGridView7.Rows[i].Cells["FDel7"].Value = Boolean.TrueString;

            }
        }


        private void SelAll8()
        {
            for (int i = 0; i < dataGridView8.Rows.Count; i++)
            {
                dataGridView8.Rows[i].Cells["FOpen8"].Value = Boolean.TrueString;
                dataGridView8.Rows[i].Cells["FUpdate8"].Value = Boolean.TrueString;
                dataGridView8.Rows[i].Cells["FSave8"].Value = Boolean.TrueString;
                dataGridView8.Rows[i].Cells["FDel8"].Value = Boolean.TrueString;

            }
        }
        private void BtnSelAll1_Click(object sender, EventArgs e)
        {
            SelAll2();
        }

        private void SelAllBtn_Click(object sender, EventArgs e)
        {
           
            SelAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelAll3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelAll4();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelAll5();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelAll6();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelAll7();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelAll8();
        }

        private void AccttabPage_Click(object sender, EventArgs e)
        {

        }


    }
}