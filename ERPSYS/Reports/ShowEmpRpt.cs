using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowEmpRpt : Form
    {
        public DateTime ToDate;
        public DateTime  FromDate;
        public string EmpName = "";
        public string Year;
        public string Month;

        public NEWERPDataSet nEWERPDataSet;
        public PersonalDataSet personalDataSet=new PersonalDataSet ();
        public int choiceNum;
        public int NofDaysInMonth;
        public ShowEmpRpt()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
        this.setupTableAdapter.Fill(this.personalDataSet.setup);
        //Dim rentDSet As New rentDataSet()
        //Dim ReciteViewTableAdapter As New Wi
        //QidOutRpt rpt =new QidOutRpt();;

        CrystalDecisions.Shared.ParameterDiscreteValue disValFromDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValToDate = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disValYear = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValMonth = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disDaysInMonth = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disEmpName= new CrystalDecisions.Shared.ParameterDiscreteValue();
            
        switch  (choiceNum)
        {
            case 1:
                PerEmpDataRpt rpt = new PerEmpDataRpt();
                crystalReportViewer1.Visible = true;
                rpt.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt;
               
                break;
            case 2:
                PerEmpMonthSalRpt rpt1 = new PerEmpMonthSalRpt();
                crystalReportViewer1.Visible = true;
                disValYear.Value =Year ;
                disValMonth.Value = Month;
                disDaysInMonth.Value = NofDaysInMonth;
                //disValFromDate.Value = FromDate;
                //disValToDate.Value = ToDate;

                rpt1.Parameter_Year.CurrentValues.Add(disValYear);
                rpt1.Parameter_Month.CurrentValues.Add(disValMonth);
                rpt1.Parameter_DaysInMonth.CurrentValues.Add(disDaysInMonth);
           
                


                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;
                rpt1.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt1;
                break;
            case 3:
                PerEmpLoansRpt rpt3 = new PerEmpLoansRpt();
                crystalReportViewer1.Visible = true;
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;

                rpt3.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt3.Parameter_ToDate.CurrentValues.Add(disValToDate);


                crystalReportViewer1.ParameterFieldInfo = rpt3.ParameterFields;
                rpt3.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt3;
                break;
            case 4:
                PerEmpAbsenceRpt rpt4 = new PerEmpAbsenceRpt();
                crystalReportViewer1.Visible = true;
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;

                rpt4.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt4.Parameter_ToDate.CurrentValues.Add(disValToDate);


                crystalReportViewer1.ParameterFieldInfo = rpt4.ParameterFields;
                rpt4.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt4;
                break;
            case 5:
                PerEmpDiscountRpt rpt5 = new PerEmpDiscountRpt();
                crystalReportViewer1.Visible = true;
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;

                rpt5.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt5.Parameter_ToDate.CurrentValues.Add(disValToDate);


                crystalReportViewer1.ParameterFieldInfo = rpt5.ParameterFields;
                rpt5.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt5;
                break;
            case 6:
                PerEmpAllowanceRpt rpt6 = new PerEmpAllowanceRpt();
                crystalReportViewer1.Visible = true;
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;

                rpt6.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt6.Parameter_ToDate.CurrentValues.Add(disValToDate);


                crystalReportViewer1.ParameterFieldInfo = rpt6.ParameterFields;
                rpt6.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt6;
                break;
                case 7:
                PerEmpVactionsRpt rpt7= new PerEmpVactionsRpt();
                crystalReportViewer1.Visible = true;
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;

                rpt7.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt7.Parameter_ToDate.CurrentValues.Add(disValToDate);


                crystalReportViewer1.ParameterFieldInfo = rpt7.ParameterFields;
                rpt7.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt7;
                break;
            case 8:
                PerEmpMonthSalRpt rpt8 = new PerEmpMonthSalRpt();
                crystalReportViewer1.Visible = true;
                //disValFromDate.Value = FromDate;
                //disValToDate.Value = ToDate;

                disValYear.Value = Year;
                disValMonth.Value = Month;
                //disValFromDate.Value = FromDate;
                //disValToDate.Value = ToDate;

                rpt8.Parameter_Year.CurrentValues.Add(disValYear);
                rpt8.Parameter_Month.CurrentValues.Add(disValMonth);


                crystalReportViewer1.ParameterFieldInfo = rpt8.ParameterFields;
                rpt8.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt8;
                break;
                  case 9:
               PerEmpRelativeDataRpt rpt9 = new PerEmpRelativeDataRpt();
                crystalReportViewer1.Visible = true;
                //disValFromDate.Value = FromDate;
                //disValToDate.Value = ToDate;

                disEmpName.Value = EmpName;
            
                //disValFromDate.Value = FromDate;
                //disValToDate.Value = ToDate;

                rpt9.Parameter_EmpName.CurrentValues.Add(disEmpName);
              


                crystalReportViewer1.ParameterFieldInfo = rpt9.ParameterFields;
                rpt9.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt9;
                break;
                
              
        }
       
        }

       
    }
}