using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ERPSYS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nEWERPDataSet.accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.nEWERPDataSet.accounting);

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ComboBox cb = sender as ComboBox;

            //if (!e.Handled && !cb.DroppedDown && (e.KeyChar != (char)Keys.Return) && (e.KeyChar != (char)Keys.Escape))
            //{
            //    if ((cb.DropDownStyle == ComboBoxStyle.DropDownList) && ((cb.AutoCompleteMode == AutoCompleteMode.Suggest) || (cb.AutoCompleteMode == AutoCompleteMode.SuggestAppend)))
            //    {
            //        cb.DroppedDown = true;
            //    }
            //}


        }

       

        private void Form4_Validated(object sender, EventArgs e)
        {

        }
    }
}