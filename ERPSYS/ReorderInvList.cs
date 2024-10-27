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
    public partial class ReorderInvList : DockContent
    {
       
        private Nullable<long> ReorderId = null;
        private Nullable<DateTime> ToDate = null;
        private Nullable<DateTime> FromDate = null;
        public Boolean EditFlag = false;
        public int LInvType;

        private StaticList slInvType = new StaticList(GLibrary.strarrInvType);

        public ReorderInvList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvoiceReoders' table. You can move, or remove it, as needed.
            //this.invoiceReodersTableAdapter.Fill(this.nEWERPDataSet.InvoiceReoders);
      
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.

            txtFromDate.Text = new DateTime(DateTime.Today.Year, 1, 1).ToShortDateString();
            txtToDate.Text = DateTime.Today.ToShortDateString();
            Search();
           

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

        private void Search()
        {

            ReorderId = null;
            ToDate = null;
            FromDate = null;
            if (GLibrary .IsNumeric ( txtCode.Text))
            {
                ReorderId = long.Parse(txtCode.Text); 
                
            }
            if (txtFromDate.Text  != "")
            {
                //string FromDate = DateTime.Parse(txtFromDate.Text + " 23:59").ToString();
                FromDate = DateTime.Parse(txtFromDate.Text); 
            }
            if (txtToDate.Text  != "")
            {
              
                ToDate = DateTime.Parse(txtToDate.Text + " 23:59"); 
               
            }
            invoiceReodersTableAdapter.FillByDate(this.nEWERPDataSet.InvoiceReoders, ReorderId, FromDate, ToDate);
           
        }

    

       
        private void StoresDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string ReorderId = StoresDGView.SelectedRows[0].Cells["curReorderId"].Value.ToString();
        
              
                        ReoderInvoicesAdd frm = new ReoderInvoicesAdd();
                        frm.EditFlag = true;
                        frm.ReorderId = long.Parse(ReorderId);
                    
                        frm.ShowDialog();
                       
                    
                }
            
            
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    Search();
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void enterDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = enterDateDateTimePicker.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dateTimePicker1.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

     
              

            
    }
}