

Imports System
Imports System.Data
Namespace ERPSYS
    Class ModuleLib

        Public Function FigureInWordsNumType(ByVal Num As Double, ByVal QtyTyp As Integer) As String

            Dim FIGURESTableAdapter As New rentDataSetTableAdapters.FIGURESTableAdapter
            Dim IntrentDataSet As New rentDataSet
            'Public CustBindingSource As System.Windows.Forms.BindingSource
            Dim objFigures As New rentDataSet.FIGURESDataTable
            FIGURESTableAdapter.Fill(objFigures)
            Dim FiguresRow As rentDataSet.FIGURESRow

            Dim Wa As String, Wa2 As String
            Dim NumStr As String, NumTxT As String, GroupTxT As String
            Dim HundredTxt As String, TenUnitTxt As String
            Dim QtyTxt1 As String
            Dim GroupCtr As Integer, GroupNum As Integer, SubGroupNum As Integer
            Dim HundredNum As Integer, TenUnitNum As Integer
            Dim StartPos As Integer

            'Static MyDB As Database, MyRecordset As Recordset
            'MyDB = DBEngine.Workspaces(0).Databases(0)
            'MyRecordset = MyDB.OpenRecordset("Figures", DB_OPEN_TABLE)
            'MyRecordset.Index = "PrimaryKey"

            '**297************************************************
            'Select Case QtyTyp
            '    Case Is = 1
            '        QtyTxt1 = " œÌ‰«— "
            '        QtyTxt2 = " œÌ‰«—«‰ "
            '        QtyTxt3 = " œ‰«‰Ì— "
            '        QtyTxt4 = "»œÊ‰ √Ì ﬁÌ„… «·„«·Ì…"
            '    Case Is = 2
            '        QtyTxt1 = " ﬂÌ” √”„‰  "
            '        QtyTxt2 = " ﬂÌ”«‰ √”„‰  "
            '        QtyTxt3 = " √ﬂÌ«” √”„‰  "
            '        QtyTxt4 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·√”„‰ "
            '    Case Is = 3
            '        QtyTxt1 = " ÿ‰ ÕœÌœ "
            '        QtyTxt2 = " ÿ‰«‰ ÕœÌœ "
            '        QtyTxt3 = " √ÿ‰«‰ ÕœÌœ "
            '        QtyTxt4 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·ÕœÌœ"
            '    Case Is = 4
            '        QtyTxt1 = " ÿ«»Êﬁ… ÃÌ—Ì… "
            '        QtyTxt2 = " ÿ«»Êﬁ «‰ ÃÌ—Ì «‰ "
            '        QtyTxt3 = " ÿ«»Êﬁ ÃÌ—Ì "
            '        QtyTxt4 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·ÿ«»Êﬁ «·ÃÌ—Ì"
            'End Select
            '**297************************************************297**
            'objFigures.LoadAll()
            Wa = ""
            Wa2 = ""
            NumTxT = ""
            NumStr = Format$(Num, "+000,000,000,000.000")
            StartPos = 2

            For GroupCtr = 1 To 5 Step 1
                GroupNum = Val(Mid$(NumStr, StartPos, 3))
                SubGroupNum = Val(Mid$(NumStr, StartPos + 1, 2))
                HundredNum = Val(Mid$(NumStr, StartPos, 1) & "00")
                TenUnitNum = Val(Mid$(NumStr, StartPos + 1, 2))
                TenUnitTxt = ""
                HundredTxt = ""
                StartPos = StartPos + 4
                If GroupNum = 0 Then
                    GoTo NextGroupCtr
                End If
                Select Case GroupNum
                    '    Select Case SubGroupNum
                    Case Is = 1
                        Select Case GroupCtr
                            Case Is = 1
                                GroupTxT = " »·ÌÊ‰ "
                            Case Is = 2
                                GroupTxT = " „·ÌÊ‰ "
                            Case Is = 3
                                GroupTxT = " «·› "
                            Case Is = 4
                                GroupTxT = "Ê«Õœ"
                            Case Is = 5
                                '            GroupTxT = " ›·” "
                        End Select
                        GoTo BuildText
                    Case Is = 2
                        Select Case GroupCtr
                            Case Is = 1
                                GroupTxT = " »·ÌÊ‰«‰ "
                            Case Is = 2
                                GroupTxT = " „·ÌÊ‰«‰ "
                            Case Is = 3
                                GroupTxT = " «·›«‰ "
                            Case Is = 4
                                GroupTxT = "«À‰«‰"
                            Case Is = 5
                                '            GroupTxT = " ›·” "
                        End Select
                        GoTo BuildText
                End Select

                '297   If GroupNum > 2 And GroupNum < 11 Then
                If SubGroupNum > 2 And SubGroupNum < 11 Then
                    Select Case GroupCtr
                        Case Is = 1
                            GroupTxT = " »·«ÌÌ‰ "
                        Case Is = 2
                            GroupTxT = " „·«ÌÌ‰ "
                        Case Is = 3
                            GroupTxT = " ¬·«› "
                        Case Is = 4
                            '297            GroupTxT = QtyTxt3
                        Case Is = 5
                            '            GroupTxT = " ›·” "
                    End Select
                Else
                    Select Case GroupCtr
                        Case Is = 1
                            GroupTxT = " »·ÌÊ‰ "
                        Case Is = 2
                            GroupTxT = " „·ÌÊ‰ "
                        Case Is = 3
                            GroupTxT = " «·› "
                        Case Is = 4
                            '297            GroupTxT = QtyTxt1
                        Case Is = 5
                            '            GroupTxT = " ›·” "
                    End Select
                End If
                If TenUnitNum > 0 Then
                    FiguresRow = objFigures.FindByFigure(TenUnitNum)
                    'objFigures.Filter = "Figure=" & TenUnitNum
                    'MyRecordset.Seek("=", TenUnitNum)
                    'If MyRecordset.NoMatch Then
                    If FiguresRow Is Nothing Then
                        TenUnitTxt = "***ERROR***"
                    Else
                        TenUnitTxt = FiguresRow.FigureInWords
                    End If
                End If
                'objFigures.Filter = ""

                If HundredNum > 0 Then
                    FiguresRow = objFigures.FindByFigure(HundredNum)
                    'objFigures.Filter = "Figure=" & HundredNum
                    'MyRecordset.Seek("=", HundredNum)
                    'If MyRecordset.NoMatch Then
                    If FiguresRow Is Nothing Then
                        HundredTxt = "***ERROR***"
                    Else
                        HundredTxt = FiguresRow.FigureInWords
                    End If
                End If

