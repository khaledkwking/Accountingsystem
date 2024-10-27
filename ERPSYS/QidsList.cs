using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class QidsList : DockContent
    {

     
        //private Nullable<long> CustSupId = null;
        //private Nullable<long> StoreId = null;
        private Nullable<DateTime> ToDate = null;
        private Nullable<DateTime> FromDate = null;
        //private Nullable<long> ProductId = null;

         public string Tilte="";
        public int choiceNum;
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private StaticList slQidTypes = new StaticList(GLibrary.strarrQidTypes);

        public QidsList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    
            // TODO: This line of code loads data into the 'nEWERPDataSet.AccountingView' table. You can move, or remove it, as needed.
            this.Text = this.Text + Tilte;
            txtFromDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
            txtToDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");  
            Qidtypes.DataSource = slQidTypes.ToDataTable();
                
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
              
        }
        private void Search()
        {
           
            //CustSupId = null;
            ToDate = null;
            FromDate = null;
            //ProductId = null;
            //StoreId = null;
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
                    if (txtToDate.Text != "")
                    {
                        ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
                    }
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
            //if (cmbBranch.SelectedValue != null && cmbBranch.Text != "")
            //{
            //    BranchId = long.Parse(cmbBranch.SelectedValue.ToString());
            //}
            qidsBindingSource.Filter = "qidDate >='" + FromDate.ToString() + "'" + " and qidDate<='" + ToDate.ToString() + "'";
            if (Qidtypes.SelectedValue != null)
            {
                qidsBindingSource.Filter = qidsBindingSource.Filter + " and recitetype=" + Qidtypes.SelectedValue.ToString();
            }
           
        }
             

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Search();
           // ShowQidsRpt frm=new ShowQidsRpt ();

           // frm.ToDate = txtToDate.Text;
           // frm.FromDate = txtFromDate.Text;
           // frm.choiceNum=choiceNum;

           // frm.nEWERPDataSet = nEWERPDataSet;
           // frm.Tilte=Tilte;
                     
           //frm.ShowDialog(this);
           
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void StockDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

      

       

      

      

      

      
      

     
      

       

       

        
    }
}