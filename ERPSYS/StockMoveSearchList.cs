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
    public partial class StockMoveSearchList : DockContent
    {
        public int iStoreId;
        public String strStoreName;
        public String strStoreCode;
        public Boolean EditFlag = true;

        public StockMoveSearchList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovementView' table. You can move, or remove it, as needed.
            this.stockMovementViewTableAdapter.Fill(this.nEWERPDataSet.StockMovementView);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.
        
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            pRODUCTSBindingSource.Filter = "MainNode=false";
            pRODUCTIDComboBox.SelectedValue = -1;
            unitIDComboBox.SelectedValue =-1;
            sTOREFromIDComboBox.SelectedValue = -1;
            sTOREToIDComboBox.SelectedValue =-1;
            comboBox1.SelectedValue = -1;
            cmbBarCode.SelectedValue = -1;

            //enterDateDateTimePicker.Value = null;
        }

                  

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            //AddNew();
        }

      

      

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                if (pRODUCTIDComboBox.SelectedValue != null && sTOREFromIDComboBox.SelectedValue != null && sTOREToIDComboBox != null && GLibrary.IsNumeric(movmentQtyTextBox.Text))
                {
                    if (int.Parse(movmentQtyTextBox.Text) > 0)
                    {
                        this.Validate();
                        stockMovementViewBindingSource.EndEdit();
                        //stockMovementViewBindingSource.Update(nEWERPDataSet.StockMovement);
                        GLibrary.MsgSave();
                        CmdAdd.Enabled = true;
                        CmdSearch.Enabled = false;
                        EditFlag = true;
                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            CmdSave.Text = "ÊÚÏíá";

                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            CmdSave.Text = "òõEdit";
                        }
                    }
                    else
                    {
                        MessageBox.Show("ßãíÉ ÇáÊÍæíá ÛíÑ ÕÍíÍíÉ", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show("ÇÏÎá ÈíÇäÇÊ ÇáÊÍæíá ÈØÑíÞÉ ÕÍíÍÉ", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void pRODUCTIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pRODUCTIDComboBox.SelectedValue != null)
            {

                string ProductId = pRODUCTIDComboBox.SelectedValue.ToString();
                int pos=product_Units_PricesBindingSource.Find("productid", ProductId);
                if (pos > -1)
                {
                    long unitId = long.Parse(nEWERPDataSet.Product_Units_Prices.Rows[pos]["UintId"].ToString());
                    unitIDComboBox.SelectedValue = unitId;
                }
                //this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
            }
 
            
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //if (StoresDGView.SelectedRows.Count > 0 && EditFlag)
            //{
            //    this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            //    string MoveId = StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString();
            //    string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].FormattedValue.ToString();
            //    string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].FormattedValue.ToString();
            //    string PRODUCTID = StoresDGView.SelectedRows[0].Cells["MovPRODUCTID"].FormattedValue.ToString();
            //    string UnitID = StoresDGView.SelectedRows[0].Cells["MovUINTID"].FormattedValue.ToString();
            //    string MovmentQty = StoresDGView.SelectedRows[0].Cells["MovMovmentQty"].Value.ToString();
            //    string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
            //    ShowReport frm = new ShowReport();
            //    frm.MoveId = MoveId;
            //    frm.STOREFromID = STOREFromID;
            //    frm.STOREToID = STOREToID;
            //    frm.PRODUCTID = PRODUCTID;
            //    frm.UnitID = UnitID;
            //    frm.MovmentQty = MovmentQty;
            //    frm.EnterDate = EnterDate;
            //    frm.ProdcutCode = pRODUCTIDComboBox.Text;
            //    frm.choiceNum = 2;
            //    frm.nEWERPDataSet = nEWERPDataSet;
            //    frm.ShowDialog();

            //}
           
                //ShowProductsRpt frm = new ShowProductsRpt();
                //this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
             
                //frm.nEWERPDataSet = nEWERPDataSet;
                //frm.choiceNum = 12;
                //frm.InvType = "òÓäÏ ÊÍæíá";
                //frm.InvDate = MoveDatePicker.Value;
                //frm.ShowDialog(this);

           //}
            //else
            //{
            //    MessageBox.Show(Messages.CheckInvPrintMsg, "ÇáÇÕäÇÝ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}
            //else
            //{
            //    MessageBox.Show("ÞÇã ÈÍÝÙ ÇáÊÍæíá ÇæáÇ", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}
        }

        private void cmbBarCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbBarCode.SelectedValue != null)
            {
                long ProductId = long.Parse(cmbBarCode.SelectedValue.ToString());
                int Pos =pRODUCTSBindingSource.Find("PRODUCTID", ProductId);
                if (Pos>-1)
                {
                    pRODUCTSBindingSource.Position = Pos;
                }
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            string SqlStr = "1=1 ";
            if (pRODUCTIDComboBox.SelectedValue != null)
            {
                SqlStr = SqlStr+ " And PRODUCTID=" + pRODUCTIDComboBox.SelectedValue;
            }
            if (unitIDComboBox.SelectedValue != null)
            {
                SqlStr = SqlStr+ " And UnitID=" + unitIDComboBox.SelectedValue;
            }
            if (sTOREFromIDComboBox.SelectedValue != null)
            {
                SqlStr = SqlStr + " And STOREFromID=" + sTOREFromIDComboBox.SelectedValue;
            }

            if (sTOREToIDComboBox.SelectedValue != null)
            {
                SqlStr = SqlStr + " And STOREToID=" + sTOREToIDComboBox.SelectedValue;
            }
            if (GLibrary.IsDate( txtEnterDate.Text))
            {
                SqlStr = SqlStr + " And EnterDate='" + txtEnterDate.Text + "'";
            }
            if (GLibrary.IsNumeric(movmentQtyTextBox.Text))
            {
                SqlStr = SqlStr + " And MovmentQty=" + movmentQtyTextBox.Text;
            }


            stockMovementViewBindingSource.Filter = SqlStr;
        }

        private void enterDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtEnterDate.Text = enterDateDateTimePicker.Value.ToShortDateString();

        }

        private void StoresDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             if (StoresDGView.SelectedRows.Count > 0)
            {
                string MoveId = StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString();
                //string InvType = StoresDGView.SelectedRows[0].Cells["InvType"].Value.ToString();
               //
                        StockMoveAdd frm = new StockMoveAdd();
                        frm.EditFlag = true;
                        frm.MoveId  = long.Parse(MoveId);
                       
                        frm.ShowDialog();
                       
                    //
                }
        }
      

            
    }
}