using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class NewCustSupAdd : Form
    {
        public int CustSupType;
        public String CustSupName;
        public string AccCode;
        public string AccId;
        public Boolean  AddFlag=false ;
        public NewCustSupAdd()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
     
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.

            LoadData();

        }

  
        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            sUPPLIERSCUSTOMERSBindingSource.EndEdit();
            //nEWERPDataSet.AcceptChanges();
            sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            
                GLibrary.MsgSave();
                          
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewCust();
            
            if (SupCustradioBtn.Checked)
            {
                txtCustSuptype.Text  = Messages.CustSupFlag ;
            }
            else
            {
                switch (CustSupType)
                {
                    case 1:
                        if (SupradioBtn.Checked)
                        {
                            txtCustSuptype.Text = Messages.SupFlag ;
                        }
                        break;
                    case 2:
                        if (SupradioBtn.Checked)
                        {
                            txtCustSuptype.Text = Messages.CustFlag ;
                        }
                        break;

                }
            }
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            
            if (GLibrary.MsgCheckDel())
            {
                
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                sUPPLIERSCUSTOMERSBindingSource.RemoveCurrent();
                sUPPLIERSCUSTOMERSBindingSource.EndEdit();
                sUPPLIERS_CUSTOMERSTableAdapter.Update(nEWERPDataSet.SUPPLIERS_CUSTOMERS );
                
            }
            
        }

        private void CustSupAdd_Activated(object sender, EventArgs e)
        {
      
        }
        private void LoadData()
        {
            switch (CustSupType)
            {

                case 1:
                    SupradioBtn.Text = "ãæÇÑÏ ÝÞØ";
                    this.Text = "ÊÍÑíÑ ãæÑÏ";

                    break;
                case 2:
                    SupradioBtn.Text = "Úãíá ÝÞØ";
                    this.Text = "ÊÍÑíÑ Úãíá";

                    break;
                case 3:
                    break;
            }

            sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_TYPE = " + Messages.CustSupFlag + " Or SUP_CUST_TYPE = " + CustSupType.ToString();
            //if (sUPPLIERSCUSTOMERSBindingSource.List.Count == 0)
            //{
            //    AddNewCust();

            //}
            
            txtCustSuptype.Text = CustSupType.ToString();
            txtSUP_CUST_CODE.Focus();
        }
        public  void AddNewCust()
        {
            sUPPLIERSCUSTOMERSBindingSource.AddNew();
            int LastIden = int.Parse (txtSUP_CUST_ID.Text);//.ToString () ;
            txtSUP_CUST_CODE.Text = nEWERPDataSet.SetupCodes.Rows[0]["SupCode"].ToString() + LastIden.ToString("000000");

        }
        public Boolean CheckCust(int AccountId)
        {
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

       

        

       

        
    }
}