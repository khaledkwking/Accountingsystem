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
    public partial class ProductPurchaseRpt : DockContent
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> CustSupId   =  null ;
      private Nullable<long> StoreId = null;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> ProductId = null;
      private Nullable<int> Free = null;

        private Nullable<int> EmpId = null;
        public int invType;
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slItemSorted = new StaticList(GLibrary.strarrItemSorted);

        public ProductPurchaseRpt()
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
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.nEWERPDataSet.USER);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            //this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));
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
            //accountingBindingSource.Sort = "AccountName";
            pRODUCTSBindingSource.Sort = "productname";
            pRODUCTSBindingSource.Filter = "MainNode=false";
            sUPPLIERSCUSTOMERSBindingSource.Sort  = "SUP_CUST_FNAME";
            txtFromDate.Text = new DateTime(DateTime.Today.Year, 1, 1).ToShortDateString();// ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
            CmbCustomer.SelectedValue = -1;
            cmbProducts.SelectedValue = -1;
            cmbStores.SelectedValue = -1;
            
            cmbBranch.SelectedValue = -1;
            cmbEmp.SelectedValue = -1;
        }

         private void Search()
        {
            
              BranchId   =  null ;
              CustSupId = null;
              ToDate =null ;
              FromDate  = null;
              ProductId =null;
              StoreId =null;
              EmpId = null;

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

              if (CmbCustomer.SelectedValue != null && CmbCustomer.Text != "")
              {
                  CustSupId = long.Parse(CmbCustomer.SelectedValue.ToString());
              }
              else
              {
                  CustSupId = null;
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
                  StoreId = long.Parse(cmbStores.SelectedValue.ToString());
              }
              else
              {
                  StoreId = null;
              }

              if (cmbBranch.SelectedValue != null && cmbBranch.Text != "") 
              { 
                  BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); 
              }
              if (cmbEmp.SelectedValue != null && cmbEmp.Text != "")
              {
                  EmpId = int.Parse(cmbEmp.SelectedValue.ToString());
              }
              productSalesSelectViewTableAdapter.FillPurchaseBy (nEWERPDataSet.ProductSalesSelectView, CustSupId, BranchId,StoreId, FromDate, ToDate, ProductId,EmpId );
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
                                 
              frm.choiceNum = 78;  
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
        private void SearchStat()
        {

            BranchId = null;
            CustSupId = null;
            ToDate = null;
            FromDate = null;
            ProductId = null;
            StoreId = null;
            EmpId = null;
            Free = null;

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

            if (CmbCustomer.SelectedValue != null && CmbCustomer.Text != "")
            {
                CustSupId = long.Parse(CmbCustomer.SelectedValue.ToString());
            }
            else
            {
                CustSupId = null;
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
                StoreId = long.Parse(cmbStores.SelectedValue.ToString());
            }
            else
            {
                StoreId = null;
            }

            if (cmbBranch.SelectedValue != null && cmbBranch.Text != "")
            {
                BranchId = long.Parse(cmbBranch.SelectedValue.ToString());
            }
            if (cmbEmp.SelectedValue != null && cmbEmp.Text != "")
            {
                EmpId = int.Parse(cmbEmp.SelectedValue.ToString());
            }
            if (chkBoxFree.Checked)
            {
                Free = 0;
            }

            productSalesSelectViewMonthsTableAdapter.FillByPurchase(nEWERPDataSet.ProductSalesSelectViewMonths, CustSupId, BranchId, StoreId, FromDate, ToDate, ProductId, EmpId, Free, invType);
            


        }
        private void btnStatSales_Click(object sender, EventArgs e)
        {
            SearchStat();
            string CustName="";
            ShowProductsRpt frm = new ShowProductsRpt();
            if (CmbCustomer.Text != "")
            {
                CustName = CmbCustomer.Text;

            }
            frm.CustName = CustName;

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
            if (chkBoxFree.Checked)
            {
                frm.choiceNum = 777;
            }
            else
            {
                frm.choiceNum = 77;
            }
            frm.Title = "„‘ —Ì« ";
            frm.nEWERPDataSet = nEWERPDataSet;
            frm.ShowDialog(this);
        }

         

       

        
    }
}