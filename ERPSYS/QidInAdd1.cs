using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class QidInAdd1 : Form
    {
        private int LastIden = -1;
        public QidInAdd1()
        {
            InitializeComponent();
        }

        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            accountingBindingSource.Filter = "root=" + Boolean.FalseString;
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                      
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            LastIden = (int)qidsTableAdapter.GetQidsLastIdentity();

            qidsBindingSource.AddNew();
            qidDateDateTimePicker.Value = DateTime.Today;
            txtrecitetype.Text = Messages.qidInTypeId;
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
            }
          
            
        }
        
        
     

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //sTORESBindingSource.EndEdit();
            ////nEWERPDataSet.AcceptChanges();
            //sTORESTableAdapter.Update(nEWERPDataSet.STORES);
            //StoresDGView.Refresh();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            //int ProductId=-1;
            //int ProductUnit=-1;
            //int StoreId=-1;
            //if (txtProductId.Text != "")
            //{
            //     StoreId = int.Parse(StoresDGView.SelectedRows[0].Cells["StoreId"].Value.ToString());

            //    productUnitsPricesBindingSource.Filter = "ProductId=" + txtProductId.Text;
            //    System.Data.DataView list = new System.Data.DataView();
            //    list = (DataView)productUnitsPricesBindingSource.List;
            //    DataTable T = list.ToTable();
            //    for (int i = 0; i < T.Rows.Count; i++)
            //    {
            //        ProductId = int.Parse(T.Rows[i]["ProductId"].ToString ());
            //        ProductUnit = int.Parse(T.Rows[i]["UintId"].ToString ());


            //        if (ProductId != -1 && ProductUnit != -1 && StoreId != -1)
            //        {
            //            ERPSYS.NEWERPDataSet.STOCKRow row = nEWERPDataSet.STOCK.NewSTOCKRow();
            //            row.PRODUCTID = ProductId;
            //            row.UnitID = ProductUnit;
            //            row.STOREID = StoreId;
                         
            //            nEWERPDataSet.STOCK.Rows.Add(row);
                        
            //        }
            //    }
            //    sTOCKTableAdapter.Update(nEWERPDataSet.STOCK);
            //    GetStock();

            //}
   
        }
    
              
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    int iProductId = -1;
            //    string strProductName = "";
            //    string strProductCode = "";
            //    DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

            //    txtProductCode.Text = strProductCode;
            //    txtProductName.Text = strProductName;
            //    txtProductId.Text = iProductId.ToString();
            //}
        }

        private void DisplayProducts(ref string ProductName, ref int ProductID, ref string ProductCode)
        {
            //ProductsList frm = new ProductsList();
            //DialogResult ret = frm.ShowDialog(this);
            //if (DialogResult.OK == ret)
            //{
            //    ProductName = frm.CurProductName;
            //    ProductID = frm.CurProductId;
            //    ProductCode = frm.CurProductCode;
            //}

        }
     
        private void StoreSearch(string ColName, string Value)
        {
            //int Pos = sTOCKBindingSource.Find(ColName, Value);
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    StoresDGView.Rows[Pos].Selected = true;
            //}
        }

        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {
                                
                if (qidsBindingSource.Count == 1 && ((DataRowView)qidsBindingSource.Current)["qidid"].ToString() == "0")
                {
                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(LastIden);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                qidsDetailsBindingSource.Filter = "qidid = " + qidid.ToString();

                
            }
        }

        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            {

                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");
               
            }
        }

        private void StockDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (StockDGView.Rows.Count > 0)
            {
                //decimal Credit = 0;
                //switch (e.ColumnIndex)
                {
                    //    case 0: //Tovale

                    //        if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    //        {

                    //            txtTotalToValue.Text = (decimal.Parse(txtTotalToValue.Text) + decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString();
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString()))
                    //            {
                    //                txtTotalFromValue.Text = (decimal.Parse(txtTotalFromValue.Text) - decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())).ToString();
                    //            }
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[1].Value = DBNull.Value;
                    //        }
                    //        else
                    //        {
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                    //        }
                    //         Credit=(decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
                    //        if (Credit<0)
                    //        {
                    //            Credit =(Credit * -1);
                    //        }
                    //        txttotalBalance.Text = Credit.ToString();
                    //        break;
                    //    case 1: //fromValue
                    //        if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    //        {
                    //            txtTotalFromValue.Text = (decimal.Parse(txtTotalFromValue.Text) + decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())).ToString();
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    //            {
                    //                txtTotalToValue.Text = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString();
                    //            }
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[0].Value =DBNull.Value  ;
                    //        }
                    //        else
                    //        {
                    //            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                    //        }
                    //        Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
                    //        if (Credit < 0)
                    //        {
                    //            Credit = (Credit * -1);
                    //        }
                    //        txttotalBalance.Text = Credit.ToString();
                    //        break;

                    //}
                }
            }
        }

        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            //if (decimal.Parse(txtTotalFromValue.Text) == decimal.Parse(txtTotalToValue.Text))
            //{
            //    this.Validate();
            //    qidsBindingSource.EndEdit();
            //    qidsDetailsBindingSource.EndEdit();

            //    qidsTableAdapter.Update(nEWERPDataSet.qids);
            //    qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            //    GLibrary.MsgSave();
            //}
            //else
            //{
            //    MessageBox.Show(Messages.QidNotBalanceMesg, "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}
        }

        
       

        
    }
}