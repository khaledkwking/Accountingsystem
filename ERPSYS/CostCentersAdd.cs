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
    public partial class CostCentersAdd : DockContent
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
        private string  LastSerialNo = "";
        public CostCentersAdd()
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
            Flag = false;
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            ERPSYS.NEWERPDataSet nEWERPDataSetClosedTo = new NEWERPDataSet();
            //BindingSource CostCentersClosedtoBindingSource = new BindingSource();
            //NEWERPDataSetTableAdapters.CostCentersTableAdapter CostCentersClosedToTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.CostCentersTableAdapter();
            //CostCentersClosedtoBindingSource.DataMember = "CostCenters";
            //CostCentersClosedtoBindingSource.DataSource = nEWERPDataSetClosedTo;
            //CmbClosedTo.DataSource = CostCentersClosedtoBindingSource;
             //CostCentersClosedtoBindingSource.Filter = "CostId > 0";

            //CostCentersClosedToTableAdapter.FillByClosedTo(nEWERPDataSetClosedTo.CostCenters);
            //if (nEWERPDataSetClosedTo.CostCenters.Rows.Count > 0)
            //{
            //    //CmbClosedTo.SelectedIndex = 0;
            //}
            
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
           
            selectedTab = this.tabControlProduct.SelectedTab;
            //CmbPriceRule.DataSource = slPriceRules.ToDataTable();
            LoadTreeData();
            costCentersBindingSource.Filter = "CostParentId <> -1";
            //if (tabControlProduct.TabPages.Contains(EmptabPage)) tabControlProduct.TabPages.Remove(EmptabPage);
            //if (tabControlProduct.TabPages.Contains(CustTabPage)) tabControlProduct.TabPages.Remove(CustTabPage);
            Flag = true;
            errorProvider1.Clear();
            if (costCentersBindingSource.Count == 0)
            {
                CmdDel.Enabled = false;
                CmdSave.Enabled = false;
                txtStartdate.Text = DateTime.Today.ToShortDateString();
                AddNew();
                //costCentersBindingSource.RemoveFilter();

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
            SaveAllData(MainAddNode,false);  
        }
        private Boolean CheckCode(string AcctCode)
        {
            int Count = 0;
            Count = int.Parse(costCentersTableAdapter.FillByCheckCode(AcctCode).ToString());
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
        private Boolean  SaveAllData(TreeNode SNode, Boolean DelFlag  )
        {
            
            Boolean ret = false;
            if (GLibrary.MsgCheckSave(DelFlag))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, txtAccountName, "√œŒ· √”„ «·Õ”«» „‰ ›÷·ﬂ", "Õ›Ÿ", true) && GLibrary.ValidatetxtBox(errorProvider1, txtAccountCode, "√œŒ· ﬂÊœ «·Õ”«» „‰ ›÷·ﬂ", "Õ›Ÿ", true) && GLibrary.IsNumeric (txtAccountCode.Text ))
                    {
                        if (!CheckCode(txtAccountCode.Text))
                        {
                            MessageBox.Show(Messages.codeErrorMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                
                            return false;
                        }

                        int pos = costCentersBindingSource.Find("costid", txtAccountparentId.Text);
                        if (!EditFlag)
                        {
                           
                            if (pos > -1)
                            {
                                 long oldLastSerialNo;
                                if (nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"] != DBNull.Value)
                                {
                                     oldLastSerialNo = long.Parse(nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"].ToString());
                                }
                                else
                                {
                                    oldLastSerialNo = long.Parse (LastSerialNo);
                                }
                                if (long.Parse(txtAccountCode.Text) >= oldLastSerialNo)
                                {
                                    nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"] = txtAccountCode.Text;
                                }
                            }
                            txtLastSerial.Text = txtAccountCode.Text + "0";
                        }
                        else
                        {
                            if (pos > -1)
                            {
                                long oldLastSerialNo;
                                if (nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"] != DBNull.Value)
                                {
                                     oldLastSerialNo = long.Parse(nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"].ToString());
                                }
                                else
                                {
                                    oldLastSerialNo = long.Parse (txtAccountCode.Text);
                                }
                                if (long.Parse(txtAccountCode.Text) >= oldLastSerialNo)
                                {
                                    nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"] = txtAccountCode.Text;
                                }
                            }
                        }
                      
                       

                        bFlag = false;
                        RestoreTreeNode();
                     
                        costCentersBindingSource.EndEdit();
                        int I = costCentersTableAdapter.Update(nEWERPDataSet.CostCenters);
                       
                        LastSerialNo = "";
                        //int Type;
                       
                        if (!EditFlag)
                        {
                            TreeNode Node = new TreeNode();
                            Node.Text = txtAccountCode.Text + " / " + txtAccountName.Text;
                            Node.Name = txtAccountId.Text;
    
                            
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

                            Node.Tag = txtAccountId.Text;
                            Node.Text = txtAccountCode.Text + " / " + txtAccountName.Text;
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
                            if (SNode !=null)
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
                            CmdSave.Text = " ⁄œÌ·";

                        }
                        else
                        {
                            if (AccountTreeView.SelectedNode != null)
                            {
                                string str = ((DataRowView)costCentersBindingSource.Current)["costCode"].ToString() + " / " + ((DataRowView)costCentersBindingSource.Current)["costName"].ToString().ToString();
                                AccountTreeView.SelectedNode.Tag = ((DataRowView)costCentersBindingSource.Current)["costid"].ToString();
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
            CmdSave.Text = "Õ›Ÿ";
            bFlag = false;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
            CmdSave.Enabled = true;
        }
    
        private void AddNewAccount(TreeNode Node, Boolean  MainFlag)
        {
           
            costCentersBindingSource.AddNew();
            txtdisplay_Flag.Text  = bool.FalseString;
            txtLastSerial.Text = "0";
            CmdSave.Text = "Õ›Ÿ";
            if (Node == null)
            {
                ((DataRowView)costCentersBindingSource.Current)["costparentId"] = 1;
                ((DataRowView)costCentersBindingSource.Current)["costCode"] = 0;
                ((DataRowView)costCentersBindingSource.Current)["AccLevel"] = 0;
                ((DataRowView)costCentersBindingSource.Current)["MainParentAccId"] = 1;
                ((DataRowView)costCentersBindingSource.Current)["root"] = true;
                ((DataRowView)costCentersBindingSource.Current)["ProcessFlag"] = false;
                ((DataRowView)costCentersBindingSource.Current)["MainNode"] = true;
              
                txtAccountparentId.Text = "1";
                txtAccountparentCode.Text ="0";
                txtLevel.Text = "0";
                txtMainParentId.Text  = "1";
                txtRootFlag.Text = bool.TrueString;
                txtProcessFlag.Text = bool.FalseString;
                MainAccChkBox.Checked = true;
                int intCount=AccountTreeView.Nodes.Count;
                txtAccountCode.Text = txtAccountCode.Text + (intCount + 1).ToString();
                ((DataRowView)costCentersBindingSource.Current)["costCode"] = intCount + 1;
              
            }
            else if (Node.Level > -1)
            {
                txtAccountparentId.Text = Node.Tag.ToString();
                txtAccountparentName.Text = Node.Text;
                int index = Node.ToolTipText.IndexOf("/");
                txtAccountparentCode.Text = Node.ToolTipText.Substring(0, index);
                txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                txtLevel.Text = (Node.Level+1).ToString();
                GetMainParent(Node);
                txtRootFlag.Text = bool.FalseString;
                txtProcessFlag.Text = bool.FalseString;
                               
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
                //update parent informations
                //int Pos = costCentersBindingSource.Find("costid", txtAccountparentId.Text);
                //if (Pos != -1)
                //{
                //    nEWERPDataSet.CostCenters.Rows[Pos].BeginEdit();
                //    nEWERPDataSet.CostCenters.Rows[Pos]["Root"] = true;
                //    nEWERPDataSet.CostCenters.Rows[Pos]["MainNode"] = true;
                //    nEWERPDataSet.CostCenters.Rows[Pos]["ProcessFlag"] = true;
                //    ((DataRowView)costCentersBindingSource.Current).Row.BeginEdit();
                //    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = true;
                //    ((DataRowView)costCentersBindingSource.Current).Row.EndEdit ();
                    
                //    nEWERPDataSet.CostCenters.Rows[Pos].EndEdit();
                //    if (Node.Level > 0)
                //    {
                //        CmbClosedTo.SelectedValue = nEWERPDataSet.CostCenters.Rows[Pos]["ClosedTo"];
                //        CmbClosedTo.Enabled = false;
                //    }

               // }

         
            }
          
            //MainAccChkBox.Enabled = true;
            //MainAccChkBox.Checked = false;
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            txtAccountName.Focus();
            txtStartdate.Text = DateTime.Today.ToShortDateString();
        }
        private void GetMainParent(TreeNode Node)
        {
            int intCount = Node.Nodes.Count;
            int index = Node.ToolTipText.IndexOf("/");
            txtAccountCode.Text  = Node.ToolTipText.Substring(0, index);
            txtAccountCode.Text = txtAccountCode.Text.TrimEnd();
            string accountid =Node.Tag.ToString () ;
            int pos =costCentersBindingSource.Find("costid", accountid);
            long Serial = 0;
            if (pos >-1)
            {
                string str="";
                 LastSerialNo= nEWERPDataSet.CostCenters.Rows [pos]["LastSerialNo"].ToString ();
                 if (LastSerialNo == "")
                 {
                     str = txtAccountCode.Text + Node.Nodes.Count .ToString();
                     
                 }
                 else
                 {
                      str = LastSerialNo.Remove(0, txtAccountCode.Text.Length);
                     if (str == "")
                     {
                         str = "0";
                     }
                 }
                 Serial=long.Parse (str);
                 //Serial = long.Parse(nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"].ToString());

            }
            
             Serial = Serial + 1;
            
            int NewSeraillen = Serial.ToString().Length;
            if (NewSeraillen == LastSerialNo.Length ) // old =new length
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
                    LastSerialNo = Serial.ToString ();
                }
            }
            //LastSerialNo = LastSerialNo + 1;
            txtAccountCode.Text =  LastSerialNo; //(intCount + 1); //"-"+ .ToString("000000");
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

                    CmdSave.Text = " ⁄œÌ·";
                    if (((DataRowView)costCentersBindingSource.Current).Row.RowState == DataRowState.Detached)
                    {
                        if (GLibrary.MsgCheckSave(false))
                        {
                            if (SaveAllData(MainAddNode,false))
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
                       // string AccId = e.Node.Tag.ToString ();
                       // int pos = costCentersBindingSource.Find("costid", AccId);
                       //if (pos > -1)
                       //{
                       //    costCentersBindingSource.Position = pos;
                       //}
                        ((DataRowView)costCentersBindingSource.Current).EndEdit();
                        if (this.nEWERPDataSet.HasChanges() == true)
                        //if (((DataRowView)costCentersBindingSource.Current).RowVersion == DataRowVersion.Proposed)
                        {
                            Boolean LocFlag = false  ;
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
                    int Pos = costCentersBindingSource.Find("costid", Accountid);
                    bFlag = false;
                    costCentersBindingSource.Position = Pos;
                    bFlag = true;
                    
                    
                    if (e.Node.Level > 0) //Get Parent info
                    {
                        txtAccountparentName.Text = e.Node.Parent.Text;
                        int index = e.Node.Parent.ToolTipText.IndexOf("/");
                        txtAccountparentCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
                        txtAccountparentCode.Text = txtAccountparentCode.Text.TrimEnd();
                    }
                    if (e.Node.Level > 0)
                    {
                        Boolean ProcessFlag = (Boolean)((DataRowView)costCentersBindingSource.Current)["ProcessFlag"];

                        if (ProcessFlag)
                        {
                            //MainAccChkBox.Checked = true;
                            MainAccChkBox.Enabled = false;

                        }
                        else
                        {
                            Boolean MainNode = (Boolean)((DataRowView)costCentersBindingSource.Current)["MainNode"];
                            MainAccChkBox.Checked = MainNode;
                            if (e.Node.Nodes !=null)
                            {
                                if (e.Node .Nodes.Count >0)
                                {
                                    MainAccChkBox.Enabled = false;
                                }
                                else
                                {
                                    MainAccChkBox.Enabled = true;
                                }
                            }
                            
                            
                        }

                        //txtRootFlag.Text = (Boolean)((DataRowView)costCentersBindingSource.Current)["Root"];// bool.FalseString;
                       
                    }
                    else
                    {
                        MainAccChkBox.Enabled = false;
                       
                        //((DataRowView)costCentersBindingSource.Current)["ProcessFlag"] = true;
                        //nEWERPDataSet.CostCenters[Pos]["ProcessFlag"] = true;
                        //txtRootFlag.Text = bool.TrueString;

                    }


                    errorProvider1.Clear();
                }

                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
            int Pos = costCentersBindingSource.Find("costName", txtSearch.Text);
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
                MessageBox.Show(Messages.AccSearchMessage, "«·»ÕÀ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                Int64 ProductId = (Int64)((DataRowView)costCentersBindingSource.Current)["costid"];
              
            }
        }

     
       
       
      
        private void RestoreTreeNode()
        {

            if (costCentersBindingSource.Count > 0)
            {
                if (EditFlag)
                {
                    Boolean ProcessFlag = Boolean.Parse(txtProcessFlag.Text);// ((DataRowView)costCentersBindingSource.Current)["ProcessFlag"];
                  
                    Boolean root = Boolean.Parse(txtRootFlag.Text); //((DataRowView)costCentersBindingSource.Current)["root"];
                    if (MainAccChkBox.Checked)
                    {

                        AccountTreeView.SelectedNode.ImageIndex = 0;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 0;
                    }
                    else
                    {
                        AccountTreeView.SelectedNode.ImageIndex = 1;
                        AccountTreeView.SelectedNode.SelectedImageIndex = 1;
                    }
                }
               
                    //((DataRowView)costCentersBindingSource.Current).BeginEdit();
                if (MainAccChkBox.Checked)
                {
                    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = Boolean.TrueString;
                }
                else
                {
                    ((DataRowView)costCentersBindingSource.Current)["MainNode"] = Boolean.FalseString;
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
                try
                {
                    if (AccountTreeView.SelectedNode != null)
                    {
                        if (AccountTreeView.SelectedNode.Nodes.Count > 0)
                        {
                            MessageBox.Show(Messages.AccountErrorMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                        else if (((DataRowView)costCentersBindingSource.Current)["ProcessFlag"].ToString() == Boolean.TrueString)
                        {
                            MessageBox.Show(Messages.AccountProcessErrorMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }

                        else
                        {
                            string PNode = "1";
                            Boolean ChangeFlag = false;
                            if (AccountTreeView.SelectedNode.Parent != null)
                            {
                                PNode = AccountTreeView.SelectedNode.Parent.Tag.ToString();
                            }
                            costCentersBindingSource.RemoveCurrent();
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
                                int pos = costCentersBindingSource.Find("costid", PNode);
                                if (pos > -1)
                                {
                                    string AccountCode = "1";
                                    if (AccountTreeView.SelectedNode.LastNode != null)
                                    {
                                        int index = AccountTreeView.SelectedNode.LastNode.ToolTipText.IndexOf("/");
                                        AccountCode = AccountTreeView.SelectedNode.LastNode.ToolTipText.Substring(0, index);
                                        AccountCode = AccountCode.TrimEnd();
                                    }

                                    nEWERPDataSet.CostCenters.Rows[pos]["LastSerialNo"] = AccountCode;

                                }


                            }
                        }

                        costCentersTableAdapter.Update(nEWERPDataSet.CostCenters);
                        MessageBox.Show(Messages.AccountdelRightMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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

                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "„—ﬂ“ «· ﬂ·›…", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }

        }

      
        private void TreeOpenAllMItem_Click(object sender, EventArgs e)
        {
            AccountTreeView.ExpandAll();
        }

       
      
 

        
    }
}