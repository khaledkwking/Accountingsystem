using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class CustSupEdit : Form
    {
        public int CustSupType;
        public String CustSupName;
        public string AccCode;
        public string AccId;
        public Int64 iCustSupId;
        public Boolean  EditFlag=true ;
        public CustSupEdit()
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
                ChangeCustType();
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
           
                sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID=" + iCustSupId.ToString();
                //txtCustSuptype.Text = CustSupType.ToString();
          
           
             txtSUP_CUST_CODE.Focus();
            
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
                    ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current).EndEdit(); 
                    sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS);
                     GLibrary.MsgSave();
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
                ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_TYPE"] = CustSupType.ToString ();
                sUPPLIERSCUSTOMERSBindingSource.EndEdit();
            }
        }

        private void SupCustradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (SupCustradioBtn.Checked )
            {
                    txtCustSuptype.Text = Messages.CustSupFlag;
                    ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_TYPE"] = Messages.CustSupFlag;
                    sUPPLIERSCUSTOMERSBindingSource.EndEdit();
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

        private void sUPPLIERSCUSTOMERSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            ChangeCustType();

        }
        private void ChangeCustType()
        {
             if (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_TYPE"] != DBNull .Value )
            {
                int sel = int .Parse (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_TYPE"].ToString());
                if (sel.ToString () == Messages.CustSupFlag)
                {
                    SupCustradioBtn.Checked = true;
                }
                else
                {
                    SupradioBtn.Checked = true;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        

       

        
    }
}