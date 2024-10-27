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
    public partial class EMP_DATA_AddOld1 : DockContent
    {
       
        public decimal LastIden = -1;
        private StaticList slGenderTypes = new StaticList(GLibrary.strarrGenderTypes);
        private StaticList slMalStatusType = new StaticList(GLibrary.strarrMalStatusType);
        public Boolean EditFlagABS = false;
        public Boolean EditFlagVAC= false;
        public Boolean EditFlagLoan = false;
        public Boolean EditFlagDisc = false;
        public Boolean EditFlagALL = false;
        private Boolean Flag = false;
        private DateTime lastDataError = DateTime.MinValue;

        public EMP_DATA_AddOld1()
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
            // TODO: This line of code loads data into the 'personalDataSet.Emp_Groups' table. You can move, or remove it, as needed.
            this.emp_GroupsTableAdapter.Fill(this.personalDataSet.Emp_Groups);
            Flag = false;
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_Allowance' table. You can move, or remove it, as needed.
            this.pER_EMP_AllowanceTableAdapter.Fill(this.personalDataSet.PER_EMP_Allowance);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_ABSENCE' table. You can move, or remove it, as needed.
            this.pER_EMP_ABSENCETableAdapter.Fill(this.personalDataSet.PER_EMP_ABSENCE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.
            this.pRL_EMP_LOAN_DETAILTableAdapter.Fill(this.personalDataSet.PRL_EMP_LOAN_DETAIL);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.
            this.pER_EMP_VACATIONTableAdapter.Fill(this.personalDataSet.PER_EMP_VACATION);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
            this.pER_EMP_DISCOUNTTableAdapter.Fill(this.personalDataSet.PER_EMP_DISCOUNT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
      
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


            Flag = true;

        }

       
        private void CmdSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            pEREMPLOYEEDATABindingSource.EndEdit();
            pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
           
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

     

     

    
        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {          
               
            }
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

     

        private void AddNewEmp()
        {
            LastIden = (decimal)pER_EMPLOYEE_DATATableAdapter.GetEmpIdenty();
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
            //EditFlag = false;
            CmdAddABSENCE.Enabled = false;
            CmdDelABSENCE.Enabled = false;      
            
        }
       
     
        private void InvtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EmptabControl.SelectedIndex)
            {
                case 0:

                    break;

                case 2:
                    //if (ProductsDGView.Rows.Count > 0 && txtinvTotal.Text!="0")
                    //{
                    //    GetQid();
                       
                    //}
                    //else
                    //{
                    //    MessageBox.Show(Messages.ProductInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        
                    //    EmptabControl.SelectedIndex = 0;
                    //    EmptabControl.Select();

                    //}
                    break;
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
                long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString()); ;
                pEREMPABSENCEBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                pEREMPDISCOUNTBindingSource.Filter ="EMP_CODE= " + EMPCODE.ToString();
                pRLEMPLOANDETAILBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                pEREMPVACATIONBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();
                pER_EMP_AllowanceBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();

              
            }
        }

      

       

        //private void AddVacCmd_Click(object sender, EventArgs e)
        //{
        //    //if (EditFlag)
        //    //{

        //    //    frmVacationAdd.EditFlag = false;
        //    //    frmVacationAdd.Show();
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show(Messages.EmpSaveMesg, "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

        //    //}
        //}

     
        private void EmpPicBox_Click(object sender, EventArgs e)
        {

        }

        private void CmdAddABSENCE_Click(object sender, EventArgs e)
        {

            pEREMPABSENCEBindingSource.CurrencyManager.AddNew();
          
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
           
           
                    
        }

        private void CmdSaveABSENCE_Click(object sender, EventArgs e)
        {
            if (CheckAbsDate())
            {
                if (GLibrary.ValidatetxtBox(errorProvider1, yEAR_CODETextBox, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, mONTH_CODETextBox, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true))
                {
                    if (GLibrary.IsNumeric(yEAR_CODETextBox.Text) && GLibrary.IsNumeric(mONTH_CODETextBox.Text))
                    {
                        pEREMPABSENCEBindingSource.EndEdit();
                        pER_EMP_ABSENCETableAdapter.Update(personalDataSet.PER_EMP_ABSENCE);
                        CmdAddABSENCE.Enabled = true;
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
            EditFlagLoan = false;
            CmdAddLOAN.Enabled = false;
            CmMakeLOAN.Enabled = false;
        }

        private void CmdSaveLOAN_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtTotalAmount, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, txtTOTAL_MON_NUM, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true))
            {
                if (GLibrary.IsNumeric(txtTotalAmount.Text) && GLibrary.IsNumeric(txtTOTAL_MON_NUM.Text))
                {
                    pRLEMPLOANDETAILBindingSource.EndEdit();
                    pRL_EMP_LOAN_DETAILTableAdapter.Update(personalDataSet.PRL_EMP_LOAN_DETAIL);
                    CmdAddLOAN.Enabled = true;
                    EditFlagLoan = true;
                    CmMakeLOAN.Enabled = true;

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
        }

        private void CmdSaveDiscount_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtDisYear, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, txtDisMonth, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true) && GLibrary.ValidatetxtBox(errorProvider1, aMOUNTTextBox, "√œŒ· «·„»·€ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„»·€", true))
            {
                if (GLibrary.IsNumeric(txtDisYear.Text) && GLibrary.IsNumeric(txtDisMonth.Text) && GLibrary.IsNumeric(aMOUNTTextBox.Text))
                {
                    pEREMPDISCOUNTBindingSource.EndEdit();
                    pER_EMP_DISCOUNTTableAdapter.Update(personalDataSet.PER_EMP_DISCOUNT);
                    CmdAddDiscount.Enabled = true;
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
            pEREMPVACATIONBindingSource.CurrencyManager.AddNew();

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
        }

        private void CmdSaveVAC_Click(object sender, EventArgs e)
        {
            if (checkVacDate())
            {
                pEREMPVACATIONBindingSource.EndEdit();
                pER_EMP_VACATIONTableAdapter.Update(personalDataSet.PER_EMP_VACATION);
                CmdAddVAC.Enabled = true;
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
        }
        private void CmdSaveEMP_Click(object sender, EventArgs e)
        {
            if (CmbEmpDept.SelectedValue != null && txtEmpName.Text != "")
            {
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
            }
            else
            {
                MessageBox.Show("«œŒ«· »Ì«‰«  «·„ÊŸ› »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„ÊŸ›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
        }

        private void CmdSAVEALLOWNCE_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtAllYear, "√œŒ· «·”‰… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·”‰…", true) && GLibrary.ValidatetxtBox(errorProvider1, txtAllMonth, "√œŒ· «·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·‘Â—", true) && GLibrary.ValidatetxtBox(errorProvider1, txtAllAmount, "√œŒ· «·„»·€ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·„»·€", true))
            {
                if (GLibrary.IsNumeric(txtAllYear.Text) && GLibrary.IsNumeric(txtAllMonth.Text) && GLibrary.IsNumeric(txtAllAmount.Text))
                {
                    pER_EMP_AllowanceBindingSource.EndEdit();
                    pER_EMP_AllowanceTableAdapter.Update(personalDataSet.PER_EMP_Allowance);
                    //CmdAddVAC.Enabled = true;
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
            //if (Flag)
            //{
            //    TimeSpan T = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
            //    if (T.Days >= 0)
            //    {
            //        TimeSpan t = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
            //        int d = t.Days + 1;
            //        dAYS_NUMTextBox.Text = d.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            //    }
            //}
            
        }

        private void eND_DATEDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //if (Flag)
            //{
            //    TimeSpan T = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
            //    if (T.Days >= 0)
            //    {
            //        TimeSpan t = eND_DATEDateTimePicker.Value.Subtract(sTART_DATEDateTimePicker.Value);
            //        int d = t.Days + 1;
            //        dAYS_NUMTextBox.Text = d.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            //    }
            //}
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
            //    }
            //    else
            //    {
            //        MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            //    }
            //}
        }

        private void vAC_DATE_TODateTimePicker_ValueChanged(object sender, EventArgs e)
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
            //    }
            //    else
            //    {
            //        MessageBox.Show(" «—ÌŒ «·»œÌ… ÌÃ» «‰ ÌﬂÊ‰ «ﬁ· „‰ «ÊÌ”«ÊÌ  «—ÌŒ «·‰Â«Ì…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            //    }
            //}
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
    

    }
 
}