using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowEmpFormsRpt : Form
    {
        public DateTime ToDate;
        public DateTime  FromDate;
       
        public DateTime ApplyDate;
        public string ApplyNo;
        public string ApplyType;
        public string sCompanyName;
        public string Dinar;
        public string Fils;
        public string FileNo;
        public string Gov;
        public string GovContract;
        public string NewTitle;
        public string workOnwer;
        public string SignPerson;
        public string UsePeroid;

        public DateTime  StartDate;
        public DateTime EndDate;
        public string EmpName;
        public NEWERPDataSet nEWERPDataSet;
        public PersonalDataSet personalDataSet=new PersonalDataSet ();
        public int choiceNum;
        public ShowEmpFormsRpt()
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
        CrystalDecisions.Shared.ParameterDiscreteValue             disApplyDate= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disApplyNo= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disApplyType= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disCompanyName= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disDinar= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disFils= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disFileNo= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disGov= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disGovContract= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disNewTitle= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue                disworkOnwer= new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disSignPerson = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disUsePeroid = new CrystalDecisions.Shared.ParameterDiscreteValue();
        switch  (choiceNum)
        {
            case 1:
                HRResAddRenewRpt rpt1 = new HRResAddRenewRpt();
                crystalReportViewer1.Visible = true;
               
                disApplyDate.Value = ApplyDate;
                disApplyNo.Value = ApplyNo;
                disApplyType.Value = ApplyType;
                disCompanyName.Value = sCompanyName;
                disDinar.Value = Dinar;
                disFils.Value = Fils;
                disFileNo.Value = FileNo;
                disGov.Value = Gov;
                disGovContract.Value = GovContract;
                disNewTitle.Value = NewTitle;
                disworkOnwer.Value = workOnwer;
                disSignPerson.Value =SignPerson;
                disUsePeroid.Value = UsePeroid;
                rpt1.Parameter_ApplyDate.CurrentValues.Add(disApplyDate);
                rpt1.Parameter_ApplyNo.CurrentValues.Add(disApplyNo);
                rpt1.Parameter_ApplyType.CurrentValues.Add(disApplyType);
                rpt1.Parameter_CompanyName.CurrentValues.Add(disCompanyName);
                rpt1.Parameter_Dinar.CurrentValues.Add(disDinar);
                rpt1.Parameter_Fils.CurrentValues.Add(disFils);
                rpt1.Parameter_FileNo.CurrentValues.Add(disFileNo);
                rpt1.Parameter_Gov.CurrentValues.Add(disGov);
                rpt1.Parameter_GovContract.CurrentValues.Add(disGovContract);
                rpt1.Parameter_NewTitle.CurrentValues.Add(disNewTitle);
                rpt1.Parameter_workOnwer.CurrentValues.Add(disworkOnwer);
                rpt1.Parameter_SignPerson.CurrentValues.Add(disSignPerson);
                rpt1.Parameter_UsePeroid.CurrentValues.Add(disUsePeroid);

                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;
                //rpt1.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt1;
               
                break;
            case 2:
                 HRResContractRpt rpt2 = new HRResContractRpt();
                crystalReportViewer1.Visible = true;
                CrystalDecisions.Shared.ParameterDiscreteValue disStartDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disEndDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                disCompanyName.Value = sCompanyName;
                disDinar.Value = Dinar;
                disStartDate.Value =StartDate ;
                disEndDate .Value =EndDate ;
                disName .Value =EmpName;
               
                rpt2.Parameter_CompanyName.CurrentValues.Add(disCompanyName);
                rpt2.Parameter_Dinar.CurrentValues.Add(disDinar);

                rpt2.Parameter_StartDate.CurrentValues.Add(disStartDate);
                rpt2.Parameter_EndDate.CurrentValues.Add(disEndDate);
                rpt2.Parameter_Name.CurrentValues.Add(disName);
       

                crystalReportViewer1.ParameterFieldInfo = rpt2.ParameterFields;
                //rpt1.SetDataSource(personalDataSet);
                crystalReportViewer1.ReportSource = rpt2;

                break;
            case 3:
             
                break;
            case 4:
              
                break;
            case 5:
               
                break;
            case 6:
               
                break;
                case 7:
               
                break;
            case 8:
                
                break;
              
        }
       
        }

       
    }
}