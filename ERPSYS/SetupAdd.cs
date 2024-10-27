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
    public partial class SetupAdd : DockContent
    {
        public SetupAdd()
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
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.SetupCodes' table. You can move, or remove it, as needed.
            this.setupCodesTableAdapter.Fill(this.nEWERPDataSet.SetupCodes);

            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
           

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
     

        private void CmdSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (Cmbbox.SelectedValue == null)
            {
                ((DataRowView)setupBindingSource.Current)["boxaccid"] = -1;
            }
            if (cmbBoxPur.SelectedValue == null)
            {
                ((DataRowView)setupBindingSource.Current)["purchaseaccid"] = -1;
            }
            if (cmbBoxSales.SelectedValue == null)
            {
                ((DataRowView)setupBindingSource.Current)["salesaccid"] = -1;
            }
          
            if (cmbBoxPay.SelectedValue == null)
            {
                ((DataRowView)setupBindingSource.Current)["Paymentsaccid"] = -1;
            }
            
            setupBindingSource.EndEdit();
            //nEWERPDataSet.AcceptChanges();
            setupCodesBindingSource.EndEdit();
            bRANCHESBindingSource.EndEdit();

            setupTableAdapter.Update(nEWERPDataSet.setup);
            setupCodesTableAdapter.Update(nEWERPDataSet.SetupCodes );
            bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES);

            GLibrary.MsgSave();
            if (nEWERPDataSet.setup.Count > 0)
            {
                if (nEWERPDataSet.setup.Rows[0]["boxaccid"] != DBNull.Value)
                {
                    Messages.boxAccid = int.Parse(nEWERPDataSet.setup.Rows[0]["boxaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["bankaccid"] != DBNull.Value)
                {
                    Messages.bankaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["bankaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["custaccid"] != DBNull.Value)
                {
                    Messages.custaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["custaccid"].ToString()); 
                }
                if (nEWERPDataSet.setup.Rows[0]["suppaccid"] != DBNull.Value)
                {
                    Messages.suppaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["suppaccid"].ToString()); 
                }
                if (nEWERPDataSet.setup.Rows[0]["salesaccid"] != DBNull.Value)
                {
                    Messages.salesaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["salesaccid"].ToString()); 
                }
                if (nEWERPDataSet.setup.Rows[0]["purchaseaccid"] != DBNull.Value)
                {
                    Messages.purchaseaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["purchaseaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["Discountaccid"] != DBNull.Value)
                {
                    Messages.Discountaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["Discountaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["PurReorderaccid"] != DBNull.Value)
                {
                    Messages.PurReorderaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["PurReorderaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["SalReorderaccid"] != DBNull.Value)
                {
                    Messages.SalReorderaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["SalReorderaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["Paymentsaccid"] != DBNull.Value)
                {
                    Messages.Paymentsaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["Paymentsaccid"].ToString());
                              
                }
              
               
              

                if (nEWERPDataSet.setup.Rows[0]["salesAgalaccid"] != DBNull.Value)
                {
                    Messages.salesAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["salesAgalaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["purchaseAgalaccid"] != DBNull.Value)
                {
                    Messages.purchaseAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["purchaseAgalaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["SalReorderAgalaccid"] != DBNull.Value)
                {
                    Messages.SalReorderAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["SalReorderAgalaccid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["PurReorderAgalaccid"] != DBNull.Value)
                {
                    Messages.PurReorderAgalaccid = int.Parse(nEWERPDataSet.setup.Rows[0]["PurReorderAgalaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["Mainsalesaccid"].ToString() != "")
                {
                    Messages.MainSalesAccid  = int.Parse(nEWERPDataSet.setup.Rows[0]["Mainsalesaccid"].ToString());
                }

                if (nEWERPDataSet.setup.Rows[0]["MainPurchaseaccid"].ToString() != "")
                {
                    Messages.MainPurchaseaccid  = int.Parse(nEWERPDataSet.setup.Rows[0]["MainPurchaseaccid"].ToString());
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
                if (nEWERPDataSet.setup.Rows[0]["accountid"].ToString() != "")
                {
                    Messages.accountidMainBox = int.Parse(nEWERPDataSet.setup.Rows[0]["accountid"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["StockAccId"].ToString() != "")
                {
                    Messages.StockAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["StockAccId"].ToString());
                }
                if (nEWERPDataSet.setup.Rows[0]["CostSalesProductAccId"].ToString() != "")
                {
                    Messages.CostSalesProductAccId = int.Parse(nEWERPDataSet.setup.Rows[0]["CostSalesProductAccId"].ToString());
                }
                
            }
            
            
        }

        private void SetupAdd_Activated(object sender, EventArgs e)
        {
            
        
        }

        private void logoPictureBox_DoubleClick(object sender, EventArgs e)
        {
            AddPic();    
        }
        private void AddPic()
        {
            openFileDialog1.Filter = "Images | *.bmp;*.tif;*.jpg;*.gif";
            //Show OPEN FILE DIALOG to user
            openFileDialog1.ShowDialog();
            DialogResult ret = openFileDialog1.ShowDialog();
            if (ret != DialogResult.Cancel)
            {
                logoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void BtnPic_Click(object sender, EventArgs e)
        {
            AddPic();
        }

       

        

        
    }
}