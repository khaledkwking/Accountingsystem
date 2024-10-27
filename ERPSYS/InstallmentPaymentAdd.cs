using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class InstallmentPaymentAdd : DockContent
    {
        public Boolean EditFlag = false;

        private Nullable<int> CustAccId = null;
        private Nullable<int> CollectorAccId = null;
        private Nullable<DateTime> PayDate = null;
        public int QidLastIden = -1;
       
      
        private StaticList slPaymentTypes = new StaticList(GLibrary.strarrPaymentTypes);
        public InstallmentPaymentAdd()
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
            Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
          
           // this.installmentTableAdapter.Fill(this.nEWERPDataSet.Installment);
            //// TODO: This line of code loads data into the 'nEWERPDataSet.Installment_Distribution' table. You can move, or remove it, as needed.
            this.installment_DistributionTableAdapter.Fill(this.nEWERPDataSet.Installment_Distribution);

            accountingBindingSource.Filter = "Mainnode=" + Boolean.FalseString;
            accountingBindingSource1.Filter = "Mainnode=" + Boolean.FalseString;
            cmbCustaccId.SelectedValue = -1;
            CmbCollectorAccid.SelectedValue = -1;
            txtDate.Text = DateTime.Today.ToShortDateString();
            search();
            
        }



        private void search()
        {
            nEWERPDataSet.Installment_Distribution.Rows.Clear();
            CustAccId = null;
            CollectorAccId = null;
            PayDate = null;
            if (txtDate.Text != "")
            {
                if (GLibrary.IsDate(txtDate.Text))
                {
                    if (txtDate.Text != "") { PayDate = DateTime.Parse(txtDate.Text + " 23:59"); }

                }
                else
                {
                    MessageBox.Show(Messages.CheckDate, "ÍÐÝ ÚäÕÑ", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return;
                }
            }
            //installmentDistributionBindingSource.Filter = "PayFlag = false and CustAccid =" + CustAccId.ToString() + " AND (CollectorAccid= " + CollectorAccId.ToString() + " AND (DistDate <='" + PayDate.ToString ()+"'";
            installment_DistributionTableAdapter.FillByPayment (nEWERPDataSet.Installment_Distribution, CustAccId, CollectorAccId, PayDate);
        }

       

        private void dtPaymentDate_ValueChanged(object sender, EventArgs e)
        {
            txtDate.Text = dtPaymentDate.Value.ToShortDateString();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            search();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show(Messages.InstallPaymentMesg , "ÊÓÏíÏ ÇáÇÞÓÇØ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (ret == DialogResult.Yes)
            {
                installmentDistributionBindingSource.EndEdit();
                installment_DistributionTableAdapter.Update(this.nEWERPDataSet.Installment_Distribution);
                GetQid();
                search();
            }
            
           
        }

        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {

                if (qidsBindingSource.Count > 0 && ((DataRowView)qidsBindingSource.Current).IsNew) //["qidid"].ToString() == "0")
                {

                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(QidLastIden + 1);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

                //this.qidsDetailsTableAdapter.FillById(this.nEWERPDataSet.qidsDetails, qidid);

                qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString();


            }
            //else
            //{
            //    qidsDetailsBindingSource.Filter = "qidid = -1";
            //}
        }
        private void GetQid()
        {


            int AccountIdTo;
            int AccountIdFrom;

             AccountIdTo = Messages.boxAccid ;

            //if (qidsBindingSource.Count == 0)
            //{
            QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
            qidsBindingSource.AddNew();
            ((DataRowView)qidsBindingSource.Current).BeginEdit();
            ((DataRowView)qidsBindingSource.Current)["qidcode"] = "QT" + QidLastIden.ToString();// QidId.ToString();
            ((DataRowView)qidsBindingSource.Current)["qidDate"] = DateTime.Today;
            ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[10, 0];
            //((DataRowView)qidsBindingSource.Current)["InvId"] = ((DataRowView)installmentDistributionBindingSource[i])["InstallId"].ToString(); //((DataRowView)invoicesBindingSource.Current)["InvId"];
            ((DataRowView)qidsBindingSource.Current)["BrachId"] = Messages.CurBranch;
            ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;
            //qidsBindingSource.EndEdit();
            ((DataRowView)qidsBindingSource.Current).EndEdit();
            //}

            Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

            for (int i = 0; i < installmentDistributionBindingSource.Count; i++)
            {
                if (((DataRowView)installmentDistributionBindingSource[i])["RequiredFlag"].ToString() == Boolean.TrueString)
                {
                    AccountIdFrom = int.Parse(((DataRowView)installmentDistributionBindingSource[i])["CustAccid"].ToString());
                    decimal Value = decimal.Parse(((DataRowView)installmentDistributionBindingSource[i])["DistValue"].ToString());



                    int pos = -1;

                    pos = qidsDetailsBindingSource.Find("ActionType", 2);

                    if (pos == -1)
                    {
                        qidsDetailsBindingSource.AddNew();
                        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                    }
                    else
                    {
                        qidsDetailsBindingSource.Position = pos;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = Value;
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = AccountIdTo;
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[10, 0];
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ÊÓÏíÏ ÇáÇÞÓÇØ";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;


                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

                    //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);





                    pos = qidsDetailsBindingSource.Find("ActionType", 4);

                    if (pos == -1)
                    {
                        qidsDetailsBindingSource.AddNew();
                        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                    }
                    else
                    {
                        qidsDetailsBindingSource.Position = pos;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = Value;
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = AccountIdFrom; // ÍÓÇÈ ÇáÚãíá
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[10, 0];
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ÊÓÏíÏ ÇáÇÞÓÇØ";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 4;

                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();




                }
            }
            qidsBindingSource.EndEdit();
            qidsTableAdapter.Update(nEWERPDataSet.qids);
            qidsDetailsBindingSource.EndEdit();
            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);

        }

       
        
    }
}