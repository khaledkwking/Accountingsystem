using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace ERPSYS
{
    public partial class EmpAdd : Form
    {
       
        public decimal LastIden = -1;
        private StaticList slGenderTypes = new StaticList(GLibrary.strarrGenderTypes);
        private StaticList slMalStatusType = new StaticList(GLibrary.strarrMalStatusType);        
        public Boolean  EditFlag=false ;
        private DateTime lastDataError = DateTime.MinValue;
        private VacationAdd frmVacationAdd = new VacationAdd();
        private DiscountAdd frmDiscountAdd = new DiscountAdd();
        private AbsenceAdd frmAbsenceAdd = new AbsenceAdd();
        private LoanAdd frmLoanAdd = new LoanAdd();
        public EmpAdd()
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


            //if (!EditFlag)
           // {
               // AddNewEmp();
            //}
        }
      
        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveData();                       
            
        }
        public void SaveData()
        {
            this.Validate();
            pEREMPLOYEEDATABindingSource.EndEdit();
            pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);

            GLibrary.MsgSave();
            EditFlag = true;
        }
        public Boolean CheckCust(int AccountId)
        {
            FillData();
            pEREMPLOYEEDATABindingSource.Filter = "AccountID = " + AccountId.ToString();
            if (pEREMPLOYEEDATABindingSource.List.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewEmp();
                  
            
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
       
       
        public void AddNewEmp()
        {
            LastIden = (decimal)pER_EMPLOYEE_DATATableAdapter.GetEmpIdenty();
            txtEmpCode.Text = nEWERPDataSet.SetupCodes.Rows[0]["EmpCode"].ToString() + LastIden.ToString("000000");
            pEREMPLOYEEDATABindingSource.AddNew();
            CmbEmpGender.SelectedIndex = 0;
            CmbEmpGender.Select();
            CmbEmpMatStatus.SelectedIndex = 0;
            CmbEmpMatStatus.Select();

            //if (CmbEmpNat.Items.Count > 0)
            //{
            //    CmbEmpNat.SelectedIndex  = 0;
            //    CmbEmpNat.Select();
            //}
            //if (CmbEmpGov.Items.Count > 0)
            //{
            //    CmbEmpGov.SelectedIndex  =0;
            //    CmbEmpGov.Select();
            //}
            //if (CmbEmpDept.Items.Count > 0)
            //{
            //    CmbEmpDept.SelectedIndex = 0;
            //    CmbEmpDept.Select();
            //}
            EditFlag = false;
            
            
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

        private void AddAbsCmd_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                frmAbsenceAdd.EditFlag = false;
                frmAbsenceAdd.Show();
            }
            else
            {
                MessageBox.Show(Messages.EmpSaveMesg, "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }
 

        }

        private void EditAbsCmd_Click(object sender, EventArgs e)
        {
            frmAbsenceAdd.EditFlag = true;
            frmAbsenceAdd.EmpCode = decimal.Parse(txtEmpCode.Text );
            frmAbsenceAdd.Show();
        }

        private void AddLoanCmd_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                frmLoanAdd.EditFlag = false;
                frmLoanAdd.Show();
            }
            else
            {
                MessageBox.Show(Messages.EmpSaveMesg, "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }
        }

        private void EditLoanCmd_Click(object sender, EventArgs e)
        {
            frmLoanAdd.EditFlag = true;
            frmLoanAdd.EmpCode = decimal.Parse(txtEmpCode.Text); ;
            frmLoanAdd.Show();
        }

        private void AddVacCmd_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {

                frmVacationAdd.EditFlag = false;
                frmVacationAdd.Show();
            }
            else
            {
                MessageBox.Show(Messages.EmpSaveMesg, "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }
        }

        private void EditVacCmd_Click(object sender, EventArgs e)
        {
            frmVacationAdd.EditFlag = true;
            //frmVacationAdd.EmpCode = long.Parse(txtEmpCode.Text); ;
            frmVacationAdd.Show();
        }

        private void AddDisCmd_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                frmDiscountAdd.EditFlag = false;
                frmDiscountAdd.Show();
            }
            else
            {
                MessageBox.Show(Messages.EmpSaveMesg, "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        
            }
        }

        private void EditDisCmd_Click(object sender, EventArgs e)
        {
            frmDiscountAdd.EditFlag = true;
            frmDiscountAdd.EmpCode = decimal.Parse(txtEmpCode.Text); ;
            frmDiscountAdd.Show();
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

        private void label21_Click(object sender, EventArgs e)
        {

        }

    

    }
 
}