using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS.Reports
{
    public partial class ShowProductsRpt : Form
    {
        public NEWERPDataSet nEWERPDataSet;
        public int choiceNum;
        public decimal TotalTo;
        public decimal TotalFrom;
        public decimal ValTotalSum;

        public string CustName;
        public string InvType;
        public decimal TotalSum;
        public decimal Discount;
        public decimal TotalNet;
        public string strTotalSum;
        public string strDiscount;
        public string strTotalNet;
        public DateTime InvDate;
        public string AccountName;
        public DateTime FromDate;
        public DateTime ToDate;
        public string InvTitle;

        
        public decimal Balance60;
        public decimal Balance30;
        public decimal Balance90;
        public decimal BalanceMore;
        public Boolean PrintFlag = false;
        public decimal  TotBeforeBlance;
        public int sumrpt = 1;
        public string AccountCode;
        public string Title = "";
        public string ToValueDesc = "";

        public string CustHomeName = "";
        public string Tel = "";
        public string Address = "";
        public string block = "";
        public string street = "";
        public string Gada = "";
        public string Buliding = "";
        public string Flat = "";
        public string House = "";
        public string Floor = "";
        public string Notes = "";
        public int choice = 1;
        public string costName="";
        public decimal InvPayment = 0;
        public decimal InvRemain = 0;
        public string CustBranch = "";
        public string CurUser = "";
        public string Percentage = "";
     
        public ShowProductsRpt()
        {
            InitializeComponent();
        }

        private void ShowRpt_Load(object sender, EventArgs e)
        {

            ShowReport();
          
        }
       
        
        public void ShowReport()
        {
            CrystalDecisions.Shared.ParameterDiscreteValue disValToBeforeBlance = new CrystalDecisions.Shared.ParameterDiscreteValue();

      CrystalDecisions.Shared.ParameterDiscreteValue disValTotalTo = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValTotalFrom = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValMainAccName = new CrystalDecisions.Shared.ParameterDiscreteValue();


        CrystalDecisions.Shared.ParameterDiscreteValue disValBalanceAll = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValBalance60 = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValBalance30 = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValBalance90 = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValBalanceMore = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disValDateFromValue = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValDateToValue = new CrystalDecisions.Shared.ParameterDiscreteValue();


        CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValInvDate = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValCurUser = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValAccountCode = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValTitle = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueToDesc = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disvalueTel =new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueAddress=new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueblock = new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvaluestreet =new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueGada = new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueBuliding=new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueFlat = new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueHouse = new CrystalDecisions.Shared.ParameterDiscreteValue(); 
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueFloor = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueNotes = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueCostName = new CrystalDecisions.Shared.ParameterDiscreteValue();

        CrystalDecisions.Shared.ParameterDiscreteValue disvaluePayment = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disvalueRemain = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValCustBranch = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disUserName1 = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disPercentage = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValUser = new CrystalDecisions.Shared.ParameterDiscreteValue();
        CrystalDecisions.Shared.ParameterDiscreteValue disValInvTitle = new CrystalDecisions.Shared.ParameterDiscreteValue();
        switch (choiceNum)
        {
            case 1:
                ProductStockRpt rpt = new ProductStockRpt();
                crystalReportViewer1.Visible = true;
                rpt.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt;

                break;
            case 10:
                ProductCreditStockRpt rpt10 = new ProductCreditStockRpt();
                crystalReportViewer1.Visible = true;
                rpt10.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt10;

                break;
            case 4:

                AccountSumDetRpt rpt4 = new AccountSumDetRpt();
                crystalReportViewer1.Visible = true;

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;
                disValMainAccName.Value = AccountName;
                disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");

                rpt4.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                rpt4.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt4.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt4.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt4.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt4.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
               

                crystalReportViewer1.ParameterFieldInfo = rpt4.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt4.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt4;

                break;
            case 2:
                if (sumrpt == 1)
                {
                    if (choice == 1)
                    {
                        AccountSumRpt rpt1 = new AccountSumRpt();
                        crystalReportViewer1.Visible = true;

                        disValTotalTo.Value = TotalTo;
                        disValTotalFrom.Value = TotalFrom;
                        disValTotalSum.Value = ValTotalSum;
                        disValMainAccName.Value = AccountName;
                        disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                        disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");
                        disValToBeforeBlance.Value = TotBeforeBlance;
                        disValCurUser.Value = Messages.CurUser;
                        disvalueToDesc.Value = ToValueDesc;
                        disvalueCostName.Value = costName;
                        rpt1.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                        rpt1.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                        rpt1.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                        rpt1.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                        rpt1.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                        rpt1.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                        rpt1.Parameter_TotBeforeBlance.CurrentValues.Add(disValToBeforeBlance);
                        rpt1.Parameter_PUser.CurrentValues.Add(disValCurUser);
                        rpt1.Parameter_ToValueDesc.CurrentValues.Add(disvalueToDesc);
                        rpt1.Parameter_CostName.CurrentValues.Add(disvalueCostName);

                        crystalReportViewer1.ParameterFieldInfo = rpt1.ParameterFields;

                        //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                        rpt1.SetDataSource(nEWERPDataSet);
                        crystalReportViewer1.ReportSource = rpt1;
                    }
                    else
                    {
                        AccountSumBankRpt rpt111 = new AccountSumBankRpt();
                        crystalReportViewer1.Visible = true;

                        disValTotalTo.Value = TotalTo;
                        disValTotalFrom.Value = TotalFrom;
                        disValTotalSum.Value = ValTotalSum;
                        disValMainAccName.Value = AccountName;
                        disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                        disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");
                        disValToBeforeBlance.Value = TotBeforeBlance;
                        disValCurUser.Value = Messages.CurUser;
                        disvalueToDesc.Value = ToValueDesc;

                        rpt111.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                        rpt111.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                        rpt111.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                        rpt111.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                        rpt111.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                        rpt111.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                        rpt111.Parameter_TotBeforeBlance.CurrentValues.Add(disValToBeforeBlance);
                        rpt111.Parameter_PUser.CurrentValues.Add(disValCurUser);
                        rpt111.Parameter_ToValueDesc.CurrentValues.Add(disvalueToDesc);

                        crystalReportViewer1.ParameterFieldInfo = rpt111.ParameterFields;

                        //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                        rpt111.SetDataSource(nEWERPDataSet);
                        crystalReportViewer1.ReportSource = rpt111;
                    }
                }
                else if (sumrpt == 2)
                {
                    disValTotalTo.Value = TotalTo;
                    disValTotalFrom.Value = TotalFrom;
                    disValTotalSum.Value = ValTotalSum;
                    disValMainAccName.Value = AccountName;
                    disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                    disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");
                    disValToBeforeBlance.Value = TotBeforeBlance;
                    disValAccountCode.Value = AccountCode;
                    disValCurUser.Value = Messages.CurUser;
                    AccountSumMainRpt rpt111 = new AccountSumMainRpt();
                    rpt111.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                    rpt111.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                    rpt111.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                    rpt111.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                    rpt111.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                    rpt111.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                    rpt111.Parameter_PUser.CurrentValues.Add(disValCurUser);

                    rpt111.Parameter_TotBeforeBlance.CurrentValues.Add(disValToBeforeBlance);
                    rpt111.Parameter_AccountCode.CurrentValues.Add(disValAccountCode);

                    crystalReportViewer1.ParameterFieldInfo = rpt111.ParameterFields;

                    //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                    rpt111.SetDataSource(nEWERPDataSet);
                    crystalReportViewer1.ReportSource = rpt111;
                }
                else if (sumrpt == 3)
                {

                    disValTotalTo.Value = TotalTo;
                    disValTotalFrom.Value = TotalFrom;
                    disValTotalSum.Value = ValTotalSum;
                    disValMainAccName.Value = AccountName;
                    disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                    disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");
                    disValToBeforeBlance.Value = TotBeforeBlance;
                    disValAccountCode.Value = AccountCode;
                    disValCurUser.Value = Messages.CurUser;
                    AccountSumMainMonthRpt rpt1111 = new AccountSumMainMonthRpt();
                    rpt1111.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                    rpt1111.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                    rpt1111.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                    rpt1111.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                    rpt1111.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                    rpt1111.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                    rpt1111.Parameter_PUser.CurrentValues.Add(disValCurUser);

                    rpt1111.Parameter_TotBeforeBlance.CurrentValues.Add(disValToBeforeBlance);
                    rpt1111.Parameter_AccountCode.CurrentValues.Add(disValAccountCode);

                    crystalReportViewer1.ParameterFieldInfo = rpt1111.ParameterFields;

                    //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                    rpt1111.SetDataSource(nEWERPDataSet);
                    crystalReportViewer1.ReportSource = rpt1111;
                }


                else
                {
                    disValTotalTo.Value = TotalTo;
                    disValTotalFrom.Value = TotalFrom;
                    disValTotalSum.Value = ValTotalSum;
                    disValDateFromValue.Value = FromDate.ToShortDateString();// ToString("dd/MM/yyyy");
                    disValDateToValue.Value = ToDate.ToShortDateString();// ToString("dd/MM/yyyy");

                    disValCurUser.Value = Messages.CurUser;
                    AccountSumCostCenterRpt rpt112 = new AccountSumCostCenterRpt();

                    rpt112.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                    rpt112.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                    rpt112.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                    rpt112.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                    rpt112.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                    rpt112.Parameter_PUser.CurrentValues.Add(disValCurUser);


                    crystalReportViewer1.ParameterFieldInfo = rpt112.ParameterFields;

                    //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                    rpt112.SetDataSource(nEWERPDataSet);
                    crystalReportViewer1.ReportSource = rpt112;
                }

                break;
            case 3:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
               

                CurUser = Messages.CurName;
                InvoiceRpt rpt2 = new InvoiceRpt();
                disValUser.Value = CurUser;

                crystalReportViewer1.Visible = true;
                disValCustBranch.Value = CustHomeName;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;
            
                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;
                disValInvTitle.Value = InvTitle;
                disPercentage.Value = Percentage;

                rpt2.Parameter_InvTitle.CurrentValues.Add(disValInvTitle);
                rpt2.Parameter_disPercentage.CurrentValues.Add(disPercentage);

                rpt2.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt2.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt2.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt2.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt2.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt2.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt2.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt2.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt2.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt2.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt2.Parameter_Remain.CurrentValues.Add(disvalueRemain);
                rpt2.Parameter_CustBranch.CurrentValues.Add(disValCustBranch);
                rpt2.Parameter_CurUser.CurrentValues.Add(disValUser);

                crystalReportViewer1.ParameterFieldInfo = rpt2.ParameterFields;

                rpt2.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt2;
                if (PrintFlag)
                {
                   
                    crystalReportViewer1.PrintReport();
                    
                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;
                    
                    //rpt2.PrintToPrinter(1, true, 0, 0);
                    
                }

                break;
            case 3000:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
               

                CurUser = Messages.CurName;
                InvoiceSalesReorderRpt rpt300 = new InvoiceSalesReorderRpt();
                disValUser.Value = CurUser;

                crystalReportViewer1.Visible = true;
                disValCustBranch.Value = CustHomeName;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;
                disValInvTitle.Value = InvTitle;
                disPercentage.Value = Percentage;

                rpt300.Parameter_InvTitle.CurrentValues.Add(disValInvTitle);
                rpt300.Parameter_disPercentage.CurrentValues.Add(disPercentage);

                rpt300.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt300.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt300.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt300.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt300.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt300.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt300.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt300.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt300.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt300.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt300.Parameter_Remain.CurrentValues.Add(disvalueRemain);
                rpt300.Parameter_CustBranch.CurrentValues.Add(disValCustBranch);
                rpt300.Parameter_CurUser.CurrentValues.Add(disValUser);

                crystalReportViewer1.ParameterFieldInfo = rpt300.ParameterFields;

                rpt300.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt300;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;
            case 330:
             


                InvoiceNewRpt rpt233 = new InvoiceNewRpt();
                crystalReportViewer1.Visible = true;
                disValCustBranch.Value = CustBranch;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;


                rpt233.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt233.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt233.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt233.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt233.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt233.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt233.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt233.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt233.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt233.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt233.Parameter_Remain.CurrentValues.Add(disvalueRemain);
                rpt233.Parameter_CustBranch.CurrentValues.Add(disValCustBranch);

                crystalReportViewer1.ParameterFieldInfo = rpt233.ParameterFields;

                rpt233.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt233;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;
            case 3301:


                InvoiceHomeNewRpt rpt3301 = new InvoiceHomeNewRpt();
                disUserName1.Value = Messages.CurUser;
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustHomeName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;



                disvalueTel.Value = Tel;
                disvalueAddress.Value = Address;
                disvalueblock.Value = block;
                disvaluestreet.Value = street;
                disvalueGada.Value = Gada;
                disvalueBuliding.Value = Buliding;
                disvalueFlat.Value = Flat;
                disvalueHouse.Value = House;
                disvalueFloor.Value = Floor;
                disvalueNotes.Value = Notes;

                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;

                rpt3301.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt3301.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt3301.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt3301.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt3301.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt3301.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt3301.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt3301.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt3301.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt3301.Parameter_UserName.CurrentValues.Add(disUserName1);


                rpt3301.Parameter_Tel.CurrentValues.Add(disvalueTel);
                rpt3301.Parameter_Area.CurrentValues.Add(disvalueAddress);
                rpt3301.Parameter_Block.CurrentValues.Add(disvalueblock);
                rpt3301.Parameter_Street.CurrentValues.Add(disvaluestreet);
                rpt3301.Parameter_Buliding.CurrentValues.Add(disvalueBuliding);
                rpt3301.Parameter_Flat.CurrentValues.Add(disvalueFlat);
                rpt3301.Parameter_House.CurrentValues.Add(disvalueHouse);
                rpt3301.Parameter_Floor.CurrentValues.Add(disvalueFloor);
                rpt3301.Parameter_Notes.CurrentValues.Add(disvalueNotes);
                rpt3301.Parameter_Gada.CurrentValues.Add(disvalueGada);

                rpt3301.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt3301.Parameter_Remain.CurrentValues.Add(disvalueRemain);

                crystalReportViewer1.ParameterFieldInfo = rpt3301.ParameterFields;

                rpt3301.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt3301;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }
                break;
            case 333:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disUserName = new CrystalDecisions.Shared.ParameterDiscreteValue();

                InvoiceRptSmall rpt333 = new InvoiceRptSmall();
                disUserName.Value = Messages.CurUser;
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value =InvRemain ;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;

                rpt333.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt333.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt333.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt333.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt333.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt333.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt333.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt333.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt333.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt333.Parameter_userName.CurrentValues.Add(disUserName);

                rpt333.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt333.Parameter_Remain .CurrentValues.Add(disvalueRemain);


                crystalReportViewer1.ParameterFieldInfo = rpt333.ParameterFields;

                rpt333.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt333;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }
                break;
            case 3355:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
               CrystalDecisions.Shared.ParameterDiscreteValue disUserNameRe = new CrystalDecisions.Shared.ParameterDiscreteValue();

                InvoiceRptReoderSmall rpt3355 = new InvoiceRptReoderSmall();
                disUserNameRe.Value = Messages.CurUser;
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;

                rpt3355.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt3355.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt3355.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt3355.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt3355.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt3355.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt3355.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt3355.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt3355.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt3355.Parameter_userName.CurrentValues.Add(disUserNameRe);

                rpt3355.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt3355.Parameter_Remain.CurrentValues.Add(disvalueRemain);


                crystalReportViewer1.ParameterFieldInfo = rpt3355.ParameterFields;

                rpt3355.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt3355;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }
                break;
            case 334:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
               

                InvoiceHomeRpt rpt334 = new InvoiceHomeRpt();
                disUserName1.Value = Messages.CurUser;
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustHomeName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;



               disvalueTel.Value  = Tel;
               disvalueAddress.Value =Address ;
               disvalueblock.Value = block ;
               disvaluestreet.Value =street ;
               disvalueGada.Value = Gada ;
               disvalueBuliding.Value = Buliding ;
               disvalueFlat.Value = Flat;
               disvalueHouse.Value = House ;
               disvalueFloor.Value = Floor ;
               disvalueNotes.Value = Notes ;

               disvaluePayment.Value = InvPayment;
               disvalueRemain.Value = InvRemain;

                rpt334.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt334.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt334.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt334.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt334.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt334.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt334.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt334.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt334.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt334.Parameter_UserName.CurrentValues.Add(disUserName1);


                rpt334.Parameter_Tel .CurrentValues.Add(disvalueTel);
                rpt334.Parameter_Area .CurrentValues.Add(disvalueAddress);
                rpt334.Parameter_Block .CurrentValues.Add(disvalueblock);
                rpt334.Parameter_Street .CurrentValues.Add(disvaluestreet);
                rpt334.Parameter_Buliding .CurrentValues.Add(disvalueBuliding);
                rpt334.Parameter_Flat .CurrentValues.Add(disvalueFlat);
                rpt334.Parameter_House .CurrentValues.Add(disvalueHouse);
                rpt334.Parameter_Floor .CurrentValues.Add(disvalueFloor);
                rpt334.Parameter_Notes .CurrentValues.Add(disvalueNotes);
                rpt334.Parameter_Gada.CurrentValues.Add(disvalueGada);

                rpt334.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt334.Parameter_Remain.CurrentValues.Add(disvalueRemain);

                crystalReportViewer1.ParameterFieldInfo = rpt334.ParameterFields;

                rpt334.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt334;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }
                break;

            case 30:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvDate = new CrystalDecisions.Shared.ParameterDiscreteValue();

                ReoderInvRpt rpt30 = new ReoderInvRpt();
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
              
               

             
                disValTotalNet.Value = TotalNet;
                disValstrTotalNet.Value = strTotalNet;
                disValInvDate.Value = InvDate;

                rpt30.Parameter_CustName.CurrentValues.Add(disValCustName);
         
                rpt30.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt30.Parameter_InvDate.CurrentValues.Add(disValInvDate);

                crystalReportViewer1.ParameterFieldInfo = rpt30.ParameterFields;

                rpt30.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt30;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;

            case 33:
                InvPriceListRpt rpt33 = new InvPriceListRpt();
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;

                rpt33.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt33.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt33.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt33.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt33.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt33.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt33.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt33.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt33.Parameter_InvDate.CurrentValues.Add(disValInvDate);

                crystalReportViewer1.ParameterFieldInfo = rpt33.ParameterFields;

                rpt33.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt33;
                if (PrintFlag)
                {
                   
                    crystalReportViewer1.PrintReport();
                    
                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;
                    
                    //rpt2.PrintToPrinter(1, true, 0, 0);
                    
                }

                break;
             
            case 5:

                AccountSumWithDauwanRpt rpt3 = new AccountSumWithDauwanRpt();
                crystalReportViewer1.Visible = true;

                //CrystalDecisions.Shared.ParameterDiscreteValue disValFrom = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvDate = new CrystalDecisions.Shared.ParameterDiscreteValue();

                disValTotalTo.Value = TotalTo;
                disValTotalFrom.Value = TotalFrom;
                disValTotalSum.Value = ValTotalSum;
                disValMainAccName.Value = AccountName;


                disValBalance60.Value = Balance60;
                disValBalance30.Value = Balance30;
                disValBalance90.Value = Balance90;
                disValBalanceMore.Value = BalanceMore;


                rpt3.Parameter_MainAccountName.CurrentValues.Add(disValMainAccName);
                rpt3.Parameter_TotalFrom.CurrentValues.Add(disValTotalFrom);
                rpt3.Parameter_TotalTo.CurrentValues.Add(disValTotalTo);
                rpt3.Parameter_TotalSum.CurrentValues.Add(disValTotalSum);

                rpt3.Parameter_Balance30.CurrentValues.Add(disValBalance30);
                rpt3.Parameter_Balance60.CurrentValues.Add(disValBalance60);
                rpt3.Parameter_Balance90.CurrentValues.Add(disValBalance90);
                rpt3.Parameter_BalanceMore.CurrentValues.Add(disValBalanceMore);

                crystalReportViewer1.ParameterFieldInfo = rpt3.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt3.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt3;

                break;
            case 6:

                CustomerSalesRpt rpt41 = new CustomerSalesRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValCustName.Value = CustName;
                rpt41.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt41.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                rpt41.Parameter_CustName.CurrentValues.Add(disValCustName);


                crystalReportViewer1.ParameterFieldInfo = rpt41.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt41.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt41;

                break;
                case 66:

               CustomerSupplierSalesRpt rpt42 = new CustomerSupplierSalesRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValTitle.Value = Title;

                rpt42.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt42.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                rpt42.Parameter_Title.CurrentValues.Add(disValTitle);



                crystalReportViewer1.ParameterFieldInfo = rpt42.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt42.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt42;

                break;
                
            case 7:

                ProductSalesRpt rpt5 = new ProductSalesRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                    disValCustName.Value = CustName;

                    rpt5.Parameter_CustName.CurrentValues.Add(disValCustName);

                    rpt5.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt5.Parameter_DateTo.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt5.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt5.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt5;

                break;
                case 78:

                    ProductPurchaseRpt rpt78 = new ProductPurchaseRpt();
                    crystalReportViewer1.Visible = true;

                    disValDateFromValue.Value = FromDate;
                    disValDateToValue.Value = ToDate;

                    rpt78.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                    rpt78.Parameter_DateTo.CurrentValues.Add(disValDateToValue);



                    crystalReportViewer1.ParameterFieldInfo = rpt78.ParameterFields;

                    //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                    rpt78.SetDataSource(nEWERPDataSet);
                    crystalReportViewer1.ReportSource = rpt78;

                    break;
                case 77:

                ProductSalesCustomersRpt rpt77 = new ProductSalesCustomersRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValTitle.Value = Title;
                 disValCustName.Value = CustName;

                    rpt77.Parameter_CustName.CurrentValues.Add(disValCustName);
                    rpt77.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt77.Parameter_DateTo.CurrentValues.Add(disValDateToValue);
                rpt77.Parameter_Title.CurrentValues.Add(disValTitle);
                    


                crystalReportViewer1.ParameterFieldInfo = rpt77.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt77.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt77;

                break;
            case 777:

                ProductSalesCustomersCostRpt rpt777 = new ProductSalesCustomersCostRpt();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;
                disValCustName.Value = CustName;

               rpt777.Parameter_CustName.CurrentValues.Add(disValCustName);

                rpt777.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                rpt777.Parameter_DateTo.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt777.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt777.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt777;

                break;
            case 8:
                A3marAlDuanPeroid rpt6 = new A3marAlDuanPeroid();
                crystalReportViewer1.Visible = true;

                disValDateFromValue.Value = FromDate;
                disValDateToValue.Value = ToDate;




                rpt6.Parameter_FromDate.CurrentValues.Add(disValDateFromValue);
                rpt6.Parameter_Todate.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt6.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt6.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt6;

                break;
            case 9:

                CustomersMove rpt7 = new CustomersMove();
                crystalReportViewer1.Visible = true;

                //disValDateFromValue.Value = FromDate;
                //disValDateToValue.Value = ToDate;

                //rpt7.Parameter_DateFrom.CurrentValues.Add(disValDateFromValue);
                //rpt7.Parameter_DateTo.CurrentValues.Add(disValDateToValue);



                crystalReportViewer1.ParameterFieldInfo = rpt7.ParameterFields;

                //rpt1.Parameter_AccountName.CurrentValues.Add(disValAccountName);
                rpt7.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt7;

                break;
            case 11:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvDate = new CrystalDecisions.Shared.ParameterDiscreteValue();

                OrderRpt rpt11 = new OrderRpt();
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;

                rpt11.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt11.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt11.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt11.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt11.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt11.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt11.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt11.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt11.Parameter_InvDate.CurrentValues.Add(disValInvDate);

                crystalReportViewer1.ParameterFieldInfo = rpt11.ParameterFields;

                rpt11.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt11;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;
            case 12:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvDate = new CrystalDecisions.Shared.ParameterDiscreteValue();

                MoveStockRpt rpt12 = new MoveStockRpt();
                crystalReportViewer1.Visible = true;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;

                rpt12.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt12.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt12.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt12.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt12.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt12.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt12.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt12.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt12.Parameter_InvDate.CurrentValues.Add(disValInvDate);

                crystalReportViewer1.ParameterFieldInfo = rpt12.ParameterFields;

                rpt12.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt12;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;
            case 13:
                //CrystalDecisions.Shared.ParameterDiscreteValue disValCustName = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvType = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValInvTotalSum = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrDiscount = new CrystalDecisions.Shared.ParameterDiscreteValue();
                //CrystalDecisions.Shared.ParameterDiscreteValue disValstrTotalNet = new CrystalDecisions.Shared.ParameterDiscreteValue();
                CrystalDecisions.Shared.ParameterDiscreteValue disValUser1 = new CrystalDecisions.Shared.ParameterDiscreteValue();

                CurUser = Messages.CurName;
                InvoiceReturnRpt rpt13 = new InvoiceReturnRpt();
                disValUser1.Value = CurUser;

                crystalReportViewer1.Visible = true;
                disValCustBranch.Value = CustHomeName;
                disValCustName.Value = CustName;
                disValInvType.Value = InvType;
                disValInvTotalSum.Value = TotalSum;

                disValDiscount.Value = Discount;
                disValTotalNet.Value = TotalNet;
                disValstrDiscount.Value = strDiscount;
                disValstrTotalNet.Value = strTotalNet;
                disValstrTotalSum.Value = strTotalSum;
                disValInvDate.Value = InvDate;
                disvaluePayment.Value = InvPayment;
                disvalueRemain.Value = InvRemain;


                rpt13.Parameter_CustName.CurrentValues.Add(disValCustName);
                rpt13.Parameter_InvType.CurrentValues.Add(disValInvType);
                rpt13.Parameter_Discount.CurrentValues.Add(disValDiscount);
                rpt13.Parameter_TotalSum.CurrentValues.Add(disValInvTotalSum);
                rpt13.Parameter_TotalNet.CurrentValues.Add(disValTotalNet);

                rpt13.Parameter_strTotalSum.CurrentValues.Add(disValstrTotalSum);
                rpt13.Parameter_strDiscount.CurrentValues.Add(disValstrDiscount);
                rpt13.Parameter_strTotalNet.CurrentValues.Add(disValstrTotalNet);
                rpt13.Parameter_InvDate.CurrentValues.Add(disValInvDate);
                rpt13.Parameter_Payment.CurrentValues.Add(disvaluePayment);
                rpt13.Parameter_Remain.CurrentValues.Add(disvalueRemain);
                rpt13.Parameter_CustBranch.CurrentValues.Add(disValCustBranch);
                rpt13.Parameter_CurUser.CurrentValues.Add(disValUser1);

                crystalReportViewer1.ParameterFieldInfo = rpt13.ParameterFields;

                rpt13.SetDataSource(nEWERPDataSet);
                crystalReportViewer1.ReportSource = rpt13;
                if (PrintFlag)
                {

                    crystalReportViewer1.PrintReport();

                    //     System.Drawing.Printing.PrintDocument printers =new  System.Drawing.Printing.PrintDocument() ;
                    //     string printername = printers.DefaultPageSettings.PrinterSettings.PrinterName;
                    //     rpt2.PrintOptions.PrinterName = printername;

                    //rpt2.PrintToPrinter(1, true, 0, 0);

                }

                break;
        }
        }
    }
}