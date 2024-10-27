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
    public partial class AccountCustomerWithDanRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<int> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;
        private decimal BalanceAll;
        //private decimal Balance60;
        //private decimal Balance30;
        private decimal Balance90;
       // private decimal BalanceMore;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public AccountCustomerWithDanRpt()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
          
            CmbItemSorted.DataSource = slItemSorted.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
             
              //NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
              //accountingBindingSource.DataMember ="accounting";
              //accountingBindingSource.DataSource = nEWERPDataSetNew;

            

              //this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            accountA3marAlDauanBindingSource.Sort = "AccountName";
            cmbAccount.SelectedValue = -1;
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    cmbStroes.SelectedIndex = 0;
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            //Search();
                   
        }
        private void GetAccountDauan()
        {

        }
         private void Search()
        {
             
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
                  ToDate = DateTime.Parse(DateTime.Today.ToShortDateString () + " 23:59"); ;
              }

              if (cmbAccount.SelectedValue != null && cmbAccount.Text != "")
              {
                  AccountId = int.Parse(cmbAccount.SelectedValue.ToString());
              }
              else
              {
                  AccountId = null;
              }
             
             
              if (cmbBranch.SelectedValue != null && cmbAccount.Text != "") { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
       
              if (FromDate ==null ) 
              {
                  FromDate=new DateTime(DateTime.Today.Year,1,1); 
              }
              if (ToDate ==null ) 
              {
                  ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
              }
             TimeSpan T30=new TimeSpan (30,0,0,0);
             TimeSpan T60 = new TimeSpan(60, 0, 0, 0);
             TimeSpan T90 = new TimeSpan(90, 0, 0, 0);

             DateTime StartYearDate = new DateTime(DateTime.Today.Year, 1, 1);
             DateTime Date30 = ToDate.Value.Subtract(T30);
             DateTime Date60 = ToDate.Value.Subtract(T60);
             DateTime Date90 = ToDate.Value.Subtract(T90);
             accountA3marAlDauanTableAdapter.Fill(nEWERPDataSet.AccountA3marAlDauan, BranchId, FromDate, Date30, Date60, Date90, ToDate, AccountId);

             //decimal FromValueAll = decimal.Parse(accountingTableAdapter.GetAccountDauanTotFromValue(AccountId, BranchId, StartYearDate, ToDate).ToString());
             //decimal ToValueAll = decimal.Parse(accountingTableAdapter.GetAccountDauanTotToValue(AccountId, BranchId, StartYearDate, ToDate).ToString());
             // BalanceAll = FromValueAll - ToValueAll;

             // decimal FromValue30 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotFromValue(AccountId, BranchId, ToDate.Value.Subtract(T30), ToDate).ToString());
             // decimal ToValue30 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotToValue(AccountId, BranchId, ToDate.Value.Subtract(T30), ToDate).ToString());
             // Balance30 = FromValue30 - ToValue30;

             // decimal FromValue60 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotFromValue(AccountId, BranchId, ToDate.Value.Subtract(T60), ToDate).ToString());
             // decimal ToValue60 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotToValue(AccountId, BranchId, ToDate.Value.Subtract(T60), ToDate).ToString());
             // decimal Totalvalue60 = FromValue60 - ToValue60;
             // Balance60 = Totalvalue60 - Balance30;


             // decimal FromValue90 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotFromValue(AccountId, BranchId, ToDate.Value.Subtract(T90), ToDate).ToString());
             // decimal ToValue90 = decimal.Parse(accountingTableAdapter.GetAccountDauanTotToValue(AccountId, BranchId, ToDate.Value.Subtract(T90), ToDate).ToString());

             // decimal Totalvalue90 = FromValue90 - ToValue90;
             // Balance90 = Totalvalue90 - (Balance30 + Balance60);

             // BalanceMore = BalanceAll - (Balance90 + Balance60 + Balance30);
            


        }
    
     

     

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
                  Search();  

          
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
                      frm.ToDate = DateTime.Parse (DateTime.Today.ToShortDateString ()+ " 23:59");
                  }
                                      
                  frm.choiceNum = 8;
                               
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

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();//ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

       

      

       

      

      

      

      
      

     
      

       

       

        
    }
}