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
    public partial class EmpSalRpt : DockContent
    {
        public string title = "";
        public int choiceNum = 0;

      private Nullable<long> DeptCode   =  null ;
      private Nullable<int> EmpCode   =  null ;
      //private Nullable<int> ProductId = null;
      //private Nullable<int> StoreId = null;
       
  

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();

        public EmpSalRpt()
        {
            InitializeComponent();
        }

      

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.CDE_MONTHS' table. You can move, or remove it, as needed.
            this.cDE_MONTHSTableAdapter.Fill(this.personalDataSet.CDE_MONTHS);

            txtYEARCODE.Text = DateTime.Today.Year.ToString();
            cmbMonth.SelectedValue = DateTime.Today.Month.ToString();
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


            if (GLibrary.IsNumeric(txtYEARCODE.Text) &&  cmbMonth.SelectedValue !=null)
            {

                if (cmbDepts.SelectedValue != null) { DeptCode = long.Parse(cmbDepts.SelectedValue.ToString()); }
                if (cmbEmpName.SelectedValue != null) { EmpCode = int.Parse(cmbEmpName.SelectedValue.ToString()); }

                // if (CmbStores.SelectedValue != null) { StoreId = int.Parse(CmbStores.SelectedValue.ToString()); }

                ShowEmpRpt frm = new ShowEmpRpt();



                //frm.choiceNum = 2;
                frm.choiceNum = choiceNum;
                int CurMonth=int.Parse (cmbMonth.SelectedValue.ToString());
                int CurYear=int.Parse (txtYEARCODE.Text);
                int NofDaysInMonth; //= DateTime.DaysInMonth(CurYear, CurMonth);
            
                NofDaysInMonth = DateTime.DaysInMonth(CurYear, CurMonth);
                int NofFirdays = GetNoFirday(CurMonth, CurYear);
                NofDaysInMonth = NofDaysInMonth - NofFirdays;
                frm.NofDaysInMonth = NofDaysInMonth;

                frm.Month = cmbMonth.Text ;
                frm.Year = txtYEARCODE.Text;
                this.pRL_EMP_SAL_CALCULATIONTableAdapter.FillByParam(this.personalDataSet.PRL_EMP_SAL_CALCULATION, EmpCode, DeptCode, CurMonth, CurYear);
               
                //this.absence_ViewTableAdapter.FillByParam(this.personalDataSet.Absence_View, EmpCode, DeptCode, FromDate, ToDate);
                //invoiceViewTableAdapter.FillByParam  (nEWERPDataSet.InvoiceView ,BranchId,CustSupId, frm.FromDate, frm.ToDate);

                frm.personalDataSet = personalDataSet;

                frm.ShowDialog(this);
            }
           
            else
            {
                MessageBox.Show("«œŒ· «·”‰Â Ê«·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·—Ê« »", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        
           
        }
        private int GetNoFirday(int m_Month, int m_Year)
        {
            int Fridays = 0;

            DateTime dt = new DateTime(m_Year, m_Month, 1);
            while (dt.Month == m_Month)
            {
                if (dt.DayOfWeek == DayOfWeek.Friday)
                    Fridays++;
                dt = dt.AddDays(1);
            }
            return (Fridays);

        }
        

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

      

       

      

      

      

      
      

     
      

       

       

        
    }
}