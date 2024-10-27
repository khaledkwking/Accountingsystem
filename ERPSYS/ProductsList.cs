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
    public partial class ProductsList : DockContent
    {
        public string CurProductCode;
        public string CurProductName;
        public int CurProductId;
        public Boolean CurRoot;
        public ProductsList()
        {
            InitializeComponent();
        }

        private void ProductsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Category' table. You can move, or remove it, as needed.
            LoadData();
            
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //this.Hide();

        }
        private void LoadData()
        {
           
            AddMainNode();
            if (ProductstreeView.Nodes.Count > 0)
            {
                ProductstreeView.Nodes[0].Expand();
            }
        
             
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
               
                Node.ImageIndex = 0;

                Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
                ProductstreeView.Nodes.Add(Node);
                if (bRoot)
                {
                    AddItem(Node);
                }

            }

        }
        //private void AddMainNode()
        //{
        //    TreeNode RootNode = new TreeNode();
        //    ProductstreeView.Nodes.Add(RootNode);
        //    pRODUCTSBindingSource.Filter = "ParentProductId = 0" + " and root=1 ";
        //    System.Data.DataView list = new System.Data.DataView();
        //    list = (DataView)pRODUCTSBindingSource.List;
        //    DataTable T = list.ToTable();
        //    pRODUCTSBindingSource.RemoveFilter();
        //    for (int i = 0; i < T.Rows.Count; i++)
        //    {
        //        Boolean bRoot = (Boolean)T.Rows[i]["root"];
        //        TreeNode Node = new TreeNode();
        //        Node.Text = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
        //        Node.Name = T.Rows[i]["productID"].ToString();
        //        Node.Tag = (Int64)T.Rows[i]["PRODUCTID"];

        //        Node.ImageIndex = 0;
        //        Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
        //        RootNode.Nodes.Add(Node);
        //        if (bRoot)
        //        {
        //            AddItem(Node);
        //        }

        //    }

        //}
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
        //        Node.ImageIndex = 1;
        //        Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];
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

             
                Node.ToolTipText = T.Rows[i]["productCode"].ToString() + " / " + (string)T.Rows[i]["productname"];

                ParentNode.Nodes.Add(Node);
                Boolean ProcessFlag = false;
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
        private void TreeSearch()
        {
            //int Pos=pRODUCTSBindingSource.Find("ProductName",txtSearch );
            //Int64 ProductId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductId"];
            //int CatId = (int)nEWERPDataSet.PRODUCTS.Rows[Pos]["CATEGORYID"];
            //Int64 ParentId = (Int64)nEWERPDataSet.PRODUCTS.Rows[Pos]["ParentProductId"];
            string strSearch = "";
            int Pos = pRODUCTSBindingSource.Find("ProductName", txtSearch.Text);
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
                    SearchNodes[0].Expand();
                    ProductstreeView.SelectedNode = SearchNodes[0];
                    ProductstreeView.Select();
                }
            }
            //TreeNode[] SearchNodes = ProductstreeView.Nodes.Find(txtSearch.Text, true);

        }
    

       

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter )
            {
                TreeSearch();
            }
        }

        private void ProductstreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            ProductstreeView.SelectedNode =e.Node;
            ProductstreeView.Select();
        }

        private void ProductstreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            ProductstreeView.SelectedNode = e.Node;
            ProductstreeView.Select();
        }

        private void ProductstreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level > -1)
            {
                CurProductId = int.Parse(e.Node.Tag.ToString());
                int Pos = pRODUCTSBindingSource.Find("ProductId", CurProductId);
                pRODUCTSBindingSource.Position = Pos;
                CurProductName = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductName"].ToString();
                CurProductCode = nEWERPDataSet.PRODUCTS.Rows[Pos]["ProductCode"].ToString();
                if (nEWERPDataSet.PRODUCTS.Rows[Pos]["MainNode"] != System.DBNull.Value)
                {
                    CurRoot = (Boolean)nEWERPDataSet.PRODUCTS.Rows[Pos]["MainNode"];
                }
                else
                {
                    CurRoot = false;
                }

            }
            else
            {
                CurProductId = -1;
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
              this.DialogResult = System.Windows .Forms .DialogResult .OK ;
              //this.Close();
        }
          
    }
}