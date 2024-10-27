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
    public partial class InvoicesList : DockContent
    {
        public int iStoreId;
        public String strStoreName;
        public String strStoreCode;
        public Boolean EditFlag = false;
        public Boolean CallFlag = true;
        public int LInvType;

        private StaticList slInvType = new StaticList(GLibrary.strarrInvType);

        public InvoicesList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.nEWERPDataSet.USER);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.

           


            CmbInvTypes.DataSource = slInvType.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.
            this.invoiceViewTableAdapter.FillByAll (this.nEWERPDataSet.InvoiceView);
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            costCentersBindingSource.Filter = "costId <>1 ";
            pRODUCTSBindingSource.Filter = "MainNode=false";
            CmbInvTypes.SelectedValue = -1;
            CmbBranches.SelectedValue = -1;
            CmboxCenter.SelectedValue = -1;
            comboBoxUser.SelectedValue = -1;
            CmbInvTypes.SelectedValue = LInvType.ToString();
            //txtPayFromDate.Text = DateTime.Today.ToShortDateString();
            //txtPayToDate.Text = DateTime.Today.ToShortDateString();

            //CmbInvTypes.Enabled = false;
            Search(CallFlag);
            if (Messages.Usertype != Messages.AdminUser)
            {
                CmbBranches.SelectedValue = Messages.CurBranch ;
                CmbBranches.Enabled = false;
            }
            else
            {

            }
            this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));
            CmbCustSupAccid.SelectedValue = -1;
        }

    


        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string MoveId=StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString ();
                string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].Value.ToString();
                string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].Value.ToString();
                string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].Value.ToString();
                string UnitID =StoresDGView.SelectedRows[0].Cells["UnitID"].Value.ToString();
                string MovmentQty =StoresDGView.SelectedRows[0].Cells["MovmentQty"].Value.ToString();
                string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
                ShowReport frm =new ShowReport();
                frm.MoveId=MoveId;
                frm.STOREFromID=STOREFromID;
                frm.STOREToID=STOREToID;
                frm.PRODUCTID=PRODUCTID ;
                frm.UnitID=UnitID ;
                frm.MovmentQty=MovmentQty ;
                frm.EnterDate=EnterDate;
                frm.choiceNum = 2;
                frm.ShowDialog();

            }
        }

        private void Search(Boolean Flag)
        {
            this.invoiceViewTableAdapter.FillByAll(this.nEWERPDataSet.InvoiceView);

            string StrSql = "1=1";
            if (Flag)
            {
                if (CmbInvTypes.SelectedValue != null)
                {
                    StrSql = StrSql + " And InvType=" + CmbInvTypes.SelectedValue.ToString();

                }
                if (CmbBranches.SelectedValue != null)
                {
                    StrSql = StrSql + " And BranchId=" + CmbBranches.SelectedValue.ToString();
                }
                if (CmboxCenter.SelectedValue != null)
                {
                    StrSql = StrSql + " And CostId=" + CmboxCenter.SelectedValue.ToString();
                }
                if (txtCode.Text != "")
                {
                    StrSql = StrSql + " And InvCode=" + txtCode.Text;
                }
                if (txtCode.Text != "")
                {
                    StrSql = StrSql + " And InvCode=" + txtCode.Text;
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


                if (txtPayFromDate.Text != "")
                {
                    //string FromDate = DateTime.Parse(txtFromDate.Text + " 23:59").ToString();
                    StrSql = StrSql + " And PaymentDate>='" + txtPayFromDate.Text + "'";
                }
                if (txtPayToDate.Text != "")
                {
                    string toDate = DateTime.Parse(txtPayToDate.Text + " 23:59").ToString();
                    StrSql = StrSql + " And PaymentDate<='" + toDate + "'";
                }
                if (ChkReoderFlag.Checked)
                {
                    StrSql = StrSql + " And CustId=" + 1;
                }
                if (CmbCustSupAccid.SelectedValue != null)
                {
                    StrSql = StrSql + " And Cust_Sup_Accid=" + CmbCustSupAccid.SelectedValue.ToString();

                }

                if (comboBoxUser.SelectedValue != null)
                {
                    StrSql = StrSql + " And BuyerId=" + comboBoxUser.SelectedValue.ToString();

                }
            }
            else
            {
                if (txtPayFromDate.Text != "")
                {
                    //string FromDate = DateTime.Parse(txtFromDate.Text + " 23:59").ToString();
                    StrSql = StrSql + " And PaymentDate<='" + txtPayFromDate.Text + "'" + " and PayFinish <> 1";
                }
            }
            invoiceViewBindingSource.Filter = StrSql;
        }

        private void StoresDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (StoresDGView.Columns[e.ColumnIndex].Name == "PaymentTypeDesc")
                {
                    if (StoresDGView.Rows[e.RowIndex].Cells["PaymentType"].Value != DBNull.Value)
                    {
                       
                        int TypeId = int.Parse(StoresDGView.Rows[e.RowIndex].Cells["PaymentType"].Value.ToString());
                        switch (TypeId)
                        {
                            case 1:
                                e.Value  = GLibrary.strarrBillType[0, 1];
                                // strarrBillType = new string[,] { { "1", "√Ã·" }, { "2", "‰ﬁœ«" } };
                                break;

                            case 2:
                                e.Value = GLibrary.strarrBillType[1, 1];
                                break;
                            case 3:
                                e.Value = GLibrary.strarrBillType[2, 1];
                                // strarrBillType = new string[,] { { "1", "√Ã·" }, { "2", "‰ﬁœ«" } };
                                break;

                            case 4:
                                e.Value = GLibrary.strarrBillType[3, 1];
                                break;

                        }
                    }
                }
                if (StoresDGView.Columns[e.ColumnIndex].Name == "InvTypeDesc")
                {
                    if (StoresDGView.Rows[e.RowIndex].Cells["InvType"].Value != DBNull.Value)
                    {
                        int TypeId = int.Parse(StoresDGView.Rows[e.RowIndex].Cells["InvType"].Value.ToString());
                        switch (TypeId)
                        {
                            case 1:
                                e.Value = GLibrary.strarrInvType[0, 1];
                                // strarrBillType = new string[,] { { "1", "√Ã·" }, { "2", "‰ﬁœ«" } };
                                break;

                            case 2:
                                e.Value = GLibrary.strarrInvType[1, 1];
                                break;
                            case 3:
                                e.Value = GLibrary.strarrInvType[2, 1];
                                break;
                            case 4:
                                e.Value = GLibrary.strarrInvType[3, 1];
                                break;
                        }
                    }
                }

                if (StoresDGView.Columns[e.ColumnIndex].Name == "ColColor")
                {
                    long curReferID =0;
                    if (StoresDGView.Rows[e.RowIndex].Cells["ReferID"].Value != DBNull.Value)
                    {
                         curReferID=long.Parse (StoresDGView.Rows[e.RowIndex].Cells["ReferID"].Value .ToString ());
                    }
                    if (StoresDGView.Rows[e.RowIndex].Cells["InvDate"].Value != DBNull.Value)
                    {
                         
                        DateTime CurInvDate = DateTime.Parse(StoresDGView.Rows[e.RowIndex].Cells["InvDate"].Value.ToString());

                        if (CurInvDate < DateTime.Today.AddDays(-60) && curReferID == 0)
                        {
                            StoresDGView.Rows[e.RowIndex].Cells["ColColor"].Style .BackColor = Color.Red;
                        }
                    }
                }

               

            }   
        }

        private void CmbInvTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search(true);
        }

        private void CmbBranches_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search(true);
        }

        private void CmboxCenter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search(true);
        }

        private void StoresDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string InvId = StoresDGView.SelectedRows[0].Cells["InvId"].Value.ToString();
                string InvType = StoresDGView.SelectedRows[0].Cells["InvType"].Value.ToString();
                switch (InvType)
                {
                    case "1":
                        InvoicePurchaseAdd frmPur = new InvoicePurchaseAdd();
                        frmPur.EditFlag = true;
                        frmPur.InvId = long.Parse(InvId);
                        frmPur.InvType = int.Parse (InvType);
                        frmPur.ShowDialog();
                       
                        break;
                    case "2":
                        InvoiceAdd frm = new InvoiceAdd();
                        frm.EditFlag = true;
                        frm.InvId = long.Parse(InvId);
                        frm.InvType = int.Parse (InvType);
                        frm.ShowDialog();
                        break;
                    case "3":
                        InvoiceSalesReorderAdd frmReturn = new InvoiceSalesReorderAdd();
                        frmReturn.EditFlag = true;
                        frmReturn.InvId = long.Parse(InvId);
                        frmReturn.InvType = int.Parse(InvType);
                        frmReturn.ShowDialog();
                        break;
                    case "4":
                        InvoicePurchaseReorderAdd frmPReturn = new InvoicePurchaseReorderAdd();
                        frmPReturn.EditFlag = true;
                        frmPReturn.InvId = long.Parse(InvId);
                        frmPReturn.InvType = int.Parse(InvType);
                        frmPReturn.ShowDialog();
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
                if (txtCode.Text != "")
                {
                    Search(true);
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Search(true);
        }

        private void enterDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = enterDateDateTimePicker.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dateTimePicker1.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            txtPayFromDate.Text = ddlPayFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void ddlPayToDate_ValueChanged(object sender, EventArgs e)
        {
            txtPayToDate.Text = ddlPayToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

     
              

            
    }
}