using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class Form3 : Form
    {
        private decimal ProfitValue = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetailsClosed' table. You can move, or remove it, as needed.
            this.qidsDetailsClosedTableAdapter.Fill(this.nEWERPDataSet.qidsDetailsClosed);
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.FillByAll (this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            //this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            txtToDate.Text = DateTime.Today.ToShortDateString();
            qidsDetailsClosedBindingSource.Filter = "ACCOUNTID <> " + Messages.Osoalaccid.ToString() + " and ACCOUNTID <> " + Messages.Khosomaccid.ToString() + " and ACCOUNTID <> " + Messages.ProfitAccid.ToString();
           
        }
        private void BlamceBtn_Click(object sender, EventArgs e)
        {
            CloseQiqs();
        }
        private void CloseQiqs()
        {
            qidsDetailsClosedBindingSource.RemoveFilter();
            while (qidsDetailsClosedBindingSource.Count > 0)
            {
                qidsDetailsClosedBindingSource.RemoveCurrent();

            }
            qidsDetailsClosedBindingSource.Filter = "ACCOUNTID <> " + Messages.Osoalaccid.ToString() + " and ACCOUNTID <> " + Messages.Khosomaccid.ToString() + " and ACCOUNTID <> " + Messages.ProfitAccid.ToString();
            
            qidsDetailsClosedBindingSource.EndEdit();
            qidsDetailsClosedTableAdapter.Update(nEWERPDataSet.qidsDetailsClosed);

              Nullable <DateTime> ToDate = null;
              Nullable<DateTime> FromDate = null;

            FromDate = new DateTime(DateTime.Today.Year, 1, 1);
            ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
            // «·„’—Ê›« 
            accountingTableAdapter.FillSumByAccId(nEWERPDataSet.accounting, Messages.Paymentsaccid, 1, FromDate, ToDate);
            if (nEWERPDataSet.accounting.Count > 0)
            {
                 decimal TotalBalance = decimal.Parse(((DataRowView)accountingBindingSource.Current)["TotalBalance"].ToString());
                 AddQids(TotalBalance, Messages.Paymentsaccid, false);
                //AddQids(TotalBalance,Messages.Paymentsaccid,true);
                 ProfitValue = ProfitValue + TotalBalance;
                
                 //AddQids(TotalBalance, Messages.ProfitAccid, false); // «—»«Õ ÊŒ”«∆—
            }
           
          

            // «·„‘ —Ì« 
            accountingTableAdapter.FillSumByAccId(nEWERPDataSet.accounting, Messages.purchaseaccid , 1, FromDate, ToDate);
            if (nEWERPDataSet.accounting.Count > 0)
            {
                 decimal TotalBalance = decimal.Parse(((DataRowView)accountingBindingSource.Current)["TotalBalance"].ToString());

                AddQids(TotalBalance, Messages.purchaseaccid, false);
                ProfitValue = ProfitValue + TotalBalance;
                //AddQids(TotalBalance,Messages.purchaseaccid,true);
                
                // AddQids(TotalBalance, Messages.ProfitAccid, false); // «—»«Õ ÊŒ”«∆—
            }
           
            

            // «·„»Ì⁄« 
            accountingTableAdapter.FillSumByAccId(nEWERPDataSet.accounting, Messages.salesaccid , 1, FromDate, ToDate);
            if (nEWERPDataSet.accounting.Count > 0)
            {
                 decimal TotalBalance = decimal.Parse(((DataRowView)accountingBindingSource.Current)["TotalBalance"].ToString());

                 AddQids(TotalBalance, Messages.salesaccid, true);
                 ProfitValue = ProfitValue - TotalBalance;
                 //AddQids(TotalBalance,Messages.salesaccid,false);

                 //AddQids(TotalBalance,Messages.ProfitAccid,true);
            }

            accountingTableAdapter.FillSumByAccId(nEWERPDataSet.accounting, Messages.Osoalaccid, 1, FromDate, ToDate);
            if (nEWERPDataSet.accounting.Count > 0)
            {
                decimal totalToValue = decimal.Parse(((DataRowView)accountingBindingSource.Current)["totalToValue"].ToString());
                decimal totalFromValue = decimal.Parse(((DataRowView)accountingBindingSource.Current)["totalFromValue"].ToString());
                decimal TotalBalance = totalFromValue - totalToValue;
                if (TotalBalance >= 0)
                {
                    AddQids(TotalBalance, Messages.Osoalaccid, true);
                }
                else
                {
                    AddQids(TotalBalance*-1, Messages.Osoalaccid, false);
                }
               

            }

            accountingTableAdapter.FillSumByAccId(nEWERPDataSet.accounting, Messages.Khosomaccid, 1, FromDate, ToDate);
            if (nEWERPDataSet.accounting.Count > 0)
            {
                decimal totalToValue = decimal.Parse(((DataRowView)accountingBindingSource.Current)["totalToValue"].ToString());
                decimal totalFromValue = decimal.Parse(((DataRowView)accountingBindingSource.Current)["totalFromValue"].ToString());
                decimal TotalBalance = totalFromValue - totalToValue;
                if (TotalBalance >= 0)
                {
                    AddQids(TotalBalance, Messages.Khosomaccid, true);
                }
                else
                {
                    AddQids(TotalBalance*-1, Messages.Khosomaccid, false);
                }
               

            }
            if (ProfitValue > 0)
            {
                AddQids(ProfitValue, Messages.ProfitAccid, true);
            }
            else
            {
                AddQids(ProfitValue, Messages.ProfitAccid, false);
            }
            qidsDetailsClosedBindingSource.EndEdit();
            qidsDetailsClosedTableAdapter.Update(nEWERPDataSet.qidsDetailsClosed);
            this.accountingTableAdapter.FillByAll(this.nEWERPDataSet.accounting);
            qidsDetailsClosedBindingSource.Filter = "ACCOUNTID <> " + Messages.Osoalaccid.ToString() + " and ACCOUNTID <> " + Messages.Khosomaccid.ToString() + " and ACCOUNTID <> " + Messages.ProfitAccid.ToString();
            
        }
        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //string Str = "";
            //string accId = "";
            if (e.KeyCode == Keys.Down)
            {      
                //comboBox1.DroppedDown = true;
                //comboBox1.Select();   
            }
            //accountingBindingSource.Filter = " accountname like '" + comboBox1.Text + "%'";
           
            //int index=accountingBindingSource.Position;
            
            //if (index > -1)
            //{
            //     Str = ((DataRowView)accountingBindingSource.Current)["accountname"].ToString();
            //    accId = ((DataRowView)accountingBindingSource.Current)["accountid"].ToString();
            //    //int index = comboBox1.FindString(comboBox1.Text);
            //    comboBox1.SelectedText = Str;
            //    comboBox1.SelectedValue = accId;
            //}
            //accountingBindingSource.RemoveFilter();
            //comboBox1.SelectedText = Str;
            //comboBox1.SelectedValue = accId;
           
        }
        private void AddQids(decimal value,int AccountId, Boolean FromToFlag)
        {
             
   
                qidsDetailsClosedBindingSource.AddNew();
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["qidid"] = 1;
                ((DataRowView)qidsDetailsClosedBindingSource.Current).BeginEdit();
                if (FromToFlag)
                {
                    ((DataRowView)qidsDetailsClosedBindingSource.Current)["FromValue"] = value;
                }
                else
                {
                    ((DataRowView)qidsDetailsClosedBindingSource.Current)["ToValue"] = value;
                }
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["ACCOUNTID"] = AccountId;// Messages.Paymentsaccid; // Õ”«» «·⁄„Ì·
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["EnterDate"] = DateTime.Today;
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["Description"] = "";
                ((DataRowView)qidsDetailsClosedBindingSource.Current)["ActionType"] = 4;
                ((DataRowView)qidsDetailsClosedBindingSource.Current).EndEdit();
            
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void IncomeListBtn_Click(object sender, EventArgs e)
        {

            IncomeList frmIncomeList = new IncomeList();

            //frmIncomeList.MdiParent = this;
            frmIncomeList.ShowDialog();
            frmIncomeList.Focus();
        }

       
    }
}