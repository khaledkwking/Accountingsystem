using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class DiscountAdd : Form
    {
        public Boolean EditFlag = false;
        public Decimal EmpCode;
        public DiscountAdd()
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
            pER_EMP_DISCOUNTBindingSource.EndEdit();
            //nEWERPDataSet.AcceptChanges();
            pER_EMP_DISCOUNTTableAdapter.Update(personalDataSet.PER_EMP_DISCOUNT);
 
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

            pER_EMP_DISCOUNTBindingSource.AddNew();
             EditFlag =false ;
             CmdAdd.Enabled = false ;
             CmdDel.Enabled =false ;
        }
        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (pER_EMP_DISCOUNTBindingSource.Count > 0) 
            {
                if (GLibrary.MsgCheckDel())
                {

                    pER_EMP_DISCOUNTBindingSource.RemoveCurrent();
                    pER_EMP_DISCOUNTBindingSource.EndEdit();
                    pER_EMP_DISCOUNTTableAdapter.Update(personalDataSet.PER_EMP_DISCOUNT);
                   
                   
                }
            }
        }

        private void DiscountAdd_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
            this.pER_EMP_DISCOUNTTableAdapter.Fill(this.personalDataSet.PER_EMP_DISCOUNT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.

            if (!EditFlag)
            {
                AddNew();
            }
            else
            {
                pER_EMP_DISCOUNTBindingSource.Filter = "EmpCode=" + EmpCode.ToString();

            }
            pEN_CODEComboBox.Focus();
        }

             

       

        
    }
}