using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using Microsoft.Win32;

namespace ERPSYS
{
    public partial class FormsContractPassport : Form
    {

        public FormsContractPassport()
        {
            InitializeComponent();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormsResAddRenew_Load(object sender, EventArgs e)
        {
            int iOrigialScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int iOrigialScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            //Resolution.CResolution ChangeRes = new Resolution.CResolution(iOrigialScreenHeight, iOrigialScreenWidth); 


            




        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //ShowEmpFormsRpt frm = new ShowEmpFormsRpt();
            //if (GLibrary.IsDate(txtApplyDate.Text))
            //{
            //    frm.ApplyDate = DateTime.Parse(txtApplyDate.Text);
            //}
            //else
            //{
            //    frm.ApplyDate = DateTime.Today;
            //}

            //frm.ApplyNo=txtApplyNo.Text;
            //frm.ApplyType=CmbEmpApplay.SelectedText ;
            //frm.sCompanyName=txtsCompanyName.Text;
            //if (txtDinar.Text == "")
            //{
            //    frm.Dinar = "0";
            //}
            //else
            //{
            //    frm.Dinar = txtDinar.Text;
            //}
            //if (txtFils.Text == "")
            //{
            //    frm.Fils = "0";
            //}
            //else
            //{
            //    frm.Fils = txtFils.Text;
            //}
            //frm.FileNo=txtFileNo.Text ;
            //frm.Gov="«·⁄«’„…";
            //frm.GovContract=txtGovContract.Text ;
            //frm.NewTitle=txtNewTitle.Text ;
            //frm.workOnwer = txtworkOnwer.Text ;
            //frm.SignPerson = txtSignPerson.Text ;
            //frm.UsePeroid = txtUsePeroid.Text ;
            //frm.choiceNum = 1;
            //frm.ShowDialog();

        }

    }
}