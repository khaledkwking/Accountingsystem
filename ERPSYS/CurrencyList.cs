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
    public partial class CurrencyList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;

        public CurrencyList()
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
            cDECurrencyBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_Currency' table. You can move, or remove it, as needed.
            this.cDE_CurrencyTableAdapter.Fill(this.nEWERPDataSet.CDE_Currency);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_Currency' table. You can move, or remove it, as needed.
            this.cDE_CurrencyTableAdapter.Fill(this.nEWERPDataSet.CDE_Currency);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
       
                    

        }

      
        private void CmdAdd_Click(object sender, EventArgs e)
        {

            cDECurrencyBindingSource.AddNew();
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
           
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, dEPT_DESCTextBox, "√œŒ· «”„ «·ÊÕœ…", "«·ÊÕœ« ", true))
                    {
                   
                            this.Validate();
                            cDECurrencyBindingSource.EndEdit();

                            cDE_CurrencyTableAdapter.Update(nEWERPDataSet.CDE_Currency );

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

                        cDECurrencyBindingSource.RemoveCurrent();
                        cDECurrencyBindingSource.EndEdit();
                        int I = cDE_CurrencyTableAdapter.Update(nEWERPDataSet.CDE_Currency);
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·⁄„·« ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cDECurrencyBindingSource.CancelEdit();
            }
        }

            
    }
}