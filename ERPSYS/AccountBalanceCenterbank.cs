using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;

namespace ERPSYS
{
    public partial class AccountBalanceCenterbank : Form
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
        private Boolean FirstHit = false;
        public int CenterNo;
        private DateTime FromDateB ;
        private DateTime ToDateB;
       

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetTempOld = new NEWERPDataSet();

        private StaticList slRefBalanceType = new StaticList(GLibrary.strarrRefBalanceTypes);

        public AccountBalanceCenterbank()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_Currency' table. You can move, or remove it, as needed.
            this.cDE_CurrencyTableAdapter.Fill(this.nEWERPDataSet.CDE_Currency);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            //this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            //bFlag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
              accountingBindingSource.DataMember ="accounting";
              accountingBindingSource.DataSource = nEWERPDataSetNew;

              accountingBindingSourceTemp.DataMember = "accounting";
              accountingBindingSourceTemp.DataSource = nEWERPDataSetNew;
            
              this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
              this.accountingTableAdapter.Fill(nEWERPDataSetTempOld.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            //if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            //{
            //    cmbBranch.SelectedIndex = 0;
            //}
            //CmbRefTypes.DataSource = slRefBalanceType.ToDataTable();
            //if (CmbRefTypes.Items.Count > 0)
            //{
            //    CmbRefTypes.SelectedIndex = 0;
            //}
            //bFlag = true;
            //accountingBindingSource1.Sort = "AccountName";
            accountingBindingSource.Sort = "AccountName";
           // cmbAccount.SelectedValue = -1;
            

           
            //CmbCostCenter.SelectedValue = -1;

           // Search();
                   
        }

        private void AccountSum_Activated(object sender, EventArgs e)
        {
           
        }
       
        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

                  
     
        private void Search()
        {
            nEWERPDataSetTempOld.accounting.Clear();
              BranchId   =  null ;
              AccountId   =  null ;
              ToDate =null ;
              FromDate  = null;
              if (txtFromDate.Text != "")
              {
                  if (GLibrary.IsDate(txtFromDate.Text))
                  {
                      if (txtFromDate.Text != "") { FromDate = DateTime.Parse(txtFromDate.Text); }

                  }
                  else
                  {
                      MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                      return;
                  }
              }
              else
              {
                  FromDate = new DateTime(DateTime.Today.Year ,1,1);
                  //FromDate = null;
              }
              if (txtToDate.Text != "")
              {
                  if (GLibrary.IsDate(txtToDate.Text))
                  {
                      
                      if (txtToDate.Text != "") { ToDate = DateTime.Parse(txtToDate.Text + " 23:59"); }
                  }
                  else
                  {
                      MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                      return;
                  }
              }
              else
              {
                  ToDate = DateTime.Parse(DateTime.Today.ToShortDateString () + " 23:59");
                  //ToDate = null;
              }
          
              //if (cmbAccount.SelectedValue != null) { AccountId = long.Parse(cmbAccount.SelectedValue.ToString()); }
              //if (cmbBranch.SelectedValue != null) { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
              BranchId = int.Parse (Messages.CurBranch);

              ToDateB = new DateTime();
              if (FromDate == null)
              {
                  ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
              }
              else
              {
                  DateTime temp=new DateTime ();
                  temp = DateTime.Parse(FromDate.ToString());
                  ToDateB = temp.AddDays(-1);
                  
              }
              if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
              {
                  FromDateB = ToDateB;
              }
              else
              {
                  FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
              }
              //if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              //{
              //    AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              //}
              //else
              //{
                  AccountId = 1;
              //}
              ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");

             
              //int Level = int.Parse (nUpDownacc.Value.ToString ()) ;
              nEWERPDataSet.accounting.Clear();
                  accountingTableAdapter.FillByRefBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB,2);
              // GetDataLevel(long.Parse(AccountId.ToString()), Level);
              AddItem(int.Parse(AccountId.ToString()),Messages.MaxLevel );

              //if (CmbRefTypes.SelectedValue.ToString() == "1")
              //{
              //    //AccountDGView.Visible = false;
              //    //dGdViewAccCredit.Visible = true ;
              //    GetAccountCeridtSum();
              //}
              //else if (CmbRefTypes.SelectedValue.ToString() == "2")
              //{
              //    //AccountDGView.Visible = true;
              //    //dGdViewAccCredit.Visible = false ;
              //    GetAccountSum();
                 
