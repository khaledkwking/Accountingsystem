using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class CustSupAdd : Form
    {
        public int CustSupType;
        public String CustSupName;
        public string AccCode;
        public string AccId;
        
        public CustSupAdd()
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
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
                      

        }
        public  void FillData()
        {
                 this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
                // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
                this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
                LoadData();
        }
  
       

        private void CmdAdd_Click(object sender, EventArgs e)
        {
           
        }
             
        private void LoadData()
        {
            switch (CustSupType)
            {

                case 1:
                   
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        SupradioBtn.Text = "ãæÇÑÏ ÝÞØ";
                        this.Text = "ÊÍÑíÑ ãæÑÏ";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        SupradioBtn.Text = "òSup Only";
                        this.Text = "Supplier";
                    }
                    break;
                case 2:
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        SupradioBtn.Text = "Úãíá ÝÞØ";
                        this.Text = "ÊÍÑíÑ Úãíá";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        SupradioBtn.Text = "òCust Only";
                        this.Text = "Customer";
                    }
                

                    break;
                case 3:
                    break;
            }

            sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_TYPE = " + Messages.CustSupFlag + " Or SUP_CUST_TYPE = " + CustSupType.ToString();
                      
            txtCustSuptype.Text = CustSupType.ToString();
            txtSUP_CUST_CODE.Focus();
        }
        public  void AddNewCust()
        {
                
            sUPPLIERSCUSTOMERSBindingSource.AddNew();
            txtCustSuptype.Text = CustSupType.ToString();
            int LastIden = int.Parse(sUPPLIERS_CUSTOMERSTableAdapter.GetCustSupIdent ().ToString ());//.ToString () ;
            txtSUP_CUST_CODE.Text = nEWERPDataSet.SetupCodes.Rows[0]["SupCode"].ToString() + LastIden.ToString("000000");

        }
        public void CancelAdding()
        {
            sUPPLIERSCUSTOMERSBindingSource.CancelEdit();
        }
        public void SaveData()
        {

            sUPPLIERSCUSTOMERSBindingSource.EndEdit();
            sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS);

        }
        public Boolean CheckCust(int AccountId)
        {
            FillData();
            sUPPLIERSCUSTOMERSBindingSource.Filter = "AccountId = " + AccountId.ToString ();
            if (sUPPLIERSCUSTOMERSBindingSource.List.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
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

        private void CustSupAdd_Activated(object sender, EventArgs e)
        {
            FillData();
        }

       

        

       

        
    }
}