using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class stroesList : Form
    {
        public int iStoreId;
        public String strStoreName;
        public String strStoreCode;
        public stroesList()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
           

        }

                  

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;   
        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            if(StoresDGView.SelectedRows.Count >0)
            {
                iStoreId=int.Parse (StoresDGView.SelectedRows[0].Cells ["StoreId"].Value.ToString ());
                strStoreName=StoresDGView.SelectedRows[0].Cells ["StoreName"].Value.ToString ();
                strStoreCode = StoresDGView.SelectedRows[0].Cells["StoreCode"].Value.ToString();

            }
           
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                if (GLibrary.MsgCheckDel())
                {
                    int index = StoresDGView.SelectedRows[0].Index;
                    //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                    sTORESBindingSource.RemoveCurrent();
                    sTORESBindingSource.EndEdit();
                    sTORESTableAdapter.Update(nEWERPDataSet.STORES);
                    if (nEWERPDataSet.STORES.Rows.Count > 0)
                    {
                        StoresDGView.Rows[sTORESBindingSource.Position].Selected = true;
                    }
                    //StoresDGView.Refresh();


                }
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

            
    }
}