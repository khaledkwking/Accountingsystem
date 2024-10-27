using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowRpt : Form
    {
        public string qidcode="";
        public string QidDate="";
        public string AccountName="";
        public string ToValue;
        public string ChequeNo;
        public string BankName="";
     
        public string Description="";
        public string Fils;
        public string Dinar;
        public int choiceNum;
        public decimal TotPrice;
        public string BankCode="";
        public string QidTypeDesc=""  ;
        public string QidEngTypeDesc="";

        public ShowRpt()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
         this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
        //Dim rentDSet As New rentDataSet()
        //Dim ReciteViewTableAdapter As New Wi
        //QidOutRpt rpt =new QidOutRpt();;
        CrystalDecisions.Shared.ParameterDiscreteValue disValqidcode = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValQidDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValAccountName = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValToValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValChequeNo = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValBankName = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValDescription = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValFils = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValDinar = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disTotPrice = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disBankCode = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disQidTypeDesc = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disQidEngTypeDesc = new CrystalDecisions.Shared.ParameterDiscreteValue();


        switch  (choiceNum)
        {
            case 1:
                QidOutRpt rpt = new QidOutRpt();
                disValqidcode.Value = qidcode;
                disValQidDate.Value = QidDate;
                disValAccountName.Value = AccountName;
                disValToValue.Value = ToValue;
                disValChequeNo.Value = ChequeNo;
                disValBankName.Value = BankName;
                disValDescription.Value = Description;
                disValFils.Value = Fils;
                disValDinar.Value = Dinar;
                disTotPrice.Value =TotPrice;
                disBankCode.Value =BankCode;
                disQidTypeDesc.Value =QidTypeDesc;
                disQidEngTypeDesc.Value = QidEngTypeDesc;

                rpt.Parameter_qidcode.CurrentValues.Add(disValqidcode);
                rpt.Parameter_QidDate.CurrentValues.Add(disValQidDate);
                rpt.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt.Parameter_ToValue.CurrentValues.Add(disValToValue);
                rpt.Parameter_ChequeNo.CurrentValues.Add(disValChequeNo);
                rpt.Parameter_BankName.CurrentValues.Add(disValBankName);
                rpt.Parameter_Description.CurrentValues.Add(disValDescription);
                rpt.Parameter_Fils.CurrentValues.Add(disValFils);
                rpt.Parameter_Dinar.CurrentValues.Add(disValDinar);

                rpt.Parameter_TotPrice .CurrentValues.Add(disTotPrice);

                rpt.Parameter_BankCode.CurrentValues.Add(disBankCode);

                rpt.Parameter_QidTypeEngDesc.CurrentValues.Add(disQidEngTypeDesc);
                rpt.Parameter_QidTypeDesc.CurrentValues.Add(disQidTypeDesc);


                //rpt.SetDataSource(nEWERPDataSet);

                crystalReportViewer1.ParameterFieldInfo = rpt.ParameterFields;
                rpt.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt;
            break;
            case 2:
                QidInRpt rpt1 = new QidInRpt();
                disValqidcode.Value = qidcode;
                disValQidDate.Value = QidDate;
                disValAccountName.Value = AccountName;
                disValToValue.Value = ToValue;
                disValChequeNo.Value = ChequeNo;
                disValBankName.Value = BankName;
                disValDescription.Value = Description;
                disValFils.Value = Fils;
                disValDinar.Value = Dinar;

               
                rpt1.Parameter_qidcode.CurrentValues.Add(disValqidcode);
                rpt1.Parameter_QidDate.CurrentValues.Add(disValQidDate);
                rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt1.Parameter_ToValue.CurrentValues.Add(disValToValue);
                rpt1.Parameter_ChequeNo.CurrentValues.Add(disValChequeNo);
                rpt1.Parameter_BankName.CurrentValues.Add(disValBankName);
                rpt1.Parameter_Description.CurrentValues.Add(disValDescription);
                rpt1.Parameter_Fils.CurrentValues.Add(disValFils);
                rpt1.Parameter_Dinar.CurrentValues.Add(disValDinar);

                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;
                rpt1.SetDataSource(nEWERPDataSet);
                //rpt.SetDataSource(rentDSet);
                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt1;
               
                break;
           
        }
       
        }
    }
}