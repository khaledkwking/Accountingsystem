using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class InstallmentAdd : Form
    {
            
        public int CustId;
        public int CustAccId;
        public string CustName;
        public decimal TotValue;
        public int InvId;
        private int LastIden = -1;
        private TabPage selectedTab;
        public Boolean EditFlag = false; 
        private StaticList slPaymentTypes = new StaticList(GLibrary.strarrPaymentTypes);
        public InstallmentAdd()
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
            installmentDistributionBindingSource.CancelEdit();
            installmentBindingSource.CancelEdit();
            DialogResult = DialogResult.Cancel ;
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            CmbPaymentType.DataSource = slPaymentTypes.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
          
            this.installmentTableAdapter.Fill(this.nEWERPDataSet.Installment);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Installment_Distribution' table. You can move, or remove it, as needed.
            this.installment_DistributionTableAdapter.Fill(this.nEWERPDataSet.Installment_Distribution);
            selectedTab = this.tabControlInstall.SelectedTab;

            LastIden = int.Parse(installmentTableAdapter.GetLastIdentity().ToString());

            accountingBindingSource.Filter = "Mainnode=" + Boolean.FalseString;

            installmentBindingSource.Filter = "InvId = " + InvId.ToString();
            if (installmentBindingSource.Count ==0)
            {
                installmentBindingSource.AddNew();
                txtInvId.Text = InvId.ToString();
            }
            else
            {

            }

            txtCustName.Text = CustName;
            lblInvTotValue.Text = TotValue.ToString ();
            txtTotalValue.Text = TotValue.ToString ();
            txtCustAccId.Text = CustAccId.ToString ();
            txtCustId.Text = CustId.ToString ();
            CmbPaymentType.SelectedIndex = 0;
            
        }
       
                 

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Disturbition();
            installmentBindingSource.EndEdit();
            installmentTableAdapter.Update(nEWERPDataSet.Installment);

            installmentDistributionBindingSource.EndEdit();
            installment_DistributionTableAdapter.Update(nEWERPDataSet.Installment_Distribution);
            DialogResult = DialogResult.OK;
            
        }

       
        private void installmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (installmentBindingSource.Count > 0)
            {

                if (installmentBindingSource.Count > 0 && ((DataRowView)installmentBindingSource.Current).IsNew) //["qidid"].ToString() == "0")
                {

                    ((DataRowView)installmentBindingSource.Current)["InstallId"] = (Int64)(LastIden + 1);
                }
                Int64 InstallId = (Int64)((DataRowView)installmentBindingSource.Current)["InstallId"];

                installmentDistributionBindingSource.Filter = "InstallId = " + InstallId.ToString();
               

            }
        }
        private void installmentDistributionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (installmentBindingSource.Count > 0 && installmentDistributionBindingSource.Count > 0)
            {
                ((DataRowView)installmentDistributionBindingSource.Current)["InstallId"] = (Int64)((DataRowView)installmentBindingSource.Current)["InstallId"];
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTab != this.tabControlInstall.SelectedTab)

                switch (tabControlInstall.SelectedIndex)
                {
                    case 0:
                        
                        break;
                    case 1:
                        Disturbition();
                        break;
                   
                }



            selectedTab = tabControlInstall.SelectedTab;
        }
        private void Disturbition()
        {
            int rCount=installmentDistributionBindingSource.Count;
            //for (int i=0;i<rCount ;i++)
            //{
                
            //    installmentDistributionBindingSource.RemoveCurrent() ;
            //    installmentDistributionBindingSource.MoveNext();
            //}
            if (rCount == 0)
            {
                if (txtTotalValue.Text != "" && txtInstallmentValue.Text != "")
                {
                    int days = 0;
                    switch (int.Parse(CmbPaymentType.SelectedValue.ToString()))
                    {
                        case 1:
                            days = 1;
                            break;
                        case 2:
                            days = 7;
                            break;
                        case 3:
                            days = 30;
                            break;
                    }


                    decimal TotValue = decimal.Parse(txtTotalValue.Text);
                    decimal InstallmentValue = decimal.Parse(txtInstallmentValue.Text);
                    decimal res = TotValue / InstallmentValue;
                    int Count = decimal.ToInt32(res);
                    if (res > Count)
                    {
                        Count = Count + 1;
                    }
                    DateTime T = dtPaymentDate.Value;
                    for (int i = 1; i <= Count; i++)
                    {

                        installmentDistributionBindingSource.AddNew();

                        decimal Val;
                        if (i < Count)
                        {
                            Val = InstallmentValue;
                        }
                        else
                        {
                            Val = TotValue - (InstallmentValue * (i - 1));
                        }
                        ((DataRowView)installmentDistributionBindingSource.Current)["DistValue"] = Val;
                        ((DataRowView)installmentDistributionBindingSource.Current)["DistDate"] = T;
                        ((DataRowView)installmentDistributionBindingSource.Current)["PayFlag"] = Boolean.FalseString ;
                        ((DataRowView)installmentDistributionBindingSource.Current)["RequiredFlag"] = Boolean.FalseString;
                        ((DataRowView)installmentDistributionBindingSource.Current)["CustAccid"] = CustAccId.ToString();
                        if (CmbCollectorAccid.SelectedValue != null)
                        {
                            ((DataRowView)installmentDistributionBindingSource.Current)["CollectorAccid"] = CmbCollectorAccid.SelectedValue;
                        }
                        if (days > 7)
                        {
                            T = T.AddMonths(1);
                        }
                        else
                        {
                            T = T.AddDays(days);
                        }
                    }

                }
                else
                {
                    MessageBox.Show(Messages.CheckInvTaksatValueMsg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }

                
            }
            if (lblInvTotValue.Text != lblTotInstall.Text)
            {
                MessageBox.Show(Messages.CheckTotTaksatMsg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }

        }

        private void DistDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void GetSum()
        {
            lblTotInstall.Text = "0";

            //for (int i = 0; i < invProductsBindingSource.Count; i++)
            if (installmentDistributionBindingSource.Count > 0)
            {
                for (int i = 0; i < DistDGView.Rows.Count; i++)
                {
                    if (DistDGView.Rows[i].Cells["DistValue"].Value != DBNull.Value )
                    {
                        if (DistDGView.Rows[i].Cells["DistValue"].Value != null)
                        {

                            if (GLibrary.IsNumeric(DistDGView.Rows[i].Cells["DistValue"].Value.ToString()))
                            {
                                lblTotInstall.Text = (decimal.Parse(lblTotInstall.Text) + decimal.Parse(DistDGView.Rows[i].Cells["DistValue"].Value.ToString())).ToString();
                              
                            }
                           
                        }
                    }
                }
            }
        }

        private void DistDGView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
          
        }

        private void DistDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (DistDGView.Rows.Count > 0)
            {
                if (e.ColumnIndex == distValue.Index)
                {
                    if (DistDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (GLibrary.IsNumeric(DistDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {

                            GetSum();
                            // txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).ToString();
                            if (lblInvTotValue.Text != lblTotInstall.Text)
                            {
                                MessageBox.Show(Messages.CheckTotTaksatMsg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                        }
                    }

                }
            }
        }

        private void DistDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DistDGView.Rows.Count > 0)
            {
                if (e.RowIndex>=0)
                {
                    if (DistDGView.Rows[e.RowIndex].Cells["distValue"].Value != null)
                    {
                        if (GLibrary.IsNumeric(DistDGView.Rows[e.RowIndex].Cells["distValue"].Value.ToString()))
                        {

                            GetSum();
                            // txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).ToString();

                        }
                    }

                }
            }
        }

       
        
    }
}