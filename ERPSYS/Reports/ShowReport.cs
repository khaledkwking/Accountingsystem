using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowReport : Form
    {
       
        public string ValueDesc;
        public NEWERPDataSet nEWERPDataSet;
        public int choiceNum;
        public string TotalToValue;
        public string TotalFromValue;

        public string MoveId;
        public string STOREFromID;
        public string STOREToID;
        public string PRODUCTID ;
        public string UnitID ;
        public string MovmentQty ;
        public string EnterDate;
        public string ProdcutCode;
        public DateTime FromDate;
        public DateTime ToDate;
        
        public ShowReport()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet1.BRANCHES' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
       
        //Dim rentDSet As New rentDataSet()
        //Dim ReciteViewTableAdapter As New Wi
        //QidOutRpt rpt =new QidOutRpt();;
      
        CrystalDecisions.Shared.ParameterDiscreteValue disValDescription = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disToVal = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disFromVal = new CrystalDecisions.Shared.ParameterDiscreteValue();

        switch  (choiceNum)
        {
            case 1:
                QidRpt rpt = new QidRpt();
                
                crystalReportViewer1.Visible = true;

                disToVal.Value = TotalToValue;
                disFromVal.Value = TotalFromValue;
                disValDescription.Value = ValueDesc;
                //disValMainAccName.Value = AccountName;

                rpt.Parameter_ValueDesc.CurrentValues.Add(disValDescription);
                rpt.Parameter_FromValue.CurrentValues.Add(disFromVal);
                rpt.Parameter_ToValue.CurrentValues.Add(disToVal);
                //rpt.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);
                crystalReportViewer1.ParameterFieldInfo = rpt.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt;
              
            break;
            case 2:
               
                CrystalDecisions.Shared.ParameterDiscreteValue disValMoveId = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValSTOREFromID = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValSTOREToID = new CrystalDecisions.Shared.ParameterDiscreteValue();

                CrystalDecisions.Shared.ParameterDiscreteValue disValPRODUCTID = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValUnitID = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValMovmentQty = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValEnterDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValProductCode = new CrystalDecisions.Shared.ParameterDiscreteValue();

                StockMovmentRpt rpt1  = new StockMovmentRpt();
               // MoveStockRpt rpt1 = new MoveStockRpt();
                crystalReportViewer1.Visible = true;

                disValMoveId.Value = MoveId;
                disValSTOREFromID.Value = STOREFromID;
                disValSTOREToID.Value = STOREToID;
                disValPRODUCTID.Value = PRODUCTID;
                disValUnitID.Value = UnitID;
                disValMovmentQty.Value = MovmentQty;
                disValEnterDate.Value = EnterDate;
                disValProductCode.Value = ProdcutCode;
                //disValMainAccName.Value = AccountName;

                rpt1.Parameter_MoveId .CurrentValues.Add(disValMoveId);
                rpt1.Parameter_EnterDate.CurrentValues.Add(disValEnterDate);
                rpt1.Parameter_ProductName.CurrentValues.Add(disValPRODUCTID);
                rpt1.Parameter_Qty.CurrentValues.Add(disValMovmentQty);
                rpt1.Parameter_StoreFrom.CurrentValues.Add(disValSTOREFromID);
                rpt1.Parameter_StoreTo.CurrentValues.Add(disValSTOREToID);
                rpt1.Parameter_UnitDesc.CurrentValues.Add(disValUnitID);
                rpt1.Parameter_ProdcutCode.CurrentValues.Add(disValProductCode);

                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt1.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt1;
               
                break;
            case 3:

                CrystalDecisions.Shared.ParameterDiscreteValue disValDateFromValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValDateToValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
                InstallmentRpt rpt2 = new InstallmentRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;

                rpt2.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt2.Parameter_DateTo.CurrentValues.Add(disValDateToValue);


                crystalReportViewer1.ParameterFieldInfo = rpt2.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt2.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt2;

                break;
           
        }
       
        }

     
    }
}