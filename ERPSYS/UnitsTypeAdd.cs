using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace ERPSYS
{
    public partial class UnitsTypeAdd : Form
    {
       
      
        public UnitsTypeAdd()
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
            //invProductsBindingSource.CancelEdit();
            this.Close  ();
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            
           
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (txtUintDesc.Text  != "")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

     
                      

    }
 
}