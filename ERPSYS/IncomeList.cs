using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class IncomeList :  DockContent
    {
     

        public IncomeList()
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
            this.accountingTableAdapter.FillByAll(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetailsClosed' table. You can move, or remove it, as needed.
            this.qidsDetailsClosedTableAdapter.Fill(this.nEWERPDataSet.qidsDetailsClosed);
            qidsDetailsClosedBindingSource.Filter = "accountId <> 2";
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.creditssupp' table. You can move, or remove it, as needed.
            GetAccountSum();
            
                   
        }

              
        private void GetAccountSum()
        {

            DataView list = (DataView)qidsDetailsClosedBindingSource.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;
            lblSum.Text = "";

            for (int i = 0; i < T.Rows.Count; i++)
            {


                if (GLibrary.IsNumeric(T.Rows[i]["Tovalue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["Tovalue"].ToString());
                }
                if (GLibrary.IsNumeric(T.Rows[i]["fromvalue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["fromvalue"].ToString());
                }
                //if (GLibrary.IsNumeric(T.Rows[i]["ATotalBalance"].ToString()))
                //{
                //    Credit = Credit + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                //}

            }

            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            if (Credit < 0)
            {
                txttotalBalance.Text = Credit.ToString();
                lblSum.Text = " ÎÓÇÑÉ ";
            }
            else
            {
                txttotalBalance.Text = Credit.ToString();
                lblSum.Text = " ÑÈÍ ";
            }
                
                qidsDetailsClosedBindingSource.Filter = "ACCOUNTID <> " + Messages.Osoalaccid.ToString() + " and ACCOUNTID <> " + Messages.Khosomaccid.ToString() + " and ACCOUNTID <> " + Messages.ProfitAccid.ToString();
                qidsDetailsClosedBindingSource1.Filter = "ACCOUNTID = " + Messages.Osoalaccid.ToString() + " or ACCOUNTID = " + Messages.Khosomaccid.ToString() + " or ACCOUNTID = " + Messages.ProfitAccid.ToString();
        }
           
            
              
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
              //if (cmbAccount.SelectedValue != null) { AccountId = long.Parse(cmbAccount.SelectedValue.ToString()); }
              //int pos=accountingBindingSource.Find("AccountId", AccountId);
              //if (pos > -1)
              //{
              //    ShowProductsRpt frm =new ShowProductsRpt();
              //    frm.AccountName = cmbAccount.Text  ;

                                  
              //    if (txtFromDate.Text != "")
              //    {
              //        frm.FromDate = DateTime.Parse(txtFromDate.Text);
              //    }
              //    else
              //    {
              //        frm.FromDate = new DateTime(DateTime.Today.Year, 1, 1);
              //    }
              //    if (txtToDate.Text != "")
              //    {
              //        frm.ToDate = DateTime.Parse(txtToDate.Text);
              //    }
              //    else
              //    {
              //        frm.ToDate = DateTime.Today;
              //    }
              //    if (((DataRowView)accountingBindingSource[pos])["MainNode"].ToString() == Boolean.TrueString)
              //    {
              //        frm.choiceNum = 4;
              //    }
              //    else
              //    {
                        
              //        frm.choiceNum = 2;
                        
              //    }
              //    frm.nEWERPDataSet = nEWERPDataSet;
              //    if (GLibrary .IsNumeric ( txtTotalToValue.Text ))
              //      {
              //          frm.TotalTo= decimal.Parse (txtTotalToValue.Text);
              //      }
              //       if (GLibrary .IsNumeric ( txtTotalFromValue.Text ))
              //      {
              //          frm.TotalFrom = decimal.Parse (txtTotalFromValue.Text);
              //      }
              //       if (GLibrary .IsNumeric ( txttotalBalance.Text ))
              //      {
              //          frm.ValTotalSum = decimal.Parse (txttotalBalance.Text) ;
              //      }
                    
              //      frm.ShowDialog(this);
              //}
        }

        

       

      

      

      

      
      

     
      

       

       

        
    }
}