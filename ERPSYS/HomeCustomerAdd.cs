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
    public partial class HomeCustomerAdd : DockContent
    {
        private Boolean  EditFlag = true;
        private int LastIden = -1;
        private Boolean  flag=false ;
        public HomeCustomerAdd()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.HomeCustomer' table. You can move, or remove it, as needed.
            this.homeCustomerTableAdapter.Fill(this.nEWERPDataSet.HomeCustomer);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
          

            EditFlag = true;
        }

            

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GLibrary.ValidatetxtBox(errorProvider1, txtName, "√œŒ· «·ﬂÊœ ", "«·„Œ«“‰", true))
                {
                    return;
                }
                else if (!GLibrary.ValidatetxtBox(errorProvider1, txtAddress, "√œŒ· √”„ «·›—⁄ ", "«·„Œ«“‰", true))
                {
                    return;
                }
                this.Validate();
                homeCustomerBindingSource.EndEdit();
                int pos = homeCustomerBindingSource.Position;
                homeCustomerTableAdapter.Update(nEWERPDataSet.HomeCustomer .Rows[pos]);

                GLibrary.MsgSave();
                BranchesDGView.Refresh();
                EditFlag = true;
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                if (Messages.CurLang == Messages.ArabLang)
                {
                    CmdSave.Text = " ⁄œÌ·";

                }
                else if (Messages.CurLang == Messages.EngLang)
                {
                    CmdSave.Text = "ÚıEdit";
                }
                
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex, ref ErrorNo), "«·„Œ«“‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            //LastIden = (int)bRANCHESTableAdapter.GetBranchLastIdent();
            flag = false;
            homeCustomerBindingSource.AddNew();
            flag = true;
            //txtBranchCode.Text = Messages.SysStoresCode + (LastIden + 1).ToString();
           
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = "Õ›Ÿ";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "ÚıSave";
            }
          
           
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (BranchesDGView.SelectedRows.Count > 0) 
            {
                if (GLibrary.MsgCheckDel())
            {
                int index  = BranchesDGView.SelectedRows[0].Index;
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                homeCustomerBindingSource.RemoveCurrent();
                homeCustomerBindingSource.EndEdit();
                homeCustomerTableAdapter.Update(nEWERPDataSet.HomeCustomer );
                if (nEWERPDataSet.BRANCHES .Rows .Count >0)
                {
                    BranchesDGView.Rows[homeCustomerBindingSource.Position].Selected = true; 
                }
                //StoresDGView.Refresh();
                 

            }
            }
        }

        private void StoresDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            BranchesDGView.Rows[e.RowIndex].HeaderCell.Value = (BranchesDGView.RowCount).ToString();
        }

        private void StoresDGView_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        private void StoresDGView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (flag)
            //{
            //    this.Validate();
            //    sTORESBindingSource.EndEdit();
            //    nEWERPDataSet.STORES.AcceptChanges();
            //    CheckRow();
            //}
        }
        private void   CheckRow()
        {
               
            //Public Function CheckChangesAndProceed(ByRef sTORESBindingSource As BindingSource, ByRef SaveFunction As SaveToDatabase) As Boolean
         //DataRow[] dr = nEWERPDataSet.BRANCHES .Select("", "",  DataViewRowState.ModifiedCurrent ); 

         //int irowsChgd = dr.GetUpperBound(0) + 1; 
         //if (BranchesDGView.IsCurrentRowDirty | irowsChgd > 0) 
         //{ 
         //    DialogResult dlgReslt = MessageBox.Show("Save Changes?", 
         //    this.Text + " - The row has unsaved changes",          MessageBoxButtons.YesNo); 
         //    if (dlgReslt == DialogResult.Yes) 
         //    { 
         //        //regexBindingNavigatorSaveItem.PerformClick(); 
         //        //setStatus("Saved change to regex " +      regexNameTextBox.Text); 
         //   } 
         //    else 
         //    { //' problem with cancelling change, cancel edit does not         work 
         //        BranchesDGView.CancelEdit();
         //        nEWERPDataSet.RejectChanges(); 
         //        // causes exception later: 
         //        nEWERPDataSet.BRANCHES.Reset(); 
         //        //setStatus("Change to regex is still pending for " + irowsChgd + " rows. Please reload to forget change"); 
         //    } 
         //} 
         //else if (statusLabel.Text != "Ready") setStatus("Ready"); 

       
      
        }

        private void StoresDGView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

           
        }

        private void StoresDGView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            BranchesDGView.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void StoresDGView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Boolean ErrFlag = false;
            //if (sTORESBindingSource.Count > 0)
            //{

            //    //e.Cancel = true;
            //    // Set the combobox cell datasource to the filtered BindingSource
            //    DataGridViewTextBoxCell STORNAMEtxtBox = (DataGridViewTextBoxCell)StoresDGView["STORNAME", e.RowIndex];
            //    DataGridViewTextBoxCell STORCodetxtBox = (DataGridViewTextBoxCell)StoresDGView["STORECODE", e.RowIndex];

            //    if (STORNAMEtxtBox.Value == null || STORCodetxtBox.Value == null)
            //    {
            //        ErrFlag = true;
            //    }
            //    else if (STORNAMEtxtBox.Value.ToString () == "" || STORCodetxtBox.Value.ToString () == "")
            //    {
            //        ErrFlag = true;
            //    }
            //    else
            //    {
            //        errorProvider1.Clear();
            //    }
            //    if (ErrFlag)
            //    {
            //        StoresDGView.Rows[e.RowIndex].ErrorText = "√œŒ· „Õ ÊÌ«  »Ì«‰«  «·„Œ“‰ »ÿ—Ìﬁ… ’ÕÌÕ… ";
            //        e.Cancel = true;
            //        errorProvider1.SetError(StoresDGView, "√œŒ· „Õ ÊÌ«  «·”‰œ »ÿ—Ìﬁ… ’ÕÌÕ…");
            //        if (STORNAMEtxtBox.Value == null)
            //        {
            //            StoresDGView.Rows[e.RowIndex].Cells["STORNAME"].ErrorText = "„‰ ›÷·ﬂ «”„ «·„Œ“‰ ";
            //        }
            //        else if (STORCodetxtBox.Value == null)
            //        {
            //            StoresDGView.Rows[e.RowIndex].Cells["STORECODE"].ErrorText = "„‰ ›÷·ﬂ ﬂÊœ «·„Œ“‰ ";
            //        }

            //    }
            //}
        }

        private void StoresDGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = false;
            CmdAdd.Enabled = true;
            CmdDel.Enabled = true;

            if (Messages.CurLang == Messages.ArabLang)
            {
                CmdSave.Text = " ⁄œÌ·";

            }
            else if (Messages.CurLang == Messages.EngLang)
            {
                CmdSave.Text = "Edit";
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string SqlStr = "1=1 ";
             if (txtName.Text != "")
            {
                SqlStr = SqlStr + " And CustName like '%" + txtName.Text + "%'";
            }
            if (txtAddress.Text != "")
            {
                SqlStr = SqlStr + " And Address like '%" + txtAddress.Text + "%'";
        
            }
            if (telPhoneTextBox.Text != "")
            {
                SqlStr = SqlStr + " And CustTel like '%" + telPhoneTextBox.Text + "%'";  
            }

        


            homeCustomerBindingSource.Filter = SqlStr;
        }

        private void BranchesDGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (BranchesDGView.SelectedRows.Count > 0)
            {
                if (BranchesDGView.SelectedRows[0].Cells["CustId"].Value != DBNull.Value)
                {
                    string CustId = BranchesDGView.SelectedRows[0].Cells["CustId"].Value.ToString();
                    //string InvType = StoresDGView.SelectedRows[0].Cells["InvType"].Value.ToString();
                    //switch (InvType)
                    //{
                    ////    case "1":
                    //        InvoicePurchaseAdd frmPur = new InvoicePurchaseAdd();
                    //        frmPur.EditFlag = true;
                    //        frmPur.InvId = long.Parse(InvId);
                    //        frmPur.InvType = int.Parse (InvType);
                    //        frmPur.ShowDialog();

                    //        break;
                    //    case "2":
                    InvoiceAdd frm = new InvoiceAdd();
                    frm.EditFlag = true;
                    frm.CustId  = long.Parse(CustId);
                    frm.InvType = 2;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("·« ÌÊÃœ ›Ê« Ì— ·Â–« «·⁄„Ì·", "«·›Ê« Ì—", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                //        break;
                //}
                //}

            }
        }

        
       }
}