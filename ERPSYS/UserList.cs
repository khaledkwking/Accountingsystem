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
    public partial class UserList : Form
    {
       
       
        public UserList()
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
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_ABSENCE' table. You can move, or remove it, as needed.
            this.pER_EMP_ABSENCETableAdapter.Fill(this.personalDataSet.PER_EMP_ABSENCE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_PENALTY' table. You can move, or remove it, as needed.
            this.cDE_PER_PENALTYTableAdapter.Fill(this.personalDataSet.CDE_PER_PENALTY);
            // TODO: This line of code loads data into the 'personalDataSet.PRL_EMP_LOAN_DETAIL' table. You can move, or remove it, as needed.
            this.pRL_EMP_LOAN_DETAILTableAdapter.Fill(this.personalDataSet.PRL_EMP_LOAN_DETAIL);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_PER_VAC_SUB_CLASS' table. You can move, or remove it, as needed.
            this.cDE_PER_VAC_SUB_CLASSTableAdapter.Fill(this.personalDataSet.CDE_PER_VAC_SUB_CLASS);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_VACATION' table. You can move, or remove it, as needed.
            this.pER_EMP_VACATIONTableAdapter.Fill(this.personalDataSet.PER_EMP_VACATION);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
            this.pER_EMP_DISCOUNTTableAdapter.Fill(this.personalDataSet.PER_EMP_DISCOUNT);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMP_DISCOUNT' table. You can move, or remove it, as needed.
      
            this.cDE_MONTHSTableAdapter.Fill(this.personalDataSet.CDE_MONTHS);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_DEPT' table. You can move, or remove it, as needed.
            this.cDE_DEPTTableAdapter.Fill(this.personalDataSet.CDE_DEPT);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_GOVERNORATE' table. You can move, or remove it, as needed.
            this.cDE_GOVERNORATETableAdapter.Fill(this.personalDataSet.CDE_GOVERNORATE);
            // TODO: This line of code loads data into the 'personalDataSet.CDE_NATIONALITY' table. You can move, or remove it, as needed.
            this.cDE_NATIONALITYTableAdapter.Fill(this.personalDataSet.CDE_NATIONALITY);
            // TODO: This line of code loads data into the 'personalDataSet.PER_EMPLOYEE_DATA' table. You can move, or remove it, as needed.
            this.pER_EMPLOYEE_DATATableAdapter.Fill(this.personalDataSet.PER_EMPLOYEE_DATA);
            // TODO: This line of code loads data into the 'nEWERPDataSet.PER_EMP_DATA' table. You can move, or remove it, as needed.

            CmbEmpGender.DataSource = slGenderTypes.ToDataTable();
            CmbEmpMatStatus.DataSource = slMalStatusType.ToDataTable();
            
            
            if (!EditFlag)
            {
                AddNewEmp();
            }

        }

       
        private void CmdSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            pEREMPLOYEEDATABindingSource.EndEdit();
            pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
           
            //invProductsBindingSource.EndEdit();
            //inv_ProductsTableAdapter.Update(nEWERPDataSet.Inv_Products );
            //GetQid();
            //qidsBindingSource.EndEdit();
            //qidsTableAdapter.Update(nEWERPDataSet.qids);
            //qidsDetailsBindingSource.EndEdit();
            //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails );

            //qidsDetailsBindingSourceWith.EndEdit();
            //qidsDetailsTableAdapter.Update(nEWERPDataSet.qidsDetails);
            GLibrary.MsgSave();
            EditFlag = true;
            
            CmdAdd.Enabled = true ;
            CmdDel.Enabled = true;    
                           
            
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            AddNewEmp();
                  
            
        }

        private void CmdDel_Click(object sender, EventArgs e)
        {
            
                if (GLibrary.MsgCheckDel())
                {
                    
                     //int StoreId  = int.Parse (StoresDGView.SelectedRows[0].Cells["Storeid"].Value.ToString ());
                    pEREMPLOYEEDATABindingSource.RemoveCurrent();
                    pEREMPLOYEEDATABindingSource.EndEdit();
                    pER_EMPLOYEE_DATATableAdapter.Update(personalDataSet.PER_EMPLOYEE_DATA);
                
                 }
            
        }

    
        private void txtStoreCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {          
               
            }
        }
       
       

        private void pEREMPLOYEEDATABindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (pEREMPLOYEEDATABindingSource.Count > 0)
            {

                if (pEREMPLOYEEDATABindingSource.Count == 1 && ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"].ToString() == "0")
                {
                    ((DataRowView)pEREMPLOYEEDATABindingSource.Current)["EMP_CODE"] = (Int64)(LastIden) + 1;
                }
              
            }
        }

       

      

      
    

    
         

    }
 
}
//Public Class frSecurity
//    Private objFunctions As New Acement.Concrete.FUNCTIONS
//    Private objUsers As New Acement.Concrete.USER
//    Private objUserFunction As New Acement.Concrete.USER_FUNCTION
//    Private intUserID As Integer
//    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

