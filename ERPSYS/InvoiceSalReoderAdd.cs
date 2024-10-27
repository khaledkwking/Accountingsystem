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
    public partial class InvoiceSalReoderAdd : DockContent
    {
        public int InvType;
        public int LastIden = -1;
        public int QidLastIden = -1;
        public long CurInvId = 0;
        public long CurReoderId = -1;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
        private StaticList slBillType; //= new StaticList(GLibrary.strarrBillType);
        public Boolean  EditFlag=false ;
        private DateTime lastDataError = DateTime.MinValue;
        private Boolean flag = false;
        public Boolean UpdateFlag = false;
        public InvoiceSalReoderAdd()
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
            invProductsBindingSource.CancelEdit();
            invoicesBindingSource.CancelEdit();
            qidsBindingSource.CancelEdit();
            qidsDetailsBindingSource.CancelEdit();
            qidsDetailsBindingSourceWith.CancelEdit();



            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            if (Messages.CurLang == Messages.ArabLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillType);

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillTypeEng);
            }
            CmbBillType.DataSource = slBillType.ToDataTable();

            this.sUPPLIERS_CUSTOMERSTableAdapter.Fill(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            flag = false;
          
            txtInvType.Text = InvType.ToString();
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.

            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);

            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.

            this.invoicesTableAdapter.Fill(this.nEWERPDataSet.invoices);
            //invoicesBindingSource.Filter = "InvType=" + InvType.ToString();
            if (Messages.Usertype == 2)
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString() + " And BranchId=" + Messages.CurBranch.ToString();
                //CmbBranch.Enabled = false;
                //CmbStores.Enabled = false;
            }
            else
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString();
                //CmbStores.Enabled = true;
            }

            if (invoicesBindingSource.Count > 0)
            {
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
            LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());

            this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
          

            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.
            

            //this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag ));
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);

            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERDETAILS' table. You can move, or remove it, as needed.    

            
            
            accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.boxAccid; ;
            if (invoicesBindingSource.Count > 0)
            {
                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderAgalaccid + " or AccountparentId=" + Messages.SalReorderAgalaccid;
                }
                else
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderaccid + " or AccountparentId=" + Messages.SalReorderaccid;
                }

            }
            pRODUCTSBindingSource.Filter = "MainNode=false";
            sUPPLIERSCUSTOMERSBindingSource.Sort = "CREDITLIMIT DESC ,SUP_CUST_FNAME";
            accountingBindingSourceQid.Sort = "accountname";

            

            flag = true;
            getSaleAdmin();
            if (EditFlag)
            {
                SearchByInvId();
            }
         
        }

       

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveAll();                
        }
        private void SaveAll()
        {
            if (GLibrary.MsgCheckSave(false))
            {
                if (invProductsBindingSource.Count > 0 && !ProductsDGView.IsCurrentRowDirty && !dGViewQidWith.IsCurrentRowDirty)
                {
                    try
                    {
                        GetPriceSum();
                        if (txtReoderSum.Text != "")
                        {
                            GetQid();
                            this.Validate();
                            invoicesBindingSource.EndEdit();
                            invoicesTableAdapter.Update(nEWERPDataSet.invoices);

                            for (int i = 0; i < invProductsBindingSource.Count; i++)
                            {
                                decimal curQty = decimal.Parse(((DataRowView)invProductsBindingSource[i])["Qty"].ToString());
                                decimal ReorderQty = decimal.Parse(((DataRowView)invProductsBindingSource[i])["ReorderQty"].ToString());
                                if (ReorderQty > 0)
                                {
                                    ((DataRowView)invProductsBindingSource[i])["ReoderId"] = CurReoderId;
                                    ((DataRowView)invProductsBindingSource[i])["ReoderFlag"] =Boolean .TrueString ;
                                }
                                else
                                {
                                    ((DataRowView)invProductsBindingSource[i])["ReoderId"] = DBNull.Value;
                                    ((DataRowView)invProductsBindingSource[i])["ReoderFlag"] = Boolean.FalseString;
                                }

                            }
                            invProductsBindingSource.EndEdit();
                            inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products);
                            //GetQid();

                            qidsBindingSource.EndEdit();
                            qidsTableAdapter.Update(nEWERPDataSet.qids);
                            qidsDetailsBindingSource.EndEdit();
                            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);

                            //qidsDetailsBindingSourceWith.EndEdit();
                            // qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                            GLibrary.MsgSave();
                            UpdateFlag = true;
                            EditFlag = true;
                        }
                        else
                        {
                            MessageBox.Show("«œŒ· «·ﬁÌ„… «·„— Ã⁄… »ÿ—Ìﬁ… ’ÕÌÕ…", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    catch (Exception ex)
                    {
                        int ErrorNo = -1;
                        MessageBox.Show(GLibrary.ExceptionToMessage(ex,ref ErrorNo ), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.InvaildInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

       

        private void CmdDel_Click(object sender, EventArgs e)
        {
            
            if (GLibrary.MsgCheckDel())
            {
                 //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                //invoicesBindingSource.ResetAllowNew();//.CancelEdit();
                invoicesBindingSource.RemoveCurrent();
                //invoicesBindingSource.EndEdit ();
                //((DataRowView)invoicesBindingSource.Current).EndEdit();
                int i=invoicesTableAdapter.Update(nEWERPDataSet.invoices );
                if (invoicesBindingSource.Count == 0)
                {
                    this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
                    this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                    
                    CmdSave.Enabled = false;
                    InvtabControl.SelectedIndex = 0;
                    InvtabControl.Select();
                   
                }
                
            
             }
            
        }

     
        private void DisplayProducts(ref string ProductName, ref int ProductID, ref string ProductCode)
        {
            ProductsList frm = new ProductsList();
            DialogResult ret = frm.ShowDialog(this);
            if (DialogResult.OK == ret)
            {
               
                ProductName = frm.CurProductName;
                ProductID = frm.CurProductId;
                ProductCode = frm.CurProductCode;
                this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, ProductID);
            }
        }
                    
       
        private void GetOrderAdd_Activated(object sender, EventArgs e)
        {
            
        }
 

        private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (invoicesBindingSource.Count > 0)
            {

                if (invoicesBindingSource.Count == 1 && ((DataRowView)invoicesBindingSource.Current).IsNew)
                {
                    ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

                }
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];

               // invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                qidsBindingSource.Filter = "ReorderInvId = " + InvId.ToString();
                if (qidsBindingSource.Count > 0)
                {
                    Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                    qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString();
                    qidsDetailsBindingSourceWith.Filter = "qidid =" + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();
                }
                
               
            }
        }

        private void invProductsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (invoicesBindingSource.Count > 0 && invProductsBindingSource.Count > 0)
            {

                ((DataRowView)invProductsBindingSource.Current)["InvId"] = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                
            }

        }
        

        //private void AddNewInv()
        //{

        //    invoicesBindingSource.AddNew();
        //    chkBoxCheque.Checked = false;
        //    CmbBillType.SelectedIndex = 0;
        //    CmbBillType.Select();
        //    if (CmbPaymentAccid.Items.Count > 0)
        //    {
        //        CmbPaymentAccid.SelectedValue = Messages.boxAccid;
        //        CmbPaymentAccid.Select();
        //    }
        //    if (CmbInvAccid.Items.Count > 0)
        //    {
        //        CmbInvAccid.SelectedValue = Messages.salesaccid;
        //        CmbInvAccid.Select();
        //    }
        //    if (CmbCustSupAccid.Items.Count > 0)
        //    {
        //        CmbCustSupAccid.SelectedIndex = 0;
        //        CmbCustSupAccid.Select();
        //    }
        //    txtinvTotal.Text = "0";
        //    txtInvType.Text = InvType.ToString();

        //    switch (InvType)
        //    {
        //        case Messages.InvpurchasesFlag:

        //            txtInvCode.Text = Messages.SysInvpurchasesCode + LastIden.ToString("000000");

        //            break;
        //        case Messages.InvSalesFlag:

        //            txtInvCode.Text = Messages.SysinvSaleCode + LastIden.ToString("000000");

        //            break;
        //    }
        //    //CmdAdd.Enabled = false;
        //    CmdDel.Enabled = false;
        //    EditFlag = false;

        //}

       
        private void GetQid()
        {
            SetDiscount();
           // txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
            decimal Value = decimal.Parse(txtReoderSum.Text);
            decimal NetValue = decimal.Parse(txtReoderTotalNet.Text);
            decimal RemainValue = Value;
            int AccountIdTo;
            int AccountIdFrom;
 
            if (CmbBillType.SelectedValue.ToString () == GLibrary.strarrBillType[0, 0].ToString()) //√Ã·
            {
                //AccountIdTo 
                    AccountIdFrom = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
            }
            else
            {
                //AccountIdTo
                    AccountIdFrom = int.Parse(CmbPaymentAccid.SelectedValue.ToString()); // ‰ﬁœ«
            }
            //AccountIdFrom
                AccountIdTo = int.Parse(CmbInvAccid.SelectedValue.ToString()); // Õ”«» «·„»Ì⁄« 
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                qidsBindingSource.Filter = "ReorderInvId = " + InvId.ToString();

                if (qidsBindingSource.Count == 0)
                {
                    QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
                    qidsBindingSource.AddNew();
                    ((DataRowView)qidsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + txtReorderCode.Text;// QidId.ToString();
                    ((DataRowView)qidsBindingSource.Current)["qidDate"] = ReorderdateTime.Value;// DateTime.Today;
                    ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[7, 0].ToString(); ;
                    ((DataRowView)qidsBindingSource.Current)["ReorderInvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
                    ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranch.SelectedValue;
                    ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;

                    ((DataRowView)qidsBindingSource.Current).EndEdit();
                }
                else
                {
                    ((DataRowView)qidsBindingSource.Current)["qidDate"] = ReorderdateTime.Value;
                }
                Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                //int i = 0;
                int pos = -1;

                pos = qidsDetailsBindingSource.Find("ActionType", 4);   
                if (GLibrary.IsNumeric(txtInvPayment.Text)) //œ«∆‰ «·’‰œÊﬁ      ÊÃÊœ œ›⁄…
                {
                    if (pos == -1)
                    {
                        qidsDetailsBindingSource.AddNew();
                        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                    }
                    else
                    {
                        qidsDetailsBindingSource.Position = pos;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = decimal.Parse(txtInvPayment.Text);
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.boxAccid;
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = ReorderdateTime.Value;// DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[7, 0];
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 4;
                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

                              //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

                }
                else if (txtInvPayment.Text ==  "" && pos != -1 )
                {
                    qidsDetailsBindingSource.Position = pos;
                    qidsDetailsBindingSource.RemoveCurrent();
                }



                pos = qidsDetailsBindingSource.Find("ActionType", 2);                 
                if (GLibrary.IsNumeric(txtInvPayment.Text)) //ÊÃÊœ œ›⁄…   „œÌ‰ «·⁄„Ì·
                {
                    if (pos == -1)
                    {
                        qidsDetailsBindingSource.AddNew();
                        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                    }
                    else
                    {
                        qidsDetailsBindingSource.Position = pos;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = decimal.Parse(txtInvPayment.Text);
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom; // Õ”«» «·⁄„Ì·
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = ReorderdateTime.Value; // DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[7, 0];
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


                    //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

                }
                else if (txtInvPayment.Text == "" && pos != -1)
                {
                    qidsDetailsBindingSource.Position = pos;
                    qidsDetailsBindingSource.RemoveCurrent();
                }



                
                pos = qidsDetailsBindingSource.Find("ActionType",3);
                
                if (GLibrary.IsNumeric(txtDiscount.Text)) //  ÊÃÊœ Œ’„ „œÌ‰ «·Œ’Ê„
                {
                    if (pos == -1)
                    {
                        qidsDetailsBindingSource.AddNew();
                        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                    }
                    else
                    {
                        qidsDetailsBindingSource.Position = pos;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = decimal.Parse(txtReoderSum.Text) - decimal.Parse(txtReoderTotalNet.Text);
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.Discountaccid;
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[7, 0];
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ﬁÌ„… «·Œ’„";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 3;
                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
                    RemainValue = RemainValue - (decimal.Parse(txtReoderSum.Text) - decimal.Parse(txtReoderTotalNet.Text)); 
                }
                else if (txtInvPayment.Text == "" && pos != -1)
                {
                    qidsDetailsBindingSource.Position = pos;
                    qidsDetailsBindingSource.RemoveCurrent();
                }

            //  œ«∆‰ Ê„œÌ‰ ›Ï Õ«·… ⁄œ„ ÊÃÊœ œ›⁄… «Ê Œ’„ 
                pos = qidsDetailsBindingSource.Find("ActionType", 1); // œ«∆‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
                if (pos == -1)
                {
                    qidsDetailsBindingSource.AddNew();
                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                }
                else
                {
                    qidsDetailsBindingSource.Position = pos;
                }
                ((DataRowView)qidsBindingSource.Current).BeginEdit();
                ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = Value;
                ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo;
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[7, 0];
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "„— Ã⁄";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 1;
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



                pos = qidsDetailsBindingSource.Find("ActionType", 5);  // „œÌ‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄« 
               
                if (pos == -1)
                {
                    qidsDetailsBindingSource.AddNew();
                    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
                }
                else
                {
                    qidsDetailsBindingSource.Position = pos;
                }

                ((DataRowView)qidsBindingSource.Current).BeginEdit();
                ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] =RemainValue ;
                //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
                ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[7, 0];
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "„— Ã⁄";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 5;
                //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
                qidsDetailsBindingSource.Sort = "ActionType";
            }
    
                    
        

        private void InvtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InvtabControl.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    if (invProductsBindingSource.Count > 0 && GLibrary.IsNumeric (txtReoderSum.Text))
                    {
                        GetQid();
                    }
                    else
                    {
                        MessageBox.Show(Messages.ProductInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        InvtabControl.SelectedIndex = 0;
                        InvtabControl.Select();

                    }
                    break;
                case 2:
                    if (invProductsBindingSource.Count > 0 && GLibrary.IsNumeric(txtReoderSum.Text))
                    {
                        GetQid();
                       
                    }
                    else
                    {
                        MessageBox.Show(Messages.ProductInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        
                        InvtabControl.SelectedIndex = 0;
                        InvtabControl.Select();

                    }
                    break;
            }
        }

        private void ProductsDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        //private void CheckQty(string ProductId,string StoreId,string Qty)
        //{
        //    if (ProductId != "" && StoreId != "")
        //    {
        //        long StockQty=(long)sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), int.Parse(StoreId));
        //        if (long.Parse(Qty) > StockQty)
        //        {
        //            MessageBox.Show(Messages.StockQtyMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);      
        //        }
        //    }
        //    else
        //    {

        //    }
        //}
        private void GetPriceSum()
        {


            txtReoderSum.Text = "0";

            for (int i = 0; i < invProductsBindingSource.Count; i++)
            {
                if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["ReorderQty"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()))
                {
                    ProductsDGView.Rows[i].Cells["TotReOderPrice"].Value = (decimal.Parse(ProductsDGView.Rows[i].Cells["ReorderQty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString())) - decimal.Parse(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString());
                    if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["TotReOderPrice"].Value.ToString()) && ProductsDGView.Rows[i].Cells["ReoderFlag"].EditedFormattedValue.ToString() == Boolean.TrueString)
                    {
                        
                        txtReoderSum.Text = (decimal.Parse(txtReoderSum.Text) + decimal.Parse(ProductsDGView.Rows[i].Cells["TotReOderPrice"].Value.ToString())).ToString();
                    }
                }
            }
        }

        private void ProductsDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            ProductsDGView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void ProductsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //e.Cancel = true;
            //e.ThrowException = false;
            //// A single error may cause secondary calls to this handler, ignore these.
            //if (ProductsDGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

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

            //ProductsDGView.Rows[e.RowIndex].ErrorText = message;

            //if (sinceLast.TotalSeconds < 1.0)

            //    MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            //else

            //    SystemSounds.Beep.Play();
        }

        private void ProductsDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["CmbStoreId"].Value = "1";
            e.Row.Cells["Discount"].Value = "0";
        }

      
        private void ProductsDGView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == CmbUnitId.Index)
            {
                // Set the combobox cell datasource to the filtered BindingSource
                DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)ProductsDGView[e.ColumnIndex, e.RowIndex];
                //dgcb.DataSource = productUnitsPricesBindingSource;
                // Filter the BindingSource based upon the region selected
                string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                if (ProductId != "")
                {
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                    }
                    

                }

             
               // this.productUnitsPricesBindingSource.Filter = "productid = " + this.ProductsDGView[e.ColumnIndex - 1, e.RowIndex].Value.ToString();
            }

        }

        private void ProductsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.CmbUnitId.Index)
            {
                // Reset combobox cell to the unfiltered BindingSource
                DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
                this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);

               
                // dgcb.DataSource = productUnitsPricesBindingSource; //unfiltered
                //this.productUnitsPricesBindingSource.RemoveFilter();
            }
          
        }

        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {

                if (qidsBindingSource.Count == 1 && ((DataRowView)qidsBindingSource.Current)["qidid"].ToString() == "0")
                {

                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(QidLastIden + 1);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

                qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString(); 
                qidsDetailsBindingSourceWith.Filter = "qidid =" + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[4, 0].ToString(); // ﬁÌœ „—›ﬁ

            }
            else
            {
                qidsDetailsBindingSource.Filter = "qidid =-1" ;
                qidsDetailsBindingSourceWith.Filter = "qidid =-1";
            }
        }

        private void dGViewQidWith_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["QidTypeWith"].Value = GLibrary.strarrQidTypes[4, 0]; //ﬁÌœ „—›ﬁ
            e.Row.Cells["ActionTypeWith"].Value = 6; 

        }

        private void txtinvTotal_TextChanged(object sender, EventArgs e)
        {
            txtInvTotalNet.Text = txtinvTotal.Text;
        }

        private void txtDiscount_Validated(object sender, EventArgs e)
        {
            SetDiscount();
        }
        private void SetDiscount()
        {
            if (!GLibrary.IsNumeric(txtDiscount.Text))
            {
                txtReoderTotalNet.Text = txtReoderSum.Text;
            }
            else
            {
                txtReoderTotalNet.Text = (decimal.Parse(txtReoderSum.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
            }
        }
        private void qidsDetailsBindingSourceWith_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0 && qidsDetailsBindingSourceWith.Count > 0)
            {
                ((DataRowView)qidsDetailsBindingSourceWith.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            }
        }

        private void chkBoxCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxCheque.Checked)
            {
                txtChequeNo.Enabled  = true;
                accountingBindingSource.Filter = "accountid=" + Messages.bankaccid + " or AccountparentId=" + Messages.bankaccid; ; 
                //CmbPaymentAccid.Enabled = true ;

            }
            else
            {
                txtChequeNo.Enabled  = false;
                txtChequeNo.Text = "";
                accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.boxAccid; ; 
                

            }
        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSourceWith.Count>0)
            {
                qidsDetailsBindingSourceWith.RemoveCurrent();
                qidsDetailsBindingSourceWith.EndEdit();
            }
        }
        private void SearchInv()
        {
            int pos = invoicesBindingSource.Find("InvCode", txtInvCode.Text);
            if (pos != -1)
            {
                if (GLibrary.MsgCheckSave(false))
                {
                    SaveAll();
                }
                else
                {

                    invoicesBindingSource.CancelEdit();
                    invProductsBindingSource.CancelEdit();
                    qidsBindingSource.CancelEdit();
                    qidsDetailsBindingSource.CancelEdit();
                    qidsDetailsBindingSourceWith.CancelEdit();
                }
                invoicesBindingSource.Position = pos;
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                qidsBindingSource.Filter = "ReorderInvId = " + InvId.ToString();

                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderAgalaccid + " or AccountparentId=" + Messages.SalReorderAgalaccid;
                }
                else
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderaccid + " or AccountparentId=" + Messages.SalReorderaccid;
                }

                EditFlag = true;
            }
            else
            {
                MessageBox.Show(Messages.InvNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                invoicesBindingSource.CancelEdit();
                invProductsBindingSource.CancelEdit();
                qidsBindingSource.CancelEdit();
                qidsDetailsBindingSource.CancelEdit();
                qidsDetailsBindingSourceWith.CancelEdit();
                if (!EditFlag)
                {


                    EditFlag = true;
                }
            }
        }
        private void txtInvCode_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                SearchInv();
            }


        }

        private void SearchByInvId()
        {

            int pos = invoicesBindingSource.Find("InvId", CurInvId);
            if (pos != -1)
            {
                

                invoicesBindingSource.CancelEdit();
                invProductsBindingSource.CancelEdit();
                qidsBindingSource.CancelEdit();
                qidsDetailsBindingSource.CancelEdit();
                qidsDetailsBindingSourceWith.CancelEdit();
              
                invoicesBindingSource.Position = pos;
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                qidsBindingSource.Filter = "ReorderInvId = " + InvId.ToString();

                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderAgalaccid + " or AccountparentId=" + Messages.SalReorderAgalaccid;
                }
                else
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalReorderaccid + " or AccountparentId=" + Messages.SalReorderaccid;
                }

                EditFlag = true;
            }
            else
            {
                MessageBox.Show(Messages.InvNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                invoicesBindingSource.CancelEdit();
                invProductsBindingSource.CancelEdit();
                qidsBindingSource.CancelEdit();
                qidsDetailsBindingSource.CancelEdit();
                qidsDetailsBindingSourceWith.CancelEdit();
                if (!EditFlag)
                {


                    EditFlag = true;
                }
            }
        }
        private void MenuItemDelProduct_Click(object sender, EventArgs e)
        {
            if (invProductsBindingSource.Count > 0)
            {
                invProductsBindingSource.RemoveCurrent();
            }
        }

        private void ProductsDGView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "CmbPRODUCTID")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
        }
        private void ProductsDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
     
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "CmbPRODUCTID" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];

             
                DataGridViewComboBoxCell dgcbProduct = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
                int pos = pRODUCTSBindingSource.Find("productname", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());
                    dgcbProduct.Value = ProductId.ToString();

                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                    }
                }
                else
                {

                }
            }
        }

        private void dGViewQidWith_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            //if (dGViewQidWith.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

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

            //dGViewQidWith.Rows[e.RowIndex].ErrorText = message;

            //if (sinceLast.TotalSeconds < 1.0)

            //    MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            //else

            //    SystemSounds.Beep.Play();
        }

        private void dGViewQidWith_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "AccountNameWith")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
        }

        private void dGViewQidWith_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dGViewQidWith.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowProductsRpt frm = new ShowProductsRpt();

            NEWERPDataSet nEWERPDataSetTemp =new NEWERPDataSet ();
            nEWERPDataSetTemp = (NEWERPDataSet) nEWERPDataSet.Copy();
            Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
            this.inv_ProductsTableAdapter.FillByReturnByInvId(nEWERPDataSetTemp.Inv_Products, InvId);

            frm.nEWERPDataSet = nEWERPDataSetTemp;
            frm.choiceNum = 13;
            frm.CustName = CmbCustSupAccid.Text;
            frm.InvType = "›« Ê—… „— Ã⁄";

            if (txtinvTotal.Text != "")
            {
                frm.TotalSum = decimal.Parse(txtinvTotal.Text);
                frm.strTotalSum = GLibrary.FigureInWordsNumType(double.Parse(txtinvTotal.Text), 1);
            }
            else
            {

                frm.TotalSum = 0;
                frm.strTotalSum = "";
            }

            if (txtDiscount.Text != "")
            {
                frm.Discount = decimal.Parse(txtDiscount.Text);
                frm.strDiscount = GLibrary.FigureInWordsNumType(double.Parse(txtDiscount.Text), 1);
            }
            else
            {
                frm.Discount = 0;
                frm.strDiscount = "";
            }
            if (txtInvTotalNet.Text != "")
            {
                frm.TotalNet = decimal.Parse(txtInvTotalNet.Text);
                frm.strTotalNet = GLibrary.FigureInWordsNumType(double.Parse(txtInvTotalNet.Text), 1);
            }
            else 
            {
                frm.TotalNet = 0;
                frm.strTotalNet = "";
            }
            frm.InvDate = dtInvDate.Value;
            frm.ShowDialog(this);
        }

        private void CmbCustSupAccid_SelectedIndexChanged(object sender, EventArgs e)
        {

            getSaleAdmin();    
            
        }
         private void getSaleAdmin()
         {
             if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
             {
                 if (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"] != DBNull .Value  && flag)
                 {
                     int EmpCode = (int)((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"];

                     pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, EmpCode,null,null,null,null);
                     if (personalDataSet.PER_EMPLOYEE_DATA.Rows.Count > 0)
                     {
                         txtSaleAdmin.Text = personalDataSet.PER_EMPLOYEE_DATA.Rows[0]["EMPNAME"].ToString();
                     }


                 }
             }
         }

        private void ProductsDGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDGView.Rows.Count > 0)
            {
                if (e.ColumnIndex == ReoderFlag.Index)
                {
                    if (ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {

                        ((DataRowView)invProductsBindingSource.Current)["ReorderDate"] = DateTime.Today.ToShortDateString();
                        invProductsBindingSource.EndEdit();
                        GetPriceSum();
                    }

                }
            }
        }

        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ProductsDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void CmbBillType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            {
                txtInvPayment.Enabled = true;
                CmbPaymentAccid.Enabled = true;
                this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));


            }
            else //‰ﬁœ«
            {
                txtInvPayment.Enabled = false;
                CmbPaymentAccid.Enabled = false;
                this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                txtInvPayment.Text = "";
            }
        }

        private void QidDetDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

      
      
    }
 
}