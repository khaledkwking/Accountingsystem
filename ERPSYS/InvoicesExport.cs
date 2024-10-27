using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ERPSYS.Reports;
using Microsoft.Office.Tools.Excel ;

namespace ERPSYS
{
    public partial class InvoicesExport : Form
    {
        public int iStoreId;
        public String strStoreName;
        public String strStoreCode;
        public Boolean EditFlag = false;
        public int LInvType;

        private StaticList slInvType = new StaticList(GLibrary.strarrInvType);

        public InvoicesExport()
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
            CmbInvTypes.DataSource = slInvType.ToDataTable();
            // TODO: This line of code loads data into the 'nEWERPDataSet.CostCenters' table. You can move, or remove it, as needed.
            this.costCentersTableAdapter.Fill(this.nEWERPDataSet.CostCenters);
            // TODO: This line of code loads data into the 'nEWERPDataSet.Product_Units_Prices' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_UNIT_TYPES' table. You can move, or remove it, as needed.
            this.cDE_UNIT_TYPESTableAdapter.Fill(this.nEWERPDataSet.CDE_UNIT_TYPES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.StockMovement' table. You can move, or remove it, as needed.
            this.invoiceViewTableAdapter.FillByAll (this.nEWERPDataSet.InvoiceView);
            
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
            this.sTORESTableAdapter.Fill(this.nEWERPDataSet.STORES);
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);
            costCentersBindingSource.Filter = "costId <>1 ";
            pRODUCTSBindingSource.Filter = "root=false";
            CmbInvTypes.SelectedValue = -1;
            CmbBranches.SelectedValue = -1;
            CmboxCenter.SelectedValue = -1;
            CmbInvTypes.SelectedValue = LInvType.ToString();
            CmbInvTypes.Enabled = false;
            Search();
            if (Messages.Usertype != Messages.AdminUser)
            {
                CmbBranches.SelectedValue = Messages.CurBranch ;
                CmbBranches.Enabled = false;
            }
            else
            {

            }

        }

    


        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string MoveId=StoresDGView.SelectedRows[0].Cells["MoveId"].Value.ToString ();
                string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].Value.ToString();
                string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].Value.ToString();
                string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].Value.ToString();
                string UnitID =StoresDGView.SelectedRows[0].Cells["UnitID"].Value.ToString();
                string MovmentQty =StoresDGView.SelectedRows[0].Cells["MovmentQty"].Value.ToString();
                string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
                ShowReport frm =new ShowReport();
                frm.MoveId=MoveId;
                frm.STOREFromID=STOREFromID;
                frm.STOREToID=STOREToID;
                frm.PRODUCTID=PRODUCTID ;
                frm.UnitID=UnitID ;
                frm.MovmentQty=MovmentQty ;
                frm.EnterDate=EnterDate;
                frm.choiceNum = 2;
                frm.ShowDialog();


            }
        }

        private void Search()
        {
            string StrSql = "1=1";
            if (CmbInvTypes.SelectedValue !=null )
            {
                StrSql = StrSql + " And InvType=" + CmbInvTypes.SelectedValue.ToString();

            }
            if (CmbBranches.SelectedValue !=null)
            {
                StrSql = StrSql + " And BranchId=" + CmbBranches.SelectedValue.ToString();
            }
            if (CmboxCenter.SelectedValue != null)
            {
                StrSql = StrSql + " And CostId=" + CmboxCenter.SelectedValue.ToString();
            }
            if (txtCode.Text  != "")
            {
                StrSql = StrSql + " And InvCode=" + txtCode.Text;
            }
            if (txtCode.Text  != "")
            {
                StrSql = StrSql + " And InvCode=" + txtCode.Text;
            }
            if (txtFromDate.Text  != "")
            {
                //string FromDate = DateTime.Parse(txtFromDate.Text + " 23:59").ToString();
                StrSql = StrSql + " And InvDate>='" + txtFromDate.Text+"'";
            }
            if (txtToDate.Text  != "")
            {
                string toDate =DateTime.Parse(txtToDate.Text + " 23:59").ToString ();
                StrSql = StrSql + " And InvDate<='" + toDate + "'";
            }
           
            invoiceViewBindingSource.Filter = StrSql;
        }

        private void StoresDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (StoresDGView.Columns[e.ColumnIndex].Name == "PaymentTypeDesc")
                {
                    if (StoresDGView.Rows[e.RowIndex].Cells["PaymentType"].Value != DBNull.Value)
                    {
                       
                        int TypeId = int.Parse(StoresDGView.Rows[e.RowIndex].Cells["PaymentType"].Value.ToString());
                        switch (TypeId)
                        {
                            case 1:
                                e.Value  = GLibrary.strarrBillType[0, 1];
                                // strarrBillType = new string[,] { { "1", "ÃÌá" }, { "2", "äÞÏÇ" } };
                                break;

                            case 2:
                                e.Value = GLibrary.strarrBillType[1, 1];
                                break;
                        }
                    }
                }
                if (StoresDGView.Columns[e.ColumnIndex].Name == "InvTypeDesc")
                {
                    if (StoresDGView.Rows[e.RowIndex].Cells["InvType"].Value != DBNull.Value)
                    {
                        int TypeId = int.Parse(StoresDGView.Rows[e.RowIndex].Cells["InvType"].Value.ToString());
                        switch (TypeId)
                        {
                            case 1:
                                e.Value = GLibrary.strarrInvType[0, 1];
                                // strarrBillType = new string[,] { { "1", "ÃÌá" }, { "2", "äÞÏÇ" } };
                                break;

                            case 2:
                                e.Value = GLibrary.strarrInvType[1, 1];
                                break;
                        }
                    }
                }

            }   
        }

        private void CmbInvTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void CmbBranches_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void CmboxCenter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Search();
        }

        private void StoresDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0)
            {
                string InvId = StoresDGView.SelectedRows[0].Cells["InvId"].Value.ToString();
                string InvType = StoresDGView.SelectedRows[0].Cells["InvType"].Value.ToString();
                switch (InvType)
                {
                    case "1":
                        InvoicePurchaseAdd frmPur = new InvoicePurchaseAdd();
                        frmPur.EditFlag = true;
                        frmPur.InvId = long.Parse(InvId);
                        frmPur.InvType = int.Parse (InvType);
                        frmPur.ShowDialog();
                       
                        break;
                    case "2":
                        InvoiceAdd frm = new InvoiceAdd();
                        frm.EditFlag = true;
                        frm.InvId = long.Parse(InvId);
                        frm.InvType = int.Parse (InvType);
                        frm.ShowDialog();
                        break;
                }
                //string STOREFromID = StoresDGView.SelectedRows[0].Cells["STOREFromID"].Value.ToString();
                //string STOREToID = StoresDGView.SelectedRows[0].Cells["STOREToID"].Value.ToString();
                //string PRODUCTID = StoresDGView.SelectedRows[0].Cells["PRODUCTID"].Value.ToString();
                //string UnitID = StoresDGView.SelectedRows[0].Cells["UnitID"].Value.ToString();
                //string MovmentQty = StoresDGView.SelectedRows[0].Cells["MovmentQty"].Value.ToString();
                //string EnterDate = StoresDGView.SelectedRows[0].Cells["EnterDate"].Value.ToString();
                //ShowReport frm = new ShowReport();
                //frm.MoveId = MoveId;
                //frm.STOREFromID = STOREFromID;
                //frm.STOREToID = STOREToID;
                //frm.PRODUCTID = PRODUCTID;
                //frm.UnitID = UnitID;
                //frm.MovmentQty = MovmentQty;
                //frm.EnterDate = EnterDate;
                //frm.choiceNum = 2;
                //frm.ShowDialog();

            }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    Search();
                }
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
           // Search();
            Microsoft.Office.Tools.Excel.Worksheet sheet   =   wb.Worksheets.Add;

        Microsoft.Office.Tools.Excel .Worksheet 
        Excel.Application objApp;
         Excel._Workbook objBook;
      
         Excel.Workbooks objBooks;
         Excel.Sheets objSheets;
         Excel._Worksheet objSheet;
         Excel.Range range;
 
         try
         {
            // Instantiate Excel and start a new workbook.
            objApp = new Excel.Application();
            objBooks = objApp.Workbooks;
            objBook = objBooks.Add( Missing.Value );
            objSheets = objBook.Worksheets;
            objSheet = (Excel._Worksheet)objSheets.get_Item(1);
 
            //Get the range where the starting cell has the address
            //m_sStartingCell and its dimensions are m_iNumRows x m_iNumCols.
            range = objSheet.get_Range("A1", Missing.Value);
            range = range.get_Resize(5, 5);
 
            if (this.FillWithStrings.Checked == false)
            {
               //Create an array.
               double[,] saRet = new double[5, 5];
 
               //Fill the array.
               for (long iRow = 0; iRow < 5; iRow++)
               {
                  for (long iCol = 0; iCol < 5; iCol++)
                  {
                     //Put a counter in the cell.
                     saRet[iRow, iCol] = iRow * iCol;
                  }
               }
 
               //Set the range value to the array.
               range.set_Value(Missing.Value, saRet );
            }
 
            else
            {
               //Create an array.
               string[,] saRet = new string[5, 5];
 
               //Fill the array.
               for (long iRow = 0; iRow < 5; iRow++)
               {
                  for (long iCol = 0; iCol < 5; iCol++)
                  {
                     //Put the row and column address in the cell.
                     saRet[iRow, iCol] = iRow.ToString() + "|" + iCol.ToString();
                  }
               }
 
               //Set the range value to the array.
               range.set_Value(Missing.Value, saRet );
            }
 
            //Return control of Excel to the user.
            objApp.Visible = true;
            objApp.UserControl = true;
         }
         catch( Exception theException ) 
         {
            String errorMessage;
            errorMessage = "Error: ";
            errorMessage = String.Concat( errorMessage, theException.Message );
            errorMessage = String.Concat( errorMessage, " Line: " );
            errorMessage = String.Concat( errorMessage, theException.Source );
 
            MessageBox.Show( errorMessage, "Error" );
         }
      

        }

        private void enterDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = enterDateDateTimePicker.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtToDate.Text = dateTimePicker1.Value.ToShortDateString();// ToString("dd/MM/yyyy");
        }

     
              

            
    }
}