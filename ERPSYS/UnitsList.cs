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
    public partial class UnitsList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;
     
        public UnitsList()
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
            SaveCmd.Text = "ÍÝÙ";         
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
            SaveCmd.Text = "ÊÚÏíá";
            CmdAdd.Enabled = true ;
            DelCmd.Enabled = true;
            //cDEUNITTYPESBindingSource.CancelEdit();
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {
                   
                    if (GLibrary.ValidatetxtBox(errorProvider1, txUintDesc, "ÃÏÎá ÇÓã ÇáæÍÏÉ", "ÇáæÍÏÇÊ", true))
                    {
                   
                            this.Validate();
                            cDEUNITTYPESBindingSource.EndEdit();
                         
                            cDE_UNIT_TYPESTableAdapter.Update(nEWERPDataSet.CDE_UNIT_TYPES );

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

                        cDEUNITTYPESBindingSource.RemoveCurrent();
                        cDEUNITTYPESBindingSource.EndEdit();
                        int I = cDE_UNIT_TYPESTableAdapter.Update(nEWERPDataSet.CDE_UNIT_TYPES);
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáæÍÏÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDEUNITTYPESBindingSource.CancelEdit();
            }
        }

            
    }
}