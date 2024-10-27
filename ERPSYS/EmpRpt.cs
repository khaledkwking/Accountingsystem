using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class EmpRpt : DockContent
    {
        public string title = "";
        public int choiceNum = 0;

      private Nullable<long> DeptCode   =  null ;
      private Nullable<int> EmpCode   =  null ;
      //private Nullable<int> ProductId = null;
      //private Nullable<int> StoreId = null;
       
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();

        public EmpRpt()
        {
            InitializeComponent();
        }

      

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_SAL_CALCULATION' table. You can move, or remove it, as needed.
            //this.pRL_EMP_SAL_CALCULATIONTableAdapter.Fill(this.personalDataSet.PRL_EMP_SAL_CALCULATION);
            // TODO: This line of code loads data into the 'personalDataSet.Vacation_View' table. You can move, or remove it, as needed.
            //this.vacation_ViewTableAdapter.Fill(this.personalDataSet.Vacation_View);
            // TODO: This line of code loads data into the 'personalDataSet.Discount_View' table. You can move, or remove it, as needed.
            //this.discount_ViewTableAdapter.Fill(this.personalDataSet.Discount_View);
            // TODO: This line of code loads data into the 'personalDataSet.Loans_View' table. You can move, or remove it, as needed.
            //this.loans_ViewTableAdapter.Fill(this.personalDataSet.Loans_View);
            
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
            setupTableAdapter.Fill(nEWERPDataSet.setup);
            cmbDepts.SelectedIndex =-1;
            //}
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
                //CmbStores.SelectedIndex = -1;
             
               cmbEmpName.SelectedIndex = -1;
               this.Text = title;
             
            //}
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
               //if (Messages.Usertype != Messages.AdminUser)
               //{
               //    cmbDepts.SelectedValue = Messages.CurBranch;
               //    cmbDepts.Enabled = false;
               //}
               //else
               //{

               //}

                   
        }

        private void Search()
        {
            
            
             // if (pos > -1)
             // {
                  //if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
                  //{
                  //    accountingTableAdapter.FillByGetAccBalance(nEWERPDataSet.accounting, AccountId, BranchId, FromDate, ToDate);

                  //    StockDGView.Visible = false;
                  //    AccountDGView.Visible = true;
                  //    GetAccountSum();
                  //}
                  //else
                  //{
                  //nEWERPDataSet.accounting.Clear();
                  //nEWERPDataSet.AccountingView.Clear();
                  //GetDataLevel(int.Parse (AccountId.Value.ToString ()) );
                      //accountingViewTableAdapter.FillByAllAcc (nEWERPDataSet.AccountingView, AccountId, BranchId, FromDate, ToDate);
                     //StockDGView.Visible = true;
                      //AccountDGView.Visible = false;
                      //GetSum();
                 // }
             // }
        }
            

       

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

           
            DeptCode =null;
            EmpCode=null;
              
             
              
                  
             
              if (cmbDepts.SelectedValue != null) { DeptCode = long.Parse(cmbDepts.SelectedValue.ToString()); }
              if (cmbEmpName.SelectedValue != null) { EmpCode = int.Parse(cmbEmpName.SelectedValue.ToString()); }
             
             // if (CmbStores.SelectedValue != null) { StoreId = int.Parse(CmbStores.SelectedValue.ToString()); }

                  ShowEmpRpt frm = new ShowEmpRpt();
                                                  
                  if (txtFromDate.Text != "")
                  {
                      FromDate = DateTime.Parse(txtFromDate.Text);
                  }
                  else
                  {
                      FromDate = new DateTime(DateTime.Today.Year, 1, 1);
                  }
                  if (txtToDate.Text != "")
                  {
                      ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
                  }
                  else
                  {
                      ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
                  }
                    
                  frm.ToDate=ToDate.Value ;
                  frm.FromDate = FromDate.Value ;
                  frm.choiceNum = choiceNum;
                  switch (choiceNum)
                  {
                      case 3:
                          loans_ViewTableAdapter.FillByParam(this.personalDataSet.Loans_View, EmpCode, DeptCode, FromDate, ToDate);
                          break;
                      case 4:
                          this.absence_ViewTableAdapter.FillByParam(this.personalDataSet.Absence_View, EmpCode, DeptCode, FromDate, ToDate);
                          break;
                      case 5:
                          discount_ViewTableAdapter.FillByParam(this.personalDataSet.Discount_View , EmpCode, DeptCode, FromDate, ToDate);
                          break;
                     
                      case 6:
                          this.allowance_ViewTableAdapter.FillByParam (this.personalDataSet.Allowance_View , EmpCode, DeptCode, FromDate, ToDate);
                          break;
                      case 7:
                          this.vacation_ViewTableAdapter.FillByParam(this.personalDataSet.Vacation_View, EmpCode, DeptCode, FromDate, ToDate);
                          break;
                      case 8:
                          this.pRL_EMP_SAL_CALCULATIONTableAdapter.FillByParam (this.personalDataSet.PRL_EMP_SAL_CALCULATION , EmpCode, DeptCode, FromDate, ToDate);
                          break;
                  }
                  //this.absence_ViewTableAdapter.FillByParam(this.personalDataSet.Absence_View, EmpCode, DeptCode, FromDate, ToDate);
                  //invoiceViewTableAdapter.FillByParam  (nEWERPDataSet.InvoiceView ,BranchId,CustSupId, frm.FromDate, frm.ToDate);

                  frm.personalDataSet = personalDataSet;
                               
                    frm.ShowDialog(this);
            // }
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString ();//.ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

      

       

      

      

      

      
      

     
      

       

       

        
    }
}