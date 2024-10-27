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
    public partial class AccountCustomerDanWithMonthRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      
        

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public AccountCustomerDanWithMonthRpt()
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
            accountA3marAlDauanMonthsBindingSource.Sort = "AccountName";
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
                  ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59"); ;
              }
           

             DateTime FromDate1 = new DateTime(DateTime.Today.Year, 1, 1);
             DateTime ToDate1 = new DateTime(DateTime.Today.Year, 1, 31);

             DateTime FromDate2 = new DateTime(DateTime.Today.Year, 2, 1);
             DateTime ToDate2 = new DateTime(DateTime.Today.Year, 2, 28);

             DateTime FromDate3 = new DateTime(DateTime.Today.Year, 3, 1);
             DateTime ToDate3 = new DateTime(DateTime.Today.Year, 3, 31);

             DateTime FromDate4 = new DateTime(DateTime.Today.Year, 4, 1);
             DateTime ToDate4 = new DateTime(DateTime.Today.Year, 4, 30);

             DateTime FromDate5 = new DateTime(DateTime.Today.Year, 5, 1);
             DateTime ToDate5 = new DateTime(DateTime.Today.Year, 5, 31);

             DateTime FromDate6 = new DateTime(DateTime.Today.Year, 6, 1);
             DateTime ToDate6 = new DateTime(DateTime.Today.Year, 6, 30);

             DateTime FromDate7 = new DateTime(DateTime.Today.Year, 7, 1);
             DateTime ToDate7 = new DateTime(DateTime.Today.Year, 7, 31);

             DateTime FromDate8 = new DateTime(DateTime.Today.Year, 8, 1);
             DateTime ToDate8 = new DateTime(DateTime.Today.Year,8, 31);

             DateTime FromDate9 = new DateTime(DateTime.Today.Year, 9, 1);
             DateTime ToDate9 = new DateTime(DateTime.Today.Year, 9, 30);

             DateTime FromDate10 = new DateTime(DateTime.Today.Year, 10, 1);
             DateTime ToDate10 = new DateTime(DateTime.Today.Year, 10, 31);

             DateTime FromDate11 = new DateTime(DateTime.Today.Year, 11, 1);
             DateTime ToDate11 = new DateTime(DateTime.Today.Year, 11, 30);

             DateTime FromDate12 = new DateTime(DateTime.Today.Year, 12, 1);
             DateTime ToDate12 = new DateTime(DateTime.Today.Year, 12, 31);


             accountA3marAlDauanMonthsTableAdapter.Fill(nEWERPDataSet.AccountA3marAlDauanMonths , BranchId, FromDate1, ToDate1, FromDate2, ToDate2, FromDate3, ToDate3, FromDate4, ToDate4, FromDate5, ToDate5, FromDate6, ToDate6, FromDate7, ToDate7, FromDate8, ToDate8, FromDate9, ToDate9, FromDate10, ToDate10, FromDate11, ToDate11, FromDate12, ToDate12, AccountId);


             A3marAlDuanMonths rpt = new A3marAlDuanMonths();
             crystalReportViewer1.Visible = true;

           
           // crystalReportViewer1.ParameterFieldInfo = rpt6.ParameterFields;

             //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
             rpt.SetDataSource(nEWERPDataSet);
             crystalReportViewer1.ReportSource = rpt;
            


        }
    
     

     

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
              Search();  

      
             
        }

       

        

      

       

      

      

      

      
      

     
      

       

       

        
    }
}