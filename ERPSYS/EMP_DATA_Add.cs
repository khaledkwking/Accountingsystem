using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WeifenLuo.WinFormsUI;
using ERPSYS.Reports;
namespace ERPSYS
{
    
    public partial class EMP_DATA_Add : DockContent
    {
        public Boolean  EditFlag =false ;
        
          
        public decimal LastIden = -1;
        private StaticList slGenderTypes = new StaticList(GLibrary.strarrGenderTypes);
        private StaticList slMalStatusType = new StaticList(GLibrary.strarrMalStatusType);
        private StaticList slReligionType= new StaticList(GLibrary.strarrReligionTypes);
        private StaticList slLicenseTypes = new StaticList(GLibrary.strarrLicenseTypes);
        private StaticList slContractType = new StaticList(GLibrary.strarrContractType);
        private StaticList slStatusType = new StaticList(GLibrary.strarrStatusType);
        
        public Boolean EditFlagABS = false;
        public Boolean EditFlagVAC= false;
        public Boolean EditFlagLoan = false;
        public Boolean EditFlagDisc = false;
        public Boolean EditFlagALL = false;
        public Boolean EditFlagRel = false;
        private Boolean Flag = false;
        private DateTime lastDataError = DateTime.MinValue;
        public long EmpCode;

        public EMP_DATA_Add()
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
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_RELATIVE' table. You can move, or remove it, as needed.
           
            Flag = false;
            CmbEmpGender.DataSource = slGenderTypes.ToDataTable();
            CmbEmpMatStatus.DataSource = slMalStatusType.ToDataTable();
            cmbReigion.DataSource = slReligionType.ToDataTable();
            CmbLicenseType.DataSource = slLicenseTypes.ToDataTable();
            CmbContractType.DataSource = slContractType.ToDataTable();
            CmbStatus.DataSource = slStatusType.ToDataTable();
            // TODO: This line of code loads data into the 'personalDataSet.CDE_BANKS' table. You can move, or remove it, as needed.
            this.cDE_BANKSTableAdapter.Fill(this.personalDataSet.CDE_BANKS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_LOCATION' table. You can move, or remove it, as needed.
            this.cDE_LOCATIONTableAdapter.Fill(this.personalDataSet.CDE_LOCATION);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_QLF' table. You can move, or remove it, as needed.
            this.cDE_PER_QLFTableAdapter.Fill(this.personalDataSet.CDE_PER_QLF);
            // TODO: This line of code loads data into the 'personalDataSet.Emp_Groups' table. You can move, or remove it, as needed.
            this.emp_GroupsTableAdapter.Fill(this.personalDataSet.Emp_Groups);
            Flag = false;
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_Allowance' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.
                    
            //this.pRL_EMP_LOAN_DETAILTableAdapter.Fill(this.personalDataSet.PRL_EMP_LOAN_DETAIL);
            //this.pER_EMP_AllowanceTableAdapter.Fill(this.personalDataSet.PER_EMP_Allowance);
            //this.pER_EMP_ABSENCETableAdapter.Fill(this.personalDataSet.PER_EMP_ABSENCE);
            //this.pER_EMP_VACATIONTableAdapter.Fill(this.personalDataSet.PER_EMP_VACATION);
            //this.pER_EMP_DISCOUNTTableAdapter.Fill(this.personalDataSet.PER_EMP_DISCOUNT);
             // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
      
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.
            this.cDE_MONTHSTableAdapter.Fill(this.personalDataSet.CDE_MONTHS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_GOVERNORATE' table. You can move, or remove it, as needed.
            this.cDE_GOVERNORATETableAdapter.Fill(this.personalDataSet.CDE_GOVERNORATE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.PER_EMP_DATA' table. You can move, or remove it, as needed.
            pRLEMPLOANDETAILBindingSource.Sort = "START_DATE DESC";
            pER_EMP_AllowanceBindingSource.Sort = "DISCOUNT_DATE DESC";
            pEREMPDISCOUNTBindingSource.Sort = "DISCOUNT_DATE DESC";
            pEREMPVACATIONBindingSource.Sort = "VAC_DATE_FRM DESC";
            pEREMPABSENCEBindingSource.Sort = "START_DATE DESC";

           

            if (EditFlag)
            {
                this.pER_EMPLOYEE_DATATableAdapter.FillByEmpCode (this.personalDataSet.PER_EMPLOYEE_DATA, EmpCode,null,null,null,null);
                //int pos = pEREMPLOYEEDATABindingSource.Find("EMP_CODE", EmpCode);
                //if (pos > -1)
                //{
                //    pEREMPLOYEEDATABindingSource.Position = pos;
                //}
                UpdateEmpVacBalance();

            }
            else
            {
                AddNewEmp();
            }
            Flag = true;


        }
        private void UpdateEmpVacBalance()
        {
            for (int i = 0; i < pEREMPLOYEEDATABindingSource.Count; i++)
            {
                decimal curVaccationDays = 0;
                decimal curVacEarned = 0;
                decimal curVacTaken = 0;
                DateTime CurHiredate = DateTime.Today;
                if (((DataRowView)pEREMPLOYEEDATABindingSource[i])["VaccationDays"] != DBNull.Value)
                {
                    curVaccationDays = decimal.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[i])["VaccationDays"].ToString());
                }
                if (((DataRowView)pEREMPLOYEEDATABindingSource[i])["EMP_HIREDATE"] != DBNull.Value)
                {
                    CurHiredate = DateTime.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[i])["EMP_HIREDATE"].ToString());
                }
                TimeSpan T = DateTime.Today.Subtract(CurHiredate);
                if (T.Days >= 0)
                {
                    curVacEarned = (curVaccationDays / Messages.DayInYear) * T.Days;
                }
                else
                {
                    curVacEarned = 0;
                }

