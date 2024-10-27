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
namespace ERPSYS
{
    public partial class OrderAddOld : Form
    {
        public int InvType;
        public int LastIden = -1;
        public int QidLastIden = -1;
        private StaticList slGetTypes = new StaticList(GLibrary.strarrGetTypes);
        private StaticList slBillType = new StaticList(GLibrary.strarrBillType);
        public Boolean  EditFlag=false  ;
        private DateTime lastDataError = DateTime.MinValue;
        private Boolean flag = false;
        private Boolean Nflag = true;
        private string OldProductId="0";
        public long OrderId;
        public OrderAddOld()
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
            oRDERDETAILSBindingSource.CancelEdit();
            oRDERSBindingSource.CancelEdit();
           



            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERDETAILS' table. You can move, or remove it, as needed.
            this.oRDERDETAILSTableAdapter.Fill(this.nEWERPDataSet.ORDERDETAILS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERS' table. You can move, or remove it, as needed.
            this.oRDERSTableAdapter.Fill(this.nEWERPDataSet.ORDERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvOrders_Products' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.
            this.uSER_FUNCTIONTableAdapter.Fill(this.nEWERPDataSet.USER_FUNCTION);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
         
        
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            ProductsDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
           

            foreach (DataGridViewRow row in ProductsDGView.Rows)
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


            this.oRDERSTableAdapter.Fill(this.nEWERPDataSet.ORDERS  );
            if (Messages.Usertype == 2)
            {
                oRDERSBindingSource.Filter = "InvType=" + InvType.ToString() + " And BranchId=" + Messages.CurBranch.ToString ();
                CmbBranch.Enabled = false;
                CmbStores.Enabled = false ;
            }
            else
            {
                oRDERSBindingSource.Filter = "InvType=" + InvType.ToString();
                CmbStores.Enabled = true;
            }


            if (oRDERSBindingSource.Count > 0)
            {
                Int64 OrderId = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderId"];
                this.oRDERDETAILSTableAdapter.FillByOrderId(this.nEWERPDataSet.ORDERDETAILS, OrderId);
                //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.

            
            //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);


         
         
            accountingBindingSource.Filter = "accountid=" + Messages.boxAccid + " or AccountparentId=" + Messages.boxAccid; 
            accountingBindingSource1.Filter = "accountid=" + Messages.salesaccid + " or AccountparentId=" + Messages.salesaccid;
            pRODUCTSBindingSource.Filter = "root=false";
            costCentersBindingSource.Filter = "MainNode=" + Boolean.FalseString;
            pRODUCTSBindingSource.Sort = "productname";
            accountingBindingSource.Sort = "accountname";
            sUPPLIERSCUSTOMERSBindingSource.Sort = "CREDITLIMIT DESC ,SUP_CUST_FNAME";
           
            //accountingBindingSourceQid.Filter = "Mainnode=" + Boolean.FalseString;

            //qidsDetailsBindingSource.Filter =  "QidType=" + GLibrary.strarrQidTypes[2, 0].ToString();
            //qidsDetailsBindingSourceWith.Filter = "QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();
            //if (CmbBranch.SelectedValue != null)
            //{
                long BranchId = 0;
                BranchId = long.Parse (Messages.CurBranch);
                sTORESBindingSource.Filter = "BRANCHCODE=" + BranchId.ToString();
                this.pRODUCTSTableAdapter.FillByStock(this.nEWERPDataSet.PRODUCTS, BranchId);

            //}

                if (!EditFlag)
                {
                    AddNewInv();

                }
                else
                {
                    int pos = oRDERSBindingSource.Find("OrderId", OrderId);
                    if (pos > -1)
                    {
                        oRDERSBindingSource.Position = pos;
                    }

                }
           
          

            //LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            flag = true;
           
            Nflag = true;
            ProductsDGView.Focus();

            SetPermission();
        }

        private void SetPermission()
        {
            if (!Messages.SalInvPrim[1] && EditFlag)
            {
                ProductsDGView.Enabled = false;
                CmdSave.Enabled = false;
            }
            if (!Messages.SalInvPrim[2] && EditFlag)
            {
                //ProductsDGView.Enabled = false;
                CmdDel.Enabled = false;
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveAll(false);
            SetPermission();
        }
        private Boolean  ValidateControl()
        {
            //if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //{
                if (CmbCustSupAccid.SelectedValue == null || CmbCustSupAccid.Text == "")
                {
                    MessageBox.Show(Messages.EnterCustomerMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    CmbCustSupAccid.Focus();
                    return false;

                }

           // }
            //else //‰ﬁœ«
            //{
            //    if (CmbCustSupAccid.Text  == "")
            //    {
            //        MessageBox.Show(Messages.EnterCustomerMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //        CmbCustSupAccid.Focus();
            //        return false;
            //    }
            //}
            //if (CmbInvAccid.SelectedValue == null)
            //{
            //    MessageBox.Show(Messages.EnterAccountMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            //    CmbInvAccid.Focus();
            //    return false;
            //}
            return true;
            
        }
        private Boolean SaveChild()
        {

            //this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.ORDERSRow master = (NEWERPDataSet.ORDERSRow)(((DataRowView)oRDERSBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.ORDERDETAILSRow detail = (NEWERPDataSet.ORDERDETAILSRow)(((DataRowView)oRDERDETAILSBindingSource.Current).Row);

           
            if (((DataRowView)oRDERDETAILSBindingSource.Current)["ProductId"] == DBNull.Value || ((DataRowView)oRDERDETAILSBindingSource.Current)["Qty"] == DBNull.Value || ((DataRowView)oRDERDETAILSBindingSource.Current)["Price"] == DBNull.Value)
            {
                return false;
            }
            // Save the master row
            oRDERSBindingSource.EndEdit();
            oRDERSTableAdapter.Update(master);
            //invoicesTableAdapter.Update(nEWERPDataSet.invoices );
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row

            if (detail.OrderId != master.OrderId)
            {
                for (int i = 0; i < oRDERDETAILSBindingSource.Count; i++)
                {
                    ((DataRowView)oRDERDETAILSBindingSource[i])["OrderId"] = master.OrderId;
                }
            }

            
            //detail.qidid  = master.qidid;
            // Save the child row
            oRDERDETAILSBindingSource.EndEdit();
            oRDERDETAILSTableAdapter.Update(nEWERPDataSet.ORDERDETAILS );

            

          

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private void SaveAll(Boolean bflag)
        {
            
            if (this.ValidateChildren())
            {
                if (ValidateControl())
                {
                    Nflag = false;
                    if (GLibrary.MsgCheckSave(bflag))
                    {
                        if (oRDERDETAILSBindingSource.Count > 0)// && !ProductsDGView.IsCurrentRowDirty && !dGViewQidWith.IsCurrentRowDirty)
                        {
                            try
                            {
                                if (GLibrary.IsNumeric(txtInvCode.Text))
                                {
                                    if (CheckCode(txtInvCode.Text, InvType))
                                    {
                                        
                                        //if (CmbBillType.SelectedValue.ToString () == GLibrary.strarrBillType[0, 0].ToString()) // «Ã·
                                        //{
                                        //    if (txtInvPayment.Text == "" || txtInvPayment.Text == "0")
                                        //    {
                                        //        txtPayFinish.Text = Boolean.FalseString;
                                        //    }
                                        //    else if (GLibrary.IsNumeric(txtInvPayment.Text))
                                        //    {
                                        //        if (decimal.Parse(txtInvPayment.Text) < decimal.Parse(txtInvTotalNet.Text))
                                        //        {
                                        //            txtPayFinish.Text = Boolean.FalseString;
                                        //        }
                                        //        else
                                        //        {
                                        //            txtPayFinish.Text = Boolean.TrueString ;
                                        //        }
                                        //    }

                                        //}
                                        //else
                                        //{
                                        //    txtPayFinish.Text = Boolean.TrueString;
                                        //}
                                        txtUserId.Text = Messages.CurUserId;
                                        //this.Validate();

                                     
                                        //oRDERSBindingSource.EndEdit();
                                        //oRDERDETAILSBindingSource.EndEdit();
                                       
                                        //invoicesTableAdapter.Update(nEWERPDataSet.invoices);
                                        if (!SaveChild())
                                        {
                                            MessageBox.Show("«œŒ· «Œ— ’‰› »ÿ—Ìﬁ… ’ÕÌÕÂ «Ê  Õ—ﬂ «·Ï «·’‰ﬁ «·”«»ﬁ À„ «÷⁄Ÿ Õ›Ÿ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                            return;
                                        }
                                        int ret = 0;
                                        if (!EditFlag)
                                        {
                                            int Pos = 0;
                                            if (CmbBranch.SelectedValue != null)
                                            {
                                                Pos = int.Parse(CmbBranch.SelectedIndex.ToString());
                                            }
                                            else
                                            {
                                                
                                                
                                            }
                                            bRANCHESTableAdapter.Fill(nEWERPDataSet.BRANCHES);
                                            switch (InvType)
                                            {
                                                case Messages.InvpurchasesFlag:
                                                     ((DataRowView)bRANCHESBindingSource[Pos])["PurchInvSerial"]= txtInvCode.Text;
                                                    
                                                   // nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"] = txtInvCode.Text;
                                                    //nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"] = txtInvCode.Text;

                                                    break;
                                                case Messages.InvSalesFlag:
                                                    ((DataRowView)bRANCHESBindingSource[Pos])["OrderSerial"] = txtInvCode.Text;
                                                    //nEWERPDataSet.BRANCHES.Rows[Pos]["SalInvSerial"] = txtInvCode.Text;
                                                    //nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"] = txtInvCode.Text;
                                                    break;
                                            }
                                            //this.Validate();
                                            bRANCHESBindingSource.EndEdit();
                                            ret=bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);
                                            //setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                        }
                                        
                                        //oRDERDETAILSBindingSource.EndEdit();
                                       // inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products);
                                        //GetQid();

                                        //qidsBindingSource.EndEdit();
                                        //qidsTableAdapter.Update(nEWERPDataSet.qids);
                                        //qidsDetailsBindingSource.EndEdit();
                                        //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);

                                        //qidsDetailsBindingSourceWith.EndEdit();
                                        // qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
                                        GLibrary.MsgSave();
                                        CmdAdd.Enabled = true;
                                        CmdDel.Enabled = true;
                                        EditFlag = true;
                                        if (((DataRowView)oRDERSBindingSource.Current)["BranchId"] != DBNull.Value)
                                        {
                                            CmbBranch.SelectedValue = ((DataRowView)oRDERSBindingSource.Current)["BranchId"].ToString();
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
                                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                if (ErrorNo == 547)
                                {
                                    oRDERSBindingSource.RemoveCurrent();
                                    oRDERSBindingSource.EndEdit();
                                    oRDERSTableAdapter.Update(nEWERPDataSet.ORDERS  );
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
        private Boolean CheckCode(string InvCode, int InvType)
        {
            int Count = 0;
            long BranchId = 0;
            if (CmbBranch.SelectedValue != null)
            {
                BranchId = long.Parse(CmbBranch.SelectedValue.ToString ());
            }
            else
            {
                BranchId=long.Parse(Messages.CurBranch);
            }
            Count = int.Parse(oRDERSTableAdapter.CheckInvOrdersCode(InvCode, InvType, BranchId).ToString());
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

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewInv();
                      
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            
            if (GLibrary.MsgCheckDel())
            {
                 //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                //oRDERSBindingSource.ResetAllowNew();//.CancelEdit();
                oRDERSBindingSource.RemoveCurrent();
                //oRDERSBindingSource.EndEdit ();
                //((DataRowView)oRDERSBindingSource.Current).EndEdit();
                int i = oRDERSTableAdapter.Update(nEWERPDataSet.ORDERS);
                if (oRDERSBindingSource.Count == 0)
                {
                    this.oRDERDETAILSTableAdapter.Fill(this.nEWERPDataSet.ORDERDETAILS );
                   
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
                this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, ProductID);
            }
        }
                  
        private void GetOrderAdd_Activated(object sender, EventArgs e)
        {
           
        }

     
     

        private void oRDERSBindingSource_PositionChanged(object sender, EventArgs e)
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
            if (oRDERSBindingSource.Count > 0)
            {
                // if (oRDERSBindingSource.Count == 1 && ((DataRowView)oRDERSBindingSource.Current)["OrderId"].ToString() == "0")
                if (oRDERSBindingSource.Count > 0 &&  ((DataRowView)oRDERSBindingSource.Current).IsNew)
                {
                    ((DataRowView)oRDERSBindingSource.Current)["OrderId"] = (Int64)(LastIden + 1);

                }
                //if (oRDERSBindingSource.Count > 0 && ((DataRowView)oRDERSBindingSource.Current).IsNew)
                //{
                //    ((DataRowView)oRDERSBindingSource.Current)["OrderId"] = (Int64)(LastIden + 1);

                //}
                Int64 OrderId = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderId"];

                //oRDERDETAILSBindingSource.Filter = "OrderId = " + OrderId.ToString();
                this.oRDERDETAILSTableAdapter.FillByOrderId(this.nEWERPDataSet.ORDERDETAILS, OrderId);
          

            }
        }

        private void oRDERDETAILSBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (oRDERSBindingSource.Count > 0 && oRDERDETAILSBindingSource.Count > 0)
            {

                ((DataRowView)oRDERDETAILSBindingSource.Current)["OrderId"] = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderId"];
                if (((DataRowView)oRDERDETAILSBindingSource.Current)["PRODUCTID"] != DBNull.Value && ((DataRowView)oRDERDETAILSBindingSource.Current)["UnitId"] != DBNull.Value)
                {
                    string ProductId = ((DataRowView)oRDERDETAILSBindingSource.Current)["PRODUCTID"].ToString();
                    string UnitId = ((DataRowView)oRDERDETAILSBindingSource.Current)["UnitId"].ToString();
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices, );
                }
            }

        }
        

        private void AddNewInv()
        {
            LastIden = int.Parse(oRDERSTableAdapter.GetLastIdentity().ToString());
            oRDERSBindingSource.AddNew();
          
            //chkBoxCheque.Checked = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "ÚSave";
            }
            
          
            
            if (CmbBranch.Items.Count > 0)
            {
                CmbBranch.SelectedIndex = 0;
                CmbBranch.Select();
            }
            
           
            //if (CmbPaymentAccid.Items.Count > 0)
            //{
            //    CmbPaymentAccid.SelectedValue = Messages.boxAccid;
            //    CmbPaymentAccid.Select();
            //}
            //if (CmbInvAccid.Items.Count > 0)
            //{
            //    CmbInvAccid.SelectedValue = Messages.salesaccid;
            //    CmbInvAccid.Select();
            //}
           
         
            txtInvType.Text = InvType.ToString();
          
            if (Messages.CurBranch != "")
            {
                CmbBranch.SelectedValue = Messages.CurBranch;
            }
           

            int Pos = 0;
            if (CmbBranch.SelectedValue != null)
            {
                Pos = int.Parse(CmbBranch.SelectedIndex.ToString());
            }
            else
            {
                Pos = bRANCHESBindingSource.Find("BRANCHCODE", Messages.CurBranch);
            }

            switch (InvType)
            {
                case Messages.InvpurchasesFlag:
                    string PurSerial ="0";
                    if (nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"] != DBNull.Value)
                    {
                        PurSerial = nEWERPDataSet.BRANCHES.Rows[Pos]["PurchInvSerial"].ToString();
                    }//nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"].ToString();
                    txtInvCode.Text = (int.Parse(PurSerial) + 1).ToString();

                    //txtInvCode.Text = Messages.SysInvpurchasesCode + (LastIden+1).ToString();

                    break;
                case Messages.InvSalesFlag:
                    string SalSerial="0";
                    if (nEWERPDataSet.BRANCHES.Rows[Pos]["OrderSerial"] != DBNull.Value)
                    {
                        SalSerial = nEWERPDataSet.BRANCHES.Rows[Pos]["OrderSerial"].ToString();//nEWERPDataSet.SetupCodes.Rows[0]["SalInvSerial"].ToString();
                    }
                    
                    txtInvCode.Text = (int.Parse(SalSerial) + 1).ToString();

                    //txtInvCode.Text = Messages.SysinvSaleCode + (LastIden+1).ToString();

                    break;
            }
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



        }
      
    
      

        private void ProductsDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDGView.Rows.Count > 0)
            {
                
                if (e.ColumnIndex == Qty.Index)
                {
                    if (this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value !=null  && ProductsDGView["CmbStoreId", e.RowIndex].Value!=null && ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null  )
                    {
                        string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                        string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                        string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();
                        string strQty=ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        
                        CheckQty(ProductId, StoreId,UnitId , strQty);
                    }
                }
                if (e.ColumnIndex == PriceVal.Index)
                {
                    //string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                    //string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                    string strPrice = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    CheckPrice(strPrice);
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
        private void CheckQty(string ProductId,string StoreId,string UnitId,string Qty)
        {
            if (ProductId != "" && StoreId != "")
            {
                decimal StockQty = decimal.Parse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), long.Parse(UnitId), int.Parse(StoreId)).ToString());
                if (Qty != "")
                {
                    if (decimal.Parse(Qty) > StockQty)
                    {
                        MessageBox.Show(Messages.StockQtyMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
            if (null == e.Exception)

                message = "Bad value.";

            else
            {
                message = e.Exception.Message;
                if (e.Exception is System.Reflection.TargetInvocationException)
                    if (e.Exception.InnerException is FormatException)
                        message = "Bad value format. Check the type of value entered.";
            }

            ProductsDGView.Rows[e.RowIndex].ErrorText = message;

            //if (sinceLast.TotalSeconds < 1.0)

                //MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

           // else

               // SystemSounds.Beep.Play();
        }

        private void ProductsDGView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
             if(sTORESBindingSource.Count >0)
             {
                 e.Row.Cells["CmbStoreId"].Value = ((DataRowView)sTORESBindingSource.Current)["STOREID"].ToString();
             }
             else
             {
                  e.Row.Cells["CmbStoreId"].Value="1";
             }
                      
            e.Row.Cells["Qty"].Value = "1"; 
            
        }


        private void txtInvCode_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
               int pos= oRDERSBindingSource.Find("OrderCode", txtInvCode.Text);

               if (pos != -1)
               {
                   if (GLibrary.MsgCheckSave(false))
                   {
                       SaveAll(false);
                   }
                   else
                   {

                       oRDERSBindingSource.CancelEdit();
                       oRDERDETAILSBindingSource.CancelEdit();
                      
                   }
                   oRDERSBindingSource.Position = pos;
                   Int64 OrderId = (Int64)((DataRowView)oRDERSBindingSource.Current)["OrderId"];
                   //oRDERDETAILSBindingSource.Filter = "OrderId = " + OrderId.ToString();
                   this.oRDERDETAILSTableAdapter.FillByOrderId(this.nEWERPDataSet.ORDERDETAILS, OrderId);
                 
                  
                   CmdAdd.Enabled = true;
                   CmdDel.Enabled = true;
                   EditFlag = true;
               }
               else
               {
                   MessageBox.Show(Messages.InvNotfoundMesg, "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                   oRDERSBindingSource.CancelEdit();
                   oRDERDETAILSBindingSource.CancelEdit();
                  
                   if (!EditFlag)
                   {
                        CmdAdd.Enabled = true;
                        CmdDel.Enabled = true;
                        EditFlag = true;
                   }
                   
               }

            }


        }

        private void MenuItemDelProduct_Click(object sender, EventArgs e)
        {
            if (oRDERDETAILSBindingSource.Count > 0)
            {
                oRDERDETAILSBindingSource.RemoveCurrent();
            }
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
                    cb.AutoCompleteMode = AutoCompleteMode.Suggest ;
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
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                    }


                }
              
            }
            

        }

        private void ProductsDGView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            //if (e.ColumnIndex == this.CmbUnitId.Index)
            //{
            //    // Reset combobox cell to the unfiltered BindingSource
            //    DataGridViewComboBoxCell dgcb = (DataGridViewComboBoxCell)ProductsDGView["CmbPRODUCTID", e.RowIndex];
            //    this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);

            //}
          
           
        }
            

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                ShowProductsRpt frm = new ShowProductsRpt();
                this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
                frm.nEWERPDataSet = nEWERPDataSet;
                frm.choiceNum = 11;
                frm.CustName = CmbCustSupAccid.Text;
                frm.InvType = "Sales Order";

              
              
                frm.InvDate = dtInvDate.Value;
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            
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

                 if (((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"] != DBNull.Value )
                 {
                     Int64 EmpCode = (Int64)((DataRowView)sUPPLIERSCUSTOMERSBindingSource.Current)["SALEADMIN"];

                     pER_EMPLOYEE_DATATableAdapter.FillByEmpCode(personalDataSet.PER_EMPLOYEE_DATA, EmpCode);
                     if (personalDataSet.PER_EMPLOYEE_DATA.Rows.Count > 0)
                     {
                         txtSaleAdmin.Text = personalDataSet.PER_EMPLOYEE_DATA.Rows[0]["EMPNAME"].ToString();
                     }


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
            //        oRDERSBindingSource.CancelEdit();
            //        oRDERDETAILSBindingSource.CancelEdit();
            //        qidsBindingSource.CancelEdit();
            //        qidsDetailsBindingSource.CancelEdit();
            //        qidsDetailsBindingSourceWith.CancelEdit();

            //    }

            //}
            //else
            //{
            //    oRDERSBindingSource.CancelEdit();
            //    oRDERDETAILSBindingSource.CancelEdit();
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




            if (GLibrary.MsgCheckSave(false))
            {
                SaveAll(true);

            }
            else
            {

                oRDERSBindingSource.CancelEdit();
                oRDERDETAILSBindingSource.CancelEdit();
               
                nEWERPDataSet.InvOrders.RejectChanges();
                nEWERPDataSet.InvOrders_Products.RejectChanges();
            

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

         
        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ProductsDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
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
                int pos = pRODUCTSBindingSource.Find("productname", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());
                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();

                    // dgcbBarCode.Value = ProductId.ToString(); //


                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();
                        productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                        if (productUnitsPricesBindingSource.Count > 0)
                        {
                            string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                            string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                            ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                            ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                        }
                        //productUnitsPricesBindingSource.RemoveFilter();
                    }
                    PriceVal.Selected = true;
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
            // Barcode
            if (dgv.Columns[e.ColumnIndex].Name == "BarCode")
            {

                productUnitsPricesBindingSource.RemoveFilter();
                int pos = productUnitsPricesBindingSource.Find("PRODUCTBRAND", e.FormattedValue);
                if (pos > -1)
                {
                    productUnitsPricesBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString());

                    string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                    ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;

                    //dgcbBarCode.Value = ProductId.ToString(); 
                    int pos1 = pRODUCTSBindingSource.Find("PRODUCTID", ProductId);
                    pRODUCTSBindingSource.Position = pos1;
                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();

                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                    }
                    PriceVal.Selected = true;
                }
                else
                {
                   // MessageBox.Show(Messages.CheckProdcutCodeMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                }
            }

            // ProductCode
            if (dgv.Columns[e.ColumnIndex].Name == "ProductCode" && dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn cbc = (DataGridViewComboBoxColumn)dgv.Columns[e.ColumnIndex];
                
                productUnitsPricesBindingSource.RemoveFilter();
                int pos = pRODUCTSBindingSource.Find("productCode", e.FormattedValue);
                if (pos > -1)
                {
                    pRODUCTSBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());

                    dgcbProduct.Value = ProductId.ToString();
                    dgcbProductCode.Value = ProductId.ToString();
                    //dgcbBarCode.Value = ProductId.ToString(); 

                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId.ToString()));
                    if (nEWERPDataSet.CDE_UNIT_TYPES.Rows.Count > 0)
                    {
                        DataGridViewComboBoxCell dgcbUnit = (DataGridViewComboBoxCell)ProductsDGView["CmbUnitId", e.RowIndex];
                        dgcbUnit.Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

                        productUnitsPricesBindingSource.Filter = "productid=" + dgcbProduct.Value + " And UintId=" + dgcbUnit.Value;
                        if (productUnitsPricesBindingSource.Count > 0)
                        {
                            string PRODUCTBRAND = ((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTBRAND"].ToString();
                            ProductsDGView.Rows[e.RowIndex].Cells["BarCode"].Value = PRODUCTBRAND;
                            string SalePrice = ((DataRowView)productUnitsPricesBindingSource.Current)["CostmerPrice"].ToString();
                            ProductsDGView.Rows[e.RowIndex].Cells["PriceVal"].Value = SalePrice;
                        }
                        //productUnitsPricesBindingSource.RemoveFilter();
                    }
                    PriceVal.Selected = true;
                }

            }

            if (ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != DBNull.Value)
            {
                string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                string StoreId = this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();

                long StockQty = 0;
                bool t = long.TryParse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), long.Parse (UnitId), int.Parse(StoreId)).ToString(), out StockQty);
                StatusLblQty.Text = StockQty.ToString();

                //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices,long.Parse (UnitId), long.Parse (ProductId));
                //int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString())

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
                    //if (dgv.Columns[e.ColumnIndex].Name != "PriceVal" )
                    //{
                    //    ProductsDGView["PriceVal", e.RowIndex].Value = MaxPrice;
                    //}
                }
                else
                {
                    //if (dgv.Columns[e.ColumnIndex].Name != "PriceVal" )
                    //{
                    //    ProductsDGView["PriceVal", e.RowIndex].Value = "0";
                    //}
                    StatusLblMaxPrice.Text = "0";

                }
                //OldProductId = ProductsDGView["CmbPRODUCTID", e.RowIndex].Value;
            }

        }

        private void qidsDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //if (qidsBindingSource.Count > 0 && qidsDetailsBindingSource.Count > 0)
            //{
            //    ((DataRowView)qidsDetailsBindingSource.Current)["qidid"] = (Int64)((DataRowView)qidsBindingSource.Current)["qidid"];
            //}

        }

       
       
       

        

           

    }
 
}