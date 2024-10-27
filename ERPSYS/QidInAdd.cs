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
    public partial class QidInAdd : DockContent
    {
        public string temp = "";
        private int LastIden = -1;
        private int DetLastIden = -1;
        public Boolean EditFlag = false;
        private int FromValueAcc;
        private DateTime lastDataError = DateTime.MinValue;
        long FirstCode = 0;
        private NEWERPDataSet TempnEWERPDataSet = new NEWERPDataSet();
        private NEWERPDataSetTableAdapters.qidsDetailsTableAdapter TempqidsDetailsTableAdapter = new NEWERPDataSetTableAdapters.qidsDetailsTableAdapter();
        public long qidid = 0;
        public Boolean PrintFlag = false;
        public long InvId = 0;
        public QidInAdd()
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



        private void AddNew()
        {
            LastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
            DetLastIden = int.Parse(qidsDetailsTableAdapter.GetQidsDetLastIdentity().ToString());

            qidsBindingSource.CurrencyManager.AddNew();
            Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0];
            //qidsDetailsBindingSource.Filter = "FromValue is not null"; 
            //CmdSave.Text = "ÍÝÙ";
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }
            EditFlag = false;
            CmdAdd.Enabled = false;
            BtnPrint.Enabled = false;
            CmdDel.Enabled = false;
            btnRefresh.Enabled = false;
            CmdSave.Enabled = true;

            qidDateDateTimePicker.Value = DateTime.Today;
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();
            txtrecitetype.Text = GLibrary.strarrQidTypes[6, 0];
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
            }
            txtQidDate.Text = DateTime.Today.ToShortDateString();
            long QidSeial = 0;
            long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[6, 0]));
            QidSeial = MaxSerial + 1;
            qidcodeTextBox.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
            FirstCode = QidSeial;
            txtQidSerial.Text = QidSeial.ToString();

            //string QidInSerial = nEWERPDataSet.SetupCodes.Rows[0]["InQidSerial"].ToString();
            //qidcodeTextBox.Text = (int.Parse(QidInSerial) +1).ToString(); // Messages.SysQidIn + QidInSerial; //(LastIden + 1).ToString();



            if (Messages.CurBranch != "")
            {
                CmbBranch.SelectedValue = Messages.CurBranch;
            }
            BoxRdBtn.Checked = true;
            txtChequeNo.Visible = false;
            CmbBanks.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            txtTotalFromValue.Text = "";

        }


        private Boolean CheckCode(string QidCode, int QidType)
        {
            int Count = 0;
            Count = int.Parse(qidsTableAdapter.CheckQidCode(QidCode, QidType).ToString());
            if (Count > 0)
            {
                if (Count == 1 && EditFlag)
                {
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
                //    qidcodeTextBox.Text = Convert.ToString(long.Parse(nEWERPDataSet.SetupCodes.Rows[0]["InQidSerial"].ToString()) + 1);
                //    return true;
                //}
                else
                {
                    return false;
                }
            }
            return true;

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




        private void StoreSearch(string ColName, string Value)
        {
            //int Pos = sTOCKBindingSource.Find(ColName, Value);
            //if (nEWERPDataSet.STORES.Rows.Count > 0)
            //{
            //    StoresDGView.Rows[Pos].Selected = true;
            //}
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
                qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0];


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

                // ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            }
            else
            {
                qidsDetailsBindingSource.Filter = "FromValue is not null and qidid =-1 " + " and QidType=" + GLibrary.strarrQidTypes[6, 0];
            }


        }

        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            //string str = errorProvider1.GetError(StockDGView);

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
                qidsDetailsBindingSource.Filter = "qidid =" + detail.qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[6, 0] + ")";
                int icount = qidsDetailsBindingSource.Count;
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
            qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + master.qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0]; ;
            //"FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0];
            //detail.qidid  = master.qidid;
            // Save the child row

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private void SaveAll(Boolean bFlag)
        {
            if (GLibrary.MsgCheckSave(bFlag))
            {
                try
                {
                    //if (BoxRdBtn.Checked) //ÇáÕäÏæÞ
                    //{
                    //    FromValueAcc = Messages.boxAccid;
                    //}

                    if (BoxRdBtn.Checked) //ÇáÕäÏæÞ
                    {
                        if (comboBoxMain.SelectedValue != null)
                        {
                            FromValueAcc = int.Parse(comboBoxMain.SelectedValue.ToString()); // Messages.bankaccid;
                        }
                        else
                        {
                            MessageBox.Show(Messages.QidNotBankfoundMesg, "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            return;
                        }
                        //ToValueAcc = Messages.boxAccid;
                    }
                    else if (BankRdBtn.Checked) // ÇáÈäß
                    {
                        if (CmbBanks.SelectedValue != null)
                        {
                            FromValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); // Messages.bankaccid;
                        }
                        else
                        {
                            MessageBox.Show(Messages.QidNotBankfoundMesg, "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            return;
                        }
                    }
                    if (qidsDetailsBindingSource.Count > 0 && !StockDGView.IsCurrentRowDirty)
                    {
                        if (GLibrary.IsNumeric(qidcodeTextBox.Text))
                        {
                            if (GLibrary.IsDate(txtQidDate.Text))
                            {
                                long QidSeial = 0;
                                txtQidDate.Focus();
                                if (!EditFlag)
                                {
                                    long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[6, 0]));
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
                                //if (!EditFlag)
                                //{
                                //    string InQidSerial = nEWERPDataSet.SetupCodes.Rows[0]["InQidSerial"].ToString();
                                //    qidcodeTextBox.Text = (int.Parse(InQidSerial) + 1).ToString();
                                //}

                                if (CheckCode(qidcodeTextBox.Text, int.Parse(GLibrary.strarrQidTypes[6, 0].ToString())))
                                {
                                    if (BoxRdBtn.Checked)
                                    {
                                        ((DataRowView)qidsBindingSource.Current)["PaymentType"] = Boolean.FalseString;
                                    }
                                    else if (BankRdBtn.Checked)
                                    {
                                        ((DataRowView)qidsBindingSource.Current)["PaymentType"] = Boolean.TrueString;
                                    }

                                    txtUserId.Text = Messages.CurUserId;

                                    // this.Validate();

                                    SaveQidsDet();
                                    SaveChild();
                                    if (!EditFlag)
                                    {
                                        nEWERPDataSet.SetupCodes.Rows[0]["InQidSerial"] = qidcodeTextBox.Text;
                                        setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                    }
                                    //qidsBindingSource.EndEdit();
                                    //qidsDetailsBindingSource.EndEdit();
                                    CmdAdd.Enabled = true;
                                    BtnPrint.Enabled = true;
                                    CmdDel.Enabled = true;
                                    btnRefresh.Enabled = true;
                                    CmdSave.Enabled = true;
                                    EditFlag = true;
                                    //qidsTableAdapter.Update(nEWERPDataSet.qids);
                                    // qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                                    //CmdSave.Text = "ÊÚÏíá";
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        CmdSave.Text = "ÊÚÏíá";

                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        CmdSave.Text = "òõEdit";
                                    }
                                    errorProvider1.Clear();
                                    GLibrary.MsgSave();
                                }
                                else
                                {
                                    MessageBox.Show("ÑÞã ÇáãÓÊäÏ ãæÌæÏ ÓÇÈÞÇ", "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                            }
                            else
                            {
                                MessageBox.Show("ÇÏÎá ÊÇÑíÎ ÇáÞíÏ ÈØÑíÞÉ ÕÍíÕÉ", "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ÃÏÎá ÇáßæÏ ÈØÑíÞÉ ÓáíãÉ", "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    else
                    {
                        MessageBox.Show(Messages.QidEmptyMesg, "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                catch (Exception ex)
                {
                    int ErrorNo = -1;

                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }
        private void SaveQidsDet()
        {
            int icount = qidsDetailsBindingSource.Count;

            Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            //if (BoxRdBtn.Checked)
            //{
            //    ACCOUNTID = FromValueAcc;// Messages.boxAccid;

            //}
            //else if (BankRdBtn.Checked)
            //{
            //    ACCOUNTID = FromValueAcc;// Messages.bankaccid;
            //}
            for (int i = 0; i < icount; i++)
            {
                //if (((DataRowView)qidsDetailsBindingSource[i]))
                //{

                //((DataRowView)qidsDetailsBindingSource[i])["Detcode"] = ((DataRowView)qidsDetailsBindingSource[i])["ID"];

                if (!EditFlag)
                {
                    ERPSYS.NEWERPDataSet.qidsDetailsRow DetRow = nEWERPDataSet.qidsDetails.NewqidsDetailsRow();
                    DetRow.ToValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["FromValue"];

                    DetRow.ACCOUNTID = FromValueAcc;// Messages.bankaccid;

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
                    decimal FromValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["FromValue"];
                    string Desc = ((DataRowView)qidsDetailsBindingSource[i])["Description"].ToString();
                    int pos = qidsDetailsBindingSource.Position;
                    //qidsDetailsBindingSource.RemoveFilter();
                    qidsDetailsBindingSource.Filter = "Detcode=" + detCode.ToString() + " and id <>" + Id.ToString();
                    if (qidsDetailsBindingSource.Count > 0)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current).Row.BeginEdit();
                        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = FromValue;
                        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = FromValueAcc;
                        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
                        ((DataRowView)qidsDetailsBindingSource.Current).Row.EndEdit();
                    }
                    else
                    {
                        qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0]; ;
                        qidsDetailsBindingSource.Position = pos;

                        ERPSYS.NEWERPDataSet.qidsDetailsRow DetRow = nEWERPDataSet.qidsDetails.NewqidsDetailsRow();
                        DetRow.ToValue = (decimal)((DataRowView)qidsDetailsBindingSource[i])["FromValue"];

                        DetRow.ACCOUNTID = FromValueAcc;// Messages.bankaccid;

                        DetRow["EnterDate"] = ((DataRowView)qidsDetailsBindingSource[i])["EnterDate"];
                        DetRow["qidid"] = ((DataRowView)qidsDetailsBindingSource[i])["qidid"];
                        DetRow["Description"] = ((DataRowView)qidsDetailsBindingSource[i])["Description"];
                        DetRow["Detcode"] = ((DataRowView)qidsDetailsBindingSource[i])["Detcode"];
                        DetRow["QidType"] = ((DataRowView)qidsDetailsBindingSource[i])["QidType"];
                        nEWERPDataSet.qidsDetails.AddqidsDetailsRow(DetRow);
                    }

                    qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0]; ;
                    qidsDetailsBindingSource.Position = pos;
                }
                //}

            }
            qidsDetailsBindingSource.Filter = "FromValue is not null and qidid = " + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[6, 0]; ;
        }


        private void BankRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BankRdBtn.Checked)
            {

                comboBoxMain.Visible = false;
                comboBoxMain.SelectedValue = -1;
                
                //txtChequeNo.Width = 0;
                //txtChequeNo.Text = "";
             
                //txtBoxAcc.Text = Messages.boxAccid.ToString();
                //FromValueAcc = int.Parse(txtBoxAcc.Text);


                CmbBanks.Visible = true;
                //if (CmbBanks.Items.Count  >0)
                //{
                //    CmbBanks.SelectedIndex = 0;
                //}
                txtChequeNo.Visible = true;
                //txtChequeNo.Width = 170;
                label1.Visible = true;
                label2.Visible = true;
                //txtChequeNo.Text = "";

                if (CmbBanks.SelectedValue != null)
                {
                    txtBankAcc.Text = CmbBanks.SelectedValue.ToString();
                    FromValueAcc = int.Parse(CmbBanks.SelectedValue.ToString()); //int.Parse (txtBankAcc.Text);
                }
            }
        }

        private void BoxRdBtn_CheckedChanged(object sender, EventArgs e)
        {
             if (BoxRdBtn.Checked)
            {
                CmbBanks.Visible  =false ;
                CmbBanks.SelectedValue = -1;
                txtChequeNo.Visible  =false ;
                comboBoxMain.Visible = true;
                //txtChequeNo.Width = 0;
                //txtChequeNo.Text = "";
                label1.Visible = false;
                label2.Visible = false;
                txtBoxAcc.Text = Messages.boxAccid.ToString();
                FromValueAcc = int.Parse (txtBoxAcc.Text);
                comboBoxMain.SelectedValue = Messages.boxAccid.ToString();
            }
            

        }
        private void SetPermission()
        {
            if (Messages.Usertype != Messages.AdminUser)
            {
                if (!Messages.SalQidInPrim[1] && EditFlag)
                {
                    StockDGView.Enabled = false;
                    CmdSave.Enabled = false;

                }
                else
                {
                    StockDGView.Enabled = true;
                    CmdSave.Enabled = true;
                }
                if (!Messages.SalQidInPrim[2] && EditFlag)
                {
                    //ProductsDGView.Enabled = false;
                    CmdDel.Enabled = false;
                }

            }
        }
        private void QidInAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Machines' table. You can move, or remove it, as needed.
            //this.machinesTableAdapter.Fill(this.nEWERPDataSet.Machines);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            //this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            StockDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            foreach (DataGridViewRow row in StockDGView.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }





            qidsDetailsBindingSource.Filter = "FromValue is not null and QidType=" + GLibrary.strarrQidTypes[6, 0];

            if (!PrintFlag)
            {
                if (Messages.Usertype == 2)
                {
                    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[6, 0].ToString() + " And BrachId=" + Messages.CurBranch.ToString();
                    CmbBranch.Enabled = false;
                }
                else
                {
                    qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[6, 0].ToString();
                }

            }
            else
            {
                qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[6, 0].ToString() + " and InvId=" + InvId.ToString();

            }

            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);

            if (Messages.boxAccid != null || Messages.boxAccid != 0)
            {
                int Pos = accountingBindingSource.Find("AccountId", Messages.boxAccid);
                if (Pos > -1)
                {
                    Boolean MainNode = Boolean.Parse(((DataRowView)accountingBindingSource[Pos])["MainNode"].ToString());
                    if (MainNode)
                    {
                        MessageBox.Show(Messages.InvalidBoxAccMesg, "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
            }

            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            accountingBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;

            accountingBindingSourceBank.Filter = "AccountparentId=" + Messages.bankaccid.ToString() + " or AccountId= " + Messages.bankaccid.ToString() + " and MainNode=false";
            accountingBindingSourceMain.Filter = "AccountparentId=" + Messages.accountidMainBox.ToString() + " or AccountId= " + Messages.accountidMainBox.ToString() + " and MainNode=false";

            accountingBindingSource.Sort = "accountname";
            accountingBindingSourceBank.Sort = "accountname";
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.
            txtBoxAcc.Text = Messages.boxAccid.ToString();
            if (!EditFlag)
            {
                AddNew();

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
            // FromValueAcc = int.Parse(txtBoxAcc.Text);

            if (comboBoxMain.SelectedValue != null)
            {
                FromValueAcc = int.Parse(comboBoxMain.SelectedValue.ToString());
            }

            if (CmbBanks.Items.Count > 0)
            {
                CmbBanks.SelectedIndex = 0;
            }

            Messages.AccountFlag = 0;
            Messages.CostcenterFlag = 0;
            SetPermission();
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
                //ŠY“–‚·‚é—ñ‚©’²‚×‚é
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "Machineid" || dgv.CurrentCell.OwningColumn.Name == "AccountName" || dgv.CurrentCell.OwningColumn.Name == "CostId" || dgv.CurrentCell.OwningColumn.Name == "ACCOUNTCODE")
                {
                    //•ÒW‚Ì‚½‚ß‚É•\Ž¦‚³‚ê‚Ä‚¢‚éƒRƒ“ƒgƒ[ƒ‹‚ðŽæ“¾
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
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

                }

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

            }
            //if (e.ColumnIndex == Description.Index)
            //{
            //    temp = e.FormattedValue.ToString();
            //}

        }
        private void GetSum()
        {
            DataView list = (DataView)qidsDetailsBindingSource.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            for (int i = 0; i < T.Rows.Count; i++)
            {

                if (GLibrary.IsNumeric(T.Rows[i]["FromValue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["FromValue"].ToString());
                }


            }

            txtTotalFromValue.Text = Fromvalue.ToString();

        }
        private void StockDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (StockDGView.Rows.Count > 0)
            {
                if (StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != DBNull.Value && StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != null)
                {
                    GetSum();
                }
            }
        }



        private void StockDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            StockDGView.Rows[e.RowIndex].ErrorText = String.Empty;
            if (e.ColumnIndex == Description.Index)
            {
                temp = StockDGView[Description.Index, e.RowIndex].Value.ToString();
                //temp = e.FormattedValue.ToString();
            }
        }

        private void StockDGView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Boolean ErrFlag = false;
            if (qidsDetailsBindingSource.Count > 0)
            {

                if (StockDGView.IsCurrentRowDirty == true)
                {
                    // Set the combobox cell datasource to the filtered BindingSource
                    DataGridViewTextBoxCell dgtxtBox = (DataGridViewTextBoxCell)StockDGView["fromValueDataGridViewTextBoxColumn", e.RowIndex];
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
                        StockDGView.Rows[e.RowIndex].ErrorText = "ÃÏÎá ãÍÊæíÇÊ ÇáÓäÏ ÈØÑíÞÉ ÕÍíÍÉ ";
                        e.Cancel = true;
                        errorProvider1.SetError(StockDGView, "ÃÏÎá ãÍÊæíÇÊ ÇáÓäÏ ÈØÑíÞÉ ÕÍíÍÉ");
                        if (dgtxtBox.Value == null)
                        {
                            StockDGView.Rows[e.RowIndex].Cells["fromValueDataGridViewTextBoxColumn"].ErrorText = "ãä ÝÖáß ÇÏÎá ÇáãÈáÛ ÇáãÞÈæÖ ";
                        }
                        else if (!GLibrary.IsNumeric(dgtxtBox.Value.ToString()))
                        {
                            StockDGView.Rows[e.RowIndex].Cells["fromValueDataGridViewTextBoxColumn"].ErrorText = "ãä ÝÖáß ÇÏÎá ÇáãÈáÛ ÇáãÞÈæÖ ";
                        }

                        if (dgcb.Value == null)
                        {
                            StockDGView.Rows[e.RowIndex].Cells["AccountName"].ErrorText = "ãä ÝÖáß ÇÏÎá ÇáÍÓÇÈ ";
                        }
                        else if (!GLibrary.IsNumeric(dgcb.Value.ToString()))
                        {
                            StockDGView.Rows[e.RowIndex].Cells["AccountName"].ErrorText = "ãä ÝÖáß ÇÏÎá ÇáÍÓÇÈ ";
                        }
                    }
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
        }

        private void StockDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Description"].Value = "ÓäÏ ÞÈÖ";
            e.Row.Cells["QidType"].Value = GLibrary.strarrQidTypes[6, 0].ToString();
            e.Row.Cells["Description"].Value = temp;
            //e.Row.Cells["EnterDateQid"].Value = DateTime.Today.ToString("dd/MM/yyyy"); 
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
                    //MoveNextChange();
                    qidsBindingSource.Position = pos;
                    CmdAdd.Enabled = true;
                    btnRefresh.Enabled = true;
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSave.Text = "ÊÚÏíá";

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
                    MessageBox.Show(Messages.QidNotfoundMesg, "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    qidcodeTextBox.Text = oldvalue;
                }

            }



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
                    CmdSave.Text = "ÊÚÏíá";

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
                MessageBox.Show(Messages.QidNotfoundMesg, "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //qidcodeTextBox.Text=oldvalue;
            }

        }
        private void MoveNextChange()
        {
            if (((DataRowView)qidsBindingSource.Current)["PaymentType"].ToString() == Boolean.FalseString)
            {

                BoxRdBtn.Checked = true;
                CmbBanks.Visible = false;
                txtChequeNo.Visible = false;
                //txtChequeNo.Width = 0;
                label1.Visible = false;
                label2.Visible = false;
            }
            else if (((DataRowView)qidsBindingSource.Current)["PaymentType"].ToString() == Boolean.TrueString)
            {

                BankRdBtn.Checked = true;
                CmbBanks.Visible = true;
                txtChequeNo.Visible = true;
                // txtChequeNo.Width = 170;
                label1.Visible = true;
                label2.Visible = true;

            }
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSource.Count > 0)
            {
                ShowRpt Showfrm = new ShowRpt();
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

                double Value = double.Parse(((DataRowView)qidsDetailsBindingSource.Current)["FromValue"].ToString());

                Showfrm.ToValue = GLibrary.FigureInWordsNumType(Value, 1);
                string AccountId = ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"].ToString();

                int pos = accountingBindingSource.Find("accountid", AccountId);
                if (pos > -1)
                {
                    Showfrm.AccountName = ((DataRowView)accountingBindingSource[pos])["accountname"].ToString();
                }
                Showfrm.Description = ((DataRowView)qidsDetailsBindingSource.Current)["Description"].ToString();
                Showfrm.QidDate = ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"].ToString();

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
                Showfrm.Fils = string.Format("{0:000}", dd);
                Showfrm.Dinar = ii;
                Showfrm.choiceNum = 2;
                Showfrm.Show();
            }
        }



        private void StockDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //StockDGView.Rows[e.RowIndex].HeaderCell.Value = (StockDGView.RowCount ).ToString();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

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
                CmdSave.Text = "ÊÚÏíá";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõòòõõEdit";
            }

            MoveNextChange();
            GetSum();

        }

        private void CmdActiveSave_Click(object sender, EventArgs e)
        {

        }

        private void qidDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();
            this.Validate();
            //txtQidDate.Focus();
            //qidDateDateTimePicker.Focus();

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckSave();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
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
                    BtnPrint.Enabled = false;


                }


            }
        }

        private void QidInAdd_Activated(object sender, EventArgs e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            qidsBindingSource.MoveLast();
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


        //private void StockDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        //{
        //    StockDGView.Rows[e.RowIndex].Cells["Detcode"].Value  = e.RowIndex;
        //}






    }
}