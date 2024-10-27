namespace ERPSYS
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ToolStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripLabelDay = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatuslblAdv = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLblBranch = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.nEWERPDataSet = new ERPSYS.NEWERPDataSet();
            this.setupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter();
            this.setupCodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setupCodesTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter();
            this.fUNCTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fUNCTIONSTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.FUNCTIONSTableAdapter();
            this.uSERFUNCTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSER_FUNCTIONTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.USER_FUNCTIONTableAdapter();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter();
            this.FileMItem = new System.Windows.Forms.RibbonTab();
            this.AccountribbonPanel = new System.Windows.Forms.RibbonPanel();
            this.BranchCardMItem = new System.Windows.Forms.RibbonButton();
            this.AccCardMItem = new System.Windows.Forms.RibbonButton();
            this.CurrencyMenuItem = new System.Windows.Forms.RibbonButton();
            this.InventoryribbonPanel = new System.Windows.Forms.RibbonPanel();
            this.CustSupCardMItem = new System.Windows.Forms.RibbonButton();
            this.StorCardMItem = new System.Windows.Forms.RibbonButton();
            this.SalManCardMItem = new System.Windows.Forms.RibbonButton();
            this.ProductCardMItem = new System.Windows.Forms.RibbonButton();
            this.CostCenterribbonPanel = new System.Windows.Forms.RibbonPanel();
            this.CostCardMItem = new System.Windows.Forms.RibbonButton();
            this.UserribbonPane = new System.Windows.Forms.RibbonPanel();
            this.ExitBtn = new System.Windows.Forms.RibbonButton();
            this.ChangePassMItem = new System.Windows.Forms.RibbonButton();
            this.ChangeBackMItem = new System.Windows.Forms.RibbonButton();
            this.ReLoginMItem = new System.Windows.Forms.RibbonButton();
            this.AccountsMItem = new System.Windows.Forms.RibbonTab();
            this.AccountribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.QidListMenuItem = new System.Windows.Forms.RibbonButton();
            this.InQidMItem = new System.Windows.Forms.RibbonButton();
            this.OutQidMItem = new System.Windows.Forms.RibbonButton();
            this.QidMenuItemPublic = new System.Windows.Forms.RibbonButton();
            this.QidMenuItemStart = new System.Windows.Forms.RibbonButton();
            this.AcounttreeMenuItem = new System.Windows.Forms.RibbonButton();
            this.StoresMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.LinkStoreMItem = new System.Windows.Forms.RibbonButton();
            this.UintsMenuItem = new System.Windows.Forms.RibbonButton();
            this.ListProductMenuItem = new System.Windows.Forms.RibbonButton();
            this.ProductTreeMenuItem = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.InventoryCalMenuItem = new System.Windows.Forms.RibbonButton();
            this.OrderOutMenuItem = new System.Windows.Forms.RibbonButton();
            this.OutOrderMenuItem = new System.Windows.Forms.RibbonButton();
            this.SearchMovementMenuItem = new System.Windows.Forms.RibbonButton();
            this.StoreOrderMenuItem = new System.Windows.Forms.RibbonButton();
            this.PartionListMenuItem = new System.Windows.Forms.RibbonButton();
            this.CalBtn = new System.Windows.Forms.RibbonButton();
            this.SalesMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.CustMoveMenuItem = new System.Windows.Forms.RibbonButton();
            this.CustomerMenuItem = new System.Windows.Forms.RibbonButton();
            this.HomeCustBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.DailySaltoolButton = new System.Windows.Forms.RibbonButton();
            this.ReoderListMenuItem = new System.Windows.Forms.RibbonButton();
            this.ReodersAddMenuItem = new System.Windows.Forms.RibbonButton();
            this.SearchSalInvMnuItem = new System.Windows.Forms.RibbonButton();
            this.InvPaymentMItem = new System.Windows.Forms.RibbonButton();
            this.ReorderInvSalMItem = new System.Windows.Forms.RibbonButton();
            this.ReorderInvSalAllMItem = new System.Windows.Forms.RibbonButton();
            this.InvSalesMItem = new System.Windows.Forms.RibbonButton();
            this.PriceListMenuItem = new System.Windows.Forms.RibbonButton();
            this.PurchasesMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.SuppliersMenuItem = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.InvPurchasesMItem = new System.Windows.Forms.RibbonButton();
            this.GetOrderMenuItem = new System.Windows.Forms.RibbonButton();
            this.InvOutMenuItem = new System.Windows.Forms.RibbonButton();
            this.SearchPurInvMnuItem = new System.Windows.Forms.RibbonButton();
            this.InvPurReturnMenuItem = new System.Windows.Forms.RibbonButton();
            this.ReorderInvPurMItem = new System.Windows.Forms.RibbonButton();
            this.HRMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel9 = new System.Windows.Forms.RibbonPanel();
            this.HRCards = new System.Windows.Forms.RibbonButton();
            this.NatMenuItem = new System.Windows.Forms.RibbonButton();
            this.PENALTYMenuItem = new System.Windows.Forms.RibbonButton();
            this.VacationMenuItem = new System.Windows.Forms.RibbonButton();
            this.DeptMenuItem = new System.Windows.Forms.RibbonButton();
            this.GroupsMnuItem = new System.Windows.Forms.RibbonButton();
            this.EmpExpiredenuItem = new System.Windows.Forms.RibbonButton();
            this.EmpPayrollMenuItem = new System.Windows.Forms.RibbonButton();
            this.EmpListMenuItem = new System.Windows.Forms.RibbonButton();
            this.EmpDataMnuItem = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel11 = new System.Windows.Forms.RibbonPanel();
            this.EmpRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.LoanRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.ABSENCERptMenuItem = new System.Windows.Forms.RibbonButton();
            this.SalaryEmpRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.DiscountRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.AllowancesRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.VactionRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel10 = new System.Windows.Forms.RibbonPanel();
            this.AttToolStripMenuItem = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton59 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton58 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton57 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton60 = new System.Windows.Forms.RibbonButton();
            this.AccRptMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel12 = new System.Windows.Forms.RibbonPanel();
            this.BalanceClosedMenuItem = new System.Windows.Forms.RibbonButton();
            this.IncomeListMenuItem = new System.Windows.Forms.RibbonButton();
            this.RefBalanceVerMenuItem = new System.Windows.Forms.RibbonButton();
            this.BalanceBtn = new System.Windows.Forms.RibbonButton();
            this.TotalAmountBtn = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel13 = new System.Windows.Forms.RibbonPanel();
            this.CustomerMoveMItem = new System.Windows.Forms.RibbonButton();
            this.AcctSumWithDanMItem = new System.Windows.Forms.RibbonButton();
            this.AccountSumProductsMenuItem = new System.Windows.Forms.RibbonButton();
            this.CustAcctSumMenuItem = new System.Windows.Forms.RibbonButton();
            this.AccountSumDetMItemRpt = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel14 = new System.Windows.Forms.RibbonPanel();
            this.QidsReportsMenuItemNew = new System.Windows.Forms.RibbonButton();
            this.InQidsMItemRpt = new System.Windows.Forms.RibbonButton();
            this.OutQidsMItemRpt = new System.Windows.Forms.RibbonButton();
            this.QidsMItemRpt = new System.Windows.Forms.RibbonButton();
            this.StoresRptMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.PcollecttoolMenuItem = new System.Windows.Forms.RibbonButton();
            this.PcollecttoolMenuItemNew = new System.Windows.Forms.RibbonButton();
            this.DailySalesMenuItemNew = new System.Windows.Forms.RibbonButton();
            this.ProductProfitRptMenuItemNew = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel15 = new System.Windows.Forms.RibbonPanel();
            this.LifeLoansMenuItem = new System.Windows.Forms.RibbonButton();
            this.A3marDauanMonthMItem = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.A3marDauanPeriodMItem = new System.Windows.Forms.RibbonButton();
            this.OtherReport = new System.Windows.Forms.RibbonButton();
            this.DailySalesMenuItem = new System.Windows.Forms.RibbonButton();
            this.CustomerAccountsMenuItem = new System.Windows.Forms.RibbonButton();
            this.supplierAccountsMenuItem = new System.Windows.Forms.RibbonButton();
            this.ProductsAndStoresMenuItem = new System.Windows.Forms.RibbonButton();
            this.CitiesSalesMenuItem = new System.Windows.Forms.RibbonButton();
            this.SaleProductMItem = new System.Windows.Forms.RibbonButton();
            this.PurchaseProductMItem = new System.Windows.Forms.RibbonButton();
            this.CustomersSalesMItem = new System.Windows.Forms.RibbonButton();
            this.PMovetoolMenuItem = new System.Windows.Forms.RibbonButton();
            this.InvoicesRefButton = new System.Windows.Forms.RibbonButton();
            this.ProductProfitRptMenuItem = new System.Windows.Forms.RibbonButton();
            this.StoresAnyMenuItem = new System.Windows.Forms.RibbonButton();
            this.PMoveButton = new System.Windows.Forms.RibbonButton();
            this.ToolsMItem = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel16 = new System.Windows.Forms.RibbonPanel();
            this.OpenAccYearMItem = new System.Windows.Forms.RibbonButton();
            this.ChangeLangMenuItem = new System.Windows.Forms.RibbonButton();
            this.ArabLangMenuItem = new System.Windows.Forms.RibbonButton();
            this.EngLangMenuItem = new System.Windows.Forms.RibbonButton();
            this.CloseAccYearMItem = new System.Windows.Forms.RibbonButton();
            this.UserSecMenuItem = new System.Windows.Forms.RibbonButton();
            this.SetupMenuItem = new System.Windows.Forms.RibbonButton();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.DockPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HRMItemNew = new System.Windows.Forms.Ribbon();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERFUNCTIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ToolStatusLabelUser
            // 
            resources.ApplyResources(this.ToolStatusLabelUser, "ToolStatusLabelUser");
            this.ToolStatusLabelUser.ForeColor = System.Drawing.Color.White;
            this.ToolStatusLabelUser.Name = "ToolStatusLabelUser";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStatusLabelUser,
            this.ToolStripStatusDate,
            this.ToolStripLabelDay,
            this.ToolStripStatuslblAdv,
            this.StatusLblBranch,
            this.toolStripStatusLabel2});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // ToolStripStatusDate
            // 
            resources.ApplyResources(this.ToolStripStatusDate, "ToolStripStatusDate");
            this.ToolStripStatusDate.Name = "ToolStripStatusDate";
            // 
            // ToolStripLabelDay
            // 
            resources.ApplyResources(this.ToolStripLabelDay, "ToolStripLabelDay");
            this.ToolStripLabelDay.Name = "ToolStripLabelDay";
            // 
            // ToolStripStatuslblAdv
            // 
            resources.ApplyResources(this.ToolStripStatuslblAdv, "ToolStripStatuslblAdv");
            this.ToolStripStatuslblAdv.Name = "ToolStripStatuslblAdv";
            // 
            // StatusLblBranch
            // 
            resources.ApplyResources(this.StatusLblBranch, "StatusLblBranch");
            this.StatusLblBranch.ForeColor = System.Drawing.Color.Blue;
            this.StatusLblBranch.Name = "StatusLblBranch";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // nEWERPDataSet
            // 
            this.nEWERPDataSet.DataSetName = "NEWERPDataSet";
            this.nEWERPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setupBindingSource
            // 
            this.setupBindingSource.DataMember = "setup";
            this.setupBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupTableAdapter
            // 
            this.setupTableAdapter.ClearBeforeFill = true;
            // 
            // setupCodesBindingSource
            // 
            this.setupCodesBindingSource.DataMember = "SetupCodes";
            this.setupCodesBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // setupCodesTableAdapter
            // 
            this.setupCodesTableAdapter.ClearBeforeFill = true;
            // 
            // fUNCTIONSBindingSource
            // 
            this.fUNCTIONSBindingSource.DataMember = "FUNCTIONS";
            this.fUNCTIONSBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // fUNCTIONSTableAdapter
            // 
            this.fUNCTIONSTableAdapter.ClearBeforeFill = true;
            // 
            // uSERFUNCTIONBindingSource
            // 
            this.uSERFUNCTIONBindingSource.DataMember = "USER_FUNCTION";
            this.uSERFUNCTIONBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // uSER_FUNCTIONTableAdapter
            // 
            this.uSER_FUNCTIONTableAdapter.ClearBeforeFill = true;
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER";
            this.uSERBindingSource.DataSource = this.nEWERPDataSet;
            // 
            // uSERTableAdapter
            // 
            this.uSERTableAdapter.ClearBeforeFill = true;
            // 
            // FileMItem
            // 
            this.FileMItem.Panels.Add(this.AccountribbonPanel);
            this.FileMItem.Panels.Add(this.InventoryribbonPanel);
            this.FileMItem.Panels.Add(this.CostCenterribbonPanel);
            this.FileMItem.Panels.Add(this.UserribbonPane);
            resources.ApplyResources(this.FileMItem, "FileMItem");
            // 
            // AccountribbonPanel
            // 
            this.AccountribbonPanel.Items.Add(this.BranchCardMItem);
            this.AccountribbonPanel.Items.Add(this.AccCardMItem);
            this.AccountribbonPanel.Items.Add(this.CurrencyMenuItem);
            resources.ApplyResources(this.AccountribbonPanel, "AccountribbonPanel");
            // 
            // BranchCardMItem
            // 
            this.BranchCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("BranchCardMItem.Image")));
            this.BranchCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("BranchCardMItem.SmallImage")));
            resources.ApplyResources(this.BranchCardMItem, "BranchCardMItem");
            this.BranchCardMItem.Click += new System.EventHandler(this.BranchCardMItem_Click);
            // 
            // AccCardMItem
            // 
            this.AccCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("AccCardMItem.Image")));
            this.AccCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AccCardMItem.SmallImage")));
            resources.ApplyResources(this.AccCardMItem, "AccCardMItem");
            this.AccCardMItem.Click += new System.EventHandler(this.AccountTreeMenuItem_Click);
            // 
            // CurrencyMenuItem
            // 
            this.CurrencyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyMenuItem.Image")));
            this.CurrencyMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CurrencyMenuItem.SmallImage")));
            resources.ApplyResources(this.CurrencyMenuItem, "CurrencyMenuItem");
            this.CurrencyMenuItem.Visible = false;
            this.CurrencyMenuItem.Click += new System.EventHandler(this.CurrencyMenuItem_Click);
            // 
            // InventoryribbonPanel
            // 
            this.InventoryribbonPanel.Items.Add(this.CustSupCardMItem);
            this.InventoryribbonPanel.Items.Add(this.StorCardMItem);
            this.InventoryribbonPanel.Items.Add(this.SalManCardMItem);
            this.InventoryribbonPanel.Items.Add(this.ProductCardMItem);
            resources.ApplyResources(this.InventoryribbonPanel, "InventoryribbonPanel");
            // 
            // CustSupCardMItem
            // 
            this.CustSupCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("CustSupCardMItem.Image")));
            this.CustSupCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustSupCardMItem.SmallImage")));
            resources.ApplyResources(this.CustSupCardMItem, "CustSupCardMItem");
            this.CustSupCardMItem.Click += new System.EventHandler(this.CustSupCardMItem_Click);
            // 
            // StorCardMItem
            // 
            this.StorCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("StorCardMItem.Image")));
            this.StorCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("StorCardMItem.SmallImage")));
            resources.ApplyResources(this.StorCardMItem, "StorCardMItem");
            this.StorCardMItem.Click += new System.EventHandler(this.toolStroesMenuItem1_Click);
            // 
            // SalManCardMItem
            // 
            this.SalManCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("SalManCardMItem.Image")));
            this.SalManCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SalManCardMItem.SmallImage")));
            resources.ApplyResources(this.SalManCardMItem, "SalManCardMItem");
            this.SalManCardMItem.Click += new System.EventHandler(this.SalManCardMItem_Click);
            // 
            // ProductCardMItem
            // 
            this.ProductCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductCardMItem.Image")));
            this.ProductCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProductCardMItem.SmallImage")));
            resources.ApplyResources(this.ProductCardMItem, "ProductCardMItem");
            this.ProductCardMItem.Click += new System.EventHandler(this.AddProductToolMenuItem_Click);
            // 
            // CostCenterribbonPanel
            // 
            this.CostCenterribbonPanel.Items.Add(this.CostCardMItem);
            resources.ApplyResources(this.CostCenterribbonPanel, "CostCenterribbonPanel");
            // 
            // CostCardMItem
            // 
            this.CostCardMItem.Image = ((System.Drawing.Image)(resources.GetObject("CostCardMItem.Image")));
            this.CostCardMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CostCardMItem.SmallImage")));
            resources.ApplyResources(this.CostCardMItem, "CostCardMItem");
            this.CostCardMItem.Click += new System.EventHandler(this.CostCenterTreeMenuItem_Click);
            // 
            // UserribbonPane
            // 
            this.UserribbonPane.Items.Add(this.ExitBtn);
            this.UserribbonPane.Items.Add(this.ChangePassMItem);
            this.UserribbonPane.Items.Add(this.ChangeBackMItem);
            this.UserribbonPane.Items.Add(this.ReLoginMItem);
            resources.ApplyResources(this.UserribbonPane, "UserribbonPane");
            // 
            // ExitBtn
            // 
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.SmallImage")));
            resources.ApplyResources(this.ExitBtn, "ExitBtn");
            this.ExitBtn.Click += new System.EventHandler(this.ÎÑæÌToolStripMenuItem1_Click);
            // 
            // ChangePassMItem
            // 
            this.ChangePassMItem.Image = ((System.Drawing.Image)(resources.GetObject("ChangePassMItem.Image")));
            this.ChangePassMItem.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ChangePassMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ChangePassMItem.SmallImage")));
            resources.ApplyResources(this.ChangePassMItem, "ChangePassMItem");
            this.ChangePassMItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ChangePassMItem.Click += new System.EventHandler(this.ChangeMItem_Click);
            // 
            // ChangeBackMItem
            // 
            this.ChangeBackMItem.Image = ((System.Drawing.Image)(resources.GetObject("ChangeBackMItem.Image")));
            this.ChangeBackMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ChangeBackMItem.SmallImage")));
            resources.ApplyResources(this.ChangeBackMItem, "ChangeBackMItem");
            this.ChangeBackMItem.Click += new System.EventHandler(this.ChangeBackMenuItem_Click);
            // 
            // ReLoginMItem
            // 
            this.ReLoginMItem.Image = ((System.Drawing.Image)(resources.GetObject("ReLoginMItem.Image")));
            this.ReLoginMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReLoginMItem.SmallImage")));
            resources.ApplyResources(this.ReLoginMItem, "ReLoginMItem");
            this.ReLoginMItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.ReLoginMItem.Click += new System.EventHandler(this.ReLoginMItem_Click);
            // 
            // AccountsMItem
            // 
            this.AccountsMItem.Panels.Add(this.AccountribbonPanel3);
            resources.ApplyResources(this.AccountsMItem, "AccountsMItem");
            // 
            // AccountribbonPanel3
            // 
            this.AccountribbonPanel3.Items.Add(this.QidListMenuItem);
            this.AccountribbonPanel3.Items.Add(this.InQidMItem);
            this.AccountribbonPanel3.Items.Add(this.OutQidMItem);
            this.AccountribbonPanel3.Items.Add(this.QidMenuItemPublic);
            this.AccountribbonPanel3.Items.Add(this.QidMenuItemStart);
            this.AccountribbonPanel3.Items.Add(this.AcounttreeMenuItem);
            resources.ApplyResources(this.AccountribbonPanel3, "AccountribbonPanel3");
            // 
            // QidListMenuItem
            // 
            this.QidListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("QidListMenuItem.Image")));
            this.QidListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("QidListMenuItem.SmallImage")));
            resources.ApplyResources(this.QidListMenuItem, "QidListMenuItem");
            this.QidListMenuItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.QidListMenuItem.Click += new System.EventHandler(this.QidListMenuItem_Click);
            // 
            // InQidMItem
            // 
            this.InQidMItem.Image = ((System.Drawing.Image)(resources.GetObject("InQidMItem.Image")));
            this.InQidMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InQidMItem.SmallImage")));
            resources.ApplyResources(this.InQidMItem, "InQidMItem");
            this.InQidMItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.InQidMItem.Click += new System.EventHandler(this.InQidMenuItem_Click);
            // 
            // OutQidMItem
            // 
            this.OutQidMItem.Image = ((System.Drawing.Image)(resources.GetObject("OutQidMItem.Image")));
            this.OutQidMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("OutQidMItem.SmallImage")));
            resources.ApplyResources(this.OutQidMItem, "OutQidMItem");
            this.OutQidMItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.OutQidMItem.Click += new System.EventHandler(this.OutQidMenuItem_Click);
            // 
            // QidMenuItemPublic
            // 
            this.QidMenuItemPublic.Image = ((System.Drawing.Image)(resources.GetObject("QidMenuItemPublic.Image")));
            this.QidMenuItemPublic.SmallImage = ((System.Drawing.Image)(resources.GetObject("QidMenuItemPublic.SmallImage")));
            resources.ApplyResources(this.QidMenuItemPublic, "QidMenuItemPublic");
            this.QidMenuItemPublic.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.QidMenuItemPublic.Click += new System.EventHandler(this.QidMenuItem_Click);
            // 
            // QidMenuItemStart
            // 
            this.QidMenuItemStart.Image = ((System.Drawing.Image)(resources.GetObject("QidMenuItemStart.Image")));
            this.QidMenuItemStart.SmallImage = ((System.Drawing.Image)(resources.GetObject("QidMenuItemStart.SmallImage")));
            resources.ApplyResources(this.QidMenuItemStart, "QidMenuItemStart");
            this.QidMenuItemStart.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.QidMenuItemStart.Click += new System.EventHandler(this.QidMenuItemStart_Click);
            // 
            // AcounttreeMenuItem
            // 
            this.AcounttreeMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AcounttreeMenuItem.Image")));
            this.AcounttreeMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AcounttreeMenuItem.SmallImage")));
            resources.ApplyResources(this.AcounttreeMenuItem, "AcounttreeMenuItem");
            this.AcounttreeMenuItem.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.AcounttreeMenuItem.Click += new System.EventHandler(this.AcounttingMenuItem_Click);
            // 
            // StoresMItem
            // 
            this.StoresMItem.Panels.Add(this.ribbonPanel3);
            this.StoresMItem.Panels.Add(this.ribbonPanel1);
            resources.ApplyResources(this.StoresMItem, "StoresMItem");
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.LinkStoreMItem);
            this.ribbonPanel3.Items.Add(this.UintsMenuItem);
            this.ribbonPanel3.Items.Add(this.ListProductMenuItem);
            this.ribbonPanel3.Items.Add(this.ProductTreeMenuItem);
            resources.ApplyResources(this.ribbonPanel3, "ribbonPanel3");
            // 
            // LinkStoreMItem
            // 
            this.LinkStoreMItem.Image = ((System.Drawing.Image)(resources.GetObject("LinkStoreMItem.Image")));
            this.LinkStoreMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("LinkStoreMItem.SmallImage")));
            resources.ApplyResources(this.LinkStoreMItem, "LinkStoreMItem");
            this.LinkStoreMItem.Click += new System.EventHandler(this.ToolLinkStoreMenuItem_Click);
            // 
            // UintsMenuItem
            // 
            this.UintsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UintsMenuItem.Image")));
            this.UintsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("UintsMenuItem.SmallImage")));
            this.UintsMenuItem.Tag = "";
            resources.ApplyResources(this.UintsMenuItem, "UintsMenuItem");
            this.UintsMenuItem.Click += new System.EventHandler(this.UintsMenuItem_Click);
            // 
            // ListProductMenuItem
            // 
            this.ListProductMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ListProductMenuItem.Image")));
            this.ListProductMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ListProductMenuItem.SmallImage")));
            this.ListProductMenuItem.Tag = "";
            resources.ApplyResources(this.ListProductMenuItem, "ListProductMenuItem");
            this.ListProductMenuItem.Click += new System.EventHandler(this.StockProductMenuItem_Click);
            // 
            // ProductTreeMenuItem
            // 
            this.ProductTreeMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductTreeMenuItem.Image")));
            this.ProductTreeMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProductTreeMenuItem.SmallImage")));
            resources.ApplyResources(this.ProductTreeMenuItem, "ProductTreeMenuItem");
            this.ProductTreeMenuItem.Click += new System.EventHandler(this.ListPProductToolMenuItem_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.InventoryCalMenuItem);
            this.ribbonPanel1.Items.Add(this.OrderOutMenuItem);
            this.ribbonPanel1.Items.Add(this.OutOrderMenuItem);
            this.ribbonPanel1.Items.Add(this.SearchMovementMenuItem);
            this.ribbonPanel1.Items.Add(this.StoreOrderMenuItem);
            this.ribbonPanel1.Items.Add(this.PartionListMenuItem);
            this.ribbonPanel1.Items.Add(this.CalBtn);
            resources.ApplyResources(this.ribbonPanel1, "ribbonPanel1");
            // 
            // InventoryCalMenuItem
            // 
            this.InventoryCalMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InventoryCalMenuItem.Image")));
            this.InventoryCalMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InventoryCalMenuItem.SmallImage")));
            resources.ApplyResources(this.InventoryCalMenuItem, "InventoryCalMenuItem");
            this.InventoryCalMenuItem.Click += new System.EventHandler(this.InventoryCalMenuItem_Click);
            // 
            // OrderOutMenuItem
            // 
            this.OrderOutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OrderOutMenuItem.Image")));
            this.OrderOutMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("OrderOutMenuItem.SmallImage")));
            this.OrderOutMenuItem.Tag = "";
            resources.ApplyResources(this.OrderOutMenuItem, "OrderOutMenuItem");
            this.OrderOutMenuItem.Click += new System.EventHandler(this.OrderOutMenuItem_Click);
            // 
            // OutOrderMenuItem
            // 
            this.OutOrderMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OutOrderMenuItem.Image")));
            this.OutOrderMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("OutOrderMenuItem.SmallImage")));
            resources.ApplyResources(this.OutOrderMenuItem, "OutOrderMenuItem");
            this.OutOrderMenuItem.Click += new System.EventHandler(this.OutOrderMenuItem_Click);
            // 
            // SearchMovementMenuItem
            // 
            this.SearchMovementMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchMovementMenuItem.Image")));
            this.SearchMovementMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SearchMovementMenuItem.SmallImage")));
            resources.ApplyResources(this.SearchMovementMenuItem, "SearchMovementMenuItem");
            this.SearchMovementMenuItem.Click += new System.EventHandler(this.SearchMovementMenuItem_Click);
            // 
            // StoreOrderMenuItem
            // 
            this.StoreOrderMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StoreOrderMenuItem.Image")));
            this.StoreOrderMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("StoreOrderMenuItem.SmallImage")));
            resources.ApplyResources(this.StoreOrderMenuItem, "StoreOrderMenuItem");
            this.StoreOrderMenuItem.Click += new System.EventHandler(this.StoreOrderMenuItem_Click);
            // 
            // PartionListMenuItem
            // 
            this.PartionListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PartionListMenuItem.Image")));
            this.PartionListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PartionListMenuItem.SmallImage")));
            resources.ApplyResources(this.PartionListMenuItem, "PartionListMenuItem");
            this.PartionListMenuItem.Visible = false;
            this.PartionListMenuItem.Click += new System.EventHandler(this.PartionListMenuItem_Click);
            // 
            // CalBtn
            // 
            this.CalBtn.Image = ((System.Drawing.Image)(resources.GetObject("CalBtn.Image")));
            this.CalBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("CalBtn.SmallImage")));
            resources.ApplyResources(this.CalBtn, "CalBtn");
            this.CalBtn.Click += new System.EventHandler(this.ToolStripButtonCal_Click);
            // 
            // SalesMItem
            // 
            this.SalesMItem.Panels.Add(this.ribbonPanel4);
            this.SalesMItem.Panels.Add(this.ribbonPanel5);
            resources.ApplyResources(this.SalesMItem, "SalesMItem");
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Items.Add(this.CustMoveMenuItem);
            this.ribbonPanel4.Items.Add(this.CustomerMenuItem);
            this.ribbonPanel4.Items.Add(this.HomeCustBtn);
            resources.ApplyResources(this.ribbonPanel4, "ribbonPanel4");
            // 
            // CustMoveMenuItem
            // 
            this.CustMoveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CustMoveMenuItem.Image")));
            this.CustMoveMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustMoveMenuItem.SmallImage")));
            resources.ApplyResources(this.CustMoveMenuItem, "CustMoveMenuItem");
            this.CustMoveMenuItem.Click += new System.EventHandler(this.CustMoveMenuItem_Click);
            // 
            // CustomerMenuItem
            // 
            this.CustomerMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CustomerMenuItem.Image")));
            this.CustomerMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustomerMenuItem.SmallImage")));
            resources.ApplyResources(this.CustomerMenuItem, "CustomerMenuItem");
            this.CustomerMenuItem.Click += new System.EventHandler(this.CustomerToolMenuItem_Click);
            // 
            // HomeCustBtn
            // 
            this.HomeCustBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeCustBtn.Image")));
            this.HomeCustBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("HomeCustBtn.SmallImage")));
            resources.ApplyResources(this.HomeCustBtn, "HomeCustBtn");
            this.HomeCustBtn.Click += new System.EventHandler(this.HomeCustBtn_Click);
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Items.Add(this.DailySaltoolButton);
            this.ribbonPanel5.Items.Add(this.ReoderListMenuItem);
            this.ribbonPanel5.Items.Add(this.ReodersAddMenuItem);
            this.ribbonPanel5.Items.Add(this.SearchSalInvMnuItem);
            this.ribbonPanel5.Items.Add(this.InvPaymentMItem);
            this.ribbonPanel5.Items.Add(this.ReorderInvSalMItem);
            this.ribbonPanel5.Items.Add(this.ReorderInvSalAllMItem);
            this.ribbonPanel5.Items.Add(this.InvSalesMItem);
            this.ribbonPanel5.Items.Add(this.PriceListMenuItem);
            resources.ApplyResources(this.ribbonPanel5, "ribbonPanel5");
            // 
            // DailySaltoolButton
            // 
            this.DailySaltoolButton.Image = ((System.Drawing.Image)(resources.GetObject("DailySaltoolButton.Image")));
            this.DailySaltoolButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("DailySaltoolButton.SmallImage")));
            resources.ApplyResources(this.DailySaltoolButton, "DailySaltoolButton");
            this.DailySaltoolButton.Click += new System.EventHandler(this.DailySaltoolButton_Click);
            // 
            // ReoderListMenuItem
            // 
            this.ReoderListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReoderListMenuItem.Image")));
            this.ReoderListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReoderListMenuItem.SmallImage")));
            resources.ApplyResources(this.ReoderListMenuItem, "ReoderListMenuItem");
            this.ReoderListMenuItem.Visible = false;
            this.ReoderListMenuItem.Click += new System.EventHandler(this.ReoderListMenuItem_Click);
            // 
            // ReodersAddMenuItem
            // 
            this.ReodersAddMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ReodersAddMenuItem.Image")));
            this.ReodersAddMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReodersAddMenuItem.SmallImage")));
            resources.ApplyResources(this.ReodersAddMenuItem, "ReodersAddMenuItem");
            this.ReodersAddMenuItem.Visible = false;
            this.ReodersAddMenuItem.Click += new System.EventHandler(this.ReodersAddMenuItem_Click);
            // 
            // SearchSalInvMnuItem
            // 
            this.SearchSalInvMnuItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchSalInvMnuItem.Image")));
            this.SearchSalInvMnuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SearchSalInvMnuItem.SmallImage")));
            resources.ApplyResources(this.SearchSalInvMnuItem, "SearchSalInvMnuItem");
            this.SearchSalInvMnuItem.Click += new System.EventHandler(this.SearchSalInvMnuItem_Click);
            // 
            // InvPaymentMItem
            // 
            this.InvPaymentMItem.Image = ((System.Drawing.Image)(resources.GetObject("InvPaymentMItem.Image")));
            this.InvPaymentMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvPaymentMItem.SmallImage")));
            resources.ApplyResources(this.InvPaymentMItem, "InvPaymentMItem");
            this.InvPaymentMItem.Click += new System.EventHandler(this.InvPaymentMItem_Click);
            // 
            // ReorderInvSalMItem
            // 
            this.ReorderInvSalMItem.Image = ((System.Drawing.Image)(resources.GetObject("ReorderInvSalMItem.Image")));
            this.ReorderInvSalMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReorderInvSalMItem.SmallImage")));
            resources.ApplyResources(this.ReorderInvSalMItem, "ReorderInvSalMItem");
            this.ReorderInvSalMItem.Visible = false;
            this.ReorderInvSalMItem.Click += new System.EventHandler(this.ReorderInvSalMenuItem_Click);
            // 
            // ReorderInvSalAllMItem
            // 
            this.ReorderInvSalAllMItem.Image = global::ERPSYS.Properties.Resources._38;
            this.ReorderInvSalAllMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReorderInvSalAllMItem.SmallImage")));
            resources.ApplyResources(this.ReorderInvSalAllMItem, "ReorderInvSalAllMItem");
            this.ReorderInvSalAllMItem.Click += new System.EventHandler(this.ReorderInvSalAllMItem_Click);
            // 
            // InvSalesMItem
            // 
            this.InvSalesMItem.Image = ((System.Drawing.Image)(resources.GetObject("InvSalesMItem.Image")));
            this.InvSalesMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvSalesMItem.SmallImage")));
            resources.ApplyResources(this.InvSalesMItem, "InvSalesMItem");
            this.InvSalesMItem.Click += new System.EventHandler(this.InvSalesMenuItem_Click);
            // 
            // PriceListMenuItem
            // 
            this.PriceListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PriceListMenuItem.Image")));
            this.PriceListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PriceListMenuItem.SmallImage")));
            resources.ApplyResources(this.PriceListMenuItem, "PriceListMenuItem");
            this.PriceListMenuItem.Click += new System.EventHandler(this.PriceListMenuItem_Click);
            // 
            // PurchasesMItem
            // 
            this.PurchasesMItem.Panels.Add(this.ribbonPanel7);
            this.PurchasesMItem.Panels.Add(this.ribbonPanel6);
            resources.ApplyResources(this.PurchasesMItem, "PurchasesMItem");
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.SuppliersMenuItem);
            resources.ApplyResources(this.ribbonPanel7, "ribbonPanel7");
            // 
            // SuppliersMenuItem
            // 
            this.SuppliersMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SuppliersMenuItem.Image")));
            this.SuppliersMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SuppliersMenuItem.SmallImage")));
            resources.ApplyResources(this.SuppliersMenuItem, "SuppliersMenuItem");
            this.SuppliersMenuItem.Click += new System.EventHandler(this.SuppliersToolStripMenuItem_Click);
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.InvPurchasesMItem);
            this.ribbonPanel6.Items.Add(this.GetOrderMenuItem);
            this.ribbonPanel6.Items.Add(this.InvOutMenuItem);
            this.ribbonPanel6.Items.Add(this.SearchPurInvMnuItem);
            this.ribbonPanel6.Items.Add(this.InvPurReturnMenuItem);
            this.ribbonPanel6.Items.Add(this.ReorderInvPurMItem);
            resources.ApplyResources(this.ribbonPanel6, "ribbonPanel6");
            // 
            // InvPurchasesMItem
            // 
            this.InvPurchasesMItem.Image = ((System.Drawing.Image)(resources.GetObject("InvPurchasesMItem.Image")));
            this.InvPurchasesMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvPurchasesMItem.SmallImage")));
            resources.ApplyResources(this.InvPurchasesMItem, "InvPurchasesMItem");
            this.InvPurchasesMItem.Click += new System.EventHandler(this.InvPurchasesMenuItem_Click);
            // 
            // GetOrderMenuItem
            // 
            this.GetOrderMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("GetOrderMenuItem.Image")));
            this.GetOrderMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("GetOrderMenuItem.SmallImage")));
            resources.ApplyResources(this.GetOrderMenuItem, "GetOrderMenuItem");
            this.GetOrderMenuItem.Click += new System.EventHandler(this.GetOrderMenuItem_Click);
            // 
            // InvOutMenuItem
            // 
            this.InvOutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InvOutMenuItem.Image")));
            this.InvOutMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvOutMenuItem.SmallImage")));
            resources.ApplyResources(this.InvOutMenuItem, "InvOutMenuItem");
            this.InvOutMenuItem.Click += new System.EventHandler(this.InvOutMenuItem_Click);
            // 
            // SearchPurInvMnuItem
            // 
            this.SearchPurInvMnuItem.Image = ((System.Drawing.Image)(resources.GetObject("SearchPurInvMnuItem.Image")));
            this.SearchPurInvMnuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SearchPurInvMnuItem.SmallImage")));
            resources.ApplyResources(this.SearchPurInvMnuItem, "SearchPurInvMnuItem");
            this.SearchPurInvMnuItem.Click += new System.EventHandler(this.SearchPurInvMnuItem_Click);
            // 
            // InvPurReturnMenuItem
            // 
            this.InvPurReturnMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("InvPurReturnMenuItem.Image")));
            this.InvPurReturnMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvPurReturnMenuItem.SmallImage")));
            resources.ApplyResources(this.InvPurReturnMenuItem, "InvPurReturnMenuItem");
            this.InvPurReturnMenuItem.Click += new System.EventHandler(this.InvPurReturnMenuItem_Click);
            // 
            // ReorderInvPurMItem
            // 
            this.ReorderInvPurMItem.Image = ((System.Drawing.Image)(resources.GetObject("ReorderInvPurMItem.Image")));
            this.ReorderInvPurMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ReorderInvPurMItem.SmallImage")));
            resources.ApplyResources(this.ReorderInvPurMItem, "ReorderInvPurMItem");
            this.ReorderInvPurMItem.Click += new System.EventHandler(this.ReorderInvPurMenuItem1_Click);
            // 
            // HRMItem
            // 
            this.HRMItem.Panels.Add(this.ribbonPanel9);
            this.HRMItem.Panels.Add(this.ribbonPanel11);
            this.HRMItem.Panels.Add(this.ribbonPanel10);
            resources.ApplyResources(this.HRMItem, "HRMItem");
            // 
            // ribbonPanel9
            // 
            this.ribbonPanel9.Items.Add(this.HRCards);
            this.ribbonPanel9.Items.Add(this.EmpExpiredenuItem);
            this.ribbonPanel9.Items.Add(this.EmpPayrollMenuItem);
            this.ribbonPanel9.Items.Add(this.EmpListMenuItem);
            this.ribbonPanel9.Items.Add(this.EmpDataMnuItem);
            resources.ApplyResources(this.ribbonPanel9, "ribbonPanel9");
            // 
            // HRCards
            // 
            this.HRCards.DropDownItems.Add(this.NatMenuItem);
            this.HRCards.DropDownItems.Add(this.PENALTYMenuItem);
            this.HRCards.DropDownItems.Add(this.VacationMenuItem);
            this.HRCards.DropDownItems.Add(this.DeptMenuItem);
            this.HRCards.DropDownItems.Add(this.GroupsMnuItem);
            this.HRCards.Image = ((System.Drawing.Image)(resources.GetObject("HRCards.Image")));
            this.HRCards.SmallImage = ((System.Drawing.Image)(resources.GetObject("HRCards.SmallImage")));
            this.HRCards.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.HRCards, "HRCards");
            // 
            // NatMenuItem
            // 
            this.NatMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.NatMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NatMenuItem.Image")));
            this.NatMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("NatMenuItem.SmallImage")));
            resources.ApplyResources(this.NatMenuItem, "NatMenuItem");
            this.NatMenuItem.Click += new System.EventHandler(this.NatMenuItem_Click);
            // 
            // PENALTYMenuItem
            // 
            this.PENALTYMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.PENALTYMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PENALTYMenuItem.Image")));
            this.PENALTYMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PENALTYMenuItem.SmallImage")));
            resources.ApplyResources(this.PENALTYMenuItem, "PENALTYMenuItem");
            this.PENALTYMenuItem.Click += new System.EventHandler(this.PENALTYMenuItem_Click);
            // 
            // VacationMenuItem
            // 
            this.VacationMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.VacationMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VacationMenuItem.Image")));
            this.VacationMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("VacationMenuItem.SmallImage")));
            resources.ApplyResources(this.VacationMenuItem, "VacationMenuItem");
            this.VacationMenuItem.Click += new System.EventHandler(this.VacationMenuItem_Click);
            // 
            // DeptMenuItem
            // 
            this.DeptMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DeptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DeptMenuItem.Image")));
            this.DeptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("DeptMenuItem.SmallImage")));
            resources.ApplyResources(this.DeptMenuItem, "DeptMenuItem");
            this.DeptMenuItem.Click += new System.EventHandler(this.DeptMenuItem_Click);
            // 
            // GroupsMnuItem
            // 
            this.GroupsMnuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.GroupsMnuItem.Image = ((System.Drawing.Image)(resources.GetObject("GroupsMnuItem.Image")));
            this.GroupsMnuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("GroupsMnuItem.SmallImage")));
            resources.ApplyResources(this.GroupsMnuItem, "GroupsMnuItem");
            this.GroupsMnuItem.Click += new System.EventHandler(this.GroupsMnuItem_Click);
            // 
            // EmpExpiredenuItem
            // 
            this.EmpExpiredenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpExpiredenuItem.Image")));
            this.EmpExpiredenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EmpExpiredenuItem.SmallImage")));
            resources.ApplyResources(this.EmpExpiredenuItem, "EmpExpiredenuItem");
            this.EmpExpiredenuItem.Click += new System.EventHandler(this.EmpExpiredenuItem_Click);
            // 
            // EmpPayrollMenuItem
            // 
            this.EmpPayrollMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpPayrollMenuItem.Image")));
            this.EmpPayrollMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EmpPayrollMenuItem.SmallImage")));
            resources.ApplyResources(this.EmpPayrollMenuItem, "EmpPayrollMenuItem");
            this.EmpPayrollMenuItem.Click += new System.EventHandler(this.EmpPayrollMenuItem_Click);
            // 
            // EmpListMenuItem
            // 
            this.EmpListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpListMenuItem.Image")));
            this.EmpListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EmpListMenuItem.SmallImage")));
            resources.ApplyResources(this.EmpListMenuItem, "EmpListMenuItem");
            this.EmpListMenuItem.Click += new System.EventHandler(this.EmpListMenuItem_Click);
            // 
            // EmpDataMnuItem
            // 
            this.EmpDataMnuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpDataMnuItem.Image")));
            this.EmpDataMnuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EmpDataMnuItem.SmallImage")));
            resources.ApplyResources(this.EmpDataMnuItem, "EmpDataMnuItem");
            this.EmpDataMnuItem.Click += new System.EventHandler(this.EmpDataMnuItem_Click);
            // 
            // ribbonPanel11
            // 
            this.ribbonPanel11.Items.Add(this.EmpRptMenuItem);
            this.ribbonPanel11.Items.Add(this.LoanRptMenuItem);
            this.ribbonPanel11.Items.Add(this.ABSENCERptMenuItem);
            this.ribbonPanel11.Items.Add(this.SalaryEmpRptMenuItem);
            this.ribbonPanel11.Items.Add(this.DiscountRptMenuItem);
            this.ribbonPanel11.Items.Add(this.AllowancesRptMenuItem);
            this.ribbonPanel11.Items.Add(this.VactionRptMenuItem);
            resources.ApplyResources(this.ribbonPanel11, "ribbonPanel11");
            // 
            // EmpRptMenuItem
            // 
            this.EmpRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmpRptMenuItem.Image")));
            this.EmpRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EmpRptMenuItem.SmallImage")));
            resources.ApplyResources(this.EmpRptMenuItem, "EmpRptMenuItem");
            this.EmpRptMenuItem.Click += new System.EventHandler(this.EmpRptMenuItem_Click);
            // 
            // LoanRptMenuItem
            // 
            this.LoanRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LoanRptMenuItem.Image")));
            this.LoanRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("LoanRptMenuItem.SmallImage")));
            resources.ApplyResources(this.LoanRptMenuItem, "LoanRptMenuItem");
            this.LoanRptMenuItem.Click += new System.EventHandler(this.LoanRptMenuItem_Click);
            // 
            // ABSENCERptMenuItem
            // 
            this.ABSENCERptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ABSENCERptMenuItem.Image")));
            this.ABSENCERptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ABSENCERptMenuItem.SmallImage")));
            resources.ApplyResources(this.ABSENCERptMenuItem, "ABSENCERptMenuItem");
            this.ABSENCERptMenuItem.Click += new System.EventHandler(this.ABSENCERptMenuItem_Click);
            // 
            // SalaryEmpRptMenuItem
            // 
            this.SalaryEmpRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SalaryEmpRptMenuItem.Image")));
            this.SalaryEmpRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SalaryEmpRptMenuItem.SmallImage")));
            resources.ApplyResources(this.SalaryEmpRptMenuItem, "SalaryEmpRptMenuItem");
            this.SalaryEmpRptMenuItem.Click += new System.EventHandler(this.SalaryEmpRptMenuItem_Click);
            // 
            // DiscountRptMenuItem
            // 
            this.DiscountRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DiscountRptMenuItem.Image")));
            this.DiscountRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("DiscountRptMenuItem.SmallImage")));
            resources.ApplyResources(this.DiscountRptMenuItem, "DiscountRptMenuItem");
            this.DiscountRptMenuItem.Click += new System.EventHandler(this.DiscountRptMenuItem_Click);
            // 
            // AllowancesRptMenuItem
            // 
            this.AllowancesRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AllowancesRptMenuItem.Image")));
            this.AllowancesRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AllowancesRptMenuItem.SmallImage")));
            resources.ApplyResources(this.AllowancesRptMenuItem, "AllowancesRptMenuItem");
            this.AllowancesRptMenuItem.Click += new System.EventHandler(this.AllowancesRptMenuItem_Click);
            // 
            // VactionRptMenuItem
            // 
            this.VactionRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("VactionRptMenuItem.Image")));
            this.VactionRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("VactionRptMenuItem.SmallImage")));
            resources.ApplyResources(this.VactionRptMenuItem, "VactionRptMenuItem");
            this.VactionRptMenuItem.Click += new System.EventHandler(this.VactionRptMenuItem_Click);
            // 
            // ribbonPanel10
            // 
            this.ribbonPanel10.Items.Add(this.AttToolStripMenuItem);
            resources.ApplyResources(this.ribbonPanel10, "ribbonPanel10");
            // 
            // AttToolStripMenuItem
            // 
            this.AttToolStripMenuItem.DropDownItems.Add(this.ribbonButton4);
            this.AttToolStripMenuItem.DropDownItems.Add(this.ribbonButton59);
            this.AttToolStripMenuItem.DropDownItems.Add(this.ribbonButton58);
            this.AttToolStripMenuItem.DropDownItems.Add(this.ribbonButton57);
            this.AttToolStripMenuItem.DropDownItems.Add(this.ribbonButton60);
            this.AttToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AttToolStripMenuItem.Image")));
            this.AttToolStripMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AttToolStripMenuItem.SmallImage")));
            this.AttToolStripMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.AttToolStripMenuItem, "AttToolStripMenuItem");
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            resources.ApplyResources(this.ribbonButton4, "ribbonButton4");
            this.ribbonButton4.Click += new System.EventHandler(this.FormsMenuItem_Click);
            // 
            // ribbonButton59
            // 
            this.ribbonButton59.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton59.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton59.Image")));
            this.ribbonButton59.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton59.SmallImage")));
            resources.ApplyResources(this.ribbonButton59, "ribbonButton59");
            // 
            // ribbonButton58
            // 
            this.ribbonButton58.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton58.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton58.Image")));
            this.ribbonButton58.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton58.SmallImage")));
            resources.ApplyResources(this.ribbonButton58, "ribbonButton58");
            // 
            // ribbonButton57
            // 
            this.ribbonButton57.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton57.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton57.Image")));
            this.ribbonButton57.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton57.SmallImage")));
            resources.ApplyResources(this.ribbonButton57, "ribbonButton57");
            // 
            // ribbonButton60
            // 
            this.ribbonButton60.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton60.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton60.Image")));
            this.ribbonButton60.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton60.SmallImage")));
            resources.ApplyResources(this.ribbonButton60, "ribbonButton60");
            this.ribbonButton60.Click += new System.EventHandler(this.LeavEntryMenuItem_Click);
            // 
            // AccRptMItem
            // 
            this.AccRptMItem.Panels.Add(this.ribbonPanel12);
            this.AccRptMItem.Panels.Add(this.ribbonPanel13);
            this.AccRptMItem.Panels.Add(this.ribbonPanel14);
            resources.ApplyResources(this.AccRptMItem, "AccRptMItem");
            // 
            // ribbonPanel12
            // 
            this.ribbonPanel12.Items.Add(this.BalanceClosedMenuItem);
            this.ribbonPanel12.Items.Add(this.IncomeListMenuItem);
            this.ribbonPanel12.Items.Add(this.RefBalanceVerMenuItem);
            this.ribbonPanel12.Items.Add(this.BalanceBtn);
            this.ribbonPanel12.Items.Add(this.TotalAmountBtn);
            resources.ApplyResources(this.ribbonPanel12, "ribbonPanel12");
            // 
            // BalanceClosedMenuItem
            // 
            this.BalanceClosedMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("BalanceClosedMenuItem.Image")));
            this.BalanceClosedMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("BalanceClosedMenuItem.SmallImage")));
            resources.ApplyResources(this.BalanceClosedMenuItem, "BalanceClosedMenuItem");
            this.BalanceClosedMenuItem.Click += new System.EventHandler(this.BalanceClosedMenuItem_Click);
            // 
            // IncomeListMenuItem
            // 
            this.IncomeListMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IncomeListMenuItem.Image")));
            this.IncomeListMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("IncomeListMenuItem.SmallImage")));
            resources.ApplyResources(this.IncomeListMenuItem, "IncomeListMenuItem");
            this.IncomeListMenuItem.Click += new System.EventHandler(this.IncomeListMenuItem_Click);
            // 
            // RefBalanceVerMenuItem
            // 
            this.RefBalanceVerMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RefBalanceVerMenuItem.Image")));
            this.RefBalanceVerMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("RefBalanceVerMenuItem.SmallImage")));
            resources.ApplyResources(this.RefBalanceVerMenuItem, "RefBalanceVerMenuItem");
            this.RefBalanceVerMenuItem.Click += new System.EventHandler(this.RefBalanceVerMenuItem_Click);
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.Image = ((System.Drawing.Image)(resources.GetObject("BalanceBtn.Image")));
            this.BalanceBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("BalanceBtn.SmallImage")));
            resources.ApplyResources(this.BalanceBtn, "BalanceBtn");
            this.BalanceBtn.Click += new System.EventHandler(this.BalanceRefMenuItem_Click);
            // 
            // TotalAmountBtn
            // 
            this.TotalAmountBtn.Image = ((System.Drawing.Image)(resources.GetObject("TotalAmountBtn.Image")));
            this.TotalAmountBtn.SmallImage = ((System.Drawing.Image)(resources.GetObject("TotalAmountBtn.SmallImage")));
            resources.ApplyResources(this.TotalAmountBtn, "TotalAmountBtn");
            this.TotalAmountBtn.Click += new System.EventHandler(this.AccountSumMenuItem_Click);
            // 
            // ribbonPanel13
            // 
            this.ribbonPanel13.Items.Add(this.CustomerMoveMItem);
            this.ribbonPanel13.Items.Add(this.AcctSumWithDanMItem);
            this.ribbonPanel13.Items.Add(this.AccountSumProductsMenuItem);
            this.ribbonPanel13.Items.Add(this.CustAcctSumMenuItem);
            this.ribbonPanel13.Items.Add(this.AccountSumDetMItemRpt);
            resources.ApplyResources(this.ribbonPanel13, "ribbonPanel13");
            // 
            // CustomerMoveMItem
            // 
            this.CustomerMoveMItem.Image = ((System.Drawing.Image)(resources.GetObject("CustomerMoveMItem.Image")));
            this.CustomerMoveMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustomerMoveMItem.SmallImage")));
            resources.ApplyResources(this.CustomerMoveMItem, "CustomerMoveMItem");
            this.CustomerMoveMItem.Click += new System.EventHandler(this.CustomerMoveMItem_Click);
            // 
            // AcctSumWithDanMItem
            // 
            this.AcctSumWithDanMItem.Image = ((System.Drawing.Image)(resources.GetObject("AcctSumWithDanMItem.Image")));
            this.AcctSumWithDanMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AcctSumWithDanMItem.SmallImage")));
            resources.ApplyResources(this.AcctSumWithDanMItem, "AcctSumWithDanMItem");
            this.AcctSumWithDanMItem.Click += new System.EventHandler(this.AcctSumWithDanMItem_Click);
            // 
            // AccountSumProductsMenuItem
            // 
            this.AccountSumProductsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AccountSumProductsMenuItem.Image")));
            this.AccountSumProductsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("AccountSumProductsMenuItem.SmallImage")));
            resources.ApplyResources(this.AccountSumProductsMenuItem, "AccountSumProductsMenuItem");
            this.AccountSumProductsMenuItem.Click += new System.EventHandler(this.AccountSumProductsMenuItem_Click);
            // 
            // CustAcctSumMenuItem
            // 
            this.CustAcctSumMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CustAcctSumMenuItem.Image")));
            this.CustAcctSumMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustAcctSumMenuItem.SmallImage")));
            resources.ApplyResources(this.CustAcctSumMenuItem, "CustAcctSumMenuItem");
            this.CustAcctSumMenuItem.Click += new System.EventHandler(this.CustAcctSumMenuItem_Click);
            // 
            // AccountSumDetMItemRpt
            // 
            this.AccountSumDetMItemRpt.Image = ((System.Drawing.Image)(resources.GetObject("AccountSumDetMItemRpt.Image")));
            this.AccountSumDetMItemRpt.SmallImage = ((System.Drawing.Image)(resources.GetObject("AccountSumDetMItemRpt.SmallImage")));
            resources.ApplyResources(this.AccountSumDetMItemRpt, "AccountSumDetMItemRpt");
            this.AccountSumDetMItemRpt.Click += new System.EventHandler(this.AccountSumDetMItemRpt_Click);
            // 
            // ribbonPanel14
            // 
            this.ribbonPanel14.Items.Add(this.QidsReportsMenuItemNew);
            resources.ApplyResources(this.ribbonPanel14, "ribbonPanel14");
            // 
            // QidsReportsMenuItemNew
            // 
            this.QidsReportsMenuItemNew.DropDownItems.Add(this.InQidsMItemRpt);
            this.QidsReportsMenuItemNew.DropDownItems.Add(this.OutQidsMItemRpt);
            this.QidsReportsMenuItemNew.DropDownItems.Add(this.QidsMItemRpt);
            this.QidsReportsMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("QidsReportsMenuItemNew.Image")));
            this.QidsReportsMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("QidsReportsMenuItemNew.SmallImage")));
            this.QidsReportsMenuItemNew.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.QidsReportsMenuItemNew, "QidsReportsMenuItemNew");
            this.QidsReportsMenuItemNew.Click += new System.EventHandler(this.QidsMItemRpt_Click);
            // 
            // InQidsMItemRpt
            // 
            this.InQidsMItemRpt.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.InQidsMItemRpt.Image = ((System.Drawing.Image)(resources.GetObject("InQidsMItemRpt.Image")));
            this.InQidsMItemRpt.SmallImage = ((System.Drawing.Image)(resources.GetObject("InQidsMItemRpt.SmallImage")));
            resources.ApplyResources(this.InQidsMItemRpt, "InQidsMItemRpt");
            this.InQidsMItemRpt.Click += new System.EventHandler(this.InQidsMItemRpt_Click);
            // 
            // OutQidsMItemRpt
            // 
            this.OutQidsMItemRpt.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.OutQidsMItemRpt.Image = ((System.Drawing.Image)(resources.GetObject("OutQidsMItemRpt.Image")));
            this.OutQidsMItemRpt.SmallImage = ((System.Drawing.Image)(resources.GetObject("OutQidsMItemRpt.SmallImage")));
            resources.ApplyResources(this.OutQidsMItemRpt, "OutQidsMItemRpt");
            this.OutQidsMItemRpt.Click += new System.EventHandler(this.OutQidsMItemRpt_Click);
            // 
            // QidsMItemRpt
            // 
            this.QidsMItemRpt.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.QidsMItemRpt.Image = ((System.Drawing.Image)(resources.GetObject("QidsMItemRpt.Image")));
            this.QidsMItemRpt.SmallImage = ((System.Drawing.Image)(resources.GetObject("QidsMItemRpt.SmallImage")));
            resources.ApplyResources(this.QidsMItemRpt, "QidsMItemRpt");
            // 
            // StoresRptMItem
            // 
            this.StoresRptMItem.Panels.Add(this.ribbonPanel2);
            this.StoresRptMItem.Panels.Add(this.ribbonPanel15);
            resources.ApplyResources(this.StoresRptMItem, "StoresRptMItem");
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.PcollecttoolMenuItem);
            resources.ApplyResources(this.ribbonPanel2, "ribbonPanel2");
            // 
            // PcollecttoolMenuItem
            // 
            this.PcollecttoolMenuItem.DropDownItems.Add(this.PcollecttoolMenuItemNew);
            this.PcollecttoolMenuItem.DropDownItems.Add(this.DailySalesMenuItemNew);
            this.PcollecttoolMenuItem.DropDownItems.Add(this.ProductProfitRptMenuItemNew);
            this.PcollecttoolMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PcollecttoolMenuItem.Image")));
            this.PcollecttoolMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PcollecttoolMenuItem.SmallImage")));
            this.PcollecttoolMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.PcollecttoolMenuItem, "PcollecttoolMenuItem");
            // 
            // PcollecttoolMenuItemNew
            // 
            this.PcollecttoolMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.PcollecttoolMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("PcollecttoolMenuItemNew.Image")));
            this.PcollecttoolMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("PcollecttoolMenuItemNew.SmallImage")));
            resources.ApplyResources(this.PcollecttoolMenuItemNew, "PcollecttoolMenuItemNew");
            this.PcollecttoolMenuItemNew.Click += new System.EventHandler(this.ProductcheckMenuItem_Click);
            // 
            // DailySalesMenuItemNew
            // 
            this.DailySalesMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DailySalesMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("DailySalesMenuItemNew.Image")));
            this.DailySalesMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("DailySalesMenuItemNew.SmallImage")));
            resources.ApplyResources(this.DailySalesMenuItemNew, "DailySalesMenuItemNew");
            this.DailySalesMenuItemNew.Click += new System.EventHandler(this.DailySalesMenuItem_Click);
            // 
            // ProductProfitRptMenuItemNew
            // 
            this.ProductProfitRptMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ProductProfitRptMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("ProductProfitRptMenuItemNew.Image")));
            this.ProductProfitRptMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProductProfitRptMenuItemNew.SmallImage")));
            resources.ApplyResources(this.ProductProfitRptMenuItemNew, "ProductProfitRptMenuItemNew");
            this.ProductProfitRptMenuItemNew.Click += new System.EventHandler(this.ProductProfitRptMenuItem_Click);
            // 
            // ribbonPanel15
            // 
            this.ribbonPanel15.Items.Add(this.LifeLoansMenuItem);
            this.ribbonPanel15.Items.Add(this.OtherReport);
            this.ribbonPanel15.Items.Add(this.CitiesSalesMenuItem);
            this.ribbonPanel15.Items.Add(this.SaleProductMItem);
            this.ribbonPanel15.Items.Add(this.PurchaseProductMItem);
            this.ribbonPanel15.Items.Add(this.CustomersSalesMItem);
            this.ribbonPanel15.Items.Add(this.PMovetoolMenuItem);
            this.ribbonPanel15.Items.Add(this.InvoicesRefButton);
            this.ribbonPanel15.Items.Add(this.ProductProfitRptMenuItem);
            this.ribbonPanel15.Items.Add(this.StoresAnyMenuItem);
            this.ribbonPanel15.Items.Add(this.PMoveButton);
            resources.ApplyResources(this.ribbonPanel15, "ribbonPanel15");
            // 
            // LifeLoansMenuItem
            // 
            this.LifeLoansMenuItem.DropDownItems.Add(this.A3marDauanMonthMItem);
            this.LifeLoansMenuItem.DropDownItems.Add(this.A3marDauanPeriodMItem);
            this.LifeLoansMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("LifeLoansMenuItem.Image")));
            this.LifeLoansMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("LifeLoansMenuItem.SmallImage")));
            this.LifeLoansMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.LifeLoansMenuItem, "LifeLoansMenuItem");
            // 
            // A3marDauanMonthMItem
            // 
            this.A3marDauanMonthMItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.A3marDauanMonthMItem.DropDownItems.Add(this.ribbonButton1);
            this.A3marDauanMonthMItem.DropDownItems.Add(this.ribbonButton2);
            this.A3marDauanMonthMItem.Image = ((System.Drawing.Image)(resources.GetObject("A3marDauanMonthMItem.Image")));
            this.A3marDauanMonthMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("A3marDauanMonthMItem.SmallImage")));
            resources.ApplyResources(this.A3marDauanMonthMItem, "A3marDauanMonthMItem");
            this.A3marDauanMonthMItem.Click += new System.EventHandler(this.A3marDauanMonthMItem_Click);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            resources.ApplyResources(this.ribbonButton1, "ribbonButton1");
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            resources.ApplyResources(this.ribbonButton2, "ribbonButton2");
            // 
            // A3marDauanPeriodMItem
            // 
            this.A3marDauanPeriodMItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.A3marDauanPeriodMItem.Image = ((System.Drawing.Image)(resources.GetObject("A3marDauanPeriodMItem.Image")));
            this.A3marDauanPeriodMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("A3marDauanPeriodMItem.SmallImage")));
            resources.ApplyResources(this.A3marDauanPeriodMItem, "A3marDauanPeriodMItem");
            this.A3marDauanPeriodMItem.Click += new System.EventHandler(this.A3marDauanPeriodMItem_Click);
            // 
            // OtherReport
            // 
            this.OtherReport.DropDownItems.Add(this.DailySalesMenuItem);
            this.OtherReport.DropDownItems.Add(this.CustomerAccountsMenuItem);
            this.OtherReport.DropDownItems.Add(this.supplierAccountsMenuItem);
            this.OtherReport.DropDownItems.Add(this.ProductsAndStoresMenuItem);
            this.OtherReport.Image = ((System.Drawing.Image)(resources.GetObject("OtherReport.Image")));
            this.OtherReport.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.OtherReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("OtherReport.SmallImage")));
            this.OtherReport.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.OtherReport, "OtherReport");
            // 
            // DailySalesMenuItem
            // 
            this.DailySalesMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.DailySalesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DailySalesMenuItem.Image")));
            this.DailySalesMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("DailySalesMenuItem.SmallImage")));
            resources.ApplyResources(this.DailySalesMenuItem, "DailySalesMenuItem");
            this.DailySalesMenuItem.Click += new System.EventHandler(this.DailySalesMenuItem_Click);
            // 
            // CustomerAccountsMenuItem
            // 
            this.CustomerAccountsMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.CustomerAccountsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CustomerAccountsMenuItem.Image")));
            this.CustomerAccountsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustomerAccountsMenuItem.SmallImage")));
            resources.ApplyResources(this.CustomerAccountsMenuItem, "CustomerAccountsMenuItem");
            this.CustomerAccountsMenuItem.Click += new System.EventHandler(this.CustomerAccountsMenuItem_Click);
            // 
            // supplierAccountsMenuItem
            // 
            this.supplierAccountsMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.supplierAccountsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierAccountsMenuItem.Image")));
            this.supplierAccountsMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("supplierAccountsMenuItem.SmallImage")));
            resources.ApplyResources(this.supplierAccountsMenuItem, "supplierAccountsMenuItem");
            this.supplierAccountsMenuItem.Click += new System.EventHandler(this.supplierAccountsMenuItem_Click);
            // 
            // ProductsAndStoresMenuItem
            // 
            this.ProductsAndStoresMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ProductsAndStoresMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductsAndStoresMenuItem.Image")));
            this.ProductsAndStoresMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProductsAndStoresMenuItem.SmallImage")));
            resources.ApplyResources(this.ProductsAndStoresMenuItem, "ProductsAndStoresMenuItem");
            this.ProductsAndStoresMenuItem.Click += new System.EventHandler(this.ProductsAndStoresMenuItem_Click);
            // 
            // CitiesSalesMenuItem
            // 
            this.CitiesSalesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CitiesSalesMenuItem.Image")));
            this.CitiesSalesMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CitiesSalesMenuItem.SmallImage")));
            resources.ApplyResources(this.CitiesSalesMenuItem, "CitiesSalesMenuItem");
            this.CitiesSalesMenuItem.Click += new System.EventHandler(this.CitiesSalesMenuItem_Click);
            // 
            // SaleProductMItem
            // 
            this.SaleProductMItem.Image = ((System.Drawing.Image)(resources.GetObject("SaleProductMItem.Image")));
            this.SaleProductMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SaleProductMItem.SmallImage")));
            resources.ApplyResources(this.SaleProductMItem, "SaleProductMItem");
            this.SaleProductMItem.Click += new System.EventHandler(this.SaleProductMItem_Click);
            // 
            // PurchaseProductMItem
            // 
            this.PurchaseProductMItem.Image = global::ERPSYS.Properties.Resources._38;
            this.PurchaseProductMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PurchaseProductMItem.SmallImage")));
            resources.ApplyResources(this.PurchaseProductMItem, "PurchaseProductMItem");
            this.PurchaseProductMItem.Click += new System.EventHandler(this.PurchaseProductMItem_Click);
            // 
            // CustomersSalesMItem
            // 
            this.CustomersSalesMItem.Image = ((System.Drawing.Image)(resources.GetObject("CustomersSalesMItem.Image")));
            this.CustomersSalesMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CustomersSalesMItem.SmallImage")));
            resources.ApplyResources(this.CustomersSalesMItem, "CustomersSalesMItem");
            this.CustomersSalesMItem.Click += new System.EventHandler(this.CustomersSalesMItem_Click);
            // 
            // PMovetoolMenuItem
            // 
            this.PMovetoolMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PMovetoolMenuItem.Image")));
            this.PMovetoolMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("PMovetoolMenuItem.SmallImage")));
            resources.ApplyResources(this.PMovetoolMenuItem, "PMovetoolMenuItem");
            this.PMovetoolMenuItem.Click += new System.EventHandler(this.StoreCheckMenuItem_Click);
            // 
            // InvoicesRefButton
            // 
            this.InvoicesRefButton.Image = ((System.Drawing.Image)(resources.GetObject("InvoicesRefButton.Image")));
            this.InvoicesRefButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("InvoicesRefButton.SmallImage")));
            resources.ApplyResources(this.InvoicesRefButton, "InvoicesRefButton");
            this.InvoicesRefButton.Click += new System.EventHandler(this.InvoiceRefMenuItem_Click);
            // 
            // ProductProfitRptMenuItem
            // 
            this.ProductProfitRptMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ProductProfitRptMenuItem.Image")));
            this.ProductProfitRptMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ProductProfitRptMenuItem.SmallImage")));
            resources.ApplyResources(this.ProductProfitRptMenuItem, "ProductProfitRptMenuItem");
            this.ProductProfitRptMenuItem.Click += new System.EventHandler(this.ProductMatchMnuItem_Click);
            // 
            // StoresAnyMenuItem
            // 
            this.StoresAnyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("StoresAnyMenuItem.Image")));
            this.StoresAnyMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("StoresAnyMenuItem.SmallImage")));
            resources.ApplyResources(this.StoresAnyMenuItem, "StoresAnyMenuItem");
            this.StoresAnyMenuItem.Click += new System.EventHandler(this.StoresAnyMenuItem_Click);
            // 
            // PMoveButton
            // 
            this.PMoveButton.Image = ((System.Drawing.Image)(resources.GetObject("PMoveButton.Image")));
            this.PMoveButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("PMoveButton.SmallImage")));
            resources.ApplyResources(this.PMoveButton, "PMoveButton");
            this.PMoveButton.Click += new System.EventHandler(this.PMoveButton_Click);
            // 
            // ToolsMItem
            // 
            this.ToolsMItem.Panels.Add(this.ribbonPanel16);
            resources.ApplyResources(this.ToolsMItem, "ToolsMItem");
            // 
            // ribbonPanel16
            // 
            this.ribbonPanel16.Items.Add(this.OpenAccYearMItem);
            this.ribbonPanel16.Items.Add(this.ChangeLangMenuItem);
            this.ribbonPanel16.Items.Add(this.CloseAccYearMItem);
            this.ribbonPanel16.Items.Add(this.UserSecMenuItem);
            this.ribbonPanel16.Items.Add(this.SetupMenuItem);
            resources.ApplyResources(this.ribbonPanel16, "ribbonPanel16");
            // 
            // OpenAccYearMItem
            // 
            this.OpenAccYearMItem.Enabled = false;
            this.OpenAccYearMItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenAccYearMItem.Image")));
            this.OpenAccYearMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("OpenAccYearMItem.SmallImage")));
            resources.ApplyResources(this.OpenAccYearMItem, "OpenAccYearMItem");
            this.OpenAccYearMItem.Visible = false;
            // 
            // ChangeLangMenuItem
            // 
            this.ChangeLangMenuItem.DropDownItems.Add(this.ArabLangMenuItem);
            this.ChangeLangMenuItem.DropDownItems.Add(this.EngLangMenuItem);
            this.ChangeLangMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ChangeLangMenuItem.Image")));
            this.ChangeLangMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ChangeLangMenuItem.SmallImage")));
            this.ChangeLangMenuItem.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            resources.ApplyResources(this.ChangeLangMenuItem, "ChangeLangMenuItem");
            // 
            // ArabLangMenuItem
            // 
            this.ArabLangMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ArabLangMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ArabLangMenuItem.Image")));
            this.ArabLangMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("ArabLangMenuItem.SmallImage")));
            resources.ApplyResources(this.ArabLangMenuItem, "ArabLangMenuItem");
            this.ArabLangMenuItem.Click += new System.EventHandler(this.ArabLangMenuItem_Click);
            // 
            // EngLangMenuItem
            // 
            this.EngLangMenuItem.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.EngLangMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EngLangMenuItem.Image")));
            this.EngLangMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("EngLangMenuItem.SmallImage")));
            resources.ApplyResources(this.EngLangMenuItem, "EngLangMenuItem");
            this.EngLangMenuItem.Click += new System.EventHandler(this.EngLangMenuItem_Click);
            // 
            // CloseAccYearMItem
            // 
            this.CloseAccYearMItem.Image = ((System.Drawing.Image)(resources.GetObject("CloseAccYearMItem.Image")));
            this.CloseAccYearMItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("CloseAccYearMItem.SmallImage")));
            resources.ApplyResources(this.CloseAccYearMItem, "CloseAccYearMItem");
            this.CloseAccYearMItem.Visible = false;
            this.CloseAccYearMItem.Click += new System.EventHandler(this.CloseAccYearMItem_Click);
            // 
            // UserSecMenuItem
            // 
            this.UserSecMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("UserSecMenuItem.Image")));
            this.UserSecMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("UserSecMenuItem.SmallImage")));
            resources.ApplyResources(this.UserSecMenuItem, "UserSecMenuItem");
            this.UserSecMenuItem.Click += new System.EventHandler(this.UserSecurityMenuItem_Click);
            // 
            // SetupMenuItem
            // 
            this.SetupMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SetupMenuItem.Image")));
            this.SetupMenuItem.SmallImage = ((System.Drawing.Image)(resources.GetObject("SetupMenuItem.SmallImage")));
            resources.ApplyResources(this.SetupMenuItem, "SetupMenuItem");
            this.SetupMenuItem.Click += new System.EventHandler(this.SetupMenuItem_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.ActiveAutoHideContent = null;
            resources.ApplyResources(this.dockPanel1, "dockPanel1");
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.dockPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HRMItemNew);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // HRMItemNew
            // 
            this.HRMItemNew.BackColor = System.Drawing.Color.Lavender;
            this.HRMItemNew.CaptionBarVisible = false;
            resources.ApplyResources(this.HRMItemNew, "HRMItemNew");
            this.HRMItemNew.ForeColor = System.Drawing.Color.Black;
            this.HRMItemNew.Minimized = false;
            this.HRMItemNew.Name = "HRMItemNew";
            // 
            // 
            // 
            this.HRMItemNew.OrbDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("HRMItemNew.OrbDropDown.Anchor")));
            this.HRMItemNew.OrbDropDown.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HRMItemNew.OrbDropDown.BorderRoundness = 8;
            this.HRMItemNew.OrbDropDown.Font = ((System.Drawing.Font)(resources.GetObject("HRMItemNew.OrbDropDown.Font")));
            this.HRMItemNew.OrbDropDown.Location = ((System.Drawing.Point)(resources.GetObject("HRMItemNew.OrbDropDown.Location")));
            this.HRMItemNew.OrbDropDown.Name = "";
            this.HRMItemNew.OrbDropDown.Size = ((System.Drawing.Size)(resources.GetObject("HRMItemNew.OrbDropDown.Size")));
            this.HRMItemNew.OrbDropDown.TabIndex = ((int)(resources.GetObject("HRMItemNew.OrbDropDown.TabIndex")));
            this.HRMItemNew.OrbImage = null;
            this.HRMItemNew.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.HRMItemNew.OrbText = "";
            this.HRMItemNew.OrbVisible = false;
            // 
            // 
            // 
            this.HRMItemNew.QuickAcessToolbar.DropDownButtonVisible = false;
            this.HRMItemNew.RibbonTabFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRMItemNew.Tabs.Add(this.FileMItem);
            this.HRMItemNew.Tabs.Add(this.AccountsMItem);
            this.HRMItemNew.Tabs.Add(this.StoresMItem);
            this.HRMItemNew.Tabs.Add(this.SalesMItem);
            this.HRMItemNew.Tabs.Add(this.PurchasesMItem);
            this.HRMItemNew.Tabs.Add(this.HRMItem);
            this.HRMItemNew.Tabs.Add(this.AccRptMItem);
            this.HRMItemNew.Tabs.Add(this.StoresRptMItem);
            this.HRMItemNew.Tabs.Add(this.ToolsMItem);
            this.HRMItemNew.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 5);
            this.HRMItemNew.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.statusStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nEWERPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setupCodesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERFUNCTIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NEWERPDataSet nEWERPDataSet;
        private System.Windows.Forms.BindingSource setupBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.setupTableAdapter setupTableAdapter;
        private System.Windows.Forms.BindingSource setupCodesBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.SetupCodesTableAdapter setupCodesTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStatusLabelUser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripLabelDay;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatuslblAdv;
        private System.Windows.Forms.BindingSource fUNCTIONSBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.FUNCTIONSTableAdapter fUNCTIONSTableAdapter;
        private System.Windows.Forms.BindingSource uSERFUNCTIONBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.USER_FUNCTIONTableAdapter uSER_FUNCTIONTableAdapter;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        private ERPSYS.NEWERPDataSetTableAdapters.USERTableAdapter uSERTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblBranch;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusDate;
        private System.Windows.Forms.RibbonTab FileMItem;
        private System.Windows.Forms.RibbonTab AccountsMItem;
        private System.Windows.Forms.RibbonTab StoresMItem;
        private System.Windows.Forms.RibbonTab SalesMItem;
        private System.Windows.Forms.RibbonTab PurchasesMItem;
        private System.Windows.Forms.RibbonTab HRMItem;
        private System.Windows.Forms.RibbonTab AccRptMItem;
        private System.Windows.Forms.RibbonTab StoresRptMItem;
        private System.Windows.Forms.RibbonTab ToolsMItem;
        private System.Windows.Forms.RibbonPanel UserribbonPane;
        private System.Windows.Forms.RibbonButton ReLoginMItem;
        private WeifenLuo.WinFormsUI.DockPanel dockPanel1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Ribbon HRMItemNew;
        private System.Windows.Forms.RibbonButton ChangeBackMItem;
        private System.Windows.Forms.RibbonButton ChangePassMItem;
        private System.Windows.Forms.RibbonPanel AccountribbonPanel3;
        private System.Windows.Forms.RibbonPanel AccountribbonPanel;
        private System.Windows.Forms.RibbonButton AccCardMItem;
        private System.Windows.Forms.RibbonButton CurrencyMenuItem;
        private System.Windows.Forms.RibbonButton BranchCardMItem;
        private System.Windows.Forms.RibbonPanel InventoryribbonPanel;
        private System.Windows.Forms.RibbonButton StorCardMItem;
        private System.Windows.Forms.RibbonButton ProductCardMItem;
        private System.Windows.Forms.RibbonButton CustSupCardMItem;
        private System.Windows.Forms.RibbonButton SalManCardMItem;
        private System.Windows.Forms.RibbonPanel CostCenterribbonPanel;
        private System.Windows.Forms.RibbonButton CostCardMItem;
        private System.Windows.Forms.RibbonButton AcounttreeMenuItem;
        private System.Windows.Forms.RibbonButton QidMenuItemStart;
        private System.Windows.Forms.RibbonButton QidMenuItemPublic;
        private System.Windows.Forms.RibbonButton InQidMItem;
        private System.Windows.Forms.RibbonButton OutQidMItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton UintsMenuItem;
        private System.Windows.Forms.RibbonButton ListProductMenuItem;
        private System.Windows.Forms.RibbonButton ProductTreeMenuItem;
        private System.Windows.Forms.RibbonButton LinkStoreMItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton InventoryCalMenuItem;
        private System.Windows.Forms.RibbonButton OrderOutMenuItem;
        private System.Windows.Forms.RibbonButton OutOrderMenuItem;
        private System.Windows.Forms.RibbonButton SearchMovementMenuItem;
        private System.Windows.Forms.RibbonButton StoreOrderMenuItem;
        private System.Windows.Forms.RibbonButton PartionListMenuItem;
        private System.Windows.Forms.RibbonButton CustMoveMenuItem;
        private System.Windows.Forms.RibbonButton CustomerMenuItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton ReoderListMenuItem;
        private System.Windows.Forms.RibbonButton ReodersAddMenuItem;
        private System.Windows.Forms.RibbonButton SearchSalInvMnuItem;
        private System.Windows.Forms.RibbonButton InvPaymentMItem;
        private System.Windows.Forms.RibbonButton ReorderInvSalMItem;
        private System.Windows.Forms.RibbonButton InvSalesMItem;
        private System.Windows.Forms.RibbonButton PriceListMenuItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton SearchPurInvMnuItem;
        private System.Windows.Forms.RibbonButton InvPurReturnMenuItem;
        private System.Windows.Forms.RibbonButton ReorderInvPurMItem;
        private System.Windows.Forms.RibbonButton InvPurchasesMItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton SuppliersMenuItem;
        private System.Windows.Forms.RibbonButton InvOutMenuItem;
        private System.Windows.Forms.RibbonButton GetOrderMenuItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel9;
        private System.Windows.Forms.RibbonPanel ribbonPanel10;
        private System.Windows.Forms.RibbonButton AttToolStripMenuItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel11;
        private System.Windows.Forms.RibbonButton EmpExpiredenuItem;
        private System.Windows.Forms.RibbonButton EmpPayrollMenuItem;
        private System.Windows.Forms.RibbonButton EmpListMenuItem;
        private System.Windows.Forms.RibbonButton EmpDataMnuItem;
        private System.Windows.Forms.RibbonButton SalaryEmpRptMenuItem;
        private System.Windows.Forms.RibbonButton VactionRptMenuItem;
        private System.Windows.Forms.RibbonButton AllowancesRptMenuItem;
        private System.Windows.Forms.RibbonButton DiscountRptMenuItem;
        private System.Windows.Forms.RibbonButton ABSENCERptMenuItem;
        private System.Windows.Forms.RibbonButton LoanRptMenuItem;
        private System.Windows.Forms.RibbonButton EmpRptMenuItem;
        private System.Windows.Forms.RibbonButton ribbonButton57;
        private System.Windows.Forms.RibbonButton ribbonButton58;
        private System.Windows.Forms.RibbonButton ribbonButton59;
        private System.Windows.Forms.RibbonButton ribbonButton60;
        private System.Windows.Forms.RibbonPanel ribbonPanel12;
        private System.Windows.Forms.RibbonPanel ribbonPanel13;
        private System.Windows.Forms.RibbonPanel ribbonPanel14;
        private System.Windows.Forms.RibbonButton BalanceClosedMenuItem;
        private System.Windows.Forms.RibbonButton IncomeListMenuItem;
        private System.Windows.Forms.RibbonButton RefBalanceVerMenuItem;
        private System.Windows.Forms.RibbonButton BalanceBtn;
        private System.Windows.Forms.RibbonButton TotalAmountBtn;
        private System.Windows.Forms.RibbonButton QidsReportsMenuItemNew;
        private System.Windows.Forms.RibbonButton InQidsMItemRpt;
        private System.Windows.Forms.RibbonButton OutQidsMItemRpt;
        private System.Windows.Forms.RibbonButton QidsMItemRpt;
        private System.Windows.Forms.RibbonButton AccountSumDetMItemRpt;
        private System.Windows.Forms.RibbonButton CustomerMoveMItem;
        private System.Windows.Forms.RibbonButton AcctSumWithDanMItem;
        private System.Windows.Forms.RibbonButton AccountSumProductsMenuItem;
        private System.Windows.Forms.RibbonButton CustAcctSumMenuItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel15;
        private System.Windows.Forms.RibbonButton PcollecttoolMenuItem;
        private System.Windows.Forms.RibbonButton StoresAnyMenuItem;
        private System.Windows.Forms.RibbonButton PcollecttoolMenuItemNew;
        private System.Windows.Forms.RibbonButton DailySalesMenuItemNew;
        private System.Windows.Forms.RibbonButton ProductProfitRptMenuItemNew;
        private System.Windows.Forms.RibbonButton InvoicesRefButton;
        private System.Windows.Forms.RibbonButton ProductProfitRptMenuItem;
        private System.Windows.Forms.RibbonButton CustomersSalesMItem;
        private System.Windows.Forms.RibbonButton PMovetoolMenuItem;
        private System.Windows.Forms.RibbonButton CitiesSalesMenuItem;
        private System.Windows.Forms.RibbonButton SaleProductMItem;
        private System.Windows.Forms.RibbonButton OtherReport;
        private System.Windows.Forms.RibbonButton CustomerAccountsMenuItem;
        private System.Windows.Forms.RibbonButton supplierAccountsMenuItem;
        private System.Windows.Forms.RibbonButton ProductsAndStoresMenuItem;
        private System.Windows.Forms.RibbonButton LifeLoansMenuItem;
        private System.Windows.Forms.RibbonButton A3marDauanMonthMItem;
        private System.Windows.Forms.RibbonButton A3marDauanPeriodMItem;
        private System.Windows.Forms.RibbonPanel ribbonPanel16;
        private System.Windows.Forms.RibbonButton ChangeLangMenuItem;
        private System.Windows.Forms.RibbonButton CloseAccYearMItem;
        private System.Windows.Forms.RibbonButton UserSecMenuItem;
        private System.Windows.Forms.RibbonButton SetupMenuItem;
        private System.Windows.Forms.RibbonButton EngLangMenuItem;
        private System.Windows.Forms.RibbonButton ArabLangMenuItem;
        private System.Windows.Forms.RibbonButton QidListMenuItem;
        private System.Windows.Forms.RibbonButton DailySaltoolButton;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ExitBtn;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton OpenAccYearMItem;
        private System.Windows.Forms.RibbonButton CalBtn;
        private System.Windows.Forms.RibbonButton HomeCustBtn;
        private System.Windows.Forms.RibbonButton DailySalesMenuItem;
        private System.Windows.Forms.RibbonButton HRCards;
        private System.Windows.Forms.RibbonButton NatMenuItem;
        private System.Windows.Forms.RibbonButton PENALTYMenuItem;
        private System.Windows.Forms.RibbonButton VacationMenuItem;
        private System.Windows.Forms.RibbonButton DeptMenuItem;
        private System.Windows.Forms.RibbonButton GroupsMnuItem;
        private System.Windows.Forms.RibbonButton PMoveButton;
        private System.Windows.Forms.RibbonButton ReorderInvSalAllMItem;
        private System.Windows.Forms.RibbonButton PurchaseProductMItem;
    }
}

