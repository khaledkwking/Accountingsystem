using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowNewRpt : Form
    {
        public NEWERPDataSet nEWERPDataSet;
        public int choiceNum;
        public decimal TotalTo;
        public decimal TotalFrom;
        public decimal ValTotalSum;
        public string AccountName;
        //public Nullable<DateTime> ToDate = null;
        //public Nullable<DateTime> FromDate = null;
        public DateTime FromDate;
        public DateTime ToDate;
        public int AccLevel;
        public string Title = "";
        public ShowNewRpt()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {
        //Dim rentDSet As New rentDataSet()
        //Dim ReciteViewTableAdapter As New Wi
        //QidOutRpt rpt =new QidOutRpt();;
            CrystalDecisions.Shared.ParameterDiscreteValue disValTotalTo = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValTotalFrom = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();

            CrystalDecisions.Shared.ParameterDiscreteValue disValDateFromValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValDateToValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValAccountNameValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValAccLevel = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue disValTitle = new CrystalDecisions.Shared.ParameterDiscreteValue();


            switch (choiceNum)
        {
            case 1:

                RefBalanceSumRpt rpt = new RefBalanceSumRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;
                disValAccLevel.Value =AccLevel ;

                rpt.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt.Parameter_Level.CurrentValues.Add(disValAccLevel);

                rpt.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                rpt.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);


                crystalReportViewer1.ParameterFieldInfo = rpt.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt;

                break;
            case 7:

                RefBalanceCreditVerRpt rpt7 = new RefBalanceCreditVerRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;
                disValAccLevel.Value = AccLevel;

                rpt7.Parameter_Level.CurrentValues.Add(disValAccLevel);
                rpt7.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt7.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt7.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt7.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt7.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                rpt7.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);


                crystalReportViewer1.ParameterFieldInfo = rpt7.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt7.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt7;
                
            break;
        case 10:

            AccountTreeRpt rpt10 = new AccountTreeRpt();
            crystalReportViewer1.Visible = true;
            disValAccLevel.Value = AccLevel;

            rpt10.Parameter_Level.CurrentValues.Add(disValAccLevel);
          


            crystalReportViewer1.ParameterFieldInfo = rpt10.ParameterFields;

            //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
            rpt10.SetDataSource(nEWERPDataSet);
            crystalReportViewer1.ReportSource = rpt10;

            break;
            case 2:
                
                RefBalanceCreditRpt rpt1 = new RefBalanceCreditRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;
                disValAccLevel.Value = AccLevel;

                rpt1.Parameter_Level.CurrentValues.Add(disValAccLevel);
                rpt1.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt1.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt1.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt1.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt1.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);

              
                crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt1.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt1;
                
                     break;
            case 3:
                InvProductsAllRpt rpt2 = new InvProductsAllRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt2.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt2.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt2.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt2.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt2.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
              


                crystalReportViewer1.ParameterFieldInfo = rpt2.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt2.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt2;
                break;

                case 31:
                DailySalesRpt rpt31 = new DailySalesRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt31.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt31.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt31.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt31.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt31.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt31.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt31.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt31;
                break;
            case 32:
                DailySalesNewRpt rpt32 = new DailySalesNewRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt32.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt32.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt32.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt32.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt32.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt32.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt32.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt32;
                break;
            case 4:
                InvCheckProductsRpt rpt3 = new InvCheckProductsRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt3.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt3.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt3.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt3.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt3.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt3.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt3.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt3;
                break;

                case 44:
                InvCheckStoreProductsRpt rpt44 = new InvCheckStoreProductsRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt44.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt44.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt44.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt44.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt44.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt44.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt44.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt44;
                break;
                
            case 5:
                InvSalProductProfitRpt rpt4 = new InvSalProductProfitRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;

                rpt4.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt4.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt4.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt4.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt4.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt4.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt4.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt4;
                break;
            case 6:
                InvoiceRefRpt rpt5 = new InvoiceRefRpt();
                    //InvoiceRefTotalRpt rpt5 = new InvoiceRefTotalRpt();
                    disValTitle.Value = Title;
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                            
                rpt5.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt5.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                    rpt5.Parameter_Title .CurrentValues.Add(disValTitle);


                    crystalReportViewer1.ParameterFieldInfo = rpt5.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt5.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt5;
                
                break;
            case 66:
                //InvoiceRefRpt rpt5 = new InvoiceRefRpt();
                InvoiceRefTotalRpt rpt55 = new InvoiceRefTotalRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;

                rpt55.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt55.Parameter_ToDate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt55.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt55.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt55;

                break;
            case 8:

                IncomeList rpt8 = new IncomeList();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;
                disValAccLevel.Value = AccLevel;

                rpt8.Parameter_Level.CurrentValues.Add(disValAccLevel);
                rpt8.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt8.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt8.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt8.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt8.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                //rpt8.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);


                crystalReportViewer1.ParameterFieldInfo = rpt8.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt8.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt8;

                break;
            case 9:

                BudgetListRpt rpt9 = new BudgetListRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValAccountNameValue.Value = AccountName;
                disValAccLevel.Value = AccLevel;

                rpt9.Parameter_Level.CurrentValues.Add(disValAccLevel);
                rpt9.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt9.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt9.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt9.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt9.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                //rpt8.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);


                crystalReportViewer1.ParameterFieldInfo = rpt9.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt9.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt9;

                break;
            case 91:

                ProductStoresListRpt rpt91 = new ProductStoresListRpt();
                crystalReportViewer1.Visible = true;

                //disValTotalTo.Value = TotalTo;
                //disValTotalFrom.Value = TotalFrom;
                //disValTotalSum.Value = ValTotalSum;

                //disValDateFromValue.Value = FromDate;
                //disValDateToValue.Value = ToDate;
                //disValAccountNameValue.Value = AccountName;
                //disValAccLevel.Value = AccLevel;

                //rpt9.Parameter_Level.CurrentValues.Add(disValAccLevel);
                //rpt9.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                //rpt9.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                //rpt9.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                //rpt91.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                //rpt91.Parameter_ToDate.CurrentValues.Add(disValDateToValue);
                //rpt8.Parameter_AccountName.CurrentValues.Add(disValAccountNameValue);


                crystalReportViewer1.ParameterFieldInfo = rpt91.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt91.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt91;

                break;
        }
       
        }
    }
}