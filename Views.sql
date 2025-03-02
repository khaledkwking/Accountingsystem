if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvProductsMoveVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvProductsMoveVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Absence_View]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[Absence_View]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AccountingView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[AccountingView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Discount_View]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[Discount_View]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EmpInOutDays]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[EmpInOutDays]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvAllProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvAllProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[StockView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[StockView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[VIEW1]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[VIEW1]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Vacation_View]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[Vacation_View]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Allowance_View]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[Allowance_View]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CustomerInvoicesView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[CustomerInvoicesView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EmpInOutView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[EmpInOutView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EmpTotMonthAttendenceView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[EmpTotMonthAttendenceView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvProductsAllView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvProductsAllView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvReorderProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvReorderProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Loans_View]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[Loans_View]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ReorderInvView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[ReorderInvView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvoiceView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvoiceView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[StockMovementView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[StockMovementView]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.InvoiceView
AS
SELECT     dbo.invoices.InvId, dbo.invoices.InvCode, dbo.invoices.RecoderCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, dbo.invoices.InvAccid, 
                      dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, dbo.invoices.InvType, dbo.invoices.EmpId, 
                      dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.Notes, dbo.invoices.invTotal, dbo.invoices.Discount, dbo.invoices.InvTotalNet, 
                      dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, 
                      dbo.invoices.ChequeFlag, dbo.invoices.TotalAddCost, dbo.invoices.TotalReoder, dbo.invoices.TotalReoderNet, dbo.invoices.CostId, 
                      dbo.invoices.SUP_CUST_ID, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, dbo.invoices.CollectValue, dbo.invoices.KeyNetValue, 
                      dbo.invoices.VisaValue, dbo.invoices.MasterValue, dbo.invoices.ChequeValue, dbo.invoices.OtherValue, dbo.SUPPLIERS_CUSTOMERS.PHONE1
FROM         dbo.invoices INNER JOIN
                      dbo.SUPPLIERS_CUSTOMERS ON dbo.invoices.SUP_CUST_ID = dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.StockMovementView
AS
SELECT     dbo.StockMoveDetails.DetId, dbo.StockMoveDetails.MoveId, dbo.StockMoveDetails.PRODUCTID, dbo.StockMoveDetails.UnitID, 
                      dbo.StockMoveDetails.MovmentQty, dbo.StockMovement.MoveCode, dbo.StockMovement.STOREFromID, dbo.StockMovement.STOREToID, 
                      dbo.StockMovement.UserId, dbo.StockMovement.EnterDate, dbo.StockMovement.Notes, dbo.StockMovement.BranchId
FROM         dbo.StockMovement INNER JOIN
                      dbo.StockMoveDetails ON dbo.StockMovement.MoveId = dbo.StockMoveDetails.MoveId

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.Allowance_View
AS
SELECT     dbo.PER_EMP_Allowance.AllowanceID, dbo.PER_EMP_Allowance.EMP_CODE, dbo.PER_EMP_Allowance.YEAR_CODE, 
                      dbo.PER_EMP_Allowance.MONTH_CODE, dbo.PER_EMP_Allowance.AMOUNT, dbo.PER_EMP_Allowance.DISCOUNT_DATE, 
                      dbo.PER_EMP_Allowance.DES, dbo.PER_EMPLOYEE_DATA.FName, dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, 
                      dbo.PER_EMPLOYEE_DATA.FoName, dbo.PER_EMPLOYEE_DATA.FEngName, dbo.PER_EMPLOYEE_DATA.TITLE, dbo.CDE_DEPT.DEPT_DESC, 
                      dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.FullName, dbo.PER_EMPLOYEE_DATA.EmpNum
FROM         dbo.PER_EMP_Allowance INNER JOIN
                      dbo.PER_EMPLOYEE_DATA ON dbo.PER_EMP_Allowance.EMP_CODE = dbo.PER_EMPLOYEE_DATA.EMP_CODE INNER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.CustomerInvoicesView
AS
SELECT     dbo.invoices.InvId, dbo.invoices.InvCode, dbo.invoices.RecoderCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, dbo.invoices.InvAccid, 
                      dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, dbo.invoices.InvType, dbo.invoices.EmpId, 
                      dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.Notes, dbo.invoices.invTotal, dbo.invoices.Discount, dbo.invoices.InvTotalNet, 
                      dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, 
                      dbo.invoices.ChequeFlag, dbo.invoices.TotalAddCost, dbo.invoices.TotalReoder, dbo.invoices.TotalReoderNet, dbo.invoices.CostId, 
                      dbo.invoices.SUP_CUST_ID, dbo.invoices.PayFinish, dbo.invoices.CollectValue, dbo.Inv_Products.TotalPrice, dbo.Inv_Products.ReoderFlag, 
                      dbo.Inv_Products.TotReOderPrice, dbo.Inv_Products.StoreId, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, dbo.Inv_Products.ProductId, 
                      dbo.PRODUCTS.productname, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE, dbo.Inv_Products.Qty
FROM         dbo.invoices INNER JOIN
                      dbo.Inv_Products ON dbo.invoices.InvId = dbo.Inv_Products.InvId INNER JOIN
                      dbo.SUPPLIERS_CUSTOMERS ON dbo.invoices.SUP_CUST_ID = dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID INNER JOIN
                      dbo.PRODUCTS ON dbo.Inv_Products.ProductId = dbo.PRODUCTS.PRODUCTID


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.EmpInOutView
AS
SELECT     TOP 100 PERCENT dbo.PER_EMPLOYEE_DATA.EMP_CODE, dbo.PER_EMPLOYEE_DATA.CIVILID, dbo.PER_EMPLOYEE_DATA.FName, 
                      dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, dbo.PER_EMPLOYEE_DATA.FoName, dbo.PER_EMPLOYEE_DATA.TITLE, 
                      dbo.PER_EMPLOYEE_DATA.EmpNum, dbo.Emp_Groups.GroupName, dbo.Emp_Groups.NutalAttendance, dbo.Emp_Groups.SalaryCul, 
                      dbo.Emp_Groups.DefDate, dbo.Emp_Groups.WorkHour, dbo.Emp_Groups.VactionNum, dbo.Emp_Groups.AbsenceHourPercentage, 
                      dbo.Emp_Groups.AdditionPercentage, dbo.Emp_Groups.HourInVaction, dbo.Emp_Groups.AbsenceDayPercentage, dbo.Emp_Groups.ApplyVactionDays, 
                      dbo.Emp_Groups.SalaryAccountId, dbo.Emp_Groups.TaxAccountId, dbo.Emp_Groups.LoanAccountId, dbo.Emp_Groups.BoxAccountId, 
                      dbo.Emp_Groups.SickVactionNum, dbo.Emp_Groups.Shift1From, dbo.Emp_Groups.Shift1To, dbo.Emp_Groups.Shift2From, dbo.Emp_Groups.Shift2To, 
                      dbo.Emp_Groups.TwoShift, dbo.Emp_Groups.OffDays, dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.FullName, 
                      dbo.EmpInOutDays.EnrollNo, dbo.EmpInOutDays.Minchecktime1, dbo.EmpInOutDays.Maxchecktime1, dbo.EmpInOutDays.Minchecktime2, 
                      dbo.EmpInOutDays.Maxchecktime2, dbo.EmpInOutDays.CheckDay, dbo.EmpInOutDays.VerifyMode, dbo.EmpInOutDays.flag, 
                      dbo.PER_EMPLOYEE_DATA.GroupId
FROM         dbo.PER_EMPLOYEE_DATA INNER JOIN
                      dbo.EmpInOutDays ON dbo.PER_EMPLOYEE_DATA.EmpNum = dbo.EmpInOutDays.EnrollNo LEFT OUTER JOIN
                      dbo.Emp_Groups ON dbo.PER_EMPLOYEE_DATA.GroupId = dbo.Emp_Groups.GroupId
ORDER BY dbo.EmpInOutDays.CheckDay DESC

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.EmpTotMonthAttendenceView
AS
SELECT     dbo.PRL_EMP_ATTENDENCE.Id, dbo.PRL_EMP_ATTENDENCE.EMP_CODE, dbo.PRL_EMP_ATTENDENCE.YEAR_CODE, 
                      dbo.PRL_EMP_ATTENDENCE.MONTH_CODE, dbo.PRL_EMP_ATTENDENCE.TotAbsenceDays, dbo.PRL_EMP_ATTENDENCE.TotOverTime, 
                      dbo.PRL_EMP_ATTENDENCE.TotlateTime, dbo.PRL_EMP_ATTENDENCE.TotLateTimeAmount, dbo.PRL_EMP_ATTENDENCE.TotOverTimeAmount, 
                      dbo.PRL_EMP_ATTENDENCE.CommitFlag, dbo.PRL_EMP_ATTENDENCE.Note, dbo.PER_EMPLOYEE_DATA.TITLE, 
                      dbo.PER_EMPLOYEE_DATA.EmpNum, dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.GroupId, dbo.CDE_DEPT.DEPT_DESC, 
                      dbo.Emp_Groups.GroupName, dbo.PER_EMPLOYEE_DATA.FullName, dbo.PER_EMPLOYEE_DATA.CIVILID, dbo.PER_EMPLOYEE_DATA.FName, 
                      dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, dbo.PER_EMPLOYEE_DATA.FoName
FROM         dbo.PRL_EMP_ATTENDENCE INNER JOIN
                      dbo.PER_EMPLOYEE_DATA ON dbo.PRL_EMP_ATTENDENCE.EMP_CODE = dbo.PER_EMPLOYEE_DATA.EMP_CODE LEFT OUTER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE LEFT OUTER JOIN
                      dbo.Emp_Groups ON dbo.PER_EMPLOYEE_DATA.GroupId = dbo.Emp_Groups.GroupId

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.InvProductsAllView
AS
SELECT     dbo.Inv_Products.Inv_Product_Id, dbo.Inv_Products.InvId, dbo.Inv_Products.ProductId, dbo.Inv_Products.UnitId, dbo.Inv_Products.StoreId, 
                      dbo.Inv_Products.Discount, dbo.Inv_Products.ReoderFlag, dbo.Inv_Products.Qty, dbo.Inv_Products.Price, dbo.Inv_Products.TotalPrice, 
                      dbo.Inv_Products.VaildDate, dbo.PRODUCTS.productname, dbo.PRODUCTS.PRODUCTCODE, dbo.CDE_UNIT_TYPES.UNITDESC, 
                      dbo.Inv_Products.ConFactor
FROM         dbo.Inv_Products INNER JOIN
                      dbo.PRODUCTS ON dbo.Inv_Products.ProductId = dbo.PRODUCTS.PRODUCTID LEFT OUTER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Inv_Products.UnitId = dbo.CDE_UNIT_TYPES.UINTID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.InvProductsVIEW
AS
SELECT     dbo.Inv_Products.Inv_Product_Id, dbo.Inv_Products.InvId, dbo.Inv_Products.ProductId, dbo.Inv_Products.UnitId, dbo.Inv_Products.StoreId, 
                      dbo.Inv_Products.Discount, dbo.Inv_Products.ReoderFlag, dbo.invoices.InvCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, 
                      dbo.invoices.InvAccid, dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, dbo.invoices.InvType, dbo.invoices.EmpId, 
                      dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, 
                      dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, dbo.Inv_Products.Qty, dbo.Inv_Products.Price, dbo.Inv_Products.TotalPrice, 
                      dbo.Inv_Products.VaildDate, dbo.invoices.CostId, dbo.invoices.ChequeFlag, dbo.invoices.SUP_CUST_ID, dbo.Inv_Products.ConFactor
FROM         dbo.invoices INNER JOIN
                      dbo.Inv_Products ON dbo.invoices.InvId = dbo.Inv_Products.InvId

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE VIEW dbo.InvReorderProductsVIEW
AS
SELECT     dbo.Inv_Products.Inv_Product_Id, dbo.Inv_Products.InvId, dbo.Inv_Products.ProductId, dbo.Inv_Products.UnitId, dbo.Inv_Products.StoreId, 
                      dbo.Inv_Products.Discount, dbo.Inv_Products.ReoderFlag, dbo.invoices.RecoderCode AS invCode, dbo.invoices.InvDate, 
                      dbo.invoices.Cust_Sup_Accid, dbo.invoices.InvAccid, dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, 
                      CASE dbo.invoices.InvType WHEN 1 THEN 2 WHEN 2 THEN 1 END AS InvType, dbo.invoices.EmpId, dbo.invoices.PaymentValue, 
                      dbo.invoices.PaymentDate, dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, dbo.invoices.PaymentCost, 
                      dbo.invoices.ChequeNo, dbo.Inv_Products.ReorderQty AS Qty, dbo.Inv_Products.Price, dbo.Inv_Products.TotReOderPrice AS TotalPrice, 
                      dbo.Inv_Products.VaildDate, dbo.invoices.CostId, dbo.invoices.ChequeFlag, dbo.invoices.SUP_CUST_ID,dbo.Inv_Products.ConFactor
FROM         dbo.invoices INNER JOIN
                      dbo.Inv_Products ON dbo.invoices.InvId = dbo.Inv_Products.InvId
WHERE     (dbo.Inv_Products.ReoderFlag = 1)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE VIEW dbo.Loans_View
AS
SELECT     dbo.PER_EMPLOYEE_DATA.FName, dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, dbo.PER_EMPLOYEE_DATA.FoName, 
                      dbo.PER_EMPLOYEE_DATA.TITLE, dbo.CDE_DEPT.DEPT_DESC, dbo.PER_EMPLOYEE_DATA.FullName, dbo.PER_EMPLOYEE_DATA.EmpNum, 
                      dbo.PerEmpLoanDetailsReport.YEAR_CODE, dbo.PerEmpLoanDetailsReport.MONTH_CODE, dbo.PerEmpLoanDetailsReport.LoanAmount, 
                      dbo.PerEmpLoanDetailsReport.LoanDate, dbo.PerEmpLoanDetailsReport.deducted, dbo.PerEmpLoanDetailsReport.MonthlyIncrease, 
                      dbo.PerEmpLoanDetailsReport.Balance, dbo.PerEmpLoanDetailsReport.EMP_CODE, dbo.PER_EMPLOYEE_DATA.DEPTCODE
FROM         dbo.PER_EMPLOYEE_DATA INNER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE INNER JOIN
                      dbo.PerEmpLoanDetailsReport ON dbo.PER_EMPLOYEE_DATA.EMP_CODE = dbo.PerEmpLoanDetailsReport.EMP_CODE


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.ReorderInvView
AS
SELECT     dbo.Inv_Products.Inv_Product_Id, dbo.Inv_Products.InvId, dbo.Inv_Products.ProductId, dbo.Inv_Products.UnitId, dbo.Inv_Products.StoreId, dbo.Inv_Products.Discount, 
                      dbo.Inv_Products.ReoderFlag, dbo.invoices.RecoderCode AS invCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, dbo.invoices.InvAccid, 
                      dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, CASE dbo.invoices.InvType WHEN 1 THEN 2 WHEN 2 THEN 1 END AS InvType, 
                      dbo.invoices.EmpId, dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, 
                      dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, dbo.Inv_Products.ReorderQty AS Qty, dbo.Inv_Products.Price, dbo.Inv_Products.TotReOderPrice AS TotalPrice, 
                      dbo.Inv_Products.VaildDate, dbo.invoices.CostId, dbo.invoices.ChequeFlag, dbo.invoices.SUP_CUST_ID, dbo.Inv_Products.ConFactor, 
                      dbo.InvoiceReoders.ReorderDate, dbo.InvoiceReoders.ReorderId, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, dbo.PRODUCTS.productname
FROM         dbo.SUPPLIERS_CUSTOMERS RIGHT OUTER JOIN
                      dbo.invoices INNER JOIN
                      dbo.Inv_Products ON dbo.invoices.InvId = dbo.Inv_Products.InvId ON dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID = dbo.invoices.SUP_CUST_ID LEFT OUTER JOIN
                      dbo.InvoiceReoders ON dbo.Inv_Products.ReoderId = dbo.InvoiceReoders.ReorderId LEFT OUTER JOIN
                      dbo.PRODUCTS ON dbo.Inv_Products.ProductId = dbo.PRODUCTS.PRODUCTID
WHERE     (dbo.Inv_Products.ReoderFlag = 1)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.Absence_View
AS
SELECT     dbo.PER_EMP_ABSENCE.AbsenceID, dbo.PER_EMP_ABSENCE.START_DATE, dbo.PER_EMP_ABSENCE.END_DATE, 
                      dbo.PER_EMP_ABSENCE.EMP_CODE, dbo.PER_EMP_ABSENCE.YEAR_CODE, dbo.PER_EMP_ABSENCE.MONTH_CODE, 
                      dbo.PER_EMP_ABSENCE.DAYS_NUM, dbo.PER_EMP_ABSENCE.HOUR_NUM, dbo.PER_EMP_ABSENCE.HOURVALUE, 
                      dbo.PER_EMP_ABSENCE.NOTE, dbo.PER_EMPLOYEE_DATA.FName, dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, 
                      dbo.PER_EMPLOYEE_DATA.FoName, dbo.PER_EMPLOYEE_DATA.FullName, dbo.PER_EMPLOYEE_DATA.TITLE, dbo.CDE_DEPT.DEPT_DESC, 
                      dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.EmpNum
FROM         dbo.PER_EMP_ABSENCE INNER JOIN
                      dbo.PER_EMPLOYEE_DATA ON dbo.PER_EMP_ABSENCE.EMP_CODE = dbo.PER_EMPLOYEE_DATA.EMP_CODE INNER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.AccountingView
AS
SELECT     dbo.qidsDetails.ID, dbo.qidsDetails.qidid, dbo.qidsDetails.FromValue, dbo.qidsDetails.ToValue, dbo.qidsDetails.ACCOUNTID, dbo.qidsDetails.type, 
                      dbo.qidsDetails.Description, dbo.qidsDetails.EnterDate, dbo.qidsDetails.Detcode, dbo.qidsDetails.QidType, dbo.qidsDetails.TotalPrice, dbo.qidsDetails.ActionType, 
                      dbo.accounting.accountname, dbo.qids.BrachId, dbo.qids.EmpId, dbo.qids.InvId, dbo.accounting.Totalfromvalue, dbo.accounting.Totaltovalue, dbo.qids.qidcode, 
                      dbo.qids.qidDate, dbo.Cde_QidTypes.QidTypeDesc, dbo.accounting.AccountparentId, dbo.accounting.AccountCode, dbo.invoices.PaymentType, dbo.qids.recitetype, 
                      dbo.invoices.Cust_Sup_Accid, dbo.invoices.SUP_CUST_ID, dbo.qids.ChequeNo, dbo.qids.PaymentType AS QidPaymentType, dbo.qidsDetails.CostId, 
                      dbo.qids.repeated, YEAR(dbo.qids.qidDate) AS YearqidDate, MONTH(dbo.qids.qidDate) AS QidMonth,
                          (SELECT     MAX(ReoderId)
                             FROM         Inv_Products
                             WHERE     Inv_Products.invid = dbo.qids.ReorderInvId) AS ReorderId
FROM         dbo.invoices RIGHT OUTER JOIN
                      dbo.qids INNER JOIN
                      dbo.qidsDetails ON dbo.qids.qidid = dbo.qidsDetails.qidid INNER JOIN
                      dbo.accounting ON dbo.qidsDetails.ACCOUNTID = dbo.accounting.accountid ON dbo.invoices.InvId = dbo.qids.InvId LEFT OUTER JOIN
                      dbo.Cde_QidTypes ON dbo.qidsDetails.QidType = dbo.Cde_QidTypes.QidTypeId

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.Discount_View
AS
SELECT     dbo.PER_EMP_DISCOUNT.DISCOUNTID, dbo.PER_EMP_DISCOUNT.EMP_CODE, dbo.PER_EMP_DISCOUNT.YEAR_CODE, 
                      dbo.PER_EMP_DISCOUNT.MONTH_CODE, dbo.PER_EMP_DISCOUNT.PEN_CODE, dbo.PER_EMP_DISCOUNT.DISCOUNT_DATE, 
                      dbo.PER_EMP_DISCOUNT.AMOUNT, dbo.PER_EMP_DISCOUNT.DES, dbo.PER_EMP_DISCOUNT.accountid, dbo.PER_EMPLOYEE_DATA.FName, 
                      dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, dbo.PER_EMPLOYEE_DATA.FoName, dbo.PER_EMPLOYEE_DATA.TITLE, 
                      dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.FullName, dbo.CDE_DEPT.DEPT_DESC, dbo.CDE_PER_PENALTY.PEN_DESC, 
                      dbo.PER_EMPLOYEE_DATA.EmpNum
FROM         dbo.PER_EMP_DISCOUNT INNER JOIN
                      dbo.PER_EMPLOYEE_DATA ON dbo.PER_EMP_DISCOUNT.EMP_CODE = dbo.PER_EMPLOYEE_DATA.EMP_CODE INNER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE INNER JOIN
                      dbo.CDE_PER_PENALTY ON dbo.PER_EMP_DISCOUNT.PEN_CODE = dbo.CDE_PER_PENALTY.PEN_CODE

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.EmpInOutDays
AS
SELECT     TOP 100 PERCENT EnrollNo, dbo.fn_Select_CheckInDate(dbo.fn_Select_EmpInOutMinTimes(EnrollNo, CheckDay, 'General'), EnrollNo, 1) 
                      AS Minchecktime1, dbo.fn_Select_CheckInDate(dbo.fn_Select_EmpInOutMaxTimes(EnrollNo, CheckDay, 'General'), EnrollNo, 2) AS Minchecktime2, 
                      dbo.fn_Select_CheckOutDate(dbo.fn_Select_EmpInOutMinTimes(EnrollNo, CheckDay, 'IN1'), EnrollNo, 1) AS Maxchecktime1, 
                      dbo.fn_Select_CheckOutDate(dbo.fn_Select_EmpInOutMaxTimes(EnrollNo, CheckDay, 'IN1'), EnrollNo, 2) AS Maxchecktime2, CheckDay, VerifyMode, 
                      flag
FROM         dbo.EmpInOut
GROUP BY EnrollNo, CheckDay, VerifyMode, flag
ORDER BY CheckDay DESC

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW InvAllProductsVIEW

AS 
SELECT     dbo.InvProductsVIEW.*
FROM         dbo.InvProductsVIEW
UNION ALL
SELECT     dbo.InvReorderProductsVIEW.*
FROM         dbo.InvReorderProductsVIEW

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.StockView
AS
SELECT     TOP 100 PERCENT dbo.Product_Units_Prices.UitPriceId, dbo.Product_Units_Prices.UintId, dbo.Product_Units_Prices.productid, 
                      dbo.Product_Units_Prices.PRODUCTBRAND, dbo.Product_Units_Prices.ConFactor, dbo.Product_Units_Prices.PriceOnly, 
                      dbo.Product_Units_Prices.Dim, dbo.Product_Units_Prices.DimDesc, dbo.Product_Units_Prices.MainUnit, dbo.Product_Units_Prices.AvgCostPrice, 
                      dbo.Product_Units_Prices.MaxCostPrice, dbo.Product_Units_Prices.MinCostPrice, dbo.Product_Units_Prices.SalePrice, 
                      dbo.Product_Units_Prices.MinPrice, dbo.Product_Units_Prices.BuyPrice, dbo.Product_Units_Prices.CostmerPrice, 
                      dbo.Product_Units_Prices.PrivatePrice, dbo.Product_Units_Prices.Minprofit, dbo.Product_Units_Prices.MaxProfit, 
                      dbo.Product_Units_Prices.MaxSalePrice, dbo.Product_Units_Prices.MinSalePrice, dbo.Product_Units_Prices.LastSalePrice, 
                      dbo.Product_Units_Prices.MaxBuyPrice, dbo.Product_Units_Prices.MinBuyPrice, dbo.Product_Units_Prices.LastBuyPrice, dbo.STORES.STOREID, 
                      dbo.STORES.STORNAME, dbo.BRANCHES.BRANCHNAME, dbo.PRODUCTS.productname, dbo.PRODUCTS.PRODUCTCODE, dbo.STOCK.QUANTITY, 
                      dbo.STOCK.MovmentQty, dbo.STOCK.MaxQty, dbo.STOCK.visitationQty, dbo.STOCK.Related, dbo.STOCK.OrderQTY, dbo.STOCK.QtyINRoad, 
                      dbo.STOCK.QtyInStore, dbo.STOCK.QtynotAmount, dbo.STOCK.QtyNotProchuse, dbo.STOCK.QtyNotCost, dbo.STOCK.QtyNotSale, 
                      dbo.CDE_UNIT_TYPES.UNITDESC, dbo.STORES.BRANCHCODE, dbo.STOCK.StockId, dbo.Product_Units_Prices.LastCostPrice, 
                      dbo.STOCK.QUANTITY / dbo.Product_Units_Prices.ConFactor AS RealQutantity, dbo.Product_Units_Prices.THRESHOLDINSTOCK
FROM         dbo.Product_Units_Prices INNER JOIN
                      dbo.PRODUCTS ON dbo.Product_Units_Prices.productid = dbo.PRODUCTS.PRODUCTID INNER JOIN
                      dbo.STOCK ON dbo.Product_Units_Prices.productid = dbo.STOCK.PRODUCTID INNER JOIN
                      dbo.STORES ON dbo.STOCK.STOREID = dbo.STORES.STOREID INNER JOIN
                      dbo.BRANCHES ON dbo.STORES.BRANCHCODE = dbo.BRANCHES.BRANCHCODE INNER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Product_Units_Prices.UintId = dbo.CDE_UNIT_TYPES.UINTID
ORDER BY dbo.PRODUCTS.PRODUCTCODE, dbo.Product_Units_Prices.MainUnit DESC

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.VIEW1
AS
SELECT DISTINCT 
                      dbo.PRODUCTS.PRODUCTID, dbo.PRODUCTS.productname, dbo.PRODUCTS.EnglishName, dbo.PRODUCTS.PRODUCTCODE, 
                      dbo.PRODUCTS.ParentProductId, dbo.PRODUCTS.Root, dbo.PRODUCTS.ProductTypeID, dbo.PRODUCTS.SERIALNO, dbo.PRODUCTS.SUPPLIERID, 
                      dbo.PRODUCTS.CATEGORYID, dbo.PRODUCTS.PWeight, dbo.PRODUCTS.PSize, dbo.PRODUCTS.PColor, dbo.PRODUCTS.PVolume, 
                      dbo.PRODUCTS.VALIDITY, dbo.PRODUCTS.PriceRule, dbo.PRODUCTS.PriceFromDate, dbo.PRODUCTS.PriceToDate, dbo.PRODUCTS.OfferTypeID, 
                      dbo.PRODUCTS.OfferFromDate, dbo.PRODUCTS.OfferToDate, dbo.PRODUCTS.OfferProductId, dbo.PRODUCTS.OfferUnit, 
                      dbo.PRODUCTS.UNITPRICECOST, dbo.PRODUCTS.UNITPRICESALES, dbo.PRODUCTS.BUYDATE, dbo.PRODUCTS.THRESHOLDINSTOCK, 
                      dbo.PRODUCTS.DISCONTINUED, dbo.PRODUCTS.REORDERLEVEL, dbo.PRODUCTS.STOCKNO, dbo.PRODUCTS.RECEIVERID, dbo.PRODUCTS.SHAPE, 
                      dbo.PRODUCTS.QUANTITYPERUNIT, dbo.PRODUCTS.complexproduct, dbo.PRODUCTS.UNITSINSTOCK, dbo.PRODUCTS.ACCOUNTID, 
                      dbo.PRODUCTS.QUANTITYINUNIT, dbo.PRODUCTS.initialsmallquantity, dbo.PRODUCTS.initialprice, dbo.PRODUCTS.initiallargequantity, 
                      dbo.PRODUCTS.serviceproduct, dbo.PRODUCTS.profit, dbo.PRODUCTS.forcurrency, dbo.PRODUCTS.minprice, dbo.PRODUCTS.shape2, 
                      dbo.PRODUCTS.SerialCode, dbo.PRODUCTS.MainNode, dbo.PRODUCTS.ProcessFlag, dbo.PRODUCTS.[Level]
FROM         dbo.STORES INNER JOIN
                      dbo.STOCK ON dbo.STORES.STOREID = dbo.STOCK.STOREID LEFT OUTER JOIN
                      dbo.PRODUCTS ON dbo.STOCK.PRODUCTID = dbo.PRODUCTS.PRODUCTID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.Vacation_View
AS
SELECT     dbo.PER_EMP_VACATION.VACID, dbo.PER_EMP_VACATION.VAC_TYPE_CODE, dbo.PER_EMP_VACATION.EMP_CODE, 
                      dbo.PER_EMP_VACATION.VAC_DATE_FRM, dbo.PER_EMP_VACATION.VAC_DATE_TO, dbo.PER_EMP_VACATION.RETURN_DATE, 
                      dbo.PER_EMP_VACATION.VAC_PERIOD, dbo.PER_EMP_VACATION.NOTE, dbo.PER_EMP_VACATION.TotalDays, dbo.PER_EMP_VACATION.Netdays, 
                      dbo.PER_EMP_VACATION.Holidays, dbo.PER_EMP_VACATION.Ticket, dbo.PER_EMP_VACATION.DEC_FLAG, dbo.PER_EMPLOYEE_DATA.FName, 
                      dbo.PER_EMPLOYEE_DATA.SName, dbo.PER_EMPLOYEE_DATA.TName, dbo.PER_EMPLOYEE_DATA.FoName, dbo.PER_EMPLOYEE_DATA.TITLE, 
                      dbo.PER_EMPLOYEE_DATA.DEPTCODE, dbo.PER_EMPLOYEE_DATA.FullName, dbo.CDE_DEPT.DEPT_DESC, 
                      dbo.CDE_PER_VAC_SUB_CLASS.VAC_TYPE_DESC, dbo.PER_EMPLOYEE_DATA.EmpNum
FROM         dbo.PER_EMP_VACATION INNER JOIN
                      dbo.PER_EMPLOYEE_DATA ON dbo.PER_EMP_VACATION.EMP_CODE = dbo.PER_EMPLOYEE_DATA.EMP_CODE INNER JOIN
                      dbo.CDE_DEPT ON dbo.PER_EMPLOYEE_DATA.DEPTCODE = dbo.CDE_DEPT.DEPT_CODE INNER JOIN
                      dbo.CDE_PER_VAC_SUB_CLASS ON dbo.PER_EMP_VACATION.VAC_TYPE_CODE = dbo.CDE_PER_VAC_SUB_CLASS.VAC_TYPE_CODE

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE VIEW dbo.InvProductsMoveVIEW
AS
SELECT DISTINCT 
                      dbo.CDE_UNIT_TYPES.UNITDESC, dbo.PRODUCTS.productname, dbo.Product_Units_Prices.LastSalePrice, dbo.Product_Units_Prices.LastBuyPrice, 
                      dbo.Product_Units_Prices.LastCostPrice, dbo.STOCK.QUANTITY, dbo.PRODUCTS.PRODUCTCODE, dbo.STOCK.QtyInStore, 
                      dbo.Product_Units_Prices.PRODUCTBRAND, dbo.Product_Units_Prices.AvgCostPrice, dbo.Product_Units_Prices.MaxCostPrice, 
                      dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, dbo.InvAllProductsVIEW.Inv_Product_Id, dbo.InvAllProductsVIEW.InvId, 
                      dbo.InvAllProductsVIEW.ProductId, dbo.InvAllProductsVIEW.UnitId, dbo.InvAllProductsVIEW.StoreId, dbo.InvAllProductsVIEW.Discount, 
                      dbo.InvAllProductsVIEW.ReoderFlag, dbo.InvAllProductsVIEW.InvCode, dbo.InvAllProductsVIEW.InvDate, dbo.InvAllProductsVIEW.Cust_Sup_Accid, 
                      dbo.InvAllProductsVIEW.InvAccid, dbo.InvAllProductsVIEW.PaymentType, dbo.InvAllProductsVIEW.PaymentAccid, dbo.InvAllProductsVIEW.BranchId, 
                      dbo.InvAllProductsVIEW.InvType, dbo.InvAllProductsVIEW.EmpId, dbo.InvAllProductsVIEW.PaymentValue, dbo.InvAllProductsVIEW.PaymentDate, 
                      dbo.InvAllProductsVIEW.InvPayment, dbo.InvAllProductsVIEW.InvRemain, dbo.InvAllProductsVIEW.ReferID, dbo.InvAllProductsVIEW.PaymentCost, 
                      dbo.InvAllProductsVIEW.ChequeNo, dbo.InvAllProductsVIEW.Qty, dbo.InvAllProductsVIEW.Price, dbo.InvAllProductsVIEW.TotalPrice, 
                      dbo.InvAllProductsVIEW.VaildDate, dbo.InvAllProductsVIEW.CostId, dbo.InvAllProductsVIEW.ChequeFlag, dbo.InvAllProductsVIEW.SUP_CUST_ID, 
                      dbo.InvAllProductsVIEW.ConFactor, dbo.Product_Units_Prices.MainUnit, dbo.SUPPLIERS_CUSTOMERS.PHONE1, 
                      dbo.InvAllProductsVIEW.Qty * dbo.InvAllProductsVIEW.ConFactor AS totMainQty
FROM         dbo.SUPPLIERS_CUSTOMERS INNER JOIN
                      dbo.InvAllProductsVIEW INNER JOIN
                      dbo.Product_Units_Prices ON dbo.InvAllProductsVIEW.UnitId = dbo.Product_Units_Prices.UintId AND 
                      dbo.InvAllProductsVIEW.ProductId = dbo.Product_Units_Prices.productid ON 
                      dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID = dbo.InvAllProductsVIEW.SUP_CUST_ID LEFT OUTER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Product_Units_Prices.UintId = dbo.CDE_UNIT_TYPES.UINTID LEFT OUTER JOIN
                      dbo.PRODUCTS ON dbo.Product_Units_Prices.productid = dbo.PRODUCTS.PRODUCTID LEFT OUTER JOIN
                      dbo.STOCK ON dbo.InvAllProductsVIEW.ProductId = dbo.STOCK.PRODUCTID AND dbo.InvAllProductsVIEW.StoreId = dbo.STOCK.STOREID

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

