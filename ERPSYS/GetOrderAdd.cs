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
    public partial class GetOrderAdd : DockContent
    {
        public int OrderType;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
      
        
        public GetOrderAdd()
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
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERDETAILS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.nEWERPDataSet.ORDERS);

            this.oRDERDETAILSTableAdapter.Fill(this.nEWERPDataSet.ORDERDETAILS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERS' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            switch (OrderType)
            {
                case 1:
                    groupBox1.Text = "ÈíÇäÇÊ ÇãÑ ÇáÊæÑíÏ";
                    CmbReferTo.DataSource = slGetTypes.ToDataTable();
                    this.Text = "ÊæÑíÏ ãÎÒæä";

                    break;
                case 2:
                    groupBox1.Text = "ÈíÇäÇÊ ÇãÑ ÕÑÝ";
                    this.Text = "ÕÑÝ ãÎÒæä";
                    break;
                case 3:
                    break;
            }
           //oRDERSBindingSource.Filter = "ORDERTYPE = " + OrderType.ToString();
            //txtOrderType.Text = OrderType.ToString();         
           
           

        }

       
        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            oRDERSBindingSource.EndEdit();
            oRDERSTableAdapter.Update(nEWERPDataSet.ORDERS);

            oRDERDETAILSBindingSource.EndEdit();
            oRDERDETAILSTableAdapter.Update(nEWERPDataSet.ORDERDETAILS);

                GLibrary.MsgSave();
                           
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            oRDERSBindingSource.AddNew();
            oRDERDETAILSBindingSource.AddNew();
            //txtOrderType.Text = OrderType.ToString();
            txtOrderDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");

                  
            
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (ProductsDGView.SelectedRows.Count > 0) 
            {
                if (GLibrary.MsgCheckDel())
            {
                int index  = ProductsDGView.SelectedRows[0].Index;
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                sTORESBindingSource.RemoveCurrent();
                sTORESBindingSource.EndEdit();
                sTORESTableAdapter.Update(nEWERPDataSet.STORES);
                if (nEWERPDataSet.STORES.Rows .Count >0)
                {
                    ProductsDGView.Rows[sTORESBindingSource.Position].Selected = true; 
                }
                //StoresDGView.Refresh();
                 

            }
            }
        }

        private void oRDERSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (oRDERSBindingSource.Count > 0)
            //{
            //    Int64 OrderId = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderID"];
            //    oRDERDETAILSBindingSource.Filter = "OrderID = " + OrderId.ToString();
            //    if (!((DataRowView)oRDERSBindingSource.Current).IsNew)
            //    {

            //        Int64 SupCustId = (Int64)((DataRowView)oRDERSBindingSource.Current)["SUP_CUST_ID"];
            //        Int64 StoreIdFrom = (Int64)((DataRowView)oRDERSBindingSource.Current)["STOREIDFROM"];
            //        Int64 StoreIdTo = (Int64)((DataRowView)oRDERSBindingSource.Current)["STOREIDTO"];
            //        int Pos = sUPPLIERSCUSTOMERSBindingSource.Find("SUP_CUST_ID", SupCustId);
            //        if (Pos != -1)
            //        {
            //            txtCustSupName.Text = nEWERPDataSet.SUPPLIERS_CUSTOMERS.Rows[Pos]["SUP_CUST_FNAME"].ToString();
            //            txtCustSupCode.Text = nEWERPDataSet.SUPPLIERS_CUSTOMERS.Rows[Pos]["SUP_CUST_CODE"].ToString();
            //        }
            //        Int64 StroeId = -1;
            //        switch (OrderType)
            //        {
            //            case 1:
            //                StroeId = StoreIdTo;
            //                break;
            //            case 2:
            //                StroeId = StoreIdFrom;
            //                break;
            //            case 3:
            //                break;
            //        }
            //        Pos = sTORESBindingSource.Find("StoreId", StroeId);
            //        if (Pos != -1)
            //        {
            //            txtStoreName.Text = nEWERPDataSet.STORES.Rows[Pos]["STORNAME"].ToString();
            //            txtStoreCode.Text = nEWERPDataSet.STORES.Rows[Pos]["STORECode"].ToString();
            //        }

            //    }
            //}
           
        }

        //private void oRDERDETAILSBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        //{
          
          
        //}

        private void oRDERDETAILSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (oRDERSBindingSource.Count > 0 && oRDERDETAILSBindingSource.Count > 0)
            {
                  ((DataRowView)oRDERDETAILSBindingSource.Current)["OrderID"] = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderID"];
                
                   
            }
          
            
        }

        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int iStoreId = -1;
                string strStoreName = "";
                string strStoreCode="";
                DisplayStores(ref strStoreName, ref iStoreId, ref strStoreCode);
                txtStoreName.Text = strStoreName;
                txtStoreCode.Text = strStoreCode;
                switch (OrderType)
                {
                    //case 1:
                    //    txtStoreIdTo.Text = iStoreId.ToString();
                    //    break;
                    //case 2:
                    //    txtStoreIdFrom.Text = iStoreId.ToString();
                    //    break;
                    //case 3:
                    //    break;
                }
               
            }
        }
        private void DisplayStores(ref string StoreName, ref int iStoreId,ref string StoreCode)
        {
            stroesList frm = new stroesList();
            DialogResult ret = frm.ShowDialog(this);
            if (DialogResult.OK == ret)
            {
                StoreName = frm.strStoreName;
                iStoreId = frm.iStoreId;
                StoreCode = frm.strStoreCode;
               
            }
        }
        private void DisplayCustSup(ref string CustSupName, ref int iCustSupId, ref string CustSupCode)
        {
            CustSupList frm = new CustSupList();
            frm.SUPCUSTTYPE = OrderType.ToString ();
            DialogResult ret = frm.ShowDialog(this);
            if (DialogResult.OK == ret)
            {
                CustSupName = frm.strCustName ;
                iCustSupId = frm.iCustSupId ;
                CustSupCode = frm.strCustCode ;

            }

        }

        private void txtSuplierCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int iCustSupId = -1;
                string strCustSupName = "";
                string strCustSupCode = "";
                DisplayCustSup(ref strCustSupName, ref iCustSupId, ref strCustSupCode);
                txtCustSupName.Text = strCustSupName;
                txtCustSupId.Text = iCustSupId.ToString();
                txtCustSupCode.Text = strCustSupCode;

            }
        }
        private void DisplayProducts(ref string ProductName, ref int ProductID, ref string ProductCode)
        {
            ProductsList frm = new ProductsList();
            DialogResult ret = frm.ShowDialog(this);
            if (DialogResult.OK == ret)
            {
                ProductName = frm.CurProductName;
                ProductID = frm.CurProductId;
                ProductCode = frm.CurProductCode;
            }

        }
        private void StoresDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int iProductId = -1;
                string strProductName = "";
                string strProductCode = "";
                DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

                ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = strProductCode;
                ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = strProductName;
                ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = iProductId.ToString();


            }
        }

        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ProductsDGView.Rows[e.RowIndex].Cells["productIdDataGridViewTextBoxColumn"].Value != null)
            {
                string strProductId = ProductsDGView.Rows[e.RowIndex].Cells["productIdDataGridViewTextBoxColumn"].Value.ToString();

                if (strProductId != "")
                {
                    int Pos = pRODUCTSBindingSource.Find("PRODUCTID", strProductId);
                    if (Pos != -1)
                    {
                        string ProductCode = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductCode"].ToString();
                        string ProductName = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductName"].ToString();
                        ProductsDGView.Rows[e.RowIndex].Cells["ProductCode"].Value = ProductCode;
                        ProductsDGView.Rows[e.RowIndex].Cells["ProductName"].Value = ProductName;
                    }
                }
            }
        }

       
       
        private void GetOrderAdd_Activated(object sender, EventArgs e)
        {
            
        }

        private void oRDERSBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtStoreCode.Text = "";
            txtStoreName.Text = "";
            txtCustSupName.Text = "";
            txtCustSupCode.Text = "";
        }

        private void ProductsDGView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewCell  cur_cell =ProductsDGView.CurrentCell;
                int col = cur_cell.ColumnIndex;
                if (col == 0)
                {
                    int iProductId = -1;
                    string strProductName = "";
                    string strProductCode = "";
                    DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

                    ProductsDGView.Rows[cur_cell.RowIndex].Cells[col].Value = strProductCode;
                    ProductsDGView.Rows[cur_cell.RowIndex].Cells[col + 1].Value = strProductName;
                    ProductsDGView.Rows[cur_cell.RowIndex].Cells[col + 2].Value = iProductId.ToString();
                }

            }
        }

       

        

       

        
    }
}