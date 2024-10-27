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
    public partial class EmpForms : Form 
    {
        public EmpForms()
        {
            InitializeComponent();
        }

        private void ClearPanel()
        {
            for (int i = 0; i < this.Panel2.Controls.Count; i++)
            {
                this.Panel2.Controls.RemoveAt(i);
            }
        }
        private void lblNewDel_Click(object sender, EventArgs e)
        {
            FormsResAddRenew FormsResAddRenewfrm =new FormsResAddRenew ();
            FormsResAddRenewfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsResAddRenewfrm);
            FormsResAddRenewfrm.Show();
            FormsResAddRenewfrm.Focus();
        }

        private void lblWorkcontract_Click(object sender, EventArgs e)
        {
            FormsContractWork FormsContractWorkfrm = new FormsContractWork();
            FormsContractWorkfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsContractWorkfrm);
            FormsContractWorkfrm.Show();
            FormsContractWorkfrm.Focus();
     
        }

        private void lblMigration_Click(object sender, EventArgs e)
        {
            FormsContractPassport FormsContractPassportfrm = new FormsContractPassport();
            FormsContractPassportfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsContractPassportfrm);
            FormsContractPassportfrm.Show();
            
        }

        private void lblVisa_Click(object sender, EventArgs e)
        {
            FormsContractVisa FormsContractVisafrm = new FormsContractVisa();
            FormsContractVisafrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsContractVisafrm);
            FormsContractVisafrm.Show();
            FormsContractVisafrm.Focus();
            
        }

        private void lblSignature_Click(object sender, EventArgs e)
        {
            FormsSignaturePerson FormsSignaturePersonfrm = new FormsSignaturePerson();
            FormsSignaturePersonfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsSignaturePersonfrm);
            FormsSignaturePersonfrm.Show();
            FormsSignaturePersonfrm.Focus();
            
        }

        private void lblCivilApply_Click(object sender, EventArgs e)
        {
            FormsRepresentPerson FormsRepresentPersonfrm = new FormsRepresentPerson();
            FormsRepresentPersonfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsRepresentPersonfrm);
            FormsRepresentPersonfrm.Show();
            
        }

        private void lblChangePerson_Click(object sender, EventArgs e)
        {
            FormsLegalPerson FormsLegalPersonfrm = new FormsLegalPerson();
            FormsLegalPersonfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsLegalPersonfrm);
            FormsLegalPersonfrm.Show();
           
        }

        private void lblOwner_Click(object sender, EventArgs e)
        {
            FormsLicenseChange FormsLicenseChangefrm = new FormsLicenseChange();
            FormsLicenseChangefrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsLicenseChangefrm);
            FormsLicenseChangefrm.Show();

        }

        private void lblKwPassport_Click(object sender, EventArgs e)
        {
            FormsMakePassport FormsMakePassportfrm = new FormsMakePassport();
            FormsMakePassportfrm.TopLevel = false;
            ClearPanel();
            this.Panel2.Controls.Add(FormsMakePassportfrm);
            FormsMakePassportfrm.Show();
            
        }

        private void EmpForms_Load(object sender, EventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}