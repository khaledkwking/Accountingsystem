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
    public partial class CustSupList : DockContent
    {
        public int iCustSupId;
        public String strCustName;
        public String strCustCode;
        public string SUPCUSTTYPE;
        public CustSupList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.AccountingView' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

            sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_TYPE = " + Messages.CustSupFlag + " Or SUP_CUST_TYPE = " + SUPCUSTTYPE;  
           

        }

        private void CustSupList_Activated(object sender, EventArgs e)
        {
           
        }

        private void CustSupDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //CustSupDGView.Rows[e.RowIndex].HeaderCell.Value = (CustSupDGView.RowCount).ToString();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            EditCustSup();
        }
        private void EditCustSup()
        {
            if (CustSupDGView.SelectedRows.Count > 0)
            {

                iCustSupId = int.Parse(CustSupDGView.SelectedRows[0].Cells["SUP_CUST_ID"].Value.ToString());
                CustSupEdit frm = new CustSupEdit();
                frm.iCustSupId = iCustSupId;
                if (SUPCUSTTYPE!="")
                {
                    frm.CustSupType = int.Parse (SUPCUSTTYPE);
                }
                frm.ShowDialog();

            }
        }

        private void CustSupDGView_DoubleClick(object sender, EventArgs e)
        {
            EditCustSup();
        }

        private void CustSupDGView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CustSupDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //CustSupDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex+1).ToString();
            if (CustSupDGView.Rows.Count > 0)
            {
                switch (e.ColumnIndex)
                {
                    case 2:
                        if ((CustSupDGView.Rows[e.RowIndex].Cells["accountid"].Value) != DBNull.Value && (CustSupDGView.Rows[e.RowIndex].Cells["CREDITLIMIT"].Value) != DBNull.Value)
                        {
                            long curAccountId = long.Parse(CustSupDGView.Rows[e.RowIndex].Cells["accountid"].Value.ToString());
                            if (curAccountId > 0)
                            {
                                this.accountingViewTableAdapter.FillBy(nEWERPDataSet.AccountingView, curAccountId, null, null, null, null, null,null);
                                if (accountingViewBindingSource.Count > 0)
                                {
                                    decimal THRESHOLDQTY = decimal.Parse(CustSupDGView.Rows[e.RowIndex].Cells["CREDITLIMIT"].Value.ToString());
                                    decimal Credit = decimal.Parse(((DataRowView)accountingViewBindingSource[0])["Total"].ToString());
                                    if (Credit < 0)
                                    {
                                        Credit = Credit * -1;
                                        if (Credit >= THRESHOLDQTY)
                                        {
                                            CustSupDGView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Pink;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void txtCustSupCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void Search()
        {
            string FilterStr="";
            if (txtCustSupCode.Text !="")
            {
                FilterStr="SUP_CUST_CODE='"+txtCustSupCode.Text+"'";
            }
            if (txCustSupName.Text !="" && txtCustSupCode.Text !="")
            {
                FilterStr=" And SUP_CUST_FNAME like '" +txCustSupName.Text +"'%";
            }
            else if (txCustSupName.Text !="" && txtCustSupCode.Text =="")
            {
                FilterStr = "SUP_CUST_FNAME like '" + txCustSupName.Text + "%'";
            }
            sUPPLIERSCUSTOMERSBindingSource.Filter = FilterStr;
        }

        private void txCustSupName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                //invoicesBindingSource.ResetAllowNew();//.CancelEdit();
                sUPPLIERSCUSTOMERSBindingSource.RemoveCurrent();
                //invoicesBindingSource.EndEdit ();
                //((DataRowView)invoicesBindingSource.Current).EndEdit();
                int i = sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS);
                //if (qidsBindingSource.Count == 0)
                //{
                //    //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
                //    //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                //    //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                //    CmdDel.Enabled = false;
                //    CmdSave.Enabled = false;
                //    BtnPrint.Enabled = false;


                //}


            }
        }
            
    }
}