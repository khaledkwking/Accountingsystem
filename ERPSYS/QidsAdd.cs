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
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace ERPSYS
{
    public partial class QidsAdd : DockContent
    {
        public string temp = "";
        public Boolean bStart = false;
        private int LastIden = -1;
        public Boolean EditFlag = false;
        private DateTime lastDataError = DateTime.MinValue;
        long FirstCode = 0;
        public long qidid = 0;
        public QidsAdd()
        {
            InitializeComponent();
            this.KeyPreview = true;
            // this.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }

        private void ProductAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();
        }
        private void SetPermission()
        {
            if (Messages.Usertype != Messages.AdminUser)
            {
                if (!Messages.SalQidPrim[1] && EditFlag)
                {
                    StockDGView.Enabled = false;
                    CmdSave.Enabled = false;

                }
                else
                {
                    StockDGView.Enabled = true;
                    CmdSave.Enabled = true;
                }
                if (!Messages.SalQidPrim[2] && EditFlag)
                {
                    //ProductsDGView.Enabled = false;
                    CmdDel.Enabled = false;
                }

            }

        }
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Machines' table. You can move, or remove it, as needed.
            //this.machinesTableAdapter.Fill(this.nEWERPDataSet.Machines);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.

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

            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            qidsDetailsBindingSource.Filter = "QidType=" + GLibrary.strarrQidTypes[0, 0];// +" Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString();

            qidsBindingSource.Filter = "recitetype=" + GLibrary.strarrQidTypes[0, 0];// +" Or recitetype=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or recitetype=" + GLibrary.strarrQidTypes[6, 0].ToString();
            if (bStart)
            {
                qidsBindingSource.Filter = "(" + qidsBindingSource.Filter + ")" + " and repeated=true";
            }
            else
            {
                qidsBindingSource.Filter = "(" + qidsBindingSource.Filter + ")" + " and (repeated is null or repeated=0)";
            }


            if (Messages.Usertype == 2)
            {
                qidsBindingSource.Filter = "(" + qidsBindingSource.Filter + ")" + " And BrachId=" + Messages.CurBranch.ToString();
                CmbBranch.Enabled = false;
            }
            else
            {

            }

            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);

            accountingBindingSource.Filter = "Mainnode=" + Boolean.FalseString;
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            accountingBindingSource.Sort = "accountname";
            //qidsBindingSource.Sort = "qidDate";
            //qidsBindingSource.Sort = "";
            // TODO: This line of code loads data into the 'nEWERPDataSet.qidsDetails' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.qids' table. You can move, or remove it, as needed.


            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            if (!EditFlag)
            {
                AddNew();

            }
            else
            {
                FindQid();
            }

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
                    CmdSave.Text = "òõEdit";
                }

                EditFlag = true;
                SetPermission();
            }
            else
            {
                MessageBox.Show(Messages.QidNotfoundMesg, "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //qidcodeTextBox.Text = oldvalue;
            }

        }
        private void AddNew()
        {
            LastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
            qidsBindingSource.CurrencyManager.AddNew();
            txtrecitetype.Text = GLibrary.strarrQidTypes[5, 0].ToString();
            qidDateDateTimePicker.Value = DateTime.Today;
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();

            //CmdSave.Text = "ÍÝÙ";
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõSave";
            }
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
            }
            //qidcodeTextBox.Text = Messages.SysQid + (LastIden+1).ToString();

            if (bStart)
            {
                qidDateDateTimePicker.Value = new DateTime(DateTime.Today.Year, 1, 1);
                txtbStart.Text = Boolean.TrueString;
            }
            else
            {
                txtbStart.Text = Boolean.FalseString;
            }
            //txtQidDate.Text = DateTime.Today.ToShortDateString();
            //string QidSerial = nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"].ToString();
            //qidcodeTextBox.Text = (int.Parse(QidSerial) + 1).ToString();
            long QidSeial = 0;
            long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[0, 0]));
            QidSeial = MaxSerial + 1;
            qidcodeTextBox.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
            FirstCode = QidSeial;
            txtQidSerial.Text = QidSeial.ToString();

            recitetypeTextBox.Text = GLibrary.strarrQidTypes[0, 0].ToString();
            if (Messages.CurBranch != "")
            {
                CmbBranch.SelectedValue = Messages.CurBranch;
            }
            EditFlag = false;

            BtnPrint.Enabled = false;
            CmdDel.Enabled = false;
            CmdAdd.Enabled = false;
            btnRefresh.Enabled = false;
            CmdSave.Enabled = true;

            txtTotalToValue.Text = "";
            txtTotalFromValue.Text = "";
            txttotalBalance.Text = "";

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
            this.Close();
        }

        private void txtProductCode_KeyUp(object sender, KeyEventArgs e)
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

                    CheckCancel();
                    qidsBindingSource.Position = pos;
                    //MoveNextChange();
                    SetPermission();

                }
                else
                {
                    MessageBox.Show(Messages.QidNotfoundMesg, "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    qidcodeTextBox.Text = oldvalue;
                }
                GetSum();
            }
        }

        private void DisplayProducts(ref string ProductName, ref int ProductID, ref string ProductCode)
        {
            //ProductsList frm = new ProductsList();
            //DialogResult ret = frm.ShowDialog(this);
            //if (DialogResult.OK == ret)
            //{
            //    ProductName = frm.CurProductName;
            //    ProductID = frm.CurProductId;
            //    ProductCode = frm.CurProductCode;
            //}

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
                qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[0, 0] + ")"; //+ " Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString()+")";



            }
        }

        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            {

                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                //((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today.ToString("dd/MM/yyyy");

            }
        }

        private void StockDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (StockDGView.Rows.Count > 0)
            {
                //decimal Credit = 0;
                switch (e.ColumnIndex)
                {
                    case 0: //Tovale

                        if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {

                            //txtTotalToValue.Text = (decimal.Parse(txtTotalToValue.Text) + decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString();
                            //if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString()))
                            //{
                            //    txtTotalFromValue.Text = (decimal.Parse(txtTotalFromValue.Text) - decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())).ToString();
                            //}
                            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[1].Value = DBNull.Value;
                        }
                        else
                        {
                            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                        }
                        // Credit=(decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
                        //if (Credit<0)
                        //{
                        //    Credit =(Credit * -1);
                        //}
                        //txttotalBalance.Text = Credit.ToString();
                        break;
                    case 1: //fromValue
                        if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {
                            //txtTotalFromValue.Text = (decimal.Parse(txtTotalFromValue.Text) + decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[1].Value.ToString())).ToString();
                            //if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString()))
                            //{
                            //    txtTotalToValue.Text = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())).ToString();
                            //}
                            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[0].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[0].Value = DBNull.Value;
                        }
                        else
                        {
                            if (GLibrary.IsNumeric(StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())) StockDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = DBNull.Value;
                        }
                        //Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
                        //if (Credit < 0)
                        //{
                        //    Credit = (Credit * -1);
                        //}
                        //txttotalBalance.Text = Credit.ToString();
                        break;

                }
                if (StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != DBNull.Value && StockDGView.Rows[e.RowIndex].Cells["AccountName"].Value != null)
                {
                    GetSum();
                }
            }

        }
        private void GetSum()
        {
            try
            {
                DataView list = (DataView)qidsDetailsBindingSource.List;
                DataTable T = list.ToTable();
                decimal Fromvalue = 0;
                decimal Tovalue = 0;
                decimal Credit = 0;
                for (int i = 0; i < T.Rows.Count; i++)
                {

                    if (GLibrary.IsNumeric(T.Rows[i]["FromValue"].ToString()))
                    {
                        Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["FromValue"].ToString());
                    }
                    if (GLibrary.IsNumeric(T.Rows[i]["ToValue"].ToString()))
                    {
                        Tovalue = Tovalue + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                    }

                }
                txtTotalToValue.Text = Tovalue.ToString();
                txtTotalFromValue.Text = Fromvalue.ToString();
                Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
                if (Credit < 0)
                {
                    Credit = (Credit * -1);
                }
                txttotalBalance.Text = Credit.ToString();
            }
            catch (Exception ex)
            {

            }
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
            qidsDetailsBindingSource.Filter = " qidid=" + master.qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[0, 0] + ")"; //+ " Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString() + ")";

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private void SaveAll(Boolean bflag)
        {
            if (GLibrary.MsgCheckSave(bflag))
            {
                try
                {
                    if (decimal.Parse(txtTotalFromValue.Text) == decimal.Parse(txtTotalToValue.Text))
                    {
                        if (GLibrary.IsNumeric(qidcodeTextBox.Text))
                        {
                            if (GLibrary.IsDate(txtQidDate.Text))
                            {
                                long QidSeial = 0;
                                if (!EditFlag)
                                {
                                    long MaxSerial = (long)qidsTableAdapter.QidSelectMaxSerial(int.Parse(GLibrary.strarrQidTypes[0, 0]));
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


                                    //string QidSeial = nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"].ToString();
                                    //qidcodeTextBox.Text = (int.Parse(QidSeial) + 1).ToString();
                                }
                                if (CheckCode(qidcodeTextBox.Text, int.Parse(GLibrary.strarrQidTypes[0, 0].ToString())))
                                {
                                    txtUserId.Text = Messages.CurUserId;
                                    //this.Validate();
                                    //qidsBindingSource.EndEdit();
                                    //qidsDetailsBindingSource.EndEdit();
                                    //qidsTableAdapter.Update(nEWERPDataSet.qids);
                                    SaveChild();
                                    //if (!EditFlag)
                                    //{
                                    //    nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"] = qidcodeTextBox.Text;
                                    //    setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                    //}

                                    //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                                    GLibrary.MsgSave();


                                    EditFlag = true;
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        CmdSave.Text = "ÊÚÏíá";

                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        CmdSave.Text = "òõEdit";
                                    }

                                    BtnPrint.Enabled = true;
                                    CmdDel.Enabled = true;
                                    CmdAdd.Enabled = true;
                                    btnRefresh.Enabled = true;
                                    CmdSave.Enabled = true;
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
                        MessageBox.Show(Messages.QidNotBalanceMesg, "ÇáÞíæÏ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }
        private void CmdSave_Click_1(object sender, EventArgs e)
        {
            SaveAll(false);
            SetPermission();
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
                }
                else
                {
                    //if (!EditFlag)
                    //{
                    //    //setupCodesTableAdapter.Fill(nEWERPDataSet.SetupCodes);
                    //    //qidcodeTextBox.Text = Convert.ToString (long.Parse (nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"].ToString ())+1);
                    //    return true;
                    //}
                    //else
                    //{
                    return false;
                    //}
                }
            }
            return true;

        }
        private void QidsAdd_Activated(object sender, EventArgs e)
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

        private void StockDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            StockDGView.Rows[e.RowIndex].ErrorText = String.Empty;

        }

        private void StockDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            if (StockDGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

            TimeSpan sinceLast = DateTime.Now - lastDataError;
            lastDataError = DateTime.Now;
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
        private void StockDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Description.Index)
            {
                temp = StockDGView[Description.Index, e.RowIndex].Value.ToString();
                //temp = e.FormattedValue.ToString();
            }

            //if (e.ColumnIndex == AccountName.Index)
            //{
            //    DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)StockDGView  [e.ColumnIndex, e.RowIndex];
            //    dgcb.DataSource = qidsDetailsBindingSource;

            //    this.qidsDetailsBindingSource.RemoveFilter();
            //}
        }
        
        private void StockDGView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.Control.KeyPress +=   new KeyPressEventHandler(Control_KeyPress);
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //ŠY“–‚·‚é—ñ‚©’²‚×‚é
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "Machineid" || dgv.CurrentCell.OwningColumn.Name == "AccountName" || dgv.CurrentCell.OwningColumn.Name == "CostId" || dgv.CurrentCell.OwningColumn.Name == "ACCOUNTCODE")
                {
                    //•ÒW‚Ì‚½‚ß‚É•\Ž¦‚³‚ê‚Ä‚¢‚éƒRƒ“ƒgƒ[ƒ‹‚ðŽæ“¾
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend ;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;

                    //accountingBindingSource.Filter = string.Format("AccountName='{0}'", Convert.ToString(dgv.CurrentRow.Cells["AccountName"].Value ?? string.Empty));

                    cb.TextChanged -= primaryCB_SelectedIndexChanged;
                    cb.TextChanged += primaryCB_SelectedIndexChanged;




                    //cb.DropDownStyle = ComboBoxStyle.DropDownList;
                    //cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    //cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
            //if (StockDGView.CurrentRow.Cells["AccountName"].Value != null)
            //{
            //    accountingBindingSource.Filter =" AccountName LIKE '%"+ StockDGView.CurrentRow.Cells["AccountName"].Value.ToString ()+"%'";
            //}
        }
        private void primaryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //if (StockDGView.CurrentRow.Cells["AccountName"].EditedFormattedValue != null)
            //{
            //    accountingBindingSource.Filter = " AccountName LIKE '%" + StockDGView.CurrentRow.Cells["AccountName"].EditedFormattedValue.ToString() + "%'";
            //}

            //if (StockDGView.CurrentCell.ColumnIndex == 0) //allow control on only one column
            //{

            //    ComboBox cb = sender as ComboBox;

            //    if (cb != null)
            //    {
            //        //Debug.WriteLine(cb.SelectedValue + "TEST");

            //        //BindingSource bsSecondary = new BindingSource();

            //        //bsSecondary.DataSource = dataSet1.Tables["tblSecondary"];

            //        //string filter = string.Format("Primary_Type = {0}", cb.SelectedValue);

            //        //bsSecondary.Filter = filter;

            //        //Debug.WriteLine(filter);


            //    }
            //}
        }//end of primaryCB_SelectedIndexChanged
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
                //else
                //{

                //    dgcb.Value = "";
                //    ((DataRowView)qidsDetailsBindingSource.Current)["accountid"] = DBNull.Value;
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

        }

        private void StockDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["QidType"].Value = GLibrary.strarrQidTypes[0, 0].ToString();
            e.Row.Cells["Description"].Value = temp;
            //e.Row.Cells["Description"].Value = "ÓäÏ ÞíÏ";
            //if (bStart)
            //{
            //    e.Row.Cells["EnterDate"].Value = new DateTime(DateTime.Today.Year, 1, 1).ToString ("dd/MM/yyyy");
            //}
            //else
            //{
            //    e.Row.Cells["EnterDate"].Value = DateTime.Today.ToString("dd/MM/yyyy");

            //}

        }


        private void StockDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //StockDGView.Rows[e.RowIndex].HeaderCell.Value = (StockDGView.RowCount).ToString();
        }

        private void qidDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtQidDate.Text = qidDateDateTimePicker.Value.ToShortDateString();// ToString("dd/MM/yyyy");
            //txtQidDate.Focus();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowReport Showfrm = new ShowReport();
            double value = 0;
            if (GLibrary.IsNumeric(txtTotalFromValue.Text))
            {
                value = double.Parse(txtTotalFromValue.Text);
            }
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);

            Showfrm.ValueDesc = GLibrary.FigureInWordsNumType(value, 1);
            accountingViewTableAdapter.FillByQidId(nEWERPDataSet.AccountingView, long.Parse(qididTextBox.Text));
            Showfrm.nEWERPDataSet = nEWERPDataSet;
            Showfrm.TotalToValue = txtTotalToValue.Text;
            Showfrm.TotalFromValue = txtTotalFromValue.Text;

            Showfrm.choiceNum = 1;
            Showfrm.Show();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void CheckCancel()
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
                CmdSave.Text = "Edit";
            }
            ////-------------------------///////////////////////
            //if (GLibrary.MsgCheckSave(false))
            //{
            //    SaveAll();

            //}
            //else
            //{


            //    qidsBindingSource.CancelEdit();
            //    qidsDetailsBindingSource.CancelEdit();


            //    nEWERPDataSet.qids.RejectChanges();
            //    nEWERPDataSet.qidsDetails.RejectChanges();

            //    int Pos = qidsBindingSource.Position;




            //    if (!EditFlag)
            //    {
            //        CmdAdd.Enabled = true;
            //        //CmdDel.Enabled = true;
            //        BtnPrint.Enabled = true;
            //        EditFlag = true;
            //    }
            //    if (Messages.CurLang == Messages.ArabLang)
            //    {
            //        CmdSave.Text = "ÊÚÏíá";

            //    }
            //    else if (Messages.CurLang == Messages.EngLang)
            //    {
            //        CmdSave.Text = "òõòòõõEdit";
            //    }

            GetSum();

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
                    qidsDetailsBindingSource.Filter = "qidid=-1";

                }
                else if (qidsBindingSource.Count > 0)
                {
                    Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                    qidsDetailsBindingSource.Filter = "qidid=" + qidid.ToString();
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

        private void StockDGView_KeyUp(object sender, KeyEventArgs e)
        {

        }

       



        private void QidsAdd_KeyUp(object sender, KeyEventArgs e)
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

        private void txtQidDate_TextChanged(object sender, EventArgs e)
        {
            
        }

     

       





    }
}