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
    public partial class InvoiceRefRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<int> CustSupId   =  null ;
      private Nullable<int> ProductId = null;
      private Nullable<int> StoreId = null;
      private Nullable<int> inType = null;

        private Nullable<int> BuyerId = null;

      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slInvType = new StaticList(GLibrary.strarrInvType);
        private Nullable<int> BillTypeId = null;

        private StaticList slBillType;

        public InvoiceRefRpt()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.nEWERPDataSet.USER);
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            CmbInvTypes.DataSource = slInvType.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvProductsMoveVIEW' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);

            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              //NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            setupTableAdapter.Fill(nEWERPDataSet.setup);
                cmbBranch.SelectedIndex =-1;
            //}
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
                //CmbStores.SelectedIndex = -1;
               CmbProducts.SelectedValue  = -1;
              
               CmbBillType.SelectedValue = -1;
               comboBoxUser.SelectedValue = -1;

               CmbInvTypes.SelectedValue = Messages.InvSalesFlag;

               sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag;
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
               if (Messages.Usertype != Messages.AdminUser)
               {
                   cmbBranch.SelectedValue = Messages.CurBranch;
                   cmbBranch.Enabled = false;
               }
               else
               {

               }
               slBillType = new StaticList(GLibrary.strarrBillType);
               CmbBillType.DataSource = slBillType.ToDataTable();
               cmbCustSup.SelectedValue = -1; 
        }

        private void Search()
        {
            
            
             // if (pos > -1)
             // {
                  //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
                  //{
                  //    accountingTableAdapter.FillByGetAccBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate);

                  //    StockDGView.Visible = false;
                  //    AccountDGView.Visible = true;
                  //    GetAccountSum();
                  //}
                  //else
                  //{
                  //nEWERPDataSet.accounting.Clear();
                  //nEWERPDataSet.AccountingView.Clear();
                  //GetDataLevel(int.Parse (AccountId.Value.ToString ()) );
                      //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
                     //StockDGView.Visible = true;
                      //AccountDGView.Visible = false;
                      //GetSum();
                 // }
             // }
        }
            

       

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

           
               BranchId   =  null ;
               StoreId = null;
               CustSupId=null;
               ProductId=null;
               inType=null;
               BillTypeId = null;
               BuyerId = null;

              if (cmbBranch.SelectedValue != null) { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }
              if (cmbCustSup.SelectedValue != null) { CustSupId = int.Parse(cmbCustSup.SelectedValue.ToString()); }
              if (CmbProducts.SelectedValue != null) { ProductId = int.Parse(CmbProducts.SelectedValue.ToString()); }
              if (CmbInvTypes.SelectedValue != null) { inType = int.Parse(CmbInvTypes.SelectedValue.ToString()); }
              if (CmbBillType.SelectedValue != null) { BillTypeId = int.Parse(CmbBillType.SelectedValue.ToString()); }

              if (comboBoxUser.SelectedValue != null) { BuyerId = int.Parse(comboBoxUser.SelectedValue.ToString()); }

            // if (CmbStores.SelectedValue != null) { StoreId = int.Parse(CmbStores.SelectedValue.ToString()); }
            string Title = CmbInvTypes.Text;
                  ShowNewRpt frm = new ShowNewRpt();
                                                  
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
                      frm.ToDate = DateTime.Parse(txtToDate.Text+ " 23:59");
                  }
                  else
                  {
                      frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString () + " 23:59");
                  }
                    
              
                  frm.choiceNum = 6;
                    frm.Title = Title;
                  GLibrary.strarrGetTypes[1, 0].ToString();
                  invoiceViewTableAdapter.FillByParam(nEWERPDataSet.InvoiceView, BranchId, CustSupId, frm.FromDate, frm.ToDate, inType, BillTypeId, BuyerId);
                  setupTableAdapter.Fill(nEWERPDataSet.setup);
                    frm.nEWERPDataSet = nEWERPDataSet;
                               
                    frm.ShowDialog(this);
            // }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString ();//.ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

      

       

      

      

      

      
      

     
      

       

       

        
    }
}