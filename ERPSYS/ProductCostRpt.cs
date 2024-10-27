using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using System.Collections;
namespace ERPSYS
{
    public partial class ProductCostRpt : Form
    {
     
      private Nullable<int> ProductId = null;
    
        
   
        public ProductCostRpt()
        {
            InitializeComponent();
        }

    

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
            this.product_Units_PricesTableAdapter.Fill(this.nEWERPDataSet.Product_Units_Prices);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Assemply' table. You can move, or remove it, as needed.
            this.product_AssemplyTableAdapter.Fill(this.nEWERPDataSet.Product_Assemply);
            // TODO: This line of code loads data into the 'nEWERPDataSet.setup' table. You can move, or remove it, as needed.
            this.setupTableAdapter.Fill(this.nEWERPDataSet.setup);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.nEWERPDataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.InvProductsMoveVIEW' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
    
            CmbProducts.SelectedValue = -1;
          
                   
        }

          

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

           
         
               ProductId=null;
                  
             
          
              if (CmbProducts.SelectedValue != null) { ProductId = int.Parse(CmbProducts.SelectedValue.ToString()); }
           

                  ShowNewRpt frm = new ShowNewRpt();
                     
              
                   frm.choiceNum = 33;

                   this.product_AssemplyTableAdapter.FillByProductId(this.nEWERPDataSet.Product_Assemply, ProductId);
                   
                    frm.nEWERPDataSet = nEWERPDataSet;          
                    frm.ShowDialog(this);
            // }
        }

       

      

       

      

      

      

      
      

     
      

       

       

        
    }
}