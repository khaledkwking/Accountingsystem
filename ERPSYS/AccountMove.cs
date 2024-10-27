using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class AccountMove : Form
    {
     
        public long OldParentAccountId;
        public long AccountId;

        public AccountMove()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            accountingBindingSource.Filter = "MainNode=1";
            cmbAccount.SelectedValue = OldParentAccountId;

        }

                  

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (cmbAccount.SelectedValue != null)
            {
                NEWERPDataSet.accountingRow Row = nEWERPDataSet.accounting.FindByaccountid(AccountId);
                if (Row != null)
                {
                    Row.AccountparentId = int.Parse(cmbAccount.SelectedValue.ToString());
                    accountingTableAdapter.Update(Row);
                    MessageBox.Show(Messages.AccountMoveRightMesg, "«·Õ”«»« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            else
            {

            }
        }

      
   
            
    }
}