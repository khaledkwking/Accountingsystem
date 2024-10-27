using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowQidsRpt : Form
    {

        public string ToDate;
        public string FromDate;
        public string Tilte;
        public NEWERPDataSet nEWERPDataSet;
        public int choiceNum;

        public ShowQidsRpt()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
          // this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
        //Dim rentDSet As New rentDataSet()
        //Dim ReciteViewTableAdapter As New Wi
        //QidOutRpt rpt =new QidOutRpt();;
        CrystalDecisions.Shared.ParameterDiscreteValue disValFromDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValToDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValTitle = new CrystalDecisions.Shared.ParameterDiscreteValue();
    

        switch  (choiceNum)
        {
            case 1:
                QidsRpt rpt = new QidsRpt();
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;
                disValTitle.Value = Tilte;

                rpt.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt.Parameter_ToDate.CurrentValues.Add(disValToDate);
                rpt.Parameter_Desc.CurrentValues.Add(disValTitle);
                

                

                crystalReportViewer1.ParameterFieldInfo = rpt.ParameterFields;
                rpt.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt;
            break;
            case 2:
                QidsRpt rpt1 = new QidsRpt();
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;
                disValTitle.Value = Tilte;

                rpt1.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt1.Parameter_ToDate.CurrentValues.Add(disValToDate);
                rpt1.Parameter_Desc.CurrentValues.Add(disValTitle);


                
                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;
                rpt1.SetDataSource(nEWERPDataSet);

                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt1;

              
               
                break;
            case 3:
                QidsRpt rpt2= new QidsRpt();
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;
                disValTitle.Value = Tilte;

                rpt2.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt2.Parameter_ToDate.CurrentValues.Add(disValToDate);
                rpt2.Parameter_Desc.CurrentValues.Add(disValTitle);



                crystalReportViewer1.ParameterFieldInfo = rpt2.ParameterFields;
                rpt2.SetDataSource(nEWERPDataSet);

                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt2;

                break;
            case 4:
                QidsNEWRpt rpt3 = new QidsNEWRpt();
                disValFromDate.Value = FromDate;
                disValToDate.Value = ToDate;
                disValTitle.Value = Tilte;

                rpt3.Parameter_FromDate.CurrentValues.Add(disValFromDate);
                rpt3.Parameter_ToDate.CurrentValues.Add(disValToDate);
                rpt3.Parameter_Desc.CurrentValues.Add(disValTitle);



                crystalReportViewer1.ParameterFieldInfo = rpt3.ParameterFields;
                rpt3.SetDataSource(nEWERPDataSet);

                crystalReportViewer1.Visible = true;
                crystalReportViewer1.ReportSource = rpt3;

                break;
           
        }
       
        }
    }
}