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
    public partial class BranchesAdd : DockContent
    {
        private Boolean  EditFlag = true;
        private int LastIden = -1;
        private Boolean  flag=false ;
        public BranchesAdd()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'nEWERPDataSet.BRANCHES' table. You can move, or remove it, as needed.
            this.bRANCHESTableAdapter.Fill(this.nEWERPDataSet.BRANCHES);

            EditFlag = true;
            accountingBindingSource.Filter = "MainNode=0";
        }

            

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GLibrary.ValidatetxtBox(errorProvider1, txtBranchCode, "√œŒ· «·ﬂÊœ ", "«·„Œ«“‰", true))
                {
                    return;
                }
                else if (!GLibrary.ValidatetxtBox(errorProvider1, txBranchName, "√œŒ· √”„ «·›—⁄ ", "«·„Œ«“‰", true))
                {
                    return;
                }
                this.Validate();
                bRANCHESBindingSource.EndEdit();
                int pos = bRANCHESBindingSource.Position;
                bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES.Rows[pos]);

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
            bRANCHESBindingSource.AddNew();
            flag = true;
            //txtBranchCode.Text = Messages.SysStoresCode + (LastIden + 1).ToString();
           
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            CmbKeyNet.SelectedValue = -1;
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
                bRANCHESBindingSource.RemoveCurrent();
                bRANCHESBindingSource.EndEdit();
                bRANCHESTableAdapter.Update(nEWERPDataSet.BRANCHES );
                if (nEWERPDataSet.BRANCHES .Rows .Count >0)
                {
                    BranchesDGView.Rows[bRANCHESBindingSource.Position].Selected = true; 
                }
                //StoresDGView.Refresh();
                 

            }
            }
        }

        private void StoresDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //BranchesDGView.Rows[e.RowIndex].HeaderCell.Value = (BranchesDGView.RowCount).ToString();
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
         DataRow[] dr = nEWERPDataSet.BRANCHES .Select("", "",  DataViewRowState.ModifiedCurrent ); 

         int irowsChgd = dr.GetUpperBound(0) + 1; 
         if (BranchesDGView.IsCurrentRowDirty | irowsChgd > 0) 
         { 
             DialogResult dlgReslt = MessageBox.Show("Save Changes?", 
             this.Text + " - The row has unsaved changes",          MessageBoxButtons.YesNo); 
             if (dlgReslt == DialogResult.Yes) 
             { 
                 //regexBindingNavigatorSaveItem.PerformClick(); 
                 //setStatus("Saved change to regex " +      regexNameTextBox.Text); 
            } 
             else 
             { //' problem with cancelling change, cancel edit does not         work 
                 BranchesDGView.CancelEdit();
                 nEWERPDataSet.RejectChanges(); 
                 // causes exception later: 
                 nEWERPDataSet.BRANCHES.Reset(); 
                 //setStatus("Change to regex is still pending for " + irowsChgd + " rows. Please reload to forget change"); 
             } 
         } 
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
                CmdSave.Text = "ÚıEdit";
            }
           
        }

       

           

        
       }
}