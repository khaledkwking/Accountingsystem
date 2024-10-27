using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WeifenLuo.WinFormsUI;
using ERPSYS.Reports;
namespace ERPSYS
{
    public partial class EMPPayRal : DockContent
    {
       
        public decimal LastIden = -1;
        private StaticList slGenderTypes = new StaticList(GLibrary.strarrGenderTypes);
        private StaticList slMalStatusType = new StaticList(GLibrary.strarrMalStatusType);
        public Boolean EditFlagABS = false;
        public Boolean EditFlagVAC= false;
        public Boolean EditFlagLoan = false;
        public Boolean EditFlagDisc = false;
        private Nullable<int> EmpCode = null;
        private int NofDaysInMonth;
        private DateTime lastDataError = DateTime.MinValue;

        public EMPPayRal()
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
            //invProductsBindingSource.CancelEdit();
            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.
            this.pER_EMP_VACATIONTableAdapter.Fill(this.personalDataSet.PER_EMP_VACATION);
            // TODO: This line of code loads data into the 'personalDataSet.Emp_Groups' table. You can move, or remove it, as needed.
            this.emp_GroupsTableAdapter.Fill(this.personalDataSet.Emp_Groups);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
      
            cmbMonth.SelectedValue = DateTime.Today.Month.ToString();
            txtYEARCODE.Text = DateTime.Today.Year.ToString();

            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_SAL_CALCULATION' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'personalDataSet.PerEmpLoanDetailsReport' table. You can move, or remove it, as needed.
            this.perEmpLoanDetailsReportTableAdapter.Fill(this.personalDataSet.PerEmpLoanDetailsReport);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_Allowance' table. You can move, or remove it, as needed.
            this.pER_EMP_AllowanceTableAdapter.Fill(this.personalDataSet.PER_EMP_Allowance);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_ABSENCE' table. You can move, or remove it, as needed.
            this.pER_EMP_ABSENCETableAdapter.Fill(this.personalDataSet.PER_EMP_ABSENCE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.
            this.pRL_EMP_LOAN_DETAILTableAdapter.Fill(this.personalDataSet.PRL_EMP_LOAN_DETAIL);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.pER_EMP_DISCOUNTTableAdapter.Fill(this.personalDataSet.PER_EMP_DISCOUNT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
      
            this.cDE_MONTHSTableAdapter.Fill(this.personalDataSet.CDE_MONTHS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
          
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PER_EMP_DATA' table. You can move, or remove it, as needed.

            //CmbEmpGender.DataSource = slGenderTypes.ToDataTable();
            //CmbEmpMatStatus.DataSource = slMalStatusType.ToDataTable();
            txtYEARCODE.Text = DateTime.Today.Year.ToString ();
            cmbMonth.SelectedValue = DateTime.Today.Month.ToString();
            Search();

        }

        private void pEREMPLOYEEDATABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {

                FilterALL();

            }
        }
        private void FilterALL()
        {
            if (pEREMPLOYEEDATABindingSource.Count == 1 && ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString() == "0")
            {
                ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"] = (Int64)(LastIden) + 1;
            }
            long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString());
            string Str = "";
            if (txtYEARCODE.Text != "")
            {
                Str = Str + " And YEAR_CODE=" + txtYEARCODE.Text;
            }
            if (cmbMonth.SelectedValue  != null)
            {
                Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue;
            }
            if (txtEmpCode.Text != "")
            {
                Str = Str + " And EMP_CODE=" + txtEmpCode.Text;
            }
            pEREMPABSENCEBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString() + Str; // "And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text;
            pEREMPDISCOUNTBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString() + Str; //"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text;
            pRLEMPLOANDETAILBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString();// +Str;//+ "And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; ;
            pER_EMP_AllowanceBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString() + Str;//"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; 
            pER_EMP_VACATIONBindingSource.Filter = "EMP_CODE= " + EMPCODE.ToString() + Str;//"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; 

            if (pRLEMPLOANDETAILBindingSource.Count > 0)
            {
                long LoanId = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanId"].ToString());

                MakeFilter(LoanId);

            }

        }
        private void pRLEMPLOANDETAILBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //string Str = "";
            //if (txtYEARCODE.Text != "")
            //{
            //    Str = Str + " And YEAR_CODE=" + txtYEARCODE.Text;
            //}
            //if (txtMONTHCODE.Text != "")
            //{
            //    Str = Str + " And MONTH_CODE=" + txtMONTHCODE.Text;
            //}
            if (pRLEMPLOANDETAILBindingSource.Count > 0)
            {
                long LoanId = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanId"].ToString());

                MakeFilter(LoanId);

            }
        }
        private void MakeFilter(long LoanId)
        {
            string Str = "";
            if (txtYEARCODE.Text != "")
            {
                Str = Str + " And YEAR_CODE=" + txtYEARCODE.Text;
            }
            if (cmbMonth.SelectedValue != null)
            {
                Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue;
            }
            if (pRLEMPLOANDETAILBindingSource.Count > 0)
            {
                //long LoanId = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanId"].ToString());
                perEmpLoanDetailsReportBindingSource.Filter = "LoanId= " + LoanId.ToString() + Str; //"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; 


            }
        }
        private int GetNoFirday(int m_Month,int m_Year)
        {
            int Fridays = 0; 
          
            DateTime  dt = new DateTime(m_Year, m_Month, 1);
            while (dt.Month == m_Month)
            {
                if (dt.DayOfWeek == DayOfWeek.Friday)
                    Fridays++;
                dt = dt.AddDays(1);
            }
            return (Fridays);

        }
        private void CmdGetSalary_Click(object sender, EventArgs e)
        {
           
            if (GLibrary.IsNumeric(txtYEARCODE.Text) && cmbMonth.SelectedValue !=null)
            {
                string Str = "";
               

                if (txtYEARCODE.Text != "")
                {
                    Str = Str + " And YEAR_CODE=" + txtYEARCODE.Text;
                }
                if (cmbMonth.SelectedValue != null)
                {
                    Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue.ToString ();
                }

                int Year = int.Parse(txtYEARCODE.Text);
                int month = int.Parse(cmbMonth.SelectedValue.ToString());
               

                int RowCount = pEREMPLOYEEDATABindingSource.Count;
               
                for (int i = 0; i < RowCount; i++)
                {
                    decimal DiscountAmount = 0, AbseneceAmount = 0, LoanAmount = 0, AllowanceAmount = 0, BasicAmount = 0, AllowanceAmountPervMonth = 0, DiscountAmountPervMonth = 0, YearVacationNo = 0, OtherVacationNo = 0;
                    long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[i])["EMP_CODE"].ToString());
                   
                

                    pRLEMPSALCALCULATIONBindingSource.RemoveFilter();
                    pRLEMPSALCALCULATIONBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString() + Str;
                    if (pRLEMPSALCALCULATIONBindingSource.Count == 0)
                    {
                        pRLEMPSALCALCULATIONBindingSource.AddNew();
                        
                    }
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["EMP_CODE"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["EMP_CODE"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["DEPTCODE"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["DEPTCODE"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["YEAR_CODE"] = txtYEARCODE.Text;
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["MONTH_CODE"] = cmbMonth.SelectedValue.ToString();
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["BasicAmount"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["SALARY"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["GetAllow"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["GetAllow"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["PhoneAllow"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["PhoneAllow"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["TransAllow"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["TransAllow"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["InsuranceValue"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["InsuranceValue"];


                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["FullName"] = ((DataRowView)pEREMPLOYEEDATABindingSource[i])["FullName"];
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["SalaryDate"] = new DateTime(int.Parse (txtYEARCODE.Text), int.Parse (cmbMonth.SelectedValue.ToString()), 1);
                    
                    if (((DataRowView)pEREMPLOYEEDATABindingSource.Current)["SALARY"] != DBNull.Value)
                    {
                        BasicAmount = decimal.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[i])["SALARY"].ToString());
                    }
                    DiscountSum(i, ref  DiscountAmount, ref  AbseneceAmount, ref  LoanAmount, ref  AllowanceAmount, ref AllowanceAmountPervMonth, ref DiscountAmountPervMonth, ref YearVacationNo, ref  OtherVacationNo);
                    if (DiscountAmount == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["DiscountAmount"] = DBNull .Value ;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["DiscountAmount"] = DiscountAmount;
                    }

                    if (AbseneceAmount == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AbseneceAmount"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AbseneceAmount"] = AbseneceAmount;
                    }
                    if (LoanAmount == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["LoanAmount"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["LoanAmount"] = LoanAmount;
                    }
                    if (AllowanceAmountPervMonth == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AllowanceAmountPervMonth"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AllowanceAmountPervMonth"] = AllowanceAmountPervMonth;
                    }
                    if (DiscountAmountPervMonth == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["DiscountAmountPervMonth"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["DiscountAmountPervMonth"] = DiscountAmountPervMonth;
                    }

                    if (YearVacationNo == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["YearVacationNo"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["YearVacationNo"] = YearVacationNo;
                    }

                    if (OtherVacationNo == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["OtherVacationNo"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["OtherVacationNo"] = OtherVacationNo;
                    }
                    if (AllowanceAmount == 0)
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AllowanceAmount"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["AllowanceAmount"] = AllowanceAmount;
                    }
                                      
                   
                    ((DataRowView)pRLEMPSALCALCULATIONBindingSource.Current)["CALCULATION_AMOUNT"] = BasicAmount + AllowanceAmount - DiscountAmount - AbseneceAmount - LoanAmount;
                    pRLEMPSALCALCULATIONBindingSource.EndEdit();
                    //DiscountAmount
                    //AbseneceAmount
                    //LoanAmount
                    //AllowanceAmount
                    //CALCULATION_AMOUNT
                }
                pRL_EMP_SAL_CALCULATIONTableAdapter.Update(personalDataSet.PRL_EMP_SAL_CALCULATION);
                Str = "";
                if (txtYEARCODE.Text != "")
                {
                    Str = Str + "YEAR_CODE=" + txtYEARCODE.Text;
                }
                if (cmbMonth.SelectedValue  !=null)
                {
                    Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue.ToString ();
                }
                pRLEMPSALCALCULATIONBindingSource.Filter = Str;
                MessageBox.Show(" „ «Õ ”«» «·Ê« » »‰Ã«Õ", "«·—Ê« »", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }
            else
            {
                MessageBox.Show("«œŒ· «·”‰Â Ê«·‘Â— »ÿ—Ìﬁ… ’ÕÌÕ…", "«·—Ê« »", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
           
        }
        private void DiscountSum(int index, ref decimal DiscountAmount, ref decimal AbseneceAmount, ref decimal LoanAmount, ref decimal AllowanceAmount, ref decimal AllowanceAmountPervMonth, ref decimal DiscountAmountPervMonth, ref decimal YearVacationNo, ref decimal OtherVacationNo)
        {
            try
            {
                decimal WorkHourInDay = 0;
                decimal AbsenceHourPercentage = 0;
                decimal AbsenceDayPercentage = 0;

                DiscountAmount = 0;
                LoanAmount = 0;
                AbseneceAmount = 0;
                AllowanceAmount = 0;

                long EMPCODE = long.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[index])["EMP_CODE"].ToString());
              
                int GroupId = 0;

                if (((DataRowView)pEREMPLOYEEDATABindingSource[index])["EMP_CODE"] != DBNull.Value)
                {
                    GroupId = int.Parse(((DataRowView)pEREMPLOYEEDATABindingSource[index])["GroupId"].ToString());
                }

                int pos = emp_GroupsBindingSource.Find("GroupId", GroupId);
                if (pos > -1)
                {
                    if (((DataRowView)emp_GroupsBindingSource.Current)["WorkHour"] != DBNull.Value)
                    {
                        WorkHourInDay = decimal.Parse(((DataRowView)emp_GroupsBindingSource.Current)["WorkHour"].ToString());
                    }
                    if (((DataRowView)emp_GroupsBindingSource.Current)["AbsenceHourPercentage"]!=DBNull .Value )
                    {
                        AbsenceHourPercentage = decimal.Parse(((DataRowView)emp_GroupsBindingSource.Current)["AbsenceHourPercentage"].ToString());
                    }
                    if (((DataRowView)emp_GroupsBindingSource.Current)["AbsenceDayPercentage"]!=DBNull.Value )
                    {
                          AbsenceDayPercentage = decimal.Parse(((DataRowView)emp_GroupsBindingSource.Current)["AbsenceDayPercentage"].ToString());
                    }
                  
                }

                string Str = "";
                if (txtYEARCODE.Text != "")
                {
                    Str = Str + " And YEAR_CODE=" + txtYEARCODE.Text;
                }
                if (cmbMonth.SelectedValue != null)
                {
                    Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue.ToString ();
                }
                pRLEMPLOANDETAILBindingSource.RemoveFilter();

                pEREMPABSENCEBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString() + Str; // "And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text;
                pEREMPDISCOUNTBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString() + Str; //"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text;
                pRLEMPLOANDETAILBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString(); //+ Str;//+ "And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; ;
                pER_EMP_AllowanceBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString() + Str;//"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; 
                pER_EMP_VACATIONBindingSource.Filter = "EMP_CODE=" + EMPCODE.ToString() + Str;//"And YEAR_CODE=" + txtYEARCODE.Text + "And MONTH_CODE=" + txtMONTHCODE.Text; 


                DataView list = (DataView)pEREMPABSENCEBindingSource.List;
                DataTable T = list.ToTable();      
                for (int i = 0; i < T.Rows.Count; i++)
                {
                    decimal  days = 0;
                    decimal Hours = 0;
                    decimal value=0;
                    decimal tot = 0;
                    if (GLibrary.IsNumeric(T.Rows[i]["HOURVALUE"].ToString()))
                    {
                        value = decimal.Parse(T.Rows[i]["HOURVALUE"].ToString ());
                        if (T.Rows[i]["DAYS_NUM"] != DBNull.Value)
                        {
                            days = decimal.Parse(T.Rows[i]["DAYS_NUM"].ToString());
                        }
                        if (T.Rows[i]["HOUR_NUM"] != DBNull.Value)
                        {
                            Hours = decimal.Parse(T.Rows[i]["HOUR_NUM"].ToString());
                        }
                        tot = (days * AbsenceDayPercentage * WorkHourInDay + Hours * AbsenceHourPercentage) * value;
                        AbseneceAmount = AbseneceAmount + tot;
                    }

                }
                long LoanId;

                DataView list1 = (DataView)pRLEMPLOANDETAILBindingSource.List;
                DataTable T1 = list1.ToTable();
                for (int j = 0; j < T1.Rows.Count; j++)
                {
                   
                    LoanId=long.Parse(T1.Rows[j]["LoanId"].ToString());
                    MakeFilter(LoanId);
                    list = (DataView)perEmpLoanDetailsReportBindingSource.List;
                    T = list.ToTable();

                    for (int i = 0; i < T.Rows.Count; i++)
                    {

                        if (GLibrary.IsNumeric(T.Rows[i]["LoanAmount"].ToString()))
                        {
                            LoanAmount = LoanAmount + decimal.Parse(T.Rows[i]["LoanAmount"].ToString());
                        }

                    }
                }

                 list = (DataView)pEREMPDISCOUNTBindingSource.List;
                 T = list.ToTable();

                for (int i = 0; i < T.Rows.Count; i++)
                {

                    Boolean bPervMonth = false;
                    if (T.Rows[i]["PervMonthFlag"] != DBNull.Value)
                    {
                        bPervMonth = Boolean.Parse(T.Rows[i]["PervMonthFlag"].ToString());

                    }
                    if (GLibrary.IsNumeric(T.Rows[i]["AMOUNT"].ToString()))
                    {
                        if (bPervMonth)
                        {
                            DiscountAmountPervMonth = DiscountAmountPervMonth + decimal.Parse(T.Rows[i]["AMOUNT"].ToString());
                        }
                        else
                        {
                            DiscountAmount = DiscountAmount + decimal.Parse(T.Rows[i]["AMOUNT"].ToString());
                        }

                    }
                
                }

                list = (DataView)pER_EMP_AllowanceBindingSource.List;
                T = list.ToTable();

                for (int i = 0; i < T.Rows.Count; i++)
                {
                    Boolean bPervMonth = false;
                    if (T.Rows[i]["PervMonthFlag"] != DBNull.Value)
                    {
                        bPervMonth = Boolean.Parse(T.Rows[i]["PervMonthFlag"].ToString());
                        
                    }
                    if (GLibrary.IsNumeric(T.Rows[i]["AMOUNT"].ToString()))
                    {
                        if (bPervMonth)
                        {
                            AllowanceAmountPervMonth = AllowanceAmountPervMonth + decimal.Parse(T.Rows[i]["AMOUNT"].ToString());
                        }
                        else
                        {
                            AllowanceAmount = AllowanceAmount + decimal.Parse(T.Rows[i]["AMOUNT"].ToString());
                        }

                    }
                }

                list = (DataView)pER_EMP_VACATIONBindingSource.List;
                T = list.ToTable();
                for (int i = 0; i < T.Rows.Count; i++)
                {
                    Boolean bPERIOD_FLAG =true; //«Ã«“… ”‰ÊÌ…
                    if (T.Rows[i]["PERIOD_FLAG"] != DBNull.Value)
                    {
                        bPERIOD_FLAG = Boolean.Parse(T.Rows[i]["PERIOD_FLAG"].ToString());

                    }
                    if (GLibrary.IsNumeric(T.Rows[i]["Netdays"].ToString()))
                    {
                        if (bPERIOD_FLAG)
                        {
                            YearVacationNo = YearVacationNo + decimal.Parse(T.Rows[i]["Netdays"].ToString());
                        }
                        else
                        {
                            OtherVacationNo = OtherVacationNo + decimal.Parse(T.Rows[i]["Netdays"].ToString());
                        }

                    }
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        private void txtMONTHCODE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }

        }
        private void Search()
        {
            if (GLibrary.IsNumeric(txtYEARCODE.Text) && cmbMonth.SelectedValue !=null )
            {
               
                string Str = "";
                int curMonth = DateTime.Today.Month ;
                int CurYear = DateTime.Today.Year;
                if (txtYEARCODE.Text != "")
                {
                    Str = Str + "YEAR_CODE=" + txtYEARCODE.Text;
                    CurYear = int.Parse(txtYEARCODE.Text);
                   
                }
                if (cmbMonth.SelectedValue != null)
                {
                    Str = Str + " And MONTH_CODE=" + cmbMonth.SelectedValue.ToString();
                    curMonth = int.Parse(cmbMonth.SelectedValue.ToString());
                }
              
                if (txtEmpCode.Text != "")
                {
                    Str = Str + " And EMP_CODE=" + txtEmpCode.Text;
                    EmpCode = int.Parse(txtEmpCode.Text);
                }
                else
                {
                    EmpCode = null;
                }

                DateTime FromDate = new DateTime(CurYear, curMonth, 1);
                DateTime ToDate = new DateTime(CurYear, curMonth, DateTime.DaysInMonth(CurYear,curMonth) );

                this.pRL_EMP_SAL_CALCULATIONTableAdapter.FillByParam(this.personalDataSet.PRL_EMP_SAL_CALCULATION, EmpCode, null, FromDate, ToDate);
                pRLEMPSALCALCULATIONBindingSource.Filter = Str;
                if (pEREMPLOYEEDATABindingSource.Count > 0)
                {
                    FilterALL();
                 

                }
            }
        }

        private void txtYEARCODE_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void CmdMoveSalary_Click(object sender, EventArgs e)
        {

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (pRLEMPSALCALCULATIONBindingSource.Count > 0)
            {
                if (GLibrary.IsNumeric(txtYEARCODE.Text) && cmbMonth.SelectedValue != null)
                {
                    int Year = int.Parse(txtYEARCODE.Text);
                    int month = int.Parse(cmbMonth.SelectedValue.ToString());
                     NofDaysInMonth = DateTime.DaysInMonth(Year, month);
                    int NofFirdays = GetNoFirday(month, Year);
                    NofDaysInMonth = NofDaysInMonth - NofFirdays;

                    Search();
                    ShowEmpRpt frm = new ShowEmpRpt();
                    frm.Month = cmbMonth.Text;
                    frm.Year = txtYEARCODE.Text;
                    frm.NofDaysInMonth  = NofDaysInMonth;
                    //frm.FromDate = new DateTime(int.Parse(txtYEARCODE.Text), int.Parse(cmbMonth.SelectedValue.ToString()), 1);
                    //frm.ToDate = new DateTime(int.Parse(txtYEARCODE.Text), int.Parse(cmbMonth.SelectedValue.ToString()), 30);

                    frm.choiceNum = 2;
                    frm.personalDataSet = personalDataSet;
                    //frm.MdiParent = this;
                    frm.ShowDialog();
                    frm.Focus();
                }
            }
            else
            {
                MessageBox.Show("ﬂ‘› «·„ÊŸ›Ì‰ ›«—€ ·« Ì„ﬂ‰ ⁄—÷ «· ﬁ—Ì—", "«·„ÊŸ›Ì‰", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }

        }
        private void cmbMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void txtEmpCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
       
        

        
 
     


      
    
