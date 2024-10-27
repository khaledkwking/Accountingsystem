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
    public partial class AccountBalanceRefVer : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
        private Nullable<long> CostId = null; 
        private DateTime FromDateB ;
        private DateTime ToDateB;
        private Boolean  bFlag=false ;
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetTempOld = new NEWERPDataSet();
        private DateTime StartDate;
        private StaticList slRefBalanceType = new StaticList(GLibrary.strarrRefBalanceTypes);

        public AccountBalanceRefVer()
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
            bFlag = false;
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
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            CmbRefTypes.DataSource = slRefBalanceType.ToDataTable();
            if (CmbRefTypes.Items.Count > 0)
            {
                CmbRefTypes.SelectedIndex = 0;
            }
            bFlag = true;
            //accountingBindingSource1.Sort = "AccountName";
            accountingBindingSource.Sort = "AccountName";
            cmbAccount.SelectedValue = -1;

           

            costCentersBindingSource.Filter = "costid > 1";
            CmbCostCenter.SelectedValue = -1;
            //Search();
                   
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
            if (cmbBranch.SelectedValue != null && bFlag)
            {
                Search();
            }
        }
        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbAccount.SelectedValue != null)
            //{
            //    Search();
            //}
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
                      MessageBox.Show(Messages.CheckDate, "Õ–› ⁄‰’—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                      MessageBox.Show(Messages.CheckDate, "Õ–› ⁄‰’—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                      return;
                  }
              }
              else
              {
                  ToDate = DateTime.Parse(DateTime.Today.ToShortDateString () + " 23:59");
                  //ToDate = null;
              }

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
                  //ToDateB = temp;//.AddDays(-1);
                  ToDateB = new DateTime(FromDate.Value.Year, 1, 1);
                  //ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");
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

              if (cmbAccount.SelectedValue != null) { AccountId = long.Parse(cmbAccount.SelectedValue.ToString()); }
              if (cmbBranch.SelectedValue != null) { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
                       
              //-----------------------------------------—’Ìœ ”«»ﬁ
           
            //--------------------------------------------------------------------
              if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              {
                  AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              }
              else
              {
                  AccountId = 1;
              }
              if (CmbCostCenter.SelectedValue != null)
              {
                  CostId = int.Parse(CmbCostCenter.SelectedValue.ToString());
              }
              else
              {
                  CostId = null;
              }
              int Level = int.Parse (nUpDownacc.Value.ToString ()) ;
              nEWERPDataSet.accounting.Clear();
               StartDate = new DateTime (DateTime.Today .Year ,1,1);
              accountingTableAdapter.FillByRefBalanceLast (nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate, FromDateB, ToDateB,StartDate,2,CostId);
              // GetDataLevel(long.Parse(AccountId.ToString()), Level);
              AddItem(int.Parse(AccountId.ToString()), Level);

              if (CmbRefTypes.SelectedValue.ToString() == "1")
              {
                  //AccountDGView.Visible = false;
                  //dGdViewAccCredit.Visible = true ;
                  GetAccountCeridtSum();
              }
              else if (CmbRefTypes.SelectedValue.ToString() == "2")
              {
                  //AccountDGView.Visible = true;
                  //dGdViewAccCredit.Visible = false ;
                  GetAccountSum();
                 
              }
          
                 
              
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
                    accountingTableAdapter.FillByRefBalanceLast (nEWERPDataSetTempOld.accounting, accountid, BranchId, FromDate, ToDate, FromDateB, ToDateB,StartDate,2,CostId);
                   
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
                        if (chkBoxFlag.Checked) // ⁄œ„ «ŸÂ«— «·ﬁÌ„… «·’›—Ì…
                        {
                            if (TotBalB - TotBal != 0)
                            {
                                nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                            }
                        }
                        else
                        {
                            nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                        }
                    }



                    //if (nEWERPDataSetTempOld.accounting.Count > 0)
                    //{
                    //    nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                    //}
                    //Node.Tag = (Int64)T.Rows[i]["accountid"];
                    //Node.ContextMenuStrip = ContextMenuAccount;
                    //Node.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];


                    //Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                    //int accountType = (int)T.Rows[i]["accountType"];
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
            
            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            if (Credit < 0)
            {
                txttotalBalance.Text = (-1*Credit).ToString();
                lblSum.Text = " œ«∆‰ ";
            }
            else
            {
                txttotalBalance.Text = Credit.ToString() ;
                lblSum.Text = " „œÌ‰ ";
            }
            if (Credit == 0)
            {
                lblSum.Text = "";
            }
          
        }

        private void GetAccountCeridtSum()
        {
            //DataView list = (DataView)accountingBindingSource1.List;
            //DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;


            for (int i = 0; i < dGdViewAccCredit.Rows.Count; i++)
            {
                if (dGdViewAccCredit.Rows[i].Cells["FromValueCredit"].FormattedValue  != null)
                {
                    if (GLibrary.IsNumeric(dGdViewAccCredit.Rows[i].Cells["FromValueCredit"].FormattedValue.ToString()))
                    {
                        Fromvalue = Fromvalue + decimal.Parse(dGdViewAccCredit.Rows[i].Cells["FromValueCredit"].FormattedValue .ToString());
                    }
                }
                if (dGdViewAccCredit.Rows[i].Cells["ToValueCredit"].FormattedValue  != null)
                {
                    if (GLibrary.IsNumeric(dGdViewAccCredit.Rows[i].Cells["ToValueCredit"].FormattedValue .ToString()))
                    {
                        Tovalue = Tovalue + decimal.Parse(dGdViewAccCredit.Rows[i].Cells["ToValueCredit"].FormattedValue .ToString());
                    }
                }

            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            if (Credit < 0)
            {
                txttotalBalance.Text = (-1*Credit).ToString();
                lblSum.Text = " „œÌ‰ ";
            }
            else
            {
                txttotalBalance.Text = Credit.ToString();
                lblSum.Text = " œ«∆‰ ";
            }
            if (Credit == 0)
            {
                lblSum.Text = "";
            }

        }
       
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            int AccLevel = 0;
            Search();
            if (cmbAccount.SelectedValue != null)
            {
                AccountId = long.Parse(cmbAccount.SelectedValue.ToString());
            }
            else
            {
                AccountId = 1;
            }
            int pos = accountingBindingSource.Find("AccountId", AccountId);
            if (pos > -1 || AccountId==1)
            {
                if (pos > -1)
                {
                    AccLevel = int.Parse(((DataRowView)accountingBindingSource.Current)["AccLevel"].ToString());
                }
                ShowNewRpt frm = new ShowNewRpt();
                frm.AccountName = cmbAccount.Text;


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
                    FromDate = new DateTime(DateTime.Today.Year, 1, 1);
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
                        MessageBox.Show(Messages.CheckDate, "Õ–› ⁄‰’—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return;
                    }
                }
                else
                {
                    ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
                    //ToDate = null;
                }

                ToDateB = new DateTime();
                if (FromDate == null)
                {
                    ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
                }
                else
                {
                    DateTime temp = new DateTime();
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
               
                ToDateB = DateTime.Parse(ToDateB.ToShortDateString() + " 23:59");


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
                if (CmbRefTypes.SelectedValue.ToString() == "1")
                {
                    frm.choiceNum = 7; //vertical
                }
                else if (CmbRefTypes.SelectedValue.ToString() == "2")
                {
                    frm.choiceNum = 1;
                }
              
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

        private void cmbAccount_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedValue != null && bFlag)
            {
                Search();
            }
        }

       
        private void AccountDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (AccountDGView.Rows.Count > 0)
            {

                if (TotalBalanceTo.Index == e.ColumnIndex)// „œÌ‰
                {
                    decimal Credit = 0;
                    decimal TotalToVaule = 0;
                    decimal TotalFromVaule = 0;
                    TotalToVaule = decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalToValueB"].Value.ToString()) + decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalToValue"].Value.ToString());
                    TotalFromVaule = decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalFromValueB"].Value.ToString()) + decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalFromValue"].Value.ToString());
                    Credit = TotalToVaule - TotalFromVaule;
                    if (Credit > 0)
                    {
                        AccountDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Credit;
                    }

                }
                if (TotalBalnceFrom.Index == e.ColumnIndex) // œ«∆‰
                {
                    decimal Credit = 0;
                    decimal TotalToVaule = 0;
                    decimal TotalFromVaule = 0;
                    TotalToVaule = decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalToValueB"].Value.ToString()) + decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalToValue"].Value.ToString());
                    TotalFromVaule = decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalFromValueB"].Value.ToString()) + decimal.Parse(AccountDGView.Rows[e.RowIndex].Cells["totalFromValue"].Value.ToString());
                    Credit = TotalToVaule - TotalFromVaule;
                    if (Credit < 0)
                    {
                        AccountDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Credit * -1;
                    }
                }
                //switch (e.ColumnIndex)
                //{




                //}
                //if (StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != DBNull.Value && StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value!=null )
                //{
                //    GetSum();
                //}
            }
        }

        private void rdBtnAllAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnAllAcc.Checked)
            {
                Search();
                accountingBindingSource1.RemoveFilter();
            }

        }

        private void rdBtnToAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnToAcc.Checked)
            {
                Search();
                accountingBindingSource1.Filter = "TotalBalance >= 0";
            }
        }

        private void rdBtnFromAcc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnFromAcc.Checked)
            {
                Search();
                accountingBindingSource1.Filter = "TotalBalance <= 0";
            }
        }

        private void dGdViewAccCredit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ToValueCreditB.Index == e.ColumnIndex)// —’Ìœ „œÌ‰ ﬁ»·
            {
                if (decimal.Parse(dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceBT"].Value.ToString()) > 0)
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceBT"].Value;
                }
                else
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
               
            }
            if (FromValueCreditB.Index == e.ColumnIndex)// —’Ìœ œ«∆‰ ﬁ»·
            {
                if (decimal.Parse(dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceBT"].Value.ToString()) < 0)
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = -1*decimal.Parse (dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceBT"].Value.ToString ());
                }
                else
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

            }
            
            if (ToValueCredit.Index == e.ColumnIndex)// —’Ìœ „œÌ‰ 
            {
                if (decimal.Parse(dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceT"].Value.ToString()) > 0)
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceT"].Value;
                }
                else
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

            }
            if (FromValueCredit.Index == e.ColumnIndex)// —’Ìœ œ«∆‰ 
            {
                if (decimal.Parse(dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceT"].Value.ToString()) < 0)
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = -1*decimal.Parse (dGdViewAccCredit.Rows[e.RowIndex].Cells["TotalBalanceT"].Value.ToString ());
                }
                else
                {
                    dGdViewAccCredit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

            }
        }

        private void CmbRefTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbRefTypes.SelectedValue != null && bFlag)
            {
            //    Search();
            }
        }
      
        
    }
}