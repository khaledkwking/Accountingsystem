using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    public partial class AccountTree : DockContent
    {
        private CustSupAdd frmCustSup = new CustSupAdd();
        private EmpAdd frmEmp = new EmpAdd();
        private StaticList slAccountTypes = new StaticList(GLibrary.strarrAccountTypes);
        private Boolean bFlag = false;
        
        private TabPage selectedTab; 
        public Boolean EditFlag;
        public Boolean SaveFlag = false ;
        public Boolean EmpSaveFlag = false;
        private TreeNode MainAddNode = null;
        private Boolean Flag = false;
        private Boolean FlagFoDel = false;
        public AccountTree()
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
            Flag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            ERPSYS.NEWERPDataSet nEWERPDataSetClosedTo = new NEWERPDataSet();
            BindingSource accountingClosedtoBindingSource = new BindingSource();
            NEWERPDataSetTableAdapters.accountingTableAdapter accountingClosedToTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.accountingTableAdapter();
            accountingClosedtoBindingSource.DataMember = "accounting";
            accountingClosedtoBindingSource.DataSource = nEWERPDataSetClosedTo;
          

            accountingClosedToTableAdapter.FillByClosedTo(nEWERPDataSetClosedTo.accounting);
           
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            
            //CmbPriceRule.DataSource = slPriceRules.ToDataTable();
            LoadTreeData();

         
            Flag = true;
            errorProvider1.Clear();
           
          
        }
        private void LoadTreeData()
        {
            bFlag = false;
            if (AccountTreeView.Nodes.Count > 0)
            {
                AccountTreeView.Nodes.Clear();
            }
             AddMainNode();
             EditFlag = true;
             if (AccountTreeView.Nodes.Count > 0)
             {
                 AccountTreeView.Nodes[0].Expand();
                 AccountTreeView.SelectedNode = AccountTreeView.Nodes[0].FirstNode;
                 AccountTreeView.Select();
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
                RootNode.Text = T.Rows[i]["AccountCode"].ToString() + " / " + (string)T.Rows[i]["AccountName"] + "-"+T.Rows[i]["AccountSName"].ToString ();
                RootNode.Name = T.Rows[i]["accountid"].ToString();
                RootNode.Tag = (Int64)T.Rows[i]["accountid"];
                //RootNode.ContextMenuStrip = ContextMenuAccount;
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
                //Node.ContextMenuStrip = ContextMenuAccount;
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
            //SaveAllData(MainAddNode,false);  
        }
        //private Boolean  SaveAllData(TreeNode SNode, Boolean DelFlag  )
        //{
            
        //    Boolean ret = false;
        //    if (GLibrary.MsgCheckSave(DelFlag))
        //    {
        //        try
        //        {

        //            if (GLibrary.ValidatetxtBox(errorProvider1, txtAccountName, "ÃÏÎá ÃÓã ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true) && GLibrary.ValidatetxtBox(errorProvider1, txtAccountCode, "ÃÏÎá ßæÏ ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true))
        //            {
        //                bFlag = false;
        //                RestoreTreeNode();
        //                accountingBindingSource.EndEdit();
        //                int I = accountingTableAdapter.Update(nEWERPDataSet.accounting);
        //                int Type;
        //                if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 3)
        //                {
        //                    Type = int.Parse(Messages.CustFlag.ToString());
        //                    tabControlProduct.SelectedIndex = 1;
        //                    tabControlProduct.SelectedIndex = 0;
        //                    frmCustSup.SaveData();
        //                }
        //                else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 4)
        //                {
        //                    Type = int.Parse(Messages.CustFlag.ToString());
        //                    tabControlProduct.SelectedIndex = 1;
        //                    tabControlProduct.SelectedIndex = 0;
        //                    frmCustSup.SaveData();
        //                }
        //                else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 5)
        //                {
        //                    tabControlProduct.SelectedIndex = 2;
        //                    tabControlProduct.SelectedIndex = 0;

        //                    frmEmp.salesAdminFalgCheckBox.Checked = false;
        //                    frmEmp.txtcom.Enabled = false;
        //                    frmEmp.lblEmpCode.Text = "ßæÏ ÇáãæÙÝ";
        //                    frmEmp.lblEmpName.Text = "ÃÓã ÇáãæÙÝ";
        //                    frmEmp.SaveData();
        //                }
        //                else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 6)
        //                {
        //                    tabControlProduct.SelectedIndex = 2;
        //                    tabControlProduct.SelectedIndex = 0;
                          
        //                    frmEmp.salesAdminFalgCheckBox.Checked = true;
        //                    frmEmp.txtcom.Enabled = true;
        //                    frmEmp.lblEmpCode.Text = "ßæÏ ÇáãäÏæÈ";
        //                    frmEmp.lblEmpName.Text = "ÃÓã ÇáãäÏæÈ";

        //                    frmEmp.SaveData();
        //                }
        //                if (!EditFlag)
        //                {
        //                    TreeNode Node = new TreeNode();
        //                    Node.Text = txtAccountCode.Text + " / " + txtAccountName.Text;
        //                    Node.Name = txtAccountId.Text;

        //                    if (int.Parse(CmbAccountType.SelectedValue.ToString()) > 2)
        //                    {
        //                        Node.ImageIndex = 3;
        //                        Node.SelectedImageIndex = 3;
        //                    }
        //                    else
        //                    {
        //                        if (MainAccChkBox.Checked)
        //                        {
        //                            Node.ImageIndex = 0;
        //                            Node.SelectedImageIndex = 0;
        //                        }
        //                        else
        //                        {
        //                            Node.ImageIndex = 1;
        //                            Node.SelectedImageIndex = 1;
        //                        }
        //                    }

        //                    Node.Tag = txtAccountId.Text;
        //                    Node.ToolTipText = txtAccountCode.Text + " / " + txtAccountName.Text;
        //                    if (SNode == null)
        //                    {
        //                        AccountTreeView.Nodes.Add(Node);
        //                    }
        //                    else
        //                    {
        //                        SNode.Nodes.Add(Node);
        //                    }

        //                    Node.ContextMenuStrip = ContextMenuAccount;
        //                    AccountTreeView.SelectedNode = Node;
        //                    AccountTreeView.Select();
        //                    EditFlag = true;
        //                    CmdAdd.Enabled = true;
        //                    CmdDel.Enabled = true;
        //                    CmdSave.Enabled = true;
                            

        //                }

        //                GLibrary.MsgSave();
        //                bFlag = true;
        //                ret = true;
        //            }
        //            else
        //            {
        //                ret = false;
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            GLibrary.ExceptionToMessage(ex);
        //        }
        //    }
        //    return ret;
        //}
        //private void CmdAdd_Click(object sender, EventArgs e)
        //{
        //    AddNew();
        //}
        //private void AddNew()
        //{
        //    if (AccountTreeView.SelectedNode == null)
        //    {
        //        MainAddNode = null;
        //    }

        //    else if (AccountTreeView.SelectedNode.Parent == null)
        //    {
        //        MainAddNode = null;
        //    }
        //    else
        //    {
        //        MainAddNode = AccountTreeView.SelectedNode.Parent;

        //    }
        //    CmdSave.Text = "ÍÝÙ";
        //    bFlag = false;
        //    AddNewAccount(MainAddNode, false);
        //    bFlag = true;
        //    CmdSave.Enabled = true;
        //}
        //private void CheckAccountType(TreeNode Node)
        //{
        //    Int64 AccountId= (Int64)Node.Tag ;
            
        //        if ( AccountId==Messages.custaccid)
        //        {
        //               CmbAccountType.SelectedValue =3;
        //        }
        //        else if(  AccountId==Messages.suppaccid)
        //        {
        //            CmbAccountType.SelectedValue =4;
        //        }
        //        else
        //        {
        //            CmbAccountType.SelectedValue = 1;
        //        }
                
                   
            
        //}
        //private void AddNewAccount(TreeNode Node, Boolean  MainFlag)
        //{
        //    CmbClosedTo.SelectedIndex = 0;
        //    accountingBindingSource.AddNew();
        //    txtdisplay_Flag.Text  = bool.FalseString;
        //    if (Node == null)
        //    {
        //        txtAccountparentId.Text = "1";
        //        txtAccountparentCode.Text ="0";
        //        txtLevel.Text = "0";
        //        txtMainParentId.Text  = "1";
        //        txtRootFlag.Text = bool.TrueString;
        //        txtProcessFlag.Text = bool.FalseString;
        //        MainAccChkBox.Checked = true;
        //        int intCount=AccountTreeView.Nodes.Count;
        //        txtAccountCode.Text = txtAccountCode.Text + (intCount + 1);
                
        //    }
        //    else if (Node.Level > -1)
        //    {
        //        txtAccountparentId.Text = Node.Tag.ToString();
        //        txtAccountparentName.Text = Node.Text;
        //        int index = Node.ToolTipText.IndexOf("/");
        //        txtAccountparentCode.Text = Node.ToolTipText.Substring(0, index);
        //        txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
        //        txtLevel.Text = (Node.Level+1).ToString();
        //        GetMainParent(Node);
        //        txtRootFlag.Text = bool.FalseString;
        //        txtProcessFlag.Text = bool.FalseString;
        //        if (CmbClosedTo.Items.Count > 0) CmbClosedTo.SelectedIndex = 0;
                
        //        Node.ImageIndex = 0;
        //        Node.SelectedImageIndex = 0;
        //        if (Node==null)
        //        {
        //            MainAccChkBox.Checked  = true ;
        //            MainAccChkBox.Enabled = false;
        //        }
        //        else
        //        {
        //            MainAccChkBox.Checked = MainFlag;
        //            MainAccChkBox.Enabled = true;
        //        }
        //        //update parent informations
        //        //int Pos = accountingBindingSource.Find("accountid", txtAccountparentId.Text);
        //        //if (Pos != -1)
        //        //{
        //        //    nEWERPDataSet.accounting.Rows[Pos].BeginEdit();
        //        //    nEWERPDataSet.accounting.Rows[Pos]["Root"] = true;
        //        //    nEWERPDataSet.accounting.Rows[Pos]["MainNode"] = true;
        //        //    nEWERPDataSet.accounting.Rows[Pos]["ProcessFlag"] = true;
        //        //    ((DataRowView)accountingBindingSource.Current).Row.BeginEdit();
        //        //    ((DataRowView)accountingBindingSource.Current)["MainNode"] = true;
        //        //    ((DataRowView)accountingBindingSource.Current).Row.EndEdit ();
                    
        //        //    nEWERPDataSet.accounting.Rows[Pos].EndEdit();
        //        //    if (Node.Level > 0)
        //        //    {
        //        //        CmbClosedTo.SelectedValue = nEWERPDataSet.accounting.Rows[Pos]["ClosedTo"];
        //        //        CmbClosedTo.Enabled = false;
        //        //    }

        //       // }

         
        //    }

        //    CheckAccountType(Node);
        //    //MainAccChkBox.Enabled = true;
        //    //MainAccChkBox.Checked = false;
        //    EditFlag = false;
        //    CmdAdd.Enabled = false;
        //    CmdDel.Enabled = false;
        //    txtAccountName.Focus();
        //    txtStartdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        //}
        //private void GetMainParent(TreeNode Node)
        //{
        //    int intCount = Node.Nodes.Count;
        //    int index = Node.ToolTipText.IndexOf("/");
        //    txtAccountCode.Text  = Node.ToolTipText.Substring(0, index);
        //    txtAccountCode.Text = txtAccountCode.Text.TrimEnd();
        //    txtAccountCode.Text = txtAccountCode.Text + (intCount+1); //"-"+ .ToString("000000");
        //    //String strMainParent="";
        //    //for (int i = 0; i > Node.Level; i--)
        //    //{
        //    //    if (i == 0)
        //    //    {
        //    //        strMainParent = Node.Tag.ToString ();
        //    //    }
        //    //    else
        //    //    {
        //    //        TreeNode TNode = Node.Parent;
        //    //        strMainParent = TNode.Tag.ToString();
        //    //    }
        //    //}
        //    //txtMainParentId.Text = strMainParent;
        //}
        private void ProductstreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            //if (Flag)
            //{
            //    try
            //    {
            //        //add mode 
            //        if (((DataRowView)accountingBindingSource.Current).Row.RowState == DataRowState.Detached)
            //        {
            //            if (GLibrary.MsgCheckSave(false))
            //            {
            //                if (SaveAllData(MainAddNode,false))
            //                {
            //                }
            //                else
            //                {
            //                    CmdAdd.Enabled = true;
            //                    CmdDel.Enabled = true;
            //                    EditFlag = true;
            //                    return;

            //                }
            //            }
            //            else
            //            {
            //                accountingBindingSource.CancelEdit();
            //                this.nEWERPDataSet.RejectChanges();
            //                CmdAdd.Enabled = true;
            //                CmdDel.Enabled = true;
            //                EditFlag = true;

            //            }
            //        }
            //        else //edit mode
            //        {
            //            ((DataRowView)accountingBindingSource.Current).EndEdit();
            //            if (this.nEWERPDataSet.HasChanges() == true)
            //            {
            //                Boolean LocFlag = false;
            //                if (FlagFoDel)
            //                {
            //                    LocFlag = true;
            //                }
            //                if (GLibrary.MsgCheckSave(LocFlag))
            //                {
            //                    if (SaveAllData(MainAddNode, LocFlag))
            //                    {
            //                    }
            //                    else
            //                    {
            //                        CmdAdd.Enabled = true;
            //                        CmdDel.Enabled = true;
            //                        EditFlag = true;
            //                        return;

            //                    }
            //                }
            //                else
            //                {
            //                    accountingBindingSource.CancelEdit();
            //                    this.nEWERPDataSet.RejectChanges();
            //                    CmdAdd.Enabled = true;
            //                    CmdDel.Enabled = true;
            //                    EditFlag = true;

            //                }
            //            }
            //        }
            //        //else  //edit mode
            //        //{

            //        //    //if (EditFlag)
            //        //    //{
            //        //    //    if (SaveAllData(MainAddNode))
            //        //    //    {

            //        //    //    }
            //        //    //    else
            //        //    //    {
            //        //    //        accountingBindingSource.CancelEdit();
            //        //    //        CmdAdd.Enabled = true;
            //        //    //        CmdDel.Enabled = true;
            //        //    //        EditFlag = true;
            //        //    //    }
            //        //    //}

            //        //}


            //        int Accountid = int.Parse(e.Node.Tag.ToString());
            //        int Pos = accountingBindingSource.Find("accountid", Accountid);
            //        bFlag = false;
            //        accountingBindingSource.Position = Pos;
            //        bFlag = true;
            //        ChangeNodeData();
            //        decimal fromvalue = 0;
            //        decimal tovalue = 0;
            //        if (GLibrary.IsNumeric(txtFromValue.Text))
            //        {
            //            fromvalue = decimal.Parse(txtFromValue.Text);
            //        }
            //        if (GLibrary.IsNumeric(txtToValue.Text))
            //        {
            //            tovalue = decimal.Parse(txtToValue.Text);
            //        }
            //        txtAccValue.Text = (fromvalue - tovalue).ToString();
            //        if (e.Node.Level > 0) //Get Parent info
            //        {
            //            txtAccountparentName.Text = e.Node.Parent.Text;
            //            int index = e.Node.Parent.ToolTipText.IndexOf("/");
            //            txtAccountparentCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
            //            txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
            //        }
            //        if (e.Node.Level > 0)
            //        {
            //            Boolean ProcessFlag = (Boolean)((DataRowView)accountingBindingSource.Current)["ProcessFlag"];

            //            if (ProcessFlag)
            //            {
            //                //MainAccChkBox.Checked = true;
            //                MainAccChkBox.Enabled = false;

            //            }
            //            else
            //            {
            //                Boolean MainNode = (Boolean)((DataRowView)accountingBindingSource.Current)["MainNode"];
            //                MainAccChkBox.Checked = MainNode;
            //                if (e.Node.Nodes !=null)
            //                {
            //                    if (e.Node .Nodes.Count >0)
            //                    {
            //                        MainAccChkBox.Enabled = false;
            //                    }
            //                    else
            //                    {
            //                        MainAccChkBox.Enabled = true;
            //                    }
            //                }
                            
                            
            //            }

            //            //txtRootFlag.Text = (Boolean)((DataRowView)accountingBindingSource.Current)["Root"];// bool.FalseString;
            //            CmbClosedTo.Enabled = false;
            //        }
            //        else
            //        {
            //            MainAccChkBox.Enabled = false;
            //            CmbClosedTo.Enabled = true;
            //            //((DataRowView)accountingBindingSource.Current)["ProcessFlag"] = true;
            //            //nEWERPDataSet.accounting[Pos]["ProcessFlag"] = true;
            //            //txtRootFlag.Text = bool.TrueString;

            //        }


            //        errorProvider1.Clear();
            //    }

            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(GLibrary.ExceptionToMessage(ex), "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //    }
            //}
        }

        private void TreeSearch()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch="";
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

     

       

        
        //private Boolean  ChangeState()
        //{
        //    if (accountingBindingSource.Count > 0)
        //    {
        //        Boolean PervRoot=false;
        //        if (((DataRowView)accountingBindingSource.Current)["MainNode"].ToString() != "")   
        //        {
        //            PervRoot = (Boolean)((DataRowView)accountingBindingSource.Current)["MainNode"];
        //        }
        //        //Boolean root = Boolean.Parse(txtRootFlag.Text);
               
        //        int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());
        //        int PervaccountType;
        //        if (((DataRowView)accountingBindingSource.Current).IsNew)
        //        {
        //            PervaccountType = 1;
        //            //PervRoot = MainAccChkBox.Checked;
        //        }
        //        else
        //        {
        //             PervaccountType = int.Parse(((DataRowView)accountingBindingSource.Current)["accountType"].ToString());
        //        }
        //        if (PervRoot && accountType >= 3)
        //        {
        //            bFlag = false;
        //            CmbAccountType.SelectedValue = PervaccountType;
                    
        //            //((DataRowView)accountingBindingSource.Current).CancelEdit();
        //            bFlag = true;
        //            MessageBox.Show(Messages.ChangeTypeMessage, "ÊÛíÑ äæÚ ÇáÍÓÇÈ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
                
        //    }
        //    return false;
        //}
        //private void RestoreTreeNode()
        //{

        //    if (accountingBindingSource.Count > 0)
        //    {
        //        if (EditFlag)
        //        {
        //            Boolean ProcessFlag = Boolean.Parse(txtProcessFlag.Text);// ((DataRowView)accountingBindingSource.Current)["ProcessFlag"];
        //            int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());// ((DataRowView)accountingBindingSource.Current)["accountType"];
        //            Boolean root = Boolean.Parse(txtRootFlag.Text); //((DataRowView)accountingBindingSource.Current)["root"];
        //            if (MainAccChkBox.Checked)
        //            {
        //                if (accountType == 2)
        //                {
        //                    AccountTreeView.SelectedNode.ImageIndex = 4;
        //                    AccountTreeView.SelectedNode.SelectedImageIndex = 4;
        //                }
        //                else
        //                {
        //                    AccountTreeView.SelectedNode.ImageIndex = 0;
        //                    AccountTreeView.SelectedNode.SelectedImageIndex = 0;
        //                }
        //            }
        //            else if (accountType > 2)
        //            {
        //                AccountTreeView.SelectedNode.ImageIndex = 3;
        //                AccountTreeView.SelectedNode.SelectedImageIndex = 3;
        //            }
        //            else if (ProcessFlag)
        //            {
        //                AccountTreeView.SelectedNode.ImageIndex = 2;
        //                AccountTreeView.SelectedNode.SelectedImageIndex = 2;
        //            }
        //            else
        //            {
        //                AccountTreeView.SelectedNode.ImageIndex = 1;
        //                AccountTreeView.SelectedNode.SelectedImageIndex = 1;
        //            }
        //        }
        //        else
        //        {
        //            //((DataRowView)accountingBindingSource.Current).BeginEdit();
        //            if (MainAccChkBox.Checked)
        //            {
        //                ((DataRowView)accountingBindingSource.Current)["MainNode"] = Boolean.TrueString;
        //            }
        //            else
        //            {
        //                ((DataRowView)accountingBindingSource.Current)["MainNode"] = Boolean.FalseString;
        //            }
        //           // ((DataRowView)accountingBindingSource.Current).EndEdit();
        //        }
        //    }
           
        //}
              

        private void TreeReFreshMenuItem_Click(object sender, EventArgs e)
        {
            LoadTreeData();
        }


       

        private void AccountTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //AccountTreeView.SelectedNode = e.Node;
            //AccountTreeView.Select();
            //if (!MainAccChkBox.Checked)
            //{
            //    AddSubAccMenuItem.Enabled = false;
            //    AddMainAccMenuItem.Enabled = false;

            //}
            //else
            //{
            //    AddSubAccMenuItem.Enabled = true;
            //    AddMainAccMenuItem.Enabled = true;
            //}
        }

        private void AccountTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            
            //if (!MainAccChkBox.Checked)
            //{
            //    AddSubAccMenuItem.Enabled = false;
            //    AddMainAccMenuItem.Enabled = false;

            //}
            //else
            //{
            //    AddSubAccMenuItem.Enabled = true;
            //    AddMainAccMenuItem.Enabled = true;
            //}
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            //if (GLibrary.MsgCheckDel())
            //{
            //    if (AccountTreeView.SelectedNode != null)
            //    {
            //        accountingBindingSource.RemoveCurrent();
            //        FlagFoDel = true;
            //        AccountTreeView.SelectedNode.Remove();
            //        FlagFoDel =false ;
            //        SaveAllData(MainAddNode,true );

            //    }
            //}
           


        }

       
        private void AccountTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node !=null) //AccountTreeView.SelectedNode != null)
            {
                AccountAdd frm = new AccountAdd();
                int index ;
                index = e.Node.Text.IndexOf ('/');
                if (index >-1)
                {
                    frm.Show(this);
                    frm.txtSearch.Text  = e.Node.Text.Substring (0,index).TrimEnd ();
                    
                    frm.TreeSearch();
                }
            }
        }

       
      
 

        
    }
}