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
    public partial class CustomersMoveRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> AccountId   =  null ;
      private Nullable<int> StoreId = null;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public CustomersMoveRpt()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.AccountingView' table. You can move, or remove it, as needed.
            accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            CmbItemSorted.DataSource = slItemSorted.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
             NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
             
                        // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            accountingBindingSource.Sort = "AccountName";
            pRODUCTSBindingSource.Sort = "productname";
            //pRODUCTSBindingSource.Filter = "root=false";
            accountingBindingSource.Filter = "AccountparentId=" + Messages.custaccid + " or accountid=" + Messages.custaccid;
            txtFromDate.Text = new DateTime(DateTime.Today.Year, 1, 1).ToShortDateString();// ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
            CmbCustomer.SelectedValue = -1;
            cmbProducts.SelectedValue = -1;
            cmbStores.SelectedValue = -1;
          
        }

         private void Search()
        {
            
              BranchId   =  null ;
              AccountId = null;
              ToDate =null ;
              FromDate  = null;
              ProductId =null;
              StoreId =null;
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

              if (CmbCustomer.SelectedValue != null && CmbCustomer.Text != "")
              {
                  AccountId = long.Parse(CmbCustomer.SelectedValue.ToString());
              }
              else
              {
                  AccountId = null;
              }

              if (cmbProducts.SelectedValue != null && cmbProducts.Text != "")
              {
                  ProductId = int.Parse(cmbProducts.SelectedValue.ToString());
              }
              else
              {
                  ProductId = null;
              }

              if (cmbStores.SelectedValue != null && cmbStores.Text != "")
              {
                  StoreId = int.Parse(cmbStores.SelectedValue.ToString());
              }
              else
              {
                  StoreId = null;
              }

              if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") 
              { 
                  BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); 
              }

              invoiceViewSelectMoveTableAdapter.Fill(nEWERPDataSet.InvoiceViewSelectMove , AccountId, BranchId, FromDate, ToDate, ProductId, StoreId);
              switch (int.Parse (CmbItemSorted.SelectedValue.ToString ()))
              {
                  case 1:
                      break;
                  case 2:
                      break;
                  case 3:
                      break;
              }

            
        }
       
     

        

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Search();  
          
              ShowProductsRpt frm =new ShowProductsRpt();
                        
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
                                 
              frm.choiceNum = 9;  
              frm.nEWERPDataSet = nEWERPDataSet;                                         
              frm.ShowDialog(this);
          
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

                 

       

        
    }
}