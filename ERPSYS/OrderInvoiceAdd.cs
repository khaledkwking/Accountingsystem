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
using System.Collections;
namespace ERPSYS
{
    public partial class OrderInvoiceAdd : Form
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
        public OrderInvoiceAdd()
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
          
            oRDERSBindingSource.CancelEdit();
           



            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.ORDERDETAILS' table. You can move, or remove it, as needed.
        
            this.oRDERSTableAdapter.Fill(this.nEWERPDataSet.ORDERS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvOrders_Products' table. You can move, or remove it, as needed.
          
            // TODO: This line of code loads data into the 'nEWERPDataSet.USER_FUNCTION' table. You can move, or remove it, as needed.
           
        
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
                   

           
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
       
            flag = false;
            //this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));
            //this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));
            //this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

            CmbBillType.DataSource = slBillType.ToDataTable();
            txtFromDate.Text = DateTime.Today.ToShortDateString();
            txtToDate.Text = DateTime.Today.ToShortDateString();
            SelType();
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
         


            

            // TODO: This line of code loads data into the 'nEWERPDataSet.Inv_Products' table. You can move, or remove it, as needed.

            
            //this.qidsDetailsTableAdapter.Fill(this.nEWERPDataSet.qidsDetails);
            //this.qidsTableAdapter.Fill(this.nEWERPDataSet.qids);

                  
         
            sUPPLIERSCUSTOMERSBindingSource.Sort = "CREDITLIMIT DESC ,SUP_CUST_FNAME";
           
            //accountingBindingSourceQid.Filter = "Mainnode=" + Boolean.FalseString;

            //qidsDetailsBindingSource.Filter =  "QidType=" + GLibrary.strarrQidTypes[2, 0].ToString();
            //qidsDetailsBindingSourceWith.Filter = "QidType=" + GLibrary.strarrQidTypes[4, 0].ToString();
            //if (CmbBranch.SelectedValue != null)
            //{

            search();
            //}

            
           
          

            //LastIden = int.Parse(invoicesTableAdapter.GetLastIdentity().ToString());
            flag = true;
           
            Nflag = true;
            ProductsDGView.Focus();

           
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
        
        }
   

        

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = dtFromDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dtToDate.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

       
        private void search()
        {
            oRDERSBindingSource.RemoveFilter();
            string Sqlstr = "1=1";
            DateTime FromDate;
            DateTime ToDate;
            string Cust_Sup_Accid;
            if (txtFromDate.Text != "")
            {
                FromDate = DateTime.Parse(txtFromDate.Text);
                Sqlstr = Sqlstr + " And OrderDate>='" + FromDate.ToString() + "'";
            }
            //else
            //{
            //    frm.FromDate = new DateTime(DateTime.Today.Year, 1, 1);
            //}
            if (txtToDate.Text != "")
            {
                ToDate = DateTime.Parse(txtToDate.Text + " 23:59");
                Sqlstr = Sqlstr + " And OrderDate<='" + ToDate.ToString() + "'";
            }
            //else
            //{
            //    frm.ToDate = DateTime.Parse(DateTime.Today.ToShortDateString() + " 23:59");
            //}
            if (CmbCustSupAccid.SelectedValue != null)
            {
                Cust_Sup_Accid = CmbCustSupAccid.SelectedValue.ToString();
                Sqlstr = Sqlstr + " And Cust_Sup_Accid=" + Cust_Sup_Accid.ToString();
            }
            oRDERSBindingSource.Filter = Sqlstr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void ProductsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //ProductsDGView.Rows[e.RowIndex].Cells["OrderSel"].Value = 1;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (oRDERSBindingSource.Count > 0)
            {
                ArrayList OrdersArray = new ArrayList();
                for (int i = 0; i < oRDERSBindingSource.Count; i++)
                {

                    DataGridViewCheckBoxCell dgcb = (DataGridViewCheckBoxCell)ProductsDGView["OrderSel", i];
                    //dgcb.DataSource = productUnitsPricesBindingSource;
                    // Filter the BindingSource based upon the region selected

                    Boolean bOrderSel = Boolean.Parse(ProductsDGView["OrderSel", i].Value.ToString());
                    if (bOrderSel)
                    {
                        oRDERSBindingSource.Position = i;
                        string OrderId = ((DataRowView)oRDERSBindingSource.Current)["OrderId"].ToString();
                        OrdersArray.Add(OrderId);
                        //int Cust_Sup_Accid = int.Parse (((DataRowView)invoicesBindingSource.Current)["Cust_Sup_Accid"].ToString ());



                    }
                }
                InvoiceAdd frm = new InvoiceAdd();
                frm.OrdersArray = OrdersArray;
                frm.InvType = Messages.InvSalesFlag;
                frm.FromOrder = true;
                frm.PCust_Sup_Accid = long.Parse(CmbCustSupAccid.SelectedValue.ToString());
                frm.PBillType = int.Parse(CmbBillType.SelectedValue.ToString());
                frm.ShowDialog();
            }
        }

        private void ProductsDGView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            ProductsDGView.Rows[e.RowIndex].Cells["OrderSel"].Value = 1;
        }

        private void CmbBillType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelType();
        }
        private void SelType()
        {
            if (CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[0, 0].ToString() || CmbBillType.SelectedValue.ToString() == GLibrary.strarrBillType[2, 0].ToString()) //ÇÌב
            {


                CmbCustSupAccid.DataBindings.Clear();

                this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                this.CmbCustSupAccid.ValueMember = "accountid";
                this.Validate();

                this.sUPPLIERS_CUSTOMERSTableAdapter.FillBytype(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                CmbCustSupAccid.SelectedValue = -1;
                //sUPPLIERSCUSTOMERSBindingSource.Filter = "accountid>0 and accountid is not null and (SUP_CUST_TYPE=" + Messages.CustFlag + " or SUP_CUST_TYPE=" + Messages.CustSupFlag + ")" ;

            }
            else //הÞÏÇ
            {


                CmbCustSupAccid.DataBindings.Clear();

                this.CmbCustSupAccid.DataSource = this.sUPPLIERSCUSTOMERSBindingSource;
                this.CmbCustSupAccid.DisplayMember = "SUP_CUST_FNAME";
                this.CmbCustSupAccid.ValueMember = "accountid";


                this.sUPPLIERS_CUSTOMERSTableAdapter.FillByPayByType(this.nEWERPDataSet.SUPPLIERS_CUSTOMERS, int.Parse(Messages.CustFlag));

                //sUPPLIERSCUSTOMERSBindingSource.RemoveFilter();
                CmbCustSupAccid.SelectedValue = -1;

            }
        }
       
         
       
            

      
             
      
//MsgBox("Please finish edit the current new row first.")

//EndTry

 
           

    }
 
}