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
    public partial class AccountSum1 : Form
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<int> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public AccountSum1()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            CmbItemSorted.DataSource = slItemSorted.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
              accountingBindingSource.DataMember ="accounting";
              accountingBindingSource.DataSource = nEWERPDataSetNew;

              this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            accountingBindingSource.Sort = "AccountName";
            accountingViewBindingSource.Sort = "AccountName";
            accountingBindingSource1.Sort = "AccountName";
            cmbAccount.SelectedValue = -1;
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    cmbStroes.SelectedIndex = 0;
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            Search();
                   
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

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        private void txtBarCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedValue !=null)
            {
                Search();
            }
        }
        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedValue != null)
            {
                Search();
            }
        }
        private void Search()
        {
            nEWERPDataSet.AccountingView.Rows.Clear();
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
                  FromDate = null;
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
                  ToDate = null;
              }

              if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              {
                  AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              }
              else
              {
                  AccountId = 1;
              }
              if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
              int pos=accountingBindingSource.Find("AccountId", AccountId);
              if (pos > -1)
              {
                 
                  nEWERPDataSet.accounting.Clear();
                  nEWERPDataSet.AccountingView.Clear();
                  GetDataLevel(int.Parse (AccountId.Value.ToString ()) );
                      //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
                      StockDGView.Visible = true;
                      AccountDGView.Visible = false;
                      //GetSum();
                 // }
              }
              else if (AccountId == 1) // ÌãíÚ ÇáÍÓÇÈÇÊ
              {
                  GetDataLevel(1);
              }
              if (nEWERPDataSet.AccountingView.Rows.Count > 0)
              {
                  GetSum();
              }
        }
        private void GetAccountDauan()
        {

        }
        private void GetDataLevel(int AccountId)
        {

            Stack vegStack = new Stack();
            nEWERPDataSetTemp.AccountingView.Clear();

            long CostId=0;
            accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId,null);
           
            for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
            {
                nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
            }
            
            accountingTableAdapter.FillByAccId(nEWERPDataSetTemp.accounting, AccountId);

            int count = nEWERPDataSetTemp.accounting.Count;
            for (int i = 0; i < count; i++)
            {
                //nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.accounting.Rows[i]);
                vegStack.Push(nEWERPDataSetTemp.accounting.Rows[i]["accountid"].ToString());

            }
            if (count>0)
            {
                for (int j = 0; j < count; j++)
                {
                    GetDataLevel(int.Parse(vegStack.Pop().ToString()));
                }
            }
            

        }
        private void GetAccountSum()
        {
            DataView list = (DataView)accountingBindingSource1.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;
          

            for (int i = 0; i < T.Rows.Count; i++)
            {
              
   
                if (GLibrary.IsNumeric(T.Rows[i]["Totalfromvalue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["Totalfromvalue"].ToString());
                }
                if (GLibrary.IsNumeric(T.Rows[i]["TotalTovalue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["TotalTovalue"].ToString());
                }
                //if (GLibrary.IsNumeric(T.Rows[i]["ATotalBalance"].ToString()))
                //{
                //    Credit = Credit + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                //}

            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            if (Credit < 0)
            {
                txttotalBalance.Text = Credit.ToString();
                lblSum.Text = " ãÏíä ";
            }
            else
            {
                txttotalBalance.Text = Credit.ToString() ;
                lblSum.Text = " ÏÇÆä ";
            }
          
        }

        private void GetSum()
        {
            //DataView list = (DataView)accountingViewBindingSource.List;
            DataTable T = nEWERPDataSet.AccountingView; //list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;


            for (int i = 0; i < T.Rows.Count; i++)
            {
                if (i == 0)
                {
                    if (decimal.Parse(T.Rows[i]["Total"].ToString()) < -1)
                    {
                        nEWERPDataSet.AccountingView.Rows[i]["AccountValue"] = ((-1) * decimal.Parse(T.Rows[i]["Total"].ToString())).ToString() + " ãÏíä ";
                    }
                    else
                    {
                        nEWERPDataSet.AccountingView.Rows[i]["AccountValue"] = T.Rows[i]["Total"].ToString() + " ÏÇÆä ";
                    }


                }
                else
                {
                    decimal TotalSum = decimal.Parse(T.Rows[i]["Total"].ToString()) + decimal.Parse(T.Rows[i - 1]["Total"].ToString());
                    if (TotalSum < -1)
                    {
                        nEWERPDataSet.AccountingView.Rows[i]["AccountValue"] = ((-1) * TotalSum).ToString() + " ãÏíä ";
                    }
                    else
                    {
                        nEWERPDataSet.AccountingView.Rows[i]["AccountValue"] = TotalSum.ToString() + " ÏÇÆä ";
                    }
                }

                if (GLibrary.IsNumeric(T.Rows[i]["FromValue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["FromValue"].ToString());
                }
                if (GLibrary.IsNumeric(T.Rows[i]["ToValue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                }

            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalFromValue.Text) - decimal.Parse(txtTotalToValue.Text));
            if (Credit < 0)
            {
                txttotalBalance.Text = (Credit*-1).ToString();
                lblSum.Text = " ãÏíä ";
            }
            else
            {
                txttotalBalance.Text = Credit.ToString();
                lblSum.Text = " ÏÇÆä ";
            }
            // txttotalBalance.Text = Credit.ToString();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedValue != null)
            {
                AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
            }
            else
            {
                AccountId = 1;
            }
              int pos=accountingBindingSource.Find("AccountId", AccountId);
              if (pos > -1 || AccountId==1)
              {
                  ShowProductsRpt frm =new ShowProductsRpt();
                  frm.AccountName = cmbAccount.Text  ;

                                  
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
                  //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
                  //{
                  //    frm.choiceNum = 4;
                  //}
                  //else
                  //{
                        
                      frm.choiceNum = 2;
                      frm.AccountName = cmbAccount.Text ;
                 // }
                  frm.nEWERPDataSet = nEWERPDataSet;
                  if (GLibrary .IsNumeric ( txtTotalToValue.Text ))
                    {
                        frm.TotalTo= decimal.Parse (txtTotalToValue.Text);
                    }
                     if (GLibrary .IsNumeric ( txtTotalFromValue.Text ))
                    {
                        frm.TotalFrom = decimal.Parse (txtTotalFromValue.Text);
                    }
                     if (GLibrary .IsNumeric ( txttotalBalance.Text ))
                    {
                        frm.ValTotalSum = decimal.Parse (txttotalBalance.Text) ;
                    }
                    
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

       

      

      

      

      
      

     
      

       

       

        
    }
}