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
    public partial class FormsMakePassport : Form
    {
        private StaticList slPassportTypes = new StaticList(GLibrary.strarrPssportType);
        
        public FormsMakePassport()
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
            cmbApplyType.DataSource = slPassportTypes.ToDataTable();
       

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
            //frm.Gov="�������";
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