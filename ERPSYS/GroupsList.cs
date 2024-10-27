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
    public partial class GroupsList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;
        private StaticList slAttendanceType = new StaticList(GLibrary.strarrAttendanceType);
        private StaticList slCalSalaryType = new StaticList(GLibrary.strarrCalSalaryType);

        public GroupsList()
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
            empGroupsBindingSource.CancelEdit();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'personalDataSet.Emp_Groups' table. You can move, or remove it, as needed.
            this.emp_GroupsTableAdapter.Fill(this.personalDataSet.Emp_Groups);

            salaryCulComboBox.DataSource = slCalSalaryType.ToDataTable();
            nutalAttendanceComboBox.DataSource = slAttendanceType.ToDataTable();

        }

       
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            empGroupsBindingSource.AddNew();
            SaveCmd.Text = "Õ›Ÿ";         
            CmdAdd.Enabled = false;
            DelCmd.Enabled = false;
            txtGroupName.Focus();

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
           // cDEPERPENALTYBindingSource.CancelEdit();
           
        }

        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {
                   
                    if (GLibrary.ValidatetxtBox(errorProvider1, txtGroupName, "√œŒ· «”„ «·ÊÕœ…", "«·ÊÕœ« ", true))
                    {
                   
                            this.Validate();
                            empGroupsBindingSource.EndEdit();

                            emp_GroupsTableAdapter.Update(personalDataSet.Emp_Groups);

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

                   

                        empGroupsBindingSource.RemoveCurrent();
                        empGroupsBindingSource.EndEdit();
                        int I = emp_GroupsTableAdapter.Update(personalDataSet.Emp_Groups);
                          
                   
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·ÊÕœ« ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                empGroupsBindingSource.CancelEdit();
            }
        }

            
    }
}