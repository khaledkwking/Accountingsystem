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
    public partial class EmpList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;

        public EmpList()
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
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
                    // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            txtCode.Focus();
                    

        }
                
       

       
        private void DelCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if (GLibrary.MsgCheckDel())
                {

                    if (UnitsDGView.SelectedRows .Count >0)
                    {

                        pEREMPLOYEEDATABindingSource.RemoveCurrent();
                        pEREMPLOYEEDATABindingSource.EndEdit();
                        int I = pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA );
                          
                    }
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáÇÌÇÒÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pEREMPLOYEEDATABindingSource.CancelEdit();
            }
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();

        }

        private void UnitsDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UnitsDGView.SelectedRows.Count > 0)
            {
                string EmpCode = UnitsDGView.SelectedRows[0].Cells["EMP_CODE"].Value.ToString();
                EMP_DATA_Add frm = new EMP_DATA_Add();
                frm.EmpCode = long.Parse (EmpCode);
                frm.EditFlag = true;
                frm.ShowDialog();

            }

        }
        private void Search()
        {
            Nullable<long> Empcode = null;

            string FName = null;
            string SName = null;
            string TName = null;
            string FoName = null;
            if (txtCode.Text != "")
            {
                Empcode = long.Parse(txtCode.Text);
            }
            if (txtFname.Text != "")
            {
                FName = txtFname.Text;
            }


            if (txtSName.Text != "")
            {
                SName = txtSName.Text;
            }

            if (txtTName.Text != "")
            {
                TName = txtTName.Text;
            }

            if (txtFoName.Text != "")
            {
                FoName = txtFoName.Text;
            }

            pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, Empcode, FName, SName, TName, FoName);
        }
        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void txtFname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSName.Focus();
            }
        }

        private void txtSName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTName.Focus();
            }
        }

        private void txtTName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFoName.Focus();
            }

        }

        private void txtFoName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch.Focus();
            }
        }
            
    }
}