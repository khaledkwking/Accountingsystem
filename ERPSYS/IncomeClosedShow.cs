using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;
namespace ERPSYS
{
    public partial class IncomeClosedShow : Form
    {
      private Nullable<long> BranchId   =  null ;
      private Nullable<long> AccountId   =  null ;
      private Nullable <DateTime> ToDate = null;
      private Nullable<DateTime> FromDate = null;
      private Nullable<long> CostId = null; 
      private DateTime FromDateB ;
      private DateTime ToDateB;
      private Boolean  bFlag=false ;

        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetTempOld = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetOSal = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetDiscount = new NEWERPDataSet();
        private string curYear;
        private NEWERPDataSet nEWERPDataSetNew = new NEWERPDataSet();
        private StaticList slRefBalanceType = new StaticList(GLibrary.strarrRefBalanceTypes);
        private int iActionType;
        private Boolean Editflag;
        public IncomeClosedShow()
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
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            Editflag = false;
            cmbYears.SelectedText = DateTime.Today.Year.ToString();
            curYear = DateTime.Today.Year.ToString();

            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            accountingBindingSource1.DataMember = "accounting";
            accountingBindingSource1.DataSource = nEWERPDataSet;


            accountingBindingSource.DataMember = "accounting";
            accountingBindingSource.DataSource = nEWERPDataSetNew;

            accountingBindingSourceTemp.DataMember = "accounting";
            accountingBindingSourceTemp.DataSource = nEWERPDataSetNew;

            this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);
            this.accountingTableAdapter.Fill(nEWERPDataSetTempOld.accounting);

            this.accountingTableAdapter.FillByAllAcc (this.nEWERPDataSet.accounting);

            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            qidsDetailsBindingSource.Filter = "ActionType=" + curYear + "3";
            qidsDetailsBindingSource1.Filter = "ActionType=" + curYear + "2";
            //qidsDetailsBindingSource2.Filter = "ActionType=" + curYear + "3";

