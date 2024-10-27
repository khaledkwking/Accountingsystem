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
    public partial class QidOutAdd : DockContent
    {
        public string temp = "";
        private int LastIden = -1;
        private int DetLastIden = -1;
        public Boolean EditFlag = false;
        private int ToValueAcc;
        private DateTime lastDataError = DateTime.MinValue;
        private NEWERPDataSet TempnEWERPDataSet = new NEWERPDataSet();
        long FirstCode = 0;
        public long qidid = 0;
        public Boolean PrintFlag = false;
        public long InvId = 0;
        private NEWERPDataSetTableAdapters.qidsDetailsTableAdapter TempqidsDetailsTableAdapter = new NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
        public QidOutAdd()
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
            qidsBindingSource.CancelEdit();
            qidsDetailsBindingSource.CancelEdit();
            this.Close();
        }


        private void AddNew()
        {
            qidsBindingSource.CurrencyManager.AddNew();
            Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[5, 0];

            //qidsDetailsBindingSource.Filter = "ToValue is not null"; 
            //CmdSave.Text = "Õ›Ÿ";
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }

            qidDateDateTimePicker.Value = DateTime.Today;
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();
            txtrecitetype.Text = GLibrary.strarrQidTypes[5, 0].ToString();
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
            }
            //qidcodeTextBox.Text = Messages.SysQidOut  + (LastIden+1).ToString();
            //string QidInSerial = nEWERPDataSet.SetupCodes.Rows[0]["OutQidSerial"].ToString();
            //qidcodeTextBox.Text = (int.Parse(QidInSerial) + 1).ToString(); // Messages.SysQidIn + QidInSerial; //(LastIden + 1).ToString();
            long QidSeial = 0;
            long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[5, 0]));
            QidSeial = MaxSerial + 1;
            qidcodeTextBox.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
            FirstCode = QidSeial;
            txtQidSerial.Text = QidSeial.ToString();


            if (Messages.CurBranch != "")
            {
                CmbBranch.SelectedValue = Messages.CurBranch;
            }
            EditFlag = false;
            CmdAdd.Enabled = false;
            BtnPrint.Enabled = false;
            CmdDel.Enabled = false;
            btnRefresh.Enabled = false;
            CmdSave.Enabled = true;

            BoxRdBtn.Checked = true;
            txtChequeNo.Visible = false;
            CmbBanks.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            txtTotalToValue.Text = "";

        }



        private void CmdAdd_Click(object sender, EventArgs e)
        {

            AddNew();
            SetPermission();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            qidsBindingSource.CancelEdit();
            qidsDetailsBindingSource.CancelEdit();
            errorProvider1.Clear();
            this.Close();
        }

        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {

                if (qidsBindingSource.Count == 1 && ((DataRowView)qidsBindingSource.Current)["qidid"].ToString() == "0")
                {
                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(LastIden + 1);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + qidid.ToString() + "and QidType=" + GLibrary.strarrQidTypes[5, 0];


            }
        }

        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSource.Count == 1 && ((DataRowView)qidsDetailsBindingSource.Current)["id"].ToString() == "0")
            {
                ((DataRowView)qidsDetailsBindingSource.Current)["id"] = (Int64)(DetLastIden + 1);
            }
            if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            {
                if (((DataRowView)qidsDetailsBindingSource.Current).IsNew)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["Detcode"] = ((DataRowView)qidsDetailsBindingSource.Current)["id"];
                }
                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");


            }
        }


        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            SaveAll(false);
            SetPermission();
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
            qidsTableAdapter.Update(master);
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row


            if (detail.qidid != master.qidid)
            {
                qidsDetailsBindingSource.Filter = "qidid =" + detail.qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[5, 0] + ")";

                int icount = qidsDetailsBindingSource.Count;

                //for (int i = 0; i < icount; i++)
                while (qidsDetailsBindingSource.Count > 0)
                {
                    ((DataRowView)qidsDetailsBindingSource[0])["qidid"] = master.qidid;
                    qidsDetailsBindingSource.EndEdit();
                }

                //for (int i = 0; i < icount; i++)
                //{
                //    ((DataRowView)qidsDetailsBindingSource[0])["qidid"] = master.qidid;

                //}
            }

            //detail.qidid  = master.qidid;
            // Save the child row
            qidsDetailsBindingSource.EndEdit();
            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + master.qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[5, 0]; ;
            //detail.qidid  = master.qidid;
            // Save the child row

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private void SaveQidsDet()
        {
            int icount = qidsDetailsBindingSource.Count;
            Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

            for (int i = 0; i < icount; i++)
            {
                //if (((DataRowView)qidsDetailsBindingSource[i]))
                //{

                //((DataRowView)qidsDetailsBindingSource[i])["Detcode"] = ((DataRowView)qidsDetailsBindingSource[i])["ID"];
                if (!EditFlag)
                {
                    ERPSYS.NEWERPDataSet.qidsDetailsRow DetRow = nEWERPDataSet.qidsDetails.NewqidsDetailsRow();
                    DetRow.FromValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["ToValue"];

                    DetRow.ACCOUNTID = ToValueAcc;// Messages.bankaccid;
                    DetRow["EnterDate"] = ((DataRowView)qidsDetailsBindingSource[i])["EnterDate"];
                    DetRow["qidid"] = ((DataRowView)qidsDetailsBindingSource[i])["qidid"];
                    DetRow["Description"] = ((DataRowView)qidsDetailsBindingSource[i])["Description"];
                    DetRow["Detcode"] = ((DataRowView)qidsDetailsBindingSource[i])["Detcode"];
                    DetRow["QidType"] = ((DataRowView)qidsDetailsBindingSource[i])["QidType"];
                    nEWERPDataSet.qidsDetails.AddqidsDetailsRow(DetRow);
                }
                else
                {
                    int detCode = int.Parse(((DataRowView)qidsDetailsBindingSource[i])["Detcode"].ToString());
                    int Id = int.Parse(((DataRowView)qidsDetailsBindingSource[i])["id"].ToString());
                    decimal ToValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["ToValue"];
                    string Desc = ((DataRowView)qidsDetailsBindingSource[i])["Description"].ToString();
                    int pos = qidsDetailsBindingSource.Position;
                    qidsDetailsBindingSource.RemoveFilter();
                    qidsDetailsBindingSource.Filter = "Detcode=" + detCode.ToString() + " and id <>" + Id.ToString();
                    if (qidsDetailsBindingSource.Count > 0)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current).Row.BeginEdit();
                        ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = ToValue;
                        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = ToValueAcc;
                        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
                        ((DataRowView)qidsDetailsBindingSource.Current).Row.EndEdit();
                    }
                    else
                    { //new Qid Details
                        qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[5, 0];
                        qidsDetailsBindingSource.Position = pos;

                        ERPSYS.NEWERPDataSet.qidsDetailsRow DetRow = nEWERPDataSet.qidsDetails.NewqidsDetailsRow();
                        DetRow.FromValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["ToValue"];

                        DetRow.ACCOUNTID = ToValueAcc;// Messages.bankaccid;
                        DetRow["EnterDate"] = ((DataRowView)qidsDetailsBindingSource[i])["EnterDate"];
                        DetRow["qidid"] = ((DataRowView)qidsDetailsBindingSource[i])["qidid"];
                        DetRow["Description"] = ((DataRowView)qidsDetailsBindingSource[i])["Description"];
                        DetRow["Detcode"] = ((DataRowView)qidsDetailsBindingSource[i])["Detcode"];
                        DetRow["QidType"] = ((DataRowView)qidsDetailsBindingSource[i])["QidType"];
                        nEWERPDataSet.qidsDetails.AddqidsDetailsRow(DetRow);
                    }
                    qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[5, 0];
                    qidsDetailsBindingSource.Position = pos;
                }
                //}

            }
            qidsDetailsBindingSource.Filter = "ToValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[5, 0]; ;
        }
        private void SaveAll(Boolean bflag)
        {
            if (GLibrary.MsgCheckSave(bflag))
            {
                try
                {
                    if (BoxRdBtn.Checked) //«·’‰œÊﬁ
                    {
                        if (comboBoxMain.SelectedValue != null)
                        {
                            ToValueAcc = int.Parse(comboBoxMain.SelectedValue.ToString()); // Messages.bankaccid;
                        }
                        else
                        {
                            MessageBox.Show(Messages.QidNotBankfoundMesg, "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            return;
                        }
                        //ToValueAcc = Messages.boxAccid;
                    }
                    else if (BankRdBtn.Checked) // «·»‰ﬂ
                    {
                        if (CmbBanks.SelectedValue != null)
                        {
                            ToValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); // Messages.bankaccid;
                        }
                        else
                        {
                            MessageBox.Show(Messages.QidNotBankfoundMesg, "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            return;
                        }
                    }
                    if (qidsDetailsBindingSource.Count > 0 && !StockDGView.IsCurrentRowDirty)
                    {
                        if (GLibrary.IsNumeric(qidcodeTextBox.Text))
                        {
                            if (GLibrary.IsDate(txtQidDate.Text))
                            {
                                if (CheckQidNo() == 1)
                                {
                                    //if (!EditFlag)
                                    //{
                                    //    string QidInSerial = nEWERPDataSet.SetupCodes.Rows[0]["OutQidSerial"].ToString();
                                    //    qidcodeTextBox.Text = (int.Parse(QidInSerial) + 1).ToString();
                                    //}
                                    long QidSeial = 0;
                                    if (!EditFlag)
                                    {
                                        long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[5, 0]));
                                        //QidSeial = int.Parse(nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"].ToString());
                                        QidSeial = MaxSerial + 1;

                                        if (long.Parse(qidcodeTextBox.Text) > QidSeial)
                                        {
                                            QidSeial = long.Parse(qidcodeTextBox.Text);
                                            txtQidSerial.Text = QidSeial.ToString();
                                        }
                                        else
                                        {
                                            if (long.Parse(qidcodeTextBox.Text) < FirstCode)
                                            {
                                                txtQidSerial.Text = qidcodeTextBox.Text;
                                            }
                                            else
                                            {
                                                qidcodeTextBox.Text = QidSeial.ToString();
                                                txtQidSerial.Text = QidSeial.ToString();
                                            }
                                            //if (QidSeial)
                                            //qidcodeTextBox.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
                                        }

                                    }
                                    if (CheckCode(qidcodeTextBox.Text, int.Parse(GLibrary.strarrQidTypes[5, 0].ToString())))
                                    {
                                        if (BoxRdBtn.Checked)
                                        {
                                            ((DataRowView)qidsBindingSource.Current)["PaymentType"] = false;
                                        }
                                        else if (BankRdBtn.Checked)
                                        {
                                            ((DataRowView)qidsBindingSource.Current)["PaymentType"] = true;
                                        }
                                        txtUserId.Text = Messages.CurUserId;
                                        //this.Validate();

                                        SaveQidsDet();
                                        SaveChild();
                                        //qidsBindingSource.EndEdit();
                                        //qidsDetailsBindingSource.EndEdit();
                                        if (!EditFlag)
                                        {
                                            nEWERPDataSet.SetupCodes.Rows[0]["OutQidSerial"] = qidcodeTextBox.Text;
                                            setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                            //if (BankRdBtn.Checked && GLibrary.IsNumeric(txtChequeNo.Text))
                                            //{
                                            //    long ChequeNo = long.Parse(((DataRowView)accountingBindingSourceBank.Current)["CurId"].ToString());
                                            //    ChequeNo = ChequeNo + 1;
                                            //    txtChequeNo.Text = ChequeNo.ToString();
                                            //}
                                            //if (BankRdBtn.Checked && GLibrary.IsNumeric (txtChequeNo.Text))
                                            //{
                                            //    nEWERPDataSet.BRANCHES.Rows[0]["OrderSerial"] = txtChequeNo.Text;
                                            //    bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);
                                            //}
                                        }
                                        CmdAdd.Enabled = true;
                                        BtnPrint.Enabled = true;
                                        CmdDel.Enabled = true;
                                        btnRefresh.Enabled = true;
                                        CmdSave.Enabled = true;
                                        EditFlag = true;
                                        //qidsTableAdapter.Update(nEWERPDataSet.qids);


                                        //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                                        GLibrary.MsgSave();

                                        if (Messages.CurLang == Messages.ArabLang)
                                        {
                                            CmdSave.Text = " ⁄œÌ·";

                                        }
                                        else if (Messages.CurLang == Messages.EngLang)
                                        {
                                            CmdSave.Text = "ÚıEdit";
                                        }

                                        errorProvider1.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("—ﬁ„ «·„” ‰œ „ÊÃÊœ ”«»ﬁ«", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("«œŒ·  «—ÌŒ «·ﬁÌœ »ÿ—Ìﬁ… ’ÕÌ’…", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }

                        }
                        else
                        {
                            MessageBox.Show("√œŒ· «·ﬂÊœ »ÿ—Ìﬁ… ”·Ì„…", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Messages.QidEmptyMesg, "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }
        private Boolean CheckCode(string QidCode, int QidType)
        {
            int Count = 0;
            Count = int.Parse(qidsTableAdapter.CheckQidCode(QidCode, QidType).ToString());
            if (Count > 0)
            {
                if (Count == 1 && EditFlag)
                {

                    //qidsBindingSource.EndEdit();
                    qidsBindingSourceSearch.Filter = "qidcode='" + QidCode.ToString() + "' and recitetype=" + QidType;
                    int icount = qidsBindingSourceSearch.Count;
                    if (icount == 1)
                    {
                        if (long.Parse(((DataRowView)qidsBindingSource.Current)["qidid"].ToString()) != long.Parse(((DataRowView)qidsBindingSourceSearch.Current)["qidid"].ToString()))
                        {
                            return false;
                        }
                    }

                    return true;
                }
                //if (!EditFlag)
                //{
                //    setupCodesTableAdapter.Fill(nEWERPDataSet.SetupCodes);
                //    qidcodeTextBox.Text = Convert.ToString(long.Parse(nEWERPDataSet.SetupCodes.Rows[0]["OutQidSerial"].ToString()) + 1);
                //    return true;
                //}
                else
                {
                    return false;
                }
            }
            return true;

        }




        private void BoxRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxRdBtn.Checked)
            {
                CmbBanks.Visible = false;
                CmbBanks.SelectedValue = -1;
                txtChequeNo.Visible = false;
                //txtChequeNo.Width = 0;
                //txtChequeNo.Text = "";
                label1.Visible = false;
                label2.Visible = false;
                // txtBoxAcc.Text = Messages.boxAccid.ToString();
                txtBoxAcc.Text = comboBoxMain.SelectedValue.ToString();
                ToValueAcc = int.Parse(txtBoxAcc.Text);
                //ToValueAcc = int.Parse(txtBoxAcc.Text);
            }
        }

        private void BankRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BankRdBtn.Checked)
            {
                CmbBanks.Visible = true;
                comboBoxMain.Visible = false;
                //if (CmbBanks.Items.Count > 0)
                //{
                //    CmbBanks.SelectedIndex = 0;
                //}
                txtChequeNo.Visible = true;
                //txtChequeNo.Width = 170;
                label1.Visible = true;
                label2.Visible = true;

                //if (((DataRowView)bRANCHESBindingSource.Current)["OrderSerial"] != DBNull.Value)
                //{
                //    int ChequeNo = int.Parse(((DataRowView)bRANCHESBindingSource.Current)["OrderSerial"].ToString());
                //    ChequeNo = ChequeNo + 1;
                //    txtChequeNo.Text = ChequeNo.ToString();
                //}

                //txtChequeNo.Text = "";
                if (CmbBanks.SelectedValue != null)
                {
                    txtBankAcc.Text = CmbBanks.SelectedValue.ToString();
                    ToValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); //int.Parse (txtBankAcc.Text);
                }
                //if (txtBankAcc.Text!="")   ToValueAcc = int.Parse(txtBankAcc.Text);
            }
        }
        private void SetPermission()
        {
            if (Messages.Usertype != Messages.AdminUser)
            {
                if (!Messages.SalQidOutPrim[1] && EditFlag)
                {
                    StockDGView.Enabled = false;
                    CmdSave.Enabled = false;

                }
                else
                {
                    StockDGView.Enabled = true;
                    CmdSave.Enabled = true;
                }
                if (!Messages.SalQidOutPrim[2] && EditFlag)
                {
                    //ProductsDGView.Enabled = false;
                    CmdDel.Enabled = false;
                }

            }

        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Machines' table. You can move, or remove it, as needed.
            //this.machinesTableAdapter.Fill(this.nEWERPDataSet.Machines);
            // TODO: This line of code loads data into the 'nEWERPDataSet.AccountingView' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.AccountingView' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            StockDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            foreach (DataGridViewRow row in StockDGView.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            LastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
            DetLastIden = int.Parse(qidsDetailsTableAdapter.GetQidsDetLastIdentity().ToString());

            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            qidsDetailsBindingSource.Filter = "ToValue is not null and QidType=" + GLibrary.strarrQidTypes[5, 0];

            if (!PrintFlag)
            {
                if (Messages.Usertype == 2)
                {
                    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString() + " And BrachId=" + Messages.CurBranch.ToString();
                    CmbBranch.Enabled = false;
                }
                else
                {
                    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString();
                }

            }
            else
            {
                qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString() + " and InvId=" + InvId.ToString();

            }


            //qidsDetailsBindingSource.Filter = "ToValue is not null and QidType=" + GLibrary.strarrQidTypes[5, 0];
            //if (Messages.Usertype == 2)
            //{
            //    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString() +" And BrachId=" + Messages.CurBranch.ToString();
            //    CmbBranch.Enabled = false;
            //}
            //else
            //{

            //    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString();
            //}


            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.
            if (Messages.boxAccid != null || Messages.boxAccid != 0)
            {
                int Pos = accountingBindingSource.Find("AccountId", Messages.boxAccid);
                if (Pos > -1)
                {
                    Boolean MainNode = Boolean.Parse(((DataRowView)accountingBindingSource[Pos])["MainNode"].ToString());
                    if (MainNode)
                    {
                        MessageBox.Show(Messages.InvalidBoxAccMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
            }

            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            accountingBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            accountingBindingSourceBank.Filter = "AccountparentId=" + Messages.bankaccid.ToString() + " or AccountId= " + Messages.bankaccid.ToString() + " and MainNode=false";
            accountingBindingSourceMain.Filter = "AccountparentId=" + Messages.accountidMainBox.ToString() + " or AccountId= " + Messages.accountidMainBox.ToString() + " and MainNode=false";
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            //nEWERPDataSet.qidsDetails.ToValueColumn.AllowDBNull = false; //impottant to required coulnm
            accountingBindingSource.Sort = "accountname";
            accountingBindingSourceBank.Sort = "accountname";
            txtBoxAcc.Text = Messages.boxAccid.ToString();
            if (!EditFlag)
            {
                AddNew();
                if (CmbBanks.Items.Count > 0)
                {
                    CmbBanks.SelectedIndex = 0;
                }

            }
            else
            {
                if (!PrintFlag)
                {
                    FindQid();
                }
                else
                {
                    qidsBindingSource.MoveLast();
                }
            }

            if (comboBoxMain.SelectedValue != null)
            {
                ToValueAcc = int.Parse(comboBoxMain.SelectedValue.ToString());
            }
            //int.Parse(txtBoxAcc.Text);

            //AddDataGridColumn();


            Messages.AccountFlag = 0;
            Messages.CostcenterFlag = 0;
            SetPermission();

        }
        private void FindQid()
        {
            int pos = qidsBindingSource.Find("qidid", qidid);
            if (pos != -1)
            {
                //if (GLibrary.MsgCheckSave(false))
                //{
                //    SaveAll(false);
                //}
                //else
                //{

                //    qidsBindingSource.CancelEdit();
                //    qidsDetailsBindingSource.CancelEdit();

                //}
                //CheckSave();

                qidsBindingSource.Position = pos;
                MoveNextChange();
                CmdAdd.Enabled = true;
                btnRefresh.Enabled = true;
                if (Messages.CurLang == Messages.ArabLang)
                {
                    CmdSave.Text = " ⁄œÌ·";

                }
                else if (Messages.CurLang == Messages.EngLang)
                {
                    CmdSave.Text = "Edit";
                }

                EditFlag = true;
                SetPermission();
            }
            else
            {
                MessageBox.Show(Messages.QidNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //qidcodeTextBox.Text = oldvalue;
            }

        }
        private void QidOutAdd_Activated(object sender, EventArgs e)
        {
            if (Messages.AccountFlag == 1)
            {
                this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
                Messages.AccountFlag = 0;

            }
            if (Messages.CostcenterFlag == 1)
            {
                this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
                Messages.CostcenterFlag = 0;

            }
        }

        private void GetSum()
        {
            DataView list = (DataView)qidsDetailsBindingSource.List;
            DataTable T = list.ToTable();
            decimal Tovalue = 0;
            for (int i = 0; i < T.Rows.Count; i++)
            {

                if (GLibrary.IsNumeric(T.Rows[i]["ToValue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                }

            }
            txtTotalToValue.Text = Tovalue.ToString();

        }

        private void StockDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == AccountName.Index)
            {
                // Set the combobox cell datasource to the filtered BindingSource
                DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)StockDGView[e.ColumnIndex, e.RowIndex];
                //dgcb.DataSource = productUnitsPricesBindingSource;
                // Filter the BindingSource based upon the region selected
                int pos = accountingBindingSource.Find("accountname", e.FormattedValue);
                if (pos > -1)
                {
                    accountingBindingSource.Position = pos;
                    int Accountid = int.Parse(((DataRowView)accountingBindingSource.Current)["accountid"].ToString());
                    dgcb.Value = Accountid.ToString();
                    StockDGView[ACCOUNTCODE.Index, e.RowIndex].Value = Accountid.ToString();
                    // ((DataRowView)qidsDetailsBindingSource.Current)["accountid"] = Accountid.ToString();

                }
                //else
                //{

                //    dgcb.Value = "";
                //    ((DataRowView)qidsDetailsBindingSource.Current)["accountid"] = DBNull .Value ;
                //}
            }
            if (e.ColumnIndex == ACCOUNTCODE.Index)
            {
                // Set the combobox cell datasource to the filtered BindingSource
                DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)StockDGView[e.ColumnIndex, e.RowIndex];
                //dgcb.DataSource = productUnitsPricesBindingSource;
                // Filter the BindingSource based upon the region selected
                int pos = accountingBindingSource.Find("AccountCode", e.FormattedValue);
                if (pos > -1)
                {
                    accountingBindingSource.Position = pos;
                    int Accountid = int.Parse(((DataRowView)accountingBindingSource.Current)["accountid"].ToString());
                    dgcb.Value = Accountid.ToString();
                    StockDGView[AccountName.Index, e.RowIndex].Value = Accountid.ToString();

                }
                //else
                //{

                //    dgcb.Value = "";
                //    ((DataRowView)qidsDetailsBindingSource.Current)["accountid"] = DBNull.Value;
                //}
            }
            //if (e.ColumnIndex == Description.Index)
            //{
            //    temp = e.FormattedValue.ToString();
            //}


        }



        private void StockDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            if (StockDGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

            //TimeSpan sinceLast = DateTime.Now - lastDataError;
            //lastDataError = DateTime.Now;
            //string message;
            //if (null == e.Exception)

            //    message = "Bad value.";

            //else
            //{
            //    message = e.Exception.Message;
            //    if (e.Exception is System.Reflection.TargetInvocationException)
            //        if (e.Exception.InnerException is FormatException)
            //            message = "Bad value format. Check the type of value entered.";
            //}

            //StockDGView.Rows[e.RowIndex].ErrorText = message;

            //if (sinceLast.TotalSeconds < 1.0)

            //    MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            //else

            //    SystemSounds.Beep.Play();
        }

        private void StockDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            StockDGView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void StockDGView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;

                if (dgv.CurrentCell.OwningColumn.Name == "Machineid" || dgv.CurrentCell.OwningColumn.Name == "AccountName" || dgv.CurrentCell.OwningColumn.Name == "CostId" || dgv.CurrentCell.OwningColumn.Name == "ACCOUNTCODE")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }

        private void StockDGView_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {

            if (StockDGView.Rows.Count > 0)
            {
                if (StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != DBNull.Value && StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != null)
                {
                    GetSum();
                }
            }
        }

        private void StockDGView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

            if (qidsDetailsBindingSource.Count > 0)
            {

                Boolean ErrFlag = false;
                if (StockDGView.IsCurrentRowDirty == true)
                {

                    // Set the combobox cell datasource to the filtered BindingSource
                    DataGridViewTextBoxCell dgtxtBox = (DataGridViewTextBoxCell)StockDGView["toValueDataGridViewTextBoxColumn", e.RowIndex];
                    DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)StockDGView["AccountName", e.RowIndex];
                    if (dgtxtBox.Value == null || dgcb.Value == null) { ErrFlag = true; }
                    if ((!GLibrary.IsNumeric(dgtxtBox.Value.ToString()) || !GLibrary.IsNumeric(dgcb.Value.ToString())))
                    {
                        ErrFlag = true;

                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    if (ErrFlag)
                    {
                        StockDGView.Rows[e.RowIndex].ErrorText = "√œŒ· „Õ ÊÌ«  «·”‰œ »ÿ—Ìﬁ… ’ÕÌÕ… ";
                        e.Cancel = true;
                        errorProvider1.SetError(StockDGView, "√œŒ· „Õ ÊÌ«  «·”‰œ »ÿ—Ìﬁ… ’ÕÌÕ…");
                        if (dgtxtBox.Value == null)
                        {
                            StockDGView.Rows[e.RowIndex].Cells["toValueDataGridViewTextBoxColumn"].ErrorText = "„‰ ›÷·ﬂ «œŒ· «·„»·€ «·„œ›Ê⁄ ";
                        }
                        else if (!GLibrary.IsNumeric(dgtxtBox.Value.ToString()))
                        {
                            StockDGView.Rows[e.RowIndex].Cells["toValueDataGridViewTextBoxColumn"].ErrorText = "„‰ ›÷·ﬂ «œŒ· «·„»·€ «·„œ›Ê⁄ ";
                        }

                        if (dgcb.Value == null)
                        {
                            StockDGView.Rows[e.RowIndex].Cells["AccountName"].ErrorText = "„‰ ›÷·ﬂ «œŒ· «·Õ”«» ";
                        }
                        else if (!GLibrary.IsNumeric(dgcb.Value.ToString()))
                        {
                            StockDGView.Rows[e.RowIndex].Cells["AccountName"].ErrorText = "„‰ ›÷·ﬂ «œŒ· «·Õ”«» ";
                        }
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }

                }
                else
                {
                    errorProvider1.Clear();
                }
            }

        }

        private void StockDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            StockDGView.Rows[e.RowIndex].ErrorText = String.Empty;
            if (e.ColumnIndex == Description.Index)
            {
                temp = StockDGView[Description.Index, e.RowIndex].Value.ToString();
                //temp = e.FormattedValue.ToString();
            }

        }

        private void StockDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Description"].Value = "”‰œ ’—›";
            e.Row.Cells["QidType"].Value = GLibrary.strarrQidTypes[5, 0].ToString();
            e.Row.Cells["Description"].Value = temp;
            //e.Row.Cells["EnterDateQid"].Value = DateTime.Today.ToString("dd/MM/yyyy"); 
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSource.Count > 0)
            {
                ShowRpt Showfrm = new ShowRpt();
                long QidId;
                QidId = long.Parse(((DataRowView)qidsBindingSource.Current)["qidid"].ToString());

                this.accountingViewTableAdapter.FillByPayQidid(this.nEWERPDataSet.AccountingView, QidId);

                Showfrm.qidcode = ((DataRowView)qidsBindingSource.Current)["qidcode"].ToString();
                Showfrm.ChequeNo = ((DataRowView)qidsBindingSource.Current)["ChequeNo"].ToString();
                if (BoxRdBtn.Checked)
                {
                    Showfrm.BankName = comboBoxMain.Text;

                }
                else
                {
                    Showfrm.BankName = CmbBanks.Text;
                }
                if (CmbBanks.SelectedValue != null)
                {
                    if (accountingBindingSourceBank.Position > -1)
                    {
                        Showfrm.BankCode = ((DataRowView)accountingBindingSourceBank.Current)["accountCode"].ToString();

                    }
                }


                double Value = double.Parse(txtTotalToValue.Text); // double.Parse(((DataRowView)qidsDetailsBindingSource.Current)["ToValue"].ToString());
                Showfrm.ToValue = GLibrary.FigureInWordsNumType(Value, 1);
                Showfrm.AccountName = txtPayTo.Text;

                //string AccountId =((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"].ToString();
                //int pos = accountingBindingSource.Find("accountid", AccountId);
                //if (pos > -1)
                //{
                // ((DataRowView)accountingBindingSource[pos])["accountname"].ToString();
                //}
                Showfrm.Description = ((DataRowView)qidsBindingSource.Current)["Notes"].ToString();
                Showfrm.QidDate = ((DataRowView)qidsBindingSource.Current)["qidDate"].ToString();

                string v = Value.ToString();
                v = String.Format("{0:c}", v);
                string[] p = new string[10];
                // define which character is seperating fields
                char[] splitter = { '.' };
                p = v.Split(splitter);
                //string [] p  = v.Split(new Char[], ".") ;
                string ii = "0", dd = "0";
                if (p.Length == 2)
                {
                    ii = p[0];
                    dd = p[1];
                }
                else if (p.Length == 1)
                {
                    ii = p[0];
                    dd = "0";
                }
                if (BoxRdBtn.Checked)
                {
                    Showfrm.QidTypeDesc = "‰ﬁœ«";
                    Showfrm.QidEngTypeDesc = "CASH";

                }
                else
                {
                    Showfrm.QidTypeDesc = "‘Ìﬂ";
                    Showfrm.QidEngTypeDesc = "CHEQUE";
                }
                Showfrm.nEWERPDataSet = nEWERPDataSet;
                Showfrm.Fils = string.Format("{0:000}", dd);
                Showfrm.Dinar = ii;
                Showfrm.TotPrice = decimal.Parse(txtTotalToValue.Text);

                Showfrm.choiceNum = 1;
                Showfrm.Show();

                //newContactRow("fils") = Format(dd, "000")
                //newContactRow("kd") = ii
                //      qidcode;
                // QidDate;
                // AccountName;
                // ToValue;
                //ChequeNo;
                // BankName;
                // Description;
                // Fils;
                // Dinar;
            }
        }

        private void qidcodeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string oldvalue = "";
                if (qidsBindingSource.Count > 0)
                {
                    oldvalue = ((DataRowView)qidsBindingSource.Current)["qidcode"].ToString();

                }

                int pos = qidsBindingSource.Find("qidcode", qidcodeTextBox.Text);
                if (pos != -1)
                {
                    //if (GLibrary.MsgCheckSave(false))
                    //{
                    //    SaveAll(false);
                    //}
                    //else
                    //{

                    //    qidsBindingSource.CancelEdit();
                    //    qidsDetailsBindingSource.CancelEdit();

                    //}
                    CheckSave();
                    EditFlag = true;
                    //MoveNextChange();
                    qidsBindingSource.Position = pos;
                    CmdAdd.Enabled = true;
                    btnRefresh.Enabled = true;
                    // setbank();
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSave.Text = " ⁄œÌ·";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSave.Text = "Edit";
                    }

                    EditFlag = true;
                    SetPermission();
                }
                else
                {
                    MessageBox.Show(Messages.QidNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    qidcodeTextBox.Text = oldvalue;

                }

            }
        }



        private void StockDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //StockDGView.Rows[e.RowIndex].HeaderCell.Value = (StockDGView.RowCount).ToString();
        }

        private void qidDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();
            txtQidDate.Focus();
        }

        //private void CheckSave()
        //{
        //    if (GLibrary.MsgCheckSave(false))
        //    {
        //        SaveAll();

        //    }
        //    else
        //    {

        //        qidsBindingSource.CancelEdit();
        //        qidsDetailsBindingSource.CancelEdit();
        //        nEWERPDataSet.qids.RejectChanges();
        //        nEWERPDataSet.qidsDetails.RejectChanges();

        //        if (!EditFlag)
        //        {
        //            CmdAdd.Enabled = true;
        //            //CmdDel.Enabled = true;
        //            EditFlag = true;
        //            if (Messages.CurLang == Messages.ArabLang)
        //            {
        //                CmdSave.Text = " ⁄œÌ·";

        //            }
        //            else if (Messages.CurLang == Messages.EngLang)
        //            {
        //                CmdSave.Text = "ÚıEdit";
        //            }
        //            //CmdSave.Text = " ⁄œÌ·";
        //        }


        //    }
        //    MoveNextChange();
        //}
        private void CheckSave()
        {
            DataRow[] dr = nEWERPDataSet.qidsDetails.Select("", "", DataViewRowState.ModifiedCurrent);

            int irowsChgd = dr.GetUpperBound(0) + 1;
            if (StockDGView.IsCurrentRowDirty | irowsChgd > 0)
            {
                // DialogResult dlgReslt = MessageBox.Show("Save Changes?", this.Text + " - The row has unsaved changes", MessageBoxButtons.YesNo);
                //if (dlgReslt == DialogResult.Yes)
                if (GLibrary.MsgCheckSave(false))
                {
                    SaveAll(true);
                    //setStatus("Saved change to regex "+ regexNameTextBox.Text);
                }
                else
                {  //' problem with cancelling change, cancel edit does not

                    //StockDGView.CancelEdit();
                    qidsBindingSource.CancelEdit();
                    qidsDetailsBindingSource.CancelEdit();
                    nEWERPDataSet.qids.RejectChanges();
                    nEWERPDataSet.qidsDetails.RejectChanges();

                }

            }
            else
            {
                qidsBindingSource.CancelEdit();
                qidsDetailsBindingSource.CancelEdit();
                nEWERPDataSet.qids.RejectChanges();
                nEWERPDataSet.qidsDetails.RejectChanges();
            }
            if (!EditFlag)
            {
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                BtnPrint.Enabled = true;
                btnRefresh.Enabled = true;
                EditFlag = true;
            }
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Edit";
            }
            MoveNextChange();
            GetSum();

        }

        private void MoveNextChange()
        {
            if (((DataRowView)qidsBindingSource.Current)["PaymentType"].ToString() == Boolean.FalseString)
            {

                BoxRdBtn.Checked = true;
                CmbBanks.Visible = false;
                //txtChequeNo.Width = 0;
                txtChequeNo.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else if (((DataRowView)qidsBindingSource.Current)["PaymentType"].ToString() == Boolean.TrueString)
            {

                BankRdBtn.Checked = true;
                CmbBanks.Visible = true;
                txtChequeNo.Visible = true;
                //txtChequeNo.Width =170;
                label1.Visible = true;
                label2.Visible = true;

            }
        }
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

        private void DelMenuItem_Click(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSource.Count > 0)
            {
                qidsDetailsBindingSource.RemoveCurrent();
                GetSum();
            }
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                //invoicesBindingSource.ResetAllowNew();//.CancelEdit();
                qidsBindingSource.RemoveCurrent();
                //invoicesBindingSource.EndEdit ();
                //((DataRowView)invoicesBindingSource.Current).EndEdit();
                int i = qidsTableAdapter.Update(nEWERPDataSet.qids);
                if (qidsBindingSource.Count == 0)
                {
                    //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
                    //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                    CmdDel.Enabled = false;
                    CmdSave.Enabled = false;


                }


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            qidsBindingSource.MoveLast();
        }

        private void CmbBanks_SelectedValueChanged(object sender, EventArgs e)
        {
            if (accountingBindingSourceBank.Count > 0)
            {
                setbank();
            }

        }
        private void setbank()
        {
            if (CmbBanks.SelectedValue != null && !EditFlag)
            {
                //long AcctId = long.Parse(CmbBanks.SelectedValue.ToString());
                //long ChequeNo = long.Parse(qidsTableAdapter.QidSelectMaxChequeNo(int.Parse(GLibrary.strarrQidTypes[5, 0].ToString()), AcctId).ToString());
                //ChequeNo = ChequeNo + 1;
                //txtChequeNo.Text = ChequeNo.ToString();

            }
        }
        private void QidOutAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.F2))

            //{
            //    if (qidsDetailsBindingSource.Count > 0)
            //    {
            //       // ((DataRowView)qidsDetailsBindingSource.Current)["Description"].ToString();
            //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = temp;

            //    }
            //}

        }



        private void StockDGView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (qidsDetailsBindingSource.Count > 0)
                {
                    // ((DataRowView)qidsDetailsBindingSource.Current)["Description"].ToString();
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = temp;

                }
            }
        }

        private void txtChequeNo_Validating(object sender, CancelEventArgs e)
        {
            CheckQidNo();
        }
        private int CheckQidNo()
        {
            if (accountingBindingSourceBank.Count > 0)
            {
                if (CmbBanks.SelectedValue != null && GLibrary.IsNumeric(txtChequeNo.Text))
                {

                    long AcctId = long.Parse(CmbBanks.SelectedValue.ToString());
                    long ChequeNo = long.Parse(qidsTableAdapter.QidCheckChequeNo(int.Parse(GLibrary.strarrQidTypes[5, 0].ToString()), AcctId, txtChequeNo.Text).ToString());
                    if (ChequeNo >= 1 && !EditFlag)
                    {
                        MessageBox.Show("—ﬁ„ «·‘Ìﬂ „ﬂ——");
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }

                }
            }
            return 1;
        }







    }
}