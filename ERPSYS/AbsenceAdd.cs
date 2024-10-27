using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class AbsenceAdd : Form
    {
        public Boolean EditFlag = false;
        public Decimal EmpCode;
        public AbsenceAdd()
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
            
        }
       
                 

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            pER_EMP_ABSENCEBindingSource.EndEdit();
            //nEWERPDataSet.AcceptChanges();
            pER_EMP_ABSENCETableAdapter.Update(personalDataSet.PER_EMP_ABSENCE);
 
            GLibrary.MsgSave();
            CmdAdd.Enabled = true;
            CmdDel.Enabled = true;
            EditFlag = true;
               
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNew();   
        }
        private void AddNew()
        {

            pER_EMP_ABSENCEBindingSource.AddNew();
             EditFlag =false ;
             CmdAdd.Enabled = false ;
             CmdDel.Enabled =false ;
        }
        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (pER_EMP_ABSENCEBindingSource.Count > 0) 
            {
                if (GLibrary.MsgCheckDel())
                {
                    
                    pER_EMP_ABSENCEBindingSource.RemoveCurrent();
                    pER_EMP_ABSENCEBindingSource.EndEdit();
                    pER_EMP_ABSENCETableAdapter.Update(personalDataSet.PER_EMP_ABSENCE);
                   
                   
                }
            }
        }

        private void AbsenceAdd_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_ABSENCE' table. You can move, or remove it, as needed.
            this.pER_EMP_ABSENCETableAdapter.Fill(this.personalDataSet.PER_EMP_ABSENCE);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_ABSENCE' table. You can move, or remove it, as needed.

            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.

            if (!EditFlag)
            {
                AddNew();
            }
            else
            {
                pER_EMP_ABSENCEBindingSource.Filter = "EmpCode=" + EmpCode.ToString();

            }
            dAYS_NUMTextBox.Focus();
        }

             

       

        
    }
}