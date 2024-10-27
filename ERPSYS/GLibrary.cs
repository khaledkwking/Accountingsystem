using System;
using System.Collections.Generic;
using System.Text;
using System.Windows .Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections ;
namespace ERPSYS
{
    public class StaticList : System.Collections.Hashtable
    {
        private DataTable _DataTable;

        public StaticList(string[,] strArr)
        {
            if (strArr.GetLength(1) != 2) return;

            _DataTable = new DataTable();
            _DataTable.Columns.Add("ID", typeof(string));
            _DataTable.Columns.Add("Desc", typeof(string));

            for (int i = strArr.GetLowerBound(0); i <= strArr.GetUpperBound(0); i++)
            {
                try
                {
                    this.Add(strArr[i, 0], strArr[i, 1]);
                    _DataTable.Rows.Add(new object[] { strArr[i, 0], strArr[i, 1] });
                }
                catch { }
            }
        }

        public DataTable ToDataTable()
        {
            return _DataTable;
        }
    }

    class GLibrary
    {
        public static string[,] strarrPssportType = new string[,] { { "1", "��� ���" }, { "2", "��� ����" }, { "3", "�������" }, { "4", "��� ����" } };
        public static string[,] strarrFormsTypes = new string[,] { { "1", "�����" }, { "2", "�����" }, { "3", "�����" }, { "4", "�����" }, { "5", "����� �����" }, { "6", "��� �����" }, { "7", "�����" } };

        public static string[,] strarrLicenseTypes = new string[,] { { "1", "����" }, { "2", "����" } };
        public static string[,] strarrContractType = new string[,] { { "1", "����" }, { "2", "����" } };
        public static string[,] strarrStatusType = new string[,] { { "1", "���� ��� ������" }, { "2", "�����" }, { "2", "������" } };
        public static string[,] strarrReligionTypes = new string[,] { { "1", "����" }, { "2", "�����" } };

        public static string[,] strarrGetTypes = new string[,] { { "1", "������ �������" }, { "2", "������� ������" }, { "3", "��� ���" } };
        public static string[,] strarrOffersTypes = new string[,] { { "1", "�����" }, { "2", "����� ���� ����" }, { "3", "��� �����" } };
        public static string[,] strarrPriceRules = new string[,] { { "1", "�����" }, { "2", "������" } };
        public static string[,] strarrItemSorted = new string[,] { { "1", "���� �����" }, { "2", "��� �����" }, { "3", "��� �����" } };

        public static string[,] strarrBillType = new string[,] { { "1", "���" }, { "2", "���� / �� ��" }, { "3", "������ �������" } };
        public static string[,] strarrBillTypeEng = new string[,] { { "1", "Credit" }, { "2", "Cash" }, { "3", "Admeasure" } };

        public static string[,] strarrPaymentTypes = new string[,] { { "1", "����" }, { "2", "������" }, { "3", "����" } };

        public static string[,] strarrAccountTypes = new string[,] { { "1", "����" }, { "3", "����" }, { "4", "����" }, { "5", "����" }, { "6", "�����" } };
        public static string[,] strarrEngAccountTypes = new string[,] { { "1", "Account" }, { "3", "Customer" }, { "4", "Supplier" }, { "5", "Employee" }, { "6", "Commisser" } };

        public static string[,] strarrQidTypes = new string[,] { { "1", "����" }, { "2", "����" }, { "3", "������ ������" }, { "4", "������ �������" }, { "5", "����" }, { "6", "���" }, { "7", "���" }, { "8", "������� ��������" }, { "9", "������� ���������" }, { "10", "�����" }, { "11", "�������" }, { "12", "����" } };
        public static string[,] strarrRefBalanceTypes = new string[,] { { "1", "�����" }, { "2", "������" }, { "3", "������ ������" } };

        public static string[,] strarrGenderTypes = new string[,] { { "1", "���" }, { "2", "����" } };
        public static string[,] strarrMalStatusType = new string[,] { { "1", "�����" }, { "2", "�����" }, { "3", "����" } };
   

