using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using ERPSYS.Reports;
using Microsoft.Win32;
using WeifenLuo.WinFormsUI;

namespace ERPSYS
{
    public partial class InvoiceSalesReorderAdd : DockContent
    {
        public int InvType;
        public int LastIden = -1;
        public int QidLastIden = -1;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
        private StaticList slBillType;
        public Boolean EditFlag = false;
        private DateTime lastDataError = DateTime.MinValue;
        private Boolean flag = false;
        private Boolean Nflag = true;
        private string OldProductId = "0";
        public long InvId;
        public long CustId = 0;
        public Boolean bYearFlag = false;
        public Boolean QtyFlag = false;
        private NEWERPDataSet nTempEWERPDataSet = new NEWERPDataSet();
        private Boolean PrintFlag = false;
        private Boolean ShowPrintDlg = true;
        private int CurProductId = 0;
        System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
        private StaticList slInvPaymentMethod = new StaticList(GLibrary.strarrInvPaymentMethodTypeEng);
        public Boolean CreateFromPriceList = false;
        public long InvOrderId;
        long FirstCode = 0;
        public InvoiceSalesReorderAdd()
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



            this.Close();
        }
        private void Cashbox()
        {
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);
            pd.BeginPrint += new System.Drawing.Printing.PrintEventHandler(pd_BeginPrint);
            pd.EndPrint += new System.Drawing.Printing.PrintEventHandler(pd_EndPrint);
            pd.Print();
        }
        void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("", new Font("Arial", 20f), new SolidBrush(Color.Red), new PointF(20, 20));

        }
        void pd_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        void pd_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvOrders_Products' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvOrders_Products' table. You can move, or remove it, as needed.
           

            this.KeyPreview = true;
            // TODO: This line of code loads data into the 'nEWERPDataSet.HomeCustomer' table. You can move, or remove it, as needed.
            this.homeCustomerTableAdapter.Fill(this.nEWERPDataSet.HomeCustomer);
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER' table. You can move, or remove it, as needed.
            this.uSERTableAdapter.Fill(this.nEWERPDataSet.USER);


            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.
            this.uSER_FUNCTIONTableAdapter.Fill(this.nEWERPDataSet.USER_FUNCTION);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.

            //
            if (Messages.CurLang == Messages.ArabLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillType);

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillTypeEng);
            }

            CmbBillType.DataSource = slBillType.ToDataTable();
            cmbPayMethode.DataSource = slInvPaymentMethod.ToDataTable();

            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            ProductsDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dGViewQidWith.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            QidDetDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            foreach (DataGridViewRow row in ProductsDGView.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }
            foreach (DataGridViewRow row in dGViewQidWith.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }
            foreach (DataGridViewRow row in QidDetDGView.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            flag = false;


            this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.

            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);




            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.


            //this.invoicesTableAdapter.Fill(this.nEWERPDataSet.invoices);
            if (Messages.Usertype == 2)
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString() + " And BranchId=" + Messages.CurBranch.ToString();
                CmbBranch.Enabled = false;
                //CmbStores.Enabled = false ;
            }
            else
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString();
                CmbStores.Enabled = true;
            }


            if (invoicesBindingSource.Count > 0)
            {
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.


            //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);



            accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.accountidMainBox;
            accountingBindingSource1.Filter = "accountid=" + Messages.salesaccid + " or AccountparentId=" + Messages.salesaccid;
            pRODUCTSBindingSource.Filter = "MainNode=false";
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            pRODUCTSBindingSource.Sort = "productname";
            accountingBindingSource.Sort = "accountname";
            sUPPLIERSCUSTOMERSBindingSource.Sort = "SUP_CUST_FNAME";
            accountingBindingSourceQid.Sort = "accountname";
            costCentersBindingSource1.Filter = "MainNode=" + Boolean.FalseString;

            accountingBindingSourceCust.Filter = "AccountparentId=" + Messages.custaccid;
            //accountingBindingSourceQid.Filter = "Mainnode=" + Boolean.FalseString;

            //qidsDetailsBindingSource.Filter =  "QidType=" + GLibrary.strarrQidTypes[2, 0].ToString();
            //qidsDetailsBindingSourceWith.Filter = "QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();
            //if (CmbBranch.SelectedValue != null)
            //{
            long BranchId = 0;
            BranchId = long.Parse(Messages.CurBranch);
            sTORESBindingSource.Filter = "BRANCHCODE=" + BranchId.ToString();
            this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS, BranchId);

            //}
            if (CreateFromPriceList)
            {

                this.invOrdersTableAdapter.FillByInvId(this.nEWERPDataSet.InvOrders, InvOrderId);
                this.invOrders_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.InvOrders_Products, InvOrderId);
                if (invOrdersBindingSource.Count > 0 && invOrdersProductsBindingSource.Count > 0)
                {
                    AddNewInv();
                    Int64 InvId = (Int64)((DataRowView)invOrdersBindingSource.Current)["InvId"];
                    //this.invOrders_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.InvOrders_Products, InvOrderId);
                    ((DataRowView)invoicesBindingSource.Current)["Cust_Sup_Accid"] = ((DataRowView)invOrdersBindingSource.Current)["Cust_Sup_Accid"];
                    ((DataRowView)invoicesBindingSource.Current)["PaymentType"] = ((DataRowView)invOrdersBindingSource.Current)["PaymentType"];
                    ((DataRowView)invoicesBindingSource.Current)["BranchId"] = ((DataRowView)invOrdersBindingSource.Current)["BranchId"];
                    ((DataRowView)invoicesBindingSource.Current)["InvType"] = ((DataRowView)invOrdersBindingSource.Current)["InvType"];
                    ((DataRowView)invoicesBindingSource.Current)["invTotal"] = ((DataRowView)invOrdersBindingSource.Current)["invTotal"];
                    ((DataRowView)invoicesBindingSource.Current)["Discount"] = ((DataRowView)invOrdersBindingSource.Current)["Discount"];
                    ((DataRowView)invoicesBindingSource.Current)["InvTotalNet"] = ((DataRowView)invOrdersBindingSource.Current)["InvTotalNet"];
                    ((DataRowView)invoicesBindingSource.Current)["SUP_CUST_ID"] = ((DataRowView)invOrdersBindingSource.Current)["SUP_CUST_ID"];
                    ((DataRowView)invoicesBindingSource.Current)["PayFinish"] = ((DataRowView)invOrdersBindingSource.Current)["PayFinish"];
                    invoicesBindingSource.EndEdit();

                    for (int i = 0; i < invOrdersProductsBindingSource.Count; i++)
                    {
                        invProductsBindingSource.AddNew();
                        ((DataRowView)invProductsBindingSource.Current)["InvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
                        ((DataRowView)invProductsBindingSource.Current)["ProductId"] = ((DataRowView)invOrdersProductsBindingSource[i])["ProductId"];
                        ((DataRowView)invProductsBindingSource.Current)["UnitId"] = ((DataRowView)invOrdersProductsBindingSource[i])["UnitId"];
                        ((DataRowView)invProductsBindingSource.Current)["Qty"] = ((DataRowView)invOrdersProductsBindingSource[i])["Qty"];
                        ((DataRowView)invProductsBindingSource.Current)["StoreId"] = ((DataRowView)invOrdersProductsBindingSource[i])["StoreId"];
                        ((DataRowView)invProductsBindingSource.Current)["Discount"] = ((DataRowView)invOrdersProductsBindingSource[i])["Discount"];
                        ((DataRowView)invProductsBindingSource.Current)["VaildDate"] = ((DataRowView)invOrdersProductsBindingSource[i])["VaildDate"];
                        ((DataRowView)invProductsBindingSource.Current)["TotalPrice"] = ((DataRowView)invOrdersProductsBindingSource[i])["TotalPrice"];
                        ((DataRowView)invProductsBindingSource.Current)["ReoderFlag"] = ((DataRowView)invOrdersProductsBindingSource[i])["ReoderFlag"];
                        ((DataRowView)invProductsBindingSource.Current)["TotReOderPrice"] = ((DataRowView)invOrdersProductsBindingSource[i])["TotReOderPrice"];
                        ((DataRowView)invProductsBindingSource.Current)["PRODUCTBRAND"] = ((DataRowView)invOrdersProductsBindingSource[i])["PRODUCTBRAND"];
                        if (((DataRowView)invOrdersProductsBindingSource[i])["Price"] != DBNull.Value)
                        {
                            ((DataRowView)invProductsBindingSource.Current)["Price"] = ((DataRowView)invOrdersProductsBindingSource[i])["Price"];
                        }
                        else
                        {
                            ((DataRowView)invProductsBindingSource.Current)["Price"] = 0;
                        }

                        invProductsBindingSource.EndEdit();
                    }
                }
            }
            else if (!EditFlag)
            {
                AddNewInv();


            }
            else if (CustId > 0)
            {
                this.invoicesTableAdapter.FillBycustId(this.nEWERPDataSet.invoices, CustId);
                invoicesBindingSource.Sort = "InvId DESC ";
                int pos = invoicesBindingSource.Find("CustomerId", CustId);
                if (pos > -1)
                {
                    invoicesBindingSource.Position = pos;
                    GetCustomerData();
                }
            }

                // TODO: This line of code loads data into the 'nEWERPDataSet.InvOrders' table. You can move, or remove it, as needed.



            else
            {


                this.invoicesTableAdapter.FillByInvId(this.nEWERPDataSet.invoices, InvId);

                int pos = invoicesBindingSource.Find("InvId", InvId);

                if (pos > -1)
                {
                    invoicesBindingSource.Position = pos;
                    GetCustomerData();
                }
            }


            Messages.StockFlag = 0;
            Messages.ProductFlag = 0;
            //LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            flag = true;

            Nflag = true;
            ProductsDGView.Focus();

            SetPermission();
            pEREMPLOYEEDATABindingSource1.Filter = "not (AccountID is null) ";
            if (Messages.Usertype == Messages.AdminUser)
            {
                txtDiscount.Enabled = true;
                cmbBuyerId.Enabled = true;

            }
            else
            {
                cmbBuyerId.SelectedValue = Messages.CurUserId;

            }
        }

        private void SetPermission()
        {


            if (!Messages.SalInvPrim[1] && EditFlag)
            {
                ProductsDGView.Enabled = false;
                CmdSave.Enabled = false;
                cmbBuyerId.Enabled = false;
            }
            if (!Messages.SalInvPrim[2] && EditFlag)
            {
                //ProductsDGView.Enabled = false;
                CmdDel.Enabled = false;
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            PrintFlag = true;
            SaveAll(false);
            SetPermission();
        }
        private Boolean ValidateControl()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //«Ã·
            {
                if (CmbCustSupAccid.SelectedValue == null || CmbCustSupAccid.Text == "")
                {
                    MessageBox.Show(Messages.EnterCustomerMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    CmbCustSupAccid.Focus();
                    return false;

                }

            }
            //else //‰ﬁœ«
            //{
            //    if (CmbCustSupAccid.Text  == "")
            //    {
            //        MessageBox.Show(Messages.EnterCustomerMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //        CmbCustSupAccid.Focus();
            //        return false;
            //    }
            //}
            if (CmbInvAccid.SelectedValue == null)
            {
                MessageBox.Show(Messages.EnterAccountMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                CmbInvAccid.Focus();
                return false;
            }
            return true;

        }
        private Boolean SaveChild()
        {
            if (txtTel.Text != "")
            {
                int Cuspos = homeCustomerBindingSource.Find("CustTel", txtTel.Text);
                string Name = txtCustomerName.Text;
                string Tel = txtTel.Text;
                string Address = txtAddress.Text;
                string block = txtblock.Text;
                string street = txtStreet.Text;
                string Gada = txtGada.Text;
                string Buliding = txtBuliding.Text;
                string Flat = txtFlat.Text;
                string House = txtHouse.Text;
                string Floor = txtFloor.Text;
                //string Notes = txtCustNote.Text;

                if (Cuspos > -1)
                {

                    homeCustomerBindingSource.Position = Cuspos;
                    ((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"] = Name;
                    ((DataRowView)homeCustomerBindingSource[Cuspos])["Address"] = Address;
                    ((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"] = Tel;

                    if (txtblock.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["block"] = block;
                    }
                    if (txtStreet.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["street"] = street;
                    }
                    if (txtGada.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"] = Gada;
                    }
                    if (txtBuliding.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"] = Buliding;
                    }
                    if (txtFlat.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"] = Flat;
                    }
                    if (txtHouse.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["House"] = House;
                    }
                    if (txtFloor.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"] = Floor;
                    }
                    //if (txtCustNote.Text != "")
                    //{
                    //    ((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"] = Notes;
                    //}

                    homeCustomerBindingSource.EndEdit();
                    homeCustomerTableAdapter.Update(nEWERPDataSet.HomeCustomer);
                    ((DataRowView)invoicesBindingSource.Current)["CustomerId"] = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustId"];
                }
                else
                {
                    homeCustomerBindingSource.AddNew();
                    ((DataRowView)homeCustomerBindingSource.Current)["CustName"] = Name;
                    ((DataRowView)homeCustomerBindingSource.Current)["Address"] = Address;
                    ((DataRowView)homeCustomerBindingSource.Current)["CustTel"] = Tel;

                    if (txtblock.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["block"] = block;
                    }
                    if (txtStreet.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["street"] = street;
                    }
                    if (txtGada.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["Gada"] = Gada;
                    }
                    if (txtBuliding.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["Buliding"] = Buliding;
                    }
                    if (txtFlat.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["Flat"] = Flat;
                    }
                    if (txtHouse.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["House"] = House;
                    }
                    if (txtFloor.Text != "")
                    {
                        ((DataRowView)homeCustomerBindingSource.Current)["Floor"] = Floor;
                    }
                    //if (txtCustNote.Text != "")
                    //{
                    //    ((DataRowView)homeCustomerBindingSource.Current)["Notes"] = Notes;
                    //}
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["block"] = block;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["street"] = street;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"] = Gada;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"] = Buliding;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"] = Flat;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["House"] = House;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"] = Floor;
                    //((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"] = Notes;

                    homeCustomerBindingSource.EndEdit();
                    homeCustomerTableAdapter.Update(nEWERPDataSet.HomeCustomer);
                    ((DataRowView)invoicesBindingSource.Current)["CustomerId"] = ((DataRowView)homeCustomerBindingSource.Current)["CustId"];
                }
            }
            //this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.invoicesRow master = (NEWERPDataSet.invoicesRow)(((DataRowView)invoicesBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.Inv_ProductsRow detail = (NEWERPDataSet.Inv_ProductsRow)(((DataRowView)invProductsBindingSource.Current).Row);

            NEWERPDataSet.qidsRow Qiddetail = (NEWERPDataSet.qidsRow)(((DataRowView)qidsBindingSource.Current).Row);
            if (((DataRowView)invProductsBindingSource.Current)["ProductId"] == DBNull.Value || ((DataRowView)invProductsBindingSource.Current)["Qty"] == DBNull.Value || ((DataRowView)invProductsBindingSource.Current)["Price"] == DBNull.Value)
            {
                return false;
            }
            // Save the master row

            invoicesBindingSource.EndEdit();
            invoicesTableAdapter.Update(master);
            //invoicesTableAdapter.Update(nEWERPDataSet.invoices );
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row

            if (detail.InvId != master.InvId)
            {
                for (int i = 0; i < invProductsBindingSource.Count; i++)
                {
                    ((DataRowView)invProductsBindingSource[i])["InvId"] = master.InvId;
                }
            }

            if (Qiddetail.InvId != master.InvId)
            {
                for (int i = 0; i < qidsBindingSource.Count; i++)
                {
                    ((DataRowView)qidsBindingSource[i])["InvId"] = master.InvId;
                }
            }
            //detail.qidid  = master.qidid;
            // Save the child row
            invProductsBindingSource.EndEdit();
            inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products);

            qidsBindingSource.EndEdit();
            qidsTableAdapter.Update(nEWERPDataSet.qids);
            qidsDetailsBindingSource.EndEdit();
            qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);

            //invProductsBindingSource.Filter = "qidid = " + master.qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[0, 0] + ")"; //+ " Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString() + ")";
            qidsBindingSource.Filter = "InvId = " + master.InvId.ToString();

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;


            return true;


        }
        //private void SetDiscount()
        //{

        //    if (!GLibrary.IsNumeric(txtDiscount.Text))
        //    {
        //        //GLibrary.ValidatetxtBox(errorProvider1, txtDiscount, "√œŒ· «·Œ’„ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·Œ’„", true);
        //    }
        //    else
        //    {
        //        if (DistPerrdBtn.Checked)
        //        {
        //            decimal DisVaule = decimal.Parse(txtDiscount.Text);


        //            txtInvTotalNet.Text = (decimal.Parse(txtNetAll.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();



        //        }
        //        if (DistValrdBtn.Checked)
        //        {
        //            txtInvTotalNet.Text = (decimal.Parse(txtNetAll.Text) - decimal.Parse(txtDiscount.Text)).ToString();
        //        }
        //    }
        //}
        private void InvSetSerial()
        {
            long QidSeial = 0;

            if (!EditFlag)
            {
                long MaxSerial = (long)invoicesTableAdapter.InvoicesSelectMaxSerial(InvType);
                //QidSeial = int.Parse(nEWERPDataSet.SetupCodes.Rows[0]["QidSeial"].ToString());
                QidSeial = MaxSerial + 1;
                if (long.Parse(txtInvCode.Text) > QidSeial)
                {
                    QidSeial = long.Parse(txtInvCode.Text);
                    txtQidSerial.Text = QidSeial.ToString();
                }
                else
                {
                    if (long.Parse(txtInvCode.Text) < FirstCode)
                    {
                        txtQidSerial.Text = txtInvCode.Text;
                    }
                    else
                    {
                        txtInvCode.Text = QidSeial.ToString();
                        txtQidSerial.Text = QidSeial.ToString();
                    }
                    //if (QidSeial)
                    //qidcodeTextBox.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
                }
            }
        }
        private void SaveAll(Boolean bflag)
        {

            if (this.ValidateChildren())
            {
                if (ValidateControl())
                {
                    Nflag = false;
                    //if (GLibrary.MsgCheckSave(bflag))
                    //{
                    if (invProductsBindingSource.Count > 0)// && !ProductsDGView.IsCurrentRowDirty && !dGViewQidWith.IsCurrentRowDirty)
                    {
                        try
                        {
                            if (!EditFlag)
                            {
                                InvSetSerial();
                            }
                            if (GLibrary.IsNumeric(txtInvCode.Text) || bYearFlag)
                            {
                               
                                if (CheckCode(txtInvCode.Text, InvType))
                                {
                                    GetPriceSum();
                                    txtInvTotalNet.Text = txtinvTotal.Text;
                                    
                                    //txtInvPay.Text = txtInvTotalNet.Text;
                                    //txtNetAll.Text = txtInvTotalNet.Text;
                                    invoicesBindingSource.EndEdit();
                                    SetDiscount();
                                    decimal Rem = 0;
                                    decimal Payvalue = 0;
                                    decimal KeyNetvalue = 0;
                                    decimal Total = 0;
                                    if (txtInvTotalNet.Text == "")
                                    {
                                        txtInvTotalNet.Text = "0";
                                    }
                                    Total = decimal.Parse(txtInvTotalNet.Text);
                                    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()) // ‰ﬁœ«
                                    {

                                        txtInvPay.Text = Total.ToString();
                                        Payvalue = decimal.Parse(txtInvPay.Text);


                                        if (GLibrary.IsNumeric(txtKeyNetValue.Text) && chkBoxCheque.Checked)
                                        {
                                            KeyNetvalue = decimal.Parse(txtKeyNetValue.Text);
                                            if (KeyNetvalue > Total)
                                            {
                                                MessageBox.Show("Vaule of payment does not same to total sum of invoice ", "Invoices", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                                return;
                                            }
                                            txtInvPay.Text = (decimal.Parse(txtInvPay.Text) - decimal.Parse(txtKeyNetValue.Text)).ToString();
                                            Rem = decimal.Parse(txtInvTotalNet.Text) - decimal.Parse(txtKeyNetValue.Text);

                                        }
                                        else
                                        {
                                            Rem = decimal.Parse(txtInvPay.Text) - decimal.Parse(txtInvTotalNet.Text);
                                        }

                                        txtRemain.Text = Rem.ToString();
                                        //((DataRowView)invoicesBindingSource.Current)["InvTotalNet"] = txtInvTotalNet.Text;
                                        //((DataRowView)invoicesBindingSource.Current)["PaymentValue"] 
                                            txtInvPayment.Text= txtInvPay.Text;
                                    }
                                    invoicesBindingSource.EndEdit();

                                    //GetQid();
                                    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) // «Ã·
                                    {
                                       
                                        if (txtInvPayment.Text == "" || txtInvPayment.Text == "0")
                                        {
                                            txtPayFinish.Text = Boolean.FalseString;
                                        }
                                        else if (GLibrary.IsNumeric(txtInvPayment.Text))
                                        {
                                            if (decimal.Parse(txtInvPayment.Text) < decimal.Parse(txtInvTotalNet.Text))
                                            {
                                                txtPayFinish.Text = Boolean.FalseString;
                                            }
                                            else
                                            {
                                                txtPayFinish.Text = Boolean.TrueString;
                                            }
                                        }

                                    }
                                    else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //  ﬁ”Ìÿ
                                    {
                                        //if (!ShowTasat())
                                        //{
                                        //    MessageBox.Show("«œŒ· »Ì«‰«  «· ﬁ”Ìÿ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        // return;
                                        //}
                                        txtPayFinish.Text = Boolean.TrueString;
                                    }
                                    else
                                    {
                                        //txtInvTotalNet.Text = txtinvTotal.Text;
                                        //txtInvPay.Text = txtInvTotalNet.Text;
                                        txtPayFinish.Text = Boolean.TrueString;
                                       
                                    }

                                    this.Validate();
                                 
                                    invoicesBindingSource.EndEdit();
                                    invProductsBindingSource.EndEdit();
                                    GetQid();
                                    txtUserId.Text = Messages.CurUserId;
                                    //this.Validate();

                                    recoderCodeTextBox.Text = "O" + txtInvCode.Text;

                                    //invoicesBindingSource.EndEdit();
                                    //invProductsBindingSource.EndEdit();

                                    //invoicesTableAdapter.Update(nEWERPDataSet.invoices);
                                    if (CmbCostCenters.Text == "")
                                    {
                                        ((DataRowView)invoicesBindingSource.Current)["CostId"] = DBNull.Value;
                                    }
                                    //if (GLibrary.IsNumeric(txtInvPay.Text))
                                    //{
                                    //    decimal Rem= decimal.Parse(txtInvTotalNet.Text) - decimal.Parse(txtInvPay.Text) ;
                                    //    txtRemain.Text = Rem.ToString();
                                    //}
                                    //GetPriceSum();
                                    getSaleAdmin();
                                    if (!SaveChild())
                                    {
                                        MessageBox.Show("«œŒ· «Œ— ’‰› »ÿ—Ìﬁ… ’ÕÌÕÂ «Ê  Õ—ﬂ «·Ï «·’‰ﬁ «·”«»ﬁ À„ «÷⁄Ÿ Õ›Ÿ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        return;
                                    }
                                    int ret = 0;
                                    //if (!EditFlag)
                                    //{
                                        //int Pos = 0;
                                        //if (CmbBranch.SelectedValue != null)
                                        //{
                                        //    Pos = int.Parse(CmbBranch.SelectedIndex.ToString());
                                        //}
                                    
                                        //bRANCHESTableAdapter.Fill(nEWERPDataSet.BRANCHES);
                                        //string LastInvCode = "";
                                        //if (bYearFlag)
                                        //{

                                        //    char[] delimiter = "/".ToCharArray();
                                        //    String[] res = txtInvCode.Text.Split(delimiter); //Now split the different SQL statements into an array
                                        //    if (res.Length > 1)
                                        //    {
                                        //        LastInvCode = res[1];
                                        //    }
                                        //    //txtInvCode.Text

                                        //}
                                        //else
                                        //{
                                        //    LastInvCode = txtInvCode.Text;
                                        //}
                                        //switch (InvType)
                                        //{
                                        //    case Messages.InvpurchasesFlag:
                                        //        ((DataRowView)bRANCHESBindingSource[Pos])["PurchInvSerial"] = LastInvCode;//txtInvCode.Text;

                                        //        // nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"] = txtInvCode.Text;
                                        //        //nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"] = txtInvCode.Text;

                                        //        break;
                                        //    case Messages.InvSalesFlag:
                                        //        ((DataRowView)bRANCHESBindingSource[Pos])["SalInvSerial"] = LastInvCode;// txtInvCode.Text;
                                        //        //nEWERPDataSet.BRANCHES.Rows[Pos]["SalInvSerial"] = txtInvCode.Text;
                                        //        //nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"] = txtInvCode.Text;
                                        //        break;
                                        //}
                                        ////this.Validate();
                                        //bRANCHESBindingSource.EndEdit();
                                        //ret = bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);
                                        //setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                   // }

                                    //invProductsBindingSource.EndEdit();
                                    // inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products);
                                    //GetQid();

                                    //qidsBindingSource.EndEdit();
                                    //qidsTableAdapter.Update(nEWERPDataSet.qids);
                                    //qidsDetailsBindingSource.EndEdit();
                                    //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);

                                    //qidsDetailsBindingSourceWith.EndEdit();
                                    // qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                                    if (PrintFlag)
                                    {
                                        GLibrary.MsgSave();
                                    }
                                    CmdAdd.Enabled = true;
                                    CmdDel.Enabled = true;
                                    EditFlag = true;
                                    if (((DataRowView)invoicesBindingSource.Current)["BranchId"] != DBNull.Value)
                                    {
                                        CmbBranch.SelectedValue = ((DataRowView)invoicesBindingSource.Current)["BranchId"].ToString();
                                    }
                                    if (Messages.CurLang == Messages.ArabLang)
                                    {
                                        CmdSave.Text = " ⁄œÌ·";

                                    }
                                    else if (Messages.CurLang == Messages.EngLang)
                                    {
                                        CmdSave.Text = "Edit";
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("—ﬁ„ «·„” ‰œ „ÊÃÊœ ”«»ﬁ«", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                            }
                            else
                            {
                                MessageBox.Show("√œŒ· «·ﬂÊœ «·›« Ê—… »ÿ—Ìﬁ… ”·Ì„…", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                        }
                        catch (Exception ex)
                        {
                            int ErrorNo = -1;
                            MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            if (ErrorNo == 547)
                            {
                                invoicesBindingSource.RemoveCurrent();
                                invoicesBindingSource.EndEdit();
                                invoicesTableAdapter.Update(nEWERPDataSet.invoices);
                            }

                        }


                    }
                    else
                    {
                        MessageBox.Show(Messages.InvaildInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }

                    Nflag = true;
                }
            }
            else
            {
                MessageBox.Show(Messages.InvaildDataInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }

        }
        private Boolean CheckCode(string InvCode, int InvType)
        {
            if (!EditFlag)
            {
                //UpdateInvCode();
                if (InvCode != txtInvCode.Text)
                {
                    InvCode = txtInvCode.Text;
                }
            }
            int Count = 0;
            long BranchId = 0;
            if (CmbBranch.SelectedValue != null)
            {
                BranchId = long.Parse(CmbBranch.SelectedValue.ToString());
            }
            else
            {
                BranchId = long.Parse(Messages.CurBranch);
            }
            Count = int.Parse(invoicesTableAdapter.CheckInvCode(InvCode, InvType, BranchId).ToString());
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
            //if (bYearFlag)
            //{

            //    char[] delimiter = "/".ToCharArray();
            //    String[] res = txtInvCode.Text.Split(delimiter);
            //    if (res.Length == 2)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        MessageBox.Show("«œŒ· ﬂÊœ «·›« Ê—… »ÿ—Ìﬁ… ’ÕÌÕÌ…", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //        return false;
            //    }
            //}
            return true;

        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewInv();
            //if (Messages.SalInvPrim[3] && !EditFlag)
            //{
            //    ProductsDGView.Enabled = true;
            //    CmdSave.Enabled = true;
            //}           
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
                int i = invoicesTableAdapter.Update(nEWERPDataSet.invoices);
                if (invoicesBindingSource.Count == 0)
                {
                    this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, -1);
                    //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
                    //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                    CmdDel.Enabled = false;
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
                this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, ProductID);
            }
        }



        private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (qidsBindingSource.Count > 0)
            //{

            //    if (qidsBindingSource.Count == 1 && ((DataRowView)qidsBindingSource.Current)["qidid"].ToString() == "0")
            //    {
            //        ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(LastIden + 1);
            //    }
            //    Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            //    qidsDetailsBindingSource.Filter = "qidid = " + qidid.ToString() + " and (QidType=" + GLibrary.strarrQidTypes[0, 0] + ")"; //+ " Or QidType=" + GLibrary.strarrQidTypes[5, 0].ToString() + " Or QidType=" + GLibrary.strarrQidTypes[6, 0].ToString()+")";
            // }
            if (invoicesBindingSource.Count > 0)
            {
                // if (invoicesBindingSource.Count == 1 && ((DataRowView)invoicesBindingSource.Current)["InvId"].ToString() == "0")
                if (invoicesBindingSource.Count > 0 && ((DataRowView)invoicesBindingSource.Current).IsNew)
                {
                    ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

                }
                //if (invoicesBindingSource.Count > 0 && ((DataRowView)invoicesBindingSource.Current).IsNew)
                //{
                //    ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

                //}
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];

                //invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                qidsTableAdapter.FillByInvId(nEWERPDataSet.qids, InvId);

                qidsBindingSource.Filter = "InvId = " + InvId.ToString();

                if (qidsBindingSource.Count > 0)
                {
                    Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
                    this.qidsDetailsTableAdapter.FillById(this.nEWERPDataSet.qidsDetails, qidid);

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
                ((DataRowView)invProductsBindingSource.Current)["InvType"] = InvType.ToString();
                if (((DataRowView)invProductsBindingSource.Current)["PRODUCTID"] != DBNull.Value && ((DataRowView)invProductsBindingSource.Current)["UnitId"] != DBNull.Value)
                {
                    string ProductId = ((DataRowView)invProductsBindingSource.Current)["PRODUCTID"].ToString();
                    string UnitId = ((DataRowView)invProductsBindingSource.Current)["UnitId"].ToString();
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices, );
                }
            }

        }


        private void AddNewInv()
        {
            LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            invoicesBindingSource.AddNew();
            if (((DataRowView)bRANCHESBindingSource.Current)["DiscountValue"] != DBNull.Value)
            {
                txtDiscount.Text = ((DataRowView)bRANCHESBindingSource.Current)["DiscountValue"].ToString();
            }
            else
            {
                txtDiscount.Text = "0";
            }

            sUPPLIERSCUSTOMERSBindingSource.Sort = "SUP_CUST_ID";


            chkBoxCheque.Checked = false;
           
            txtKeyNetValue.Enabled = false;
            cmbPayMethode.Enabled = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }

            txtchequeFlag.Text = Boolean.FalseString;
            CmbBillType.SelectedIndex = 1;
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
                CmbBranch.Select();
            }

            CmbBillType.Select();
            if (CmbPaymentAccid.Items.Count > 0)
            {
                CmbPaymentAccid.SelectedValue = Messages.boxAccid;
                CmbPaymentAccid.Select();
            }
            if (CmbInvAccid.Items.Count > 0)
            {
                CmbInvAccid.SelectedValue = Messages.salesaccid;
                CmbInvAccid.Select();
            }

            txtinvTotal.Text = "0";
            txtInvType.Text = InvType.ToString();
            txtRemain.Text = "0";
            if (Messages.CurBranch != "")
            {
                CmbBranch.SelectedValue = Messages.CurBranch;
            }

            UpdateInvCode();

            //if (bYearFlag)
            //{
            //    txtInvCode.Text = DateTime.Today.Year.ToString() + "/" + txtInvCode.Text;
            //}
            if (CmbCustSupAccid.Items.Count > 0)
            {
                if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
                {
                    CmbCustSupAccid.SelectedIndex = 0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
                }
                //SelectedIndex = 0;
                CmbCustSupAccid.Select();
            }

            getSaleAdmin();
         

            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            EditFlag = false;

            if (Messages.SalInvPrim[3] && !EditFlag)
            {
                ProductsDGView.Enabled = true;
                CmdSave.Enabled = true;
            }
            ProductsDGView.Focus();

        }
        private void UpdateInvCode()
        {
            long QidSeial = 0;
            long MaxSerial = (long)invoicesTableAdapter.InvoicesSelectMaxSerial(InvType);
            QidSeial = MaxSerial + 1;
            txtInvCode.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
            FirstCode = QidSeial;
            txtQidSerial.Text = QidSeial.ToString();


            //int Pos = 0;
            //if (CmbBranch.SelectedValue != null)
            //{
            //    Pos = int.Parse(CmbBranch.SelectedIndex.ToString());
            //}
            //else
            //{
            //    Pos = bRANCHESBindingSource.Find("BRANCHCODE", Messages.CurBranch);
            //}

            //switch (InvType)
            //{
            //    case Messages.InvpurchasesFlag:
            //        string PurSerial = "0";
            //        if (nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"] != DBNull.Value)
            //        {
            //            PurSerial = nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"].ToString();
            //        }//nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"].ToString();
            //        txtInvCode.Text = (int.Parse(PurSerial) + 1).ToString();
            //        //txtInvCode.Text = Messages.SysInvpurchasesCode + (LastIden+1).ToString();
            //        break;
            //    case Messages.InvSalesFlag:
            //        string SalSerial = "0";
            //        if (nEWERPDataSet.BRANCHES.Rows[Pos]["SalInvSerial"] != DBNull.Value)
            //        {
            //            SalSerial = nEWERPDataSet.BRANCHES.Rows[Pos]["SalInvSerial"].ToString();//nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"].ToString();
            //        }

            //        txtInvCode.Text = (int.Parse(SalSerial) + 1).ToString();

            //        //txtInvCode.Text = Messages.SysinvSaleCode + (LastIden+1).ToString();

            //        break;
            //}
        }
        private void ClearCust()
        {
            txtCustomerName.Text = "";
            txtTel.Text = "";
            txtAddress.Text = "";
            txtGada.Text = "";
            txtStreet.Text = "";
            txtblock.Text = "";
            txtBuliding.Text = "";
            txtFloor.Text = "";
            txtFlat.Text = "";
            txtblock.Text = "";
            txtHouse.Text = "";
            ////txtCustNote.Text = "";
        }
        private void GetQid()
        {
            SetDiscount();
            // txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
            decimal Value = decimal.Parse(txtinvTotal.Text);
            decimal NetValue = decimal.Parse(txtInvTotalNet.Text);
            decimal RemainValue = Value;
            int AccountIdTo;
            int AccountIdFrom;
            int costId = 0;

            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString())
            {
                AccountIdFrom = int.Parse(CmbCustSupAccid.SelectedValue.ToString()); //   „Ê«—œ œ«∆‰ √Ã·
            }
            else
            {
                AccountIdFrom = int.Parse(CmbPaymentAccid.SelectedValue.ToString());  // ’‰œﬁ œ«∆‰  ‰ﬁœ«
            }

            AccountIdTo = int.Parse(CmbInvAccid.SelectedValue.ToString()); // Õ”«» «·„‘ —Ì«  À«» 
            if (CmbCostCenters.SelectedValue != null)
            {
                costId = int.Parse(CmbCostCenters.SelectedValue.ToString());
            }
            if (qidsBindingSource.Count == 0)
            {
                QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
                qidsBindingSource.AddNew();
                ((DataRowView)qidsBindingSource.Current).BeginEdit();
                ((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + txtInvCode.Text;// QidId.ToString();
                //((DataRowView)qidsBindingSource.Current)["qidDate"] = DateTime.Today;
                ((DataRowView)qidsBindingSource.Current)["qidDate"] = dtInvDate.Value.ToShortDateString();
                ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[3, 0].ToString();
                ((DataRowView)qidsBindingSource.Current)["InvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
                ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranch.SelectedValue;
                ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;
                ((DataRowView)qidsBindingSource.Current).EndEdit();
            }
            else
            {
                ((DataRowView)qidsBindingSource.Current)["qidDate"] = dtInvDate.Value.ToShortDateString();
                ((DataRowView)qidsBindingSource.Current).EndEdit();
            }
            Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            //int i = 0;
            int pos = -1;

            pos = qidsDetailsBindingSource.Find("ActionType", 4);

            if (GLibrary.IsNumeric(txtInvPayment.Text)) //ÊÃÊœ œ›⁄…
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
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 4;
                if (CmbCostCenters.SelectedValue != null)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                }
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
                //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

            }
            else if (txtInvPayment.Text == "" && pos != -1)
            {
                qidsDetailsBindingSource.Position = pos;
                qidsDetailsBindingSource.RemoveCurrent();
            }


            pos = qidsDetailsBindingSource.Find("ActionType", 2);
            if (GLibrary.IsNumeric(txtInvPayment.Text)) //ÊÃÊœ œ›⁄…   „œÌ‰ «·„Ê«—œ
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
                ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom; // Õ”«» «·„Ê«—œ
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
                if (CmbCostCenters.SelectedValue != null)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                }
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


                //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

            }
            else if (txtInvPayment.Text == "" && pos != -1)
            {
                qidsDetailsBindingSource.Position = pos;
                qidsDetailsBindingSource.RemoveCurrent();
            }


            pos = qidsDetailsBindingSource.Find("ActionType", 3);

            if (GLibrary.IsNumeric(txtDiscount.Text)) // ÊÃÊœ Œ’„
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
                ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text);
                ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.Discountaccid;
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); //DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ﬁÌ„… «·Œ’„";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 3;
                if (CmbCostCenters.SelectedValue != null)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                }
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
                RemainValue = RemainValue - (decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text));
            }
            else if (txtInvPayment.Text == "" && pos != -1)
            {
                qidsDetailsBindingSource.Position = pos;
                qidsDetailsBindingSource.RemoveCurrent();
            }


            // œ«∆‰ Ê„œÌ‰ ›Ï Õ«·… ⁄œ„ ÊÃÊœ Œ’„
            // «·„œÌ‰ «·„‘ —Ì« 
            pos = qidsDetailsBindingSource.Find("ActionType", 1);  // «·„Ê«—œ œ«∆‰
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
            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
            if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
            {
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "„— Ã⁄ „»Ì⁄« ";
            }
            //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 1;
            if (CmbCostCenters.SelectedValue != null)
            {
                ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
            }
            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



            pos = qidsDetailsBindingSource.Find("ActionType", 5);

            if (pos == -1)
            {
                qidsDetailsBindingSource.AddNew();
                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
            }
            else
            {
                qidsDetailsBindingSource.Position = pos;
            }
            // œ«∆‰ «·’‰œÊﬁ «Ê «·„Ê«—œ
            ((DataRowView)qidsBindingSource.Current).BeginEdit();
            ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = RemainValue;
            //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); //DateTime.Today;
            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
            if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
            {
                ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "„— Ã⁄ „»Ì⁄« ";
            }
            //((DataRowView)qidsDetailsBindingSource.Current)["Description"] ="›« Ê—…";
            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 5;
            if (CmbCostCenters.SelectedValue != null)
            {
                ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
            }
            //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

            // ---------------------------------------------  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â -------------------------------
            //if (Messages.CostSalesProductAccId > 0 && Messages.StockAccId > 0)
            //{
            //    //„»Ì⁄«  --------------------------------- œ«∆‰
            //    pos = qidsDetailsBindingSource.Find("ActionType", 6);  // «·„»Ì⁄« 
            //    if (pos == -1)
            //    {
            //        qidsDetailsBindingSource.AddNew();
            //        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
            //    }
            //    else
            //    {
            //        qidsDetailsBindingSource.Position = pos;
            //    }

            //    ((DataRowView)qidsBindingSource.Current).BeginEdit();
            //    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = NetValue;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)(Int64)AccountIdTo;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
            //    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
            //    {
            //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—… «·„Œ“Ê‰ «·”·⁄Ï «·„‘ —Ì« ";
            //    }
            //    //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
            //    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 6;
            //    if (CmbCostCenters.SelectedValue != null)
            //    {
            //        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
            //    }
            //    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

            //    // --------------------------------------------- ‰Â«Ì… «·„‘ —Ì«  -------------------------------


            //    // ---------------------------------------------  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â -------------------------------
            //    pos = qidsDetailsBindingSource.Find("ActionType", 7);  //  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â
            //    if (pos == -1)
            //    {
            //        qidsDetailsBindingSource.AddNew();
            //        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
            //    }
            //    else
            //    {
            //        qidsDetailsBindingSource.Position = pos;
            //    }

            //    ((DataRowView)qidsBindingSource.Current).BeginEdit();
            //    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = NetValue;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.StockAccId;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
            //    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
            //    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
            //    {
            //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—… «·„Œ“Ê‰ «·”·⁄Ï";
            //    }
            //    //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
            //    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 7;
            //    if (CmbCostCenters.SelectedValue != null)
            //    {
            //        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
            //    }
            //    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
            //}


            // ---------------------------------------------  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â -------------------------------
            qidsDetailsBindingSource.Sort = "ActionType";
        }
        //private void GetQid()
        //{
        //    int CurBoxAccount = 0;

        //    CurBoxAccount = Messages.boxAccid;

        //    string Desc = "›« Ê—… Œ«’Â »«·⁄„Ì· " + CmbCustSupAccid.Text;

        //    int costId = 0;
        //    // txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
        //    decimal Value = decimal.Parse(txtinvTotal.Text);
        //    decimal NetValue = decimal.Parse(txtInvTotalNet.Text);

        //    decimal RemainValue = Value;
        //    int AccountIdTo;
        //    int AccountIdFrom;

        //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //√Ã·
        //    {
        //        AccountIdTo = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
        //    }
        //    else
        //    {

        //        AccountIdTo = int.Parse(CmbPaymentAccid.SelectedValue.ToString());
        //    }

        //    AccountIdFrom = int.Parse(CmbInvAccid.SelectedValue.ToString()); // Õ”«» «·„»Ì⁄« 

        //    double DisCountvalue = double.Parse(txtinvTotal.Text) - double.Parse(txtInvTotalNet.Text);
        //    Boolean DisFlag = true;



        //    if (qidsBindingSource.Count == 0)
        //    {
        //        QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
        //        qidsBindingSource.AddNew();
        //        ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + txtInvCode.Text;// QidId.ToString();

        //        ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsBindingSource.Current)["InvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
        //        ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranch.SelectedValue;
        //        ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;
        //        //qidsBindingSource.EndEdit();
        //        ((DataRowView)qidsBindingSource.Current).EndEdit();
        //    }
        //      ((DataRowView)qidsBindingSource.Current)["qidDate"] = dtInvDate.Value.ToShortDateString();//'DateTime.Today;

        //    Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
        //    qidsBindingSource.EndEdit();
        //    //int i = 0;
        //    int pos = -1;




        //    pos = qidsDetailsBindingSource.Find("ActionType", 3);

        //    if (GLibrary.IsNumeric(txtDiscount.Text)) //  ÊÃÊœ Œ’„ „œÌ‰ «·Œ’Ê„
        //    {
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text);
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.Discountaccid;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); 
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ﬁÌ„… «·Œ’„";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 3;
        //        //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
        //        RemainValue = RemainValue - (decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text));
        //    }
        //    else if (txtInvPayment.Text == "" && pos != -1)
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //        qidsDetailsBindingSource.RemoveCurrent();
        //    }


        //    if (GLibrary.IsNumeric(((DataRowView)invoicesBindingSource.Current)["KeyNetValue"].ToString()) || GLibrary.IsNumeric(txtKeyNetValue.Text))
        //    {

        //        decimal KeyNetValue = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["KeyNetValue"].ToString());
        //        decimal remain = NetValue - KeyNetValue;
        //        if (remain > 0)
        //        {
        //            ((DataRowView)invoicesBindingSource.Current)["PaymentValue"] = remain;
        //        }
        //        else
        //        {
        //            ((DataRowView)invoicesBindingSource.Current)["PaymentValue"] = DBNull.Value;
        //        }
        //    }

        //    //  œ«∆‰ Ê„œÌ‰ ›Ï Õ«·… ⁄œ„ ÊÃÊœ œ›⁄… ‰ﬁœ« «Ê Œ’„ 
        //    Boolean SFlag = true;
        //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString() && ((DataRowView)invoicesBindingSource.Current)["PaymentValue"] != DBNull.Value)) //√Ã·
        //    {
        //        if ((CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()) && decimal.Parse(((DataRowView)invoicesBindingSource.Current)["PaymentValue"].ToString()) == 0)
        //        {
        //            SFlag = false;
        //        }
        //        if (SFlag)
        //        {
        //            int CurAccountIdTo = AccountIdTo;
        //            if ((CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()))
        //            {
        //                RemainValue = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["PaymentValue"].ToString());
        //                CurAccountIdTo = CurBoxAccount;
        //            }
        //            pos = qidsDetailsBindingSource.Find("ActionType", 1); // „œÌ‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
        //            if (pos == -1)
        //            {
        //                qidsDetailsBindingSource.AddNew();
        //                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //            }
        //            else
        //            {
        //                qidsDetailsBindingSource.Position = pos;
        //            }

        //            ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = RemainValue;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)CurAccountIdTo; //CurBoxAccount;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 1;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



        //            pos = qidsDetailsBindingSource.Find("ActionType", 5);  // œ«∆‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄« 

        //            if (pos == -1)
        //            {
        //                qidsDetailsBindingSource.AddNew();
        //                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //            }
        //            else
        //            {
        //                qidsDetailsBindingSource.Position = pos;
        //            }
        //            if ((CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()))
        //            {
        //                Value = decimal.Parse(((DataRowView)invoicesBindingSource.Current)["PaymentValue"].ToString());
        //                if (DisCountvalue > 0 && DisFlag)
        //                {
        //                    DisFlag = false;
        //                    Value = Value + decimal.Parse(DisCountvalue.ToString());
        //                }
        //            }

        //            ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = Value;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 5;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //            //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
        //            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
        //            qidsDetailsBindingSource.Sort = "ActionType";
        //        }
        //    }
        //    else
        //    {
        //        pos = qidsDetailsBindingSource.Find("ActionType", 1); // „œÌ‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
        //        if (pos > -1)
        //        {

        //            qidsDetailsBindingSource.RemoveAt(pos);
        //            qidsDetailsBindingSource.EndEdit();
        //        }

        //        pos = qidsDetailsBindingSource.Find("ActionType", 5); // œ«∆‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄« 
        //        if (pos > -1)
        //        {
        //            qidsDetailsBindingSource.RemoveAt(pos);
        //            qidsDetailsBindingSource.EndEdit();
        //        }
        //    }



        //    /// Key NET
        //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString() && ((DataRowView)invoicesBindingSource.Current)["KeyNetValue"] != DBNull.Value)
        //    {
        //        if (decimal.Parse(((DataRowView)invoicesBindingSource.Current)["KeyNetValue"].ToString()) != 0)
        //        {

        //            double KeyNetValue = double.Parse(((DataRowView)invoicesBindingSource.Current)["KeyNetValue"].ToString());
        //            double ComKeyNetValue = KeyNetValue * Messages.KeyNetComPercentage;
        //            double BankValue = KeyNetValue - ComKeyNetValue;

        //            if (DisCountvalue > 0 && DisFlag)
        //            {
        //                DisFlag = false;
        //                KeyNetValue = KeyNetValue + DisCountvalue;
        //            }

        //            pos = qidsDetailsBindingSource.Find("ActionType", 8); // „œÌ‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
        //            if (pos == -1)
        //            {
        //                qidsDetailsBindingSource.AddNew();
        //                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //            }
        //            else
        //            {
        //                qidsDetailsBindingSource.Position = pos;
        //            }

        //            ((DataRowView)qidsBindingSource.Current).BeginEdit();

        //            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = BankValue;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo;//Messages.PosBankaccid;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 8;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


        //            pos = qidsDetailsBindingSource.Find("ActionType", 9); // „œÌ‰  ⁄„Ê·… «·ﬂÏ ‰ 
        //            if (pos == -1)
        //            {
        //                qidsDetailsBindingSource.AddNew();
        //                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //            }
        //            else
        //            {
        //                qidsDetailsBindingSource.Position = pos;
        //            }

        //            ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = ComKeyNetValue;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.KeyNetComaccid;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 9;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



        //            pos = qidsDetailsBindingSource.Find("ActionType", 10);  // œ«∆‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄«  «·ﬂÏ ‰ 

        //            if (pos == -1)
        //            {
        //                qidsDetailsBindingSource.AddNew();
        //                ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //            }
        //            else
        //            {
        //                qidsDetailsBindingSource.Position = pos;
        //            }

        //            ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = KeyNetValue;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;// Messages.KeyNetaccid;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = Desc;
        //            ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 10;
        //            //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //            //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
        //            ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();





        //        }
        //    }
        //    else
        //    { //delete Key net
        //        pos = qidsDetailsBindingSource.Find("ActionType", 8); // „œÌ‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
        //        if (pos > -1)
        //        {

        //            qidsDetailsBindingSource.RemoveAt(pos);
        //            qidsDetailsBindingSource.EndEdit();
        //        }

        //        pos = qidsDetailsBindingSource.Find("ActionType", 9); // „œÌ‰  ⁄„Ê·… «·ﬂÏ ‰ 
        //        if (pos > -1)
        //        {
        //            qidsDetailsBindingSource.RemoveAt(pos);
        //            qidsDetailsBindingSource.EndEdit();
        //        }

        //        pos = qidsDetailsBindingSource.Find("ActionType", 10);  // œ«∆‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄«  «·ﬂÏ ‰ 
        //        if (pos > -1)
        //        {
        //            qidsDetailsBindingSource.RemoveAt(pos);
        //            qidsDetailsBindingSource.EndEdit();
        //        }
        //    }

        //    if (Messages.CostSalesProductAccId > 0 && Messages.StockAccId > 0)
        //    {
        //        decimal TotalCost=0;
        //        if (GLibrary.IsNumeric ( txtTotalcost.Text ))
        //        {
        //            TotalCost = decimal.Parse(txtTotalcost.Text);
        //        }
        //        // «·„Œ“‰ «·”·⁄Ì --------------------------------- œ«∆‰
        //        pos = qidsDetailsBindingSource.Find("ActionType", 11);  // «·„Œ“‰ «·”·⁄Ì
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }

        //        ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = TotalCost;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)(Int64)Messages.StockAccId;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—… «·„Œ“Ê‰ «·”·⁄Ï";
        //        }
        //        //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 11;
        //        if (CmbCostCenters.SelectedValue != null)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

        //        // --------------------------------------------- ‰Â«Ì… «·„Œ“Ê‰ «·”·⁄Ï -------------------------------

        //        //  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â ---------------------------------„œÌ‰
        //        pos = qidsDetailsBindingSource.Find("ActionType", 12);  //  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }

        //        ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = TotalCost;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.CostSalesProductAccId;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â ";
        //        }
        //        //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 12;
        //        if (CmbCostCenters.SelectedValue != null)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
        //    }

            

        //}
        //private void GetQid()
        //{
        //    SetDiscount();
        //    int costId = 0;
        //    decimal PaymentValue = 0;
        //    // txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
        //    decimal Value = decimal.Parse(txtinvTotal.Text);
        //    decimal NetValue = decimal.Parse(txtInvTotalNet.Text);
        //    if (GLibrary.IsNumeric(txtInvPay.Text))
        //    {
        //        PaymentValue = decimal.Parse(txtInvPay.Text);
        //    }
        //    decimal Remain = NetValue - PaymentValue;
        //    txtRemain.Text = Remain.ToString();

        //    decimal RemainValue = Value;
        //    int AccountIdTo;
        //    int AccountIdFrom;
        //    long CostId = -1;
        //    AccountIdTo = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
        //    if (CmbCostCenters.SelectedValue != null)
        //    {
        //        CostId = long.Parse(CmbCostCenters.SelectedValue.ToString());
        //    }
        //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //√Ã·
        //    {
        //        AccountIdTo = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
        //    }
        //    else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) // ﬁ”Ìÿ
        //    {
        //        AccountIdTo = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
        //    }
        //    else
        //    {
        //        AccountIdTo = int.Parse(CmbPaymentAccid.SelectedValue.ToString());
        //    }

        //    AccountIdFrom = int.Parse(CmbInvAccid.SelectedValue.ToString()); // Õ”«» «·„»Ì⁄« 

        //    if (CmbCostCenters.SelectedValue != null)
        //    {
        //        costId = int.Parse(CmbCostCenters.SelectedValue.ToString());
        //    }
        //    DateTime QidDate = dtInvDate.Value;
        //    if (qidsBindingSource.Count == 0)
        //    {
        //        QidLastIden = (int)qidsTableAdapter.GetQidsLastIdentity();
        //        qidsBindingSource.AddNew();
        //        ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsBindingSource.Current)["qidcode"] = "Q" + txtInvCode.Text;// QidId.ToString();
        //        //((DataRowView)qidsBindingSource.Current)["qidDate"] = DateTime.Today;
        //        ((DataRowView)qidsBindingSource.Current)["qidDate"] = dtInvDate.Value.ToShortDateString();
        //        ((DataRowView)qidsBindingSource.Current)["recitetype"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsBindingSource.Current)["InvId"] = ((DataRowView)invoicesBindingSource.Current)["InvId"];
        //        ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranch.SelectedValue;
        //        ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId;
        //        //qidsBindingSource.EndEdit();
        //        ((DataRowView)qidsBindingSource.Current).EndEdit();
        //    }
        //    else
        //    {
        //        ((DataRowView)qidsBindingSource.Current)["qidDate"] = dtInvDate.Value.ToShortDateString();
        //        ((DataRowView)qidsBindingSource.Current).EndEdit();
        //    }


        //    Int64 QidId = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
        //    //int i = 0;
        //    int pos = -1;

        //    pos = qidsDetailsBindingSource.Find("ActionType", 2);
        //    if (GLibrary.IsNumeric(txtInvPayment.Text)) //„œÌ‰ «·’‰œÊﬁ      ÊÃÊœ œ›⁄…
        //    {
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = decimal.Parse(txtInvPayment.Text);
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.boxAccid;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 2;
        //        if (CostId > -1)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = CostId;
        //        }

        //        //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

        //        //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

        //    }
        //    else if (txtInvPayment.Text == "" && pos != -1)
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //        qidsDetailsBindingSource.RemoveCurrent();
        //    }



        //    pos = qidsDetailsBindingSource.Find("ActionType", 4);
        //    if (GLibrary.IsNumeric(txtInvPayment.Text)) //ÊÃÊœ œ›⁄…   œ«∆‰ «·⁄„Ì·
        //    {
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = decimal.Parse(txtInvPayment.Text);
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo; // Õ”«» «·⁄„Ì·
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "œ›⁄… ‰ﬁœÌ…";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 4;
        //        if (CostId > -1)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = CostId;
        //        }
        //        //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


        //        //RemainValue = RemainValue - decimal.Parse(txtInvPayment.Text);

        //    }
        //    else if (txtInvPayment.Text == "" && pos != -1)
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //        qidsDetailsBindingSource.RemoveCurrent();
        //    }




        //    pos = qidsDetailsBindingSource.Find("ActionType", 3);

        //    if (GLibrary.IsNumeric(txtDiscount.Text)) //  ÊÃÊœ Œ’„ „œÌ‰ «·Œ’Ê„
        //    {
        //        if (pos == -1)
        //        {
        //            qidsDetailsBindingSource.AddNew();
        //            ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //        }
        //        else
        //        {
        //            qidsDetailsBindingSource.Position = pos;
        //        }
        //        ((DataRowView)qidsDetailsBindingSource.Current).BeginEdit();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text);
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.Discountaccid;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); //DateTime.Today;
        //        ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "ﬁÌ„… «·Œ’„";
        //        ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 3;
        //        if (CostId > -1)
        //        {
        //            ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = CostId;
        //        }
        //        // ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //        ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
        //        RemainValue = RemainValue - (decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text));
        //    }
        //    else if (txtInvPayment.Text == "" && pos != -1)
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //        qidsDetailsBindingSource.RemoveCurrent();
        //    }

        //    //  œ«∆‰ Ê„œÌ‰ ›Ï Õ«·… ⁄œ„ ÊÃÊœ œ›⁄… «Ê Œ’„ 
        //    pos = qidsDetailsBindingSource.Find("ActionType", 1); // „œÌ‰ «·⁄„Ì· «Ê «·’‰œÊﬁ
        //    if (pos == -1)
        //    {
        //        qidsDetailsBindingSource.AddNew();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //    }
        //    else
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //    }
        //    ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = RemainValue;
        //    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdTo;
        //    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); //DateTime.Today;
        //    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //    if (CostId > -1)
        //    {
        //        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = CostId;
        //    }

        //    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
        //    {
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
        //    }
        //    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 1;

        //    //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();



        //    pos = qidsDetailsBindingSource.Find("ActionType", 5);  // œ«∆‰ «·„»Ì⁄«    Õ”«» «·„»Ì⁄« 

        //    if (pos == -1)
        //    {
        //        qidsDetailsBindingSource.AddNew();
        //        ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = QidId;
        //    }
        //    else
        //    {
        //        qidsDetailsBindingSource.Position = pos;
        //    }

        //    ((DataRowView)qidsBindingSource.Current).BeginEdit();
        //    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = Value;
        //    //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
        //    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
        //    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();//DateTime.Today;
        //    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[2, 0];
        //    if (CostId > -1)
        //    {
        //        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = CostId;
        //    }

        //    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
        //    {
        //        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
        //    }

        //    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 5;
        //    //((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
        //    //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
        //    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
        //    qidsDetailsBindingSource.Sort = "ActionType";
        //}

        private void InvtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InvtabControl.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    if (invProductsBindingSource.Count > 0 && txtinvTotal.Text != "")
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
                    if (invProductsBindingSource.Count > 0 && txtinvTotal.Text != "")
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
            if (ProductsDGView.Rows.Count > 0)
            {
                if (e.ColumnIndex == PriceVal.Index || e.ColumnIndex == Qty.Index || e.ColumnIndex == Discount.Index)
                {
                    if (ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        if (GLibrary.IsNumeric(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                        {

                            GetPriceSum();
                            // txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())).ToString();

                        }
                    }

                }
                if (e.ColumnIndex == Qty.Index)
                {
                    if (this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != null && ProductsDGView["CmbStoreId", e.RowIndex].Value != null && ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                        string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                        string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();
                        string strQty = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        Boolean ret;
                        //ret = CheckQty(ProductId, StoreId, UnitId, strQty);
                        //if (!ret)
                        //{
                        //    QtyFlag = true;
                        //    this.ProductsDGView["Qty", e.RowIndex].Value = DBNull.Value;
                        //    QtyFlag = false;
                        //}

                    }
                }
                if (e.ColumnIndex == PriceVal.Index)
                {
                    //string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                    //string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                    if (ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string strPrice = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        CheckPrice(strPrice);
                    }
                }
                if (e.ColumnIndex == BarCode.Index)
                {
                    string strBarCode = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                }
            }
        }
        private void CheckPrice(string strPrice)
        {
            if (((DataRowView)productUnitsPricesBindingSource.Current)["SalePrice"] != DBNull.Value)
            {
                decimal MinPrice = decimal.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["SalePrice"].ToString());
                if (strPrice != "")
                {
                    if (decimal.Parse(strPrice) < MinPrice)
                    {
                        MessageBox.Show(Messages.MinPriceMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.StockNullQtyMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            else
            {

            }
        }
        private Boolean CheckQty(string ProductId, string StoreId, string UnitId, string Qty)
        {
            if (ProductId != "" && StoreId != "")
            {
                decimal StockQty = decimal.Parse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), int.Parse(StoreId)).ToString());
                long Inv_Product_Id = 0;
                if (((DataRowView)invProductsBindingSource.Current)["Inv_Product_Id"] != DBNull.Value)
                {
                    Inv_Product_Id = long.Parse(((DataRowView)invProductsBindingSource.Current)["Inv_Product_Id"].ToString());
                }
                decimal CurrentQty = 0;
                if (EditFlag)
                {
                    CurrentQty = decimal.Parse(invoicesTableAdapter.GetInvProductQty(Inv_Product_Id).ToString());
                }

                if (Qty != "")
                {
                    long CurConFactor = 1;
                    CurConFactor = long.Parse(sTOCKTableAdapter.GetConFactor(int.Parse(ProductId), int.Parse(UnitId)).ToString());

                    //if (CurConFactor != 0)
                    //{
                    //    CurConFactor = CurConFactor;
                    //}

                    if ((decimal.Parse(Qty) * CurConFactor) > StockQty + CurrentQty)
                    {
                        MessageBox.Show(Messages.StockQtyMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        return false;
                    }
                }
                else
                {
                    if (!QtyFlag)
                    {
                        MessageBox.Show(Messages.StockNullQtyMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }

                }
            }
            return true;
            //else
            //{

            //}
        }
        private void GetPriceSum()
        {
            txtinvTotal.Text = "0";
            txtTotalcost.Text = "0";
            //for (int i = 0; i < invProductsBindingSource.Count; i++)
            if (invProductsBindingSource.Count > 0)
            {
                for (int i = 0; i < ProductsDGView.Rows.Count; i++)
                {
                    if (ProductsDGView.Rows[i].Cells["Qty"].Value != DBNull.Value && ProductsDGView.Rows[i].Cells["PriceVal"].Value != DBNull.Value)
                    {
                        if (ProductsDGView.Rows[i].Cells["Qty"].Value != null)
                        {
                            if (ProductsDGView.Rows[i].Cells["PriceVal"].Value != null)
                            {
                                if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()))
                                {
                                    decimal CurDistcount = (decimal.Parse(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString())) * (decimal.Parse(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()) / 100);
                                    decimal CurTotal = (decimal.Parse(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString())) - CurDistcount;
                                    ProductsDGView.Rows[i].Cells["TotalPrice"].Value = decimal.Round(CurTotal, 3);
                                    decimal ItemDiscount = decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString()) * (decimal.Parse(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()) / 100);

                                    //ProductsDGView.Rows[i].Cells["CurItemNo"].Value = decimal.Round(ItemDiscount, 3);
                                    if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString()))
                                    {
                                        txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString())).ToString();
                                    }
                                }
                            }
                            if (ProductsDGView.Rows[i].Cells["ItemNo"].Value != null)
                            {
                                if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["ItemNo"].Value.ToString()))
                                {
                                    decimal CurBuyTotal = (decimal.Parse(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["ItemNo"].Value.ToString()));
                                    //txtTotalcost.Text = CurBuyTotal.ToString();
                                    //if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString()))
                                    //{
                                        txtTotalcost.Text = (decimal.Parse(txtTotalcost.Text) + CurBuyTotal).ToString();
                                    //}
                                }
                            }
                        }
                    }

                }
                SetDiscount();
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

            //MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            // else

            // SystemSounds.Beep.Play();
        }

        private void ProductsDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (sTORESBindingSource.Count > 0)
            {
                e.Row.Cells["CmbStoreId"].Value = ((DataRowView)sTORESBindingSource.Current)["STOREID"].ToString();
            }
            else
            {
                e.Row.Cells["CmbStoreId"].Value = "1";
            }

            e.Row.Cells["Discount"].Value = "0";
            e.Row.Cells["ReoderFlag"].Value = Boolean.FalseString;
            e.Row.Cells["Qty"].Value = "1";


        }


        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {

                if (qidsBindingSource.Count > 0 && ((DataRowView)qidsBindingSource.Current).IsNew) //["qidid"].ToString() == "0")
                {

                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(QidLastIden + 1);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

                //this.qidsDetailsTableAdapter.FillById(this.nEWERPDataSet.qidsDetails, qidid);

                qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString();
                qidsDetailsBindingSourceWith.Filter = "qidid =" + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[4, 0].ToString(); // ﬁÌœ „—›ﬁ

            }
            else
            {
                qidsDetailsBindingSource.Filter = "qidid =-1";
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
                //GLibrary.ValidatetxtBox(errorProvider1, txtDiscount, "√œŒ· «·Œ’„ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·Œ’„", true);
            }
            else
            {
                if (DistPerrdBtn.Checked)
                {
                    txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
                }
                if (DistValrdBtn.Checked)
                {
                    txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtDiscount.Text)).ToString();
                }
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

            //if (chkBoxCheque.Checked)
            //{
            //    txtChequeNo.Enabled = true;
            //    accountingBindingSource.Filter = "accountid=" + Messages.bankaccid + " or AccountparentId=" + Messages.bankaccid;
            //    txtchequeFlag.Text = Boolean.TrueString;
            //    CmbPaymentAccid.Enabled = true ;
            //    //CmbPaymentAccid.SelectedIndex = 0;
            //    if (bRANCHESBindingSource.Count > 0)
            //    {
            //        if (((DataRowView)bRANCHESBindingSource.Current)["KeyNetaccid"] != DBNull.Value)
            //        {
            //            CmbPaymentAccid.SelectedValue = long.Parse (((DataRowView)bRANCHESBindingSource.Current)["KeyNetaccid"].ToString ());
            //        }
            //    }

            //}
            //else
            //{

            //    txtChequeNo.Enabled = false;
            //    txtChequeNo.Text = "";
            //    accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.boxAccid;
            //    txtchequeFlag.Text = Boolean.FalseString ;

            //    //if (accountingBindingSource.Count > 0)
            //    //{
            //    //    CmbPaymentAccid.SelectedIndex = 0;
            //    //}

            //}
            if (chkBoxCheque.Checked)
            {
                accountingBindingSource.Filter = /*"accountid=" + Messages.bankaccid + " or*/ "AccountparentId=" + Messages.bankaccid;
                txtchequeFlag.Text = Boolean.TrueString;
                txtChequeNo.Enabled = true;
                txtKeyNetValue.Enabled = true;
                txtKeyNetValue.ReadOnly = false;

                ((DataRowView)invoicesBindingSource.Current)["PaymentValue"] = DBNull.Value;
                ((DataRowView)invoicesBindingSource.Current)["ChequeFlag"] = Boolean.TrueString;
                invoicesBindingSource.EndEdit();

                if (accountingBindingSource.Count > 0)
                {
                    CmbPaymentAccid.SelectedIndex = 0;
                    CmbPaymentAccid.SelectedValue = ((DataRowView)accountingBindingSource.Current)["ACCOUNTID"];
                    ((DataRowView)invoicesBindingSource.Current)["PaymentAccid"] = ((DataRowView)accountingBindingSource.Current)["ACCOUNTID"];
                    CmbPaymentAccid.Select();
                }

                //txtKeyNetValue.ReadOnly = false ;
                //txtInvPay.ReadOnly = true;
                cmbPayMethode.Enabled = true;
                cmbPayMethode.SelectedIndex = 0;
                cmbPayMethode.SelectedValue = "1";

                //accountingBindingSource.Filter = "accountid=" + Messages.bankaccid + " or AccountparentId=" + Messages.bankaccid;
                //txtchequeFlag.Text = Boolean.TrueString;
                //CmbPaymentAccid.Enabled = true ;
                //if (accountingBindingSource.Count > 0)
                //{
                //    CmbPaymentAccid.SelectedIndex = 0;
                //}

            }
            else
            {

                //txtKeyNetValue.ReadOnly = true; 

                txtChequeNo.Text = "";
                txtKeyNetValue.Text = "";
                txtchequeFlag.Text = Boolean.FalseString;


               
              
                ((DataRowView)invoicesBindingSource.Current)["ChequeFlag"] = Boolean.FalseString;
                ((DataRowView)invoicesBindingSource.Current)["ChequeNo"] = DBNull.Value;
                ((DataRowView)invoicesBindingSource.Current)["KeyNetValue"] = 0;

                invoicesBindingSource.EndEdit();


                accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.accountidMainBox;
                //txtchequeFlag.Text = Boolean.FalseString ;
                if (accountingBindingSource.Count > 0)
                {
                    CmbPaymentAccid.SelectedIndex = 0;
                    CmbPaymentAccid.SelectedValue = ((DataRowView)accountingBindingSource.Current)["ACCOUNTID"];
                    ((DataRowView)invoicesBindingSource.Current)["PaymentAccid"] = ((DataRowView)accountingBindingSource.Current)["ACCOUNTID"];
                    CmbPaymentAccid.Select();
                }

                txtChequeNo.Enabled = false;
                txtKeyNetValue.Enabled = false;
                //txtInvPay.ReadOnly = false;
                txtKeyNetValue.ReadOnly = true;
                cmbPayMethode.SelectedValue = -1;
                cmbPayMethode.Enabled = false;

            }


        }

        private void MenuItemDel_Click(object sender, EventArgs e)
        {
            if (qidsDetailsBindingSourceWith.Count > 0)
            {
                qidsDetailsBindingSourceWith.RemoveCurrent();
                qidsDetailsBindingSourceWith.EndEdit();
            }
        }

        private void txtInvCode_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.invoicesTableAdapter.FillByCode(this.nEWERPDataSet.invoices, txtInvCode.Text);

                int pos = invoicesBindingSource.Find("InvCode", txtInvCode.Text);

                if (pos != -1)
                {
                    EditFlag = true;
                    if (GLibrary.MsgCheckSave(false))
                    {

                        SaveAll(false);
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
                    //invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
                    this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                    qidsTableAdapter.FillByInvId(nEWERPDataSet.qids, InvId);
                    qidsBindingSource.Filter = "InvId = " + InvId.ToString();
                    GetCustomerData();

                    //if (((DataRowView)invoicesBindingSource.Current)["CustomerId"] != DBNull.Value)
                    //{
                    //    long CustId = long.Parse(((DataRowView)invoicesBindingSource.Current)["CustomerId"].ToString());
                    //    int Cuspos = homeCustomerBindingSource.Find("CustId", CustId);
                    //    if (Cuspos > -1)
                    //    {
                    //        homeCustomerBindingSource.Position = Cuspos;
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"] != DBNull.Value)
                    //        {
                    //            txtCustomerName.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Address"] != DBNull.Value)
                    //        {
                    //            txtAddress.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Address"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"] != DBNull.Value)
                    //        {
                    //            txtTel.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"].ToString();
                    //        }

                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["block"] != DBNull.Value)
                    //        {
                    //            txtblock.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["block"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["street"] != DBNull.Value)
                    //        {
                    //            txtStreet.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["street"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"] != DBNull.Value)
                    //        {
                    //            txtGada.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"] != DBNull.Value)
                    //        {
                    //            txtBuliding.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"] != DBNull.Value)
                    //        {
                    //            txtFlat.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["House"] != DBNull.Value)
                    //        {
                    //            txtHouse.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["House"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"] != DBNull.Value)
                    //        {
                    //            txtFloor.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"].ToString();
                    //        }
                    //        if (((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"] != DBNull.Value)
                    //        {
                    //            txtCustNote.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"].ToString();
                    //        }
                    //    }
                    //}


                    CmdAdd.Enabled = true;
                    CmdDel.Enabled = true;

                    SetPermission();
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
                        CmdAdd.Enabled = true;
                        CmdDel.Enabled = true;
                        EditFlag = true;
                    }

                }

            }


        }
        private void GetCustomerData()
        {
            if (((DataRowView)invoicesBindingSource.Current)["CustomerId"] != DBNull.Value)
            {
                long CustId = long.Parse(((DataRowView)invoicesBindingSource.Current)["CustomerId"].ToString());
                int Cuspos = homeCustomerBindingSource.Find("CustId", CustId);
                if (Cuspos > -1)
                {
                    homeCustomerBindingSource.Position = Cuspos;
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"] != DBNull.Value)
                    {
                        txtCustomerName.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["Address"] != DBNull.Value)
                    {
                        txtAddress.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Address"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"] != DBNull.Value)
                    {
                        txtTel.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"].ToString();
                    }

                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["block"] != DBNull.Value)
                    {
                        txtblock.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["block"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["street"] != DBNull.Value)
                    {
                        txtStreet.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["street"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"] != DBNull.Value)
                    {
                        txtGada.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"] != DBNull.Value)
                    {
                        txtBuliding.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"] != DBNull.Value)
                    {
                        txtFlat.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Flat"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["House"] != DBNull.Value)
                    {
                        txtHouse.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["House"].ToString();
                    }
                    if (((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"] != DBNull.Value)
                    {
                        txtFloor.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"].ToString();
                    }
                    //if (((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"] != DBNull.Value)
                    //{
                    //    txtCustNote.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"].ToString();
                    //}
                }
            }
        }
        void deleteItem()
        {
            if (invProductsBindingSource.Count > 0)
            {
                invProductsBindingSource.RemoveCurrent();
            }
        }
        private void MenuItemDelProduct_Click(object sender, EventArgs e)
        {
            deleteItem();
        }

        private void ProductsDGView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "CmbPRODUCTID" || dgv.CurrentCell.OwningColumn.Name == "ProductCode")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

            }
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
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        //dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                    }


                }

            }


        }

        private void ProductsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            i = 10;
            //if (e.ColumnIndex == this.CmbUnitId.Index)
            //{
            //    // Reset combobox cell to the unfiltered BindingSource
            //    DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
            //    this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);

            //}


        }


        private void dGViewQidWith_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //e.Cancel = true;
            //e.ThrowException = false;
            //// A single error may cause secondary calls to this handler, ignore these.
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
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
            }
        }

        private void dGViewQidWith_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            dGViewQidWith.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowPrintDlg = true;
            if (!EditFlag)
            {
                SaveAll(false);
            }
            SetPermission();
            PrintFlag = true;
            printInv(3000);
            AddNewInv();
            ClearCust();
            //if (EditFlag)
            //{
            //    ShowProductsRpt frm = new ShowProductsRpt();
            //    this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            //    frm.nEWERPDataSet = nEWERPDataSet;
            //    frm.choiceNum = 3;
            //    frm.CustName = CmbCustSupAccid.Text;
            //    //frm.InvType = "Sales Invoice";
            //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //    {
            //        frm.InvType = "CREDIT";
            //    }
            //    else
            //    {
            //        frm.InvType = "CASH";
            //    }

            //    if (txtinvTotal.Text != "")
            //    {
            //        frm.TotalSum = decimal.Parse(txtinvTotal.Text);
            //        frm.strTotalSum = GLibrary.FigureInWordsNumType(double.Parse(txtinvTotal.Text), 1);
            //    }
            //    else
            //    {

            //        frm.TotalSum = 0;
            //        frm.strTotalSum = "";
            //    }
            //    if (txtInvTotalNet.Text != "")
            //    {
            //        frm.TotalNet = decimal.Parse(txtInvTotalNet.Text);
            //        frm.strTotalNet = GLibrary.FigureInWordsNumType(double.Parse(txtInvTotalNet.Text), 1);
            //    }
            //    else
            //    {
            //        frm.TotalNet = 0;
            //        frm.strTotalNet = "";
            //    }

            //    if (txtDiscount.Text != "")
            //    {
            //        frm.Discount = decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text); // decimal.Parse(txtDiscount.Text);
            //        frm.strDiscount = GLibrary.FigureInWordsNumType(double.Parse(txtDiscount.Text), 1);
            //    }
            //    else
            //    {
            //        frm.Discount = 0;
            //        frm.strDiscount = "";
            //    }

            //    frm.InvDate = dtInvDate.Value;
            //  DialogResult ret = MessageBox.Show(Messages.ShowInvMesg, "«·⁄„·«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //  if (ret == DialogResult.Yes)
            //  {
            //      frm.PrintFlag = false;
            //      frm.ShowDialog(this);
            //  }
            //  else
            //  {
            //      frm.PrintFlag = true;
            //      frm.ShowReport();
            //  }
            //}
            //else
            //{
            //    MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //}

        }


        private void CmbCustSupAccid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getSaleAdmin();
        }
        private void getSaleAdmin()
        {
            if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            {
                int pos = sUPPLIERSCUSTOMERSBindingSource.Find("accountid", CmbCustSupAccid.SelectedValue);
                if (pos > -1)
                {
                    System.Data.DataView list = new System.Data.DataView();
                    list = (DataView)sUPPLIERSCUSTOMERSBindingSource.List;
                    DataTable T = list.ToTable();
                    txtSupCustId.Text = T.Rows[pos]["SUP_CUST_ID"].ToString();

                }
                //txtSupCustId.Text = ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_ID"].ToString();

                if (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"] != DBNull.Value)
                {
                    //int EmpCode = int.Parse (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"].ToString ());

                    //pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, EmpCode,null,null,null,null);
                    //if (personalDataSet.PER_EMPLOYEE_DATA.Rows.Count > 0)
                    //{
                    //    //txtSaleAdmin.Text = personalDataSet.PER_EMPLOYEE_DATA.Rows[0]["EMPNAME"].ToString();
                    //}


                }
            }
        }
        private void CheckCancel()
        {
            //DataRow[] dr = nEWERPDataSet.Inv_Products.Select("", "", DataViewRowState.ModifiedCurrent);

            //int irowsChgd = dr.GetUpperBound(0) + 1;
            //if (ProductsDGView.IsCurrentRowDirty | irowsChgd > 0)
            //{
            //    // DialogResult dlgReslt = MessageBox.Show("Save Changes?", this.Text + " - The row has unsaved changes", MessageBoxButtons.YesNo);
            //    //if (dlgReslt == DialogResult.Yes)
            //    if (GLibrary.MsgCheckSave(false))
            //    {
            //        SaveAll(true);
            //        //SaveAll(true);
            //        //setStatus("Saved change to regex "+ regexNameTextBox.Text);
            //    }
            //    else
            //    {  //' problem with cancelling change, cancel edit does not

            //        //StockDGView.CancelEdit();
            //        invoicesBindingSource.CancelEdit();
            //        invProductsBindingSource.CancelEdit();
            //        qidsBindingSource.CancelEdit();
            //        qidsDetailsBindingSource.CancelEdit();
            //        qidsDetailsBindingSourceWith.CancelEdit();

            //    }

            //}
            //else
            //{
            //    invoicesBindingSource.CancelEdit();
            //    invProductsBindingSource.CancelEdit();
            //    qidsBindingSource.CancelEdit();
            //    qidsDetailsBindingSource.CancelEdit();
            //    qidsDetailsBindingSourceWith.CancelEdit();
            //}
            //if (!EditFlag)
            //{
            //    CmdAdd.Enabled = true;
            //    //CmdDel.Enabled = true;
            //    BtnPrint.Enabled = true;
            //    EditFlag = true;
            //}
            //if (Messages.CurLang == Messages.ArabLang)
            //{
            //    CmdSave.Text = " ⁄œÌ·";

            //}
            //else if (Messages.CurLang == Messages.EngLang)
            //{
            //    CmdSave.Text = "ÚıÚÚııEdit";
            //}




            //if (GLibrary.MsgCheckSave(false))
            //{

            //    SaveAll(true);

            //}
            //else
            //{

            invoicesBindingSource.CancelEdit();
            invProductsBindingSource.CancelEdit();
            qidsBindingSource.CancelEdit();
            qidsDetailsBindingSource.CancelEdit();
            qidsDetailsBindingSourceWith.CancelEdit();

            nEWERPDataSet.invoices.RejectChanges();
            nEWERPDataSet.Inv_Products.RejectChanges();
            nEWERPDataSet.qids.RejectChanges();
            nEWERPDataSet.qidsDetails.RejectChanges();

            if (!EditFlag)
            {
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                EditFlag = true;
            }
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = " ⁄œÌ·";
            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "ÚEdit";
            }


            //  }
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //«Ã·
            {
                txtInvPayment.Enabled = true;
                CmbPaymentAccid.Enabled = true;
            }
            else
            {
                txtInvPayment.Enabled = false;
                CmbPaymentAccid.Enabled = false;
            }
            SetPermission();
        }
        //        Catch rAs NoNullAllowedException

        //MsgBox("Please finish edit the current new row first.")

        //EndTry


        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

            CheckCancel();


        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckCancel();

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }






        private void CmbCustSupAccid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                AddCust();

            }
        }
        private void AddCust()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            {
                int pos = CmbCustSupAccid.FindStringExact(CmbCustSupAccid.Text);
                if (pos == -1)
                {
                    DialogResult ret = MessageBox.Show(Messages.CustNotFoundMsg, "«·⁄„·«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (ret == DialogResult.Yes)
                    {
                        CustSupOutAdd frmCustSup = new CustSupOutAdd();

                        frmCustSup.CustSupType = 2;
                        frmCustSup.EditFlag = false;


                        frmCustSup.CustFname = CmbCustSupAccid.Text;


                        if (frmCustSup.ShowDialog() == DialogResult.OK)
                        {

                            this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                            CmbCustSupAccid.SelectedValue = frmCustSup.txtAccountId.Text;
                            //CmbCustSupAccid.Select();
                        }
                    }
                    else
                    {
                        CmbCustSupAccid.Text = "";
                    }
                }
            }
        }

        private void ProductsDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            DataGridViewComboBoxCell dgcbProduct = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
            DataGridViewComboBoxCell dgcbProductCode = (DataGridViewComboBoxCell)ProductsDGView["ProductCode", e.RowIndex];
            //string  dgcbBarCode = ProductsDGView["BarCode", e.RowIndex].FormattedValue.ToString ();

            if (dgv.Columns[e.ColumnIndex].Name == "CmbPRODUCTID" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) // ⁄„Êœ «·’‰›
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];
                productUnitsPricesBindingSource.RemoveFilter();
                int pos = pRODUCTSBindingSource.Find("EnglishName", e.FormattedValue);
                 //int pos = pRODUCTSBindingSource.Find("productname", e.FormattedValue);
                
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());

                    if (dgcbProduct.Value.ToString() != ProductId.ToString())
                    {
                        dgcbProduct.Value = ProductId.ToString();
                        dgcbProductCode.Value = ProductId.ToString();

                        // dgcbBarCode.Value = ProductId.ToString(); //


                        this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));

                        if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                        {
                            DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                            dgcbUnit.Value = nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                            productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                            if (productUnitsPricesBindingSource.Count > 0)
                            {
                                string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                                string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                                string AvgBuyPrice = ((DataRowView)productUnitsPricesBindingSource.Current)["AvgCostPrice"].ToString();

                                ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                                if (GLibrary.IsNumeric(SalePrice))
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                                    CurProductId = ProductId;
                                }
                                //if (ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value == DBNull.Value)
                                //{
                                //    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                                  
                                //    CurProductId = ProductId;
                                //}

                                //if (ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value == DBNull.Value)
                                //{
                                if (GLibrary.IsNumeric(AvgBuyPrice))
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = AvgBuyPrice;
                                    CurProductId = ProductId;
                                }
                                else
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = 0;
                                }
                               // }
                                


                            }
                            //productUnitsPricesBindingSource.RemoveFilter();
                        }
                    }
                    PriceVal.Selected = true;
                    ItemNo.Selected = true;
                }
                //else
                //{
                //    DialogResult ret = MessageBox.Show(Messages.CheckProdcutAddMsg, "«·«’‰«›", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //    if (ret == DialogResult.Yes)
                //    {
                //        ProductAdd frm = new ProductAdd();
                //        frm.ShowDialog();
                //    }
                //}
            }
            if (dgv.Columns[e.ColumnIndex].Name == "ProductCode" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];

                productUnitsPricesBindingSource.RemoveFilter();
                //int pos = pRODUCTSBindingSource.Find("productCode", e.FormattedValue);
                int pos = pRODUCTSBindingSource.Find("productname", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());


                    //dgcbBarCode.Value = ProductId.ToString(); 
                    if (dgcbProductCode.Value.ToString() != ProductId.ToString())
                    {
                        dgcbProduct.Value = ProductId.ToString();
                        dgcbProductCode.Value = ProductId.ToString();
                        this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                        if (nTempEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                        {
                            DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                            dgcbUnit.Value = nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                            productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                            if (productUnitsPricesBindingSource.Count > 0)
                            {
                                string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                                ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                                string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                                string AvgBuyPrice = ((DataRowView)productUnitsPricesBindingSource.Current)["AvgCostPrice"].ToString();
                                //if (ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value == DBNull.Value)
                                //{
                                //    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                                   
                                //}
                                if (GLibrary.IsNumeric(SalePrice))
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                                   
                                }

                                if (GLibrary.IsNumeric(AvgBuyPrice))
                                {
                                    //if (ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value == DBNull.Value)
                                    //{
                                        ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = AvgBuyPrice;
                                    //}
                                }
                                else
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = 0;
                                }
                               
                            }
                            //productUnitsPricesBindingSource.RemoveFilter();
                        }
                    }
                    PriceVal.Selected = true;
                    ItemNo.Selected = true;
                }

            }

            // Barcode
            if (dgv.Columns[e.ColumnIndex].Name == "BarCode")
            {
                if (e.FormattedValue.ToString() != "")
                {
                    productUnitsPricesBindingSource.RemoveFilter();
                    int pos = productUnitsPricesBindingSource.Find("PRODUCTBRAND", e.FormattedValue);
                    if (pos > -1)
                    {

                        productUnitsPricesBindingSource.Position = pos;
                        int ProductId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString());

                        string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                        string AvgBuyPrice = ((DataRowView)productUnitsPricesBindingSource.Current)["AvgCostPrice"].ToString();

                        //if (ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value == DBNull.Value)
                        //{
                        //    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                         
                        //}
                        if (GLibrary.IsNumeric(SalePrice))
                        {
                            ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                            CurProductId = ProductId;
                        }

                        //if (ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value == DBNull.Value)
                        //{
                        if (GLibrary.IsNumeric(AvgBuyPrice))
                        {

                            ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = AvgBuyPrice;
                        }
                        //}

                        //dgcbBarCode.Value = ProductId.ToString(); 
                        int pos1 = pRODUCTSBindingSource.Find("PRODUCTID", ProductId);
                        pRODUCTSBindingSource.Position = pos1;
                        dgcbProduct.Value = ProductId.ToString();
                        dgcbProductCode.Value = ProductId.ToString();

                        int CurUintId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["UintId"].ToString());

                        //this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                        //if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                        //{
                        //    DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        //    dgcbUnit.Value = nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                        //}
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = CurUintId;// nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                        PriceVal.Selected = true;
                        ItemNo.Selected = true;
                    }
                    else
                    {
                        // MessageBox.Show(Messages.CheckProdcutCodeMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                    }
                }

            }

            if (dgv.Columns[e.ColumnIndex].Name == "CmbUnitId" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) // ⁄„Êœ «·’‰›
            {
                //productUnitsPricesBindingSource.RemoveFilter();
                int pos = cDEUNITTYPESBindingSource.Find("UNITDESC", e.FormattedValue);
                if (pos > -1)
                {
                    int CurUintId = int.Parse(((DataRowView)cDEUNITTYPESBindingSource[pos])["UINTID"].ToString());
                    DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                    if (ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != DBNull.Value)
                    {
                        string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                        productUnitsPricesBindingSource.Filter = "productid=" + ProductId + " And UintId=" + CurUintId;
                        if (productUnitsPricesBindingSource.Count > 0)
                        {
                            dgcbUnit.Value = CurUintId;//
                            string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                            string AvgBuyPrice = ((DataRowView)productUnitsPricesBindingSource.Current)["AvgCostPrice"].ToString();

                            if (SalePrice != "" && ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value != DBNull.Value)
                            {
                                //((DataRowView)invProductsBindingSource.Current)["Price"] = SalePrice;
                                if (decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value.ToString()) != 0)
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                                 
                                }
                                else
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = 0;
                                }


                            }
                            else
                            {
                                ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = 0;
                            }

                            if (AvgBuyPrice != "" && ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value != DBNull.Value)
                            {
                                if (decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value.ToString()) != 0)
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = AvgBuyPrice;
                                }
                                else
                                {
                                    ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = 0;
                                }
                            }
                            else
                            {
                                ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = 0;
                            }


                        }
                        else
                        {
                            MessageBox.Show("Â–Â «·ÊÕœ… €Ì— „ÕœœÂ ·Â–« «·’‰›", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }


                }
            }
            if (dgv.Columns[e.ColumnIndex].Name == "PriceVal")
            {

            }
            else
            {
            if (ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != DBNull.Value)
            {
                if (this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != null)
                {
                    string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                    string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                    string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();
                    string strQty = this.ProductsDGView["Qty", e.RowIndex].Value.ToString();

                    long StockQty = 0;

                    bool t = long.TryParse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), int.Parse(StoreId)).ToString(), out StockQty);

                    long GetTHRESHOLDQty = long.Parse(sTOCKTableAdapter.GetTHRESHOLDQty(int.Parse(ProductId), int.Parse(UnitId)).ToString());
                    decimal CurrentQty = decimal.Parse(sTOCKTableAdapter.StockCheckQtyByProductId(long.Parse(UnitId), long.Parse(ProductId), long.Parse(StoreId)).ToString());
                    StatusLblQty.Text = decimal.Round(CurrentQty, 3).ToString();
                    ThQtyLabel.Text = GetTHRESHOLDQty.ToString();


                    Boolean ret;
                    //ret = CheckQty(ProductId, StoreId, UnitId, strQty);
                    //if (!ret)
                    //{
                    //    QtyFlag = true;
                    //    this.ProductsDGView["Qty", e.RowIndex].Value = DBNull.Value;
                    //    QtyFlag = false;
                    //}

                    //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices,long.Parse (UnitId), long.Parse (ProductId));
                    //int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString())
                    productUnitsPricesBindingSource.Filter = "productid=" + ProductId + " And UintId=" + UnitId;
                    if (productUnitsPricesBindingSource.Count > 0)
                    {
                        string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                        string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                        string AvgBuyPrice = ((DataRowView)productUnitsPricesBindingSource.Current)["AvgCostPrice"].ToString();
                        //ProductsDGView.BeginEdit(false);
                        if (PRODUCTBRAND != "")
                        {

                            //((DataRowView)invProductsBindingSource.Current)["PRODUCTBRAND"] = PRODUCTBRAND;
                            ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                        }
                        ProductsDGView.EndEdit();
                        if (SalePrice != "" && ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value != DBNull.Value)
                        {
                            // ((DataRowView)invProductsBindingSource.Current)["Price"] = SalePrice;
                            if (decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value.ToString()) == 0)
                            {
                                ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = 0; //SalePrice;
                            }
                            else
                            {
                                //((DataRowView)invProductsBindingSource.Current)["Price"] = SalePrice;
                            }
                        }
                        if (AvgBuyPrice != "" && ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value != DBNull.Value)
                        {
                            if (decimal.Parse(ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value.ToString()) == 0)
                            {
                                ProductsDGView.Rows[e.RowIndex].Cells["ItemNo"].Value = 0; //SalePrice;
                            }
                            else
                            {
                                //((DataRowView)invProductsBindingSource.Current)["Price"] = SalePrice;
                            }
                        }

                        ProductsDGView.EndEdit();
                        if (((DataRowView)productUnitsPricesBindingSource.Current)["SalePrice"] != DBNull.Value)
                        {
                            decimal MinPrice = decimal.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["SalePrice"].ToString());
                            StatusLblMinPrice.Text = MinPrice.ToString();
                        }
                        else
                        {
                            StatusLblMinPrice.Text = "0";
                        }
                        if (((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"] != DBNull.Value)
                        {
                            decimal MaxPrice = decimal.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString());

                            StatusLblMaxPrice.Text = MaxPrice.ToString();
                        }
                        else
                        {
                            StatusLblMaxPrice.Text = "0";
                        }
                    }
                }

                    //OldProductId = ProductsDGView["CmbPRODUCTID", e.RowIndex].Value;
                }
            }
            productUnitsPricesBindingSource.RemoveFilter();

        }

        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            //{
            //    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            //}

        }

        private void CmbBillType_SelectionChangeCommitted(object sender, EventArgs e)
        {

            SelchangeInVType();
        }
        private void SelchangeInVType()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            {
                txtInvPayment.Enabled = false;
                CmbPaymentAccid.Enabled = false;

                chkBoxCheque.Checked = false;
                chkBoxCheque.Enabled = false;
                txtKeyNetValue.Enabled = false;
                cmbPayMethode.Enabled = false;

                txtInvPayment.Text = "0";
                txtInvPay.Text = "0";
                txtInvPayment.Text = "0";
                txtRemain.Text = "0";
                sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID>1";

                //CmbCustSupAccid.DataBindings.Clear();
                //this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
                //this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                //this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                //this.CmbCustSupAccid.ValueMember = "accountid";
                //this.Validate();

                //this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                //CmbCustSupAccid.SelectedValue = -1;
                CmbPaymentAccid.SelectedValue = -1;

               

                //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;
            }
            else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //«Ã·
            {
                txtInvPayment.Enabled = false;
                CmbPaymentAccid.Enabled = false;

                chkBoxCheque.Checked = false;
                chkBoxCheque.Enabled = false;
                txtKeyNetValue.Enabled = false;
                cmbPayMethode.Enabled = false;

                txtInvPayment.Text = "0";
                txtInvPay.Text = "0";
                txtRemain.Text = "0";
                sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID>1";

                //CmbCustSupAccid.DataBindings.Clear();
                //this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
                //this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                //this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                //this.CmbCustSupAccid.ValueMember = "accountid";
                //this.Validate();

                //this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                //CmbCustSupAccid.SelectedValue = -1;

             
                //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;
            }
            else //‰ﬁœ«
            {

                txtInvPayment.Enabled = true;
                CmbPaymentAccid.Enabled = true;
               
                chkBoxCheque.Enabled = true;
                txtKeyNetValue.Enabled = false;
                cmbPayMethode.Enabled = false;

                sUPPLIERSCUSTOMERSBindingSource.Filter = "";

                CmbCustSupAccid.DataBindings.Clear();
                this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
                this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                this.CmbCustSupAccid.ValueMember = "accountid";


                //this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));
                //txtInvPayment.Text = "";
                //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();

                //CmbCustSupAccid.SelectedValue = -1;
                if (CmbPaymentAccid.Items.Count > 0)
                {
                    CmbPaymentAccid.SelectedValue = Messages.boxAccid;
                    CmbPaymentAccid.Select();
                }

            }
            //if (CmbCustSupAccid.Items.Count > 0)
            //{
            //    if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            //    {
            //        CmbCustSupAccid.SelectedIndex = 0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
            //    }
            //    //SelectedIndex = 0;
            //    CmbCustSupAccid.Select();
             
            //}
            //if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            //{
            //    CmbCustSupAccid.SelectedIndex =0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
            //    CmbCustSupAccid.Select();
            //}
            //getSaleAdmin();
        }
        private void CmbBillType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbBillType.SelectedValue != null)
            {
                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.salesAgalaccid + " or AccountparentId=" + Messages.salesAgalaccid;
                    if (accountingBindingSource1.Count > 0)
                    {
                        //((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();


                        //((DataRowView)invoicesBindingSource.Current)["PaymentAccid"] = DBNull.Value;
                        //((DataRowView)invoicesBindingSource.Current)["InvPayment"] = DBNull.Value;
                        CmbInvAccid.Select();
                        CmbInvAccid.Focus();
                        getSaleAdmin();
                    }
                }
                else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()) //‰ﬁœ«
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.salesaccid + " or AccountparentId=" + Messages.salesaccid;

                    if (accountingBindingSource1.Count > 0)
                    {
                        //((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                        CmbInvAccid.Select();
                        CmbInvAccid.Focus();
                        getSaleAdmin();
                    }
                }
                else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) // ﬁ”Ìÿ
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.SalesTakastaccid + " or AccountparentId=" + Messages.SalesTakastaccid;
                    if (accountingBindingSource1.Count > 0)
                    {

                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                        ((DataRowView)invoicesBindingSource.Current)["PaymentAccid"] = DBNull.Value;
                        ((DataRowView)invoicesBindingSource.Current)["InvPayment"] = DBNull.Value;
                    }
                }

            }
        }
        private Boolean ShowTasat()
        {
            Boolean bret = false;
            if (CmbCustSupAccid.SelectedValue != null)
            {
                InstallmentAdd frm = new InstallmentAdd();
                frm.CustName = CmbCustSupAccid.Text;
                frm.CustAccId = int.Parse(CmbCustSupAccid.SelectedValue.ToString());
                frm.CustId = int.Parse(txtSupCustId.Text);
                frm.InvId = int.Parse(((DataRowView)invoicesBindingSource.Current)["InvId"].ToString());
                frm.TotValue = decimal.Parse(txtInvTotalNet.Text);
                frm.EditFlag = EditFlag;
                DialogResult ret = frm.ShowDialog();
                if (DialogResult.OK == ret)
                {
                    bret = true;
                }
            }
            else
            {
                MessageBox.Show(Messages.CheckInvTaksatMsg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            return bret;
        }

        private void QidDetDGView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //äYìñÇ∑ÇÈóÒÇ©í≤Ç◊ÇÈ
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "CmbCostId")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

            }
        }

        private void QidDetDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void InvoiceAdd_Activated(object sender, EventArgs e)
        {
            if (Messages.ProductFlag == 1)
            {
                this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
                Messages.ProductFlag = 0;

            }
            if (Messages.StockFlag == 1)
            {
                long BranchId = 0;
                BranchId = long.Parse(Messages.CurBranch);
                this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS, BranchId);
                Messages.StockFlag = 0;
            }


        }

        private void AddNewProductMenuItem_Click(object sender, EventArgs e)
        {
            ProductsPop frm = new ProductsPop();

            frm.ShowDialog();
            if (frm.EditFlag)
            {
                long BranchId = 0;
                BranchId = long.Parse(Messages.CurBranch);
                this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS, BranchId);
                Messages.StockFlag = 0;
            }
        }

        private void CmbBranch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbBranch.SelectedValue != null)
            {
                long BranchId;
                if (Messages.Usertype == 2)
                {
                    BranchId = long.Parse(Messages.CurBranch);
                }
                else
                {
                    BranchId = long.Parse(CmbBranch.SelectedValue.ToString());
                }
                sTORESBindingSource.Filter = "BRANCHCODE=" + BranchId.ToString();
                this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS, BranchId);
            }
        }

        private void CmbCustSupAccid_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void chkInvPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInvPay.Checked)
            {
                txtReferID.Text = "1";
            }
            else
            {
                txtReferID.Text = "0";
            }
        }

        private void txtReferID_TextChanged(object sender, EventArgs e)
        {
            if (txtReferID.Text != "")
            {
                if (txtReferID.Text == "1")
                {
                    chkInvPay.Checked = true;
                }
                if (txtReferID.Text == "0")
                {
                    chkInvPay.Checked = false;
                }

            }


        }

        private void txtTel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCust();
            }
        }
        private void SearchCust()
        {
            int Cuspos = homeCustomerBindingSource.Find("CustTel", txtTel.Text);
            string Name = txtCustomerName.Text;
            string Tel = txtTel.Text;
            string Address = txtAddress.Text;
            if (Cuspos > -1)
            {
                homeCustomerBindingSource.Position = Cuspos;
                if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"] != DBNull.Value)
                {
                    txtCustomerName.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustName"].ToString();
                }
                if (((DataRowView)homeCustomerBindingSource[Cuspos])["Address"] != DBNull.Value)
                {
                    txtAddress.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Address"].ToString();
                }
                if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"] != DBNull.Value)
                {
                    txtTel.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["CustTel"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["block"] != DBNull.Value)
                {
                    txtblock.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["block"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["street"] != DBNull.Value)
                {
                    txtStreet.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["street"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"] != DBNull.Value)
                {
                    txtGada.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Gada"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"] != DBNull.Value)
                {
                    txtBuliding.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Buliding"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["House"] != DBNull.Value)
                {
                    txtHouse.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["House"].ToString();
                }


                if (((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"] != DBNull.Value)
                {
                    txtFloor.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Floor"].ToString();
                }

                if (((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"] != DBNull.Value)
                {
                    txtNotes.Text = ((DataRowView)homeCustomerBindingSource[Cuspos])["Notes"].ToString();
                }
                if (((DataRowView)homeCustomerBindingSource[Cuspos])["CustId"] != DBNull.Value)
                {
                    long CustomerId = long.Parse(((DataRowView)homeCustomerBindingSource[Cuspos])["CustId"].ToString());
                    GetCustomerInv(CustomerId);
                }

            }
            else
            {
                MessageBox.Show("·«ÌÊÃœ ⁄„Ì· »Â–« «·»Ì«‰", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
        private void GetCustomerInv(long CustomerId)
        {

            this.invoicesTableAdapter.FillByCustomerId(this.nEWERPDataSet.invoices, CustomerId);



            if (invoicesBindingSource.Count > 0)
            {
                if (GLibrary.MsgCheckSave(false))
                {
                    SaveAll(false);
                }
                else
                {

                    invoicesBindingSource.CancelEdit();
                    invProductsBindingSource.CancelEdit();
                    qidsBindingSource.CancelEdit();
                    qidsDetailsBindingSource.CancelEdit();
                    qidsDetailsBindingSourceWith.CancelEdit();
                }
                //invoicesBindingSource.Position = pos;
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                //invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                qidsTableAdapter.FillByInvId(nEWERPDataSet.qids, InvId);
                qidsBindingSource.Filter = "InvId = " + InvId.ToString();
                //GetCustomerData();    
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
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
                    CmdAdd.Enabled = true;
                    CmdDel.Enabled = true;
                    EditFlag = true;
                }

            }


        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchCust();
        }
        private void printInv(int choice)
        {
            if (EditFlag)
            {
                ShowProductsRpt frm = new ShowProductsRpt();
                this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
                frm.nEWERPDataSet = nEWERPDataSet;
                frm.choiceNum = choice;
             

                if (GLibrary.IsNumeric(txtInvPay.Text))
                {
                    frm.InvPayment = decimal.Parse(txtInvPay.Text);
                }
                else
                {
                    frm.InvPayment = 0;
                }

                if (GLibrary.IsNumeric(txtRemain.Text))
                {
                    frm.InvRemain = decimal.Parse(txtRemain.Text);
                }
                else
                {
                    frm.InvRemain = 0;
                }
                if (CmbCostCenters.SelectedValue != null)
                {
                    frm.CustBranch = CmbCostCenters.Text;
                }
                //frm.InvType = "Sales Invoice";
                frm.InvTitle = "„— Ã⁄ „»Ì⁄« ";
                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    frm.InvType = "«Ã·";
                    frm.CustName = CmbCustSupAccid.Text;
                }
                else
                {
                    frm.CustName = txtCustomerName.Text;
                    if (chkBoxCheque.Checked)
                    {
                        frm.InvType = "KeyNet";
                    }
                    else
                    {
                        frm.InvType = "ﬂ«‘";
                    }
                }


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

                if (txtDiscount.Text != "")
                {
                    frm.Discount = decimal.Parse(txtinvTotal.Text) - decimal.Parse(txtInvTotalNet.Text); // decimal.Parse(txtDiscount.Text);
                    frm.strDiscount = GLibrary.FigureInWordsNumType(double.Parse(txtDiscount.Text), 1);
                }
                else
                {
                    frm.Discount = 0;
                    frm.strDiscount = "";
                }

                if (txtTel.Text != "")
                {
                    frm.Tel = txtTel.Text;
                }
                if (txtCustomerName.Text != "")
                {
                    frm.CustHomeName = txtCustomerName.Text;
                }

                if (txtAddress.Text != "")
                {
                    frm.Address = txtAddress.Text;
                }

                if (txtblock.Text != "")
                {
                    frm.block = txtblock.Text;
                }
                if (txtStreet.Text != "")
                {
                    frm.street = txtStreet.Text;
                }

                if (txtGada.Text != "")
                {
                    frm.Gada = txtGada.Text;
                }
                if (txtHouse.Text != "")
                {
                    frm.House = txtHouse.Text;
                }

                if (txtBuliding.Text != "")
                {
                    frm.Buliding = txtBuliding.Text;
                }
                if (txtFloor.Text != "")
                {
                    frm.Floor = txtFloor.Text;
                }

                if (txtFlat.Text != "")
                {
                    frm.Flat = txtFlat.Text;
                }
                if (DistPerrdBtn.Checked)
                {
                    frm.Percentage = txtDiscount.Text + " %";
                }
                ////if (txtCustNote.Text != "")
                //{
                //    frm.Notes = txtCustNote.Text;
                //}

                frm.InvDate = dtInvDate.Value;
                DialogResult ret;
                if (ShowPrintDlg)
                {
                    ret = MessageBox.Show(Messages.ShowInvMesg, "«·⁄„·«¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                {
                    ret = DialogResult.No;
                }
                if (ret == DialogResult.Yes)
                {
                    frm.PrintFlag = false;
                    frm.ShowDialog(this);
                }
                else
                {
                    frm.PrintFlag = true;
                    frm.ShowReport();
                }
            }
            else
            {
                MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
        private void BtnSmall_Click(object sender, EventArgs e)
        {
            ShowPrintDlg = true;
            if (!EditFlag)
            {
                SaveAll(false);
            }
            SetPermission();
            PrintFlag = true;
            printInv(333);
            AddNewInv();
            ClearCust();
        }

        private void BtnHomeInvPrint_Click(object sender, EventArgs e)
        {
            ShowPrintDlg = true;
            SaveAll(false);
            SetPermission();
            PrintFlag = true;
            printInv(334);
            AddNewInv();
            ClearCust();
        }

        private void txtCustAcc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int pos = accountingBindingSourceCust.Find("AccountCode", txtCustAcc.Text);
                if (pos > -1)
                {
                    long Curaccountid = long.Parse(((DataRowView)accountingBindingSourceCust[pos])["accountid"].ToString());
                    int sel = int.Parse(CmbBillType.SelectedValue.ToString());
                    if (sel == 1)
                    {

                        int CurPos = int.Parse(sUPPLIERSCUSTOMERSBindingSource.Find("accountid", Curaccountid).ToString());
                        if (CurPos > -1)
                        {
                            sUPPLIERSCUSTOMERSBindingSource.Position = CurPos;
                            CmbCustSupAccid.SelectedValue = Curaccountid;
                        }
                    }

                }
            }
        }
        private void BtnPrintTotal()
        {
            Nullable<long> BranchId = null;
            Nullable<int> CustSupId = null;
            Nullable<int> ProductId = null;
            Nullable<int> StoreId = null;
            Nullable<int> inType = null;
            Nullable<int> BillTypeId = null;

            BranchId = null;
            StoreId = null;
            CustSupId = null;
            ProductId = null;
            inType = null;
            BillTypeId = null;


            ShowNewRpt frm = new ShowNewRpt();


            frm.FromDate = DateTime.Parse(DateTime.Today.ToShortDateString());

            frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");



            frm.choiceNum = 66;

            invoiceViewTableAdapter.FillByParam(nEWERPDataSet.InvoiceView, BranchId, CustSupId, frm.FromDate, frm.ToDate, inType, BillTypeId, null);

            frm.nEWERPDataSet = nEWERPDataSet;

            frm.ShowDialog(this);
            // }
        }

        private void InvoiceAdd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                PrintFlag = true;
                SaveAll(false);
                SetPermission();
            }
            if (e.KeyCode == Keys.F10)
            {
                ShowPrintDlg = false;
                SaveAll(false);
                SetPermission();
                PrintFlag = true;
                printInv(333);
                AddNewInv();
                ClearCust();
            }
            if (e.KeyCode == Keys.F8)
            {
                if (Messages.Usertype == Messages.AdminUser)
                {
                    Cashbox();
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                BtnPrintTotal();
            }
            if (e.KeyCode == Keys.F1)
            {
                deleteItem();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearCust();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowPrintDlg = true;
            SaveAll(false);
            SetPermission();
            PrintFlag = true;
            printInv(330);
            AddNewInv();
            ClearCust();
        }

        private void btnHomeNew_Click(object sender, EventArgs e)
        {
            ShowPrintDlg = true;
            SaveAll(false);
            SetPermission();
            PrintFlag = true;
            printInv(3301);
            AddNewInv();
            ClearCust();
        }

       
        


    }

}