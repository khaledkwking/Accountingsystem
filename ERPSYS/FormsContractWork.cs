using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
namespace ERPSYS
{
    public partial class FormsContractWork : Form
    {
      
        public FormsContractWork()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormsResAddRenew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);

       

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowEmpFormsRpt frm = new ShowEmpFormsRpt();
            if (GLibrary.IsDate(txtStartDate.Text))
            {
                frm.StartDate  = DateTime.Parse(txtStartDate.Text);
            }
            else
            {
                frm.StartDate  = DateTime.Today;
            }

            if (GLibrary.IsDate(txtEndDate.Text))
            {
                frm.EndDate  = DateTime.Parse(txtEndDate.Text);
            }
            else
            {
                frm.EndDate = DateTime.Today;
            }
         
            frm.sCompanyName = txtsCompanyName.Text;
            frm.EmpName = CmbEmp.Text;
            if (txtDinar.Text == "")
            {
                frm.Dinar = "0";
            }
            else
            {
                frm.Dinar = txtDinar.Text;
            }
                                
            frm.choiceNum = 2;
            frm.ShowDialog();

        }
    }
}