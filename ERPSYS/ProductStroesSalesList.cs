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
    public partial class ProductStroesSalesList :DockContent
    {
        private Nullable<long> BranchId = null;
        //private Nullable<int> ProductId = null;
        private Nullable<int> StoreId = null;
        private string SBarCode=null ;
       
        private string SProductCode = null;
        private Nullable<int> UnitId = null;
        private Nullable<DateTime> ToDate = null;
        private Nullable<DateTime> FromDate = null;
        private Nullable<long> ProductId = null;

        public ProductStroesSalesList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERS' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvProductsMoveVIEW' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
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
            cmbProductCode.SelectedValue = -1;
            cmbProductName.SelectedValue = -1;
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

                //txtProductCode.Text = strProductCode;
                //txtProductName.Text = strProductName;
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
              BranchId   =  null ;
              ProductId   =  null ;
              ToDate =null ;
              FromDate  = null;
        
        
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
            if (cmbProductName.SelectedValue !=null )
            {
                ProductId = long.Parse(cmbProductName.SelectedValue.ToString());
            }
             else 
            {
                ProductId =null;
            }
             if (txtBarCode.Text !="")
            {
                SBarCode=txtBarCode.Text;
            }
            else
            {
                SBarCode=null;
            }
            invProductsMoveVIEWBindingSource.Filter = "InvType=" + GLibrary.strarrInvType[1, 0].ToString();
            invProductsMoveVIEWBindingSource1.Filter = "InvType=" + GLibrary.strarrInvType[0, 0].ToString();
           
            this.invProductsMoveVIEWTableAdapter.FillByParamAll(this.nEWERPDataSet.InvProductsMoveVIEW, ProductId, BranchId, StoreId, null, UnitId, SBarCode, FromDate,ToDate );
            //this.stockViewTableAdapter.FillByParam(this.nEWERPDataSet.StockView, BranchId, StoreId, SBarCode, SProductName, SProductCode, MinPriceVal, MaxPriceVal,UnitId );
            GetSalesPriceSum();
            GetPruchasePriceSum();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowNewRpt frm = new ShowNewRpt();
            frm.choiceNum = 91;
            frm.nEWERPDataSet = nEWERPDataSet;
            frm.ShowDialog(this);
         
        }
        private void GetSalesPriceSum()
        {
            txtinvTotal.Text = "0";
            //for (int i = 0; i < invProductsBindingSource.Count; i++)
            if (invProductsMoveVIEWBindingSource.Count > 0)
            {
                decimal invTotalQty = 0;
                decimal invTotalPrice = 0;
                decimal invTotalCostPrice = 0;
                decimal TotalProfit = 0;
                for (int i = 0; i < StockDGView.Rows.Count; i++)
                {
                    if (StockDGView.Rows[i].Cells["Qty"].Value != null)
                    {
                        if (GLibrary.IsNumeric(StockDGView.Rows[i].Cells["Qty"].Value.ToString()))
                        {
                            invTotalQty = invTotalQty + decimal.Parse(StockDGView.Rows[i].Cells["Qty"].Value.ToString());
                           
                        }
                    }
                    if (StockDGView.Rows[i].Cells["TotalPrice"].Value != DBNull.Value)
                    {
                        if (GLibrary.IsNumeric(StockDGView.Rows[i].Cells["TotalPrice"].Value.ToString()))
                        {
                             invTotalPrice  = invTotalPrice + decimal.Parse(StockDGView.Rows[i].Cells["TotalPrice"].Value.ToString());
                          
                        }
                    }
                    if (StockDGView.Rows[i].Cells["LastCostPrice"].Value != DBNull.Value)
                    {
                        if (GLibrary.IsNumeric(StockDGView.Rows[i].Cells["LastCostPrice"].Value.ToString()))
                        {
                            invTotalCostPrice = invTotalCostPrice + decimal.Parse(StockDGView.Rows[i].Cells["LastCostPrice"].Value.ToString());
                            
                        }
                    }
                 
                   
                }
            
                txtTotalQty.Text = invTotalQty.ToString();
                txtinvTotal.Text = invTotalPrice.ToString();
                txtTotalCost.Text = (invTotalCostPrice * invTotalQty).ToString();

                TotalProfit = invTotalPrice - (invTotalCostPrice * invTotalQty);
                txtTotalProfit.Text = TotalProfit.ToString();
                
            }
        }

        private void GetPruchasePriceSum()
        {
            txtPTotalQty.Text = "0";
            txtPinvTotal.Text = "0";
            //for (int i = 0; i < invProductsBindingSource.Count; i++)
            if (invProductsMoveVIEWBindingSource1.Count > 0)
            {
                decimal invTotalQty = 0;
                decimal invTotalPrice = 0;
               
                for (int i = 0; i < StockPruchaseView.Rows.Count; i++)
                {
                    if (StockPruchaseView.Rows[i].Cells["PQty"].Value != null)
                    {
                        if (GLibrary.IsNumeric(StockPruchaseView.Rows[i].Cells["PQty"].Value.ToString()))
                        {
                            invTotalQty = invTotalQty + decimal.Parse(StockPruchaseView.Rows[i].Cells["PQty"].Value.ToString());

                        }
                    }
                    if (StockPruchaseView.Rows[i].Cells["PTotalPrice"].Value != DBNull.Value)
                    {
                        if (GLibrary.IsNumeric(StockPruchaseView.Rows[i].Cells["PTotalPrice"].Value.ToString()))
                        {
                            invTotalPrice = invTotalPrice + decimal.Parse(StockPruchaseView.Rows[i].Cells["PTotalPrice"].Value.ToString());

                        }
                    }
                    //if (StockPruchaseView.Rows[i].Cells["LastCostPrice"].Value != DBNull.Value)
                    //{
                    //    if (GLibrary.IsNumeric(StockPruchaseView.Rows[i].Cells["LastCostPrice"].Value.ToString()))
                    //    {
                    //        invTotalCostPrice = invTotalPrice + decimal.Parse(StockPruchaseView.Rows[i].Cells["LastCostPrice"].Value.ToString());

                    //    }
                    //}

                }
                txtPTotalQty.Text = invTotalQty.ToString();
                txtPinvTotal.Text = invTotalPrice.ToString();

                //txtTotalCost.Text = (invTotalCostPrice * invTotalQty).ToString();
            }
        }

        private void StockDGView_SelectionChanged(object sender, EventArgs e)
        {
            decimal Qty = 0;
            decimal TotalPrice = 0;
            if ((DataRowView)(invProductsMoveVIEWBindingSource.Current) != null)
            {

                if (((DataRowView)(invProductsMoveVIEWBindingSource.Current))["QUANTITY"] != DBNull.Value)
                {
                    if (GLibrary.IsNumeric(((DataRowView)(invProductsMoveVIEWBindingSource.Current))["QUANTITY"].ToString()))
                    {
                        txtStockTotalQty.Text = ((DataRowView)(invProductsMoveVIEWBindingSource.Current))["QUANTITY"].ToString();
                        Qty = decimal.Parse(txtStockTotalQty.Text);
                    }
                    if (((DataRowView)(invProductsMoveVIEWBindingSource.Current))["QUANTITY"] != DBNull.Value)
                    {
                        if (GLibrary.IsNumeric(((DataRowView)(invProductsMoveVIEWBindingSource.Current))["Price"].ToString()))
                        {
                            TotalPrice =Qty * decimal.Parse( ((DataRowView)(invProductsMoveVIEWBindingSource.Current))["Price"].ToString());
                            txtStockTotalCost.Text = TotalPrice.ToString();
                        }
                    }
                }
            }
        }

        
    }
}