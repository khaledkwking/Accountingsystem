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
    public partial class VactionTypesList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;

        public VactionTypesList()
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
            cDEPERVACSUBCLASSBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
          
                    

        }
   

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            cDEPERVACSUBCLASSBindingSource.AddNew();
            SaveCmd.Text = "Õ›Ÿ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;
            pERIOD_FLAGCheckBox.Checked = false;
            dEC_FLAGCheckBox.Checked = false;
            txDesc.Focus();


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
            //cDEPERVACSUBCLASSBindingSource.CancelEdit();
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {
                   
                    if (GLibrary.ValidatetxtBox(errorProvider1, txDesc, "√œŒ· «”„ «·ÊÕœ…", "«·ÊÕœ« ", true))
                    {
                   
                            this.Validate();
                            cDEPERVACSUBCLASSBindingSource.EndEdit();
                            cDE_PER_VAC_SUB_CLASSTableAdapter.Update(personalDataSet.CDE_PER_VAC_SUB_CLASS);

                            GLibrary.MsgSave();
                            CmdAdd.Enabled = true;
                         
                            DelCmd.Enabled = true;
                            SaveCmd.Text = " ⁄œÌ·";
                       }
                            
                    
                       
                }
                 
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·ÊÕœ« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void DelCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if (GLibrary.MsgCheckDel())
                {

                    if (UnitsDGView.SelectedRows .Count >0)
                    {

                        cDEPERVACSUBCLASSBindingSource.RemoveCurrent();
                        cDEPERVACSUBCLASSBindingSource.EndEdit();
                        int I = cDE_PER_VAC_SUB_CLASSTableAdapter.Update(personalDataSet.CDE_PER_VAC_SUB_CLASS);
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·«Ã«“« ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDEPERVACSUBCLASSBindingSource.CancelEdit();
            }
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

            
    }
}