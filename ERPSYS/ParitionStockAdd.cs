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
    public partial class ParitionStockAdd : DockContent
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
        public long MoveId;
        public int PassfromStoreId=-1;
        public ParitionStockAdd()
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
            partitionDetailsBindingSource.CancelEdit();
            partitionBindingSource.CancelEdit();
           



            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Partition' table. You can move, or remove it, as needed.
            this.partitionTableAdapter.Fill(this.nEWERPDataSet.Partition);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PartitionDetails' table. You can move, or remove it, as needed.
            //this.partitionDetailsTableAdapter.Fill(this.nEWERPDataSet.PartitionDetails);
           
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.

            productsTableAdapterMain.Fill(this.newerpDataSetMain.PRODUCTS);
         
            ProductsDGView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
           

            foreach (DataGridViewRow row in ProductsDGView.Rows)
            {

                row.HeaderCell.Value = row.Index.ToString();
            }
           
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            flag = false;
                     
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
 
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.

                       
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.


           
            if (partitionBindingSource.Count > 0)
            {
                Int64 MoveId = (Int64)((DataRowView)partitionBindingSource.Current)["Id"];
                this.partitionDetailsTableAdapter.FillByPartId (this.nEWERPDataSet.PartitionDetails , MoveId);
                //this.inv_ProductsTableAdapter.Fill(this.nEWERPDataSet.Inv_Products);
            }

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.

            
            //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
                   
         
            pRODUCTSBindingSource.Filter = "MainNode=false";
           
            pRODUCTSBindingSource.Sort = "productname";


            pRODUCTSBindingSourceMain.Filter = "MainNode=false";

            pRODUCTSBindingSourceMain.Sort = "productname";

                     
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
                    int pos = partitionBindingSource.Find("Id", MoveId);
                    if (pos > -1)
                    {
                        partitionBindingSource.Position = pos;
                    }

                }
           
          

            //LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            flag = true;
           
            Nflag = true;
            ProductsDGView.Focus();

            
        }

       

        private void CmdSave_Click(object sender, EventArgs e)
        {
            SaveAll(false);
            
        }
     
        private Boolean SaveChild()
        {

            //this.Validate();
            nEWERPDataSet.EnforceConstraints = false;
            // Get the master row
            NEWERPDataSet.PartitionRow master = (NEWERPDataSet.PartitionRow)(((DataRowView)partitionBindingSource.Current).Row);
            // Get the child row
            NEWERPDataSet.PartitionDetailsRow detail = (NEWERPDataSet.PartitionDetailsRow)(((DataRowView)partitionDetailsBindingSource.Current).Row);


            if (((DataRowView)partitionDetailsBindingSource.Current)["PRODUCTID"] == DBNull.Value || ((DataRowView)partitionDetailsBindingSource.Current)["Qty"] == DBNull.Value)
            {
                return false;
            }
            // Save the master row
            partitionBindingSource.EndEdit();
            partitionTableAdapter.Update(master);
            //invoicesTableAdapter.Update(nEWERPDataSet.invoices );
            //masterTableAdapter.Update(master);
            // Store the new database-generated ID to the child row

            if (detail.PartId != master.Id )
            {
                for (int i = 0; i < partitionDetailsBindingSource.Count; i++)
                {
                    ((DataRowView)partitionDetailsBindingSource[i])["PartId"] = master.Id;
                }
            }

            
            //detail.qidid  = master.qidid;
            // Save the child row
            partitionDetailsBindingSource.EndEdit();
            partitionDetailsTableAdapter.Update(nEWERPDataSet.PartitionDetails );

            

          

            // Re-enable constraints
            nEWERPDataSet.EnforceConstraints = true;
            return true;

        }
        private Boolean  CheckProductInStock()
        {
            long   ProductId   = long.Parse (CmbMainProductId.SelectedValue.ToString());
            long StoreId = long.Parse (sTOREComboBox.SelectedValue.ToString());// this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
            long UnitId =  long.Parse (cmbMainUnit.SelectedValue.ToString());
           
            //string strQty = ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

             decimal StockQty = decimal.Parse(sTOCKTableAdapter.StockCheckQtyByProductId(UnitId ,ProductId,StoreId ).ToString ());
             if (StockQty == 0)
             {
                 MessageBox.Show("Â–« «·’‰› €Ì— „ÊÃÊœ »«·„Ã“‰ «Ê «·ﬂ„Ì… ›Ï «·„Œ“‰ «ﬁ· „‰ «·ﬂ„Ì… «·„Õœœ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false); 
                 return false;
             }
             else
             {
                 return true ;
             }
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
                        if (partitionDetailsBindingSource.Count > 0)// && !ProductsDGView.IsCurrentRowDirty && !dGViewQidWith.IsCurrentRowDirty)
                        {
                            try
                            {
                                if (CmbMainProductId.SelectedValue!=null)
                                {
                                    if (cmbMainUnit.SelectedValue != null && sTOREComboBox.SelectedValue != null && GLibrary.IsNumeric (txtQty.Text))
                                    {


                                        
                                        if (!SaveChild())
                                        {
                                            MessageBox.Show("«œŒ· «Œ— ’‰› »ÿ—Ìﬁ… ’ÕÌÕÂ «Ê  Õ—ﬂ «·Ï «·’‰ﬁ «·”«»ﬁ À„ «÷⁄Ÿ Õ›Ÿ", "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                            return;
                                        }
                                        int ret = 0;
                                        //if (!EditFlag)
                                        //{
                                        //    int Pos = 0;
                                        //    bRANCHESBindingSource.Find("BRANCHCODE", Messages.CurBranch);

                                        //    ((DataRowView)bRANCHESBindingSource[Pos])["MovementSerial"] = txtId.Text;

                                        //    //this.Validate();
                                        //    bRANCHESBindingSource.EndEdit();
                                        //    ret = bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);
                                        //    //setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes);
                                        //}

                                        //partitionDetailsBindingSource.EndEdit();
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
                                        BtnPrint.Enabled = true;
                                        EditFlag = true;

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
                                        MessageBox.Show(" «œŒ· «·ÊÕœ…Ê«·„Œ“‰ »ÿ—Ìﬁ… ”·Ì„…", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("√œŒ· «”„ «·’‰›", "«·ﬁÌÊœ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                }
                            }
                            catch (Exception ex)
                            {
                                int ErrorNo = -1;
                                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                if (ErrorNo == 547)
                                {
                                    partitionBindingSource.RemoveCurrent();
                                    partitionBindingSource.EndEdit();
                                    partitionTableAdapter.Update(nEWERPDataSet.Partition );
                                }

                            }


                        }
                        else
                        {
                            MessageBox.Show(Messages.InvaildInvMesg, "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                    Nflag = true;
                }
            }
            else
            {
                MessageBox.Show(Messages.InvaildDataInvMesg, "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                
            }
           
        }
        private Boolean ValidateControl()
        {
            //if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString()) //«Ã·
            //{
            if (sTOREComboBox.SelectedValue == null || sTOREComboBox.Text == "")
            {
                MessageBox.Show(Messages.EnterMoveStoreMesg, "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                sTOREComboBox.Focus();
                return false;

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
                //partitionBindingSource.ResetAllowNew();//.CancelEdit();
                partitionBindingSource.RemoveCurrent();
                //partitionBindingSource.EndEdit ();
                //((DataRowView)partitionBindingSource.Current).EndEdit();
                int i = partitionTableAdapter.Update(nEWERPDataSet.Partition );
                if (partitionBindingSource.Count == 0)
                {
                    this.partitionDetailsTableAdapter.Fill(this.nEWERPDataSet.PartitionDetails );
                   
                    CmdDel.Enabled = false;
                    CmdSave.Enabled = false;
                    BtnPrint.Enabled = false;
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
                  
                  
        

        private void AddNewInv()
        {
            //LastIden = int.Parse(partitionTableAdapter.GetMoveStockIden().ToString());
            partitionBindingSource.AddNew();
            txtQty.Text = "1";

            sTOREComboBox.SelectedIndex = 0;

            //chkBoxCheque.Checked = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Save";
            }

            //branchIdTextBox.Text = Messages.CurBranch;
          
            //int Pos = bRANCHESBindingSource.Find("BRANCHCODE", Messages.CurBranch);

            //string MoveSerial = "0";
            //if (nEWERPDataSet.BRANCHES.Rows[Pos]["MovementSerial"] != DBNull.Value)
            //{
            //    MoveSerial = nEWERPDataSet.BRANCHES.Rows[Pos]["MovementSerial"].ToString();
            //}//nEWERPDataSet.SetupCodes.Rows[0]["PurchInvSerial"].ToString();
            //txtId.Text = (int.Parse(MoveSerial) + 1).ToString();

                //txtInvCode.Text = Messages.SysInvpurchasesCode + (LastIden+1).ToString();
          
             
           
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            BtnPrint.Enabled = false;
            EditFlag = false;



        }
      
    
      

        private void ProductsDGView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsDGView.Rows.Count > 0)
            {
                
                if (e.ColumnIndex == Qty.Index)
                {
                    if (this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != null && sTOREComboBox.SelectedValue != null && ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                        string StoreId = sTOREComboBox.SelectedValue.ToString();// this.ProductsDGView["CmbStoreId", e.RowIndex].Value.ToString();
                        string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();
                        string strQty=ProductsDGView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        
                        //CheckQty(ProductId, StoreId,UnitId , strQty);
                    }
                }
               
            }
        }
       
        private void CheckQty(string ProductId,string StoreId,string UnitId,string Qty)
        {
            if (ProductId != "" && StoreId != "")
            {
                decimal StockQty = decimal.Parse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), int.Parse(StoreId)).ToString());
                if (Qty != "")
                {
                    if (decimal.Parse(Qty) > StockQty)
                    {
                        MessageBox.Show(Messages.StockQtyMesg, "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show(Messages.StockNullQtyMesg, "”‰œ «· ÕÊÌ·", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
             
                      
            e.Row.Cells["Qty"].Value = "1";
            if (sTOREComboBox.SelectedValue != null)
            {
                e.Row.Cells["STOREID"].Value = sTOREComboBox.SelectedValue.ToString();
            }
            
            
        }


        private void txtInvCode_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                int pos = partitionBindingSource.Find("Id", txtId.Text);

               if (pos != -1)
               {
                   if (GLibrary.MsgCheckSave(false))
                   {
                       SaveAll(false);
                   }
                   else
                   {

                       partitionBindingSource.CancelEdit();
                       partitionDetailsBindingSource.CancelEdit();
                      
                   }
                   partitionBindingSource.Position = pos;
                   Int64 MoveId = (Int64)((DataRowView)partitionBindingSource.Current)["Id"];
                   //partitionDetailsBindingSource.Filter = "MoveId = " + MoveId.ToString();
                   this.partitionDetailsTableAdapter.FillByPartId (this.nEWERPDataSet.PartitionDetails  , MoveId);
                 
                  
                   CmdAdd.Enabled = true;
                   CmdDel.Enabled = true;
                   BtnPrint.Enabled = true;
                   EditFlag = true;
               }
               else
               {
                   MessageBox.Show(Messages.InvNotfoundMesg, "”‰œ  Ã“∆…", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                   partitionBindingSource.CancelEdit();
                   partitionDetailsBindingSource.CancelEdit();
                  
                   if (!EditFlag)
                   {
                        CmdAdd.Enabled = true;
                        CmdDel.Enabled = true;
                        BtnPrint.Enabled = true;
                        EditFlag = true;
                   }
                   
               }

            }


        }

        private void MenuItemDelProduct_Click(object sender, EventArgs e)
        {
            if (partitionDetailsBindingSource.Count > 0)
            {
                partitionDetailsBindingSource.RemoveCurrent();
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

       
            

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (EditFlag)
            {
                ShowProductsRpt frm = new ShowProductsRpt();
                //this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
             

                frm.nEWERPDataSet = nEWERPDataSet;
                frm.choiceNum = 12;
             
                frm.InvType = "Ú”‰œ  ÕÊÌ·";


                frm.InvDate = MoveDatePicker.Value;
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(Messages.CheckInvPrintMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
            //        partitionBindingSource.CancelEdit();
            //        partitionDetailsBindingSource.CancelEdit();
            //        qidsBindingSource.CancelEdit();
            //        qidsDetailsBindingSource.CancelEdit();
            //        qidsDetailsBindingSourceWith.CancelEdit();

            //    }

            //}
            //else
            //{
            //    partitionBindingSource.CancelEdit();
            //    partitionDetailsBindingSource.CancelEdit();
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

                partitionBindingSource.CancelEdit();
                partitionDetailsBindingSource.CancelEdit();
               
                nEWERPDataSet.StockMovement.RejectChanges();
                nEWERPDataSet.StockMoveDetails.RejectChanges();
            

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
                    CmdSave.Text = "ÚEdit";
                }


            }
           
        }
//        Catch rAs NoNullAllowedException

//MsgBox("Please finish edit the current new row first.")

//EndTry


        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            
            CheckCancel();
           
            
        }

       
         
        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ProductsDGView.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }

       

      

       
     
        private void ProductsDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (sTOREComboBox.SelectedValue != null)
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
                        ProductsDGView["CmbUnitId", e.RowIndex].Value = nEWERPDataSet.CDE_UNIT_TYPES.Rows[0]["UINTID"].ToString();

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
            // Barcode
            if (dgv.Columns[e.ColumnIndex].Name == "BarCode")
            {

                productUnitsPricesBindingSource.RemoveFilter();
                int pos = productUnitsPricesBindingSource.Find("PRODUCTBRAND", e.FormattedValue);
                if (pos > -1)
                {
                    productUnitsPricesBindingSource.Position = pos;
                    int ProductId = int.Parse(((DataRowView)productUnitsPricesBindingSource.Current)["PRODUCTID"].ToString());

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
                           
                          
                        }
                        //productUnitsPricesBindingSource.RemoveFilter();
                    }
                    
                }

            }

            if (ProductsDGView["CmbPRODUCTID", e.RowIndex].Value != DBNull.Value)
            {
                
                string ProductId = this.ProductsDGView["CmbPRODUCTID", e.RowIndex].Value.ToString();
                string StoreId = sTOREComboBox.SelectedValue.ToString();
                string UnitId = this.ProductsDGView["CmbUnitId", e.RowIndex].Value.ToString();
               long StockQty = 0;
               if (UnitId != "" && ProductId != "" && StoreId != "")
               {

                   bool t = long.TryParse(sTOCKTableAdapter.GetQuntityValue(int.Parse(ProductId), int.Parse(StoreId)).ToString(), out StockQty);
               }
             }

           
            }
       
            else
            {
                MessageBox.Show(Messages.MoveStockProdcutMsg, "«·«’‰«›", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                return;
            }
            this.cDE_UNIT_TYPESTableAdapter.Fill (this.nEWERPDataSet.CDE_UNIT_TYPES);
        }

     
        private void partitionDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (partitionBindingSource.Count > 0 && partitionDetailsBindingSource.Count > 0)
            {

                ((DataRowView)partitionDetailsBindingSource.Current)["PartId"] = (Int64)((DataRowView)partitionBindingSource.Current)["Id"];
                if (((DataRowView)partitionDetailsBindingSource.Current)["PRODUCTID"] != DBNull.Value && ((DataRowView)partitionDetailsBindingSource.Current)["UnitID"] != DBNull.Value)
                {
                    string ProductId = ((DataRowView)partitionDetailsBindingSource.Current)["PRODUCTID"].ToString();
                    string UnitId = ((DataRowView)partitionDetailsBindingSource.Current)["UnitId"].ToString();
                    this.cDE_UNIT_TYPESTableAdapter.FillByProductId(this.nEWERPDataSet.CDE_UNIT_TYPES, long.Parse(ProductId));
                    //product_Units_PricesTableAdapter.FillByByUnitId(this.nEWERPDataSet.Product_Units_Prices, );
                }
            }
        }

        private void partitionBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (partitionBindingSource.Count > 0)
            {
                // if (partitionBindingSource.Count == 1 && ((DataRowView)partitionBindingSource.Current)["MoveId"].ToString() == "0")
              
                //if (partitionBindingSource.Count > 0 && ((DataRowView)partitionBindingSource.Current).IsNew)
                //{
                //    ((DataRowView)partitionBindingSource.Current)["MoveId"] = (Int64)(LastIden + 1);

                //}
                Int64 MoveId = (Int64)((DataRowView)partitionBindingSource.Current)["Id"];

                //partitionDetailsBindingSource.Filter = "MoveId = " + MoveId.ToString();
                this.partitionDetailsTableAdapter.FillByPartId (this.nEWERPDataSet.PartitionDetails , MoveId);


            }
        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMovePreviousItem_Click_1(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveFirstItem_Click_1(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void bindingNavigatorMoveLastItem_Click_1(object sender, EventArgs e)
        {
            CheckCancel();
        }

        private void CmbMainProductId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CmbMainProductId.SelectedValue != null)
            {
                long CurProductId = long.Parse(CmbMainProductId.SelectedValue.ToString());

                this.cdE_UNIT_TYPESTableAdapterMain.FillByProductId(this.newerpDataSetMain.CDE_UNIT_TYPES, CurProductId);
            }
        }

       
       
       

        

           

    }
 
}