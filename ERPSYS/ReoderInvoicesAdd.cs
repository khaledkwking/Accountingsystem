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
    public partial class ReoderInvoicesAdd : DockContent
    {
        public int iStoreId;
        public String strStoreName;
        public long ReorderId = 0;
        public Boolean EditFlag = false;
        public int LInvType;

        private StaticList slInvType = new StaticList(GLibrary.strarrInvType);

        public ReoderInvoicesAdd()
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
            product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvoiceReoders' table. You can move, or remove it, as needed.
            this.invoiceReodersTableAdapter.Fill(this.nEWERPDataSet.InvoiceReoders);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            //CmbInvTypes.DataSource = slInvType.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.
            pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);

            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            pRODUCTSBindingSource.Filter = "MainNode=false";

            txtFromDate.Text = new DateTime(DateTime.Today.Year, 1, 1).ToShortDateString();
            txtToDate.Text = DateTime.Today.ToShortDateString();

            //CmboxCenter.SelectedValue = -1;
            //CmbInvTypes.SelectedValue = LInvType.ToString();
            //CmbInvTypes.Enabled = false;
            if (EditFlag)
            {
                if (ReorderId > 0)
                {
                    invoiceReodersTableAdapter.FillByDate(this.nEWERPDataSet.InvoiceReoders, ReorderId, null, null);
                    this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, ReorderId);
                }
                this.invoiceViewTableAdapter.FillByAll(this.nEWERPDataSet.InvoiceView);
                Search();
                GetPriceSum();
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                BtnPrint.Enabled = true;

            }
            else
            {
                AddNew();
            }

        }




        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string MoveId = StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString();
                string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].Value.ToString();
                string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].Value.ToString();
                string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].Value.ToString();
                string UnitID = StoresDGView.SelectedRows[0].Cells["UnitID"].Value.ToString();
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
                frm.choiceNum = 2;
                frm.ShowDialog();

            }
        }

        private void Search()
        {
            this.invoiceViewTableAdapter.FillByAll(this.nEWERPDataSet.InvoiceView);

            string StrSql = "InvType=2";
            //if (CmbInvTypes.SelectedValue !=null )
            //{
            //    StrSql = StrSql + " And InvType=" + CmbInvTypes.SelectedValue.ToString();

            //}
            //if (CmbBranches.SelectedValue !=null)
            //{
            //    StrSql = StrSql + " And BranchId=" + CmbBranches.SelectedValue.ToString();
            //}
            if (CmbCustSupAccid.SelectedValue != null)
            {
                StrSql = StrSql + " And SUP_CUST_ID=" + CmbCustSupAccid.SelectedValue.ToString();
            }

            if (txtFromDate.Text != "")
            {
                //string FromDate = DateTime.Parse(txtFromDate.Text + " 23:59").ToString();
                StrSql = StrSql + " And InvDate>='" + txtFromDate.Text + "'";
            }
            if (txtToDate.Text != "")
            {
                string toDate = DateTime.Parse(txtToDate.Text + " 23:59").ToString();
                StrSql = StrSql + " And InvDate<='" + toDate + "'";
            }

            invoiceViewBindingSource.Filter = StrSql;

        }

        private void StoresDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void CmbInvTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void CmbBranches_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void CmboxCenter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void StoresDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string InvId = StoresDGView.SelectedRows[0].Cells["InvId"].Value.ToString();
                string InvType = StoresDGView.SelectedRows[0].Cells["InvType"].Value.ToString();
                switch (InvType)
                {
                    case "2":
                        InvoiceSalReoderAdd frm = new InvoiceSalReoderAdd();
                        frm.EditFlag = true;
                        frm.CurInvId = long.Parse(InvId);
                        frm.CurReoderId = long.Parse(txtCode.Text);
                        frm.InvType = 2;
                        frm.ShowDialog();
                        if (frm.UpdateFlag)
                        {
                            if (txtCode.Text != "")
                            {
                                long reoderId = long.Parse(txtCode.Text);
                                this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, reoderId);
                            }
                            GetPriceSum();
                        }
                        break;
                }
                //string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].Value.ToString();
                //string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].Value.ToString();
                //string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].Value.ToString();
                //string UnitID = StoresDGView.SelectedRows[0].Cells["UnitID"].Value.ToString();
                //string MovmentQty = StoresDGView.SelectedRows[0].Cells["MovmentQty"].Value.ToString();
                //string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
                //ShowReport frm = new ShowReport();
                //frm.MoveId = MoveId;
                //frm.STOREFromID = STOREFromID;
                //frm.STOREToID = STOREToID;
                //frm.PRODUCTID = PRODUCTID;
                //frm.UnitID = UnitID;
                //frm.MovmentQty = MovmentQty;
                //frm.EnterDate = EnterDate;
                //frm.choiceNum = 2;
                //frm.ShowDialog();

            }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ( GLibrary .IsNumeric ( txtCode.Text))
                {
                    long ReorderId = long.Parse(txtCode.Text);
                    invoiceReodersTableAdapter.FillByDate(this.nEWERPDataSet.InvoiceReoders, ReorderId, null, null);
                    this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, ReorderId);
                    if ( invoiceReodersBindingSource .Count > 0 )
                    {
                        EditFlag=true ;
                        CmdAdd.Enabled = true;
                        CmdDel.Enabled = true;
                        BtnPrint.Enabled = true;
                    }
                }
                   Search();
            
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                if ( GLibrary .IsNumeric ( txtCode.Text))
                {
                    long ReorderId = long.Parse(txtCode.Text);
                    invoiceReodersTableAdapter.FillByDate(this.nEWERPDataSet.InvoiceReoders, ReorderId, null, null);
                    this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, ReorderId);
                }
                Search();
            }
        }

        private void enterDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = enterDateDateTimePicker.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dateTimePicker1.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void AddNew()
        {
            invoiceReodersBindingSource.AddNew();

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "ÚSave";
            }
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            BtnPrint.Enabled = false;
            CmbCustSupAccid.SelectedValue = -1;
            this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, -2);
            txtReorderDate.Text = DateTime.Today.ToShortDateString();
            EditFlag = false;

        }

        private void CmbCustSupAccid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                Search();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            invoiceReodersBindingSource.EndEdit();
            invoiceReodersTableAdapter.Update(this.nEWERPDataSet.InvoiceReoders);
            EditFlag = true;
            GLibrary.MsgSave();
            CmdAdd.Enabled = true;
            CmdDel.Enabled = true;
            BtnPrint.Enabled = true;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Edit";
            }


        }

        private void CmdDel_Click(object sender, EventArgs e)
        {

            if (GLibrary.MsgCheckDel())
            {
                if (ProductsDGView.RowCount < 1)
                {
                    //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                    invoiceReodersBindingSource.RemoveCurrent();
                    invoiceReodersBindingSource.EndEdit();
                    invoiceReodersTableAdapter.Update(this.nEWERPDataSet.InvoiceReoders);
                }
                else
                {
                    MessageBox.Show("ÌÃ» «Ê·«  ’›Ì— «’‰«› «·„— Ã⁄", "«·„— Ã⁄", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }


            }

        }

        private void ProductsDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ProductsDGView.SelectedRows.Count > 0)
            {
                string InvId = ProductsDGView.SelectedRows[0].Cells["PInvId"].Value.ToString();
                //string InvType = ProductsDGView.SelectedRows[0].Cells["InvType"].Value.ToString();


                InvoiceSalReoderAdd frm = new InvoiceSalReoderAdd();
                frm.EditFlag = true;
                frm.CurInvId = long.Parse(InvId);
                frm.CurReoderId = long.Parse(txtCode.Text); 
                frm.InvType = 2;
                frm.ShowDialog();
                if (frm.UpdateFlag)
                {
                    if (txtCode.Text != "")
                    {
                        long reoderId = long.Parse(txtCode.Text);
                        this.inv_ProductsTableAdapter.FillByReorderId(this.nEWERPDataSet.Inv_Products, reoderId);
                    }
                    GetPriceSum();
                }


            }
        }

        private void dateTimeReoder_ValueChanged(object sender, EventArgs e)
        {
            txtReorderDate.Text = dateTimeReoder.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void StoresDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void ProductsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnPrint_Click_1(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                ShowProductsRpt frm = new ShowProductsRpt();

                frm.nEWERPDataSet = nEWERPDataSet;
                frm.choiceNum = 30;
                frm.CustName = CmbCustSupAccid.Text;
                //frm.InvType = "Sales Invoice";


                if (txtinvTotal.Text != "")
                {
                    frm.TotalNet = decimal.Parse(txtinvTotal.Text);
                    frm.strTotalNet = GLibrary.FigureInWordsNumType(double.Parse(txtinvTotal.Text), 1);
                }
                else
                {
                    frm.TotalNet = 0;
                    frm.strTotalNet = "";
                }


                frm.InvDate = DateTime.Parse(txtReorderDate.Text);
                DialogResult ret = MessageBox.Show(Messages.ShowInvMesg, "«·⁄„·«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                if (ret == DialogResult.Yes)
                {
                    frm.PrintFlag = false;
                    frm.ShowDialog(this);
                }
                else
                {
                    frm.PrintFlag = true;
                    frm.ShowReport();
                }
            }
            else
            {
                MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }

        }


        private void GetPriceSum()
        {
            txtinvTotal.Text = "0";

            //for (int i = 0; i < invProductsBindingSource.Count; i++)
            if (invProductsBindingSource.Count > 0)
            {
                for (int i = 0; i < ProductsDGView.Rows.Count; i++)
                {
                    if (ProductsDGView.Rows[i].Cells["Qty"].Value != DBNull.Value && ProductsDGView.Rows[i].Cells["PriceVal"].Value != DBNull.Value)
                    {
                        if (ProductsDGView.Rows[i].Cells["Qty"].Value != null)
                        {
                            if (ProductsDGView.Rows[i].Cells["PriceVal"].Value != null)
                            {
                                if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["ReorderQty"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()))
                                {
                                    ProductsDGView.Rows[i].Cells["TotalPrice"].Value = (decimal.Parse(ProductsDGView.Rows[i].Cells["ReorderQty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString())) - decimal.Parse(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString());

                                    if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString()))
                                    {
                                        txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString())).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ProductsDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDGView.Rows.Count > 0)
            {
                if (e.ColumnIndex == PriceVal.Index || e.ColumnIndex == ReorderQty.Index)
                {
                    if (ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (GLibrary.IsNumeric(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {

                            GetPriceSum();
                            // txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).ToString();

                        }
                    }

                }
            }

        }
    }
    
}