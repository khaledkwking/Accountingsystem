using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
namespace ERPSYS
{
    public partial class StockMoveList : Form
    {
        public int iStoreId;
        public String strStoreName;
        public String strStoreCode;
        public Boolean EditFlag = true;
      
        public StockMoveList()
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
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.
            this.stockMovementTableAdapter.Fill(this.nEWERPDataSet.StockMovement);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            pRODUCTSBindingSource.Filter = "MainNode=false";

        }

                  

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            //LastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
            //DetLastIden = int.Parse(qidsDetailsTableAdapter.GetQidsDetLastIdentity().ToString());

            stockMovementBindingSource.CurrencyManager.AddNew();
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõSave";
            }
            movmentQtyTextBox.Text = "0";
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
           
            
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            //if (StoresDGView.SelectedRows.Count > 0)
            //{
            //    if (GLibrary.MsgCheckDel())
            //    {
            //        int index = StoresDGView.SelectedRows[0].Index;
            //        //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
            //        sTORESBindingSource.RemoveCurrent();
            //        sTORESBindingSource.EndEdit();
            //        sTORESTableAdapter.Update(nEWERPDataSet.STORES);
            //        if (nEWERPDataSet.STORES.Rows.Count > 0)
            //        {
            //            StoresDGView.Rows[sTORESBindingSource.Position].Selected = true;
            //        }
            //        //StoresDGView.Refresh();


            //    }
            //}
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
                        stockMovementBindingSource.EndEdit();
                        stockMovementTableAdapter.Update(nEWERPDataSet.StockMovement);
                        GLibrary.MsgSave();
                        CmdAdd.Enabled = true;
                        CmdDel.Enabled = false;
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
            if (StoresDGView.SelectedRows.Count > 0 && EditFlag)
            {
                this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

                string MoveId = StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString();
                string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].FormattedValue.ToString();
                string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].FormattedValue.ToString();
                string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].FormattedValue.ToString();
                string UnitID = StoresDGView.SelectedRows[0].Cells["UnitID"].FormattedValue.ToString();
                string MovmentQty = StoresDGView.SelectedRows[0].Cells["MovmentQty"].Value.ToString();
                string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
                ShowReport frm = new ShowReport();
                frm.MoveId = MoveId;
                frm.STOREFromID = STOREFromID;
                frm.STOREToID = STOREToID;
                frm.PRODUCTID = PRODUCTID;
                frm.UnitID = UnitID;
                frm.MovmentQty = MovmentQty;
                frm.EnterDate = EnterDate;
                frm.ProdcutCode = pRODUCTIDComboBox.Text;
                frm.choiceNum = 2;
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("ÞÇã ÈÍÝÙ ÇáÊÍæíá ÇæáÇ", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
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

      

            
    }
}