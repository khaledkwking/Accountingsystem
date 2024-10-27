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
    public partial class FunctionsAdd : DockContent
    {
        private Boolean  EditFlag = true;
        private int LastIden = -1;
        private Boolean  flag=false ;
        public FunctionsAdd()
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
            // TODO: This line of code loads data into the 'nEWERPDataSet.FUNCTIONS' table. You can move, or remove it, as needed.
            this.fUNCTIONSTableAdapter.Fill(this.nEWERPDataSet.FUNCTIONS);
            // TODO: This line of code loads data into the 'nEWERPDataSet.STORES' table. You can move, or remove it, as needed.
        

            EditFlag = true;
        }

            

        private void CmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!GLibrary.ValidatetxtBox(errorProvider1, txtStoreCode, "√œŒ· «·ﬂÊœ ", "«·„Œ«“‰", true))
                //{
                //    return;
                //}
                //else if (!GLibrary.ValidatetxtBox(errorProvider1, txStoreName, "√œŒ· √”„ «·›—⁄ ", "«·„Œ«“‰", true))
                //{
                //    return;
                //}
                //this.Validate();
                //sTORESBindingSource.EndEdit();
                //int pos = sTORESBindingSource.Position;
                //sTORESTableAdapter.Update(nEWERPDataSet.STORES.Rows[pos]);

                GLibrary.MsgSave();
                StoresDGView.Refresh();
                EditFlag = true;
                CmdAdd.Enabled = true;
                CmdDel.Enabled = true;
                CmdSave.Text = " ⁄œÌ·";
            }
            catch (Exception ex)
            {
                int ErrorNo = -1;
                MessageBox.Show(GLibrary.ExceptionToMessage(ex,ref ErrorNo), "«·„Œ«“‰", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            //LastIden = (int)sTORESTableAdapter.GetStoresLastIdent();
            //flag = false;
            //sTORESBindingSource.AddNew();
            flag = true;
            //txtStoreCode.Text = Messages.SysStoresCode + (LastIden + 1).ToString();
            if (CmbBranchName.Items.Count > 0)
            {
                CmbBranchName.SelectedIndex = 0;
            }
            EditFlag = false;
            CmdAdd.Enabled = false;
            CmdDel.Enabled = false;
            CmdSave.Text = "Õ›Ÿ";
           
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            if (StoresDGView.SelectedRows.Count > 0) 
            {
            if (GLibrary.MsgCheckDel())
            {
                int index = StoresDGView.SelectedRows[0].Index;
                //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                //sTORESBindingSource.RemoveCurrent();
                //sTORESBindingSource.EndEdit();
                //sTORESTableAdapter.Update(nEWERPDataSet.STORES);
                //if (nEWERPDataSet.STORES.Rows .Count >0)
                //{
                //    StoresDGView.Rows[sTORESBindingSource.Position].Selected = true; 
                //}
                ////StoresDGView.Refresh();
                 

            }
            }
        }

        private void StoresDGView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //StoresDGView.Rows[e.RowIndex].HeaderCell.Value = (StoresDGView.RowCount).ToString();
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
         DataRow[] dr = nEWERPDataSet.STORES.Select("", "",  DataViewRowState.ModifiedCurrent ); 

         int irowsChgd = dr.GetUpperBound(0) + 1;
         if (StoresDGView.IsCurrentRowDirty | irowsChgd > 0) 
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
                 StoresDGView.CancelEdit();
                 nEWERPDataSet.RejectChanges(); 
                 // causes exception later: 
                 nEWERPDataSet.STORES.Reset(); 
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
            StoresDGView.Rows[e.RowIndex].ErrorText = String.Empty;
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
            CmdSave.Text = " ⁄œÌ·";
            e.ThrowException = false;
            // A single error may cause secondary calls to this handler, ignore these.
            //if (StoresDGView.Rows[e.RowIndex].ErrorText != String.Empty && null == e.Exception) return;

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

            //StoresDGView.Rows[e.RowIndex].ErrorText = message;

            //if (sinceLast.TotalSeconds < 1.0)

            //    MessageBox.Show(message + "\r\n\r\nPress Ctrl-Z to restore previous value.", "Bad Value");

            //else

            //    SystemSounds.Beep.Play();
        }

       

           

        
       }
}