BuildText:

                If TenUnitNum > 0 And HundredNum > 0 Then
                    Wa2 = " Ê "
                Else
                    Wa2 = " "
                End If

                NumTxT = NumTxT & Wa & HundredTxt & Wa2 & TenUnitTxt & " " & GroupTxT
                Wa = "Ê "
                GroupTxT = ""

NextGroupCtr:
            Next

            'MyRecordset.Close()

            If NumTxT = " " Then
                Select Case QtyTyp
                    Case Is = 1
                        QtyTxt1 = "»œÊ‰ √Ì ﬁÌ„… «·„«·Ì…"
                    Case Is = 2
                        QtyTxt1 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·√”„‰ "
                    Case Is = 3
                        QtyTxt1 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·ÕœÌœ"
                    Case Is = 4
                        QtyTxt1 = "»œÊ‰ √Ì ﬂ„Ì… „‰ «·ÿ«»Êﬁ «·ÃÌ—Ì"
                End Select
                FigureInWordsNumType = NumTxT & QtyTxt1
            Else
                Select Case QtyTyp
                    Case Is = 1
                        QtyTxt1 = " œÌ‰«— ﬂÊÌ Ì    ›ﬁÿ ·«€Ì—"
                    Case Is = 2
                        QtyTxt1 = " ﬂÌ” √”„‰  ›ﬁÿ ·«€Ì—"
                    Case Is = 3
                        QtyTxt1 = " ÿ‰ ÕœÌœ ›ﬁÿ ·«€Ì—"
                    Case Is = 4
                        QtyTxt1 = " ÿ«»Êﬁ ÃÌ—Ì ›ﬁÿ ·«€Ì—"
                End Select
                FigureInWordsNumType = NumTxT & QtyTxt1
            End If

        End Function

    End Class
End Namespace