        public static string[,] strarrInterfaceType = new string[,] { { "1", "Arabic" }, { "2", "English" } };

        public static string[,] strarrInvType = new string[,] { { "1", "�������" }, { "2", "������" } , { "3", "����� ������" }, { "4", "����� �������" } };

        public static string[,] strarrProductTypes = new string[,] { { "1", "�����" }, { "2", "�����" }, { "3", "����" }, { "4", "������" } };

        public static string[,] strarrAttendanceType = new string[,] { { "1", "��� �����" }, { "2", "��� ���" }, { "3", "������" }, { "3", "��� ����" } };
        public static string[,] strarrCalSalaryType = new string[,] { { "1", "��� ������" }, { "2", "��� �������� �� �����" } };
        public static string[,] strarrInvPaymentMethodTypeEng = new string[,] { { "1", "KeyNet" }, { "2", "Link" }, { "3", "Cheque" } };

        public static Boolean IsDate(string anyString)
        {
            if (anyString == null)
            {
                anyString = "";
            }
            if (anyString.Length > 0)
            {
                DateTime dummyOut;
                return DateTime.TryParse(anyString, out dummyOut);
            }
            else
            {
                return false;
            }
        }
        public static Boolean IsNumeric(string anyString)
        {
            if (anyString == null)
            {
                anyString = "";
            }
            if (anyString.Length > 0)
            {
                double dummyOut = new Double();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return Double.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
            }
            else
            {
                return false;
            }
        }
        public static Boolean MsgCheckDel()
        {
            DialogResult ret;
            ret = GLibrary.ShowMsgCheck("��� ����", Messages.CheckDel, "DELETING", Messages.CheckDelE, Messages.CurLang);
            //ret = MessageBox.Show(Messages.CheckDel, "��� ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (ret == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static  void ShowMsg(string ArbTitleMsg, string ArabMsg, string EngTitleMsg, string EngMsg, string  ArabFlag)
        {
           
            if (ArabFlag==Messages.ArabLang)
            {
                 MessageBox.Show(ArabMsg,ArbTitleMsg, MessageBoxButtons.OK , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                MessageBox.Show(EngMsg,EngTitleMsg, MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
           
        }
        public static DialogResult ShowMsgCheck(string ArbTitleMsg, string ArabMsg, string EngTitleMsg, string EngMsg, string ArabFlag)
        {
            DialogResult ret;
            if (ArabFlag == Messages.ArabLang)
            {
                ret = MessageBox.Show(ArabMsg,ArbTitleMsg,  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                ret = MessageBox.Show(EngMsg,EngTitleMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            return ret;
        }
        public static Boolean MsgCheckCancel()
        {
            DialogResult ret;
            ret = GLibrary.ShowMsgCheck("��� �����", Messages.CheckCancelMsg, "Saving", Messages.CheckCancelMsgE, Messages.CurLang);

           // ret = MessageBox.Show(Messages.CheckCancelMsg, "����� ���������", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            if (ret == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean MsgCheckSave(Boolean DelFlag)
        {
            DialogResult ret;
            if (!DelFlag)
            {
               ret= GLibrary.ShowMsgCheck("��� �����",Messages.CheckSaveMsg, "Saving", Messages.CheckSaveMsgE, Messages.CurLang);
               // ret = MessageBox.Show(Messages.CheckSaveMsg, "��� ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                ret = DialogResult.Yes;
            }

            if (ret == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void MsgSave()
        {
            DialogResult ret;
             GLibrary.ShowMsg("��� �����",Messages.SaveMesg,  "Saving", Messages.SaveMesgE, Messages.CurLang);
            //ret = MessageBox.Show(Messages.SaveMesg, "��� �����", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

        }
        public static void MsgDel()
        {
            DialogResult ret;
            GLibrary.ShowMsg("������", Messages.AccountdelRightMesg, "Account", Messages.AccountdelRightMesgE, Messages.CurLang);
            //ret = MessageBox.Show(Messages.SaveMesg, "��� �����", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

        }
        public static Boolean ValidateComboBox(ErrorProvider ErrorProvider1, ComboBox txtboxCntrl, string msg, string title, Boolean force)
        {
            if (txtboxCntrl.SelectedValue == null)
            {
                ErrorProvider1.SetError(txtboxCntrl, msg);
                if (force)
                {
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxCntrl.Focus();
                    return false;
                }
                else
                {
                    ErrorProvider1.SetError(txtboxCntrl, String.Empty);
                    txtboxCntrl.Focus();
                    return false;
                }
            }
            return true;
        }
        public static Boolean ValidatetxtBox(ErrorProvider ErrorProvider1, TextBox txtboxCntrl, string msg, string title, Boolean force)
        {
            if (txtboxCntrl.Text.Length == 0)
            {
                ErrorProvider1.SetError(txtboxCntrl, msg);
                if (force)
                {
                    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtboxCntrl.Focus();
                    return false;
                }
                else
                {
                    ErrorProvider1.SetError(txtboxCntrl, String.Empty);
                    txtboxCntrl.Focus();
                    return false;
                }
            }
            return true;
        }
        //Function ValidatetxtBox(ByVal ErrorProvider1 As ErrorProvider, ByVal txtboxCntrl As TextBox, ByVal msg As String, ByVal title As String, ByVal force As Boolean) As Boolean
        //    If txtboxCntrl.Text.Length = 0 Then
        //        ErrorProvider1.SetError(txtboxCntrl, msg)
        //        If force Then
        //            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        //        End If
        //        Return False
        //    Else
        //        ErrorProvider1.SetError(txtboxCntrl, String.Empty)
        //        Return True
        //    End If
        //End Function
        public static string ExceptionToMessage(Exception ex, ref int ErrorNo)
        {
            ErrorNo = 0;
            string sMessage = "��� ��� ����� ������� :\n";

            if (ex is SqlException || ex.InnerException is SqlException)
            {
                SqlException exSQL;

                if (ex is SqlException)
                    exSQL = (SqlException)ex;
                else
                    exSQL = (SqlException)ex.InnerException;

                switch (exSQL.Number)
                {
                    case 515:	//Column does not allow Nulls
                        sMessage += "��� ������ �� ���� ����� ��� ����.";
                        break;
                    case 547:	//Column Foreign Key Constraint
                        sMessage += "��� ������� ������ ���� ������ ��������.";
                        break;
                    case 2601:	//Duplicate Key Row due to Unique Index
                        sMessage += "��� ������� ������ ���� ��� ����� ��� ������.";
                        break;
                    case 2627:	//Violation of UNIQUE KEY constraint
                        sMessage += "��� ����� ���� �� ���� ���� ��� ���.";
                        break;
                    default:
                        sMessage += exSQL.Message;
                        break;
                }
                ErrorNo = exSQL.Number;
            }
            else
                sMessage = ex.Message;

            return sMessage;
            //			return ERP.Web.UI.Common.AppError.FormatErrorMsg( ex );
        }
        public static string FigureInWordsNumType(double Num, int QtyTyp)
        {
            string functionReturnValue = null;

            ERPSYS.NEWERPDataSetTableAdapters.FIGURESTableAdapter FIGURESTableAdapter = new ERPSYS.NEWERPDataSetTableAdapters.FIGURESTableAdapter();
            ERPSYS.NEWERPDataSet IntrentDataSet;
            //Public CustBindingSource As System.Windows.Forms.BindingSource 
            ERPSYS.NEWERPDataSet.FIGURESDataTable objFigures = new ERPSYS.NEWERPDataSet.FIGURESDataTable();
            FIGURESTableAdapter.Fill(objFigures);
            ERPSYS.NEWERPDataSet.FIGURESRow FiguresRow;

            string Wa;
            string Wa2;
            string NumStr;
            string NumTxT;
            string GroupTxT = "";
            string HundredTxt;
            string TenUnitTxt;
            string QtyTxt1 = "";
            int GroupCtr;
            int GroupNum;
            int SubGroupNum;
            int HundredNum=0;
            int TenUnitNum=0;
            int StartPos;

            //Static MyDB As Database, MyRecordset As Recordset 
            //MyDB = DBEngine.Workspaces(0).Databases(0) 
            //MyRecordset = MyDB.OpenRecordset("Figures", DB_OPEN_TABLE) 
            //MyRecordset.Index = "PrimaryKey" 

            //**297************************************************ 
            //Select Case QtyTyp 
            // Case Is = 1 
            // QtyTxt1 = " ����� " 
            // QtyTxt2 = " ������� " 
            // QtyTxt3 = " ������ " 
            // QtyTxt4 = "���� �� ���� �������" 
            // Case Is = 2 
            // QtyTxt1 = " ��� ����� " 
            // QtyTxt2 = " ����� ����� " 
            // QtyTxt3 = " ����� ����� " 
            // QtyTxt4 = "���� �� ���� �� �������" 
            // Case Is = 3 
            // QtyTxt1 = " �� ���� " 
            // QtyTxt2 = " ���� ���� " 
            // QtyTxt3 = " ����� ���� " 
            // QtyTxt4 = "���� �� ���� �� ������" 
            // Case Is = 4 
            // QtyTxt1 = " ������ ����� " 
            // QtyTxt2 = " �������� ������� " 
            // QtyTxt3 = " ����� ���� " 
            // QtyTxt4 = "���� �� ���� �� ������� ������" 
            //End Select 
            //**297************************************************297** 
            //objFigures.LoadAll() 
            Wa = "";
            Wa2 = "";
            NumTxT = "";
            NumStr = String.Format("{0:+000,000,000,000.000}", Num);
            StartPos = 1;


            for (GroupCtr = 1; GroupCtr <= 5; GroupCtr++)
            {
            mark:
                GroupNum = Convert.ToInt32(NumStr.Substring(StartPos, 3));
                SubGroupNum = Convert.ToInt32(NumStr.Substring(StartPos + 1, 2));
                HundredNum = Convert.ToInt32(NumStr.Substring(StartPos, 1) + "00");
                TenUnitNum = Convert.ToInt32(NumStr.Substring(StartPos + 1, 2));
                TenUnitTxt = "";
                HundredTxt = "";
                StartPos = StartPos + 4;
                if (GroupNum == 0)
                {
                    GroupCtr++;
                    if (GroupCtr > 5) break;
                    //return GroupCtr;
                    goto mark;

                    //goto NextGroupCtr; 
                }
                switch (GroupNum)
                {
                    // Select Case SubGroupNum 
                    case 1: // ERROR: Case labels with binary operators are unsupported : Equality 1: 
                        switch (GroupCtr)
                        {
                            case 1:
                                GroupTxT = " ����� ";
                                break;
                            case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                                GroupTxT = " ����� ";
                                break;
                            case 3: // ERROR: Case labels with binary operators are unsupported : Equality 3: 
                                GroupTxT = " ��� ";
                                break;
                            case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                                GroupTxT = "����";
                                break;
                            case 5:// ERROR: Case labels with binary operators are unsupported : Equality 5: 
                                break;
                               // GroupTxT = " ��� ";
                        }
                        goto BuildText;
                        break;
                    case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                        switch (GroupCtr)
                        {
                            case 1:// ERROR: Case labels with binary operators are unsupported : Equality 1: 
                                GroupTxT = " ������� ";
                                break;
                            case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                                GroupTxT = " ������� ";
                                break;
                            case 3:// ERROR: Case labels with binary operators are unsupported : Equality 3: 
                                GroupTxT = " ����� ";
                                break;
                            case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                                GroupTxT = "����� ";
                                break;
                            case 5:// ERROR: Case labels with binary operators are unsupported : Equality 5: 
                                break;
                            // GroupTxT = " ��� " 
                        }
                        goto BuildText;
                        break;
                }

                //297 If GroupNum > 2 And GroupNum < 11 Then 
                if (SubGroupNum > 2 & SubGroupNum < 11)
                {
                    switch (GroupCtr)
                    {
                        case 1:// ERROR: Case labels with binary operators are unsupported : Equality 1: 
                            GroupTxT = " ������ ";
                            break;
                        case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                            GroupTxT = " ������ ";
                            break;
                        case 3:// ERROR: Case labels with binary operators are unsupported : Equality 3: 
                            GroupTxT = " ���� ";
                            break;
                        case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                            break;
                        //297 GroupTxT = QtyTxt3 
                        case 5:// ERROR: Case labels with binary operators are unsupported : Equality 5: 
                            break;
                        // GroupTxT = " ��� " 
                    }
                }
                else
                {
                    switch (GroupCtr)
                    {
                        case 1:// ERROR: Case labels with binary operators are unsupported : Equality 1: 
                            GroupTxT = " ����� ";
                            break;
                        case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                            GroupTxT = " ����� ";
                            break;
                        case 3:// ERROR: Case labels with binary operators are unsupported : Equality 3: 
                            GroupTxT = " ��� ";
                            break;
                        case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                            break;
                        //297 GroupTxT = QtyTxt1 
                        case 5:// ERROR: Case labels with binary operators are unsupported : Equality 5: 
                            break;
                        // GroupTxT = " ��� " 
                    }
                }
                if (TenUnitNum > 0)
                {
                    FiguresRow = objFigures.FindByFigure(short.Parse(TenUnitNum.ToString()));
                    //objFigures.Filter = "Figure=" & TenUnitNum 
                    //MyRecordset.Seek("=", TenUnitNum) 
                    //If MyRecordset.NoMatch Then 
                    if (FiguresRow == null)
                    {
                        TenUnitTxt = "***ERROR***";
                    }
                    else
                    {
                        TenUnitTxt = FiguresRow.FigureInWords;
                    }
                }
                //objFigures.Filter = "" 

                if (HundredNum > 0)
                {
                    FiguresRow = objFigures.FindByFigure(short.Parse(HundredNum.ToString()));
                    //objFigures.Filter = "Figure=" & HundredNum 
                    //MyRecordset.Seek("=", HundredNum) 
                    //If MyRecordset.NoMatch Then 
                    if (FiguresRow == null)
                    {
                        HundredTxt = "***ERROR***";
                    }
                    else
                    {
                        HundredTxt = FiguresRow.FigureInWords;
                    }
                }
            BuildText:

                if (TenUnitNum > 0 & HundredNum > 0)
                {
                    Wa2 = " � ";
                }
                else
                {
                    Wa2 = " ";
                }

                NumTxT = NumTxT + Wa + HundredTxt + Wa2 + TenUnitTxt + " " + GroupTxT;
                //if (HundredNum > 0)
              
                 Wa = "����� �  ";
               
                GroupTxT = "";

                //NextGroupCtr: 

            }
            //MyRecordset.Close() 

            if (NumTxT == " ")
            {
                switch (QtyTyp)
                {
                    case 1:// ERROR: Case labels with binary operators are unsupported : Equality 1: 
                        QtyTxt1 = "���� �� ���� �������";
                        break;
                    case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                        QtyTxt1 = "���� �� ���� �� �������";
                        break;
                    case 3:// ERROR: Case labels with binary operators are unsupported : Equality 3: 
                        QtyTxt1 = "���� �� ���� �� ������";
                        break;
                    case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                        QtyTxt1 = "���� �� ���� �� ������� ������";
                        break;
                }
                functionReturnValue = NumTxT + QtyTxt1;
            }
            else
            {
                if (HundredNum > 0 || TenUnitNum > 0)
                {
                    Wa2 = " ���";
                }
                else
                {
                    Wa2 = " ����� �����";
                   
                }
                NumTxT = NumTxT + Wa2;
                switch (QtyTyp)
                {
                    case 1:// ERROR: Case labels with binary operators are unsupported : Equality 1: 
                        QtyTxt1 = "  ��� �����"; //" ����� ����� ��� �����";
                        break;
                    case 2:// ERROR: Case labels with binary operators are unsupported : Equality 2: 
                        QtyTxt1 = " ��� ����� ��� �����";
                        break;
                    case 3:// ERROR: Case labels with binary operators are unsupported : Equality 3: 
                        QtyTxt1 = " �� ���� ��� �����";
                        break;
                    case 4:// ERROR: Case labels with binary operators are unsupported : Equality 4: 
                        QtyTxt1 = " ����� ���� ��� �����";
                        break;
                }
                functionReturnValue = NumTxT + QtyTxt1;
            }
            return functionReturnValue;

        }
        public static void SetFrm(System.Windows.Forms.Form frm, string Lang)
        {
            if(Lang==Messages.EngLang )
            {
                    frm.RightToLeft = RightToLeft.No;
                    frm.RightToLeftLayout = false;
                   
            }
            else if (Lang == Messages.ArabLang)
            {
                frm.RightToLeft = RightToLeft.Yes;
                //frm.RightToLeftLayout =true ;
            }
        }
       
    }
      public  class Messages
      {
          //Accounts
          public static Boolean[] SalInvPrim = new Boolean[5] { true, true, true, true, true };
          public static Boolean [] PurInvPrim = new Boolean[5] { true, true, true, true, true };

          public static Boolean[] SalQidPrim = new Boolean[5] { true, true, true, true, true };
          public static Boolean[] SalQidInPrim = new Boolean[5] { true, true, true, true, true };
          public static Boolean[] SalQidOutPrim = new Boolean[5] { true, true, true, true, true };

          public static int MovmentProfitsAccid;
          public static int BalanceAccid=4;
          public static int ProfitAccid=2;
          public static int CommercingAccid = 2;
          public static int Osoalaccid=5;
          public static int Khosomaccid=134;

          public static int Budgetaccid = 4;
          public static int Incomeaccid = 136;

          public static  int boxAccid; // ���� �������
          public static int accountidMainBox;
          public static  int bankaccid;// ���� �����
          public static int custaccid;
          public static int suppaccid;
          public static int salesaccid;
          public static int salesAgalaccid;
          public static int purchaseaccid;
          public static int purchaseAgalaccid;

          public static int Discountaccid;
          public static int PurReorderaccid;
          public static int SalReorderaccid;
          public static int PurReorderAgalaccid;
          public static int SalReorderAgalaccid;
          public static int Paymentsaccid;

          public static int MainPurchaseaccid;
          public static int MainSalesAccid;

          public static int purchasePayaccid;
          public static int ProfitLossAccId=2;
          public static int OsalAccId;
          public static int DeductAccId;

          public static int Visaaccid;
          public static int Masteraccid;
          public static int KeyNetaccid;
          public static int Otheraccid;

          public static int VisaComaccid;
          public static int MasterComaccid;
          public static int KeyNetComaccid;
          public static int OtherComaccid;

          public static int PosBoxaccid;
          public static int PosBankaccid;
          public static int PosSalesaccid;
          public static int PosPruchaseaccid;
          public static int PosAgalaccid;
          public static int PosPurAgalaccid;
          public static int SalesTakastaccid;
          public static int StockAccId=0;
          public static int CostSalesProductAccId=0;
          public static double KeyNetComPercentage = 0.0;

          //System Codes
          public static string BasicDBName = "NEWERP";
          public static string SysSupCode;
          public static string SysCustCode;
          public static string SysinvSaleCode;
          public static string SysInvpurchasesCode;
          public static string SysStoresCode;
          public static string SysACCountCode;
          public static string SysQid;
          public static string SysQidIn;
          public static string SysQidOut;
          public static string BranchCode;
          public static string CurLang = "";

          public static string CurUser="";
          public static string CurUserId="";
          public static string CurBranch = "";
          public static string CurBranchName = "";
          public static string CurName = "";

          public static int Usertype=0;
          public static string BackGround = "";
          public static readonly string SupFlag = "1";
          public static readonly string CustFlag = "2";
          public static readonly string CustSupFlag = "3";

          public  const  int InvpurchasesFlag = 1;
          public  const int InvSalesFlag = 2;
          public const int InvSalesReturnFlag = 3;
          public const int InvpurchasesReturnFlag = 4;

          public static readonly string qidTypeId = "1";
          public static readonly string qidOutTypeId = "2";
          public static readonly string qidInTypeId = "3";
          public static string InterfaceType = "1";
          public static int DayHours =8;
          public static int AdminUser = 1;
          public static int DayInYear = 365;


          public static int AccountFlag = 0;
          public static int ProductFlag = 0;
          public static int StockFlag = 0;
          public static int CostcenterFlag = 0;

          public  static readonly string ClickToAdd  = "���� �������";
          public  static readonly  string stringClickToGoBack  = "���� ������";
        //Add, Edit
          public  static readonly string ClickToSave  = "���� ���� ������";
          public  static readonly string ClickToCancelAdd  = "���� ������ ����� �������";
        //Edit
          public  static readonly  string ClickToDelete  = "���� ���� ������";
          public  static readonly string ClickToCancelEdit  = "���� ������ ����� �������";

        //'------------ Error --------------------------------------------------------
          public  static readonly string ErrRowAlreadyExists  = "��� ������ ���� �� ���";
          public  static readonly string ErrUnableToLoadData  = "�� ��� ������ ��� ������";
          public  static readonly string printFound  = "�� ����� ��� ��������� �� ���";
       // '------------- Info --------------------------------------------------------
          public static readonly string CheckInvPrintMsg = "�� ���� ���� �������� ��� ������ �������";

          public static readonly string CheckProdcutAddMsg = "����� ��� ����� �� ���� ����� �����";
          public static readonly string CheckProdcutCodeMsg = "����� ��� ����� ";
          public static readonly string CustNotFoundMsg = "��� ������ ��� ����� �� ���� ������";

          public  static readonly string CheckDel = "�� ���� �����";
          public static readonly string CheckDelE = "Do you want to Delete";

          public static readonly string CheckTotVaule = " ������ �������� �� ����� ������ ������ ������� ";
          public static readonly string CheckTotVauleE = "Value Error";


          public static readonly string CheckSaveMsg = "�� ���� �����";
          public static readonly string CheckSaveMsgE = "Do you want to save";

          public static readonly string CheckCancelMsg = "�� ���� ����� ���������";
          public static readonly string CheckCancelMsgE = "Do you cancel Information";

          public  static readonly string SaveMesg = "�� ����� �����";
          public static readonly string SaveMesgE = "Saving Success";

          public static readonly string ConfirmSaveMesg = "�� ���� �����";
          public static readonly string ConfirmExitMesg = "�� ���� ���� ��������";

          public static readonly string ConfirmSaveMesgE = "Do you want to Save";

          public static readonly string TabSaveMesg = "�� ���� ���� �������� ��������";
          public static readonly string TabProductMesg = "�� ���� ������� �� ��� �����";
          public static readonly string ErrorSaveMesg = "���� ��� �� �������� ���� ��� �����";
          public static readonly string ErrorDelMesg = "�� ���� ��� ��� ������ ������ ������ ������ ��";
          public static readonly string CemenetDateCheck = " ���� ����� ����� ������� ������ �������� ���� ��� ������ �����";
          public static readonly string CatCodeCheck = " ���� ��� ����� ����� ����";
          public static readonly string CatDescCheck = " ���� ��� ����� ����� ����";
          public static readonly string ChangeTypeMessage = " �� ���� ���� ��� ������ ��� ��� ����� ";
          public static readonly string AccSearchMessage = " ��� ������ ��� ����� ";
          public static readonly string QidNotBalanceMesg = "����� ����� ��� ������� ";
          public static readonly string QidEmptyMesg = "��� ��� ����";
          public static readonly string NoAccountMesg = "�� ���� ���� ������ ";
          public static readonly string NoToValueMesg = "���� ������ ������� ������ ����� ";
          public static readonly string NoFromValueMesg = "���� ������ �������� ������ ����� ";
          public static readonly string ProductInvMesg = "���� ������� �������� ";
          public static readonly string StockQtyMesg = "������ �������� �� ������ ��� �� �������";
          public static readonly string StockNullQtyMesg = "���� ������ ��������";

          public static readonly string MinPriceMesg = "��� ����� ��� �� ��� ��� �����";
          public static readonly string EmpSaveMesg = "��� ����� ������ ����";
          public static readonly string InvaildInvMesg = "��� ������ ����� ��� ���� �����";
          public static readonly string InvaildDataInvMesg = "���� ������ �������� ������ �����";
          public static readonly string InvNotfoundMesg = "��� �������� ��� ������";
          public static readonly string QidNotfoundMesg = "��� ����� ��� ������";
          public static readonly string QidNotBankfoundMesg = "���� ���� �����";
          public static readonly string EmpNotfoundMesg = "��� ��� ������ ��� ������";

          public static readonly string CheckDate = "���� ������� ������ �����";
          public static readonly string ProductLevelMesg = "������ ����� ��� ���� ��� ��� �����";
          public static readonly string EnterCustomerMesg = "���� ������ ������ �����";
          public static readonly string EnterAccountMesg = "���� ������ ������ �����";
          public static readonly string ProductUnitsMesg ="���� ����� �����";
          public static readonly string codeErrorMesg = "��� ����� ����� �� ���";
          public static readonly string AccountProcessErrorMesg = "������ ��� ��� ������ ���� �� ����� ����";
          public static readonly string ProductProcessErrorMesg = "������ ��� ��� ����� ���� ����� ��������� ���� ����� ��� ��� ��� ��� �������� �� ���� ���� ������� ������ ��";

          public static readonly string AccountErrorMesg = " ������ ��� ��� ������ ���� ������ ����� ����";
          public static readonly string ProductErrorMesg = " ������ ��� ��� ����� ���� ������ ����� ����";
          public static readonly string AccountdelRightMesg = "�� ����� �����";
          public static readonly string AccountdelRightMesgE = "Deleting Success";
          public static readonly string ErrorUnitsMesg = "������ �� ���� ����� ���� �� ���� ������";
          public static readonly string ErrorMainUnitMesg = "��� ����� ������ �������� �����";
          public static readonly string CheckInvTaksatMsg = "���� ���� ������ ����";

          public static readonly string CheckInvTaksatValueMsg = "���� ���� �����";

          public static readonly string AccountMoveRightMesg = "�� ����� �����";
          public static readonly string InstallRequiredMesg = "�� ���� ����� ������ ����� ���������";
          public static readonly string InstallPaymentMesg = "�� ���� ����� ������ ����� �������";

          public static readonly string RegPath = @"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\MSArabSoft\A";
          public static readonly string ArabLang = "ar-KW";
          public static readonly string EngLang = "en-US";
          public static readonly string CheckTotTaksatMsg = "������� ����� ������� ������� ������� ����� ��������";
          public static readonly string ShowInvMesg = "�� ���� ��� ��������";
          public static readonly string InvalidBoxAccMesg = "������ ���� ������� ���� �� ������ ���� ����� ��� ���� �������� ";
          public static readonly string DBNameError= "���� ��� ����� ��������";
          public static readonly string DBNameAddSuccess = "�� ����� ����� �������� ������� �����";
          public static readonly string DBNameSel = "��� ������� ����� �������� ������ �� ����� ������� ����";
          public static readonly string DBaseClose = "��� ��� ���� �������� ��� ��� ���� �������� �� ���� ���� ��� ���� ����� ��������";
          public static readonly string DBaseDefError = "�� ���� ��� ����� �������� ��������";
          public static readonly string DBFoundError = "���� ����� ���� ����� �� ���";
          public static readonly string MoveStockProdcutMsg = "�� ���� ������� ������� �� ��� ��� ������� ��������";
          public static readonly string EnterMoveStoreMesg = "���� ��� ������ ������ �����";
          public static readonly double ExchangeRate = 0.310;
    }

}
  