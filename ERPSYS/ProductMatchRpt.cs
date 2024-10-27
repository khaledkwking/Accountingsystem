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
    public partial class ProductMatchRpt : DockContent
    {
        private Nullable<long> BranchCode = null;
        private Nullable<long> StoreCode = null;
        private Nullable<long> ProductId = null;
       
        private string BarCodeName = null;
        private string ProductCode = null;
        private Nullable <decimal> Qty = null;
        private Nullable<decimal> ToQty = null;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();

        public ProductMatchRpt()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvProductsMoveVIEW' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
        

            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
              //NEWERPDataSet nEWERPDataSetNew=new NEWERPDataSet();
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.

            cmbBranch.SelectedValue = -1;
            //}
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            CmbStores.SelectedValue = -1;
            CmbProducts.SelectedValue = -1;
            //txtToQty.Text = "0";
            //movmentQtyTextBox.Text = "0";
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
          
                   
        }

                    

       

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Search()
        {
            BranchCode = null;
            StoreCode = null;
            ProductId = null;
            BarCodeName = null;
            ProductCode = null;
            Qty = null;
            ToQty = null;

            if (txtBarCode.Text != "") { BarCodeName = txtBarCode.Text; }
            if (CmbProducts.SelectedValue != null) { ProductId = long.Parse(CmbProducts.SelectedValue.ToString()); }

            if (txtProductCode.Text != "") { ProductCode = txtProductCode.Text; }

            if (CmbStores.SelectedValue != null) { StoreCode = long.Parse(CmbStores.SelectedValue.ToString()); }
            if (cmbBranch.SelectedValue != null) { BranchCode = long.Parse(cmbBranch.SelectedValue.ToString()); }
            if (GLibrary.IsNumeric(movmentQtyTextBox.Text))
            {
                Qty = decimal.Parse(movmentQtyTextBox.Text);
            }
            if (GLibrary.IsNumeric(txtToQty.Text))
            {
                ToQty = decimal.Parse(txtToQty.Text);
            }

            this.stockViewTableAdapter.FillByKey(this.nEWERPDataSet.StockView, BranchCode, StoreCode, BarCodeName, ProductId, ProductCode, Qty, ToQty);
            stockViewBindingSource.Sort = "";
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {

            Search();

            ShowProductsRpt frm = new ShowProductsRpt();
            frm.nEWERPDataSet = nEWERPDataSet;
            frm.choiceNum = 10;
            frm.ShowDialog();
          
        }

      

       

       

       

      

      

      

      
      

     
      

       

       

        
    }
}