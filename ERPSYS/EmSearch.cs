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
    public partial class EmSearch :  DockContent
    {
     
        public  Nullable<int> Empcode = null;
        private string EmpFName = null;
        private string EmpSName = null;
        private string EmpTName = null;
        private string EmpFoName = null;
       
        public EmSearch()
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
       
                 


      
       
      
       private void  SearchEmp  ()
        {
            if (GLibrary.IsNumeric(txtEmpCode.Text))
            {
                Empcode = int.Parse (txtEmpCode.Text);
            }
            else
            {
            }
            if (txtFname.Text != "")
            {
                EmpFName = txtFname.Text;
            }
            else
            {
                EmpFName = null;
            }
            if (txtSName.Text != "")
            {
                EmpSName = txtSName.Text;
            }
            else
            {
                EmpSName = null;
            }
            if (txtTName.Text != "")
            {
                EmpTName = txtTName.Text;
            }
            else
            {
                EmpTName = null;
            }
            if (txtFoName.Text != "")
            {
                EmpFoName = txtFoName.Text;
     
            }
            else
            {
                EmpFoName = null;
            }



            this.pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(this.personalDataSet.PER_EMPLOYEE_DATA, Empcode, EmpFName, EmpSName, EmpTName, EmpFoName);

        }

        private void txtEmpCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmp();
            }
        }

        private void txtFname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmp();
            }
        }

        private void txtSName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmp();
            }
        }

        private void txtTName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmp();
            }
        }

        private void txtFoName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEmp();
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
       
             

       

        
    }
}