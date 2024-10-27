using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WeifenLuo.WinFormsUI;

namespace ERPSYS
{
    public partial class ProductAdd : DockContent
    {
        private StaticList slOffersTypes = new StaticList(GLibrary.strarrOffersTypes);
        private StaticList slPriceRules = new StaticList(GLibrary.strarrPriceRules);
        
        private TabPage selectedTab; 
        public Boolean EditFlag;
        private DateTime lastDataError = DateTime.MinValue;
        private int SerialCode=0;
        private Boolean bFlag = false;
        private TreeNode MainAddNode = null;
        private string LastSerialNo = "";
        private Boolean Flag = false;
        private Boolean FlagFoDel = false;
        public long PassProductId=-1;
        public ProductAdd()
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
            errorProvider1.Clear();
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
            this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            Flag = false;
            selectedTab = this.tabControlProduct.SelectedTab;
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            this.cDE_PRODUCTTYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_PRODUCTTYPES);

            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.
            this.sTOCKTableAdapter.Fill(this.nEWERPDataSet.STOCK);
            

            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Assemply' table. You can move, or remove it, as needed.
            this.product_AssemplyTableAdapter.Fill(this.nEWERPDataSet.Product_Assemply);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ProductReplacment' table. You can move, or remove it, as needed.
            this.productReplacmentTableAdapter.Fill(this.nEWERPDataSet.ProductReplacment);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
          
             // TODO: This line of code loads data into the 'nEWERPDataSet.ProductOffers' table. You can move, or remove it, as needed.
            this.productOffersTableAdapter.Fill(this.nEWERPDataSet.ProductOffers);

            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
           

