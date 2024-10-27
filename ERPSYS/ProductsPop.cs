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
    public partial class ProductsPop : DockContent
    {
        public int iunitId;
        public String strUnitDesc;
        public Boolean EditFlag = false ;
        public Boolean flag = false ;
        private  NEWERPDataSet TempnEWERPDataSet =new NEWERPDataSet ();
        public ProductsPop()
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
            //cDEDEPTBindingSource.CancelEdit();
            //this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.STOCK' table. You can move, or remove it, as needed.
            //this.sTOCKTableAdapter.Fill(this.nEWERPDataSet.STOCK);
            //// TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            //this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
          
           
            this.pRODUCTSTableAdapter.FillByMainNode(TempnEWERPDataSet.PRODUCTS);
            cmbMainProducts.DataSource = TempnEWERPDataSet.PRODUCTS;
            cmbMainProducts.DisplayMember = "productname";
            cmbMainProducts.ValueMember  = "productId";
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_PRODUCTTYPES' table. You can move, or remove it, as needed.
            this.cDE_PRODUCTTYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_PRODUCTTYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            //this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            //flag = false;
            //// TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            //this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            //// TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.

            //flag = true;
            AddNew();
            
        }
         private void AddNew()
         {
                pRODUCTSBindingSource.AddNew();
                txtProcessFlag.Text = Boolean.FalseString;
                txtRootFlag.Text = Boolean.FalseString;
                txtMainNode.Text = Boolean.FalseString;
                cmbMainProducts.SelectedIndex = 0;
                CmbProductType.SelectedIndex = 0;
                txtProductPrice.Text = "0";
                txtLimitQty.Text = "0";
                //txtFactor.Text = "1";
                //MainUnitChkBox.Checked = true;
                GetProductCode();
                txtProductName.Focus();

         }
       
        private void SaveCmd_Click(object sender, EventArgs e)
        {
            if (GLibrary.MsgCheckSave(false))
            {
                try
                {

                    if (GLibrary.ValidatetxtBox(errorProvider1, txtProductName, "ÃÏÎá ÃÓã ÇáÕäÝ", "ÇáÇÕäÇÝ", true))
                    {
                        if (cmbUnits.SelectedValue != null)
                        {
                            if (CmbStores.SelectedValue != null)
                            {
                              
                                    this.Validate();
                                    pRODUCTSBindingSource.EndEdit();
                                    int i = pRODUCTSTableAdapter.Update(nEWERPDataSet.PRODUCTS);

                                    if (i > 0)
                                    {
                                        long CurProductId = long.Parse(((DataRowView)pRODUCTSBindingSource.Current)["PRODUCTID"].ToString());
                                        product_Units_PricesBindingSource.AddNew();
                                        ((DataRowView)product_Units_PricesBindingSource.Current)["PRODUCTID"] = CurProductId;

                                        ((DataRowView)product_Units_PricesBindingSource.Current)["UintId"] = int.Parse(cmbUnits.SelectedValue.ToString());
                                        if (txtBarcode.Text != "")
                                        {
                                            ((DataRowView)product_Units_PricesBindingSource.Current)["PRODUCTBRAND"] = txtBarcode.Text;
                                        }
                                        //if (GLibrary.IsNumeric(txtFactor.Text))
                                        //{

                                        //    ((DataRowView)product_Units_PricesBindingSource.Current)["ConFactor"] = txtFactor.Text;
                                        //    if (int.Parse(txtFactor.Text) > 1)
                                        //    {
                                        //        ((DataRowView)product_Units_PricesBindingSource.Current)["MainUnit"] = Boolean.TrueString;
                                        //    }
                                        //}
                                        //else
                                        //{
                                            ((DataRowView)product_Units_PricesBindingSource.Current)["ConFactor"] = 1;
                                            ((DataRowView)product_Units_PricesBindingSource.Current)["MainUnit"] = Boolean.TrueString;
                                           
                                       

                                        if (GLibrary.IsNumeric(txtProductPrice.Text))
                                        {
                                            ((DataRowView)product_Units_PricesBindingSource.Current)["CostmerPrice"] = txtProductPrice.Text;
                                        }
                                        if (GLibrary.IsNumeric(txtLimitQty.Text))
                                        {
                                            ((DataRowView)product_Units_PricesBindingSource.Current)["THRESHOLDINSTOCK"] = txtLimitQty.Text;
                                        }

                                        product_Units_PricesBindingSource.EndEdit();
                                        product_Units_PricesTableAdapter.Update(nEWERPDataSet.Product_Units_Prices);
                                    
                                    sTOCKBindingSource.AddNew();
                                    ((DataRowView)sTOCKBindingSource.Current)["PRODUCTID"] = ((DataRowView)product_Units_PricesBindingSource.Current)["PRODUCTID"];
                                    ((DataRowView)sTOCKBindingSource.Current)["UnitID"] = ((DataRowView)product_Units_PricesBindingSource.Current)["UintId"];
                                    ((DataRowView)sTOCKBindingSource.Current)["STOREID"] = int.Parse(CmbStores.SelectedValue.ToString());
                                    ((DataRowView)sTOCKBindingSource.Current)["QtyInStore"] = 0;

                                    sTOCKBindingSource.EndEdit();

                                    this.sTOCKTableAdapter.Update(this.nEWERPDataSet.STOCK);


                                    GLibrary.MsgSave();
                                    EditFlag = true;
                                    AddNew();

                                    //                CmdAdd.Enabled = true;
                                    //                EditFlag = true;
                                    //                flag = true ;
                                    //                DelCmd.Enabled = true;
                                    //                SaveCmd.Text = "ÊÚÏíá";


                                }
                               
                            }
                            else
                            {
                                MessageBox.Show("ÃÏÎá ÇáãÎÒä", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }

                    }
                    else
                    {
                        MessageBox.Show("ÃÏÎá æÍÏÉ ÇáÕäÝ", "ÍÝÙ ÇáÓÌá", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                

                }
                 
                catch (Exception ex)
                {
                    int ErrorNo = -1;
                    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáæÍÏÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void DelCmd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (GLibrary.MsgCheckDel())
            //    {

            //        if (UnitsDGView.SelectedRows .Count >0)
            //        {

            //            cDEDEPTBindingSource.RemoveCurrent();
            //            cDEDEPTBindingSource.EndEdit();
            //            int I = cDE_DEPTTableAdapter.Update(personalDataSet.CDE_DEPT);
                          
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    int ErrorNo = -1;
            //    MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "ÇáæÍÏÇÊ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    cDEDEPTBindingSource.CancelEdit();
            //}
        }

        private void UnitsDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void cmbMainProducts_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetProductCode();
        }
        private void GetProductCode()
        {
            if (cmbMainProducts.SelectedValue != null)
            {
                string curPRODUCTID = cmbMainProducts.SelectedValue.ToString();
                NEWERPDataSet.PRODUCTSRow Row;
                Row = TempnEWERPDataSet.PRODUCTS.FindByPRODUCTID(long.Parse(curPRODUCTID));

                
                //int pos = pRODUCTSBindingSource.Find("PRODUCTID", PRODUCTID);
                long Serial = 0;
                string LastSerialNo = "";
                if (Row != null)
                {
                    //int index = Row.PRODUCTCODE.IndexOf("/");
                    //string ParentCode = Row.PRODUCTCODE.Substring(0, index);
                    string ParentCode = Row.PRODUCTCODE.ToString().TrimEnd();

                    string str = "";
                    LastSerialNo = Row.SerialCode.ToString(); // nEWERPDataSet.PRODUCTS.Rows[pos]["SerialCode"].ToString();
                    if (LastSerialNo == "" || LastSerialNo == "0")
                    {
                        int ParentChildCount = int.Parse(pRODUCTSTableAdapter.PRODUCTSelectNumofChild(long.Parse(curPRODUCTID)).ToString());
                        str = ParentCode + ParentChildCount.ToString();// Node.Nodes.Count.ToString();
                    }
                    else
                    {
                        str = LastSerialNo.Remove(0, ParentCode.Length);
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
                    if (LastSerialNo != "" && LastSerialNo != "0")
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
                Row.SerialCode = long.Parse (LastSerialNo);
                pRODUCTSTableAdapter.Update(Row);

            }
        }
            
    }
}