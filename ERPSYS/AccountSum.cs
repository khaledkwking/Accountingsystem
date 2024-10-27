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
    public partial class AccountSum : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<int> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;
        private Nullable<long> CostId = null;
        private Nullable<long> MachineId = null; 
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        //private NEWERPDataSet nEWERPDataSetTemp1 = new NEWERPDataSet();

        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);
        private DateTime FromDateB;
        private DateTime ToDateB;
        private decimal TotBeforeBlance;
        private DateTime StartDate;
        Boolean flag = true;
        public AccountSum()
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
            flag = false;
            txtFromDate.Text = "1/1/" + DateTime.Today.Year;
            //lblMachineName.Text = "";
            // TODO: This line of code loads data into the 'nEWERPDataSet.Machines' table. You can move, or remove it, as needed.
                //this.machinesTableAdapter.Fill(this.nEWERPDataSet.Machines);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            CmbItemSorted.DataSource = slItemSorted.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
              accountingBindingSource.DataMember ="accounting";
              accountingBindingSource.DataSource = nEWERPDataSetNew;
              costCentersBindingSource.Filter = "CostId >1";
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
            pRODUCTSBindingSource.Sort = "productname";
            cmbAccount.SelectedValue = -1;
            cmbProducts.SelectedValue = -1;
            CmbCostCenter.SelectedValue = -1;
            AccountCodecmbBox.SelectedValue = -1;
            //cmbMachineId.SelectedValue = -1;

          
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
            flag = true;
        }
        private void Search()
        {
            accountingViewBindingSource.Sort = "qidid DESC";
            TotBeforeBlance = 0;
            nEWERPDataSet.AccountingView.Rows.Clear();
            BranchId = null;
            AccountId = null;
            ToDate = null;
            FromDate = null;
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
            //-----------------------------------------ÑÕíÏ ÓÇÈÞ
            //ToDateB = new DateTime();
            //if (FromDate == null)
            //{
            //    //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
            //    ToDateB = DateTime.Parse(new DateTime(2009, 12, 31).ToShortDateString() + " 23:59"); //null;
            //}
            //else
            //{
            //    DateTime temp = new DateTime();
            //    temp = DateTime.Parse(FromDate.ToString());
            //    ToDateB = temp.AddDays(-1);
            //    ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");
            //    //ToDateB = temp.AddDays(-1);
            //}
            ////-----------------------------------------


            //if (FromDate == null)
            //{
            //    FromDateB = new DateTime(2009, 1, 1);
            //}
            //else
            //{
            //    if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
            //    {
            //        FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
            //        //FromDateB = ToDateB;
            //    }
            //    else
            //    {
            //        DateTime temp = new DateTime();
            //        temp = DateTime.Parse(ToDateB.ToString());
            //        FromDateB = DateTime.Parse(temp.ToShortDateString() + " 00:00");
            //        //FromDateB = ToDateB; //new DateTime(DateTime.Today.Year, 1, 1);
            //    }
            //}

            //--------------------------NEw Code ----------------------
            ToDateB = new DateTime();
            if (FromDate == null)
            {
                //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
                ToDateB = DateTime.Parse(new DateTime(2008, 12, 31).ToShortDateString() + " 23:59"); //null;
                FromDateB = DateTime.Parse(new DateTime(2008, 12, 31).ToShortDateString()); //null;
            }
            else
            {
                DateTime temp = new DateTime();
                temp = DateTime.Parse(FromDate.ToString());
                ToDateB = temp.AddDays(-1);
                //ToDateB = new DateTime(FromDate.Value.Year, 1, 1);
                ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");

                //DateTime temp = new DateTime();
                //temp = DateTime.Parse(FromDate.ToString());
                //ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
                ////ToDateB = temp.AddDays(-1);
                if (FromDate.Value.Day == 1 && FromDate.Value.Month == 1)
                {
                    //FromDateB = ToDateB;
                    FromDateB = new DateTime(2009, 1, 1);
                }
                else
                {
                    FromDateB = DateTime.Parse(new DateTime(FromDate.Value.Year, 1, 1).ToShortDateString()); //null;

                }
            }
            StartDate = DateTime.Parse(new DateTime(FromDate.Value.Year, 1, 1).ToShortDateString()); //null;

            ///----------------end of new code---------------------
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
            ProductId = null;

            if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
            int pos = accountingBindingSource.Find("AccountId", AccountId);
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
                GetDataLevel(int.Parse(AccountId.Value.ToString()));
                //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
                //StockDGView.Visible = true;
                //AccountDGView.Visible = false;
                //if (FromDate != null)
                //{


                //TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalanceLast(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB, StartDate).ToString());
                //TotBeforeBlance = TotBeforeBlance * -1;

                //TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                //TotBeforeBlance = TotBeforeBlance * -1;

                //}
                GetSum();

                // }
            }
            else if (AccountId == 1) // ÌãíÚ ÇáÍÓÇÈÇÊ
            {
                GetDataLevel(1);
            }
            GetAccountSum();
            if (accountingViewBindingSource.Count > 0)
            {
                accountingViewBindingSource.Position = 0;
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
                TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                TotBeforeBlance = TotBeforeBlance * -1;
                nEWERPDataSetTemp.AccountingView.Rows[j]["TotBeforeBlance"] = TotBeforeBlance;

                nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
            }
            if (nEWERPDataSetTemp.AccountingView.Rows.Count == 0)
            {
                TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                TotBeforeBlance = TotBeforeBlance * -1;
            }

            if (nEWERPDataSetTemp.AccountingView.Rows.Count == 0)
            {
                this.accountingViewTableAdapter.FillByNotStartMove(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId);
                for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
                {

                   
                    nEWERPDataSet.AccountingView.ImportRow(nEWERPDataSetTemp.AccountingView.Rows[j]);
                }
            }

            accountingTableAdapter.FillByAccId(nEWERPDataSetTemp.accounting, AccountId);

            if (nEWERPDataSetTemp.accounting.Rows.Count > 0)
            {

                for (int j = 0; j < nEWERPDataSetTemp.accounting.Rows.Count; j++)
                {
                    Boolean  curMainNode = false;
                    if (nEWERPDataSetTemp.accounting.Rows[j]["MainNode"] != DBNull.Value)
                    {
                        curMainNode = Boolean.Parse(nEWERPDataSetTemp.accounting.Rows[j]["MainNode"].ToString());
                    }
                    if (!curMainNode)
                    {
                        int curAccountId = int.Parse(nEWERPDataSetTemp.accounting.Rows[j]["AccountId"].ToString());
                        TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(curAccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
                        TotBeforeBlance = TotBeforeBlance * -1;

                       
                            nEWERPDataSetTemp.accounting.Rows[j]["TotalBalanceB"] = TotBeforeBlance;

                            nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTemp.accounting.Rows[j]);
                       
                    }
                }
            }

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
        // private void Search()
        //{
        //    TotBeforeBlance = 0;
        //    nEWERPDataSet.AccountingView.Rows.Clear();
        //      BranchId   =  null ;
        //      AccountId   =  null ;
        //      ToDate =null ;
        //      FromDate  = null;
        //      CostId = null;
        //      if (txtFromDate.Text != "")
        //      {
        //          if (GLibrary.IsDate(txtFromDate.Text))
        //          {
        //              if (txtFromDate.Text != "") { FromDate = DateTime.Parse(txtFromDate.Text); }

        //          }
        //          else
        //          {
        //              MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //              return;
        //          }
        //      }
        //      else
        //      {
        //          FromDate = null;
        //      }
        //      if (txtToDate.Text != "")
        //      {
        //          if (GLibrary.IsDate(txtToDate.Text))
        //          {
        //              if (txtToDate.Text != "") { ToDate = DateTime.Parse(txtToDate.Text + " 23:59"); }
        //          }
        //          else
        //          {
        //              MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //              return;
        //          }
        //      }
        //      else
        //      {
        //          ToDate = null;
        //      }
        //      ToDateB = new DateTime();
        //      if (FromDate == null)
        //      {
        //          //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
        //          ToDateB = DateTime.Parse(new DateTime(2009, 12, 31).ToShortDateString() + " 23:59"); //null;
        //      }
        //      else
        //      {
        //          DateTime temp = new DateTime();
        //          temp = DateTime.Parse(FromDate.ToString());
        //          ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
        //          //ToDateB = temp.AddDays(-1);
        //      }
        //      if (FromDate == null)
        //      {
        //          FromDateB = new DateTime(2009, 1, 1);
        //      }
        //      else
        //      {
        //          if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
        //          {
        //              FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
        //              //FromDateB = ToDateB;
        //          }
        //          else
        //          {
        //              DateTime temp = new DateTime();
        //              temp = DateTime.Parse(ToDateB.ToString());
        //              FromDateB = DateTime.Parse(temp.ToShortDateString() + " 00:00");
        //              //FromDateB = ToDateB; //new DateTime(DateTime.Today.Year, 1, 1);
        //          }
        //      }
        //     //ToDateB = new DateTime();
        //     // if (FromDate == null)
        //     // {
        //     //     ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
        //     // }
        //     // else
        //     // {
        //     //     DateTime temp=new DateTime ();
        //     //     temp = DateTime.Parse(FromDate.ToString());
        //     //     ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
        //     //     //ToDateB = temp.AddDays(-1);
        //     // }
        //     // if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
        //     // {
        //     //     FromDateB = ToDateB;
        //     // }
        //     // else
        //     // {
        //     //     FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
        //     // }
        //      if (CmbCostCenter.SelectedValue != null)
        //      {
        //          CostId = int.Parse(CmbCostCenter.SelectedValue.ToString());
        //      }
        //      else
        //      {
        //          CostId = null;
        //      }

        //      if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
        //      {
        //          AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
        //      }
        //      else
        //      {
        //          AccountId = 1;
        //      }
        //      if (cmbProducts.SelectedValue != null && cmbProducts.Text != "")
        //      {
        //          ProductId = int.Parse(cmbProducts.SelectedValue.ToString());
        //      }
        //      else
        //      {
        //          ProductId = null;
        //      }

        //      if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
        //      int pos=accountingBindingSource.Find("AccountId", AccountId);
        //      if (pos > -1)
        //      {
        //          //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
        //          //{
        //          //    accountingTableAdapter.FillByGetAccBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate);

        //          //    StockDGView.Visible = false;
        //          //    AccountDGView.Visible = true;
        //          //    GetAccountSum();
        //          //}
        //          //else
        //          //{
        //          nEWERPDataSet.accounting.Clear();
        //          nEWERPDataSet.AccountingView.Clear();
        //          GetDataLevel(int.Parse (AccountId.Value.ToString ()) );
        //              //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
        //              //StockDGView.Visible = true;
        //              //AccountDGView.Visible = false;
        //          //if (FromDate != null)
        //          //{
        //          TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
        //          TotBeforeBlance = TotBeforeBlance * -1;
        //          //}
        //          GetSum();
        //         // }
        //      }
        //      else if (AccountId == 1) // ÌãíÚ ÇáÍÓÇÈÇÊ
        //      {
        //          GetDataLevel(1);
        //      }
        //}
        //private void Search()
        //{
        //    accountingViewBindingSource.Sort = "qidid DESC";
       
        //    TotBeforeBlance = 0;
        //    nEWERPDataSet.AccountingView.Rows.Clear();
        //    BranchId = null;
        //    AccountId = null;
        //    ToDate = null;
        //    FromDate = null;
        //    CostId = null;
        //    MachineId = null;
        //    if (txtFromDate.Text != "")
        //    {
        //        if (GLibrary.IsDate(txtFromDate.Text))
        //        {
        //            if (txtFromDate.Text != "") { FromDate = DateTime.Parse(txtFromDate.Text); }

        //        }
        //        else
        //        {
        //            MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        FromDate = null;
        //    }
        //    if (txtToDate.Text != "")
        //    {
        //        if (GLibrary.IsDate(txtToDate.Text))
        //        {
        //            if (txtToDate.Text != "") { ToDate = DateTime.Parse(txtToDate.Text + " 23:59"); }
        //        }
        //        else
        //        {
        //            MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        ToDate = null;
        //    }
        //    //-----------------------------------------ÑÕíÏ ÓÇÈÞ
        //    //ToDateB = new DateTime();
        //    //if (FromDate == null)
        //    //{
        //    //    //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
        //    //    ToDateB = DateTime.Parse(new DateTime(2009, 12, 31).ToShortDateString() + " 23:59"); //null;
        //    //}
        //    //else
        //    //{
        //    //    DateTime temp = new DateTime();
        //    //    temp = DateTime.Parse(FromDate.ToString());
        //    //    ToDateB = temp.AddDays(-1);
        //    //    ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");
        //    //    //ToDateB = temp.AddDays(-1);
        //    //}
        //    ////-----------------------------------------


        //    //if (FromDate == null)
        //    //{
        //    //    FromDateB = new DateTime(2009, 1, 1);
        //    //}
        //    //else
        //    //{
        //    //    if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
        //    //    {
        //    //        FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
        //    //        //FromDateB = ToDateB;
        //    //    }
        //    //    else
        //    //    {
        //    //        DateTime temp = new DateTime();
        //    //        temp = DateTime.Parse(ToDateB.ToString());
        //    //        FromDateB = DateTime.Parse(temp.ToShortDateString() + " 00:00");
        //    //        //FromDateB = ToDateB; //new DateTime(DateTime.Today.Year, 1, 1);
        //    //    }
        //    //}

        //    //--------------------------NEw Code ----------------------
        //    ToDateB = new DateTime();
        //    if (FromDate == null)
        //    {
        //        //ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
        //        ToDateB = DateTime.Parse(new DateTime(2008, 12, 31).ToShortDateString() + " 23:59"); //null;
        //        FromDateB = DateTime.Parse(new DateTime(2008, 12, 31).ToShortDateString()); //null;
        //    }
        //    else
        //    {
        //        DateTime temp = new DateTime();
        //        temp = DateTime.Parse(FromDate.ToString());
        //        ToDateB = temp.AddDays(-1);
        //        ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");

        //        //DateTime temp = new DateTime();
        //        //temp = DateTime.Parse(FromDate.ToString());
        //        //ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
        //        ////ToDateB = temp.AddDays(-1);
        //        if (FromDate.Value.Day == 1 && FromDate.Value.Month == 1)
        //        {
        //            FromDateB = ToDateB;
        //            //FromDateB = new DateTime(2009, 1, 1);
        //        }
        //        else
        //        {
        //            FromDateB = DateTime.Parse(new DateTime(FromDate.Value.Year, 1, 1).ToShortDateString()); //null;

        //        }
        //    }
        //    StartDate = DateTime.Parse(new DateTime(FromDate.Value.Year, 1, 1).ToShortDateString()); //null;

        //    ///----------------end of new code---------------------
        //    //ToDateB = new DateTime();
        //    // if (FromDate == null)
        //    // {
        //    //     ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
        //    // }
        //    // else
        //    // {
        //    //     DateTime temp=new DateTime ();
        //    //     temp = DateTime.Parse(FromDate.ToString());
        //    //     ToDateB = DateTime.Parse(temp.ToShortDateString() + " 23:59");
        //    //     //ToDateB = temp.AddDays(-1);
        //    // }
        //    // if (FromDate == new DateTime(DateTime.Today.Year, 1, 1))
        //    // {
        //    //     FromDateB = ToDateB;
        //    // }
        //    // else
        //    // {
        //    //     FromDateB = new DateTime(DateTime.Today.Year, 1, 1);
        //    // }
          

        //    if (CmbCostCenter.SelectedValue != null)
        //    {
        //        CostId = int.Parse(CmbCostCenter.SelectedValue.ToString());
        //    }
        //    else
        //    {
        //        CostId = null;
        //    }

        //    if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
        //    {
        //        AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
        //    }
        //    else
        //    {
        //        AccountId = 1;
        //    }
        //    ProductId = null;

        //    if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
        //    int pos = accountingBindingSource.Find("AccountId", AccountId);
        //    if (pos > -1)
        //    {
        //        //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
        //        //{
        //        //    accountingTableAdapter.FillByGetAccBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate);

        //        //    StockDGView.Visible = false;
        //        //    AccountDGView.Visible = true;
        //        //    GetAccountSum();
        //        //}
        //        //else
        //        //{
        //        nEWERPDataSet.accounting.Clear();
        //        nEWERPDataSet.AccountingView.Clear();
        //        GetDataLevel(int.Parse(AccountId.Value.ToString()));
        //        //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
        //        //StockDGView.Visible = true;
        //        //AccountDGView.Visible = false;
        //        //if (FromDate != null)
        //        //{
        //        TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalanceLast(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB, StartDate).ToString());
        //        TotBeforeBlance = TotBeforeBlance * -1;
        //        //TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
        //        //TotBeforeBlance = TotBeforeBlance * -1;

        //        //}
        //        GetSum();

        //        // }
        //    }
        //    else if (AccountId == 1) // ÌãíÚ ÇáÍÓÇÈÇÊ
        //    {
        //        GetDataLevel(1);
        //    }
        //    GetAccountSum();
        //    if (accountingViewBindingSource.Count > 0)
        //    {
        //        accountingViewBindingSource.Position = 0;
        //    }
        //}
        //private void GetDataLevel(int AccountId)
        //{
        //    Stack vegStack = new Stack();
        //    nEWERPDataSetTemp.accounting.Clear();

        //    //this.accountingViewTableAdapter.FillBy(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId,CostId );
        //    this.accountingViewTableAdapter.FillByNotStart(nEWERPDataSetTemp.AccountingView, AccountId, BranchId, FromDate, ToDate, ProductId, CostId, MachineId);
            
        //    if (nEWERPDataSetTemp.AccountingView.Rows.Count > 0)
        //    {
        //        GetSum();
        //    }
        //    for (int j = 0; j < nEWERPDataSetTemp.AccountingView.Rows.Count; j++)
        //    {
        //        TotBeforeBlance = decimal.Parse(accountingViewTableAdapter.GetBeforeTotBalance(AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB).ToString());
        //        TotBeforeBlance = TotBeforeBlance * -1;
        //                nEWERPDataSetTemp.AccountingView.Rows[j]["TotBeforeBlance"] = TotBeforeBlance;
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
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = ((-1) * decimal.Round(decimal.Parse(T.Rows[i]["Total"].ToString()),3)).ToString() + " ãÏíä ";

                    }
                    else
                    {
                        nEWERPDataSetTemp.AccountingView.Rows[i]["AccountValue"] = decimal.Round (decimal.Parse(T.Rows[i]["Total"].ToString()),3).ToString () + " ÏÇÆä ";
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
        
            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
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
            printRpt(1);
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

       

        private void btnView_Click(object sender, EventArgs e)
        {
            printRpt(2);
           
        }

        private void printRpt(int choice)
        {
            Search();
            if (cmbAccount.SelectedValue != null) { AccountId = int.Parse(cmbAccount.SelectedValue.ToString()); }


            int pos = accountingBindingSource.Find("AccountId", AccountId);
            if (pos > -1 || AccountId == 1)
            {
                ShowProductsRpt frm = new ShowProductsRpt();
                if (CmbCostCenter.SelectedValue != null)
                {
                    frm.sumrpt = 3;
                    //frm.sumrpt = 1;
                    frm.costName = CmbCostCenter.Text;
                }
                else
                {
                    if (((DataRowView)accountingBindingSource.Current)["MainNode"] != DBNull.Value)
                    {
                        if (((DataRowView)accountingBindingSource.Current)["MainNode"].ToString() == Boolean.TrueString)
                        {
                            if (chkBoxMonth.Checked)
                            {
                                frm.sumrpt = 3;
                            }
                            else
                            {
                                frm.sumrpt = 2;
                            }

                        }
                        else
                        {
                            frm.sumrpt = 1;
                        }
                    }
                }


                frm.AccountName = cmbAccount.Text;
                frm.AccountCode = AccountCodecmbBox.Text;

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
                frm.choice = choice;

                frm.AccountName = cmbAccount.Text;
                if (PerviouscheckBox.Checked)
                {
                    frm.TotBeforeBlance = TotBeforeBlance;
                }
                else
                {
                    frm.TotBeforeBlance = 0;
                }
                // }
                frm.nEWERPDataSet = nEWERPDataSet;
                if (GLibrary.IsNumeric(txtTotalToValue.Text))
                {
                    frm.TotalTo = decimal.Parse(txtTotalToValue.Text);
                    frm.ToValueDesc = GLibrary.FigureInWordsNumType(double.Parse(txtTotalToValue.Text), 1);
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
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void StudentsView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (StudentsView.SelectedRows.Count > 0)
            {
                string qidid = StudentsView.SelectedRows[0].Cells["qidid"].Value.ToString();
                int QidType = int.Parse(StudentsView.SelectedRows[0].Cells["QidType"].Value.ToString());

                switch (QidType)
                {
                    case 1:
                        QidsAdd frmQidsAdd = new QidsAdd();
                        frmQidsAdd.EditFlag = true;
                        frmQidsAdd.qidid = long.Parse(qidid);
                        frmQidsAdd.ShowDialog();

                        break;
                    case 6: //out 
                        QidOutAdd frmQidOutAdd = new QidOutAdd();
                        frmQidOutAdd.EditFlag = true;
                        frmQidOutAdd.qidid = long.Parse(qidid);
                        frmQidOutAdd.ShowDialog();
                        break;
                    case 7: //in
                        QidInAdd frmQidInAdd = new QidInAdd();
                        frmQidInAdd.EditFlag = true;
                        frmQidInAdd.qidid = long.Parse(qidid);
                        frmQidInAdd.ShowDialog();
                        break;
                }
                 
             }
        }

       

        
    }
}