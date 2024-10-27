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
    public partial class NatList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;
        public Boolean EditFlag = true;
        public Boolean flag = false ;
        public NatList()
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
            cDENATIONALITYBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            flag = false;
       
            flag = true;

        }

      
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            flag = false;
            cDENATIONALITYBindingSource.AddNew();
            SaveCmd.Text = "Õ›Ÿ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;
            EditFlag = false;
            flag = true ;
            txtdesc.Focus();

        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            //if(UnitsDGView.SelectedRows.Count >0)
            //{
            //    iunitId = int.Parse(UnitsDGView.SelectedRows[0].Cells["UNITId"].Value.ToString());
            //    strUnitDesc = UnitsDGView.SelectedRows[0].Cells["UNITDESC"].Value.ToString();
               

            //}

            if (cDENATIONALITYBindingSource.Count > 0 && flag)
            {
                cDENATIONALITYBindingSource.CancelEdit();
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

                    if (GLibrary.ValidatetxtBox(errorProvider1, txtdesc, "√œŒ· «”„ «·Ã‰”Ì…", "«·Ã‰”Ì« ", true))
                    {
                   
                            this.Validate();
                            cDENATIONALITYBindingSource.EndEdit();
                            cDE_NATIONALITYTableAdapter.Update(personalDataSet.CDE_NATIONALITY );

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

                        cDENATIONALITYBindingSource.RemoveCurrent();
                        cDENATIONALITYBindingSource.EndEdit();
                        int I = cDE_NATIONALITYTableAdapter.Update(personalDataSet.CDE_NATIONALITY );
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·«ﬁ”«„", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDENATIONALITYBindingSource.CancelEdit();
            }
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

            
    }
}