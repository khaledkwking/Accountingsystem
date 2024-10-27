using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class LoanAdd : Form
    {
        public Boolean EditFlag = false;
        public Decimal EmpCode;
        public long LoanId;
        public LoanAdd()
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
            this.perEmpLoanDetailsReportTableAdapter.Fill(this.personalDataSet.PerEmpLoanDetailsReport);
            // TODO: This line of code loads data into the 'personalDataSet.PerEmpLoanDetailsReport' table. You can move, or remove it, as needed.
            this.pRL_EMP_LOAN_DETAILTableAdapter.FillByLoanId(this.personalDataSet.PRL_EMP_LOAN_DETAIL,LoanId );
          
            ApplyLoan();
            GetSum();

        }
       
                 

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DialogResult ret= DialogResult.Yes;
            if (GLibrary.IsNumeric(txtTotalAmount.Text) && GLibrary.IsNumeric(txtTotalToValue.Text))
            {
                if (decimal.Parse(txtTotalAmount.Text) != decimal.Parse(txtTotalToValue.Text))
                {
                    ret = GLibrary.ShowMsgCheck("«·”·›", Messages.CheckTotVaule, "Loans", Messages.CheckTotVauleE, Messages.CurLang);
                }
            //
           
            }
            if (ret == DialogResult.Yes)
            {
                this.Validate();
                perEmpLoanDetailsReportBindingSource.EndEdit();
                //nEWERPDataSet.AcceptChanges();
                perEmpLoanDetailsReportTableAdapter.Update(personalDataSet.PerEmpLoanDetailsReport);

                if (Messages.CurLang == Messages.ArabLang)
                {
                    CmdSave.Text = " ⁄œÌ·";

                }
                else if (Messages.CurLang == Messages.EngLang)
                {
                    CmdSave.Text = "ÚıEdit";
                }
                GLibrary.MsgSave();

                //CmdAdd.Enabled = true;
                //CmdDel.Enabled = true;
                EditFlag = true;
            }
               
            
        }

        private void ApplyLoan()
        {
            decimal TotalAmount = 0;
            decimal TotPaid = 0;
            int NumOfLoan= 1;
            decimal LoanValue = 0;

            if (txtTotalAmount.Text != "")
            {
                TotalAmount = decimal.Parse(txtTotalAmount.Text);
            }
            if (txtTOT_PAID.Text !="")
            {
                TotPaid = decimal.Parse(txtTOT_PAID.Text);
            }
            if (txtTOTAL_MON_NUM.Text != "")
            {
                NumOfLoan=int.Parse(txtTOTAL_MON_NUM.Text);
            }
           
            LoanValue = (TotalAmount - TotPaid) / NumOfLoan;
           
            for (int i = 0; i < NumOfLoan;i++ )
            {
              perEmpLoanDetailsReportBindingSource.AddNew();
             ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["LoanDate"] =dtSTART_DATE.Value.AddMonths(i+1);
             ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["LoanAmount"] =LoanValue;
             ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["YEAR_CODE"]=dtSTART_DATE.Value.AddMonths(i+1).Year ;
             ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["MONTH_CODE"]=dtSTART_DATE.Value.AddMonths(i+1).Month ;
             ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["deducted"] = false;

            }
        }

        private void pRLEMPLOANDETAILBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRLEMPLOANDETAILBindingSource.Count > 0)
            {

                //if (pRLEMPLOANDETAILBindingSource.Count == 1 && ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["LoanID"].ToString() == "0")
                //{
                //    ((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanID"] = (Int64)(LastIden) + 1;
                //}
                long LoanID = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanID"].ToString()); ;
                perEmpLoanDetailsReportBindingSource.Filter = "LoanID= " + LoanID.ToString();
               

            }
        }

        private void perEmpLoanDetailsReportBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRLEMPLOANDETAILBindingSource.Count > 0 && perEmpLoanDetailsReportBindingSource.Count > 0)
            {

                ((DataRowView)perEmpLoanDetailsReportBindingSource.Current)["LoanID"] = long.Parse(((DataRowView)pRLEMPLOANDETAILBindingSource.Current)["LoanID"].ToString());


            }
        }

        private void StoresDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == LoanDate.Index)
            {
                if (e.FormattedValue.ToString () != "")
                {
                    DateTime RLoanDt = DateTime.Parse(e.FormattedValue.ToString ());
                    StoresDGView.Rows[e.RowIndex].Cells["YEAR_CODE"].Value = RLoanDt.Year;
                    StoresDGView.Rows[e.RowIndex].Cells["MONTH_CODE"].Value = RLoanDt.Month;
                }

            }
            //if (e.RowIndex > -1)
            //{
            //    if (StoresDGView.Rows[e.RowIndex].Cells["LoanAmount"].Value != DBNull.Value && StoresDGView.Rows[e.RowIndex].Cells["LoanAmount"].Value != null)
            //    {
            //        GetSum();
            //    }
            //}
        }

        private void StoresDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (StoresDGView.Rows[e.RowIndex].Cells["LoanAmount"].Value != DBNull.Value && StoresDGView.Rows[e.RowIndex].Cells["LoanAmount"].Value != null)
                {
                    GetSum();
                }
            }
            
        }
         

        private void GetSum()
        {
            try
            {
                DataView list = (DataView)perEmpLoanDetailsReportBindingSource.List;
                DataTable T = list.ToTable();
                
                decimal totValue = 0;
                for (int i = 0; i < T.Rows.Count; i++)
                {

                    if (GLibrary.IsNumeric(T.Rows[i]["LoanAmount"].ToString()))
                    {
                        totValue = totValue + decimal.Parse(T.Rows[i]["LoanAmount"].ToString());

                    }
                   
                }
                totValue=decimal.Round(totValue);
                txtTotalToValue.Text = totValue.ToString();
              
            }
            catch (Exception ex)
            {

            }
        }
             

       

        
    }
}