                if (((DataRowView)pEREMPLOYEEDATABindingSource[i])["VacTaken"] != DBNull.Value)
                {
                    curVacTaken = decimal.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[i])["VacTaken"].ToString());
                }
                ((DataRowView)pEREMPLOYEEDATABindingSource[i])["VacEarned"] = decimal.Round(curVacEarned, 5);
                ((DataRowView)pEREMPLOYEEDATABindingSource[i])["VacBalance"] = decimal.Round(curVacEarned - curVacTaken, 5);


            }
            //pEREMPLOYEEDATABindingSource.EndEdit();
            //pER_EMPLOYEE_DATATableAdapter.Update(this.personalDataSet.PER_EMPLOYEE_DATA);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            pEREMPLOYEEDATABindingSource.EndEdit();
            int i= pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
            //invProductsBindingSource.EndEdit();
            //inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products );
            //GetQid();
            //qidsBindingSource.EndEdit();
            //qidsTableAdapter.Update(nEWERPDataSet.qids);
            //qidsDetailsBindingSource.EndEdit();
            //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails );

            //qidsDetailsBindingSourceWith.EndEdit();
            //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            GLibrary.MsgSave();
            //EditFlag = true;
            
            CmdAddABSENCE.Enabled = true ;
            CmdDelABSENCE.Enabled = true;    
                           
            
        }
 

        //private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        //{
        //    if (invoicesBindingSource.Count > 0)
        //    {

        //        if (invoicesBindingSource.Count == 1 && ((DataRowView)invoicesBindingSource.Current).IsNew)
        //        {
        //            ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

        //        }
        //        Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];

        //        invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
        //        qidsBindingSource.Filter = "InvId = " + InvId.ToString();
                
               
        //    }
        //}

        //private void invProductsBindingSource_PositionChanged(object sender, EventArgs e)
        //{
        //    if (invoicesBindingSource.Count > 0 && invProductsBindingSource.Count > 0)
        //    {

        //        ((DataRowView)invProductsBindingSource.Current)["InvId"] = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];


        //    }

        //}
        //private void AddNewRec()
        //{
        //    if (invoicesBindingSource.Count > 0 && invProductsBindingSource.Count > 0)
        //    {
        //        if (invoicesBindingSource.Count == 1 && ((DataRowView)invoicesBindingSource.Current)["InvId"].ToString() == "0")
        //        {

        //            ((DataRowView)invProductsBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);
        //        }
        //        else
        //        {
        //            ((DataRowView)invProductsBindingSource.Current)["InvId"] = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
        //        }

        //    }
        //}

        private void EnbDisbControls(Boolean EnProp)
        {
            
            if (EnProp)
            {


                if (!EmptabControl.TabPages.Contains(tabVac)) EmptabControl.TabPages.Add(tabVac);
                if (!EmptabControl.TabPages.Contains(tabAllow)) EmptabControl.TabPages.Add(tabAllow);
                if (!EmptabControl.TabPages.Contains(tabDisc)) EmptabControl.TabPages.Add(tabDisc);
                if (!EmptabControl.TabPages.Contains(tabAbsence)) EmptabControl.TabPages.Add(tabAbsence);
                if (!EmptabControl.TabPages.Contains(tabLoans)) EmptabControl.TabPages.Add(tabLoans);
                if (!EmptabControl.TabPages.Contains(tabFamily)) EmptabControl.TabPages.Add(tabFamily);
               
             
                 CmdAddABSENCE.Enabled =true ;
                CmdSaveABSENCE.Enabled =true ;
                CmdDelABSENCE.Enabled =true ;

                CmdAddLOAN.Enabled =true ;
                CmdSaveLOAN.Enabled =true ;
                CmMakeLOAN.Enabled =true ;
                CmdDelLOAN.Enabled =true ;


                CmdAddDiscount.Enabled =true ;
                CmdSaveDiscount.Enabled =true ;
                CmdDelDiscount.Enabled =true ;

                CmdAddALLOWNCE.Enabled =true ;
                CmdSAVEALLOWNCE.Enabled =true ;
                CmdDELALLOWNCE.Enabled =true ;

                CmdAddVAC.Enabled =true ;
                CmdSaveVAC.Enabled =true ;
                CmdDelVAC.Enabled = true;

                RelAddBtn.Enabled = true;
                RelSaveBtn.Enabled = true;
                RelDelBtn.Enabled = true;

            }
            else
            {
         
                EmptabControl.TabPages.Remove(tabAbsence);
                EmptabControl.TabPages.Remove(tabLoans);
                EmptabControl.TabPages.Remove(tabDisc);
                EmptabControl.TabPages.Remove(tabAllow);
                EmptabControl.TabPages.Remove(tabVac);
                EmptabControl.TabPages.Remove(tabFamily);

                CmdAddABSENCE.Enabled = false;
                CmdSaveABSENCE.Enabled = false;
                CmdDelABSENCE.Enabled = false;

                CmdAddLOAN.Enabled = false;
                CmdSaveLOAN.Enabled = false;
                CmMakeLOAN.Enabled = false;
                CmdDelLOAN.Enabled = false;


                CmdAddDiscount.Enabled = false;
                CmdSaveDiscount.Enabled = false;
                CmdDelDiscount.Enabled = false;

                CmdAddALLOWNCE.Enabled = false;
                CmdSAVEALLOWNCE.Enabled = false;
                CmdDELALLOWNCE.Enabled = true;

                CmdAddVAC.Enabled = false;
                CmdSaveVAC.Enabled = false;
                CmdDelVAC.Enabled = false;

                RelAddBtn.Enabled = false;
                RelSaveBtn.Enabled = false;
                RelDelBtn.Enabled = false;
           
            }
        }

        private void AddNewEmp()
        {
            LastIden = (decimal)pER_EMPLOYEE_DATATableAdapter.GetEmpIdenty();
            pEREMPLOYEEDATABindingSource.AddNew();
            CmbEmpGender.SelectedIndex = 0;
            CmbEmpGender.Select();
            CmbEmpMatStatus.SelectedIndex = 0;
            CmbEmpMatStatus.Select();
            rdMonthSalary.Checked = true;
            EditFlag = false;
            DelCmd.Enabled = false;
            CmdAdd.Enabled = false;
            CmbStatus.SelectedValue = 1;

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveEMP.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveEMP.Text = "ÚıSave";
            }
            EnbDisbControls(false);
            txtFname.Focus();
            
        }
       
     
        private void InvtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Flag = false;
            if (pEREMPLOYEEDATABindingSource.Count >0)
            {
                long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());
                switch (EmptabControl.SelectedIndex)
                {
                    case 0:

                        break;

                    case 1:

                        break;
                    case 2:
                        this.pER_EMP_VACATIONTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_VACATION, EMPCODE);
                        break;
                    case 3:
                        this.pER_EMP_DISCOUNTTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_DISCOUNT, EMPCODE);
                        break;
                    case 4:
                        this.pER_EMP_AllowanceTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_Allowance, EMPCODE);
                        break;
                    case 5:
                        this.pER_EMP_ABSENCETableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_ABSENCE, EMPCODE);
                        break;
                    case 6:
                        this.pRL_EMP_LOAN_DETAILTableAdapter.FillByEmpCode(this.personalDataSet.PRL_EMP_LOAN_DETAIL, EMPCODE);
                        break;
                    case 7:
                        this.pER_EMP_RELATIVETableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_RELATIVE, EMPCODE);
                        break;
                }  
            }
            Flag = true;
        }

        private void pEREMPLOYEEDATABindingSource_PositionChanged(object sender, EventArgs e)
        {

            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {

                if (pEREMPLOYEEDATABindingSource.Count == 1 && ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString() == "0")
                {
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"] = (Int64)(LastIden) + 1;
                }
                //long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString()); ;
                //this.pRL_EMP_LOAN_DETAILTableAdapter.FillByEmpCode(this.personalDataSet.PRL_EMP_LOAN_DETAIL, EMPCODE);
                //this.pER_EMP_AllowanceTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_Allowance, EMPCODE);
                //this.pER_EMP_ABSENCETableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_ABSENCE, EMPCODE);
                //this.pER_EMP_VACATIONTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_VACATION, EMPCODE);
                //this.pER_EMP_DISCOUNTTableAdapter.FillByEmpCode(this.personalDataSet.PER_EMP_DISCOUNT, EMPCODE);

                //pEREMPABSENCEBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                //pEREMPDISCOUNTBindingSource.Filter ="EMP_CODE= " + EMPCODE.ToString();
                //pRLEMPLOANDETAILBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                //pEREMPVACATIONBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                //pER_EMP_AllowanceBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();

              
            }
        }

      
     
      
        private void CmdAddABSENCE_Click(object sender, EventArgs e)
        {

            pEREMPABSENCEBindingSource.CurrencyManager.AddNew();
            yEAR_CODETextBox.Text = DateTime.Today.ToString();
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveABSENCE.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveABSENCE.Text = "ÚıSave";
            }
            EditFlagABS = false;
            CmdAddABSENCE.Enabled = false;
            CmdDelABSENCE.Enabled = false;
            yEAR_CODETextBox.Text = DateTime.Today.Year.ToString();
            cmbAbsMonth.SelectedValue = DateTime.Today.Month.ToString();
            dAYS_NUMTextBox.Focus();
        }

        private void CmdSaveABSENCE_Click(object sender, EventArgs e)
        {
            if (CheckAbsDate())
            {
                if (GLibrary.ValidatetxtBox(errorProvider1, yEAR_CODETextBox, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) )
                {
                    if (GLibrary.IsNumeric(yEAR_CODETextBox.Text) && cmbAbsMonth.SelectedValue !=null)
                    {
                        pEREMPABSENCEBindingSource.EndEdit();
                        pER_EMP_ABSENCETableAdapter.Update(personalDataSet.PER_EMP_ABSENCE);
                        CmdAddABSENCE.Enabled = true;
                        CmdDelABSENCE.Enabled = true;
                        EditFlagABS = true;

                        //CmdSave.Text = " ⁄œÌ·";
                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            CmdSaveABSENCE.Text = " ⁄œÌ·";

                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            CmdSaveABSENCE.Text = "ÚıEdit";
                        }
                        GLibrary.MsgSave();
                    }
                    else
                    {
                        MessageBox.Show("«œŒ· «·»Ì«‰«  »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                    }
                }
            }

        }
        
        
        
        private void CmdDelABSENCE_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pEREMPABSENCEBindingSource.RemoveCurrent();
                pEREMPABSENCEBindingSource.EndEdit();
                pER_EMP_ABSENCETableAdapter.Update(personalDataSet.PER_EMP_ABSENCE);
                if (pEREMPABSENCEBindingSource.Count == 0)
                {
                    CmdDelABSENCE.Enabled = false;
                    CmdSaveABSENCE.Enabled = false;
                }

            }
        }

        private void CmdAddLOAN_Click(object sender, EventArgs e)
        {

            pRLEMPLOANDETAILBindingSource.CurrencyManager.AddNew();

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveLOAN.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveLOAN.Text = "ÚıSave";
            }
            lblLoanBalance.Text = "0";
            EditFlagLoan = false;
            CmdAddLOAN.Enabled = false;
            CmMakeLOAN.Enabled = false;
            CmdDelLOAN.Enabled = false;
            lblEnterDate.Text = DateTime.Today.ToShortDateString();
            txtTOT_PAID.Focus();

       }

        private void CmdSaveLOAN_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtTotalAmount, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, txtTOTAL_MON_NUM, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true))
            {
                if (GLibrary.IsNumeric(txtTotalAmount.Text) && GLibrary.IsNumeric(txtTOTAL_MON_NUM.Text))
                {
                    if (lblLoanBalance.Text == "0")
                    {
                        lblLoanBalance.Text = txtTotalAmount.Text;
                    }
                    pRLEMPLOANDETAILBindingSource.EndEdit();
                    pRL_EMP_LOAN_DETAILTableAdapter.Update(personalDataSet.PRL_EMP_LOAN_DETAIL);
                    CmdAddLOAN.Enabled = true;
                    CmdDelLOAN.Enabled = true;
                    EditFlagLoan = true;
                    CmMakeLOAN.Enabled = true;
                    sTOP_FLAGCheckBox.Checked = false;
                    //CmdSave.Text = " ⁄œÌ·";
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSaveLOAN.Text = " ⁄œÌ·";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSaveLOAN.Text = "ÚıEdit";
                    }
                    GLibrary.MsgSave();
                }
                else
                {
                 
                    MessageBox.Show("«œŒ· «·»Ì«‰«  »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                
                }
            }
                   
        }

        private void CmdDelLOAN_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pRLEMPLOANDETAILBindingSource.RemoveCurrent();
                pRLEMPLOANDETAILBindingSource.EndEdit();
                pRL_EMP_LOAN_DETAILTableAdapter.Update(personalDataSet.PRL_EMP_LOAN_DETAIL);
                if (pRLEMPLOANDETAILBindingSource.Count == 0)
                {
                    CmdDelLOAN.Enabled = false;
                    CmdSaveLOAN.Enabled = false;
                }

            }
        }

        private void CmdAddDiscount_Click(object sender, EventArgs e)
        {
            pEREMPDISCOUNTBindingSource.CurrencyManager.AddNew();
            txtDisYear.Text = DateTime.Today.Year.ToString();
            pervMonthFlagCheckBox1.Checked = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveDiscount.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveDiscount.Text = "ÚıSave";
            }
            EditFlagDisc = false;
            CmdAddDiscount.Enabled = false;
            CmdDelDiscount.Enabled = false;
            txtDisYear.Text = DateTime.Today.Year.ToString();
            cmbDisMonth.SelectedValue = DateTime.Today.Month.ToString();
            aMOUNTTextBox.Focus();
        }

        private void CmdSaveDiscount_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtDisYear, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, aMOUNTTextBox, "√œŒ· «·„»·€ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„»·€", true) && GLibrary.ValidateComboBox(errorProvider1, pEN_CODEComboBox, "√œŒ· ‰Ê⁄ «·«Ã«“… »ÿ—Ìﬁ… ’ÕÌÕ…", "‰Ê⁄ «·«Ã«“…", true) &&  GLibrary.ValidateComboBox(errorProvider1, cmbDisMonth, "√œŒ· ‰Ê⁄ «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true) )
            {
                if (GLibrary.IsNumeric(txtDisYear.Text) && cmbDisMonth.SelectedValue !=null && GLibrary.IsNumeric(aMOUNTTextBox.Text))
                {
                    pEREMPDISCOUNTBindingSource.EndEdit();
                    pER_EMP_DISCOUNTTableAdapter.Update(personalDataSet.PER_EMP_DISCOUNT);
                    CmdAddDiscount.Enabled = true;
                    CmdDelDiscount.Enabled = true;
                    EditFlagDisc = true;

                    //CmdSave.Text = " ⁄œÌ·";
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSaveDiscount.Text = " ⁄œÌ·";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSaveDiscount.Text = "ÚıEdit";
                    }
                    GLibrary.MsgSave();
                }
                else
                {

                    MessageBox.Show("«œŒ· «·»Ì«‰«  »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);


                }
            }
        }

        private void CmdDelDiscount_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pEREMPDISCOUNTBindingSource.RemoveCurrent();
                pEREMPDISCOUNTBindingSource.EndEdit();
                pER_EMP_DISCOUNTTableAdapter.Update(personalDataSet.PER_EMP_DISCOUNT);
                if (pEREMPDISCOUNTBindingSource.Count == 0)
                {
                    CmdDelDiscount.Enabled = false;
                    CmdSaveDiscount.Enabled = false;
                }

            }
        }

        private void CmdAddVAC_Click(object sender, EventArgs e)
        {
            Flag = false;
            pEREMPVACATIONBindingSource.CurrencyManager.AddNew();
            vAC_PERIODTextBox.Text = "0";
            txtHoldiays.Text = "0";
            txtNetVac.Text = "0";
            //txtEarned.Text = "0";
            //txtTaken.Text = "0";
            //txtBalance.Text = "0";
            //txtUnpaid.Text = "0";
            chkDecFlag.Checked = false;
            chkVacYear.Checked = false;
            ticketCheckBox.Checked = false;

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveVAC.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveVAC.Text = "ÚıSave";
            }
            EditFlagVAC = false;
            CmdAddVAC.Enabled = false;
            CmdDelVAC.Enabled = false;
            txtVacYear.Text = DateTime.Today.Year.ToString();
            cmbVacMonth.SelectedValue = DateTime.Today.Month.ToString();
            Flag = true;
        }
        private Boolean  VacCal()
        {
            
                TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                if (T.Days >= 0)
                {
                    //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
                    //{
                    TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                    int d = t.Days + 1;
                    vAC_PERIODTextBox.Text = d.ToString();
                    if (GLibrary.IsNumeric(txtHoldiays.Text) && GLibrary.IsNumeric(vAC_PERIODTextBox.Text))
                    {
                         txtNetVac.Text= (decimal.Parse (vAC_PERIODTextBox.Text)-decimal .Parse (txtHoldiays.Text)).ToString();
                    }
                    else
                    {
                        txtNetVac.Text = d.ToString();
                    }
                   
                }
                else
                {
                    MessageBox.Show(" «—ÌŒ «·»œÌ…«·«Ã«“… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì… «·«Ã«“…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
                return true;
           
        }
        private void CmdSaveVAC_Click(object sender, EventArgs e)
        {
            Flag = false;
            if (VacCal())
            {
                if (GLibrary.IsNumeric(txtVacYear.Text) && cmbVacMonth.SelectedValue != null && GLibrary.IsNumeric(vAC_PERIODTextBox.Text) && GLibrary.IsNumeric(txtNetVac.Text))
                {
                 

                        pEREMPVACATIONBindingSource.EndEdit();
                        pER_EMP_VACATIONTableAdapter.Update(personalDataSet.PER_EMP_VACATION);
                        CmdAddVAC.Enabled = true;
                        CmdDelVAC.Enabled = true;
                        EditFlagVAC = true;

                        //CmdSave.Text = " ⁄œÌ·";
                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            CmdSaveVAC.Text = " ⁄œÌ·";

                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            CmdSaveVAC.Text = "ÚıEdit";
                        }
                        GLibrary.MsgSave();
                    }
                    else
                    {
                        MessageBox.Show("«œŒ· «·‘Â— Ê«·”‰… Ê„œ… «·«Ã«“… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·«Ã«“« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
            }
           
            
            Flag = true ;
        }
        private void CmdSaveEMP_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtTitle, "√œŒ· «·ÊŸÌ›…", "«·Ã‰”Ì« ", true))
            {
                if (GLibrary.ValidatetxtBox(errorProvider1, txtFname, "√œŒ· «·ÊŸÌ›…", "«·Ã‰”Ì« ", true))
                {
                    if (GLibrary.ValidateComboBox(errorProvider1, CmbEmpGender, "√œŒ· «·‰Ê⁄", "«·‰Ê⁄", true))
                    {
                        if (GLibrary.ValidateComboBox(errorProvider1, CmbGroups, "√œŒ· «·„Ã„Ê⁄…", "«·‰Ê⁄", true))
                        {
                            if (GLibrary.ValidateComboBox(errorProvider1, CmbEmpDept, "√œŒ· «·ﬁ”„", "«·«ﬁ”«„", true))
                            {
                                if (GLibrary.IsNumeric(txtBSalary.Text))
                                {

                                    txtFullName.Text = txtFname.Text;
                                    if (txtSName.Text != "")
                                    {
                                        txtFullName.Text = txtFullName.Text + " " + txtSName.Text;
                                    }
                                    if (txtTName.Text != "")
                                    {
                                        txtFullName.Text = txtFullName.Text + " " + txtTName.Text;
                                    }
                                    if (txtFoName.Text != "")
                                    {
                                        txtFullName.Text = txtFullName.Text + " " + txtFoName.Text;
                                    }
                                    //if (GLibrary.IsNumeric(txtBSalary.Text) && GLibrary.IsNumeric(txtDayNoMonth.Text))
                                    //{
                                    //    decimal SalPerDay=(decimal.Parse(txtBSalary.Text) / decimal.Parse(txtDayNoMonth.Text));
                                    //    txtHoursNoDay.Text = decimal.Round(SalPerDay, 5).ToString();
                                    //}
                                    //else
                                    //{
                                    //    txtHoursNoDay.Text = "0";
                                    //}
                                    UpdateEmpVacBalance();
                                    pEREMPLOYEEDATABindingSource.EndEdit();
                                    pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
                                    //CmdAddVAC.Enabled = true;
                                    //EditFlagVAC = true;

                                    //CmdSave.Text = " ⁄œÌ·";
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        CmdSaveEMP.Text = " ⁄œÌ·";

                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        CmdSaveEMP.Text = "ÚıEdit";
                                    }
                                    GLibrary.MsgSave();
                                    EditFlag = true;
                                    CmdAdd.Enabled = true;
                                    DelCmd.Enabled = true;
                                    EnbDisbControls(true);
                                }
                                else
                                {
                                    MessageBox.Show("«œŒ«· »Ì«‰«  «·—« » «·«”«”… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„ÊŸ›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void CmdDelVAC_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pEREMPVACATIONBindingSource.RemoveCurrent();
                pEREMPVACATIONBindingSource.EndEdit();
                pER_EMP_VACATIONTableAdapter.Update(personalDataSet.PER_EMP_VACATION);
                if (pEREMPVACATIONBindingSource.Count == 0)
                {
                    CmdDelVAC.Enabled = false;
                    CmdSaveVAC.Enabled = false;
                }

            }
        }

        private void pEREMPABSENCEBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pEREMPABSENCEBindingSource.Count > 0)
            {

                ((DataRowView)pEREMPABSENCEBindingSource.Current)["EMP_CODE"] = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());

             
            }
        }

        private void pEREMPDISCOUNTBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pEREMPDISCOUNTBindingSource.Count > 0)
            {

                ((DataRowView)pEREMPDISCOUNTBindingSource.Current)["EMP_CODE"] = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());


            }
        }

        private void pEREMPVACATIONBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pEREMPVACATIONBindingSource.Count > 0)
            {

                ((DataRowView)pEREMPVACATIONBindingSource.Current)["EMP_CODE"] = ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"];


            }
        }

        private void pRLEMPLOANDETAILBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pRLEMPLOANDETAILBindingSource.Count > 0)
            {

                ((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["EMP_CODE"] = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());


            }
        }

        private void CmdAddALLOWNCE_Click(object sender, EventArgs e)
        {
            pER_EMP_AllowanceBindingSource.CurrencyManager.AddNew();
            txtAllYear.Text = DateTime.Today.Year.ToString();
            pervMonthFlagCheckBox.Checked = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSAVEALLOWNCE.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSAVEALLOWNCE.Text = "ÚıSave";
            }
            EditFlagALL = false;
            CmdAddALLOWNCE.Enabled = false;
            CmdDELALLOWNCE.Enabled = false;
            txtAllYear.Text = DateTime.Today.Year.ToString();
            cmbMonths.SelectedValue = DateTime.Today.Month.ToString();
            txtAllAmount.Focus();
        }

        private void CmdSAVEALLOWNCE_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtAllYear, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidateComboBox (errorProvider1, cmbMonths, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true)  && GLibrary.ValidatetxtBox(errorProvider1, txtAllAmount, "√œŒ· «·„»·€ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„»·€", true))
            {
                if (GLibrary.IsNumeric(txtAllYear.Text) && cmbMonths.SelectedValue !=null  && GLibrary.IsNumeric(txtAllAmount.Text))
                {
                    pER_EMP_AllowanceBindingSource.EndEdit();
                    pER_EMP_AllowanceTableAdapter.Update(personalDataSet.PER_EMP_Allowance);
                    CmdAddALLOWNCE.Enabled = true;
                    CmdDELALLOWNCE.Enabled = true;
                    EditFlagALL = true ;

                    //EditFlagVAC = true;

                    //CmdSave.Text = " ⁄œÌ·";
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSAVEALLOWNCE.Text = " ⁄œÌ·";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSAVEALLOWNCE.Text = "ÚıEdit";
                    }
                    GLibrary.MsgSave();
                }
                else
                {

                }
            }
        }

        private void CmdDELALLOWNCE_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pER_EMP_AllowanceBindingSource.RemoveCurrent();
                pER_EMP_AllowanceBindingSource.EndEdit();
                pER_EMP_AllowanceTableAdapter.Update(personalDataSet.PER_EMP_Allowance);
                if (pER_EMP_AllowanceBindingSource.Count == 0)
                {
                    CmdDELALLOWNCE.Enabled = false;
                    CmdSAVEALLOWNCE.Enabled = false;
                }

            }
        }

        private void pER_EMP_AllowanceBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pER_EMP_AllowanceBindingSource.Count > 0)
            {

                ((DataRowView)pER_EMP_AllowanceBindingSource.Current)["EMP_CODE"] = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());


            }
        }

        private void sTART_DATEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void eND_DATEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void vAC_DATE_FRMDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //if (Flag)
            //{
            //    TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
            //    if (T.Days >= 0)
            //    {
            //        //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
            //        //{
            //        TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
            //        int d = t.Days + 1;
            //        vAC_PERIODTextBox.Text = d.ToString();
            //        txtNetVac.Text = d.ToString();
            //        txtHoldiays.Text = "0";
            //    }
            //    else
            //    {
            //        MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            //    }
            //}
        }

        private void vAC_DATE_TODateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Flag)
            {
                //VacCal();
                //TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                //if (T.Days >= 0)
                //{
                //    //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
                //    //{
                //    TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                //    int d = t.Days + 1;
                //    vAC_PERIODTextBox.Text = d.ToString();
                //    txtNetVac.Text = d.ToString();
                //    txtHoldiays.Text = "0";
                //}
                //else
                //{
                //    MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                //}
            }
        }
        
        private void AplacationAdd_Click(object sender, EventArgs e)
        {

            ApplayList frmApplayList = new ApplayList();
            frmApplayList.ShowDialog (this);
      
            
        }

        private void CmMakeLOAN_Click(object sender, EventArgs e)
        {
            LoanAdd frm = new LoanAdd();
            long LoanID = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanId"].ToString());
           frm.LoanId = LoanID;
           frm.ShowDialog();

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["STOP_FLAG"].Value = Boolean.FalseString;
        }

        private Boolean  checkVacDate()
        {
           
                TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                if (T.Days >= 0)
                {
                    //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
                    //{
                    TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                    int d = t.Days + 1;
                    vAC_PERIODTextBox.Text = d.ToString();
                }
                else
                {
                    MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
                return true;
        }
        private Boolean CheckAbsDate()
        {
           
                TimeSpan T = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
                if (T.Days >= 0)
                {
                    TimeSpan t = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
                    int d = t.Days + 1;
                    dAYS_NUMTextBox.Text = d.ToString();
                }
                else
                {
                    MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
                return true;  
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewEmp();
            
        }

       
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }
        private void CheckCancel()
        {
     
            pEREMPLOYEEDATABindingSource.CancelEdit();
            personalDataSet.PER_EMPLOYEE_DATA.RejectChanges();
            pEREMPABSENCEBindingSource.CancelEdit();
            pEREMPDISCOUNTBindingSource.CancelEdit();
            pRLEMPLOANDETAILBindingSource.CancelEdit();
            pEREMPVACATIONBindingSource.CancelEdit();
            pER_EMP_AllowanceBindingSource.CancelEdit();
        
            if (!EditFlag)
            {
                CmdAdd.Enabled = true;
                DelCmd.Enabled = true;
                //BtnPrint.Enabled = true;
                EditFlag = true;
            }
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveEMP.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveEMP.Text = "ÚıÚÚııEdit";
            }
            EnbDisbControls(true);



        }
        
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
            
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void rdMonthSalary_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMonthSalary.Checked )
            {
                txtSalaryType.Text = "1";
            }
        }
        private void rdDaySalary_CheckedChanged(object sender, EventArgs e)
        {

            if (rdDaySalary.Checked)
            {
                txtSalaryType.Text = "2";
            }
        }

        private void rETURN_DATEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void txtEmpCode_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                int pos = pEREMPLOYEEDATABindingSource.Find("EMP_CODE", txtEmpCode.Text);
                if (pos != -1)
               {
                   //if (GLibrary.MsgCheckSave(false))
                   //{
                      
                   //}
                   //else
                   //{

                       CheckCancel();
                   //}
                   pEREMPLOYEEDATABindingSource.Position = pos;             
                   CmdAdd.Enabled = true;
                   DelCmd.Enabled = true;
                   EditFlag = true;
               }
               else
               {
                   MessageBox.Show(Messages.EmpNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                   CheckCancel();
                   if (!EditFlag)
                   {
                        CmdAdd.Enabled = true;
                        DelCmd.Enabled = true;
                        EditFlag = true;
                   }
                   
               }

            }

            
        }

        private void CmbGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (empGroupsBindingSource.Count >0)
            {
                int pos =CmbGroups.SelectedIndex ;

                empGroupsBindingSource.Position = pos;
                if (((DataRowView)empGroupsBindingSource.Current)["VactionNum"]!=DBNull .Value )
                {
                     txtVacationNo.Text =((DataRowView)empGroupsBindingSource.Current)["VactionNum"].ToString ();
                     ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["VaccationDays"] = ((DataRowView)empGroupsBindingSource.Current)["VactionNum"].ToString();
                }
              
                if (((DataRowView)empGroupsBindingSource.Current)["WorkHour"]!=DBNull .Value )
                {
                    txtHoursNoDay.Text = ((DataRowView)empGroupsBindingSource.Current)["WorkHour"].ToString();
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["WorkHourPerDay"] = ((DataRowView)empGroupsBindingSource.Current)["WorkHour"].ToString();
                }
                if (((DataRowView)empGroupsBindingSource.Current)["SickVactionNum"] != DBNull.Value)
                {
                    txtSickNo.Text = ((DataRowView)empGroupsBindingSource.Current)["SickVactionNum"].ToString();
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["IndemnityDays"] = ((DataRowView)empGroupsBindingSource.Current)["SickVactionNum"].ToString();
                }
                if (((DataRowView)empGroupsBindingSource.Current)["NutalAttendance"] != DBNull.Value)
                {
                    txtDayNoMonth.Text = ((DataRowView)empGroupsBindingSource.Current)["NutalAttendance"].ToString();
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["WorkDaysperMonth"] = ((DataRowView)empGroupsBindingSource.Current)["NutalAttendance"].ToString();
                }
                if (((DataRowView)empGroupsBindingSource.Current)["AbsenceHourPercentage"] != DBNull.Value)
                {
                   hOURVALUETextBox.Text = ((DataRowView)empGroupsBindingSource.Current)["AbsenceHourPercentage"].ToString();
                  // ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"] = ((DataRowView)empGroupsBindingSource.Current)["AbsenceHourPercentage"].ToString();
                }
                              
            }

        }

        private void CmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vAC_TYPE_CODEComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cDEPERVACSUBCLASSBindingSource.Count >= 0)
                {
                    if (vAC_TYPE_CODEComboBox.SelectedValue != null)
                    {
                        int VAC_TYPE_CODE = int.Parse(vAC_TYPE_CODEComboBox.SelectedValue.ToString());
                        int pos = cDEPERVACSUBCLASSBindingSource.Find("VAC_TYPE_CODE", VAC_TYPE_CODE);
                        if (pos > -1)
                        {
                            
                            if (((DataRowView)cDEPERVACSUBCLASSBindingSource[pos])["DEC_FLAG"] != DBNull.Value)
                            {
                                if (Boolean.Parse(((DataRowView)cDEPERVACSUBCLASSBindingSource[pos])["DEC_FLAG"].ToString()))
                                {
                                    chkDecFlag.Checked = true;
                                    ((DataRowView)pEREMPVACATIONBindingSource.Current)["DEC_FLAG"] = true;
                                }
                                else
                                {
                                    chkDecFlag.Checked = false;
                                    ((DataRowView)pEREMPVACATIONBindingSource.Current)["DEC_FLAG"] = false ;
                                }
                            }
                            else
                            {
                                chkDecFlag.Checked = true;
                                ((DataRowView)pEREMPVACATIONBindingSource.Current)["DEC_FLAG"] = true;
                            }

                            if (((DataRowView)cDEPERVACSUBCLASSBindingSource[pos])["PERIOD_FLAG"] != DBNull.Value)
                            {
                                if (Boolean.Parse(((DataRowView)cDEPERVACSUBCLASSBindingSource[pos])["PERIOD_FLAG"].ToString()))
                                {
                                    chkVacYear.Checked = true;
                                    ((DataRowView)pEREMPVACATIONBindingSource.Current)["PERIOD_FLAG"] = true;
                                }
                                else
                                {
                                    chkVacYear.Checked = false;
                                    ((DataRowView)pEREMPVACATIONBindingSource.Current)["PERIOD_FLAG"] = false ;
                                }
                            }
                            else
                            {
                                chkVacYear.Checked = true;
                                ((DataRowView)pEREMPVACATIONBindingSource.Current)["PERIOD_FLAG"] = true;
                            }

                        }
                    }
            }
        }

        private void RelAddBtn_Click(object sender, EventArgs e)
        {
            pEREMPRELATIVEBindingSource.CurrencyManager.AddNew();
             if (Messages.CurLang == Messages.ArabLang)
            {
                RelSaveBtn.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                RelSaveBtn.Text = "ÚıSave";
            }

            RelAddBtn.Enabled = false;
            RelDelBtn.Enabled = false;
            EditFlagRel = false;
            txtRelName.Focus();
          
        }

        private void RelSaveBtn_Click(object sender, EventArgs e)
        {
           
               
                  if (GLibrary.ValidatetxtBox (errorProvider1 , txtRelName,"«œŒ· «”„ «·„—«›ﬁ","«·„—«›ﬁÌ‰",true )) 
                  {
                        pEREMPRELATIVEBindingSource.EndEdit();
                        pER_EMP_RELATIVETableAdapter.Update(personalDataSet.PER_EMP_RELATIVE );
                        RelAddBtn.Enabled = true;
                        RelDelBtn.Enabled = true;
                        EditFlagRel = true ;
                        //CmdSave.Text = " ⁄œÌ·";
                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            RelSaveBtn.Text = " ⁄œÌ·";
                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            RelSaveBtn.Text = "ÚıEdit";
                        }
                        GLibrary.MsgSave();
                    }
                   
              
        }

        private void RelDelBtn_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pEREMPRELATIVEBindingSource.RemoveCurrent();
                pEREMPRELATIVEBindingSource.EndEdit();
                pER_EMP_RELATIVETableAdapter.Update(personalDataSet.PER_EMP_RELATIVE);
                if (pEREMPRELATIVEBindingSource.Count == 0)
                {
                    RelDelBtn.Enabled = false;
                    RelSaveBtn.Enabled = false;
                }
            }
        }

        private void pEREMPRELATIVEBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pEREMPRELATIVEBindingSource.Count > 0)
            {
                ((DataRowView)pEREMPRELATIVEBindingSource.Current)["EMP_CODE"] = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());
            }
        }

        private void txtHoldiays_Validated(object sender, EventArgs e)
        {
            updateNetVac();

        }
        private void updateNetVac()
        {
            if (GLibrary.IsNumeric(vAC_PERIODTextBox.Text) && GLibrary.IsNumeric(txtHoldiays.Text))
            {
                decimal NetVc= decimal.Parse(vAC_PERIODTextBox.Text) - decimal.Parse(txtHoldiays.Text);
                txtNetVac.Text = NetVc.ToString();
            }
            else
            {

                txtNetVac.Text = vAC_PERIODTextBox.Text;
                    
            }
        }

       
        private void dataGridRel_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            RelAddBtn.Enabled = true;
            RelDelBtn.Enabled = true;
            EditFlagRel = true;
            if (Messages.CurLang == Messages.ArabLang)
            {
                RelSaveBtn.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                RelSaveBtn.Text = "ÚıEdit";
            }
        }

        private void dataGridLoans_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            CmdAddLOAN.Enabled = true;
            CmdDelLOAN.Enabled = true;
            EditFlagLoan = true;
            CmMakeLOAN.Enabled = true;
            sTOP_FLAGCheckBox.Checked = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveLOAN.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveLOAN.Text = "ÚıEdit";
            }
        }

        private void DataGridAbsence_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            CmdAddABSENCE.Enabled = true;
            CmdDelABSENCE.Enabled = true;
            EditFlagABS = true;
          
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveABSENCE.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveABSENCE.Text = "ÚıEdit";
            }
        }

        private void dataGridAllow_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            CmdAddALLOWNCE.Enabled = true;
            CmdDELALLOWNCE.Enabled = true;
             EditFlagALL = true;
          
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSAVEALLOWNCE.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSAVEALLOWNCE.Text = "ÚıEdit";
            }
        }

        private void dataGridDisc_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            CmdAddDiscount.Enabled = true;
            CmdDelDiscount.Enabled = true;
           
            EditFlagDisc = true;
          
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveDiscount.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveDiscount.Text = "ÚıEdit";
            }
        }

        private void dataGridVac_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            
            EditFlagVAC = true ;
            CmdAddVAC.Enabled = true;
            CmdDelVAC.Enabled = true;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSaveVAC.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSaveVAC.Text = "ÚıEdit";
            }
        }

        private void vAC_DATE_FRMDateTimePicker_Validated(object sender, EventArgs e)
        {
            VacCal();
        }

        private void vAC_DATE_TODateTimePicker_Validated(object sender, EventArgs e)
        {
            VacCal();
        }

        private void sTART_DATEDateTimePicker_Validated(object sender, EventArgs e)
        {
            CheckAbsDate();
        }

        private void eND_DATEDateTimePicker_Validated(object sender, EventArgs e)
        {
            CheckAbsDate();
        }

        private void RelDelBtn_Click_1(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {

                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                pEREMPRELATIVEBindingSource.RemoveCurrent();
                pEREMPRELATIVEBindingSource.EndEdit();
                pER_EMP_RELATIVETableAdapter.Update(personalDataSet.PER_EMP_RELATIVE );
                if (pEREMPRELATIVEBindingSource.Count == 0)
                {
                    RelDelBtn.Enabled = false;
                    RelSaveBtn.Enabled = false;
                }

            }
        }

        private void btnPrintRel_Click(object sender, EventArgs e)
        {
                     
            ShowEmpRpt frm = new ShowEmpRpt();
            frm.choiceNum = 9;
            frm.EmpName = txtFname.Text + " " + txtSName.Text + " " + txtTName.Text + " " + txtFoName.Text;
            frm.personalDataSet = personalDataSet;
            //frm.MdiParent = this;
            frm.ShowDialog();
            frm.Focus();
        }

       

        

       
    }
 
}