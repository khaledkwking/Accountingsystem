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
    public partial class InvoicePurchaseAdd : DockContent
    {
        public int InvType;
        public int LastIden = -1;
        public int QidLastIden = -1;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
        private StaticList slBillType;// = new StaticList(GLibrary.strarrBillType);
        public Boolean  EditFlag=false  ;
        private DateTime lastDataError = DateTime.MinValue;
        private Boolean Nflag = true;
        private NEWERPDataSet nTempEWERPDataSet = new NEWERPDataSet();
        public int ReorderFlag = 0;
        public long InvId;
        long FirstCode = 0;
        public InvoicePurchaseAdd()
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
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            if (Messages.CurLang == Messages.ArabLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillType);

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                slBillType = new StaticList(GLibrary.strarrBillTypeEng);
            }
            CmbBillType.DataSource = slBillType.ToDataTable();
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

            //switch (InvType)
            //{
            //    case 1:
            //        this.Text = "›« Ê—… „‘ —Ì« ";
            //        labelCustSup.Text = "√”„ «·„Ê—œ";

            //        break;
            //    case 2:

            //        this.Text = "›« Ê—… „»Ì⁄« ";
            //        labelCustSup.Text = "√”„ «·⁄„Ì·";
            //        break;
            //}
            txtInvType.Text = InvType.ToString();

            this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.

            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);

            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SUPPLIERS_CUSTOMERS' table. You can move, or remove it, as needed.

           
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            //this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS);
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

            //this.invoicesTableAdapter.Fill(this.nEWERPDataSet.invoices);
            if (Messages.Usertype == 2)
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString() + " And BranchId=" + Messages.CurBranch.ToString();
                CmbBranches.Enabled = false;
                CmbStores.Enabled = false;

            }
            else
            {
                invoicesBindingSource.Filter = "InvType=" + InvType.ToString();
                CmbStores.Enabled = true;
            }
         
           
           // this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
           // this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.
                      

         
         
            accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + "or AccountparentId=" + Messages.boxAccid;
            accountingBindingSource1.Filter = "accountid=" + Messages.purchaseaccid + " or AccountparentId=" + Messages.purchaseaccid;

            pRODUCTSBindingSource.Filter = "MainNode=false";
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            pRODUCTSBindingSource.Sort = "productname";
            accountingBindingSource.Sort = "accountname";
            sUPPLIERSCUSTOMERSBindingSource.Sort = "SUP_CUST_FNAME";
            accountingBindingSourceQid.Sort = "accountname";
            costCentersBindingSource1.Filter = "MainNode=" + Boolean.FalseString;

            long BranchId = 0;
            BranchId = long.Parse(Messages.CurBranch);
            sTORESBindingSource.Filter = "BRANCHCODE=" + BranchId.ToString();
                     
            if (!EditFlag)
            {
                AddNewInv();

            }
            else
            {
                this.invoicesTableAdapter.FillByInvId (this.nEWERPDataSet.invoices, InvId);
                //int pos = invoicesBindingSource.Find("InvCode", txtInvCode.Text);

                int pos = invoicesBindingSource.Find("InvId", InvId);
                if (pos > -1)
                {
                    invoicesBindingSource.Position = pos;
                }

            }
            if (invoicesBindingSource.Count > 0)
            {
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];
                this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, InvId);
                if (GLibrary.IsNumeric(txtRate.Text))
                {
                    double Result =  double.Parse(txtInvTotalNet.Text)/double.Parse(txtRate.Text);
                    txtdollar.Text=Math.Round(Result, 3).ToString();
                }
            }
            Nflag = true;
            SetPermission();
            Messages.StockFlag = 0;
            Messages.ProductFlag = 0;
        }


        private Boolean ValidateControl()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //√Ã·
            {
                if (CmbCustSupAccid.SelectedValue == null)
                {
                    MessageBox.Show(Messages.EnterCustomerMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    CmbCustSupAccid.Focus();
                    return false;

                }

            }
            if (CmbInvAccid.SelectedValue == null)
            {
                MessageBox.Show(Messages.EnterAccountMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                CmbInvAccid.Focus();
                return false;
            }
            return true;

        }
        private Boolean CheckCode(string InvCode, int InvType)
        {
            int Count = 0;
            long BranchId = 0;
            if (CmbBranches.SelectedValue != null)
            {
                BranchId = long.Parse(CmbBranches.SelectedValue.ToString());
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
            return true;

        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveAll();
            SetPermission();   
        }
        private Boolean SaveChild()
        {

            //this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.invoicesRow master = (NEWERPDataSet.invoicesRow)(((DataRowView)invoicesBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.Inv_ProductsRow detail = (NEWERPDataSet.Inv_ProductsRow)(((DataRowView)invProductsBindingSource.Current).Row);

            if (((DataRowView)invProductsBindingSource.Current)["ProductId"] == DBNull.Value || ((DataRowView)invProductsBindingSource.Current)["Qty"] == DBNull.Value || ((DataRowView)invProductsBindingSource.Current)["Price"] == DBNull.Value)
            {
                return false;
            }
            NEWERPDataSet.qidsRow Qiddetail = (NEWERPDataSet.qidsRow)(((DataRowView)qidsBindingSource.Current).Row);

            // Save the master row
            invoicesBindingSource.EndEdit();
            invoicesTableAdapter.Update(master);
            //invoicesTableAdapter.Update(nEWERPDataSet.invoices);
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
            qidsBindingSource.Filter = "InvId =" + master.InvId.ToString();

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private void SaveAll()
        {
            if (this.ValidateChildren())
            {
                if (ValidateControl())
                {
                    Nflag = false;
                    if (GLibrary.MsgCheckSave(false))
                    {

                        if (invProductsBindingSource.Count > 0)// && !ProductsDGView.IsCurrentRowDirty && !dGViewQidWith.IsCurrentRowDirty)
                        {
                            try
                            {
                                if (!EditFlag)
                                {
                                    InvSetSerial();
                                }
                                if (GLibrary.IsNumeric(txtInvCode.Text))
                                {

                                    if (CheckCode(txtInvCode.Text, InvType))
                                    {
                                        GetQid();
                                        if (CmbBillType.SelectedValue == GLibrary.strarrBillType[0, 0].ToString()) // «Ã·
                                        {
                                            if (txtInvPayment.Text == "" || txtInvPayment.Text == "0")
                                            {
                                                txtPayFinish.Text = Boolean.FalseString;
                                            }

                                        }
                                        else
                                        {
                                            txtPayFinish.Text = Boolean.TrueString;
                                        }
                                        txtUserId.Text = Messages.CurUserId;
                                        //this.Validate();

                                        recoderCodeTextBox.Text = "O" + txtInvCode.Text;
                                        if (GLibrary.IsNumeric (txtRate.Text))
                                        {
                                            double Result=  double.Parse(txtInvTotalNet.Text)/double.Parse(txtRate.Text);
                                            txtdollar.Text=Math.Round(Result,3).ToString();
                                        }
                                        if (!SaveChild())
                                        {
                                            MessageBox.Show("«œŒ· «Œ— ’‰› »ÿ—Ìﬁ… ’ÕÌÕÂ «Ê  Õ—ﬂ «·Ï «·’‰ﬁ «·”«»ﬁ À„ «÷⁄Ÿ Õ›Ÿ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                            return;
                                        }
                                        int ret = 0;
                                        if (!EditFlag)
                                        {
                                           
                                            //int Pos = 0;
                                            //if (CmbBranches.SelectedValue != null)
                                            //{
                                            //    Pos = int.Parse(CmbBranches.SelectedIndex.ToString());
                                            //}
                                            //else
                                            //{


                                            //}
                                            //bRANCHESTableAdapter.Fill (nEWERPDataSet.BRANCHES);
                                            //switch (InvType)
                                            //{
                                            //    case Messages.InvpurchasesFlag:
                                                    
                                            //        ((DataRowView)bRANCHESBindingSource[Pos])["PurchInvSerial"] = txtInvCode.Text;
                                                    
                                            //        // nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"] = txtInvCode.Text;
                                            //        //nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"] = txtInvCode.Text;

                                            //        break;
                                            //    case Messages.InvSalesFlag:
                                            //        ((DataRowView)bRANCHESBindingSource[Pos])["SalInvSerial"] = txtInvCode.Text;
                                                   
                                            //        //nEWERPDataSet.BRANCHES.Rows[Pos]["SalInvSerial"] = txtInvCode.Text;
                                            //        //nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"] = txtInvCode.Text;
                                            //        break;
                                            //}
                                            //this.Validate();
                                            //bRANCHESBindingSource.EndEdit();
                                            //ret=bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);
                                            //setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                        }
                                        //if (!EditFlag)
                                        //{
                                        //    switch (InvType)
                                        //    {
                                        //        case Messages.InvpurchasesFlag:
                                        //            nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"] = txtInvCode.Text;

                                        //            break;
                                        //        case Messages.InvSalesFlag:
                                        //            nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"] = txtInvCode.Text;
                                        //            break;
                                        //    }
                                        //    setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                        //}

                                       
                                        GLibrary.MsgSave();
                                        CmdAdd.Enabled = true;
                                        CmdDel.Enabled = true;
                                        BtnPrint.Enabled = true ;
                                        EditFlag = true;
                                        if (((DataRowView)invoicesBindingSource.Current)["BranchId"] != DBNull.Value)
                                        {
                                            CmbBranches.SelectedValue = ((DataRowView)invoicesBindingSource.Current)["BranchId"].ToString();
                                        }
                                        if (Messages.CurLang == Messages.ArabLang)
                                        {
                                            CmdSave.Text = " ⁄œÌ·";

                                        }
                                        else if (Messages.CurLang == Messages.EngLang)
                                        {
                                            CmdSave.Text = "ÚıEdit";
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
                                MessageBox.Show(GLibrary.ExceptionToMessage(ex,ref ErrorNo), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                    }
                    Nflag = true;
                }
            }
            else
            {
                MessageBox.Show(Messages.InvaildDataInvMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

            }

        }
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
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewInv();
                      
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
                    this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, -1);
                    //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                    CmdDel.Enabled = false;
                    CmdSave.Enabled = false;
                    BtnPrint.Enabled = false;
                    InvtabControl.SelectedIndex = 0;
                    InvtabControl.Select();

                    //if (invoicesBindingSource.Count == 0)
                    //{
                    //    this.inv_ProductsTableAdapter.FillByInvId(this.nEWERPDataSet.Inv_Products, -1);
                    //    //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
                    //    //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);
                    //    //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
                    //    CmdDel.Enabled = false;
                    //    CmdSave.Enabled = false;
                    //    InvtabControl.SelectedIndex = 0;
                    //    InvtabControl.Select();

                    //}
                   
                }
                
            
             }
            
        }

    
        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //int iStoreId = -1;
                //string strStoreName = "";
                //string strStoreCode="";
                //DisplayStores(ref strStoreName, ref iStoreId, ref strStoreCode);
                //txtStoreName.Text = strStoreName;
                //txtStoreCode.Text = strStoreCode;
                //txtStoreId.Text = iStoreId.ToString();
               
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
        private void StoresDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    int iProductId = -1;
            //    string strProductName = "";
            //    string strProductCode = "";
            //    DisplayProducts(ref strProductName, ref iProductId, ref strProductCode);

            //    ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = strProductCode;
            //    ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = strProductName;
            //    ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = iProductId.ToString();
            //}
        }
           
    

        private void invoicesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (invoicesBindingSource.Count > 0)
            {
                //if (invoicesBindingSource.Count == 1 )//&& ((DataRowView)invoicesBindingSource.Current)["InvId"].ToString() == "0")
                if (invoicesBindingSource.Count >0 && ((DataRowView)invoicesBindingSource.Current).IsNew)
                {
                    ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

                }
                //if (invoicesBindingSource.Count > 0  && ((DataRowView)invoicesBindingSource.Current).IsNew) //==1
                //{
                //    ((DataRowView)invoicesBindingSource.Current)["InvId"] = (Int64)(LastIden + 1);

                //}
                Int64 InvId = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];

               // invProductsBindingSource.Filter = "InvId = " + InvId.ToString();
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
                ((DataRowView)invProductsBindingSource.Current)["InvType"] = InvType.ToString();
                ((DataRowView)invProductsBindingSource.Current)["InvId"] = (Int64)((DataRowView)invoicesBindingSource.Current)["InvId"];


            }

        }
        
        private void AddNewInv()
        {

            LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            invoicesBindingSource.AddNew();
            txtReoderFlag.Text = ReorderFlag.ToString ();
            txtRate.Text =Messages.ExchangeRate.ToString();
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }
            chkBoxCheque.Checked = false;
            txtchequeFlag.Text = Boolean.FalseString;
            CmbBillType.SelectedIndex = 0;
            CmbBillType.Select();
            //if (CmbBranches.Items.Count > 0)
            //{
            //    CmbBranches.SelectedIndex = 0;
            //    CmbBranches.Select();
            //}
            if (CmbPaymentAccid.Items.Count > 0)
            {
                CmbPaymentAccid.SelectedValue = Messages.boxAccid;
                CmbPaymentAccid.Select();
            }
            accountingBindingSource1.Filter = "accountid=" + Messages.purchaseAgalaccid + " or AccountparentId=" + Messages.purchaseAgalaccid;
            if (CmbInvAccid.Items.Count > 0)
            {
                CmbInvAccid.SelectedIndex  = 0 ;
                CmbInvAccid.Select();
            }
           
            txtinvTotal.Text = "0";
            txtInvType.Text = InvType.ToString();

            sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID>1";
            sUPPLIERSCUSTOMERSBindingSource.Sort = "SUP_CUST_ID";

            //int Pos = 0;
            //if (CmbBranches.SelectedValue != null)
            //{
            //    Pos = int.Parse(CmbBranches.SelectedIndex.ToString());
            //}
            //else
            //{
            //    Pos = bRANCHESBindingSource.Find("BRANCHCODE", Messages.CurBranch);
            //}

            if (Messages.CurBranch != "")
            {
                CmbBranches.SelectedValue = Messages.CurBranch;
            }

            UpdateInvCode();
            //int Pos = 0;
            //if (CmbBranches.SelectedValue != null)
            //{
            //    Pos = int.Parse(CmbBranches.SelectedIndex.ToString());
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

                   
            //        break;
            //}
            //switch (InvType)
            //{
            //    case Messages.InvpurchasesFlag:
            //        string PurSerial = nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"].ToString();
            //        txtInvCode.Text = (int.Parse(PurSerial) + 1).ToString();

            //        //txtInvCode.Text = Messages.SysInvpurchasesCode + (LastIden+1).ToString();

            //        break;
            //    case Messages.InvSalesFlag:
            //        string SalSerial = nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"].ToString();
            //        txtInvCode.Text = (int.Parse(SalSerial) + 1).ToString();

            //        //txtInvCode.Text = Messages.SysinvSaleCode + (LastIden+1).ToString();

            //        break;
            //}
            //if (CmbCustSupAccid.Items.Count > 0)
            //{
            //    if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            //    {
            //        //CmbCustSupAccid.SelectedIndex = 0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
            //        sUPPLIERSCUSTOMERSBindingSource.Position = 0;
            //        CmbCustSupAccid.SelectedValue = ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
            //    }
            //    //SelectedIndex = 0;
            //    //CmbCustSupAccid.Select();
            //}
            if (Messages.CurBranch != "")
            {
                CmbBranches.SelectedValue = Messages.CurBranch;
            }
            //GetCustId();
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            BtnPrint.Enabled = false;
            EditFlag = false;
           

        }
        private void UpdateInvCode()
        {
            long QidSeial = 0;
            long MaxSerial = (long)invoicesTableAdapter.InvoicesSelectMaxSerial(InvType);
            QidSeial = MaxSerial + 1;
            txtInvCode.Text = QidSeial.ToString(); //DateTime.Parse(txtQidDate.Text).Year.ToString () +DateTime.Parse(txtQidDate.Text).Month .ToString ()+ QidSeial.ToString();
            FirstCode = QidSeial;
            txtQidSerial.Text = QidSeial.ToString();


           
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
 
            if (CmbBillType.SelectedValue.ToString () == GLibrary.strarrBillType[0, 0].ToString())
            {
                AccountIdFrom  = int.Parse(CmbCustSupAccid.SelectedValue.ToString()); //   „Ê«—œ œ«∆‰ √Ã·
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
                ((DataRowView)qidsBindingSource.Current)["BrachId"] = CmbBranches.SelectedValue;
                ((DataRowView)qidsBindingSource.Current)["EmpId"] = Messages.CurUserId ;
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
                else if (txtInvPayment.Text ==  "" && pos != -1 )
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


                pos = qidsDetailsBindingSource.Find("ActionType",3);
                
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
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
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
                ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = RemainValue ;
                //((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = "500";
                ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)AccountIdFrom;
                ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString(); //DateTime.Today;
                ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
                }
                //((DataRowView)qidsDetailsBindingSource.Current)["Description"] ="›« Ê—…";
                ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 5;
                if (CmbCostCenters.SelectedValue != null)
                {
                    ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                }
                //((DataRowView)qidsDetailsBindingSource[0])["QidType"] = GLibrary.strarrQidTypes[3, 1];
                ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();


                if (Messages.CostSalesProductAccId > 0 && Messages.StockAccId > 0)
                {
                    // «·„‘ —Ì«  --------------------------------- œ«∆‰
                    pos = qidsDetailsBindingSource.Find("ActionType", 6);  // «·„‘ —Ì« 
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
                    ((DataRowView)qidsDetailsBindingSource.Current)["FromValue"] = NetValue;
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)(Int64)AccountIdTo;
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—… «·„Œ“Ê‰ «·”·⁄Ï «·„‘ —Ì« ";
                    }
                    //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 6;
                    if (CmbCostCenters.SelectedValue != null)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();

                    // --------------------------------------------- ‰Â«Ì… «·„‘ —Ì«  -------------------------------


                    // «·„Œ“‰ «·”·⁄Ì - ---------------------------------„œÌ‰
                    pos = qidsDetailsBindingSource.Find("ActionType", 7);  //  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â
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
                    ((DataRowView)qidsDetailsBindingSource.Current)["ToValue"] = NetValue;
                    ((DataRowView)qidsDetailsBindingSource.Current)["ACCOUNTID"] = (Int64)Messages.StockAccId;
                    ((DataRowView)qidsDetailsBindingSource.Current)["EnterDate"] = dtInvDate.Value.ToShortDateString();// DateTime.Today;
                    ((DataRowView)qidsDetailsBindingSource.Current)["QidType"] = GLibrary.strarrQidTypes[3, 0];
                    if (((DataRowView)qidsDetailsBindingSource.Current)["Description"] == DBNull.Value)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—… «·„Œ“Ê‰ «·”·⁄Ï";
                    }
                    //((DataRowView)qidsDetailsBindingSource.Current)["Description"] = "›« Ê—…";
                    ((DataRowView)qidsDetailsBindingSource.Current)["ActionType"] = 7;
                    if (CmbCostCenters.SelectedValue != null)
                    {
                        ((DataRowView)qidsDetailsBindingSource.Current)["CostId"] = costId;
                    }
                    ((DataRowView)qidsDetailsBindingSource.Current).EndEdit();
                }
                // ---------------------------------------------  ﬂ·›… «·»÷«⁄Â «·„»«⁄Â -------------------------------
                qidsDetailsBindingSource.Sort = "ActionType";
            }
    
        
        private void InvtabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (InvtabControl.SelectedIndex)
            {
                case 0:

                    break;
                case 1:
                    if (invProductsBindingSource.Count > 0 && txtinvTotal.Text != "0")
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
                    if (invProductsBindingSource.Count > 0 && txtinvTotal.Text != "0")
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
                if (e.ColumnIndex == PriceVal.Index || e.ColumnIndex == Qty.Index || e.ColumnIndex==Discount.Index)
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
                    if (this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != null)
                    {
                        string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                        string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                        string strQty = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    }
                    //CheckQty(ProductId, StoreId, strQty);
                }
                //if (e.ColumnIndex == PriceVal.Index )
                //{
                //    string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                  
                //    //CheckQty(ProductId, StoreId, strQty);
                //}
            }
        }
      
        private void GetPriceSum()
        {
            txtinvTotal.Text="0";

            for (int i = 0; i < invProductsBindingSource.Count; i++)
            {
                if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString()) && GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString()))
                {
                    ProductsDGView.Rows[i].Cells["TotalPrice"].Value = (decimal.Parse(ProductsDGView.Rows[i].Cells["Qty"].Value.ToString()) * decimal.Parse(ProductsDGView.Rows[i].Cells["PriceVal"].Value.ToString())) - decimal.Parse(ProductsDGView.Rows[i].Cells["Discount"].Value.ToString());

                    if (GLibrary.IsNumeric(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString ()))
                    {
                        txtinvTotal.Text = (decimal.Parse(txtinvTotal.Text) + decimal.Parse(ProductsDGView.Rows[i].Cells["TotalPrice"].Value.ToString())).ToString();
                    }
                }
            }
            SetDiscount();
        }

        private void ProductsDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            ProductsDGView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void ProductsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            if (ProductsDGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

            TimeSpan sinceLast = DateTime.Now - lastDataError;
            lastDataError = DateTime.Now;
            string message;
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
            //e.Row.Cells["CmbStoreId"].Value = "1";

            e.Row.Cells["Discount"].Value = "0";
            e.Row.Cells["ReoderFlag"].Value = Boolean .FalseString ;
            e.Row.Cells["Qty"].Value = "1"; 
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
                    //this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    this.cDE_UNIT_TYPESTableAdapter.Fill(this.nTempEWERPDataSet.CDE_UNIT_TYPES);
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
            //if (e.ColumnIndex == this.CmbUnitId.Index)
            //{
            //    // Reset combobox cell to the unfiltered BindingSource
            //    DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
            //    this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);

               
            //    // dgcb.DataSource = productUnitsPricesBindingSource; //unfiltered
            //    //this.productUnitsPricesBindingSource.RemoveFilter();
            //}
          
        }

        private void qidsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (qidsBindingSource.Count > 0)
            {

                if (qidsBindingSource.Count > 0 && ((DataRowView)qidsBindingSource.Current).IsNew ) //["qidid"].ToString() == "0")
                {

                    ((DataRowView)qidsBindingSource.Current)["qidid"] = (Int64)(QidLastIden + 1);
                }
                Int64 qidid = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];

                qidsDetailsBindingSource.Filter = "qidid =" + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[3, 0].ToString()+ " or QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();;
                qidsDetailsBindingSourceWith.Filter = "qidid =" + qidid.ToString() + " and QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();
            }
            else
            {
                qidsDetailsBindingSource.Filter = "qidid =-1" ;
                qidsDetailsBindingSourceWith.Filter = "qidid =-1";
            }
        }

        private void dGViewQidWith_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["QidTypeWith"].Value = GLibrary.strarrQidTypes[4, 0];
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
        
            //if (!GLibrary.IsNumeric(txtDiscount.Text))
            //{
            //    //GLibrary.ValidatetxtBox(errorProvider1, txtDiscount, "√œŒ· «·Œ’„ »ÿ—Ìﬁ… ’ÕÌÕ…", "«·Œ’„", true);
            //}
            //else
            //{
            //    txtInvTotalNet.Text = (decimal.Parse(txtinvTotal.Text) * (1 - (decimal.Parse(txtDiscount.Text) / 100))).ToString();
            //}
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
                txtChequeNo.Enabled = true;
                accountingBindingSource.Filter = "accountid=" + Messages.bankaccid + " or AccountparentId=" + Messages.bankaccid;
                chkBoxCheque.Text = Boolean.TrueString;
                //CmbPaymentAccid.Enabled = true ;

            }
            else
            {
                txtChequeNo.Enabled = false;
                txtChequeNo.Text = "";
                accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.boxAccid;
                chkBoxCheque.Text = Boolean.FalseString ;

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

        private void txtInvCode_KeyUp(object sender, KeyEventArgs e)
        {

            
            if (e.KeyCode == Keys.Enter)
            {
                this.invoicesTableAdapter.FillByCode (this.nEWERPDataSet.invoices , txtInvCode.Text);
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
                    qidsTableAdapter.FillByInvId(nEWERPDataSet.qids, InvId);
                    qidsBindingSource.Filter = "InvId = " + InvId.ToString();
                    CmdAdd.Enabled = true;
                    CmdDel.Enabled = true;
                    BtnPrint.Enabled = true ;
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
                        BtnPrint.Enabled = true;
                        EditFlag = true;
                    }
                }

            }
            else
            {

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
                if (dgv.CurrentCell.OwningColumn.Name == "CmbPRODUCTID" || dgv.CurrentCell.OwningColumn.Name == "BarCode" || dgv.CurrentCell.OwningColumn.Name == "ProductCode")
                {
                    //ï“èWÇÃÇΩÇﬂÇ…ï\é¶Ç≥ÇÍÇƒÇ¢ÇÈÉRÉìÉgÉçÅ[ÉãÇéÊìæ
                    DataGridViewComboBoxEditingControl cb = (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cb.AutoCompleteSource = AutoCompleteSource.ListItems;
                }

            }
        }
        private void ProductsDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            DataGridViewComboBoxCell dgcbProduct = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
            DataGridViewComboBoxCell dgcbProductCode = (DataGridViewComboBoxCell)ProductsDGView["ProductCode", e.RowIndex];
            

            if (dgv.Columns[e.ColumnIndex].Name == "CmbPRODUCTID" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn) // ⁄„Êœ «·’‰›
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];
                productUnitsPricesBindingSource.RemoveFilter();
                
                //int pos = pRODUCTSBindingSource.Find("productname", e.FormattedValue);
                int pos = pRODUCTSBindingSource.Find("EnglishName", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());
                    if (dgcbProduct.Value.ToString() != ProductId.ToString())
                    {
                        dgcbProduct.Value = ProductId.ToString();
                        dgcbProductCode.Value = ProductId.ToString();

                        // dgcbBarCode.Value = ProductId.ToString(); //
                        //this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
                        this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));                  
                        if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                        {
                            DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                            dgcbUnit.Value = nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                            productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                            if (productUnitsPricesBindingSource.Count > 0)
                            {
                                string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                                ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;

                            }
                        }
                    }
                }
                else
                {
                    DialogResult ret = MessageBox.Show(Messages.CheckProdcutAddMsg, "«·«’‰«›", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    if (ret == DialogResult.Yes)
                    {
                        AddNewProduct();
                    }
                }
            }
            // Barcode
            if (dgv.Columns[e.ColumnIndex].Name == "BarCode" )
            {
                productUnitsPricesBindingSource.RemoveFilter();
                int pos = productUnitsPricesBindingSource.Find("PRODUCTBRAND", e.FormattedValue);
                if (pos > -1)
                {
                    productUnitsPricesBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString());            
                    
                    int pos1 = pRODUCTSBindingSource.Find("PRODUCTID", ProductId);
                    pRODUCTSBindingSource.Position = pos1;
                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();

                    //this.cDE_UNIT_TYPESTableAdapter.Fill (this.nEWERPDataSet.CDE_UNIT_TYPES);
                    //if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    //{
                    //    DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                    //    dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                    //}
                    int CurUintId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["UintId"].ToString());
                    DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                    dgcbUnit.Value = CurUintId;
                   
                }
                else
                {
                    //MessageBox.Show(Messages.CheckProdcutCodeMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                }
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

                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();
                    //dgcbBarCode.Value = ProductId.ToString(); 
                    if (dgcbProductCode.Value.ToString() == ProductId.ToString())
                    {
                        this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nTempEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));                  
                        //this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
                        if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                        {
                            DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                            dgcbUnit.Value = nTempEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                            productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                            if (productUnitsPricesBindingSource.Count > 0)
                            {
                                string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                                ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;

                            }
                            //productUnitsPricesBindingSource.RemoveFilter();
                        }
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
                        }
                        else
                        {
                            MessageBox.Show("Â–Â «·ÊÕœ… €Ì— „ÕœœÂ ·Â–« «·’‰›", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }

                }
            }
            if (ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != DBNull.Value)
            {
                string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();

                long StockQty = 0;
                bool t = long.TryParse(sTOCKTableAdapter.GetQuntityValue(long.Parse(ProductId), long.Parse(StoreId)).ToString(), out StockQty);
                StatusLblQty.Text = StockQty.ToString();
                productUnitsPricesBindingSource.Filter = "productid=" + ProductId + " And UintId=" + UnitId;
                if (productUnitsPricesBindingSource.Count > 0)
                {
                    string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                    //ProductsDGView.BeginEdit(false);
                    if (PRODUCTBRAND != "")
                    {
                        //((DataRowView)invProductsBindingSource.Current)["PRODUCTBRAND"] = PRODUCTBRAND;
                        ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                    }
                }
                //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices,long.Parse (UnitId), long.Parse (ProductId));
                //int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString())
            }    
           
        }

        private void dGViewQidWith_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
            e.Cancel = true;
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            if (dGViewQidWith.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

            TimeSpan sinceLast = DateTime.Now - lastDataError;
            lastDataError = DateTime.Now;
            string message;
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
        private void GetSum()
        {
            DataView list = (DataView)qidsDetailsBindingSourceWith.List;
            DataTable T = list.ToTable();
            decimal Fromvalue = 0;
            decimal Tovalue = 0;
            decimal Credit = 0;
            for (int i = 0; i < T.Rows.Count; i++)
            {

                if (GLibrary.IsNumeric(T.Rows[i]["FromValue"].ToString()))
                {
                    Fromvalue = Fromvalue + decimal.Parse(T.Rows[i]["FromValue"].ToString());
                }
                if (GLibrary.IsNumeric(T.Rows[i]["ToValue"].ToString()))
                {
                    Tovalue = Tovalue + decimal.Parse(T.Rows[i]["ToValue"].ToString());
                }

            }
            txtTotalToValue.Text = Tovalue.ToString();
            txtTotalFromValue.Text = Fromvalue.ToString();
            Credit = (decimal.Parse(txtTotalToValue.Text) - decimal.Parse(txtTotalFromValue.Text));
            if (Credit < 0)
            {
                Credit = (Credit * -1);
            }
            txttotalAdd.Text = Credit.ToString();
        }

        private void dGViewQidWith_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (dGViewQidWith.Rows.Count > 0)
            //{
            //    if (dGViewQidWith.Rows[e.RowIndex].Cells["AccountNameWith"].Value != DBNull.Value && dGViewQidWith.Rows[e.RowIndex].Cells["AccountNameWith"].Value != null)
            //    {
            //        GetSum();
            //    }
            //}
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                ShowProductsRpt frm = new ShowProductsRpt();
                this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
                frm.nEWERPDataSet = nEWERPDataSet;
                frm.choiceNum = 3;
                frm.CustName = CmbCustSupAccid.Text;
                frm.InvType = this.Text;
                frm.InvTitle = this.Text;

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
                if (DistPerrdBtn.Checked)
                {
                    frm.Percentage = txtDiscount.Text + " %";
                }
                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    frm.InvType = "«Ã·";
                }
                else
                {
                    if (chkBoxCheque.Checked)
                    {
                        frm.InvType = "KeyNet";
                    }
                    else
                    {
                        frm.InvType = "ﬂ«‘";
                    }
                }
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
        private void CheckCancel()
        {
            //if (GLibrary.MsgCheckSave(false))
            //{
            //    SaveAll();

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
                    BtnPrint.Enabled = true;
                    EditFlag = true;
                }
                if (Messages.CurLang == Messages.ArabLang)
                {
                    CmdSave.Text = " ⁄œÌ·";

                }
                else if (Messages.CurLang == Messages.EngLang)
                {
                    CmdSave.Text = "ÚıEdit";
                }
                //CmdSave.Text = " ⁄œÌ·";

           // }
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
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            CheckCancel();
        }

  
        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ProductsDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex+1).ToString();
        }

        private void dGViewQidWith_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dGViewQidWith.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void QidDetDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //QidDetDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

        private void CmbCustSupAccid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //SelchangeInVType();
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

                //if (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"] != DBNull.Value)
                //{
                //    int EmpCode = (int)((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"];

                //    pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, EmpCode, null, null, null, null);
                //    if (personalDataSet.PER_EMPLOYEE_DATA.Rows.Count > 0)
                //    {
                //        txtSaleAdmin.Text = personalDataSet.PER_EMPLOYEE_DATA.Rows[0]["EMPNAME"].ToString();
                //    }


                //}
            }
        }
        private void SelchangeInVType()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //«Ã·
            {
                txtInvPayment.Enabled = true;
                CmbPaymentAccid.Enabled = true;
                CmbCustSupAccid.DataBindings.Clear();
                this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
                this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                this.CmbCustSupAccid.ValueMember = "accountid";
                this.Validate();

                sUPPLIERSCUSTOMERSBindingSource.Filter = "SUP_CUST_ID>1";

                //this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag ));

                //CmbCustSupAccid.SelectedValue = -1;
                //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;
            }
            else //‰ﬁœ«
            {

                txtInvPayment.Enabled = false;
                CmbPaymentAccid.Enabled = false;
                sUPPLIERSCUSTOMERSBindingSource.Filter = "";

                CmbCustSupAccid.DataBindings.Clear();
                this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
                this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                this.CmbCustSupAccid.ValueMember = "accountid";


                //this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));
                txtInvPayment.Text = "";
                //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();
                //CmbCustSupAccid.SelectedValue = -1;

            }

            //if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            //{
            //    CmbCustSupAccid.SelectedIndex =0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
            //    CmbCustSupAccid.Select();
            //}
            GetCustId();
        }
        private void CmbCustSupAccid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MakeBillType();
        }
        private void GetCustId()
        {
            if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
            {
                //txtSupCustId.Text = ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SUP_CUST_ID"].ToString();

                int pos = sUPPLIERSCUSTOMERSBindingSource.Find("accountid", CmbCustSupAccid.SelectedValue);
                if (pos > -1)
                {
                    System.Data.DataView list = new System.Data.DataView();
                    list = (DataView)sUPPLIERSCUSTOMERSBindingSource.List;
                    DataTable T = list.ToTable();
                    txtSupCustId.Text = T.Rows[pos]["SUP_CUST_ID"].ToString();

                }
            }

            
        }
        //private void SelchangeInVType()
        //{
        //    if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //«Ã·
        //    {
        //        txtInvPayment.Enabled = true;
        //        CmbPaymentAccid.Enabled = true;
        //        CmbCustSupAccid.DataBindings.Clear();
        //        this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
        //        this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
        //        this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
        //        this.CmbCustSupAccid.ValueMember = "accountid";
        //        this.Validate();

        //        this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

        //        CmbCustSupAccid.SelectedValue = -1;
        //        //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;
        //    }
        //    else //‰ﬁœ«
        //    {

        //        txtInvPayment.Enabled = false;
        //        CmbPaymentAccid.Enabled = false;
        //        CmbCustSupAccid.DataBindings.Clear();
        //        this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
        //        this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
        //        this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
        //        this.CmbCustSupAccid.ValueMember = "accountid";


        //        this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));
        //        txtInvPayment.Text = "";
        //        //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();
        //        CmbCustSupAccid.SelectedValue = -1;

        //    }

        //    //if (sUPPLIERSCUSTOMERSBindingSource.Count > 0)
        //    //{
        //    //    CmbCustSupAccid.SelectedIndex =0; // ((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["accountid"].ToString();
        //    //    CmbCustSupAccid.Select();
        //    //}
        //    //getSaleAdmin();
        //}
        private void CmbBillType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelchangeInVType();
            //if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //{
            //    txtInvPayment.Enabled = true;
            //    CmbPaymentAccid.Enabled = true;
            //    CmbCustSupAccid.DataBindings.Clear();
            //    this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
            //    this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            //    this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            //    this.CmbCustSupAccid.ValueMember = "accountid";
            //    this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));
            //    CmbCustSupAccid.SelectedValue = -1;

            //}
            //else //‰ﬁœ«
            //{
            //    txtInvPayment.Enabled = false;
            //    CmbPaymentAccid.Enabled = false;
            //    CmbCustSupAccid.DataBindings.Clear();
            //    this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
            //    this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            //    this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            //    this.CmbCustSupAccid.ValueMember = "accountid";
            //    this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

            //    txtInvPayment.Text = "";
            //    CmbCustSupAccid.SelectedValue = -1;
            //}

            //GetCustId();
            
        }
        private void MakeBillType()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            {
                accountingBindingSource1.Filter = "accountid=" + Messages.purchaseAgalaccid + " or AccountparentId=" + Messages.purchaseAgalaccid; //salesAgalaccid;
                if (accountingBindingSource1.Count > 0)
                {

                    CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                    ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                    //CmbInvAccid.Select();
                    //CmbInvAccid.Focus();
                    this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

                }
            }
            else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()) //‰ﬁœ«
            {
                accountingBindingSource1.Filter = "accountid=" + Messages.purchaseaccid + " or AccountparentId=" + Messages.purchaseaccid; //.salesaccid;
                if (accountingBindingSource1.Count > 0)
                {
                    CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                    ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                }
                this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));//.CustFlag));
            }

            else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) // ﬁ”Ìÿ
            {
                accountingBindingSource1.Filter = "accountid=" + Messages.purchaseaccid + " or AccountparentId=" + Messages.purchaseaccid; //.salesaccid;
                if (accountingBindingSource1.Count > 0)
                {

                    CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                    ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                }
            }
        }
        private void CmbBillType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbBillType.SelectedValue != null)
            {
                if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.purchaseAgalaccid + " or AccountparentId=" + Messages.purchaseAgalaccid;
                    if (accountingBindingSource1.Count > 0)
                    {
                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                        //CmbInvAccid.Select();
                        //CmbInvAccid.Focus();
                    }
                }
                else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[1, 0].ToString()) //‰ﬁœ«
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.purchaseaccid + " or AccountparentId=" + Messages.purchaseaccid;

                    if (accountingBindingSource1.Count > 0)
                    {
                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                    }
                }
                else if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) // ﬁ”Ìÿ
                {
                    accountingBindingSource1.Filter = "accountid=" + Messages.purchaseAgalaccid + " or AccountparentId=" + Messages.purchaseAgalaccid;
                    if (accountingBindingSource1.Count > 0)
                    {

                        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
                        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
                    }
                }
            }
            //if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //{

            //    txtInvPayment.Enabled = true;
            //    CmbPaymentAccid.Enabled = true;
            //    CmbCustSupAccid.DataBindings.Clear();
            //    this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
            //    this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            //    this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            //    this.CmbCustSupAccid.ValueMember = "accountid";
            //    this.Validate();

            //    this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));

            //    CmbCustSupAccid.SelectedValue = -1;
            //    CmbCustSupAccid.Enabled = true;
            //    //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;

            //}
            //else //‰ﬁœ«
            //{

            //    txtInvPayment.Enabled = false;
            //    CmbPaymentAccid.Enabled = false;
            //    CmbCustSupAccid.DataBindings.Clear();
            //    this.CmbCustSupAccid.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoicesBindingSource, "Cust_Sup_Accid", true));
            //    this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
            //    this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
            //    this.CmbCustSupAccid.ValueMember = "accountid";


            //    this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.SupFlag));
            //    txtInvPayment.Text = "";
            //    //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();

            //    CmbCustSupAccid.SelectedIndex = 0;
            //    ((DataRowView)invoicesBindingSource.Current)["Cust_Sup_Accid"] = Messages.custaccid; //CustAccId;
            //    //CmbCustSupAccid.Enabled = false;

            //    //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();
            //    // CmbCustSupAccid.SelectedValue = -1;

            //}
            //GetCustId();
            
            //if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //{
            //    accountingBindingSource1.Filter = "accountid=" + Messages.purchaseAgalaccid + " or AccountparentId=" + Messages.purchaseAgalaccid;
            //    if (accountingBindingSource1.Count > 0)
            //    {
            //        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
            //        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
            //    }
            //}
            //else
            //{
            //    accountingBindingSource1.Filter = "accountid=" + Messages.purchaseaccid + " or AccountparentId=" + Messages.purchaseaccid;
            //    if (accountingBindingSource1.Count > 0)
            //    {
            //        CmbInvAccid.SelectedValue = ((DataRowView)accountingBindingSource1.Current)["accountid"].ToString();
            //        ((DataRowView)invoicesBindingSource.Current)["InvAccid"] = ((DataRowView)accountingBindingSource1.Current)["accountid"];
            //    }
            //}
        }
        private void SetPermission()
        {
            if (!Messages.PurInvPrim[1] && EditFlag)
            {
                ProductsDGView.Enabled = false;
                CmdSave.Enabled = false;
            }
            if (!Messages.PurInvPrim[2] && EditFlag)
            {
                //ProductsDGView.Enabled = false;
                CmdDel.Enabled = false;
            }
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

        private void InvoicePurchaseAdd_Activated(object sender, EventArgs e)
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
            AddNewProduct();
        }
        private void AddNewProduct()
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

        private void QidDetDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
       

      

    }
 
}