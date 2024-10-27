using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class EmpSalesAdd : DockContent
    {

        private Boolean EditFlag = true;
        private int LastIden = -1;
        private Boolean flag = false;

        private StaticList slGenderTypes = new StaticList(GLibrary.strarrGenderTypes);
        private StaticList slMalStatusType = new StaticList(GLibrary.strarrMalStatusType);        
        private DateTime lastDataError = DateTime.MinValue;
        private VacationAdd frmVacationAdd = new VacationAdd();
        private DiscountAdd frmDiscountAdd = new DiscountAdd();
        private AbsenceAdd frmAbsenceAdd = new AbsenceAdd();
        private LoanAdd frmLoanAdd = new LoanAdd();
        public EmpSalesAdd()
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
            //invProductsBindingSource.CancelEdit();
            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            FillData();

        }
        private void FillData()
        {
           
            this.cDE_MONTHSTableAdapter.Fill(this.personalDataSet.CDE_MONTHS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_GOVERNORATE' table. You can move, or remove it, as needed.
            this.cDE_GOVERNORATETableAdapter.Fill(this.personalDataSet.CDE_GOVERNORATE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PER_EMP_DATA' table. You can move, or remove it, as needed.
            
            CmbEmpGender.DataSource = slGenderTypes.ToDataTable();
            CmbEmpMatStatus.DataSource = slMalStatusType.ToDataTable();
            pEREMPLOYEEDATABindingSource.Filter = "SalesAdminFalg=true";
           
            //if (!EditFlag)
           // {
               // AddNewEmp();
            //}
            if (pEREMPLOYEEDATABindingSource.Count == 0)
            {
                groupBox3.Enabled = false;
            }
        }
            
      
        private void CmdDel_Click(object sender, EventArgs e)
        {
            
                if (GLibrary.MsgCheckDel())
                {
                    
                     //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                    pEREMPLOYEEDATABindingSource.RemoveCurrent();
                    pEREMPLOYEEDATABindingSource.EndEdit();
                    pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
                
                 }
            
        }

    
        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {          
               
            }
        }
       
                   
           
        private void pEREMPLOYEEDATABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {

                if (pEREMPLOYEEDATABindingSource.Count == 1 && ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString() == "0")
                {
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"] = (Int64)(LastIden) + 1;
                }
              
            }
        }

        private void EmpPicBox_Click(object sender, EventArgs e)
        {

        }

        private void salesAdminFalgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (salesAdminFalgCheckBox.Checked)
            {
                txtcom.Enabled = true;
            }
            else
            {
                txtcom.Enabled =false ;
            }
        }

        private void CmdCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdAdd_Click_1(object sender, EventArgs e)
        {
            //LastIden = (int)bRANCHESTableAdapter.GetBranchLastIdent();
            flag = false;
            pEREMPLOYEEDATABindingSource.AddNew();
            flag = true;
            //txtEmpCode.Text = (LastIden + 1).ToString();
            if (CmbEmpGender.Items.Count > 0)
            {
                CmbEmpGender.SelectedIndex = 0;
            }
            if (CmbEmpMatStatus.Items.Count > 0)
            {
                CmbEmpMatStatus.SelectedIndex = 0;
            }
            if (CmbEmpGov.Items.Count > 0)
            {
                CmbEmpGov.SelectedIndex = 0;
            }
            if (CmbEmpNat.Items.Count > 0)
            {
                CmbEmpNat.SelectedIndex = 0;
            }

            if (CmbEmpDept.Items.Count > 0)
            {
                CmbEmpDept.SelectedIndex = 0;
            }
          
            salesAdminFalgCheckBox.Checked = true;
            salesAdminFalgCheckBox.CheckState = CheckState.Checked;
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            CmdSave.Text = "Õ›Ÿ";
            groupBox3.Enabled = true ;
        }

        private void CmdDel_Click_1(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {
                if (GLibrary.MsgCheckDel())
                {
                    //int index = BranchesDGView.SelectedRows[0].Index;
                    //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                    pEREMPLOYEEDATABindingSource.RemoveCurrent();
                    pEREMPLOYEEDATABindingSource.EndEdit();
                    pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
                    //if (personalDataSet.PER_EMPLOYEE_DATA.Rows.Count > 0)
                    //{
                    //    BranchesDGView.Rows[bRANCHESBindingSource.Position].Selected = true;
                    //}
                    //StoresDGView.Refresh();


                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GLibrary.ValidatetxtBox(errorProvider1, txtEmpCode, "√œŒ· «·ﬂÊœ ", "«·„Œ«“‰", true))
                {
                    return;
                }
                else if (!GLibrary.ValidatetxtBox(errorProvider1, txtEmpName, "√œŒ· √”„ «·„‰œÊ» ", "«·„Œ«“‰", true))
                {
                    return;
                }
                this.Validate();
                pEREMPLOYEEDATABindingSource.EndEdit();
                int pos = pEREMPLOYEEDATABindingSource.Position;
                
                pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);

                GLibrary.MsgSave();
                //BranchesDGView.Refresh();
                EditFlag = true;
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                CmdSave.Text = " ⁄œÌ·";
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·„Œ«“‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

    

    }
 
}