using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;

namespace ERPSYS
{
    public partial class LinkProductToStroe :DockContent
    {
        public LinkProductToStroe()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
            //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            this.sTOCKTableAdapter.Fill(this.nEWERPDataSet.STOCK);
            productUnitsPricesBindingSource.Sort = "productid , UintId ";
            pRODUCTSBindingSource.Sort = "PRODUCTCODE";
            sTOCKBindingSource.Sort = "PRODUCTID";
            //GetStock();
        }
        private void GetStock()
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                if (txtProductId.Text == "") { txtProductId.Text = "-1"; }
                string StoreId = StoresDGView.SelectedRows[0].Cells["StoreId"].Value.ToString();
                sTOCKBindingSource.Filter = "ProductId=" + txtProductId.Text + " and StoreId=" + StoreId;
            }
        }
          

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            sTORESBindingSource.EndEdit();
            sTORESTableAdapter.Update(nEWERPDataSet.STORES);
            sTOCKBindingSource.EndEdit();
            sTOCKTableAdapter.Update(nEWERPDataSet.STOCK );
            StoresDGView.Refresh();
            GLibrary.MsgSave();
            Messages.StockFlag = 1;
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
           //int ProductId = -1; 
            int StoreId=-1;
            if (txtProductId.Text != "")
            {
                 StoreId = int.Parse(StoresDGView.SelectedRows[0].Cells["StoreId"].Value.ToString());
                 if (!Boolean.Parse(txtRoot.Text))
                 {
                     AddProductUnits(int.Parse(txtProductId.Text), StoreId);
                 }
                 else
                 {
                     pRODUCTSBindingSource.Filter = "ParentProductId=" + txtProductId.Text;
                     System.Data.DataView Productlist = new System.Data.DataView();
                     Productlist = (DataView)pRODUCTSBindingSource.List;
                     DataTable TProduct = Productlist.ToTable();
                     Boolean MainNode = false;
                     for (int i = 0; i < TProduct.Rows.Count; i++)
                     {
                         MainNode = false;
                         if (TProduct.Rows[i]["MainNode"] != DBNull.Value)
                         {
                             MainNode=Boolean.Parse (TProduct.Rows[i]["MainNode"].ToString ());
                            
                         }
                         if (!MainNode)
                         {
                             AddProductUnits(int.Parse(TProduct.Rows[i]["ProductId"].ToString()), StoreId);
                         }
                     }

                 }
               
                sTOCKTableAdapter.Update(nEWERPDataSet.STOCK);
                //GetStock();

            }
            pRODUCTSBindingSource.RemoveFilter();
   
        }
        private void AddProductUnits(int ProductId, int StoreId)
        {
            
            int ProductUnit = -1;
            productUnitsPricesBindingSource.Filter = "ProductId=" + ProductId.ToString ();
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)productUnitsPricesBindingSource.List;
            DataTable T = list.ToTable();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                ProductId = int.Parse(T.Rows[i]["ProductId"].ToString());
                ProductUnit = int.Parse(T.Rows[i]["UintId"].ToString());
                if (T.Rows[i]["MainUnit"] != DBNull.Value)
                {
                    Boolean MainUnit = Boolean.Parse(T.Rows[i]["MainUnit"].ToString());
                    if (MainUnit)
                    {
                        if (ProductId != -1 && ProductUnit != -1 && StoreId != -1)
                        {
                            ERPSYS.NEWERPDataSet.STOCKRow row = nEWERPDataSet.STOCK.NewSTOCKRow();

                            try
                            {
                                row.PRODUCTID = ProductId;
                                row.UnitID = ProductUnit;
                                row.STOREID = StoreId;
                                row.QUANTITY = 0;
                                nEWERPDataSet.STOCK.Rows.Add(row);
                            }
                            catch (Exception ex)
                            {
                                row.CancelEdit();
                            }

                        }
                    }
                }
            }
        }
        private void CmdDel_Click(object sender, EventArgs e)
        {
            Boolean bflag = false;
            if (StockDGView.SelectedRows.Count > 0)
            {
                int RCount = StockDGView.SelectedRows.Count;
                for (int i = 0; i <RCount; i++)
                {
                    if (StockDGView.SelectedRows[0].Cells["cmbPRODUCTID"].Value != DBNull.Value)
                    {
                        long ProductId = long.Parse(StockDGView.SelectedRows[0].Cells["cmbPRODUCTID"].Value.ToString ());
                        long STOREID = long.Parse(StockDGView.SelectedRows[0].Cells["cmbSTOREID"].Value.ToString ());
                        int Pcount = int.Parse(inv_ProductsTableAdapter.FillBybyCountProductId(ProductId, STOREID).ToString());
                        if (Pcount < 1)
                        {
                            int pos = sTOCKBindingSource.Find("ProductId", ProductId);
                            if (pos > -1)
                            {
                                sTOCKBindingSource.RemoveAt(pos);
                                sTOCKBindingSource.EndEdit();
                            }
                        }
                        else
                        {
                            bflag = true;
                        }
                    }
                }
            }
            sTOCKTableAdapter.Update(nEWERPDataSet.STOCK);
            if (bflag)
            {
                MessageBox.Show("åÐÇ ÇáÕäÝ ãÑÊÈØ ÈÇáÝæÇÊíÑ æáÇ íãßä ÍÐÝå", "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

              
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int iProductId = -1;
                string strProductName = "";
                string strProductCode = "";
                Boolean Root = false;
                DisplayProducts(ref strProductName, ref iProductId, ref strProductCode,ref Root);

                txtProductCode.Text = strProductCode;
                txtProductName.Text = strProductName;
                txtProductId.Text = iProductId.ToString();
                txtRoot.Text = Root.ToString();

            }
        }

        private void DisplayProducts(ref string ProductName, ref int ProductID, ref string ProductCode,ref Boolean Root)
        {
            ProductsList frm = new ProductsList();
            //frm.MdiParent = MainMenu;
            DialogResult ret = frm.ShowDialog(this);
            if (DialogResult.OK == ret)
            {
                ProductName = frm.CurProductName;
                ProductID = frm.CurProductId;
                ProductCode = frm.CurProductCode;
                Root = frm.CurRoot;
            }

        }
     
        private void StoreSearch(string ColName, string Value)
        {
            int Pos = sTOCKBindingSource.Find(ColName, Value);
            if (nEWERPDataSet.STORES.Rows.Count > 0)
            {
                StoresDGView.Rows[Pos].Selected = true;
            }
        }

        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            //StoreSearch("STORECODE", txtStoreCode.Text);
        }

        private void txtStoreName_KeyUp(object sender, KeyEventArgs e)
        {
           // StoreSearch("StoreName", txtStoreName.Text);
        }

        private void sTOCKBindingSource_PositionChanged(object sender, EventArgs e)
        {
           
        
        }
        private void sTORESBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Int64 STOREID = (Int64)((DataRowView)sTORESBindingSource.Current)["STOREID"];
            sTOCKBindingSource.Filter = "STOREID = " + STOREID.ToString();
        }
        private void StockDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["QUANTITY"].Value = 0;
        }

        private void LinkProductToStroe_Activated(object sender, EventArgs e)
        {
            //if (Messages.ProductFlag  == 1)
            //{
            //    long BranchId = 0;
            //    BranchId = long.Parse(Messages.CurBranch);
            //    this.pRODUCTSTableAdapter.Fill (this.nEWERPDataSet.PRODUCTS);
            //    Messages.ProductFlag = 0;
            //}
        }

        private void StockDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void StoresDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

      

       

       

        
    }
}