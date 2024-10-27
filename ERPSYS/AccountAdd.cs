using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ERPSYS.Reports;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class AccountAdd : DockContent
    {
        private CustSupAdd frmCustSup = new CustSupAdd();
        private EmpAdd frmEmp = new EmpAdd();
        private StaticList slAccountTypes;

        private Boolean bFlag = false;

        private TabPage selectedTab;
        public Boolean EditFlag;
        public Boolean SaveFlag = false;
        public Boolean EmpSaveFlag = false;
        private TreeNode MainAddNode = null;
        private Boolean Flag = false;
        private Boolean FlagFoDel = false;
        private string LastSerialNo = "";
        private NEWERPDataSet nEWERPDataSetTemp = new NEWERPDataSet();
        private NEWERPDataSet nEWERPDataSetTempOld = new NEWERPDataSet();
        NEWERPDataSet nEWERPDataSetNew = new NEWERPDataSet();
        private BindingSource accountingBindingSourceTemp = new BindingSource();

        public AccountAdd()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_Currency' table. You can move, or remove it, as needed.
            this.cDE_CurrencyTableAdapter.Fill(this.nEWERPDataSet.CDE_Currency);
            if (Messages.CurLang == Messages.ArabLang)
            {
                slAccountTypes = new StaticList(GLibrary.strarrAccountTypes);
            }
            else
            {
                slAccountTypes = new StaticList(GLibrary.strarrEngAccountTypes);
                CmbClosedTo.ValueMember = "accountId";
                CmbClosedTo.DisplayMember = "AccountSName";
            }
            Flag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            ERPSYS.NEWERPDataSet nEWERPDataSetClosedTo = new NEWERPDataSet();
            BindingSource accountingClosedtoBindingSource = new BindingSource();
            NEWERPDataSetTableAdapters.accountingTableAdapter accountingClosedToTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            accountingClosedtoBindingSource.DataMember = "accounting";
            accountingClosedtoBindingSource.DataSource = nEWERPDataSetClosedTo;
            CmbClosedTo.DataSource = accountingClosedtoBindingSource;

            accountingClosedToTableAdapter.FillByClosedTo(nEWERPDataSetClosedTo.accounting);
            if (nEWERPDataSetClosedTo.accounting.Rows.Count > 0)
            {
                CmbClosedTo.SelectedIndex = 0;
            }
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            selectedTab = this.tabControlProduct.SelectedTab;
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Assemply' table. You can move, or remove it, as needed.
            CmbAccountType.DataSource = slAccountTypes.ToDataTable();
            //CmbPriceRule.DataSource = slPriceRules.ToDataTable();
            LoadTreeData();

            if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
            if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
            Flag = true;
            errorProvider1.Clear();
            if (nEWERPDataSet.accounting.Count == 0)
            {
                //AddNew();
                CmdDel.Enabled = false;
                CmdSave.Enabled = false;

            }



        }
        private void LoadTreeData()
        {
            string SelAcc = "";
            if (AccountTreeView.SelectedNode != null)
            {
                SelAcc = AccountTreeView.SelectedNode.Tag.ToString();
            }
            bFlag = false;
            if (AccountTreeView.Nodes.Count > 0)
            {
                AccountTreeView.Nodes.Clear();
            }
            AddMainNode();
            EditFlag = true;
            if (AccountTreeView.Nodes.Count > 0)
            {

                //AccountTreeView.Nodes[0].Expand();
                TreeNode[] SearchNodes = AccountTreeView.Nodes.Find(SelAcc, true);
                if (SearchNodes.Length > 0)
                {
                    if (SearchNodes[0].Nodes.Count > 0)
                    {
                        SearchNodes[0].Expand();
                    }
                    else
                    {
                        if (SearchNodes[0].Parent != null)
                        {
                            SearchNodes[0].Parent.Expand();
                        }
                    }

                    AccountTreeView.SelectedNode = SearchNodes[0];
                    AccountTreeView.Select();
                }
                else
                {
                    AccountTreeView.Nodes[0].Expand();
                    AccountTreeView.SelectedNode = AccountTreeView.Nodes[0];
                    AccountTreeView.Select();
                }

            }

            bFlag = true;
        }
        private void AddMainNode()
        {
            accountingBindingSource.Filter = "AccountparentId = 1" + " and root=1 ";

            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)accountingBindingSource.List;
            DataTable T = list.ToTable();
            accountingBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["root"];
                TreeNode RootNode = new TreeNode();
                RootNode.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"] + "-" + T.Rows[i]["AccountSName"].ToString();
                RootNode.Name = T.Rows[i]["accountid"].ToString();
                RootNode.Tag = (Int64)T.Rows[i]["accountid"];
                RootNode.ContextMenuStrip = ContextMenuAccount;
                RootNode.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];
                AccountTreeView.Nodes.Add(RootNode);

                if (bRoot)
                {
                    AddItem(RootNode);
                }

            }

        }
        private void AddItem(TreeNode ParentNode)
        {


            accountingBindingSource.Filter = "AccountparentId = " + ParentNode.Tag.ToString();
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)accountingBindingSource.List;

            DataTable T = new DataTable();
            T = list.ToTable();
            accountingBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["Root"];

                TreeNode Node = new TreeNode();
                Node.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"] + "-" + T.Rows[i]["AccountSName"].ToString();
                Node.Name = T.Rows[i]["accountid"].ToString();
                Node.Tag = (Int64)T.Rows[i]["accountid"];
                Node.ContextMenuStrip = ContextMenuAccount;
                Node.ToolTipText = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"];

                ParentNode.Nodes.Add(Node);
                Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                int accountType = (int)T.Rows[i]["accountType"];
                Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];

                if (MainNode) //has childern
                {
                    if (accountType == 2)
                    {
                        Node.ImageIndex = 4;
                        Node.SelectedImageIndex = 4;
                    }
                    else
                    {
                        Node.ImageIndex = 0;
                        Node.SelectedImageIndex = 0;
                    }
                    AddItem(Node);
                }
                else
                {
                    if (accountType > 2)
                    {
                        Node.ImageIndex = 3;
                        Node.SelectedImageIndex = 3;
                    }
                    else if (ProcessFlag)
                    {
                        Node.ImageIndex = 2;
                        Node.SelectedImageIndex = 2;
                    }
                    else
                    {
                        Node.ImageIndex = 1;
                        Node.SelectedImageIndex = 1;
                    }


                }
            }

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveAllData(MainAddNode, false);
        }
        private Boolean CheckCode(string AcctCode)
        {
            int Count = 0;
            Count = int.Parse(accountingTableAdapter.CheckAccountCode(AcctCode).ToString());
            if (Count > 0)
            {
                if (Count == 1 && EditFlag)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
        private Boolean SaveAllData(TreeNode SNode, Boolean DelFlag)
        {

            Boolean ret = false;
            if (GLibrary.MsgCheckSave(DelFlag))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, txtAccountName, "ÃÏÎá ÃÓã ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true) && GLibrary.ValidatetxtBox(errorProvider1, txtAccountCode, "ÃÏÎá ßæÏ ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true) && GLibrary.IsNumeric(txtAccountCode.Text))
                    {
                        if (!CheckCode(txtAccountCode.Text))
                        {
                            MessageBox.Show(Messages.codeErrorMesg, "ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                            return false;
                        }

                        int pos = accountingBindingSource.Find("accountid", txtAccountparentId.Text);
                        if (!EditFlag)
                        {

                            if (pos > -1)
                            {
                                long oldLastSerialNo;
                                if (nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"] != DBNull.Value)
                                {
                                    oldLastSerialNo = long.Parse(nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"].ToString());
                                }
                                else
                                {
                                    oldLastSerialNo = long.Parse(LastSerialNo);
                                }
                                if (long.Parse(txtAccountCode.Text) >= oldLastSerialNo)
                                {
                                    nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"] = txtAccountCode.Text;
                                }
                            }
                            txtLastSerial.Text = txtAccountCode.Text + "0";
                        }
                        else
                        {
                            if (pos > -1)
                            {
                                long oldLastSerialNo;
                                if (nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"] != DBNull.Value)
                                {
                                    oldLastSerialNo = long.Parse(nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"].ToString());
                                }
                                else
                                {
                                    oldLastSerialNo = long.Parse(txtAccountCode.Text);
                                }
                                if (long.Parse(txtAccountCode.Text) >= oldLastSerialNo)
                                {
                                    nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"] = txtAccountCode.Text;
                                }
                            }
                        }



                        bFlag = false;
                        RestoreTreeNode();

                        accountingBindingSource.EndEdit();
                        int I = accountingTableAdapter.Update(nEWERPDataSet.accounting);
                        Messages.AccountFlag = 1;
                        LastSerialNo = "";
                        int Type;
                        if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 3) // Úãíá
                        {

                            //frmCustSup.SaveData();
                            Type = int.Parse(Messages.CustFlag.ToString());
                            tabControlProduct.SelectedIndex = 1;
                            tabControlProduct.SelectedIndex = 0;
                            frmCustSup.txtSUP_CUST_FNAME.Text = txtAccountName.Text;

                            showNewTab(int.Parse(Messages.CustFlag.ToString()));
                            frmCustSup.SaveData();

                        }
                        else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 4) //ãæÇÑÏ
                        {
                            //Type = int.Parse(Messages.SupFlag.ToString());
                            //tabControlProduct.SelectedIndex = 1;
                            //tabControlProduct.SelectedIndex = 0;
                            //frmCustSup.SaveData();

                            Type = int.Parse(Messages.SupFlag.ToString());
                            tabControlProduct.SelectedIndex = 1;
                            tabControlProduct.SelectedIndex = 0;
                            frmCustSup.txtSUP_CUST_FNAME.Text = txtAccountName.Text;
                            showNewTab(int.Parse(Messages.SupFlag.ToString()));
                            frmCustSup.SaveData();
                        }
                        else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 5)
                        {
                            tabControlProduct.SelectedIndex = 2;
                            tabControlProduct.SelectedIndex = 0;

                            frmEmp.salesAdminFalgCheckBox.Checked = false;
                            frmEmp.txtcom.Enabled = false;
                            if (Messages.CurLang == Messages.ArabLang)
                            {
                                frmEmp.lblEmpCode.Text = "ßæÏ ÇáãæÙÝ";
                                frmEmp.lblEmpName.Text = "ÃÓã ÇáãæÙÝ";

                            }
                            else if (Messages.CurLang == Messages.EngLang)
                            {
                                frmEmp.lblEmpCode.Text = "Code";
                                frmEmp.lblEmpName.Text = "Name";
                            }

                            frmEmp.SaveData();
                        }
                        else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 6)
                        {
                            tabControlProduct.SelectedIndex = 2;
                            tabControlProduct.SelectedIndex = 0;

                            frmEmp.salesAdminFalgCheckBox.Checked = true;
                            frmEmp.txtcom.Enabled = true;
                            if (Messages.CurLang == Messages.ArabLang)
                            {
                                frmEmp.lblEmpCode.Text = "ßæÏ ÇáãäÏæÈ";
                                frmEmp.lblEmpName.Text = "ÃÓã ÇáãäÏæÈ";
                            }
                            else if (Messages.CurLang == Messages.EngLang)
                            {
                                frmEmp.lblEmpCode.Text = "Code";
                                frmEmp.lblEmpName.Text = "Name";
                            }


                            frmEmp.SaveData();
                        }
                        if (!EditFlag)
                        {
                            TreeNode Node = new TreeNode();
                            Node.Text = txtAccountCode.Text + " / " + txtAccountName.Text;
                            Node.Name = txtAccountId.Text;

                            if (int.Parse(CmbAccountType.SelectedValue.ToString()) > 2)
                            {
                                Node.ImageIndex = 3;
                                Node.SelectedImageIndex = 3;
                            }
                            else
                            {
                                if (MainAccChkBox.Checked)
                                {
                                    Node.ImageIndex = 0;
                                    Node.SelectedImageIndex = 0;
                                }
                                else
                                {
                                    Node.ImageIndex = 1;
                                    Node.SelectedImageIndex = 1;
                                }
                            }

                            Node.Tag = txtAccountId.Text;
                            Node.Text = txtAccountCode.Text + " / " + txtAccountName.Text + txtAccountSName.Text;
                            Node.ToolTipText = txtAccountCode.Text + " / " + txtAccountName.Text;


                            if (SNode == null)
                            {
                                AccountTreeView.Nodes.Add(Node);
                            }
                            else
                            {
                                SNode.Nodes.Add(Node);
                            }

                            Node.ContextMenuStrip = ContextMenuAccount;
                            Flag = false;
                            if (SNode != null)
                            {
                                SNode.Expand();
                            }

                            AccountTreeView.SelectedNode = Node;

                            Flag = true;
                            AccountTreeView.Select();
                            EditFlag = true;
                            CmdAdd.Enabled = true;
                            CmdDel.Enabled = true;
                            CmdSave.Enabled = true;

                            if (Messages.CurLang == Messages.ArabLang)
                            {
                                CmdSave.Text = "ÊÚÏíá";

                            }
                            else if (Messages.CurLang == Messages.EngLang)
                            {
                                CmdSave.Text = "Edit";
                            }
                            //CmdSave.Text = "ÊÚÏíá";

                        }
                        else
                        {
                            if (AccountTreeView.SelectedNode != null)
                            {
                                string str = ((DataRowView)accountingBindingSource.Current)["AccountCode"].ToString() + " / " + ((DataRowView)accountingBindingSource.Current)["accountname"].ToString() + "-" + ((DataRowView)accountingBindingSource.Current)["AccountSName"].ToString();
                                AccountTreeView.SelectedNode.Tag = ((DataRowView)accountingBindingSource.Current)["accountid"].ToString();
                                AccountTreeView.SelectedNode.Text = str;
                                AccountTreeView.SelectedNode.ToolTipText = str;

                            }
                        }
                        if (!DelFlag)
                        {
                            GLibrary.MsgSave();
                        }
                        bFlag = true;
                        ret = true;
                    }
                    else
                    {
                        ret = false;
                    }
                }
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    GLibrary.ExceptionToMessage(ex, ref ErrorNo);
                }
            }
            return ret;
        }
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }
        private void AddNew()
        {
            if (AccountTreeView.SelectedNode == null)
            {
                MainAddNode = null;
            }

            else if (AccountTreeView.SelectedNode.Parent == null)
            {
                MainAddNode = null;
            }
            else
            {
                MainAddNode = AccountTreeView.SelectedNode.Parent;

            }

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõòòSave";
            }
            bFlag = false;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
            CmdSave.Enabled = true;
        }
        private void CheckAccountType(TreeNode Node)
        {
            long AccountId = long.Parse(Node.Tag.ToString());

            if (AccountId == Messages.custaccid)
            {
                CmbAccountType.SelectedValue = 3;
            }
            else if (AccountId == Messages.suppaccid)
            {
                CmbAccountType.SelectedValue = 4;
            }
            else
            {
                CmbAccountType.SelectedValue = 1;
            }



        }
        private void AddNewAccount(TreeNode Node, Boolean MainFlag)
        {
            //CmbClosedTo.SelectedIndex = 0;
            accountingBindingSource.AddNew();
            txtdisplay_Flag.Text = bool.FalseString;
            txtLastSerial.Text = "0";

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "ÍÝÙ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "òõòòSave";
            }
            if (Node == null)
            {
                txtAccountparentId.Text = "1";
                txtAccountparentCode.Text = "0";
                txtLevel.Text = "0";
                txtMainParentId.Text = "1";
                txtRootFlag.Text = bool.TrueString;
                txtProcessFlag.Text = bool.FalseString;
                MainAccChkBox.Checked = true;
                int intCount = AccountTreeView.Nodes.Count;
                txtAccountCode.Text = txtAccountCode.Text + (intCount + 1).ToString();
                if (CmbClosedTo.Items.Count > 0) CmbClosedTo.SelectedIndex = 0;
                if (CmbAccountType.Items.Count > 0) CmbAccountType.SelectedIndex = 0;
            }
            else if (Node.Level > -1)
            {
                txtAccountparentId.Text = Node.Tag.ToString();
                txtAccountparentName.Text = Node.Text;
                int index = Node.ToolTipText.IndexOf("/");
                txtAccountparentCode.Text = Node.ToolTipText.Substring(0, index);
                txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                txtLevel.Text = (Node.Level + 1).ToString();
                GetMainParent(Node);
                txtRootFlag.Text = bool.FalseString;
                txtProcessFlag.Text = bool.FalseString;
                //if (CmbClosedTo.Items.Count > 0) CmbClosedTo.SelectedIndex = 0;

                Node.ImageIndex = 0;
                Node.SelectedImageIndex = 0;
                if (Node == null)
                {
                    MainAccChkBox.Checked = true;
                    MainAccChkBox.Enabled = false;
                }
                else
                {
                    MainAccChkBox.Checked = MainFlag;
                    MainAccChkBox.Enabled = true;
                }



                //update parent informations
                //int Pos = accountingBindingSource.Find("accountid", txtAccountparentId.Text);
                //if (Pos != -1)
                //{
                //    nEWERPDataSet.accounting.Rows[Pos].BeginEdit();
                //    nEWERPDataSet.accounting.Rows[Pos]["Root"] = true;
                //    nEWERPDataSet.accounting.Rows[Pos]["MainNode"] = true;
                //    nEWERPDataSet.accounting.Rows[Pos]["ProcessFlag"] = true;
                //    ((DataRowView)accountingBindingSource.Current).Row.BeginEdit();
                //    ((DataRowView)accountingBindingSource.Current)["MainNode"] = true;
                //    ((DataRowView)accountingBindingSource.Current).Row.EndEdit ();

                //    nEWERPDataSet.accounting.Rows[Pos].EndEdit();
                //    if (Node.Level > 0)
                //    {
                //        CmbClosedTo.SelectedValue = nEWERPDataSet.accounting.Rows[Pos]["ClosedTo"];
                //        CmbClosedTo.Enabled = false;
                //    }

                // }


            }
            if (Node != null)
            {
                CheckAccountType(Node);
            }
            //MainAccChkBox.Enabled = true;
            //MainAccChkBox.Checked = false;
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            txtAccountName.Focus();
            txtStartdate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
        }
        private void GetMainParent(TreeNode Node)
        {
            int intCount = Node.Nodes.Count;
            int index = Node.ToolTipText.IndexOf("/");
            txtAccountCode.Text = Node.ToolTipText.Substring(0, index);
            txtAccountCode.Text = txtAccountCode.Text.TrimEnd();
            string accountid = Node.Tag.ToString();
            int pos = accountingBindingSource.Find("accountid", accountid);
            long Serial = 0;
            if (pos > -1)
            {
                string str = "";
                LastSerialNo = nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"].ToString();
                if (LastSerialNo == "")
                {
                    str = txtAccountCode.Text + Node.Nodes.Count.ToString();

                }
                else
                {
                    str = LastSerialNo.Remove(0, txtAccountCode.Text.Length);
                    if (str == "")
                    {
                        str = "0";
                    }
                }
                Serial = long.Parse(str);
                //Serial = long.Parse(nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"].ToString());
                if (nEWERPDataSet.accounting.Rows[pos]["ClosedTo"] != DBNull.Value)
                {
                    //((DataRowView)accountingBindingSource.Current)["ClosedTo"] = nEWERPDataSet.accounting.Rows[pos]["ClosedTo"].ToString();
                    CmbClosedTo.SelectedValue = nEWERPDataSet.accounting.Rows[pos]["ClosedTo"].ToString();
                }
                else
                {
                    CmbClosedTo.SelectedIndex = 0;
                }
                CmbClosedTo.Enabled = false;

            }

            Serial = Serial + 1;

            int NewSeraillen = Serial.ToString().Length;
            if (NewSeraillen == LastSerialNo.Length) // old =new length
            {
                LastSerialNo = Serial.ToString();
            }
            else
            {
                if (LastSerialNo != "")
                {

                    LastSerialNo = LastSerialNo.Substring(0, LastSerialNo.Length - Serial.ToString().Length) + Serial;
                }
                else
                {
                    LastSerialNo = Serial.ToString();
                }
            }
            //LastSerialNo = LastSerialNo + 1;
            txtAccountCode.Text = LastSerialNo; //(intCount + 1); //"-"+ .ToString("000000");
            //String strMainParent="";
            //for (int i = 0; i > Node.Level; i--)
            //{
            //    if (i == 0)
            //    {
            //        strMainParent = Node.Tag.ToString ();
            //    }
            //    else
            //    {
            //        TreeNode TNode = Node.Parent;
            //        strMainParent = TNode.Tag.ToString();
            //    }
            //}
            //txtMainParentId.Text = strMainParent;
        }
        private void ProductstreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (Flag)
            {
                try
                {
                    //add mode 

                    //CmdSave.Text = "ÊÚÏíá";
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSave.Text = "ÊÚÏíá";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSave.Text = "òõòòEdit";
                    }
                    if (((DataRowView)accountingBindingSource.Current).Row.RowState == DataRowState.Detached)
                    {
                        if (GLibrary.MsgCheckSave(false))
                        {
                            if (SaveAllData(MainAddNode, false))
                            {
                            }
                            else
                            {
                                CmdAdd.Enabled = true;
                                CmdDel.Enabled = true;
                                EditFlag = true;
                                return;

                            }
                        }
                        else
                        {
                            accountingBindingSource.CancelEdit();
                            this.nEWERPDataSet.RejectChanges();
                            CmdAdd.Enabled = true;
                            CmdDel.Enabled = true;
                            EditFlag = true;

                        }
                    }
                    else //edit mode
                    {
                        // string AccId = e.Node.Tag.ToString ();
                        // int pos = accountingBindingSource.Find("accountid", AccId);
                        //if (pos > -1)
                        //{
                        //    accountingBindingSource.Position = pos;
                        //}
                        ((DataRowView)accountingBindingSource.Current).EndEdit();
                        if (this.nEWERPDataSet.HasChanges() == true)
                        //if (((DataRowView)accountingBindingSource.Current).RowVersion == DataRowVersion.Proposed)
                        {
                            Boolean LocFlag = false;
                            if (FlagFoDel)
                            {
                                LocFlag = true;
                            }
                            if (GLibrary.MsgCheckSave(LocFlag))
                            {
                                LocFlag = true;
                                if (SaveAllData(MainAddNode, LocFlag))
                                {
                                }
                                else
                                {
                                    CmdAdd.Enabled = true;
                                    CmdDel.Enabled = true;
                                    EditFlag = true;
                                    return;

                                }
                            }
                            else
                            {
                                accountingBindingSource.CancelEdit();
                                this.nEWERPDataSet.RejectChanges();
                                CmdAdd.Enabled = true;
                                CmdDel.Enabled = true;
                                EditFlag = true;

                            }
                        }
                    }
                    //else  //edit mode
                    //{

                    //    //if (EditFlag)
                    //    //{
                    //    //    if (SaveAllData(MainAddNode))
                    //    //    {

                    //    //    }
                    //    //    else
                    //    //    {
                    //    //        accountingBindingSource.CancelEdit();
                    //    //        CmdAdd.Enabled = true;
                    //    //        CmdDel.Enabled = true;
                    //    //        EditFlag = true;
                    //    //    }
                    //    //}

                    //}


                    int Accountid = int.Parse(e.Node.Tag.ToString());
                    int Pos = accountingBindingSource.Find("accountid", Accountid);
                    bFlag = false;
                    accountingBindingSource.Position = Pos;
                    bFlag = true;
                    ChangeNodeData();
                    decimal fromvalue = 0;
                    decimal tovalue = 0;
                    if (GLibrary.IsNumeric(txtFromValue.Text))
                    {
                        fromvalue = decimal.Parse(txtFromValue.Text);
                    }
                    if (GLibrary.IsNumeric(txtToValue.Text))
                    {
                        tovalue = decimal.Parse(txtToValue.Text);
                    }
                    txtAccValue.Text = (fromvalue - tovalue).ToString();
                    if (e.Node.Level > 0) //Get Parent info
                    {
                        txtAccountparentName.Text = e.Node.Parent.Text;
                        int index = e.Node.Parent.ToolTipText.IndexOf("/");
                        txtAccountparentCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
                        txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                    }
                    if (e.Node.Level > 0)
                    {
                        Boolean ProcessFlag = (Boolean)((DataRowView)accountingBindingSource.Current)["ProcessFlag"];

                        if (ProcessFlag)
                        {
                            //MainAccChkBox.Checked = true;
                            MainAccChkBox.Enabled = false;

                        }
                        else
                        {
                            Boolean MainNode = (Boolean)((DataRowView)accountingBindingSource.Current)["MainNode"];
                            MainAccChkBox.Checked = MainNode;
                            if (e.Node.Nodes != null)
                            {
                                if (e.Node.Nodes.Count > 0)
                                {
                                    MainAccChkBox.Enabled = false;
                                }
                                else
                                {
                                    MainAccChkBox.Enabled = true;
                                }
                            }


                        }

                        //txtRootFlag.Text = (Boolean)((DataRowView)accountingBindingSource.Current)["Root"];// bool.FalseString;
                        CmbClosedTo.Enabled = false;
                    }
                    else
                    {
                        MainAccChkBox.Enabled = false;
                        CmbClosedTo.Enabled = true;
                        //((DataRowView)accountingBindingSource.Current)["ProcessFlag"] = true;
                        //nEWERPDataSet.accounting[Pos]["ProcessFlag"] = true;
                        //txtRootFlag.Text = bool.TrueString;

                    }


                    errorProvider1.Clear();
                }

                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáÍÓÇÈÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        public void TreeSearch()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch = "";
            int Pos = accountingBindingSource.Find("accountname", txtSearch.Text);
            if (Pos == -1)
            {
                Pos = accountingBindingSource.Find("AccountCode", txtSearch.Text);

            }
            if (Pos != -1)
            {
                strSearch = nEWERPDataSet.accounting.Rows[Pos]["accountid"].ToString();
                TreeNode[] SearchNodes = AccountTreeView.Nodes.Find(strSearch, true);
                if (SearchNodes.Length > 0)
                {
                    if (SearchNodes[0].Nodes.Count > 0)
                    {
                        SearchNodes[0].Expand();
                    }
                    else
                    {
                        if (SearchNodes[0].Parent != null)
                        {
                            SearchNodes[0].Parent.Expand();
                        }
                    }
                    AccountTreeView.SelectedNode = SearchNodes[0];
                    AccountTreeView.Select();
                }
            }
            else
            {
                MessageBox.Show(Messages.AccSearchMessage, "ÇáÈÍË", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeSearch();
            }
        }

        private void ProductstreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            AccountTreeView.SelectedNode = e.Node;
            AccountTreeView.Select();
        }

        private void ProductstreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            AccountTreeView.SelectedNode = e.Node;
            AccountTreeView.Select();
        }

        private void pRODUCTSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (accountingBindingSource.Count > 0)
            {
                Int64 ProductId = (Int64)((DataRowView)accountingBindingSource.Current)["accountid"];

            }
        }



        private void tabControlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTab != this.tabControlProduct.SelectedTab)

                switch (tabControlProduct.SelectedIndex)
                {
                    case 0:
                        //DialogResult ret; 
                        //ret = MessageBox.Show(Messages.ConfirmSaveMesg, "ÍÝÙ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        //if (ret == DialogResult.Yes)
                        //{
                        //    SaveAllData(MainAddNode);


                        //}
                        //else
                        //{
                        //    frmCustSup.CancelAdding();
                        //}
                        break;
                    case 1:
                        if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 3)
                        {
                            showNewTab(int.Parse(Messages.CustFlag.ToString()));
                        }
                        else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 4)
                        {
                            showNewTab(int.Parse(Messages.SupFlag.ToString()));
                        }
                        if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 5)
                        {
                            SaveEmp(false);
                        }
                        if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 6)
                        {
                            SaveEmp(true);
                        }
                        break;
                    case 2:

                        break;
                }



            selectedTab = tabControlProduct.SelectedTab;

        }

        private void CmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeNodeData();

        }
        private void ChangeNodeData()
        {
            if (bFlag)
            {
                if (CmbAccountType.SelectedValue != null && bFlag)
                {
                    if (txtAccountName.Text == "")
                    {
                        CmbAccountType.SelectedValue = "1";
                        errorProvider1.SetError(txtAccountName, "ÃÏÎá ÃÓã ÇáÍÓÇÈ ÇæáÇ");

                    }
                    else
                    {

                        switch (int.Parse(CmbAccountType.SelectedValue.ToString()))
                        {
                            case 1:
                                if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                                if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                                RestoreTreeNode();
                                break;
                            case 2:
                                if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                                if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                                RestoreTreeNode();

                                break;
                            case 3:
                                if (ChangeState())
                                {
                                    if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                                    if (!tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Add(CustTabPage);
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        tabControlProduct.TabPages["CustTabPage"].Text = "ÈØÇÞÉ Úãíá";
                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        tabControlProduct.TabPages["CustTabPage"].Text = "Customer";
                                    }


                                    RestoreTreeNode();

                                    //tabControlProduct.TabPages[1].Select();
                                }
                                break;
                            case 4:
                                if (ChangeState())
                                {
                                    if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                                    if (!tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Add(CustTabPage);
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        tabControlProduct.TabPages["CustTabPage"].Text = "ÈØÇÞÉ ãæÑÏ";
                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        tabControlProduct.TabPages["CustTabPage"].Text = "Supplier";
                                    }

                                    RestoreTreeNode();
                                    //showNewTab(int.Parse(Messages.SupFlag));
                                }

                                break;
                            case 5:
                                if (ChangeState())
                                {
                                    if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                                    if (!tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Add(EmptabPage);

                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        tabControlProduct.TabPages["EmptabPage"].Text = "ÈØÇÞÉ ãæÙÝ";
                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        tabControlProduct.TabPages["EmptabPage"].Text = "Emp Card";
                                    }
                                    RestoreTreeNode();
                                }
                                break;
                            case 6:
                                if (ChangeState())
                                {
                                    if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                                    if (!tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Add(EmptabPage);
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        tabControlProduct.TabPages["EmptabPage"].Text = "ÈØÇÞÉ ãäÏæÈ";
                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        tabControlProduct.TabPages["EmptabPage"].Text = "commissioner";
                                    }

                                    RestoreTreeNode();
                                }
                                break;
                        }
                    }
                }
            }
        }
        private Boolean ChangeState()
        {
            if (accountingBindingSource.Count > 0)
            {
                Boolean PervRoot = false;
                if (((DataRowView)accountingBindingSource.Current)["MainNode"].ToString() != "")
                {
                    PervRoot = (Boolean)((DataRowView)accountingBindingSource.Current)["MainNode"];
                }
                //Boolean root = Boolean.Parse(txtRootFlag.Text);

                int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());
                int PervaccountType;
                if (((DataRowView)accountingBindingSource.Current).IsNew)
                {
                    PervaccountType = 1;
                    //PervRoot = MainAccChkBox.Checked;
                }
                else
                {
                    PervaccountType = int.Parse(((DataRowView)accountingBindingSource.Current)["accountType"].ToString());
                }
                if (PervRoot && accountType >= 3)
                {
                    bFlag = false;
                    CmbAccountType.SelectedValue = PervaccountType;

                    //((DataRowView)accountingBindingSource.Current).CancelEdit();
                    bFlag = true;
                    MessageBox.Show(Messages.ChangeTypeMessage, "ÊÛíÑ äæÚ ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
        private void RestoreTreeNode()
        {

            if (accountingBindingSource.Count > 0)
            {
                if (EditFlag)
                {
                    Boolean ProcessFlag = Boolean.Parse(txtProcessFlag.Text);// ((DataRowView)accountingBindingSource.Current)["ProcessFlag"];
                    int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());// ((DataRowView)accountingBindingSource.Current)["accountType"];
                    Boolean root = Boolean.Parse(txtRootFlag.Text); //((DataRowView)accountingBindingSource.Current)["root"];
                    if (MainAccChkBox.Checked)
                    {
                        if (accountType == 2)
                        {
                            AccountTreeView.SelectedNode.ImageIndex = 4;
                            AccountTreeView.SelectedNode.SelectedImageIndex = 4;
                        }
                        else
                        {
                            AccountTreeView.SelectedNode.ImageIndex = 0;
                            AccountTreeView.SelectedNode.SelectedImageIndex = 0;
                        }
                    }
                    else if (accountType > 2)
                    {
                        AccountTreeView.SelectedNode.ImageIndex = 3;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 3;
                    }
                    else if (ProcessFlag)
                    {
                        AccountTreeView.SelectedNode.ImageIndex = 2;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 2;
                    }
                    else
                    {
                        AccountTreeView.SelectedNode.ImageIndex = 1;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 1;
                    }
                }
                else
                {
                    //((DataRowView)accountingBindingSource.Current).BeginEdit();
                    if (MainAccChkBox.Checked)
                    {
                        ((DataRowView)accountingBindingSource.Current)["MainNode"] = Boolean.TrueString;
                    }
                    else
                    {
                        ((DataRowView)accountingBindingSource.Current)["MainNode"] = Boolean.FalseString;
                    }
                    // ((DataRowView)accountingBindingSource.Current).EndEdit();
                }
            }

        }
        private void showNewTab(int Type)
        {
            SaveCust(Type);
            //tabControlProduct.SelectedIndex = 1;
            //tabControlProduct.TabPages[1].Select();
        }
        private void SaveCust(int Type)
        {
            frmCustSup.TopLevel = false;
            frmCustSup.FormBorderStyle = FormBorderStyle.None;
            frmCustSup.Parent = tabControlProduct.TabPages["CustTabPage"];
            frmCustSup.CustSupType = Type;
            long Curaccountid = (long)((DataRowView)accountingBindingSource.Current)["accountid"];
            frmCustSup.AccId = Curaccountid.ToString();
            frmCustSup.Show();
            //tabControlProduct.SelectedIndex = 1;
            //frmCustSup.FillData();
            SaveFlag = true;
            if (accountingBindingSource.Count > 0)
            {
                Int64 accountid = (Int64)((DataRowView)accountingBindingSource.Current)["accountid"];
                string SUP_CUST_FNAME = txtAccountName.Text; //((DataRowView)accountingBindingSource.Current)["accountname"].ToString();
                string AccountCode = txtAccountCode.Text; //((DataRowView)accountingBindingSource.Current)["AccountCode"].ToString();
                if (!frmCustSup.CheckCust(int.Parse(accountid.ToString())))
                {

                    frmCustSup.AddNewCust();

                    frmCustSup.txtAccountId.Text = accountid.ToString();
                    frmCustSup.txtSUP_CUST_FNAME.Text = SUP_CUST_FNAME;
                    frmCustSup.txtAccCode.Text = AccountCode;

                }
                else
                {
                    frmCustSup.txtAccountId.Text = accountid.ToString();
                    frmCustSup.txtSUP_CUST_FNAME.Text = SUP_CUST_FNAME;
                    frmCustSup.txtAccCode.Text = AccountCode;
                    frmCustSup.txtCustSuptype.Text = Type.ToString();
                }
            }
        }
        private void SaveEmp(Boolean EmpFlag)
        {
            frmEmp.TopLevel = false;
            frmEmp.FormBorderStyle = FormBorderStyle.None;
            frmEmp.Parent = tabControlProduct.TabPages["EmpTabPage"];
            frmEmp.Show();
            //tabControlProduct.SelectedIndex = 1;
            //frmCustSup.FillData();
            EmpSaveFlag = true;
            if (accountingBindingSource.Count > 0)
            {
                Int64 accountid = (Int64)((DataRowView)accountingBindingSource.Current)["accountid"];
                string Emp_FNAME = ((DataRowView)accountingBindingSource.Current)["accountname"].ToString();
                string AccountCode = ((DataRowView)accountingBindingSource.Current)["AccountCode"].ToString();
                if (!frmEmp.CheckCust(int.Parse(accountid.ToString())))
                {

                    frmEmp.AddNewEmp();

                    frmEmp.txtEmpAccountId.Text = accountid.ToString();
                    frmEmp.txtEmpName.Text = Emp_FNAME;
                    if (EmpFlag)
                    {
                        frmEmp.salesAdminFalgCheckBox.Checked = true;
                        frmEmp.txtcom.Enabled = true;


                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            frmEmp.lblEmpCode.Text = "ßæÏ ÇáãäÏæÈ";
                            frmEmp.lblEmpName.Text = "ÃÓã ÇáãäÏæÈ";
                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            frmEmp.lblEmpCode.Text = "Code";
                            frmEmp.lblEmpName.Text = "Name";
                        }
                    }
                    else
                    {
                        frmEmp.salesAdminFalgCheckBox.Checked = false;
                        frmEmp.txtcom.Enabled = false;
                        if (Messages.CurLang == Messages.ArabLang)
                        {
                            frmEmp.lblEmpCode.Text = "ßæÏ ÇáãæÙÝ";
                            frmEmp.lblEmpName.Text = "ÃÓã ÇáãæÙÝ";
                        }
                        else if (Messages.CurLang == Messages.EngLang)
                        {
                            frmEmp.lblEmpCode.Text = "Code";
                            frmEmp.lblEmpName.Text = "Name";
                        }

                    }
                    //frmEmp.txtAccCode.Text = AccountCode;

                }
            }
        }
        //private void SaveCust(int Type)
        //{
        //    frmCustSup.TopLevel = false;
        //    frmCustSup.FormBorderStyle = FormBorderStyle.None;
        //    frmCustSup.Parent = tabControlProduct.TabPages["CustTabPage"];
        //    frmCustSup.CustSupType = Type;
        //    frmCustSup.Show();
        //    //tabControlProduct.SelectedIndex = 1;
        //    //frmCustSup.FillData();
        //    SaveFlag = true;
        //    if (accountingBindingSource.Count > 0)
        //    {
        //        Int64 accountid = (Int64)((DataRowView)accountingBindingSource.Current)["accountid"];
        //        string SUP_CUST_FNAME = txtAccountName.Text; //((DataRowView)accountingBindingSource.Current)["accountname"].ToString();
        //        string AccountCode = txtAccountCode.Text; //((DataRowView)accountingBindingSource.Current)["AccountCode"].ToString();
        //        if (!frmCustSup.CheckCust(int.Parse(accountid.ToString())))
        //        {

        //            frmCustSup.AddNewCust();

        //            frmCustSup.txtAccountId.Text = accountid.ToString();
        //            frmCustSup.txtSUP_CUST_FNAME.Text = SUP_CUST_FNAME;
        //            frmCustSup.txtAccCode.Text = AccountCode;

        //        }
        //    }
        //}
        //private void SaveEmp(Boolean EmpFlag)
        //{
        //    frmEmp.TopLevel = false;
        //    frmEmp.FormBorderStyle = FormBorderStyle.None;
        //    frmEmp.Parent = tabControlProduct.TabPages["EmpTabPage"];
        //    frmEmp.Show();
        //    //tabControlProduct.SelectedIndex = 1;
        //    //frmCustSup.FillData();
        //    EmpSaveFlag = true;
        //    if (accountingBindingSource.Count > 0)
        //    {
        //        Int64 accountid = (Int64)((DataRowView)accountingBindingSource.Current)["accountid"];
        //        string Emp_FNAME = ((DataRowView)accountingBindingSource.Current)["accountname"].ToString ();
        //        string AccountCode = ((DataRowView)accountingBindingSource.Current)["AccountCode"].ToString ();
        //        if (!frmEmp.CheckCust(int.Parse(accountid.ToString())))
        //        {

        //            frmEmp.AddNewEmp();

        //            frmEmp.txtEmpAccountId.Text = accountid.ToString();
        //            frmEmp.txtEmpName.Text = Emp_FNAME;
        //            if (EmpFlag)
        //            {
        //                frmEmp.salesAdminFalgCheckBox.Checked = true;
        //                frmEmp.txtcom.Enabled = true;


        //                if (Messages.CurLang == Messages.ArabLang)
        //                {
        //                    frmEmp.lblEmpCode.Text = "ßæÏ ÇáãäÏæÈ";
        //                    frmEmp.lblEmpName.Text = "ÃÓã ÇáãäÏæÈ";
        //                }
        //                else if (Messages.CurLang == Messages.EngLang)
        //                {
        //                    frmEmp.lblEmpCode.Text = "Code";
        //                    frmEmp.lblEmpName.Text = "Name";
        //                }
        //            }
        //            else
        //            {
        //                frmEmp.salesAdminFalgCheckBox.Checked = false;
        //                frmEmp.txtcom.Enabled = false ;
        //                if (Messages.CurLang == Messages.ArabLang)
        //                {
        //                    frmEmp.lblEmpCode.Text = "ßæÏ ÇáãæÙÝ";
        //                    frmEmp.lblEmpName.Text = "ÃÓã ÇáãæÙÝ";
        //                }
        //                else if (Messages.CurLang == Messages.EngLang)
        //                {
        //                    frmEmp.lblEmpCode.Text = "Code";
        //                    frmEmp.lblEmpName.Text = "Name";
        //                }

        //            }
        //            //frmEmp.txtAccCode.Text = AccountCode;

        //        }
        //    }
        //}

        private void MainAccChkBox_CheckedChanged(object sender, EventArgs e)
        {
            //if (bFlag)
            //{
            //    RestoreTreeNode();
            //}


        }



        private void TreeReFreshMenuItem_Click(object sender, EventArgs e)
        {
            LoadTreeData();
        }

        private void AddMainAccMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = false;
            MainAddNode = AccountTreeView.SelectedNode;

            AddNewAccount(MainAddNode, true);

            bFlag = true;
        }

        private void AddSubAccMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = false;
            MainAddNode = AccountTreeView.SelectedNode;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
        }

        private void AccountTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            AccountTreeView.SelectedNode = e.Node;
            AccountTreeView.Select();
            if (!MainAccChkBox.Checked)
            {
                AddSubAccMenuItem.Enabled = false;
                AddMainAccMenuItem.Enabled = false;

            }
            else
            {
                AddSubAccMenuItem.Enabled = true;
                AddMainAccMenuItem.Enabled = true;
            }
        }

        private void AccountTreeView_MouseClick(object sender, MouseEventArgs e)
        {

            if (!MainAccChkBox.Checked)
            {
                AddSubAccMenuItem.Enabled = false;
                AddMainAccMenuItem.Enabled = false;

            }
            else
            {
                AddSubAccMenuItem.Enabled = true;
                AddMainAccMenuItem.Enabled = true;
            }
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {
                if (AccountTreeView.SelectedNode != null)
                {
                    if (AccountTreeView.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show(Messages.AccountErrorMesg, "ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return;
                    }
                    else if (((DataRowView)accountingBindingSource.Current)["ProcessFlag"].ToString() == Boolean.TrueString)
                    {
                        MessageBox.Show(Messages.AccountProcessErrorMesg, "ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }

                    else
                    {
                        string PNode = "1";
                        Boolean ChangeFlag = false;
                        if (AccountTreeView.SelectedNode.Parent != null)
                        {
                            PNode = AccountTreeView.SelectedNode.Parent.Tag.ToString();
                        }

                        if (Boolean.Parse(((DataRowView)accountingBindingSource.Current)["MainNode"].ToString()) != true)
                        {
                            accountingBindingSource.RemoveCurrent();
                            FlagFoDel = true;
                            if (AccountTreeView.SelectedNode.NextNode == null)
                            {
                                ChangeFlag = true;
                            }
                            Flag = false;
                            AccountTreeView.SelectedNode.Remove();

                            FlagFoDel = false;
                            if (ChangeFlag)
                            {
                                int pos = accountingBindingSource.Find("accountid", PNode);
                                if (pos > -1)
                                {
                                    string AccountCode = "1";
                                    if (AccountTreeView.SelectedNode.LastNode != null)
                                    {
                                        int index = AccountTreeView.SelectedNode.LastNode.ToolTipText.IndexOf("/");
                                        AccountCode = AccountTreeView.SelectedNode.LastNode.ToolTipText.Substring(0, index);
                                        AccountCode = AccountCode.TrimEnd();
                                    }
                                    else  //if (AccountTreeView.SelectedNode.LastNode != null)
                                    {
                                        int index = AccountTreeView.SelectedNode.ToolTipText.IndexOf("/");
                                        AccountCode = AccountTreeView.SelectedNode.ToolTipText.Substring(0, index);
                                        AccountCode = AccountCode.TrimEnd();
                                        AccountCode = AccountCode + "0";
                                    }
                                    nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"] = AccountCode;

                                }


                            }
                        }
                        else
                        {
                            GLibrary.ShowMsg("ÇáÍÓÇÈ", "áÇ íãßä ÍÐÝ ÍÓÇÈ ÑÆíÓì", "Account", Messages.AccountdelRightMesgE, Messages.CurLang);
                        }
                    }

                    accountingTableAdapter.Update(nEWERPDataSet.accounting);
                    GLibrary.MsgDel();
                    //GLibrary .ShowMsg ("ÇáÍÓÇÈ",Messages.AccountdelRightMesg,"Account",Messages.AccountdelRightMesgE,Messages.CurLang );
                    //MessageBox.Show(Messages.AccountdelRightMesg, "ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    Flag = true;
                    if (AccountTreeView.SelectedNode.LastNode != null)
                    {
                        if (!AccountTreeView.SelectedNode.IsExpanded)
                        {
                            AccountTreeView.SelectedNode.Expand();
                        }
                        AccountTreeView.SelectedNode = AccountTreeView.SelectedNode.LastNode;
                        AccountTreeView.Select();
                    }

                }
            }




        }

        private void AccountAdd_Activated(object sender, EventArgs e)
        {

        }

        private void TreeOpenAllMItem_Click(object sender, EventArgs e)
        {
            AccountTreeView.ExpandAll();
        }

        private void PrintTreeMenuItem_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            NEWERPDataSetTableAdapters.setupTableAdapter SetupTableAdaptertemp = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            accountingBindingSourceTemp.DataMember = "accounting";
            accountingBindingSourceTemp.DataSource = nEWERPDataSetNew;
            this.accountingTableAdapter.Fill(nEWERPDataSetNew.accounting);

            this.accountingTableAdapter.Fill(nEWERPDataSetTempOld.accounting);
            SetupTableAdaptertemp.Fill(nEWERPDataSetTemp.setup);

            nEWERPDataSetTempOld.accounting.Clear();


            int AccountId = 1;
            int Level = 10;
            nEWERPDataSet.accounting.Clear();
            AddItem(int.Parse(AccountId.ToString()), Level);
            int AccLevel = 0;

            ShowNewRpt frm = new ShowNewRpt();

            frm.choiceNum = 10; //vertical
            frm.nEWERPDataSet = nEWERPDataSetTemp;
            frm.AccLevel = AccLevel;
            frm.ShowDialog(this);

        }

        private void AddItem(int AccountparentId, int Level)
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
                    //accountingTableAdapter.FillByRefBalance(nEWERPDataSetTempOld.accounting, accountid, null, null, null, null, null, 2);
                    NEWERPDataSet.accountingRow row = null;
                    row = nEWERPDataSetNew.accounting.FindByaccountid(accountid);
                    if (row != null)
                    {
                        nEWERPDataSetTemp.accounting.ImportRow(row);//nEWERPDataSetTempOld.accounting.Rows[0]);
                    }
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

        private void AccountMoveMenuItem_Click(object sender, EventArgs e)
        {
            AccountMove frm = new AccountMove();

            if (AccountTreeView.SelectedNode != null)
            {
                frm.AccountId = long.Parse(txtAccountId.Text);
                frm.OldParentAccountId = long.Parse(txtAccountparentId.Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
                    LoadTreeData();
                }
                else
                {

                }
            }

        }





    }
}