           this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);

            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            bFlag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
          
         

          //qidsDetailsBindingSource.DataMember = "qidsDetails";
          //qidsDetailsBindingSource.DataSource = nEWERPDataSetNew;
        

        
        // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.

        // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
        this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
        // TODO: This line of code loads data into the 'nEWERPDataSet.StockView' table. You can move, or remove it, as needed.
        if (nEWERPDataSet.BRANCHES.Rows.Count > 0)
        {
            cmbBranch.SelectedIndex = 0;
        }
        //CmbRefTypes.DataSource = slRefBalanceType.ToDataTable();
        //if (CmbRefTypes.Items.Count > 0)
        //{
        //    CmbRefTypes.SelectedIndex = 0;
        //}
        bFlag = true;
        //accountingBindingSource1.Sort = "AccountName";
        //accountingBindingSource.Sort = "AccountName";
        //cmbAccount.SelectedValue = -1;
  
        //Search();
            if (qidsDetailsBindingSource.Count>0)
            {
                Editflag = true;
            }
        }

               
        private void Search()
        {
             curYear=cmbYears.Text ;
 
             qidsDetailsBindingSource.Filter = "ActionType=" + curYear + "3";
             qidsDetailsBindingSource1.Filter = "ActionType=" + curYear + "2";
             //qidsDetailsBindingSource2.Filter = "ActionType=" + curYear + "3";
             //if (qidsDetailsBindingSource.Count > 0)
             //{
             //    MessageBox.Show(" „ «€·ﬁ Â–Â «·”‰Â „‰ ﬁ»·", "«€·ﬁ «·”‰Â «·„«·Ì…", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
               
             //}
             //else
             //{
                 nEWERPDataSetTempOld.accounting.Clear();
                 BranchId = null;
                 AccountId = null;
                 ToDate = null;
                 FromDate = null;
                 txtFromDate.Text = "1/1/" + curYear;
                 FromDate = new DateTime(int.Parse(curYear), 1, 1);

                 txtToDate.Text = "31/12/" + curYear;
                 ToDate = DateTime.Parse(txtToDate.Text + " 23:59");


                 //if (cmbAccount.SelectedValue != null) { AccountId = long.Parse(cmbAccount.SelectedValue.ToString()); }
                 if (cmbBranch.SelectedValue != null) { BranchId = long.Parse(cmbBranch.SelectedValue.ToString()); }


                 ToDateB = new DateTime();
                 if (FromDate == null)
                 {
                     ToDateB = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");//DateTime.Today ;
                 }
                 else
                 {
                     DateTime temp = new DateTime();
                     temp = DateTime.Parse(FromDate.ToString());
                     ToDateB = temp.AddDays(-1);

                 }
                 if (FromDate == new DateTime(int.Parse(curYear), 1, 1))
                 {
                     FromDateB = ToDateB;
                 }
                 else
                 {
                     FromDateB = new DateTime(int.Parse(curYear), 1, 1);
                 }

                 int Level;// = int.Parse(nUpDownacc.Value.ToString());
                 //nEWERPDataSet.accounting.Clear();
                 decimal DiffTotalBalance = 0;
                 decimal IncomeTotalBalance = 0;
                 decimal PaymentsTotalBalance = 0;

                 // accountingTableAdapter.FillByRefBalance(nEWERPDataSet.accounting, Messages.Mainsalesaccid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                 //«·„»Ì⁄« 
                 //qidsBindingSource.CurrencyManager.AddNew();
                 //((DataRowView)qidsBindingSource.Current)["qidDate"] = "31/12/" + curYear;
                 //((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + curYear;
                 //((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[0, 0].ToString();
                 // ((DataRowView)qidsBindingSource.Current)["BrachId"]=Messages.CurBranch;
                 // ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[11, 0];


                 int iPos = qidsClosedBindingSource.Find("qidcode", "CQ" + (int.Parse(curYear)).ToString());
                 if (iPos > -1)
                 {
                     qidsClosedBindingSource.Position = iPos;
                 }
                 else
                 {
                     qidsClosedBindingSource.CurrencyManager.AddNew();
                 }

                 
                 ((DataRowView)qidsClosedBindingSource.Current)["qidDate"] = "31/12/" + curYear;
                 ((DataRowView)qidsClosedBindingSource.Current)["qidcode"] = "CQ" + curYear;
                 ((DataRowView)qidsClosedBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[0, 0].ToString();
                 ((DataRowView)qidsClosedBindingSource.Current)["BrachId"] = Messages.CurBranch;
                 ((DataRowView)qidsClosedBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[11, 0];

                iPos=qidsOpenBindingSource.Find ("qidcode","Q" + (int.Parse(curYear) + 1).ToString());
                if (iPos > -1)
                {
                    qidsOpenBindingSource.Position = iPos;
                }
                else
                {
                    qidsOpenBindingSource.CurrencyManager.AddNew();
                }
                 
                 ((DataRowView)qidsOpenBindingSource.Current)["qidDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                 ((DataRowView)qidsOpenBindingSource.Current)["qidcode"] = "Q" + (int.Parse(curYear) + 1).ToString();
                 ((DataRowView)qidsOpenBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[0, 0].ToString();
                 ((DataRowView)qidsOpenBindingSource.Current)["repeated"] = 1;
                 ((DataRowView)qidsOpenBindingSource.Current)["BrachId"] = Messages.CurBranch;
                 ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;

                 //«·„’«—Ì›/
                 accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, Messages.Paymentsaccid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                 if (nEWERPDataSetTempOld.accounting.Count > 0)
                 {
                     PaymentsTotalBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"].ToString());
                     if (PaymentsTotalBalance < -1)
                     {
                         PaymentsTotalBalance = PaymentsTotalBalance * -1;
                     }
                     nEWERPDataSetTempOld.accounting.Rows[0]["AccLevel"] = 0;
                     //nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                 }
                 //if (Level > 1)
                 //{
                 //    AddItem(int.Parse(Messages.Paymentsaccid.ToString()), Level);
                 //}
                 //«·«Ì—«œ« 
                 accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, Messages.MainSalesAccid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                 if (nEWERPDataSetTempOld.accounting.Count > 0)
                 {
                     IncomeTotalBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"].ToString());
                     if (IncomeTotalBalance < -1)
                     {
                         IncomeTotalBalance = IncomeTotalBalance * -1;
                     }
                     nEWERPDataSetTempOld.accounting.Rows[0]["AccLevel"] = 0;
                     //nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                 }
                 DiffTotalBalance = IncomeTotalBalance - PaymentsTotalBalance;

                            

                 int ProfitFlag = 0;
                 if (DiffTotalBalance > 0)
                 {
                     ProfitFlag = 1;

                 }
                 else
                 {
                     ProfitFlag = -1;
                 }
                 //decimal SumCredit = GetAccountSum(ref ProfitFlag);
                 int pos = qidsDetailsBindingSource.Find("ACCOUNTID", Messages.MovmentProfitsAccid);
                 if (ProfitFlag > 0) // —»Õ
                 {
                     iActionType = 3;
                     
                     if (pos > -1)
                     {
                         qidsDetailsBindingSource.Position = pos;
                         if (((DataRowView)qidsDetailsBindingSource.Current)["type"] != DBNull.Value)
                         {
                             if (((DataRowView)qidsDetailsBindingSource.Current)["type"].ToString() != curYear + "1")
                             {
                                 pos= qidsDetailsBindingSource.Find("type", curYear + "1");
                             }
                         }
                     }
                     else
                     {
                         qidsDetailsBindingSource.CurrencyManager.AddNew();
                     }
                     ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DBNull.Value;
                     ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = DiffTotalBalance;
                     ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.MovmentProfitsAccid;
                     ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                     ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                     ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                     ((DataRowView)qidsDetailsBindingSource.Current)["type"] = curYear + "1";
                     qidsDetailsBindingSource.EndEdit();


                     //iActionType = 2;
                     //qidsDetailsBindingSource.CurrencyManager.AddNew();
                     //((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = DiffTotalBalance;
                     ////((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = SumCredit;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.ProfitLossAccId;
                     //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";


                 } // Œ”«—…
                 else
                 {
                     DiffTotalBalance = DiffTotalBalance * -1;
                     iActionType = 3;
                     if (pos > -1)
                     {
                         qidsDetailsBindingSource.Position = pos;
                         if (((DataRowView)qidsDetailsBindingSource.Current)["type"] != DBNull.Value)
                         {
                             if (((DataRowView)qidsDetailsBindingSource.Current)["type"].ToString() != curYear + "1")
                             {
                                 pos = qidsDetailsBindingSource.Find("type", curYear + "1");
                             }
                         }
                     }
                     else
                     {
                         qidsDetailsBindingSource.CurrencyManager.AddNew();
                     }
                     ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DiffTotalBalance;
                     ((DataRowView)qidsDetailsBindingSource.Current)["fromValue"] = DBNull.Value;
                     ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.MovmentProfitsAccid; //«—»«—Õ „—Õ·… „œÊ—…
                     ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString(); 
                     ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                     ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                     ((DataRowView)qidsDetailsBindingSource.Current)["type"] =  curYear + "1";
                     qidsDetailsBindingSource.EndEdit();

                     //iActionType = 2;
                     //qidsDetailsBindingSource.CurrencyManager.AddNew();
                     ////((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = PurchaseTotalBalance;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DiffTotalBalance;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.ProfitLossAccId;//«—»«Õ ÊŒ”«∆—
                     //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";

                 }
           
            ////////////////////////////////////////\\ ﬁÌœ «€·«ﬁ
                 pos = qidsDetailsBindingSource1.Find("ACCOUNTID", Messages.ProfitLossAccId);
                 if (ProfitFlag > 0) // —»Õ
                 {
                     iActionType = 2;

                     if (pos > -1)
                     {
                         qidsDetailsBindingSource1.Position = pos;
                         if (((DataRowView)qidsDetailsBindingSource1.Current)["type"] != DBNull.Value)
                         {
                             if (((DataRowView)qidsDetailsBindingSource1.Current)["type"].ToString() != curYear + "1")
                             {
                                 pos = qidsDetailsBindingSource1.Find("type", curYear + "1");
                             }
                         }
                     }
                     else
                     {
                         qidsDetailsBindingSource1.CurrencyManager.AddNew();
                     }
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ToValue"] = DBNull.Value ; //clear
                     ((DataRowView)qidsDetailsBindingSource1.Current)["FromValue"] = DiffTotalBalance;
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ACCOUNTID"] = Messages.ProfitLossAccId;
                     ((DataRowView)qidsDetailsBindingSource1.Current)["EnterDate"] = "31/12/" + (int.Parse(curYear)).ToString();
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ActionType"] = curYear + "2";
                     ((DataRowView)qidsDetailsBindingSource1.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                     ((DataRowView)qidsDetailsBindingSource1.Current)["type"] = curYear + "1";
                     qidsDetailsBindingSource1.EndEdit();


                     //iActionType = 2;
                     //qidsDetailsBindingSource.CurrencyManager.AddNew();
                     //((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = DiffTotalBalance;
                     ////((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = SumCredit;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.ProfitLossAccId;
                     //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";


                 } // Œ”«—…
                 else
                 {
                     DiffTotalBalance = DiffTotalBalance * -1;
                     iActionType =2;
                     if (pos > -1)
                     {
                         qidsDetailsBindingSource1.Position = pos;
                         if (((DataRowView)qidsDetailsBindingSource1.Current)["type"] != DBNull.Value)
                         {
                             if (((DataRowView)qidsDetailsBindingSource1.Current)["type"].ToString() != curYear + "1")
                             {
                                 pos = qidsDetailsBindingSource1.Find("type", curYear + "1");
                             }
                         }
                     }
                     else
                     {
                         qidsDetailsBindingSource1.CurrencyManager.AddNew();
                     }
                     ((DataRowView)qidsDetailsBindingSource1.Current)["FromValue"] = DBNull.Value;
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ToValue"] = DiffTotalBalance;
                  
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ACCOUNTID"] = Messages.ProfitLossAccId; //«—»«—Õ „—Õ·… „œÊ—…
                     ((DataRowView)qidsDetailsBindingSource1.Current)["EnterDate"] = "31/12/" + (int.Parse(curYear)).ToString();
                     ((DataRowView)qidsDetailsBindingSource1.Current)["ActionType"] = curYear + "2";
                     ((DataRowView)qidsDetailsBindingSource1.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                     ((DataRowView)qidsDetailsBindingSource1.Current)["type"] = curYear + "1";
                     qidsDetailsBindingSource1.EndEdit();

                     //iActionType = 2;
                     //qidsDetailsBindingSource.CurrencyManager.AddNew();
                     ////((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = PurchaseTotalBalance;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DiffTotalBalance;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = Messages.ProfitLossAccId;//«—»«Õ ÊŒ”«∆—
                     //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                     //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";

                 }
                 AddNodeOsal(Messages.OsalAccId);
                 AddNodeDiscount(Messages.DeductAccId);
              
                
                 
              
             
              
        }
        private void UpdateQidDet()
        {
            int vpos = qidsDetailsBindingSource.Find("ACCOUNTID", Messages.MovmentProfitsAccid);
            if (vpos > -1)
            {
                qidsDetailsBindingSource.Position = vpos;
                if (((DataRowView)qidsDetailsBindingSource.Current)["fromvalue"] != DBNull.Value && ((DataRowView)qidsDetailsBindingSource.Current)["tovalue"] != DBNull.Value)
                {
                    decimal fromvalue = decimal.Parse(((DataRowView)qidsDetailsBindingSource.Current)["fromvalue"].ToString());
                    decimal Tovalue = decimal.Parse(((DataRowView)qidsDetailsBindingSource.Current)["Tovalue"].ToString());
                    if (fromvalue - Tovalue > 0)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["fromvalue"] = fromvalue - Tovalue;
                        ((DataRowView)qidsDetailsBindingSource.Current)["tovalue"] = DBNull.Value;
                    }
                    else
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["tovalue"] = Tovalue - fromvalue;
                        ((DataRowView)qidsDetailsBindingSource.Current)["fromvalue"] = DBNull.Value;
                    }

                }
            }
        }
        private void AddItem(int AccountparentId,int Level)
        {
            if (Level > 0)
            {
                accountingBindingSourceTemp.Filter = "AccountparentId = " + AccountparentId.ToString();
                System.Data.DataView list = new System.Data.DataView();
                list = (DataView)accountingBindingSourceTemp.List;
                DataTable T = new DataTable();
                T = list.ToTable();
                accountingBindingSourceTemp.RemoveFilter();
                for (int i = 0; i < T.Rows.Count; i++)
                {
                    //Boolean bRoot = (Boolean)T.Rows[i]["Root"];

                    //TreeNode Node = new TreeNode();
                    //Node.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];
                    int accountid = int.Parse(T.Rows[i]["accountid"].ToString());
                    accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, accountid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                    if (nEWERPDataSetTempOld.accounting.Count > 0)
                    {
                        nEWERPDataSet.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                    }
                    //Node.Tag = (Int64)T.Rows[i]["accountid"];
                    //Node.ContextMenuStrip = ContextMenuAccount;
                    //Node.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];


                    //Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                    //int accountType = (int)T.Rows[i]["accountType"];
                    Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];
                    //Level = Level - 1;
                    if (MainNode && Level != 0) //has childern
                    {

                        AddItem(accountid, Level - 1);
                    }
                    else
                    {
                    }
                }
            }
        }
        private decimal GetAccountSum(ref int  lossOrProff)
        {
            DataView list = (DataView)accountingBindingSource1.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;
          

            for (int i = 0; i < T.Rows.Count; i++)
            {
              
                if (GLibrary.IsNumeric(T.Rows[i]["Totalfromvalue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["Totalfromvalue"].ToString());
                }
                if (GLibrary.IsNumeric(T.Rows[i]["TotalTovalue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["TotalTovalue"].ToString());
                }
            
            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = decimal.Parse(txtTotalFromValue.Text) - decimal.Parse(txtTotalToValue.Text);
            
            if (Credit < 0)
            {
                //txttotalBalance.Text = (-1*Credit).ToString();
                //lblSum.Text = " Œ”«—… ";
                lossOrProff=-1;
            }
            else
            {
               // txttotalBalance.Text = Credit.ToString() ;
                //lblSum.Text = " —»Õ ";
                 lossOrProff=1;
            }
            //if (Credit == 0)
            //{
            //    lblSum.Text = "";
            //}
         return Credit ;
        }

      
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void AddNodeOsal(int AccountparentId)//, int Level)
        {
            //if (Level > 0)
            //{
            

                accountingBindingSourceTemp.Filter = "AccountparentId = " + AccountparentId.ToString();
                System.Data.DataView list = new System.Data.DataView();
                list = (DataView)accountingBindingSourceTemp.List;
                DataTable T = new DataTable();
                T = list.ToTable();
                accountingBindingSourceTemp.RemoveFilter();
                for (int i = 0; i < T.Rows.Count; i++)
                {
                    //Boolean bRoot = (Boolean)T.Rows[i]["Root"];
                    Boolean Flag = false;
                    //TreeNode Node = new TreeNode();
                    //Node.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];
                    int accountid = int.Parse(T.Rows[i]["accountid"].ToString());
                   
                    accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, accountid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                    if (nEWERPDataSetTempOld.accounting.Count > 0)
                    {

                        Boolean CurMainNode = (Boolean)T.Rows[i]["MainNode"];
                        if (!CurMainNode)
                        {
                            decimal TotalBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"].ToString());
                            //decimal TotalStockBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalStockBalance"].ToString());
                            //decimal TotalBalanceFC = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalanceFC"].ToString());

                            if (TotalBalance != 0)
                            {
                                int CurAccId = int.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["accountid"].ToString());
                                if (TotalBalance < -1)
                                {
                                    TotalBalance = TotalBalance * -1;
                                    Flag = true;

                                }
                                else
                                {
                                    Flag = false;
                                }
                                iActionType = 2;
                                int pos = qidsDetailsBindingSource.Find("ACCOUNTID", CurAccId);
                                if (Flag) //negative
                                {
                                    //qidsDetailsBindingSource.CurrencyManager.AddNew();
                                   
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = TotalBalance;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";
                                    //((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];

                                    iActionType = 3;
                                    if (pos > -1)
                                    {
                                        qidsDetailsBindingSource.Position = pos;
                                    }
                                    else
                                    {
                                        qidsDetailsBindingSource.CurrencyManager.AddNew();
                                    }
                                   
                                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = TotalBalance;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DBNull.Value;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["FromValueFC"] = TotalBalanceFC;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                                    ((DataRowView)qidsDetailsBindingSource.Current)["type"] = curYear + "2";
                                    //((DataRowView)qidsDetailsBindingSource.Current)["StockNum"] = TotalStockBalance;

                                    qidsDetailsBindingSource.EndEdit();
                                }
                                else
                                {
                                    //qidsDetailsBindingSource.CurrencyManager.AddNew();
                                   
                                    //((DataRowView)qidsDetailsBindingSource.Current)["fromValue"] = TotalBalance;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";
                                    //((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];

                                    iActionType = 3;
                                    if (pos > -1)
                                    {
                                        qidsDetailsBindingSource.Position = pos;
                                    }
                                    else
                                    {
                                        qidsDetailsBindingSource.CurrencyManager.AddNew();
                                    }

                                   
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = TotalBalance;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = DBNull.Value;
                                    //((DataRowView)qidsDetailsBindingSource.Current)["ToValueFC"] = TotalBalanceFC;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                                    ((DataRowView)qidsDetailsBindingSource.Current)["type"] =  curYear + "2";
                                    //((DataRowView)qidsDetailsBindingSource.Current)["StockNum"] = TotalStockBalance;

                                    qidsDetailsBindingSource.EndEdit();

                                }
                                //nEWERPDataSetOSal.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                            }
                        }
                        }
                    

                        //Node.Tag = (Int64)T.Rows[i]["accountid"];
                        //Node.ContextMenuStrip = ContextMenuAccount;
                        //Node.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];


                        //Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                        //int accountType = (int)T.Rows[i]["accountType"];
                        Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];
                        //Level = Level - 1;
                        if (MainNode)//&& Level != 0) //has childern
                        {

                            AddNodeOsal(accountid);//, Level - 1);
                        }
                        else
                        {
                        }
                    
                }
           // }
        }
        private void AddNodeDiscount(int AccountparentId)//, int Level)
        {
            //if (Level > 0)
            //{
            accountingBindingSourceTemp.Filter = "AccountparentId = " + AccountparentId.ToString();
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)accountingBindingSourceTemp.List;
            DataTable T = new DataTable();
            T = list.ToTable();
            accountingBindingSourceTemp.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                //Boolean bRoot = (Boolean)T.Rows[i]["Root"];

                //TreeNode Node = new TreeNode();
                //Node.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];
                Boolean Flag = false;
                int accountid = int.Parse(T.Rows[i]["accountid"].ToString());
                //if (accountid != Messages.ProfitLossAccId)
                //{
                    accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, accountid, BranchId, FromDate, ToDate, FromDateB, ToDateB, 2);
                    if (nEWERPDataSetTempOld.accounting.Count > 0)
                    {
                        Boolean CurMainNode = (Boolean)T.Rows[i]["MainNode"];

                        if (!CurMainNode)
                        {
                            decimal TotalBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalance"].ToString());
                            //decimal TotalStockBalance = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalStockBalance"].ToString());
                            //decimal TotalBalanceFC = decimal.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["TotalBalanceFC"].ToString());

                            if (TotalBalance != 0)
                            {
                                int CurAccId = int.Parse(nEWERPDataSetTempOld.accounting.Rows[0]["accountid"].ToString());

                                if (TotalBalance < -1)
                                {
                                    TotalBalance = TotalBalance * -1;
                                    Flag = true;
                                }
                                else
                                {
                                    Flag = false;
                                }

                                iActionType = 2;
                                int pos = qidsDetailsBindingSource.Find("ACCOUNTID", CurAccId);
                                //if (CurAccId != Messages.MovmentProfitsAccid)
                                //{
                                    if (Flag) //negative
                                    {
                                        //qidsDetailsBindingSource.CurrencyManager.AddNew();
                                        //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = TotalBalance;

                                        //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                        //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                                        //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";
                                        //((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];

                                        iActionType = 3;
                                        if (pos > -1)
                                        {
                                            qidsDetailsBindingSource.Position = pos;
                                            if (((DataRowView)qidsDetailsBindingSource.Current)["type"] != DBNull.Value)
                                            {
                                                if (((DataRowView)qidsDetailsBindingSource.Current)["type"].ToString() != curYear + "2")
                                                {
                                                    //qidsDetailsBindingSource.Filter = "type=" + curYear + "2 and ACCOUNTID=" + CurAccId.ToString();
                                                    //pos = qidsDetailsBindingSource.Position;

                                                    //if (pos == -1)
                                                    //{
                                                    //    qidsDetailsBindingSource.CurrencyManager.AddNew();
                                                    //}
                                                }
                                            }
                                        }
                                        else
                                        {
                                            qidsDetailsBindingSource.CurrencyManager.AddNew();
                                        }

                                       
                                            if (((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] != DBNull.Value)
                                            {
                                                decimal TempValue = decimal.Parse(((DataRowView)qidsDetailsBindingSource.Current)["FromValue"].ToString());
                                                TempValue = TempValue + TotalBalance;
                                                ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = TempValue;

                                            }
                                            else
                                            {
                                                ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = TotalBalance;
                                            }
                                      
                                        
                                        //((DataRowView)qidsDetailsBindingSource.Current)["FromValueFC"] = TotalBalanceFC;
                                        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                                        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                                        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                                        ((DataRowView)qidsDetailsBindingSource.Current)["type"] = curYear + "2";
                                        //((DataRowView)qidsDetailsBindingSource.Current)["StockNum"] = TotalStockBalance;
                                        if (CurAccId == Messages.MovmentProfitsAccid)
                                        {
                                            UpdateQidDet();
                                        }
                                        else
                                        {
                                            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = DBNull.Value;
                                        }
                                        qidsDetailsBindingSource.EndEdit();
                                        qidsDetailsBindingSource.Filter = "ActionType=" + curYear + "3";

                                    }
                                    else
                                    {
                                        //qidsDetailsBindingSource.CurrencyManager.AddNew();
                                        //((DataRowView)qidsDetailsBindingSource.Current)["fromValue"] = TotalBalance;

                                        //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                        //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "31/12/" + curYear;
                                        //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "2";
                                        //((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];

                                        iActionType = 3;
                                        if (pos > -1)
                                        {
                                            qidsDetailsBindingSource.Position = pos;
                                            if (((DataRowView)qidsDetailsBindingSource.Current)["type"] != DBNull.Value)
                                            {
                                                //if (((DataRowView)qidsDetailsBindingSource.Current)["type"].ToString() != curYear + "2")
                                                //{
                                                //    qidsDetailsBindingSource.Filter = "type=" + curYear + "2 and ACCOUNTID=" + CurAccId.ToString();
                                                //    pos = qidsDetailsBindingSource.Position;

                                                //    //if (pos == -1)
                                                //    //{
                                                //    //    qidsDetailsBindingSource.CurrencyManager.AddNew();
                                                //    //}
                                                //}
                                            }
                                        }
                                        else
                                        {
                                            qidsDetailsBindingSource.CurrencyManager.AddNew();
                                        }
                                        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = TotalBalance;
                                        //((DataRowView)qidsDetailsBindingSource.Current)["ToValueFC"] = TotalBalanceFC;
                                        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = CurAccId;
                                        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = "1/1/" + (int.Parse(curYear) + 1).ToString();
                                        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = curYear + "3";
                                        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[0, 0];
                                        ((DataRowView)qidsDetailsBindingSource.Current)["type"] = curYear + "2";
                                        //((DataRowView)qidsDetailsBindingSource.Current)["StockNum"] = TotalStockBalance;
                                        if (CurAccId == Messages.MovmentProfitsAccid)
                                        {
                                            UpdateQidDet();
                                        }
                                        else
                                        {
                                            ((DataRowView)qidsDetailsBindingSource.Current)["fromValue"] = DBNull.Value;
                                        }
                                        qidsDetailsBindingSource.EndEdit();
                                        qidsDetailsBindingSource.Filter = "ActionType=" + curYear + "3";
                                    }
                                //}
                                //qidsDetailsBindingSource1.AddNew();
                                ////((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = PurchaseTotalBalance;
                                //((DataRowView)qidsDetailsBindingSource1.Current)["ToValue"] = TotalBalance;
                                //((DataRowView)qidsDetailsBindingSource1.Current)["ACCOUNTID"] = Messages.Budgetaccid;
                                //((DataRowView)qidsDetailsBindingSource1.Current)["EnterDate"] = "31/12/" + DateTime.Today.Year.ToString();
                                //((DataRowView)qidsDetailsBindingSource1.Current)["ActionType"] = 2;


                                // nEWERPDataSetDiscount.accounting.ImportRow(nEWERPDataSetTempOld.accounting.Rows[0]);
                            }
                        }
                    }
             //   }
                //Node.Tag = (Int64)T.Rows[i]["accountid"];
                //Node.ContextMenuStrip = ContextMenuAccount;
                //Node.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];


                //Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                //int accountType = (int)T.Rows[i]["accountType"];
                Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];
                //Level = Level - 1;
                if (MainNode)//&& Level != 0) //has childern
                {

                    AddNodeDiscount(accountid);//, Level - 1);
                }
                else
                {

                }
            }
            // }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //if (!Editflag)
            //{
            if (SaveChild())
            {
                MessageBox.Show(" „ «€·ﬁ Â–Â «·”‰Â »‰Ã«Õ", "«€·ﬁ «·”‰Â «·„«·Ì…", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
                Editflag = true;

            //}

          
           
            qidsDetailsTableAdapter.Fill (nEWERPDataSet.qidsDetails);
        }
        private Boolean SaveChild()
        {

            this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.qidsRow master = (NEWERPDataSet.qidsRow)(((DataRowView)qidsOpenBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.qidsDetailsRow detail = (NEWERPDataSet.qidsDetailsRow)(((DataRowView)qidsDetailsBindingSource.Current).Row);
            // Save the master row
            qidsOpenBindingSource.EndEdit();
            qidsTableAdapter.Update(master);
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row

            if (detail.qidid != master.qidid)
            {
                for (int i = 0; i < qidsDetailsBindingSource.Count; i++)
                {
                    ((DataRowView)qidsDetailsBindingSource[i])["qidid"] = master.qidid;
                }
            }
            qidsDetailsBindingSource.EndEdit();

            //closed
            NEWERPDataSet.qidsRow masterClosed = (NEWERPDataSet.qidsRow)(((DataRowView)qidsClosedBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.qidsDetailsRow detailClosed = (NEWERPDataSet.qidsDetailsRow)(((DataRowView)qidsDetailsBindingSource1.Current).Row);
            // Save the master row
            qidsClosedBindingSource.EndEdit();
            qidsTableAdapter.Update(masterClosed);
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row

            if (detailClosed.qidid != masterClosed.qidid)
            {
                for (int j = 0; j < qidsDetailsBindingSource1.Count; j++)
                {
                    ((DataRowView)qidsDetailsBindingSource1[j])["qidid"] = masterClosed.qidid;
                }
            }
            qidsDetailsBindingSource1.EndEdit();
            // Save the child row
           
            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        //private Boolean SaveChildClose()
        //{

        //    this.Validate();
        //    nEWERPDataSet.EnforceConstraints = false;
        //    // Get the master row
        //    NEWERPDataSet.qidsRow master = (NEWERPDataSet.qidsRow)(((DataRowView)qidsClosedBindingSource.Current).Row);
        //    // Get the child row
        //    NEWERPDataSet.qidsDetailsRow detail = (NEWERPDataSet.qidsDetailsRow)(((DataRowView)qidsDetailsBindingSource1.Current).Row);
        //    // Save the master row
        //    qidsClosedBindingSource.EndEdit();
        //    qidsTableAdapter.Update(master);
        //    //masterTableAdapter.Update(master);
        //    // Store the new database-generated ID to the child row

        //    if (detail.qidid != master.qidid)
        //    {
        //        for (int i = 0; i < qidsDetailsBindingSource1.Count; i++)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource1[i])["qidid"] = master.qidid;
        //        }
        //    }

        //    //detail.qidid  = master.qidid;
        //    // Save the child row
        //    qidsDetailsBindingSource2.EndEdit();
          
        //    // Re-enable constraints
        //    nEWERPDataSet.EnforceConstraints = true;
        //    return true;

        //}
        private void qidsDetailsBindingSource1_PositionChanged(object sender, EventArgs e)
        {
            if (qidsClosedBindingSource.Count > 0 && qidsDetailsBindingSource1.Count > 0)
            {

                ((DataRowView)qidsDetailsBindingSource1.Current)["qidid"] = (Int64)((DataRowView)qidsClosedBindingSource.Current)["qidid"];
                //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            }
        }

        private void qidsDetailsBindingSource2_PositionChanged(object sender, EventArgs e)
        {
            //if (qidsOpenBindingSource.Count > 0 && qidsDetailsBindingSource2.Count > 0)
            //{

            //    ((DataRowView)qidsDetailsBindingSource2.Current)["qidid"] = (Int64)((DataRowView)qidsOpenBindingSource.Current)["qidid"];
            //    //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            //}
        }
        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            {
                if (iActionType == 1)
                {

                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                }
                else if (iActionType == 2)
                {

                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsClosedBindingSource.Current)["qidid"];
                }

                else if (iActionType == 3)
                {

                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsOpenBindingSource.Current)["qidid"];
                }
                else
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                }

                //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            }
        }

       
        private void cmbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            curYear = cmbYears.Text;

            qidsDetailsBindingSource.Filter = "ActionType=" + curYear + "3";
            qidsDetailsBindingSource1.Filter = "ActionType=" + curYear + "2";
           // qidsDetailsBindingSource2.Filter = "ActionType=" + curYear + "3";
         
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Search();
            if (dataGridView1.RowCount > 0)
            {
                SaveBtn.Enabled = true;
            }
            else
            {
                SaveBtn.Enabled = false;
            }
          
        }
       
      
        
    }
}