//        Me.Close()
//    End Sub
//    Private Sub LoadUsers()
//        intUserID = Nothing
//        objUsers.LoadAll()
//        UsersDGView.DataSource = objUsers.DefaultView
//    End Sub
//    Private Sub LoadFunctions()
//        objFunctions.LoadAll()
//        FunctionsDGView.DataSource = objFunctions.DefaultView
//    End Sub

//    Private Sub frmSecurity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
//        LoadFunctions()
//        LoadUsers()

//    End Sub


//    Private Sub UsersDGView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersDGView.SelectionChanged
//        'If (intUserID <> Nothing) Then
//        '    SaveUserFunctions()
//        'End If
//        If (UsersDGView.SelectedRows.Count > 0) Then
//            Dim intUserType As Integer
//            If (Not UsersDGView.SelectedRows(0).IsNewRow()) Then
//                intUserType = UsersDGView.SelectedRows(0).Cells("USER_TYPE").Value
//                intUserID = UsersDGView.SelectedRows(0).Cells("ID").Value
//                Select Case intUserType
//                    Case 1
//                        RadioBtnUser.Checked = True
//                    Case 2
//                        RadioBtnManager.Checked = True
//                    Case 3
//                        RadioBtnAdmin.Checked = True
//                End Select
//                objUserFunction.Where.USER_ID.Value = intUserID
//                objUserFunction.Query.Load()
//                Dim FunId As Integer
//                Dim FunArray As ArrayList = New ArrayList()
//                For Each s As DataRowView In objUserFunction.DefaultView
//                    FunId = s("FUNCTION_ID")
//                    FunArray.Add(FunId)
//                Next
//                UpdateUserFunctions(FunArray)
//            End If
//        End If
//    End Sub
//    Private Sub UpdateUserFunctions(ByVal FunArray As ArrayList)
//        Dim i As Integer
//        'Dim FunStat As Integer
//        Dim FunId As Integer
//        For i = 0 To FunctionsDGView.Rows.Count - 1
//            FunId = FunctionsDGView.Rows(i).Cells("FunID").Value
//            If FunArray.Contains(FunId) Then
//                FunctionsDGView.Rows(i).Cells("FunStat").Value = True
//            Else
//                FunctionsDGView.Rows(i).Cells("FunStat").Value = False
//            End If

//        Next
//    End Sub

//    Private Sub FunctionsDGView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles FunctionsDGView.CellFormatting

//    End Sub

//    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
//        SaveUserFunctions()
//        MessageBox.Show(Messages.SaveMesg, "ÇáãÓÊÎÏãíä", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
//    End Sub

//    Private Sub FunctionsDGView_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FunctionsDGView.CurrentCellDirtyStateChanged
//        'If FunctionsDGView.IsCurrentCellDirty Then
//        '    FunctionsDGView.CommitEdit(DataGridViewDataErrorContexts.Commit)
//        'End If
//    End Sub

//    Private Sub FunctionsDGView_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FunctionsDGView.CellValueChanged

//        'If FunctionsDGView.Columns(e.ColumnIndex).Name = "FunStat" Then
//        '    Dim FunId As Integer