            CmbOfferType.DataSource = slOffersTypes.ToDataTable();
            CmbPriceRule.DataSource = slPriceRules.ToDataTable();
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);

            LoadTreeData();
            EditFlag = true;
            Flag = true;
            if (ProductstreeView.Nodes.Count > 0)
            {
                ProductstreeView.Nodes[0].Expand();
                ProductstreeView.SelectedNode = ProductstreeView.Nodes[0].FirstNode;
                ProductstreeView.Select();
            }
            CmbStroes.SelectedIndex = 0;
            CmbUnitTypes.SelectedIndex = 0;
            CmbOfferType.SelectedValue  = 1;
            CmbPriceRule.SelectedIndex = 0;
            CmbValidUnitType.SelectedIndex = 0;
            cmbValidStroes.SelectedIndex = 0;
            pRODUCTSBindingSource1.Filter = "root<>1";
            if (PassProductId > -1)
            {
                TreeSearchById();
            }

         
          
        }
        private void LoadTreeData()
        {
            string SelAcc = "";
            if (ProductstreeView.SelectedNode != null)
            {
                SelAcc = ProductstreeView.SelectedNode.Tag.ToString();
            }
            bFlag = false;
            if (ProductstreeView.Nodes.Count > 0)
            {
                ProductstreeView.Nodes.Clear();
            }
            AddMainNode();
            EditFlag = true;
            if (ProductstreeView.Nodes.Count > 0)
            {

                //AccountTreeView.Nodes[0].Expand();
                TreeNode[] SearchNodes = ProductstreeView.Nodes.Find(SelAcc, true);
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

                    ProductstreeView.SelectedNode = SearchNodes[0];
                    ProductstreeView.Select();
                }
                else
                {
                    ProductstreeView.Nodes[0].Expand();
                    ProductstreeView.SelectedNode = ProductstreeView.Nodes[0];
                    ProductstreeView.Select();
                }

            }

            bFlag = true;
        }
        private void AddMainNode()
        {
            //TreeNode RootNode = new TreeNode();
            //ProductstreeView.Nodes.Add(RootNode);
            pRODUCTSBindingSource.Filter = "ParentProductId = 0" + " and root=1 ";
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)pRODUCTSBindingSource.List;
            DataTable T = list.ToTable();
            pRODUCTSBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["root"];
                TreeNode Node = new TreeNode();
                Node.Text = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"] + "-" + T.Rows[i]["EnglishName"].ToString();
                Node.Name = T.Rows[i]["productID"].ToString();
                Node.Tag = (Int64)T.Rows[i]["PRODUCTID"];
                Node.ContextMenuStrip = ContextMenuAccount;
                Node.ImageIndex =0;
                
                Node.ToolTipText = T.Rows[i]["productCode"].ToString () + " / " + (string)T.Rows[i]["productname"];
                ProductstreeView.Nodes.Add(Node);
                if (bRoot)
                {
                    AddItem(Node);
                }

            }

        }
        //private void AddItem(TreeNode ParentNode)
        //{

                       
        //    pRODUCTSBindingSource.Filter = "ParentProductId = " + ParentNode.Tag.ToString();
        //    System.Data.DataView list = new System.Data.DataView();
        //    list = (DataView)pRODUCTSBindingSource.List;

        //    DataTable T = new DataTable();
        //    T = list.ToTable();
        //    pRODUCTSBindingSource.RemoveFilter();
        //    for (int i = 0; i < T.Rows.Count; i++)
        //    {
        //        Boolean bRoot = (Boolean)T.Rows[i]["Root"];
        //        TreeNode Node = new TreeNode();
        //        Node.Text = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
        //        Node.Name = T.Rows[i]["productID"].ToString(); 
        //        Node.Tag = (Int64)T.Rows[i]["PRODUCTID"];
                
        //        Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
        //        Node.ImageIndex = 1;
        //        ParentNode.Nodes.Add(Node);
        //        if (bRoot)
        //        {
        //            AddItem(Node);   
        //        }
        //        else
        //        {
                    
        //        }
        //        //pRODUCTSBindingSource.MoveNext();
        //    }

        //    //Boolean BLastNode= nEWERPDataSet.PRODUCTS .fi.Rows[index]["LastNode"];
        //}
        private void AddItem(TreeNode ParentNode)
        {


            pRODUCTSBindingSource.Filter = "ParentProductId = " + ParentNode.Tag.ToString();
            System.Data.DataView list = new System.Data.DataView();
            list = (DataView)pRODUCTSBindingSource.List;

            DataTable T = new DataTable();
            T = list.ToTable();
            pRODUCTSBindingSource.RemoveFilter();
            for (int i = 0; i < T.Rows.Count; i++)
            {
                Boolean bRoot = (Boolean)T.Rows[i]["Root"];
        
                TreeNode Node = new TreeNode();
                Node.Text = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"] + "-" + T.Rows[i]["EnglishName"].ToString();
                Node.Name = T.Rows[i]["PRODUCTID"].ToString();
                Node.Tag = (Int64)T.Rows[i]["PRODUCTID"];
                                
               
                Node.ContextMenuStrip = ContextMenuAccount;
                Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];

                ParentNode.Nodes.Add(Node);
                Boolean ProcessFlag=false ;
                Boolean MainNode = false;
                if (T.Rows[i]["ProcessFlag"] != DBNull.Value)
                {
                     ProcessFlag = Boolean.Parse(T.Rows[i]["ProcessFlag"].ToString());
                }
                if (T.Rows[i]["MainNode"] != DBNull.Value)
                {
                     MainNode = Boolean.Parse(T.Rows[i]["MainNode"].ToString());
                }

                if (MainNode) //has childern
                {
                   
                    Node.ImageIndex = 0;
                    Node.SelectedImageIndex = 0;
                    
                    AddItem(Node);
                }
                else
                {
                    if (ProcessFlag)
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
            //SaveAllData(
            SaveAll(MainAddNode, false); 
            
        }
        private Boolean  CheckUints()
        {
            int i;
            int count = 0;
            //if (ProductstreeView.SelectedNode.Level > 0)
            if(!MainAccChkBox.Checked)
            {
                for (i = 0; i < productUnitsPricesBindingSource.Count; i++)
                {
                    if (((DataRowView)productUnitsPricesBindingSource[i])["MainUnit"] != DBNull.Value)
                    {
                        Boolean BasicUnit = (Boolean)((DataRowView)productUnitsPricesBindingSource[i])["MainUnit"];
                        if (BasicUnit)
                        {
                            count = count + 1;
                        }
                    }
                }
                if (count > 1)
                {
                    MessageBox.Show(Messages.ErrorUnitsMesg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
                if (count == 0)
                {
                    MessageBox.Show(Messages.ErrorMainUnitMesg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    return false;
                }
            }
            return true;
        }
        private void RestoreTreeNode()
        {

            if (pRODUCTSBindingSource.Count > 0)
            {
                if (EditFlag)
                {
                    Boolean ProcessFlag = false;
                    if (txtProcessFlag.Text != "")
                    {
                         ProcessFlag = Boolean.Parse(txtProcessFlag.Text);
                    }// ((DataRowView)accountingBindingSource.Current)["ProcessFlag"];
                    Boolean root = Boolean.Parse(txtRootFlag.Text); //((DataRowView)accountingBindingSource.Current)["root"];
                    if (MainAccChkBox.Checked)
                    {

                        ProductstreeView.SelectedNode.ImageIndex = 0;
                        ProductstreeView.SelectedNode.SelectedImageIndex = 0;
                       
                    }
                   
                    else if (ProcessFlag)
                    {
                        ProductstreeView.SelectedNode.ImageIndex = 2;
                        ProductstreeView.SelectedNode.SelectedImageIndex = 2;
                    }
                    else
                    {
                        ProductstreeView.SelectedNode.ImageIndex = 1;
                        ProductstreeView.SelectedNode.SelectedImageIndex = 1;
                    }
                }
                else
                {
                    //((DataRowView)accountingBindingSource.Current).BeginEdit();
                    if (MainAccChkBox.Checked)
                    {
                        ((DataRowView)pRODUCTSBindingSource.Current)["MainNode"] = Boolean.TrueString;
                    }
                    else
                    {
                        ((DataRowView)pRODUCTSBindingSource.Current)["MainNode"] = Boolean.FalseString;
                    }
                    pRODUCTSBindingSource.EndEdit();
                }
            }

        }
        private Boolean SaveChild()
        {

              
           

            //this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.PRODUCTSRow master = (NEWERPDataSet.PRODUCTSRow)(((DataRowView)pRODUCTSBindingSource.Current).Row);
            // Get the child row

            NEWERPDataSet.Product_Units_PricesRow detail = (NEWERPDataSet.Product_Units_PricesRow)(((DataRowView)productUnitsPricesBindingSource.Current).Row);
          
          
         
            if (((DataRowView)productUnitsPricesBindingSource.Current)["productid"] == DBNull.Value)
            {
                return false;
            }
            // Save the master row
            pRODUCTSBindingSource.EndEdit();
            pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS); //master);
           
            if (detail.productid  != master.PRODUCTID )
            {
                for (int i = 0; i < productUnitsPricesBindingSource.Count; i++)
                {
                    ((DataRowView)productUnitsPricesBindingSource[i])["productid"] = master.PRODUCTID;
                }
            }
            productUnitsPricesBindingSource.EndEdit();
            product_Units_PricesTableAdapter.Update(nEWERPDataSet.Product_Units_Prices);


            if (productOffersBindingSource.Count >0)
            {
                NEWERPDataSet.ProductOffersRow detail1 = (NEWERPDataSet.ProductOffersRow)(((DataRowView)productOffersBindingSource.Current).Row);

                if (detail1.productid != master.PRODUCTID)
                {
                    for (int i = 0; i < productOffersBindingSource.Count; i++)
                    {
                        ((DataRowView)productOffersBindingSource[i])["productid"] = master.PRODUCTID;
                    }
                }
                productOffersBindingSource.EndEdit();
                productOffersTableAdapter.Update(nEWERPDataSet.ProductOffers);

            }
            if (productAssemplyBindingSource.Count > 0)
            {
             NEWERPDataSet.Product_AssemplyRow detail2 = (NEWERPDataSet.Product_AssemplyRow)(((DataRowView)productAssemplyBindingSource.Current).Row);

                if (detail2.productid != master.PRODUCTID)
                {
                    for (int i = 0; i < productOffersBindingSource.Count; i++)
                    {
                        ((DataRowView)productAssemplyBindingSource[i])["productid"] = master.PRODUCTID;
                    }
                }
            
            productAssemplyBindingSource.EndEdit();
            productReplacmentTableAdapter.Update(nEWERPDataSet.ProductReplacment);

            }

            if (productReplacmentBindingSource.Count > 0)
            {
                   NEWERPDataSet.ProductReplacmentRow detail3 = (NEWERPDataSet.ProductReplacmentRow)(((DataRowView)productReplacmentBindingSource.Current).Row);


                if (detail3.productid != master.PRODUCTID)
                {
                    for (int i = 0; i < productReplacmentBindingSource.Count; i++)
                    {
                        ((DataRowView)productReplacmentBindingSource[i])["productid"] = master.PRODUCTID;
                    }
                }
                productReplacmentBindingSource.EndEdit();
                product_AssemplyTableAdapter.Update(nEWERPDataSet.Product_Assemply);
           }


            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }

        private Boolean  SaveAll(TreeNode SNode, Boolean DelFlag)
        {
           Boolean ret = false;
            
                try
                {
                    if (GLibrary.MsgCheckSave(DelFlag))
                    {
                        if (this.ValidateChildren())
                        {
                            if (!EditFlag)
                            {
                                if (!GLibrary.ValidatetxtBox(errorProvider1, txtProductCode, "√œŒ· «·ﬂÊœ ", "«·«’‰«›", true) && !GLibrary.ValidatetxtBox(errorProvider1, txtProductName, "√œŒ· «·ﬂÊœ ", "«·«’‰«›", true))
                                {
                                    return false;
                                }
                            }
                            if (productUnitsPricesBindingSource.Count == 0 && !MainAccChkBox.Checked)
                            {

                                MessageBox.Show(Messages.ProductUnitsMesg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                return false;
                            }
                            else
                            {
                                if (CheckUints())
                                {

                            int pos = pRODUCTSBindingSource.Find("PRODUCTID", txtMainProductId.Text);
                            if (!EditFlag)
                            {
                                if (MainAccChkBox.Checked)
                                {
                                    txtProcessFlag.Text = bool.TrueString;
                                }
                                else
                                {
                                    txtProcessFlag.Text = bool.FalseString ;
                                }
                                if (pos > -1)
                                {
                                    long oldLastSerialNo;
                                    if (nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"] != DBNull.Value)
                                    {
                                        oldLastSerialNo = long.Parse(nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"].ToString());
                                    }
                                    else
                                    {
                                        oldLastSerialNo = long.Parse(LastSerialNo);
                                    }
                                    if (long.Parse(txtProductCode.Text) >= oldLastSerialNo)
                                    {
                                        //nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"] = txtProductCode.Text;
                                        ((DataRowView)pRODUCTSBindingSource[pos])["SerialCode"] = txtProductCode.Text;
                                        pRODUCTSBindingSource.EndEdit();
                                    }
                                }
                                txtLastSerial.Text = txtProductCode.Text + "0";
                            }
                            else
                            {
                                if (pos > -1)
                                {
                                    long oldLastSerialNo;
                                    if (nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"] != DBNull.Value)
                                    {
                                        oldLastSerialNo = long.Parse(nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"].ToString());
                                    }
                                    else
                                    {
                                        oldLastSerialNo = long.Parse(txtProductCode.Text);
                                    }
                                    if (long.Parse(txtProductCode.Text) >= oldLastSerialNo)
                                    {
                                        //nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"] = txtProductCode.Text;
                                        ((DataRowView)pRODUCTSBindingSource[pos])["SerialCode"] = txtProductCode.Text;
                                        pRODUCTSBindingSource.EndEdit();
                                    }
                                }
                            }
                            bFlag = false;
                            RestoreTreeNode();

                            pRODUCTSBindingSource.EndEdit();
                            int I = pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);

                            Messages.ProductFlag  = 1;
                          
                            if (!MainAccChkBox.Checked)
                            {
                                SaveChild();


                                if (!EditFlag)
                                {
                                    int Curpos = productUnitsPricesBindingSource.Find("MainUnit", true);
                                    if (Curpos > -1)
                                    {
                                        int sPos= sTORESBindingSource.Find ("BRANCHCODE",Messages.CurBranch);
                                        if (sPos >-1)
                                        {
                                        sTOCKBindingSource.AddNew();
                                        ((DataRowView)sTOCKBindingSource.Current)["PRODUCTID"] = ((DataRowView)productUnitsPricesBindingSource[Curpos])["PRODUCTID"];
                                        ((DataRowView)sTOCKBindingSource.Current)["UnitID"] = ((DataRowView)productUnitsPricesBindingSource[Curpos])["UintId"];                         
                                        ((DataRowView)sTOCKBindingSource.Current)["STOREID"] = ((DataRowView)sTORESBindingSource[Curpos])["STOREID"];
                                        ((DataRowView)sTOCKBindingSource.Current)["QtyInStore"] = 0;
                                        sTOCKBindingSource.EndEdit();
                                        this.sTOCKTableAdapter.Update(this.nEWERPDataSet.STOCK);
                                        //int CurproductId=int.Parse ( ((DataRowView)productUnitsPricesBindingSource[Curpos])["PRODUCTID"].ToString ());
                                        //int cpos = pRODUCTSBindingSource.Find("PRODUCTID", CurproductId);
                                        //    if (cpos >-1)
                                        //    {
                                        //        ((DataRowView)pRODUCTSBindingSource[cpos])["ProcessFlag"] = Boolean.TrueString;
                                        //         pRODUCTSBindingSource.EndEdit();
                                        //          pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);
                                        //    }
                                    }
                                    }
                                                               
                                }

                            }
                            else
                            {
                                productUnitsPricesBindingSource.CancelEdit();
                                productOffersBindingSource.CancelEdit();
                                productAssemplyBindingSource.CancelEdit();
                                productReplacmentBindingSource.CancelEdit();
                            }

                            if (!EditFlag)
                            {
                               TreeNode Node = new TreeNode();                                    
              
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
                                

                                Node.Tag = txtProductId.Text;
                                Node.Text = txtProductCode.Text + " / " + txtProductName.Text + txtProductEngName.Text;
                                Node.ToolTipText = txtProductCode.Text + " / " + txtProductName.Text;

                                if (SNode == null)
                                {
                                    ProductstreeView.Nodes.Add(Node);
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

                                ProductstreeView.SelectedNode = Node;

                                Flag = true;
                                ProductstreeView.Select();
                                EditFlag = true;
                                CmdAdd.Enabled = true;
                                CmdDel.Enabled = true;
                                CmdSave.Enabled = true;
                                if (Messages.CurLang == Messages.ArabLang)
                                {
                                    CmdSave.Text = " ⁄œÌ·";

                                }
                                else if (Messages.CurLang == Messages.EngLang)
                                {
                                    CmdSave.Text = "Edit";
                                }
                                //CmdSave.Text = " ⁄œÌ·";

                            }
                            else
                            {
                                if (ProductstreeView.SelectedNode != null)
                                {
                                    string str = ((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTCODE"].ToString() + " / " + ((DataRowView)pRODUCTSBindingSource.Current)["productname"].ToString() + "-" + ((DataRowView)pRODUCTSBindingSource.Current)["EnglishName"].ToString();
                                    ProductstreeView.SelectedNode.Tag = ((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString();
                                    ProductstreeView.SelectedNode.Text = str;
                                    ProductstreeView.SelectedNode.ToolTipText = str;

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

                     }
                  }


                   
            }
            catch (Exception ex)
            {
                int ErrorNo=-1;
                GLibrary.ExceptionToMessage(ex,ref ErrorNo );
            }
            return ret;
        
        }
       
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (ProductstreeView.SelectedNode == null)
            {
                MainAddNode = null;
            }

            else if (ProductstreeView.SelectedNode.Parent == null)
            {
                MainAddNode = null;
            }
            else
            {
                MainAddNode = ProductstreeView.SelectedNode.Parent;

            }

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }
            bFlag = false;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
            CmdSave.Enabled = true;
        }
        private void AddNewAccount(TreeNode Node, Boolean MainFlag)
        {
            //CmbClosedTo.SelectedIndex = 0;
            pRODUCTSBindingSource.CurrencyManager.AddNew();
            //txtdisplay_Flag.Text = bool.FalseString;
            txtLastSerial.Text = "0";

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }
            if (Node == null)
            {
                txtMainProductId.Text = "0";
                txtMainProductCode.Text = "0";
                txtLevel.Text = "0";
               // txtMainParentId.Text = "1";
                txtRootFlag.Text = bool.TrueString;
                txtProcessFlag.Text = bool.FalseString;
                MainAccChkBox.Checked = true;
                int intCount = ProductstreeView.Nodes.Count;
                txtProductCode.Text = txtProductCode.Text + (intCount + 1).ToString();
               
            }
            else if (Node.Level > -1)
            {
                txtMainProductId.Text = Node.Tag.ToString();
                txtMainProductName.Text = Node.Text;
                int index = Node.ToolTipText.IndexOf("/");
                txtMainProductCode.Text = Node.ToolTipText.Substring(0, index);
                txtMainProductCode.Text = txtMainProductCode.Text.TrimEnd();
                txtLevel.Text = (Node.Level + 1).ToString();
                GetMainParent(Node);
                txtRootFlag.Text = bool.FalseString;
                txtProcessFlag.Text = bool.FalseString;
                if (CmbProductType.Items.Count > 0) CmbProductType.SelectedIndex = 0;

                Node.ImageIndex = 0;
                Node.SelectedImageIndex = 0;
                if (Node == null)
                {
                    MainAccChkBox.Checked = true;
                    MainAccChkBox.Enabled = false;
                    EnbDisbControls(false);
                }
                else
                {
                    MainAccChkBox.Checked = MainFlag;
                    MainAccChkBox.Enabled = true;
                    if (MainFlag)
                    {
                        EnbDisbControls(false);
                    }
                    else
                    {
                        EnbDisbControls(true);
                    }
                    
                }


            }
           
            //MainAccChkBox.Enabled = true;
            //MainAccChkBox.Checked = false;
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            txtProductName.Focus();
            //txtStartdate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
           
        }
        //private void AddNewProduct()
        //{
        //    if (ProductstreeView.SelectedNode.Level > 1)
        //    {
               
        //        MessageBox.Show(Messages.ProductLevelMesg, "Õ›Ÿ «·”Ã·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //    }
        //    else
        //    {
        //        pRODUCTSBindingSource.AddNew();
        //        ((DataRowView)pRODUCTSBindingSource.Current)["SerialCode"] = 0;
        //        if (ProductstreeView.SelectedNode.Level == 1)
        //        {

        //            EnbDisbControls(true);
        //            txtMainProductId.Text = ProductstreeView.SelectedNode.Tag.ToString();
        //            txtMainProductName.Text = ProductstreeView.SelectedNode.Text;
        //            int index = ProductstreeView.SelectedNode.ToolTipText.IndexOf("/");
        //            txtMainProductCode.Text = ProductstreeView.SelectedNode.ToolTipText.Substring(0, index);
        //            txtMainProductCode.Text = txtMainProductCode.Text.TrimEnd();
        //            txtRootFlag.Text = bool.FalseString;
        //            if (ProductstreeView.SelectedNode.Level > 0)
        //            {
        //                GetMainParent(ProductstreeView.SelectedNode);
        //            }

        //            int Pos = pRODUCTSBindingSource.Find("ProductId", txtMainProductId.Text);
        //            if (Pos != -1)
        //            {
        //                nEWERPDataSet.PRODUCTS.Rows[Pos]["Root"] = true;
        //            }

        //        }
        //        else
        //        {
        //            txtRootFlag.Text = bool.TrueString;
        //            txtMainProductId.Text = "0";
        //            txtProductCode.Text = (ProductstreeView.SelectedNode.Nodes.Count + 1).ToString();
        //            EnbDisbControls(false);


        //        }

        //        CmbProductType.SelectedIndex = 0;
        //        EditFlag = false;
        //        CmdAdd.Enabled = false;
        //        CmdDel.Enabled = false;
        //        txtProductCode.Focus();
        //    }

        //}
        //private void GetMainParent(TreeNode Node)
        //{
        //       int intCount=0;// = Node.Nodes.Count;
        //       //if(Node.Level >1)
        //       //{
        //       //     Node = Node.Parent;
        //       //}
           
        //        int Pos = pRODUCTSBindingSource.Find("ProductId", Node.Tag );
        //        if (Pos != -1)
        //        {
        //            intCount = int.Parse (nEWERPDataSet.PRODUCTS.Rows[Pos]["SerialCode"].ToString ());
        //        }
        //        intCount = intCount + 1; //intCount+ Node.Nodes.Count;
        //    ((DataRowView)pRODUCTSBindingSource[Pos])["SerialCode"]=intCount;
               
            
           
        //    int index = Node.ToolTipText.IndexOf("/");
        //    txtProductCode.Text  = Node.ToolTipText.Substring(0, index);
        //    txtProductCode.Text = txtProductCode.Text.TrimEnd();
        //    txtProductCode.Text = txtProductCode.Text + intCount.ToString("");

        //}
        private void GetMainParent(TreeNode Node)
        {
            int intCount = Node.Nodes.Count;
            int index = Node.ToolTipText.IndexOf("/");
            txtProductCode.Text = Node.ToolTipText.Substring(0, index);
            txtProductCode.Text = txtProductCode.Text.TrimEnd();
            string PRODUCTID = Node.Tag.ToString();
            int pos = pRODUCTSBindingSource.Find("PRODUCTID", PRODUCTID);
            long Serial = 0;
            if (pos > -1)
            {
                string str = "";
                LastSerialNo = nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"].ToString();
                if (LastSerialNo == "" || LastSerialNo=="0")
                {
                    str = txtProductCode.Text + Node.Nodes.Count.ToString();

                }
                else
                {
                    str = LastSerialNo.Remove(0, txtProductCode.Text.Length);
                    if (str == "")
                    {
                        str = "0";
                    }
                }
                Serial = long.Parse(str);
                //Serial = long.Parse(nEWERPDataSet.accounting.Rows[pos]["LastSerialNo"].ToString());
               
            }

            Serial = Serial + 1;

            int NewSeraillen = Serial.ToString().Length;
            if (NewSeraillen == LastSerialNo.Length) // old =new length
            {
                LastSerialNo = Serial.ToString();
            }
            else
            {
                if (LastSerialNo != "" && LastSerialNo!="0")
                {

                    LastSerialNo = LastSerialNo.Substring(0, LastSerialNo.Length - Serial.ToString().Length) + Serial;
                }
                else
                {
                    LastSerialNo = Serial.ToString();
                }
            }
            //LastSerialNo = LastSerialNo + 1;
            txtProductCode.Text = LastSerialNo; //(intCount + 1); //"-"+ .ToString("000000");
           
        }
        private void SetMainParent(TreeNode Node)
        {
            //int intCount; //= Node.Nodes.Count;
               if(Node.Level >1)
                {
                    Node = Node.Parent;
               }
           
                int Pos = pRODUCTSBindingSource.Find("ProductId", Node.Tag );
                if (Pos != -1)
                {
                    ((DataRowView)pRODUCTSBindingSource[Pos])["SerialCode"] = SerialCode;
                    pRODUCTSBindingSource.EndEdit();
                    //nEWERPDataSet.PRODUCTS.Rows[Pos]["SerialCode"] = SerialCode;
                }
             
               
           
        }
        private void ProductstreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Level > 0)
            //if (pRODUCTSBindingSource.Count > 0)
            //{
            //    if (((DataRowView)pRODUCTSBindingSource.Current).IsNew)
            //    {
            //        if (GLibrary.MsgCheckSave(false ))
            //        {
            //            SaveAll();
            //        }
            //        else
            //        {
            //            pRODUCTSBindingSource.CancelEdit();
            //            productUnitsPricesBindingSource.CancelEdit ();
            //            productOffersBindingSource.CancelEdit ();
            //            productReplacmentBindingSource.CancelEdit ();
            //            productAssemplyBindingSource.CancelEdit();

            //        }
            //        if (!EditFlag)
            //        {
            //            CmdAdd.Enabled = true;
            //            CmdDel.Enabled = true;
            //            EditFlag = true;

            //        }
            //    }
            //    else
            //    {
            //        pRODUCTSBindingSource.CancelEdit();
            //        productUnitsPricesBindingSource.CancelEdit();
            //        productOffersBindingSource.CancelEdit();
            //        productReplacmentBindingSource.CancelEdit();
            //        productAssemplyBindingSource.CancelEdit();
            //    }

            //}
            //else
            //{
            //    txtMainProductCode.Text = "";
            //    txtMainProductName.Text = "";
            //    txtRootFlag.Text = bool.TrueString ;
            //    EnbDisbControls(false);
            //}
           
            //if (e.Node.Level >= 1)
            //{
            //    int ProductId = int.Parse(e.Node.Tag.ToString());
            //    int Pos = pRODUCTSBindingSource.Find("ProductId", ProductId);
            //    pRODUCTSBindingSource.Position = Pos;
            //    if (e.Node.Level > 1)
            //    {
            //        txtMainProductName.Text = e.Node.Parent.Text;
            //        int index = e.Node.Parent.ToolTipText.IndexOf("/");
            //        txtMainProductCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
            //        txtMainProductCode.Text = txtMainProductCode.Text.TrimEnd();
            //        txtRootFlag.Text = bool.FalseString ;
            //        EnbDisbControls(true);
            //        e.Node.SelectedImageIndex  = 1;
            //    }
            //    else
            //    {
            //        txtMainProductCode.Text = "";
            //        txtMainProductName.Text = "";
            //        txtRootFlag.Text = bool.TrueString ;
            //        EnbDisbControls(false);
            //        e.Node.SelectedImageIndex = 0;
            //    }
            //}

            //errorProvider1.Clear();
            try
            {
                if (Flag)
                {
                    if (Messages.CurLang == Messages.ArabLang)
                    {
                        CmdSave.Text = " ⁄œÌ·";

                    }
                    else if (Messages.CurLang == Messages.EngLang)
                    {
                        CmdSave.Text = "Edit";
                    }
                    //if (((DataRowView)pRODUCTSBindingSource.Current).Row.RowState == DataRowState.Detached)
                    //{
                    //    if (GLibrary.MsgCheckSave(false))
                    //    {
                    //        if (SaveAll(MainAddNode, false))
                    //        {
                    //        }
                    //        else
                    //        {
                    //            CmdAdd.Enabled = true;
                    //            CmdDel.Enabled = true;
                    //            EditFlag = true;
                    //            return;
                    //        }
                    //    }
                    //    else
                    //    {
                    //        pRODUCTSBindingSource.CancelEdit();
                    //        productUnitsPricesBindingSource.CancelEdit();
                    //        productOffersBindingSource.CancelEdit();
                    //        productReplacmentBindingSource.CancelEdit();
                    //        productAssemplyBindingSource.CancelEdit();
                    //        this.nEWERPDataSet.RejectChanges();
                    //        CmdAdd.Enabled = true;
                    //        CmdDel.Enabled = true;
                    //        EditFlag = true;

                    //    }
                    //}
                    //else //edit mode
                    //{
                    //    // string AccId = e.Node.Tag.ToString ();
                    //    // int pos = accountingBindingSource.Find("accountid", AccId);
                    //    //if (pos > -1)
                    //    //{
                    //    //    accountingBindingSource.Position = pos;
                    //    //}
                    //    //((DataRowView)pRODUCTSBindingSource.Current).EndEdit();
                    //    int ipos=pRODUCTSBindingSource.Position ;
                    //    if(((DataRowView)(pRODUCTSBindingSource.List[ipos])).Row.RowState == DataRowState.Modified )
                    //    //if (this.nEWERPDataSet.HasChanges() == true)
                    //    //if (((DataRowView)accountingBindingSource.Current).RowVersion == DataRowVersion.Proposed)
                    //    {
                    //        Boolean LocFlag = false;
                    //        if (FlagFoDel)
                    //        {
                    //            LocFlag = true;
                    //        }
                    //        if (GLibrary.MsgCheckSave(LocFlag))
                    //        {
                    //            LocFlag = true;
                    //            if (SaveAll(MainAddNode, LocFlag))
                    //            {
                    //            }
                    //            else
                    //            {
                    //                CmdAdd.Enabled = true;
                    //                CmdDel.Enabled = true;
                    //                EditFlag = true;
                    //                return;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            pRODUCTSBindingSource.CancelEdit();
                    //            productUnitsPricesBindingSource.CancelEdit();
                    //            productOffersBindingSource.CancelEdit();
                    //            productReplacmentBindingSource.CancelEdit();
                    //            productAssemplyBindingSource.CancelEdit();
                    //            this.nEWERPDataSet.RejectChanges();
                    //            CmdAdd.Enabled = true;
                    //            CmdDel.Enabled = true;
                    //            EditFlag = true;

                    //        }
                    //    }
                    //    else
                    //    {
                    //        pRODUCTSBindingSource.CancelEdit();
                    //        productUnitsPricesBindingSource.CancelEdit();
                    //        productOffersBindingSource.CancelEdit();
                    //        productReplacmentBindingSource.CancelEdit();
                    //        productAssemplyBindingSource.CancelEdit();
                    //        this.nEWERPDataSet.RejectChanges();
                    //        CmdAdd.Enabled = true;
                    //        CmdDel.Enabled = true;
                    //        EditFlag = true;

                    //    }
                    //}



                    pRODUCTSBindingSource.CancelEdit();
                    productUnitsPricesBindingSource.CancelEdit();
                    productOffersBindingSource.CancelEdit();
                    productReplacmentBindingSource.CancelEdit();
                    productAssemplyBindingSource.CancelEdit();
                    this.nEWERPDataSet.RejectChanges();
                    pRODUCTSBindingSource.EndEdit();

                    //int I = pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);
                  
                    CmdAdd.Enabled = true;
                    CmdDel.Enabled = true;
                    EditFlag = true;


                    int Productid = int.Parse(e.Node.Tag.ToString());
                    int Pos = pRODUCTSBindingSource.Find("PRODUCTID", Productid);
                    bFlag = false;
                    pRODUCTSBindingSource.Position = Pos;
                    bFlag = true;
                    //ChangeNodeData();


                    if (e.Node.Level > 0) //Get Parent info
                    {
                        txtMainProductName.Text = e.Node.Parent.Text;
                        int index = e.Node.Parent.ToolTipText.IndexOf("/");
                        txtMainProductCode.Text = e.Node.Parent.ToolTipText.Substring(0, index);
                        txtMainProductCode.Text = txtMainProductCode.Text.TrimEnd();
                        EnbDisbControls(true);
                    }
                    if (e.Node.Level > 0)
                    {
                        Boolean ProcessFlag = false;
                        Boolean MainNode = false;
                        if (((DataRowView)pRODUCTSBindingSource.Current)["MainNode"] != DBNull.Value)
                        {
                            MainNode = (Boolean)((DataRowView)pRODUCTSBindingSource.Current)["MainNode"];
                        }
                        if (((DataRowView)pRODUCTSBindingSource.Current)["ProcessFlag"] != DBNull.Value)
                        {
                             ProcessFlag = (Boolean)((DataRowView)pRODUCTSBindingSource.Current)["ProcessFlag"];
                        }
                        if (ProcessFlag)
                        {
                              MainAccChkBox.Enabled = false;
                            
                        }
                        else
                        {
                          
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
                        if (MainNode)
                        {
                            EnbDisbControls(false);
                        }
                        else
                        {
                            EnbDisbControls(true);
                        }
                    }
                    else
                    {
                        MainAccChkBox.Enabled = false;
                        EnbDisbControls(false);
                    }


                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·Õ”«»« ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            }

        private void EnbDisbControls(Boolean EnProp)
        {
            UnitsdGridView.Enabled = EnProp;
            if (EnProp)
            {


                if (!tabControlProduct.TabPages.Contains(tabPage2)) tabControlProduct.TabPages.Add(tabPage2);
                if (!tabControlProduct.TabPages.Contains(tabPage3)) tabControlProduct.TabPages.Add(tabPage3);
                if (!tabControlProduct.TabPages.Contains(tabPage7)) tabControlProduct.TabPages.Add(tabPage7);
                if (!tabControlProduct.TabPages.Contains(tabPage4)) tabControlProduct.TabPages.Add(tabPage4);
                if (!tabControlProduct.TabPages.Contains(tabPage6)) tabControlProduct.TabPages.Add(tabPage6);
                if (!tabControlProduct.TabPages.Contains(tabPage5)) tabControlProduct.TabPages.Add(tabPage5);


                if (CmbProductType.SelectedValue != null)
                {
                    //if (CmbProductType.SelectedValue.ToString() != "2")
                    if (int.Parse(CmbProductType.SelectedValue.ToString()) != int.Parse(GLibrary.strarrProductTypes[1, 0]))
                    {
                        tabControlProduct.TabPages.Remove(tabPage6);
                    }
                    else
                    {
                        if (!tabControlProduct.TabPages.Contains(tabPage6)) tabControlProduct.TabPages.Add(tabPage6);
                    }
                }
                else
                {
                    tabControlProduct.TabPages.Remove(tabPage6);
                }
                CmbProductType.Enabled = true;
                
            }
            else
            {
                //dGrdViewPrice.CancelEdit();
                //productUnitsPricesBindingSource.CancelEdit();


                tabControlProduct.TabPages.Remove (tabPage2);
                tabControlProduct.TabPages.Remove(tabPage3);
                tabControlProduct.TabPages.Remove(tabPage4);
                tabControlProduct.TabPages.Remove(tabPage5);
                tabControlProduct.TabPages.Remove(tabPage7);
                tabControlProduct.TabPages.Remove(tabPage6);
                CmbProductType.Enabled = false;
            }


        }
        private void TreeSearch()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch="";
            int Pos= pRODUCTSBindingSource.Find("ProductName", txtSearch.Text);
            if (Pos == -1)
            {
                Pos = pRODUCTSBindingSource.Find("ProductCode", txtSearch.Text); 
            }
            if (Pos != -1)
            {
                strSearch = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductID"].ToString();
                TreeNode[] SearchNodes = ProductstreeView.Nodes.Find(strSearch, true);
                if (SearchNodes.Length > 0)
                {
                    if (SearchNodes[0].Parent != null)
                    {
                        SearchNodes[0].Parent.Expand();
                    }
                    else
                    {
                        SearchNodes[0].Expand();
                    }
                    
                    ProductstreeView.SelectedNode = SearchNodes[0];
                    ProductstreeView.Select();
                }
            }
            //TreeNode[] SearchNodes = ProductstreeView.Nodes.Find(txtSearch.Text, true);
           
        }
        public void TreeSearchById()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch = "";
            int Pos = pRODUCTSBindingSource.Find("ProductId", PassProductId);
            if (Pos != -1)
            {
                strSearch = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductID"].ToString();
                TreeNode[] SearchNodes = ProductstreeView.Nodes.Find(strSearch, true);
                if (SearchNodes.Length > 0)
                {

                    if (SearchNodes[0].Parent != null)
                    {
                        SearchNodes[0].Parent.Expand();
                    }
                    else
                    {
                        SearchNodes[0].Expand();
                    }
                    ProductstreeView.SelectedNode = SearchNodes[0];
                    ProductstreeView.Select();
                }
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
            ProductstreeView.SelectedNode = e.Node;
            ProductstreeView.Select();
        }

        private void ProductstreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            ProductstreeView.SelectedNode = e.Node;
            ProductstreeView.Select();
        }

        private void pRODUCTSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUCTSBindingSource.Count > 0)
            {
                Int64 ProductId = (Int64)((DataRowView)pRODUCTSBindingSource.Current)["ProductID"];
                productUnitsPricesBindingSource.Filter = "ProductID = " + ProductId.ToString();
                if (CmbStroes.SelectedValue != null && CmbUnitTypes.SelectedValue != null)
                {
                    sTOCKBindingSource.Filter = "ProductID = " + ProductId.ToString() + " and StoreId= " + CmbStroes.SelectedValue + " and unitId=" + CmbUnitTypes.SelectedValue;
                }
                productReplacmentBindingSource.Filter = "ProductID = " + ProductId.ToString();
                productAssemplyBindingSource.Filter = "ProductID = " + ProductId.ToString();

            }
        }

        private void productUnitsPricesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUCTSBindingSource.Count > 0 && productUnitsPricesBindingSource.Count >0)
            {
                 if (pRODUCTSBindingSource.Count > 0 && productUnitsPricesBindingSource.Count >0)
            {
                    ((DataRowView)productUnitsPricesBindingSource.Current)["ProductID"] = (Int64)((DataRowView)pRODUCTSBindingSource.Current)["ProductID"];
                }
            }
        }

        private void productOffersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUCTSBindingSource.Count > 0 && productOffersBindingSource.Count >0)
            {
                ((DataRowView)productOffersBindingSource.Current)["ProductID"] = (Int64)((DataRowView)pRODUCTSBindingSource.Current)["ProductID"];
            }

        }

        private void productReplacmentBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUCTSBindingSource.Count > 0 && productReplacmentBindingSource.Count >0)
            {
                ((DataRowView)productReplacmentBindingSource.Current)["ProductID"] = (Int64)((DataRowView)pRODUCTSBindingSource.Current)["ProductID"];
            }

        }

        private void productAssemplyBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pRODUCTSBindingSource.Count > 0 && productAssemplyBindingSource.Count >0)
            {
                ((DataRowView)productAssemplyBindingSource.Current)["ProductID"] = (Int64)((DataRowView)pRODUCTSBindingSource.Current)["ProductID"];
            }
        }
     

        private void ProductAdd_Activated(object sender, EventArgs e)
        {
            
        }

        private void tabControlProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedTab != this.tabControlProduct.SelectedTab)
            {
                 Boolean MainNode = false;
                 if (((DataRowView)pRODUCTSBindingSource.Current)["MainNode"] != DBNull.Value)
                 {
                     MainNode = (Boolean)((DataRowView)pRODUCTSBindingSource.Current)["MainNode"];
                     //if (EditFlag && ProductstreeView.SelectedNode.Level >1)
                     if (EditFlag && !MainNode)
                     {
                         switch (tabControlProduct.SelectedIndex)
                         {
                             case 1:

                                 break;

                             case 2:
                                 break;
                         }
                     }
                     else
                     {

                         {

                             MessageBox.Show(Messages.TabSaveMesg, "Õ›Ÿ «·”Ã·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                         }
                         tabControlProduct.SelectedIndex = 0;
                     }
                     selectedTab = tabControlProduct.SelectedTab;
                 }
            }
        
        }

        private void txtOfferProductName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int iProductId=-1;
                string strProductName="";
                string strProductCode = "";
                DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

                txtOfferProductName.Text = strProductName;
                txtOfferProductId.Text = iProductId.ToString();

            }
        }
        private void DisplayProducts(ref string  ProductName,ref int ProductID,ref string ProductCode)
        {
            ProductsList frm = new ProductsList();
            DialogResult ret =frm.ShowDialog(this);
            if (DialogResult.OK==ret )
            {
                ProductName=frm.CurProductName;
                ProductID = frm.CurProductId;
                ProductCode = frm.CurProductCode;
            }

        }

        private void dGridViewRep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                 int iProductId=-1;
                string strProductName="";
                string strProductCode = "";
                DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

                dGridViewRep.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = strProductCode;
                dGridViewRep.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = strProductName;
                dGridViewRep.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = iProductId.ToString ();


            }
        }

        private void dGridViewRep_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dGridViewRep.Rows[e.RowIndex].Cells["ReplaceProductId"].Value != null)
            {
                string strReplaceProductId = dGridViewRep.Rows[e.RowIndex].Cells["ReplaceProductId"].Value.ToString();
                if (strReplaceProductId != "")
                {
                    int Pos = pRODUCTSBindingSource.Find("ProductId", strReplaceProductId);
                    if (Pos != -1)
                    {
                        string ProductCode = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductCode"].ToString();
                        string ProductName = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductName"].ToString();
                        dGridViewRep.Rows[e.RowIndex].Cells["RepProductCode"].Value = ProductCode;
                        dGridViewRep.Rows[e.RowIndex].Cells["RepProductName"].Value = ProductName;
                    }
                }
            }
            
        }

     

        private void txtOfferProductId_TextChanged(object sender, EventArgs e)
        {
            if (txtOfferProductId.Text != "")
            {
                string strOfferProductId = txtOfferProductId.Text;
                int Pos = pRODUCTSBindingSource.Find("ProductId", strOfferProductId);
                if (Pos != -1)
                {
                    txtOfferProductName.Text  = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductName"].ToString();
                }
            }
        }

        private void ProductpicBox_DoubleClick(object sender, EventArgs e)
        {
            AddPic();

        }
        private void AddPic()
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                byte[] imageData = ReadFile(openFileDialog1.FileName);
                int Pos = pRODUCTSBindingSource.Position;
                ((DataRowView)pRODUCTSBindingSource.Current)["picpath"] = (object)imageData;
                pRODUCTSBindingSource.EndEdit();
                //nEWERPDataSet.PRODUCTS.Rows[Pos]["picpath"] = (object)imageData;
                //ProductpicBox.Image.Save(imageData);
                //ProductpicBox.Image = (object)imageData; //Image.FromStream((object)imageData);

            }
        }
        byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        //check vaidaition DataGrid
        private void CheckValiad(ref DataGridView DGView, ref DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            if (DGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

            TimeSpan sinceLast = DateTime.Now - lastDataError;
            lastDataError = DateTime.Now;
            string message;
            if (null == e.Exception)

                message = "Bad value.";

            else
            {
                message = e.Exception.Message;
                if (e.Exception is System.Reflection.TargetInvocationException)
                    if (e.Exception.InnerException is FormatException)
                        message = "Bad value format. Check the type of value entered.";
            }

            DGView.Rows[e.RowIndex].ErrorText = message;

            if (sinceLast.TotalSeconds < 1.0)

                MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            else

                SystemSounds.Beep.Play();
        }

        private void UnitsdGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            UnitsdGridView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void UnitsdGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CheckValiad(ref UnitsdGridView, ref e);
        }

        private void dGridViewRep_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dGridViewRep.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dGridViewRep_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CheckValiad(ref dGridViewRep, ref e);
        }

        


        private void UnitsdGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ConFactor"].Value = "1";
            e.Row.Cells["UintID"].Value=1 ;
           
            
        }

        private void dGridViewRep_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["AvaliableQty"].Value = 1;
        }

        private void dGridViewAssmp_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["AssUINTID"].Value = 1;
            e.Row.Cells["AssQty"].Value = 1;
            
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckDel())
            {
                if (ProductstreeView.SelectedNode != null)
                {
                    if (ProductstreeView.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show(Messages.ProductErrorMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else if (((DataRowView)pRODUCTSBindingSource.Current)["ProcessFlag"].ToString() == Boolean.TrueString)
                    {
                        MessageBox.Show(Messages.ProductProcessErrorMesg, "«·Õ”«»", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return;
                    }

                    else
                    {
                        string PNode = "1";
                        Boolean ChangeFlag = false;
                        if (ProductstreeView.SelectedNode.Parent != null)
                        {
                            PNode = ProductstreeView.SelectedNode.Parent.Tag.ToString();
                        }
                        pRODUCTSBindingSource.RemoveCurrent();
                        FlagFoDel = true;
                        if (ProductstreeView.SelectedNode.NextNode == null)
                        {
                            ChangeFlag = true;
                        }
                        Flag = false;
                        ProductstreeView.SelectedNode.Remove();

                        FlagFoDel = false;
                        if (ChangeFlag)
                        {
                            int pos = pRODUCTSBindingSource.Find("PRODUCTID", PNode);
                            if (pos > -1)
                            {
                                string AccountCode = "1";
                                if (ProductstreeView.SelectedNode.LastNode != null)
                                {
                                    int index = ProductstreeView.SelectedNode.LastNode.ToolTipText.IndexOf("/");
                                    AccountCode = ProductstreeView.SelectedNode.LastNode.ToolTipText.Substring(0, index);
                                    AccountCode = AccountCode.TrimEnd();
                                }
                                else  //if (AccountTreeView.SelectedNode.LastNode != null)
                                {
                                    int index = ProductstreeView.SelectedNode.ToolTipText.IndexOf("/");
                                    AccountCode = ProductstreeView.SelectedNode.ToolTipText.Substring(0, index);
                                    AccountCode = AccountCode.TrimEnd();
                                    AccountCode = AccountCode + "0";
                                }
                                ((DataRowView)pRODUCTSBindingSource[pos])["SerialCode"] = AccountCode;
                                pRODUCTSBindingSource.EndEdit();
                                //nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"] = AccountCode;

                            }


                        }
                    }

                    pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);
                    GLibrary.MsgDel();
                  
                    Flag = true;
                    if (ProductstreeView.SelectedNode.LastNode != null)
                    {
                        if (!ProductstreeView.SelectedNode.IsExpanded)
                        {
                            ProductstreeView.SelectedNode.Expand();
                        }
                        ProductstreeView.SelectedNode = ProductstreeView.SelectedNode.LastNode;
                        ProductstreeView.Select();
                    }

                }
            }
            
            //try
            //{
            //    if (ProductstreeView.SelectedNode.Nodes.Count > 0)
            //    {
            //        MessageBox.Show("·« Ì„ﬂ‰ Õ–› Â–« «·’‰› «·« »⁄œ Õ–› Ã„Ì⁄ «·«’‰«› «· «»⁄… ·Â", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    if (GLibrary.MsgCheckDel())
            //    {
                    
            //        if (ProductstreeView.SelectedNode != null)
            //        {

            //            if (ProductstreeView.SelectedNode.Level > 0)
            //            {
            //                pRODUCTSBindingSource.RemoveCurrent();

            //                pRODUCTSBindingSource.EndEdit();
            //                int I = pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);
            //                ProductstreeView.SelectedNode.Remove();
            //            }
            //            //SaveAllData(MainAddNode);

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    int ErrorNo = -1;
               
            //    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    pRODUCTSBindingSource.CancelEdit();
            //}
           
        }

        private void UnitsdGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == UintID.HeaderCell.ColumnIndex)
            {
                //cDEUNITTYPESBindingSource

                UnitsTypeAdd frm = new UnitsTypeAdd();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    cDEUNITTYPESBindingSource.AddNew();
                    ((DataRowView)cDEUNITTYPESBindingSource.Current)["UNITDESC"] = frm.txtUintDesc.Text;
                    //DataRow row = nEWERPDataSet.CDE_UNIT_TYPES.NewRow();
                    //row["UNITDESC"] = frm.txtUintDesc.Text;
                    //nEWERPDataSet.CDE_UNIT_TYPES.Rows.Add(row);
                    cDEUNITTYPESBindingSource.EndEdit ();
                    cDE_UNIT_TYPESTableAdapter.Update(nEWERPDataSet.CDE_UNIT_TYPES);
                }
            }
        }

        private void BtnPic_Click(object sender, EventArgs e)
        {
            AddPic();
        }

        private void CmbProductType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (int.Parse (CmbProductType.SelectedValue.ToString ()) == int.Parse (GLibrary.strarrProductTypes[1, 0]))
            //{
            //    tabControlProduct.Visible = true;

            //}
            //else
            //{
            //    tabControlProduct.Visible = false ;
            //}
            EnbDisbControls(true);
        }

        private void dGridViewAssmp_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "AssProductName" || dgv.CurrentCell.OwningColumn.Name == "AssProductCode")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

            }
        }

        private void dGridViewAssmp_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewComboBoxCell dgcbProduct = (DataGridViewComboBoxCell)dGridViewAssmp["AssProductName", e.RowIndex];
            DataGridViewComboBoxCell dgcbProductCode = (DataGridViewComboBoxCell)dGridViewAssmp["AssProductCode", e.RowIndex];
            //string  dgcbBarCode = ProductsDGView["BarCode", e.RowIndex].FormattedValue.ToString ();

            if (dgv.Columns[e.ColumnIndex].Name == "AssProductName" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) // ⁄„Êœ «·’‰›
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];


                //productUnitsPricesBindingSource.RemoveFilter();
                int pos = pRODUCTSBindingSource1.Find("productname", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource1.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource1.Current)["PRODUCTID"].ToString());
                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();

                    // dgcbBarCode.Value = ProductId.ToString(); //


                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)dGridViewAssmp["AssUINTID", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                        //productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                        //if (productUnitsPricesBindingSource.Count > 0)
                        //{
                        //    //string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                        //    //string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                        //    //ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                        //    //ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                        //}
                        //productUnitsPricesBindingSource.RemoveFilter();
                    }
                 
                }
            }
                 // ProductCode
            if (dgv.Columns[e.ColumnIndex].Name == "AssProductCode" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];

                //productUnitsPricesBindingSource.RemoveFilter();
                int pos = pRODUCTSBindingSource1.Find("productCode", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource1.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource1.Current)["PRODUCTID"].ToString());

                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();
                    //dgcbBarCode.Value = ProductId.ToString(); 
                    
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)dGridViewAssmp["AssUINTID", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                        //productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                        //if (productUnitsPricesBindingSource.Count > 0)
                        //{
                        //    //string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                        //    //ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                        //    //string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                        //    //ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                        //}
                        //productUnitsPricesBindingSource.RemoveFilter();
                    }
                    this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
                  }

            }
        }
     
        private void dGridViewAssmp_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dGridViewAssmp.Rows[e.RowIndex].ErrorText = String.Empty;
        }


        private void dGridViewAssmp_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            CheckValiad(ref dGridViewAssmp, ref e);
        }

        private void dGrdViewPrice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dGrdViewPrice.Rows.Count > 0)
            {
                if (e.ColumnIndex == costmerPriceDataGridViewTextBoxColumn.Index)
                {
                    if (dGrdViewPrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        //if (GLibrary.IsNumeric(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        //{

                        //    GetPriceSum();
                        //    // txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).ToString();

                        //}
                        int i;
                        decimal MainPrice=0;
                       // if (dGrdViewPrice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value
                        for (i=0; i< dGrdViewPrice.Rows.Count ;i++)  //decimal.Parse(dGrdViewPrice.Rows[i].Cells["costmerPriceDataGridViewTextBoxColumn"].Value.ToString());
                        {
                            if (dGrdViewPrice.Rows[i].Cells["mainUnitDataGridViewCheckBoxColumn"].Value != null && dGrdViewPrice.Rows[i].Cells["mainUnitDataGridViewCheckBoxColumn"].Value !=DBNull.Value )
                            {
                                Boolean  unitBol = Boolean.Parse (dGrdViewPrice.Rows[i].Cells["mainUnitDataGridViewCheckBoxColumn"].Value.ToString ());
                                if (unitBol)
                                {
                                    MainPrice = decimal.Parse(dGrdViewPrice.Rows[i].Cells["costmerPriceDataGridViewTextBoxColumn"].Value.ToString());
                                }
                                else
                                {
                                    //dGrdViewPrice.Rows[i].Cells["costmerPriceDataGridViewTextBoxColumn"].Value = MainPrice * int.Parse(dGrdViewPrice.Rows[i].Cells["conFactorDataGridViewTextBoxColumn"].Value.ToString());
                                }

                            }
                            else
                            {
                                //dGrdViewPrice.Rows[i].Cells["costmerPriceDataGridViewTextBoxColumn"].Value = MainPrice * int.Parse(dGrdViewPrice.Rows[i].Cells["conFactorDataGridViewTextBoxColumn"].Value.ToString());
                            }
                        }
                        
                       
                        //ValuecostmerPriceDataGridViewTextBoxColumn
                    }

                }
            }
        }

        private void AddMainAccMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = false;
            MainAddNode = ProductstreeView.SelectedNode;

            AddNewAccount(MainAddNode, true);

            bFlag = true;
        }

        private void AddSubAccMenuItem_Click(object sender, EventArgs e)
        {
            bFlag = false;
            MainAddNode = ProductstreeView.SelectedNode;
            AddNewAccount(MainAddNode, false);
            bFlag = true;
        }

        private void TreeReFreshMenuItem_Click(object sender, EventArgs e)
        {
            LoadTreeData();
        }

        private void TreeOpenAllMItem_Click(object sender, EventArgs e)
        {
            ProductstreeView.ExpandAll();
        }

        private void AccountMoveMenuItem_Click(object sender, EventArgs e)
        {
            AccountMove frm = new AccountMove();

            if (ProductstreeView.SelectedNode != null)
            {
                frm.AccountId = long.Parse(txtProductId.Text);
                frm.OldParentAccountId = long.Parse(txtMainProductId.Text);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
                    LoadTreeData();
                }
                else
                {

                }
            }
        }

        private void ProductstreeView_MouseClick(object sender, MouseEventArgs e)
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

        private void ProductstreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
            ProductstreeView.SelectedNode = e.Node;
            ProductstreeView.Select();
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

        private void MainAccChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MainAccChkBox.Checked )
            {
                EnbDisbControls(false);
            }
            else
            {
                EnbDisbControls(true);
            }
        }

       

    

        private void UnitsdGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == MainUnit.Index)
            {
                if (Boolean.Parse(e.FormattedValue.ToString()))
                {
                    UnitsdGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Boolean.TrueString;
                }
                else
                {
                    UnitsdGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Boolean.FalseString;
                }
            }
        }

        private void dGrdViewPrice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void DelUnitMenuItem_Click(object sender, EventArgs e)
        {
            if (productUnitsPricesBindingSource.Count > 0)
            {
                int Unit= int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["UintId"].ToString());
                long ProductId= long.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["productid"].ToString());
                int count = int.Parse (this.inv_ProductsTableAdapter.FillCountProductID (ProductId).ToString ());
                if (count < 1)
                {
                    productUnitsPricesBindingSource.RemoveCurrent();
                    productUnitsPricesBindingSource.EndEdit();
                    product_Units_PricesTableAdapter.Update(this.nEWERPDataSet.Product_Units_Prices);
                }
                else
                {
                    MessageBox.Show("·« Ì„ﬂ‰ Õ–› Â–« «·’‰› ·«— »«ÿÂ »«»Ì«‰«  «Œ—Ì", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void pRODUCTSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            int i;
            i = 90;
        }

       
            

      

        
    }
}