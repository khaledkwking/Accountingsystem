using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Win32;
using System.Data;
using WeifenLuo.WinFormsUI;
namespace ERPSYS
{
    partial class ChangeUserPassword : DockContent
    {
        public ChangeUserPassword()
        {
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            
        }
 

         private void OK_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == "") 
            {
                errorProvider1.SetError(txtOldPassword, "√œŒ· ﬂ·„… «·„—Ê— «·ﬁœÌ„… ");
            }
        
            if (txtNewPassword.Text == "") 
            {
                errorProvider1.SetError(txtNewPassword, "√œŒ· ﬂ·„… «·„—Ê— «·ÃœÌœ…");
            }
            this.Cursor = Cursors.WaitCursor;
            if (txtOldPassword.Text != "" && txtNewPassword.Text != "") 
            {

                userTableAdapter.FillByUserName(nEWERPDataSet.USER, Messages.CurUser , txtOldPassword.Text);
                if (nEWERPDataSet.USER.Rows.Count > 0) 
                {
                    ((DataRowView)userBindingSource.Current)["Password"]=txtNewPassword.Text ;
                    userBindingSource.EndEdit();
                    userTableAdapter.Update (nEWERPDataSet.USER);
                    GLibrary.MsgSave();

                                    
                }
                else
                {

                    errorProvider1.SetError(txtOldPassword, "Œÿ√ ›Ï ﬂ·„… «·„—Ê— ");
                    errorProvider1.SetError(txtNewPassword, "Œÿ« ›Ï ﬂ·„… «·„—Ê—");
                   
                }
        }
        this.Cursor = Cursors.Default;
        }
        private void UserLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.users' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.nEWERPDataSet.USER );
           ;
        }

        private void UsernameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPassword.Focus();
            }
        }

        private void PasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OK.Focus();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