//        '    Dim checkCell As DataGridViewCheckBoxCell = CType(FunctionsDGView.Rows(e.RowIndex).Cells("FunStat"), DataGridViewCheckBoxCell)
//        '    FunId = FunctionsDGView.Rows(e.RowIndex).Cells("FunID").Value
//        '    'objUserFunction
//        '    FunctionsDGView.Invalidate()
//        'End If
//    End Sub
//    Private Sub SaveUserFunctions()
//        Dim i As Integer
//        Dim FunID As Integer
//        For i = 0 To FunctionsDGView.Rows.Count - 1
//            FunID = FunctionsDGView.Rows(i).Cells("FunID").Value
//            If (FunctionsDGView.Rows(i).Cells("FunStat").Value = True) Then
//                objUserFunction.Filter = "FUNCTION_ID =" & FunID.ToString()
//                If (objUserFunction.RowCount = 0) Then 'user not found
//                    objUserFunction.AddNew() ' add new function
//                    objUserFunction.FUNCTION_ID = FunID
//                    objUserFunction.USER_ID = intUserID
//                    objUserFunction.Save()
//                End If
//            Else 'equal false
//                objUserFunction.Filter = "FUNCTION_ID =" & FunID.ToString()
//                If (objUserFunction.RowCount > 0) Then
//                    objUserFunction.MarkAsDeleted()
//                    objUserFunction.Save()
//                End If

//            End If

//        Next

//    End Sub

//    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
//        Dim frm As New frmAddNewUser
//        frm.userId = Nothing
//        If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
//            LoadUsers()
//        End If

//    End Sub

//    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
//        If (UsersDGView.SelectedRows.Count > 0) Then
//            Dim frm As New frmAddNewUser
//            frm.userId = UsersDGView.SelectedRows(0).Cells("ID").Value
//            If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
//                LoadUsers()
//            End If
//        End If
//    End Sub

//    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
//        If (MsgCheckDel()) Then
//            If (UsersDGView.SelectedRows.Count > 0) Then
//                Dim userId As Integer = UsersDGView.SelectedRows(0).Cells("ID").Value
//                If objUsers.RowCount > 0 Then
//                    objUsers.Rewind()  'move to first record 
//                    Do While objUsers.MoveNext
//                        If (objUsers.ID = userId) Then
//                            Dim objRetFunctions As New Acement.Concrete.USER_FUNCTION
//                            objRetFunctions.Where.USER_ID.Value = userId
//                            objRetFunctions.Query.Load()
//                            objRetFunctions.DeleteAll()
//                            objRetFunctions.Save()
//                            objUsers.MarkAsDeleted()
//                            objUsers.Save()
//                            Exit Do
//                        End If
//                    Loop
//                End If

//            End If
//        End If
//    End Sub

//    Private Sub frSecurity_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
//        SecFlag = 0
//    End Sub

//    Private Sub UsersDGView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsersDGView.CellContentClick

//    End Sub

//    Private Sub UsersDGView_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles UsersDGView.CellFormatting
//        If (Not IsDBNull(UsersDGView.Rows(e.RowIndex).Cells("AdaraId").Value)) Then
//            Dim AdaraId As Integer = UsersDGView.Rows(e.RowIndex).Cells("AdaraId").Value
//            Dim objSetup As New Acement.Concrete.Setup
//            objSetup.LoadByPrimaryKey(AdaraId)
//            UsersDGView.Rows(e.RowIndex).Cells("AdaraDesc").Value = objSetup.AdaraDesc
//        End If
//    End Sub

//    Private Sub frSecurity_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
//        'GroupBox3.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
//        'GroupBox2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
//        'GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
//        'BtnSave.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
//        'btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)

//        'GroupBox1.Size = New System.Drawing.Size(Me.Size.Width * Me.Width / GroupBox1.Width, GroupBox1.Size.Height)



//    End Sub

//    Private Sub frSecurity_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
//        e.Cancel = True
//        '  But hide it from the user.
//        Me.Hide()
//    End Sub
//End Class