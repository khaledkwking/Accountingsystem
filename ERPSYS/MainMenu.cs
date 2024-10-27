using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Xceed;
using Xceed.SmartUI;
using System.Resources;

using WeifenLuo.WinFormsUI;
using VS2005Extender;
using System.Runtime.InteropServices;
using ERPSYS.Reports;
using Microsoft.Win32;

namespace ERPSYS
{
    public partial class MainMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private Boolean RepFlag = false;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private int m_ChildFormNumber = 0;
        private ToolStripProfessionalRenderer oDefaultRenderer = new ToolStripProfessionalRenderer(new PropertyGridEx.CustomColorScheme());

        ProductAdd frmProductAdd ;

        StroesAdd frmStroes = new StroesAdd();
        LinkProductToStroe frmLnkStore ;
        GetOrderAdd frmGetOrder ;
        OrderAdd frmOrderAdd;
        //CustSupAdd frmCustSup ;
        CustSupList frmCustSupList ;
        InvoiceAdd frmInvoiceAdd;
        InvoiceSalesReorderAdd frmInvoiceSalesReorderAdd;
        InvoicePurchaseAdd frmInvoicePurchaseAdd;
        AccountAdd frmAccountAdd ;
        AccountTree frmAccountTree;
        QidsAdd frmQids ;
        QidsAdd frmQidsStart;
        QidOutAdd frmOutQid ;
        QidInAdd frmInQid ;
        SetupAdd frmSetup ;
        StoresProducts frmStoresProducts ;
        AccountSum frmAccountSum ;
        AccountSumDetRpt frmAccountSumDetRpt;
        ProductsList frmProductListTree ;
        InvoiceSalReoderAdd frmInvoiceSalReoderAdd ;
        InvoicePurReorderAdd frmInvoicePurReoderAdd ;
        CostCentersAdd frmCostCentersAdd;
        AccountBalanceRef frmAccountBalanceRef;
        BudgetListShow frmBudgetListShow;
        AccountBalanceRefVer frmAccountBalanceRefVer;
        InvoicesList frmSalInvoicesList;
        InvoicesList frmPurInvoicesList;
        IncomeList frmIncomeList ;
        IncomeListShow frmIncomeListShow;
        ProductRpt frmProductRpt;
        ProductCheckRpt frmProductCheckRpt;
        ProductProfitRpt frmProductProfitRpt;
        InvoiceRefRpt frmInvoiceRefRpt;
        UnitsList frmUnitsList;
        UserSec frmUserSec;
        ChangeUserPassword frmChangeUserPassword;
        BranchesAdd frmBranchesAdd;
        InvoicePayment frmInvoicePayment;
        EmpSalesAdd frmEmpSalesAdd;
        AccountSumWithDanRpt frmAccountSumWithDanRpt;
        CustomersSalesRpt frmCustomersSalesRpt;
        ProductSalesRpt frmProductSalesRpt;
        QidsRpt frmInQidsRpt;
        QidsRpt frmOutQidsRpt;
        AccountCustomerWithDanRpt frmAccountCustomerWithDanRpt;
        AccountCustomerDanWithMonthRpt frmAccountCustomerDanWithMonthRpt;
        CustomersMoveRpt frmCustomersMoveRpt;
        StockMoveAdd frmStockMoveAdd;
        ProductMatchRpt frmProductMatchRpt;
        EMP_DATA_Add frmEMPDATAAdd;
        EMPPayRal frmEMPPayRal;
        DeptList frmDeptList;
        PENALTYList frmPENALTYList;
        VactionTypesList frmVactionTypesList;
        StockMoveSearchList frmStockMoveSearchList;
        PriceListAdd frmPriceListAdd;
        DailySalesRpt frmDailySalesRpt;
        InstallmentRequiredAdd frmInstallmentRequiredAdd;
        InstallmentPaymentAdd frmInstallmentPaymentAdd;
        InstallmentSelect frmInstallmentSelect;
        AccountSumProdcutDetRpt frmAccountSumProdcutDetRpt;
        GroupsList frmGroupsList;
        IncomeClosedShow frmIncomeClosedShow;
        CurrencyList frmCurrencyList;
        VacationAdd frmVacationAdd ;
        DailySalesNew frmDailySalesNewRpt;
         ProductStroesList frmProductStroesList;
        EmpRpt frmEmpAbsencesRpt;
        EmpExpireList frmEmpExpireList;
        QidsList frmQidsList;
        EmpForms frmEmpForms;
        AccountSumCustomer frmAccountSumCustomer ;
        ProductStroesSalesList frmProductStroesSalesList;
        ProductStoreCheckRpt frmProductStoreCheckRpt;
        CustomersSupplierSalesRpt frmCustomersSupplierSalesRpt;
        CustomersSupplierSalesRpt frmCustomersSupplierSalesRpt1;
        NatList frmNatList;
        EmpList frmEmpList;
        ReoderInvoicesAdd frmReoderInvoicesList;
        ReorderInvList frmReorderInvList;
        ParitionStockAdd frmParitionStockAdd;
        ParitionSearchList frmParitionSearchList;
        HomeCustomerAdd frmHomeCustomerAdd;
        InvoicePurchasePayment frmInvoicePurchasePayment;
        InventoryCheckProduct frmInventoryCheckProduct;
        OrderOutAdd frmOrderOutAdd;
        ProductPurchaseRpt frmProductPurchaseRpt;
        InvoicePurchaseReorderAdd frmInvoicePurchaseReorderAdd;
        public MainMenu()
        {
            Licenser.LicenseKey = "SUN32-5EPA0-18LY6-SWJA";
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(3000);
            th.Abort();
            Thread.Sleep(1000);
            InitializeComponent();

           
        }
        private void DoSplash()
        {
            FlashScreen frm = new FlashScreen();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
        private void CreateBasicLayout()
        {
            //frmSolution.Show(dockPanel1, WeifenLuo.WinFormsUI.DockState.DockLeft);
            //PropertiesWindow.Show(dockPanel1, WeifenLuo.WinFormsUI.DockState.DockLeft);
        }
        private IDockContent ReloadContent(string persistString)
        {
            switch (persistString)
            {
                case "frmDocument":
                    return null;

                //case "frmSolution":

                //    frmSolution = new Form2();
                //    return (IDockContent)frmSolution;

                //case "frmProperty":

                //    PropertiesWindow = new Form3();
                //    return (IDockContent)PropertiesWindow;

            }

            return null;
        }
        private void LoadData()
        {

            if (!RepFlag)
            {
                string configFile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config");
                // Apply a gray professional renderer as a default renderer
                ToolStripManager.Renderer = oDefaultRenderer;
                oDefaultRenderer.RoundedEdges = false;

                // Set DockPanel properties
                dockPanel1.ActiveAutoHideContent = null;
                dockPanel1.Parent = this;
                VS2005Extender.VS2005Style.Extender.SetSchema(dockPanel1, VS2005Extender.VS2005Style.Extender.Schema.FromBase);

                dockPanel1.SuspendLayout(true);
                if (System.IO.File.Exists(configFile))
                {
                    dockPanel1.LoadFromXml(configFile, ReloadContent);

                }
                else
                {

                    // Load a basic layout
                    CreateBasicLayout();
                }
                dockPanel1.ResumeLayout(true, true);

                // Create a document
                //ShowNewForm(sender, e);
            }

            //dockPanel1.Width = this.Width - 22;
            ////dockPanel1.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            ////dockPanel1..StartPosition = FormStartPosition.Manual;
            //dockPanel1.Location = new Point(-17, 0); // Always opens the forms at 15,15
          



            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.
            this.uSER_FUNCTIONTableAdapter.Fill(this.nEWERPDataSet.USER_FUNCTION);
            // TODO: This line of code loads data into the 'nEWERPDataSet.FUNCTIONS' table. You can move, or remove it, as needed.
            this.fUNCTIONSTableAdapter.Fill(this.nEWERPDataSet.FUNCTIONS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.


            UserLogin frm = new UserLogin(); // áÊÔÛíá ÔÇÔÉ ÇáÊÌÑÈÉ ÇáÏíãæÇ
            frmStroes.MdiParent = this;
            DialogResult ret = frm.ShowDialog();
            if (ret == DialogResult.Cancel)
            {
                if (RepFlag)
                {
                    return;
                }
                else
                {
                    Application.ExitThread();
                }

            }

            else
            {
                ToolStripStatuslblAdv.Text = "ÈÑäÇãÌ ÇáãËÇáì"; ;
                ToolStatusLabelUser.Text = Messages.CurUser;
                ToolStripStatusDate.Text = DateTime.Today.ToShortDateString();// ToString("dd/MM/yyyy");
                ToolStripLabelDay.Text = DateTime.Today.DayOfWeek.ToString();
                StatusLblBranch.Text = Messages.CurBranchName;
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            if (nEWERPDataSet.setup.Rows.Count > 0)
            {
                if (nEWERPDataSet.setup.Rows[0]["boxaccid"].ToString() != "")
                {
                    Messages.boxAccid = int.Parse(nEWERPDataSet.setup.Rows[0]["boxaccid"].ToString());

                }
                if (nEWERPDataSet.setup.Rows[0]["accountid"].ToString() != "")
                {
                    Messages.accountidMainBox = int.Parse(nEWERPDataSet.setup.Rows[0]["accountid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["bankaccid"].ToString() != "")
                {
                    Messages.bankaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["bankaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["custaccid"].ToString() != "")
                {
                    Messages.custaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["custaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["suppaccid"].ToString() != "")
                {
                    Messages.suppaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["suppaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["salesaccid"].ToString() != "")
                {
                    Messages.salesaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["salesaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["salesAgalaccid"].ToString() != "")
                {
                    Messages.salesAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["salesAgalaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["purchaseAgalaccid"].ToString() != "")
                {
                    Messages.purchaseAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["purchaseAgalaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["Discountaccid"].ToString() != "")
                {
                    Messages.Discountaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["Discountaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["purchaseaccid"].ToString() != "")
                {
                    Messages.purchaseaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["purchaseaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["PurReorderaccid"].ToString() != "")
                {
                    Messages.PurReorderaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["PurReorderaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["SalReorderaccid"].ToString() != "")
                {
                    Messages.SalReorderaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["SalReorderaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["PurReorderAgalaccid"].ToString() != "")
                {
                    Messages.PurReorderAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["PurReorderAgalaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["SalReorderAgalaccid"].ToString() != "")
                {
                    Messages.SalReorderAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["SalReorderAgalaccid"].ToString());
                }


                if (nEWERPDataSet.setup.Rows[0]["Mainsalesaccid"].ToString() != "")
                {
                    Messages.MainSalesAccid = int.Parse(nEWERPDataSet.setup.Rows[0]["Mainsalesaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["MainPurchaseaccid"].ToString() != "")
                {
                    Messages.MainPurchaseaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["MainPurchaseaccid"].ToString());
                }


                if (nEWERPDataSet.setup.Rows[0]["Paymentsaccid"].ToString() != "")
                {
                    Messages.Paymentsaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["Paymentsaccid"].ToString());
                }


                if (nEWERPDataSet.setup.Rows[0]["OsalAccId"].ToString() != "")
                {
                    Messages.OsalAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["OsalAccId"].ToString());
                }


                if (nEWERPDataSet.setup.Rows[0]["DeductAccId"].ToString() != "")
                {
                    Messages.DeductAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["DeductAccId"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["SalesTakastaccid"].ToString() != "")
                {
                    Messages.SalesTakastaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["SalesTakastaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["MovmentProfitsAccid"].ToString() != "")
                {
                    Messages.MovmentProfitsAccid = int.Parse(nEWERPDataSet.setup.Rows[0]["MovmentProfitsAccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["StockAccId"].ToString() != "")
                {
                    Messages.StockAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["StockAccId"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["CostSalesProductAccId"].ToString() != "")
                {
                    Messages.CostSalesProductAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["CostSalesProductAccId"].ToString());
                }


                Messages.SysSupCode = nEWERPDataSet.SetupCodes.Rows[0]["SupCode"].ToString();
                Messages.SysCustCode = nEWERPDataSet.SetupCodes.Rows[0]["CustCode"].ToString();
                Messages.SysinvSaleCode = nEWERPDataSet.SetupCodes.Rows[0]["invSaleCode"].ToString();
                Messages.SysInvpurchasesCode = nEWERPDataSet.SetupCodes.Rows[0]["InvpurchasesCode"].ToString();
                Messages.SysStoresCode = nEWERPDataSet.SetupCodes.Rows[0]["StoresCode"].ToString();
                Messages.SysACCountCode = nEWERPDataSet.SetupCodes.Rows[0]["ACCountCode"].ToString();
                Messages.SysQid = nEWERPDataSet.SetupCodes.Rows[0]["Qid"].ToString();
                Messages.SysQidIn = nEWERPDataSet.SetupCodes.Rows[0]["QidIn"].ToString();
                Messages.SysQidOut = nEWERPDataSet.SetupCodes.Rows[0]["QidOut"].ToString();
                Messages.BranchCode = nEWERPDataSet.SetupCodes.Rows[0]["BranchCode"].ToString();
                OpenMenus();
                if (Messages.Usertype != Messages.AdminUser)
                {
                    ShowHideMenu();
                }
                else
                {
                    SetupMenuItem.Enabled = true;
                    UserSecMenuItem.Enabled = true;
                    OpenAccYearMItem.Enabled = true;
                    CloseAccYearMItem.Enabled = true;
                }
                try
                {
                    if (nEWERPDataSet.setup.Rows.Count > 0)
                    {
                        string FileName = Messages.BackGround; //nEWERPDataSet.setup.Rows[0]["logo"].ToString();
                        if (FileName != "")
                        {
                            // this.BackgroundImage = new System.Drawing.Bitmap(FileName);
                            this.BackgroundImage = Image.FromFile(FileName);

                        }

                    }

                }
                catch { }

                //BRANCHES  acc =new BRANCHES () ;
                //acc.LoadAll ();
                //dataGridView1.DataSource = acc.DefaultView;

            }
            SetArabLang();
            int FixHeight = 0;
            int FixWidth = 0;
            FixHeight = 1024;
            FixWidth = 768;
            //Resolution.CResolution ChangeRes768 = new Resolution.CResolution(FixHeight, FixWidth);
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RepFlag = false;
            LoadData();
            //InvoicesPayements();
        }
        private void InvoicesPayements()
        {
            if (frmSalInvoicesList == null || frmSalInvoicesList.IsDisposed)
            {
                frmSalInvoicesList = new InvoicesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmSalInvoicesList.LInvType = int.Parse(GLibrary.strarrInvType[1, 0].ToString());
            frmSalInvoicesList.CallFlag = false;
            frmSalInvoicesList.Show(dockPanel1);
            frmSalInvoicesList.Focus();
        }
        private  void SetLocale(string locale_name )
        {
        
           //Boolean  setting_locale = false;
          // ResourceManager resource_manager = new ResourceManager("ERPSYS.MainMenu", this.GetType().Assembly);
            //If setting_locale Then Exit Sub
            if (!this.Created) return; 
            //if (Thread.CurrentThread.CurrentCulture.Name == locale_name) return ;
           
            //setting_locale = true;

            // Make a CultureInfo.l
            System.Globalization .CultureInfo  culture_info =new   System.Globalization .CultureInfo  (locale_name) ;

           // Make the thread use this locale.
            Thread.CurrentThread.CurrentUICulture = culture_info;
            Thread.CurrentThread.CurrentCulture = culture_info;

            // Reload the form.
            if (this.components != null  ) this.components.Dispose();
            if (this.MdiChildren.Length > 0)
            {
                
                int len = MdiChildren.Length;
                for (int i = 0; i < len-1; i++)
                {
                    //DockContent.ActiveForm.Dispose();
                    this.MdiChildren[0].Dispose();
                }
            }
            this.Controls.Clear();
            this.InitializeComponent();
            //this.dockPanel1 = new WeifenLuo.WinFormsUI.DockPanel();
            MessageBox.Show("ãä ÝÖáß Þã ÈÛáÞ ÇáÈÑäÇãÌ Ëã ÇÝÊÍ ÇáÈÑäÇãÌ ãÑå ÇÎÑí");
            Application.ExitThread();
            
        }
  
        
    
        private void AddProductToolMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
            
        }
        private void AddProduct()
        {
            if (frmProductAdd == null || frmProductAdd.IsDisposed)
            {
                frmProductAdd = new ProductAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmProductAdd.EditFlag = false;
            frmProductAdd.Show(dockPanel1);

            //frmProductAdd.MdiParent = this;
         
            //frmProductAdd.Show();
            frmProductAdd.Focus();
        }
        private void ListPProductToolMenuItem_Click(object sender, EventArgs e)
        {
            ProductsList();
        }
        private void ProductsList()
        {
            if (frmProductListTree == null || frmProductListTree.IsDisposed)
            {
                frmProductListTree = new ProductsList();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmProductListTree.Show(dockPanel1);

            //frmProductListTree.MdiParent = this;
            //frmProductListTree.Show();
            frmProductListTree.Focus();
        }
        private void toolStroesMenuItem1_Click(object sender, EventArgs e)
        {
            StoresList();

        }
        private void StoresList()
        {
            if (frmStroes == null || frmStroes.IsDisposed)
            {
                frmStroes = new StroesAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmStroes.Show(dockPanel1);

            //frmStroes.MdiParent = this;
            //frmStroes.Show();
            frmStroes.Focus();
        }
        private void ToolLinkStoreMenuItem_Click(object sender, EventArgs e)
        {
            LinkProductsStores();
          
        }
        private void LinkProductsStores()
        {
            if (frmLnkStore == null || frmLnkStore.IsDisposed)
            {
                frmLnkStore = new LinkProductToStroe();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmLnkStore.Show(dockPanel1);

            //frmLnkStore.MdiParent = this;
            //frmLnkStore.Show();
            frmLnkStore.Focus();
        }
        private void GetOrderMenuItem_Click(object sender, EventArgs e)
        {
            GetOrder();
        }
        private void GetOrder()
        {
            if (frmGetOrder == null || frmGetOrder.IsDisposed)
            {
                frmGetOrder = new GetOrderAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmGetOrder.OrderType = 1;
            frmGetOrder.Show(dockPanel1);
            frmGetOrder.Focus();

            //frmGetOrder.MdiParent = this;
          
            //frmGetOrder.Show();
           
        }

        private void OutOrderMenuItem_Click(object sender, EventArgs e)
        {
            OutOrder();
        }
        private void OutOrder()
        {
            if (frmOrderAdd == null || frmOrderAdd.IsDisposed)
            {
                frmOrderAdd = new OrderAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmOrderAdd.InvType = Messages.InvSalesFlag;
            frmOrderAdd.Show(dockPanel1);

            //frmOrderAdd.MdiParent = this;
            //frmOrderAdd.InvType = Messages.InvSalesFlag;
            //frmOrderAdd.Show();
            frmOrderAdd.Focus();
        }
        private void CustomerToolMenuItem_Click(object sender, EventArgs e)
        {
            CustList();
          
        }
        private void CustList()
        {
            if (frmCustSupList == null || frmCustSupList.IsDisposed)
            {
                frmCustSupList = new CustSupList();
            }
            //frmCustSupList.MdiParent = this;
            frmCustSupList.SUPCUSTTYPE = Messages.CustFlag;

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmCustSupList.Show(dockPanel1);
            frmCustSupList.Focus();

            //frmCustSup.AddFlag = true;
            //frmCustSup.CustSupName = "khaled";
        }
        private void SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierList();
            
        }
        private void SupplierList()
        {
            if (frmCustSupList == null || frmCustSupList.IsDisposed)
            {
                frmCustSupList = new CustSupList();
            }
            //frmCustSupList.MdiParent = this;
            frmCustSupList.SUPCUSTTYPE = Messages.SupFlag;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmCustSupList.Show(dockPanel1);
            frmCustSupList.Focus();

            //frmCustSup.AddFlag = true;
            //frmCustSup.CustSupName = "khaled";
            //frmCustSupList.Show();
            //frmCustSupList.Focus();
        }
        private void InvPurchasesMenuItem_Click(object sender, EventArgs e)
        {
            AddInvPurchase();
        }
        private void AddInvPurchase()
        {
            if (frmInvoicePurchaseAdd == null || frmInvoicePurchaseAdd.IsDisposed)
            {
                frmInvoicePurchaseAdd = new InvoicePurchaseAdd();
            }
            //frmInvoicePurchaseAdd.MdiParent = this;
            frmInvoicePurchaseAdd.InvType = Messages.InvpurchasesFlag;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoicePurchaseAdd.Show(dockPanel1);
            frmInvoicePurchaseAdd.Focus();

            //frmInvoicePurchaseAdd.Show();
            //frmInvoicePurchaseAdd.Focus();
        }
        private void InvSalesMenuItem_Click(object sender, EventArgs e)
        {
            AddInvSales();
        }
        private void AddInvSales()
        {
            if (frmInvoiceAdd == null || frmInvoiceAdd.IsDisposed)
            {
                frmInvoiceAdd = new InvoiceAdd();
            }
            //frmInvoiceAdd.MdiParent = this;
            frmInvoiceAdd.InvType = Messages.InvSalesFlag;
            frmInvoiceAdd.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoiceAdd.Show(dockPanel1);
            frmInvoiceAdd.Focus();

            //frmInvoiceAdd.Show();
            //frmInvoiceAdd.Focus();
        }
        private void AccountTreeMenuItem_Click(object sender, EventArgs e)
        {

            AccountCard();
            //DisplayAccountTree();
            
        }
        private void AccountCard()
        {
            if (frmAccountAdd == null || frmAccountAdd.IsDisposed)
            {
                frmAccountAdd = new AccountAdd();
            }
            //frmAccountAdd.MdiParent = this;
            //frmAccountAdd.Show();
            //frmAccountAdd.Focus();
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmAccountAdd.Show(dockPanel1);
            frmAccountAdd.Focus();
           
        }

        private void DisplayAccountTree()
        {
            if (frmAccountTree == null || frmAccountTree.IsDisposed)
            {
                frmAccountTree = new AccountTree();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmAccountTree.Show(dockPanel1);
            frmAccountTree.Focus();

            //frmAccountTree.MdiParent = this;
            //frmAccountTree.Show();
            //frmAccountTree.Focus();
        }

        private void QidMenuItem_Click(object sender, EventArgs e)
        {
            AddQid();
            
        }
        private void AddQid()
        {
           
            if (frmQids == null || frmQids.IsDisposed)
            {
                frmQids = new QidsAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
           // frmQids.Text = frmQids.Text;
            frmQids.EditFlag = false;
            frmQids.bStart = false;
            frmQids.Show(dockPanel1);

            //frmQids.MdiParent = this;
            //frmQids.EditFlag = false;
            //frmQids.bStart = false;
            //frmQids.Show();
            frmQids.Focus();
        }
        private void OutQidMenuItem_Click(object sender, EventArgs e)
        {
            AddOutQid();
        }
        private void AddOutQid()
        {
            if (frmOutQid == null || frmOutQid.IsDisposed)
            {
                frmOutQid = new QidOutAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            // frmQids.Text = frmQids.Text;
            frmOutQid.EditFlag = false;
            frmOutQid.Show(dockPanel1);

            //frmOutQid.MdiParent = this;
            //frmOutQid.EditFlag = false;
            //frmOutQid.Show();
            frmOutQid.Focus();
        }
        private void InQidMenuItem_Click(object sender, EventArgs e)
        {
            AddInQid();
        }
        private void AddInQid()
        {
            if (frmInQid == null || frmInQid.IsDisposed)
            {
                frmInQid = new QidInAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInQid.EditFlag = false;
            frmInQid.Show(dockPanel1);

            //frmInQid.MdiParent = this;

            //frmInQid.Show();
            frmInQid.Focus();
        }
        private void SetupMenuItem_Click(object sender, EventArgs e)
        {
            if (frmSetup == null || frmSetup.IsDisposed)
            {
                frmSetup = new SetupAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmSetup.Show(dockPanel1);
            frmSetup.Focus();

            //frmSetup.MdiParent = this;
            //frmSetup.Show();
            //frmSetup.Focus();

        }

        private void ChangeBackMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

      
        private void LoadImage()
        {
        //shows OPEN FILE DIALOG for locating graphic files on the harddisk 
       //setting visible file filter
            openFileDialog1.Filter = "Images | *.bmp;*.tif;*.jpg;*.gif";
        //Show OPEN FILE DIALOG to user

            DialogResult ret = openFileDialog1.ShowDialog();
        if ( ret != DialogResult.Cancel) 
            {
            //Load located file to the picturebox
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            //Messages.BackGround
                uSERTableAdapter.FillById(nEWERPDataSet.USER,int.Parse (Messages.CurUserId));
                if (nEWERPDataSet.USER.Rows.Count > 0) 
                {
                    Messages.BackGround = openFileDialog1.FileName;
                    nEWERPDataSet.USER.Rows[0]["BackGround"] = openFileDialog1.FileName;
                    uSERBindingSource.EndEdit();
                    uSERTableAdapter.Update(nEWERPDataSet.USER);
                }
            }

        }

        private void ÎÑæÌToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
                this.Close();
            
        }

        private void QidMenuItemStart_Click(object sender, EventArgs e)
        {
            if (frmQidsStart == null || frmQidsStart.IsDisposed)
            {
                frmQidsStart = new QidsAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmQidsStart.EditFlag = false;
            frmQidsStart.bStart = true;
            frmQidsStart.Show(dockPanel1);
            frmQidsStart.Focus();

            //frmQidsStart.MdiParent = this;
            //frmQidsStart.EditFlag = false;
            //frmQidsStart.bStart = true;
            //frmQidsStart.Show();
            //frmQidsStart.Focus();
        }

        private void StockProductMenuItem_Click(object sender, EventArgs e)
        {
            ProductList();
        }
        private void ProductList()
        {
            if (frmStoresProducts == null || frmStoresProducts.IsDisposed)
            {
                frmStoresProducts = new StoresProducts();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmStoresProducts.Show(dockPanel1);
            frmStoresProducts.Focus();
            //frmStoresProducts.MdiParent = this;
            //frmStoresProducts.Show();
            //frmStoresProducts.Focus();
        }
        private void AccountSumMenuItem_Click(object sender, EventArgs e)
        {
            AccountSumFun();
        }
         private void AccountSumDetMItemRpt_Click(object sender, EventArgs e)
        {
            AccountSumDetFun();
        }

        private void AccountSumFun()
        {
            if (frmAccountSum == null || frmAccountSum.IsDisposed)
            {
                frmAccountSum = new AccountSum();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmAccountSum.Show(dockPanel1);
            frmAccountSum.Focus();

            //frmAccountSum.MdiParent = this;
            //frmAccountSum.Show();
            //frmAccountSum.Focus();
        }

        private void AccountSumDetFun()
        {
            if (frmAccountSumDetRpt == null || frmAccountSumDetRpt.IsDisposed)
            {
                frmAccountSumDetRpt = new AccountSumDetRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmAccountSumDetRpt.Show(dockPanel1);
            frmAccountSumDetRpt.Focus();

            //frmAccountSumDetRpt.MdiParent = this;
            //frmAccountSumDetRpt.Show();
            //frmAccountSumDetRpt.Focus();
        }
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox frm = new AboutBox();
            frm.ShowDialog();
        }

        private void ReorderInvSalMenuItem_Click(object sender, EventArgs e)
        {
            AddInvReorder();
        }
        private void AddInvReorder()
        {
            if (frmInvoiceSalReoderAdd == null || frmInvoiceSalReoderAdd.IsDisposed)
            {
                frmInvoiceSalReoderAdd = new InvoiceSalReoderAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoiceSalReoderAdd.InvType = Messages.InvSalesFlag;
            frmInvoiceSalReoderAdd.Show(dockPanel1);
            frmInvoiceSalReoderAdd.Focus();

            //frmInvoiceSalReoderAdd.MdiParent = this;
            //frmInvoiceSalReoderAdd.InvType = Messages.InvSalesFlag;
            //frmInvoiceSalReoderAdd.Show();
            //frmInvoiceSalReoderAdd.Focus();
        }
        private void ReorderInvPurMenuItem1_Click(object sender, EventArgs e)
        {
            AddInvReorderPur();
            
        }
        private void AddInvReorderPur()
        {
            if (frmInvoicePurReoderAdd == null || frmInvoicePurReoderAdd.IsDisposed)
            {
                frmInvoicePurReoderAdd = new InvoicePurReorderAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoicePurReoderAdd.InvType = Messages.InvpurchasesFlag;
            frmInvoicePurReoderAdd.Show(dockPanel1);
            frmInvoicePurReoderAdd.Focus();

            //frmInvoicePurReoderAdd.MdiParent = this;
            //frmInvoicePurReoderAdd.InvType = Messages.InvpurchasesFlag;
            //frmInvoicePurReoderAdd.Show();
            //frmInvoicePurReoderAdd.Focus();
        }
        private void CostCenterTreeMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCostCentersAdd == null || frmCostCentersAdd.IsDisposed)
            {
                frmCostCentersAdd = new CostCentersAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCostCentersAdd.Show(dockPanel1);
            frmCostCentersAdd.Focus();

            //frmCostCentersAdd.MdiParent = this;
            //frmCostCentersAdd.Show();
            //frmCostCentersAdd.Focus();
            
        }

        private void BalanceRefMenuItem_Click(object sender, EventArgs e)
        {
            BalanceRef();
        }
        private void BalanceRef()
        {
            if (frmAccountBalanceRef == null || frmAccountBalanceRef.IsDisposed)
            {
                frmAccountBalanceRef = new AccountBalanceRef();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountBalanceRef.Show(dockPanel1);
            frmAccountBalanceRef.Focus();

            //frmAccountBalanceRef.MdiParent = this;
            //frmAccountBalanceRef.Show();
            //frmAccountBalanceRef.Focus();
        }
        private void BalanceClosedMenuItem_Click(object sender, EventArgs e)
        {

            if (frmBudgetListShow == null || frmBudgetListShow.IsDisposed)
            {
                frmBudgetListShow = new BudgetListShow();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmBudgetListShow.Show(dockPanel1);
            frmBudgetListShow.Focus();

            //frmBudgetListShow.MdiParent = this;
            //frmBudgetListShow.Show();
            //frmBudgetListShow.Focus();

            //Form3 frm = new Form3();
            //frm.MdiParent = this;
            //frm.Show();
            //frm.Focus();
        }

        private void IncomeListMenuItem_Click(object sender, EventArgs e)
        {


            if (frmIncomeListShow == null || frmIncomeListShow.IsDisposed)
            {
                frmIncomeListShow = new IncomeListShow();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmIncomeListShow.Show(dockPanel1);
            frmIncomeListShow.Focus();

            //frmIncomeListShow.MdiParent = this;
            //frmIncomeListShow.Show();
            //frmIncomeListShow.Focus();

            //if (frmIncomeList == null || frmIncomeList.IsDisposed)
            //{
            //    frmIncomeList = new IncomeList();
            //}

            //frmIncomeList.MdiParent = this;
            //frmIncomeList.Show();
            //frmIncomeList.Focus();
        }

        private void ProductMoveMenuItem_Click(object sender, EventArgs e)
        {
            ProductMove();  
        }
        private void ProductMove()
        {
             if (frmProductRpt == null || frmProductRpt.IsDisposed)
            {
                frmProductRpt = new ProductRpt ();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmProductRpt.Show(dockPanel1);
            frmProductRpt.Focus();

            //frmProductRpt.MdiParent = this;
            //frmProductRpt.Show();
            //frmProductRpt.Focus();
        }
        private void ProductcheckMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmProductCheckRpt == null || frmProductCheckRpt.IsDisposed)
            //{
            //    frmProductCheckRpt = new ProductCheckRpt();
            //}
            //m_ChildFormNumber = m_ChildFormNumber + 1;

            //frmProductCheckRpt.Show(dockPanel1);
            //frmProductCheckRpt.Focus();
            productCheck();
            //frmProductCheckRpt.MdiParent = this;
            //frmProductCheckRpt.Show();
            //frmProductCheckRpt.Focus();
        }
        private void productCheck()

        {
            if (frmProductStoreCheckRpt == null || frmProductStoreCheckRpt.IsDisposed)
            {
                frmProductStoreCheckRpt = new ProductStoreCheckRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmProductStoreCheckRpt.Show(dockPanel1);
            frmProductStoreCheckRpt.Focus();
        }

        private void shortcutAccountTree_Click(object sender, SmartItemClickEventArgs e)
        {
            DisplayAccountTree();
        }

        private void shortcutNewQid_Click(object sender, SmartItemClickEventArgs e)
        {
            AddQid();
        }

        private void shortcutOutQid_Click(object sender, SmartItemClickEventArgs e)
        {
            AddOutQid();
        }

        private void shortcutInQid_Click(object sender, SmartItemClickEventArgs e)
        {
            AddInQid();
        }

        private void shortcutCustomers_Click(object sender, SmartItemClickEventArgs e)
        {
            CustList();
        }

        private void shortcutInvSales_Click(object sender, SmartItemClickEventArgs e)
        {
            AddInvSales();
        }

        private void shortcutInvReoderSal_Click(object sender, SmartItemClickEventArgs e)
        {
            AddInvReorder();
        }

        private void shortcutSuppliers_Click(object sender, SmartItemClickEventArgs e)
        {
            SupplierList();
        }

        private void shortcutInvPruches_Click(object sender, SmartItemClickEventArgs e)
        {
            AddInvPurchase();
        }

        private void shortcutInvReorderPur_Click(object sender, SmartItemClickEventArgs e)
        {
            AddInvReorderPur();
        }

        private void shortcutProductTree_Click(object sender, SmartItemClickEventArgs e)
        {
            ProductsList();
        }

        private void shortcutNewProduct_Click(object sender, SmartItemClickEventArgs e)
        {
            AddProduct();
        }

        private void shortcutProductList_Click(object sender, SmartItemClickEventArgs e)
        {
            ProductList();
        }

        private void shortcutStores_Click(object sender, SmartItemClickEventArgs e)
        {
            StoresList();
        }

        private void shortcutAddProductToStore_Click(object sender, SmartItemClickEventArgs e)
        {
            LinkProductsStores();
        }

        private void shortcutGetOrder_Click(object sender, SmartItemClickEventArgs e)
        {
            GetOrder(); 
        }

        private void shortcutOutOrder_Click(object sender, SmartItemClickEventArgs e)
        {
            OutOrder();
        }

        private void shortcut1TransOrder_Click(object sender, SmartItemClickEventArgs e)
        {
            if (frmStockMoveAdd == null || frmStockMoveAdd.IsDisposed)
            {
                frmStockMoveAdd = new StockMoveAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmStockMoveAdd.Show(dockPanel1);
            frmStockMoveAdd.Focus();

            //frmStockMoveAdd.MdiParent = this;
            //frmStockMoveAdd.Show();
            //frmStockMoveAdd.Focus();
        }

        private void StoreOrderMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStockMoveAdd == null || frmStockMoveAdd.IsDisposed)
            {
                frmStockMoveAdd = new StockMoveAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmStockMoveAdd.Show(dockPanel1);
            frmStockMoveAdd.Focus();

            //frmStockMoveAdd.MdiParent = this;
            //frmStockMoveAdd.Show();
            //frmStockMoveAdd.Focus();
            
        }

        private void ProductProfitRptMenuItem_Click(object sender, EventArgs e)
        {
            showProfitRpt();
        }
        private void showProfitRpt()
        {
            if (frmProductProfitRpt == null || frmProductProfitRpt.IsDisposed)
            {
                frmProductProfitRpt = new ProductProfitRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmProductProfitRpt.Show(dockPanel1);
            frmProductProfitRpt.Focus();

            //frmProductProfitRpt.MdiParent = this;
            //frmProductProfitRpt.Show();
            //frmProductProfitRpt.Focus();
        }

        private void InvoiceRefMenuItem_Click(object sender, EventArgs e)
        {
            InvRef();
            
        }
        private void InvRef()
        {
            if (frmInvoiceRefRpt == null || frmInvoiceRefRpt.IsDisposed)
            {
                frmInvoiceRefRpt = new InvoiceRefRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmInvoiceRefRpt.Show(dockPanel1);
            frmInvoiceRefRpt.Focus();

            //frmInvoiceRefRpt.MdiParent = this;
            //frmInvoiceRefRpt.Show();
            //frmInvoiceRefRpt.Focus();
        }
        private void UintsMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUnitsList == null || frmUnitsList.IsDisposed)
            {
                frmUnitsList = new UnitsList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmUnitsList.Show(dockPanel1);
            frmUnitsList.Focus();

            //frmUnitsList.MdiParent = this;
            //frmUnitsList.Show();
            //frmUnitsList.Focus();
        }

    
        private void ToolStripBtnAccTree_Click(object sender, EventArgs e)
        {
            AccountCard();
           // DisplayAccountTree();
        }

        private void ToolStripBtnProductTree_Click(object sender, EventArgs e)
        {
            AddProduct();
            //ProductsList();
        }

        private void ToolStripBtnInvSale_Click(object sender, EventArgs e)
        {
            AddInvSales();
        }

        private void StripButtonInvPur_Click(object sender, EventArgs e)
        {
            AddInvPurchase();
        }

        private void StripButtonQids_Click(object sender, EventArgs e)
        {
            AddQid();
        }

        private void ToolStripButtonOutQid_Click(object sender, EventArgs e)
        {
            AddOutQid();
        }

        private void ToolStripSplitInQid_ButtonClick(object sender, EventArgs e)
        {
            AddInQid();
        }

        private void TotalAmountButton_Click(object sender, EventArgs e)
        {
            AccountSumFun();
        }

        private void ToolStripBtnBalance_Click(object sender, EventArgs e)
        {
             BalanceRef();
        }

        private void ToolStripButtonCal_Click(object sender, EventArgs e)
        {
            StoresAnalysis();
            //System.Diagnostics.Process.Start("calc");
        }

        private void ToolStripBtnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void UserSecurityMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUserSec == null || frmUserSec.IsDisposed)
            {
                frmUserSec = new UserSec ();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmUserSec.Show(dockPanel1);
            frmUserSec.Focus();

            //frmUserSec.MdiParent = this;
            //frmUserSec.Show();
            //frmUserSec.Focus();
        }

        private void ShowHideMenu()
        {
            if (Messages.CurUserId != "")
            {
                uSER_FUNCTIONTableAdapter.FillByFunUserId(nEWERPDataSet.USER_FUNCTION, int.Parse(Messages.CurUserId));
                 
                for (int i = 0; i < nEWERPDataSet.USER_FUNCTION.Rows.Count; i++)
                {
                   
                    int FunId = int.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUNCTION_ID"].ToString());
                    int pos = fUNCTIONSBindingSource.Find("ID", FunId);
                    fUNCTIONSBindingSource.Position = pos;

                    string FunName = ((DataRowView)fUNCTIONSBindingSource.Current)["NAME"].ToString();
                    switch (FunName)
                    {
                        case "ProductCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                ProductCardMItem.Enabled = false;
                               // ProductTreeBtn.Enabled = false;
                             
                            }
                            break;
                        case "AccCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                AccCardMItem.Enabled = false;
                                //AccTreeBtn.Enabled = false;
                             //   shortcutAccountTree.Enabled = false;
                                AcounttreeMenuItem.Enabled = false;
                                

                            }
                            break;
                        case "BranchCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                BranchCardMItem.Enabled = false;
                            }
                            break;

                        case "CustSupCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                CustSupCardMItem.Enabled = false;
                            }
                            break;
                        case "StorCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                StorCardMItem.Enabled = false;
                            }
                            break;
                        case "SalManCardMItem":
                            SalManCardMItem.Enabled = false;
                            break;
                        case "CostCardMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                CostCardMItem.Enabled = false;
                            }
                            break;

                        case "QidMenuItemPublic":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                QidMenuItemPublic.Enabled = false;
                                //QidsBtn.Enabled = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"] != DBNull.Value)
                            {
                                Messages.SalQidPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"] != DBNull.Value)
                            {
                                Messages.SalQidPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                            }
                            else
                            {
                                Messages.SalQidPrim[1] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"] != DBNull.Value)
                            {
                                Messages.SalQidPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                            }
                            else
                            {
                                Messages.SalQidPrim[2] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"] != DBNull.Value)
                            {
                                Messages.SalQidPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                            }
                            else
                            {
                                Messages.SalQidPrim[3] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"] != DBNull.Value)
                            {
                                Messages.SalQidPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                            }
                            else
                            {
                                Messages.SalQidPrim[4] = false;
                            }

                            break;
                            //if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            //{
                            //    QidMenuItemPublic.Enabled = false;
                            //    QidsBtn.Enabled = false;
                            //    shortcutQid.Enabled = false;
                            //}
                            //break;
                        case "InQidMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                InQidMItem.Enabled = false;
                                //InQidBtn.Enabled = false;
                                //shortcutInQid.Enabled = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"] != DBNull.Value)
                            {
                                Messages.SalQidInPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"] != DBNull.Value)
                            {
                                Messages.SalQidInPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                            }
                            else
                            {
                                Messages.SalQidInPrim[1] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"] != DBNull.Value)
                            {
                                Messages.SalQidInPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                            }
                            else
                            {
                                Messages.SalQidInPrim[2] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"] != DBNull.Value)
                            {
                                Messages.SalQidInPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                            }
                            else
                            {
                                Messages.SalQidInPrim[3] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"] != DBNull.Value)
                            {
                                Messages.SalQidInPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                            }
                            else
                            {
                                Messages.SalQidInPrim[4] = false;
                            }

                            break;
                            //if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            //{
                            //    InQidMItem.Enabled = false;
                            //    InQidBtn.Enabled = false;
                            //    shortcutInQid.Enabled = false;
                            //}
                            //break;
                        case "OutQidMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                OutQidMItem.Enabled = false;
                                //OutQidBtn.Enabled = false;
                               
                               // shortcutOutQid.Enabled = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"] != DBNull.Value)
                            {
                                Messages.SalQidOutPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                            }

                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"] != DBNull.Value)
                            {
                                Messages.SalQidOutPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                            }
                            else
                            {
                                Messages.SalQidOutPrim[1] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"] != DBNull.Value)
                            {
                                Messages.SalQidOutPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                            }
                            else
                            {
                                Messages.SalQidOutPrim[2] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"] != DBNull.Value)
                            {
                                Messages.SalQidOutPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                            }
                            else
                            {
                                Messages.SalQidOutPrim[3] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"] != DBNull.Value)
                            {
                                Messages.SalQidOutPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                            }
                            else
                            {
                                Messages.SalQidOutPrim[4] = false;
                            }

                            break;
                            //if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            //{
                            //    OutQidMItem.Enabled = false;
                            //    OutQidBtn.Enabled = false;
                            //    shortcutOutQid.Enabled = false;
                            //}
                            //break;
                        case "QidMenuItemStart":

                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                QidMenuItemStart.Enabled = false;
                            }
                            break;
                        case "InvSalesMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                InvSalesMItem.Enabled = false;
                               // InvSaleBtn.Enabled = false;
                               // shortcutInvSales.Enabled = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"] != DBNull.Value)
                            {
                                Messages.SalInvPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                            }
                            else
                            {
                                Messages.SalInvPrim[0] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"] != DBNull.Value)
                            {
                                Messages.SalInvPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                            }
                            else
                            {
                                Messages.SalInvPrim[1] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"] != DBNull.Value)
                            {
                                Messages.SalInvPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                            }
                            else
                            {
                                Messages.SalInvPrim[2] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"] != DBNull.Value)
                            {
                                Messages.SalInvPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                            }
                            else
                            {
                                Messages.SalInvPrim[3] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"] != DBNull.Value)
                            {
                                Messages.SalInvPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                            }
                            else
                            {
                                Messages.SalInvPrim[4] = false;
                            }
                           //Messages.SalInvPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                           //Messages.SalInvPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                           //Messages.SalInvPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                           //Messages.SalInvPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                           //Messages.SalInvPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                           
                            break;
                        case "InvPurchasesMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                InvPurchasesMItem.Enabled = false;
                                //InvPurBtn.Enabled = false;
                               // shortcutInvPruches.Enabled = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"] != DBNull.Value)
                            {
                                Messages.PurInvPrim[0] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString());
                            }
                            else
                            {
                                Messages.PurInvPrim[0] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"] != DBNull.Value)
                            {
                                Messages.PurInvPrim[1] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FUpdate"].ToString());
                            }
                            else
                            {
                                Messages.PurInvPrim[1] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"] != DBNull.Value)
                            {
                                Messages.PurInvPrim[2] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FDel"].ToString());
                            }
                            else
                            {
                                Messages.PurInvPrim[2] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"] != DBNull.Value)
                            {
                                Messages.PurInvPrim[3] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FSave"].ToString());
                            }
                            else
                            {
                                Messages.PurInvPrim[3] = false;
                            }
                            if (nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"] != DBNull.Value)
                            {
                                Messages.PurInvPrim[4] = Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FCommit"].ToString());
                            }
                            else
                            {
                                Messages.PurInvPrim[4] = false;
                            }
                            break;
                        // case "StorFirstMItem":
                        //    StorFirstMItem.Enabled = false;
                        //   break;
                        case "ReorderInvSalMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                ReorderInvSalMItem.Enabled = false;
                                //ReorderInvSalButton.Enabled =false;
                                //shortcutInvReoderSal.Enabled = false;
                            }
                            break;
                        case "ReorderInvPurMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                ReorderInvPurMItem.Enabled = false;
                                //shortcutInvReorderPur.Enabled = false;
                            }
                            break;
                        case "LinkStoreMItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                LinkStoreMItem.Enabled = false;
                                CalBtn.Enabled = false;
                            }
                            break;
                        case "CurrencyMenuItem":
                            if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                            {
                                CurrencyMenuItem.Enabled = false;

                            }
                            break;

                        case "StoreOrderMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            StoreOrderMenuItem.Enabled = false;

                        }
                        break;




                   
                    //case "MangReportsMItem":
                    //    if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                    //    {
                    //        MangReportsMItem.Enabled = false;

                    //    }
                    //    break;

                    case "AcounttreeMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            AcounttreeMenuItem.Enabled = false;

                        }
                        break;

                    case "QidListMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            QidListMenuItem.Enabled = false;

                        }
                        break;
                    case "ProductTreeMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ProductTreeMenuItem.Enabled = false;

                        }
                        break;


                    case "ListProductMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ListProductMenuItem.Enabled = false;

                        }
                        break;

                    case "UintsMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            UintsMenuItem.Enabled = false;

                        }
                        break;


                    case "OutOrderMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            OutOrderMenuItem.Enabled = false;

                        }
                        break;

                    case "CustMoveMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustMoveMenuItem.Enabled = false;

                        }
                        break;

                    case "SearchSalInvMnuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SearchSalInvMnuItem.Enabled = false;

                        }
                        break;



                    case "GetOrderMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            GetOrderMenuItem.Enabled = false;

                        }
                        break;


                    case "PriceListMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            PriceListMenuItem.Enabled = false;

                        }
                        break;


                    case "SearchPurInvMnuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SearchPurInvMnuItem.Enabled = false;

                        }
                        break;

                    case "InstallRequiredMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            //InstallRequiredMenuItem.Enabled = false;

                        }
                        break;

                    case "InstallPaymentMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            //InstallPaymentMenuItem.Enabled = false;

                        }
                        break;

                    case "SelectInstallMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                           // SelectInstallMenuItem.Enabled = false;

                        }
                        break;

                    case "AccountSumMItemRpt":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                           // AccountSumMItemRpt.Enabled = false;
                            TotalAmountBtn.Enabled = false;
                        }
                        break;


                    case "AccountSumDetMItemRpt":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            AccountSumDetMItemRpt.Enabled = false;

                        }
                        break;

                    case "CustAcctSumMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustAcctSumMenuItem.Enabled = false;

                        }
                        break;


                    case "AccountSumProductsMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            AccountSumProductsMenuItem.Enabled = false;

                        }
                        break;


                    case "AcctSumWithDanMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            AcctSumWithDanMItem.Enabled = false;

                        }
                        break;

                    case "RefBalanceMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                           // RefBalanceMenuItem.Enabled = false;
                            BalanceBtn.Enabled = false;
                        }
                        break;


                    case "RefBalanceVerMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            RefBalanceVerMenuItem.Enabled = false;

                        }
                        break;



                    case "CustomerMoveMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustomerMoveMItem.Enabled = false;

                        }
                        break;

                    case "InQidsMItemRpt":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            InQidsMItemRpt.Enabled = false;

                        }
                        break;

                    case "OutQidsMItemRpt":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            OutQidsMItemRpt.Enabled = false;

                        }
                        break;

                    case "QidsMItemRpt":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            QidsMItemRpt.Enabled = false;

                        }
                        break;


                    case "IncomeListMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            IncomeListMenuItem.Enabled = false;

                        }
                        break;



                    case "BalanceClosedMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            BalanceClosedMenuItem.Enabled = false;

                        }
                        break;


                    case "PMovetoolMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            PMovetoolMenuItem.Enabled = false;

                        }
                        break;


                    case "PcollecttoolMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            OtherReport.Enabled = false;

                        }
                        break;

                    case "DailySalesMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            DailySalesMenuItem.Enabled = false;

                        }
                        break;


                    case "ProductProfitRptMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ProductProfitRptMenuItem.Enabled = false;

                        }
                        break;


                    case "InvoiceRefMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            //InvoiceRefMenuItem.Enabled = false;
                            InvoicesRefButton.Enabled = false;
                        }
                        break;

                    case "StoresAnyMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            StoresAnyMenuItem.Enabled = false;

                        }
                        break;

                    case "ProductMatchMnuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ProductProfitRptMenuItem.Enabled = false;

                        }
                        break;

                    case "StoreCheckMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            InvoicesRefButton.Enabled = false;

                        }
                        break;


                    case "CustomersSalesMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustomersSalesMItem.Enabled = false;

                        }
                        break;

                    case "CustomerAccountsMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustomerAccountsMenuItem.Enabled = false;

                        }
                        break;

                    case "supplierAccountsMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            supplierAccountsMenuItem.Enabled = false;

                        }
                        break;



                    case "SaleProductMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SaleProductMItem.Enabled = false;
                            DailySaltoolButton.Enabled = false;
                        }
                        break;



                    case "CitiesSalesMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CitiesSalesMenuItem.Enabled = false;

                        }
                        break;



                    case "ProductsAndStoresMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ProductsAndStoresMenuItem.Enabled = false;

                        }
                        break;


                    case "A3marDauanMonthMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            A3marDauanMonthMItem.Enabled = false;

                        }
                        break;


                    case "A3marDauanPeriodMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            A3marDauanPeriodMItem.Enabled = false;

                        }
                        break;


                    case "ChangeLangMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ChangeLangMenuItem.Enabled = false;

                        }
                        break;


                    case "UserSecMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            UserSecMenuItem.Enabled = false;

                        }
                        break;

                    case "SetupMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SetupMenuItem.Enabled = false;

                        }
                        break;






                    case "ChangePassMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ChangePassMItem.Enabled = false;

                        }
                        break;
                    case "ChangeBackMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            ChangeBackMItem.Enabled = false;

                        }
                        break;
                    case "smartOutlookShortcutBar":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                          //  smartShortcutBar.Enabled = false;

                        }
                        break;
                    case "CustomerMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            CustomerMenuItem.Enabled = false;

                        }
                        break;
                   
                    case "InvPaymentMItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            InvPaymentMItem.Enabled = false;

                        }
                        break;
                    case "SuppliersMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SuppliersMenuItem.Enabled = false;

                        }
                        break;
                    
                                    
                   

                    
                    case "SearchMovementMenuItem":
                        if (!Boolean.Parse(nEWERPDataSet.USER_FUNCTION.Rows[i]["FOpen"].ToString()))
                        {
                            SearchMovementMenuItem.Enabled = false;

                        }
                        break;
                    }
                    
                    
               
              }

            }
                
        }
        

        private void ChangeMItem_Click(object sender, EventArgs e)
        {
            if (frmChangeUserPassword == null || frmChangeUserPassword.IsDisposed)
            {
                frmChangeUserPassword = new ChangeUserPassword();
            }
            //m_ChildFormNumber = m_ChildFormNumber + 1;

            //frmChangeUserPassword.Show(dockPanel1);
            //frmChangeUserPassword.Focus();
            frmChangeUserPassword.ShowDialog();

            //frmChangeUserPassword.MdiParent = this;
            //frmChangeUserPassword.Show();
            //frmChangeUserPassword.Focus();

        }

        private void AcounttingMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAccountTree();
        }

        private void BranchCardMItem_Click(object sender, EventArgs e)
        {
            if (frmBranchesAdd == null || frmBranchesAdd.IsDisposed)
            {
                frmBranchesAdd = new BranchesAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmBranchesAdd.Show(dockPanel1);
            frmBranchesAdd.Focus();

            //frmBranchesAdd.MdiParent = this;
            //frmBranchesAdd.Show();
            //frmBranchesAdd.Focus();
            
        }

        private void InvPaymentMItem_Click(object sender, EventArgs e)
        {
            if (frmInvoicePayment == null || frmInvoicePayment.IsDisposed)
            {
                frmInvoicePayment = new InvoicePayment();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoicePayment.InvType = Messages.InvSalesFlag;
            frmInvoicePayment.Show(dockPanel1);
            frmInvoicePayment.Focus();

            //frmInvoicePayment.MdiParent = this;
            //frmInvoicePayment.Show();
            //frmInvoicePayment.Focus();
            
        }

        private void SalManCardMItem_Click(object sender, EventArgs e)
        {
            if (frmEmpSalesAdd == null || frmEmpSalesAdd.IsDisposed)
            {
                frmEmpSalesAdd = new EmpSalesAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmEmpSalesAdd.Show(dockPanel1);
            frmEmpSalesAdd.Focus();

            //frmEmpSalesAdd.MdiParent = this;
            //frmEmpSalesAdd.Show();
            //frmEmpSalesAdd.Focus();
            
        }

        private void AcctSumWithDanMItem_Click(object sender, EventArgs e)
        {
            if (frmAccountSumWithDanRpt == null || frmAccountSumWithDanRpt.IsDisposed)
            {
                frmAccountSumWithDanRpt = new AccountSumWithDanRpt();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountSumWithDanRpt.Show(dockPanel1);
            frmAccountSumWithDanRpt.Focus();

            //frmAccountSumWithDanRpt.MdiParent = this;
            //frmAccountSumWithDanRpt.Show();
            //frmAccountSumWithDanRpt.Focus();
          
        }

        private void CustomersSalesMItem_Click(object sender, EventArgs e)
        {
            if (frmCustomersSalesRpt == null || frmCustomersSalesRpt.IsDisposed)
            {
                frmCustomersSalesRpt = new CustomersSalesRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCustomersSalesRpt.Show(dockPanel1);
            frmCustomersSalesRpt.Focus();

            //frmCustomersSalesRpt.MdiParent = this;
            //frmCustomersSalesRpt.Show();
            //frmCustomersSalesRpt.Focus();
            
        }

        private void InQidsMItemRpt_Click(object sender, EventArgs e)
        {
            if (frmInQidsRpt == null || frmInQidsRpt.IsDisposed)
            {
                frmInQidsRpt = new QidsRpt();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInQidsRpt.Tilte = "ÊÞÑíÑ íæãí áÓäÏÇÊ ÇáÞÈÖ";
            frmInQidsRpt.choiceNum = 1;
            frmInQidsRpt.Show(dockPanel1);
            frmInQidsRpt.Focus();

            //frmInQidsRpt.MdiParent = this;
            //frmInQidsRpt.Tilte = "ÞÈÖ";
            //frmInQidsRpt.choiceNum = 1;   
            //frmInQidsRpt.Show();

            //frmInQidsRpt.Focus();
          
        }

        private void OutQidsMItemRpt_Click(object sender, EventArgs e)
        {
            if (frmOutQidsRpt == null || frmOutQidsRpt.IsDisposed)
            {
                frmOutQidsRpt = new QidsRpt();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmOutQidsRpt.Tilte = "ÊÞÑíÑ íæãí áÓäÏÇÊ ÇáÕÑÝ";
            frmOutQidsRpt.choiceNum = 2;
            frmOutQidsRpt.Show(dockPanel1);
            frmOutQidsRpt.Focus();

            //frmOutQidsRpt.MdiParent = this;
            //frmOutQidsRpt.Tilte = "ÕÑÝ";
            //frmOutQidsRpt.choiceNum = 2;  
            //frmOutQidsRpt.Show();
            //frmOutQidsRpt.Focus();
        }

        private void SaleProductMItem_Click(object sender, EventArgs e)
        {
            if (frmProductSalesRpt == null || frmProductSalesRpt.IsDisposed)
            {
                frmProductSalesRpt = new ProductSalesRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmProductSalesRpt.invType = 2;
            frmProductSalesRpt.Show(dockPanel1);
            frmProductSalesRpt.Focus();

            //frmProductSalesRpt.MdiParent = this;
            //frmProductSalesRpt.Show();
            //frmProductSalesRpt.Focus();
        }

        private void A3marDauanPeriodMItem_Click(object sender, EventArgs e)
        {
            if (frmAccountCustomerWithDanRpt == null || frmAccountCustomerWithDanRpt.IsDisposed)
            {
                frmAccountCustomerWithDanRpt = new AccountCustomerWithDanRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountCustomerWithDanRpt.Show(dockPanel1);
            frmAccountCustomerWithDanRpt.Focus();

            //frmAccountCustomerWithDanRpt.MdiParent = this;
            //frmAccountCustomerWithDanRpt.Show();
            //frmAccountCustomerWithDanRpt.Focus();
        
        }

        private void A3marDauanMonthMItem_Click(object sender, EventArgs e)
        {
            if (frmAccountCustomerDanWithMonthRpt == null || frmAccountCustomerDanWithMonthRpt.IsDisposed)
            {
                frmAccountCustomerDanWithMonthRpt = new AccountCustomerDanWithMonthRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountCustomerDanWithMonthRpt.Show(dockPanel1);
            frmAccountCustomerDanWithMonthRpt.Focus();

            //frmAccountCustomerDanWithMonthRpt.MdiParent = this;
            //frmAccountCustomerDanWithMonthRpt.Show();
            //frmAccountCustomerDanWithMonthRpt.Focus();
        }

        private void CustomerMoveMItem_Click(object sender, EventArgs e)
        {
            if (frmCustomersMoveRpt == null || frmCustomersMoveRpt.IsDisposed)
            {
                frmCustomersMoveRpt = new CustomersMoveRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCustomersMoveRpt.Show(dockPanel1);
            frmCustomersMoveRpt.Focus();

            //frmCustomersMoveRpt.MdiParent = this;
            //frmCustomersMoveRpt.Show();
            //frmCustomersMoveRpt.Focus();
        }

        private void StockGroupShortcuts_Click(object sender, SmartItemClickEventArgs e)
        {

        }

        private void ChangeLangMenuItem_Click(object sender, EventArgs e)
        {
            
            
            //if (Registry.GetValue(Messages.RegPath, "lang", "0") == null)
            //{
            //    Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang);
            //}
            //else if (Registry.GetValue(Messages.RegPath, "lang", "").ToString () == Messages.ArabLang)
            //{
            //    Registry.SetValue(Messages.RegPath, "lang", Messages.EngLang );
            //    SetLocale(Messages.EngLang);
            //   // GLibrary.SetFrm(this, Messages.EngLang);
            //   // ToolStrip1.RightToLeft = RightToLeft.No ;

            //}
            //else if (Registry.GetValue(Messages.RegPath, "lang", "").ToString () == Messages.EngLang )
            //{
            //    Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang );
            //    SetLocale(Messages.ArabLang);
            //    //GLibrary.SetFrm(this, Messages.ArabLang);
            //    //ToolStrip1.RightToLeft= RightToLeft.Yes;
            //}
           
        }
        private void SetArabLang()
        {
            if (Registry.GetValue(Messages.RegPath, "lang", "").ToString () == Messages.ArabLang)
            {
                ArabLangMenuItem.Enabled = false;
                EngLangMenuItem.Enabled =true ;
                Messages.CurLang = Messages.ArabLang;

            }
            else if(Registry.GetValue(Messages.RegPath, "lang", "").ToString () == Messages.EngLang)
            {
                ArabLangMenuItem.Enabled = true ;
                EngLangMenuItem.Enabled = false ;
                Messages.CurLang = Messages.EngLang;
            }
        }
        private void ArabLangMenuItem_Click(object sender, EventArgs e)
        {
            if (Registry.GetValue(Messages.RegPath, "lang", "0") == null)
            {
                Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang);
                Messages.CurLang = Messages.ArabLang;
            }
            //else if (Registry.GetValue(Messages.RegPath, "lang", "").ToString() == Messages.ArabLang)
            //{
            Registry.SetValue(Messages.RegPath, "lang", Messages.ArabLang);
            SetLocale(Messages.ArabLang);
                // GLibrary.SetFrm(this, Messages.EngLang);
                // ToolStrip1.RightToLeft = RightToLeft.No ;

            //}
            SetArabLang();
            if (Messages.Usertype != Messages.AdminUser)
            {
                ShowHideMenu();
            }
            else
            {
                SetupMenuItem.Enabled = true;
                UserSecMenuItem.Enabled = true;
                OpenAccYearMItem.Enabled = true;
                CloseAccYearMItem.Enabled = true;
            }

        }

        private void EngLangMenuItem_Click(object sender, EventArgs e)
        {
            if (Registry.GetValue(Messages.RegPath, "lang", "0") == null)
            {
                Registry.SetValue(Messages.RegPath, "lang", Messages.EngLang);
            }
            //else if (Registry.GetValue(Messages.RegPath, "lang", "").ToString() == Messages.EngLang)
            //{
            Registry.SetValue(Messages.RegPath, "lang", Messages.EngLang);
            SetLocale(Messages.EngLang);
                //GLibrary.SetFrm(this, Messages.ArabLang);
                //ToolStrip1.RightToLeft= RightToLeft.Yes;
            //}
            SetArabLang();

            if (Messages.Usertype != Messages.AdminUser)
            {
                ShowHideMenu();
            }
            else
            {
                SetupMenuItem.Enabled = true;
                UserSecMenuItem.Enabled = true;
                OpenAccYearMItem.Enabled = true;
                CloseAccYearMItem.Enabled = true;
            }
        }

        private void RefBalanceVerMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAccountBalanceRefVer == null || frmAccountBalanceRefVer.IsDisposed)
            {
                frmAccountBalanceRefVer = new AccountBalanceRefVer();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountBalanceRefVer.Show(dockPanel1);
            frmAccountBalanceRefVer.Focus();

            //frmAccountBalanceRefVer.MdiParent = this;
            //frmAccountBalanceRefVer.Show();
            //frmAccountBalanceRefVer.Focus();
        }

        private void QidsMItemRpt_Click(object sender, EventArgs e)
        {
            if (frmOutQidsRpt == null || frmOutQidsRpt.IsDisposed)
            {
                frmOutQidsRpt = new QidsRpt();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmOutQidsRpt.Tilte = "ÊÞÑíÑ íæãí áÓäÏÇÊ ÇáÞíæÏ";
            frmOutQidsRpt.choiceNum = 3;
            frmOutQidsRpt.Show(dockPanel1);
            frmOutQidsRpt.Focus();

            //frmOutQidsRpt.MdiParent = this;
           
            //frmOutQidsRpt.Show();
            //frmOutQidsRpt.Focus();
        }

       

        private void ProductMoveButton_Click(object sender, EventArgs e)
        {
            InvRef();
            //ProductMove(); 
        }

        private void ProductMatchMnuItem_Click(object sender, EventArgs e)
        {
            if (frmProductMatchRpt == null || frmProductMatchRpt.IsDisposed)
            {
                frmProductMatchRpt = new ProductMatchRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmProductMatchRpt.Show(dockPanel1);
            frmProductMatchRpt.Focus();

            //frmProductMatchRpt.MdiParent = this;
            //frmProductMatchRpt.Show();
            //frmProductMatchRpt.Focus();
        }

        private void CustSupCardMItem_Click(object sender, EventArgs e)
        {
            CustList();
        }

        private void SearchSalInvMnuItem_Click(object sender, EventArgs e)
        {
            if (frmSalInvoicesList == null || frmSalInvoicesList.IsDisposed)
            {
                frmSalInvoicesList = new InvoicesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmSalInvoicesList.LInvType = int.Parse(GLibrary.strarrInvType[1, 0].ToString());
            frmSalInvoicesList.Show(dockPanel1);
            frmSalInvoicesList.Focus();

          
            //frmSalInvoicesList.MdiParent = this;
            //frmSalInvoicesList.Show();
            //frmSalInvoicesList.Focus();
            
        }

        private void SearchPurInvMnuItem_Click(object sender, EventArgs e)
        {
            if (frmPurInvoicesList == null || frmPurInvoicesList.IsDisposed)
            {
                frmPurInvoicesList = new InvoicesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmPurInvoicesList.LInvType = int.Parse(GLibrary.strarrInvType[0, 0].ToString());
            frmPurInvoicesList.Show(dockPanel1);
            frmPurInvoicesList.Focus();

            //frmPurInvoicesList.LInvType = int.Parse(GLibrary.strarrInvType[0, 0].ToString());
            //frmPurInvoicesList.MdiParent = this;
            //frmPurInvoicesList.Show();
            //frmPurInvoicesList.Focus();
        }

        private void EmpDataMnuItem_Click(object sender, EventArgs e)
        {
            if (frmEMPDATAAdd == null || frmEMPDATAAdd.IsDisposed)
            {
                frmEMPDATAAdd = new EMP_DATA_Add();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmEMPDATAAdd.Show(dockPanel1);
            frmEMPDATAAdd.Focus();

            //frmEMPDATAAdd.MdiParent = this;
            //frmEMPDATAAdd.Show();
            //frmEMPDATAAdd.Focus();
        }

        private void EmpPayrollMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEMPPayRal == null || frmEMPPayRal.IsDisposed)
            {
                frmEMPPayRal = new EMPPayRal();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmEMPPayRal.Show(dockPanel1);
            frmEMPPayRal.Focus();

            //frmEMPPayRal.MdiParent = this;
            //frmEMPPayRal.Show();
            //frmEMPPayRal.Focus();
        }

        private void DeptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDeptList == null || frmDeptList.IsDisposed)
            {
                frmDeptList = new DeptList();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmDeptList.Show(dockPanel1);
            frmDeptList.Focus();

            //frmDeptList.MdiParent = this;
            //frmDeptList.Show();
            //frmDeptList.Focus();
        }

        private void VacationMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVactionTypesList == null || frmVactionTypesList.IsDisposed)
            {
                frmVactionTypesList = new VactionTypesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmVactionTypesList.Show(dockPanel1);
            frmVactionTypesList.Focus();

            //frmVactionTypesList.MdiParent = this;
            //frmVactionTypesList.Show();
            //frmVactionTypesList.Focus();
        }

        private void PENALTYMenuItem_Click(object sender, EventArgs e)
        {

            if (frmPENALTYList == null || frmPENALTYList.IsDisposed)
            {
                frmPENALTYList = new PENALTYList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmPENALTYList.Show(dockPanel1);
            frmPENALTYList.Focus();

            //frmPENALTYList.MdiParent = this;
            //frmPENALTYList.Show();
            //frmPENALTYList.Focus();
        }

        private void SearchMovementMenuItem_Click(object sender, EventArgs e)
        {
            if (frmStockMoveSearchList == null || frmStockMoveSearchList.IsDisposed)
            {
                frmStockMoveSearchList = new StockMoveSearchList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmStockMoveSearchList.Show(dockPanel1);
            frmStockMoveSearchList.Focus();

            //frmStockMoveSearchList.MdiParent = this;
            //frmStockMoveSearchList.Show();
            //frmStockMoveSearchList.Focus();
        }

        private void PriceListMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPriceListAdd == null || frmPriceListAdd.IsDisposed)
            {
                frmPriceListAdd = new PriceListAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmPriceListAdd.InvType = Messages.InvSalesFlag;
            frmPriceListAdd.Show(dockPanel1);
            frmPriceListAdd.Focus();

            //frmPriceListAdd.MdiParent = this;
            //frmPriceListAdd.InvType = Messages.InvSalesFlag;
            //frmPriceListAdd.Show();
            //frmPriceListAdd.Focus();
        }

        private void DailySalesMenuItem_Click(object sender, EventArgs e)
        {
            DailySales();
        }
        private void DailySales()
        {
            if (frmDailySalesRpt == null || frmDailySalesRpt.IsDisposed)
            {
                frmDailySalesRpt = new DailySalesRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmDailySalesRpt.Show(dockPanel1);
            frmDailySalesRpt.Focus();

            //frmDailySalesRpt.MdiParent = this;
            //frmDailySalesRpt.Show();
            //frmDailySalesRpt.Focus();
        }

        private void DailySaltoolButton_Click(object sender, EventArgs e)
        {
            DailySales();
        }

        private void InstallRequiredMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInstallmentRequiredAdd == null || frmInstallmentRequiredAdd.IsDisposed)
            {
                frmInstallmentRequiredAdd = new InstallmentRequiredAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmInstallmentRequiredAdd.Show(dockPanel1);
            frmInstallmentRequiredAdd.Focus();

            //frmInstallmentRequiredAdd.MdiParent = this;
            //frmInstallmentRequiredAdd.Show();
            //frmInstallmentRequiredAdd.Focus();
        }

        private void InstallPaymentMenuItem_Click(object sender, EventArgs e)
        {

            if (frmInstallmentPaymentAdd == null || frmInstallmentPaymentAdd.IsDisposed)
            {
                frmInstallmentPaymentAdd = new InstallmentPaymentAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmInstallmentPaymentAdd.Show(dockPanel1);
            frmInstallmentPaymentAdd.Focus();

            //frmInstallmentPaymentAdd.MdiParent = this;
            //frmInstallmentPaymentAdd.Show();
            //frmInstallmentPaymentAdd.Focus();
        }

        private void SelectInstallMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInstallmentSelect == null || frmInstallmentSelect.IsDisposed)
            {
                frmInstallmentSelect = new InstallmentSelect();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmInstallmentSelect.Show(dockPanel1);
            frmInstallmentSelect.Focus();

            //frmInstallmentSelect.MdiParent = this;
            //frmInstallmentSelect.Show();
            //frmInstallmentSelect.Focus();
            
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
          DialogResult ret;
            ret = MessageBox.Show(Messages.ConfirmExitMesg, "ÎÑæÌ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (ret != DialogResult.Yes)
            {
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false ;
            }

        }

        private void AccountSumProductsMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAccountSumProdcutDetRpt == null || frmAccountSumProdcutDetRpt.IsDisposed)
            {
                frmAccountSumProdcutDetRpt = new AccountSumProdcutDetRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmAccountSumProdcutDetRpt.Show(dockPanel1);
            frmAccountSumProdcutDetRpt.Focus();


            //frmAccountSumProdcutDetRpt.MdiParent = this;
            //frmAccountSumProdcutDetRpt.Show();
            //frmAccountSumProdcutDetRpt.Focus();
        }

        private void GroupsMnuItem_Click(object sender, EventArgs e)
        {
            if (frmGroupsList == null || frmGroupsList.IsDisposed)
            {
                frmGroupsList = new GroupsList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmGroupsList.Show(dockPanel1);
            frmGroupsList.Focus();

            //frmGroupsList.MdiParent = this;
            //frmGroupsList.Show();
            //frmGroupsList.Focus();
            
        }

        private void OpenAccYearMItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseAccYearMItem_Click(object sender, EventArgs e)
        {
            if (frmIncomeClosedShow == null || frmIncomeClosedShow.IsDisposed)
            {
                frmIncomeClosedShow = new IncomeClosedShow();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmIncomeClosedShow.Show(dockPanel1);
            frmIncomeClosedShow.Focus();

            //frmIncomeClosedShow.MdiParent = this;
            //frmIncomeClosedShow.Show();
            //frmIncomeClosedShow.Focus();
            
        }

        private void CreateNEwDBMnuItem_Click(object sender, EventArgs e)
        {
            DbList frm = new DbList();
            frm.ShowDialog();
        }

        private void ChangeDbMnuItem_Click(object sender, EventArgs e)
        {
            DbChangeList frm = new DbChangeList();
            frm.ShowDialog();  
            
        }

        private void CurrencyMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCurrencyList == null || frmCurrencyList.IsDisposed)
            {
                frmCurrencyList = new CurrencyList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCurrencyList.Show(dockPanel1);
            frmCurrencyList.Focus();

            //frmCurrencyList.MdiParent = this;
            //frmCurrencyList.Show();
            //frmCurrencyList.Focus();
        }

        private void CustMoveMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCustomersSalesRpt == null || frmCustomersSalesRpt.IsDisposed)
            {
                frmCustomersSalesRpt = new CustomersSalesRpt();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCustomersSalesRpt.Show(dockPanel1);
            frmCustomersSalesRpt.Focus();

            //frmCustomersSalesRpt.MdiParent = this;
            //frmCustomersSalesRpt.Show();
            //frmCustomersSalesRpt.Focus();
        }

        private void shortcutCustMoving_Click(object sender, SmartItemClickEventArgs e)
        {
            if (frmCustomersSalesRpt == null || frmCustomersSalesRpt.IsDisposed)
            {
                frmCustomersSalesRpt = new CustomersSalesRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmCustomersSalesRpt.Show(dockPanel1);
            frmCustomersSalesRpt.Focus();


            //frmCustomersSalesRpt.MdiParent = this;
            //frmCustomersSalesRpt.Show();
            //frmCustomersSalesRpt.Focus();
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Cursor cr = Cursor.Current;
                Cursor.Current = Cursors.SizeAll;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LeavEntryMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVacationAdd == null || frmVacationAdd.IsDisposed)
            {
                frmVacationAdd = new VacationAdd();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmVacationAdd.Show(dockPanel1);
            frmVacationAdd.Focus();
        }

        private void EmpRptMenuItem_Click(object sender, EventArgs e)
        {
            PersonalDataSet personalDataSet=new PersonalDataSet ();
            PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter pER_EMPLOYEE_DATATableAdapter =new PersonalDataSetTableAdapters.PER_EMPLOYEE_DATATableAdapter ();
            PersonalDataSetTableAdapters.CDE_DEPTTableAdapter cDE_DEPTTableAdapter = new PersonalDataSetTableAdapters.CDE_DEPTTableAdapter();
            cDE_DEPTTableAdapter.Fill(personalDataSet.CDE_DEPT);
            pER_EMPLOYEE_DATATableAdapter.Fill(personalDataSet.PER_EMPLOYEE_DATA);
            ShowEmpRpt frm = new ShowEmpRpt();
            frm.choiceNum = 1;
            frm.personalDataSet = personalDataSet;
            //frm.MdiParent = this;
            frm.ShowDialog ();
            frm.Focus();
        }

        private void CitiesSalesMenuItem_Click(object sender, EventArgs e)
        {
            
            if (frmDailySalesNewRpt == null || frmDailySalesNewRpt.IsDisposed)
            {
                frmDailySalesNewRpt = new DailySalesNew();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmDailySalesNewRpt.Show(dockPanel1);
            frmDailySalesNewRpt.Focus();

            //frmDailySalesNewRpt.MdiParent = this;
            //frmDailySalesNewRpt.Show();
            //frmDailySalesNewRpt.Focus();
       
        }

        private void StoresAnyMenuItem_Click(object sender, EventArgs e)
        {
            StoresAnalysis();
        }
        private void StoresAnalysis()
        {
            if (frmProductStroesList == null || frmProductStroesList.IsDisposed)
            {
                frmProductStroesList = new ProductStroesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmProductStroesList.Show(dockPanel1);
            frmProductStroesList.Focus();
        }

        private void LoanRptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum =3;
            frmEmpAbsencesRpt.title = "ÊÞÇíÑ ÓáÝ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
            
        }

        private void ABSENCERptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum = 4;
            frmEmpAbsencesRpt.title = "ÊÞÇíÑ ÛíÇÈ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
        }

        private void DiscountRptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum = 5;
            frmEmpAbsencesRpt.title = "ÊÞÇíÑ ÎÕæãÇÊ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
        }

        private void AllowancesRptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum = 6;
            frmEmpAbsencesRpt.title = "ÊÞÇÑíÑ ãßÇÝÇÊ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Text = "ÊÞÇÑíÑ ãßÇÝÇÊ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
        }

        private void VactionRptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum = 7;
            frmEmpAbsencesRpt.title = "ÊÞÇÑíÑ ÇÌÇÒÇÊ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
        }

        private void SalaryEmpRptMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpAbsencesRpt == null || frmEmpAbsencesRpt.IsDisposed)
            {
                frmEmpAbsencesRpt = new EmpRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpAbsencesRpt.choiceNum = 8;
            frmEmpAbsencesRpt.title = "ÊÞÇÑíÑ ÑæÇÊÈ ÇáãæÙÝíä";
            frmEmpAbsencesRpt.Show(dockPanel1);
            frmEmpAbsencesRpt.Focus();
        }

        private void EmpExpiredenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpExpireList == null || frmEmpExpireList.IsDisposed)
            {
                frmEmpExpireList = new EmpExpireList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmEmpExpireList.Show(dockPanel1);
            frmEmpExpireList.Focus();
            
        }

        private void QidListMenuItem_Click(object sender, EventArgs e)
        {
            if (frmQidsList == null || frmQidsList.IsDisposed)
            {
                frmQidsList = new QidsList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmQidsList.Show(dockPanel1);
            frmQidsList.Focus();

          //  frmQidsList.MdiParent = this;
            //frmQidsList.Show();
            //frmQidsList.Focus();
        }

        private void FormsMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpForms == null || frmEmpForms.IsDisposed)
            {
                frmEmpForms = new EmpForms();
            }
            //m_ChildFormNumber = m_ChildFormNumber + 1;
            //frmEmpForms.MdiParent = this;
            frmEmpForms.ShowDialog ();
            frmEmpForms.Focus();
           

        }

        private void CustAcctSumMenuItem_Click(object sender, EventArgs e)
        {
            if (frmAccountSumCustomer == null || frmAccountSumCustomer.IsDisposed)
            {
                frmAccountSumCustomer = new AccountSumCustomer();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmAccountSumCustomer.Show(dockPanel1);
            frmAccountSumCustomer.Focus();

        }

        private void ProductsAndStoresMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProductStroesSalesList == null || frmProductStroesSalesList.IsDisposed)
            {
                frmProductStroesSalesList = new ProductStroesSalesList();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmProductStroesSalesList.Show(dockPanel1);
            frmProductStroesSalesList.Focus();
            
        }

        private void StoreCheckMenuItem_Click(object sender, EventArgs e)
        {
            //if (frmProductStoreCheckRpt == null || frmProductStoreCheckRpt.IsDisposed)
            //{
            //    frmProductStoreCheckRpt = new ProductStoreCheckRpt();
            //}
            //m_ChildFormNumber = m_ChildFormNumber + 1;

            //frmProductStoreCheckRpt.Show(dockPanel1);
            //frmProductStoreCheckRpt.Focus();
            productCheck();
        }

        private void CustomerAccountsMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCustomersSupplierSalesRpt == null || frmCustomersSupplierSalesRpt.IsDisposed)
            {
                frmCustomersSupplierSalesRpt = new CustomersSupplierSalesRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmCustomersSupplierSalesRpt.choicenum = 1;
            frmCustomersSupplierSalesRpt.Show(dockPanel1);
            frmCustomersSupplierSalesRpt.Focus();
        }

        private void supplierAccountsMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCustomersSupplierSalesRpt1 == null || frmCustomersSupplierSalesRpt1.IsDisposed)
            {
                frmCustomersSupplierSalesRpt1 = new CustomersSupplierSalesRpt();
            }
            
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmCustomersSupplierSalesRpt1.choicenum = 2;
            frmCustomersSupplierSalesRpt1.Show(dockPanel1);
            frmCustomersSupplierSalesRpt1.Focus();
        }

        private void ReLoginMItem_Click(object sender, EventArgs e)
        {
            RepFlag = true;
            LoadData();
        }
        private void OpenMenus()
        {


             

            AccCardMItem.Enabled = true;
           // shortcutAccountTree.Enabled = true;
            AcounttreeMenuItem.Enabled = true;


            BranchCardMItem.Enabled = true;

            CostCardMItem.Enabled = true;

            QidMenuItemPublic.Enabled = true;
            //shortcutQid.Enabled = true;


            InQidMItem.Enabled = true;

           // shortcutInQid.Enabled = true;

            OutQidMItem.Enabled = true;

          //  shortcutOutQid.Enabled = true;


            QidMenuItemStart.Enabled = true;

            InvSalesMItem.Enabled = true;
            //InvSaleBtn.Enabled = true;
         
            //shortcutInvSales.Enabled = true;

            CurrencyMenuItem.Enabled = true;

            AcounttreeMenuItem.Enabled = true;


            QidListMenuItem.Enabled = true;


            SearchSalInvMnuItem.Enabled = true;


            //AccountSumMItemRpt.Enabled = true;
    

            AccountSumDetMItemRpt.Enabled = true;


            CustAcctSumMenuItem.Enabled = true;


            AccountSumProductsMenuItem.Enabled = true;


            AcctSumWithDanMItem.Enabled = true;


            //RefBalanceMenuItem.Enabled = true;


            RefBalanceVerMenuItem.Enabled = true;


            CustomerMoveMItem.Enabled = true;


            InQidsMItemRpt.Enabled = true;


            OutQidsMItemRpt.Enabled = true;


            QidsMItemRpt.Enabled = true;


            IncomeListMenuItem.Enabled = true;

            BalanceClosedMenuItem.Enabled = true;


            ChangeLangMenuItem.Enabled = true;


            UserSecMenuItem.Enabled = true;


            SetupMenuItem.Enabled = true;


            ChangePassMItem.Enabled = true;



            ChangeBackMItem.Enabled = true;

            //smartShortcutBar.Enabled = true;

            InvPaymentMItem.Enabled = true;
         

            HRMItem.Visible = true;

            





        }

        private void UserSwitchBtn_Click(object sender, EventArgs e)
        {
            RepFlag = true;
            LoadData();
        }

        private void NatMenuItem_Click(object sender, EventArgs e)
        {
            if (frmNatList == null || frmNatList.IsDisposed)
            {
                frmNatList = new NatList();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmNatList.Show(dockPanel1);
            frmNatList.Focus();
        }

        private void EmpListMenuItem_Click(object sender, EventArgs e)
        {
            if (frmEmpList == null || frmEmpList.IsDisposed)
            {
                frmEmpList = new EmpList();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmEmpList.Show(dockPanel1);
            frmEmpList.Focus();

            
        }

        private void ReodersAddMenuItem_Click(object sender, EventArgs e)
        {
            if (frmReoderInvoicesList == null || frmReoderInvoicesList.IsDisposed)
            {
                frmReoderInvoicesList = new ReoderInvoicesAdd();
            }
            frmReoderInvoicesList.LInvType = int.Parse(GLibrary.strarrInvType[1, 0].ToString());
            frmReoderInvoicesList.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmReoderInvoicesList.Show(dockPanel1);
            frmReoderInvoicesList.Focus();

        }

        private void ReoderListMenuItem_Click(object sender, EventArgs e)
        {

            if (frmReorderInvList == null || frmReorderInvList.IsDisposed)
            {
                frmReorderInvList = new ReorderInvList();
            }

            frmReorderInvList.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmReorderInvList.Show(dockPanel1);
            frmReorderInvList.Focus();
        }

        private void PartionMenuItem_Click(object sender, EventArgs e)
        {
            ShowParition();
        }
        private void ShowParition()
        {
            if (frmParitionStockAdd == null || frmParitionStockAdd.IsDisposed)
            {
                frmParitionStockAdd = new ParitionStockAdd();
            }

            frmParitionStockAdd.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmParitionStockAdd.Show(dockPanel1);
            frmParitionStockAdd.Focus();
        }
        private void PartionListMenuItem_Click(object sender, EventArgs e)
        {
            if (frmParitionSearchList == null || frmParitionSearchList.IsDisposed)
            {
                frmParitionSearchList = new ParitionSearchList();
            }

            frmParitionSearchList.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmParitionSearchList.Show(dockPanel1);
            frmParitionSearchList.Focus();
            
        }

        private void PartionMenuButton_Click(object sender, EventArgs e)
        {
            ShowParition();
        }

        private void HomeCustBtn_Click(object sender, EventArgs e)
        {
            //frmHomeCustomerAdd = new HomeCustomerAdd();
            //frmHomeCustomerAdd.ShowDialog ();
            if (frmHomeCustomerAdd == null || frmHomeCustomerAdd.IsDisposed)
            {
                frmHomeCustomerAdd = new HomeCustomerAdd();
            }


            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmHomeCustomerAdd.Show(dockPanel1);
            frmHomeCustomerAdd.Focus();
        }

        private void ReorderInvSalButton_Click(object sender, EventArgs e)
        {
            AddInvReorder();
        }

        private void ãÎÇÒäToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InvPurReturnMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInvoicePurchaseReorderAdd == null || frmInvoicePurchaseReorderAdd.IsDisposed)
            {
                frmInvoicePurchaseReorderAdd = new InvoicePurchaseReorderAdd();
            }
            //frmInvoicePurchaseAdd.MdiParent = this;
            frmInvoicePurchaseReorderAdd.InvType = Messages.InvpurchasesReturnFlag;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoicePurchaseReorderAdd.Show(dockPanel1);
            frmInvoicePurchaseReorderAdd.Focus();
            frmInvoicePurchaseReorderAdd.ReorderFlag = 1;
            frmInvoicePurchaseReorderAdd.Text = "ÝÇÊæÑÉ ãÑÊÌÚ";
            frmInvoicePurchaseReorderAdd.TabText = "ÝÇÊæÑÉ ãÑÊÌÚ";
            
        }

        private void dockPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InvOutMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInvoicePurchasePayment == null || frmSalInvoicesList.IsDisposed)
            {
                frmInvoicePurchasePayment = new InvoicePurchasePayment();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoicePurchasePayment.InvType = int.Parse(GLibrary.strarrInvType[0, 0].ToString());
            frmInvoicePurchasePayment.Show(dockPanel1);
            frmInvoicePurchasePayment.Focus();
        }

        private void InventoryCalMenuItem_Click(object sender, EventArgs e)
        {
            if (frmInventoryCheckProduct == null || frmInventoryCheckProduct.IsDisposed)
            {
                frmInventoryCheckProduct = new InventoryCheckProduct();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;

            frmInventoryCheckProduct.Show(dockPanel1);

            frmInventoryCheckProduct.Focus();
        }

        private void OrderOutMenuItem_Click(object sender, EventArgs e)
        {
            if (frmOrderOutAdd == null || frmOrderOutAdd.IsDisposed)
            {
                frmOrderOutAdd = new OrderOutAdd();
            }

            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmOrderOutAdd.InvType = Messages.InvpurchasesFlag;
            frmOrderOutAdd.Show(dockPanel1);

            //frmOrderAdd.MdiParent = this;
            //frmOrderAdd.InvType = Messages.InvSalesFlag;
            //frmOrderAdd.Show();
            frmOrderOutAdd.Focus();
            
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            

            if (frmAccountAdd == null || frmAccountAdd.IsDisposed)
            {
                frmAccountAdd = new AccountAdd();
            }
            //frmAccountAdd.MdiParent = this;
            //frmAccountAdd.Show();
            //frmAccountAdd.Focus();
            //m_ChildFormNumber = m_ChildFormNumber + 1;
            //frmAccountAdd.Show(dockPanel1);
            //frmAccountAdd.Focus();

          
                //frmAccountAdd.MdiParent = this;
                m_ChildFormNumber = m_ChildFormNumber + 1;

                frmAccountAdd.Show(dockPanel1);
                frmAccountAdd.Focus();
                //frmAccountAdd.Width = this.Width - 22;
                //frmAccountAdd.FormBorderStyle = FormBorderStyle.FixedToolWindow;
              
                //frmAccountAdd.StartPosition = FormStartPosition.Manual;
                //frmAccountAdd.Location = new Point(-17, 0); // Always opens the forms at 15,15
                //frmAccountAdd.MaximizeBox = false;
                //frmAccountAdd.Show();

            
        }

        public static bool IsFormOpen(Form frm)
        {
            bool res = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == frm.Name)
                {
                    res = true;
                    //  f.BringToFront();
                    f.WindowState = FormWindowState.Maximized;
                    f.Focus();
                    break;
                }
            }
            return res;
        }

        
        

        private void PMoveButton_Click(object sender, EventArgs e)
        {
            ProductMove();  
        }

        private void ReorderInvSalAllMItem_Click(object sender, EventArgs e)
        {
            AddInvSalesReturn();
        }
        private void AddInvSalesReturn()
        {
            if (frmInvoiceSalesReorderAdd == null || frmInvoiceSalesReorderAdd.IsDisposed)
            {
                frmInvoiceSalesReorderAdd = new InvoiceSalesReorderAdd();
            }
            //frmInvoiceAdd.MdiParent = this;
            frmInvoiceSalesReorderAdd.InvType = Messages.InvSalesReturnFlag;
            frmInvoiceSalesReorderAdd.EditFlag = false;
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmInvoiceSalesReorderAdd.Show(dockPanel1);
            frmInvoiceSalesReorderAdd.Focus();

            //frmInvoiceAdd.Show();
            //frmInvoiceAdd.Focus();
        }

        private void PurchaseProductMItem_Click(object sender, EventArgs e)
        {
            if (frmProductPurchaseRpt == null || frmProductPurchaseRpt.IsDisposed)
            {
                frmProductPurchaseRpt = new ProductPurchaseRpt();
            }
            m_ChildFormNumber = m_ChildFormNumber + 1;
            frmProductPurchaseRpt.invType = 1;
            frmProductPurchaseRpt.Show(dockPanel1);
            frmProductPurchaseRpt.Focus();
        }
    }

       
}