              //}
          
                 
              
        }
        private void GetDataLevel(long  AccountId,int Level)
        {
            if (Level != 0)
            {
                Stack vegStack = new Stack();
                nEWERPDataSetTemp.accounting.Clear();
                nEWERPDataSetTemp.AccountingView.Clear();
                accountingTableAdapter.FillByRefBalance(nEWERPDataSetTemp.accounting, AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB,1);
                int count = nEWERPDataSetTemp.accounting.Count;
                for (int i = 0; i < count; i++)
                {
                    nEWERPDataSetTempOld.accounting.ImportRow(nEWERPDataSetTemp.accounting.Rows[i]);
                    vegStack.Push(nEWERPDataSetTemp.accounting.Rows[i]["accountid"].ToString());
                   
                   
                }
               

               
                    Level = Level - 1;
                    for (int j = 0; j < count; j++)
                    {
                        nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[j]);
                       
                        GetDataLevel(long.Parse(vegStack.Pop().ToString()), Level);
                    }
            }
 
            
        }
        private void AddItem(int AccountparentId,int Level)
        {
            if (Level > 0)
            {
                accountingBindingSourceTemp.Filter = "AccountparentId = " + AccountparentId.ToString();
                System.Data.DataView list = new System.Data.DataView();
                list = (DataView)accountingBindingSourceTemp.List;
                DataTable T = new DataTable();
                T = list.ToTable();
                accountingBindingSourceTemp.RemoveFilter();
                for (int i = 0; i < T.Rows.Count; i++)
                {
                    //Boolean bRoot = (Boolean)T.Rows[i]["Root"];

                    //TreeNode Node = new TreeNode();
                    //Node.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];
                    int accountid = int.Parse(T.Rows[i]["accountid"].ToString());
                   
                   
                   
                        accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, accountid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                        if (nEWERPDataSetTempOld.accounting.Count > 0)
                        {
                            decimal TotBal = 0;
                            decimal TotBalB = 0;
                            if (nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"] != DBNull.Value)
                            {
                                TotBal = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"].ToString());
                            }
                            if (nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalanceB"] != DBNull.Value)
                            {
                                TotBalB = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalanceB"].ToString());
                            }
                            //if (chkBoxFlag.Checked) // ÚÏã ÇÙåÇÑ ÇáÞíãÉ ÇáÕÝÑíÉ
                            //{
                            //    if (TotBalB - TotBal != 0)
                            //    {
                            //        nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                            //    }
                            //}
                            //else
                            //{
                                nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                            //}
                        }
                      
                       
                        Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];
                        //Level = Level - 1;
                        if (MainNode && Level != 0) //has childern
                        {

                            AddItem(accountid, Level - 1);
                        }
                        else
                        {
                        }
                   
                }
            }
        }
       

       
       
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowReport();
        }
        private void ShowReport()
        {
           
            int AccLevel = 0;
            
            Search();
            //if (cmbAccount.SelectedValue != null)
            //{
            //    AccountId = long.Parse(cmbAccount.SelectedValue.ToString());
            //}
            //else
            //{
            AccountId = 1;
            // }
            int pos = accountingBindingSource.Find("AccountId", AccountId);
            if (pos > -1 || AccountId == 1)
            {
                if (pos > -1)
                {
                    AccLevel = int.Parse(((DataRowView)accountingBindingSource.Current)["AccLevel"].ToString());
                }
                ShowNewRpt frm = new ShowNewRpt();
                //frm.AccountName = cmbAccount.Text;

                if (txtFromDate.Text != "")
                {
                    frm.FromDate = DateTime.Parse(txtFromDate.Text);
                }
                else
                {
                    frm.FromDate = new DateTime(DateTime.Today.Year, 1, 1);
                }
                if (txtToDate.Text != "")
                {
                    frm.ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
                }
                else
                {
                    frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
                }
                if (CenterNo == 1)
                {
                    frm.choiceNum = 22;
                }
                else if(CenterNo == 2)
                {
                    frm.choiceNum = 23;
                }
                else if (CenterNo == 3)
                {
                    frm.choiceNum = 24;
                }
                else if (CenterNo == 4)
                {
                    frm.choiceNum = 25;
                }
                frm.nEWERPDataSet = nEWERPDataSet;

                frm.AccLevel = AccLevel;
                frm.ShowDialog(this);
            }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void PrintBtn1_Click(object sender, EventArgs e)
        {
            CenterNo = 3;
            ShowReport();
        }

        private void PrintBtn2_Click(object sender, EventArgs e)
        {
            CenterNo = 4;
            ShowReport();
        }

          
      
        
    }
}