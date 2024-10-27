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
    public partial class PENALTYList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;

        public PENALTYList()
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
            cDEPERPENALTYBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
         

        }

       
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            cDEPERPENALTYBindingSource.AddNew();
            SaveCmd.Text = "ÍÝÙ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;
            txDesc.Focus();

        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            //if(UnitsDGView.SelectedRows.Count >0)
            //{
            //    iunitId = int.Parse(UnitsDGView.SelectedRows[0].Cells["UNITId"].Value.ToString());
            //    strUnitDesc = UnitsDGView.SelectedRows[0].Cells["UNITDESC"].Value.ToString();
               

            //}
            SaveCmd.Text = "ÊÚÏíá";
            CmdAdd.Enabled = true ;
            DelCmd.Enabled = true;
           // cDEPERPENALTYBindingSource.CancelEdit();
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {
                   
                    if (GLibrary.ValidatetxtBox(errorProvider1, txDesc, "ÃÏÎá ÇÓã ÇáæÍÏÉ", "ÇáæÍÏÇÊ", true))
                    {
                   
                            this.Validate();
                            cDEPERPENALTYBindingSource.EndEdit();

                            cDE_PER_PENALTYTableAdapter.Update(personalDataSet.CDE_PER_PENALTY);

                            GLibrary.MsgSave();
                            CmdAdd.Enabled = true;
                         
                            DelCmd.Enabled = true;
                            SaveCmd.Text = "ÊÚÏíá";
                       }
                            
                    
                       
                }
                 
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáæÍÏÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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

                        cDEPERPENALTYBindingSource.RemoveCurrent();
                        cDEPERPENALTYBindingSource.EndEdit();
                        int I = cDE_PER_PENALTYTableAdapter.Update(personalDataSet.CDE_PER_PENALTY);
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáæÍÏÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDEPERPENALTYBindingSource.CancelEdit();
            }
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

            
    }
}