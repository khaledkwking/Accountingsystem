using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class StoresProducts : DockContent
    {
      private Nullable<long> BranchCode   =  null ;
      private Nullable<long> StoreCode   =  null ;
      private string strProductName =null ;
      private string BarCodeName = null;
      private string ProductCode = null;

        public StoresProducts()
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

            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
            {
                cmbBranch.SelectedIndex = 0;
            }
            if (nEWERPDataSet.STORES.Rows.Count > 0)
            {
                cmbStroes.SelectedIndex = 0;
            }
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            Search();
                   
        }
        private void StoresProducts_Activated(object sender, EventArgs e)
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
            if (cmbBranch.SelectedValue !=null)
            {
                Search();
            }
        }
        private void cmbStroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStroes.SelectedValue != null)
            {
                Search();
            }
        }
        private void Search()
        {
              BranchCode   =  null ;
              StoreCode   =  null ;
              strProductName =null ;
              BarCodeName = null;
              ProductCode = null;

            if (txtBarCode.Text != "") { BarCodeName = txtBarCode.Text;}
            if (txtProductName.Text != "") { strProductName = txtProductName.Text; }

            if (txtProductCode.Text != "") { ProductCode = txtProductCode.Text; }

            if (cmbStroes.SelectedValue != null) { StoreCode = long.Parse (cmbStroes.SelectedValue.ToString ()); }
            if (cmbBranch.SelectedValue != null) { BranchCode = long.Parse(cmbBranch.SelectedValue.ToString()); }

            this.stockViewTableAdapter.Fill(this.nEWERPDataSet.StockView, BranchCode, StoreCode, BarCodeName, strProductName, ProductCode);
            stockViewBindingSource.Sort = "";
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowProductsRpt frm =new ShowProductsRpt();
            frm.nEWERPDataSet = nEWERPDataSet;
            frm.choiceNum = 1;
            frm.ShowDialog();
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

       

      

      

      
      

     
      

       

       

        
    }
}