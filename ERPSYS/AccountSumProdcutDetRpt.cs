using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class AccountSumProdcutDetRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<int> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;
        private Nullable<long> CostId = null; 

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public AccountSumProdcutDetRpt()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
            this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            CmbItemSorted.DataSource = slItemSorted.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
              accountingBindingSource.DataMember ="accounting";
              accountingBindingSource.DataSource = nEWERPDataSetNew;

              this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
              costCentersBindingSource.Filter = "CostId >1";

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            accountingBindingSource.Sort = "AccountName";
            pRODUCTSBindingSource.Sort = "productname";
            cmbAccount.SelectedValue = -1;
            cmbProducts.SelectedValue = -1;
            CmbCostCenter.SelectedValue = -1;
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    cmbStroes.SelectedIndex = 0;
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            //Search();
                   
        }

         private void Search()
        {
            nEWERPDataSet.AccountingView.Rows.Clear();
              BranchId   =  null ;
              AccountId   =  null ;
              ToDate =null ;
              FromDate  = null;
              CostId = null;
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
              if (CmbCostCenter.SelectedValue != null)
              {
                  CostId = int.Parse(CmbCostCenter.SelectedValue.ToString());
              }
              else
              {
                  CostId = null;
              }
              if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              {
                  AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              }
              else
              {
                  AccountId = 1;
              }
              if (cmbProducts.SelectedValue != null && cmbProducts.Text != "")
              {
                  ProductId = int.Parse(cmbProducts.SelectedValue.ToString());
              }
              else
              {
                  ProductId = null;
              }

              if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
              int pos=accountingBindingSource.Find("AccountId", AccountId);
              if (pos > -1)
              {
                  //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
                  //{
                  //    accountingTableAdapter.FillByGetAccBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate);

                  //    StockDGView.Visible = false;
                  //    AccountDGView.Visible = true;
                  //    GetAccountSum();
                  //}
                  //else
                  //{
                  nEWERPDataSet.accounting.Clear();
                  nEWERPDataSet.AccountingView.Clear();
                  GetDataLevel(int.Parse (AccountId.Value.ToString ()) );
                      //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
                      //StockDGView.Visible = true;
                      //AccountDGView.Visible = false;
                     GetSum();
                 // }
              }
              else if (AccountId == 1) // ÌãíÚ ÇáÍÓÇÈÇÊ
              {
                  GetDataLevel(1);
              }
        }
        private void GetDataLevel(int AccountId)
        {

            Stack vegStack = new Stack();

            nEWERPDataSetTemp.accounting.Clear();

            this.accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId,null);
            if (nEWERPDataSetTemp.AccountingView.Rows.Count > 0)
            {
                GetSum();
            }
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
            if (count > 0)
            {
                for (int j = 0; j < count; j++)
                {
                    GetDataLevel(int.Parse(vegStack.Pop().ToString()));
                }
            }


        }
        //private void GetDataLevel(int AccountId)
        //{

        //    Stack vegStack = new Stack();

        //    nEWERPDataSetTemp.accounting.Clear();

        //    this.accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId);
        //    if (nEWERPDataSetTemp.AccountingView.Rows.Count > 0)
        //    {
        //        GetSum();
        //    }
        //    for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
        //    {
        //        nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
        //    }
            
        //    accountingTableAdapter.FillByAccId(nEWERPDataSetTemp.accounting, AccountId);

        //    int count = nEWERPDataSetTemp.accounting.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        //nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.accounting.Rows[i]);
        //        vegStack.Push(nEWERPDataSetTemp.accounting.Rows[i]["accountid"].ToString());

        //    }
        //    if (count>0)
        //    {
        //        for (int j = 0; j < count; j++)
        //        {
        //            GetDataLevel(int.Parse(vegStack.Pop().ToString()));
        //        }
        //    }


        //}
        private void GetAccountSum()
        {
            DataView list = (DataView)accountingBindingSource1.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            //decimal Credit = 0;
          

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

            //txtTotalToValue.Text = Tovalue.ToString();
            //txtTotalFromValue.Text = Fromvalue.ToString();
            //Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            //if (Credit < 0)
            //{
            //    txttotalBalance.Text = Credit.ToString();
            //    lblSum.Text = " ãÏíä ";
            //}
            //else
            //{
            //    txttotalBalance.Text = Credit.ToString() ;
            //    lblSum.Text = " ÏÇÆä ";
            //}
          
        }

        private void GetSum()
        {
            //DataView list = (DataView)accountingViewBindingSource.List;
            DataTable T = nEWERPDataSetTemp.AccountingView; //list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            //decimal Credit = 0;
            decimal TotalSum = 0;

            for (int i = 0; i < T.Rows.Count; i++)
            {
                if (i == 0)
                {
                    if (decimal.Parse(T.Rows[i]["Total"].ToString()) < -1)
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = ((-1) * decimal.Parse(T.Rows[i]["Total"].ToString())).ToString() + " ãÏíä ";

                    }
                    else
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = T.Rows[i]["Total"].ToString() + " ÏÇÆä ";
                    }
                    TotalSum = decimal.Parse(T.Rows[i]["Total"].ToString());

                }
                else
                {
                    TotalSum = TotalSum + decimal.Parse(T.Rows[i]["Total"].ToString());
                    //decimal TotalSum = decimal.Parse(T.Rows[i]["Total"].ToString()) + decimal.Parse(T.Rows[i - 1]["Total"].ToString());
                    if (TotalSum < -1)
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = ((-1) * TotalSum).ToString() + " ãÏíä ";
                    }
                    else
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = TotalSum.ToString() + " ÏÇÆä ";
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

            //txtTotalToValue.Text = Tovalue.ToString();
            //txtTotalFromValue.Text = Fromvalue.ToString();
            //Credit = (decimal.Parse(txtTotalFromValue.Text) - decimal.Parse(txtTotalToValue.Text));
            //if (Credit < 0)
            //{
            //    txttotalBalance.Text = (Credit*-1).ToString();
            //    lblSum.Text = " ãÏíä ";
            //}
            //else
            //{
            //    txttotalBalance.Text = Credit.ToString();
            //    lblSum.Text = " ÏÇÆä ";
            //}
            //// txttotalBalance.Text = Credit.ToString();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Search();  
            if (cmbAccount.SelectedValue != null) { AccountId = int.Parse(cmbAccount.SelectedValue.ToString()); }
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
                        
                      frm.choiceNum = 4;
                      frm.AccountName = cmbAccount.Text ;
                 // }
                  frm.nEWERPDataSet = nEWERPDataSet;
                  if (GLibrary.IsNumeric(txtTotalToValue.Text))
                  {
                      frm.TotalTo = decimal.Parse(txtTotalToValue.Text);
                  }
                  if (GLibrary.IsNumeric(txtTotalFromValue.Text))
                  {
                      frm.TotalFrom = decimal.Parse(txtTotalFromValue.Text);
                  }
                  if (GLibrary.IsNumeric(txttotalBalance.Text))
                  {
                      frm.ValTotalSum = decimal.Parse(txttotalBalance.Text);
                  }
                    
                    frm.ShowDialog(this);
              }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ng("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

      

       

      

      

      

      
      

     
      

       

       

        
    }
}