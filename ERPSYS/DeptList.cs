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
    public partial class DeptList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;
        public Boolean EditFlag = true;
        public Boolean flag = false ;
        public DeptList()
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
            cDEDEPTBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            flag = false;
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.

            flag = true;

        }

      
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            flag = false;
            cDEDEPTBindingSource.AddNew();
            SaveCmd.Text = "Õ›Ÿ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;
            EditFlag = false;
            flag = true ;
            dEPT_DESCTextBox.Focus();

        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            //if(UnitsDGView.SelectedRows.Count >0)
            //{
            //    iunitId = int.Parse(UnitsDGView.SelectedRows[0].Cells["UNITId"].Value.ToString());
            //    strUnitDesc = UnitsDGView.SelectedRows[0].Cells["UNITDESC"].Value.ToString();
               

            //}

            if (cDEDEPTBindingSource.Count > 0 && flag)
            {
                cDEDEPTBindingSource.CancelEdit();
                UnitsDGView.CancelEdit();
                SaveCmd.Text = " ⁄œÌ·";
                CmdAdd.Enabled = true;
                DelCmd.Enabled = true;
                EditFlag = true;
            }
           
           
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, dEPT_DESCTextBox, "√œŒ· «”„ «·ﬁ”„", "«·«ﬁ”«„", true))
                    {
                   
                            this.Validate();
                            cDEDEPTBindingSource.EndEdit();
                            cDE_DEPTTableAdapter.Update(personalDataSet.CDE_DEPT);

                            GLibrary.MsgSave();
                            CmdAdd.Enabled = true;
                            EditFlag = true;
                            flag = true ;
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

                        cDEDEPTBindingSource.RemoveCurrent();
                        cDEDEPTBindingSource.EndEdit();
                        int I = cDE_DEPTTableAdapter.Update(personalDataSet.CDE_DEPT);
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·«ﬁ”«„", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDEDEPTBindingSource.CancelEdit();
            }
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

            
    }
}