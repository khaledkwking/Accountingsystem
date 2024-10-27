using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using ERPSYS.Reports;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class InvoicePayment : DockContent
    {
        public int InvType;
        public int LastIden = -1;
        public int QidLastIden = -1;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
        private StaticList slBillType = new StaticList(GLibrary.strarrBillType);
        public Boolean  EditFlag=false ;
        private DateTime lastDataError = DateTime.MinValue;
        private Boolean flag = false;
        private Boolean Nflag = true;
        private int FromValueAcc;
        public InvoicePayment()
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
            //invProductsBindingSource.CancelEdit();
            //invoicesBindingSource.CancelEdit();
            //qidsBindingSource.CancelEdit();
            //qidsDetailsBindingSource.CancelEdit();
            //qidsDetailsBindingSourceWith.CancelEdit();

            this.Close  ();
        }

        private void InvoicePayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype (this.nEWERPDataSet.SUPPLIERS_CUSTOMERS,int.Parse (Messages.CustFlag) );
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            invoicesTableAdapter.FillByInvType(this.nEWERPDataSet.invoices, InvType);
            
            GetInvoices();
            if (invoicesBindingSource.Count > 0)
            {
                GetInvRemain(); 
                CalInvTotal();
               
            }
            accountingBindingSource.Filter = "AccountparentId=" + Messages.bankaccid.ToString() + " or AccountId= " + Messages.bankaccid.ToString() + " and MainNode=false";
            if (BoxRdBtn.Checked)
            {
                CmbBanks.Enabled = false ;
                txtChequeNo.Enabled = false ;
                CmbBanks.SelectedValue = -1;
                FromValueAcc = int.Parse(Messages.boxAccid.ToString());
            }
            flag = true;
            FromValueAcc = Messages.boxAccid;
        
           
        }
        private void GetInvoices()
        {
            //lblInvRemain.Text = "";
            if (CmbCustSupAccid.SelectedValue != null && CmbBranch.SelectedValue != null)
            {
                if (chkAll.Checked)
                {
                    invoicesBindingSource.Filter = "PaymentType=1 and SUP_CUST_ID=" + CmbCustSupAccid.SelectedValue + " and BranchId=" + CmbBranch.SelectedValue;
                }

                else
                {
                    invoicesBindingSource.Filter = "PayFinish=false and PaymentType=1 and SUP_CUST_ID=" + CmbCustSupAccid.SelectedValue + " and BranchId=" + CmbBranch.SelectedValue;

                }
            }
        }

        private void CmbCustSupAccid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                GetInvoices();
                GetInvRemain();
                CalInvTotal();
            }
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                GetInvoices();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (GLibrary.ValidatetxtBox(errorProvider1, txtInvPayment, "«œŒ· «·ﬁÌ„… «·„œ›Ê⁄… »ÿ—Ìﬁ… ’ÕÌÕ…", "«· Õ’Ì·", true))
            {
                decimal InvRemainPayment = decimal.Parse(txtInvPayment.Text); // «·„»·€ «·„”œœ

                if (BoxRdBtn.Checked) //«·’‰œÊﬁ
                {
                   
                    //ToValueAcc = Messages.boxAccid;
                }
                else if (BankRdBtn.Checked) // «·»‰ﬂ
                {
                    if (CmbBanks.SelectedValue != null)
                    {
                        FromValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); // Messages.bankaccid;
                    }
                    else
                    {
                        MessageBox.Show(Messages.QidNotBankfoundMesg, "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return;
                    }
                }

                //for (int i = 0; i < invoicesBindingSource.Count; i++)
                Boolean FinishFlag=false ;
                if (invoicesBindingSource.Count > 0)
                {
                    
                    if (!FinishFlag)
                    {
                        //DataGridViewCheckBoxCell dgcb = (DataGridViewCheckBoxCell)InvoiceDGView["CmbInvPay", i];
                        ////dgcb.DataSource = productUnitsPricesBindingSource;
                        //// Filter the BindingSource based upon the region selected
                        //int   bPay = int.Parse (InvoiceDGView["CmbInvPay", i].Value.ToString());
                        //if (bPay==1)
                        //{
                        //invoicesBindingSource.Position = i;
                        string InvCode = ((DataRowView)invoicesBindingSource.Current)["InvCode"].ToString();
                        long InvId = long.Parse(((DataRowView)invoicesBindingSource.Current)["InvId"].ToString());
                        SearchInvoice();
                        int pos = invoicesBindingSource.Find("InvId", InvId);
                        invoicesBindingSource.Position = pos;

                        string InvTotalNet;
                        decimal InvAllPayment = 0;

                        if (((DataRowView)invoicesBindingSource.Current)["CollectValue"] != DBNull.Value)
                        {
                            decimal CurRemainvalue = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["CollectValue"].ToString());
                            if (CurRemainvalue <= 0)
                            {
                                FinishFlag = true;
                            }
                        }
                        InvTotalNet = ((DataRowView)invoicesBindingSource.Current)["InvTotalNet"].ToString();

                        if (((DataRowView)invoicesBindingSource.Current)["InvPayment"] != DBNull.Value)
                        {
                            InvAllPayment = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["InvPayment"].ToString());
                        }


                        decimal InvPayment;
                        //«·ﬁÌ„… «·„œ›Ê⁄ Õ«·Ì«
                        InvPayment = decimal.Parse(invoicesTableAdapter.GetCustTotalPayment(InvId, 4).ToString()); // «·œ›⁄…

                        decimal Remain = decimal.Parse(InvTotalNet) - (InvAllPayment + InvRemainPayment);
                        //if (Remain < 0)
                        //{
                        //    Remain = 0;
                        //}
                        // «·ﬁÌ„… «·„ »ﬁÌ…
                        //InvRemainPayment «·ﬁÌ„… «·„œ›Ê⁄ Õ«·Ì«
                        //InvRemainPayment = Remain - InvRemainPayment ;
                        int Cust_Sup_Accid = int.Parse(((DataRowView)invoicesBindingSource.Current)["Cust_Sup_Accid"].ToString());

                        if (InvRemainPayment >= 0)
                        {




                            // «·„œ›Ê⁄
                            if (((DataRowView)invoicesBindingSource.Current)["InvTotalNet"] != DBNull.Value)
                            {

                                if (((DataRowView)invoicesBindingSource.Current)["InvPayment"] != DBNull.Value)
                                {
                                    ((DataRowView)invoicesBindingSource.Current)["InvPayment"] = (InvAllPayment + InvRemainPayment);// decimal.Parse(((DataRowView)invoicesBindingSource.Current)["InvPayment"].ToString()) + InvRemainPayment;
                                }
                                else
                                {
                                    ((DataRowView)invoicesBindingSource.Current)["InvPayment"] = InvRemainPayment;
                                }
                            }
                            // «·„ »ﬁÌ
                            if (((DataRowView)invoicesBindingSource.Current)["InvTotalNet"] != DBNull.Value)
                            {

                                ((DataRowView)invoicesBindingSource.Current)["CollectValue"] = Remain;

                            }
                            if (Remain <= 0)
                            {
                                ((DataRowView)invoicesBindingSource.Current)["PayFinish"] = true;
                            }
                            GetInvRemain();
                            CalInvTotal();

                            GetQid(InvCode, InvRemainPayment, Cust_Sup_Accid);
                            SaveChild();
                            ((DataRowView)invoicesBindingSource.Current)["ReferID"] = ((DataRowView)qidsBindingSource.Current)["qidid"];
                            ((DataRowView)invoicesBindingSource.Current)["OtherValue"] = txtRequired.Text;
                            invoicesBindingSource.EndEdit();
                            invoicesTableAdapter.Update(nEWERPDataSet.invoices);

                            txtInvPayment.Text = "";

                        }
                       

                    


                   
                }
                else
                {
                    MessageBox.Show("Â–Â «·›« Ê—… „”œœ… »«·ﬂ«„·", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                    //qidsTableAdapter.Update(nEWERPDataSet.qids);
                    //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                }
            }  
            
        }
        private void CalInvTotal()
        {
            decimal TotalRequiredvalue = 0;
            decimal TotalPaymentValue = 0;
            decimal TotalRemainInvoicevalue = 0;
            for (int i = 0; i < invoicesBindingSource.Count; i++)
            {
                if (InvoiceDGView.Rows[i].Cells["CollectValue"].Value != null && InvoiceDGView.Rows[i].Cells["CollectValue"].Value != DBNull.Value)
                {
                    TotalRequiredvalue = TotalRequiredvalue + decimal.Parse(InvoiceDGView.Rows[i].Cells["CollectValue"].Value.ToString());
                }
                if (InvoiceDGView.Rows[i].Cells["CurpaymentValue"].Value != null && InvoiceDGView.Rows[i].Cells["CurpaymentValue"].Value !=DBNull.Value)
                   {
                       TotalPaymentValue = TotalPaymentValue + decimal.Parse(InvoiceDGView.Rows[i].Cells["CurpaymentValue"].Value.ToString());
                   }
            }
            if (invoicesBindingSource.Count > 0)
            {
                if (((DataRowView)invoicesBindingSource.Current)["CollectValue"] != null && ((DataRowView)invoicesBindingSource.Current)["CollectValue"] != DBNull.Value)
                {
                    TotalRemainInvoicevalue = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["CollectValue"].ToString());
                }
            }

            txtRequired.Text = Math.Round(TotalRemainInvoicevalue, 3).ToString();
            txtPaymented.Text = Math.Round (TotalPaymentValue,3).ToString();
            
        }
        private Boolean SaveChild()
        {
            this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.qidsRow master = (NEWERPDataSet.qidsRow)(((DataRowView)qidsBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.qidsDetailsRow detail = (NEWERPDataSet.qidsDetailsRow)(((DataRowView)qidsDetailsBindingSource.Current).Row);
            // Save the master row
            qidsBindingSource.EndEdit();
            qidsTableAdapter.Update(nEWERPDataSet.qids );//master);
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row
            if (detail.qidid != master.qidid)
            {
                qidsDetailsBindingSource.Filter = "qidid =" + detail.qidid.ToString(); // +" and (QidType=" + GLibrary.strarrQidTypes[6, 0] + ")";
                int Icount = qidsDetailsBindingSource.Count;
                for (int i = 0; i < Icount; i++)
                {
                    ((DataRowView)qidsDetailsBindingSource[0])["qidid"] = master.qidid;
                }
            }
            //detail.qidid  = master.qidid;
            // Save the child row
            qidsDetailsBindingSource.EndEdit();
            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            //qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + master.qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0]; ;
            //"FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0];
            //detail.qidid  = master.qidid;
            // Save the child row

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            GLibrary.MsgSave();
            return true;

        }
        private void GetQid(string InvCode,decimal InvValue,int Cust_Sup_Accid)
        {
           string Desc = /*Environment.NewLine +*/        " «·„»·€ «·„ »ﬁÌ : " + txtRequired.Text + ":";
           string Invcode = " "+ ((DataRowView)invoicesBindingSource.Current)["InvCode"].ToString(); 
            decimal Value = InvValue; //decimal.Parse(txtInvPayment.Text);
            int AccountIdTo;
            int AccountIdFrom;

            AccountIdFrom = Cust_Sup_Accid; // int.Parse(CmbCustSupAccid.SelectedValue.ToString()); //Õ”«» «·⁄„Ì·
            
           // AccountIdTo = Messages.salesaccid; // Õ”«» «·„»Ì⁄« 
            AccountIdTo = Messages.salesAgalaccid;

           // if (qidsBindingSource.Count == 0)
           // {
                QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
                qidsBindingSource.AddNew();
                ((DataRowView)qidsBindingSource.Current).BeginEdit();
                ((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + QidLastIden.ToString ();// QidId.ToString();
                ((DataRowView)qidsBindingSource.Current)["qidDate"] = DateTime.Today;
                ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[6, 0]; // GLibrary.strarrQidTypes[9, 0].ToString(); 
                ((DataRowView)qidsBindingSource.Current)["InvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
                ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranch.SelectedValue;
                ((DataRowView)qidsBindingSource.Current)["description"] = txtNotes.Text + Invcode + Desc;

                if (BoxRdBtn.Checked)
                {
                    ((DataRowView)qidsBindingSource.Current)["PaymentType"] = Boolean.FalseString;
                }
                else if (BankRdBtn.Checked)
                {
                    ((DataRowView)qidsBindingSource.Current)["PaymentType"] = Boolean.TrueString;
                }
                if (BankRdBtn.Checked)
                {
                    ((DataRowView)qidsBindingSource.Current)["ChequeNo"] = txtChequeNo.Text;
                    if (CmbBanks.SelectedValue != null)
                    {
                        ((DataRowView)qidsBindingSource.Current)["BankAccId"] = int.Parse(CmbBanks.SelectedValue.ToString());
                    }   
                }
                if (CmbEmp.SelectedValue != null)
                {
                    ((DataRowView)qidsBindingSource.Current)["EmpId"] = int.Parse(CmbEmp.SelectedValue.ToString());
                }
                ((DataRowView)qidsBindingSource.Current).EndEdit();
           // }

            Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            if (qidsBindingSource.Count > 0)
            {
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                qidsDetailsBindingSource.Filter = "qidid=" + qidid.ToString();
            }

            //int i = 0;
            //int pos = -1;
          
            //  œ«∆‰ Ê„œÌ‰ ›Ï Õ«·… ⁄œ„ ÊÃÊœ œ›⁄… «Ê Œ’„ 
            //pos = qidsDetailsBindingSource.Find("ActionType", 1); // „œÌ‰  «·’‰œﬁ 
            //if (pos == -1)
            //{
                qidsDetailsBindingSource.AddNew();
                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
           // }
           // else
           // {
               // qidsDetailsBindingSource.Position = pos;
           // }
            ((DataRowView)qidsBindingSource.Current).BeginEdit();
            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = Value;
            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo;
            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[9, 0];
            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = " Õ’Ì· ›« Ê—… „»Ì⁄«  —ﬁ„" + Invcode + Desc;
            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



            //pos = qidsDetailsBindingSource.Find("ActionType", 5);  // œ«∆‰ «·⁄„Ì·

           // if (pos == -1)
          //  {
                qidsDetailsBindingSource.AddNew();
                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
           // }
          //  else
          //  {
          //      qidsDetailsBindingSource.Position = pos;
           // }

            ((DataRowView)qidsBindingSource.Current).BeginEdit();
            ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = Value;
            //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[6, 0];//GLibrary.strarrQidTypes[9, 0];
            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = " Õ’Ì· ›« Ê—… „»Ì⁄«  —ﬁ„" + Invcode + Desc;
            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 4;
            //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



            //---------------------------------- ﬁÌœ «‰ ﬁ«·Ï
            qidsDetailsBindingSource.AddNew();
            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
            ((DataRowView)qidsBindingSource.Current).BeginEdit();
            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = Value;
            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)FromValueAcc; // // «·’‰Êﬁ «Ê «·»‰ﬂ
            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[6, 0]; // GLibrary.strarrQidTypes[9, 0];
            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = " Õ’Ì· ›« Ê—… „»Ì⁄«  —ﬁ„" + Invcode + Desc;
            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



            //pos = qidsDetailsBindingSource.Find("ActionType", 5);  // œ«∆‰ «·⁄„Ì·

            // if (pos == -1)
            //  {

            // Õ—ﬂ… «·„»Ì⁄«  «·«Ã·…
            //qidsDetailsBindingSource.AddNew();
            //((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
            

            //((DataRowView)qidsBindingSource.Current).BeginEdit();
            //((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = Value;
            ////((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
            //((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo; //«·„»Ì⁄«  «·«Ã·…
            //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
            //((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[9, 0];
            //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = " Õ’Ì· ﬁ« Ê—… „»Ì⁄« ";
            //((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
            ////((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
            //((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


            //------------------------


            qidsDetailsBindingSource.Sort = "ActionType";
        }

        private void InvoiceDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
           // e.Row.Cells["CmbInvPay"].Value = 1;
        }

        private void InvoiceDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            InvoiceDGView.Rows[e.RowIndex].Cells["CmbInvPay"].Value = 1;

        }

        private void InvoiceDGView_SelectionChanged(object sender, EventArgs e)
        {
            //if (flag)
            //{
            //    GetInvRemain();
            //}
        }

       
        private void GetInvRemain()
        {
            if (invoicesBindingSource.Count > 0)
            {
            //for (int i = 0; i < invoicesBindingSource.Count; ++i)
            //{
               
                    long InvId = long.Parse(((DataRowView)invoicesBindingSource.Current)["InvId"].ToString());
                    string InvTotalNet = ((DataRowView)invoicesBindingSource.Current)["InvTotalNet"].ToString();
                    string Remain = ((DataRowView)invoicesBindingSource.Current)["CollectValue"].ToString();

                
                    decimal InvPayment;
                    //InvPayment = decimal.Parse(invoicesTableAdapter.GetCustTotalPayment(InvId, 4).ToString()); // «·œ›⁄…

                    //decimal Remain = decimal.Parse(InvTotalNet) - InvPayment;
                    //if (Remain == 0)
                    //{
                    //    lblInvRemain.Text = "";
                    //}
                    //else
                    //{
                    //    lblInvRemain.Text = Remain.ToString();
                    //}
                    //if (InvoiceDGView.SelectedRows.Count > 0)
                    //{
                        //int i = InvoiceDGView.SelectedRows[0].Index;
                    int i = invoicesBindingSource.Position;
                    if (Remain != "")
                    {
                        //if (decimal.Parse(Remain) == 0)
                        //{
                        //    InvoiceDGView.Rows[i].Cells["CollectValue"].Value = InvTotalNet.ToString();
                        //}
                        //else
                        //{
                            InvoiceDGView.Rows[i].Cells["CollectValue"].Value = Remain.ToString();
                       // }
                    }
                    else
                    {
                        InvoiceDGView.Rows[i].Cells["CollectValue"].Value = InvTotalNet.ToString();
                    }

                    //}

                //}
            
            }
        }

        private void BoxRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxRdBtn.Checked)
            {
                CmbBanks.Enabled = false;
                //if (CmbBanks.Items.Count  >0)
                //{
                //    CmbBanks.SelectedIndex = 0;
                //}
                txtChequeNo.Enabled = false ;
                CmbBanks.SelectedValue = -1;
                //txtChequeNo.Visible = false;
                //txtChequeNo.Width = 0;
                //txtChequeNo.Text = "";
                //label1.Visible = false;
                //label2.Visible = false;
                //txtBoxAcc.Text = Messages.boxAccid.ToString();
                FromValueAcc = int.Parse(Messages.boxAccid.ToString());
            }
        }

        private void BankRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BankRdBtn.Checked)
            {
                CmbBanks.Enabled  = true;
                //if (CmbBanks.Items.Count  >0)
                //{
                //    CmbBanks.SelectedIndex = 0;
                //}
                txtChequeNo.Enabled  = true;
                //txtChequeNo.Width = 170;
                //label1.Visible = true;
                //label2.Visible = true;
                //txtChequeNo.Text = "";

                if (CmbBanks.SelectedValue != null)
                {
                    //txtBankAcc.Text = CmbBanks.SelectedValue.ToString();
                    FromValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); //int.Parse (txtBankAcc.Text);
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            QidInAdd frm = new QidInAdd();
            frm.PrintFlag = true;
            long InvId = long.Parse(((DataRowView)invoicesBindingSource.Current )["InvId"].ToString());
            frm.InvId = InvId;
            if (((DataRowView)invoicesBindingSource.Current)["ReferID"] != DBNull .Value )
            {
                 frm.qidid = long.Parse(((DataRowView)invoicesBindingSource.Current)["ReferID"].ToString());
                 frm.PrintFlag = false;
            }
            else
            {
                frm.PrintFlag = true;
            }
            frm.EditFlag = true;
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SearchInvoice();
        }
        private void SearchInvoice()
        {
            invoicesTableAdapter.Fill(this.nEWERPDataSet.invoices);

            GetInvoices();
            if (invoicesBindingSource.Count > 0)
            {
                GetInvRemain();
                CalInvTotal();

            }
        }
           
    }
 
}