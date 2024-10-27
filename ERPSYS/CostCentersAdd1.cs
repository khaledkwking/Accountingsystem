using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ERPSYS
{
    public partial class CostCentersAdd1 : Form
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

        public CostCentersAdd1()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            //this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            Flag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            ERPSYS.NEWERPDataSet nEWERPDataSetClosedTo = new NEWERPDataSet();
            BindingSource CostCentersClosedtoBindingSource = new BindingSource();
            NEWERPDataSetTableAdapters.CostCentersTableAdapter  CostCentersClosedToTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter ();
            CostCentersClosedtoBindingSource.DataMember = "CostCenters";
            CostCentersClosedtoBindingSource.DataSource = nEWERPDataSetClosedTo;
           //CmbClosedTo.DataSource = CostCentersClosedtoBindingSource;
           
            CostCentersClosedToTableAdapter.FillByClosedTo(nEWERPDataSetClosedTo.CostCenters);
            if (nEWERPDataSetClosedTo.CostCenters.Rows.Count > 0)
            {
                //CmbClosedTo.SelectedIndex = 0;
            }
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            selectedTab = this.tabControlProduct.SelectedTab;

            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Assemply' table. You can move, or remove it, as needed.


           // CmbAccountType.DataSource = slAccountTypes.ToDataTable();
            //CmbPriceRule.DataSource = slPriceRules.ToDataTable();

            LoadTreeData();

            //if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
            //if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
            Flag = true;
            errorProvider1.Clear();
            if (nEWERPDataSet.CostCenters.Count == 0)
            {
                CmdDel.Enabled = false;
                CmdSave.Enabled = false;
                //AddNew();

            }
          
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
            costCentersBindingSource.Filter = "CostparentId = 1" + " and root=1 ";
            
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)costCentersBindingSource.List;
            DataTable T = list.ToTable();
            costCentersBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["root"];
                TreeNode RootNode = new TreeNode();
                RootNode.Text = T.Rows[i]["CostCode"].ToString() + " / " + (string)T.Rows[i]["CostName"];
                RootNode.Name = T.Rows[i]["Costid"].ToString();
                RootNode.Tag = (Int64)T.Rows[i]["Costid"];
                RootNode.ContextMenuStrip = ContextMenuAccount;
                RootNode.ToolTipText = T.Rows[i]["CostCode"].ToString() + " / " + (string)T.Rows[i]["costName"];
                AccountTreeView.Nodes.Add(RootNode);

                if (bRoot)
                {
                    AddItem(RootNode);
                }

            }

        }
        private void AddItem(TreeNode ParentNode)
        {


            costCentersBindingSource.Filter = "CostparentId = " + ParentNode.Tag.ToString();
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)costCentersBindingSource.List;

            DataTable T = new DataTable();
            T = list.ToTable();
            costCentersBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["Root"];

                TreeNode Node = new TreeNode();
                Node.Text = T.Rows[i]["CostCode"].ToString() + " / " + (string)T.Rows[i]["CostName"];
                Node.Name = T.Rows[i]["Costid"].ToString();
                Node.Tag = (Int64)T.Rows[i]["Costid"];
                Node.ContextMenuStrip = ContextMenuAccount;
                Node.ToolTipText = T.Rows[i]["CostCode"].ToString() + " / " + (string)T.Rows[i]["costName"];
               
                ParentNode.Nodes.Add(Node);
                Boolean ProcessFlag = (Boolean)T.Rows[i]["ProcessFlag"];
                //int accountType = (int)T.Rows[i]["costType"];
                Boolean MainNode = (Boolean)T.Rows[i]["MainNode"];

                if (MainNode) //has childern
                {
                    //if (accountType == 2)
                    //{
                    //    Node.ImageIndex = 4;
                    //    Node.SelectedImageIndex = 4;
                    //}
                    //else
                    
                        Node.ImageIndex = 0;
                        Node.SelectedImageIndex = 0;
                    
                    AddItem(Node);   
                }
                else
                {                   
                    //if (accountType > 2)
                    //{
                    //    Node.ImageIndex = 3;
                    //    Node.SelectedImageIndex = 3;
                    //}
                    //else if (ProcessFlag)
                    //{
                    //    Node.ImageIndex = 2;
                    //    Node.SelectedImageIndex = 2;
                    //}
                    //else 
                    //{
                        Node.ImageIndex = 1;
                        Node.SelectedImageIndex = 1;
                    //}
                    

                }
            }
            
        }
      
        private void CmdSave_Click(object sender, EventArgs e)
        {
           
            SaveAllData(MainAddNode);
            
        }
        private Boolean  SaveAllData(TreeNode SNode)
        {
            
            Boolean ret = false;
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, txtCostName, "ÃÏÎá ÃÓã ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true) && GLibrary.ValidatetxtBox(errorProvider1, txtCostCode, "ÃÏÎá ßæÏ ÇáÍÓÇÈ ãä ÝÖáß", "ÍÝÙ", true))
                    {
                        bFlag = false;
                        RestoreTreeNode();
                        costCentersBindingSource.EndEdit();
                        int I = costCentersTableAdapter.Update(nEWERPDataSet.CostCenters);



                        //if (SaveFlag) // customer or Supplier
                        //{
                        //int Type;
                        //if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 3)
                        //{
                        //    Type = int.Parse(Messages.CustFlag.ToString());
                        //    tabControlProduct.SelectedIndex = 1;
                        //    tabControlProduct.SelectedIndex = 0;
                        //    frmCustSup.SaveData();
                        //}
                        //else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 4)
                        //{
                        //    Type = int.Parse(Messages.CustFlag.ToString());
                        //    tabControlProduct.SelectedIndex = 1;
                        //    tabControlProduct.SelectedIndex = 0;
                        //    frmCustSup.SaveData();
                        //}
                        //else if (int.Parse(CmbAccountType.SelectedValue.ToString()) == 5)
                        //{
                        //    tabControlProduct.SelectedIndex = 2;
                        //    tabControlProduct.SelectedIndex = 0;
                        //    frmEmp.SaveData();
                        //}
                        // }

                        if (!EditFlag)
                        {
                           TreeNode Node = new TreeNode();
                            Node.Text = txtCostCode.Text + " / " + txtCostName.Text;
                            Node.Name = txtCostId.Text;

                        //    if (int.Parse(CmbAccountType.SelectedValue.ToString()) > 2)
                        //    {
                        //        Node.ImageIndex = 3;
                        //        Node.SelectedImageIndex = 3;
                        //    }
                        //    else
                        //    {
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
                        //    }

                            Node.Tag = txtCostId.Text;
                            Node.ToolTipText = txtCostCode.Text + " / " + txtCostName.Text;
                            if (SNode == null)
                            {
                                AccountTreeView.Nodes.Add(Node);
                            }
                            else
                            {
                                SNode.Nodes.Add(Node);
                            }

                            Node.ContextMenuStrip = ContextMenuAccount;
                            AccountTreeView.SelectedNode = Node;
                            AccountTreeView.Select();
                            EditFlag = true;
                            CmdAdd.Enabled = true;
                            CmdDel.Enabled = true;
                            CmdSave.Enabled = true ;

                        }

                        GLibrary.MsgSave();
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
            CmdSave.Text = "ÍÝÙ";
            bFlag = false;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
        }
        private void CheckAccountType(TreeNode Node)
        {
            //if (Node != null)
            //{
            //    Int64 AccountId = (Int64)Node.Tag;

            //    if (AccountId == Messages.custaccid)
            //    {
            //        CmbAccountType.SelectedValue = 3;
            //    }
            //    else if (AccountId == Messages.suppaccid)
            //    {
            //        CmbAccountType.SelectedValue = 4;
            //    }
            //    else
            //    {
            //        CmbAccountType.SelectedValue = 1;
            //    }

            //}  
            
        }
        private void AddNewAccount(TreeNode Node, Boolean  MainFlag)
        {
            //CmbClosedTo.SelectedIndex = 0;
            costCentersBindingSource.AddNew();
            txtdisplay_Flag.Text  = bool.FalseString;
            if (Node == null)
            {
                txtCostparentId.Text = "1";
                txtAccountparentCode.Text ="0";
              
                txtRootFlag.Text = bool.TrueString;
                txtProcessFlag.Text = bool.FalseString;
                MainAccChkBox.Checked = true;
                int intCount=AccountTreeView.Nodes.Count;
                txtCostCode.Text = txtCostCode.Text + (intCount + 1);
                
            }
            else if (Node.Level > -1)
            {
                txtCostparentId.Text = Node.Tag.ToString();
                txtAccountparentName.Text = Node.Text;
                int index = Node.ToolTipText.IndexOf("/");
                txtAccountparentCode.Text = Node.ToolTipText.Substring(0, index);
                txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                GetMainParent(Node);
                txtRootFlag.Text = bool.FalseString;
                txtProcessFlag.Text = bool.FalseString;
                //if (CmbClosedTo.Items.Count > 0) CmbClosedTo.SelectedIndex = 0;
                
                Node.ImageIndex = 0;
                Node.SelectedImageIndex = 0;
                if (Node==null)
                {
                    MainAccChkBox.Checked  = true ;
                    MainAccChkBox.Enabled = false;
                }
                else
                {
                    MainAccChkBox.Checked = MainFlag;
                    MainAccChkBox.Enabled = true;
                }
                CmdSave.Enabled = true;
                CmdSave.Text = "ÍÝÙ";
                //update parent informations
                //int Pos = costCentersBindingSource.Find("accountid", txtAccountparentId.Text);
                //if (Pos != -1)
                //{
                //    nEWERPDataSet.CostCenters.Rows[Pos].BeginEdit();
                //    nEWERPDataSet.CostCenters.Rows[Pos]["Root"] = true;
                //    nEWERPDataSet.accounting.Rows[Pos]["MainNode"] = true;
                //    nEWERPDataSet.accounting.Rows[Pos]["ProcessFlag"] = true;
                //    ((DataRowView)costCentersBindingSource.Current).Row.BeginEdit();
                //    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = true;
                //    ((DataRowView)costCentersBindingSource.Current).Row.EndEdit ();
                    
                //    nEWERPDataSet.accounting.Rows[Pos].EndEdit();
                //    if (Node.Level > 0)
                //    {
                //        CmbClosedTo.SelectedValue = nEWERPDataSet.accounting.Rows[Pos]["ClosedTo"];
                //        CmbClosedTo.Enabled = false;
                //    }

               // }

         
            }

            CheckAccountType(Node);
            //MainAccChkBox.Enabled = true;
            //MainAccChkBox.Checked = false;
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            CmdSave.Enabled = true;
            txtCostName.Focus();
            txtStartdate.Text = DateTime.Today.ToShortDateString();
        }
        private void GetMainParent(TreeNode Node)
        {
            int intCount = Node.Nodes.Count;
            int index = Node.ToolTipText.IndexOf("/");
            txtCostCode.Text  = Node.ToolTipText.Substring(0, index);
            txtCostCode.Text = txtCostCode.Text.TrimEnd();
            txtCostCode.Text = txtCostCode.Text + (intCount+1); //"-"+ .ToString("000000");

        }
        private void ProductstreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (Flag)
            {
                try
                {
                    //add mode 
                    if (((DataRowView)costCentersBindingSource.Current).Row.RowState == DataRowState.Detached)
                    {
                        if (GLibrary.MsgCheckSave(false))
                        {
                            if (SaveAllData(MainAddNode))
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
                            costCentersBindingSource.CancelEdit();
                            this.nEWERPDataSet.RejectChanges();
                            CmdAdd.Enabled = true;
                            CmdDel.Enabled = true;
                            EditFlag = true;

                        }
                    }
                    else //edit mode
                    {
                        ((DataRowView)costCentersBindingSource.Current).EndEdit();
                        if (this.nEWERPDataSet.HasChanges() == true)
                        {
                            if (GLibrary.MsgCheckSave(false))
                            {
                                if (SaveAllData(MainAddNode))
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
                                costCentersBindingSource.CancelEdit();
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
                    //    //        costCentersBindingSource.CancelEdit();
                    //    //        CmdAdd.Enabled = true;
                    //    //        CmdDel.Enabled = true;
                    //    //        EditFlag = true;
                    //    //    }
                    //    //}

                    //}


                    int Accountid = int.Parse(e.Node.Tag.ToString());
                    int Pos = costCentersBindingSource.Find("Costid", Accountid);
                    bFlag = false;
                    costCentersBindingSource.Position = Pos;
                    bFlag = true;
                    ChangeNodeData();
                    
                    //if (GLibrary.IsNumeric(txtFromValue.Text))
                    //{
                    //    fromvalue = decimal.Parse(txtFromValue.Text);
                    //}
                    //if (GLibrary.IsNumeric(txtToValue.Text))
                    //{
                    //    tovalue = decimal.Parse(txtToValue.Text);
                    //}
                    //txtAccValue.Text = (fromvalue - tovalue).ToString();
                    if (e.Node.Level > 0) //Get Parent info
                    {
                        txtAccountparentName.Text = e.Node.Parent.Text;
                        int index = e.Node.Parent.ToolTipText.IndexOf("/");
                        txtAccountparentCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
                        txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                    }
                    if (e.Node.Level > 0)
                    {
                        
                            Boolean MainNode = (Boolean)((DataRowView)costCentersBindingSource.Current)["MainNode"];
                            MainAccChkBox.Checked = MainNode;
                            MainAccChkBox.Enabled = true;
                       

                        //txtRootFlag.Text = (Boolean)((DataRowView)costCentersBindingSource.Current)["Root"];// bool.FalseString;
                        //CmbClosedTo.Enabled = false;
                    }
                    else
                    {
                        MainAccChkBox.Enabled = false;
                        //CmbClosedTo.Enabled = true;
                        //((DataRowView)costCentersBindingSource.Current)["ProcessFlag"] = true;
                        //nEWERPDataSet.accounting[Pos]["ProcessFlag"] = true;
                        //txtRootFlag.Text = bool.TrueString;

                    }


                    errorProvider1.Clear();
                }

                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáÝæÇÊíÑ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void TreeSearch()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch="";
            int Pos = costCentersBindingSource.Find("Costname", txtSearch.Text);
            if (Pos == -1)
            {
                Pos = costCentersBindingSource.Find("costCode", txtSearch.Text);
                
            }
            if (Pos != -1)
            {
                strSearch = nEWERPDataSet.CostCenters.Rows[Pos]["costid"].ToString();
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
            if (costCentersBindingSource.Count > 0)
            {
                Int64 ProductId = (Int64)((DataRowView)costCentersBindingSource.Current)["Costid"];
              
            }
        }

     

        

        private void ChangeNodeData()
        {
            if (bFlag)
            {
                //if (CmbAccountType.SelectedValue != null && bFlag)
                //{
                    if (txtCostName.Text == "")
                    {
                        //CmbAccountType.SelectedValue = "1";
                        errorProvider1.SetError(txtCostName, "ÃÏÎá ÃÓã ÇáÍÓÇÈ ÇæáÇ");

                    }
                    else
                    {
                        RestoreTreeNode();
                        //switch (int.Parse(CmbAccountType.SelectedValue.ToString()))
                        //{
                        //    case 1:
                        //        if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                        //        if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                        //        RestoreTreeNode();
                        //        break;
                        //    case 2:
                        //        if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                        //        if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                        //        RestoreTreeNode();

                        //        break;
                        //    case 3:
                        //        if (ChangeState())
                        //        {
                        //            if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                        //            if (!tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Add(CustTabPage);
                        //            tabControlProduct.TabPages["CustTabPage"].Text = "ÈØÇÞÉ Úãíá";
                        //            RestoreTreeNode();
                                    
                        //            //tabControlProduct.TabPages[1].Select();
                        //        }
                        //        break;
                        //    case 4:
                        //        if (ChangeState())
                        //        {
                        //            if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
                        //            if (!tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Add(CustTabPage);
                        //            tabControlProduct.TabPages["CustTabPage"].Text = "ÈØÇÞÉ ãæÑÏ";
                        //            RestoreTreeNode();
                        //            //showNewTab(int.Parse(Messages.SupFlag));
                        //        }

                        //        break;
                        //    case 5:
                        //        if (ChangeState())
                        //        {
                        //            if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
                        //            if (!tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Add(EmptabPage);
                        //            tabControlProduct.TabPages["EmptabPage"].Text = "ÈØÇÞÉ ãæÙÝ";
                        //        }
                        //        break;
                        //}
                       
                    }
                //}
            }
        }
        private Boolean  ChangeState()
        {
            if (costCentersBindingSource.Count > 0)
            {
                Boolean PervRoot=false;
                if (((DataRowView)costCentersBindingSource.Current)["MainNode"].ToString() != "")   
                {
                    PervRoot = (Boolean)((DataRowView)costCentersBindingSource.Current)["MainNode"];
                }
                //Boolean root = Boolean.Parse(txtRootFlag.Text);
               
                //int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());
                int PervaccountType;
                if (((DataRowView)costCentersBindingSource.Current).IsNew)
                {
                    PervaccountType = 1;
                    //PervRoot = MainAccChkBox.Checked;
                }
                else
                {
                    PervaccountType = int.Parse(((DataRowView)costCentersBindingSource.Current)["CostType"].ToString());
                }
                if (PervRoot )
                {
                    bFlag = false;
                    //CmbAccountType.SelectedValue = PervaccountType;

                    //((DataRowView)costCentersBindingSource.Current).CancelEdit();
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

            if (costCentersBindingSource.Count > 0)
            {
                if (EditFlag)
                {
                    Boolean ProcessFlag = Boolean.Parse(txtProcessFlag.Text);// ((DataRowView)costCentersBindingSource.Current)["ProcessFlag"];
                    //int accountType = int.Parse(CmbAccountType.SelectedValue.ToString());// ((DataRowView)costCentersBindingSource.Current)["accountType"];
                    Boolean root = Boolean.Parse(txtRootFlag.Text); 
                    if (MainAccChkBox.Checked)
                    {
                        //if (accountType == 2)
                        //{
                        //    AccountTreeView.SelectedNode.ImageIndex = 4;
                        //    AccountTreeView.SelectedNode.SelectedImageIndex = 4;
                        //}
                        //else
                        //{
                            AccountTreeView.SelectedNode.ImageIndex = 0;
                            AccountTreeView.SelectedNode.SelectedImageIndex = 0;
                       // }
                    }
                    //else if (accountType > 2)
                    //{
                    //    AccountTreeView.SelectedNode.ImageIndex = 3;
                    //    AccountTreeView.SelectedNode.SelectedImageIndex = 3;
                    //}
                    //else if (ProcessFlag)
                    //{
                    //    AccountTreeView.SelectedNode.ImageIndex = 2;
                    //    AccountTreeView.SelectedNode.SelectedImageIndex = 2;
                    //}
                    else
                    {
                        AccountTreeView.SelectedNode.ImageIndex = 1;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 1;
                    }
                }
                else
                {
                    //((DataRowView)costCentersBindingSource.Current).BeginEdit();
                    //if (MainAccChkBox.Checked)
                    //{
                    //    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = Boolean.TrueString;
                    //}
                    //else
                    //{
                    //    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = Boolean.FalseString;
                    //}
                    // ((DataRowView)costCentersBindingSource.Current).EndEdit();
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
            frmCustSup.Show();
            //tabControlProduct.SelectedIndex = 1;
            //frmCustSup.FillData();
            SaveFlag = true;
            if (costCentersBindingSource.Count > 0)
            {
                Int64 accountid = (Int64)((DataRowView)costCentersBindingSource.Current)["costid"];
                string SUP_CUST_FNAME = (string)((DataRowView)costCentersBindingSource.Current)["costname"];
                string AccountCode = (string)((DataRowView)costCentersBindingSource.Current)["costCode"];
                if (!frmCustSup.CheckCust(int.Parse(accountid.ToString())))
                {

                    frmCustSup.AddNewCust();

                    frmCustSup.txtAccountId.Text = accountid.ToString();
                    frmCustSup.txtSUP_CUST_FNAME.Text = SUP_CUST_FNAME;
                    frmCustSup.txtAccCode.Text = AccountCode;

                }
            }
        }
        private void SaveEmp()
        {
            frmEmp.TopLevel = false;
            frmEmp.FormBorderStyle = FormBorderStyle.None;
            frmEmp.Parent = tabControlProduct.TabPages["EmpTabPage"];
            frmEmp.Show();
            //tabControlProduct.SelectedIndex = 1;
            //frmCustSup.FillData();
            EmpSaveFlag = true;
            if (costCentersBindingSource.Count > 0)
            {
                Int64 accountid = (Int64)((DataRowView)costCentersBindingSource.Current)["costid"];
                string Emp_FNAME = (string)((DataRowView)costCentersBindingSource.Current)["costname"];
                string AccountCode = (string)((DataRowView)costCentersBindingSource.Current)["costCode"];
                if (!frmEmp.CheckCust(int.Parse(accountid.ToString())))
                {

                    frmEmp.AddNewEmp();

                    frmEmp.txtEmpAccountId.Text = accountid.ToString();
                    frmEmp.txtEmpName.Text = Emp_FNAME;
                   
                    //frmEmp.txtAccCode.Text = AccountCode;

                }
            }
        }

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
            
            AddNewAccount(MainAddNode,true );
            bFlag = true;
        }

        private void AddSubAccMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = false;
            MainAddNode = AccountTreeView.SelectedNode;
            AddNewAccount(MainAddNode,false );
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
                    costCentersBindingSource.RemoveCurrent();
                    AccountTreeView.SelectedNode.Remove();
                    SaveAllData(MainAddNode);

                }
            }
           


        }

        private void AccountAdd_Activated(object sender, EventArgs e)
        {
          

        }

       
      
 

        
    }
}