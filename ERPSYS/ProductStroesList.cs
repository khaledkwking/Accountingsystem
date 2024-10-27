using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using ERPSYS.Reports;

namespace ERPSYS
{
    public partial class ProductStroesList :DockContent
    {
        private Nullable<long> BranchId = null;
        //private Nullable<int> ProductId = null;
        private Nullable<int> StoreId = null;
        private string SBarCode=null ;
        private string SProductName = null;
        private string SProductCode = null;
        private Nullable<int> UnitId = null;
        private Nullable<decimal > MaxPriceVal = null;
        private Nullable<decimal> MinPriceVal = null;

        private Nullable<double> MaxQtyVal = null;
        private Nullable<double> MinQtyVal = null;
        private string SBarMaster = null;
        public ProductStroesList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
                     
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            bRANCHESTableAdapter.Fill(nEWERPDataSet.BRANCHES);
            cDE_UNIT_TYPESTableAdapter.Fill(nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
           // this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
          
            //productUnitsPricesBindingSource.Sort = "productid , UintId ";
            //pRODUCTSBindingSource.Sort = "PRODUCTCODE";
            //GetStock();
            unitIDComboBox.SelectedValue = -1;
            Search();   
        }
        //private void GetStock()
        //{
        //    if (StoresDGView.SelectedRows.Count > 0)
        //    {
        //        if (txtProductId.Text == "") { txtProductId.Text = "-1"; }
        //        string StoreId = StoresDGView.SelectedRows[0].Cells["StoreId"].Value.ToString();
        //        sTOCKBindingSource.Filter = "ProductId=" + txtProductId.Text + " and StoreId=" + StoreId;
        //    }
        //}
          
               
         
              
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
     
      

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();   
        }
        private void Search()
        {
           
        
            BranchId = long.Parse (Messages.CurBranch);
            if ( sTOREFromIDComboBox.SelectedValue !=null )
            {
                   StoreId =int.Parse (sTOREFromIDComboBox.SelectedValue.ToString ());
            }
            else 
            {
                StoreId=null;
            }
            if (unitIDComboBox.SelectedValue !=null )
            {
                   UnitId= int.Parse (unitIDComboBox.SelectedValue.ToString ());
            }
             else 
            {
                UnitId =null;
            }

            if (txtBarCode.Text !="")
            {
                SBarCode=txtBarCode.Text;
            }
            else
            {
                SBarCode=null;
            }

            if (txtProductName.Text !="")
            {
                SProductName=txtProductName.Text;
            }
             else 
            {
                 SProductName=null;
            }

            if (txtProductCode.Text != "")
            {
                SProductCode = txtProductCode.Text;
            }
            else
            {
                SProductCode = null;
            }
            
            if (txtMinPrice.Text != "")
            {
                MinPriceVal = decimal.Parse (txtMinPrice.Text);
            }
            else
            {
                MinPriceVal = null;
            }
             if (txtMaxPrice.Text != "")
            {
                MaxPriceVal = decimal.Parse (txtMaxPrice.Text);
            }
            else
            {
                MaxPriceVal = null;
            }
            if (txtMinPrice.Text != "")
            {
                MinPriceVal = decimal.Parse (txtMinPrice.Text);
            }
            else
            {
                MinPriceVal = null;
            }
             if (txtMaxPrice.Text != "")
            {
                MaxPriceVal = decimal.Parse (txtMaxPrice.Text);
            }
            else
            {
                MaxPriceVal = null;
            }


            if (txtMinQty.Text != "")
            {
                MinQtyVal = double.Parse(txtMinQty.Text);
            }
            else
            {
                MinQtyVal = null;
            }
            if (txtMaxQty.Text != "")
            {
                MaxQtyVal = double.Parse(txtMaxQty.Text);
            }
            else
            {
                MaxQtyVal = null;
            }

            if (txtMasterBarcode.Text != "")
            {
                SBarMaster = txtMasterBarcode.Text;
            }
            else
            {
                SBarMaster = null;
            }

            this.stockViewTableAdapter.FillByParam(this.nEWERPDataSet.StockView, BranchId, StoreId, SBarCode, SProductName, SProductCode, MinPriceVal, MaxPriceVal, UnitId, SBarMaster, MinQtyVal, MaxQtyVal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNewRpt frm = new ShowNewRpt();
            frm.choiceNum = 91;
            frm.nEWERPDataSet = nEWERPDataSet;
            frm.ShowDialog(this);
         
        }

        private void NewProductMenuItem_Click(object sender, EventArgs e)
        {
            ProductsPop frm = new ProductsPop();
           
            frm.ShowDialog();
            if (frm.EditFlag)
            {
                Search();
            }
        }

        private void UpdateProductMenuItem_Click(object sender, EventArgs e)
        {
            if (StockDGView.SelectedRows .Count >0) 
            {
                string Productname= StockDGView.SelectedRows[0].Cells["productid"].Value.ToString();
               if ( GLibrary .IsNumeric(Productname) )
                {
                    ProductAdd frm =new ProductAdd ();
                    frm.PassProductId = long.Parse (Productname);
                    frm.ShowDialog ();
                }
            }
           
        }

        private void ProductsTreeMenuItem_Click(object sender, EventArgs e)
        {
            
          ProductsList  frmProductListTree = new ProductsList();
          frmProductListTree.ShowDialog();
    
          
        }

        private void StoreAddMenuItem_Click(object sender, EventArgs e)
        {
           
               StroesAdd frmStroes = new StroesAdd();     
               frmStroes.ShowDialog ();
               this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
      
         
        }

        private void TransItemsMenuItem_Click(object sender, EventArgs e)
        {
         
            StockMoveAdd frmStockMoveAdd = new StockMoveAdd();
            if (sTOREFromIDComboBox.SelectedValue != null)
            {
                frmStockMoveAdd.PassfromStoreId = int.Parse (sTOREFromIDComboBox.SelectedValue.ToString ());
            }
            frmStockMoveAdd.ShowDialog ();
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            ProductsPop frm = new ProductsPop();

            frm.ShowDialog();
            if (frm.EditFlag)
            {
                Search();
            }
        }

        private void StockDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            if (StockDGView.Rows.Count > 0)
            {
                switch (e.ColumnIndex)
                {
                    case 10:
                        if ((StockDGView.Rows[e.RowIndex].Cells["THRESHOLDINSTOCK"].Value) != DBNull.Value && (StockDGView.Rows[e.RowIndex].Cells["QUANTITY"].Value) != DBNull.Value)
                        {
                            decimal THRESHOLDQTY = decimal.Parse(StockDGView.Rows[e.RowIndex].Cells["THRESHOLDINSTOCK"].Value.ToString());
                            decimal QTY = decimal.Parse(StockDGView.Rows[e.RowIndex].Cells["QUANTITY"].Value.ToString());

                            if (QTY<=THRESHOLDQTY )
                            {
                                StockDGView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink  ;
                            }
                        }
                        break;
                }
            }


        }

        
    }
}