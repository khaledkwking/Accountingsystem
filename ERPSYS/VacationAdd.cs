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
    public partial class VacationAdd :  DockContent
    {
        public Boolean EditFlag = false;
        public Boolean Flag = false;
        //public Decimal EmpCode;
        private Nullable<long> EmpCode = null;
        private string CurFName=null;
        private string CurSName=null;
        private string CurTName=null;
        private string CurFoName=null;

        public VacationAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
           // e.Cancel = true;
            //this.Hide();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
           
        }
       
                 

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (checkVacDate() )
            {
                if (pEREMPLOYEEDATABindingSource.Count > 0)
                {
                    VacCal();
                    pER_EMP_VACATIONBindingSource.EndEdit();
                    pER_EMP_VACATIONTableAdapter.Update(personalDataSet.PER_EMP_VACATION);
                    GLibrary.MsgSave();
                    CmdAdd.Enabled = true;
                    CmdDel.Enabled = true;
                    EditFlag = true;

                    //CmdSave.Text = "ÊÚÏíá";
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSave.Text = "ÊÚÏíá";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSave.Text = "òõEdit";
                    }
                    GLibrary.MsgSave();
                }
                else
                {
                    MessageBox.Show("ÇÎÊÇÑ ÇáãæÙÝ ÇæáÇ", "ÇáÇÌÇÒÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
           
            
        }
        private Boolean checkVacDate()
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
                MessageBox.Show("ÊÇÑíÎ ÇáÈÏíÉ íÌÈ Çä íßæä ÇÞá ãä ÇæíÓÇæí ÊÇÑíÎ ÇáäåÇíÉ", "ÇáÇÌÇÒÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                return false;
            }
            return true;
        }
        private void VacCal()
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
                    txtNetVac.Text = (decimal.Parse(vAC_PERIODTextBox.Text) - decimal.Parse(txtHoldiays.Text)).ToString();
                }
                else
                {
                    txtNetVac.Text = d.ToString();
                }

            }
            else
            {
                MessageBox.Show("ÊÇÑíÎ ÇáÈÏíÉ íÌÈ Çä íßæä ÇÞá ãä ÇæíÓÇæí ÊÇÑíÎ ÇáäåÇíÉ", "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }

        }
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNew();   
        }
        private void AddNew()
        {
            pER_EMP_VACATIONBindingSource.CurrencyManager.AddNew();
            vAC_PERIODTextBox.Text = "0";
            txtHoldiays.Text = "0";
            txtNetVac.Text = "0";
            txtEarned.Text = "0";
            txtTaken.Text = "0";
            txtBalance.Text = "0";
            txtUnpaid.Text = "0";
            chkDecFlag.Checked = false;
            ticketCheckBox.Checked = false;

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõSave";
            }
            
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;

          

            
            
        }
        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (pER_EMP_VACATIONBindingSource.Count > 0) 
            {
                if (GLibrary.MsgCheckDel())
                {

                    pER_EMP_VACATIONBindingSource.RemoveCurrent();
                    pER_EMP_VACATIONBindingSource.EndEdit();
                    pER_EMP_VACATIONTableAdapter.Update(personalDataSet.PER_EMP_VACATION);
                   
                   
                }
            }
        }

        private void VacationAdd_Activated(object sender, EventArgs e)
        {
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.
            this.pER_EMP_VACATIONTableAdapter.Fill(this.personalDataSet.PER_EMP_VACATION);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.

            if (!EditFlag)
            {
                AddNew();
            }
            else
            {
                pER_EMP_VACATIONBindingSource.Filter = "EmpCode=" + EmpCode.ToString();

            }
         
        }

        private void pEREMPLOYEEDATABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {

                //if (pEREMPLOYEEDATABindingSource.Count == 1 && ((DataRowView)pER_EMP_VACATIONBindingSource.Current)["EMP_CODE"].ToString() == "0")
                //{
                //    ((DataRowView)qidsBindingSource.Current)["EMP_CODE"] = (Int64)(LastIden + 1);
                //}
                Int64 Empid = (Int64)((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"];
                pER_EMP_VACATIONBindingSource.Filter = "EMP_CODE = " + Empid.ToString(); //+ " Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString()+")";



            }
        }

        private void pER_EMP_VACATIONBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0 && pER_EMP_VACATIONBindingSource.Count > 0)
            {

                ((DataRowView)pER_EMP_VACATIONBindingSource.Current)["EMP_CODE"] = (Int64)((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"];
                //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmSearch frm = new EmSearch();
             DialogResult ret =  frm.ShowDialog(this);
             if (DialogResult.OK == ret)
             {
                Nullable<int> Empcode  = frm.Empcode;
                 if (GLibrary.IsNumeric(Empcode.ToString()))
                 {
                     this.pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(this.personalDataSet.PER_EMPLOYEE_DATA, frm.Empcode, null, null, null, null);
                 }
             }

        }

        private void txtEmpcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        private void Search()
        {
            if (txtEmpcode.Text!="")
            {
                     EmpCode=  long .Parse (txtEmpcode.Text);              
            }
            else
            {
                 EmpCode=null;
            }


            if (txtFname.Text!="")
            {
                     CurFName=  txtFname.Text;              
            }
            else
            {
                 CurFName=null;
            }

            if (txtSName.Text != "")
            {
                CurSName = txtSName.Text;              
            }
            else
            {
                 CurSName=null;
            }
            
            if (txtTName.Text!="")
            {
                     CurTName= txtTName.Text;              
            }
            else
            {
                 CurTName=null;
            }

            if (txtFoName.Text != "")
            {
                     CurFoName=  txtFoName.Text;              
            }
            else
            {
                 CurFoName=null;
            }
            pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, EmpCode, CurFName, CurSName, CurTName, CurFoName);

        }

        private void vAC_DATE_FRMDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Flag)
            {
                TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                if (T.Days >= 0)
                {
                    //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
                    //{
                    TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                    int d = t.Days + 1;
                    vAC_PERIODTextBox.Text = d.ToString();
                    txtNetVac.Text = d.ToString();
                }
                else
                {
                    MessageBox.Show("ÊÇÑíÎ ÇáÈÏíÉ íÌÈ Çä íßæä ÇÞá ãä ÇæíÓÇæí ÊÇÑíÎ ÇáäåÇíÉ", "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                }
            }
        }

        private void vAC_DATE_TODateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (Flag)
            {
                TimeSpan T = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                if (T.Days >= 0)
                {
                    //if (vAC_DATE_FRMDateTimePicker.Value <= vAC_DATE_TODateTimePicker.Value)
                    //{
                    TimeSpan t = vAC_DATE_TODateTimePicker.Value.Subtract(vAC_DATE_FRMDateTimePicker.Value);
                    int d = t.Days + 1;
                    vAC_PERIODTextBox.Text = d.ToString();
                    txtNetVac.Text = d.ToString();
                }
                else
                {
                    MessageBox.Show("ÊÇÑíÎ ÇáÈÏíÉ íÌÈ Çä íßæä ÇÞá ãä ÇæíÓÇæí ÊÇÑíÎ ÇáäåÇíÉ", "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                }
            }
        }

             

       

        
    }
}