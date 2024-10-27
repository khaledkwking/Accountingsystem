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
    public partial class AccountSumCustomer : DockContent
    {
      private Nullable<long> BranchId   =  null ;
        private string  AccountIdFrom   =  "" ;
        private string AccountIdTo = "";

        private string CostIdFrom = "";
        private string CostIdTo = "";
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;
        private Nullable<long> CostId = null; 
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);
        private DateTime FromDateB;
        private DateTime ToDateB;
        private decimal TotBeforeBlance;
        private int sumrpt;
       private  NEWERPDataSet nEWERPDataSetNew = new NEWERPDataSet();
        public AccountSumCustomer()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);

            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.

            accountingBindingSource1.DataMember ="accounting";
            accountingBindingSource1.DataSource = nEWERPDataSetNew;

              accountingBindingSourceCust1.DataMember = "accounting";
              accountingBindingSourceCust1.DataSource = nEWERPDataSetNew;

              accountingBindingSourceCust2.DataMember = "accounting";
              accountingBindingSourceCust2.DataSource = nEWERPDataSetNew;

              costCentersBindingSource2.Filter = "CostId >1";
              costCentersBindingSource1.Filter = "CostId >1";

              accountingBindingSource.Filter = "AccountparentId=" + Messages.custaccid.ToString();
              accountingBindingSourceCust2.Filter = "AccountparentId=" + Messages.custaccid.ToString();
              accountingBindingSourceCust1.Filter = "AccountparentId=" + Messages.custaccid.ToString();

              this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
       
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            accountingBindingSource1.Sort = "AccountName";
            pRODUCTSBindingSource.Sort = "productname";
            cmbCust1.SelectedValue = -1;
            cmbProducts.SelectedValue = -1;
            CmbCostCenter.SelectedValue = -1;
            CmbCostCenter1.SelectedValue = -1;
            cmbCust2.SelectedValue = -1;

            txtFromDate.Text = "1/1/" + DateTime.Today.Year;
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    cmbStroes.SelectedIndex = 0;
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            //Search();

            //if (Messages.Usertype != Messages.AdminUser)
            //{
            //    cmbBranch.SelectedValue = Messages.CurBranch;
            //    cmbBranch.Enabled = false;
            //}
            //else
            //{

            //}

        }

         private void Search()
        {
              TotBeforeBlance = 0;
              nEWERPDataSet.AccountingView.Rows.Clear();
            nEWERPDataSet.accounting.Rows.Clear();
            BranchId   =  null ;
              //AccountIdFrom   =  null ;
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
                      MessageBox.Show(Messages.CheckDate, "Õ–› ⁄‰’—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                      MessageBox.Show(Messages.CheckDate, "Õ–› ⁄‰’—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                      return;
                  }
              }
              else
              {
                  ToDate = null;
              }
              ToDateB = new DateTime();
              if (FromDate == null)
              {
                  //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
                  ToDateB = DateTime.Parse(new DateTime(2009, 12, 31).ToShortDateString() + " 23:59"); //null;
              }
              else
              {
                  DateTime temp = new DateTime();
                  temp = DateTime.Parse(FromDate.ToString());
                  ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
                  //ToDateB = temp.AddDays(-1);
              }
              if (FromDate == null)
              {
                  FromDateB = new DateTime(2009, 1, 1);
              }
              else
              {
                  if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
                  {
                      FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
                      //FromDateB = ToDateB;
                  }
                  else
                  {
                      DateTime temp = new DateTime();
                      temp = DateTime.Parse(ToDateB.ToString());
                      FromDateB = DateTime.Parse(temp.ToShortDateString() + " 00:00");
                      //FromDateB = ToDateB; //new DateTime(DateTime.Today.Year, 1, 1);
                  }
              }
             //ToDateB = new DateTime();
             // if (FromDate == null)
             // {
             //     ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
             // }
             // else
             // {
             //     DateTime temp=new DateTime ();
             //     temp = DateTime.Parse(FromDate.ToString());
             //     ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
             //     //ToDateB = temp.AddDays(-1);
             // }
             // if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
             // {
             //     FromDateB = ToDateB;
             // }
             // else
             // {
             //     FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
             // }
              //if (CmbCostCenter.SelectedValue != null)
              //{
              //    CostId = int.Parse(CmbCostCenter.SelectedValue.ToString());
              //}
              //else
              //{
              //    CostId = null;
              //}

              //if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              //{
              //    AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              //}
              //else
              //{
              //    AccountId = 1;
              //}
            
             if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
             if (cmbCust1.Text != "") { AccountIdFrom = cmbCust1.SelectedValue.ToString (); }
             if (cmbCust2.Text != "") { AccountIdTo = cmbCust2.SelectedValue.ToString(); }
             if (CmbCostCenter.Text != "") { CostIdFrom = CmbCostCenter.Text; }
             if (CmbCostCenter1.Text != "") { CostIdTo = CmbCostCenter1.Text; }
 

             nEWERPDataSet.AccountingView.Clear();
             nEWERPDataSet.accounting.Clear();
             if (cmbCust1.Text != "" && cmbCust2.Text !="")
             {
                 accountingBindingSource1.Filter = "AccountId>=" + AccountIdFrom.ToString() + " AND AccountId <=" + AccountIdTo.ToString() + " and AccountparentId=" + Messages.custaccid.ToString(); 
                 sumrpt = 2;

                 for (int i = 0; i < accountingBindingSource1.Count; i++)
                 {
                     //int pos = accountingBindingSource1.Find("AccountId", AccountId);
                     //if (pos > -1)
                     //{
                     int AccountId = int.Parse(((DataRowView)accountingBindingSource1[i])["AccountId"].ToString());
                     TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                     TotBeforeBlance = TotBeforeBlance * -1;

                     GetDataLevel(int.Parse(AccountId.ToString()));
                     GetSum();
                     // }
                     //}
                     //else if (AccountId == 1) // Ã„Ì⁄ «·Õ”«»« 
                     //{
                     //    GetDataLevel(1);
                     //}

                 }
             }
             else if (CmbCostCenter.Text != "" & CmbCostCenter1.Text != "")
             {
                 
                 sumrpt = 3;
                 costCentersBindingSource.Filter = "convert([costCode], 'System.Int64') >=" + CostIdFrom.ToString() + " AND convert([costCode], 'System.Int64') <=" + CostIdTo.ToString() + "";
                 for (int i = 0; i < costCentersBindingSource.Count; i++)
                 {
                     int CurCostId = int.Parse(((DataRowView)costCentersBindingSource[i])["CostId"].ToString());
                     //this.accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, null, BranchId, FromDate, ToDate, ProductId, CurCostId);
                     this.accountingViewTableAdapter.FillByNotStart(nEWERPDataSetTemp.AccountingView,null, BranchId, FromDate, ToDate, ProductId, CurCostId);
                     
                     if (nEWERPDataSetTemp.AccountingView.Rows.Count > 0)
                     {
                         GetSum();
                     }
                     for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
                     {
                         nEWERPDataSetTemp.AccountingView.Rows[j]["TotBeforeBlance"] = TotBeforeBlance;
                         nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
                     }
                 }
             }
        }
        private void GetDataLevel(int AccountId)
        {
            Stack vegStack = new Stack();
            nEWERPDataSetTemp.accounting.Clear();

            //this.accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId,CostId );
            this.accountingViewTableAdapter.FillByNotStart(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId);
           
            if (nEWERPDataSetTemp.AccountingView.Rows.Count > 0)
            {
                GetSum();
            }
            for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
            {
               

                nEWERPDataSetTemp.AccountingView.Rows[j]["TotBeforeBlance"] = TotBeforeBlance;
                nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
            }
            
            accountingTableAdapter.FillByParam(nEWERPDataSetTemp.accounting, AccountId, AccountId);

            if (nEWERPDataSetTemp.accounting.Rows.Count > 0)
            {
                TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                TotBeforeBlance = TotBeforeBlance * -1;
                nEWERPDataSetTemp.accounting.Rows[0]["TotalBalanceB"] = TotBeforeBlance;
                nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTemp.accounting.Rows[0]);
            }

            //if (nEWERPDataSetTemp.accounting.Rows.Count > 0)
            //{
            //    for (int j = 0; j < nEWERPDataSetTem.counp.accounting.Rows.Count; j++)
            //    {
            //        Boolean curMainNode = false;
            //        if (nEWERPDataSetTemp.accounting.Rows[j]["MainNode"] != DBNull.Value)
            //        {
            //            curMainNode = Boolean.Parse(nEWERPDataSetTemp.accounting.Rows[j]["MainNode"].ToString());
            //        }
            //        if (!curMainNode)
            //        {
            //            int curAccountId = int.Parse(nEWERPDataSetTemp.accounting.Rows[j]["AccountId"].ToString());
            //            TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(curAccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
            //            TotBeforeBlance = TotBeforeBlance * -1;

            //            nEWERPDataSetTemp.accounting.Rows[j]["TotalBalanceB"] = TotBeforeBlance;

            //            nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTemp.accounting.Rows[j]);

            //        }
            //    }
            //}


            //int count = nEWERPDataSetTemp.accounting.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    //nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.accounting.Rows[i]);
            //    vegStack.Push(nEWERPDataSetTemp.accounting.Rows[i]["accountid"].ToString());

            //}
            //if (count>0)
            //{
            //    for (int j = 0; j < count; j++)
            //    {
            //        GetDataLevel(int.Parse(vegStack.Pop().ToString()));
            //    }
            //}


        }
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
            //    lblSum.Text = " „œÌ‰ ";
            //}
            //else
            //{
            //    txttotalBalance.Text = Credit.ToString() ;
            //    lblSum.Text = " œ«∆‰ ";
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
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = ((-1) * decimal.Round(decimal.Parse(T.Rows[i]["Total"].ToString()),3)).ToString() + " „œÌ‰ ";

                    }
                    else
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = decimal.Round (decimal.Parse(T.Rows[i]["Total"].ToString()),3).ToString () + " œ«∆‰ ";
                    }
                    TotalSum = decimal.Parse(T.Rows[i]["Total"].ToString());
                    TotalSum = decimal.Round(TotalSum, 3);

                }
                else
                {
                    TotalSum = TotalSum + decimal.Parse(T.Rows[i]["Total"].ToString());
                    TotalSum= decimal.Round(TotalSum, 3); 
                    //decimal TotalSum = decimal.Parse(T.Rows[i]["Total"].ToString()) + decimal.Parse(T.Rows[i - 1]["Total"].ToString());
                    if (TotalSum < -1)
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = ((-1) * TotalSum).ToString() + " „œÌ‰ ";
                    }
                    else
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = TotalSum.ToString() + " œ«∆‰ ";
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
            //    lblSum.Text = " „œÌ‰ ";
            //}
            //else
            //{
            //    txttotalBalance.Text = Credit.ToString();
            //    lblSum.Text = " œ«∆‰ ";
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
            //if (cmbAccount.SelectedValue != null) { AccountId = int.Parse(cmbAccount.SelectedValue.ToString()); }


            //int pos = accountingBindingSource1.Find("AccountId", AccountIdFrom);
            //if (pos > -1 )
            //{
                  ShowProductsRpt frm =new ShowProductsRpt();


                  frm.sumrpt = sumrpt;
          
                  frm.AccountName = "«·⁄„·«¡"  ;
                  frm.AccountCode = "-----";
              
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
                      frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString () + " 23:59");
                  }
                  //if (((DataRowView)accountingBindingSource1[pos])["MainNode"].ToString() == Boolean.TrueString)
                  //{
                  //    frm.choiceNum = 4;
                  //}
                  //else
                  //{
                        
                  frm.choiceNum = 2;
                  //frm.AccountName = cmbAccount.Text ;
                  frm.TotBeforeBlance = TotBeforeBlance;
            // }
          
            //for (int j = 0; j < nEWERPDataSetNew.accounting.Rows.Count; j++)
            //{
               
            //    nEWERPDataSet.accounting.ImportRow(nEWERPDataSetNew.accounting.Rows[j]);
            //}
            //string str = "accountId >=" + AccountIdFrom.ToString() + " And accountId <=" + AccountIdTo.ToString();
            //nEWERPDataSet.accounting.Select(str);

            //accountingBindingSource1.Filter = "convert([AccountCode], 'System.Int64') >=" + AccountIdFrom.ToString() + " AND convert([AccountCode], 'System.Int64') <=" + AccountIdTo.ToString() + "";

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
                    
                    frm.Show();
             // }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void accountingBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}