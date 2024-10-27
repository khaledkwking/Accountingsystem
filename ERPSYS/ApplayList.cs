using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class ApplayList : Form
    {
        public int iunitId;
        public String strUnitDesc;

        public ApplayList()
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
            cDEUNITTYPESBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
                    

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
           

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            cDEUNITTYPESBindingSource.AddNew();
            SaveCmd.Text = "Õ›Ÿ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;

        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            //if(UnitsDGView.SelectedRows.Count >0)
            //{
            //    iunitId = int.Parse(UnitsDGView.SelectedRows[0].Cells["UNITId"].Value.ToString());
            //    strUnitDesc = UnitsDGView.SelectedRows[0].Cells["UNITDESC"].Value.ToString();
               

            //}
            SaveCmd.Text = " ⁄œÌ·";
            CmdAdd.Enabled = true ;
            DelCmd.Enabled = true;
            cDEUNITTYPESBindingSource.CancelEdit();
           
        }

       

       

            
    }
}