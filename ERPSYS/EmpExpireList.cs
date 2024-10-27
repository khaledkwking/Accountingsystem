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
    public partial class EmpExpireList : DockContent
    {
        public int iunitId;
        public String strUnitDesc;

        public EmpExpireList()
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
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.CDE_Currency' table. You can move, or remove it, as needed.
        
                    

        }

         

      

        private void UnitsDGView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int vpos = -1;
            if (UnitsDGView.Rows.Count > 0)
            {

                switch (e.ColumnIndex)
                {
                    case 0:
                        if (UnitsDGView.Rows[e.RowIndex].Cells["ResidenceEndDate"].Value != DBNull.Value)
                        {
                            if (DateTime.Today.AddDays(30) >= DateTime.Parse(UnitsDGView.Rows[e.RowIndex].Cells["ResidenceEndDate"].Value.ToString()))
                            {
                                UnitsDGView.Rows[e.RowIndex].Cells[0].Style.BackColor = Color.Red;
                                UnitsDGView.Rows[e.RowIndex].Cells[0].Value = "√ﬁ«„…";
                            }
                        }
                       
                        break;
                    case 1:
                        if (UnitsDGView.Rows[e.RowIndex].Cells["PassEndDate"].Value != DBNull.Value)
                        {
                            if (DateTime.Today.AddDays(30) >= DateTime.Parse(UnitsDGView.Rows[e.RowIndex].Cells["PassEndDate"].Value.ToString()))
                            {
                                UnitsDGView.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.Pink ;
                                UnitsDGView.Rows[e.RowIndex].Cells[1].Value = "ÃÊ«“";
                            }
                        }
                        break;
                    case 2:
                        if (UnitsDGView.Rows[e.RowIndex].Cells["LicenseEndDate"].Value != DBNull.Value)
                        {
                            if (DateTime.Today.AddDays(30) >= DateTime.Parse(UnitsDGView.Rows[e.RowIndex].Cells["LicenseEndDate"].Value.ToString()))
                            {
                                UnitsDGView.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.Yellow ;
                                UnitsDGView.Rows[e.RowIndex].Cells[2].Value = "—Œ’…";
                            }
                        }
                        break;
                }








            }
        }
            
    }
}