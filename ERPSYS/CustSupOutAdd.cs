using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class CustSupOutAdd : Form
    {
        public int CustSupType;
        public String CustSupName;
        public string AccCode;
        public string AccId;
        public Int64 iCustSupId;
        public Boolean  EditFlag=true ;
        public string CustFname="";
        public CustSupOutAdd()
        {
            InitializeComponent();
        }

        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
           
            FillData();         

        }
        public  void FillData()
        {
                this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
                 this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
                // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
                this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);

                LoadData();
        }
  
      
             
        private void LoadData()
        {
            switch (CustSupType)
            {

                case 1:
                    SupradioBtn.Text = "„Ê«—œ ›ﬁÿ";
                    this.Text = " Õ—Ì— „Ê—œ";

                    break;
                case 2:
                    SupradioBtn.Text = "⁄„Ì· ›ﬁÿ";
                    this.Text = " Õ—Ì— ⁄„Ì·";

                    break;
                case 3:
                    break;
            }
            if (EditFlag)
            {
                sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID=" + iCustSupId.ToString();
                //txtCustSuptype.Text = CustSupType.ToString();
            }
            else
            {
                sUPPLIERSCUSTOMERSBindingSource.AddNew();
                txtCustSuptype.Text = CustSupType.ToString();
                int LastIden = int.Parse(sUPPLIERS_CUSTOMERSTableAdapter.GetCustSupIdent().ToString());//.ToString () ;
                long AccountId = LastIden * -1;
                txtAccountId.Text = AccountId.ToString();
                sUP_CUST_CODETextBox.Text = nEWERPDataSet.SetupCodes.Rows[0]["SupCode"].ToString() + LastIden.ToString("000000");
                txtSUP_CUST_FNAME.Text = CustFname;
            }
            txtSUP_CUST_FNAME.Focus();
            
        }
       
        public void CancelAdding()
        {
            sUPPLIERSCUSTOMERSBindingSource.CancelEdit();
        }
        public void SaveData()
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {
                    if (!GLibrary.ValidatetxtBox(errorProvider1, txtSUP_CUST_FNAME, "√œŒ· «”„ «·⁄„Ì· ", "«·⁄„·«¡", true))
                    {
                        return;
                    }
                    this.Validate();
                    sUPPLIERSCUSTOMERSBindingSource.EndEdit (); 
                    sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS);
                     GLibrary.MsgSave();
                     this.Close();
                }
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·⁄„·«¡ Ÿ «·„Ê«—œÌ‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }

        }
        
        private void SupradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SupradioBtn.Checked)
            {
                txtCustSuptype.Text = CustSupType.ToString();
            }
        }

        private void SupCustradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SupCustradioBtn.Checked )
            {
                    txtCustSuptype.Text = Messages.CustSupFlag; 
            }
        }

     
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

       

        

       

        
    }
}