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
    public partial class InstallmentSelect : DockContent
    {
        public Boolean EditFlag = false;

        private Nullable<int> CustAccId = null;
        private Nullable<int> CollectorAccId = null;
        private Nullable<DateTime> ToDate = null;
        private Nullable<DateTime> FromDate = null;
        private Nullable<bool> bPayFlag = null;
        private Nullable<bool> bRequiredFlag = null;
        public int QidLastIden = -1;
       
      
        private StaticList slPaymentTypes = new StaticList(GLibrary.strarrPaymentTypes);
        public InstallmentSelect()
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
            installmentDistributionBindingSource.CancelEdit();
            installmentBindingSource.CancelEdit();
            Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
          
           // this.installmentTableAdapter.Fill(this.nEWERPDataSet.Installment);
            //// TODO: This line of code loads data into the 'nEWERPDataSet.Installment_Distribution' table. You can move, or remove it, as needed.
            this.installment_DistributionTableAdapter.Fill(this.nEWERPDataSet.Installment_Distribution);

            accountingBindingSource.Filter = "Mainnode=" + Boolean.FalseString;
            accountingBindingSource1.Filter = "Mainnode=" + Boolean.FalseString;
            cmbCustaccId.SelectedValue = -1;
            CmbCollectorAccid.SelectedValue = -1;
            radioBtnAll.Checked = true;
            search();
            
        }



        private void search()
        {
            nEWERPDataSet.Installment_Distribution.Rows.Clear();
            CustAccId = null;
            CollectorAccId = null;
            ToDate = null;
            FromDate = null;
            bPayFlag = null;
            bRequiredFlag = null;

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
            if (cmbCustaccId.SelectedValue != null && cmbCustaccId.Text != "")
            {
                CustAccId = int.Parse(cmbCustaccId.SelectedValue.ToString());
            }
            else
            {
                CustAccId = null;
            }

            if (CmbCollectorAccid.SelectedValue != null && CmbCollectorAccid.Text != "")
            {
                CollectorAccId = int.Parse(CmbCollectorAccid.SelectedValue.ToString());
            }
            else
            {
                CollectorAccId = null;
            }

            if (radioBtnReqired.Checked)
            {
                bRequiredFlag = true;
            }
            else
            {
                bRequiredFlag = null;
            }
            if (radioBtnPayment.Checked)
            {
                bPayFlag = true;
            }
            else
            {
                bPayFlag = null;
            }
            //installmentDistributionBindingSource.Filter = "PayFlag = false and CustAccid =" + CustAccId.ToString() + " AND (CollectorAccid= " + CollectorAccId.ToString() + " AND (DistDate <='" + PayDate.ToString ()+"'";
           installment_DistributionTableAdapter.FillByAll (nEWERPDataSet.Installment_Distribution, CustAccId, CollectorAccId, FromDate,ToDate ,bPayFlag ,bRequiredFlag );
        }

       

        private void dtPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtPaymentDate.Value.ToShortDateString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ShowReport frm = new ShowReport();

            search();
            if (txtFromDate.Text != "")
            {
                frm.FromDate = DateTime.Parse(txtFromDate.Text);
            }
            else
            {
                frm.FromDate = new DateTime(DateTime.Today.Year, 1, 1);
            }
            if (txtToDate.Text != "")
            {
                frm.ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
            }
            else
            {
                frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
            }
            frm.choiceNum = 3;
            frm.nEWERPDataSet = nEWERPDataSet;
        
            frm.ShowDialog(this);
        }

       

    
      
       
        
    }
}