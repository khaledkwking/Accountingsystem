if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_UNIT_TYPESDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CDE_UNIT_TYPESDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_UNIT_TYPESInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CDE_UNIT_TYPESInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_UNIT_TYPESSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CDE_UNIT_TYPESSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_UNIT_TYPESUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[CDE_UNIT_TYPESUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ClearAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[ClearAll]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Product_Units_Prices_view]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[Product_Units_Prices_view]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SelectQuery]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[SelectQuery]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UpdateAssembly_QtyValue]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[UpdateAssembly_QtyValue]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[clearTables]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[clearTables]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ CDE_PER_QLFDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ CDE_PER_QLFDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ CDE_PER_QLFInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ CDE_PER_QLFInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ CDE_PER_QLFSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ CDE_PER_QLFSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ CDE_PER_QLFUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ CDE_PER_QLFUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ InsertInvoiceOrders]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ InsertInvoiceOrders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ InvOrders_ProductsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ InvOrders_ProductsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ InvOrders_ProductsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ InvOrders_ProductsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ InvOrders_ProductsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ InvOrders_ProductsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ InvOrders_ProductsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ InvOrders_ProductsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ StockMoveDetailsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ StockMoveDetailsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ StockMoveDetailsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ StockMoveDetailsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ StockMoveDetailsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ StockMoveDetailsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ StockMoveDetailsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ StockMoveDetailsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Absence_ViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Absence_ViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Absence_ViewSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Absence_ViewSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountA3marAlDauan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountA3marAlDauan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountA3marAlDauanMonths]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountA3marAlDauanMonths]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountBeforeTotRefBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountBeforeTotRefBalance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountBeforeTotRefBalanceLast]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountBeforeTotRefBalanceLast]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountDauanTotFromValue]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountDauanTotFromValue]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountDauanTotToValue]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountDauanTotToValue]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountGetTotalSum]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountGetTotalSum]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountSelectAllTotRefBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountSelectAllTotRefBalance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountSelectTotBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountSelectTotBalance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountSelectTotRefBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountSelectTotRefBalance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountSelectTotRefBalanceIncome]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountSelectTotRefBalanceIncome]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountSelectTotRefBalanceNewLast]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountSelectTotRefBalanceNewLast]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountUpdateBalance]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountUpdateBalance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountUpdateClosedTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountUpdateClosedTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingGetAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingGetAll]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingSelectByAccId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingSelectByAccId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingSelectClosedTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingSelectClosedTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewByPayQidId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewByPayQidId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewByQidId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewByQidId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelectByParm]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelectByParm]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelectNotStartByParm]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelectNotStartByParm]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelectNotStartNoMovingByParm]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelectNotStartNoMovingByParm]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewbyRecitetype]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewbyRecitetype]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Allowance_ViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Allowance_ViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Allowance_ViewSelectbyParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Allowance_ViewSelectbyParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_BoxCheck]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_BoxCheck]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_BranchesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_BranchesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_BranchesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_BranchesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_BranchesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_BranchesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_BranchesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_BranchesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_BANKDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_BANKDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_BANKInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_BANKInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_BANKSSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_BANKSSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_BANKUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_BANKUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_LOCATIONDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_LOCATIONDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_LOCATIONInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_LOCATIONInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_LOCATIONSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_LOCATIONSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_LOCATIONUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_LOCATIONUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_Offer_TypesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_Offer_TypesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_Offer_TypesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_Offer_TypesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_Offer_TypesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_Offer_TypesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_Offer_TypesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_Offer_TypesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PER_QLFInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PER_QLFInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PER_QLFSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PER_QLFSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PRODUCTTYPESDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PRODUCTTYPESDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PRODUCTTYPESInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PRODUCTTYPESInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PRODUCTTYPESSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PRODUCTTYPESSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CDE_PRODUCTTYPESUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CDE_PRODUCTTYPESUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CategoryDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CategoryDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CategoryInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CategoryInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CategorySelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CategorySelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CategoryUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CategoryUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckAccountCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckAccountCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckCostCenterCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckCostCenterCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckEmpCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckEmpCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckInvCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckInvCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckInvOrdersCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckInvOrdersCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckMoveStockCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckMoveStockCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckOrdersCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckOrdersCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckQidCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckQidCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CostCentersDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CostCentersDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CostCentersInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CostCentersInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CostCentersSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CostCentersSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CostCentersUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CostCentersUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CurrencyDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CurrencyDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CurrencyInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CurrencyInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CurrencySelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CurrencySelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CurrencyUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CurrencyUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CustomerSalesAgalSelectView]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CustomerSalesAgalSelectView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CustomerSalesSelectView]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CustomerSalesSelectView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DBNAMESInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DBNAMESInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DBNAMESSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DBNAMESSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DEPTDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DEPTDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DEPTInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DEPTInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DEPTSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DEPTSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DEPTUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DEPTUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DOCUMENT_TYPESDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DOCUMENT_TYPESDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DOCUMENT_TYPESInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DOCUMENT_TYPESInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DOCUMENT_TYPESUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DOCUMENT_TYPESUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_DOCUMENT_TYPESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_DOCUMENT_TYPESelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Discount_ViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Discount_ViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Discount_ViewSelectbyParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Discount_ViewSelectbyParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCEDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCEDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCEInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCEInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCESelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCESelectByEmpCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCESelectByEmpCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCEUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCEUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DISCOUNTDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DISCOUNTDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DISCOUNTInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DISCOUNTInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DISCOUNTSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DISCOUNTSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DISCOUNTSelectbyEmpId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DISCOUNTSelectbyEmpId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DISCOUNTUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DISCOUNTUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DOCUMNETDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DOCUMNETDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DOCUMNETInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DOCUMNETInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DOCUMNETSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DOCUMNETSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_DOCUMNETUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_DOCUMNETUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANSelectByLoanId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANSelectByLoanId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANSelectbyEmpId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANSelectbyEmpId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_LOANUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_LOANUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONSelectbyempId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONSelectbyempId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpGroupOffDayDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpGroupOffDayDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpGroupOffDayInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpGroupOffDayInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpGroupOffDaySelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpGroupOffDaySelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpGroupOffDayUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpGroupOffDayUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInOutViewSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInOutViewSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpTotMonthAttendenceViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpTotMonthAttendenceViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpTotMonthAttendenceViewSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpTotMonthAttendenceViewSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Emp_GroupsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Emp_GroupsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Emp_GroupsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Emp_GroupsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Emp_GroupsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Emp_GroupsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Emp_GroupsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Emp_GroupsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FIGURESInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FIGURESInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FIGURESSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FIGURESSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FunctionDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FunctionDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FunctionInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FunctionInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FunctionSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FunctionSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_FunctionUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_FunctionUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GOVERNORATEDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GOVERNORATEDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GOVERNORATEInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GOVERNORATEInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GOVERNORATESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GOVERNORATESelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GOVERNORATEUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GOVERNORATEUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetBranchIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetBranchIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetCustSupIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetCustSupIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetCustTotalPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetCustTotalPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetEmpIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetEmpIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetInstallmentIden]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetInstallmentIden]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetInvOrdersIden]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetInvOrdersIden]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetInvoiceIden]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetInvoiceIden]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetMoveStockIden]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetMoveStockIden]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetOrdersIden]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetOrdersIden]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetQidDetIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetQidDetIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetQidsIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetQidsIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_GetStoresIdent]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_GetStoresIdent]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_HomeCustomerDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_HomeCustomerDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_HomeCustomerInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_HomeCustomerInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_HomeCustomerSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_HomeCustomerSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_HomeCustomerSelectByCustId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_HomeCustomerSelectByCustId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_HomeCustomerUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_HomeCustomerUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InstallmentDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InstallmentDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InstallmentInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InstallmentInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InstallmentSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InstallmentSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InstallmentUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InstallmentUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionAll]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionPayment]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionPayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionRequired]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionRequired]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Installment_DistributionUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Installment_DistributionUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvOrdersDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvOrdersDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvOrdersInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvOrdersInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvOrdersProductsById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvOrdersProductsById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvOrdersSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvOrdersSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvOrdersUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvOrdersUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsAllViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsAllViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsAllViewSelectByInvId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsAllViewSelectByInvId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsByInvId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsByInvId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsMoveVIEW]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsMoveVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsMoveVIEWByCustParms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsMoveVIEWByCustParms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsMoveVIEWByParms]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsMoveVIEWByParms]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvProductsMoveVIEWByParmsAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvProductsMoveVIEWByParmsAll]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvSelectMaxSerial]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvSelectMaxSerial]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_PRODUCTSelectCountProductID]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_PRODUCTSelectCountProductID]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_PRODUCTSelectbyProduct]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_PRODUCTSelectbyProduct]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsSelectbyReoderId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsSelectbyReoderId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceReodersDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceReodersDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceReodersInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceReodersInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceReodersSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceReodersSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceReodersSelectbyDate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceReodersSelectbyDate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceReodersUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceReodersUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceViewSelectAll]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceViewSelectAll]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceViewSelectByCust]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceViewSelectByCust]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceViewSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceViewSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoiceViewSelectMove]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoiceViewSelectMove]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Loans_ViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Loans_ViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Loans_ViewSelectbyParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Loans_ViewSelectbyParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_MonthsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_MonthsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_MoveDetailsSelectByMoveId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_MoveDetailsSelectByMoveId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_NATIONALITYDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_NATIONALITYDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_NATIONALITYInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_NATIONALITYInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_NATIONALITYSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_NATIONALITYSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_NATIONALITYUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_NATIONALITYUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERDETAILSDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERDETAILSDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERDETAILSInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERDETAILSInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERDETAILSSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERDETAILSSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERDETAILSUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERDETAILSUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERSDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERSDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERSInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERSInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERSSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERSSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ORDERSUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ORDERSUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_OrderDetailsSelectByOrderId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_OrderDetailsSelectByOrderId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PENALTYDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PENALTYDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PENALTYInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PENALTYInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PENALTYSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PENALTYSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PENALTYUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PENALTYUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceSelectByEmpId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceSelectByEmpId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_RELATIVEDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_RELATIVEDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_RELATIVEInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_RELATIVEInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_RELATIVESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_RELATIVESelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_RELATIVEUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_RELATIVEUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_RELATIVEbyEmpCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_RELATIVEbyEmpCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_ATTENDENCEDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_ATTENDENCEDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_ATTENDENCEInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_ATTENDENCEInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_ATTENDENCESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_ATTENDENCESelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_ATTENDENCESelectByMonth]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_ATTENDENCESelectByMonth]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_ATTENDENCEUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_ATTENDENCEUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_SAL_CALCULATIONDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_SAL_CALCULATIONDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_SAL_CALCULATIONInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_SAL_CALCULATIONInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_SAL_CALCULATIONSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_SAL_CALCULATIONSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_SAL_CALCULATIONSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_SAL_CALCULATIONSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRL_EMP_SAL_CALCULATIONUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRL_EMP_SAL_CALCULATIONUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTSelectMainNode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTSelectMainNode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTSelectNumofChild]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTSelectNumofChild]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDetailsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDetailsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDetailsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDetailsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDetailsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDetailsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDetailsSelectByPartId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDetailsSelectByPartId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionDetailsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionDetailsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionSelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionSelectById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PartitionUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PartitionUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PerEmpLoanDetailsReportDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PerEmpLoanDetailsReportDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PerEmpLoanDetailsReportInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PerEmpLoanDetailsReportInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PerEmpLoanDetailsReportSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PerEmpLoanDetailsReportSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PerEmpLoanDetailsReportUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PerEmpLoanDetailsReportUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PerEmpLoanDetailsReportbyEmpCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PerEmpLoanDetailsReportbyEmpCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Per_Employee_DataGetByEmpCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Per_Employee_DataGetByEmpCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductOffersDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductOffersDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductOffersInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductOffersInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductOffersSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductOffersSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductOffersUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductOffersUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductReplacmentDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductReplacmentDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductReplacmentInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductReplacmentInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductReplacmentSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductReplacmentSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductReplacmentUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductReplacmentUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductSalesSelectView]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductSalesSelectView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductSalesSelectViewMonths]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductSalesSelectViewMonths]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplyDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplyDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplyInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplyInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplySelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplySelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplySelectbyProductId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplySelectbyProductId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplyUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplyUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesByUnitId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesByUnitId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesSelectbyBarCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesSelectbyBarCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesSelectbyProductId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesSelectbyProductId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductsSelectQuery]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductsSelectQuery]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductsSelectStock]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductsSelectStock]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_QidCheckChequeNo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_QidCheckChequeNo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_QidSelectMaxChequeNo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_QidSelectMaxChequeNo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_QidSelectMaxSerialNotDate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_QidSelectMaxSerialNotDate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ReoderDetailsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ReoderDetailsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ReoderDetailsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ReoderDetailsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ReoderDetailsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ReoderDetailsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ReoderDetailsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ReoderDetailsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_STORESSelectByBranchId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_STORESSelectByBranchId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_STORESSelectByStoreId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_STORESSelectByStoreId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSByType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSByType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSPayByType]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSPayByType]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SUPPLIERS_CUSTOMERSUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SUPPLIERS_CUSTOMERSUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectAllAccounts]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectAllAccounts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectBRANCHESById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectBRANCHESById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectCostClosedTo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectCostClosedTo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectInvoiceOrders]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectInvoiceOrders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectInvoiceOrdersbyInvId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectInvoiceOrdersbyInvId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectProductUints]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectProductUints]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectQidByInvId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectQidByInvId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectQidDerialsById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectQidDerialsById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SelectViewAllProducts]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SelectViewAllProducts]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SetupCodesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SetupCodesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SetupCodesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SetupCodesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SetupCodesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SetupCodesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_SetupCodesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_SetupCodesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockCheckQtyByProductId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockCheckQtyByProductId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockMovementDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockMovementDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockMovementInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockMovementInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockMovementSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockMovementSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockMovementUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockMovementUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockMovementViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockMovementViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockSelectByMainUnit]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockSelectByMainUnit]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockViewSelectbyKey]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockViewSelectbyKey]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockViewkSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockViewkSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockViewkSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockViewkSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StoresDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StoresDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StoresInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StoresInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StoresSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StoresSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StoresUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StoresUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Suppliers_CustomerAccId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Suppliers_CustomerAccId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USERDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USERDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USERInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USERInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USERSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USERSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USERUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USERUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONByUserId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONByUserId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_USER_FUNCTIONnsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_USER_FUNCTIONnsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UserFunctionsByUserId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UserFunctionsByUserId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UserSelectById]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UserSelectById]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UserSelectByName]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UserSelectByName]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UsersDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UsersDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UsersInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UsersInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UsersSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UsersSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_UsersUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_UsersUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_VAC_SUB_CLASSDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_VAC_SUB_CLASSDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_VAC_SUB_CLASSInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_VAC_SUB_CLASSInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_VAC_SUB_CLASSSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_VAC_SUB_CLASSSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_VAC_SUB_CLASSUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_VAC_SUB_CLASSUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Vacation_ViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Vacation_ViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Vacation_ViewSelectbyParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Vacation_ViewSelectbyParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_WeekDaysDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_WeekDaysDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_WeekDaysInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_WeekDaysInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_WeekDaysSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_WeekDaysSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_WeekDaysUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_WeekDaysUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingSelectByParam]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingSelectByParam]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyCodeAndCust]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyCodeAndCust]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyCustId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyCustId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyCustomerId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyCustomerId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyInvId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyInvId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsClosedDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsClosedDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsClosedInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsClosedInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsClosedSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsClosedSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsClosedUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsClosedUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsDetailsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsDetailsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_qidsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_qidsUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_setupDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_setupDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_setupInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_setupInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_setupSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_setupSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_setupUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_setupUpdate]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.CDE_UNIT_TYPESDelete
(
	@Original_UINTID bigint,
	@IsNull_UNITDESC nvarchar(50),
	@Original_UNITDESC nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_UNIT_TYPES] WHERE (([UINTID] = @Original_UINTID) AND ((@IsNull_UNITDESC = 1 AND [UNITDESC] IS NULL) OR ([UNITDESC] = @Original_UNITDESC)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.CDE_UNIT_TYPESInsert
(
	@UNITDESC nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_UNIT_TYPES] ([UNITDESC]) VALUES (@UNITDESC);
	
SELECT UINTID, UNITDESC FROM CDE_UNIT_TYPES WHERE (UINTID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.CDE_UNIT_TYPESSelect
AS
	SET NOCOUNT ON;
SELECT     UINTID, UNITDESC
FROM         CDE_UNIT_TYPES









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.CDE_UNIT_TYPESUpdate
(
	@UNITDESC nvarchar(50),
	@Original_UINTID bigint,
	@IsNull_UNITDESC nvarchar(50),
	@Original_UNITDESC nvarchar(50),
	@UINTID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_UNIT_TYPES] SET [UNITDESC] = @UNITDESC WHERE (([UINTID] = @Original_UINTID) AND ((@IsNull_UNITDESC = 1 AND [UNITDESC] IS NULL) OR ([UNITDESC] = @Original_UNITDESC)));
	
SELECT UINTID, UNITDESC FROM CDE_UNIT_TYPES WHERE (UINTID = @UINTID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE ClearAll  AS
UPDATE    accounting
SET              Totalfromvalue = 0, Totaltovalue = 0
delete from qidsDetails
delete from Inv_Products
delete from qids
delete from Invoices
delete from ORDERS
DBCC CHECKIDENT (qids, RESEED, 0)
DBCC CHECKIDENT (qidsDetails, RESEED, 0)
DBCC CHECKIDENT (invoices, RESEED, 0)
DBCC CHECKIDENT (Inv_Products, RESEED, 0)

DBCC CHECKIDENT (ORDERS, RESEED, 0)
DBCC CHECKIDENT (OrderDetails, RESEED, 0)

update setupCodes set SalInvSerial=0,PurchInvSerial=0,InQidSerial=0,OutQidSerial=0,QidSeial=0







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.Product_Units_Prices_view
AS
	SET NOCOUNT ON;
SELECT     dbo.Product_Units_Prices.UintId, dbo.Product_Units_Prices.productid, dbo.Product_Units_Prices.ConFactor, dbo.Product_Units_Prices.PriceOnly, 
                      dbo.Product_Units_Prices.Dim, dbo.Product_Units_Prices.DimDesc, dbo.Product_Units_Prices.MainUnit, dbo.Product_Units_Prices.LastCostPrice, 
                      dbo.Product_Units_Prices.SalePrice, dbo.Product_Units_Prices.MinPrice, dbo.Product_Units_Prices.BuyPrice, dbo.Product_Units_Prices.CostmerPrice,
                       dbo.Product_Units_Prices.PrivatePrice, dbo.Product_Units_Prices.Minprofit, dbo.Product_Units_Prices.MaxProfit, 
                      dbo.Product_Units_Prices.AvgCostPrice, dbo.Product_Units_Prices.MaxCostPrice, dbo.Product_Units_Prices.PRODUCTBRAND, 
                      dbo.PRODUCTS.PRODUCTCODE, dbo.PRODUCTS.productname, dbo.CDE_UNIT_TYPES.UNITDESC, dbo.CDE_PRODUCTTYPES.TYPEDESC
FROM         dbo.Product_Units_Prices INNER JOIN
                      dbo.PRODUCTS ON dbo.Product_Units_Prices.productid = dbo.PRODUCTS.PRODUCTID INNER JOIN
                      dbo.CDE_PRODUCTTYPES ON dbo.PRODUCTS.ProductTypeID = dbo.CDE_PRODUCTTYPES.TYPEID INNER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Product_Units_Prices.UintId = dbo.CDE_UNIT_TYPES.UINTID









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.SelectQuery
(
	@STOREID bigint
)
AS
	SET NOCOUNT ON;
SELECT     STOCK.StockId, STOCK.STOREID, STOCK.PRODUCTID, STOCK.UnitID, STOCK.QUANTITY, STOCK.MovmentQty, STOCK.MaxQty, STOCK.visitationQty, 
                      STOCK.Related, STOCK.OrderQTY, STOCK.QtyInStore, STOCK.QtyINRoad, STOCK.QtynotAmount, STOCK.QtyNotProchuse, STOCK.QtyNotCost, 
                      STOCK.QtyNotSale, PRODUCTS.productname
FROM         STOCK LEFT OUTER JOIN
                      PRODUCTS ON STOCK.PRODUCTID = PRODUCTS.PRODUCTID
where STOREID=@STOREID









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE UpdateAssembly_QtyValue(@ProductId bigint,@STOREID bigint,@NewPQty float,@OldPQty float)
as

BEGIN

declare @NewProductId  bigint
declare @NewUnitId  bigint
declare @NewQty float 
declare @updateQty float

DECLARE c1 CURSOR local  FOR
  SELECT Assproductid,unit,Qty
   FROM  Product_Assemply
  WHERE productid = @ProductId
	
OPEN c1
FETCH NEXT FROM c1 INTO @NewProductId,@NewUnitId,@NewQty
WHILE @@fetch_status = 0
BEGIN
  

if (@OldPQty=0)
begin --Insert Qty

	update STOCK set QUANTITY = QUANTITY- (@NewQty*@NewPQty)  where STOREID = @STOREID and PRODUCTID=@NewProductId and  UnitID=@NewUnitId
end 
else
begin -- update Qty
	set  @updateQty=@NewPQty-@OldPQty

	update STOCK set QUANTITY = QUANTITY- (@NewQty*@updateQty)  where STOREID = @STOREID and PRODUCTID=@NewProductId and  UnitID=@NewUnitId
end 

  FETCH NEXT FROM c1 INTO @NewProductId,@NewUnitId,@NewQty
END
CLOSE c1
DEALLOCATE c1

END







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE clearTables  AS
UPDATE    accounting
SET              Totalfromvalue = 0, Totaltovalue = 0
delete from qids
delete from accounting where accountid>4
delete from STOCK
delete from Product_Units_Prices
delete from PRODUCTS 
delete from SUPPLIERS_CUSTOMERS where SUP_CUST_ID>1
DBCC CHECKIDENT (qids, RESEED, 0)
DBCC CHECKIDENT (qidsDetails, RESEED, 0)
DBCC CHECKIDENT (invoices, RESEED, 0)
DBCC CHECKIDENT (Inv_Products, RESEED, 0)
DBCC CHECKIDENT (accounting, RESEED, 4)
DBCC CHECKIDENT (SUPPLIERS_CUSTOMERS, RESEED, 1)
DBCC CHECKIDENT (PRODUCTS, RESEED, 0)
DBCC CHECKIDENT (STOCK, RESEED, 0)
DBCC CHECKIDENT (Product_Units_Prices, RESEED, 0)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ CDE_PER_QLFDelete]
(
	@Original_QLF_CODE numeric(5, 0),
	@Original_QLF_DESC varchar(100),
	@Original_QLF_TYP_CODE numeric(5, 0)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_PER_QLF] WHERE (([QLF_CODE] = @Original_QLF_CODE) AND ([QLF_DESC] = @Original_QLF_DESC) AND ([QLF_TYP_CODE] = @Original_QLF_TYP_CODE))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ CDE_PER_QLFInsert]
(
	@QLF_CODE numeric(5, 0),
	@QLF_DESC varchar(100),
	@QLF_TYP_CODE numeric(5, 0)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_QLF] ([QLF_CODE], [QLF_DESC], [QLF_TYP_CODE]) VALUES (@QLF_CODE, @QLF_DESC, @QLF_TYP_CODE);
	
SELECT QLF_CODE, QLF_DESC, QLF_TYP_CODE FROM CDE_PER_QLF WHERE (QLF_CODE = @QLF_CODE) AND (QLF_TYP_CODE = @QLF_TYP_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ CDE_PER_QLFSelect]
AS
	SET NOCOUNT ON;
SELECT QLF_CODE, QLF_DESC, QLF_TYP_CODE FROM CDE_PER_QLF







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ CDE_PER_QLFUpdate]
(
	@QLF_CODE numeric(5, 0),
	@QLF_DESC varchar(100),
	@QLF_TYP_CODE numeric(5, 0),
	@Original_QLF_CODE numeric(5, 0),
	@Original_QLF_DESC varchar(100),
	@Original_QLF_TYP_CODE numeric(5, 0)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PER_QLF] SET [QLF_CODE] = @QLF_CODE, [QLF_DESC] = @QLF_DESC, [QLF_TYP_CODE] = @QLF_TYP_CODE WHERE (([QLF_CODE] = @Original_QLF_CODE) AND ([QLF_DESC] = @Original_QLF_DESC) AND ([QLF_TYP_CODE] = @Original_QLF_TYP_CODE));
	
SELECT QLF_CODE, QLF_DESC, QLF_TYP_CODE FROM CDE_PER_QLF WHERE (QLF_CODE = @QLF_CODE) AND (QLF_TYP_CODE = @QLF_TYP_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.[usp_ InsertInvoiceOrders]
(
	@InvId bigint,
	@OrderId bigint,
	@InvDate smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [InvoiceOrders] ([InvId], [OrderId], [InvDate]) VALUES (@InvId, @OrderId, @InvDate)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ InvOrders_ProductsDelete]
(
	@Original_Inv_Product_Id bigint,
	@Original_InvId bigint,
	@Original_ProductId bigint,
	@Original_UnitId bigint,
	@Original_Qty float,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@Original_Price money,
	@Original_StoreId bigint,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ReoderFlag bit,
	@Original_ReoderFlag bit,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [InvOrders_Products] WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ InvOrders_ProductsInsert]
(
	@InvId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@ReorderQty float,
	@Price money,
	@StoreId bigint,
	@Discount float,
	@VaildDate datetime,
	@TotalPrice money,
	@ReoderFlag bit,
	@TotReOderPrice money,
	@PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [InvOrders_Products] ([InvId], [ProductId], [UnitId], [Qty], [ReorderQty], [Price], [StoreId], [Discount], [VaildDate], [TotalPrice], [ReoderFlag], [TotReOderPrice], [PRODUCTBRAND]) VALUES (@InvId, @ProductId, @UnitId, @Qty, @ReorderQty, @Price, @StoreId, @Discount, @VaildDate, @TotalPrice, @ReoderFlag, @TotReOderPrice, @PRODUCTBRAND);
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND FROM InvOrders_Products WHERE (Inv_Product_Id = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ InvOrders_ProductsSelect]
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND
FROM         InvOrders_Products







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ InvOrders_ProductsUpdate]
(
	@InvId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@ReorderQty float,
	@Price money,
	@StoreId bigint,
	@Discount float,
	@VaildDate datetime,
	@TotalPrice money,
	@ReoderFlag bit,
	@TotReOderPrice money,
	@PRODUCTBRAND nvarchar(30),
	@Original_Inv_Product_Id bigint,
	@Original_InvId bigint,
	@Original_ProductId bigint,
	@Original_UnitId bigint,
	@Original_Qty float,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@Original_Price money,
	@Original_StoreId bigint,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ReoderFlag bit,
	@Original_ReoderFlag bit,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30),
	@Inv_Product_Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [InvOrders_Products] SET [InvId] = @InvId, [ProductId] = @ProductId, [UnitId] = @UnitId, [Qty] = @Qty, [ReorderQty] = @ReorderQty, [Price] = @Price, [StoreId] = @StoreId, [Discount] = @Discount, [VaildDate] = @VaildDate, [TotalPrice] = @TotalPrice, [ReoderFlag] = @ReoderFlag, [TotReOderPrice] = @TotReOderPrice, [PRODUCTBRAND] = @PRODUCTBRAND WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)));
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND FROM InvOrders_Products WHERE (Inv_Product_Id = @Inv_Product_Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ StockMoveDetailsDelete]
(
	@Original_DetId bigint,
	@IsNull_MoveId bigint,
	@Original_MoveId bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_MovmentQty float
)
AS
	SET NOCOUNT OFF;
DELETE FROM [StockMoveDetails] WHERE (([DetId] = @Original_DetId) AND ((@IsNull_MoveId = 1 AND [MoveId] IS NULL) OR ([MoveId] = @Original_MoveId)) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([MovmentQty] = @Original_MovmentQty))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ StockMoveDetailsInsert]
(
	@MoveId bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@MovmentQty float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [StockMoveDetails] ([MoveId], [PRODUCTID], [UnitID], [MovmentQty]) VALUES (@MoveId, @PRODUCTID, @UnitID, @MovmentQty);
	
SELECT DetId, MoveId, PRODUCTID, UnitID, MovmentQty FROM StockMoveDetails WHERE (DetId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ StockMoveDetailsSelect]
AS
	SET NOCOUNT ON;
SELECT     DetId, MoveId, PRODUCTID, UnitID, MovmentQty
FROM         StockMoveDetails







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.[usp_ StockMoveDetailsUpdate]
(
	@MoveId bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@MovmentQty float,
	@Original_DetId bigint,
	@IsNull_MoveId bigint,
	@Original_MoveId bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_MovmentQty float,
	@DetId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [StockMoveDetails] SET [MoveId] = @MoveId, [PRODUCTID] = @PRODUCTID, [UnitID] = @UnitID, [MovmentQty] = @MovmentQty WHERE (([DetId] = @Original_DetId) AND ((@IsNull_MoveId = 1 AND [MoveId] IS NULL) OR ([MoveId] = @Original_MoveId)) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([MovmentQty] = @Original_MovmentQty));
	
SELECT DetId, MoveId, PRODUCTID, UnitID, MovmentQty FROM StockMoveDetails WHERE (DetId = @DetId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Absence_ViewSelect
AS
	SET NOCOUNT ON;
SELECT     AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE, FName, SName, 
                      TName, FoName, FullName, TITLE, DEPT_DESC, DEPTCODE,EmpNum
FROM         Absence_View






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_Absence_ViewSelectByParam
@EMP_CODE bigint ,
@DEPTCODE bigint ,
@FromDate smalldatetime,
@ToDate smalldatetime,
@EmpNum bigint
AS
	SET NOCOUNT ON;
SELECT     AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE, FName, SName, 
                      TName, FoName, FullName, TITLE, DEPT_DESC, DEPTCODE,EmpNum
FROM         Absence_View
where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and (START_DATE>=@FromDate or @FromDate is null) and (START_DATE<=@ToDate or @ToDate is null)

and (EmpNum=@EmpNum or @EmpNum is null)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountA3marAlDauan (
	
 @BrachId bigint,
 @FromDate smalldatetime,
 @FromDate30 smalldatetime,
 @FromDate60 smalldatetime,
 @FromDate90 smalldatetime,
 @ToDate smalldatetime,
 @ACCOUNTID bigint
)
as
SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId,
 dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) ) AS  TotalBalance,
	ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate30,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate30,@ToDate),0) ) AS  TotalBalance30,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate60,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate60,@ToDate),0) ) AS  TotalBalance60,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate90,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate60,@ToDate),0) ) AS  TotalBalance90
FROM         dbo.accounting INNER JOIN
                      dbo.SUPPLIERS_CUSTOMERS ON dbo.accounting.accountid = dbo.SUPPLIERS_CUSTOMERS.accountid
WHERE     (dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE > 1)
and  (dbo.accounting.ACCOUNTID = @ACCOUNTID or @ACCOUNTID is null)  and (dbo.accounting.accountid>4)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountA3marAlDauanMonths (
	
  @BrachId bigint,
 @FromDate1 smalldatetime,
 @ToDate1 smalldatetime,
 @FromDate2 smalldatetime,
 @ToDate2 smalldatetime,
 @FromDate3 smalldatetime,
 @ToDate3 smalldatetime,
 @FromDate4 smalldatetime,
 @ToDate4 smalldatetime,
 @FromDate5 smalldatetime,
 @ToDate5 smalldatetime,
 @FromDate6 smalldatetime,
 @ToDate6 smalldatetime,
 @FromDate7 smalldatetime,
 @ToDate7 smalldatetime,
 @FromDate8 smalldatetime,
 @ToDate8 smalldatetime,
 @FromDate9 smalldatetime,
 @ToDate9 smalldatetime,
 @FromDate10 smalldatetime,
 @ToDate10 smalldatetime,
 @FromDate11 smalldatetime,
 @ToDate11 smalldatetime,
 @FromDate12 smalldatetime,
 @ToDate12 smalldatetime,
 @ACCOUNTID bigint)
as
SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId,
 dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate1,@ToDate1) AS totalFromValue
             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate1,@ToDate1) AS totalToValue,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate1,@ToDate1) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate1,@ToDate1),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate1,@ToDate1) AS  TotalBalance1,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate2,@ToDate2) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate2,@ToDate2),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate2,@ToDate2) AS  TotalBalance2,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate3,@ToDate3) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate3,@ToDate3),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate3,@ToDate3) AS  TotalBalance3,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate4,@ToDate4) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate4,@ToDate4),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate4,@ToDate4) AS  TotalBalance4,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate5,@ToDate5) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate5,@ToDate5),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate5,@ToDate5) AS  TotalBalance5,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate6,@ToDate6) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate6,@ToDate6),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate6,@ToDate6) AS  TotalBalance6,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate7,@ToDate7) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate7,@ToDate7),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate7,@ToDate7) AS  TotalBalance7,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate8,@ToDate8) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate8,@ToDate8),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate8,@ToDate8) AS  TotalBalance8,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate9,@ToDate9) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate9,@ToDate9),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate9,@ToDate9) AS  TotalBalance9,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate10,@ToDate10) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate10,@ToDate10),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate10,@ToDate10) AS  TotalBalance10,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate11,@ToDate11) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate11,@ToDate11),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate11,@ToDate11) AS  TotalBalance11,
ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate12,@ToDate12) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate12,@ToDate12),0) )-
 dbo.fn_Select_InvoicePayment(dbo.accounting.accountid,@BrachId,@FromDate12,@ToDate12) AS  TotalBalance12
FROM         dbo.accounting INNER JOIN
                      dbo.SUPPLIERS_CUSTOMERS ON dbo.accounting.accountid = dbo.SUPPLIERS_CUSTOMERS.accountid
WHERE     (dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE > 1)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO






















CREATE PROCEDURE usp_AccountBeforeTotRefBalance  

(

@ACCOUNTID bigint,
@BrachId bigint,
@FromDate smalldatetime,
@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime
 
)
AS
select sum( (isnull(dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore),0) - isnull(dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) ,0)) ) AS TotalBalanceB
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






create PROCEDURE [dbo].[usp_AccountBeforeTotRefBalanceLast]  

(

@ACCOUNTID bigint,
@BrachId bigint,
@FromDate smalldatetime,
@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime,
@StartDate smalldatetime
)
AS
select sum( (isnull(dbo.fn_Select_totalToValuebeforeNEWLast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,null),0) - isnull(dbo.fn_Select_totalFromValuebeforeNEWLast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,null) ,0)) ) AS TotalBalanceB
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null ) 








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountDauanTotFromValue (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
as
SELECT    Sum(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate))AS totalFromValue
             
--,Sum((isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) )- sum(isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) )) AS  TotalBalance
FROM         dbo.accounting 
WHERE     (dbo.accounting.accountid = @ACCOUNTID or @ACCOUNTID is null)  --and (dbo.accounting.accountid>4)
--SELECT     ACCOUNTID, accountname, AccountCode,SUM(FromValue) AS totalFromValue, SUM(ToValue) AS totalToValue,ABS(isnull(SUM(ToValue),0) - isnull(SUM(FromValue),0) )
--                      AS totalBalance
--FROM         AccountingView
--WHERE     (AccountparentId = @ACCOUNTID ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
--WHERE     (AccountparentId = 14)
--GROUP BY ACCOUNTID, accountname,AccountCode








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountDauanTotToValue (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
as
SELECT     --Sum(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) )AS totalFromValue
             Sum(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ) AS totalToValue
--,Sum((isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) )- sum(isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) )) AS  TotalBalance
FROM         dbo.accounting 
WHERE     (dbo.accounting.accountid = @ACCOUNTID or @ACCOUNTID is null)  --and (dbo.accounting.accountid>4)
--SELECT     ACCOUNTID, accountname, AccountCode,SUM(FromValue) AS totalFromValue, SUM(ToValue) AS totalToValue,ABS(isnull(SUM(ToValue),0) - isnull(SUM(FromValue),0) )
--                      AS totalBalance
--FROM         AccountingView
--WHERE     (AccountparentId = @ACCOUNTID ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
--WHERE     (AccountparentId = 14)
--GROUP BY ACCOUNTID, accountname,AccountCode








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountGetTotalSum (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
as
SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
	ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) ) AS  TotalBalance
FROM         dbo.accounting 
WHERE     (dbo.accounting.accountid = @ACCOUNTID or @ACCOUNTID is null)  and (dbo.accounting.accountid>4)
--SELECT     ACCOUNTID, accountname, AccountCode,SUM(FromValue) AS totalFromValue, SUM(ToValue) AS totalToValue,ABS(isnull(SUM(ToValue),0) - isnull(SUM(FromValue),0) )
--                      AS totalBalance
--FROM         AccountingView
--WHERE     (AccountparentId = @ACCOUNTID ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
--WHERE     (AccountparentId = 14)
--GROUP BY ACCOUNTID, accountname,AccountCode








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE usp_AccountSelectAllTotRefBalance (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime,
@flag int
)
as
if (@flag=1)
begin
	SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel, dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
	             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
	(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)  ,0) - isnull(  dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)   ,0) ) AS TotalBalance,
	dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalFromValueB,
	dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalToValueB,
	(isnull(dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore),0) - isnull(dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) ,0)) AS TotalBalanceB
,Mainnode
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.AccountparentId = @ACCOUNTID or  @ACCOUNTID is null ) 
order by  accounting.AccountCode
end
else
begin
	 SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel,dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
		             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
		(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)  ,0) - isnull(  dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)   ,0) ) AS TotalBalance,
		dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalFromValueB,
		dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalToValueB,
		(isnull(dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore),0) - isnull(dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) ,0)) AS TotalBalanceB
,Mainnode
		FROM         dbo.accounting 
		WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null ) 
order by  accounting.AccountCode
end






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountSelectTotBalance (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
as
SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
	ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) ) AS  TotalBalance,Mainnode
FROM         dbo.accounting 
WHERE     (dbo.accounting.AccountparentId = @ACCOUNTID or @ACCOUNTID is null)  and (dbo.accounting.accountid>4)
--SELECT     ACCOUNTID, accountname, AccountCode,SUM(FromValue) AS totalFromValue, SUM(ToValue) AS totalToValue,ABS(isnull(SUM(ToValue),0) - isnull(SUM(FromValue),0) )
--                      AS totalBalance
--FROM         AccountingView
--WHERE     (AccountparentId = @ACCOUNTID ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
--WHERE     (AccountparentId = 14)
--GROUP BY ACCOUNTID, accountname,AccountCode






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE usp_AccountSelectTotRefBalance (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime,
@flag int
)
as
if (@flag=1)
begin
	SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel, dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
	             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
	(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)  ,0) - isnull(  dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)   ,0) ) AS TotalBalance,
	dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalFromValueB,
	dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalToValueB,
	(isnull(dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore),0) - isnull(dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) ,0)) AS TotalBalanceB
,Mainnode
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.AccountparentId = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end
else
begin
	 SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel,dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalFromValue
		             , dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) AS totalToValue,
		(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)  ,0) - isnull(  dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate)   ,0) ) AS TotalBalance,
		dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalFromValueB,
		dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) AS totalToValueB,
		(isnull(dbo.fn_Select_totalToValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore),0) - isnull(dbo.fn_Select_totalFromValuebefore(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore) ,0)) AS TotalBalanceB
,Mainnode
		FROM         dbo.accounting 
		WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE usp_AccountSelectTotRefBalanceIncome (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime,
@flag int,
@CostId bigint
)
as
if (@flag=1)
begin
	SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel, dbo.fn_Select_totalFromValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalFromValue
	             , dbo.fn_Select_totalToValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalToValue,
	(isnull(dbo.fn_Select_totalToValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)  ,0) - isnull(  dbo.fn_Select_totalFromValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)   ,0) ) AS TotalBalance,
	dbo.fn_Select_totalFromValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) AS totalFromValueB,
	dbo.fn_Select_totalToValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) AS totalToValueB,
	(isnull(dbo.fn_Select_totalToValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId),0) - isnull(dbo.fn_Select_totalFromValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) ,0)) AS TotalBalanceB
,Mainnode
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.AccountparentId = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end
else
begin
	 SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel,dbo.fn_Select_totalFromValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalFromValue
		             , dbo.fn_Select_totalToValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalToValue,
		(isnull(dbo.fn_Select_totalToValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)  ,0) - isnull(  dbo.fn_Select_totalFromValueIncome(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)   ,0) ) AS TotalBalance,
		dbo.fn_Select_totalFromValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) AS totalFromValueB,
		dbo.fn_Select_totalToValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) AS totalToValueB,
		(isnull(dbo.fn_Select_totalToValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId),0) - isnull(dbo.fn_Select_totalFromValuebeforeIncome(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@CostId) ,0)) AS TotalBalanceB
,Mainnode
		FROM         dbo.accounting 
		WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE usp_AccountSelectTotRefBalanceNewLast (
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
@FromDateBefore smalldatetime,
@ToDateBefore smalldatetime,
@StartDate smalldatetime,
@flag int,
@CostId bigint
)
as
if (@flag=1)
begin
	SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel, dbo.fn_Select_totalFromValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalFromValue
	             , dbo.fn_Select_totalToValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalToValue,
	(isnull(dbo.fn_Select_totalToValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)  ,0) - isnull(  dbo.fn_Select_totalFromValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)   ,0) ) AS TotalBalance,
	dbo.fn_Select_totalFromValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) AS totalFromValueB,
	dbo.fn_Select_totalToValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) AS totalToValueB,
	(isnull(dbo.fn_Select_totalToValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId),0) - isnull(dbo.fn_Select_totalFromValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) ,0)) AS TotalBalanceB
,Mainnode
	FROM         dbo.accounting 
	WHERE     (dbo.accounting.AccountparentId = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end
else
begin
	 SELECT     dbo.accounting.accountid, dbo.accounting.AccountCode, dbo.accounting.accountname,dbo.accounting.AccountparentId, AccLevel,dbo.fn_Select_totalFromValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalFromValue
		             , dbo.fn_Select_totalToValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId) AS totalToValue,
		(isnull(dbo.fn_Select_totalToValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)  ,0) - isnull(  dbo.fn_Select_totalFromValueNewlast(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate,@CostId)   ,0) ) AS TotalBalance,
		dbo.fn_Select_totalFromValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) AS totalFromValueB,
		dbo.fn_Select_totalToValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) AS totalToValueB,
		(isnull(dbo.fn_Select_totalToValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId),0) - isnull(dbo.fn_Select_totalFromValuebeforeNewlast(dbo.accounting.accountid,@BrachId,@FromDateBefore,@ToDateBefore,@StartDate,@CostId) ,0)) AS TotalBalanceB
,Mainnode
		FROM         dbo.accounting 
		WHERE     (dbo.accounting.accountid = @ACCOUNTID or  @ACCOUNTID is null ) and dbo.accounting.accountid>4
order by  accounting.AccountCode
end







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_AccountUpdateBalance
(
	@accountParentId bigint,@DifTotalFromvalue money ,@DifTotalTovalue money
)
AS
	
BEGIN
DECLARE @accountid bigint 
set @accountid=-1
 SELECT @accountid= AccountparentId    FROM   accounting   WHERE accountid = @accountParentId
update accounting set Totalfromvalue = ISNULL(Totalfromvalue, 0)+ISNULL(@DifTotalFromvalue,0) where accountId = @accountParentId 
update accounting set TotalTovalue = ISNULL(TotalTovalue, 0)+ISNULL(@DifTotalTovalue,0) where accountId = @accountParentId 
if (@accountid>-1)
BEGIN
	exec  usp_AccountUpdateBalance @accountid,@DifTotalFromvalue,@DifTotalTovalue
END
end








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_AccountUpdateClosedTo
(
	@accountId bigint,@ClosedTo bigint
)
AS
	
BEGIN
DECLARE @Newaccountid bigint 
--set @accountid=-1
 --SELECT @accountid= AccountparentId    FROM   accounting   WHERE accountid = @accountParentId
update accounting set ClosedTo =@ClosedTo where accountParentId  = @accountId 
DECLARE c1 CURSOR LOCAL FOR
   SELECT accountId
   FROM  accounting
   WHERE accountParentId  = @accountId 
OPEN c1
FETCH NEXT FROM c1 INTO @Newaccountid
WHILE @@fetch_status = 0
BEGIN
exec  usp_AccountUpdateClosedTo  @Newaccountid,@ClosedTo
   
   FETCH NEXT FROM c1 INTO @Newaccountid
END
CLOSE c1
DEALLOCATE c1
--if (@accountid>-1)
--BEGIN
	--exec  usp_AccountUpdateClosedTo  @accountId,@ClosedTo
--END
end








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_AccountingGetAll
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, 
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo
FROM         accounting






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_AccountingSelectByAccId
(
	@ACCOUNTID int
)
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, 
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId
FROM         accounting
WHERE     (AccountparentId = @ACCOUNTID) AND (accountid > 4) OR
                      (accountid > 4) AND (@ACCOUNTID IS NULL)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_AccountingSelectClosedTo
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, 
                      balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag
FROM         accounting
WHERE     (accountType = 2)
ORDER BY accountid DESC








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_AccountingViewByPayQidId
(
	@QidId bigint
)
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate, QidTypeDesc, AccountparentId, AccountCode, PaymentType, recitetype, Cust_Sup_Accid, 
                      SUP_CUST_ID, ChequeNo, QidPaymentType, CostId, repeated,Machineid
FROM         AccountingView
WHERE     (ToValue IS NOT NULL) AND (qidid = @QidId)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_AccountingViewByQidId
(
	@QidId bigint
)
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate, QidTypeDesc, AccountparentId, AccountCode, PaymentType, recitetype, 
                      Cust_Sup_Accid, SUP_CUST_ID, ChequeNo, QidPaymentType,Machineid
FROM         AccountingView
WHERE     (qidid = @QidId)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_AccountingViewSelect
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate, QidTypeDesc, AccountparentId, AccountCode, PaymentType, recitetype, Cust_Sup_Accid, 
                      SUP_CUST_ID, ChequeNo, QidPaymentType, CostId, repeated, YearqidDate, QidMonth,Machineid
FROM         AccountingView


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_AccountingViewSelectByParm
(
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
@CostID bigint,
@Machineid bigint)
AS
	SET NOCOUNT ON;

SELECT   ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate,AccountparentId, AccountCode,QidTypeDesc,(isnull(FromValue,0 )-isnull(ToValue,0 )) as Total, CostId,Machineid
FROM         AccountingView

WHERE     (ACCOUNTID = @ACCOUNTID or @ACCOUNTID  IS NULL ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
  and  ( invId in (select InvId from dbo.Inv_Products where ProductId=@ProductId)  or @ProductId is null ) and   (CostID = @CostID or @CostID  IS NULL ) and   (Machineid  = @Machineid or @Machineid  IS NULL ) 
order by qidDate

/*SELECT   ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate,AccountparentId, AccountCode,QidTypeDesc,(isnull(FromValue,0 )-isnull(ToValue,0 )) as Total, CostId,recitetype
FROM         AccountingView
WHERE     (ACCOUNTID = @ACCOUNTID or @ACCOUNTID  IS NULL ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
  and  ( invId in (select InvId from dbo.Inv_Products where ProductId=@ProductId)  or @ProductId is null ) and   (CostID = @CostID or @CostID  IS NULL ) 
order by qidDate
GO*/


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE [dbo].[usp_AccountingViewSelectNotStartByParm]
(
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
	@CostID bigint,
@Machineid bigint)
AS
	SET NOCOUNT ON;
SELECT   ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate,AccountparentId, AccountCode,QidTypeDesc,(isnull(FromValue,0 )-isnull(ToValue,0 )) as Total, CostId,YearqidDate, QidMonth
,Machineid,ChequeNo


FROM         AccountingView
WHERE     (ACCOUNTID = @ACCOUNTID or @ACCOUNTID  IS NULL ) 
AND (BrachId = @BrachId or @BrachId is null )
AND (qidDate >= @FromDate or @FromDate is null ) 
AND (qidDate <= @ToDate or @ToDate is null)
and  ( invId in (select InvId from dbo.Inv_Products where ProductId=@ProductId)  or @ProductId is null ) 
and   (CostID = @CostID or @CostID  IS NULL ) and (repeated <> 1 or repeated is null) and   (Machineid = @Machineid or @Machineid  IS NULL ) 
order by qidDate


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE PROCEDURE [dbo].[usp_AccountingViewSelectNotStartNoMovingByParm]
(
	@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
	@CostID bigint,
	@Machineid bigint
)
AS
	SET NOCOUNT ON;
SELECT   ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate,AccountparentId, AccountCode,QidTypeDesc,(isnull(FromValue,0 )-isnull(ToValue,0 )) as Total, CostId,YearqidDate, QidMonth
,Machineid

FROM         AccountingView
WHERE     (ACCOUNTID = @ACCOUNTID or @ACCOUNTID  IS NULL ) 
AND (BrachId = @BrachId or @BrachId is null )
AND (qidDate >= @FromDate or @FromDate is null ) 
AND (qidDate <= @ToDate or @ToDate is null)
and  ( invId in (select InvId from dbo.Inv_Products where ProductId=@ProductId)  or @ProductId is null ) 
and   (CostID = @CostID or @CostID  IS NULL ) 
and   (Machineid = @Machineid or @Machineid  IS NULL ) 
--and (repeated <> 1 or repeated is null)
order by qidDate


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_AccountingViewbyRecitetype
(
	@recitetype int,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate, QidTypeDesc, AccountparentId, AccountCode, PaymentType, recitetype, 
                      Cust_Sup_Accid, SUP_CUST_ID, ChequeNo, QidPaymentType,Machineid
FROM         AccountingView
WHERE     (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)and (recitetype = @recitetype)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Allowance_ViewSelect
AS
	SET NOCOUNT ON;
SELECT     AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, FName, SName, TName, FoName, FEngName, TITLE, 
                      DEPT_DESC, DEPTCODE, FullName,EmpNum
FROM         Allowance_View







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.[usp_Allowance_ViewSelectbyParam]
@EMP_CODE bigint ,
@DEPTCODE bigint ,
@FromDate smalldatetime,
@ToDate smalldatetime,
@EmpNum bigint
AS
	SET NOCOUNT ON;
SELECT     AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, FName, SName, TName, FoName, FEngName, TITLE, 
                      DEPT_DESC, DEPTCODE, FullName,EmpNum
FROM         Allowance_View
where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and (DISCOUNT_DATE>=@FromDate or @FromDate is null) and (DISCOUNT_DATE<=@ToDate or @ToDate is null)
and (EmpNum=@EmpNum or @EmpNum is null)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO










CREATE PROCEDURE usp_BoxCheck (
	@branchId bigint,
	@StartDate smalldatetime,
	@EndDate smalldatetime,
@EmpId int
)
as
SELECT     isnull(SUM(KeyNetValue) ,0) AS totalKeyNet, isnull(SUM(VisaValue),0) AS totalVisa, isnull(SUM(MasterValue),0)  AS totalMaster, isnull(SUM(ChequeValue),0)  AS totalCheque, 
                      SUM(OtherValue) AS totalOther, isnull(SUM(PaymentValue),0) AS totalPayment, isnull(SUM(InvTotalNet),0) AS totalSalNet,  isnull(SUM(PaymentValue) ,0) AS totalCashNet,
	 -- isnull(SUM(TotalReoderNet) ,0) AS totalReorderNet,
 isnull((SELECT     SUM(FromValue)
                             FROM         AccountingView
                             WHERE    (EmpId=@EmpId) and  (QidType = 8) AND (BrachId = @branchId) and QidDate>=@StartDate and QidDate<=@EndDate) ,0) AS totalReorderNet,

                         isnull( (SELECT     SUM(FromValue)
                             FROM         AccountingView
                             WHERE    (EmpId=@EmpId) and  (QidType = 7) AND (BrachId = @branchId) and QidDate>=@StartDate and QidDate<=@EndDate  ) ,0 ) AS totalGetQidvalue,
 isnull((SELECT     SUM(FromValue)
                             FROM         AccountingView
                             WHERE    (EmpId=@EmpId) and  (QidType = 6) AND (BrachId = @branchId) and QidDate>=@StartDate and QidDate<=@EndDate) ,0) AS totalOutQidvalue

,isnull((select   SUM(InvTotalNet)   FROM dbo.InvoiceView WHERE (InvType = 1) and PaymentType=2 AND (BranchId = @branchId) and InvDate>=@StartDate and InvDate<=@EndDate ),0)AS totalPurNet
FROM         dbo.InvoiceView

WHERE     (EmpId=@EmpId) and (InvType = 2) AND (BranchId = @branchId) and InvDate>=@StartDate and InvDate<=@EndDate







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_BranchesDelete
(
	@Original_BRANCHCODE bigint,
	@Original_BRANCHNAME varchar(100),
	@IsNull_CompanyName nvarchar(150),
	@Original_CompanyName nvarchar(150),
	@IsNull_Address nvarchar(150),
	@Original_Address nvarchar(150),
	@IsNull_TelPhone nvarchar(100),
	@Original_TelPhone nvarchar(100),
	@IsNull_HintName varchar(50),
	@Original_HintName varchar(50),
	@IsNull_SalInvSerial bigint,
	@Original_SalInvSerial bigint,
	@IsNull_PurchInvSerial bigint,
	@Original_PurchInvSerial bigint,
	@IsNull_InvOrderSerial bigint,
	@Original_InvOrderSerial bigint,
	@IsNull_OrderSerial bigint,
	@Original_OrderSerial bigint,
	@IsNull_MovementSerial bigint,
	@Original_MovementSerial bigint,
	@IsNull_salesaccid smallint,
	@Original_salesaccid smallint,
	@IsNull_purchaseaccid smallint,
	@Original_purchaseaccid smallint,
	@IsNull_boxaccid bigint,
	@Original_boxaccid bigint,
	@IsNull_bankaccid bigint,
	@Original_bankaccid bigint,
	@IsNull_Visaaccid bigint,
	@Original_Visaaccid bigint,
	@IsNull_Masteraccid bigint,
	@Original_Masteraccid bigint,
	@IsNull_KeyNetaccid bigint,
	@Original_KeyNetaccid bigint,
	@IsNull_Otheraccid bigint,
	@Original_Otheraccid bigint,
	@IsNull_VisaComaccid bigint,
	@Original_VisaComaccid bigint,
	@IsNull_MasterComaccid bigint,
	@Original_MasterComaccid bigint,
	@IsNull_KeyNetComaccid bigint,
	@Original_KeyNetComaccid bigint,
	@IsNull_OtherComaccid bigint,
	@Original_OtherComaccid bigint,
	@IsNull_salesAgalaccid bigint,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseAgalaaccid bigint,
	@Original_purchaseAgalaaccid bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [BRANCHES] WHERE (([BRANCHCODE] = @Original_BRANCHCODE) AND ([BRANCHNAME] = @Original_BRANCHNAME) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_HintName = 1 AND [HintName] IS NULL) OR ([HintName] = @Original_HintName)) AND ((@IsNull_SalInvSerial = 1 AND [SalInvSerial] IS NULL) OR ([SalInvSerial] = @Original_SalInvSerial)) AND ((@IsNull_PurchInvSerial = 1 AND [PurchInvSerial] IS NULL) OR ([PurchInvSerial] = @Original_PurchInvSerial)) AND ((@IsNull_InvOrderSerial = 1 AND [InvOrderSerial] IS NULL) OR ([InvOrderSerial] = @Original_InvOrderSerial)) AND ((@IsNull_OrderSerial = 1 AND [OrderSerial] IS NULL) OR ([OrderSerial] = @Original_OrderSerial)) AND ((@IsNull_MovementSerial = 1 AND [MovementSerial] IS NULL) OR ([MovementSerial] = @Original_MovementSerial)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_Visaaccid = 1 AND [Visaaccid] IS NULL) OR ([Visaaccid] = @Original_Visaaccid)) AND ((@IsNull_Masteraccid = 1 AND [Masteraccid] IS NULL) OR ([Masteraccid] = @Original_Masteraccid)) AND ((@IsNull_KeyNetaccid = 1 AND [KeyNetaccid] IS NULL) OR ([KeyNetaccid] = @Original_KeyNetaccid)) AND ((@IsNull_Otheraccid = 1 AND [Otheraccid] IS NULL) OR ([Otheraccid] = @Original_Otheraccid)) AND ((@IsNull_VisaComaccid = 1 AND [VisaComaccid] IS NULL) OR ([VisaComaccid] = @Original_VisaComaccid)) AND ((@IsNull_MasterComaccid = 1 AND [MasterComaccid] IS NULL) OR ([MasterComaccid] = @Original_MasterComaccid)) AND ((@IsNull_KeyNetComaccid = 1 AND [KeyNetComaccid] IS NULL) OR ([KeyNetComaccid] = @Original_KeyNetComaccid)) AND ((@IsNull_OtherComaccid = 1 AND [OtherComaccid] IS NULL) OR ([OtherComaccid] = @Original_OtherComaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseAgalaaccid = 1 AND [purchaseAgalaaccid] IS NULL) OR ([purchaseAgalaaccid] = @Original_purchaseAgalaaccid)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_BranchesInsert
(
	@BRANCHNAME varchar(100),
	@CompanyName nvarchar(150),
	@Address nvarchar(150),
	@TelPhone nvarchar(100),
	@HintName varchar(50),
	@SalInvSerial bigint,
	@PurchInvSerial bigint,
	@InvOrderSerial bigint,
	@OrderSerial bigint,
	@MovementSerial bigint,
	@salesaccid smallint,
	@purchaseaccid smallint,
	@boxaccid bigint,
	@bankaccid bigint,
	@Visaaccid bigint,
	@Masteraccid bigint,
	@KeyNetaccid bigint,
	@Otheraccid bigint,
	@VisaComaccid bigint,
	@MasterComaccid bigint,
	@KeyNetComaccid bigint,
	@OtherComaccid bigint,
	@salesAgalaccid bigint,
	@purchaseAgalaaccid bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [BRANCHES] ([BRANCHNAME], [CompanyName], [Address], [TelPhone], [HintName], [SalInvSerial], [PurchInvSerial], [InvOrderSerial], [OrderSerial], [MovementSerial], [salesaccid], [purchaseaccid], [boxaccid], [bankaccid], [Visaaccid], [Masteraccid], [KeyNetaccid], [Otheraccid], [VisaComaccid], [MasterComaccid], [KeyNetComaccid], [OtherComaccid], [salesAgalaccid], [purchaseAgalaaccid]) VALUES (@BRANCHNAME, @CompanyName, @Address, @TelPhone, @HintName, @SalInvSerial, @PurchInvSerial, @InvOrderSerial, @OrderSerial, @MovementSerial, @salesaccid, @purchaseaccid, @boxaccid, @bankaccid, @Visaaccid, @Masteraccid, @KeyNetaccid, @Otheraccid, @VisaComaccid, @MasterComaccid, @KeyNetComaccid, @OtherComaccid, @salesAgalaccid, @purchaseAgalaaccid);
	
SELECT BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, MovementSerial, salesaccid, purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, OtherComaccid, salesAgalaccid, purchaseAgalaaccid FROM BRANCHES WHERE (BRANCHCODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_BranchesSelect
AS
	SET NOCOUNT ON;
SELECT     BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, 
                      MovementSerial, salesaccid, purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, 
                      KeyNetComaccid, OtherComaccid, salesAgalaccid, purchaseAgalaaccid
FROM         BRANCHES







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_BranchesUpdate
(
	@BRANCHNAME varchar(100),
	@CompanyName nvarchar(150),
	@Address nvarchar(150),
	@TelPhone nvarchar(100),
	@HintName varchar(50),
	@SalInvSerial bigint,
	@PurchInvSerial bigint,
	@InvOrderSerial bigint,
	@OrderSerial bigint,
	@MovementSerial bigint,
	@salesaccid smallint,
	@purchaseaccid smallint,
	@boxaccid bigint,
	@bankaccid bigint,
	@Visaaccid bigint,
	@Masteraccid bigint,
	@KeyNetaccid bigint,
	@Otheraccid bigint,
	@VisaComaccid bigint,
	@MasterComaccid bigint,
	@KeyNetComaccid bigint,
	@OtherComaccid bigint,
	@salesAgalaccid bigint,
	@purchaseAgalaaccid bigint,
	@Original_BRANCHCODE bigint,
	@Original_BRANCHNAME varchar(100),
	@IsNull_CompanyName nvarchar(150),
	@Original_CompanyName nvarchar(150),
	@IsNull_Address nvarchar(150),
	@Original_Address nvarchar(150),
	@IsNull_TelPhone nvarchar(100),
	@Original_TelPhone nvarchar(100),
	@IsNull_HintName varchar(50),
	@Original_HintName varchar(50),
	@IsNull_SalInvSerial bigint,
	@Original_SalInvSerial bigint,
	@IsNull_PurchInvSerial bigint,
	@Original_PurchInvSerial bigint,
	@IsNull_InvOrderSerial bigint,
	@Original_InvOrderSerial bigint,
	@IsNull_OrderSerial bigint,
	@Original_OrderSerial bigint,
	@IsNull_MovementSerial bigint,
	@Original_MovementSerial bigint,
	@IsNull_salesaccid smallint,
	@Original_salesaccid smallint,
	@IsNull_purchaseaccid smallint,
	@Original_purchaseaccid smallint,
	@IsNull_boxaccid bigint,
	@Original_boxaccid bigint,
	@IsNull_bankaccid bigint,
	@Original_bankaccid bigint,
	@IsNull_Visaaccid bigint,
	@Original_Visaaccid bigint,
	@IsNull_Masteraccid bigint,
	@Original_Masteraccid bigint,
	@IsNull_KeyNetaccid bigint,
	@Original_KeyNetaccid bigint,
	@IsNull_Otheraccid bigint,
	@Original_Otheraccid bigint,
	@IsNull_VisaComaccid bigint,
	@Original_VisaComaccid bigint,
	@IsNull_MasterComaccid bigint,
	@Original_MasterComaccid bigint,
	@IsNull_KeyNetComaccid bigint,
	@Original_KeyNetComaccid bigint,
	@IsNull_OtherComaccid bigint,
	@Original_OtherComaccid bigint,
	@IsNull_salesAgalaccid bigint,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseAgalaaccid bigint,
	@Original_purchaseAgalaaccid bigint,
	@BRANCHCODE bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [BRANCHES] SET [BRANCHNAME] = @BRANCHNAME, [CompanyName] = @CompanyName, [Address] = @Address, [TelPhone] = @TelPhone, [HintName] = @HintName, [SalInvSerial] = @SalInvSerial, [PurchInvSerial] = @PurchInvSerial, [InvOrderSerial] = @InvOrderSerial, [OrderSerial] = @OrderSerial, [MovementSerial] = @MovementSerial, [salesaccid] = @salesaccid, [purchaseaccid] = @purchaseaccid, [boxaccid] = @boxaccid, [bankaccid] = @bankaccid, [Visaaccid] = @Visaaccid, [Masteraccid] = @Masteraccid, [KeyNetaccid] = @KeyNetaccid, [Otheraccid] = @Otheraccid, [VisaComaccid] = @VisaComaccid, [MasterComaccid] = @MasterComaccid, [KeyNetComaccid] = @KeyNetComaccid, [OtherComaccid] = @OtherComaccid, [salesAgalaccid] = @salesAgalaccid, [purchaseAgalaaccid] = @purchaseAgalaaccid WHERE (([BRANCHCODE] = @Original_BRANCHCODE) AND ([BRANCHNAME] = @Original_BRANCHNAME) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_HintName = 1 AND [HintName] IS NULL) OR ([HintName] = @Original_HintName)) AND ((@IsNull_SalInvSerial = 1 AND [SalInvSerial] IS NULL) OR ([SalInvSerial] = @Original_SalInvSerial)) AND ((@IsNull_PurchInvSerial = 1 AND [PurchInvSerial] IS NULL) OR ([PurchInvSerial] = @Original_PurchInvSerial)) AND ((@IsNull_InvOrderSerial = 1 AND [InvOrderSerial] IS NULL) OR ([InvOrderSerial] = @Original_InvOrderSerial)) AND ((@IsNull_OrderSerial = 1 AND [OrderSerial] IS NULL) OR ([OrderSerial] = @Original_OrderSerial)) AND ((@IsNull_MovementSerial = 1 AND [MovementSerial] IS NULL) OR ([MovementSerial] = @Original_MovementSerial)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_Visaaccid = 1 AND [Visaaccid] IS NULL) OR ([Visaaccid] = @Original_Visaaccid)) AND ((@IsNull_Masteraccid = 1 AND [Masteraccid] IS NULL) OR ([Masteraccid] = @Original_Masteraccid)) AND ((@IsNull_KeyNetaccid = 1 AND [KeyNetaccid] IS NULL) OR ([KeyNetaccid] = @Original_KeyNetaccid)) AND ((@IsNull_Otheraccid = 1 AND [Otheraccid] IS NULL) OR ([Otheraccid] = @Original_Otheraccid)) AND ((@IsNull_VisaComaccid = 1 AND [VisaComaccid] IS NULL) OR ([VisaComaccid] = @Original_VisaComaccid)) AND ((@IsNull_MasterComaccid = 1 AND [MasterComaccid] IS NULL) OR ([MasterComaccid] = @Original_MasterComaccid)) AND ((@IsNull_KeyNetComaccid = 1 AND [KeyNetComaccid] IS NULL) OR ([KeyNetComaccid] = @Original_KeyNetComaccid)) AND ((@IsNull_OtherComaccid = 1 AND [OtherComaccid] IS NULL) OR ([OtherComaccid] = @Original_OtherComaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseAgalaaccid = 1 AND [purchaseAgalaaccid] IS NULL) OR ([purchaseAgalaaccid] = @Original_purchaseAgalaaccid)));
	
SELECT BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, MovementSerial, salesaccid, purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, OtherComaccid, salesAgalaccid, purchaseAgalaaccid FROM BRANCHES WHERE (BRANCHCODE = @BRANCHCODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_BANKDelete
(
	@Original_BNK_CODE numeric,
	@Original_BNK_DESC varchar(100)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_BANKS] WHERE (([BNK_CODE] = @Original_BNK_CODE) AND ([BNK_DESC] = @Original_BNK_DESC))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_BANKInsert
(
	@BNK_DESC varchar(100)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_BANKS] ([BNK_DESC]) VALUES (@BNK_DESC);
	
SELECT BNK_CODE, BNK_DESC FROM CDE_BANKS WHERE (BNK_CODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_BANKSSelect
AS
	SET NOCOUNT ON;
SELECT     BNK_CODE, BNK_DESC
FROM         CDE_BANKS







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_BANKUpdate
(
	@BNK_DESC varchar(100),
	@Original_BNK_CODE numeric,
	@Original_BNK_DESC varchar(100),
	@BNK_CODE numeric
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_BANKS] SET [BNK_DESC] = @BNK_DESC WHERE (([BNK_CODE] = @Original_BNK_CODE) AND ([BNK_DESC] = @Original_BNK_DESC));
	
SELECT BNK_CODE, BNK_DESC FROM CDE_BANKS WHERE (BNK_CODE = @BNK_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_LOCATIONDelete
(
	@Original_LocId bigint,
	@IsNull_LocName varchar(200),
	@Original_LocName varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_LOCATION] WHERE (([LocId] = @Original_LocId) AND ((@IsNull_LocName = 1 AND [LocName] IS NULL) OR ([LocName] = @Original_LocName)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_LOCATIONInsert
(
	@LocName varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_LOCATION] ([LocName]) VALUES (@LocName);
	
SELECT LocId, LocName FROM CDE_LOCATION WHERE (LocId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_LOCATIONSelect
AS
	SET NOCOUNT ON;
SELECT     LocId, LocName
FROM         CDE_LOCATION







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_LOCATIONUpdate
(
	@LocName varchar(200),
	@Original_LocId bigint,
	@IsNull_LocName varchar(200),
	@Original_LocName varchar(200),
	@LocId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_LOCATION] SET [LocName] = @LocName WHERE (([LocId] = @Original_LocId) AND ((@IsNull_LocName = 1 AND [LocName] IS NULL) OR ([LocName] = @Original_LocName)));
	
SELECT LocId, LocName FROM CDE_LOCATION WHERE (LocId = @LocId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_Offer_TypesDelete
(
	@Original_OfferTypeID bigint,
	@Original_OfferTypeDesc nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_Offer_Types] WHERE (([OfferTypeID] = @Original_OfferTypeID) AND ([OfferTypeDesc] = @Original_OfferTypeDesc))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_Offer_TypesInsert
(
	@OfferTypeID bigint,
	@OfferTypeDesc nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_Offer_Types] ([OfferTypeID], [OfferTypeDesc]) VALUES (@OfferTypeID, @OfferTypeDesc);
	
SELECT OfferTypeID, OfferTypeDesc FROM CDE_Offer_Types WHERE (OfferTypeID = @OfferTypeID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_Offer_TypesSelect
AS
	SET NOCOUNT ON;
SELECT     OfferTypeID, OfferTypeDesc
FROM         CDE_Offer_Types









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_Offer_TypesUpdate
(
	@OfferTypeID bigint,
	@OfferTypeDesc nvarchar(50),
	@Original_OfferTypeID bigint,
	@Original_OfferTypeDesc nvarchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_Offer_Types] SET [OfferTypeID] = @OfferTypeID, [OfferTypeDesc] = @OfferTypeDesc WHERE (([OfferTypeID] = @Original_OfferTypeID) AND ([OfferTypeDesc] = @Original_OfferTypeDesc));
	
SELECT OfferTypeID, OfferTypeDesc FROM CDE_Offer_Types WHERE (OfferTypeID = @OfferTypeID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_PER_QLFInsert
(
	@QLF_CODE numeric(5, 0),
	@QLF_TYP_CODE numeric(5, 0),
	@QLF_DESC varchar(100),
	@AZHAR_FLAG numeric(1, 0),
	@ROWID uniqueidentifier
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_QLF] ([QLF_CODE], [QLF_TYP_CODE], [QLF_DESC], [AZHAR_FLAG], [ROWID]) VALUES (@QLF_CODE, @QLF_TYP_CODE, @QLF_DESC, @AZHAR_FLAG, @ROWID);
	
SELECT QLF_CODE, QLF_TYP_CODE, QLF_DESC, AZHAR_FLAG, ROWID FROM CDE_PER_QLF WHERE (QLF_CODE = @QLF_CODE) AND (QLF_TYP_CODE = @QLF_TYP_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CDE_PER_QLFSelect
AS
	SET NOCOUNT ON;
SELECT     QLF_CODE, QLF_TYP_CODE, QLF_DESC, AZHAR_FLAG, ROWID
FROM         CDE_PER_QLF







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_PRODUCTTYPESDelete
(
	@Original_TYPEID bigint,
	@Original_TYPEDESC nvarchar(70)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_PRODUCTTYPES] WHERE (([TYPEID] = @Original_TYPEID) AND ([TYPEDESC] = @Original_TYPEDESC))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_PRODUCTTYPESInsert
(
	@TYPEDESC nvarchar(70)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PRODUCTTYPES] ([TYPEDESC]) VALUES (@TYPEDESC);
	
SELECT TYPEID, TYPEDESC FROM CDE_PRODUCTTYPES WHERE (TYPEID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_PRODUCTTYPESSelect
AS
	SET NOCOUNT ON;
SELECT     TYPEID, TYPEDESC
FROM         CDE_PRODUCTTYPES









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CDE_PRODUCTTYPESUpdate
(
	@TYPEDESC nvarchar(70),
	@Original_TYPEID bigint,
	@Original_TYPEDESC nvarchar(70),
	@TYPEID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PRODUCTTYPES] SET [TYPEDESC] = @TYPEDESC WHERE (([TYPEID] = @Original_TYPEID) AND ([TYPEDESC] = @Original_TYPEDESC));
	
SELECT TYPEID, TYPEDESC FROM CDE_PRODUCTTYPES WHERE (TYPEID = @TYPEID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CategoryDelete
(
	@Original_CatID bigint,
	@Original_CatCode nvarchar(50),
	@Original_CatDesc nvarchar(100),
	@IsNull_Serial bigint,
	@Original_Serial bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Category] WHERE (([CatID] = @Original_CatID) AND ([CatCode] = @Original_CatCode) AND ([CatDesc] = @Original_CatDesc) AND ((@IsNull_Serial = 1 AND [Serial] IS NULL) OR ([Serial] = @Original_Serial)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CategoryInsert
(
	@CatCode nvarchar(50),
	@CatDesc nvarchar(100),
	@Serial bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Category] ([CatCode], [CatDesc], [Serial]) VALUES (@CatCode, @CatDesc, @Serial);
	
SELECT CatID, CatCode, CatDesc, Serial FROM Category WHERE (CatID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CategorySelect
AS
	SET NOCOUNT ON;
SELECT     CatID, CatCode, CatDesc, Serial
FROM         Category









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CategoryUpdate
(
	@CatCode nvarchar(50),
	@CatDesc nvarchar(100),
	@Serial bigint,
	@Original_CatID bigint,
	@Original_CatCode nvarchar(50),
	@Original_CatDesc nvarchar(100),
	@IsNull_Serial bigint,
	@Original_Serial bigint,
	@CatID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Category] SET [CatCode] = @CatCode, [CatDesc] = @CatDesc, [Serial] = @Serial WHERE (([CatID] = @Original_CatID) AND ([CatCode] = @Original_CatCode) AND ([CatDesc] = @Original_CatDesc) AND ((@IsNull_Serial = 1 AND [Serial] IS NULL) OR ([Serial] = @Original_Serial)));
	
SELECT CatID, CatCode, CatDesc, Serial FROM Category WHERE (CatID = @CatID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CheckAccountCode
(
	@AccountCode varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS AcctCount
FROM         accounting
WHERE     (AccountCode = @AccountCode)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CheckCostCenterCode
(
	@CostCode varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS AcctCount
FROM         CostCenters
WHERE     (costCode = @CostCode)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_CheckEmpCode
(
	@EmpNum bigint
	
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS EmpNum
FROM         PER_EMPLOYEE_DATA
WHERE     (EmpNum = @EmpNum)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CheckInvCode
(
	@InvCode nvarchar(100),
	@InvType int,
	@BranchId bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS InvCount
FROM         invoices
WHERE     (InvCode = @InvCode) AND (InvType = @InvType) and BranchId=@BranchId







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_CheckInvOrdersCode
(
	@InvCode nvarchar(100),
	@InvType int,
	@BranchId bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS InvCount
FROM         InvOrders
WHERE     (InvCode = @InvCode) AND (InvType = @InvType) and BranchId=@BranchId







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CheckMoveStockCode
(
	@MoveCode varchar(100),
	@BranchId bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS MoveCount
FROM         StockMovement
WHERE     (MoveCode = @MoveCode) AND (BranchId = @BranchId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_CheckOrdersCode
(
	@OrderCode nvarchar(100),
	@InvType int,
	@BranchId bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS InvCount
FROM         Orders
WHERE     (OrderCode = @OrderCode) AND (InvType = @InvType) and BranchId=@BranchId







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CheckQidCode
(
	@QidCode varchar(50),
	@reciteType int
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS QidsCount
FROM         qids
WHERE     (qidcode = @QidCode) AND (recitetype = @reciteType)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CostCentersDelete
(
	@Original_costid bigint,
	@Original_costName nvarchar(100),
	@IsNull_costCode Int,
	@Original_costCode varchar(50),
	@IsNull_costSName Int,
	@Original_costSName nvarchar(100),
	@IsNull_costparentId Int,
	@Original_costparentId int,
	@IsNull_root Int,
	@Original_root bit,
	@IsNull_Totalfromvalue Int,
	@Original_Totalfromvalue money,
	@IsNull_Totaltovalue Int,
	@Original_Totaltovalue money,
	@IsNull_startbalancefrom Int,
	@Original_startbalancefrom float,
	@IsNull_startdate Int,
	@Original_startdate smalldatetime,
	@IsNull_startbalanceto Int,
	@Original_startbalanceto float,
	@IsNull_balance Int,
	@Original_balance bit,
	@IsNull_costType Int,
	@Original_costType int,
	@IsNull_ClosedTo Int,
	@Original_ClosedTo bigint,
	@IsNull_MainNode Int,
	@Original_MainNode bit,
	@IsNull_ProcessFlag Int,
	@Original_ProcessFlag bit,
	@IsNull_display_Flag Int,
	@Original_display_Flag bit,
	@IsNull_LastSerialNo Int,
	@Original_LastSerialNo varchar(50),
	@IsNull_AccLevel Int,
	@Original_AccLevel int,
	@IsNull_MainParentAccId Int,
	@Original_MainParentAccId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CostCenters] WHERE (([costid] = @Original_costid) AND ([costName] = @Original_costName) AND ((@IsNull_costCode = 1 AND [costCode] IS NULL) OR ([costCode] = @Original_costCode)) AND ((@IsNull_costSName = 1 AND [costSName] IS NULL) OR ([costSName] = @Original_costSName)) AND ((@IsNull_costparentId = 1 AND [costparentId] IS NULL) OR ([costparentId] = @Original_costparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_costType = 1 AND [costType] IS NULL) OR ([costType] = @Original_costType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CostCentersInsert
(
	@costName nvarchar(100),
	@costCode varchar(50),
	@costSName nvarchar(100),
	@costparentId int,
	@root bit,
	@Totalfromvalue money,
	@Totaltovalue money,
	@notes ntext,
	@startbalancefrom float,
	@startdate smalldatetime,
	@startbalanceto float,
	@balance bit,
	@costType int,
	@ClosedTo bigint,
	@MainNode bit,
	@ProcessFlag bit,
	@display_Flag bit,
	@LastSerialNo varchar(50),
	@AccLevel int,
	@MainParentAccId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CostCenters] ([costName], [costCode], [costSName], [costparentId], [root], [Totalfromvalue], [Totaltovalue], [notes], [startbalancefrom], [startdate], [startbalanceto], [balance], [costType], [ClosedTo], [MainNode], [ProcessFlag], [display_Flag], [LastSerialNo], [AccLevel], [MainParentAccId]) VALUES (@costName, @costCode, @costSName, @costparentId, @root, @Totalfromvalue, @Totaltovalue, @notes, @startbalancefrom, @startdate, @startbalanceto, @balance, @costType, @ClosedTo, @MainNode, @ProcessFlag, @display_Flag, @LastSerialNo, @AccLevel, @MainParentAccId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CostCentersSelect
AS
	SET NOCOUNT ON;
SELECT     costid, costName, costCode, costSName, costparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, 
                      costType, ClosedTo, MainNode, ProcessFlag, display_Flag, LastSerialNo, AccLevel, MainParentAccId
FROM         CostCenters







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_CostCentersUpdate
(
	@costName nvarchar(100),
	@costCode varchar(50),
	@costSName nvarchar(100),
	@costparentId int,
	@root bit,
	@Totalfromvalue money,
	@Totaltovalue money,
	@notes ntext,
	@startbalancefrom float,
	@startdate smalldatetime,
	@startbalanceto float,
	@balance bit,
	@costType int,
	@ClosedTo bigint,
	@MainNode bit,
	@ProcessFlag bit,
	@display_Flag bit,
	@LastSerialNo varchar(50),
	@AccLevel int,
	@MainParentAccId bigint,
	@Original_costid bigint,
	@Original_costName nvarchar(100),
	@IsNull_costCode Int,
	@Original_costCode varchar(50),
	@IsNull_costSName Int,
	@Original_costSName nvarchar(100),
	@IsNull_costparentId Int,
	@Original_costparentId int,
	@IsNull_root Int,
	@Original_root bit,
	@IsNull_Totalfromvalue Int,
	@Original_Totalfromvalue money,
	@IsNull_Totaltovalue Int,
	@Original_Totaltovalue money,
	@IsNull_startbalancefrom Int,
	@Original_startbalancefrom float,
	@IsNull_startdate Int,
	@Original_startdate smalldatetime,
	@IsNull_startbalanceto Int,
	@Original_startbalanceto float,
	@IsNull_balance Int,
	@Original_balance bit,
	@IsNull_costType Int,
	@Original_costType int,
	@IsNull_ClosedTo Int,
	@Original_ClosedTo bigint,
	@IsNull_MainNode Int,
	@Original_MainNode bit,
	@IsNull_ProcessFlag Int,
	@Original_ProcessFlag bit,
	@IsNull_display_Flag Int,
	@Original_display_Flag bit,
	@IsNull_LastSerialNo Int,
	@Original_LastSerialNo varchar(50),
	@IsNull_AccLevel Int,
	@Original_AccLevel int,
	@IsNull_MainParentAccId Int,
	@Original_MainParentAccId bigint,
	@costid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CostCenters] SET [costName] = @costName, [costCode] = @costCode, [costSName] = @costSName, [costparentId] = @costparentId, [root] = @root, [Totalfromvalue] = @Totalfromvalue, [Totaltovalue] = @Totaltovalue, [notes] = @notes, [startbalancefrom] = @startbalancefrom, [startdate] = @startdate, [startbalanceto] = @startbalanceto, [balance] = @balance, [costType] = @costType, [ClosedTo] = @ClosedTo, [MainNode] = @MainNode, [ProcessFlag] = @ProcessFlag, [display_Flag] = @display_Flag, [LastSerialNo] = @LastSerialNo, [AccLevel] = @AccLevel, [MainParentAccId] = @MainParentAccId WHERE (([costid] = @Original_costid) AND ([costName] = @Original_costName) AND ((@IsNull_costCode = 1 AND [costCode] IS NULL) OR ([costCode] = @Original_costCode)) AND ((@IsNull_costSName = 1 AND [costSName] IS NULL) OR ([costSName] = @Original_costSName)) AND ((@IsNull_costparentId = 1 AND [costparentId] IS NULL) OR ([costparentId] = @Original_costparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_costType = 1 AND [costType] IS NULL) OR ([costType] = @Original_costType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)));
	
SELECT costid, costName, costCode, costSName, costparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, costType, ClosedTo, MainNode, ProcessFlag, display_Flag, LastSerialNo, AccLevel, MainParentAccId FROM CostCenters WHERE (costid = @costid)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CurrencyDelete
(
	@Original_CurId bigint,
	@IsNull_CurDesc varchar(200),
	@Original_CurDesc varchar(200),
	@IsNull_TransFactor float,
	@Original_TransFactor float
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_Currency] WHERE (([CurId] = @Original_CurId) AND ((@IsNull_CurDesc = 1 AND [CurDesc] IS NULL) OR ([CurDesc] = @Original_CurDesc)) AND ((@IsNull_TransFactor = 1 AND [TransFactor] IS NULL) OR ([TransFactor] = @Original_TransFactor)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CurrencyInsert
(
	@CurDesc varchar(200),
	@TransFactor float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_Currency] ([CurDesc], [TransFactor]) VALUES (@CurDesc, @TransFactor);
	
SELECT CurId, CurDesc, TransFactor FROM CDE_Currency WHERE (CurId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CurrencySelect
AS
	SET NOCOUNT ON;
SELECT     CurId, CurDesc, TransFactor
FROM         CDE_Currency







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_CurrencyUpdate
(
	@CurDesc varchar(200),
	@TransFactor float,
	@Original_CurId bigint,
	@IsNull_CurDesc varchar(200),
	@Original_CurDesc varchar(200),
	@IsNull_TransFactor float,
	@Original_TransFactor float,
	@CurId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_Currency] SET [CurDesc] = @CurDesc, [TransFactor] = @TransFactor WHERE (([CurId] = @Original_CurId) AND ((@IsNull_CurDesc = 1 AND [CurDesc] IS NULL) OR ([CurDesc] = @Original_CurDesc)) AND ((@IsNull_TransFactor = 1 AND [TransFactor] IS NULL) OR ([TransFactor] = @Original_TransFactor)));
	
SELECT CurId, CurDesc, TransFactor FROM CDE_Currency WHERE (CurId = @CurId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_CustomerSalesAgalSelectView
(
	@SUP_CUST_ID bigint,
	@BranchId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
	@StoreId bigint,
@invType int
)
AS
	SET NOCOUNT ON;
SELECT     SUP_CUST_ID, SUP_CUST_FNAME, 
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 0  THEN  isnull( TotalPrice, 0)  end END) AS CashVaule, 
SUM(CASE PaymentType WHEN 1 THEN 
CASE ReoderFlag WHEN 0  THEN isnull( TotalPrice, 0)  else 0 end END) AS AgalValue, 
SUM(CASE PaymentType WHEN 1 THEN CASE ReoderFlag WHEN 1 THEN   isnull(TotReoderPrice, 0) else 0 end  END) AS AgalreorderValue, 
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 1 then isnull(TotReoderPrice, 0) else 0 end END) AS ChashReordervalue,
                        
  (SELECT     SUM(isnull(collectValue, 0) + isnull(PaymentValue, 0))
                             FROM         invoices
                             WHERE     (CustomerInvoicesView. SUP_CUST_ID = invoices.SUP_CUST_ID ) and (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
					--AND (StoreId = @StoreId or @StoreId is null )
					AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
					--AND (ProductId = @ProductId or @ProductId is null )
                           --  GROUP BY SUP_CUST_ID, invId
) AS CashColValue
FROM         dbo.CustomerInvoicesView
where  (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
AND (StoreId = @StoreId or @StoreId is null )
AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
AND (ProductId = @ProductId or @ProductId is null ) and (SUP_CUST_TYPE=2 or SUP_CUST_TYPE=3) and Paymenttype=1  and  invtype =@invType
GROUP BY SUP_CUST_ID, SUP_CUST_FNAME






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_CustomerSalesSelectView
(
	@SUP_CUST_ID bigint,
	@BranchId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
	@StoreId bigint
)
AS
	SET NOCOUNT ON;
SELECT     SUP_CUST_ID, SUP_CUST_FNAME, 
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 0  THEN  isnull( TotalPrice, 0)  end END) -MAX(isnull( DISCOUNT, 0))AS CashVaule, 
SUM(CASE PaymentType WHEN 1 THEN 
CASE ReoderFlag WHEN 0  THEN isnull( TotalPrice, 0)  else 0 end END) -MAX(isnull( DISCOUNT, 0)) AS AgalValue, 
SUM(CASE PaymentType WHEN 1 THEN CASE ReoderFlag WHEN 1 THEN   isnull(TotReoderPrice, 0) else 0 end  END) AS AgalreorderValue, 
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 1 then isnull(TotReoderPrice, 0) else 0 end END) AS ChashReordervalue,
                        
  (SELECT     SUM(isnull(collectValue, 0) + isnull(PaymentValue, 0))
                             FROM         invoices
                             WHERE     (CustomerInvoicesView. SUP_CUST_ID = invoices.SUP_CUST_ID ) and (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
					--AND (StoreId = @StoreId or @StoreId is null )
					AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
					--AND (ProductId = @ProductId or @ProductId is null )
                           --  GROUP BY SUP_CUST_ID, invId
) AS CashColValue
FROM         dbo.CustomerInvoicesView
where  (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
AND (StoreId = @StoreId or @StoreId is null )
AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
AND (ProductId = @ProductId or @ProductId is null ) and (SUP_CUST_TYPE=2 or SUP_CUST_TYPE=3) and invtype =2
GROUP BY SUP_CUST_ID, SUP_CUST_FNAME






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_DBNAMESInsert
(
	@DBNAME varchar(200),
	@Flag bit
	
)
AS
	SET NOCOUNT OFF;
INSERT INTO  NEWERP.dbo.DBNames (DBNAME ,DelFlag)
	
values(@DBNAME,@Flag)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_DBNAMESSelect

AS
	SET NOCOUNT OFF;
select DBNAME ,DelFlag from  NEWERP.dbo.DBNames







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DEPTDelete
(
	@Original_DEPT_CODE bigint,
	@Original_DEPT_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_DEPT] WHERE (([DEPT_CODE] = @Original_DEPT_CODE) AND ([DEPT_DESC] = @Original_DEPT_DESC))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DEPTInsert
(
	@DEPT_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_DEPT] ([DEPT_DESC]) VALUES (@DEPT_DESC);
	
SELECT DEPT_CODE, DEPT_DESC FROM CDE_DEPT WHERE (DEPT_CODE = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DEPTSelect
AS
	SET NOCOUNT ON;
SELECT     DEPT_CODE, DEPT_DESC
FROM         CDE_DEPT









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DEPTUpdate
(
	@DEPT_DESC varchar(200),
	@Original_DEPT_CODE bigint,
	@Original_DEPT_DESC varchar(200),
	@DEPT_CODE bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_DEPT] SET [DEPT_DESC] = @DEPT_DESC WHERE (([DEPT_CODE] = @Original_DEPT_CODE) AND ([DEPT_DESC] = @Original_DEPT_DESC));
	
SELECT DEPT_CODE, DEPT_DESC FROM CDE_DEPT WHERE (DEPT_CODE = @DEPT_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DOCUMENT_TYPESDelete
(
	@Original_DOC_TYPE_CODE numeric(5, 0),
	@IsNull_EXP_DATE_FLAG varchar(1),
	@Original_EXP_DATE_FLAG varchar(1),
	@Original_DOC_TYPE_DESC varchar(200),
	@IsNull_DOC_M_F_FLAG varchar(1),
	@Original_DOC_M_F_FLAG varchar(1)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_PER_DOCUMENT_TYPE] WHERE (([DOC_TYPE_CODE] = @Original_DOC_TYPE_CODE) AND ((@IsNull_EXP_DATE_FLAG = 1 AND [EXP_DATE_FLAG] IS NULL) OR ([EXP_DATE_FLAG] = @Original_EXP_DATE_FLAG)) AND ([DOC_TYPE_DESC] = @Original_DOC_TYPE_DESC) AND ((@IsNull_DOC_M_F_FLAG = 1 AND [DOC_M_F_FLAG] IS NULL) OR ([DOC_M_F_FLAG] = @Original_DOC_M_F_FLAG)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DOCUMENT_TYPESInsert
(
	@DOC_TYPE_CODE numeric(5, 0),
	@EXP_DATE_FLAG varchar(1),
	@DOC_TYPE_DESC varchar(200),
	@DOC_M_F_FLAG varchar(1)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_DOCUMENT_TYPE] ([DOC_TYPE_CODE], [EXP_DATE_FLAG], [DOC_TYPE_DESC], [DOC_M_F_FLAG]) VALUES (@DOC_TYPE_CODE, @EXP_DATE_FLAG, @DOC_TYPE_DESC, @DOC_M_F_FLAG);
	
SELECT DOC_TYPE_CODE, EXP_DATE_FLAG, DOC_TYPE_DESC, DOC_M_F_FLAG FROM CDE_PER_DOCUMENT_TYPE WHERE (DOC_TYPE_CODE = @DOC_TYPE_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DOCUMENT_TYPESUpdate
(
	@DOC_TYPE_CODE numeric(5, 0),
	@EXP_DATE_FLAG varchar(1),
	@DOC_TYPE_DESC varchar(200),
	@DOC_M_F_FLAG varchar(1),
	@Original_DOC_TYPE_CODE numeric(5, 0),
	@IsNull_EXP_DATE_FLAG varchar(1),
	@Original_EXP_DATE_FLAG varchar(1),
	@Original_DOC_TYPE_DESC varchar(200),
	@IsNull_DOC_M_F_FLAG varchar(1),
	@Original_DOC_M_F_FLAG varchar(1)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PER_DOCUMENT_TYPE] SET [DOC_TYPE_CODE] = @DOC_TYPE_CODE, [EXP_DATE_FLAG] = @EXP_DATE_FLAG, [DOC_TYPE_DESC] = @DOC_TYPE_DESC, [DOC_M_F_FLAG] = @DOC_M_F_FLAG WHERE (([DOC_TYPE_CODE] = @Original_DOC_TYPE_CODE) AND ((@IsNull_EXP_DATE_FLAG = 1 AND [EXP_DATE_FLAG] IS NULL) OR ([EXP_DATE_FLAG] = @Original_EXP_DATE_FLAG)) AND ([DOC_TYPE_DESC] = @Original_DOC_TYPE_DESC) AND ((@IsNull_DOC_M_F_FLAG = 1 AND [DOC_M_F_FLAG] IS NULL) OR ([DOC_M_F_FLAG] = @Original_DOC_M_F_FLAG)));
	
SELECT DOC_TYPE_CODE, EXP_DATE_FLAG, DOC_TYPE_DESC, DOC_M_F_FLAG FROM CDE_PER_DOCUMENT_TYPE WHERE (DOC_TYPE_CODE = @DOC_TYPE_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_DOCUMENT_TYPESelect
AS
	SET NOCOUNT ON;
SELECT     DOC_TYPE_CODE, EXP_DATE_FLAG, DOC_TYPE_DESC, DOC_M_F_FLAG
FROM         CDE_PER_DOCUMENT_TYPE









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Discount_ViewSelect
AS
	SET NOCOUNT ON;
SELECT     DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, FName, SName, TName, FoName, 
                      TITLE, DEPTCODE, FullName, DEPT_DESC, PEN_DESC,EmpNum
FROM         Discount_View







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_Discount_ViewSelectbyParam
@EMP_CODE bigint ,
@DEPTCODE bigint ,
@FromDate smalldatetime,
@ToDate smalldatetime,
@EmpNum bigint
AS
	SET NOCOUNT ON;
SELECT     DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, FName, SName, TName, FoName, 
                      TITLE, DEPTCODE, FullName, DEPT_DESC, PEN_DESC,EmpNum
FROM         Discount_View

where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and (DISCOUNT_DATE>=@FromDate or @FromDate is null) and (DISCOUNT_DATE<=@ToDate or @ToDate is null)
and (EmpNum=@EmpNum or @EmpNum is null)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_ABSENCEDelete
(
	@Original_AbsenceID bigint,
	@Original_START_DATE datetime,
	@Original_END_DATE datetime,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_DAYS_NUM Int,
	@Original_DAYS_NUM numeric(5, 0),
	@IsNull_HOUR_NUM Int,
	@Original_HOUR_NUM decimal(18, 0),
	@IsNull_HOURVALUE Int,
	@Original_HOURVALUE money,
	@IsNull_NOTE Int,
	@Original_NOTE varchar(500)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_ABSENCE] WHERE (([AbsenceID] = @Original_AbsenceID) AND ([START_DATE] = @Original_START_DATE) AND ([END_DATE] = @Original_END_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_DAYS_NUM = 1 AND [DAYS_NUM] IS NULL) OR ([DAYS_NUM] = @Original_DAYS_NUM)) AND ((@IsNull_HOUR_NUM = 1 AND [HOUR_NUM] IS NULL) OR ([HOUR_NUM] = @Original_HOUR_NUM)) AND ((@IsNull_HOURVALUE = 1 AND [HOURVALUE] IS NULL) OR ([HOURVALUE] = @Original_HOURVALUE)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_ABSENCEInsert
(
	@START_DATE datetime,
	@END_DATE datetime,
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@DAYS_NUM numeric(5, 0),
	@HOUR_NUM decimal(18, 0),
	@HOURVALUE money,
	@NOTE varchar(500)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_ABSENCE] ([START_DATE], [END_DATE], [EMP_CODE], [YEAR_CODE], [MONTH_CODE], [DAYS_NUM], [HOUR_NUM], [HOURVALUE], [NOTE]) VALUES (@START_DATE, @END_DATE, @EMP_CODE, @YEAR_CODE, @MONTH_CODE, @DAYS_NUM, @HOUR_NUM, @HOURVALUE, @NOTE);
	
SELECT AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE FROM PER_EMP_ABSENCE WHERE (AbsenceID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_ABSENCESelect
AS
	SET NOCOUNT ON;
SELECT     AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE
FROM         PER_EMP_ABSENCE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_EMP_ABSENCESelectByEmpCode
@EMP_CODE as bigint
AS
	SET NOCOUNT ON;
SELECT     AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE
FROM         PER_EMP_ABSENCE
where EMP_CODE=@EMP_CODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_ABSENCEUpdate
(
	@START_DATE datetime,
	@END_DATE datetime,
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@DAYS_NUM numeric(5, 0),
	@HOUR_NUM decimal(18, 0),
	@HOURVALUE money,
	@NOTE varchar(500),
	@Original_AbsenceID bigint,
	@Original_START_DATE datetime,
	@Original_END_DATE datetime,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_DAYS_NUM Int,
	@Original_DAYS_NUM numeric(5, 0),
	@IsNull_HOUR_NUM Int,
	@Original_HOUR_NUM decimal(18, 0),
	@IsNull_HOURVALUE Int,
	@Original_HOURVALUE money,
	@IsNull_NOTE Int,
	@Original_NOTE varchar(500),
	@AbsenceID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_ABSENCE] SET [START_DATE] = @START_DATE, [END_DATE] = @END_DATE, [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [DAYS_NUM] = @DAYS_NUM, [HOUR_NUM] = @HOUR_NUM, [HOURVALUE] = @HOURVALUE, [NOTE] = @NOTE WHERE (([AbsenceID] = @Original_AbsenceID) AND ([START_DATE] = @Original_START_DATE) AND ([END_DATE] = @Original_END_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_DAYS_NUM = 1 AND [DAYS_NUM] IS NULL) OR ([DAYS_NUM] = @Original_DAYS_NUM)) AND ((@IsNull_HOUR_NUM = 1 AND [HOUR_NUM] IS NULL) OR ([HOUR_NUM] = @Original_HOUR_NUM)) AND ((@IsNull_HOURVALUE = 1 AND [HOURVALUE] IS NULL) OR ([HOURVALUE] = @Original_HOURVALUE)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)));
	
SELECT AbsenceID, START_DATE, END_DATE, EMP_CODE, YEAR_CODE, MONTH_CODE, DAYS_NUM, HOUR_NUM, HOURVALUE, NOTE FROM PER_EMP_ABSENCE WHERE (AbsenceID = @AbsenceID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_DISCOUNTDelete
(
	@Original_DISCOUNTID int,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_PEN_CODE Int,
	@Original_PEN_CODE numeric(5, 0),
	@IsNull_DISCOUNT_DATE Int,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_AMOUNT Int,
	@Original_AMOUNT money,
	@IsNull_DES Int,
	@Original_DES nvarchar(500),
	@IsNull_accountid Int,
	@Original_accountid int,
	@IsNull_PervMonthFlag Int,
	@Original_PervMonthFlag bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_DISCOUNT] WHERE (([DISCOUNTID] = @Original_DISCOUNTID) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_PEN_CODE = 1 AND [PEN_CODE] IS NULL) OR ([PEN_CODE] = @Original_PEN_CODE)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DES = 1 AND [DES] IS NULL) OR ([DES] = @Original_DES)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_PervMonthFlag = 1 AND [PervMonthFlag] IS NULL) OR ([PervMonthFlag] = @Original_PervMonthFlag)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_DISCOUNTInsert
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@PEN_CODE numeric(5, 0),
	@DISCOUNT_DATE smalldatetime,
	@AMOUNT money,
	@DES nvarchar(500),
	@accountid int,
	@PervMonthFlag bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_DISCOUNT] ([EMP_CODE], [YEAR_CODE], [MONTH_CODE], [PEN_CODE], [DISCOUNT_DATE], [AMOUNT], [DES], [accountid], [PervMonthFlag]) VALUES (@EMP_CODE, @YEAR_CODE, @MONTH_CODE, @PEN_CODE, @DISCOUNT_DATE, @AMOUNT, @DES, @accountid, @PervMonthFlag);
	
SELECT DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, PervMonthFlag FROM PER_EMP_DISCOUNT WHERE (DISCOUNTID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_DISCOUNTSelect
AS
	SET NOCOUNT ON;
SELECT     DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, PervMonthFlag
FROM         PER_EMP_DISCOUNT







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_EMP_DISCOUNTSelectbyEmpId
@EmpCode as bigint
AS
	SET NOCOUNT ON;
SELECT     DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, PervMonthFlag
FROM         PER_EMP_DISCOUNT
where EMP_CODE=@EMPCODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_DISCOUNTUpdate
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@PEN_CODE numeric(5, 0),
	@DISCOUNT_DATE smalldatetime,
	@AMOUNT money,
	@DES nvarchar(500),
	@accountid int,
	@PervMonthFlag bit,
	@Original_DISCOUNTID int,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_PEN_CODE Int,
	@Original_PEN_CODE numeric(5, 0),
	@IsNull_DISCOUNT_DATE Int,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_AMOUNT Int,
	@Original_AMOUNT money,
	@IsNull_DES Int,
	@Original_DES nvarchar(500),
	@IsNull_accountid Int,
	@Original_accountid int,
	@IsNull_PervMonthFlag Int,
	@Original_PervMonthFlag bit,
	@DISCOUNTID int
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_DISCOUNT] SET [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [PEN_CODE] = @PEN_CODE, [DISCOUNT_DATE] = @DISCOUNT_DATE, [AMOUNT] = @AMOUNT, [DES] = @DES, [accountid] = @accountid, [PervMonthFlag] = @PervMonthFlag WHERE (([DISCOUNTID] = @Original_DISCOUNTID) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_PEN_CODE = 1 AND [PEN_CODE] IS NULL) OR ([PEN_CODE] = @Original_PEN_CODE)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DES = 1 AND [DES] IS NULL) OR ([DES] = @Original_DES)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_PervMonthFlag = 1 AND [PervMonthFlag] IS NULL) OR ([PervMonthFlag] = @Original_PervMonthFlag)));
	
SELECT DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid, PervMonthFlag FROM PER_EMP_DISCOUNT WHERE (DISCOUNTID = @DISCOUNTID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EMP_DOCUMNETDelete
(
	@Original_DOC_SERIAL numeric,
	@Original_DOC_TYPE_CODE numeric(5, 0),
	@Original_EMP_CODE numeric(38, 0),
	@IsNull_DOC_END_DATE datetime,
	@Original_DOC_END_DATE datetime,
	@IsNull_DOC_NUM varchar(20),
	@Original_DOC_NUM varchar(20),
	@IsNull_NOTES varchar(2000),
	@Original_NOTES varchar(2000),
	@IsNull_DOC_DATE datetime,
	@Original_DOC_DATE datetime,
	@IsNull_DOC_DELIVERY_DATE datetime,
	@Original_DOC_DELIVERY_DATE datetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_DOCUMNET] WHERE (([DOC_SERIAL] = @Original_DOC_SERIAL) AND ([DOC_TYPE_CODE] = @Original_DOC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_DOC_END_DATE = 1 AND [DOC_END_DATE] IS NULL) OR ([DOC_END_DATE] = @Original_DOC_END_DATE)) AND ((@IsNull_DOC_NUM = 1 AND [DOC_NUM] IS NULL) OR ([DOC_NUM] = @Original_DOC_NUM)) AND ((@IsNull_NOTES = 1 AND [NOTES] IS NULL) OR ([NOTES] = @Original_NOTES)) AND ((@IsNull_DOC_DATE = 1 AND [DOC_DATE] IS NULL) OR ([DOC_DATE] = @Original_DOC_DATE)) AND ((@IsNull_DOC_DELIVERY_DATE = 1 AND [DOC_DELIVERY_DATE] IS NULL) OR ([DOC_DELIVERY_DATE] = @Original_DOC_DELIVERY_DATE)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EMP_DOCUMNETInsert
(
	@DOC_TYPE_CODE numeric(5, 0),
	@EMP_CODE numeric(38, 0),
	@DOC_END_DATE datetime,
	@DOC_NUM varchar(20),
	@NOTES varchar(2000),
	@DOC_DATE datetime,
	@DOC_DELIVERY_DATE datetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_DOCUMNET] ([DOC_TYPE_CODE], [EMP_CODE], [DOC_END_DATE], [DOC_NUM], [NOTES], [DOC_DATE], [DOC_DELIVERY_DATE]) VALUES (@DOC_TYPE_CODE, @EMP_CODE, @DOC_END_DATE, @DOC_NUM, @NOTES, @DOC_DATE, @DOC_DELIVERY_DATE);
	
SELECT DOC_SERIAL, DOC_TYPE_CODE, EMP_CODE, DOC_END_DATE, DOC_NUM, NOTES, DOC_DATE, DOC_DELIVERY_DATE FROM PER_EMP_DOCUMNET WHERE (DOC_SERIAL = SCOPE_IDENTITY()) AND (DOC_TYPE_CODE = @DOC_TYPE_CODE) AND (EMP_CODE = @EMP_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EMP_DOCUMNETSelect
AS
	SET NOCOUNT ON;
SELECT     DOC_SERIAL, DOC_TYPE_CODE, EMP_CODE, DOC_END_DATE, DOC_NUM, NOTES, DOC_DATE, DOC_DELIVERY_DATE
FROM         PER_EMP_DOCUMNET









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EMP_DOCUMNETUpdate
(
	@DOC_TYPE_CODE numeric(5, 0),
	@EMP_CODE numeric(38, 0),
	@DOC_END_DATE datetime,
	@DOC_NUM varchar(20),
	@NOTES varchar(2000),
	@DOC_DATE datetime,
	@DOC_DELIVERY_DATE datetime,
	@Original_DOC_SERIAL numeric,
	@Original_DOC_TYPE_CODE numeric(5, 0),
	@Original_EMP_CODE numeric(38, 0),
	@IsNull_DOC_END_DATE datetime,
	@Original_DOC_END_DATE datetime,
	@IsNull_DOC_NUM varchar(20),
	@Original_DOC_NUM varchar(20),
	@IsNull_NOTES varchar(2000),
	@Original_NOTES varchar(2000),
	@IsNull_DOC_DATE datetime,
	@Original_DOC_DATE datetime,
	@IsNull_DOC_DELIVERY_DATE datetime,
	@Original_DOC_DELIVERY_DATE datetime,
	@DOC_SERIAL numeric
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_DOCUMNET] SET [DOC_TYPE_CODE] = @DOC_TYPE_CODE, [EMP_CODE] = @EMP_CODE, [DOC_END_DATE] = @DOC_END_DATE, [DOC_NUM] = @DOC_NUM, [NOTES] = @NOTES, [DOC_DATE] = @DOC_DATE, [DOC_DELIVERY_DATE] = @DOC_DELIVERY_DATE WHERE (([DOC_SERIAL] = @Original_DOC_SERIAL) AND ([DOC_TYPE_CODE] = @Original_DOC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_DOC_END_DATE = 1 AND [DOC_END_DATE] IS NULL) OR ([DOC_END_DATE] = @Original_DOC_END_DATE)) AND ((@IsNull_DOC_NUM = 1 AND [DOC_NUM] IS NULL) OR ([DOC_NUM] = @Original_DOC_NUM)) AND ((@IsNull_NOTES = 1 AND [NOTES] IS NULL) OR ([NOTES] = @Original_NOTES)) AND ((@IsNull_DOC_DATE = 1 AND [DOC_DATE] IS NULL) OR ([DOC_DATE] = @Original_DOC_DATE)) AND ((@IsNull_DOC_DELIVERY_DATE = 1 AND [DOC_DELIVERY_DATE] IS NULL) OR ([DOC_DELIVERY_DATE] = @Original_DOC_DELIVERY_DATE)));
	
SELECT DOC_SERIAL, DOC_TYPE_CODE, EMP_CODE, DOC_END_DATE, DOC_NUM, NOTES, DOC_DATE, DOC_DELIVERY_DATE FROM PER_EMP_DOCUMNET WHERE (DOC_SERIAL = @DOC_SERIAL) AND (DOC_TYPE_CODE = @DOC_TYPE_CODE) AND (EMP_CODE = @EMP_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANDelete
(
	@Original_LoanID bigint,
	@Original_START_DATE datetime,
	@Original_EMP_CODE bigint,
	@IsNull_MONTHLY_AMOUNT numeric(9, 3),
	@Original_MONTHLY_AMOUNT numeric(9, 3),
	@Original_TOTAL_AMOUNT numeric(9, 3),
	@IsNull_TOT_PAID numeric(9, 3),
	@Original_TOT_PAID numeric(9, 3),
	@IsNull_TOTAL_MON_NUM numeric(5, 0),
	@Original_TOTAL_MON_NUM numeric(5, 0),
	@IsNull_NOTE nvarchar(200),
	@Original_NOTE nvarchar(200),
	@IsNull_STOP_FLAG bit,
	@Original_STOP_FLAG bit,
	@IsNull_accountid int,
	@Original_accountid int,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime,
	@IsNull_TotBalance numeric(18, 0),
	@Original_TotBalance numeric(18, 0)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRL_EMP_LOAN_DETAIL] WHERE (([LoanID] = @Original_LoanID) AND ([START_DATE] = @Original_START_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_MONTHLY_AMOUNT = 1 AND [MONTHLY_AMOUNT] IS NULL) OR ([MONTHLY_AMOUNT] = @Original_MONTHLY_AMOUNT)) AND ([TOTAL_AMOUNT] = @Original_TOTAL_AMOUNT) AND ((@IsNull_TOT_PAID = 1 AND [TOT_PAID] IS NULL) OR ([TOT_PAID] = @Original_TOT_PAID)) AND ((@IsNull_TOTAL_MON_NUM = 1 AND [TOTAL_MON_NUM] IS NULL) OR ([TOTAL_MON_NUM] = @Original_TOTAL_MON_NUM)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_STOP_FLAG = 1 AND [STOP_FLAG] IS NULL) OR ([STOP_FLAG] = @Original_STOP_FLAG)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)) AND ((@IsNull_TotBalance = 1 AND [TotBalance] IS NULL) OR ([TotBalance] = @Original_TotBalance)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANInsert
(
	@START_DATE datetime,
	@EMP_CODE bigint,
	@MONTHLY_AMOUNT numeric(9, 3),
	@TOTAL_AMOUNT numeric(9, 3),
	@TOT_PAID numeric(9, 3),
	@TOTAL_MON_NUM numeric(5, 0),
	@NOTE nvarchar(200),
	@STOP_FLAG bit,
	@accountid int,
	@LoanDate smalldatetime,
	@TotBalance numeric(18, 0)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRL_EMP_LOAN_DETAIL] ([START_DATE], [EMP_CODE], [MONTHLY_AMOUNT], [TOTAL_AMOUNT], [TOT_PAID], [TOTAL_MON_NUM], [NOTE], [STOP_FLAG], [accountid], [LoanDate], [TotBalance]) VALUES (@START_DATE, @EMP_CODE, @MONTHLY_AMOUNT, @TOTAL_AMOUNT, @TOT_PAID, @TOTAL_MON_NUM, @NOTE, @STOP_FLAG, @accountid, @LoanDate, @TotBalance);
	
SELECT LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid, LoanDate, TotBalance FROM PRL_EMP_LOAN_DETAIL WHERE (LoanID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANSelect
AS
	SET NOCOUNT ON;
SELECT     LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid, LoanDate, 
                      TotBalance
FROM         PRL_EMP_LOAN_DETAIL







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANSelectByLoanId
(
	@LoanId bigint
)
AS
	SET NOCOUNT ON;
SELECT     LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid, LoanDate, 
                      TotBalance
FROM         PRL_EMP_LOAN_DETAIL
WHERE     (LoanID = @LoanId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANSelectbyEmpId
@EmpCode as bigint
AS
	SET NOCOUNT ON;
SELECT     LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid, LoanDate, 
                      TotBalance
FROM         PRL_EMP_LOAN_DETAIL
where EMP_CODE=@EMPCODE






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_LOANUpdate
(
	@START_DATE datetime,
	@EMP_CODE bigint,
	@MONTHLY_AMOUNT numeric(9, 3),
	@TOTAL_AMOUNT numeric(9, 3),
	@TOT_PAID numeric(9, 3),
	@TOTAL_MON_NUM numeric(5, 0),
	@NOTE nvarchar(200),
	@STOP_FLAG bit,
	@accountid int,
	@LoanDate smalldatetime,
	@TotBalance numeric(18, 0),
	@Original_LoanID bigint,
	@Original_START_DATE datetime,
	@Original_EMP_CODE bigint,
	@IsNull_MONTHLY_AMOUNT numeric(9, 3),
	@Original_MONTHLY_AMOUNT numeric(9, 3),
	@Original_TOTAL_AMOUNT numeric(9, 3),
	@IsNull_TOT_PAID numeric(9, 3),
	@Original_TOT_PAID numeric(9, 3),
	@IsNull_TOTAL_MON_NUM numeric(5, 0),
	@Original_TOTAL_MON_NUM numeric(5, 0),
	@IsNull_NOTE nvarchar(200),
	@Original_NOTE nvarchar(200),
	@IsNull_STOP_FLAG bit,
	@Original_STOP_FLAG bit,
	@IsNull_accountid int,
	@Original_accountid int,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime,
	@IsNull_TotBalance numeric(18, 0),
	@Original_TotBalance numeric(18, 0),
	@LoanID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRL_EMP_LOAN_DETAIL] SET [START_DATE] = @START_DATE, [EMP_CODE] = @EMP_CODE, [MONTHLY_AMOUNT] = @MONTHLY_AMOUNT, [TOTAL_AMOUNT] = @TOTAL_AMOUNT, [TOT_PAID] = @TOT_PAID, [TOTAL_MON_NUM] = @TOTAL_MON_NUM, [NOTE] = @NOTE, [STOP_FLAG] = @STOP_FLAG, [accountid] = @accountid, [LoanDate] = @LoanDate, [TotBalance] = @TotBalance WHERE (([LoanID] = @Original_LoanID) AND ([START_DATE] = @Original_START_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_MONTHLY_AMOUNT = 1 AND [MONTHLY_AMOUNT] IS NULL) OR ([MONTHLY_AMOUNT] = @Original_MONTHLY_AMOUNT)) AND ([TOTAL_AMOUNT] = @Original_TOTAL_AMOUNT) AND ((@IsNull_TOT_PAID = 1 AND [TOT_PAID] IS NULL) OR ([TOT_PAID] = @Original_TOT_PAID)) AND ((@IsNull_TOTAL_MON_NUM = 1 AND [TOTAL_MON_NUM] IS NULL) OR ([TOTAL_MON_NUM] = @Original_TOTAL_MON_NUM)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_STOP_FLAG = 1 AND [STOP_FLAG] IS NULL) OR ([STOP_FLAG] = @Original_STOP_FLAG)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)) AND ((@IsNull_TotBalance = 1 AND [TotBalance] IS NULL) OR ([TotBalance] = @Original_TotBalance)));
	
SELECT LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid, LoanDate, TotBalance FROM PRL_EMP_LOAN_DETAIL WHERE (LoanID = @LoanID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_VACATIONDelete
(
	@Original_VACID bigint,
	@Original_VAC_TYPE_CODE numeric(5, 0),
	@Original_EMP_CODE bigint,
	@Original_VAC_DATE_FRM datetime,
	@Original_VAC_DATE_TO datetime,
	@IsNull_RETURN_DATE datetime,
	@Original_RETURN_DATE datetime,
	@IsNull_VAC_PERIOD numeric(5, 0),
	@Original_VAC_PERIOD numeric(5, 0),
	@IsNull_NOTE varchar(300),
	@Original_NOTE varchar(300),
	@IsNull_TotalDays numeric(5, 0),
	@Original_TotalDays numeric(5, 0),
	@IsNull_Netdays numeric(18, 0),
	@Original_Netdays numeric(18, 0),
	@IsNull_Holidays numeric(18, 0),
	@Original_Holidays numeric(18, 0),
	@IsNull_Ticket bit,
	@Original_Ticket bit,
	@IsNull_DEC_FLAG bit,
	@Original_DEC_FLAG bit,
	@IsNull_YEAR_CODE int,
	@Original_YEAR_CODE int,
	@IsNull_MONTH_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_PERIOD_FLAG bit,
	@Original_PERIOD_FLAG bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_VACATION] WHERE (([VACID] = @Original_VACID) AND ([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([VAC_DATE_FRM] = @Original_VAC_DATE_FRM) AND ([VAC_DATE_TO] = @Original_VAC_DATE_TO) AND ((@IsNull_RETURN_DATE = 1 AND [RETURN_DATE] IS NULL) OR ([RETURN_DATE] = @Original_RETURN_DATE)) AND ((@IsNull_VAC_PERIOD = 1 AND [VAC_PERIOD] IS NULL) OR ([VAC_PERIOD] = @Original_VAC_PERIOD)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_TotalDays = 1 AND [TotalDays] IS NULL) OR ([TotalDays] = @Original_TotalDays)) AND ((@IsNull_Netdays = 1 AND [Netdays] IS NULL) OR ([Netdays] = @Original_Netdays)) AND ((@IsNull_Holidays = 1 AND [Holidays] IS NULL) OR ([Holidays] = @Original_Holidays)) AND ((@IsNull_Ticket = 1 AND [Ticket] IS NULL) OR ([Ticket] = @Original_Ticket)) AND ((@IsNull_DEC_FLAG = 1 AND [DEC_FLAG] IS NULL) OR ([DEC_FLAG] = @Original_DEC_FLAG)) AND ((@IsNull_YEAR_CODE = 1 AND [YEAR_CODE] IS NULL) OR ([YEAR_CODE] = @Original_YEAR_CODE)) AND ((@IsNull_MONTH_CODE = 1 AND [MONTH_CODE] IS NULL) OR ([MONTH_CODE] = @Original_MONTH_CODE)) AND ((@IsNull_PERIOD_FLAG = 1 AND [PERIOD_FLAG] IS NULL) OR ([PERIOD_FLAG] = @Original_PERIOD_FLAG)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_VACATIONInsert
(
	@VAC_TYPE_CODE numeric(5, 0),
	@EMP_CODE bigint,
	@VAC_DATE_FRM datetime,
	@VAC_DATE_TO datetime,
	@RETURN_DATE datetime,
	@VAC_PERIOD numeric(5, 0),
	@NOTE varchar(300),
	@TotalDays numeric(5, 0),
	@Netdays numeric(18, 0),
	@Holidays numeric(18, 0),
	@Ticket bit,
	@DEC_FLAG bit,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@PERIOD_FLAG bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_VACATION] ([VAC_TYPE_CODE], [EMP_CODE], [VAC_DATE_FRM], [VAC_DATE_TO], [RETURN_DATE], [VAC_PERIOD], [NOTE], [TotalDays], [Netdays], [Holidays], [Ticket], [DEC_FLAG], [YEAR_CODE], [MONTH_CODE], [PERIOD_FLAG]) VALUES (@VAC_TYPE_CODE, @EMP_CODE, @VAC_DATE_FRM, @VAC_DATE_TO, @RETURN_DATE, @VAC_PERIOD, @NOTE, @TotalDays, @Netdays, @Holidays, @Ticket, @DEC_FLAG, @YEAR_CODE, @MONTH_CODE, @PERIOD_FLAG);
	
SELECT VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, DEC_FLAG, YEAR_CODE, MONTH_CODE, PERIOD_FLAG FROM PER_EMP_VACATION WHERE (VACID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_VACATIONSelect
AS
	SET NOCOUNT ON;
SELECT     VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, 
                      DEC_FLAG, YEAR_CODE, MONTH_CODE, PERIOD_FLAG
FROM         PER_EMP_VACATION







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_EMP_VACATIONSelectbyempId
@Empcode as bigint
AS
	SET NOCOUNT ON;
SELECT     VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, 
                      DEC_FLAG, YEAR_CODE, MONTH_CODE, PERIOD_FLAG
FROM         PER_EMP_VACATION
where EMP_CODE =@Empcode







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EMP_VACATIONUpdate
(
	@VAC_TYPE_CODE numeric(5, 0),
	@EMP_CODE bigint,
	@VAC_DATE_FRM datetime,
	@VAC_DATE_TO datetime,
	@RETURN_DATE datetime,
	@VAC_PERIOD numeric(5, 0),
	@NOTE varchar(300),
	@TotalDays numeric(5, 0),
	@Netdays numeric(18, 0),
	@Holidays numeric(18, 0),
	@Ticket bit,
	@DEC_FLAG bit,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@PERIOD_FLAG bit,
	@Original_VACID bigint,
	@Original_VAC_TYPE_CODE numeric(5, 0),
	@Original_EMP_CODE bigint,
	@Original_VAC_DATE_FRM datetime,
	@Original_VAC_DATE_TO datetime,
	@IsNull_RETURN_DATE datetime,
	@Original_RETURN_DATE datetime,
	@IsNull_VAC_PERIOD numeric(5, 0),
	@Original_VAC_PERIOD numeric(5, 0),
	@IsNull_NOTE varchar(300),
	@Original_NOTE varchar(300),
	@IsNull_TotalDays numeric(5, 0),
	@Original_TotalDays numeric(5, 0),
	@IsNull_Netdays numeric(18, 0),
	@Original_Netdays numeric(18, 0),
	@IsNull_Holidays numeric(18, 0),
	@Original_Holidays numeric(18, 0),
	@IsNull_Ticket bit,
	@Original_Ticket bit,
	@IsNull_DEC_FLAG bit,
	@Original_DEC_FLAG bit,
	@IsNull_YEAR_CODE int,
	@Original_YEAR_CODE int,
	@IsNull_MONTH_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_PERIOD_FLAG bit,
	@Original_PERIOD_FLAG bit,
	@VACID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_VACATION] SET [VAC_TYPE_CODE] = @VAC_TYPE_CODE, [EMP_CODE] = @EMP_CODE, [VAC_DATE_FRM] = @VAC_DATE_FRM, [VAC_DATE_TO] = @VAC_DATE_TO, [RETURN_DATE] = @RETURN_DATE, [VAC_PERIOD] = @VAC_PERIOD, [NOTE] = @NOTE, [TotalDays] = @TotalDays, [Netdays] = @Netdays, [Holidays] = @Holidays, [Ticket] = @Ticket, [DEC_FLAG] = @DEC_FLAG, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [PERIOD_FLAG] = @PERIOD_FLAG WHERE (([VACID] = @Original_VACID) AND ([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([VAC_DATE_FRM] = @Original_VAC_DATE_FRM) AND ([VAC_DATE_TO] = @Original_VAC_DATE_TO) AND ((@IsNull_RETURN_DATE = 1 AND [RETURN_DATE] IS NULL) OR ([RETURN_DATE] = @Original_RETURN_DATE)) AND ((@IsNull_VAC_PERIOD = 1 AND [VAC_PERIOD] IS NULL) OR ([VAC_PERIOD] = @Original_VAC_PERIOD)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_TotalDays = 1 AND [TotalDays] IS NULL) OR ([TotalDays] = @Original_TotalDays)) AND ((@IsNull_Netdays = 1 AND [Netdays] IS NULL) OR ([Netdays] = @Original_Netdays)) AND ((@IsNull_Holidays = 1 AND [Holidays] IS NULL) OR ([Holidays] = @Original_Holidays)) AND ((@IsNull_Ticket = 1 AND [Ticket] IS NULL) OR ([Ticket] = @Original_Ticket)) AND ((@IsNull_DEC_FLAG = 1 AND [DEC_FLAG] IS NULL) OR ([DEC_FLAG] = @Original_DEC_FLAG)) AND ((@IsNull_YEAR_CODE = 1 AND [YEAR_CODE] IS NULL) OR ([YEAR_CODE] = @Original_YEAR_CODE)) AND ((@IsNull_MONTH_CODE = 1 AND [MONTH_CODE] IS NULL) OR ([MONTH_CODE] = @Original_MONTH_CODE)) AND ((@IsNull_PERIOD_FLAG = 1 AND [PERIOD_FLAG] IS NULL) OR ([PERIOD_FLAG] = @Original_PERIOD_FLAG)));
	
SELECT VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, DEC_FLAG, YEAR_CODE, MONTH_CODE, PERIOD_FLAG FROM PER_EMP_VACATION WHERE (VACID = @VACID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpDelete
(
	@Original_EMP_CODE bigint,
	@IsNull_EmpNum Int,
	@Original_EmpNum bigint,
	@IsNull_CIVILID Int,
	@Original_CIVILID nvarchar(50),
	@IsNull_FName Int,
	@Original_FName varchar(50),
	@IsNull_SName Int,
	@Original_SName varchar(50),
	@IsNull_TName Int,
	@Original_TName varchar(50),
	@IsNull_FoName Int,
	@Original_FoName varchar(50),
	@IsNull_FEngName Int,
	@Original_FEngName varchar(50),
	@IsNull_SEngName Int,
	@Original_SEngName varchar(50),
	@IsNull_TEngName Int,
	@Original_TEngName varchar(50),
	@IsNull_FoEngName Int,
	@Original_FoEngName varchar(50),
	@IsNull_TITLE Int,
	@Original_TITLE nvarchar(150),
	@IsNull_EMP_GENDER Int,
	@Original_EMP_GENDER int,
	@IsNull_EMP_BIRTH_DATE Int,
	@Original_EMP_BIRTH_DATE datetime,
	@IsNull_EMP_BIRTH_PLACE Int,
	@Original_EMP_BIRTH_PLACE varchar(100),
	@IsNull_DEPTCODE Int,
	@Original_DEPTCODE bigint,
	@IsNull_EMP_EMAIL Int,
	@Original_EMP_EMAIL varchar(50),
	@IsNull_EMP_HIREDATE Int,
	@Original_EMP_HIREDATE datetime,
	@IsNull_Emp_End_HIREDATE Int,
	@Original_Emp_End_HIREDATE smalldatetime,
	@IsNull_JOB_CODE Int,
	@Original_JOB_CODE numeric(5, 0),
	@IsNull_JOB_CLS_CODE Int,
	@Original_JOB_CLS_CODE numeric(5, 0),
	@IsNull_FILE_NUM Int,
	@Original_FILE_NUM varchar(20),
	@IsNull_DEGREE_CODE Int,
	@Original_DEGREE_CODE numeric(5, 0),
	@IsNull_REC_TYPE_CODE Int,
	@Original_REC_TYPE_CODE numeric(5, 0),
	@IsNull_MARITAL_STATUS_CODE Int,
	@Original_MARITAL_STATUS_CODE numeric(5, 0),
	@IsNull_NATIONALITY_CODE Int,
	@Original_NATIONALITY_CODE numeric(5, 0),
	@IsNull_GOVER_CODE Int,
	@Original_GOVER_CODE numeric(5, 0),
	@IsNull_EMP_VISA Int,
	@Original_EMP_VISA bit,
	@IsNull_BANK_CODE Int,
	@Original_BANK_CODE numeric(5, 0),
	@IsNull_AccountID Int,
	@Original_AccountID numeric(38, 0),
	@IsNull_NOTES Int,
	@Original_NOTES varchar(300),
	@IsNull_PassportNo Int,
	@Original_PassportNo nvarchar(50),
	@IsNull_PassType Int,
	@Original_PassType nvarchar(50),
	@IsNull_PassDate Int,
	@Original_PassDate smalldatetime,
	@IsNull_PassEndDate Int,
	@Original_PassEndDate smalldatetime,
	@IsNull_Passplace Int,
	@Original_Passplace nvarchar(50),
	@IsNull_entrydate Int,
	@Original_entrydate smalldatetime,
	@IsNull_SALARY Int,
	@Original_SALARY money,
	@IsNull_bankacc Int,
	@Original_bankacc int,
	@IsNull_BRANCH_CODE Int,
	@Original_BRANCH_CODE bigint,
	@IsNull_SalesAdminFalg Int,
	@Original_SalesAdminFalg bit,
	@IsNull_GroupId Int,
	@Original_GroupId bigint,
	@IsNull_ReligionId Int,
	@Original_ReligionId int,
	@IsNull_EducationId Int,
	@Original_EducationId int,
	@IsNull_EducationMajored Int,
	@Original_EducationMajored varchar(100),
	@IsNull_EducationMajoredDate Int,
	@Original_EducationMajoredDate smalldatetime,
	@IsNull_EducationMajoredYear Int,
	@Original_EducationMajoredYear int,
	@IsNull_EducationMajoredPlace Int,
	@Original_EducationMajoredPlace varchar(100),
	@IsNull_LocationId Int,
	@Original_LocationId int,
	@IsNull_RegionId Int,
	@Original_RegionId int,
	@IsNull_DivisionId Int,
	@Original_DivisionId int,
	@IsNull_GardeId Int,
	@Original_GardeId int,
	@IsNull_ResidenceId Int,
	@Original_ResidenceId int,
	@IsNull_ResidenceNo Int,
	@Original_ResidenceNo varchar(50),
	@IsNull_ResidenceRemark Int,
	@Original_ResidenceRemark varchar(200),
	@IsNull_ResidenceIssueDate Int,
	@Original_ResidenceIssueDate smalldatetime,
	@IsNull_ResidenceEndDate Int,
	@Original_ResidenceEndDate smalldatetime,
	@IsNull_LicenseNo Int,
	@Original_LicenseNo varchar(50),
	@IsNull_LicenseTypeId Int,
	@Original_LicenseTypeId int,
	@IsNull_LicenseIssueDate Int,
	@Original_LicenseIssueDate smalldatetime,
	@IsNull_LicenseEndDate Int,
	@Original_LicenseEndDate smalldatetime,
	@IsNull_EMP_HEALTH_INS_DATE Int,
	@Original_EMP_HEALTH_INS_DATE datetime,
	@IsNull_EMP_HEALTH_INS_NUM Int,
	@Original_EMP_HEALTH_INS_NUM varchar(200),
	@IsNull_JoiningDate Int,
	@Original_JoiningDate smalldatetime,
	@IsNull_SalaryType Int,
	@Original_SalaryType int,
	@IsNull_ContractType Int,
	@Original_ContractType int,
	@IsNull_ContractNo Int,
	@Original_ContractNo varchar(50),
	@IsNull_IndemnityDays Int,
	@Original_IndemnityDays numeric(18, 3),
	@IsNull_VaccationDays Int,
	@Original_VaccationDays numeric(18, 3),
	@IsNull_Ticket Int,
	@Original_Ticket numeric(18, 0),
	@IsNull_WorkHourPerDay Int,
	@Original_WorkHourPerDay numeric(18, 3),
	@IsNull_WorkDaysperMonth Int,
	@Original_WorkDaysperMonth numeric(18, 3),
	@IsNull_ADDRESS Int,
	@Original_ADDRESS nvarchar(60),
	@IsNull_BlockNo Int,
	@Original_BlockNo varchar(10),
	@IsNull_Street Int,
	@Original_Street varchar(50),
	@IsNull_Floor Int,
	@Original_Floor varchar(10),
	@IsNull_WorkTel Int,
	@Original_WorkTel varchar(50),
	@IsNull_HomeTel Int,
	@Original_HomeTel varchar(50),
	@IsNull_Mobile1 Int,
	@Original_Mobile1 varchar(50),
	@IsNull_Mobile2 Int,
	@Original_Mobile2 varchar(50),
	@IsNull_Fax Int,
	@Original_Fax varchar(50),
	@IsNull_Email Int,
	@Original_Email varchar(50),
	@IsNull_bank Int,
	@Original_bank bit,
	@IsNull_BankFId Int,
	@Original_BankFId int,
	@IsNull_BankSId Int,
	@Original_BankSId int,
	@IsNull_BankFBranch Int,
	@Original_BankFBranch varchar(50),
	@IsNull_BankSBranch Int,
	@Original_BankSBranch varchar(50),
	@IsNull_BankFAccountNo Int,
	@Original_BankFAccountNo varchar(50),
	@IsNull_BankSAccountNo Int,
	@Original_BankSAccountNo varchar(50),
	@IsNull_DankEffDate Int,
	@Original_DankEffDate smalldatetime,
	@IsNull_JobLevel Int,
	@Original_JobLevel int,
	@IsNull_ContactLocation Int,
	@Original_ContactLocation varchar(100),
	@IsNull_ContactLocationDate Int,
	@Original_ContactLocationDate smalldatetime,
	@IsNull_Status Int,
	@Original_Status int,
	@IsNull_VacEarned Int,
	@Original_VacEarned numeric(18, 3),
	@IsNull_VacTaken Int,
	@Original_VacTaken numeric(18, 3),
	@IsNull_VacBalance Int,
	@Original_VacBalance numeric(18, 3),
	@IsNull_VacUnpaid Int,
	@Original_VacUnpaid numeric(18, 3),
	@IsNull_SALEADMIN Int,
	@Original_SALEADMIN int,
	@IsNull_FullName Int,
	@Original_FullName varchar(200),
	@IsNull_GetAllow Int,
	@Original_GetAllow money,
	@IsNull_PhoneAllow Int,
	@Original_PhoneAllow money,
	@IsNull_TransAllow Int,
	@Original_TransAllow money,
	@IsNull_InsuranceValue Int,
	@Original_InsuranceValue money
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMPLOYEE_DATA] WHERE (([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_EmpNum = 1 AND [EmpNum] IS NULL) OR ([EmpNum] = @Original_EmpNum)) AND ((@IsNull_CIVILID = 1 AND [CIVILID] IS NULL) OR ([CIVILID] = @Original_CIVILID)) AND ((@IsNull_FName = 1 AND [FName] IS NULL) OR ([FName] = @Original_FName)) AND ((@IsNull_SName = 1 AND [SName] IS NULL) OR ([SName] = @Original_SName)) AND ((@IsNull_TName = 1 AND [TName] IS NULL) OR ([TName] = @Original_TName)) AND ((@IsNull_FoName = 1 AND [FoName] IS NULL) OR ([FoName] = @Original_FoName)) AND ((@IsNull_FEngName = 1 AND [FEngName] IS NULL) OR ([FEngName] = @Original_FEngName)) AND ((@IsNull_SEngName = 1 AND [SEngName] IS NULL) OR ([SEngName] = @Original_SEngName)) AND ((@IsNull_TEngName = 1 AND [TEngName] IS NULL) OR ([TEngName] = @Original_TEngName)) AND ((@IsNull_FoEngName = 1 AND [FoEngName] IS NULL) OR ([FoEngName] = @Original_FoEngName)) AND ((@IsNull_TITLE = 1 AND [TITLE] IS NULL) OR ([TITLE] = @Original_TITLE)) AND ((@IsNull_EMP_GENDER = 1 AND [EMP_GENDER] IS NULL) OR ([EMP_GENDER] = @Original_EMP_GENDER)) AND ((@IsNull_EMP_BIRTH_DATE = 1 AND [EMP_BIRTH_DATE] IS NULL) OR ([EMP_BIRTH_DATE] = @Original_EMP_BIRTH_DATE)) AND ((@IsNull_EMP_BIRTH_PLACE = 1 AND [EMP_BIRTH_PLACE] IS NULL) OR ([EMP_BIRTH_PLACE] = @Original_EMP_BIRTH_PLACE)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_EMP_EMAIL = 1 AND [EMP_EMAIL] IS NULL) OR ([EMP_EMAIL] = @Original_EMP_EMAIL)) AND ((@IsNull_EMP_HIREDATE = 1 AND [EMP_HIREDATE] IS NULL) OR ([EMP_HIREDATE] = @Original_EMP_HIREDATE)) AND ((@IsNull_Emp_End_HIREDATE = 1 AND [Emp_End_HIREDATE] IS NULL) OR ([Emp_End_HIREDATE] = @Original_Emp_End_HIREDATE)) AND ((@IsNull_JOB_CODE = 1 AND [JOB_CODE] IS NULL) OR ([JOB_CODE] = @Original_JOB_CODE)) AND ((@IsNull_JOB_CLS_CODE = 1 AND [JOB_CLS_CODE] IS NULL) OR ([JOB_CLS_CODE] = @Original_JOB_CLS_CODE)) AND ((@IsNull_FILE_NUM = 1 AND [FILE_NUM] IS NULL) OR ([FILE_NUM] = @Original_FILE_NUM)) AND ((@IsNull_DEGREE_CODE = 1 AND [DEGREE_CODE] IS NULL) OR ([DEGREE_CODE] = @Original_DEGREE_CODE)) AND ((@IsNull_REC_TYPE_CODE = 1 AND [REC_TYPE_CODE] IS NULL) OR ([REC_TYPE_CODE] = @Original_REC_TYPE_CODE)) AND ((@IsNull_MARITAL_STATUS_CODE = 1 AND [MARITAL_STATUS_CODE] IS NULL) OR ([MARITAL_STATUS_CODE] = @Original_MARITAL_STATUS_CODE)) AND ((@IsNull_NATIONALITY_CODE = 1 AND [NATIONALITY_CODE] IS NULL) OR ([NATIONALITY_CODE] = @Original_NATIONALITY_CODE)) AND ((@IsNull_GOVER_CODE = 1 AND [GOVER_CODE] IS NULL) OR ([GOVER_CODE] = @Original_GOVER_CODE)) AND ((@IsNull_EMP_VISA = 1 AND [EMP_VISA] IS NULL) OR ([EMP_VISA] = @Original_EMP_VISA)) AND ((@IsNull_BANK_CODE = 1 AND [BANK_CODE] IS NULL) OR ([BANK_CODE] = @Original_BANK_CODE)) AND ((@IsNull_AccountID = 1 AND [AccountID] IS NULL) OR ([AccountID] = @Original_AccountID)) AND ((@IsNull_NOTES = 1 AND [NOTES] IS NULL) OR ([NOTES] = @Original_NOTES)) AND ((@IsNull_PassportNo = 1 AND [PassportNo] IS NULL) OR ([PassportNo] = @Original_PassportNo)) AND ((@IsNull_PassType = 1 AND [PassType] IS NULL) OR ([PassType] = @Original_PassType)) AND ((@IsNull_PassDate = 1 AND [PassDate] IS NULL) OR ([PassDate] = @Original_PassDate)) AND ((@IsNull_PassEndDate = 1 AND [PassEndDate] IS NULL) OR ([PassEndDate] = @Original_PassEndDate)) AND ((@IsNull_Passplace = 1 AND [Passplace] IS NULL) OR ([Passplace] = @Original_Passplace)) AND ((@IsNull_entrydate = 1 AND [entrydate] IS NULL) OR ([entrydate] = @Original_entrydate)) AND ((@IsNull_SALARY = 1 AND [SALARY] IS NULL) OR ([SALARY] = @Original_SALARY)) AND ((@IsNull_bankacc = 1 AND [bankacc] IS NULL) OR ([bankacc] = @Original_bankacc)) AND ((@IsNull_BRANCH_CODE = 1 AND [BRANCH_CODE] IS NULL) OR ([BRANCH_CODE] = @Original_BRANCH_CODE)) AND ((@IsNull_SalesAdminFalg = 1 AND [SalesAdminFalg] IS NULL) OR ([SalesAdminFalg] = @Original_SalesAdminFalg)) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)) AND ((@IsNull_ReligionId = 1 AND [ReligionId] IS NULL) OR ([ReligionId] = @Original_ReligionId)) AND ((@IsNull_EducationId = 1 AND [EducationId] IS NULL) OR ([EducationId] = @Original_EducationId)) AND ((@IsNull_EducationMajored = 1 AND [EducationMajored] IS NULL) OR ([EducationMajored] = @Original_EducationMajored)) AND ((@IsNull_EducationMajoredDate = 1 AND [EducationMajoredDate] IS NULL) OR ([EducationMajoredDate] = @Original_EducationMajoredDate)) AND ((@IsNull_EducationMajoredYear = 1 AND [EducationMajoredYear] IS NULL) OR ([EducationMajoredYear] = @Original_EducationMajoredYear)) AND ((@IsNull_EducationMajoredPlace = 1 AND [EducationMajoredPlace] IS NULL) OR ([EducationMajoredPlace] = @Original_EducationMajoredPlace)) AND ((@IsNull_LocationId = 1 AND [LocationId] IS NULL) OR ([LocationId] = @Original_LocationId)) AND ((@IsNull_RegionId = 1 AND [RegionId] IS NULL) OR ([RegionId] = @Original_RegionId)) AND ((@IsNull_DivisionId = 1 AND [DivisionId] IS NULL) OR ([DivisionId] = @Original_DivisionId)) AND ((@IsNull_GardeId = 1 AND [GardeId] IS NULL) OR ([GardeId] = @Original_GardeId)) AND ((@IsNull_ResidenceId = 1 AND [ResidenceId] IS NULL) OR ([ResidenceId] = @Original_ResidenceId)) AND ((@IsNull_ResidenceNo = 1 AND [ResidenceNo] IS NULL) OR ([ResidenceNo] = @Original_ResidenceNo)) AND ((@IsNull_ResidenceRemark = 1 AND [ResidenceRemark] IS NULL) OR ([ResidenceRemark] = @Original_ResidenceRemark)) AND ((@IsNull_ResidenceIssueDate = 1 AND [ResidenceIssueDate] IS NULL) OR ([ResidenceIssueDate] = @Original_ResidenceIssueDate)) AND ((@IsNull_ResidenceEndDate = 1 AND [ResidenceEndDate] IS NULL) OR ([ResidenceEndDate] = @Original_ResidenceEndDate)) AND ((@IsNull_LicenseNo = 1 AND [LicenseNo] IS NULL) OR ([LicenseNo] = @Original_LicenseNo)) AND ((@IsNull_LicenseTypeId = 1 AND [LicenseTypeId] IS NULL) OR ([LicenseTypeId] = @Original_LicenseTypeId)) AND ((@IsNull_LicenseIssueDate = 1 AND [LicenseIssueDate] IS NULL) OR ([LicenseIssueDate] = @Original_LicenseIssueDate)) AND ((@IsNull_LicenseEndDate = 1 AND [LicenseEndDate] IS NULL) OR ([LicenseEndDate] = @Original_LicenseEndDate)) AND ((@IsNull_EMP_HEALTH_INS_DATE = 1 AND [EMP_HEALTH_INS_DATE] IS NULL) OR ([EMP_HEALTH_INS_DATE] = @Original_EMP_HEALTH_INS_DATE)) AND ((@IsNull_EMP_HEALTH_INS_NUM = 1 AND [EMP_HEALTH_INS_NUM] IS NULL) OR ([EMP_HEALTH_INS_NUM] = @Original_EMP_HEALTH_INS_NUM)) AND ((@IsNull_JoiningDate = 1 AND [JoiningDate] IS NULL) OR ([JoiningDate] = @Original_JoiningDate)) AND ((@IsNull_SalaryType = 1 AND [SalaryType] IS NULL) OR ([SalaryType] = @Original_SalaryType)) AND ((@IsNull_ContractType = 1 AND [ContractType] IS NULL) OR ([ContractType] = @Original_ContractType)) AND ((@IsNull_ContractNo = 1 AND [ContractNo] IS NULL) OR ([ContractNo] = @Original_ContractNo)) AND ((@IsNull_IndemnityDays = 1 AND [IndemnityDays] IS NULL) OR ([IndemnityDays] = @Original_IndemnityDays)) AND ((@IsNull_VaccationDays = 1 AND [VaccationDays] IS NULL) OR ([VaccationDays] = @Original_VaccationDays)) AND ((@IsNull_Ticket = 1 AND [Ticket] IS NULL) OR ([Ticket] = @Original_Ticket)) AND ((@IsNull_WorkHourPerDay = 1 AND [WorkHourPerDay] IS NULL) OR ([WorkHourPerDay] = @Original_WorkHourPerDay)) AND ((@IsNull_WorkDaysperMonth = 1 AND [WorkDaysperMonth] IS NULL) OR ([WorkDaysperMonth] = @Original_WorkDaysperMonth)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_BlockNo = 1 AND [BlockNo] IS NULL) OR ([BlockNo] = @Original_BlockNo)) AND ((@IsNull_Street = 1 AND [Street] IS NULL) OR ([Street] = @Original_Street)) AND ((@IsNull_Floor = 1 AND [Floor] IS NULL) OR ([Floor] = @Original_Floor)) AND ((@IsNull_WorkTel = 1 AND [WorkTel] IS NULL) OR ([WorkTel] = @Original_WorkTel)) AND ((@IsNull_HomeTel = 1 AND [HomeTel] IS NULL) OR ([HomeTel] = @Original_HomeTel)) AND ((@IsNull_Mobile1 = 1 AND [Mobile1] IS NULL) OR ([Mobile1] = @Original_Mobile1)) AND ((@IsNull_Mobile2 = 1 AND [Mobile2] IS NULL) OR ([Mobile2] = @Original_Mobile2)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_bank = 1 AND [bank] IS NULL) OR ([bank] = @Original_bank)) AND ((@IsNull_BankFId = 1 AND [BankFId] IS NULL) OR ([BankFId] = @Original_BankFId)) AND ((@IsNull_BankSId = 1 AND [BankSId] IS NULL) OR ([BankSId] = @Original_BankSId)) AND ((@IsNull_BankFBranch = 1 AND [BankFBranch] IS NULL) OR ([BankFBranch] = @Original_BankFBranch)) AND ((@IsNull_BankSBranch = 1 AND [BankSBranch] IS NULL) OR ([BankSBranch] = @Original_BankSBranch)) AND ((@IsNull_BankFAccountNo = 1 AND [BankFAccountNo] IS NULL) OR ([BankFAccountNo] = @Original_BankFAccountNo)) AND ((@IsNull_BankSAccountNo = 1 AND [BankSAccountNo] IS NULL) OR ([BankSAccountNo] = @Original_BankSAccountNo)) AND ((@IsNull_DankEffDate = 1 AND [DankEffDate] IS NULL) OR ([DankEffDate] = @Original_DankEffDate)) AND ((@IsNull_JobLevel = 1 AND [JobLevel] IS NULL) OR ([JobLevel] = @Original_JobLevel)) AND ((@IsNull_ContactLocation = 1 AND [ContactLocation] IS NULL) OR ([ContactLocation] = @Original_ContactLocation)) AND ((@IsNull_ContactLocationDate = 1 AND [ContactLocationDate] IS NULL) OR ([ContactLocationDate] = @Original_ContactLocationDate)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND ((@IsNull_VacEarned = 1 AND [VacEarned] IS NULL) OR ([VacEarned] = @Original_VacEarned)) AND ((@IsNull_VacTaken = 1 AND [VacTaken] IS NULL) OR ([VacTaken] = @Original_VacTaken)) AND ((@IsNull_VacBalance = 1 AND [VacBalance] IS NULL) OR ([VacBalance] = @Original_VacBalance)) AND ((@IsNull_VacUnpaid = 1 AND [VacUnpaid] IS NULL) OR ([VacUnpaid] = @Original_VacUnpaid)) AND ((@IsNull_SALEADMIN = 1 AND [SALEADMIN] IS NULL) OR ([SALEADMIN] = @Original_SALEADMIN)) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_GetAllow = 1 AND [GetAllow] IS NULL) OR ([GetAllow] = @Original_GetAllow)) AND ((@IsNull_PhoneAllow = 1 AND [PhoneAllow] IS NULL) OR ([PhoneAllow] = @Original_PhoneAllow)) AND ((@IsNull_TransAllow = 1 AND [TransAllow] IS NULL) OR ([TransAllow] = @Original_TransAllow)) AND ((@IsNull_InsuranceValue = 1 AND [InsuranceValue] IS NULL) OR ([InsuranceValue] = @Original_InsuranceValue)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpGroupOffDayDelete
(
	@Original_Id bigint,
	@IsNull_GroupId bigint,
	@Original_GroupId bigint,
	@IsNull_DayDesc varchar(50),
	@Original_DayDesc varchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [EmpGroupOffDay] WHERE (([Id] = @Original_Id) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)) AND ((@IsNull_DayDesc = 1 AND [DayDesc] IS NULL) OR ([DayDesc] = @Original_DayDesc)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpGroupOffDayInsert
(
	@GroupId bigint,
	@DayDesc varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [EmpGroupOffDay] ([GroupId], [DayDesc]) VALUES (@GroupId, @DayDesc);
	
SELECT Id, GroupId, DayDesc FROM EmpGroupOffDay WHERE (Id = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpGroupOffDaySelect
AS
	SET NOCOUNT ON;
SELECT     EmpGroupOffDay.*
FROM         EmpGroupOffDay







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpGroupOffDayUpdate
(
	@GroupId bigint,
	@DayDesc varchar(50),
	@Original_Id bigint,
	@IsNull_GroupId bigint,
	@Original_GroupId bigint,
	@IsNull_DayDesc varchar(50),
	@Original_DayDesc varchar(50),
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [EmpGroupOffDay] SET [GroupId] = @GroupId, [DayDesc] = @DayDesc WHERE (([Id] = @Original_Id) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)) AND ((@IsNull_DayDesc = 1 AND [DayDesc] IS NULL) OR ([DayDesc] = @Original_DayDesc)));
	
SELECT Id, GroupId, DayDesc FROM EmpGroupOffDay WHERE (Id = @Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpInOutDelete
(
	@Original_Id bigint,
	@Original_EnrollNo varchar(20),
	@IsNull_VerifyMode varchar(50),
	@Original_VerifyMode varchar(50),
	@IsNull_InOutMode varchar(50),
	@Original_InOutMode varchar(50),
	@IsNull_checktime datetime,
	@Original_checktime datetime,
	@IsNull_flag int,
	@Original_flag int,
	@IsNull_CheckDay smalldatetime,
	@Original_CheckDay smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [EmpInOut] WHERE (([Id] = @Original_Id) AND ([EnrollNo] = @Original_EnrollNo) AND ((@IsNull_VerifyMode = 1 AND [VerifyMode] IS NULL) OR ([VerifyMode] = @Original_VerifyMode)) AND ((@IsNull_InOutMode = 1 AND [InOutMode] IS NULL) OR ([InOutMode] = @Original_InOutMode)) AND ((@IsNull_checktime = 1 AND [checktime] IS NULL) OR ([checktime] = @Original_checktime)) AND ((@IsNull_flag = 1 AND [flag] IS NULL) OR ([flag] = @Original_flag)) AND ((@IsNull_CheckDay = 1 AND [CheckDay] IS NULL) OR ([CheckDay] = @Original_CheckDay)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpInOutInsert
(
	@EnrollNo varchar(20),
	@VerifyMode varchar(50),
	@InOutMode varchar(50),
	@checktime datetime,
	@flag int,
	@CheckDay smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [EmpInOut] ([EnrollNo], [VerifyMode], [InOutMode], [checktime], [flag], [CheckDay]) VALUES (@EnrollNo, @VerifyMode, @InOutMode, @checktime, @flag, @CheckDay);
	
SELECT Id, EnrollNo, VerifyMode, InOutMode, checktime, flag, CheckDay FROM EmpInOut WHERE (Id = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpInOutSelect
AS
	SET NOCOUNT ON;
SELECT     Id, EnrollNo, VerifyMode, InOutMode, checktime, flag, CheckDay
FROM         EmpInOut







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpInOutUpdate
(
	@EnrollNo varchar(20),
	@VerifyMode varchar(50),
	@InOutMode varchar(50),
	@checktime datetime,
	@flag int,
	@CheckDay smalldatetime,
	@Original_Id bigint,
	@Original_EnrollNo varchar(20),
	@IsNull_VerifyMode varchar(50),
	@Original_VerifyMode varchar(50),
	@IsNull_InOutMode varchar(50),
	@Original_InOutMode varchar(50),
	@IsNull_checktime datetime,
	@Original_checktime datetime,
	@IsNull_flag int,
	@Original_flag int,
	@IsNull_CheckDay smalldatetime,
	@Original_CheckDay smalldatetime,
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [EmpInOut] SET [EnrollNo] = @EnrollNo, [VerifyMode] = @VerifyMode, [InOutMode] = @InOutMode, [checktime] = @checktime, [flag] = @flag, [CheckDay] = @CheckDay WHERE (([Id] = @Original_Id) AND ([EnrollNo] = @Original_EnrollNo) AND ((@IsNull_VerifyMode = 1 AND [VerifyMode] IS NULL) OR ([VerifyMode] = @Original_VerifyMode)) AND ((@IsNull_InOutMode = 1 AND [InOutMode] IS NULL) OR ([InOutMode] = @Original_InOutMode)) AND ((@IsNull_checktime = 1 AND [checktime] IS NULL) OR ([checktime] = @Original_checktime)) AND ((@IsNull_flag = 1 AND [flag] IS NULL) OR ([flag] = @Original_flag)) AND ((@IsNull_CheckDay = 1 AND [CheckDay] IS NULL) OR ([CheckDay] = @Original_CheckDay)));
	
SELECT Id, EnrollNo, VerifyMode, InOutMode, checktime, flag, CheckDay FROM EmpInOut WHERE (Id = @Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EmpInOutViewSelect
AS
	SET NOCOUNT ON;

 select EMP_CODE, CIVILID, FName, 
                      SName, TName, FoName, TITLE, 
                      EmpNum, GroupName, NutalAttendance, SalaryCul, 
                      DefDate, WorkHour, VactionNum, AbsenceHourPercentage, 
                      AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, 
                      SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId, 
                      SickVactionNum, Shift1From, Shift1To, Shift2From, Shift2To, 
                      TwoShift, OffDays, DEPTCODE, GroupId, 
                      FullName, EnrollNo, Minchecktime1, Maxchecktime1, Minchecktime2, Maxchecktime2, 
                      CheckDay, VerifyMode, flag

FROM         EmpInOutView







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EmpInOutViewSelectByParam
(
@Emp_code bigint,
@FName varchar(50),
@SName varchar(50),
@TName varchar(50),
@FoName varchar(50),
@EmpNum as bigint,
@DeptCode bigint,
@GroupId bigint,
@FromDate smalldatetime,
@ToDate smalldatetime
)
AS
	SET NOCOUNT ON;
 select EMP_CODE, CIVILID, FName, 
                      SName, TName, FoName, TITLE, 
                      EmpNum, GroupName, NutalAttendance, SalaryCul, 
                      DefDate, WorkHour, VactionNum, AbsenceHourPercentage, 
                      AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, 
                      SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId, 
                      SickVactionNum, Shift1From, Shift1To, Shift2From, Shift2To, 
                      TwoShift, OffDays, DEPTCODE, GroupId, 
                      FullName, EnrollNo,Minchecktime1, Maxchecktime1, Minchecktime2, Maxchecktime2, 
                      CheckDay, VerifyMode, flag
FROM         EmpInOutView
WHERE     (EMP_CODE = @Emp_code or  @Emp_code IS NULL)  AND (FName like  @FName + '%' OR @FName IS NULL)
AND (SName like  @SName + '%'   OR @SName IS NULL) 
AND (TName  like  @TName + '%'    OR  @TName IS NULL) 
AND (FoName  like  @FoName + '%'   OR  @FoName IS NULL) and (EmpNum = @EmpNum or  @EmpNum IS NULL)
AND (DEPTCODE = @DeptCode OR  @DeptCode IS NULL) and (GroupId=@GroupId or @GroupId is null) 
AND (CheckDay >= @FromDate  ) AND (CheckDay <= @ToDate )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpInsert
(
	@EmpNum bigint,
	@CIVILID nvarchar(50),
	@FName varchar(50),
	@SName varchar(50),
	@TName varchar(50),
	@FoName varchar(50),
	@FEngName varchar(50),
	@SEngName varchar(50),
	@TEngName varchar(50),
	@FoEngName varchar(50),
	@TITLE nvarchar(150),
	@EMP_GENDER int,
	@EMP_BIRTH_DATE datetime,
	@EMP_BIRTH_PLACE varchar(100),
	@DEPTCODE bigint,
	@EMP_EMAIL varchar(50),
	@EMP_HIREDATE datetime,
	@Emp_End_HIREDATE smalldatetime,
	@JOB_CODE numeric(5, 0),
	@JOB_CLS_CODE numeric(5, 0),
	@FILE_NUM varchar(20),
	@DEGREE_CODE numeric(5, 0),
	@REC_TYPE_CODE numeric(5, 0),
	@MARITAL_STATUS_CODE numeric(5, 0),
	@NATIONALITY_CODE numeric(5, 0),
	@GOVER_CODE numeric(5, 0),
	@EMP_VISA bit,
	@BANK_CODE numeric(5, 0),
	@AccountID numeric(38, 0),
	@NOTES varchar(300),
	@PassportNo nvarchar(50),
	@PassType nvarchar(50),
	@PassDate smalldatetime,
	@PassEndDate smalldatetime,
	@Passplace nvarchar(50),
	@entrydate smalldatetime,
	@SALARY money,
	@bankacc int,
	@BRANCH_CODE bigint,
	@SalesAdminFalg bit,
	@GroupId bigint,
	@ReligionId int,
	@EducationId int,
	@EducationMajored varchar(100),
	@EducationMajoredDate smalldatetime,
	@EducationMajoredYear int,
	@EducationMajoredPlace varchar(100),
	@LocationId int,
	@RegionId int,
	@DivisionId int,
	@GardeId int,
	@ResidenceId int,
	@ResidenceNo varchar(50),
	@ResidenceRemark varchar(200),
	@ResidenceIssueDate smalldatetime,
	@ResidenceEndDate smalldatetime,
	@LicenseNo varchar(50),
	@LicenseTypeId int,
	@LicenseIssueDate smalldatetime,
	@LicenseEndDate smalldatetime,
	@EMP_HEALTH_INS_DATE datetime,
	@EMP_HEALTH_INS_NUM varchar(200),
	@JoiningDate smalldatetime,
	@SalaryType int,
	@ContractType int,
	@ContractNo varchar(50),
	@IndemnityDays numeric(18, 3),
	@VaccationDays numeric(18, 3),
	@Ticket numeric(18, 0),
	@WorkHourPerDay numeric(18, 3),
	@WorkDaysperMonth numeric(18, 3),
	@ADDRESS nvarchar(60),
	@BlockNo varchar(10),
	@Street varchar(50),
	@Floor varchar(10),
	@WorkTel varchar(50),
	@HomeTel varchar(50),
	@Mobile1 varchar(50),
	@Mobile2 varchar(50),
	@Fax varchar(50),
	@Email varchar(50),
	@bank bit,
	@BankFId int,
	@BankSId int,
	@BankFBranch varchar(50),
	@BankSBranch varchar(50),
	@BankFAccountNo varchar(50),
	@BankSAccountNo varchar(50),
	@DankEffDate smalldatetime,
	@JobLevel int,
	@ContactLocation varchar(100),
	@ContactLocationDate smalldatetime,
	@Status int,
	@VacEarned numeric(18, 3),
	@VacTaken numeric(18, 3),
	@VacBalance numeric(18, 3),
	@VacUnpaid numeric(18, 3),
	@SALEADMIN int,
	@FullName varchar(200),
	@GetAllow money,
	@PhoneAllow money,
	@TransAllow money,
	@InsuranceValue money
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMPLOYEE_DATA] ([EmpNum], [CIVILID], [FName], [SName], [TName], [FoName], [FEngName], [SEngName], [TEngName], [FoEngName], [TITLE], [EMP_GENDER], [EMP_BIRTH_DATE], [EMP_BIRTH_PLACE], [DEPTCODE], [EMP_EMAIL], [EMP_HIREDATE], [Emp_End_HIREDATE], [JOB_CODE], [JOB_CLS_CODE], [FILE_NUM], [DEGREE_CODE], [REC_TYPE_CODE], [MARITAL_STATUS_CODE], [NATIONALITY_CODE], [GOVER_CODE], [EMP_VISA], [BANK_CODE], [AccountID], [NOTES], [PassportNo], [PassType], [PassDate], [PassEndDate], [Passplace], [entrydate], [SALARY], [bankacc], [BRANCH_CODE], [SalesAdminFalg], [GroupId], [ReligionId], [EducationId], [EducationMajored], [EducationMajoredDate], [EducationMajoredYear], [EducationMajoredPlace], [LocationId], [RegionId], [DivisionId], [GardeId], [ResidenceId], [ResidenceNo], [ResidenceRemark], [ResidenceIssueDate], [ResidenceEndDate], [LicenseNo], [LicenseTypeId], [LicenseIssueDate], [LicenseEndDate], [EMP_HEALTH_INS_DATE], [EMP_HEALTH_INS_NUM], [JoiningDate], [SalaryType], [ContractType], [ContractNo], [IndemnityDays], [VaccationDays], [Ticket], [WorkHourPerDay], [WorkDaysperMonth], [ADDRESS], [BlockNo], [Street], [Floor], [WorkTel], [HomeTel], [Mobile1], [Mobile2], [Fax], [Email], [bank], [BankFId], [BankSId], [BankFBranch], [BankSBranch], [BankFAccountNo], [BankSAccountNo], [DankEffDate], [JobLevel], [ContactLocation], [ContactLocationDate], [Status], [VacEarned], [VacTaken], [VacBalance], [VacUnpaid], [SALEADMIN], [FullName], [GetAllow], [PhoneAllow], [TransAllow], [InsuranceValue]) VALUES (@EmpNum, @CIVILID, @FName, @SName, @TName, @FoName, @FEngName, @SEngName, @TEngName, @FoEngName, @TITLE, @EMP_GENDER, @EMP_BIRTH_DATE, @EMP_BIRTH_PLACE, @DEPTCODE, @EMP_EMAIL, @EMP_HIREDATE, @Emp_End_HIREDATE, @JOB_CODE, @JOB_CLS_CODE, @FILE_NUM, @DEGREE_CODE, @REC_TYPE_CODE, @MARITAL_STATUS_CODE, @NATIONALITY_CODE, @GOVER_CODE, @EMP_VISA, @BANK_CODE, @AccountID, @NOTES, @PassportNo, @PassType, @PassDate, @PassEndDate, @Passplace, @entrydate, @SALARY, @bankacc, @BRANCH_CODE, @SalesAdminFalg, @GroupId, @ReligionId, @EducationId, @EducationMajored, @EducationMajoredDate, @EducationMajoredYear, @EducationMajoredPlace, @LocationId, @RegionId, @DivisionId, @GardeId, @ResidenceId, @ResidenceNo, @ResidenceRemark, @ResidenceIssueDate, @ResidenceEndDate, @LicenseNo, @LicenseTypeId, @LicenseIssueDate, @LicenseEndDate, @EMP_HEALTH_INS_DATE, @EMP_HEALTH_INS_NUM, @JoiningDate, @SalaryType, @ContractType, @ContractNo, @IndemnityDays, @VaccationDays, @Ticket, @WorkHourPerDay, @WorkDaysperMonth, @ADDRESS, @BlockNo, @Street, @Floor, @WorkTel, @HomeTel, @Mobile1, @Mobile2, @Fax, @Email, @bank, @BankFId, @BankSId, @BankFBranch, @BankSBranch, @BankFAccountNo, @BankSAccountNo, @DankEffDate, @JobLevel, @ContactLocation, @ContactLocationDate, @Status, @VacEarned, @VacTaken, @VacBalance, @VacUnpaid, @SALEADMIN, @FullName, @GetAllow, @PhoneAllow, @TransAllow, @InsuranceValue);
	
SELECT EMP_CODE, EmpNum, CIVILID, FName, SName, TName, FoName, FEngName, SEngName, TEngName, FoEngName, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_BIRTH_PLACE, DEPTCODE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, JOB_CODE, JOB_CLS_CODE, FILE_NUM, DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, BANK_CODE, AccountID, NOTES, PassportNo, PassType, PassDate, PassEndDate, Passplace, entrydate, SALARY, bankacc, BRANCH_CODE, SalesAdminFalg, GroupId, ReligionId, EducationId, EducationMajored, EducationMajoredDate, EducationMajoredYear, EducationMajoredPlace, LocationId, RegionId, DivisionId, GardeId, ResidenceId, ResidenceNo, ResidenceRemark, ResidenceIssueDate, ResidenceEndDate, LicenseNo, LicenseTypeId, LicenseIssueDate, LicenseEndDate, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JoiningDate, SalaryType, ContractType, ContractNo, IndemnityDays, VaccationDays, Ticket, WorkHourPerDay, WorkDaysperMonth, ADDRESS, BlockNo, Street, Floor, WorkTel, HomeTel, Mobile1, Mobile2, Fax, Email, bank, BankFId, BankSId, BankFBranch, BankSBranch, BankFAccountNo, BankSAccountNo, DankEffDate, JobLevel, ContactLocation, ContactLocationDate, Status, VacEarned, VacTaken, VacBalance, VacUnpaid, SALEADMIN, FullName, GetAllow, PhoneAllow, TransAllow, InsuranceValue FROM PER_EMPLOYEE_DATA WHERE (EMP_CODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpSelect
AS
	SET NOCOUNT ON;
SELECT     EMP_CODE, EmpNum, CIVILID, FName, SName, TName, FoName, FEngName, SEngName, TEngName, FoEngName, TITLE, EMP_GENDER, 
                      EMP_BIRTH_DATE, EMP_BIRTH_PLACE, DEPTCODE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, JOB_CODE, JOB_CLS_CODE, FILE_NUM, 
                      DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, BANK_CODE, AccountID, NOTES, 
                      PassportNo, PassType, PassDate, PassEndDate, Passplace, entrydate, SALARY, bankacc, BRANCH_CODE, SalesAdminFalg, GroupId, ReligionId, 
                      EducationId, EducationMajored, EducationMajoredDate, EducationMajoredYear, EducationMajoredPlace, LocationId, RegionId, DivisionId, GardeId, 
                      ResidenceId, ResidenceNo, ResidenceRemark, ResidenceIssueDate, ResidenceEndDate, LicenseNo, LicenseTypeId, LicenseIssueDate, 
                      LicenseEndDate, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JoiningDate, SalaryType, ContractType, ContractNo, IndemnityDays, 
                      VaccationDays, Ticket, WorkHourPerDay, WorkDaysperMonth, ADDRESS, BlockNo, Street, Floor, WorkTel, HomeTel, Mobile1, Mobile2, Fax, Email, 
                      bank, BankFId, BankSId, BankFBranch, BankSBranch, BankFAccountNo, BankSAccountNo, DankEffDate, JobLevel, ContactLocation, 
                      ContactLocationDate, Status, VacEarned, VacTaken, VacBalance, VacUnpaid, SALEADMIN, FullName, GetAllow, PhoneAllow, TransAllow, 
                      InsuranceValue
FROM         PER_EMPLOYEE_DATA







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EmpTotMonthAttendenceViewSelect
AS
	SET NOCOUNT ON;
SELECT     Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, 
                      Note, TITLE, EmpNum, DEPTCODE, GroupId, DEPT_DESC, GroupName, FullName, CIVILID, FName, SName, TName, FoName
FROM         EmpTotMonthAttendenceView







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_EmpTotMonthAttendenceViewSelectByParam
(
@year bigint,
@month bigint,
@Emp_code bigint,
@FName varchar(50),
@SName varchar(50),
@TName varchar(50),
@FoName varchar(50),
@EmpNum as bigint,
@DeptCode bigint,
@GroupId bigint

)
AS
	SET NOCOUNT ON;
SELECT     Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, 
                      Note, TITLE, EmpNum, DEPTCODE, GroupId, DEPT_DESC, GroupName, FullName, CIVILID, FName, SName, TName, FoName
FROM         EmpTotMonthAttendenceView

WHERE     (EMP_CODE = @Emp_code or  @Emp_code IS NULL)  AND (FName like  @FName + '%' OR @FName IS NULL)
AND (SName like  @SName + '%'   OR @SName IS NULL) 
AND (TName  like  @TName + '%'    OR  @TName IS NULL) 
AND (FoName  like  @FoName + '%'   OR  @FoName IS NULL) and (EmpNum = @EmpNum or  @EmpNum IS NULL)
AND (DEPTCODE = @DeptCode OR  @DeptCode IS NULL) and (GroupId=@GroupId or @GroupId is null) 
AND (YEAR_CODE = @year  ) AND (MONTH_CODE = @month )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_EmpUpdate
(
	@EmpNum bigint,
	@CIVILID nvarchar(50),
	@FName varchar(50),
	@SName varchar(50),
	@TName varchar(50),
	@FoName varchar(50),
	@FEngName varchar(50),
	@SEngName varchar(50),
	@TEngName varchar(50),
	@FoEngName varchar(50),
	@TITLE nvarchar(150),
	@EMP_GENDER int,
	@EMP_BIRTH_DATE datetime,
	@EMP_BIRTH_PLACE varchar(100),
	@DEPTCODE bigint,
	@EMP_EMAIL varchar(50),
	@EMP_HIREDATE datetime,
	@Emp_End_HIREDATE smalldatetime,
	@JOB_CODE numeric(5, 0),
	@JOB_CLS_CODE numeric(5, 0),
	@FILE_NUM varchar(20),
	@DEGREE_CODE numeric(5, 0),
	@REC_TYPE_CODE numeric(5, 0),
	@MARITAL_STATUS_CODE numeric(5, 0),
	@NATIONALITY_CODE numeric(5, 0),
	@GOVER_CODE numeric(5, 0),
	@EMP_VISA bit,
	@BANK_CODE numeric(5, 0),
	@AccountID numeric(38, 0),
	@NOTES varchar(300),
	@PassportNo nvarchar(50),
	@PassType nvarchar(50),
	@PassDate smalldatetime,
	@PassEndDate smalldatetime,
	@Passplace nvarchar(50),
	@entrydate smalldatetime,
	@SALARY money,
	@bankacc int,
	@BRANCH_CODE bigint,
	@SalesAdminFalg bit,
	@GroupId bigint,
	@ReligionId int,
	@EducationId int,
	@EducationMajored varchar(100),
	@EducationMajoredDate smalldatetime,
	@EducationMajoredYear int,
	@EducationMajoredPlace varchar(100),
	@LocationId int,
	@RegionId int,
	@DivisionId int,
	@GardeId int,
	@ResidenceId int,
	@ResidenceNo varchar(50),
	@ResidenceRemark varchar(200),
	@ResidenceIssueDate smalldatetime,
	@ResidenceEndDate smalldatetime,
	@LicenseNo varchar(50),
	@LicenseTypeId int,
	@LicenseIssueDate smalldatetime,
	@LicenseEndDate smalldatetime,
	@EMP_HEALTH_INS_DATE datetime,
	@EMP_HEALTH_INS_NUM varchar(200),
	@JoiningDate smalldatetime,
	@SalaryType int,
	@ContractType int,
	@ContractNo varchar(50),
	@IndemnityDays numeric(18, 3),
	@VaccationDays numeric(18, 3),
	@Ticket numeric(18, 0),
	@WorkHourPerDay numeric(18, 3),
	@WorkDaysperMonth numeric(18, 3),
	@ADDRESS nvarchar(60),
	@BlockNo varchar(10),
	@Street varchar(50),
	@Floor varchar(10),
	@WorkTel varchar(50),
	@HomeTel varchar(50),
	@Mobile1 varchar(50),
	@Mobile2 varchar(50),
	@Fax varchar(50),
	@Email varchar(50),
	@bank bit,
	@BankFId int,
	@BankSId int,
	@BankFBranch varchar(50),
	@BankSBranch varchar(50),
	@BankFAccountNo varchar(50),
	@BankSAccountNo varchar(50),
	@DankEffDate smalldatetime,
	@JobLevel int,
	@ContactLocation varchar(100),
	@ContactLocationDate smalldatetime,
	@Status int,
	@VacEarned numeric(18, 3),
	@VacTaken numeric(18, 3),
	@VacBalance numeric(18, 3),
	@VacUnpaid numeric(18, 3),
	@SALEADMIN int,
	@FullName varchar(200),
	@GetAllow money,
	@PhoneAllow money,
	@TransAllow money,
	@InsuranceValue money,
	@Original_EMP_CODE bigint,
	@IsNull_EmpNum Int,
	@Original_EmpNum bigint,
	@IsNull_CIVILID Int,
	@Original_CIVILID nvarchar(50),
	@IsNull_FName Int,
	@Original_FName varchar(50),
	@IsNull_SName Int,
	@Original_SName varchar(50),
	@IsNull_TName Int,
	@Original_TName varchar(50),
	@IsNull_FoName Int,
	@Original_FoName varchar(50),
	@IsNull_FEngName Int,
	@Original_FEngName varchar(50),
	@IsNull_SEngName Int,
	@Original_SEngName varchar(50),
	@IsNull_TEngName Int,
	@Original_TEngName varchar(50),
	@IsNull_FoEngName Int,
	@Original_FoEngName varchar(50),
	@IsNull_TITLE Int,
	@Original_TITLE nvarchar(150),
	@IsNull_EMP_GENDER Int,
	@Original_EMP_GENDER int,
	@IsNull_EMP_BIRTH_DATE Int,
	@Original_EMP_BIRTH_DATE datetime,
	@IsNull_EMP_BIRTH_PLACE Int,
	@Original_EMP_BIRTH_PLACE varchar(100),
	@IsNull_DEPTCODE Int,
	@Original_DEPTCODE bigint,
	@IsNull_EMP_EMAIL Int,
	@Original_EMP_EMAIL varchar(50),
	@IsNull_EMP_HIREDATE Int,
	@Original_EMP_HIREDATE datetime,
	@IsNull_Emp_End_HIREDATE Int,
	@Original_Emp_End_HIREDATE smalldatetime,
	@IsNull_JOB_CODE Int,
	@Original_JOB_CODE numeric(5, 0),
	@IsNull_JOB_CLS_CODE Int,
	@Original_JOB_CLS_CODE numeric(5, 0),
	@IsNull_FILE_NUM Int,
	@Original_FILE_NUM varchar(20),
	@IsNull_DEGREE_CODE Int,
	@Original_DEGREE_CODE numeric(5, 0),
	@IsNull_REC_TYPE_CODE Int,
	@Original_REC_TYPE_CODE numeric(5, 0),
	@IsNull_MARITAL_STATUS_CODE Int,
	@Original_MARITAL_STATUS_CODE numeric(5, 0),
	@IsNull_NATIONALITY_CODE Int,
	@Original_NATIONALITY_CODE numeric(5, 0),
	@IsNull_GOVER_CODE Int,
	@Original_GOVER_CODE numeric(5, 0),
	@IsNull_EMP_VISA Int,
	@Original_EMP_VISA bit,
	@IsNull_BANK_CODE Int,
	@Original_BANK_CODE numeric(5, 0),
	@IsNull_AccountID Int,
	@Original_AccountID numeric(38, 0),
	@IsNull_NOTES Int,
	@Original_NOTES varchar(300),
	@IsNull_PassportNo Int,
	@Original_PassportNo nvarchar(50),
	@IsNull_PassType Int,
	@Original_PassType nvarchar(50),
	@IsNull_PassDate Int,
	@Original_PassDate smalldatetime,
	@IsNull_PassEndDate Int,
	@Original_PassEndDate smalldatetime,
	@IsNull_Passplace Int,
	@Original_Passplace nvarchar(50),
	@IsNull_entrydate Int,
	@Original_entrydate smalldatetime,
	@IsNull_SALARY Int,
	@Original_SALARY money,
	@IsNull_bankacc Int,
	@Original_bankacc int,
	@IsNull_BRANCH_CODE Int,
	@Original_BRANCH_CODE bigint,
	@IsNull_SalesAdminFalg Int,
	@Original_SalesAdminFalg bit,
	@IsNull_GroupId Int,
	@Original_GroupId bigint,
	@IsNull_ReligionId Int,
	@Original_ReligionId int,
	@IsNull_EducationId Int,
	@Original_EducationId int,
	@IsNull_EducationMajored Int,
	@Original_EducationMajored varchar(100),
	@IsNull_EducationMajoredDate Int,
	@Original_EducationMajoredDate smalldatetime,
	@IsNull_EducationMajoredYear Int,
	@Original_EducationMajoredYear int,
	@IsNull_EducationMajoredPlace Int,
	@Original_EducationMajoredPlace varchar(100),
	@IsNull_LocationId Int,
	@Original_LocationId int,
	@IsNull_RegionId Int,
	@Original_RegionId int,
	@IsNull_DivisionId Int,
	@Original_DivisionId int,
	@IsNull_GardeId Int,
	@Original_GardeId int,
	@IsNull_ResidenceId Int,
	@Original_ResidenceId int,
	@IsNull_ResidenceNo Int,
	@Original_ResidenceNo varchar(50),
	@IsNull_ResidenceRemark Int,
	@Original_ResidenceRemark varchar(200),
	@IsNull_ResidenceIssueDate Int,
	@Original_ResidenceIssueDate smalldatetime,
	@IsNull_ResidenceEndDate Int,
	@Original_ResidenceEndDate smalldatetime,
	@IsNull_LicenseNo Int,
	@Original_LicenseNo varchar(50),
	@IsNull_LicenseTypeId Int,
	@Original_LicenseTypeId int,
	@IsNull_LicenseIssueDate Int,
	@Original_LicenseIssueDate smalldatetime,
	@IsNull_LicenseEndDate Int,
	@Original_LicenseEndDate smalldatetime,
	@IsNull_EMP_HEALTH_INS_DATE Int,
	@Original_EMP_HEALTH_INS_DATE datetime,
	@IsNull_EMP_HEALTH_INS_NUM Int,
	@Original_EMP_HEALTH_INS_NUM varchar(200),
	@IsNull_JoiningDate Int,
	@Original_JoiningDate smalldatetime,
	@IsNull_SalaryType Int,
	@Original_SalaryType int,
	@IsNull_ContractType Int,
	@Original_ContractType int,
	@IsNull_ContractNo Int,
	@Original_ContractNo varchar(50),
	@IsNull_IndemnityDays Int,
	@Original_IndemnityDays numeric(18, 3),
	@IsNull_VaccationDays Int,
	@Original_VaccationDays numeric(18, 3),
	@IsNull_Ticket Int,
	@Original_Ticket numeric(18, 0),
	@IsNull_WorkHourPerDay Int,
	@Original_WorkHourPerDay numeric(18, 3),
	@IsNull_WorkDaysperMonth Int,
	@Original_WorkDaysperMonth numeric(18, 3),
	@IsNull_ADDRESS Int,
	@Original_ADDRESS nvarchar(60),
	@IsNull_BlockNo Int,
	@Original_BlockNo varchar(10),
	@IsNull_Street Int,
	@Original_Street varchar(50),
	@IsNull_Floor Int,
	@Original_Floor varchar(10),
	@IsNull_WorkTel Int,
	@Original_WorkTel varchar(50),
	@IsNull_HomeTel Int,
	@Original_HomeTel varchar(50),
	@IsNull_Mobile1 Int,
	@Original_Mobile1 varchar(50),
	@IsNull_Mobile2 Int,
	@Original_Mobile2 varchar(50),
	@IsNull_Fax Int,
	@Original_Fax varchar(50),
	@IsNull_Email Int,
	@Original_Email varchar(50),
	@IsNull_bank Int,
	@Original_bank bit,
	@IsNull_BankFId Int,
	@Original_BankFId int,
	@IsNull_BankSId Int,
	@Original_BankSId int,
	@IsNull_BankFBranch Int,
	@Original_BankFBranch varchar(50),
	@IsNull_BankSBranch Int,
	@Original_BankSBranch varchar(50),
	@IsNull_BankFAccountNo Int,
	@Original_BankFAccountNo varchar(50),
	@IsNull_BankSAccountNo Int,
	@Original_BankSAccountNo varchar(50),
	@IsNull_DankEffDate Int,
	@Original_DankEffDate smalldatetime,
	@IsNull_JobLevel Int,
	@Original_JobLevel int,
	@IsNull_ContactLocation Int,
	@Original_ContactLocation varchar(100),
	@IsNull_ContactLocationDate Int,
	@Original_ContactLocationDate smalldatetime,
	@IsNull_Status Int,
	@Original_Status int,
	@IsNull_VacEarned Int,
	@Original_VacEarned numeric(18, 3),
	@IsNull_VacTaken Int,
	@Original_VacTaken numeric(18, 3),
	@IsNull_VacBalance Int,
	@Original_VacBalance numeric(18, 3),
	@IsNull_VacUnpaid Int,
	@Original_VacUnpaid numeric(18, 3),
	@IsNull_SALEADMIN Int,
	@Original_SALEADMIN int,
	@IsNull_FullName Int,
	@Original_FullName varchar(200),
	@IsNull_GetAllow Int,
	@Original_GetAllow money,
	@IsNull_PhoneAllow Int,
	@Original_PhoneAllow money,
	@IsNull_TransAllow Int,
	@Original_TransAllow money,
	@IsNull_InsuranceValue Int,
	@Original_InsuranceValue money,
	@EMP_CODE bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMPLOYEE_DATA] SET [EmpNum] = @EmpNum, [CIVILID] = @CIVILID, [FName] = @FName, [SName] = @SName, [TName] = @TName, [FoName] = @FoName, [FEngName] = @FEngName, [SEngName] = @SEngName, [TEngName] = @TEngName, [FoEngName] = @FoEngName, [TITLE] = @TITLE, [EMP_GENDER] = @EMP_GENDER, [EMP_BIRTH_DATE] = @EMP_BIRTH_DATE, [EMP_BIRTH_PLACE] = @EMP_BIRTH_PLACE, [DEPTCODE] = @DEPTCODE, [EMP_EMAIL] = @EMP_EMAIL, [EMP_HIREDATE] = @EMP_HIREDATE, [Emp_End_HIREDATE] = @Emp_End_HIREDATE, [JOB_CODE] = @JOB_CODE, [JOB_CLS_CODE] = @JOB_CLS_CODE, [FILE_NUM] = @FILE_NUM, [DEGREE_CODE] = @DEGREE_CODE, [REC_TYPE_CODE] = @REC_TYPE_CODE, [MARITAL_STATUS_CODE] = @MARITAL_STATUS_CODE, [NATIONALITY_CODE] = @NATIONALITY_CODE, [GOVER_CODE] = @GOVER_CODE, [EMP_VISA] = @EMP_VISA, [BANK_CODE] = @BANK_CODE, [AccountID] = @AccountID, [NOTES] = @NOTES, [PassportNo] = @PassportNo, [PassType] = @PassType, [PassDate] = @PassDate, [PassEndDate] = @PassEndDate, [Passplace] = @Passplace, [entrydate] = @entrydate, [SALARY] = @SALARY, [bankacc] = @bankacc, [BRANCH_CODE] = @BRANCH_CODE, [SalesAdminFalg] = @SalesAdminFalg, [GroupId] = @GroupId, [ReligionId] = @ReligionId, [EducationId] = @EducationId, [EducationMajored] = @EducationMajored, [EducationMajoredDate] = @EducationMajoredDate, [EducationMajoredYear] = @EducationMajoredYear, [EducationMajoredPlace] = @EducationMajoredPlace, [LocationId] = @LocationId, [RegionId] = @RegionId, [DivisionId] = @DivisionId, [GardeId] = @GardeId, [ResidenceId] = @ResidenceId, [ResidenceNo] = @ResidenceNo, [ResidenceRemark] = @ResidenceRemark, [ResidenceIssueDate] = @ResidenceIssueDate, [ResidenceEndDate] = @ResidenceEndDate, [LicenseNo] = @LicenseNo, [LicenseTypeId] = @LicenseTypeId, [LicenseIssueDate] = @LicenseIssueDate, [LicenseEndDate] = @LicenseEndDate, [EMP_HEALTH_INS_DATE] = @EMP_HEALTH_INS_DATE, [EMP_HEALTH_INS_NUM] = @EMP_HEALTH_INS_NUM, [JoiningDate] = @JoiningDate, [SalaryType] = @SalaryType, [ContractType] = @ContractType, [ContractNo] = @ContractNo, [IndemnityDays] = @IndemnityDays, [VaccationDays] = @VaccationDays, [Ticket] = @Ticket, [WorkHourPerDay] = @WorkHourPerDay, [WorkDaysperMonth] = @WorkDaysperMonth, [ADDRESS] = @ADDRESS, [BlockNo] = @BlockNo, [Street] = @Street, [Floor] = @Floor, [WorkTel] = @WorkTel, [HomeTel] = @HomeTel, [Mobile1] = @Mobile1, [Mobile2] = @Mobile2, [Fax] = @Fax, [Email] = @Email, [bank] = @bank, [BankFId] = @BankFId, [BankSId] = @BankSId, [BankFBranch] = @BankFBranch, [BankSBranch] = @BankSBranch, [BankFAccountNo] = @BankFAccountNo, [BankSAccountNo] = @BankSAccountNo, [DankEffDate] = @DankEffDate, [JobLevel] = @JobLevel, [ContactLocation] = @ContactLocation, [ContactLocationDate] = @ContactLocationDate, [Status] = @Status, [VacEarned] = @VacEarned, [VacTaken] = @VacTaken, [VacBalance] = @VacBalance, [VacUnpaid] = @VacUnpaid, [SALEADMIN] = @SALEADMIN, [FullName] = @FullName, [GetAllow] = @GetAllow, [PhoneAllow] = @PhoneAllow, [TransAllow] = @TransAllow, [InsuranceValue] = @InsuranceValue WHERE (([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_EmpNum = 1 AND [EmpNum] IS NULL) OR ([EmpNum] = @Original_EmpNum)) AND ((@IsNull_CIVILID = 1 AND [CIVILID] IS NULL) OR ([CIVILID] = @Original_CIVILID)) AND ((@IsNull_FName = 1 AND [FName] IS NULL) OR ([FName] = @Original_FName)) AND ((@IsNull_SName = 1 AND [SName] IS NULL) OR ([SName] = @Original_SName)) AND ((@IsNull_TName = 1 AND [TName] IS NULL) OR ([TName] = @Original_TName)) AND ((@IsNull_FoName = 1 AND [FoName] IS NULL) OR ([FoName] = @Original_FoName)) AND ((@IsNull_FEngName = 1 AND [FEngName] IS NULL) OR ([FEngName] = @Original_FEngName)) AND ((@IsNull_SEngName = 1 AND [SEngName] IS NULL) OR ([SEngName] = @Original_SEngName)) AND ((@IsNull_TEngName = 1 AND [TEngName] IS NULL) OR ([TEngName] = @Original_TEngName)) AND ((@IsNull_FoEngName = 1 AND [FoEngName] IS NULL) OR ([FoEngName] = @Original_FoEngName)) AND ((@IsNull_TITLE = 1 AND [TITLE] IS NULL) OR ([TITLE] = @Original_TITLE)) AND ((@IsNull_EMP_GENDER = 1 AND [EMP_GENDER] IS NULL) OR ([EMP_GENDER] = @Original_EMP_GENDER)) AND ((@IsNull_EMP_BIRTH_DATE = 1 AND [EMP_BIRTH_DATE] IS NULL) OR ([EMP_BIRTH_DATE] = @Original_EMP_BIRTH_DATE)) AND ((@IsNull_EMP_BIRTH_PLACE = 1 AND [EMP_BIRTH_PLACE] IS NULL) OR ([EMP_BIRTH_PLACE] = @Original_EMP_BIRTH_PLACE)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_EMP_EMAIL = 1 AND [EMP_EMAIL] IS NULL) OR ([EMP_EMAIL] = @Original_EMP_EMAIL)) AND ((@IsNull_EMP_HIREDATE = 1 AND [EMP_HIREDATE] IS NULL) OR ([EMP_HIREDATE] = @Original_EMP_HIREDATE)) AND ((@IsNull_Emp_End_HIREDATE = 1 AND [Emp_End_HIREDATE] IS NULL) OR ([Emp_End_HIREDATE] = @Original_Emp_End_HIREDATE)) AND ((@IsNull_JOB_CODE = 1 AND [JOB_CODE] IS NULL) OR ([JOB_CODE] = @Original_JOB_CODE)) AND ((@IsNull_JOB_CLS_CODE = 1 AND [JOB_CLS_CODE] IS NULL) OR ([JOB_CLS_CODE] = @Original_JOB_CLS_CODE)) AND ((@IsNull_FILE_NUM = 1 AND [FILE_NUM] IS NULL) OR ([FILE_NUM] = @Original_FILE_NUM)) AND ((@IsNull_DEGREE_CODE = 1 AND [DEGREE_CODE] IS NULL) OR ([DEGREE_CODE] = @Original_DEGREE_CODE)) AND ((@IsNull_REC_TYPE_CODE = 1 AND [REC_TYPE_CODE] IS NULL) OR ([REC_TYPE_CODE] = @Original_REC_TYPE_CODE)) AND ((@IsNull_MARITAL_STATUS_CODE = 1 AND [MARITAL_STATUS_CODE] IS NULL) OR ([MARITAL_STATUS_CODE] = @Original_MARITAL_STATUS_CODE)) AND ((@IsNull_NATIONALITY_CODE = 1 AND [NATIONALITY_CODE] IS NULL) OR ([NATIONALITY_CODE] = @Original_NATIONALITY_CODE)) AND ((@IsNull_GOVER_CODE = 1 AND [GOVER_CODE] IS NULL) OR ([GOVER_CODE] = @Original_GOVER_CODE)) AND ((@IsNull_EMP_VISA = 1 AND [EMP_VISA] IS NULL) OR ([EMP_VISA] = @Original_EMP_VISA)) AND ((@IsNull_BANK_CODE = 1 AND [BANK_CODE] IS NULL) OR ([BANK_CODE] = @Original_BANK_CODE)) AND ((@IsNull_AccountID = 1 AND [AccountID] IS NULL) OR ([AccountID] = @Original_AccountID)) AND ((@IsNull_NOTES = 1 AND [NOTES] IS NULL) OR ([NOTES] = @Original_NOTES)) AND ((@IsNull_PassportNo = 1 AND [PassportNo] IS NULL) OR ([PassportNo] = @Original_PassportNo)) AND ((@IsNull_PassType = 1 AND [PassType] IS NULL) OR ([PassType] = @Original_PassType)) AND ((@IsNull_PassDate = 1 AND [PassDate] IS NULL) OR ([PassDate] = @Original_PassDate)) AND ((@IsNull_PassEndDate = 1 AND [PassEndDate] IS NULL) OR ([PassEndDate] = @Original_PassEndDate)) AND ((@IsNull_Passplace = 1 AND [Passplace] IS NULL) OR ([Passplace] = @Original_Passplace)) AND ((@IsNull_entrydate = 1 AND [entrydate] IS NULL) OR ([entrydate] = @Original_entrydate)) AND ((@IsNull_SALARY = 1 AND [SALARY] IS NULL) OR ([SALARY] = @Original_SALARY)) AND ((@IsNull_bankacc = 1 AND [bankacc] IS NULL) OR ([bankacc] = @Original_bankacc)) AND ((@IsNull_BRANCH_CODE = 1 AND [BRANCH_CODE] IS NULL) OR ([BRANCH_CODE] = @Original_BRANCH_CODE)) AND ((@IsNull_SalesAdminFalg = 1 AND [SalesAdminFalg] IS NULL) OR ([SalesAdminFalg] = @Original_SalesAdminFalg)) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)) AND ((@IsNull_ReligionId = 1 AND [ReligionId] IS NULL) OR ([ReligionId] = @Original_ReligionId)) AND ((@IsNull_EducationId = 1 AND [EducationId] IS NULL) OR ([EducationId] = @Original_EducationId)) AND ((@IsNull_EducationMajored = 1 AND [EducationMajored] IS NULL) OR ([EducationMajored] = @Original_EducationMajored)) AND ((@IsNull_EducationMajoredDate = 1 AND [EducationMajoredDate] IS NULL) OR ([EducationMajoredDate] = @Original_EducationMajoredDate)) AND ((@IsNull_EducationMajoredYear = 1 AND [EducationMajoredYear] IS NULL) OR ([EducationMajoredYear] = @Original_EducationMajoredYear)) AND ((@IsNull_EducationMajoredPlace = 1 AND [EducationMajoredPlace] IS NULL) OR ([EducationMajoredPlace] = @Original_EducationMajoredPlace)) AND ((@IsNull_LocationId = 1 AND [LocationId] IS NULL) OR ([LocationId] = @Original_LocationId)) AND ((@IsNull_RegionId = 1 AND [RegionId] IS NULL) OR ([RegionId] = @Original_RegionId)) AND ((@IsNull_DivisionId = 1 AND [DivisionId] IS NULL) OR ([DivisionId] = @Original_DivisionId)) AND ((@IsNull_GardeId = 1 AND [GardeId] IS NULL) OR ([GardeId] = @Original_GardeId)) AND ((@IsNull_ResidenceId = 1 AND [ResidenceId] IS NULL) OR ([ResidenceId] = @Original_ResidenceId)) AND ((@IsNull_ResidenceNo = 1 AND [ResidenceNo] IS NULL) OR ([ResidenceNo] = @Original_ResidenceNo)) AND ((@IsNull_ResidenceRemark = 1 AND [ResidenceRemark] IS NULL) OR ([ResidenceRemark] = @Original_ResidenceRemark)) AND ((@IsNull_ResidenceIssueDate = 1 AND [ResidenceIssueDate] IS NULL) OR ([ResidenceIssueDate] = @Original_ResidenceIssueDate)) AND ((@IsNull_ResidenceEndDate = 1 AND [ResidenceEndDate] IS NULL) OR ([ResidenceEndDate] = @Original_ResidenceEndDate)) AND ((@IsNull_LicenseNo = 1 AND [LicenseNo] IS NULL) OR ([LicenseNo] = @Original_LicenseNo)) AND ((@IsNull_LicenseTypeId = 1 AND [LicenseTypeId] IS NULL) OR ([LicenseTypeId] = @Original_LicenseTypeId)) AND ((@IsNull_LicenseIssueDate = 1 AND [LicenseIssueDate] IS NULL) OR ([LicenseIssueDate] = @Original_LicenseIssueDate)) AND ((@IsNull_LicenseEndDate = 1 AND [LicenseEndDate] IS NULL) OR ([LicenseEndDate] = @Original_LicenseEndDate)) AND ((@IsNull_EMP_HEALTH_INS_DATE = 1 AND [EMP_HEALTH_INS_DATE] IS NULL) OR ([EMP_HEALTH_INS_DATE] = @Original_EMP_HEALTH_INS_DATE)) AND ((@IsNull_EMP_HEALTH_INS_NUM = 1 AND [EMP_HEALTH_INS_NUM] IS NULL) OR ([EMP_HEALTH_INS_NUM] = @Original_EMP_HEALTH_INS_NUM)) AND ((@IsNull_JoiningDate = 1 AND [JoiningDate] IS NULL) OR ([JoiningDate] = @Original_JoiningDate)) AND ((@IsNull_SalaryType = 1 AND [SalaryType] IS NULL) OR ([SalaryType] = @Original_SalaryType)) AND ((@IsNull_ContractType = 1 AND [ContractType] IS NULL) OR ([ContractType] = @Original_ContractType)) AND ((@IsNull_ContractNo = 1 AND [ContractNo] IS NULL) OR ([ContractNo] = @Original_ContractNo)) AND ((@IsNull_IndemnityDays = 1 AND [IndemnityDays] IS NULL) OR ([IndemnityDays] = @Original_IndemnityDays)) AND ((@IsNull_VaccationDays = 1 AND [VaccationDays] IS NULL) OR ([VaccationDays] = @Original_VaccationDays)) AND ((@IsNull_Ticket = 1 AND [Ticket] IS NULL) OR ([Ticket] = @Original_Ticket)) AND ((@IsNull_WorkHourPerDay = 1 AND [WorkHourPerDay] IS NULL) OR ([WorkHourPerDay] = @Original_WorkHourPerDay)) AND ((@IsNull_WorkDaysperMonth = 1 AND [WorkDaysperMonth] IS NULL) OR ([WorkDaysperMonth] = @Original_WorkDaysperMonth)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_BlockNo = 1 AND [BlockNo] IS NULL) OR ([BlockNo] = @Original_BlockNo)) AND ((@IsNull_Street = 1 AND [Street] IS NULL) OR ([Street] = @Original_Street)) AND ((@IsNull_Floor = 1 AND [Floor] IS NULL) OR ([Floor] = @Original_Floor)) AND ((@IsNull_WorkTel = 1 AND [WorkTel] IS NULL) OR ([WorkTel] = @Original_WorkTel)) AND ((@IsNull_HomeTel = 1 AND [HomeTel] IS NULL) OR ([HomeTel] = @Original_HomeTel)) AND ((@IsNull_Mobile1 = 1 AND [Mobile1] IS NULL) OR ([Mobile1] = @Original_Mobile1)) AND ((@IsNull_Mobile2 = 1 AND [Mobile2] IS NULL) OR ([Mobile2] = @Original_Mobile2)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_bank = 1 AND [bank] IS NULL) OR ([bank] = @Original_bank)) AND ((@IsNull_BankFId = 1 AND [BankFId] IS NULL) OR ([BankFId] = @Original_BankFId)) AND ((@IsNull_BankSId = 1 AND [BankSId] IS NULL) OR ([BankSId] = @Original_BankSId)) AND ((@IsNull_BankFBranch = 1 AND [BankFBranch] IS NULL) OR ([BankFBranch] = @Original_BankFBranch)) AND ((@IsNull_BankSBranch = 1 AND [BankSBranch] IS NULL) OR ([BankSBranch] = @Original_BankSBranch)) AND ((@IsNull_BankFAccountNo = 1 AND [BankFAccountNo] IS NULL) OR ([BankFAccountNo] = @Original_BankFAccountNo)) AND ((@IsNull_BankSAccountNo = 1 AND [BankSAccountNo] IS NULL) OR ([BankSAccountNo] = @Original_BankSAccountNo)) AND ((@IsNull_DankEffDate = 1 AND [DankEffDate] IS NULL) OR ([DankEffDate] = @Original_DankEffDate)) AND ((@IsNull_JobLevel = 1 AND [JobLevel] IS NULL) OR ([JobLevel] = @Original_JobLevel)) AND ((@IsNull_ContactLocation = 1 AND [ContactLocation] IS NULL) OR ([ContactLocation] = @Original_ContactLocation)) AND ((@IsNull_ContactLocationDate = 1 AND [ContactLocationDate] IS NULL) OR ([ContactLocationDate] = @Original_ContactLocationDate)) AND ((@IsNull_Status = 1 AND [Status] IS NULL) OR ([Status] = @Original_Status)) AND ((@IsNull_VacEarned = 1 AND [VacEarned] IS NULL) OR ([VacEarned] = @Original_VacEarned)) AND ((@IsNull_VacTaken = 1 AND [VacTaken] IS NULL) OR ([VacTaken] = @Original_VacTaken)) AND ((@IsNull_VacBalance = 1 AND [VacBalance] IS NULL) OR ([VacBalance] = @Original_VacBalance)) AND ((@IsNull_VacUnpaid = 1 AND [VacUnpaid] IS NULL) OR ([VacUnpaid] = @Original_VacUnpaid)) AND ((@IsNull_SALEADMIN = 1 AND [SALEADMIN] IS NULL) OR ([SALEADMIN] = @Original_SALEADMIN)) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_GetAllow = 1 AND [GetAllow] IS NULL) OR ([GetAllow] = @Original_GetAllow)) AND ((@IsNull_PhoneAllow = 1 AND [PhoneAllow] IS NULL) OR ([PhoneAllow] = @Original_PhoneAllow)) AND ((@IsNull_TransAllow = 1 AND [TransAllow] IS NULL) OR ([TransAllow] = @Original_TransAllow)) AND ((@IsNull_InsuranceValue = 1 AND [InsuranceValue] IS NULL) OR ([InsuranceValue] = @Original_InsuranceValue)));
	
SELECT EMP_CODE, EmpNum, CIVILID, FName, SName, TName, FoName, FEngName, SEngName, TEngName, FoEngName, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_BIRTH_PLACE, DEPTCODE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, JOB_CODE, JOB_CLS_CODE, FILE_NUM, DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, BANK_CODE, AccountID, NOTES, PassportNo, PassType, PassDate, PassEndDate, Passplace, entrydate, SALARY, bankacc, BRANCH_CODE, SalesAdminFalg, GroupId, ReligionId, EducationId, EducationMajored, EducationMajoredDate, EducationMajoredYear, EducationMajoredPlace, LocationId, RegionId, DivisionId, GardeId, ResidenceId, ResidenceNo, ResidenceRemark, ResidenceIssueDate, ResidenceEndDate, LicenseNo, LicenseTypeId, LicenseIssueDate, LicenseEndDate, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JoiningDate, SalaryType, ContractType, ContractNo, IndemnityDays, VaccationDays, Ticket, WorkHourPerDay, WorkDaysperMonth, ADDRESS, BlockNo, Street, Floor, WorkTel, HomeTel, Mobile1, Mobile2, Fax, Email, bank, BankFId, BankSId, BankFBranch, BankSBranch, BankFAccountNo, BankSAccountNo, DankEffDate, JobLevel, ContactLocation, ContactLocationDate, Status, VacEarned, VacTaken, VacBalance, VacUnpaid, SALEADMIN, FullName, GetAllow, PhoneAllow, TransAllow, InsuranceValue FROM PER_EMPLOYEE_DATA WHERE (EMP_CODE = @EMP_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Emp_GroupsDelete
(
	@Original_GroupId bigint,
	@Original_GroupName varchar(200),
	@IsNull_NutalAttendance int,
	@Original_NutalAttendance int,
	@IsNull_SalaryCul int,
	@Original_SalaryCul int,
	@IsNull_DefDate int,
	@Original_DefDate int,
	@IsNull_WorkHour float,
	@Original_WorkHour float,
	@IsNull_VactionNum float,
	@Original_VactionNum float,
	@IsNull_AbsenceHourPercentage float,
	@Original_AbsenceHourPercentage float,
	@IsNull_AdditionPercentage float,
	@Original_AdditionPercentage float,
	@IsNull_HourInVaction float,
	@Original_HourInVaction float,
	@IsNull_AbsenceDayPercentage float,
	@Original_AbsenceDayPercentage float,
	@IsNull_ApplyVactionDays bit,
	@Original_ApplyVactionDays bit,
	@IsNull_SalaryAccountId bigint,
	@Original_SalaryAccountId bigint,
	@IsNull_TaxAccountId bigint,
	@Original_TaxAccountId bigint,
	@IsNull_LoanAccountId bigint,
	@Original_LoanAccountId bigint,
	@IsNull_BoxAccountId bigint,
	@Original_BoxAccountId bigint,
	@IsNull_SickVactionNum float,
	@Original_SickVactionNum float,
	@IsNull_Shift1From datetime,
	@Original_Shift1From datetime,
	@IsNull_Shift1To datetime,
	@Original_Shift1To datetime,
	@IsNull_Shift2From datetime,
	@Original_Shift2From datetime,
	@IsNull_Shift2To datetime,
	@Original_Shift2To datetime,
	@IsNull_TwoShift bit,
	@Original_TwoShift bit,
	@IsNull_OffDays varchar(100),
	@Original_OffDays varchar(100)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Emp_Groups] WHERE (([GroupId] = @Original_GroupId) AND ([GroupName] = @Original_GroupName) AND ((@IsNull_NutalAttendance = 1 AND [NutalAttendance] IS NULL) OR ([NutalAttendance] = @Original_NutalAttendance)) AND ((@IsNull_SalaryCul = 1 AND [SalaryCul] IS NULL) OR ([SalaryCul] = @Original_SalaryCul)) AND ((@IsNull_DefDate = 1 AND [DefDate] IS NULL) OR ([DefDate] = @Original_DefDate)) AND ((@IsNull_WorkHour = 1 AND [WorkHour] IS NULL) OR ([WorkHour] = @Original_WorkHour)) AND ((@IsNull_VactionNum = 1 AND [VactionNum] IS NULL) OR ([VactionNum] = @Original_VactionNum)) AND ((@IsNull_AbsenceHourPercentage = 1 AND [AbsenceHourPercentage] IS NULL) OR ([AbsenceHourPercentage] = @Original_AbsenceHourPercentage)) AND ((@IsNull_AdditionPercentage = 1 AND [AdditionPercentage] IS NULL) OR ([AdditionPercentage] = @Original_AdditionPercentage)) AND ((@IsNull_HourInVaction = 1 AND [HourInVaction] IS NULL) OR ([HourInVaction] = @Original_HourInVaction)) AND ((@IsNull_AbsenceDayPercentage = 1 AND [AbsenceDayPercentage] IS NULL) OR ([AbsenceDayPercentage] = @Original_AbsenceDayPercentage)) AND ((@IsNull_ApplyVactionDays = 1 AND [ApplyVactionDays] IS NULL) OR ([ApplyVactionDays] = @Original_ApplyVactionDays)) AND ((@IsNull_SalaryAccountId = 1 AND [SalaryAccountId] IS NULL) OR ([SalaryAccountId] = @Original_SalaryAccountId)) AND ((@IsNull_TaxAccountId = 1 AND [TaxAccountId] IS NULL) OR ([TaxAccountId] = @Original_TaxAccountId)) AND ((@IsNull_LoanAccountId = 1 AND [LoanAccountId] IS NULL) OR ([LoanAccountId] = @Original_LoanAccountId)) AND ((@IsNull_BoxAccountId = 1 AND [BoxAccountId] IS NULL) OR ([BoxAccountId] = @Original_BoxAccountId)) AND ((@IsNull_SickVactionNum = 1 AND [SickVactionNum] IS NULL) OR ([SickVactionNum] = @Original_SickVactionNum)) AND ((@IsNull_Shift1From = 1 AND [Shift1From] IS NULL) OR ([Shift1From] = @Original_Shift1From)) AND ((@IsNull_Shift1To = 1 AND [Shift1To] IS NULL) OR ([Shift1To] = @Original_Shift1To)) AND ((@IsNull_Shift2From = 1 AND [Shift2From] IS NULL) OR ([Shift2From] = @Original_Shift2From)) AND ((@IsNull_Shift2To = 1 AND [Shift2To] IS NULL) OR ([Shift2To] = @Original_Shift2To)) AND ((@IsNull_TwoShift = 1 AND [TwoShift] IS NULL) OR ([TwoShift] = @Original_TwoShift)) AND ((@IsNull_OffDays = 1 AND [OffDays] IS NULL) OR ([OffDays] = @Original_OffDays)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Emp_GroupsInsert
(
	@GroupName varchar(200),
	@NutalAttendance int,
	@SalaryCul int,
	@DefDate int,
	@WorkHour float,
	@VactionNum float,
	@AbsenceHourPercentage float,
	@AdditionPercentage float,
	@HourInVaction float,
	@AbsenceDayPercentage float,
	@ApplyVactionDays bit,
	@SalaryAccountId bigint,
	@TaxAccountId bigint,
	@LoanAccountId bigint,
	@BoxAccountId bigint,
	@SickVactionNum float,
	@Shift1From datetime,
	@Shift1To datetime,
	@Shift2From datetime,
	@Shift2To datetime,
	@TwoShift bit,
	@OffDays varchar(100)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Emp_Groups] ([GroupName], [NutalAttendance], [SalaryCul], [DefDate], [WorkHour], [VactionNum], [AbsenceHourPercentage], [AdditionPercentage], [HourInVaction], [AbsenceDayPercentage], [ApplyVactionDays], [SalaryAccountId], [TaxAccountId], [LoanAccountId], [BoxAccountId], [SickVactionNum], [Shift1From], [Shift1To], [Shift2From], [Shift2To], [TwoShift], [OffDays]) VALUES (@GroupName, @NutalAttendance, @SalaryCul, @DefDate, @WorkHour, @VactionNum, @AbsenceHourPercentage, @AdditionPercentage, @HourInVaction, @AbsenceDayPercentage, @ApplyVactionDays, @SalaryAccountId, @TaxAccountId, @LoanAccountId, @BoxAccountId, @SickVactionNum, @Shift1From, @Shift1To, @Shift2From, @Shift2To, @TwoShift, @OffDays);
	
SELECT GroupId, GroupName, NutalAttendance, SalaryCul, DefDate, WorkHour, VactionNum, AbsenceHourPercentage, AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId, SickVactionNum, Shift1From, Shift1To, Shift2From, Shift2To, TwoShift, OffDays FROM Emp_Groups WHERE (GroupId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Emp_GroupsSelect
AS
	SET NOCOUNT ON;
SELECT     GroupId, GroupName, NutalAttendance, SalaryCul, DefDate, WorkHour, VactionNum, AbsenceHourPercentage, AdditionPercentage, HourInVaction, 
                      AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId, SickVactionNum, Shift1From, Shift1To, 
                      Shift2From, Shift2To, TwoShift, OffDays
FROM         Emp_Groups







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Emp_GroupsUpdate
(
	@GroupName varchar(200),
	@NutalAttendance int,
	@SalaryCul int,
	@DefDate int,
	@WorkHour float,
	@VactionNum float,
	@AbsenceHourPercentage float,
	@AdditionPercentage float,
	@HourInVaction float,
	@AbsenceDayPercentage float,
	@ApplyVactionDays bit,
	@SalaryAccountId bigint,
	@TaxAccountId bigint,
	@LoanAccountId bigint,
	@BoxAccountId bigint,
	@SickVactionNum float,
	@Shift1From datetime,
	@Shift1To datetime,
	@Shift2From datetime,
	@Shift2To datetime,
	@TwoShift bit,
	@OffDays varchar(100),
	@Original_GroupId bigint,
	@Original_GroupName varchar(200),
	@IsNull_NutalAttendance int,
	@Original_NutalAttendance int,
	@IsNull_SalaryCul int,
	@Original_SalaryCul int,
	@IsNull_DefDate int,
	@Original_DefDate int,
	@IsNull_WorkHour float,
	@Original_WorkHour float,
	@IsNull_VactionNum float,
	@Original_VactionNum float,
	@IsNull_AbsenceHourPercentage float,
	@Original_AbsenceHourPercentage float,
	@IsNull_AdditionPercentage float,
	@Original_AdditionPercentage float,
	@IsNull_HourInVaction float,
	@Original_HourInVaction float,
	@IsNull_AbsenceDayPercentage float,
	@Original_AbsenceDayPercentage float,
	@IsNull_ApplyVactionDays bit,
	@Original_ApplyVactionDays bit,
	@IsNull_SalaryAccountId bigint,
	@Original_SalaryAccountId bigint,
	@IsNull_TaxAccountId bigint,
	@Original_TaxAccountId bigint,
	@IsNull_LoanAccountId bigint,
	@Original_LoanAccountId bigint,
	@IsNull_BoxAccountId bigint,
	@Original_BoxAccountId bigint,
	@IsNull_SickVactionNum float,
	@Original_SickVactionNum float,
	@IsNull_Shift1From datetime,
	@Original_Shift1From datetime,
	@IsNull_Shift1To datetime,
	@Original_Shift1To datetime,
	@IsNull_Shift2From datetime,
	@Original_Shift2From datetime,
	@IsNull_Shift2To datetime,
	@Original_Shift2To datetime,
	@IsNull_TwoShift bit,
	@Original_TwoShift bit,
	@IsNull_OffDays varchar(100),
	@Original_OffDays varchar(100),
	@GroupId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Emp_Groups] SET [GroupName] = @GroupName, [NutalAttendance] = @NutalAttendance, [SalaryCul] = @SalaryCul, [DefDate] = @DefDate, [WorkHour] = @WorkHour, [VactionNum] = @VactionNum, [AbsenceHourPercentage] = @AbsenceHourPercentage, [AdditionPercentage] = @AdditionPercentage, [HourInVaction] = @HourInVaction, [AbsenceDayPercentage] = @AbsenceDayPercentage, [ApplyVactionDays] = @ApplyVactionDays, [SalaryAccountId] = @SalaryAccountId, [TaxAccountId] = @TaxAccountId, [LoanAccountId] = @LoanAccountId, [BoxAccountId] = @BoxAccountId, [SickVactionNum] = @SickVactionNum, [Shift1From] = @Shift1From, [Shift1To] = @Shift1To, [Shift2From] = @Shift2From, [Shift2To] = @Shift2To, [TwoShift] = @TwoShift, [OffDays] = @OffDays WHERE (([GroupId] = @Original_GroupId) AND ([GroupName] = @Original_GroupName) AND ((@IsNull_NutalAttendance = 1 AND [NutalAttendance] IS NULL) OR ([NutalAttendance] = @Original_NutalAttendance)) AND ((@IsNull_SalaryCul = 1 AND [SalaryCul] IS NULL) OR ([SalaryCul] = @Original_SalaryCul)) AND ((@IsNull_DefDate = 1 AND [DefDate] IS NULL) OR ([DefDate] = @Original_DefDate)) AND ((@IsNull_WorkHour = 1 AND [WorkHour] IS NULL) OR ([WorkHour] = @Original_WorkHour)) AND ((@IsNull_VactionNum = 1 AND [VactionNum] IS NULL) OR ([VactionNum] = @Original_VactionNum)) AND ((@IsNull_AbsenceHourPercentage = 1 AND [AbsenceHourPercentage] IS NULL) OR ([AbsenceHourPercentage] = @Original_AbsenceHourPercentage)) AND ((@IsNull_AdditionPercentage = 1 AND [AdditionPercentage] IS NULL) OR ([AdditionPercentage] = @Original_AdditionPercentage)) AND ((@IsNull_HourInVaction = 1 AND [HourInVaction] IS NULL) OR ([HourInVaction] = @Original_HourInVaction)) AND ((@IsNull_AbsenceDayPercentage = 1 AND [AbsenceDayPercentage] IS NULL) OR ([AbsenceDayPercentage] = @Original_AbsenceDayPercentage)) AND ((@IsNull_ApplyVactionDays = 1 AND [ApplyVactionDays] IS NULL) OR ([ApplyVactionDays] = @Original_ApplyVactionDays)) AND ((@IsNull_SalaryAccountId = 1 AND [SalaryAccountId] IS NULL) OR ([SalaryAccountId] = @Original_SalaryAccountId)) AND ((@IsNull_TaxAccountId = 1 AND [TaxAccountId] IS NULL) OR ([TaxAccountId] = @Original_TaxAccountId)) AND ((@IsNull_LoanAccountId = 1 AND [LoanAccountId] IS NULL) OR ([LoanAccountId] = @Original_LoanAccountId)) AND ((@IsNull_BoxAccountId = 1 AND [BoxAccountId] IS NULL) OR ([BoxAccountId] = @Original_BoxAccountId)) AND ((@IsNull_SickVactionNum = 1 AND [SickVactionNum] IS NULL) OR ([SickVactionNum] = @Original_SickVactionNum)) AND ((@IsNull_Shift1From = 1 AND [Shift1From] IS NULL) OR ([Shift1From] = @Original_Shift1From)) AND ((@IsNull_Shift1To = 1 AND [Shift1To] IS NULL) OR ([Shift1To] = @Original_Shift1To)) AND ((@IsNull_Shift2From = 1 AND [Shift2From] IS NULL) OR ([Shift2From] = @Original_Shift2From)) AND ((@IsNull_Shift2To = 1 AND [Shift2To] IS NULL) OR ([Shift2To] = @Original_Shift2To)) AND ((@IsNull_TwoShift = 1 AND [TwoShift] IS NULL) OR ([TwoShift] = @Original_TwoShift)) AND ((@IsNull_OffDays = 1 AND [OffDays] IS NULL) OR ([OffDays] = @Original_OffDays)));
	
SELECT GroupId, GroupName, NutalAttendance, SalaryCul, DefDate, WorkHour, VactionNum, AbsenceHourPercentage, AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId, SickVactionNum, Shift1From, Shift1To, Shift2From, Shift2To, TwoShift, OffDays FROM Emp_Groups WHERE (GroupId = @GroupId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FIGURESInsert
(
	@Figure smallint,
	@FigureInWords nvarchar(15),
	@EngFigureInWords nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [FIGURES] ([Figure], [FigureInWords], [EngFigureInWords]) VALUES (@Figure, @FigureInWords, @EngFigureInWords)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FIGURESSelect
AS
	SET NOCOUNT ON;
SELECT     Figure, FigureInWords, EngFigureInWords
FROM         FIGURES









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FunctionDelete
(
	@Original_ID int,
	@Original_TEXT varchar(50),
	@IsNull_NAME varchar(50),
	@Original_NAME varchar(50),
	@IsNull_Type int,
	@Original_Type int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [FUNCTIONS] WHERE (([ID] = @Original_ID) AND ([TEXT] = @Original_TEXT) AND ((@IsNull_NAME = 1 AND [NAME] IS NULL) OR ([NAME] = @Original_NAME)) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FunctionInsert
(
	@TEXT varchar(50),
	@NAME varchar(50),
	@Type int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [FUNCTIONS] ([TEXT], [NAME], [Type]) VALUES (@TEXT, @NAME, @Type);
	
SELECT ID, TEXT, NAME, Type FROM FUNCTIONS WHERE (ID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FunctionSelect
AS
	SET NOCOUNT ON;
SELECT     ID, TEXT, NAME, Type
FROM         FUNCTIONS









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_FunctionUpdate
(
	@TEXT varchar(50),
	@NAME varchar(50),
	@Type int,
	@Original_ID int,
	@Original_TEXT varchar(50),
	@IsNull_NAME varchar(50),
	@Original_NAME varchar(50),
	@IsNull_Type int,
	@Original_Type int,
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [FUNCTIONS] SET [TEXT] = @TEXT, [NAME] = @NAME, [Type] = @Type WHERE (([ID] = @Original_ID) AND ([TEXT] = @Original_TEXT) AND ((@IsNull_NAME = 1 AND [NAME] IS NULL) OR ([NAME] = @Original_NAME)) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)));
	
SELECT ID, TEXT, NAME, Type FROM FUNCTIONS WHERE (ID = @ID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GOVERNORATEDelete
(
	@Original_GOVER_CODE numeric(5, 0),
	@Original_GOVER_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_GOVERNORATE] WHERE (([GOVER_CODE] = @Original_GOVER_CODE) AND ([GOVER_DESC] = @Original_GOVER_DESC))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GOVERNORATEInsert
(
	@GOVER_CODE numeric(5, 0),
	@GOVER_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_GOVERNORATE] ([GOVER_CODE], [GOVER_DESC]) VALUES (@GOVER_CODE, @GOVER_DESC);
	
SELECT GOVER_CODE, GOVER_DESC FROM CDE_GOVERNORATE WHERE (GOVER_CODE = @GOVER_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GOVERNORATESelect
AS
	SET NOCOUNT ON;
SELECT     GOVER_CODE, GOVER_DESC
FROM         CDE_GOVERNORATE









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GOVERNORATEUpdate
(
	@GOVER_CODE numeric(5, 0),
	@GOVER_DESC varchar(200),
	@Original_GOVER_CODE numeric(5, 0),
	@Original_GOVER_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_GOVERNORATE] SET [GOVER_CODE] = @GOVER_CODE, [GOVER_DESC] = @GOVER_DESC WHERE (([GOVER_CODE] = @Original_GOVER_CODE) AND ([GOVER_DESC] = @Original_GOVER_DESC));
	
SELECT GOVER_CODE, GOVER_DESC FROM CDE_GOVERNORATE WHERE (GOVER_CODE = @GOVER_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetBranchIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('BRANCHES') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_GetCustSupIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('SUPPLIERS_CUSTOMERS') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetCustTotalPayment
(
	@InvId bigint,
	@ActionType int
)
AS
	SET NOCOUNT ON;
SELECT     isnull(SUM(qidsDetails.FromValue),0) AS TotalPayment
FROM         qids INNER JOIN
                      qidsDetails ON qids.qidid = qidsDetails.qidid
WHERE     (qids.InvId = @InvId) AND (qidsDetails.ActionType = @ActionType)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_GetEmpIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('PER_EMPLOYEE_DATA') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_GetInstallmentIden
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('Installment') AS IdenValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_GetInvOrdersIden
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('InvOrders') AS IdenValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetInvoiceIden
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('invoices') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_GetMoveStockIden
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('StockMovement') AS IdenValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_GetOrdersIden
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('Orders') AS IdenValue







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetQidDetIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('QidsDetails') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetQidsIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('Qids') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_GetStoresIdent
AS
	SET NOCOUNT ON;
SELECT     IDENT_CURRENT('STORES') AS IdenValue









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE dbo.usp_HomeCustomerDelete
(
	@Original_CustId bigint,
	@Original_CustName varchar(300),
	@IsNull_Address varchar(400),
	@Original_Address varchar(400),
	@IsNull_CustTel varchar(50),
	@Original_CustTel varchar(50),
	@IsNull_block varchar(50),
	@Original_block varchar(50),
	@IsNull_street varchar(50),
	@Original_street varchar(50),
	@IsNull_Gada varchar(50),
	@Original_Gada varchar(50),
	@IsNull_Buliding varchar(50),
	@Original_Buliding varchar(50),
	@IsNull_Flat varchar(50),
	@Original_Flat varchar(50),
	@IsNull_House varchar(50),
	@Original_House varchar(50),
	@IsNull_Floor varchar(50),
	@Original_Floor varchar(50),
	@IsNull_Notes varchar(255),
	@Original_Notes varchar(255)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [HomeCustomer] WHERE (([CustId] = @Original_CustId) AND ([CustName] = @Original_CustName) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_CustTel = 1 AND [CustTel] IS NULL) OR ([CustTel] = @Original_CustTel)) AND ((@IsNull_block = 1 AND [block] IS NULL) OR ([block] = @Original_block)) AND ((@IsNull_street = 1 AND [street] IS NULL) OR ([street] = @Original_street)) AND ((@IsNull_Gada = 1 AND [Gada] IS NULL) OR ([Gada] = @Original_Gada)) AND ((@IsNull_Buliding = 1 AND [Buliding] IS NULL) OR ([Buliding] = @Original_Buliding)) AND ((@IsNull_Flat = 1 AND [Flat] IS NULL) OR ([Flat] = @Original_Flat)) AND ((@IsNull_House = 1 AND [House] IS NULL) OR ([House] = @Original_House)) AND ((@IsNull_Floor = 1 AND [Floor] IS NULL) OR ([Floor] = @Original_Floor)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)))


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE dbo.usp_HomeCustomerInsert
(
	@CustName varchar(300),
	@Address varchar(400),
	@CustTel varchar(50),
	@block varchar(50),
	@street varchar(50),
	@Gada varchar(50),
	@Buliding varchar(50),
	@Flat varchar(50),
	@House varchar(50),
	@Floor varchar(50),
	@Notes varchar(255)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [HomeCustomer] ([CustName], [Address], [CustTel], [block], [street], [Gada], [Buliding], [Flat], [House], [Floor], [Notes]) VALUES (@CustName, @Address, @CustTel, @block, @street, @Gada, @Buliding, @Flat, @House, @Floor, @Notes);
	
SELECT CustId, CustName, Address, CustTel, block, street, Gada, Buliding, Flat, House, Floor, Notes FROM HomeCustomer WHERE (CustId = SCOPE_IDENTITY())


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE dbo.usp_HomeCustomerSelect
AS
	SET NOCOUNT ON;
SELECT        CustId, CustName, Address, CustTel, block, street, Gada, Buliding, Flat, House, Floor, Notes
FROM            HomeCustomer


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_HomeCustomerSelectByCustId
(
	@CustId bigint
)
AS
	SET NOCOUNT ON;
SELECT        CustId, CustName, Address, CustTel, block, street, Gada, Buliding, Flat, House, Floor, Notes
FROM            HomeCustomer
WHERE        (CustId = @CustId)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE dbo.usp_HomeCustomerUpdate
(
	@CustName varchar(300),
	@Address varchar(400),
	@CustTel varchar(50),
	@block varchar(50),
	@street varchar(50),
	@Gada varchar(50),
	@Buliding varchar(50),
	@Flat varchar(50),
	@House varchar(50),
	@Floor varchar(50),
	@Notes varchar(255),
	@Original_CustId bigint,
	@Original_CustName varchar(300),
	@IsNull_Address varchar(400),
	@Original_Address varchar(400),
	@IsNull_CustTel varchar(50),
	@Original_CustTel varchar(50),
	@IsNull_block varchar(50),
	@Original_block varchar(50),
	@IsNull_street varchar(50),
	@Original_street varchar(50),
	@IsNull_Gada varchar(50),
	@Original_Gada varchar(50),
	@IsNull_Buliding varchar(50),
	@Original_Buliding varchar(50),
	@IsNull_Flat varchar(50),
	@Original_Flat varchar(50),
	@IsNull_House varchar(50),
	@Original_House varchar(50),
	@IsNull_Floor varchar(50),
	@Original_Floor varchar(50),
	@IsNull_Notes varchar(255),
	@Original_Notes varchar(255),
	@CustId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [HomeCustomer] SET [CustName] = @CustName, [Address] = @Address, [CustTel] = @CustTel, [block] = @block, [street] = @street, [Gada] = @Gada, [Buliding] = @Buliding, [Flat] = @Flat, [House] = @House, [Floor] = @Floor, [Notes] = @Notes WHERE (([CustId] = @Original_CustId) AND ([CustName] = @Original_CustName) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_CustTel = 1 AND [CustTel] IS NULL) OR ([CustTel] = @Original_CustTel)) AND ((@IsNull_block = 1 AND [block] IS NULL) OR ([block] = @Original_block)) AND ((@IsNull_street = 1 AND [street] IS NULL) OR ([street] = @Original_street)) AND ((@IsNull_Gada = 1 AND [Gada] IS NULL) OR ([Gada] = @Original_Gada)) AND ((@IsNull_Buliding = 1 AND [Buliding] IS NULL) OR ([Buliding] = @Original_Buliding)) AND ((@IsNull_Flat = 1 AND [Flat] IS NULL) OR ([Flat] = @Original_Flat)) AND ((@IsNull_House = 1 AND [House] IS NULL) OR ([House] = @Original_House)) AND ((@IsNull_Floor = 1 AND [Floor] IS NULL) OR ([Floor] = @Original_Floor)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)));
	
SELECT CustId, CustName, Address, CustTel, block, street, Gada, Buliding, Flat, House, Floor, Notes FROM HomeCustomer WHERE (CustId = @CustId)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InstallmentDelete
(
	@Original_InstallId bigint,
	@IsNull_InvId bigint,
	@Original_InvId bigint,
	@IsNull_CustAccid bigint,
	@Original_CustAccid bigint,
	@IsNull_CustID bigint,
	@Original_CustID bigint,
	@IsNull_InstallmentAccid bigint,
	@Original_InstallmentAccid bigint,
	@IsNull_StartDate smalldatetime,
	@Original_StartDate smalldatetime,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_InstallmentValue money,
	@Original_InstallmentValue money,
	@IsNull_TotalValue money,
	@Original_TotalValue money,
	@IsNull_AdminName varchar(200),
	@Original_AdminName varchar(200),
	@IsNull_AdminAddress varchar(200),
	@Original_AdminAddress varchar(200),
	@IsNull_Notes varchar(300),
	@Original_Notes varchar(300),
	@IsNull_CollectorAccid bigint,
	@Original_CollectorAccid bigint,
	@IsNull_TypeId int,
	@Original_TypeId int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Installment] WHERE (([InstallId] = @Original_InstallId) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_CustAccid = 1 AND [CustAccid] IS NULL) OR ([CustAccid] = @Original_CustAccid)) AND ((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ((@IsNull_InstallmentAccid = 1 AND [InstallmentAccid] IS NULL) OR ([InstallmentAccid] = @Original_InstallmentAccid)) AND ((@IsNull_StartDate = 1 AND [StartDate] IS NULL) OR ([StartDate] = @Original_StartDate)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_InstallmentValue = 1 AND [InstallmentValue] IS NULL) OR ([InstallmentValue] = @Original_InstallmentValue)) AND ((@IsNull_TotalValue = 1 AND [TotalValue] IS NULL) OR ([TotalValue] = @Original_TotalValue)) AND ((@IsNull_AdminName = 1 AND [AdminName] IS NULL) OR ([AdminName] = @Original_AdminName)) AND ((@IsNull_AdminAddress = 1 AND [AdminAddress] IS NULL) OR ([AdminAddress] = @Original_AdminAddress)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_CollectorAccid = 1 AND [CollectorAccid] IS NULL) OR ([CollectorAccid] = @Original_CollectorAccid)) AND ((@IsNull_TypeId = 1 AND [TypeId] IS NULL) OR ([TypeId] = @Original_TypeId)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InstallmentInsert
(
	@InvId bigint,
	@CustAccid bigint,
	@CustID bigint,
	@InstallmentAccid bigint,
	@StartDate smalldatetime,
	@PaymentDate smalldatetime,
	@InstallmentValue money,
	@TotalValue money,
	@AdminName varchar(200),
	@AdminAddress varchar(200),
	@Notes varchar(300),
	@CollectorAccid bigint,
	@TypeId int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Installment] ([InvId], [CustAccid], [CustID], [InstallmentAccid], [StartDate], [PaymentDate], [InstallmentValue], [TotalValue], [AdminName], [AdminAddress], [Notes], [CollectorAccid], [TypeId]) VALUES (@InvId, @CustAccid, @CustID, @InstallmentAccid, @StartDate, @PaymentDate, @InstallmentValue, @TotalValue, @AdminName, @AdminAddress, @Notes, @CollectorAccid, @TypeId);
	
SELECT InstallId, InvId, CustAccid, CustID, InstallmentAccid, StartDate, PaymentDate, InstallmentValue, TotalValue, AdminName, AdminAddress, Notes, CollectorAccid, TypeId FROM Installment WHERE (InstallId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InstallmentSelect
AS
	SET NOCOUNT ON;
SELECT     InstallId, InvId, CustAccid, CustID, InstallmentAccid, StartDate, PaymentDate, InstallmentValue, TotalValue, AdminName, AdminAddress, Notes, 
                      CollectorAccid, TypeId
FROM         Installment







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InstallmentUpdate
(
	@InvId bigint,
	@CustAccid bigint,
	@CustID bigint,
	@InstallmentAccid bigint,
	@StartDate smalldatetime,
	@PaymentDate smalldatetime,
	@InstallmentValue money,
	@TotalValue money,
	@AdminName varchar(200),
	@AdminAddress varchar(200),
	@Notes varchar(300),
	@CollectorAccid bigint,
	@TypeId int,
	@Original_InstallId bigint,
	@IsNull_InvId bigint,
	@Original_InvId bigint,
	@IsNull_CustAccid bigint,
	@Original_CustAccid bigint,
	@IsNull_CustID bigint,
	@Original_CustID bigint,
	@IsNull_InstallmentAccid bigint,
	@Original_InstallmentAccid bigint,
	@IsNull_StartDate smalldatetime,
	@Original_StartDate smalldatetime,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_InstallmentValue money,
	@Original_InstallmentValue money,
	@IsNull_TotalValue money,
	@Original_TotalValue money,
	@IsNull_AdminName varchar(200),
	@Original_AdminName varchar(200),
	@IsNull_AdminAddress varchar(200),
	@Original_AdminAddress varchar(200),
	@IsNull_Notes varchar(300),
	@Original_Notes varchar(300),
	@IsNull_CollectorAccid bigint,
	@Original_CollectorAccid bigint,
	@IsNull_TypeId int,
	@Original_TypeId int,
	@InstallId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Installment] SET [InvId] = @InvId, [CustAccid] = @CustAccid, [CustID] = @CustID, [InstallmentAccid] = @InstallmentAccid, [StartDate] = @StartDate, [PaymentDate] = @PaymentDate, [InstallmentValue] = @InstallmentValue, [TotalValue] = @TotalValue, [AdminName] = @AdminName, [AdminAddress] = @AdminAddress, [Notes] = @Notes, [CollectorAccid] = @CollectorAccid, [TypeId] = @TypeId WHERE (([InstallId] = @Original_InstallId) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_CustAccid = 1 AND [CustAccid] IS NULL) OR ([CustAccid] = @Original_CustAccid)) AND ((@IsNull_CustID = 1 AND [CustID] IS NULL) OR ([CustID] = @Original_CustID)) AND ((@IsNull_InstallmentAccid = 1 AND [InstallmentAccid] IS NULL) OR ([InstallmentAccid] = @Original_InstallmentAccid)) AND ((@IsNull_StartDate = 1 AND [StartDate] IS NULL) OR ([StartDate] = @Original_StartDate)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_InstallmentValue = 1 AND [InstallmentValue] IS NULL) OR ([InstallmentValue] = @Original_InstallmentValue)) AND ((@IsNull_TotalValue = 1 AND [TotalValue] IS NULL) OR ([TotalValue] = @Original_TotalValue)) AND ((@IsNull_AdminName = 1 AND [AdminName] IS NULL) OR ([AdminName] = @Original_AdminName)) AND ((@IsNull_AdminAddress = 1 AND [AdminAddress] IS NULL) OR ([AdminAddress] = @Original_AdminAddress)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_CollectorAccid = 1 AND [CollectorAccid] IS NULL) OR ([CollectorAccid] = @Original_CollectorAccid)) AND ((@IsNull_TypeId = 1 AND [TypeId] IS NULL) OR ([TypeId] = @Original_TypeId)));
	
SELECT InstallId, InvId, CustAccid, CustID, InstallmentAccid, StartDate, PaymentDate, InstallmentValue, TotalValue, AdminName, AdminAddress, Notes, CollectorAccid, TypeId FROM Installment WHERE (InstallId = @InstallId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionAll
(
	@CustAccid bigint,
	@CollectorAccid bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@PayFlag bit,
	@RequiredFlag bit
)
AS
	SET NOCOUNT ON;
SELECT     DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid
FROM         Installment_Distribution
WHERE     (CustAccid = @CustAccid OR  @CustAccid IS NULL) AND (CollectorAccid = @CollectorAccid OR @CollectorAccid IS NULL) 
 AND (DistDate >= @FromDate or @FromDate is null ) AND (DistDate <= @ToDate or @ToDate is null)

and ( PayFlag=@PayFlag  or @PayFlag is null ) and ( RequiredFlag =@RequiredFlag or @RequiredFlag is  null ) 







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionDelete
(
	@Original_DistubId bigint,
	@IsNull_InstallId bigint,
	@Original_InstallId bigint,
	@IsNull_DistValue money,
	@Original_DistValue money,
	@IsNull_DistDate smalldatetime,
	@Original_DistDate smalldatetime,
	@IsNull_PayFlag bit,
	@Original_PayFlag bit,
	@IsNull_RequiredFlag bit,
	@Original_RequiredFlag bit,
	@IsNull_CustAccid bigint,
	@Original_CustAccid bigint,
	@IsNull_CollectorAccid bigint,
	@Original_CollectorAccid bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Installment_Distribution] WHERE (([DistubId] = @Original_DistubId) AND ((@IsNull_InstallId = 1 AND [InstallId] IS NULL) OR ([InstallId] = @Original_InstallId)) AND ((@IsNull_DistValue = 1 AND [DistValue] IS NULL) OR ([DistValue] = @Original_DistValue)) AND ((@IsNull_DistDate = 1 AND [DistDate] IS NULL) OR ([DistDate] = @Original_DistDate)) AND ((@IsNull_PayFlag = 1 AND [PayFlag] IS NULL) OR ([PayFlag] = @Original_PayFlag)) AND ((@IsNull_RequiredFlag = 1 AND [RequiredFlag] IS NULL) OR ([RequiredFlag] = @Original_RequiredFlag)) AND ((@IsNull_CustAccid = 1 AND [CustAccid] IS NULL) OR ([CustAccid] = @Original_CustAccid)) AND ((@IsNull_CollectorAccid = 1 AND [CollectorAccid] IS NULL) OR ([CollectorAccid] = @Original_CollectorAccid)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionInsert
(
	@InstallId bigint,
	@DistValue money,
	@DistDate smalldatetime,
	@PayFlag bit,
	@RequiredFlag bit,
	@CustAccid bigint,
	@CollectorAccid bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Installment_Distribution] ([InstallId], [DistValue], [DistDate], [PayFlag], [RequiredFlag], [CustAccid], [CollectorAccid]) VALUES (@InstallId, @DistValue, @DistDate, @PayFlag, @RequiredFlag, @CustAccid, @CollectorAccid);
	
SELECT DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid FROM Installment_Distribution WHERE (DistubId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionPayment
(
	@CustAccid bigint,
	@CollectorAccid bigint,
	@DistDate smalldatetime
)
AS
	SET NOCOUNT ON;
SELECT     DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid
FROM         Installment_Distribution
WHERE     (CustAccid = @CustAccid OR
                      @CustAccid IS NULL) AND (CollectorAccid = @CollectorAccid OR
                      @CollectorAccid IS NULL) AND (DistDate <= @DistDate ) AND ( PayFlag= 0 and RequiredFlag=1)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionRequired
(
	@CustAccid bigint,
	@CollectorAccid bigint,
	@DistDate smalldatetime
)
AS
	SET NOCOUNT ON;
SELECT     DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid
FROM         Installment_Distribution
WHERE     (CustAccid = @CustAccid OR
                      @CustAccid IS NULL) AND (CollectorAccid = @CollectorAccid OR
                      @CollectorAccid IS NULL) AND (DistDate <= @DistDate ) AND (PayFlag = 0 and RequiredFlag=0)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionSelect
AS
	SET NOCOUNT ON;
SELECT     DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid
FROM         Installment_Distribution







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Installment_DistributionUpdate
(
	@InstallId bigint,
	@DistValue money,
	@DistDate smalldatetime,
	@PayFlag bit,
	@RequiredFlag bit,
	@CustAccid bigint,
	@CollectorAccid bigint,
	@Original_DistubId bigint,
	@IsNull_InstallId bigint,
	@Original_InstallId bigint,
	@IsNull_DistValue money,
	@Original_DistValue money,
	@IsNull_DistDate smalldatetime,
	@Original_DistDate smalldatetime,
	@IsNull_PayFlag bit,
	@Original_PayFlag bit,
	@IsNull_RequiredFlag bit,
	@Original_RequiredFlag bit,
	@IsNull_CustAccid bigint,
	@Original_CustAccid bigint,
	@IsNull_CollectorAccid bigint,
	@Original_CollectorAccid bigint,
	@DistubId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Installment_Distribution] SET [InstallId] = @InstallId, [DistValue] = @DistValue, [DistDate] = @DistDate, [PayFlag] = @PayFlag, [RequiredFlag] = @RequiredFlag, [CustAccid] = @CustAccid, [CollectorAccid] = @CollectorAccid WHERE (([DistubId] = @Original_DistubId) AND ((@IsNull_InstallId = 1 AND [InstallId] IS NULL) OR ([InstallId] = @Original_InstallId)) AND ((@IsNull_DistValue = 1 AND [DistValue] IS NULL) OR ([DistValue] = @Original_DistValue)) AND ((@IsNull_DistDate = 1 AND [DistDate] IS NULL) OR ([DistDate] = @Original_DistDate)) AND ((@IsNull_PayFlag = 1 AND [PayFlag] IS NULL) OR ([PayFlag] = @Original_PayFlag)) AND ((@IsNull_RequiredFlag = 1 AND [RequiredFlag] IS NULL) OR ([RequiredFlag] = @Original_RequiredFlag)) AND ((@IsNull_CustAccid = 1 AND [CustAccid] IS NULL) OR ([CustAccid] = @Original_CustAccid)) AND ((@IsNull_CollectorAccid = 1 AND [CollectorAccid] IS NULL) OR ([CollectorAccid] = @Original_CollectorAccid)));
	
SELECT DistubId, InstallId, DistValue, DistDate, PayFlag, RequiredFlag, CustAccid, CollectorAccid FROM Installment_Distribution WHERE (DistubId = @DistubId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvOrdersDelete
(
	@Original_InvId bigint,
	@Original_InvCode nvarchar(100),
	@IsNull_RecoderCode nvarchar(50),
	@Original_RecoderCode nvarchar(50),
	@IsNull_InvDate smalldatetime,
	@Original_InvDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_InvAccid bigint,
	@Original_InvAccid bigint,
	@IsNull_PaymentType smallint,
	@Original_PaymentType smallint,
	@IsNull_PaymentAccid bigint,
	@Original_PaymentAccid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_PaymentValue money,
	@Original_PaymentValue money,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_invTotal money,
	@Original_invTotal money,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_InvTotalNet money,
	@Original_InvTotalNet money,
	@IsNull_InvPayment money,
	@Original_InvPayment money,
	@IsNull_InvRemain money,
	@Original_InvRemain money,
	@IsNull_ReferID bigint,
	@Original_ReferID bigint,
	@IsNull_PaymentCost money,
	@Original_PaymentCost money,
	@IsNull_ChequeNo nvarchar(50),
	@Original_ChequeNo nvarchar(50),
	@IsNull_ChequeFlag bit,
	@Original_ChequeFlag bit,
	@IsNull_TotalAddCost money,
	@Original_TotalAddCost money,
	@IsNull_TotalReoder money,
	@Original_TotalReoder money,
	@IsNull_TotalReoderNet money,
	@Original_TotalReoderNet money,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_PayFinish bit,
	@Original_PayFinish bit,
	@IsNull_CollectValue money,
	@Original_CollectValue money,
	@IsNull_KeyNetValue money,
	@Original_KeyNetValue money,
	@IsNull_VisaValue money,
	@Original_VisaValue money,
	@IsNull_MasterValue money,
	@Original_MasterValue money,
	@IsNull_ChequeValue money,
	@Original_ChequeValue money,
	@IsNull_OtherValue money,
	@Original_OtherValue money
)
AS
	SET NOCOUNT OFF;
DELETE FROM [InvOrders] WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvOrdersInsert
(
	@InvCode nvarchar(100),
	@RecoderCode nvarchar(50),
	@InvDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@InvAccid bigint,
	@PaymentType smallint,
	@PaymentAccid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@PaymentValue money,
	@PaymentDate smalldatetime,
	@Notes ntext,
	@invTotal money,
	@Discount float,
	@InvTotalNet money,
	@InvPayment money,
	@InvRemain money,
	@ReferID bigint,
	@PaymentCost money,
	@ChequeNo nvarchar(50),
	@ChequeFlag bit,
	@TotalAddCost money,
	@TotalReoder money,
	@TotalReoderNet money,
	@CostId bigint,
	@SUP_CUST_ID bigint,
	@PayFinish bit,
	@CollectValue money,
	@KeyNetValue money,
	@VisaValue money,
	@MasterValue money,
	@ChequeValue money,
	@OtherValue money
)
AS
	SET NOCOUNT OFF;
INSERT INTO [InvOrders] ([InvCode], [RecoderCode], [InvDate], [Cust_Sup_Accid], [InvAccid], [PaymentType], [PaymentAccid], [BranchId], [InvType], [EmpId], [PaymentValue], [PaymentDate], [Notes], [invTotal], [Discount], [InvTotalNet], [InvPayment], [InvRemain], [ReferID], [PaymentCost], [ChequeNo], [ChequeFlag], [TotalAddCost], [TotalReoder], [TotalReoderNet], [CostId], [SUP_CUST_ID], [PayFinish], [CollectValue], [KeyNetValue], [VisaValue], [MasterValue], [ChequeValue], [OtherValue]) VALUES (@InvCode, @RecoderCode, @InvDate, @Cust_Sup_Accid, @InvAccid, @PaymentType, @PaymentAccid, @BranchId, @InvType, @EmpId, @PaymentValue, @PaymentDate, @Notes, @invTotal, @Discount, @InvTotalNet, @InvPayment, @InvRemain, @ReferID, @PaymentCost, @ChequeNo, @ChequeFlag, @TotalAddCost, @TotalReoder, @TotalReoderNet, @CostId, @SUP_CUST_ID, @PayFinish, @CollectValue, @KeyNetValue, @VisaValue, @MasterValue, @ChequeValue, @OtherValue);
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue FROM InvOrders WHERE (InvId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvOrdersProductsById
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND
FROM         InvOrders_Products
WHERE     (InvId = @InvId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvOrdersSelect
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue
FROM         InvOrders







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvOrdersUpdate
(
	@InvCode nvarchar(100),
	@RecoderCode nvarchar(50),
	@InvDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@InvAccid bigint,
	@PaymentType smallint,
	@PaymentAccid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@PaymentValue money,
	@PaymentDate smalldatetime,
	@Notes ntext,
	@invTotal money,
	@Discount float,
	@InvTotalNet money,
	@InvPayment money,
	@InvRemain money,
	@ReferID bigint,
	@PaymentCost money,
	@ChequeNo nvarchar(50),
	@ChequeFlag bit,
	@TotalAddCost money,
	@TotalReoder money,
	@TotalReoderNet money,
	@CostId bigint,
	@SUP_CUST_ID bigint,
	@PayFinish bit,
	@CollectValue money,
	@KeyNetValue money,
	@VisaValue money,
	@MasterValue money,
	@ChequeValue money,
	@OtherValue money,
	@Original_InvId bigint,
	@Original_InvCode nvarchar(100),
	@IsNull_RecoderCode nvarchar(50),
	@Original_RecoderCode nvarchar(50),
	@IsNull_InvDate smalldatetime,
	@Original_InvDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_InvAccid bigint,
	@Original_InvAccid bigint,
	@IsNull_PaymentType smallint,
	@Original_PaymentType smallint,
	@IsNull_PaymentAccid bigint,
	@Original_PaymentAccid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_PaymentValue money,
	@Original_PaymentValue money,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_invTotal money,
	@Original_invTotal money,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_InvTotalNet money,
	@Original_InvTotalNet money,
	@IsNull_InvPayment money,
	@Original_InvPayment money,
	@IsNull_InvRemain money,
	@Original_InvRemain money,
	@IsNull_ReferID bigint,
	@Original_ReferID bigint,
	@IsNull_PaymentCost money,
	@Original_PaymentCost money,
	@IsNull_ChequeNo nvarchar(50),
	@Original_ChequeNo nvarchar(50),
	@IsNull_ChequeFlag bit,
	@Original_ChequeFlag bit,
	@IsNull_TotalAddCost money,
	@Original_TotalAddCost money,
	@IsNull_TotalReoder money,
	@Original_TotalReoder money,
	@IsNull_TotalReoderNet money,
	@Original_TotalReoderNet money,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_PayFinish bit,
	@Original_PayFinish bit,
	@IsNull_CollectValue money,
	@Original_CollectValue money,
	@IsNull_KeyNetValue money,
	@Original_KeyNetValue money,
	@IsNull_VisaValue money,
	@Original_VisaValue money,
	@IsNull_MasterValue money,
	@Original_MasterValue money,
	@IsNull_ChequeValue money,
	@Original_ChequeValue money,
	@IsNull_OtherValue money,
	@Original_OtherValue money,
	@InvId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [InvOrders] SET [InvCode] = @InvCode, [RecoderCode] = @RecoderCode, [InvDate] = @InvDate, [Cust_Sup_Accid] = @Cust_Sup_Accid, [InvAccid] = @InvAccid, [PaymentType] = @PaymentType, [PaymentAccid] = @PaymentAccid, [BranchId] = @BranchId, [InvType] = @InvType, [EmpId] = @EmpId, [PaymentValue] = @PaymentValue, [PaymentDate] = @PaymentDate, [Notes] = @Notes, [invTotal] = @invTotal, [Discount] = @Discount, [InvTotalNet] = @InvTotalNet, [InvPayment] = @InvPayment, [InvRemain] = @InvRemain, [ReferID] = @ReferID, [PaymentCost] = @PaymentCost, [ChequeNo] = @ChequeNo, [ChequeFlag] = @ChequeFlag, [TotalAddCost] = @TotalAddCost, [TotalReoder] = @TotalReoder, [TotalReoderNet] = @TotalReoderNet, [CostId] = @CostId, [SUP_CUST_ID] = @SUP_CUST_ID, [PayFinish] = @PayFinish, [CollectValue] = @CollectValue, [KeyNetValue] = @KeyNetValue, [VisaValue] = @VisaValue, [MasterValue] = @MasterValue, [ChequeValue] = @ChequeValue, [OtherValue] = @OtherValue WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)));
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue FROM InvOrders WHERE (InvId = @InvId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_InvProductsAllViewSelect
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, Qty, Price, TotalPrice, VaildDate, productname, PRODUCTCODE, 
                      UNITDESC
FROM         InvProductsAllView








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_InvProductsAllViewSelectByInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, Qty, Price, TotalPrice, VaildDate, productname, PRODUCTCODE, 
                      UNITDESC
FROM         InvProductsAllView
WHERE     (InvId = @InvId)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_InvProductsByInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND, ConFactor,InvType,ReoderId
FROM         Inv_Products
WHERE     (InvId = @InvId)




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO











CREATE PROCEDURE dbo.usp_InvProductsMoveVIEW
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, UNITDESC, ProductName, LastSalePrice, LastCostPrice, LastBuyPrice, QUANTITY, PRODUCTCODE, QtyInStore, 
                      PRODUCTBRAND,AvgCostPrice,MaxCostPrice, SUP_CUST_FNAME,MainUnit,ConFactor,totMainQty
FROM         dbo.InvProductsMoveVIEW







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_InvProductsMoveVIEWByCustParms
(
	@invtype int,
	@BranchId bigint,
	@SUP_CUST_ID bigint,
	@FromDate datetime,
	@ToDate datetime,
	@phone1 varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, SUP_CUST_FNAME, UNITDESC, ProductName,  LastSalePrice, LastBuyPrice,QUANTITY,PRODUCTCODE,PHONE1,
Qty*Price as totPrice,MainUnit,ConFactor
FROM         InvProductsMoveVIEW
WHERE     (InvType =@invtype) and   (BranchId= @BranchId )  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)  and  (InvDate<= @ToDate OR @ToDate IS NULL) and (phone1=@phone1 Or phone1 is null )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_InvProductsMoveVIEWByParms
(
	@ProductId bigint,
	@BranchId bigint,
	@StoreId bigint,
@SUP_CUST_ID bigint,
	@FromDate datetime,
	@ToDate datetime,
@BillTypeId int
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, UNITDESC, ProductName, LastSalePrice, LastCostPrice, LastBuyPrice, QUANTITY, PRODUCTCODE, QtyInStore, 
                      PRODUCTBRAND,AvgCostPrice,MaxCostPrice,SUP_CUST_FNAME,MainUnit,ConFactor,totMainQty,dbo.fn_Select_SalesGroupbyInvProduct(ProductId,@BranchId,@StoreId,@SUP_CUST_ID,@FromDate,@ToDate) as TotalQty
,dbo.fn_Select_pruchaseGroupbyInvProduct(ProductId,@BranchId,@StoreId,@SUP_CUST_ID,@FromDate,@ToDate) as TotalPruchaseQty
FROM         InvProductsMoveVIEW
where  (ProductId= @ProductId OR @ProductId IS NULL) AND  (BranchId= @BranchId OR @BranchId IS NULL) and  (StoreId= @StoreId OR @StoreId IS NULL)  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)
 and  (InvDate<= @ToDate OR @ToDate IS NULL)
and   (PaymentType<= @BillTypeId OR @BillTypeId IS NULL)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE usp_InvProductsMoveVIEWByParmsAll
(
	@ProductId bigint,
	@BranchId bigint,
	@StoreId bigint,
@SUP_CUST_ID bigint,
@UnitId bigint,
@Barcode nvarchar(30),
	@FromDate datetime,
	@ToDate datetime
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, UNITDESC, ProductName, LastSalePrice, LastCostPrice, LastBuyPrice, QUANTITY, PRODUCTCODE, QtyInStore, 
                      PRODUCTBRAND,AvgCostPrice,MaxCostPrice,SUP_CUST_FNAME,MainUnit,ConFactor,totMainQty,dbo.fn_Select_SalesGroupbyInvProduct(ProductId,@BranchId,@StoreId,@SUP_CUST_ID,@FromDate,@ToDate) as TotalQty
,dbo.fn_Select_pruchaseGroupbyInvProduct(ProductId,@BranchId,@StoreId,@SUP_CUST_ID,@FromDate,@ToDate) as TotalPruchaseQty

FROM         dbo.InvProductsMoveVIEW

where  (ProductId= @ProductId OR @ProductId IS NULL) AND  (BranchId= @BranchId OR @BranchId IS NULL) and  (StoreId= @StoreId OR @StoreId IS NULL)  and
  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  and   (UnitId= @UnitId OR @UnitId IS NULL)  
and   (PRODUCTBRAND = @Barcode OR @Barcode IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)
 and  (InvDate<= @ToDate OR @ToDate IS NULL) and  (ReoderFlag <> 1)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO










Create PROCEDURE [dbo].[usp_InvSelectMaxSerial]

AS
	SET NOCOUNT ON;
SELECT     ISNULL(MAX(Serial), 0) AS MaxSerial
FROM         Invoices






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_Inv_PRODUCTSelectCountProductID
(
	@productId bigint
	)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS PCount
FROM         Inv_Products
WHERE     (ProductId = @productId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Inv_PRODUCTSelectbyProduct
(
	@productId bigint,
	@StoreId bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS PCount
FROM         Inv_Products
WHERE     (ProductId = @productId) AND (StoreId = @StoreId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_Inv_ProductsDelete
(
	@Original_Inv_Product_Id bigint,
	@Original_InvId bigint,
	@Original_ProductId bigint,
	@Original_UnitId bigint,
	@Original_Qty float,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@Original_Price money,
	@Original_StoreId bigint,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ReoderFlag bit,
	@Original_ReoderFlag bit,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30),
	@IsNull_ConFactor float,
	@Original_ConFactor float,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_ReoderId bigint,
	@Original_ReoderId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Inv_Products] WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ((@IsNull_ConFactor = 1 AND [ConFactor] IS NULL) OR ([ConFactor] = @Original_ConFactor)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_ReoderId = 1 AND [ReoderId] IS NULL) OR ([ReoderId] = @Original_ReoderId)))




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_Inv_ProductsInsert
(
	@InvId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@ReorderQty float,
	@Price money,
	@StoreId bigint,
	@Discount float,
	@VaildDate datetime,
	@TotalPrice money,
	@ReoderFlag bit,
	@TotReOderPrice money,
	@PRODUCTBRAND nvarchar(30),
	@ConFactor float,
	@InvType int,
	@ReoderId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Inv_Products] ([InvId], [ProductId], [UnitId], [Qty], [ReorderQty], [Price], [StoreId], [Discount], [VaildDate], [TotalPrice], [ReoderFlag], [TotReOderPrice], [PRODUCTBRAND], [ConFactor], [InvType], [ReoderId]) VALUES (@InvId, @ProductId, @UnitId, @Qty, @ReorderQty, @Price, @StoreId, @Discount, @VaildDate, @TotalPrice, @ReoderFlag, @TotReOderPrice, @PRODUCTBRAND, @ConFactor, @InvType, @ReoderId);
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND, ConFactor, InvType, ReoderId FROM Inv_Products WHERE (Inv_Product_Id = SCOPE_IDENTITY())




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_Inv_ProductsSelect
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND, ConFactor, InvType, ReoderId
FROM         Inv_Products




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE PROCEDURE dbo.usp_Inv_ProductsSelectbyReoderId
(
 	@ReoderId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND, ConFactor, InvType,ReoderId
FROM         Inv_Products
where ReoderId=@ReoderId and ReoderFlag=1




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_Inv_ProductsUpdate
(
	@InvId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@ReorderQty float,
	@Price money,
	@StoreId bigint,
	@Discount float,
	@VaildDate datetime,
	@TotalPrice money,
	@ReoderFlag bit,
	@TotReOderPrice money,
	@PRODUCTBRAND nvarchar(30),
	@ConFactor float,
	@InvType int,
	@ReoderId bigint,
	@Original_Inv_Product_Id bigint,
	@Original_InvId bigint,
	@Original_ProductId bigint,
	@Original_UnitId bigint,
	@Original_Qty float,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@Original_Price money,
	@Original_StoreId bigint,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ReoderFlag bit,
	@Original_ReoderFlag bit,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30),
	@IsNull_ConFactor float,
	@Original_ConFactor float,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_ReoderId bigint,
	@Original_ReoderId bigint,
	@Inv_Product_Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Inv_Products] SET [InvId] = @InvId, [ProductId] = @ProductId, [UnitId] = @UnitId, [Qty] = @Qty, [ReorderQty] = @ReorderQty, [Price] = @Price, [StoreId] = @StoreId, [Discount] = @Discount, [VaildDate] = @VaildDate, [TotalPrice] = @TotalPrice, [ReoderFlag] = @ReoderFlag, [TotReOderPrice] = @TotReOderPrice, [PRODUCTBRAND] = @PRODUCTBRAND, [ConFactor] = @ConFactor, [InvType] = @InvType, [ReoderId] = @ReoderId WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ((@IsNull_ConFactor = 1 AND [ConFactor] IS NULL) OR ([ConFactor] = @Original_ConFactor)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_ReoderId = 1 AND [ReoderId] IS NULL) OR ([ReoderId] = @Original_ReoderId)));
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND, ConFactor, InvType, ReoderId FROM Inv_Products WHERE (Inv_Product_Id = @Inv_Product_Id)




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_InvoiceReodersDelete
(
	@Original_ReorderId bigint,
	@IsNull_ReorderDate smalldatetime,
	@Original_ReorderDate smalldatetime,
	@IsNull_CustId bigint,
	@Original_CustId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [InvoiceReoders] WHERE (([ReorderId] = @Original_ReorderId) AND ((@IsNull_ReorderDate = 1 AND [ReorderDate] IS NULL) OR ([ReorderDate] = @Original_ReorderDate)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)))




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_InvoiceReodersInsert
(
	@ReorderDate smalldatetime,
	@CustId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [InvoiceReoders] ([ReorderDate], [CustId]) VALUES (@ReorderDate, @CustId);
	
SELECT ReorderId, ReorderDate, CustId FROM InvoiceReoders WHERE (ReorderId = SCOPE_IDENTITY())




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_InvoiceReodersSelect
AS
	SET NOCOUNT ON;
SELECT     ReorderId, ReorderDate, CustId
FROM         InvoiceReoders




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_InvoiceReodersSelectbyDate
(
	@ReorderId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime
)
AS
	SET NOCOUNT ON;
SELECT     ReorderId, ReorderDate, CustId
FROM         InvoiceReoders
WHERE     (ReorderId = @ReorderId OR  @ReorderId IS NULL) 
and  (ReorderDate >=@FromDate or @FromDate IS NULL) 
AND  (ReorderDate <=@ToDate or @ToDate  is null) 
            






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_InvoiceReodersUpdate
(
	@ReorderDate smalldatetime,
	@CustId bigint,
	@Original_ReorderId bigint,
	@IsNull_ReorderDate smalldatetime,
	@Original_ReorderDate smalldatetime,
	@IsNull_CustId bigint,
	@Original_CustId bigint,
	@ReorderId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [InvoiceReoders] SET [ReorderDate] = @ReorderDate, [CustId] = @CustId WHERE (([ReorderId] = @Original_ReorderId) AND ((@IsNull_ReorderDate = 1 AND [ReorderDate] IS NULL) OR ([ReorderDate] = @Original_ReorderDate)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)));
	
SELECT ReorderId, ReorderDate, CustId FROM InvoiceReoders WHERE (ReorderId = @ReorderId)




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_InvoiceViewSelect
(
	@invtype int,
	@BranchId bigint,
	@SUP_CUST_ID bigint,
	@FromDate datetime,
	@ToDate datetime
)
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID,SUP_CUST_FNAME, InvoiceView.CollectValue,phone1
FROM         InvoiceView
WHERE     (InvType =@invtype) and   (BranchId= @BranchId OR @BranchId IS NULL)  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)  and  (InvDate<= @ToDate OR @ToDate IS NULL)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_InvoiceViewSelectAll
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, SUP_CUST_FNAME, CollectValue,Phone1
FROM         InvoiceView







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_InvoiceViewSelectByCust
(
	@invtype int,
	@BranchId bigint,
	@SUP_CUST_ID bigint,
	@FromDate datetime,
	@ToDate datetime,
	@phone1 varchar(50)
)
AS
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID,SUP_CUST_FNAME, InvoiceView.CollectValue,phone1
FROM         InvoiceView
WHERE     (InvType =@invtype) and   (BranchId= @BranchId )  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)  and  (InvDate<= @ToDate OR @ToDate IS NULL) and (phone1=@phone1 Or phone1 is null )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_InvoiceViewSelectByParam
(
	@BranchId bigint,
	@SUP_CUST_ID bigint,
	@FromDate datetime,
	@ToDate datetime,
@InvType int,

@BillTypeId int
)
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID,SUP_CUST_FNAME, InvoiceView.CollectValue
FROM         InvoiceView
WHERE      (BranchId= @BranchId OR @BranchId IS NULL)  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)  and  (InvDate<= @ToDate OR @ToDate IS NULL) 
 and  (InvType= @InvType OR @InvType IS NULL)
and   (PaymentType<= @BillTypeId OR @BillTypeId IS NULL)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_InvoiceViewSelectMove
(
 @ACCOUNTID bigint,
	 @BranchId bigint,
	 @FromDate smalldatetime,
	 @ToDate smalldatetime,
	 @ProductId bigint,
 @StoreId int
)
AS
	SET NOCOUNT ON;
SELECT    InvoiceView.InvId,  InvoiceView.InvCode,  InvoiceView.RecoderCode,  InvoiceView.InvDate,  InvoiceView.Cust_Sup_Accid,  InvoiceView.InvAccid,  InvoiceView.PaymentType,  InvoiceView.PaymentAccid,
  InvoiceView.BranchId,  InvoiceView.InvType,  InvoiceView.EmpId,  InvoiceView.PaymentValue,  InvoiceView.PaymentDate,  InvoiceView.Notes,  InvoiceView.invTotal,  InvoiceView.Discount,
  InvoiceView.InvTotalNet,  InvoiceView.InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, SUP_CUST_FNAME, CollectValue,
ACCOUNTName,AccountCode,AccountId
FROM         dbo.accounting LEFT OUTER JOIN
                      dbo.InvoiceView ON dbo.accounting.accountid = dbo.InvoiceView.Cust_Sup_Accid
WHERE     (Cust_Sup_accid = accounting.ACCOUNTID or @ACCOUNTID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) AND (invDate >= @FromDate or @FromDate is null ) AND (invDate <= @ToDate or @ToDate is null)
and    invdate =          (SELECT     MAX(invdate)
                             FROM         InvProductsVIEW d
                             WHERE     d .cust_sup_Accid =InvoiceView.cust_sup_Accid
  and (ProductId = @ProductId or @ProductId  IS NULL) and (StoreId = @StoreId or @StoreId  IS NULL)  
group by d .cust_sup_Accid) 

or invdate is null 
and (ACCOUNTID>4 and (ACCOUNTID=@ACCOUNTID or AccountparentId=@ACCOUNTID) and mainnode=0)
order by AccountCode







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_Loans_ViewSelect
AS
	SET NOCOUNT ON;
SELECT     FName, SName, TName, FoName, TITLE, DEPT_DESC, FullName, EmpNum, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, 
                      MonthlyIncrease, Balance, EMP_CODE, DEPTCODE
FROM         Loans_View








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.[usp_Loans_ViewSelectbyParam]
@EMP_CODE bigint ,

@FromDate smalldatetime,
@ToDate smalldatetime,
@DEPTCODE bigint ,
@EmpNum bigint
AS
	SET NOCOUNT ON;
SELECT     FName, SName, TName, FoName, TITLE, DEPT_DESC, FullName, EmpNum, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, 
                      MonthlyIncrease, Balance, EMP_CODE, DEPTCODE
FROM         Loans_View
where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and ( LoanDate>=@FromDate or @FromDate is null) and ( LoanDate<=@ToDate or @ToDate is null)
and (EmpNum=@EmpNum or @EmpNum is null)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_MonthsSelect
AS
	SET NOCOUNT ON;
SELECT     MON_CODE, MON_DESC
FROM         CDE_MONTHS







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_MoveDetailsSelectByMoveId
(
	@MoveId bigint
)
AS
	SET NOCOUNT ON;
SELECT     DetId, MoveId, PRODUCTID, UnitID, MovmentQty
FROM         StockMoveDetails
WHERE     (MoveId = @MoveId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_NATIONALITYDelete
(
	@Original_NATIONALITY_CODE numeric(5, 0),
	@Original_NATIONALITY_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_NATIONALITY] WHERE (([NATIONALITY_CODE] = @Original_NATIONALITY_CODE) AND ([NATIONALITY_DESC] = @Original_NATIONALITY_DESC))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_NATIONALITYInsert
(
	@NATIONALITY_CODE numeric(5, 0),
	@NATIONALITY_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_NATIONALITY] ([NATIONALITY_CODE], [NATIONALITY_DESC]) VALUES (@NATIONALITY_CODE, @NATIONALITY_DESC);
	
SELECT NATIONALITY_CODE, NATIONALITY_DESC FROM CDE_NATIONALITY WHERE (NATIONALITY_CODE = @NATIONALITY_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_NATIONALITYSelect
AS
	SET NOCOUNT ON;
SELECT     NATIONALITY_CODE, NATIONALITY_DESC
FROM         CDE_NATIONALITY







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_NATIONALITYUpdate
(
	@NATIONALITY_CODE numeric(5, 0),
	@NATIONALITY_DESC varchar(200),
	@Original_NATIONALITY_CODE numeric(5, 0),
	@Original_NATIONALITY_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_NATIONALITY] SET [NATIONALITY_CODE] = @NATIONALITY_CODE, [NATIONALITY_DESC] = @NATIONALITY_DESC WHERE (([NATIONALITY_CODE] = @Original_NATIONALITY_CODE) AND ([NATIONALITY_DESC] = @Original_NATIONALITY_DESC));
	
SELECT NATIONALITY_CODE, NATIONALITY_DESC FROM CDE_NATIONALITY WHERE (NATIONALITY_CODE = @NATIONALITY_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ORDERDETAILSDelete
(
	@Original_Order_Product_Id bigint,
	@IsNull_OrderId bigint,
	@Original_OrderId bigint,
	@IsNull_ProductId bigint,
	@Original_ProductId bigint,
	@IsNull_UnitId bigint,
	@Original_UnitId bigint,
	@IsNull_Qty float,
	@Original_Qty float,
	@IsNull_Price money,
	@Original_Price money,
	@IsNull_StoreId bigint,
	@Original_StoreId bigint,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ORDERDETAILS] WHERE (([Order_Product_Id] = @Original_Order_Product_Id) AND ((@IsNull_OrderId = 1 AND [OrderId] IS NULL) OR ([OrderId] = @Original_OrderId)) AND ((@IsNull_ProductId = 1 AND [ProductId] IS NULL) OR ([ProductId] = @Original_ProductId)) AND ((@IsNull_UnitId = 1 AND [UnitId] IS NULL) OR ([UnitId] = @Original_UnitId)) AND ((@IsNull_Qty = 1 AND [Qty] IS NULL) OR ([Qty] = @Original_Qty)) AND ((@IsNull_Price = 1 AND [Price] IS NULL) OR ([Price] = @Original_Price)) AND ((@IsNull_StoreId = 1 AND [StoreId] IS NULL) OR ([StoreId] = @Original_StoreId)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)))








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ORDERDETAILSInsert
(
	@OrderId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@Price money,
	@StoreId bigint,
	@VaildDate datetime,
	@PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ORDERDETAILS] ([OrderId], [ProductId], [UnitId], [Qty], [Price], [StoreId], [VaildDate], [PRODUCTBRAND]) VALUES (@OrderId, @ProductId, @UnitId, @Qty, @Price, @StoreId, @VaildDate, @PRODUCTBRAND);
	
SELECT Order_Product_Id, OrderId, ProductId, UnitId, Qty, Price, StoreId, VaildDate, PRODUCTBRAND FROM ORDERDETAILS WHERE (Order_Product_Id = SCOPE_IDENTITY())








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ORDERDETAILSSelect
AS
	SET NOCOUNT ON;
SELECT     Order_Product_Id, OrderId, ProductId, UnitId, Qty, Price, StoreId, VaildDate, PRODUCTBRAND
FROM         ORDERDETAILS








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ORDERDETAILSUpdate
(
	@OrderId bigint,
	@ProductId bigint,
	@UnitId bigint,
	@Qty float,
	@Price money,
	@StoreId bigint,
	@VaildDate datetime,
	@PRODUCTBRAND nvarchar(30),
	@Original_Order_Product_Id bigint,
	@IsNull_OrderId bigint,
	@Original_OrderId bigint,
	@IsNull_ProductId bigint,
	@Original_ProductId bigint,
	@IsNull_UnitId bigint,
	@Original_UnitId bigint,
	@IsNull_Qty float,
	@Original_Qty float,
	@IsNull_Price money,
	@Original_Price money,
	@IsNull_StoreId bigint,
	@Original_StoreId bigint,
	@IsNull_VaildDate datetime,
	@Original_VaildDate datetime,
	@IsNull_PRODUCTBRAND nvarchar(30),
	@Original_PRODUCTBRAND nvarchar(30),
	@Order_Product_Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ORDERDETAILS] SET [OrderId] = @OrderId, [ProductId] = @ProductId, [UnitId] = @UnitId, [Qty] = @Qty, [Price] = @Price, [StoreId] = @StoreId, [VaildDate] = @VaildDate, [PRODUCTBRAND] = @PRODUCTBRAND WHERE (([Order_Product_Id] = @Original_Order_Product_Id) AND ((@IsNull_OrderId = 1 AND [OrderId] IS NULL) OR ([OrderId] = @Original_OrderId)) AND ((@IsNull_ProductId = 1 AND [ProductId] IS NULL) OR ([ProductId] = @Original_ProductId)) AND ((@IsNull_UnitId = 1 AND [UnitId] IS NULL) OR ([UnitId] = @Original_UnitId)) AND ((@IsNull_Qty = 1 AND [Qty] IS NULL) OR ([Qty] = @Original_Qty)) AND ((@IsNull_Price = 1 AND [Price] IS NULL) OR ([Price] = @Original_Price)) AND ((@IsNull_StoreId = 1 AND [StoreId] IS NULL) OR ([StoreId] = @Original_StoreId)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)));
	
SELECT Order_Product_Id, OrderId, ProductId, UnitId, Qty, Price, StoreId, VaildDate, PRODUCTBRAND FROM ORDERDETAILS WHERE (Order_Product_Id = @Order_Product_Id)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_ORDERSDelete
(
	@Original_OrderId bigint,
	@IsNull_OrderCode nvarchar(100),
	@Original_OrderCode nvarchar(100),
	@IsNull_OrderDate smalldatetime,
	@Original_OrderDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_SelFlag bit,
	@Original_SelFlag bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ORDERS] WHERE (([OrderId] = @Original_OrderId) AND ((@IsNull_OrderCode = 1 AND [OrderCode] IS NULL) OR ([OrderCode] = @Original_OrderCode)) AND ((@IsNull_OrderDate = 1 AND [OrderDate] IS NULL) OR ([OrderDate] = @Original_OrderDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_SelFlag = 1 AND [SelFlag] IS NULL) OR ([SelFlag] = @Original_SelFlag)))






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_ORDERSInsert
(
	@OrderCode nvarchar(100),
	@OrderDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@Notes ntext,
	@SUP_CUST_ID bigint,
	@SelFlag bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ORDERS] ([OrderCode], [OrderDate], [Cust_Sup_Accid], [BranchId], [InvType], [EmpId], [Notes], [SUP_CUST_ID], [SelFlag]) VALUES (@OrderCode, @OrderDate, @Cust_Sup_Accid, @BranchId, @InvType, @EmpId, @Notes, @SUP_CUST_ID, @SelFlag);
	
SELECT OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID, SelFlag FROM ORDERS WHERE (OrderId = SCOPE_IDENTITY())






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_ORDERSSelect
AS
	SET NOCOUNT ON;
SELECT     OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID, SelFlag
FROM         ORDERS






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_ORDERSUpdate
(
	@OrderCode nvarchar(100),
	@OrderDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@Notes ntext,
	@SUP_CUST_ID bigint,
	@SelFlag bit,
	@Original_OrderId bigint,
	@IsNull_OrderCode nvarchar(100),
	@Original_OrderCode nvarchar(100),
	@IsNull_OrderDate smalldatetime,
	@Original_OrderDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_SelFlag bit,
	@Original_SelFlag bit,
	@OrderId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ORDERS] SET [OrderCode] = @OrderCode, [OrderDate] = @OrderDate, [Cust_Sup_Accid] = @Cust_Sup_Accid, [BranchId] = @BranchId, [InvType] = @InvType, [EmpId] = @EmpId, [Notes] = @Notes, [SUP_CUST_ID] = @SUP_CUST_ID, [SelFlag] = @SelFlag WHERE (([OrderId] = @Original_OrderId) AND ((@IsNull_OrderCode = 1 AND [OrderCode] IS NULL) OR ([OrderCode] = @Original_OrderCode)) AND ((@IsNull_OrderDate = 1 AND [OrderDate] IS NULL) OR ([OrderDate] = @Original_OrderDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_SelFlag = 1 AND [SelFlag] IS NULL) OR ([SelFlag] = @Original_SelFlag)));
	
SELECT OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID, SelFlag FROM ORDERS WHERE (OrderId = @OrderId)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_OrderDetailsSelectByOrderId
(
	@OrderId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Order_Product_Id, OrderId, ProductId, UnitId, Qty, Price, StoreId, VaildDate, PRODUCTBRAND
FROM         ORDERDETAILS
WHERE     (OrderId = @OrderId)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PENALTYDelete
(
	@Original_PEN_CODE numeric,
	@Original_PEN_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_PER_PENALTY] WHERE (([PEN_CODE] = @Original_PEN_CODE) AND ([PEN_DESC] = @Original_PEN_DESC))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PENALTYInsert
(
	@PEN_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_PENALTY] ([PEN_DESC]) VALUES (@PEN_DESC);
	
SELECT PEN_CODE, PEN_DESC FROM CDE_PER_PENALTY WHERE (PEN_CODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PENALTYSelect
AS
	SET NOCOUNT ON;
SELECT     PEN_CODE, PEN_DESC
FROM         CDE_PER_PENALTY







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PENALTYUpdate
(
	@PEN_DESC varchar(200),
	@Original_PEN_CODE numeric,
	@Original_PEN_DESC varchar(200),
	@PEN_CODE numeric
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PER_PENALTY] SET [PEN_DESC] = @PEN_DESC WHERE (([PEN_CODE] = @Original_PEN_CODE) AND ([PEN_DESC] = @Original_PEN_DESC));
	
SELECT PEN_CODE, PEN_DESC FROM CDE_PER_PENALTY WHERE (PEN_CODE = @PEN_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_AllowanceDelete
(
	@Original_AllowanceID int,
	@IsNull_EMP_CODE Int,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_AMOUNT Int,
	@Original_AMOUNT money,
	@IsNull_DISCOUNT_DATE Int,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_DES Int,
	@Original_DES varchar(500),
	@IsNull_PervMonthFlag Int,
	@Original_PervMonthFlag bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_Allowance] WHERE (([AllowanceID] = @Original_AllowanceID) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_DES = 1 AND [DES] IS NULL) OR ([DES] = @Original_DES)) AND ((@IsNull_PervMonthFlag = 1 AND [PervMonthFlag] IS NULL) OR ([PervMonthFlag] = @Original_PervMonthFlag)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_AllowanceInsert
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@AMOUNT money,
	@DISCOUNT_DATE smalldatetime,
	@DES varchar(500),
	@PervMonthFlag bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_Allowance] ([EMP_CODE], [YEAR_CODE], [MONTH_CODE], [AMOUNT], [DISCOUNT_DATE], [DES], [PervMonthFlag]) VALUES (@EMP_CODE, @YEAR_CODE, @MONTH_CODE, @AMOUNT, @DISCOUNT_DATE, @DES, @PervMonthFlag);
	
SELECT AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, PervMonthFlag FROM PER_EMP_Allowance WHERE (AllowanceID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_AllowanceSelect
AS
	SET NOCOUNT ON;
SELECT     AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, PervMonthFlag
FROM         PER_EMP_Allowance







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_AllowanceSelectByEmpId
@EmpCode as bigint
AS
	SET NOCOUNT ON;
SELECT     AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, PervMonthFlag
FROM         PER_EMP_Allowance
where EMP_CODE=@EMPCODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_AllowanceUpdate
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@AMOUNT money,
	@DISCOUNT_DATE smalldatetime,
	@DES varchar(500),
	@PervMonthFlag bit,
	@Original_AllowanceID int,
	@IsNull_EMP_CODE Int,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_AMOUNT Int,
	@Original_AMOUNT money,
	@IsNull_DISCOUNT_DATE Int,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_DES Int,
	@Original_DES varchar(500),
	@IsNull_PervMonthFlag Int,
	@Original_PervMonthFlag bit,
	@AllowanceID int
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_Allowance] SET [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [AMOUNT] = @AMOUNT, [DISCOUNT_DATE] = @DISCOUNT_DATE, [DES] = @DES, [PervMonthFlag] = @PervMonthFlag WHERE (([AllowanceID] = @Original_AllowanceID) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_DES = 1 AND [DES] IS NULL) OR ([DES] = @Original_DES)) AND ((@IsNull_PervMonthFlag = 1 AND [PervMonthFlag] IS NULL) OR ([PervMonthFlag] = @Original_PervMonthFlag)));
	
SELECT AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES, PervMonthFlag FROM PER_EMP_Allowance WHERE (AllowanceID = @AllowanceID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_RELATIVEDelete
(
	@Original_REL_CODE numeric,
	@Original_EMP_CODE bigint,
	@IsNull_REL_NAME Int,
	@Original_REL_NAME varchar(100),
	@IsNull_REL_BIRTHDATE Int,
	@Original_REL_BIRTHDATE smalldatetime,
	@IsNull_REL_PassEndDate Int,
	@Original_REL_PassEndDate smalldatetime,
	@IsNull_REL_ResidenceEndDate Int,
	@Original_REL_ResidenceEndDate smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_RELATIVE] WHERE (([REL_CODE] = @Original_REL_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_REL_NAME = 1 AND [REL_NAME] IS NULL) OR ([REL_NAME] = @Original_REL_NAME)) AND ((@IsNull_REL_BIRTHDATE = 1 AND [REL_BIRTHDATE] IS NULL) OR ([REL_BIRTHDATE] = @Original_REL_BIRTHDATE)) AND ((@IsNull_REL_PassEndDate = 1 AND [REL_PassEndDate] IS NULL) OR ([REL_PassEndDate] = @Original_REL_PassEndDate)) AND ((@IsNull_REL_ResidenceEndDate = 1 AND [REL_ResidenceEndDate] IS NULL) OR ([REL_ResidenceEndDate] = @Original_REL_ResidenceEndDate)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_RELATIVEInsert
(
	@EMP_CODE bigint,
	@REL_NAME varchar(100),
	@REL_BIRTHDATE smalldatetime,
	@REL_PassEndDate smalldatetime,
	@REL_ResidenceEndDate smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_RELATIVE] ([EMP_CODE], [REL_NAME], [REL_BIRTHDATE], [REL_PassEndDate], [REL_ResidenceEndDate]) VALUES (@EMP_CODE, @REL_NAME, @REL_BIRTHDATE, @REL_PassEndDate, @REL_ResidenceEndDate);
	
SELECT REL_CODE, EMP_CODE, REL_NAME, REL_BIRTHDATE, REL_PassEndDate, REL_ResidenceEndDate FROM PER_EMP_RELATIVE WHERE (REL_CODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_RELATIVESelect
AS
	SET NOCOUNT ON;
SELECT     REL_CODE, EMP_CODE, REL_NAME, REL_BIRTHDATE, REL_PassEndDate, REL_ResidenceEndDate
FROM         PER_EMP_RELATIVE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_RELATIVEUpdate
(
	@EMP_CODE bigint,
	@REL_NAME varchar(100),
	@REL_BIRTHDATE smalldatetime,
	@REL_PassEndDate smalldatetime,
	@REL_ResidenceEndDate smalldatetime,
	@Original_REL_CODE numeric,
	@Original_EMP_CODE bigint,
	@IsNull_REL_NAME Int,
	@Original_REL_NAME varchar(100),
	@IsNull_REL_BIRTHDATE Int,
	@Original_REL_BIRTHDATE smalldatetime,
	@IsNull_REL_PassEndDate Int,
	@Original_REL_PassEndDate smalldatetime,
	@IsNull_REL_ResidenceEndDate Int,
	@Original_REL_ResidenceEndDate smalldatetime,
	@REL_CODE numeric
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_RELATIVE] SET [EMP_CODE] = @EMP_CODE, [REL_NAME] = @REL_NAME, [REL_BIRTHDATE] = @REL_BIRTHDATE, [REL_PassEndDate] = @REL_PassEndDate, [REL_ResidenceEndDate] = @REL_ResidenceEndDate WHERE (([REL_CODE] = @Original_REL_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_REL_NAME = 1 AND [REL_NAME] IS NULL) OR ([REL_NAME] = @Original_REL_NAME)) AND ((@IsNull_REL_BIRTHDATE = 1 AND [REL_BIRTHDATE] IS NULL) OR ([REL_BIRTHDATE] = @Original_REL_BIRTHDATE)) AND ((@IsNull_REL_PassEndDate = 1 AND [REL_PassEndDate] IS NULL) OR ([REL_PassEndDate] = @Original_REL_PassEndDate)) AND ((@IsNull_REL_ResidenceEndDate = 1 AND [REL_ResidenceEndDate] IS NULL) OR ([REL_ResidenceEndDate] = @Original_REL_ResidenceEndDate)));
	
SELECT REL_CODE, EMP_CODE, REL_NAME, REL_BIRTHDATE, REL_PassEndDate, REL_ResidenceEndDate FROM PER_EMP_RELATIVE WHERE (REL_CODE = @REL_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PER_EMP_RELATIVEbyEmpCode
(
	@EMPCODE bigint
)
AS
	SET NOCOUNT ON;
SELECT     REL_CODE, EMP_CODE, REL_NAME, REL_BIRTHDATE, REL_PassEndDate, REL_ResidenceEndDate
FROM         PER_EMP_RELATIVE
WHERE     (EMP_CODE = @EMPCODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_ATTENDENCEDelete
(
	@Original_Id bigint,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_TotAbsenceDays numeric(2, 0),
	@Original_TotAbsenceDays numeric(2, 0),
	@IsNull_TotOverTime float,
	@Original_TotOverTime float,
	@IsNull_TotlateTime float,
	@Original_TotlateTime float,
	@IsNull_TotLateTimeAmount float,
	@Original_TotLateTimeAmount float,
	@IsNull_TotOverTimeAmount float,
	@Original_TotOverTimeAmount float,
	@IsNull_CommitFlag bit,
	@Original_CommitFlag bit,
	@IsNull_Note varchar(300),
	@Original_Note varchar(300)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRL_EMP_ATTENDENCE] WHERE (([Id] = @Original_Id) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_TotAbsenceDays = 1 AND [TotAbsenceDays] IS NULL) OR ([TotAbsenceDays] = @Original_TotAbsenceDays)) AND ((@IsNull_TotOverTime = 1 AND [TotOverTime] IS NULL) OR ([TotOverTime] = @Original_TotOverTime)) AND ((@IsNull_TotlateTime = 1 AND [TotlateTime] IS NULL) OR ([TotlateTime] = @Original_TotlateTime)) AND ((@IsNull_TotLateTimeAmount = 1 AND [TotLateTimeAmount] IS NULL) OR ([TotLateTimeAmount] = @Original_TotLateTimeAmount)) AND ((@IsNull_TotOverTimeAmount = 1 AND [TotOverTimeAmount] IS NULL) OR ([TotOverTimeAmount] = @Original_TotOverTimeAmount)) AND ((@IsNull_CommitFlag = 1 AND [CommitFlag] IS NULL) OR ([CommitFlag] = @Original_CommitFlag)) AND ((@IsNull_Note = 1 AND [Note] IS NULL) OR ([Note] = @Original_Note)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_ATTENDENCEInsert
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@TotAbsenceDays numeric(2, 0),
	@TotOverTime float,
	@TotlateTime float,
	@TotLateTimeAmount float,
	@TotOverTimeAmount float,
	@CommitFlag bit,
	@Note varchar(300)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRL_EMP_ATTENDENCE] ([EMP_CODE], [YEAR_CODE], [MONTH_CODE], [TotAbsenceDays], [TotOverTime], [TotlateTime], [TotLateTimeAmount], [TotOverTimeAmount], [CommitFlag], [Note]) VALUES (@EMP_CODE, @YEAR_CODE, @MONTH_CODE, @TotAbsenceDays, @TotOverTime, @TotlateTime, @TotLateTimeAmount, @TotOverTimeAmount, @CommitFlag, @Note);
	
SELECT Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, Note FROM PRL_EMP_ATTENDENCE WHERE (Id = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_ATTENDENCESelect
AS
	SET NOCOUNT ON;
SELECT     Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, 
                      Note
FROM         PRL_EMP_ATTENDENCE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_PRL_EMP_ATTENDENCESelectByMonth
(
	@Year_Code int,
	@MONTH_CODE int
)
AS
	SET NOCOUNT ON;
SELECT     Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, 
                      Note
FROM         PRL_EMP_ATTENDENCE
WHERE     (YEAR_CODE = @Year_Code) AND (MONTH_CODE = @MONTH_CODE)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_ATTENDENCEUpdate
(
	@EMP_CODE bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@TotAbsenceDays numeric(2, 0),
	@TotOverTime float,
	@TotlateTime float,
	@TotLateTimeAmount float,
	@TotOverTimeAmount float,
	@CommitFlag bit,
	@Note varchar(300),
	@Original_Id bigint,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_TotAbsenceDays numeric(2, 0),
	@Original_TotAbsenceDays numeric(2, 0),
	@IsNull_TotOverTime float,
	@Original_TotOverTime float,
	@IsNull_TotlateTime float,
	@Original_TotlateTime float,
	@IsNull_TotLateTimeAmount float,
	@Original_TotLateTimeAmount float,
	@IsNull_TotOverTimeAmount float,
	@Original_TotOverTimeAmount float,
	@IsNull_CommitFlag bit,
	@Original_CommitFlag bit,
	@IsNull_Note varchar(300),
	@Original_Note varchar(300),
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRL_EMP_ATTENDENCE] SET [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [TotAbsenceDays] = @TotAbsenceDays, [TotOverTime] = @TotOverTime, [TotlateTime] = @TotlateTime, [TotLateTimeAmount] = @TotLateTimeAmount, [TotOverTimeAmount] = @TotOverTimeAmount, [CommitFlag] = @CommitFlag, [Note] = @Note WHERE (([Id] = @Original_Id) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_TotAbsenceDays = 1 AND [TotAbsenceDays] IS NULL) OR ([TotAbsenceDays] = @Original_TotAbsenceDays)) AND ((@IsNull_TotOverTime = 1 AND [TotOverTime] IS NULL) OR ([TotOverTime] = @Original_TotOverTime)) AND ((@IsNull_TotlateTime = 1 AND [TotlateTime] IS NULL) OR ([TotlateTime] = @Original_TotlateTime)) AND ((@IsNull_TotLateTimeAmount = 1 AND [TotLateTimeAmount] IS NULL) OR ([TotLateTimeAmount] = @Original_TotLateTimeAmount)) AND ((@IsNull_TotOverTimeAmount = 1 AND [TotOverTimeAmount] IS NULL) OR ([TotOverTimeAmount] = @Original_TotOverTimeAmount)) AND ((@IsNull_CommitFlag = 1 AND [CommitFlag] IS NULL) OR ([CommitFlag] = @Original_CommitFlag)) AND ((@IsNull_Note = 1 AND [Note] IS NULL) OR ([Note] = @Original_Note)));
	
SELECT Id, EMP_CODE, YEAR_CODE, MONTH_CODE, TotAbsenceDays, TotOverTime, TotlateTime, TotLateTimeAmount, TotOverTimeAmount, CommitFlag, Note FROM PRL_EMP_ATTENDENCE WHERE (Id = @Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_SAL_CALCULATIONDelete
(
	@Original_CalID bigint,
	@Original_MONTH_CODE int,
	@Original_YEAR_CODE int,
	@Original_EMP_CODE bigint,
	@IsNull_BasicAmount money,
	@Original_BasicAmount money,
	@IsNull_DiscountAmount money,
	@Original_DiscountAmount money,
	@IsNull_AbseneceAmount money,
	@Original_AbseneceAmount money,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_AllowanceAmount money,
	@Original_AllowanceAmount money,
	@IsNull_VacationAmount money,
	@Original_VacationAmount money,
	@Original_CALCULATION_AMOUNT money,
	@IsNull_FullName varchar(200),
	@Original_FullName varchar(200),
	@IsNull_SalaryDate smalldatetime,
	@Original_SalaryDate smalldatetime,
	@IsNull_DEPTCODE bigint,
	@Original_DEPTCODE bigint,
	@IsNull_GetAllow money,
	@Original_GetAllow money,
	@IsNull_PhoneAllow money,
	@Original_PhoneAllow money,
	@IsNull_TransAllow money,
	@Original_TransAllow money,
	@IsNull_InsuranceValue money,
	@Original_InsuranceValue money,
	@IsNull_YearVacationNo numeric(18, 3),
	@Original_YearVacationNo numeric(18, 3),
	@IsNull_OtherVacationNo numeric(18, 3),
	@Original_OtherVacationNo numeric(18, 3),
	@IsNull_AllowanceAmountPervMonth money,
	@Original_AllowanceAmountPervMonth money,
	@IsNull_DiscountAmountPervMonth numeric(18, 0),
	@Original_DiscountAmountPervMonth numeric(18, 0),
	@IsNull_Notes varchar(300),
	@Original_Notes varchar(300),
	@IsNull_VacationNoRentNo decimal(18, 0),
	@Original_VacationNoRentNo decimal(18, 0)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRL_EMP_SAL_CALCULATION] WHERE (([CalID] = @Original_CalID) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_BasicAmount = 1 AND [BasicAmount] IS NULL) OR ([BasicAmount] = @Original_BasicAmount)) AND ((@IsNull_DiscountAmount = 1 AND [DiscountAmount] IS NULL) OR ([DiscountAmount] = @Original_DiscountAmount)) AND ((@IsNull_AbseneceAmount = 1 AND [AbseneceAmount] IS NULL) OR ([AbseneceAmount] = @Original_AbseneceAmount)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_AllowanceAmount = 1 AND [AllowanceAmount] IS NULL) OR ([AllowanceAmount] = @Original_AllowanceAmount)) AND ((@IsNull_VacationAmount = 1 AND [VacationAmount] IS NULL) OR ([VacationAmount] = @Original_VacationAmount)) AND ([CALCULATION_AMOUNT] = @Original_CALCULATION_AMOUNT) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_SalaryDate = 1 AND [SalaryDate] IS NULL) OR ([SalaryDate] = @Original_SalaryDate)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_GetAllow = 1 AND [GetAllow] IS NULL) OR ([GetAllow] = @Original_GetAllow)) AND ((@IsNull_PhoneAllow = 1 AND [PhoneAllow] IS NULL) OR ([PhoneAllow] = @Original_PhoneAllow)) AND ((@IsNull_TransAllow = 1 AND [TransAllow] IS NULL) OR ([TransAllow] = @Original_TransAllow)) AND ((@IsNull_InsuranceValue = 1 AND [InsuranceValue] IS NULL) OR ([InsuranceValue] = @Original_InsuranceValue)) AND ((@IsNull_YearVacationNo = 1 AND [YearVacationNo] IS NULL) OR ([YearVacationNo] = @Original_YearVacationNo)) AND ((@IsNull_OtherVacationNo = 1 AND [OtherVacationNo] IS NULL) OR ([OtherVacationNo] = @Original_OtherVacationNo)) AND ((@IsNull_AllowanceAmountPervMonth = 1 AND [AllowanceAmountPervMonth] IS NULL) OR ([AllowanceAmountPervMonth] = @Original_AllowanceAmountPervMonth)) AND ((@IsNull_DiscountAmountPervMonth = 1 AND [DiscountAmountPervMonth] IS NULL) OR ([DiscountAmountPervMonth] = @Original_DiscountAmountPervMonth)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_VacationNoRentNo = 1 AND [VacationNoRentNo] IS NULL) OR ([VacationNoRentNo] = @Original_VacationNoRentNo)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_SAL_CALCULATIONInsert
(
	@MONTH_CODE int,
	@YEAR_CODE int,
	@EMP_CODE bigint,
	@BasicAmount money,
	@DiscountAmount money,
	@AbseneceAmount money,
	@LoanAmount money,
	@AllowanceAmount money,
	@VacationAmount money,
	@CALCULATION_AMOUNT money,
	@FullName varchar(200),
	@SalaryDate smalldatetime,
	@DEPTCODE bigint,
	@GetAllow money,
	@PhoneAllow money,
	@TransAllow money,
	@InsuranceValue money,
	@YearVacationNo numeric(18, 3),
	@OtherVacationNo numeric(18, 3),
	@AllowanceAmountPervMonth money,
	@DiscountAmountPervMonth numeric(18, 0),
	@Notes varchar(300),
	@VacationNoRentNo decimal(18, 0)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRL_EMP_SAL_CALCULATION] ([MONTH_CODE], [YEAR_CODE], [EMP_CODE], [BasicAmount], [DiscountAmount], [AbseneceAmount], [LoanAmount], [AllowanceAmount], [VacationAmount], [CALCULATION_AMOUNT], [FullName], [SalaryDate], [DEPTCODE], [GetAllow], [PhoneAllow], [TransAllow], [InsuranceValue], [YearVacationNo], [OtherVacationNo], [AllowanceAmountPervMonth], [DiscountAmountPervMonth], [Notes], [VacationNoRentNo]) VALUES (@MONTH_CODE, @YEAR_CODE, @EMP_CODE, @BasicAmount, @DiscountAmount, @AbseneceAmount, @LoanAmount, @AllowanceAmount, @VacationAmount, @CALCULATION_AMOUNT, @FullName, @SalaryDate, @DEPTCODE, @GetAllow, @PhoneAllow, @TransAllow, @InsuranceValue, @YearVacationNo, @OtherVacationNo, @AllowanceAmountPervMonth, @DiscountAmountPervMonth, @Notes, @VacationNoRentNo);
	
SELECT CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, VacationAmount, CALCULATION_AMOUNT, FullName, SalaryDate, DEPTCODE, GetAllow, PhoneAllow, TransAllow, InsuranceValue, YearVacationNo, OtherVacationNo, AllowanceAmountPervMonth, DiscountAmountPervMonth, Notes, VacationNoRentNo FROM PRL_EMP_SAL_CALCULATION WHERE (CalID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_SAL_CALCULATIONSelect
AS
	SET NOCOUNT ON;
SELECT     CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, VacationAmount, 
                      CALCULATION_AMOUNT, FullName, SalaryDate, DEPTCODE, GetAllow, PhoneAllow, TransAllow, InsuranceValue, YearVacationNo, OtherVacationNo, 
                      AllowanceAmountPervMonth, DiscountAmountPervMonth, Notes, VacationNoRentNo
FROM         PRL_EMP_SAL_CALCULATION







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_SAL_CALCULATIONSelectByParam
@EMP_CODE bigint ,
@DEPTCODE bigint ,
@Month int,
@year  int
AS
	SET NOCOUNT ON;
SELECT     CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, VacationAmount, 
                      CALCULATION_AMOUNT, FullName, SalaryDate, DEPTCODE, GetAllow, PhoneAllow, TransAllow, InsuranceValue, YearVacationNo, OtherVacationNo, 
                      AllowanceAmountPervMonth, DiscountAmountPervMonth, Notes, VacationNoRentNo
FROM         PRL_EMP_SAL_CALCULATION

where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and (MONTH_CODE =@month) and  ( YEAR_CODE=@year)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRL_EMP_SAL_CALCULATIONUpdate
(
	@MONTH_CODE int,
	@YEAR_CODE int,
	@EMP_CODE bigint,
	@BasicAmount money,
	@DiscountAmount money,
	@AbseneceAmount money,
	@LoanAmount money,
	@AllowanceAmount money,
	@VacationAmount money,
	@CALCULATION_AMOUNT money,
	@FullName varchar(200),
	@SalaryDate smalldatetime,
	@DEPTCODE bigint,
	@GetAllow money,
	@PhoneAllow money,
	@TransAllow money,
	@InsuranceValue money,
	@YearVacationNo numeric(18, 3),
	@OtherVacationNo numeric(18, 3),
	@AllowanceAmountPervMonth money,
	@DiscountAmountPervMonth numeric(18, 0),
	@Notes varchar(300),
	@VacationNoRentNo decimal(18, 0),
	@Original_CalID bigint,
	@Original_MONTH_CODE int,
	@Original_YEAR_CODE int,
	@Original_EMP_CODE bigint,
	@IsNull_BasicAmount money,
	@Original_BasicAmount money,
	@IsNull_DiscountAmount money,
	@Original_DiscountAmount money,
	@IsNull_AbseneceAmount money,
	@Original_AbseneceAmount money,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_AllowanceAmount money,
	@Original_AllowanceAmount money,
	@IsNull_VacationAmount money,
	@Original_VacationAmount money,
	@Original_CALCULATION_AMOUNT money,
	@IsNull_FullName varchar(200),
	@Original_FullName varchar(200),
	@IsNull_SalaryDate smalldatetime,
	@Original_SalaryDate smalldatetime,
	@IsNull_DEPTCODE bigint,
	@Original_DEPTCODE bigint,
	@IsNull_GetAllow money,
	@Original_GetAllow money,
	@IsNull_PhoneAllow money,
	@Original_PhoneAllow money,
	@IsNull_TransAllow money,
	@Original_TransAllow money,
	@IsNull_InsuranceValue money,
	@Original_InsuranceValue money,
	@IsNull_YearVacationNo numeric(18, 3),
	@Original_YearVacationNo numeric(18, 3),
	@IsNull_OtherVacationNo numeric(18, 3),
	@Original_OtherVacationNo numeric(18, 3),
	@IsNull_AllowanceAmountPervMonth money,
	@Original_AllowanceAmountPervMonth money,
	@IsNull_DiscountAmountPervMonth numeric(18, 0),
	@Original_DiscountAmountPervMonth numeric(18, 0),
	@IsNull_Notes varchar(300),
	@Original_Notes varchar(300),
	@IsNull_VacationNoRentNo decimal(18, 0),
	@Original_VacationNoRentNo decimal(18, 0),
	@CalID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRL_EMP_SAL_CALCULATION] SET [MONTH_CODE] = @MONTH_CODE, [YEAR_CODE] = @YEAR_CODE, [EMP_CODE] = @EMP_CODE, [BasicAmount] = @BasicAmount, [DiscountAmount] = @DiscountAmount, [AbseneceAmount] = @AbseneceAmount, [LoanAmount] = @LoanAmount, [AllowanceAmount] = @AllowanceAmount, [VacationAmount] = @VacationAmount, [CALCULATION_AMOUNT] = @CALCULATION_AMOUNT, [FullName] = @FullName, [SalaryDate] = @SalaryDate, [DEPTCODE] = @DEPTCODE, [GetAllow] = @GetAllow, [PhoneAllow] = @PhoneAllow, [TransAllow] = @TransAllow, [InsuranceValue] = @InsuranceValue, [YearVacationNo] = @YearVacationNo, [OtherVacationNo] = @OtherVacationNo, [AllowanceAmountPervMonth] = @AllowanceAmountPervMonth, [DiscountAmountPervMonth] = @DiscountAmountPervMonth, [Notes] = @Notes, [VacationNoRentNo] = @VacationNoRentNo WHERE (([CalID] = @Original_CalID) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_BasicAmount = 1 AND [BasicAmount] IS NULL) OR ([BasicAmount] = @Original_BasicAmount)) AND ((@IsNull_DiscountAmount = 1 AND [DiscountAmount] IS NULL) OR ([DiscountAmount] = @Original_DiscountAmount)) AND ((@IsNull_AbseneceAmount = 1 AND [AbseneceAmount] IS NULL) OR ([AbseneceAmount] = @Original_AbseneceAmount)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_AllowanceAmount = 1 AND [AllowanceAmount] IS NULL) OR ([AllowanceAmount] = @Original_AllowanceAmount)) AND ((@IsNull_VacationAmount = 1 AND [VacationAmount] IS NULL) OR ([VacationAmount] = @Original_VacationAmount)) AND ([CALCULATION_AMOUNT] = @Original_CALCULATION_AMOUNT) AND ((@IsNull_FullName = 1 AND [FullName] IS NULL) OR ([FullName] = @Original_FullName)) AND ((@IsNull_SalaryDate = 1 AND [SalaryDate] IS NULL) OR ([SalaryDate] = @Original_SalaryDate)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_GetAllow = 1 AND [GetAllow] IS NULL) OR ([GetAllow] = @Original_GetAllow)) AND ((@IsNull_PhoneAllow = 1 AND [PhoneAllow] IS NULL) OR ([PhoneAllow] = @Original_PhoneAllow)) AND ((@IsNull_TransAllow = 1 AND [TransAllow] IS NULL) OR ([TransAllow] = @Original_TransAllow)) AND ((@IsNull_InsuranceValue = 1 AND [InsuranceValue] IS NULL) OR ([InsuranceValue] = @Original_InsuranceValue)) AND ((@IsNull_YearVacationNo = 1 AND [YearVacationNo] IS NULL) OR ([YearVacationNo] = @Original_YearVacationNo)) AND ((@IsNull_OtherVacationNo = 1 AND [OtherVacationNo] IS NULL) OR ([OtherVacationNo] = @Original_OtherVacationNo)) AND ((@IsNull_AllowanceAmountPervMonth = 1 AND [AllowanceAmountPervMonth] IS NULL) OR ([AllowanceAmountPervMonth] = @Original_AllowanceAmountPervMonth)) AND ((@IsNull_DiscountAmountPervMonth = 1 AND [DiscountAmountPervMonth] IS NULL) OR ([DiscountAmountPervMonth] = @Original_DiscountAmountPervMonth)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_VacationNoRentNo = 1 AND [VacationNoRentNo] IS NULL) OR ([VacationNoRentNo] = @Original_VacationNoRentNo)));
	
SELECT CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, VacationAmount, CALCULATION_AMOUNT, FullName, SalaryDate, DEPTCODE, GetAllow, PhoneAllow, TransAllow, InsuranceValue, YearVacationNo, OtherVacationNo, AllowanceAmountPervMonth, DiscountAmountPervMonth, Notes, VacationNoRentNo FROM PRL_EMP_SAL_CALCULATION WHERE (CalID = @CalID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTDelete
(
	@Original_PRODUCTID bigint,
	@Original_productname nvarchar(150),
	@IsNull_EnglishName Int,
	@Original_EnglishName nvarchar(50),
	@Original_PRODUCTCODE nvarchar(50),
	@IsNull_ParentProductId Int,
	@Original_ParentProductId bigint,
	@IsNull_Root Int,
	@Original_Root bit,
	@IsNull_ProcessFlag Int,
	@Original_ProcessFlag bit,
	@IsNull_MainNode Int,
	@Original_MainNode bit,
	@IsNull_Level Int,
	@Original_Level int,
	@IsNull_ProductTypeID Int,
	@Original_ProductTypeID bigint,
	@IsNull_SERIALNO Int,
	@Original_SERIALNO nvarchar(20),
	@IsNull_SUPPLIERID Int,
	@Original_SUPPLIERID bigint,
	@IsNull_CATEGORYID Int,
	@Original_CATEGORYID int,
	@IsNull_PWeight Int,
	@Original_PWeight nvarchar(50),
	@IsNull_PSize Int,
	@Original_PSize nvarchar(50),
	@IsNull_PColor Int,
	@Original_PColor nvarchar(50),
	@IsNull_PVolume Int,
	@Original_PVolume nvarchar(50),
	@IsNull_PriceRule Int,
	@Original_PriceRule nvarchar(30),
	@IsNull_PriceFromDate Int,
	@Original_PriceFromDate smalldatetime,
	@IsNull_PriceToDate Int,
	@Original_PriceToDate smalldatetime,
	@IsNull_OfferTypeID Int,
	@Original_OfferTypeID int,
	@IsNull_OfferFromDate Int,
	@Original_OfferFromDate smalldatetime,
	@IsNull_OfferToDate Int,
	@Original_OfferToDate smalldatetime,
	@IsNull_OfferProductId Int,
	@Original_OfferProductId bigint,
	@IsNull_OfferUnit Int,
	@Original_OfferUnit int,
	@IsNull_UNITPRICECOST Int,
	@Original_UNITPRICECOST money,
	@IsNull_UNITPRICESALES Int,
	@Original_UNITPRICESALES money,
	@IsNull_BUYDATE Int,
	@Original_BUYDATE smalldatetime,
	@IsNull_DISCONTINUED Int,
	@Original_DISCONTINUED bit,
	@IsNull_REORDERLEVEL Int,
	@Original_REORDERLEVEL smallint,
	@IsNull_STOCKNO Int,
	@Original_STOCKNO bigint,
	@IsNull_SHAPE Int,
	@Original_SHAPE nvarchar(10),
	@IsNull_QUANTITYPERUNIT Int,
	@Original_QUANTITYPERUNIT real,
	@IsNull_complexproduct Int,
	@Original_complexproduct bit,
	@IsNull_UNITSINSTOCK Int,
	@Original_UNITSINSTOCK float,
	@IsNull_ACCOUNTID Int,
	@Original_ACCOUNTID int,
	@IsNull_QUANTITYINUNIT Int,
	@Original_QUANTITYINUNIT float,
	@IsNull_initialsmallquantity Int,
	@Original_initialsmallquantity float,
	@IsNull_initiallargequantity Int,
	@Original_initiallargequantity float,
	@IsNull_serviceproduct Int,
	@Original_serviceproduct bit,
	@IsNull_forcurrency Int,
	@Original_forcurrency money,
	@IsNull_shape2 Int,
	@Original_shape2 nvarchar(20),
	@IsNull_SerialCode Int,
	@Original_SerialCode bigint,
	@IsNull_THRESHOLDINSTOCK Int,
	@Original_THRESHOLDINSTOCK numeric(5, 0),
	@IsNull_VALIDITY Int,
	@Original_VALIDITY smalldatetime,
	@IsNull_RECEIVERID Int,
	@Original_RECEIVERID int,
	@IsNull_minprice Int,
	@Original_minprice money,
	@IsNull_initialprice Int,
	@Original_initialprice money,
	@IsNull_profit Int,
	@Original_profit real
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRODUCTS] WHERE (([PRODUCTID] = @Original_PRODUCTID) AND ([productname] = @Original_productname) AND ((@IsNull_EnglishName = 1 AND [EnglishName] IS NULL) OR ([EnglishName] = @Original_EnglishName)) AND ([PRODUCTCODE] = @Original_PRODUCTCODE) AND ((@IsNull_ParentProductId = 1 AND [ParentProductId] IS NULL) OR ([ParentProductId] = @Original_ParentProductId)) AND ((@IsNull_Root = 1 AND [Root] IS NULL) OR ([Root] = @Original_Root)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_Level = 1 AND [Level] IS NULL) OR ([Level] = @Original_Level)) AND ((@IsNull_ProductTypeID = 1 AND [ProductTypeID] IS NULL) OR ([ProductTypeID] = @Original_ProductTypeID)) AND ((@IsNull_SERIALNO = 1 AND [SERIALNO] IS NULL) OR ([SERIALNO] = @Original_SERIALNO)) AND ((@IsNull_SUPPLIERID = 1 AND [SUPPLIERID] IS NULL) OR ([SUPPLIERID] = @Original_SUPPLIERID)) AND ((@IsNull_CATEGORYID = 1 AND [CATEGORYID] IS NULL) OR ([CATEGORYID] = @Original_CATEGORYID)) AND ((@IsNull_PWeight = 1 AND [PWeight] IS NULL) OR ([PWeight] = @Original_PWeight)) AND ((@IsNull_PSize = 1 AND [PSize] IS NULL) OR ([PSize] = @Original_PSize)) AND ((@IsNull_PColor = 1 AND [PColor] IS NULL) OR ([PColor] = @Original_PColor)) AND ((@IsNull_PVolume = 1 AND [PVolume] IS NULL) OR ([PVolume] = @Original_PVolume)) AND ((@IsNull_PriceRule = 1 AND [PriceRule] IS NULL) OR ([PriceRule] = @Original_PriceRule)) AND ((@IsNull_PriceFromDate = 1 AND [PriceFromDate] IS NULL) OR ([PriceFromDate] = @Original_PriceFromDate)) AND ((@IsNull_PriceToDate = 1 AND [PriceToDate] IS NULL) OR ([PriceToDate] = @Original_PriceToDate)) AND ((@IsNull_OfferTypeID = 1 AND [OfferTypeID] IS NULL) OR ([OfferTypeID] = @Original_OfferTypeID)) AND ((@IsNull_OfferFromDate = 1 AND [OfferFromDate] IS NULL) OR ([OfferFromDate] = @Original_OfferFromDate)) AND ((@IsNull_OfferToDate = 1 AND [OfferToDate] IS NULL) OR ([OfferToDate] = @Original_OfferToDate)) AND ((@IsNull_OfferProductId = 1 AND [OfferProductId] IS NULL) OR ([OfferProductId] = @Original_OfferProductId)) AND ((@IsNull_OfferUnit = 1 AND [OfferUnit] IS NULL) OR ([OfferUnit] = @Original_OfferUnit)) AND ((@IsNull_UNITPRICECOST = 1 AND [UNITPRICECOST] IS NULL) OR ([UNITPRICECOST] = @Original_UNITPRICECOST)) AND ((@IsNull_UNITPRICESALES = 1 AND [UNITPRICESALES] IS NULL) OR ([UNITPRICESALES] = @Original_UNITPRICESALES)) AND ((@IsNull_BUYDATE = 1 AND [BUYDATE] IS NULL) OR ([BUYDATE] = @Original_BUYDATE)) AND ((@IsNull_DISCONTINUED = 1 AND [DISCONTINUED] IS NULL) OR ([DISCONTINUED] = @Original_DISCONTINUED)) AND ((@IsNull_REORDERLEVEL = 1 AND [REORDERLEVEL] IS NULL) OR ([REORDERLEVEL] = @Original_REORDERLEVEL)) AND ((@IsNull_STOCKNO = 1 AND [STOCKNO] IS NULL) OR ([STOCKNO] = @Original_STOCKNO)) AND ((@IsNull_SHAPE = 1 AND [SHAPE] IS NULL) OR ([SHAPE] = @Original_SHAPE)) AND ((@IsNull_QUANTITYPERUNIT = 1 AND [QUANTITYPERUNIT] IS NULL) OR ([QUANTITYPERUNIT] = @Original_QUANTITYPERUNIT)) AND ((@IsNull_complexproduct = 1 AND [complexproduct] IS NULL) OR ([complexproduct] = @Original_complexproduct)) AND ((@IsNull_UNITSINSTOCK = 1 AND [UNITSINSTOCK] IS NULL) OR ([UNITSINSTOCK] = @Original_UNITSINSTOCK)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_QUANTITYINUNIT = 1 AND [QUANTITYINUNIT] IS NULL) OR ([QUANTITYINUNIT] = @Original_QUANTITYINUNIT)) AND ((@IsNull_initialsmallquantity = 1 AND [initialsmallquantity] IS NULL) OR ([initialsmallquantity] = @Original_initialsmallquantity)) AND ((@IsNull_initiallargequantity = 1 AND [initiallargequantity] IS NULL) OR ([initiallargequantity] = @Original_initiallargequantity)) AND ((@IsNull_serviceproduct = 1 AND [serviceproduct] IS NULL) OR ([serviceproduct] = @Original_serviceproduct)) AND ((@IsNull_forcurrency = 1 AND [forcurrency] IS NULL) OR ([forcurrency] = @Original_forcurrency)) AND ((@IsNull_shape2 = 1 AND [shape2] IS NULL) OR ([shape2] = @Original_shape2)) AND ((@IsNull_SerialCode = 1 AND [SerialCode] IS NULL) OR ([SerialCode] = @Original_SerialCode)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_minprice = 1 AND [minprice] IS NULL) OR ([minprice] = @Original_minprice)) AND ((@IsNull_initialprice = 1 AND [initialprice] IS NULL) OR ([initialprice] = @Original_initialprice)) AND ((@IsNull_profit = 1 AND [profit] IS NULL) OR ([profit] = @Original_profit)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTInsert
(
	@productname nvarchar(150),
	@EnglishName nvarchar(50),
	@PRODUCTCODE nvarchar(50),
	@ParentProductId bigint,
	@Root bit,
	@ProcessFlag bit,
	@MainNode bit,
	@Level int,
	@ProductTypeID bigint,
	@SERIALNO nvarchar(20),
	@SUPPLIERID bigint,
	@CATEGORYID int,
	@PWeight nvarchar(50),
	@PSize nvarchar(50),
	@PColor nvarchar(50),
	@PVolume nvarchar(50),
	@picpath image,
	@PDesc ntext,
	@PriceRule nvarchar(30),
	@PriceFromDate smalldatetime,
	@PriceToDate smalldatetime,
	@OfferTypeID int,
	@OfferFromDate smalldatetime,
	@OfferToDate smalldatetime,
	@OfferProductId bigint,
	@OfferUnit int,
	@UNITPRICECOST money,
	@UNITPRICESALES money,
	@BUYDATE smalldatetime,
	@DISCONTINUED bit,
	@REORDERLEVEL smallint,
	@STOCKNO bigint,
	@SHAPE nvarchar(10),
	@QUANTITYPERUNIT real,
	@complexproduct bit,
	@UNITSINSTOCK float,
	@ACCOUNTID int,
	@QUANTITYINUNIT float,
	@initialsmallquantity float,
	@initiallargequantity float,
	@serviceproduct bit,
	@forcurrency money,
	@shape2 nvarchar(20),
	@SerialCode bigint,
	@THRESHOLDINSTOCK numeric(5, 0),
	@VALIDITY smalldatetime,
	@RECEIVERID int,
	@minprice money,
	@initialprice money,
	@profit real
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRODUCTS] ([productname], [EnglishName], [PRODUCTCODE], [ParentProductId], [Root], [ProcessFlag], [MainNode], [Level], [ProductTypeID], [SERIALNO], [SUPPLIERID], [CATEGORYID], [PWeight], [PSize], [PColor], [PVolume], [picpath], [PDesc], [PriceRule], [PriceFromDate], [PriceToDate], [OfferTypeID], [OfferFromDate], [OfferToDate], [OfferProductId], [OfferUnit], [UNITPRICECOST], [UNITPRICESALES], [BUYDATE], [DISCONTINUED], [REORDERLEVEL], [STOCKNO], [SHAPE], [QUANTITYPERUNIT], [complexproduct], [UNITSINSTOCK], [ACCOUNTID], [QUANTITYINUNIT], [initialsmallquantity], [initiallargequantity], [serviceproduct], [forcurrency], [shape2], [SerialCode], [THRESHOLDINSTOCK], [VALIDITY], [RECEIVERID], [minprice], [initialprice], [profit]) VALUES (@productname, @EnglishName, @PRODUCTCODE, @ParentProductId, @Root, @ProcessFlag, @MainNode, @Level, @ProductTypeID, @SERIALNO, @SUPPLIERID, @CATEGORYID, @PWeight, @PSize, @PColor, @PVolume, @picpath, @PDesc, @PriceRule, @PriceFromDate, @PriceToDate, @OfferTypeID, @OfferFromDate, @OfferToDate, @OfferProductId, @OfferUnit, @UNITPRICECOST, @UNITPRICESALES, @BUYDATE, @DISCONTINUED, @REORDERLEVEL, @STOCKNO, @SHAPE, @QUANTITYPERUNIT, @complexproduct, @UNITSINSTOCK, @ACCOUNTID, @QUANTITYINUNIT, @initialsmallquantity, @initiallargequantity, @serviceproduct, @forcurrency, @shape2, @SerialCode, @THRESHOLDINSTOCK, @VALIDITY, @RECEIVERID, @minprice, @initialprice, @profit);
	
SELECT PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProcessFlag, MainNode, [Level], ProductTypeID, SERIALNO, SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, DISCONTINUED, REORDERLEVEL, STOCKNO, SHAPE, QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initiallargequantity, serviceproduct, forcurrency, shape2, SerialCode, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, minprice, initialprice, profit FROM PRODUCTS WHERE (PRODUCTID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTSelect
AS
	SET NOCOUNT ON;
SELECT     PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProcessFlag, MainNode, [Level], ProductTypeID, SERIALNO, 
                      SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, 
                      OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, DISCONTINUED, REORDERLEVEL, STOCKNO, SHAPE, 
                      QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initiallargequantity, serviceproduct, 
                      forcurrency, shape2, SerialCode, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, minprice, initialprice, profit
FROM         PRODUCTS







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTSelectMainNode
AS
	SET NOCOUNT ON;
SELECT     PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProcessFlag, MainNode, [Level], ProductTypeID, SERIALNO, 
                      SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, 
                      OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, DISCONTINUED, REORDERLEVEL, STOCKNO, SHAPE, 
                      QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initiallargequantity, serviceproduct, 
                      forcurrency, shape2, SerialCode, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, minprice, initialprice, profit
FROM         PRODUCTS
WHERE     (MainNode = 1)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTSelectNumofChild
(
	@PRODUCTID bigint
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS ProductsCount
FROM         PRODUCTS
WHERE     (ParentProductId = @PRODUCTID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_PRODUCTUpdate
(
	@productname nvarchar(150),
	@EnglishName nvarchar(50),
	@PRODUCTCODE nvarchar(50),
	@ParentProductId bigint,
	@Root bit,
	@ProcessFlag bit,
	@MainNode bit,
	@Level int,
	@ProductTypeID bigint,
	@SERIALNO nvarchar(20),
	@SUPPLIERID bigint,
	@CATEGORYID int,
	@PWeight nvarchar(50),
	@PSize nvarchar(50),
	@PColor nvarchar(50),
	@PVolume nvarchar(50),
	@picpath image,
	@PDesc ntext,
	@PriceRule nvarchar(30),
	@PriceFromDate smalldatetime,
	@PriceToDate smalldatetime,
	@OfferTypeID int,
	@OfferFromDate smalldatetime,
	@OfferToDate smalldatetime,
	@OfferProductId bigint,
	@OfferUnit int,
	@UNITPRICECOST money,
	@UNITPRICESALES money,
	@BUYDATE smalldatetime,
	@DISCONTINUED bit,
	@REORDERLEVEL smallint,
	@STOCKNO bigint,
	@SHAPE nvarchar(10),
	@QUANTITYPERUNIT real,
	@complexproduct bit,
	@UNITSINSTOCK float,
	@ACCOUNTID int,
	@QUANTITYINUNIT float,
	@initialsmallquantity float,
	@initiallargequantity float,
	@serviceproduct bit,
	@forcurrency money,
	@shape2 nvarchar(20),
	@SerialCode bigint,
	@THRESHOLDINSTOCK numeric(5, 0),
	@VALIDITY smalldatetime,
	@RECEIVERID int,
	@minprice money,
	@initialprice money,
	@profit real,
	@Original_PRODUCTID bigint,
	@Original_productname nvarchar(150),
	@IsNull_EnglishName Int,
	@Original_EnglishName nvarchar(50),
	@Original_PRODUCTCODE nvarchar(50),
	@IsNull_ParentProductId Int,
	@Original_ParentProductId bigint,
	@IsNull_Root Int,
	@Original_Root bit,
	@IsNull_ProcessFlag Int,
	@Original_ProcessFlag bit,
	@IsNull_MainNode Int,
	@Original_MainNode bit,
	@IsNull_Level Int,
	@Original_Level int,
	@IsNull_ProductTypeID Int,
	@Original_ProductTypeID bigint,
	@IsNull_SERIALNO Int,
	@Original_SERIALNO nvarchar(20),
	@IsNull_SUPPLIERID Int,
	@Original_SUPPLIERID bigint,
	@IsNull_CATEGORYID Int,
	@Original_CATEGORYID int,
	@IsNull_PWeight Int,
	@Original_PWeight nvarchar(50),
	@IsNull_PSize Int,
	@Original_PSize nvarchar(50),
	@IsNull_PColor Int,
	@Original_PColor nvarchar(50),
	@IsNull_PVolume Int,
	@Original_PVolume nvarchar(50),
	@IsNull_PriceRule Int,
	@Original_PriceRule nvarchar(30),
	@IsNull_PriceFromDate Int,
	@Original_PriceFromDate smalldatetime,
	@IsNull_PriceToDate Int,
	@Original_PriceToDate smalldatetime,
	@IsNull_OfferTypeID Int,
	@Original_OfferTypeID int,
	@IsNull_OfferFromDate Int,
	@Original_OfferFromDate smalldatetime,
	@IsNull_OfferToDate Int,
	@Original_OfferToDate smalldatetime,
	@IsNull_OfferProductId Int,
	@Original_OfferProductId bigint,
	@IsNull_OfferUnit Int,
	@Original_OfferUnit int,
	@IsNull_UNITPRICECOST Int,
	@Original_UNITPRICECOST money,
	@IsNull_UNITPRICESALES Int,
	@Original_UNITPRICESALES money,
	@IsNull_BUYDATE Int,
	@Original_BUYDATE smalldatetime,
	@IsNull_DISCONTINUED Int,
	@Original_DISCONTINUED bit,
	@IsNull_REORDERLEVEL Int,
	@Original_REORDERLEVEL smallint,
	@IsNull_STOCKNO Int,
	@Original_STOCKNO bigint,
	@IsNull_SHAPE Int,
	@Original_SHAPE nvarchar(10),
	@IsNull_QUANTITYPERUNIT Int,
	@Original_QUANTITYPERUNIT real,
	@IsNull_complexproduct Int,
	@Original_complexproduct bit,
	@IsNull_UNITSINSTOCK Int,
	@Original_UNITSINSTOCK float,
	@IsNull_ACCOUNTID Int,
	@Original_ACCOUNTID int,
	@IsNull_QUANTITYINUNIT Int,
	@Original_QUANTITYINUNIT float,
	@IsNull_initialsmallquantity Int,
	@Original_initialsmallquantity float,
	@IsNull_initiallargequantity Int,
	@Original_initiallargequantity float,
	@IsNull_serviceproduct Int,
	@Original_serviceproduct bit,
	@IsNull_forcurrency Int,
	@Original_forcurrency money,
	@IsNull_shape2 Int,
	@Original_shape2 nvarchar(20),
	@IsNull_SerialCode Int,
	@Original_SerialCode bigint,
	@IsNull_THRESHOLDINSTOCK Int,
	@Original_THRESHOLDINSTOCK numeric(5, 0),
	@IsNull_VALIDITY Int,
	@Original_VALIDITY smalldatetime,
	@IsNull_RECEIVERID Int,
	@Original_RECEIVERID int,
	@IsNull_minprice Int,
	@Original_minprice money,
	@IsNull_initialprice Int,
	@Original_initialprice money,
	@IsNull_profit Int,
	@Original_profit real,
	@PRODUCTID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRODUCTS] SET [productname] = @productname, [EnglishName] = @EnglishName, [PRODUCTCODE] = @PRODUCTCODE, [ParentProductId] = @ParentProductId, [Root] = @Root, [ProcessFlag] = @ProcessFlag, [MainNode] = @MainNode, [Level] = @Level, [ProductTypeID] = @ProductTypeID, [SERIALNO] = @SERIALNO, [SUPPLIERID] = @SUPPLIERID, [CATEGORYID] = @CATEGORYID, [PWeight] = @PWeight, [PSize] = @PSize, [PColor] = @PColor, [PVolume] = @PVolume, [picpath] = @picpath, [PDesc] = @PDesc, [PriceRule] = @PriceRule, [PriceFromDate] = @PriceFromDate, [PriceToDate] = @PriceToDate, [OfferTypeID] = @OfferTypeID, [OfferFromDate] = @OfferFromDate, [OfferToDate] = @OfferToDate, [OfferProductId] = @OfferProductId, [OfferUnit] = @OfferUnit, [UNITPRICECOST] = @UNITPRICECOST, [UNITPRICESALES] = @UNITPRICESALES, [BUYDATE] = @BUYDATE, [DISCONTINUED] = @DISCONTINUED, [REORDERLEVEL] = @REORDERLEVEL, [STOCKNO] = @STOCKNO, [SHAPE] = @SHAPE, [QUANTITYPERUNIT] = @QUANTITYPERUNIT, [complexproduct] = @complexproduct, [UNITSINSTOCK] = @UNITSINSTOCK, [ACCOUNTID] = @ACCOUNTID, [QUANTITYINUNIT] = @QUANTITYINUNIT, [initialsmallquantity] = @initialsmallquantity, [initiallargequantity] = @initiallargequantity, [serviceproduct] = @serviceproduct, [forcurrency] = @forcurrency, [shape2] = @shape2, [SerialCode] = @SerialCode, [THRESHOLDINSTOCK] = @THRESHOLDINSTOCK, [VALIDITY] = @VALIDITY, [RECEIVERID] = @RECEIVERID, [minprice] = @minprice, [initialprice] = @initialprice, [profit] = @profit WHERE (([PRODUCTID] = @Original_PRODUCTID) AND ([productname] = @Original_productname) AND ((@IsNull_EnglishName = 1 AND [EnglishName] IS NULL) OR ([EnglishName] = @Original_EnglishName)) AND ([PRODUCTCODE] = @Original_PRODUCTCODE) AND ((@IsNull_ParentProductId = 1 AND [ParentProductId] IS NULL) OR ([ParentProductId] = @Original_ParentProductId)) AND ((@IsNull_Root = 1 AND [Root] IS NULL) OR ([Root] = @Original_Root)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_Level = 1 AND [Level] IS NULL) OR ([Level] = @Original_Level)) AND ((@IsNull_ProductTypeID = 1 AND [ProductTypeID] IS NULL) OR ([ProductTypeID] = @Original_ProductTypeID)) AND ((@IsNull_SERIALNO = 1 AND [SERIALNO] IS NULL) OR ([SERIALNO] = @Original_SERIALNO)) AND ((@IsNull_SUPPLIERID = 1 AND [SUPPLIERID] IS NULL) OR ([SUPPLIERID] = @Original_SUPPLIERID)) AND ((@IsNull_CATEGORYID = 1 AND [CATEGORYID] IS NULL) OR ([CATEGORYID] = @Original_CATEGORYID)) AND ((@IsNull_PWeight = 1 AND [PWeight] IS NULL) OR ([PWeight] = @Original_PWeight)) AND ((@IsNull_PSize = 1 AND [PSize] IS NULL) OR ([PSize] = @Original_PSize)) AND ((@IsNull_PColor = 1 AND [PColor] IS NULL) OR ([PColor] = @Original_PColor)) AND ((@IsNull_PVolume = 1 AND [PVolume] IS NULL) OR ([PVolume] = @Original_PVolume)) AND ((@IsNull_PriceRule = 1 AND [PriceRule] IS NULL) OR ([PriceRule] = @Original_PriceRule)) AND ((@IsNull_PriceFromDate = 1 AND [PriceFromDate] IS NULL) OR ([PriceFromDate] = @Original_PriceFromDate)) AND ((@IsNull_PriceToDate = 1 AND [PriceToDate] IS NULL) OR ([PriceToDate] = @Original_PriceToDate)) AND ((@IsNull_OfferTypeID = 1 AND [OfferTypeID] IS NULL) OR ([OfferTypeID] = @Original_OfferTypeID)) AND ((@IsNull_OfferFromDate = 1 AND [OfferFromDate] IS NULL) OR ([OfferFromDate] = @Original_OfferFromDate)) AND ((@IsNull_OfferToDate = 1 AND [OfferToDate] IS NULL) OR ([OfferToDate] = @Original_OfferToDate)) AND ((@IsNull_OfferProductId = 1 AND [OfferProductId] IS NULL) OR ([OfferProductId] = @Original_OfferProductId)) AND ((@IsNull_OfferUnit = 1 AND [OfferUnit] IS NULL) OR ([OfferUnit] = @Original_OfferUnit)) AND ((@IsNull_UNITPRICECOST = 1 AND [UNITPRICECOST] IS NULL) OR ([UNITPRICECOST] = @Original_UNITPRICECOST)) AND ((@IsNull_UNITPRICESALES = 1 AND [UNITPRICESALES] IS NULL) OR ([UNITPRICESALES] = @Original_UNITPRICESALES)) AND ((@IsNull_BUYDATE = 1 AND [BUYDATE] IS NULL) OR ([BUYDATE] = @Original_BUYDATE)) AND ((@IsNull_DISCONTINUED = 1 AND [DISCONTINUED] IS NULL) OR ([DISCONTINUED] = @Original_DISCONTINUED)) AND ((@IsNull_REORDERLEVEL = 1 AND [REORDERLEVEL] IS NULL) OR ([REORDERLEVEL] = @Original_REORDERLEVEL)) AND ((@IsNull_STOCKNO = 1 AND [STOCKNO] IS NULL) OR ([STOCKNO] = @Original_STOCKNO)) AND ((@IsNull_SHAPE = 1 AND [SHAPE] IS NULL) OR ([SHAPE] = @Original_SHAPE)) AND ((@IsNull_QUANTITYPERUNIT = 1 AND [QUANTITYPERUNIT] IS NULL) OR ([QUANTITYPERUNIT] = @Original_QUANTITYPERUNIT)) AND ((@IsNull_complexproduct = 1 AND [complexproduct] IS NULL) OR ([complexproduct] = @Original_complexproduct)) AND ((@IsNull_UNITSINSTOCK = 1 AND [UNITSINSTOCK] IS NULL) OR ([UNITSINSTOCK] = @Original_UNITSINSTOCK)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_QUANTITYINUNIT = 1 AND [QUANTITYINUNIT] IS NULL) OR ([QUANTITYINUNIT] = @Original_QUANTITYINUNIT)) AND ((@IsNull_initialsmallquantity = 1 AND [initialsmallquantity] IS NULL) OR ([initialsmallquantity] = @Original_initialsmallquantity)) AND ((@IsNull_initiallargequantity = 1 AND [initiallargequantity] IS NULL) OR ([initiallargequantity] = @Original_initiallargequantity)) AND ((@IsNull_serviceproduct = 1 AND [serviceproduct] IS NULL) OR ([serviceproduct] = @Original_serviceproduct)) AND ((@IsNull_forcurrency = 1 AND [forcurrency] IS NULL) OR ([forcurrency] = @Original_forcurrency)) AND ((@IsNull_shape2 = 1 AND [shape2] IS NULL) OR ([shape2] = @Original_shape2)) AND ((@IsNull_SerialCode = 1 AND [SerialCode] IS NULL) OR ([SerialCode] = @Original_SerialCode)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_minprice = 1 AND [minprice] IS NULL) OR ([minprice] = @Original_minprice)) AND ((@IsNull_initialprice = 1 AND [initialprice] IS NULL) OR ([initialprice] = @Original_initialprice)) AND ((@IsNull_profit = 1 AND [profit] IS NULL) OR ([profit] = @Original_profit)));
	
SELECT PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProcessFlag, MainNode, [Level], ProductTypeID, SERIALNO, SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, DISCONTINUED, REORDERLEVEL, STOCKNO, SHAPE, QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initiallargequantity, serviceproduct, forcurrency, shape2, SerialCode, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, minprice, initialprice, profit FROM PRODUCTS WHERE (PRODUCTID = @PRODUCTID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDelete
(
	@Original_Id bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_Qty float,
	@IsNull_STOREID Int,
	@Original_STOREID bigint,
	@IsNull_EnterDate Int,
	@Original_EnterDate smalldatetime,
	@IsNull_Notes Int,
	@Original_Notes varchar(250)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Partition] WHERE (([Id] = @Original_Id) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([Qty] = @Original_Qty) AND ((@IsNull_STOREID = 1 AND [STOREID] IS NULL) OR ([STOREID] = @Original_STOREID)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)))



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDetailsDelete
(
	@Original_Id bigint,
	@IsNull_PartId Int,
	@Original_PartId bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_Qty float,
	@IsNull_STOREID Int,
	@Original_STOREID bigint,
	@IsNull_EnterDate Int,
	@Original_EnterDate smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PartitionDetails] WHERE (([Id] = @Original_Id) AND ((@IsNull_PartId = 1 AND [PartId] IS NULL) OR ([PartId] = @Original_PartId)) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([Qty] = @Original_Qty) AND ((@IsNull_STOREID = 1 AND [STOREID] IS NULL) OR ([STOREID] = @Original_STOREID)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)))



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDetailsInsert
(
	@PartId bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@Qty float,
	@STOREID bigint,
	@EnterDate smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PartitionDetails] ([PartId], [PRODUCTID], [UnitID], [Qty], [STOREID], [EnterDate]) VALUES (@PartId, @PRODUCTID, @UnitID, @Qty, @STOREID, @EnterDate);
	
SELECT Id, PartId, PRODUCTID, UnitID, Qty, STOREID, EnterDate FROM PartitionDetails WHERE (Id = SCOPE_IDENTITY())



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDetailsSelect
AS
	SET NOCOUNT ON;
SELECT        Id, PartId, PRODUCTID, UnitID, Qty, STOREID, EnterDate
FROM            PartitionDetails



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDetailsSelectByPartId
(
	@PartID bigint
)
AS
	SET NOCOUNT ON;
SELECT        Id, PartId, PRODUCTID, UnitID, Qty, STOREID, EnterDate
FROM            PartitionDetails
WHERE        (PartId = @PartID)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionDetailsUpdate
(
	@PartId bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@Qty float,
	@STOREID bigint,
	@EnterDate smalldatetime,
	@Original_Id bigint,
	@IsNull_PartId Int,
	@Original_PartId bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_Qty float,
	@IsNull_STOREID Int,
	@Original_STOREID bigint,
	@IsNull_EnterDate Int,
	@Original_EnterDate smalldatetime,
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PartitionDetails] SET [PartId] = @PartId, [PRODUCTID] = @PRODUCTID, [UnitID] = @UnitID, [Qty] = @Qty, [STOREID] = @STOREID, [EnterDate] = @EnterDate WHERE (([Id] = @Original_Id) AND ((@IsNull_PartId = 1 AND [PartId] IS NULL) OR ([PartId] = @Original_PartId)) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([Qty] = @Original_Qty) AND ((@IsNull_STOREID = 1 AND [STOREID] IS NULL) OR ([STOREID] = @Original_STOREID)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)));
	
SELECT Id, PartId, PRODUCTID, UnitID, Qty, STOREID, EnterDate FROM PartitionDetails WHERE (Id = @Id)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionInsert
(
	@PRODUCTID bigint,
	@UnitID bigint,
	@Qty float,
	@STOREID bigint,
	@EnterDate smalldatetime,
	@Notes varchar(250)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Partition] ([PRODUCTID], [UnitID], [Qty], [STOREID], [EnterDate], [Notes]) VALUES (@PRODUCTID, @UnitID, @Qty, @STOREID, @EnterDate, @Notes);
	
SELECT Id, PRODUCTID, UnitID, Qty, STOREID, EnterDate, Notes FROM Partition WHERE (Id = SCOPE_IDENTITY())



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionSelect
AS
	SET NOCOUNT ON;
SELECT        Id, PRODUCTID, UnitID, Qty, STOREID, EnterDate, Notes
FROM            Partition



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionSelectById
(
	@Id bigint
)
AS
	SET NOCOUNT ON;
SELECT        Id, PRODUCTID, UnitID, Qty, STOREID, EnterDate, Notes
FROM            Partition
WHERE        (Id = @Id)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_PartitionUpdate
(
	@PRODUCTID bigint,
	@UnitID bigint,
	@Qty float,
	@STOREID bigint,
	@EnterDate smalldatetime,
	@Notes varchar(250),
	@Original_Id bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_Qty float,
	@IsNull_STOREID Int,
	@Original_STOREID bigint,
	@IsNull_EnterDate Int,
	@Original_EnterDate smalldatetime,
	@IsNull_Notes Int,
	@Original_Notes varchar(250),
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Partition] SET [PRODUCTID] = @PRODUCTID, [UnitID] = @UnitID, [Qty] = @Qty, [STOREID] = @STOREID, [EnterDate] = @EnterDate, [Notes] = @Notes WHERE (([Id] = @Original_Id) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([Qty] = @Original_Qty) AND ((@IsNull_STOREID = 1 AND [STOREID] IS NULL) OR ([STOREID] = @Original_STOREID)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)));
	
SELECT Id, PRODUCTID, UnitID, Qty, STOREID, EnterDate, Notes FROM Partition WHERE (Id = @Id)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_PerEmpLoanDetailsReportDelete
(
	@Original_LoanDetID bigint,
	@IsNull_YEAR_CODE int,
	@Original_YEAR_CODE int,
	@IsNull_MONTH_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime,
	@IsNull_deducted bit,
	@Original_deducted bit,
	@IsNull_MonthlyIncrease numeric(18, 0),
	@Original_MonthlyIncrease numeric(18, 0),
	@IsNull_Balance numeric(18, 0),
	@Original_Balance numeric(18, 0),
	@IsNull_EMP_CODE bigint,
	@Original_EMP_CODE bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PerEmpLoanDetailsReport] WHERE (([LoanDetID] = @Original_LoanDetID) AND ((@IsNull_YEAR_CODE = 1 AND [YEAR_CODE] IS NULL) OR ([YEAR_CODE] = @Original_YEAR_CODE)) AND ((@IsNull_MONTH_CODE = 1 AND [MONTH_CODE] IS NULL) OR ([MONTH_CODE] = @Original_MONTH_CODE)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)) AND ((@IsNull_deducted = 1 AND [deducted] IS NULL) OR ([deducted] = @Original_deducted)) AND ((@IsNull_MonthlyIncrease = 1 AND [MonthlyIncrease] IS NULL) OR ([MonthlyIncrease] = @Original_MonthlyIncrease)) AND ((@IsNull_Balance = 1 AND [Balance] IS NULL) OR ([Balance] = @Original_Balance)) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_PerEmpLoanDetailsReportInsert
(
	@YEAR_CODE int,
	@MONTH_CODE int,
	@LoanAmount money,
	@LoanDate smalldatetime,
	@deducted bit,
	@MonthlyIncrease numeric(18, 0),
	@Balance numeric(18, 0),
	@EMP_CODE bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PerEmpLoanDetailsReport] ([YEAR_CODE], [MONTH_CODE], [LoanAmount], [LoanDate], [deducted], [MonthlyIncrease], [Balance], [EMP_CODE]) VALUES (@YEAR_CODE, @MONTH_CODE, @LoanAmount, @LoanDate, @deducted, @MonthlyIncrease, @Balance, @EMP_CODE);
	
SELECT LoanDetID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, MonthlyIncrease, Balance, EMP_CODE FROM PerEmpLoanDetailsReport WHERE (LoanDetID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_PerEmpLoanDetailsReportSelect
AS
	SET NOCOUNT ON;
SELECT     LoanDetID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, MonthlyIncrease, Balance, EMP_CODE
FROM         PerEmpLoanDetailsReport









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_PerEmpLoanDetailsReportUpdate
(
	@YEAR_CODE int,
	@MONTH_CODE int,
	@LoanAmount money,
	@LoanDate smalldatetime,
	@deducted bit,
	@MonthlyIncrease numeric(18, 0),
	@Balance numeric(18, 0),
	@EMP_CODE bigint,
	@Original_LoanDetID bigint,
	@IsNull_YEAR_CODE int,
	@Original_YEAR_CODE int,
	@IsNull_MONTH_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime,
	@IsNull_deducted bit,
	@Original_deducted bit,
	@IsNull_MonthlyIncrease numeric(18, 0),
	@Original_MonthlyIncrease numeric(18, 0),
	@IsNull_Balance numeric(18, 0),
	@Original_Balance numeric(18, 0),
	@IsNull_EMP_CODE bigint,
	@Original_EMP_CODE bigint,
	@LoanDetID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PerEmpLoanDetailsReport] SET [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [LoanAmount] = @LoanAmount, [LoanDate] = @LoanDate, [deducted] = @deducted, [MonthlyIncrease] = @MonthlyIncrease, [Balance] = @Balance, [EMP_CODE] = @EMP_CODE WHERE (([LoanDetID] = @Original_LoanDetID) AND ((@IsNull_YEAR_CODE = 1 AND [YEAR_CODE] IS NULL) OR ([YEAR_CODE] = @Original_YEAR_CODE)) AND ((@IsNull_MONTH_CODE = 1 AND [MONTH_CODE] IS NULL) OR ([MONTH_CODE] = @Original_MONTH_CODE)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)) AND ((@IsNull_deducted = 1 AND [deducted] IS NULL) OR ([deducted] = @Original_deducted)) AND ((@IsNull_MonthlyIncrease = 1 AND [MonthlyIncrease] IS NULL) OR ([MonthlyIncrease] = @Original_MonthlyIncrease)) AND ((@IsNull_Balance = 1 AND [Balance] IS NULL) OR ([Balance] = @Original_Balance)) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)));
	
SELECT LoanDetID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, MonthlyIncrease, Balance, EMP_CODE FROM PerEmpLoanDetailsReport WHERE (LoanDetID = @LoanDetID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO










CREATE PROCEDURE dbo.usp_PerEmpLoanDetailsReportbyEmpCode
(
	@EMP_CODE bigint
)
AS
	SET NOCOUNT ON;
SELECT     LoanDetID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate, deducted, MonthlyIncrease, Balance, EMP_CODE
FROM         PerEmpLoanDetailsReport
WHERE     (EMP_CODE = @EMP_CODE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Per_Employee_DataGetByEmpCode
(
	@Emp_code bigint,
	@FName varchar(50),
	@SName varchar(50),
	@TName varchar(50),
	@FoName varchar(50),
@EmpNum bigint
)
AS
	SET NOCOUNT ON;
SELECT     EMP_CODE, EmpNum, CIVILID, FName, SName, TName, FoName, FEngName, SEngName, TEngName, FoEngName, TITLE, EMP_GENDER, 
                      EMP_BIRTH_DATE, EMP_BIRTH_PLACE, DEPTCODE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, JOB_CODE, JOB_CLS_CODE, FILE_NUM, 
                      DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, BANK_CODE, AccountID, NOTES, 
                      PassportNo, PassType, PassDate, PassEndDate, Passplace, entrydate, SALARY, bankacc, BRANCH_CODE, SalesAdminFalg, GroupId, ReligionId, 
                      EducationId, EducationMajored, EducationMajoredDate, EducationMajoredYear, EducationMajoredPlace, LocationId, RegionId, DivisionId, GardeId, 
                      ResidenceId, ResidenceNo, ResidenceRemark, ResidenceIssueDate, ResidenceEndDate, LicenseNo, LicenseTypeId, LicenseIssueDate, 
                      LicenseEndDate, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JoiningDate, SalaryType, ContractType, ContractNo, IndemnityDays, 
                      VaccationDays, Ticket, WorkHourPerDay, WorkDaysperMonth, ADDRESS, BlockNo, Street, Floor, WorkTel, HomeTel, Mobile1, Mobile2, Fax, Email, 
                      bank, BankFId, BankSId, BankFBranch, BankSBranch, BankFAccountNo, BankSAccountNo, DankEffDate, JobLevel, ContactLocation, 
                      ContactLocationDate, Status, VacEarned, VacTaken, VacBalance, VacUnpaid, SALEADMIN, FullName, GetAllow, PhoneAllow, TransAllow, 
                      InsuranceValue
FROM         PER_EMPLOYEE_DATA
WHERE     (EMP_CODE = @Emp_code or  @Emp_code IS NULL)  AND (FName like  @FName + '%' OR @FName IS NULL)
AND (SName like  @SName + '%'   OR @SName IS NULL) 
AND (TName  like  @TName + '%'    OR  @TName IS NULL) 
AND (FoName  like  @FoName + '%'   OR  @FoName IS NULL)
and  (EmpNum = @EmpNum or  @EmpNum  IS NULL)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductOffersDelete
(
	@Original_OffertId bigint,
	@Original_productid bigint,
	@Original_UnitID bigint,
	@IsNull_BasicQty float,
	@Original_BasicQty float,
	@IsNull_OfferQty float,
	@Original_OfferQty float
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ProductOffers] WHERE (([OffertId] = @Original_OffertId) AND ([productid] = @Original_productid) AND ([UnitID] = @Original_UnitID) AND ((@IsNull_BasicQty = 1 AND [BasicQty] IS NULL) OR ([BasicQty] = @Original_BasicQty)) AND ((@IsNull_OfferQty = 1 AND [OfferQty] IS NULL) OR ([OfferQty] = @Original_OfferQty)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductOffersInsert
(
	@productid bigint,
	@UnitID bigint,
	@BasicQty float,
	@OfferQty float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ProductOffers] ([productid], [UnitID], [BasicQty], [OfferQty]) VALUES (@productid, @UnitID, @BasicQty, @OfferQty);
	
SELECT OffertId, productid, UnitID, BasicQty, OfferQty FROM ProductOffers WHERE (OffertId = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductOffersSelect
AS
	SET NOCOUNT ON;
SELECT     OffertId, productid, UnitID, BasicQty, OfferQty
FROM         ProductOffers









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductOffersUpdate
(
	@productid bigint,
	@UnitID bigint,
	@BasicQty float,
	@OfferQty float,
	@Original_OffertId bigint,
	@Original_productid bigint,
	@Original_UnitID bigint,
	@IsNull_BasicQty float,
	@Original_BasicQty float,
	@IsNull_OfferQty float,
	@Original_OfferQty float,
	@OffertId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ProductOffers] SET [productid] = @productid, [UnitID] = @UnitID, [BasicQty] = @BasicQty, [OfferQty] = @OfferQty WHERE (([OffertId] = @Original_OffertId) AND ([productid] = @Original_productid) AND ([UnitID] = @Original_UnitID) AND ((@IsNull_BasicQty = 1 AND [BasicQty] IS NULL) OR ([BasicQty] = @Original_BasicQty)) AND ((@IsNull_OfferQty = 1 AND [OfferQty] IS NULL) OR ([OfferQty] = @Original_OfferQty)));
	
SELECT OffertId, productid, UnitID, BasicQty, OfferQty FROM ProductOffers WHERE (OffertId = @OffertId)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductReplacmentDelete
(
	@Original_ReplaceId bigint,
	@Original_ReplaceProductId bigint,
	@Original_productid bigint,
	@Original_AvaliableQty bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ProductReplacment] WHERE (([ReplaceId] = @Original_ReplaceId) AND ([ReplaceProductId] = @Original_ReplaceProductId) AND ([productid] = @Original_productid) AND ([AvaliableQty] = @Original_AvaliableQty))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductReplacmentInsert
(
	@ReplaceProductId bigint,
	@productid bigint,
	@AvaliableQty bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ProductReplacment] ([ReplaceProductId], [productid], [AvaliableQty]) VALUES (@ReplaceProductId, @productid, @AvaliableQty);
	
SELECT ReplaceId, ReplaceProductId, productid, AvaliableQty FROM ProductReplacment WHERE (ReplaceId = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductReplacmentSelect
AS
	SET NOCOUNT ON;
SELECT     ReplaceId, ReplaceProductId, productid, AvaliableQty
FROM         ProductReplacment









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductReplacmentUpdate
(
	@ReplaceProductId bigint,
	@productid bigint,
	@AvaliableQty bigint,
	@Original_ReplaceId bigint,
	@Original_ReplaceProductId bigint,
	@Original_productid bigint,
	@Original_AvaliableQty bigint,
	@ReplaceId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ProductReplacment] SET [ReplaceProductId] = @ReplaceProductId, [productid] = @productid, [AvaliableQty] = @AvaliableQty WHERE (([ReplaceId] = @Original_ReplaceId) AND ([ReplaceProductId] = @Original_ReplaceProductId) AND ([productid] = @Original_productid) AND ([AvaliableQty] = @Original_AvaliableQty));
	
SELECT ReplaceId, ReplaceProductId, productid, AvaliableQty FROM ProductReplacment WHERE (ReplaceId = @ReplaceId)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductSalesSelectView
(
	@SUP_CUST_ID bigint,
	@BranchId bigint,
	@StoreId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
@EmpId int
)
AS
	SET NOCOUNT ON;
SELECT     ProductId, productname, SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 0 THEN isnull(TotalPrice, 0) END END) AS CashVaule, 
                      SUM(CASE PaymentType WHEN 1 THEN CASE ReoderFlag WHEN 0 THEN isnull(TotalPrice, 0) ELSE 0 END END) AS AgalValue, 
                      SUM(CASE PaymentType WHEN 1 THEN CASE ReoderFlag WHEN 1 THEN isnull(TotReoderPrice, 0) ELSE 0 END END) AS AgalreorderValue,
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 1 then isnull(TotReoderPrice, 0) else 0 end END) AS ChashReordervalue
FROM         CustomerInvoicesView
WHERE     (SUP_CUST_ID = @SUP_CUST_ID OR   @SUP_CUST_ID IS NULL) AND (BranchId = @BranchId OR  @BranchId IS NULL) AND
 (StoreId = @StoreId OR    @StoreId IS NULL) AND (InvDate >= @FromDate or @FromDate is null) AND (InvDate <= @ToDate or @ToDate is null) AND
 (ProductId = @ProductId OR   @ProductId IS NULL)   and (EmpId=@EmpId or @EmpId is null)
GROUP BY ProductId, productname









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_ProductSalesSelectViewMonths
(
	@SUP_CUST_ID bigint,
	@BranchId bigint,
	@StoreId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime,
	@ProductId bigint,
	@EmpId int
)
AS
	SET NOCOUNT ON;
SELECT     ProductId, productname, 
isnull(SUM(CASE MONTH(invdate) WHEN 1 THEN isnull(TotalPrice, 0) END ),0) AS TotPriceJan,
isnull(SUM(CASE MONTH(invdate) WHEN 2 THEN isnull(TotalPrice, 0) END ),0) AS TotPriceFeb,
isnull(SUM(CASE MONTH(invdate) WHEN 3 THEN isnull(TotalPrice, 0) END ), 0) AS TotPriceMar,
isnull(SUM(CASE MONTH(invdate) WHEN 4 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceApr,
isnull(SUM(CASE MONTH(invdate) WHEN 5 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceMay,

isnull(SUM(CASE MONTH(invdate) WHEN 6 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceJune,
isnull(SUM(CASE MONTH(invdate) WHEN 7 THEN isnull(TotalPrice, 0) END ), 0) AS TotPriceJuly,
isnull(SUM(CASE MONTH(invdate) WHEN 8 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceAug,
isnull(SUM(CASE MONTH(invdate) WHEN 9 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceSep,
isnull(SUM(CASE MONTH(invdate) WHEN 10 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceOct,
isnull(SUM(CASE MONTH(invdate) WHEN 11 THEN isnull(TotalPrice, 0) END ) , 0)AS TotPriceNov,
isnull(SUM(CASE MONTH(invdate) WHEN 12 THEN isnull(TotalPrice, 0) END ), 0) AS TotPriceDec,
               

isnull(SUM(CASE MONTH(invdate) WHEN 1 THEN isnull(qty, 0) END ), 0) AS TotQtyJan,
isnull(SUM(CASE MONTH(invdate) WHEN 2 THEN isnull(qty, 0) END ), 0) AS TotQtyFeb,
isnull(SUM(CASE MONTH(invdate) WHEN 3 THEN isnull(qty, 0) END ), 0) AS TotQtyMar,
isnull(SUM(CASE MONTH(invdate) WHEN 4 THEN isnull(qty, 0) END ), 0) AS TotQtyApr,
isnull(SUM(CASE MONTH(invdate) WHEN 5 THEN isnull(qty, 0) END ), 0) AS TotQtyMay,
isnull(SUM(CASE MONTH(invdate) WHEN 6 THEN isnull(qty, 0) END ) , 0)AS TotQtyJune,
isnull(SUM(CASE MONTH(invdate) WHEN 7 THEN isnull(qty, 0) END ) , 0)AS TotQtyJuly,
isnull(SUM(CASE MONTH(invdate) WHEN 8 THEN isnull(qty, 0) END ), 0) AS TotQtyAug,
isnull(SUM(CASE MONTH(invdate) WHEN 9 THEN isnull(qty, 0) END ) , 0)AS TotQtySep,
isnull(SUM(CASE MONTH(invdate) WHEN 10 THEN isnull(qty, 0) END ), 0) AS TotQtyOct,
isnull(SUM(CASE MONTH(invdate) WHEN 11 THEN isnull(qty, 0) END ) , 0)AS TotQtyNov,
isnull(SUM(CASE MONTH(invdate) WHEN 12 THEN isnull(qty, 0) END ), 0) AS TotQtyDec
   
FROM         CustomerInvoicesView


WHERE     (SUP_CUST_ID = @SUP_CUST_ID OR   @SUP_CUST_ID IS NULL) AND (BranchId = @BranchId OR  @BranchId IS NULL) AND
 (StoreId = @StoreId OR    @StoreId IS NULL) AND (InvDate >= @FromDate or @FromDate is null) AND (InvDate <= @ToDate or @ToDate is null) AND
 (ProductId = @ProductId OR   @ProductId IS NULL)   and (EmpId=@EmpId or @EmpId is null) and InvType=2 and ReoderFlag=0 and TotalPrice<>0 
GROUP BY ProductId, productname




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_AssemplyDelete
(
	@Original_AssemblyId bigint,
	@IsNull_AssemblyType nvarchar(50),
	@Original_AssemblyType nvarchar(50),
	@Original_productid bigint,
	@Original_Assproductid bigint,
	@Original_unit bigint,
	@Original_Qty float
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Product_Assemply] WHERE (([AssemblyId] = @Original_AssemblyId) AND ((@IsNull_AssemblyType = 1 AND [AssemblyType] IS NULL) OR ([AssemblyType] = @Original_AssemblyType)) AND ([productid] = @Original_productid) AND ([Assproductid] = @Original_Assproductid) AND ([unit] = @Original_unit) AND ([Qty] = @Original_Qty))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_AssemplyInsert
(
	@AssemblyType nvarchar(50),
	@productid bigint,
	@Assproductid bigint,
	@unit bigint,
	@Qty float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Product_Assemply] ([AssemblyType], [productid], [Assproductid], [unit], [Qty]) VALUES (@AssemblyType, @productid, @Assproductid, @unit, @Qty);
	
SELECT AssemblyId, AssemblyType, productid, Assproductid, unit, Qty FROM Product_Assemply WHERE (AssemblyId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_AssemplySelect
AS
	SET NOCOUNT ON;
SELECT     AssemblyId, AssemblyType, productid, Assproductid, unit, Qty
FROM         Product_Assemply







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_AssemplySelectbyProductId
(
	@productid bigint
)
AS
	SET NOCOUNT ON;
SELECT     AssemblyId, AssemblyType, productid, Assproductid, unit, Qty
FROM         Product_Assemply
WHERE     (productid = @productid) OR
                      (@productid IS NULL)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_AssemplyUpdate
(
	@AssemblyType nvarchar(50),
	@productid bigint,
	@Assproductid bigint,
	@unit bigint,
	@Qty float,
	@Original_AssemblyId bigint,
	@IsNull_AssemblyType nvarchar(50),
	@Original_AssemblyType nvarchar(50),
	@Original_productid bigint,
	@Original_Assproductid bigint,
	@Original_unit bigint,
	@Original_Qty float,
	@AssemblyId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Product_Assemply] SET [AssemblyType] = @AssemblyType, [productid] = @productid, [Assproductid] = @Assproductid, [unit] = @unit, [Qty] = @Qty WHERE (([AssemblyId] = @Original_AssemblyId) AND ((@IsNull_AssemblyType = 1 AND [AssemblyType] IS NULL) OR ([AssemblyType] = @Original_AssemblyType)) AND ([productid] = @Original_productid) AND ([Assproductid] = @Original_Assproductid) AND ([unit] = @Original_unit) AND ([Qty] = @Original_Qty));
	
SELECT AssemblyId, AssemblyType, productid, Assproductid, unit, Qty FROM Product_Assemply WHERE (AssemblyId = @AssemblyId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_Product_Units_PricesByUnitId
(
	@UintId bigint,
	@productid bigint
)
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, LastCostPrice
FROM         Product_Units_Prices
WHERE     (UintId = @UintId) AND (productid = @productid)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_Units_PricesDelete
(
	@Original_UitPriceId bigint,
	@Original_UintId bigint,
	@Original_productid bigint,
	@IsNull_PRODUCTBRAND Int,
	@Original_PRODUCTBRAND nvarchar(30),
	@Original_ConFactor float,
	@IsNull_PriceOnly Int,
	@Original_PriceOnly bit,
	@IsNull_Dim Int,
	@Original_Dim nvarchar(50),
	@IsNull_DimDesc Int,
	@Original_DimDesc nvarchar(50),
	@IsNull_MainUnit Int,
	@Original_MainUnit bit,
	@IsNull_AvgCostPrice Int,
	@Original_AvgCostPrice money,
	@IsNull_MaxCostPrice Int,
	@Original_MaxCostPrice money,
	@IsNull_MinCostPrice Int,
	@Original_MinCostPrice money,
	@IsNull_SalePrice Int,
	@Original_SalePrice money,
	@IsNull_MinPrice Int,
	@Original_MinPrice money,
	@IsNull_BuyPrice Int,
	@Original_BuyPrice money,
	@IsNull_CostmerPrice Int,
	@Original_CostmerPrice money,
	@IsNull_PrivatePrice Int,
	@Original_PrivatePrice money,
	@IsNull_Minprofit Int,
	@Original_Minprofit float,
	@IsNull_MaxProfit Int,
	@Original_MaxProfit float,
	@IsNull_MaxSalePrice Int,
	@Original_MaxSalePrice money,
	@IsNull_MinSalePrice Int,
	@Original_MinSalePrice money,
	@IsNull_LastSalePrice Int,
	@Original_LastSalePrice money,
	@IsNull_MaxBuyPrice Int,
	@Original_MaxBuyPrice money,
	@IsNull_MinBuyPrice Int,
	@Original_MinBuyPrice money,
	@IsNull_LastBuyPrice Int,
	@Original_LastBuyPrice money,
	@IsNull_LastCostPrice Int,
	@Original_LastCostPrice money,
	@IsNull_THRESHOLDINSTOCK Int,
	@Original_THRESHOLDINSTOCK numeric(5, 0),
	@IsNull_VALIDITY Int,
	@Original_VALIDITY smalldatetime,
	@IsNull_RECEIVERID Int,
	@Original_RECEIVERID int,
	@IsNull_StoreEnterDate Int,
	@Original_StoreEnterDate smalldatetime,
	@IsNull_FCostPrice Int,
	@Original_FCostPrice money,
	@IsNull_FPrice Int,
	@Original_FPrice money
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Product_Units_Prices] WHERE (([UitPriceId] = @Original_UitPriceId) AND ([UintId] = @Original_UintId) AND ([productid] = @Original_productid) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ([ConFactor] = @Original_ConFactor) AND ((@IsNull_PriceOnly = 1 AND [PriceOnly] IS NULL) OR ([PriceOnly] = @Original_PriceOnly)) AND ((@IsNull_Dim = 1 AND [Dim] IS NULL) OR ([Dim] = @Original_Dim)) AND ((@IsNull_DimDesc = 1 AND [DimDesc] IS NULL) OR ([DimDesc] = @Original_DimDesc)) AND ((@IsNull_MainUnit = 1 AND [MainUnit] IS NULL) OR ([MainUnit] = @Original_MainUnit)) AND ((@IsNull_AvgCostPrice = 1 AND [AvgCostPrice] IS NULL) OR ([AvgCostPrice] = @Original_AvgCostPrice)) AND ((@IsNull_MaxCostPrice = 1 AND [MaxCostPrice] IS NULL) OR ([MaxCostPrice] = @Original_MaxCostPrice)) AND ((@IsNull_MinCostPrice = 1 AND [MinCostPrice] IS NULL) OR ([MinCostPrice] = @Original_MinCostPrice)) AND ((@IsNull_SalePrice = 1 AND [SalePrice] IS NULL) OR ([SalePrice] = @Original_SalePrice)) AND ((@IsNull_MinPrice = 1 AND [MinPrice] IS NULL) OR ([MinPrice] = @Original_MinPrice)) AND ((@IsNull_BuyPrice = 1 AND [BuyPrice] IS NULL) OR ([BuyPrice] = @Original_BuyPrice)) AND ((@IsNull_CostmerPrice = 1 AND [CostmerPrice] IS NULL) OR ([CostmerPrice] = @Original_CostmerPrice)) AND ((@IsNull_PrivatePrice = 1 AND [PrivatePrice] IS NULL) OR ([PrivatePrice] = @Original_PrivatePrice)) AND ((@IsNull_Minprofit = 1 AND [Minprofit] IS NULL) OR ([Minprofit] = @Original_Minprofit)) AND ((@IsNull_MaxProfit = 1 AND [MaxProfit] IS NULL) OR ([MaxProfit] = @Original_MaxProfit)) AND ((@IsNull_MaxSalePrice = 1 AND [MaxSalePrice] IS NULL) OR ([MaxSalePrice] = @Original_MaxSalePrice)) AND ((@IsNull_MinSalePrice = 1 AND [MinSalePrice] IS NULL) OR ([MinSalePrice] = @Original_MinSalePrice)) AND ((@IsNull_LastSalePrice = 1 AND [LastSalePrice] IS NULL) OR ([LastSalePrice] = @Original_LastSalePrice)) AND ((@IsNull_MaxBuyPrice = 1 AND [MaxBuyPrice] IS NULL) OR ([MaxBuyPrice] = @Original_MaxBuyPrice)) AND ((@IsNull_MinBuyPrice = 1 AND [MinBuyPrice] IS NULL) OR ([MinBuyPrice] = @Original_MinBuyPrice)) AND ((@IsNull_LastBuyPrice = 1 AND [LastBuyPrice] IS NULL) OR ([LastBuyPrice] = @Original_LastBuyPrice)) AND ((@IsNull_LastCostPrice = 1 AND [LastCostPrice] IS NULL) OR ([LastCostPrice] = @Original_LastCostPrice)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_StoreEnterDate = 1 AND [StoreEnterDate] IS NULL) OR ([StoreEnterDate] = @Original_StoreEnterDate)) AND ((@IsNull_FCostPrice = 1 AND [FCostPrice] IS NULL) OR ([FCostPrice] = @Original_FCostPrice)) AND ((@IsNull_FPrice = 1 AND [FPrice] IS NULL) OR ([FPrice] = @Original_FPrice)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_Units_PricesInsert
(
	@UintId bigint,
	@productid bigint,
	@PRODUCTBRAND nvarchar(30),
	@ConFactor float,
	@PriceOnly bit,
	@Dim nvarchar(50),
	@DimDesc nvarchar(50),
	@MainUnit bit,
	@AvgCostPrice money,
	@MaxCostPrice money,
	@MinCostPrice money,
	@SalePrice money,
	@MinPrice money,
	@BuyPrice money,
	@CostmerPrice money,
	@PrivatePrice money,
	@Minprofit float,
	@MaxProfit float,
	@MaxSalePrice money,
	@MinSalePrice money,
	@LastSalePrice money,
	@MaxBuyPrice money,
	@MinBuyPrice money,
	@LastBuyPrice money,
	@LastCostPrice money,
	@THRESHOLDINSTOCK numeric(5, 0),
	@VALIDITY smalldatetime,
	@RECEIVERID int,
	@StoreEnterDate smalldatetime,
	@FCostPrice money,
	@FPrice money
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Product_Units_Prices] ([UintId], [productid], [PRODUCTBRAND], [ConFactor], [PriceOnly], [Dim], [DimDesc], [MainUnit], [AvgCostPrice], [MaxCostPrice], [MinCostPrice], [SalePrice], [MinPrice], [BuyPrice], [CostmerPrice], [PrivatePrice], [Minprofit], [MaxProfit], [MaxSalePrice], [MinSalePrice], [LastSalePrice], [MaxBuyPrice], [MinBuyPrice], [LastBuyPrice], [LastCostPrice], [THRESHOLDINSTOCK], [VALIDITY], [RECEIVERID], [StoreEnterDate], [FCostPrice], [FPrice]) VALUES (@UintId, @productid, @PRODUCTBRAND, @ConFactor, @PriceOnly, @Dim, @DimDesc, @MainUnit, @AvgCostPrice, @MaxCostPrice, @MinCostPrice, @SalePrice, @MinPrice, @BuyPrice, @CostmerPrice, @PrivatePrice, @Minprofit, @MaxProfit, @MaxSalePrice, @MinSalePrice, @LastSalePrice, @MaxBuyPrice, @MinBuyPrice, @LastBuyPrice, @LastCostPrice, @THRESHOLDINSTOCK, @VALIDITY, @RECEIVERID, @StoreEnterDate, @FCostPrice, @FPrice);
	
SELECT UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, LastBuyPrice, LastCostPrice, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, StoreEnterDate, FCostPrice, FPrice FROM Product_Units_Prices WHERE (UitPriceId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_Units_PricesSelect
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, LastCostPrice, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, StoreEnterDate, FCostPrice, FPrice
FROM         Product_Units_Prices







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_Product_Units_PricesSelectbyBarCode
(
	@PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, ConFactor, MainUnit, PRODUCTBRAND, PriceOnly, Dim, DimDesc, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, LastCostPrice
FROM         Product_Units_Prices
WHERE     (PRODUCTBRAND = @PRODUCTBRAND)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_Product_Units_PricesSelectbyProductId
(
	@ProductId bigint
)
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, ConFactor, MainUnit, PRODUCTBRAND, PriceOnly, Dim, DimDesc, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, LastCostPrice
FROM         Product_Units_Prices
WHERE     (productid = @ProductId)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Product_Units_PricesUpdate
(
	@UintId bigint,
	@productid bigint,
	@PRODUCTBRAND nvarchar(30),
	@ConFactor float,
	@PriceOnly bit,
	@Dim nvarchar(50),
	@DimDesc nvarchar(50),
	@MainUnit bit,
	@AvgCostPrice money,
	@MaxCostPrice money,
	@MinCostPrice money,
	@SalePrice money,
	@MinPrice money,
	@BuyPrice money,
	@CostmerPrice money,
	@PrivatePrice money,
	@Minprofit float,
	@MaxProfit float,
	@MaxSalePrice money,
	@MinSalePrice money,
	@LastSalePrice money,
	@MaxBuyPrice money,
	@MinBuyPrice money,
	@LastBuyPrice money,
	@LastCostPrice money,
	@THRESHOLDINSTOCK numeric(5, 0),
	@VALIDITY smalldatetime,
	@RECEIVERID int,
	@StoreEnterDate smalldatetime,
	@FCostPrice money,
	@FPrice money,
	@Original_UitPriceId bigint,
	@Original_UintId bigint,
	@Original_productid bigint,
	@IsNull_PRODUCTBRAND Int,
	@Original_PRODUCTBRAND nvarchar(30),
	@Original_ConFactor float,
	@IsNull_PriceOnly Int,
	@Original_PriceOnly bit,
	@IsNull_Dim Int,
	@Original_Dim nvarchar(50),
	@IsNull_DimDesc Int,
	@Original_DimDesc nvarchar(50),
	@IsNull_MainUnit Int,
	@Original_MainUnit bit,
	@IsNull_AvgCostPrice Int,
	@Original_AvgCostPrice money,
	@IsNull_MaxCostPrice Int,
	@Original_MaxCostPrice money,
	@IsNull_MinCostPrice Int,
	@Original_MinCostPrice money,
	@IsNull_SalePrice Int,
	@Original_SalePrice money,
	@IsNull_MinPrice Int,
	@Original_MinPrice money,
	@IsNull_BuyPrice Int,
	@Original_BuyPrice money,
	@IsNull_CostmerPrice Int,
	@Original_CostmerPrice money,
	@IsNull_PrivatePrice Int,
	@Original_PrivatePrice money,
	@IsNull_Minprofit Int,
	@Original_Minprofit float,
	@IsNull_MaxProfit Int,
	@Original_MaxProfit float,
	@IsNull_MaxSalePrice Int,
	@Original_MaxSalePrice money,
	@IsNull_MinSalePrice Int,
	@Original_MinSalePrice money,
	@IsNull_LastSalePrice Int,
	@Original_LastSalePrice money,
	@IsNull_MaxBuyPrice Int,
	@Original_MaxBuyPrice money,
	@IsNull_MinBuyPrice Int,
	@Original_MinBuyPrice money,
	@IsNull_LastBuyPrice Int,
	@Original_LastBuyPrice money,
	@IsNull_LastCostPrice Int,
	@Original_LastCostPrice money,
	@IsNull_THRESHOLDINSTOCK Int,
	@Original_THRESHOLDINSTOCK numeric(5, 0),
	@IsNull_VALIDITY Int,
	@Original_VALIDITY smalldatetime,
	@IsNull_RECEIVERID Int,
	@Original_RECEIVERID int,
	@IsNull_StoreEnterDate Int,
	@Original_StoreEnterDate smalldatetime,
	@IsNull_FCostPrice Int,
	@Original_FCostPrice money,
	@IsNull_FPrice Int,
	@Original_FPrice money,
	@UitPriceId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Product_Units_Prices] SET [UintId] = @UintId, [productid] = @productid, [PRODUCTBRAND] = @PRODUCTBRAND, [ConFactor] = @ConFactor, [PriceOnly] = @PriceOnly, [Dim] = @Dim, [DimDesc] = @DimDesc, [MainUnit] = @MainUnit, [AvgCostPrice] = @AvgCostPrice, [MaxCostPrice] = @MaxCostPrice, [MinCostPrice] = @MinCostPrice, [SalePrice] = @SalePrice, [MinPrice] = @MinPrice, [BuyPrice] = @BuyPrice, [CostmerPrice] = @CostmerPrice, [PrivatePrice] = @PrivatePrice, [Minprofit] = @Minprofit, [MaxProfit] = @MaxProfit, [MaxSalePrice] = @MaxSalePrice, [MinSalePrice] = @MinSalePrice, [LastSalePrice] = @LastSalePrice, [MaxBuyPrice] = @MaxBuyPrice, [MinBuyPrice] = @MinBuyPrice, [LastBuyPrice] = @LastBuyPrice, [LastCostPrice] = @LastCostPrice, [THRESHOLDINSTOCK] = @THRESHOLDINSTOCK, [VALIDITY] = @VALIDITY, [RECEIVERID] = @RECEIVERID, [StoreEnterDate] = @StoreEnterDate, [FCostPrice] = @FCostPrice, [FPrice] = @FPrice WHERE (([UitPriceId] = @Original_UitPriceId) AND ([UintId] = @Original_UintId) AND ([productid] = @Original_productid) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ([ConFactor] = @Original_ConFactor) AND ((@IsNull_PriceOnly = 1 AND [PriceOnly] IS NULL) OR ([PriceOnly] = @Original_PriceOnly)) AND ((@IsNull_Dim = 1 AND [Dim] IS NULL) OR ([Dim] = @Original_Dim)) AND ((@IsNull_DimDesc = 1 AND [DimDesc] IS NULL) OR ([DimDesc] = @Original_DimDesc)) AND ((@IsNull_MainUnit = 1 AND [MainUnit] IS NULL) OR ([MainUnit] = @Original_MainUnit)) AND ((@IsNull_AvgCostPrice = 1 AND [AvgCostPrice] IS NULL) OR ([AvgCostPrice] = @Original_AvgCostPrice)) AND ((@IsNull_MaxCostPrice = 1 AND [MaxCostPrice] IS NULL) OR ([MaxCostPrice] = @Original_MaxCostPrice)) AND ((@IsNull_MinCostPrice = 1 AND [MinCostPrice] IS NULL) OR ([MinCostPrice] = @Original_MinCostPrice)) AND ((@IsNull_SalePrice = 1 AND [SalePrice] IS NULL) OR ([SalePrice] = @Original_SalePrice)) AND ((@IsNull_MinPrice = 1 AND [MinPrice] IS NULL) OR ([MinPrice] = @Original_MinPrice)) AND ((@IsNull_BuyPrice = 1 AND [BuyPrice] IS NULL) OR ([BuyPrice] = @Original_BuyPrice)) AND ((@IsNull_CostmerPrice = 1 AND [CostmerPrice] IS NULL) OR ([CostmerPrice] = @Original_CostmerPrice)) AND ((@IsNull_PrivatePrice = 1 AND [PrivatePrice] IS NULL) OR ([PrivatePrice] = @Original_PrivatePrice)) AND ((@IsNull_Minprofit = 1 AND [Minprofit] IS NULL) OR ([Minprofit] = @Original_Minprofit)) AND ((@IsNull_MaxProfit = 1 AND [MaxProfit] IS NULL) OR ([MaxProfit] = @Original_MaxProfit)) AND ((@IsNull_MaxSalePrice = 1 AND [MaxSalePrice] IS NULL) OR ([MaxSalePrice] = @Original_MaxSalePrice)) AND ((@IsNull_MinSalePrice = 1 AND [MinSalePrice] IS NULL) OR ([MinSalePrice] = @Original_MinSalePrice)) AND ((@IsNull_LastSalePrice = 1 AND [LastSalePrice] IS NULL) OR ([LastSalePrice] = @Original_LastSalePrice)) AND ((@IsNull_MaxBuyPrice = 1 AND [MaxBuyPrice] IS NULL) OR ([MaxBuyPrice] = @Original_MaxBuyPrice)) AND ((@IsNull_MinBuyPrice = 1 AND [MinBuyPrice] IS NULL) OR ([MinBuyPrice] = @Original_MinBuyPrice)) AND ((@IsNull_LastBuyPrice = 1 AND [LastBuyPrice] IS NULL) OR ([LastBuyPrice] = @Original_LastBuyPrice)) AND ((@IsNull_LastCostPrice = 1 AND [LastCostPrice] IS NULL) OR ([LastCostPrice] = @Original_LastCostPrice)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_StoreEnterDate = 1 AND [StoreEnterDate] IS NULL) OR ([StoreEnterDate] = @Original_StoreEnterDate)) AND ((@IsNull_FCostPrice = 1 AND [FCostPrice] IS NULL) OR ([FCostPrice] = @Original_FCostPrice)) AND ((@IsNull_FPrice = 1 AND [FPrice] IS NULL) OR ([FPrice] = @Original_FPrice)));
	
SELECT UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, LastBuyPrice, LastCostPrice, THRESHOLDINSTOCK, VALIDITY, RECEIVERID, StoreEnterDate, FCostPrice, FPrice FROM Product_Units_Prices WHERE (UitPriceId = @UitPriceId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductsSelectQuery
AS
	SET NOCOUNT ON;
SELECT     PRODUCTS.PRODUCTID, PRODUCTS.productname, PRODUCTS.EnglishName, PRODUCTS.PRODUCTCODE, PRODUCTS.ProductTypeID, 
                      PRODUCTS.picpath, PRODUCTS.SERIALNO, PRODUCTS.SUPPLIERID, PRODUCTS.CATEGORYID, PRODUCTS.PWeight, PRODUCTS.PSize, 
                      PRODUCTS.PColor, PRODUCTS.PVolume, PRODUCTS.VALIDITY, PRODUCTS.PDesc, PRODUCTS.PriceRule, PRODUCTS.PriceFromDate, 
                      PRODUCTS.PriceToDate, PRODUCTS.OfferTypeID, PRODUCTS.OfferFromDate, PRODUCTS.OfferToDate, PRODUCTS.OfferProductId, PRODUCTS.OfferUnit, 
                      PRODUCTS.ParentProductId, PRODUCTS.UNITPRICECOST, PRODUCTS.UNITPRICESALES, PRODUCTS.BUYDATE, PRODUCTS.THRESHOLDINSTOCK, 
                      PRODUCTS.DISCONTINUED, PRODUCTS.REORDERLEVEL, PRODUCTS.STOCKNO, PRODUCTS.RECEIVERID, PRODUCTS.SHAPE, 
                      PRODUCTS.QUANTITYPERUNIT, PRODUCTS.complexproduct, PRODUCTS.UNITSINSTOCK, PRODUCTS.ACCOUNTID, PRODUCTS.QUANTITYINUNIT, 
                      PRODUCTS.initialsmallquantity, PRODUCTS.initialprice, PRODUCTS.initiallargequantity, PRODUCTS.serviceproduct, PRODUCTS.profit, 
                      PRODUCTS.forcurrency, PRODUCTS.minprice, PRODUCTS.shape2, CDE_PRODUCTTYPES.TYPEDESC,MainNode,ProcessFlag,[Level]
FROM         CDE_PRODUCTTYPES INNER JOIN
                      PRODUCTS ON CDE_PRODUCTTYPES.TYPEID = PRODUCTS.ProductTypeID







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_ProductsSelectStock
( @Branchcode bigint)
AS
	SET NOCOUNT ON;
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
                      dbo.PRODUCTS.SerialCode,MainNode,ProcessFlag,[Level]
FROM         dbo.STORES INNER JOIN
                      dbo.STOCK ON dbo.STORES.STOREID = dbo.STOCK.STOREID LEFT OUTER JOIN
                      dbo.PRODUCTS ON dbo.STOCK.PRODUCTID = dbo.PRODUCTS.PRODUCTID
where Branchcode=@Branchcode







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



Create PROCEDURE [dbo].[usp_QidCheckChequeNo]
(
	@recitetype int,
	@BankAccId bigint,
	@ChequeNo nvarchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     ISNULL(count(ChequeNo), 0) AS MaxChequeNo
FROM         qids
WHERE     (recitetype = @recitetype)and BankAccId=@BankAccId and ChequeNo=@ChequeNo 










GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE PROCEDURE [dbo].[usp_QidSelectMaxChequeNo]
(
	@recitetype int,
	@BankAccId bigint
)
AS
	SET NOCOUNT ON;
SELECT    ISNULL(MAX(CAST(ChequeNo AS int)), 0) AS MaxChequeNo
FROM         qids
WHERE     (recitetype = @recitetype)and BankAccId=@BankAccId



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







Create PROCEDURE [dbo].[usp_QidSelectMaxSerialNotDate]
(
	@recitetype int
)
AS
	SET NOCOUNT ON;
SELECT     ISNULL(MAX(QidSerial), 0) AS MaxSerial
FROM         qids
WHERE     (recitetype = @recitetype)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_ReoderDetailsDelete
(
	@Original_Id bigint,
	@IsNull_ReoderId bigint,
	@Original_ReoderId bigint,
	@IsNull_InvId bigint,
	@Original_InvId bigint,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_Inv_Product_Id bigint,
	@Original_Inv_Product_Id bigint,
	@IsNull_ProductId bigint,
	@Original_ProductId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ReoderDetails] WHERE (([Id] = @Original_Id) AND ((@IsNull_ReoderId = 1 AND [ReoderId] IS NULL) OR ([ReoderId] = @Original_ReoderId)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_Inv_Product_Id = 1 AND [Inv_Product_Id] IS NULL) OR ([Inv_Product_Id] = @Original_Inv_Product_Id)) AND ((@IsNull_ProductId = 1 AND [ProductId] IS NULL) OR ([ProductId] = @Original_ProductId)))




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_ReoderDetailsInsert
(
	@ReoderId bigint,
	@InvId bigint,
	@ReorderQty float,
	@TotReOderPrice money,
	@Inv_Product_Id bigint,
	@ProductId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ReoderDetails] ([ReoderId], [InvId], [ReorderQty], [TotReOderPrice], [Inv_Product_Id], [ProductId]) VALUES (@ReoderId, @InvId, @ReorderQty, @TotReOderPrice, @Inv_Product_Id, @ProductId);
	
SELECT Id, ReoderId, InvId, ReorderQty, TotReOderPrice, Inv_Product_Id, ProductId FROM ReoderDetails WHERE (Id = SCOPE_IDENTITY())




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_ReoderDetailsSelect
AS
	SET NOCOUNT ON;
SELECT     Id, ReoderId, InvId, ReorderQty, TotReOderPrice, Inv_Product_Id, ProductId
FROM         ReoderDetails




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO





CREATE PROCEDURE dbo.usp_ReoderDetailsUpdate
(
	@ReoderId bigint,
	@InvId bigint,
	@ReorderQty float,
	@TotReOderPrice money,
	@Inv_Product_Id bigint,
	@ProductId bigint,
	@Original_Id bigint,
	@IsNull_ReoderId bigint,
	@Original_ReoderId bigint,
	@IsNull_InvId bigint,
	@Original_InvId bigint,
	@IsNull_ReorderQty float,
	@Original_ReorderQty float,
	@IsNull_TotReOderPrice money,
	@Original_TotReOderPrice money,
	@IsNull_Inv_Product_Id bigint,
	@Original_Inv_Product_Id bigint,
	@IsNull_ProductId bigint,
	@Original_ProductId bigint,
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ReoderDetails] SET [ReoderId] = @ReoderId, [InvId] = @InvId, [ReorderQty] = @ReorderQty, [TotReOderPrice] = @TotReOderPrice, [Inv_Product_Id] = @Inv_Product_Id, [ProductId] = @ProductId WHERE (([Id] = @Original_Id) AND ((@IsNull_ReoderId = 1 AND [ReoderId] IS NULL) OR ([ReoderId] = @Original_ReoderId)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_Inv_Product_Id = 1 AND [Inv_Product_Id] IS NULL) OR ([Inv_Product_Id] = @Original_Inv_Product_Id)) AND ((@IsNull_ProductId = 1 AND [ProductId] IS NULL) OR ([ProductId] = @Original_ProductId)));
	
SELECT Id, ReoderId, InvId, ReorderQty, TotReOderPrice, Inv_Product_Id, ProductId FROM ReoderDetails WHERE (Id = @Id)




GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_STORESSelectByBranchId
(
	@BranchId bigint
)
AS
	SET NOCOUNT ON;
SELECT     STOREID, STORECODE, STORNAME, BRANCHCODE, Notes
FROM         STORES
WHERE     (BRANCHCODE = @BranchId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_STORESSelectByStoreId
(
	@StoreId bigint
)
AS
	SET NOCOUNT ON;
SELECT     STOREID, STORECODE, STORNAME, BRANCHCODE, Notes
FROM         STORES
WHERE     (StoreId = @StoreId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSByType
(
	@SUP_CUST_TYPE int
)
AS
	SET NOCOUNT ON;
SELECT     dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_CODE, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, 
                      dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_SNAME, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE, dbo.SUPPLIERS_CUSTOMERS.ADMIN_NAME, 
                      dbo.SUPPLIERS_CUSTOMERS.ADMIN_TITLE, dbo.SUPPLIERS_CUSTOMERS.ADDRESS, dbo.SUPPLIERS_CUSTOMERS.CITY, 
                      dbo.SUPPLIERS_CUSTOMERS.GOVERNERATE, dbo.SUPPLIERS_CUSTOMERS.COUNTRY, dbo.SUPPLIERS_CUSTOMERS.PHONE1, 
                      dbo.SUPPLIERS_CUSTOMERS.PHONE2, dbo.SUPPLIERS_CUSTOMERS.FAX, dbo.SUPPLIERS_CUSTOMERS.POSTOFFICE, 
                      dbo.SUPPLIERS_CUSTOMERS.EMAIL, dbo.SUPPLIERS_CUSTOMERS.SUPPLIERACOUNT, dbo.SUPPLIERS_CUSTOMERS.CONVICT, 
                      dbo.SUPPLIERS_CUSTOMERS.CREDITOR, dbo.SUPPLIERS_CUSTOMERS.NOTES, dbo.SUPPLIERS_CUSTOMERS.accountid, 
                      dbo.SUPPLIERS_CUSTOMERS.WORKHOURS, dbo.SUPPLIERS_CUSTOMERS.WEEKEND, dbo.SUPPLIERS_CUSTOMERS.SALEADMIN, 
                      dbo.SUPPLIERS_CUSTOMERS.CREDITLIMIT, dbo.SUPPLIERS_CUSTOMERS.CREDITPEROID, dbo.SUPPLIERS_CUSTOMERS.PAYPEROID
FROM         dbo.SUPPLIERS_CUSTOMERS INNER JOIN
                      dbo.accounting ON dbo.SUPPLIERS_CUSTOMERS.accountid = dbo.accounting.accountid
WHERE     (SUP_CUST_TYPE = 3) OR  (SUP_CUST_TYPE = @SUP_CUST_TYPE) and SUPPLIERS_CUSTOMERS.accountid >0









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSDelete
(
	@Original_SUP_CUST_ID bigint,
	@IsNull_SUP_CUST_CODE nvarchar(50),
	@Original_SUP_CUST_CODE nvarchar(50),
	@IsNull_SUP_CUST_FNAME nvarchar(100),
	@Original_SUP_CUST_FNAME nvarchar(100),
	@IsNull_SUP_CUST_SNAME nvarchar(100),
	@Original_SUP_CUST_SNAME nvarchar(100),
	@IsNull_SUP_CUST_TYPE int,
	@Original_SUP_CUST_TYPE int,
	@IsNull_ADMIN_NAME nvarchar(60),
	@Original_ADMIN_NAME nvarchar(60),
	@IsNull_ADMIN_TITLE nvarchar(60),
	@Original_ADMIN_TITLE nvarchar(60),
	@IsNull_ADDRESS nvarchar(60),
	@Original_ADDRESS nvarchar(60),
	@IsNull_CITY nvarchar(15),
	@Original_CITY nvarchar(15),
	@IsNull_GOVERNERATE nvarchar(15),
	@Original_GOVERNERATE nvarchar(15),
	@IsNull_COUNTRY nvarchar(15),
	@Original_COUNTRY nvarchar(15),
	@IsNull_PHONE1 nvarchar(24),
	@Original_PHONE1 nvarchar(24),
	@IsNull_PHONE2 nvarchar(24),
	@Original_PHONE2 nvarchar(24),
	@IsNull_FAX nvarchar(24),
	@Original_FAX nvarchar(24),
	@IsNull_POSTOFFICE nvarchar(50),
	@Original_POSTOFFICE nvarchar(50),
	@IsNull_EMAIL nvarchar(100),
	@Original_EMAIL nvarchar(100),
	@IsNull_SUPPLIERACOUNT float,
	@Original_SUPPLIERACOUNT float,
	@IsNull_CONVICT float,
	@Original_CONVICT float,
	@IsNull_CREDITOR float,
	@Original_CREDITOR float,
	@IsNull_accountid bigint,
	@Original_accountid bigint,
	@IsNull_WORKHOURS nvarchar(100),
	@Original_WORKHOURS nvarchar(100),
	@IsNull_WEEKEND nvarchar(80),
	@Original_WEEKEND nvarchar(80),
	@IsNull_SALEADMIN bigint,
	@Original_SALEADMIN bigint,
	@IsNull_CREDITLIMIT money,
	@Original_CREDITLIMIT money,
	@IsNull_CREDITPEROID numeric(18, 0),
	@Original_CREDITPEROID numeric(18, 0),
	@IsNull_PAYPEROID numeric(18, 0),
	@Original_PAYPEROID numeric(18, 0)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [SUPPLIERS_CUSTOMERS] WHERE (([SUP_CUST_ID] = @Original_SUP_CUST_ID) AND ((@IsNull_SUP_CUST_CODE = 1 AND [SUP_CUST_CODE] IS NULL) OR ([SUP_CUST_CODE] = @Original_SUP_CUST_CODE)) AND ((@IsNull_SUP_CUST_FNAME = 1 AND [SUP_CUST_FNAME] IS NULL) OR ([SUP_CUST_FNAME] = @Original_SUP_CUST_FNAME)) AND ((@IsNull_SUP_CUST_SNAME = 1 AND [SUP_CUST_SNAME] IS NULL) OR ([SUP_CUST_SNAME] = @Original_SUP_CUST_SNAME)) AND ((@IsNull_SUP_CUST_TYPE = 1 AND [SUP_CUST_TYPE] IS NULL) OR ([SUP_CUST_TYPE] = @Original_SUP_CUST_TYPE)) AND ((@IsNull_ADMIN_NAME = 1 AND [ADMIN_NAME] IS NULL) OR ([ADMIN_NAME] = @Original_ADMIN_NAME)) AND ((@IsNull_ADMIN_TITLE = 1 AND [ADMIN_TITLE] IS NULL) OR ([ADMIN_TITLE] = @Original_ADMIN_TITLE)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_CITY = 1 AND [CITY] IS NULL) OR ([CITY] = @Original_CITY)) AND ((@IsNull_GOVERNERATE = 1 AND [GOVERNERATE] IS NULL) OR ([GOVERNERATE] = @Original_GOVERNERATE)) AND ((@IsNull_COUNTRY = 1 AND [COUNTRY] IS NULL) OR ([COUNTRY] = @Original_COUNTRY)) AND ((@IsNull_PHONE1 = 1 AND [PHONE1] IS NULL) OR ([PHONE1] = @Original_PHONE1)) AND ((@IsNull_PHONE2 = 1 AND [PHONE2] IS NULL) OR ([PHONE2] = @Original_PHONE2)) AND ((@IsNull_FAX = 1 AND [FAX] IS NULL) OR ([FAX] = @Original_FAX)) AND ((@IsNull_POSTOFFICE = 1 AND [POSTOFFICE] IS NULL) OR ([POSTOFFICE] = @Original_POSTOFFICE)) AND ((@IsNull_EMAIL = 1 AND [EMAIL] IS NULL) OR ([EMAIL] = @Original_EMAIL)) AND ((@IsNull_SUPPLIERACOUNT = 1 AND [SUPPLIERACOUNT] IS NULL) OR ([SUPPLIERACOUNT] = @Original_SUPPLIERACOUNT)) AND ((@IsNull_CONVICT = 1 AND [CONVICT] IS NULL) OR ([CONVICT] = @Original_CONVICT)) AND ((@IsNull_CREDITOR = 1 AND [CREDITOR] IS NULL) OR ([CREDITOR] = @Original_CREDITOR)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_WORKHOURS = 1 AND [WORKHOURS] IS NULL) OR ([WORKHOURS] = @Original_WORKHOURS)) AND ((@IsNull_WEEKEND = 1 AND [WEEKEND] IS NULL) OR ([WEEKEND] = @Original_WEEKEND)) AND ((@IsNull_SALEADMIN = 1 AND [SALEADMIN] IS NULL) OR ([SALEADMIN] = @Original_SALEADMIN)) AND ((@IsNull_CREDITLIMIT = 1 AND [CREDITLIMIT] IS NULL) OR ([CREDITLIMIT] = @Original_CREDITLIMIT)) AND ((@IsNull_CREDITPEROID = 1 AND [CREDITPEROID] IS NULL) OR ([CREDITPEROID] = @Original_CREDITPEROID)) AND ((@IsNull_PAYPEROID = 1 AND [PAYPEROID] IS NULL) OR ([PAYPEROID] = @Original_PAYPEROID)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSInsert
(
	@SUP_CUST_CODE nvarchar(50),
	@SUP_CUST_FNAME nvarchar(100),
	@SUP_CUST_SNAME nvarchar(100),
	@SUP_CUST_TYPE int,
	@ADMIN_NAME nvarchar(60),
	@ADMIN_TITLE nvarchar(60),
	@ADDRESS nvarchar(60),
	@CITY nvarchar(15),
	@GOVERNERATE nvarchar(15),
	@COUNTRY nvarchar(15),
	@PHONE1 nvarchar(24),
	@PHONE2 nvarchar(24),
	@FAX nvarchar(24),
	@POSTOFFICE nvarchar(50),
	@EMAIL nvarchar(100),
	@SUPPLIERACOUNT float,
	@CONVICT float,
	@CREDITOR float,
	@NOTES ntext,
	@accountid bigint,
	@WORKHOURS nvarchar(100),
	@WEEKEND nvarchar(80),
	@SALEADMIN bigint,
	@CREDITLIMIT money,
	@CREDITPEROID numeric(18, 0),
	@PAYPEROID numeric(18, 0)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [SUPPLIERS_CUSTOMERS] ([SUP_CUST_CODE], [SUP_CUST_FNAME], [SUP_CUST_SNAME], [SUP_CUST_TYPE], [ADMIN_NAME], [ADMIN_TITLE], [ADDRESS], [CITY], [GOVERNERATE], [COUNTRY], [PHONE1], [PHONE2], [FAX], [POSTOFFICE], [EMAIL], [SUPPLIERACOUNT], [CONVICT], [CREDITOR], [NOTES], [accountid], [WORKHOURS], [WEEKEND], [SALEADMIN], [CREDITLIMIT], [CREDITPEROID], [PAYPEROID]) VALUES (@SUP_CUST_CODE, @SUP_CUST_FNAME, @SUP_CUST_SNAME, @SUP_CUST_TYPE, @ADMIN_NAME, @ADMIN_TITLE, @ADDRESS, @CITY, @GOVERNERATE, @COUNTRY, @PHONE1, @PHONE2, @FAX, @POSTOFFICE, @EMAIL, @SUPPLIERACOUNT, @CONVICT, @CREDITOR, @NOTES, @accountid, @WORKHOURS, @WEEKEND, @SALEADMIN, @CREDITLIMIT, @CREDITPEROID, @PAYPEROID);
	
SELECT SUP_CUST_ID, SUP_CUST_CODE, SUP_CUST_FNAME, SUP_CUST_SNAME, SUP_CUST_TYPE, ADMIN_NAME, ADMIN_TITLE, ADDRESS, CITY, GOVERNERATE, COUNTRY, PHONE1, PHONE2, FAX, POSTOFFICE, EMAIL, SUPPLIERACOUNT, CONVICT, CREDITOR, NOTES, accountid, WORKHOURS, WEEKEND, SALEADMIN, CREDITLIMIT, CREDITPEROID, PAYPEROID FROM SUPPLIERS_CUSTOMERS WHERE (SUP_CUST_ID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSPayByType
(
	@SUP_CUST_TYPE int
)
AS
	SET NOCOUNT ON;
SELECT     SUP_CUST_ID, SUP_CUST_CODE, SUP_CUST_FNAME, SUP_CUST_SNAME, SUP_CUST_TYPE, ADMIN_NAME, ADMIN_TITLE, ADDRESS, CITY, 
                      GOVERNERATE, COUNTRY, PHONE1, PHONE2, FAX, POSTOFFICE, EMAIL, SUPPLIERACOUNT, CONVICT, CREDITOR, NOTES, accountid, WORKHOURS,
                       WEEKEND, SALEADMIN, CREDITLIMIT, CREDITPEROID, PAYPEROID
FROM         SUPPLIERS_CUSTOMERS
WHERE     (SUP_CUST_TYPE = 3) OR  (SUP_CUST_TYPE = @SUP_CUST_TYPE)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSSelect
AS
	SET NOCOUNT ON;
SELECT     SUP_CUST_ID, SUP_CUST_CODE, SUP_CUST_FNAME, SUP_CUST_SNAME, SUP_CUST_TYPE, ADMIN_NAME, ADMIN_TITLE, ADDRESS, CITY, 
                      GOVERNERATE, COUNTRY, PHONE1, PHONE2, FAX, POSTOFFICE, EMAIL, SUPPLIERACOUNT, CONVICT, CREDITOR, NOTES, accountid, WORKHOURS,
                       WEEKEND, SALEADMIN, CREDITLIMIT, CREDITPEROID, PAYPEROID
FROM         SUPPLIERS_CUSTOMERS









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SUPPLIERS_CUSTOMERSUpdate
(
	@SUP_CUST_CODE nvarchar(50),
	@SUP_CUST_FNAME nvarchar(100),
	@SUP_CUST_SNAME nvarchar(100),
	@SUP_CUST_TYPE int,
	@ADMIN_NAME nvarchar(60),
	@ADMIN_TITLE nvarchar(60),
	@ADDRESS nvarchar(60),
	@CITY nvarchar(15),
	@GOVERNERATE nvarchar(15),
	@COUNTRY nvarchar(15),
	@PHONE1 nvarchar(24),
	@PHONE2 nvarchar(24),
	@FAX nvarchar(24),
	@POSTOFFICE nvarchar(50),
	@EMAIL nvarchar(100),
	@SUPPLIERACOUNT float,
	@CONVICT float,
	@CREDITOR float,
	@NOTES ntext,
	@accountid bigint,
	@WORKHOURS nvarchar(100),
	@WEEKEND nvarchar(80),
	@SALEADMIN bigint,
	@CREDITLIMIT money,
	@CREDITPEROID numeric(18, 0),
	@PAYPEROID numeric(18, 0),
	@Original_SUP_CUST_ID bigint,
	@IsNull_SUP_CUST_CODE nvarchar(50),
	@Original_SUP_CUST_CODE nvarchar(50),
	@IsNull_SUP_CUST_FNAME nvarchar(100),
	@Original_SUP_CUST_FNAME nvarchar(100),
	@IsNull_SUP_CUST_SNAME nvarchar(100),
	@Original_SUP_CUST_SNAME nvarchar(100),
	@IsNull_SUP_CUST_TYPE int,
	@Original_SUP_CUST_TYPE int,
	@IsNull_ADMIN_NAME nvarchar(60),
	@Original_ADMIN_NAME nvarchar(60),
	@IsNull_ADMIN_TITLE nvarchar(60),
	@Original_ADMIN_TITLE nvarchar(60),
	@IsNull_ADDRESS nvarchar(60),
	@Original_ADDRESS nvarchar(60),
	@IsNull_CITY nvarchar(15),
	@Original_CITY nvarchar(15),
	@IsNull_GOVERNERATE nvarchar(15),
	@Original_GOVERNERATE nvarchar(15),
	@IsNull_COUNTRY nvarchar(15),
	@Original_COUNTRY nvarchar(15),
	@IsNull_PHONE1 nvarchar(24),
	@Original_PHONE1 nvarchar(24),
	@IsNull_PHONE2 nvarchar(24),
	@Original_PHONE2 nvarchar(24),
	@IsNull_FAX nvarchar(24),
	@Original_FAX nvarchar(24),
	@IsNull_POSTOFFICE nvarchar(50),
	@Original_POSTOFFICE nvarchar(50),
	@IsNull_EMAIL nvarchar(100),
	@Original_EMAIL nvarchar(100),
	@IsNull_SUPPLIERACOUNT float,
	@Original_SUPPLIERACOUNT float,
	@IsNull_CONVICT float,
	@Original_CONVICT float,
	@IsNull_CREDITOR float,
	@Original_CREDITOR float,
	@IsNull_accountid bigint,
	@Original_accountid bigint,
	@IsNull_WORKHOURS nvarchar(100),
	@Original_WORKHOURS nvarchar(100),
	@IsNull_WEEKEND nvarchar(80),
	@Original_WEEKEND nvarchar(80),
	@IsNull_SALEADMIN bigint,
	@Original_SALEADMIN bigint,
	@IsNull_CREDITLIMIT money,
	@Original_CREDITLIMIT money,
	@IsNull_CREDITPEROID numeric(18, 0),
	@Original_CREDITPEROID numeric(18, 0),
	@IsNull_PAYPEROID numeric(18, 0),
	@Original_PAYPEROID numeric(18, 0),
	@SUP_CUST_ID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [SUPPLIERS_CUSTOMERS] SET [SUP_CUST_CODE] = @SUP_CUST_CODE, [SUP_CUST_FNAME] = @SUP_CUST_FNAME, [SUP_CUST_SNAME] = @SUP_CUST_SNAME, [SUP_CUST_TYPE] = @SUP_CUST_TYPE, [ADMIN_NAME] = @ADMIN_NAME, [ADMIN_TITLE] = @ADMIN_TITLE, [ADDRESS] = @ADDRESS, [CITY] = @CITY, [GOVERNERATE] = @GOVERNERATE, [COUNTRY] = @COUNTRY, [PHONE1] = @PHONE1, [PHONE2] = @PHONE2, [FAX] = @FAX, [POSTOFFICE] = @POSTOFFICE, [EMAIL] = @EMAIL, [SUPPLIERACOUNT] = @SUPPLIERACOUNT, [CONVICT] = @CONVICT, [CREDITOR] = @CREDITOR, [NOTES] = @NOTES, [accountid] = @accountid, [WORKHOURS] = @WORKHOURS, [WEEKEND] = @WEEKEND, [SALEADMIN] = @SALEADMIN, [CREDITLIMIT] = @CREDITLIMIT, [CREDITPEROID] = @CREDITPEROID, [PAYPEROID] = @PAYPEROID WHERE (([SUP_CUST_ID] = @Original_SUP_CUST_ID) AND ((@IsNull_SUP_CUST_CODE = 1 AND [SUP_CUST_CODE] IS NULL) OR ([SUP_CUST_CODE] = @Original_SUP_CUST_CODE)) AND ((@IsNull_SUP_CUST_FNAME = 1 AND [SUP_CUST_FNAME] IS NULL) OR ([SUP_CUST_FNAME] = @Original_SUP_CUST_FNAME)) AND ((@IsNull_SUP_CUST_SNAME = 1 AND [SUP_CUST_SNAME] IS NULL) OR ([SUP_CUST_SNAME] = @Original_SUP_CUST_SNAME)) AND ((@IsNull_SUP_CUST_TYPE = 1 AND [SUP_CUST_TYPE] IS NULL) OR ([SUP_CUST_TYPE] = @Original_SUP_CUST_TYPE)) AND ((@IsNull_ADMIN_NAME = 1 AND [ADMIN_NAME] IS NULL) OR ([ADMIN_NAME] = @Original_ADMIN_NAME)) AND ((@IsNull_ADMIN_TITLE = 1 AND [ADMIN_TITLE] IS NULL) OR ([ADMIN_TITLE] = @Original_ADMIN_TITLE)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_CITY = 1 AND [CITY] IS NULL) OR ([CITY] = @Original_CITY)) AND ((@IsNull_GOVERNERATE = 1 AND [GOVERNERATE] IS NULL) OR ([GOVERNERATE] = @Original_GOVERNERATE)) AND ((@IsNull_COUNTRY = 1 AND [COUNTRY] IS NULL) OR ([COUNTRY] = @Original_COUNTRY)) AND ((@IsNull_PHONE1 = 1 AND [PHONE1] IS NULL) OR ([PHONE1] = @Original_PHONE1)) AND ((@IsNull_PHONE2 = 1 AND [PHONE2] IS NULL) OR ([PHONE2] = @Original_PHONE2)) AND ((@IsNull_FAX = 1 AND [FAX] IS NULL) OR ([FAX] = @Original_FAX)) AND ((@IsNull_POSTOFFICE = 1 AND [POSTOFFICE] IS NULL) OR ([POSTOFFICE] = @Original_POSTOFFICE)) AND ((@IsNull_EMAIL = 1 AND [EMAIL] IS NULL) OR ([EMAIL] = @Original_EMAIL)) AND ((@IsNull_SUPPLIERACOUNT = 1 AND [SUPPLIERACOUNT] IS NULL) OR ([SUPPLIERACOUNT] = @Original_SUPPLIERACOUNT)) AND ((@IsNull_CONVICT = 1 AND [CONVICT] IS NULL) OR ([CONVICT] = @Original_CONVICT)) AND ((@IsNull_CREDITOR = 1 AND [CREDITOR] IS NULL) OR ([CREDITOR] = @Original_CREDITOR)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_WORKHOURS = 1 AND [WORKHOURS] IS NULL) OR ([WORKHOURS] = @Original_WORKHOURS)) AND ((@IsNull_WEEKEND = 1 AND [WEEKEND] IS NULL) OR ([WEEKEND] = @Original_WEEKEND)) AND ((@IsNull_SALEADMIN = 1 AND [SALEADMIN] IS NULL) OR ([SALEADMIN] = @Original_SALEADMIN)) AND ((@IsNull_CREDITLIMIT = 1 AND [CREDITLIMIT] IS NULL) OR ([CREDITLIMIT] = @Original_CREDITLIMIT)) AND ((@IsNull_CREDITPEROID = 1 AND [CREDITPEROID] IS NULL) OR ([CREDITPEROID] = @Original_CREDITPEROID)) AND ((@IsNull_PAYPEROID = 1 AND [PAYPEROID] IS NULL) OR ([PAYPEROID] = @Original_PAYPEROID)));
	
SELECT SUP_CUST_ID, SUP_CUST_CODE, SUP_CUST_FNAME, SUP_CUST_SNAME, SUP_CUST_TYPE, ADMIN_NAME, ADMIN_TITLE, ADDRESS, CITY, GOVERNERATE, COUNTRY, PHONE1, PHONE2, FAX, POSTOFFICE, EMAIL, SUPPLIERACOUNT, CONVICT, CREDITOR, NOTES, accountid, WORKHOURS, WEEKEND, SALEADMIN, CREDITLIMIT, CREDITPEROID, PAYPEROID FROM SUPPLIERS_CUSTOMERS WHERE (SUP_CUST_ID = @SUP_CUST_ID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_SelectAllAccounts
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, 
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo
FROM         accounting







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_SelectBRANCHESById
(
	@BRANCHCODE bigint
)
AS
	SET NOCOUNT ON;
SELECT     BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, salesaccid, purchaseaccid, boxaccid, 
                      bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, OtherComaccid, salesAgalaccid,purchaseAgalaaccid
FROM         BRANCHES
WHERE     (BRANCHCODE = @BRANCHCODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SelectCostClosedTo
AS
	SET NOCOUNT ON;
SELECT     costid, costName, costCode, costSName, costparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, 
                      costType, ClosedTo, MainNode, ProcessFlag, display_Flag
FROM         CostCenters
WHERE     (costType = 2)
ORDER BY costid DESC









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SelectInvoiceOrders
AS
	SET NOCOUNT ON;
SELECT     InvId, OrderId, InvDate
FROM         InvoiceOrders








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SelectInvoiceOrdersbyInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     InvId, OrderId, InvDate
FROM         InvoiceOrders
WHERE     (InvId = @InvId)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SelectProductUints
(
	@ProductId bigint
)
AS
	SET NOCOUNT ON;
SELECT     CDE_UNIT_TYPES.UINTID, CDE_UNIT_TYPES.UNITDESC
FROM         CDE_UNIT_TYPES INNER JOIN
                      Product_Units_Prices ON CDE_UNIT_TYPES.UINTID = Product_Units_Prices.UintId
WHERE     (Product_Units_Prices.productid = @ProductId)
order by MainUnit desc







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_SelectQidByInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, 
                      ReorderInvId, PaymentType,PaymentTo
FROM         qids
WHERE     (InvId = @InvId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO






CREATE PROCEDURE dbo.usp_SelectQidDerialsById
(
	@QidId bigint
)
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId, Machineid
FROM         qidsDetails
WHERE     (qidid = @QidId)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SelectViewAllProducts
AS

SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, SUP_CUST_FNAME, UNITDESC, ProductName, QUANTITY,  LastSalePrice, LastBuyPrice
FROM         InvProductsMoveVIEW









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SetupCodesDelete
(
	@Original_Id bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [SetupCodes] WHERE (([Id] = @Original_Id))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SetupCodesInsert
(
	@SupCode varchar(50),
	@CustCode varchar(50),
	@invSaleCode varchar(50),
	@InvpurchasesCode varchar(50),
	@StoresCode varchar(50),
	@ACCountCode varchar(50),
	@Qid varchar(50),
	@QidIn varchar(50),
	@QidOut varchar(50),
	@EmpCode varchar(50),
	@SalInvSerial bigint,
	@PurchInvSerial bigint,
	@InQidSerial bigint,
	@OutQidSerial bigint,
	@QidSeial bigint,
	@BranchCode varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [SetupCodes] ([SupCode], [CustCode], [invSaleCode], [InvpurchasesCode], [StoresCode], [ACCountCode], [Qid], [QidIn], [QidOut], [EmpCode], [SalInvSerial], [PurchInvSerial], [InQidSerial], [OutQidSerial], [QidSeial], [BranchCode]) VALUES (@SupCode, @CustCode, @invSaleCode, @InvpurchasesCode, @StoresCode, @ACCountCode, @Qid, @QidIn, @QidOut, @EmpCode, @SalInvSerial, @PurchInvSerial, @InQidSerial, @OutQidSerial, @QidSeial, @BranchCode);
	
SELECT Id, SupCode, CustCode, invSaleCode, InvpurchasesCode, StoresCode, ACCountCode, Qid, QidIn, QidOut, EmpCode, SalInvSerial, PurchInvSerial, InQidSerial, OutQidSerial, QidSeial, BranchCode FROM SetupCodes WHERE (Id = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SetupCodesSelect
AS
	SET NOCOUNT ON;
SELECT     Id, SupCode, CustCode, invSaleCode, InvpurchasesCode, StoresCode, ACCountCode, Qid, QidIn, QidOut, EmpCode, SalInvSerial, PurchInvSerial, 
                      InQidSerial, OutQidSerial, QidSeial, BranchCode
FROM         SetupCodes









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_SetupCodesUpdate
(
	@SupCode varchar(50),
	@CustCode varchar(50),
	@invSaleCode varchar(50),
	@InvpurchasesCode varchar(50),
	@StoresCode varchar(50),
	@ACCountCode varchar(50),
	@Qid varchar(50),
	@QidIn varchar(50),
	@QidOut varchar(50),
	@EmpCode varchar(50),
	@SalInvSerial bigint,
	@PurchInvSerial bigint,
	@InQidSerial bigint,
	@OutQidSerial bigint,
	@QidSeial bigint,
	@BranchCode varchar(50),
	@Original_Id bigint,
	@Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [SetupCodes] SET [SupCode] = @SupCode, [CustCode] = @CustCode, [invSaleCode] = @invSaleCode, [InvpurchasesCode] = @InvpurchasesCode, [StoresCode] = @StoresCode, [ACCountCode] = @ACCountCode, [Qid] = @Qid, [QidIn] = @QidIn, [QidOut] = @QidOut, [EmpCode] = @EmpCode, [SalInvSerial] = @SalInvSerial, [PurchInvSerial] = @PurchInvSerial, [InQidSerial] = @InQidSerial, [OutQidSerial] = @OutQidSerial, [QidSeial] = @QidSeial, [BranchCode] = @BranchCode WHERE (([Id] = @Original_Id));
	
SELECT Id, SupCode, CustCode, invSaleCode, InvpurchasesCode, StoresCode, ACCountCode, Qid, QidIn, QidOut, EmpCode, SalInvSerial, PurchInvSerial, InQidSerial, OutQidSerial, QidSeial, BranchCode FROM SetupCodes WHERE (Id = @Id)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_StockCheckQtyByProductId
(
	@UnitID bigint,
	@Productd bigint,
	@STOREID bigint
)
AS
	SET NOCOUNT ON;
SELECT        ISNULL(SUM(QUANTITY), 0) AS TotalQty
FROM            STOCK
WHERE        (UnitID = @UnitID) AND (PRODUCTID = @Productd) AND (STOREID = @STOREID)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_StockDelete
(
	@Original_StockId bigint,
	@Original_STOREID bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@IsNull_QUANTITY float,
	@Original_QUANTITY float,
	@IsNull_MovmentQty float,
	@Original_MovmentQty float,
	@IsNull_MaxQty float,
	@Original_MaxQty float,
	@IsNull_visitationQty float,
	@Original_visitationQty float,
	@IsNull_Related bit,
	@Original_Related bit,
	@IsNull_OrderQTY float,
	@Original_OrderQTY float,
	@IsNull_QtyInStore float,
	@Original_QtyInStore float,
	@IsNull_QtyINRoad float,
	@Original_QtyINRoad float,
	@IsNull_QtynotAmount float,
	@Original_QtynotAmount float,
	@IsNull_QtyNotProchuse float,
	@Original_QtyNotProchuse float,
	@IsNull_QtyNotCost float,
	@Original_QtyNotCost float,
	@IsNull_QtyNotSale float,
	@Original_QtyNotSale float
)
AS
	SET NOCOUNT OFF;
DELETE FROM [STOCK] WHERE (([StockId] = @Original_StockId) AND ([STOREID] = @Original_STOREID) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ((@IsNull_QUANTITY = 1 AND [QUANTITY] IS NULL) OR ([QUANTITY] = @Original_QUANTITY)) AND ((@IsNull_MovmentQty = 1 AND [MovmentQty] IS NULL) OR ([MovmentQty] = @Original_MovmentQty)) AND ((@IsNull_MaxQty = 1 AND [MaxQty] IS NULL) OR ([MaxQty] = @Original_MaxQty)) AND ((@IsNull_visitationQty = 1 AND [visitationQty] IS NULL) OR ([visitationQty] = @Original_visitationQty)) AND ((@IsNull_Related = 1 AND [Related] IS NULL) OR ([Related] = @Original_Related)) AND ((@IsNull_OrderQTY = 1 AND [OrderQTY] IS NULL) OR ([OrderQTY] = @Original_OrderQTY)) AND ((@IsNull_QtyInStore = 1 AND [QtyInStore] IS NULL) OR ([QtyInStore] = @Original_QtyInStore)) AND ((@IsNull_QtyINRoad = 1 AND [QtyINRoad] IS NULL) OR ([QtyINRoad] = @Original_QtyINRoad)) AND ((@IsNull_QtynotAmount = 1 AND [QtynotAmount] IS NULL) OR ([QtynotAmount] = @Original_QtynotAmount)) AND ((@IsNull_QtyNotProchuse = 1 AND [QtyNotProchuse] IS NULL) OR ([QtyNotProchuse] = @Original_QtyNotProchuse)) AND ((@IsNull_QtyNotCost = 1 AND [QtyNotCost] IS NULL) OR ([QtyNotCost] = @Original_QtyNotCost)) AND ((@IsNull_QtyNotSale = 1 AND [QtyNotSale] IS NULL) OR ([QtyNotSale] = @Original_QtyNotSale)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_StockInsert
(
	@STOREID bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@QUANTITY float,
	@MovmentQty float,
	@MaxQty float,
	@visitationQty float,
	@Related bit,
	@OrderQTY float,
	@QtyInStore float,
	@QtyINRoad float,
	@QtynotAmount float,
	@QtyNotProchuse float,
	@QtyNotCost float,
	@QtyNotSale float
)
AS
	SET NOCOUNT OFF;
INSERT INTO [STOCK] ([STOREID], [PRODUCTID], [UnitID], [QUANTITY], [MovmentQty], [MaxQty], [visitationQty], [Related], [OrderQTY], [QtyInStore], [QtyINRoad], [QtynotAmount], [QtyNotProchuse], [QtyNotCost], [QtyNotSale]) VALUES (@STOREID, @PRODUCTID, @UnitID, @QUANTITY, @MovmentQty, @MaxQty, @visitationQty, @Related, @OrderQTY, @QtyInStore, @QtyINRoad, @QtynotAmount, @QtyNotProchuse, @QtyNotCost, @QtyNotSale);
	
SELECT StockId, STOREID, PRODUCTID, UnitID, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, OrderQTY, QtyInStore, QtyINRoad, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale FROM STOCK WHERE (PRODUCTID = @PRODUCTID) AND (STOREID = @STOREID) AND (UnitID = @UnitID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StockMovementDelete
(
	@Original_MoveId bigint,
	@Original_MoveCode varchar(100),
	@IsNull_STOREFromID bigint,
	@Original_STOREFromID bigint,
	@IsNull_STOREToID bigint,
	@Original_STOREToID bigint,
	@IsNull_UserId bigint,
	@Original_UserId bigint,
	@IsNull_EnterDate smalldatetime,
	@Original_EnterDate smalldatetime,
	@IsNull_Notes varchar(400),
	@Original_Notes varchar(400),
	@IsNull_BranchId bigint,
	@Original_BranchId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [StockMovement] WHERE (([MoveId] = @Original_MoveId) AND ([MoveCode] = @Original_MoveCode) AND ((@IsNull_STOREFromID = 1 AND [STOREFromID] IS NULL) OR ([STOREFromID] = @Original_STOREFromID)) AND ((@IsNull_STOREToID = 1 AND [STOREToID] IS NULL) OR ([STOREToID] = @Original_STOREToID)) AND ((@IsNull_UserId = 1 AND [UserId] IS NULL) OR ([UserId] = @Original_UserId)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StockMovementInsert
(
	@MoveCode varchar(100),
	@STOREFromID bigint,
	@STOREToID bigint,
	@UserId bigint,
	@EnterDate smalldatetime,
	@Notes varchar(400),
	@BranchId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [StockMovement] ([MoveCode], [STOREFromID], [STOREToID], [UserId], [EnterDate], [Notes], [BranchId]) VALUES (@MoveCode, @STOREFromID, @STOREToID, @UserId, @EnterDate, @Notes, @BranchId);
	
SELECT MoveId, MoveCode, STOREFromID, STOREToID, UserId, EnterDate, Notes, BranchId FROM StockMovement WHERE (MoveId = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StockMovementSelect
AS
	SET NOCOUNT ON;
SELECT     MoveId, MoveCode, STOREFromID, STOREToID, UserId, EnterDate, Notes, BranchId
FROM         StockMovement







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StockMovementUpdate
(
	@MoveCode varchar(100),
	@STOREFromID bigint,
	@STOREToID bigint,
	@UserId bigint,
	@EnterDate smalldatetime,
	@Notes varchar(400),
	@BranchId bigint,
	@Original_MoveId bigint,
	@Original_MoveCode varchar(100),
	@IsNull_STOREFromID bigint,
	@Original_STOREFromID bigint,
	@IsNull_STOREToID bigint,
	@Original_STOREToID bigint,
	@IsNull_UserId bigint,
	@Original_UserId bigint,
	@IsNull_EnterDate smalldatetime,
	@Original_EnterDate smalldatetime,
	@IsNull_Notes varchar(400),
	@Original_Notes varchar(400),
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@MoveId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [StockMovement] SET [MoveCode] = @MoveCode, [STOREFromID] = @STOREFromID, [STOREToID] = @STOREToID, [UserId] = @UserId, [EnterDate] = @EnterDate, [Notes] = @Notes, [BranchId] = @BranchId WHERE (([MoveId] = @Original_MoveId) AND ([MoveCode] = @Original_MoveCode) AND ((@IsNull_STOREFromID = 1 AND [STOREFromID] IS NULL) OR ([STOREFromID] = @Original_STOREFromID)) AND ((@IsNull_STOREToID = 1 AND [STOREToID] IS NULL) OR ([STOREToID] = @Original_STOREToID)) AND ((@IsNull_UserId = 1 AND [UserId] IS NULL) OR ([UserId] = @Original_UserId)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)));
	
SELECT MoveId, MoveCode, STOREFromID, STOREToID, UserId, EnterDate, Notes, BranchId FROM StockMovement WHERE (MoveId = @MoveId)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StockMovementViewSelect
AS
	SET NOCOUNT ON;
SELECT     DetId, MoveId, PRODUCTID, UnitID, MovmentQty, MoveCode, STOREFromID, STOREToID, UserId, EnterDate, Notes, BranchId
FROM         StockMovementView







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_StockSelect
AS
	SET NOCOUNT ON;
SELECT     StockId, STOREID, PRODUCTID, UnitID, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, OrderQTY, QtyInStore, QtyINRoad, QtynotAmount, 
                      QtyNotProchuse, QtyNotCost, QtyNotSale
FROM         STOCK









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_StockSelectByMainUnit
AS
	SET NOCOUNT ON;
SELECT     dbo.STOCK.StockId, dbo.STOCK.STOREID, dbo.STOCK.PRODUCTID, dbo.STOCK.UnitID, dbo.STOCK.QUANTITY, dbo.STOCK.MovmentQty, 
                      dbo.STOCK.MaxQty, dbo.STOCK.visitationQty, dbo.STOCK.Related, dbo.STOCK.OrderQTY, dbo.STOCK.QtyInStore, dbo.STOCK.QtyINRoad, 
                      dbo.STOCK.QtynotAmount, dbo.STOCK.QtyNotProchuse, dbo.STOCK.QtyNotCost, dbo.STOCK.QtyNotSale
FROM         dbo.STOCK INNER JOIN
                      dbo.Product_Units_Prices ON dbo.STOCK.PRODUCTID = dbo.Product_Units_Prices.productid AND 
                      dbo.STOCK.UnitID = dbo.Product_Units_Prices.UintId
WHERE     (dbo.Product_Units_Prices.MainUnit = 1)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_StockUpdate
(
	@STOREID bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@QUANTITY float,
	@MovmentQty float,
	@MaxQty float,
	@visitationQty float,
	@Related bit,
	@OrderQTY float,
	@QtyInStore float,
	@QtyINRoad float,
	@QtynotAmount float,
	@QtyNotProchuse float,
	@QtyNotCost float,
	@QtyNotSale float,
	@Original_StockId bigint,
	@Original_STOREID bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@IsNull_QUANTITY float,
	@Original_QUANTITY float,
	@IsNull_MovmentQty float,
	@Original_MovmentQty float,
	@IsNull_MaxQty float,
	@Original_MaxQty float,
	@IsNull_visitationQty float,
	@Original_visitationQty float,
	@IsNull_Related bit,
	@Original_Related bit,
	@IsNull_OrderQTY float,
	@Original_OrderQTY float,
	@IsNull_QtyInStore float,
	@Original_QtyInStore float,
	@IsNull_QtyINRoad float,
	@Original_QtyINRoad float,
	@IsNull_QtynotAmount float,
	@Original_QtynotAmount float,
	@IsNull_QtyNotProchuse float,
	@Original_QtyNotProchuse float,
	@IsNull_QtyNotCost float,
	@Original_QtyNotCost float,
	@IsNull_QtyNotSale float,
	@Original_QtyNotSale float
)
AS
	SET NOCOUNT OFF;
UPDATE [STOCK] SET [STOREID] = @STOREID, [PRODUCTID] = @PRODUCTID, [UnitID] = @UnitID, [QUANTITY] = @QUANTITY, [MovmentQty] = @MovmentQty, [MaxQty] = @MaxQty, [visitationQty] = @visitationQty, [Related] = @Related, [OrderQTY] = @OrderQTY, [QtyInStore] = @QtyInStore, [QtyINRoad] = @QtyINRoad, [QtynotAmount] = @QtynotAmount, [QtyNotProchuse] = @QtyNotProchuse, [QtyNotCost] = @QtyNotCost, [QtyNotSale] = @QtyNotSale WHERE (([StockId] = @Original_StockId) AND ([STOREID] = @Original_STOREID) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ((@IsNull_QUANTITY = 1 AND [QUANTITY] IS NULL) OR ([QUANTITY] = @Original_QUANTITY)) AND ((@IsNull_MovmentQty = 1 AND [MovmentQty] IS NULL) OR ([MovmentQty] = @Original_MovmentQty)) AND ((@IsNull_MaxQty = 1 AND [MaxQty] IS NULL) OR ([MaxQty] = @Original_MaxQty)) AND ((@IsNull_visitationQty = 1 AND [visitationQty] IS NULL) OR ([visitationQty] = @Original_visitationQty)) AND ((@IsNull_Related = 1 AND [Related] IS NULL) OR ([Related] = @Original_Related)) AND ((@IsNull_OrderQTY = 1 AND [OrderQTY] IS NULL) OR ([OrderQTY] = @Original_OrderQTY)) AND ((@IsNull_QtyInStore = 1 AND [QtyInStore] IS NULL) OR ([QtyInStore] = @Original_QtyInStore)) AND ((@IsNull_QtyINRoad = 1 AND [QtyINRoad] IS NULL) OR ([QtyINRoad] = @Original_QtyINRoad)) AND ((@IsNull_QtynotAmount = 1 AND [QtynotAmount] IS NULL) OR ([QtynotAmount] = @Original_QtynotAmount)) AND ((@IsNull_QtyNotProchuse = 1 AND [QtyNotProchuse] IS NULL) OR ([QtyNotProchuse] = @Original_QtyNotProchuse)) AND ((@IsNull_QtyNotCost = 1 AND [QtyNotCost] IS NULL) OR ([QtyNotCost] = @Original_QtyNotCost)) AND ((@IsNull_QtyNotSale = 1 AND [QtyNotSale] IS NULL) OR ([QtyNotSale] = @Original_QtyNotSale)));
	
SELECT StockId, STOREID, PRODUCTID, UnitID, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, OrderQTY, QtyInStore, QtyINRoad, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale FROM STOCK WHERE (PRODUCTID = @PRODUCTID) AND (STOREID = @STOREID) AND (UnitID = @UnitID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_StockViewSelectbyKey
	@BRANCHCODE bigint,
	@STOREID bigint,
	@PRODUCTBRAND nvarchar(30),
	@productid  bigint,
	@PRODUCTCODE  nvarchar(50),
	@Qty decimal,
	@ToQty decimal
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, STOREID, STORNAME, BRANCHNAME, productname, PRODUCTCODE, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, 
                      OrderQTY, QtyINRoad, QtyInStore, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale, UNITDESC,StockId,lastcostPrice,RealQutantity,THRESHOLDINSTOCK
FROM         StockView
where (BRANCHCODE = @BRANCHCODE OR   @BRANCHCODE IS NULL) AND (STOREID = @STOREID OR   @STOREID IS NULL) 
	 AND (PRODUCTBRAND LIKE @PRODUCTBRAND +  '%'  OR   @PRODUCTBRAND IS NULL) and 
(productid = @productid  or  @productid IS NULL)  and
 (PRODUCTCODE LIKE @PRODUCTCODE +  '%'  OR   @PRODUCTCODE IS NULL)  and (Quantity>=@Qty or @Qty is null) and  (Quantity<=@ToQty or @ToQty is null)
ORDER BY PRODUCTCODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_StockViewkSelect
	@BRANCHCODE bigint,
	@STOREID bigint,
	@PRODUCTBRAND nvarchar(30),
	@productname  nvarchar(150),
	@PRODUCTCODE  nvarchar(50)
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, STOREID, STORNAME, BRANCHNAME, productname, PRODUCTCODE, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, 
                      OrderQTY, QtyINRoad, QtyInStore, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale, UNITDESC,StockId,lastcostPrice,RealQutantity,THRESHOLDINSTOCK
FROM         StockView
where (BRANCHCODE = @BRANCHCODE OR   @BRANCHCODE IS NULL) AND (STOREID = @STOREID OR   @STOREID IS NULL) 
	 AND (PRODUCTBRAND LIKE @PRODUCTBRAND +  '%'  OR   @PRODUCTBRAND IS NULL) and 
(productname LIKE @productname +  '%'  OR   @productname IS NULL)  and
 (PRODUCTCODE LIKE @PRODUCTCODE +  '%'  OR   @PRODUCTCODE IS NULL) 
ORDER BY PRODUCTCODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO









CREATE PROCEDURE dbo.usp_StockViewkSelectByParam
	@BRANCHCODE bigint,
	@STOREID bigint,
	@PRODUCTBRAND nvarchar(30),
	@productname  nvarchar(150),
	@PRODUCTCODE  nvarchar(50),
	@MinSalePrice money,
	@MaxSalePrice money,
	@UnitID bigint
AS
	SET NOCOUNT ON;
SELECT     UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, 
                      MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, 
                      LastBuyPrice, STOREID, STORNAME, BRANCHNAME, productname, PRODUCTCODE, QUANTITY, MovmentQty, MaxQty, visitationQty, Related, 
                      OrderQTY, QtyINRoad, QtyInStore, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale, UNITDESC,StockId,lastcostPrice,RealQutantity,THRESHOLDINSTOCK
FROM         StockView
where (BRANCHCODE = @BRANCHCODE OR   @BRANCHCODE IS NULL) AND (STOREID = @STOREID OR   @STOREID IS NULL) 
	 AND (PRODUCTBRAND LIKE @PRODUCTBRAND +  '%'  OR   @PRODUCTBRAND IS NULL) and 
(productname LIKE @productname +  '%'  OR   @productname IS NULL)  and
 (PRODUCTCODE LIKE @PRODUCTCODE +  '%'  OR   @PRODUCTCODE IS NULL) 
AND (UintId = @UnitID OR   @UnitID IS NULL) AND (CostmerPrice >= @MaxSalePrice OR   @MinSalePrice IS NULL) 
 AND (CostmerPrice <= @MaxSalePrice OR   @MaxSalePrice IS NULL) 
ORDER BY PRODUCTCODE







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StoresDelete
(
	@Original_STOREID bigint,
	@Original_STORECODE nvarchar(50),
	@Original_STORNAME varchar(100),
	@IsNull_BRANCHCODE bigint,
	@Original_BRANCHCODE bigint,
	@IsNull_Notes varchar(200),
	@Original_Notes varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [STORES] WHERE (([STOREID] = @Original_STOREID) AND ([STORECODE] = @Original_STORECODE) AND ([STORNAME] = @Original_STORNAME) AND ((@IsNull_BRANCHCODE = 1 AND [BRANCHCODE] IS NULL) OR ([BRANCHCODE] = @Original_BRANCHCODE)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StoresInsert
(
	@STORECODE nvarchar(50),
	@STORNAME varchar(100),
	@BRANCHCODE bigint,
	@Notes varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [STORES] ([STORECODE], [STORNAME], [BRANCHCODE], [Notes]) VALUES (@STORECODE, @STORNAME, @BRANCHCODE, @Notes);
	
SELECT STOREID, STORECODE, STORNAME, BRANCHCODE, Notes FROM STORES WHERE (STOREID = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StoresSelect
AS
	SET NOCOUNT ON;
SELECT     STOREID, STORECODE, STORNAME, BRANCHCODE, Notes
FROM         STORES







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_StoresUpdate
(
	@STORECODE nvarchar(50),
	@STORNAME varchar(100),
	@BRANCHCODE bigint,
	@Notes varchar(200),
	@Original_STOREID bigint,
	@Original_STORECODE nvarchar(50),
	@Original_STORNAME varchar(100),
	@IsNull_BRANCHCODE bigint,
	@Original_BRANCHCODE bigint,
	@IsNull_Notes varchar(200),
	@Original_Notes varchar(200),
	@STOREID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [STORES] SET [STORECODE] = @STORECODE, [STORNAME] = @STORNAME, [BRANCHCODE] = @BRANCHCODE, [Notes] = @Notes WHERE (([STOREID] = @Original_STOREID) AND ([STORECODE] = @Original_STORECODE) AND ([STORNAME] = @Original_STORNAME) AND ((@IsNull_BRANCHCODE = 1 AND [BRANCHCODE] IS NULL) OR ([BRANCHCODE] = @Original_BRANCHCODE)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)));
	
SELECT STOREID, STORECODE, STORNAME, BRANCHCODE, Notes FROM STORES WHERE (STOREID = @STOREID)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_Suppliers_CustomerAccId
AS
	SET NOCOUNT ON;
SELECT     SUPPLIERS_CUSTOMERS.SUP_CUST_ID, SUPPLIERS_CUSTOMERS.SUP_CUST_CODE, SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, 
                      SUPPLIERS_CUSTOMERS.SUP_CUST_SNAME, SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE, SUPPLIERS_CUSTOMERS.ADMIN_NAME, 
                      SUPPLIERS_CUSTOMERS.ADMIN_TITLE, SUPPLIERS_CUSTOMERS.ADDRESS, SUPPLIERS_CUSTOMERS.CITY, 
                      SUPPLIERS_CUSTOMERS.GOVERNERATE, SUPPLIERS_CUSTOMERS.COUNTRY, SUPPLIERS_CUSTOMERS.PHONE1, 
                      SUPPLIERS_CUSTOMERS.PHONE2, SUPPLIERS_CUSTOMERS.FAX, SUPPLIERS_CUSTOMERS.POSTOFFICE, SUPPLIERS_CUSTOMERS.EMAIL, 
                      SUPPLIERS_CUSTOMERS.SUPPLIERACOUNT, SUPPLIERS_CUSTOMERS.CONVICT, SUPPLIERS_CUSTOMERS.CREDITOR, 
                      SUPPLIERS_CUSTOMERS.NOTES, SUPPLIERS_CUSTOMERS.accountid, SUPPLIERS_CUSTOMERS.WORKHOURS, 
                      SUPPLIERS_CUSTOMERS.WEEKEND, SUPPLIERS_CUSTOMERS.SALEADMIN, SUPPLIERS_CUSTOMERS.CREDITLIMIT, 
                      SUPPLIERS_CUSTOMERS.CREDITPEROID, SUPPLIERS_CUSTOMERS.PAYPEROID
FROM         accounting INNER JOIN
                      SUPPLIERS_CUSTOMERS ON accounting.accountid = SUPPLIERS_CUSTOMERS.accountid









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USERDelete
(
	@Original_ID int,
	@Original_USER_NAME varchar(50),
	@Original_PASSWORD varchar(50),
	@IsNull_STATUS Int,
	@Original_STATUS int,
	@IsNull_USER_TYPE Int,
	@Original_USER_TYPE int,
	@IsNull_MEMBER_ID Int,
	@Original_MEMBER_ID varchar(10),
	@IsNull_Branch Int,
	@Original_Branch bigint,
	@IsNull_Name Int,
	@Original_Name varchar(100),
	@IsNull_BackGround Int,
	@Original_BackGround varchar(300)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [USER] WHERE (([ID] = @Original_ID) AND ([USER_NAME] = @Original_USER_NAME) AND ([PASSWORD] = @Original_PASSWORD) AND ((@IsNull_STATUS = 1 AND [STATUS] IS NULL) OR ([STATUS] = @Original_STATUS)) AND ((@IsNull_USER_TYPE = 1 AND [USER_TYPE] IS NULL) OR ([USER_TYPE] = @Original_USER_TYPE)) AND ((@IsNull_MEMBER_ID = 1 AND [MEMBER_ID] IS NULL) OR ([MEMBER_ID] = @Original_MEMBER_ID)) AND ((@IsNull_Branch = 1 AND [Branch] IS NULL) OR ([Branch] = @Original_Branch)) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_BackGround = 1 AND [BackGround] IS NULL) OR ([BackGround] = @Original_BackGround)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USERInsert
(
	@USER_NAME varchar(50),
	@PASSWORD varchar(50),
	@STATUS int,
	@USER_TYPE int,
	@MEMBER_ID varchar(10),
	@Branch bigint,
	@Name varchar(100),
	@BackGround varchar(300)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [USER] ([USER_NAME], [PASSWORD], [STATUS], [USER_TYPE], [MEMBER_ID], [Branch], [Name], [BackGround]) VALUES (@USER_NAME, @PASSWORD, @STATUS, @USER_TYPE, @MEMBER_ID, @Branch, @Name, @BackGround);
	
SELECT ID, USER_NAME, PASSWORD, STATUS, USER_TYPE, MEMBER_ID, Branch, Name, BackGround FROM [USER] WHERE (ID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USERSelect
AS
	SET NOCOUNT ON;
SELECT     ID, USER_NAME, PASSWORD, STATUS, USER_TYPE, MEMBER_ID, Branch, Name, BackGround
FROM         [USER]









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USERUpdate
(
	@USER_NAME varchar(50),
	@PASSWORD varchar(50),
	@STATUS int,
	@USER_TYPE int,
	@MEMBER_ID varchar(10),
	@Branch bigint,
	@Name varchar(100),
	@BackGround varchar(300),
	@Original_ID int,
	@Original_USER_NAME varchar(50),
	@Original_PASSWORD varchar(50),
	@IsNull_STATUS Int,
	@Original_STATUS int,
	@IsNull_USER_TYPE Int,
	@Original_USER_TYPE int,
	@IsNull_MEMBER_ID Int,
	@Original_MEMBER_ID varchar(10),
	@IsNull_Branch Int,
	@Original_Branch bigint,
	@IsNull_Name Int,
	@Original_Name varchar(100),
	@IsNull_BackGround Int,
	@Original_BackGround varchar(300),
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [USER] SET [USER_NAME] = @USER_NAME, [PASSWORD] = @PASSWORD, [STATUS] = @STATUS, [USER_TYPE] = @USER_TYPE, [MEMBER_ID] = @MEMBER_ID, [Branch] = @Branch, [Name] = @Name, [BackGround] = @BackGround WHERE (([ID] = @Original_ID) AND ([USER_NAME] = @Original_USER_NAME) AND ([PASSWORD] = @Original_PASSWORD) AND ((@IsNull_STATUS = 1 AND [STATUS] IS NULL) OR ([STATUS] = @Original_STATUS)) AND ((@IsNull_USER_TYPE = 1 AND [USER_TYPE] IS NULL) OR ([USER_TYPE] = @Original_USER_TYPE)) AND ((@IsNull_MEMBER_ID = 1 AND [MEMBER_ID] IS NULL) OR ([MEMBER_ID] = @Original_MEMBER_ID)) AND ((@IsNull_Branch = 1 AND [Branch] IS NULL) OR ([Branch] = @Original_Branch)) AND ((@IsNull_Name = 1 AND [Name] IS NULL) OR ([Name] = @Original_Name)) AND ((@IsNull_BackGround = 1 AND [BackGround] IS NULL) OR ([BackGround] = @Original_BackGround)));
	
SELECT ID, USER_NAME, PASSWORD, STATUS, USER_TYPE, MEMBER_ID, Branch, Name, BackGround FROM [USER] WHERE (ID = @ID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONByUserId
(
	@UserId int,
	@FunId int
)
AS
	SET NOCOUNT ON;
SELECT     COUNT(*) AS Tot
FROM         USER_FUNCTION
WHERE     (USER_ID = @UserId) AND (FUNCTION_ID = @FunId)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONDelete
(
	@Original_ID int,
	@Original_USER_ID int,
	@Original_FUNCTION_ID int,
	@IsNull_FOpen bit,
	@Original_FOpen bit,
	@IsNull_FUpdate bit,
	@Original_FUpdate bit,
	@IsNull_FSave bit,
	@Original_FSave bit,
	@IsNull_FDel bit,
	@Original_FDel bit,
	@IsNull_Type int,
	@Original_Type int,
	@IsNull_FCommit bit,
	@Original_FCommit bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [USER_FUNCTION] WHERE (([ID] = @Original_ID) AND ([USER_ID] = @Original_USER_ID) AND ([FUNCTION_ID] = @Original_FUNCTION_ID) AND ((@IsNull_FOpen = 1 AND [FOpen] IS NULL) OR ([FOpen] = @Original_FOpen)) AND ((@IsNull_FUpdate = 1 AND [FUpdate] IS NULL) OR ([FUpdate] = @Original_FUpdate)) AND ((@IsNull_FSave = 1 AND [FSave] IS NULL) OR ([FSave] = @Original_FSave)) AND ((@IsNull_FDel = 1 AND [FDel] IS NULL) OR ([FDel] = @Original_FDel)) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND ((@IsNull_FCommit = 1 AND [FCommit] IS NULL) OR ([FCommit] = @Original_FCommit)))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONInsert
(
	@USER_ID int,
	@FUNCTION_ID int,
	@FOpen bit,
	@FUpdate bit,
	@FSave bit,
	@FDel bit,
	@Type int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [USER_FUNCTION] ([USER_ID], [FUNCTION_ID], [FOpen], [FUpdate], [FSave], [FDel], [Type]) VALUES (@USER_ID, @FUNCTION_ID, @FOpen, @FUpdate, @FSave, @FDel, @Type);
	
SELECT ID, USER_ID, FUNCTION_ID, FOpen, FUpdate, FSave, FDel, Type FROM USER_FUNCTION WHERE (ID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONSelect
AS
	SET NOCOUNT ON;
SELECT     ID, USER_ID, FUNCTION_ID, FOpen, FUpdate, FSave, FDel, Type, FCommit
FROM         USER_FUNCTION









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONUpdate
(
	@USER_ID int,
	@FUNCTION_ID int,
	@FOpen bit,
	@FUpdate bit,
	@FSave bit,
	@FDel bit,
	@Type int,
	@FCommit bit,
	@Original_ID int,
	@Original_USER_ID int,
	@Original_FUNCTION_ID int,
	@IsNull_FOpen bit,
	@Original_FOpen bit,
	@IsNull_FUpdate bit,
	@Original_FUpdate bit,
	@IsNull_FSave bit,
	@Original_FSave bit,
	@IsNull_FDel bit,
	@Original_FDel bit,
	@IsNull_Type int,
	@Original_Type int,
	@IsNull_FCommit bit,
	@Original_FCommit bit,
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE [USER_FUNCTION] SET [USER_ID] = @USER_ID, [FUNCTION_ID] = @FUNCTION_ID, [FOpen] = @FOpen, [FUpdate] = @FUpdate, [FSave] = @FSave, [FDel] = @FDel, [Type] = @Type, [FCommit] = @FCommit WHERE (([ID] = @Original_ID) AND ([USER_ID] = @Original_USER_ID) AND ([FUNCTION_ID] = @Original_FUNCTION_ID) AND ((@IsNull_FOpen = 1 AND [FOpen] IS NULL) OR ([FOpen] = @Original_FOpen)) AND ((@IsNull_FUpdate = 1 AND [FUpdate] IS NULL) OR ([FUpdate] = @Original_FUpdate)) AND ((@IsNull_FSave = 1 AND [FSave] IS NULL) OR ([FSave] = @Original_FSave)) AND ((@IsNull_FDel = 1 AND [FDel] IS NULL) OR ([FDel] = @Original_FDel)) AND ((@IsNull_Type = 1 AND [Type] IS NULL) OR ([Type] = @Original_Type)) AND ((@IsNull_FCommit = 1 AND [FCommit] IS NULL) OR ([FCommit] = @Original_FCommit)));
	
SELECT ID, USER_ID, FUNCTION_ID, FOpen, FUpdate, FSave, FDel, Type, FCommit FROM USER_FUNCTION WHERE (ID = @ID)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_USER_FUNCTIONnsert
(
	@USER_ID int,
	@FUNCTION_ID int,
	@FOpen bit,
	@FUpdate bit,
	@FSave bit,
	@FDel bit,
	@Type int,
	@FCommit bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [USER_FUNCTION] ([USER_ID], [FUNCTION_ID], [FOpen], [FUpdate], [FSave], [FDel], [Type], [FCommit]) VALUES (@USER_ID, @FUNCTION_ID, @FOpen, @FUpdate, @FSave, @FDel, @Type, @FCommit);
	
SELECT ID, USER_ID, FUNCTION_ID, FOpen, FUpdate, FSave, FDel, Type, FCommit FROM USER_FUNCTION WHERE (ID = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UserFunctionsByUserId
(
	@UserId int
)
AS
	SET NOCOUNT ON;
SELECT     ID, USER_ID, FUNCTION_ID, FOpen, FUpdate, FSave, FDel, Type,FCommit
FROM         USER_FUNCTION
WHERE     (USER_ID = @UserId)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UserSelectById
(
	@Id int
)
AS
	SET NOCOUNT ON;
SELECT     ID, USER_NAME, PASSWORD, STATUS, USER_TYPE, MEMBER_ID, Branch, Name, BackGround
FROM         [USER]
WHERE     (ID = @Id)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UserSelectByName
(
	@username varchar(50),
	@pw varchar(50)
)
AS
	SET NOCOUNT ON;
SELECT     ID, USER_NAME, PASSWORD, STATUS, USER_TYPE, MEMBER_ID, Branch, Name,BackGround
FROM         [USER]
WHERE     (USER_NAME = @username) AND (PASSWORD = @pw)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UsersDelete
(
	@Original_userid bigint,
	@IsNull_username nvarchar(20),
	@Original_username nvarchar(20),
	@IsNull_pw nvarchar(20),
	@Original_pw nvarchar(20),
	@Original_sales bit,
	@Original_prinvoice bit,
	@Original_productlist bit,
	@Original_editproduct bit,
	@Original_newproduct bit,
	@Original_reorder bit,
	@Original_deleteinvoice bit,
	@Original_editreorder bit,
	@Original_custlist bit,
	@Original_newcust bit,
	@Original_editcust bit,
	@Original_estimate bit,
	@Original_statement bit,
	@Original_receivemoney bit,
	@Original_supplist bit,
	@Original_editsupp bit,
	@Original_newsupp bit,
	@Original_employees bit,
	@Original_accountlist bit,
	@Original_neweditaccount bit,
	@Original_expenselist bit,
	@Original_neweditexpense bit,
	@Original_journalreport bit,
	@Original_productreport bit,
	@Original_profitreport bit,
	@Original_opencompany bit,
	@Original_createcompany bit,
	@Original_backup bit,
	@Original_users bit,
	@Original_companyinfo bit,
	@Original_editemp bit,
	@Original_newemp bit,
	@Original_sec bit,
	@Original_doc bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [users] WHERE (([userid] = @Original_userid) AND ((@IsNull_username = 1 AND [username] IS NULL) OR ([username] = @Original_username)) AND ((@IsNull_pw = 1 AND [pw] IS NULL) OR ([pw] = @Original_pw)) AND ([sales] = @Original_sales) AND ([prinvoice] = @Original_prinvoice) AND ([productlist] = @Original_productlist) AND ([editproduct] = @Original_editproduct) AND ([newproduct] = @Original_newproduct) AND ([reorder] = @Original_reorder) AND ([deleteinvoice] = @Original_deleteinvoice) AND ([editreorder] = @Original_editreorder) AND ([custlist] = @Original_custlist) AND ([newcust] = @Original_newcust) AND ([editcust] = @Original_editcust) AND ([estimate] = @Original_estimate) AND ([statement] = @Original_statement) AND ([receivemoney] = @Original_receivemoney) AND ([supplist] = @Original_supplist) AND ([editsupp] = @Original_editsupp) AND ([newsupp] = @Original_newsupp) AND ([employees] = @Original_employees) AND ([accountlist] = @Original_accountlist) AND ([neweditaccount] = @Original_neweditaccount) AND ([expenselist] = @Original_expenselist) AND ([neweditexpense] = @Original_neweditexpense) AND ([journalreport] = @Original_journalreport) AND ([productreport] = @Original_productreport) AND ([profitreport] = @Original_profitreport) AND ([opencompany] = @Original_opencompany) AND ([createcompany] = @Original_createcompany) AND ([backup] = @Original_backup) AND ([users] = @Original_users) AND ([companyinfo] = @Original_companyinfo) AND ([editemp] = @Original_editemp) AND ([newemp] = @Original_newemp) AND ([sec] = @Original_sec) AND ([doc] = @Original_doc))









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UsersInsert
(
	@username nvarchar(20),
	@pw nvarchar(20),
	@sales bit,
	@prinvoice bit,
	@productlist bit,
	@editproduct bit,
	@newproduct bit,
	@reorder bit,
	@deleteinvoice bit,
	@editreorder bit,
	@custlist bit,
	@newcust bit,
	@editcust bit,
	@estimate bit,
	@statement bit,
	@receivemoney bit,
	@supplist bit,
	@editsupp bit,
	@newsupp bit,
	@employees bit,
	@accountlist bit,
	@neweditaccount bit,
	@expenselist bit,
	@neweditexpense bit,
	@journalreport bit,
	@productreport bit,
	@profitreport bit,
	@opencompany bit,
	@createcompany bit,
	@backup bit,
	@users bit,
	@companyinfo bit,
	@editemp bit,
	@newemp bit,
	@sec bit,
	@doc bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [users] ([username], [pw], [sales], [prinvoice], [productlist], [editproduct], [newproduct], [reorder], [deleteinvoice], [editreorder], [custlist], [newcust], [editcust], [estimate], [statement], [receivemoney], [supplist], [editsupp], [newsupp], [employees], [accountlist], [neweditaccount], [expenselist], [neweditexpense], [journalreport], [productreport], [profitreport], [opencompany], [createcompany], [backup], [users], [companyinfo], [editemp], [newemp], [sec], [doc]) VALUES (@username, @pw, @sales, @prinvoice, @productlist, @editproduct, @newproduct, @reorder, @deleteinvoice, @editreorder, @custlist, @newcust, @editcust, @estimate, @statement, @receivemoney, @supplist, @editsupp, @newsupp, @employees, @accountlist, @neweditaccount, @expenselist, @neweditexpense, @journalreport, @productreport, @profitreport, @opencompany, @createcompany, @backup, @users, @companyinfo, @editemp, @newemp, @sec, @doc);
	
SELECT userid, username, pw, sales, prinvoice, productlist, editproduct, newproduct, reorder, deleteinvoice, editreorder, custlist, newcust, editcust, estimate, statement, receivemoney, supplist, editsupp, newsupp, employees, accountlist, neweditaccount, expenselist, neweditexpense, journalreport, productreport, profitreport, opencompany, createcompany, [backup], users, companyinfo, editemp, newemp, sec, doc FROM users WHERE (userid = SCOPE_IDENTITY())









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UsersSelect
AS
	SET NOCOUNT ON;
SELECT     userid, username, pw, sales, prinvoice, productlist, editproduct, newproduct, reorder, deleteinvoice, editreorder, custlist, newcust, editcust, estimate, 
                      statement, receivemoney, supplist, editsupp, newsupp, employees, accountlist, neweditaccount, expenselist, neweditexpense, journalreport, 
                      productreport, profitreport, opencompany, createcompany, [backup], users, companyinfo, editemp, newemp, sec, doc
FROM         users









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO









CREATE PROCEDURE dbo.usp_UsersUpdate
(
	@username nvarchar(20),
	@pw nvarchar(20),
	@sales bit,
	@prinvoice bit,
	@productlist bit,
	@editproduct bit,
	@newproduct bit,
	@reorder bit,
	@deleteinvoice bit,
	@editreorder bit,
	@custlist bit,
	@newcust bit,
	@editcust bit,
	@estimate bit,
	@statement bit,
	@receivemoney bit,
	@supplist bit,
	@editsupp bit,
	@newsupp bit,
	@employees bit,
	@accountlist bit,
	@neweditaccount bit,
	@expenselist bit,
	@neweditexpense bit,
	@journalreport bit,
	@productreport bit,
	@profitreport bit,
	@opencompany bit,
	@createcompany bit,
	@backup bit,
	@users bit,
	@companyinfo bit,
	@editemp bit,
	@newemp bit,
	@sec bit,
	@doc bit,
	@Original_userid bigint,
	@IsNull_username nvarchar(20),
	@Original_username nvarchar(20),
	@IsNull_pw nvarchar(20),
	@Original_pw nvarchar(20),
	@Original_sales bit,
	@Original_prinvoice bit,
	@Original_productlist bit,
	@Original_editproduct bit,
	@Original_newproduct bit,
	@Original_reorder bit,
	@Original_deleteinvoice bit,
	@Original_editreorder bit,
	@Original_custlist bit,
	@Original_newcust bit,
	@Original_editcust bit,
	@Original_estimate bit,
	@Original_statement bit,
	@Original_receivemoney bit,
	@Original_supplist bit,
	@Original_editsupp bit,
	@Original_newsupp bit,
	@Original_employees bit,
	@Original_accountlist bit,
	@Original_neweditaccount bit,
	@Original_expenselist bit,
	@Original_neweditexpense bit,
	@Original_journalreport bit,
	@Original_productreport bit,
	@Original_profitreport bit,
	@Original_opencompany bit,
	@Original_createcompany bit,
	@Original_backup bit,
	@Original_users bit,
	@Original_companyinfo bit,
	@Original_editemp bit,
	@Original_newemp bit,
	@Original_sec bit,
	@Original_doc bit,
	@userid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [users] SET [username] = @username, [pw] = @pw, [sales] = @sales, [prinvoice] = @prinvoice, [productlist] = @productlist, [editproduct] = @editproduct, [newproduct] = @newproduct, [reorder] = @reorder, [deleteinvoice] = @deleteinvoice, [editreorder] = @editreorder, [custlist] = @custlist, [newcust] = @newcust, [editcust] = @editcust, [estimate] = @estimate, [statement] = @statement, [receivemoney] = @receivemoney, [supplist] = @supplist, [editsupp] = @editsupp, [newsupp] = @newsupp, [employees] = @employees, [accountlist] = @accountlist, [neweditaccount] = @neweditaccount, [expenselist] = @expenselist, [neweditexpense] = @neweditexpense, [journalreport] = @journalreport, [productreport] = @productreport, [profitreport] = @profitreport, [opencompany] = @opencompany, [createcompany] = @createcompany, [backup] = @backup, [users] = @users, [companyinfo] = @companyinfo, [editemp] = @editemp, [newemp] = @newemp, [sec] = @sec, [doc] = @doc WHERE (([userid] = @Original_userid) AND ((@IsNull_username = 1 AND [username] IS NULL) OR ([username] = @Original_username)) AND ((@IsNull_pw = 1 AND [pw] IS NULL) OR ([pw] = @Original_pw)) AND ([sales] = @Original_sales) AND ([prinvoice] = @Original_prinvoice) AND ([productlist] = @Original_productlist) AND ([editproduct] = @Original_editproduct) AND ([newproduct] = @Original_newproduct) AND ([reorder] = @Original_reorder) AND ([deleteinvoice] = @Original_deleteinvoice) AND ([editreorder] = @Original_editreorder) AND ([custlist] = @Original_custlist) AND ([newcust] = @Original_newcust) AND ([editcust] = @Original_editcust) AND ([estimate] = @Original_estimate) AND ([statement] = @Original_statement) AND ([receivemoney] = @Original_receivemoney) AND ([supplist] = @Original_supplist) AND ([editsupp] = @Original_editsupp) AND ([newsupp] = @Original_newsupp) AND ([employees] = @Original_employees) AND ([accountlist] = @Original_accountlist) AND ([neweditaccount] = @Original_neweditaccount) AND ([expenselist] = @Original_expenselist) AND ([neweditexpense] = @Original_neweditexpense) AND ([journalreport] = @Original_journalreport) AND ([productreport] = @Original_productreport) AND ([profitreport] = @Original_profitreport) AND ([opencompany] = @Original_opencompany) AND ([createcompany] = @Original_createcompany) AND ([backup] = @Original_backup) AND ([users] = @Original_users) AND ([companyinfo] = @Original_companyinfo) AND ([editemp] = @Original_editemp) AND ([newemp] = @Original_newemp) AND ([sec] = @Original_sec) AND ([doc] = @Original_doc));
	
SELECT userid, username, pw, sales, prinvoice, productlist, editproduct, newproduct, reorder, deleteinvoice, editreorder, custlist, newcust, editcust, estimate, statement, receivemoney, supplist, editsupp, newsupp, employees, accountlist, neweditaccount, expenselist, neweditexpense, journalreport, productreport, profitreport, opencompany, createcompany, [backup], users, companyinfo, editemp, newemp, sec, doc FROM users WHERE (userid = @userid)









GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_VAC_SUB_CLASSDelete
(
	@Original_VAC_TYPE_CODE numeric,
	@Original_VAC_TYPE_DESC varchar(200),
	@IsNull_MAX_NUM Int,
	@Original_MAX_NUM numeric(6, 0),
	@IsNull_FEM_FLAG Int,
	@Original_FEM_FLAG varchar(1),
	@IsNull_CALE_CYCLE Int,
	@Original_CALE_CYCLE numeric(3, 0),
	@IsNull_DEC_FLAG Int,
	@Original_DEC_FLAG bit,
	@IsNull_ACCUM_FLAG Int,
	@Original_ACCUM_FLAG varchar(1),
	@IsNull_MAX_DUR_ONCE Int,
	@Original_MAX_DUR_ONCE numeric(6, 0),
	@IsNull_MAX_DUR Int,
	@Original_MAX_DUR numeric(6, 0),
	@IsNull_SAL_DED_PERCENT Int,
	@Original_SAL_DED_PERCENT numeric(6, 0),
	@IsNull_BALANCE_FLAG Int,
	@Original_BALANCE_FLAG numeric(1, 0),
	@IsNull_VACATION_CLASS_CODE Int,
	@Original_VACATION_CLASS_CODE numeric(5, 0),
	@IsNull_PERIOD_FLAG Int,
	@Original_PERIOD_FLAG bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [CDE_PER_VAC_SUB_CLASS] WHERE (([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([VAC_TYPE_DESC] = @Original_VAC_TYPE_DESC) AND ((@IsNull_MAX_NUM = 1 AND [MAX_NUM] IS NULL) OR ([MAX_NUM] = @Original_MAX_NUM)) AND ((@IsNull_FEM_FLAG = 1 AND [FEM_FLAG] IS NULL) OR ([FEM_FLAG] = @Original_FEM_FLAG)) AND ((@IsNull_CALE_CYCLE = 1 AND [CALE_CYCLE] IS NULL) OR ([CALE_CYCLE] = @Original_CALE_CYCLE)) AND ((@IsNull_DEC_FLAG = 1 AND [DEC_FLAG] IS NULL) OR ([DEC_FLAG] = @Original_DEC_FLAG)) AND ((@IsNull_ACCUM_FLAG = 1 AND [ACCUM_FLAG] IS NULL) OR ([ACCUM_FLAG] = @Original_ACCUM_FLAG)) AND ((@IsNull_MAX_DUR_ONCE = 1 AND [MAX_DUR_ONCE] IS NULL) OR ([MAX_DUR_ONCE] = @Original_MAX_DUR_ONCE)) AND ((@IsNull_MAX_DUR = 1 AND [MAX_DUR] IS NULL) OR ([MAX_DUR] = @Original_MAX_DUR)) AND ((@IsNull_SAL_DED_PERCENT = 1 AND [SAL_DED_PERCENT] IS NULL) OR ([SAL_DED_PERCENT] = @Original_SAL_DED_PERCENT)) AND ((@IsNull_BALANCE_FLAG = 1 AND [BALANCE_FLAG] IS NULL) OR ([BALANCE_FLAG] = @Original_BALANCE_FLAG)) AND ((@IsNull_VACATION_CLASS_CODE = 1 AND [VACATION_CLASS_CODE] IS NULL) OR ([VACATION_CLASS_CODE] = @Original_VACATION_CLASS_CODE)) AND ((@IsNull_PERIOD_FLAG = 1 AND [PERIOD_FLAG] IS NULL) OR ([PERIOD_FLAG] = @Original_PERIOD_FLAG)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_VAC_SUB_CLASSInsert
(
	@VAC_TYPE_DESC varchar(200),
	@MAX_NUM numeric(6, 0),
	@FEM_FLAG varchar(1),
	@CALE_CYCLE numeric(3, 0),
	@DEC_FLAG bit,
	@ACCUM_FLAG varchar(1),
	@MAX_DUR_ONCE numeric(6, 0),
	@MAX_DUR numeric(6, 0),
	@SAL_DED_PERCENT numeric(6, 0),
	@BALANCE_FLAG numeric(1, 0),
	@VACATION_CLASS_CODE numeric(5, 0),
	@PERIOD_FLAG bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_VAC_SUB_CLASS] ([VAC_TYPE_DESC], [MAX_NUM], [FEM_FLAG], [CALE_CYCLE], [DEC_FLAG], [ACCUM_FLAG], [MAX_DUR_ONCE], [MAX_DUR], [SAL_DED_PERCENT], [BALANCE_FLAG], [VACATION_CLASS_CODE], [PERIOD_FLAG]) VALUES (@VAC_TYPE_DESC, @MAX_NUM, @FEM_FLAG, @CALE_CYCLE, @DEC_FLAG, @ACCUM_FLAG, @MAX_DUR_ONCE, @MAX_DUR, @SAL_DED_PERCENT, @BALANCE_FLAG, @VACATION_CLASS_CODE, @PERIOD_FLAG);
	
SELECT VAC_TYPE_CODE, VAC_TYPE_DESC, MAX_NUM, FEM_FLAG, CALE_CYCLE, DEC_FLAG, ACCUM_FLAG, MAX_DUR_ONCE, MAX_DUR, SAL_DED_PERCENT, BALANCE_FLAG, VACATION_CLASS_CODE, PERIOD_FLAG FROM CDE_PER_VAC_SUB_CLASS WHERE (VAC_TYPE_CODE = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_VAC_SUB_CLASSSelect
AS
	SET NOCOUNT ON;
SELECT     VAC_TYPE_CODE, VAC_TYPE_DESC, MAX_NUM, FEM_FLAG, CALE_CYCLE, DEC_FLAG, ACCUM_FLAG, MAX_DUR_ONCE, MAX_DUR, 
                      SAL_DED_PERCENT, BALANCE_FLAG, VACATION_CLASS_CODE, PERIOD_FLAG
FROM         CDE_PER_VAC_SUB_CLASS







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_VAC_SUB_CLASSUpdate
(
	@VAC_TYPE_DESC varchar(200),
	@MAX_NUM numeric(6, 0),
	@FEM_FLAG varchar(1),
	@CALE_CYCLE numeric(3, 0),
	@DEC_FLAG bit,
	@ACCUM_FLAG varchar(1),
	@MAX_DUR_ONCE numeric(6, 0),
	@MAX_DUR numeric(6, 0),
	@SAL_DED_PERCENT numeric(6, 0),
	@BALANCE_FLAG numeric(1, 0),
	@VACATION_CLASS_CODE numeric(5, 0),
	@PERIOD_FLAG bit,
	@Original_VAC_TYPE_CODE numeric,
	@Original_VAC_TYPE_DESC varchar(200),
	@IsNull_MAX_NUM Int,
	@Original_MAX_NUM numeric(6, 0),
	@IsNull_FEM_FLAG Int,
	@Original_FEM_FLAG varchar(1),
	@IsNull_CALE_CYCLE Int,
	@Original_CALE_CYCLE numeric(3, 0),
	@IsNull_DEC_FLAG Int,
	@Original_DEC_FLAG bit,
	@IsNull_ACCUM_FLAG Int,
	@Original_ACCUM_FLAG varchar(1),
	@IsNull_MAX_DUR_ONCE Int,
	@Original_MAX_DUR_ONCE numeric(6, 0),
	@IsNull_MAX_DUR Int,
	@Original_MAX_DUR numeric(6, 0),
	@IsNull_SAL_DED_PERCENT Int,
	@Original_SAL_DED_PERCENT numeric(6, 0),
	@IsNull_BALANCE_FLAG Int,
	@Original_BALANCE_FLAG numeric(1, 0),
	@IsNull_VACATION_CLASS_CODE Int,
	@Original_VACATION_CLASS_CODE numeric(5, 0),
	@IsNull_PERIOD_FLAG Int,
	@Original_PERIOD_FLAG bit,
	@VAC_TYPE_CODE numeric
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PER_VAC_SUB_CLASS] SET [VAC_TYPE_DESC] = @VAC_TYPE_DESC, [MAX_NUM] = @MAX_NUM, [FEM_FLAG] = @FEM_FLAG, [CALE_CYCLE] = @CALE_CYCLE, [DEC_FLAG] = @DEC_FLAG, [ACCUM_FLAG] = @ACCUM_FLAG, [MAX_DUR_ONCE] = @MAX_DUR_ONCE, [MAX_DUR] = @MAX_DUR, [SAL_DED_PERCENT] = @SAL_DED_PERCENT, [BALANCE_FLAG] = @BALANCE_FLAG, [VACATION_CLASS_CODE] = @VACATION_CLASS_CODE, [PERIOD_FLAG] = @PERIOD_FLAG WHERE (([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([VAC_TYPE_DESC] = @Original_VAC_TYPE_DESC) AND ((@IsNull_MAX_NUM = 1 AND [MAX_NUM] IS NULL) OR ([MAX_NUM] = @Original_MAX_NUM)) AND ((@IsNull_FEM_FLAG = 1 AND [FEM_FLAG] IS NULL) OR ([FEM_FLAG] = @Original_FEM_FLAG)) AND ((@IsNull_CALE_CYCLE = 1 AND [CALE_CYCLE] IS NULL) OR ([CALE_CYCLE] = @Original_CALE_CYCLE)) AND ((@IsNull_DEC_FLAG = 1 AND [DEC_FLAG] IS NULL) OR ([DEC_FLAG] = @Original_DEC_FLAG)) AND ((@IsNull_ACCUM_FLAG = 1 AND [ACCUM_FLAG] IS NULL) OR ([ACCUM_FLAG] = @Original_ACCUM_FLAG)) AND ((@IsNull_MAX_DUR_ONCE = 1 AND [MAX_DUR_ONCE] IS NULL) OR ([MAX_DUR_ONCE] = @Original_MAX_DUR_ONCE)) AND ((@IsNull_MAX_DUR = 1 AND [MAX_DUR] IS NULL) OR ([MAX_DUR] = @Original_MAX_DUR)) AND ((@IsNull_SAL_DED_PERCENT = 1 AND [SAL_DED_PERCENT] IS NULL) OR ([SAL_DED_PERCENT] = @Original_SAL_DED_PERCENT)) AND ((@IsNull_BALANCE_FLAG = 1 AND [BALANCE_FLAG] IS NULL) OR ([BALANCE_FLAG] = @Original_BALANCE_FLAG)) AND ((@IsNull_VACATION_CLASS_CODE = 1 AND [VACATION_CLASS_CODE] IS NULL) OR ([VACATION_CLASS_CODE] = @Original_VACATION_CLASS_CODE)) AND ((@IsNull_PERIOD_FLAG = 1 AND [PERIOD_FLAG] IS NULL) OR ([PERIOD_FLAG] = @Original_PERIOD_FLAG)));
	
SELECT VAC_TYPE_CODE, VAC_TYPE_DESC, MAX_NUM, FEM_FLAG, CALE_CYCLE, DEC_FLAG, ACCUM_FLAG, MAX_DUR_ONCE, MAX_DUR, SAL_DED_PERCENT, BALANCE_FLAG, VACATION_CLASS_CODE, PERIOD_FLAG FROM CDE_PER_VAC_SUB_CLASS WHERE (VAC_TYPE_CODE = @VAC_TYPE_CODE)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_Vacation_ViewSelect

AS
	SET NOCOUNT ON;
SELECT     VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, 
                      DEC_FLAG, FName, SName, TName, FoName, TITLE, DEPTCODE, FullName, DEPT_DESC, VAC_TYPE_DESC,EmpNum
FROM         Vacation_View







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_Vacation_ViewSelectbyParam
@EMP_CODE bigint ,
@DEPTCODE bigint ,
@FromDate smalldatetime,
@ToDate smalldatetime,
@EmpNum bigint
AS
	SET NOCOUNT ON;
SELECT     VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE, TotalDays, Netdays, Holidays, Ticket, 
                      DEC_FLAG, FName, SName, TName, FoName, TITLE, DEPTCODE, FullName, DEPT_DESC, VAC_TYPE_DESC,EmpNum
FROM         Vacation_View
where (EMP_CODE=@EMP_CODE or @EMP_CODE is null) and  (DEPTCODE=@DEPTCODE or @DEPTCODE is null)
and (VAC_DATE_FRM>=@FromDate or @FromDate is null) and (VAC_DATE_FRM<=@ToDate or @ToDate is null)

and (EmpNum=@EmpNum or @EmpNum is null)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_WeekDaysDelete
(
	@Original_Id int,
	@IsNull_DayDesc varchar(50),
	@Original_DayDesc varchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [WeekDays] WHERE (([Id] = @Original_Id) AND ((@IsNull_DayDesc = 1 AND [DayDesc] IS NULL) OR ([DayDesc] = @Original_DayDesc)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_WeekDaysInsert
(
	@Id int,
	@DayDesc varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [WeekDays] ([Id], [DayDesc]) VALUES (@Id, @DayDesc);
	
SELECT Id, DayDesc FROM WeekDays WHERE (Id = @Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_WeekDaysSelect
AS
	SET NOCOUNT ON;
SELECT     Id, DayDesc
FROM         WeekDays







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_WeekDaysUpdate
(
	@Id int,
	@DayDesc varchar(50),
	@Original_Id int,
	@IsNull_DayDesc varchar(50),
	@Original_DayDesc varchar(50)
)
AS
	SET NOCOUNT OFF;
UPDATE [WeekDays] SET [Id] = @Id, [DayDesc] = @DayDesc WHERE (([Id] = @Original_Id) AND ((@IsNull_DayDesc = 1 AND [DayDesc] IS NULL) OR ([DayDesc] = @Original_DayDesc)));
	
SELECT Id, DayDesc FROM WeekDays WHERE (Id = @Id)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_accountingDelete
(
	@Original_accountid bigint,
	@Original_AccountCode varchar(50),
	@Original_accountname nvarchar(100),
	@IsNull_AccountSName nvarchar(100),
	@Original_AccountSName nvarchar(100),
	@IsNull_AccountparentId int,
	@Original_AccountparentId int,
	@IsNull_root bit,
	@Original_root bit,
	@IsNull_Totalfromvalue money,
	@Original_Totalfromvalue money,
	@IsNull_Totaltovalue money,
	@Original_Totaltovalue money,
	@IsNull_startbalancefrom float,
	@Original_startbalancefrom float,
	@IsNull_startdate smalldatetime,
	@Original_startdate smalldatetime,
	@IsNull_startbalanceto float,
	@Original_startbalanceto float,
	@IsNull_balance bit,
	@Original_balance bit,
	@IsNull_accountType int,
	@Original_accountType int,
	@IsNull_ClosedTo bigint,
	@Original_ClosedTo bigint,
	@IsNull_MainNode bit,
	@Original_MainNode bit,
	@IsNull_ProcessFlag bit,
	@Original_ProcessFlag bit,
	@IsNull_display_Flag bit,
	@Original_display_Flag bit,
	@IsNull_AccLevel int,
	@Original_AccLevel int,
	@IsNull_MainParentAccId bigint,
	@Original_MainParentAccId bigint,
	@IsNull_LastSerialNo varchar(50),
	@Original_LastSerialNo varchar(50),
	@IsNull_CurId bigint,
	@Original_CurId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [accounting] WHERE (([accountid] = @Original_accountid) AND ([AccountCode] = @Original_AccountCode) AND ([accountname] = @Original_accountname) AND ((@IsNull_AccountSName = 1 AND [AccountSName] IS NULL) OR ([AccountSName] = @Original_AccountSName)) AND ((@IsNull_AccountparentId = 1 AND [AccountparentId] IS NULL) OR ([AccountparentId] = @Original_AccountparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_accountType = 1 AND [accountType] IS NULL) OR ([accountType] = @Original_accountType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)) AND ((@IsNull_CurId = 1 AND [CurId] IS NULL) OR ([CurId] = @Original_CurId)))






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_accountingInsert
(
	@AccountCode varchar(50),
	@accountname nvarchar(100),
	@AccountSName nvarchar(100),
	@AccountparentId int,
	@root bit,
	@Totalfromvalue money,
	@Totaltovalue money,
	@notes ntext,
	@startbalancefrom float,
	@startdate smalldatetime,
	@startbalanceto float,
	@balance bit,
	@accountType int,
	@ClosedTo bigint,
	@MainNode bit,
	@ProcessFlag bit,
	@display_Flag bit,
	@AccLevel int,
	@MainParentAccId bigint,
	@LastSerialNo varchar(50),
	@CurId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [accounting] ([AccountCode], [accountname], [AccountSName], [AccountparentId], [root], [Totalfromvalue], [Totaltovalue], [notes], [startbalancefrom], [startdate], [startbalanceto], [balance], [accountType], [ClosedTo], [MainNode], [ProcessFlag], [display_Flag], [AccLevel], [MainParentAccId], [LastSerialNo], [CurId]) VALUES (@AccountCode, @accountname, @AccountSName, @AccountparentId, @root, @Totalfromvalue, @Totaltovalue, @notes, @startbalancefrom, @startdate, @startbalanceto, @balance, @accountType, @ClosedTo, @MainNode, @ProcessFlag, @display_Flag, @AccLevel, @MainParentAccId, @LastSerialNo, @CurId);
	
SELECT accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo, CurId FROM accounting WHERE (accountid = SCOPE_IDENTITY())






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_accountingSelect
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, 
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo, CurId
FROM         accounting
WHERE     (accountid > 4)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_accountingSelectByParam
@AccountId1 int,
@AccountId2 int
AS
	SET NOCOUNT ON;
SELECT     accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, 
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo, CurId
FROM         accounting
WHERE     (accountid > 4) and (AccountId=@AccountId1 or AccountparentId=@AccountId1 or AccountId=@AccountId2 or AccountparentId=@AccountId2 )







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO







CREATE PROCEDURE dbo.usp_accountingUpdate
(
	@AccountCode varchar(50),
	@accountname nvarchar(100),
	@AccountSName nvarchar(100),
	@AccountparentId int,
	@root bit,
	@Totalfromvalue money,
	@Totaltovalue money,
	@notes ntext,
	@startbalancefrom float,
	@startdate smalldatetime,
	@startbalanceto float,
	@balance bit,
	@accountType int,
	@ClosedTo bigint,
	@MainNode bit,
	@ProcessFlag bit,
	@display_Flag bit,
	@AccLevel int,
	@MainParentAccId bigint,
	@LastSerialNo varchar(50),
	@CurId bigint,
	@Original_accountid bigint,
	@Original_AccountCode varchar(50),
	@Original_accountname nvarchar(100),
	@IsNull_AccountSName nvarchar(100),
	@Original_AccountSName nvarchar(100),
	@IsNull_AccountparentId int,
	@Original_AccountparentId int,
	@IsNull_root bit,
	@Original_root bit,
	@IsNull_Totalfromvalue money,
	@Original_Totalfromvalue money,
	@IsNull_Totaltovalue money,
	@Original_Totaltovalue money,
	@IsNull_startbalancefrom float,
	@Original_startbalancefrom float,
	@IsNull_startdate smalldatetime,
	@Original_startdate smalldatetime,
	@IsNull_startbalanceto float,
	@Original_startbalanceto float,
	@IsNull_balance bit,
	@Original_balance bit,
	@IsNull_accountType int,
	@Original_accountType int,
	@IsNull_ClosedTo bigint,
	@Original_ClosedTo bigint,
	@IsNull_MainNode bit,
	@Original_MainNode bit,
	@IsNull_ProcessFlag bit,
	@Original_ProcessFlag bit,
	@IsNull_display_Flag bit,
	@Original_display_Flag bit,
	@IsNull_AccLevel int,
	@Original_AccLevel int,
	@IsNull_MainParentAccId bigint,
	@Original_MainParentAccId bigint,
	@IsNull_LastSerialNo varchar(50),
	@Original_LastSerialNo varchar(50),
	@IsNull_CurId bigint,
	@Original_CurId bigint,
	@accountid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [accounting] SET [AccountCode] = @AccountCode, [accountname] = @accountname, [AccountSName] = @AccountSName, [AccountparentId] = @AccountparentId, [root] = @root, [Totalfromvalue] = @Totalfromvalue, [Totaltovalue] = @Totaltovalue, [notes] = @notes, [startbalancefrom] = @startbalancefrom, [startdate] = @startdate, [startbalanceto] = @startbalanceto, [balance] = @balance, [accountType] = @accountType, [ClosedTo] = @ClosedTo, [MainNode] = @MainNode, [ProcessFlag] = @ProcessFlag, [display_Flag] = @display_Flag, [AccLevel] = @AccLevel, [MainParentAccId] = @MainParentAccId, [LastSerialNo] = @LastSerialNo, [CurId] = @CurId WHERE (([accountid] = @Original_accountid) AND ([AccountCode] = @Original_AccountCode) AND ([accountname] = @Original_accountname) AND ((@IsNull_AccountSName = 1 AND [AccountSName] IS NULL) OR ([AccountSName] = @Original_AccountSName)) AND ((@IsNull_AccountparentId = 1 AND [AccountparentId] IS NULL) OR ([AccountparentId] = @Original_AccountparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_accountType = 1 AND [accountType] IS NULL) OR ([accountType] = @Original_accountType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)) AND ((@IsNull_CurId = 1 AND [CurId] IS NULL) OR ([CurId] = @Original_CurId)));
	
SELECT accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo, CurId FROM accounting WHERE (accountid = @accountid)






GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_invoicesDelete
(
	@Original_InvId bigint,
	@Original_InvCode nvarchar(100),
	@IsNull_RecoderCode nvarchar(50),
	@Original_RecoderCode nvarchar(50),
	@IsNull_InvDate smalldatetime,
	@Original_InvDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_InvAccid bigint,
	@Original_InvAccid bigint,
	@IsNull_PaymentType smallint,
	@Original_PaymentType smallint,
	@IsNull_PaymentAccid bigint,
	@Original_PaymentAccid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_PaymentValue money,
	@Original_PaymentValue money,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_invTotal money,
	@Original_invTotal money,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_InvTotalNet money,
	@Original_InvTotalNet money,
	@IsNull_InvPayment money,
	@Original_InvPayment money,
	@IsNull_InvRemain money,
	@Original_InvRemain money,
	@IsNull_ReferID bigint,
	@Original_ReferID bigint,
	@IsNull_PaymentCost money,
	@Original_PaymentCost money,
	@IsNull_ChequeNo nvarchar(50),
	@Original_ChequeNo nvarchar(50),
	@IsNull_ChequeFlag bit,
	@Original_ChequeFlag bit,
	@IsNull_TotalAddCost money,
	@Original_TotalAddCost money,
	@IsNull_TotalReoder money,
	@Original_TotalReoder money,
	@IsNull_TotalReoderNet money,
	@Original_TotalReoderNet money,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_PayFinish bit,
	@Original_PayFinish bit,
	@IsNull_CollectValue money,
	@Original_CollectValue money,
	@IsNull_KeyNetValue money,
	@Original_KeyNetValue money,
	@IsNull_VisaValue money,
	@Original_VisaValue money,
	@IsNull_MasterValue money,
	@Original_MasterValue money,
	@IsNull_ChequeValue money,
	@Original_ChequeValue money,
	@IsNull_OtherValue money,
	@Original_OtherValue money,
	@IsNull_CustId bigint,
	@Original_CustId bigint,
	@IsNull_Serial bigint,
	@Original_Serial bigint,
	@IsNull_CustomerName varchar(200),
	@Original_CustomerName varchar(200),
	@IsNull_CustomertTel varchar(50),
	@Original_CustomertTel varchar(50),
	@IsNull_Custaddress varchar(300),
	@Original_Custaddress varchar(300),
	@IsNull_BuyerId int,
	@Original_BuyerId int,
	@IsNull_CustomerId bigint,
	@Original_CustomerId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [invoices] WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)) AND ((@IsNull_Serial = 1 AND [Serial] IS NULL) OR ([Serial] = @Original_Serial)) AND ((@IsNull_CustomerName = 1 AND [CustomerName] IS NULL) OR ([CustomerName] = @Original_CustomerName)) AND ((@IsNull_CustomertTel = 1 AND [CustomertTel] IS NULL) OR ([CustomertTel] = @Original_CustomertTel)) AND ((@IsNull_Custaddress = 1 AND [Custaddress] IS NULL) OR ([Custaddress] = @Original_Custaddress)) AND ((@IsNull_BuyerId = 1 AND [BuyerId] IS NULL) OR ([BuyerId] = @Original_BuyerId)) AND ((@IsNull_CustomerId = 1 AND [CustomerId] IS NULL) OR ([CustomerId] = @Original_CustomerId)))



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_invoicesInsert
(
	@InvCode nvarchar(100),
	@RecoderCode nvarchar(50),
	@InvDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@InvAccid bigint,
	@PaymentType smallint,
	@PaymentAccid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@PaymentValue money,
	@PaymentDate smalldatetime,
	@Notes ntext,
	@invTotal money,
	@Discount float,
	@InvTotalNet money,
	@InvPayment money,
	@InvRemain money,
	@ReferID bigint,
	@PaymentCost money,
	@ChequeNo nvarchar(50),
	@ChequeFlag bit,
	@TotalAddCost money,
	@TotalReoder money,
	@TotalReoderNet money,
	@CostId bigint,
	@SUP_CUST_ID bigint,
	@PayFinish bit,
	@CollectValue money,
	@KeyNetValue money,
	@VisaValue money,
	@MasterValue money,
	@ChequeValue money,
	@OtherValue money,
	@CustId bigint,
	@Serial bigint,
	@CustomerName varchar(200),
	@CustomertTel varchar(50),
	@Custaddress varchar(300),
	@BuyerId int,
	@CustomerId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [invoices] ([InvCode], [RecoderCode], [InvDate], [Cust_Sup_Accid], [InvAccid], [PaymentType], [PaymentAccid], [BranchId], [InvType], [EmpId], [PaymentValue], [PaymentDate], [Notes], [invTotal], [Discount], [InvTotalNet], [InvPayment], [InvRemain], [ReferID], [PaymentCost], [ChequeNo], [ChequeFlag], [TotalAddCost], [TotalReoder], [TotalReoderNet], [CostId], [SUP_CUST_ID], [PayFinish], [CollectValue], [KeyNetValue], [VisaValue], [MasterValue], [ChequeValue], [OtherValue], [CustId], [Serial], [CustomerName], [CustomertTel], [Custaddress], [BuyerId], [CustomerId]) VALUES (@InvCode, @RecoderCode, @InvDate, @Cust_Sup_Accid, @InvAccid, @PaymentType, @PaymentAccid, @BranchId, @InvType, @EmpId, @PaymentValue, @PaymentDate, @Notes, @invTotal, @Discount, @InvTotalNet, @InvPayment, @InvRemain, @ReferID, @PaymentCost, @ChequeNo, @ChequeFlag, @TotalAddCost, @TotalReoder, @TotalReoderNet, @CostId, @SUP_CUST_ID, @PayFinish, @CollectValue, @KeyNetValue, @VisaValue, @MasterValue, @ChequeValue, @OtherValue, @CustId, @Serial, @CustomerName, @CustomertTel, @Custaddress, @BuyerId, @CustomerId);
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, BuyerId, CustomerId FROM invoices WHERE (InvId = SCOPE_IDENTITY())



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_invoicesSelect
AS
	SET NOCOUNT ON;
SELECT        InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, 
                         invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, 
                         SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, 
                         BuyerId, CustomerId
FROM            invoices



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_invoicesSelectbyCode
(
	@InvCode nvarchar(100)
)
AS
	SET NOCOUNT ON;
SELECT        InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, 
                         invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, 
                         SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, 
                         BuyerId, CustomerId
FROM            invoices

WHERE     (InvCode = @InvCode)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_invoicesSelectbyCodeAndCust
(
	@InvCode nvarchar(100),
@SUP_CUST_ID bigint
)
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue
FROM         invoices
WHERE     (InvCode = @InvCode or @InvCode is null) and (SUP_CUST_ID=@SUP_CUST_ID or @SUP_CUST_ID is null)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_invoicesSelectbyCustId
(
	@CustId bigint
)
AS
	SET NOCOUNT ON;
SELECT         InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, 
                         invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, 
                         SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, 
                         BuyerId, CustomerId
FROM            invoices
WHERE     (CustomerId = @CustId)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_invoicesSelectbyCustomerId
(
	@CustomerId bigint
)
AS
	SET NOCOUNT ON;
SELECT     TOP 1   InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, 
                         invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, 
                         SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, 
                         BuyerId, CustomerId
FROM            invoices

WHERE     (CustomerId = @CustomerId)
order by InvId desc
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS OFF 
GO








CREATE PROCEDURE dbo.usp_invoicesSelectbyInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT        InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, 
                         invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, 
                         SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, 
                         BuyerId, CustomerId
FROM            invoices
WHERE     (InvId = @InvId)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO




CREATE PROCEDURE dbo.usp_invoicesUpdate
(
	@InvCode nvarchar(100),
	@RecoderCode nvarchar(50),
	@InvDate smalldatetime,
	@Cust_Sup_Accid bigint,
	@InvAccid bigint,
	@PaymentType smallint,
	@PaymentAccid bigint,
	@BranchId bigint,
	@InvType int,
	@EmpId bigint,
	@PaymentValue money,
	@PaymentDate smalldatetime,
	@Notes ntext,
	@invTotal money,
	@Discount float,
	@InvTotalNet money,
	@InvPayment money,
	@InvRemain money,
	@ReferID bigint,
	@PaymentCost money,
	@ChequeNo nvarchar(50),
	@ChequeFlag bit,
	@TotalAddCost money,
	@TotalReoder money,
	@TotalReoderNet money,
	@CostId bigint,
	@SUP_CUST_ID bigint,
	@PayFinish bit,
	@CollectValue money,
	@KeyNetValue money,
	@VisaValue money,
	@MasterValue money,
	@ChequeValue money,
	@OtherValue money,
	@CustId bigint,
	@Serial bigint,
	@CustomerName varchar(200),
	@CustomertTel varchar(50),
	@Custaddress varchar(300),
	@BuyerId int,
	@CustomerId bigint,
	@Original_InvId bigint,
	@Original_InvCode nvarchar(100),
	@IsNull_RecoderCode nvarchar(50),
	@Original_RecoderCode nvarchar(50),
	@IsNull_InvDate smalldatetime,
	@Original_InvDate smalldatetime,
	@IsNull_Cust_Sup_Accid bigint,
	@Original_Cust_Sup_Accid bigint,
	@IsNull_InvAccid bigint,
	@Original_InvAccid bigint,
	@IsNull_PaymentType smallint,
	@Original_PaymentType smallint,
	@IsNull_PaymentAccid bigint,
	@Original_PaymentAccid bigint,
	@IsNull_BranchId bigint,
	@Original_BranchId bigint,
	@IsNull_InvType int,
	@Original_InvType int,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_PaymentValue money,
	@Original_PaymentValue money,
	@IsNull_PaymentDate smalldatetime,
	@Original_PaymentDate smalldatetime,
	@IsNull_invTotal money,
	@Original_invTotal money,
	@IsNull_Discount float,
	@Original_Discount float,
	@IsNull_InvTotalNet money,
	@Original_InvTotalNet money,
	@IsNull_InvPayment money,
	@Original_InvPayment money,
	@IsNull_InvRemain money,
	@Original_InvRemain money,
	@IsNull_ReferID bigint,
	@Original_ReferID bigint,
	@IsNull_PaymentCost money,
	@Original_PaymentCost money,
	@IsNull_ChequeNo nvarchar(50),
	@Original_ChequeNo nvarchar(50),
	@IsNull_ChequeFlag bit,
	@Original_ChequeFlag bit,
	@IsNull_TotalAddCost money,
	@Original_TotalAddCost money,
	@IsNull_TotalReoder money,
	@Original_TotalReoder money,
	@IsNull_TotalReoderNet money,
	@Original_TotalReoderNet money,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_SUP_CUST_ID bigint,
	@Original_SUP_CUST_ID bigint,
	@IsNull_PayFinish bit,
	@Original_PayFinish bit,
	@IsNull_CollectValue money,
	@Original_CollectValue money,
	@IsNull_KeyNetValue money,
	@Original_KeyNetValue money,
	@IsNull_VisaValue money,
	@Original_VisaValue money,
	@IsNull_MasterValue money,
	@Original_MasterValue money,
	@IsNull_ChequeValue money,
	@Original_ChequeValue money,
	@IsNull_OtherValue money,
	@Original_OtherValue money,
	@IsNull_CustId bigint,
	@Original_CustId bigint,
	@IsNull_Serial bigint,
	@Original_Serial bigint,
	@IsNull_CustomerName varchar(200),
	@Original_CustomerName varchar(200),
	@IsNull_CustomertTel varchar(50),
	@Original_CustomertTel varchar(50),
	@IsNull_Custaddress varchar(300),
	@Original_Custaddress varchar(300),
	@IsNull_BuyerId int,
	@Original_BuyerId int,
	@IsNull_CustomerId bigint,
	@Original_CustomerId bigint,
	@InvId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [invoices] SET [InvCode] = @InvCode, [RecoderCode] = @RecoderCode, [InvDate] = @InvDate, [Cust_Sup_Accid] = @Cust_Sup_Accid, [InvAccid] = @InvAccid, [PaymentType] = @PaymentType, [PaymentAccid] = @PaymentAccid, [BranchId] = @BranchId, [InvType] = @InvType, [EmpId] = @EmpId, [PaymentValue] = @PaymentValue, [PaymentDate] = @PaymentDate, [Notes] = @Notes, [invTotal] = @invTotal, [Discount] = @Discount, [InvTotalNet] = @InvTotalNet, [InvPayment] = @InvPayment, [InvRemain] = @InvRemain, [ReferID] = @ReferID, [PaymentCost] = @PaymentCost, [ChequeNo] = @ChequeNo, [ChequeFlag] = @ChequeFlag, [TotalAddCost] = @TotalAddCost, [TotalReoder] = @TotalReoder, [TotalReoderNet] = @TotalReoderNet, [CostId] = @CostId, [SUP_CUST_ID] = @SUP_CUST_ID, [PayFinish] = @PayFinish, [CollectValue] = @CollectValue, [KeyNetValue] = @KeyNetValue, [VisaValue] = @VisaValue, [MasterValue] = @MasterValue, [ChequeValue] = @ChequeValue, [OtherValue] = @OtherValue, [CustId] = @CustId, [Serial] = @Serial, [CustomerName] = @CustomerName, [CustomertTel] = @CustomertTel, [Custaddress] = @Custaddress, [BuyerId] = @BuyerId, [CustomerId] = @CustomerId WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)) AND ((@IsNull_Serial = 1 AND [Serial] IS NULL) OR ([Serial] = @Original_Serial)) AND ((@IsNull_CustomerName = 1 AND [CustomerName] IS NULL) OR ([CustomerName] = @Original_CustomerName)) AND ((@IsNull_CustomertTel = 1 AND [CustomertTel] IS NULL) OR ([CustomertTel] = @Original_CustomertTel)) AND ((@IsNull_Custaddress = 1 AND [Custaddress] IS NULL) OR ([Custaddress] = @Original_Custaddress)) AND ((@IsNull_BuyerId = 1 AND [BuyerId] IS NULL) OR ([BuyerId] = @Original_BuyerId)) AND ((@IsNull_CustomerId = 1 AND [CustomerId] IS NULL) OR ([CustomerId] = @Original_CustomerId)));
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId, Serial, CustomerName, CustomertTel, Custaddress, BuyerId, CustomerId FROM invoices WHERE (InvId = @InvId)



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO



CREATE PROCEDURE dbo.usp_qidsDelete
(
	@Original_qidid bigint,
	@Original_qidcode varchar(50),
	@IsNull_qidDate smalldatetime,
	@Original_qidDate smalldatetime,
	@IsNull_edit bit,
	@Original_edit bit,
	@IsNull_recitetype int,
	@Original_recitetype int,
	@IsNull_underupdate bit,
	@Original_underupdate bit,
	@IsNull_name nvarchar(100),
	@Original_name nvarchar(100),
	@IsNull_BrachId bigint,
	@Original_BrachId bigint,
	@IsNull_EmpId bigint,
	@Original_EmpId bigint,
	@IsNull_Active bit,
	@Original_Active bit,
	@IsNull_repeated bit,
	@Original_repeated bit,
	@IsNull_BankAccId bigint,
	@Original_BankAccId bigint,
	@IsNull_ChequeNo nvarchar(50),
	@Original_ChequeNo nvarchar(50),
	@IsNull_InvId bigint,
	@Original_InvId bigint,
	@IsNull_ReorderInvId bigint,
	@Original_ReorderInvId bigint,
	@IsNull_PaymentType bit,
	@Original_PaymentType bit,
	@IsNull_PaymentTo varchar(300),
	@Original_PaymentTo varchar(300),
	@IsNull_QidSerial bigint,
	@Original_QidSerial bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [qids] WHERE (([qidid] = @Original_qidid) AND ([qidcode] = @Original_qidcode) AND ((@IsNull_qidDate = 1 AND [qidDate] IS NULL) OR ([qidDate] = @Original_qidDate)) AND ((@IsNull_edit = 1 AND [edit] IS NULL) OR ([edit] = @Original_edit)) AND ((@IsNull_recitetype = 1 AND [recitetype] IS NULL) OR ([recitetype] = @Original_recitetype)) AND ((@IsNull_underupdate = 1 AND [underupdate] IS NULL) OR ([underupdate] = @Original_underupdate)) AND ((@IsNull_name = 1 AND [name] IS NULL) OR ([name] = @Original_name)) AND ((@IsNull_BrachId = 1 AND [BrachId] IS NULL) OR ([BrachId] = @Original_BrachId)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_repeated = 1 AND [repeated] IS NULL) OR ([repeated] = @Original_repeated)) AND ((@IsNull_BankAccId = 1 AND [BankAccId] IS NULL) OR ([BankAccId] = @Original_BankAccId)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderInvId = 1 AND [ReorderInvId] IS NULL) OR ([ReorderInvId] = @Original_ReorderInvId)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentTo = 1 AND [PaymentTo] IS NULL) OR ([PaymentTo] = @Original_PaymentTo)) AND ((@IsNull_QidSerial = 1 AND [QidSerial] IS NULL) OR ([QidSerial] = @Original_QidSerial)))


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsDetailsClosedDelete
(
	@Original_ID bigint,
	@IsNull_qidid bigint,
	@Original_qidid bigint,
	@IsNull_FromValue money,
	@Original_FromValue money,
	@IsNull_ToValue money,
	@Original_ToValue money,
	@IsNull_ACCOUNTID bigint,
	@Original_ACCOUNTID bigint,
	@IsNull_type smallint,
	@Original_type smallint,
	@IsNull_EnterDate datetime,
	@Original_EnterDate datetime,
	@IsNull_Detcode int,
	@Original_Detcode int,
	@IsNull_QidType int,
	@Original_QidType int,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ActionType int,
	@Original_ActionType int,
	@IsNull_CostId bigint,
	@Original_CostId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [qidsDetailsClosed] WHERE (([ID] = @Original_ID) AND ((@IsNull_qidid = 1 AND [qidid] IS NULL) OR ([qidid] = @Original_qidid)) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)))








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsDetailsClosedInsert
(
	@qidid bigint,
	@FromValue money,
	@ToValue money,
	@ACCOUNTID bigint,
	@type smallint,
	@Description ntext,
	@EnterDate datetime,
	@Detcode int,
	@QidType int,
	@TotalPrice money,
	@ActionType int,
	@CostId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [qidsDetailsClosed] ([qidid], [FromValue], [ToValue], [ACCOUNTID], [type], [Description], [EnterDate], [Detcode], [QidType], [TotalPrice], [ActionType], [CostId]) VALUES (@qidid, @FromValue, @ToValue, @ACCOUNTID, @type, @Description, @EnterDate, @Detcode, @QidType, @TotalPrice, @ActionType, @CostId);
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId FROM qidsDetailsClosed WHERE (ID = SCOPE_IDENTITY())








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsDetailsClosedSelect
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId
FROM         qidsDetailsClosed








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsDetailsClosedUpdate
(
	@qidid bigint,
	@FromValue money,
	@ToValue money,
	@ACCOUNTID bigint,
	@type smallint,
	@Description ntext,
	@EnterDate datetime,
	@Detcode int,
	@QidType int,
	@TotalPrice money,
	@ActionType int,
	@CostId bigint,
	@Original_ID bigint,
	@IsNull_qidid bigint,
	@Original_qidid bigint,
	@IsNull_FromValue money,
	@Original_FromValue money,
	@IsNull_ToValue money,
	@Original_ToValue money,
	@IsNull_ACCOUNTID bigint,
	@Original_ACCOUNTID bigint,
	@IsNull_type smallint,
	@Original_type smallint,
	@IsNull_EnterDate datetime,
	@Original_EnterDate datetime,
	@IsNull_Detcode int,
	@Original_Detcode int,
	@IsNull_QidType int,
	@Original_QidType int,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ActionType int,
	@Original_ActionType int,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@ID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [qidsDetailsClosed] SET [qidid] = @qidid, [FromValue] = @FromValue, [ToValue] = @ToValue, [ACCOUNTID] = @ACCOUNTID, [type] = @type, [Description] = @Description, [EnterDate] = @EnterDate, [Detcode] = @Detcode, [QidType] = @QidType, [TotalPrice] = @TotalPrice, [ActionType] = @ActionType, [CostId] = @CostId WHERE (([ID] = @Original_ID) AND ((@IsNull_qidid = 1 AND [qidid] IS NULL) OR ([qidid] = @Original_qidid)) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)));
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId FROM qidsDetailsClosed WHERE (ID = @ID)








GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE dbo.usp_qidsDetailsDelete
(
	@Original_ID bigint,
	@Original_qidid bigint,
	@IsNull_FromValue money,
	@Original_FromValue money,
	@IsNull_ToValue money,
	@Original_ToValue money,
	@Original_ACCOUNTID bigint,
	@IsNull_type smallint,
	@Original_type smallint,
	@IsNull_EnterDate datetime,
	@Original_EnterDate datetime,
	@IsNull_Detcode int,
	@Original_Detcode int,
	@IsNull_QidType int,
	@Original_QidType int,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ActionType int,
	@Original_ActionType int,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_Machineid bigint,
	@Original_Machineid bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [qidsDetails] WHERE (([ID] = @Original_ID) AND ([qidid] = @Original_qidid) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ([ACCOUNTID] = @Original_ACCOUNTID) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_Machineid = 1 AND [Machineid] IS NULL) OR ([Machineid] = @Original_Machineid)))

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE dbo.usp_qidsDetailsInsert
(
	@qidid bigint,
	@FromValue money,
	@ToValue money,
	@ACCOUNTID bigint,
	@type smallint,
	@Description ntext,
	@EnterDate datetime,
	@Detcode int,
	@QidType int,
	@TotalPrice money,
	@ActionType int,
	@CostId bigint,
	@Machineid bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [qidsDetails] ([qidid], [FromValue], [ToValue], [ACCOUNTID], [type], [Description], [EnterDate], [Detcode], [QidType], [TotalPrice], [ActionType], [CostId], [Machineid]) VALUES (@qidid, @FromValue, @ToValue, @ACCOUNTID, @type, @Description, @EnterDate, @Detcode, @QidType, @TotalPrice, @ActionType, @CostId, @Machineid);
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId, Machineid FROM qidsDetails WHERE (ID = SCOPE_IDENTITY())

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE dbo.usp_qidsDetailsSelect
AS
	SET NOCOUNT ON;
SELECT        ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId, Machineid
FROM            qidsDetails

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE dbo.usp_qidsDetailsUpdate
(
	@qidid bigint,
	@FromValue money,
	@ToValue money,
	@ACCOUNTID bigint,
	@type smallint,
	@Description ntext,
	@EnterDate datetime,
	@Detcode int,
	@QidType int,
	@TotalPrice money,
	@ActionType int,
	@CostId bigint,
	@Machineid bigint,
	@Original_ID bigint,
	@Original_qidid bigint,
	@IsNull_FromValue money,
	@Original_FromValue money,
	@IsNull_ToValue money,
	@Original_ToValue money,
	@Original_ACCOUNTID bigint,
	@IsNull_type smallint,
	@Original_type smallint,
	@IsNull_EnterDate datetime,
	@Original_EnterDate datetime,
	@IsNull_Detcode int,
	@Original_Detcode int,
	@IsNull_QidType int,
	@Original_QidType int,
	@IsNull_TotalPrice money,
	@Original_TotalPrice money,
	@IsNull_ActionType int,
	@Original_ActionType int,
	@IsNull_CostId bigint,
	@Original_CostId bigint,
	@IsNull_Machineid bigint,
	@Original_Machineid bigint,
	@ID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [qidsDetails] SET [qidid] = @qidid, [FromValue] = @FromValue, [ToValue] = @ToValue, [ACCOUNTID] = @ACCOUNTID, [type] = @type, [Description] = @Description, [EnterDate] = @EnterDate, [Detcode] = @Detcode, [QidType] = @QidType, [TotalPrice] = @TotalPrice, [ActionType] = @ActionType, [CostId] = @CostId, [Machineid] = @Machineid WHERE (([ID] = @Original_ID) AND ([qidid] = @Original_qidid) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ([ACCOUNTID] = @Original_ACCOUNTID) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_Machineid = 1 AND [Machineid] IS NULL) OR ([Machineid] = @Original_Machineid)));
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId, Machineid FROM qidsDetails WHERE (ID = @ID)

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsInsert
(
	@qidcode varchar(50),
	@qidDate smalldatetime,
	@description ntext,
	@edit bit,
	@recitetype int,
	@underupdate bit,
	@name nvarchar(100),
	@BrachId bigint,
	@EmpId bigint,
	@Notes ntext,
	@Active bit,
	@repeated bit,
	@BankAccId bigint,
	@ChequeNo nvarchar(50),
	@InvId bigint,
	@ReorderInvId bigint,
	@PaymentType bit,
	@PaymentTo varchar(300),
	@QidSerial bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [qids] ([qidcode], [qidDate], [description], [edit], [recitetype], [underupdate], [name], [BrachId], [EmpId], [Notes], [Active], [repeated], [BankAccId], [ChequeNo], [InvId], [ReorderInvId], [PaymentType], [PaymentTo], [QidSerial]) VALUES (@qidcode, @qidDate, @description, @edit, @recitetype, @underupdate, @name, @BrachId, @EmpId, @Notes, @Active, @repeated, @BankAccId, @ChequeNo, @InvId, @ReorderInvId, @PaymentType, @PaymentTo, @QidSerial);
	
SELECT qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, ReorderInvId, PaymentType, PaymentTo, QidSerial FROM qids WHERE (qidid = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsSelect
AS
	SET NOCOUNT ON;
SELECT     qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, 
                      ReorderInvId, PaymentType, PaymentTo, QidSerial
FROM         qids







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_qidsUpdate
(
	@qidcode varchar(50),
	@qidDate smalldatetime,
	@description ntext,
	@edit bit,
	@recitetype int,
	@underupdate bit,
	@name nvarchar(100),
	@BrachId bigint,
	@EmpId bigint,
	@Notes ntext,
	@Active bit,
	@repeated bit,
	@BankAccId bigint,
	@ChequeNo nvarchar(50),
	@InvId bigint,
	@ReorderInvId bigint,
	@PaymentType bit,
	@PaymentTo varchar(300),
	@QidSerial bigint,
	@Original_qidid bigint,
	@Original_qidcode varchar(50),
	@IsNull_qidDate Int,
	@Original_qidDate smalldatetime,
	@IsNull_edit Int,
	@Original_edit bit,
	@IsNull_recitetype Int,
	@Original_recitetype int,
	@IsNull_underupdate Int,
	@Original_underupdate bit,
	@IsNull_name Int,
	@Original_name nvarchar(100),
	@IsNull_BrachId Int,
	@Original_BrachId bigint,
	@IsNull_EmpId Int,
	@Original_EmpId bigint,
	@IsNull_Active Int,
	@Original_Active bit,
	@IsNull_repeated Int,
	@Original_repeated bit,
	@IsNull_BankAccId Int,
	@Original_BankAccId bigint,
	@IsNull_ChequeNo Int,
	@Original_ChequeNo nvarchar(50),
	@IsNull_InvId Int,
	@Original_InvId bigint,
	@IsNull_ReorderInvId Int,
	@Original_ReorderInvId bigint,
	@IsNull_PaymentType Int,
	@Original_PaymentType bit,
	@IsNull_PaymentTo Int,
	@Original_PaymentTo varchar(300),
	@IsNull_QidSerial Int,
	@Original_QidSerial bigint,
	@qidid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [qids] SET [qidcode] = @qidcode, [qidDate] = @qidDate, [description] = @description, [edit] = @edit, [recitetype] = @recitetype, [underupdate] = @underupdate, [name] = @name, [BrachId] = @BrachId, [EmpId] = @EmpId, [Notes] = @Notes, [Active] = @Active, [repeated] = @repeated, [BankAccId] = @BankAccId, [ChequeNo] = @ChequeNo, [InvId] = @InvId, [ReorderInvId] = @ReorderInvId, [PaymentType] = @PaymentType, [PaymentTo] = @PaymentTo, [QidSerial] = @QidSerial WHERE (([qidid] = @Original_qidid) AND ([qidcode] = @Original_qidcode) AND ((@IsNull_qidDate = 1 AND [qidDate] IS NULL) OR ([qidDate] = @Original_qidDate)) AND ((@IsNull_edit = 1 AND [edit] IS NULL) OR ([edit] = @Original_edit)) AND ((@IsNull_recitetype = 1 AND [recitetype] IS NULL) OR ([recitetype] = @Original_recitetype)) AND ((@IsNull_underupdate = 1 AND [underupdate] IS NULL) OR ([underupdate] = @Original_underupdate)) AND ((@IsNull_name = 1 AND [name] IS NULL) OR ([name] = @Original_name)) AND ((@IsNull_BrachId = 1 AND [BrachId] IS NULL) OR ([BrachId] = @Original_BrachId)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_repeated = 1 AND [repeated] IS NULL) OR ([repeated] = @Original_repeated)) AND ((@IsNull_BankAccId = 1 AND [BankAccId] IS NULL) OR ([BankAccId] = @Original_BankAccId)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderInvId = 1 AND [ReorderInvId] IS NULL) OR ([ReorderInvId] = @Original_ReorderInvId)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentTo = 1 AND [PaymentTo] IS NULL) OR ([PaymentTo] = @Original_PaymentTo)) AND ((@IsNull_QidSerial = 1 AND [QidSerial] IS NULL) OR ([QidSerial] = @Original_QidSerial)));
	
SELECT qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, ReorderInvId, PaymentType, PaymentTo, QidSerial FROM qids WHERE (qidid = @qidid)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_setupDelete
(
	@IsNull_custaccid smallint,
	@Original_custaccid smallint,
	@IsNull_suppaccid smallint,
	@Original_suppaccid smallint,
	@IsNull_changeid int,
	@Original_changeid int,
	@IsNull_productid int,
	@Original_productid int,
	@IsNull_orderid int,
	@Original_orderid int,
	@IsNull_accountid int,
	@Original_accountid int,
	@IsNull_qidid int,
	@Original_qidid int,
	@IsNull_salesaccid smallint,
	@Original_salesaccid smallint,
	@IsNull_salesAgalaccid bigint,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseaccid smallint,
	@Original_purchaseaccid smallint,
	@IsNull_purchaseAgalaccid bigint,
	@Original_purchaseAgalaccid bigint,
	@IsNull_boxaccid bigint,
	@Original_boxaccid bigint,
	@IsNull_bankaccid bigint,
	@Original_bankaccid bigint,
	@IsNull_PurReorderaccid bigint,
	@Original_PurReorderaccid bigint,
	@IsNull_SalReorderaccid bigint,
	@Original_SalReorderaccid bigint,
	@IsNull_PurReorderAgalaccid bigint,
	@Original_PurReorderAgalaccid bigint,
	@IsNull_SalReorderAgalaccid bigint,
	@Original_SalReorderAgalaccid bigint,
	@IsNull_Discountaccid bigint,
	@Original_Discountaccid bigint,
	@IsNull_Paymentsaccid bigint,
	@Original_Paymentsaccid bigint,
	@IsNull_purchasePayaccid bigint,
	@Original_purchasePayaccid bigint,
	@IsNull_Mainsalesaccid bigint,
	@Original_Mainsalesaccid bigint,
	@IsNull_MainPurchaseaccid bigint,
	@Original_MainPurchaseaccid bigint,
	@IsNull_OsalAccId bigint,
	@Original_OsalAccId bigint,
	@IsNull_DeductAccId bigint,
	@Original_DeductAccId bigint,
	@Original_Code bigint,
	@IsNull_CompanyName nvarchar(150),
	@Original_CompanyName nvarchar(150),
	@IsNull_CompanyNameEng nvarchar(100),
	@Original_CompanyNameEng nvarchar(100),
	@IsNull_Address nvarchar(150),
	@Original_Address nvarchar(150),
	@IsNull_AddressEng nvarchar(150),
	@Original_AddressEng nvarchar(150),
	@IsNull_TelPhone nvarchar(100),
	@Original_TelPhone nvarchar(100),
	@IsNull_TelPhoneEng nvarchar(50),
	@Original_TelPhoneEng nvarchar(50),
	@IsNull_CompActivty nvarchar(100),
	@Original_CompActivty nvarchar(100),
	@IsNull_Fax nvarchar(50),
	@Original_Fax nvarchar(50),
	@IsNull_FaxEng nvarchar(50),
	@Original_FaxEng nvarchar(50),
	@IsNull_Email nvarchar(100),
	@Original_Email nvarchar(100),
	@IsNull_SalesTakastaccid bigint,
	@Original_SalesTakastaccid bigint,
	@IsNull_MovmentProfitsAccid bigint,
	@Original_MovmentProfitsAccid bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [setup] WHERE (((@IsNull_custaccid = 1 AND [custaccid] IS NULL) OR ([custaccid] = @Original_custaccid)) AND ((@IsNull_suppaccid = 1 AND [suppaccid] IS NULL) OR ([suppaccid] = @Original_suppaccid)) AND ((@IsNull_changeid = 1 AND [changeid] IS NULL) OR ([changeid] = @Original_changeid)) AND ((@IsNull_productid = 1 AND [productid] IS NULL) OR ([productid] = @Original_productid)) AND ((@IsNull_orderid = 1 AND [orderid] IS NULL) OR ([orderid] = @Original_orderid)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_qidid = 1 AND [qidid] IS NULL) OR ([qidid] = @Original_qidid)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_purchaseAgalaccid = 1 AND [purchaseAgalaccid] IS NULL) OR ([purchaseAgalaccid] = @Original_purchaseAgalaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_PurReorderaccid = 1 AND [PurReorderaccid] IS NULL) OR ([PurReorderaccid] = @Original_PurReorderaccid)) AND ((@IsNull_SalReorderaccid = 1 AND [SalReorderaccid] IS NULL) OR ([SalReorderaccid] = @Original_SalReorderaccid)) AND ((@IsNull_PurReorderAgalaccid = 1 AND [PurReorderAgalaccid] IS NULL) OR ([PurReorderAgalaccid] = @Original_PurReorderAgalaccid)) AND ((@IsNull_SalReorderAgalaccid = 1 AND [SalReorderAgalaccid] IS NULL) OR ([SalReorderAgalaccid] = @Original_SalReorderAgalaccid)) AND ((@IsNull_Discountaccid = 1 AND [Discountaccid] IS NULL) OR ([Discountaccid] = @Original_Discountaccid)) AND ((@IsNull_Paymentsaccid = 1 AND [Paymentsaccid] IS NULL) OR ([Paymentsaccid] = @Original_Paymentsaccid)) AND ((@IsNull_purchasePayaccid = 1 AND [purchasePayaccid] IS NULL) OR ([purchasePayaccid] = @Original_purchasePayaccid)) AND ((@IsNull_Mainsalesaccid = 1 AND [Mainsalesaccid] IS NULL) OR ([Mainsalesaccid] = @Original_Mainsalesaccid)) AND ((@IsNull_MainPurchaseaccid = 1 AND [MainPurchaseaccid] IS NULL) OR ([MainPurchaseaccid] = @Original_MainPurchaseaccid)) AND ((@IsNull_OsalAccId = 1 AND [OsalAccId] IS NULL) OR ([OsalAccId] = @Original_OsalAccId)) AND ((@IsNull_DeductAccId = 1 AND [DeductAccId] IS NULL) OR ([DeductAccId] = @Original_DeductAccId)) AND ([Code] = @Original_Code) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_CompanyNameEng = 1 AND [CompanyNameEng] IS NULL) OR ([CompanyNameEng] = @Original_CompanyNameEng)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_AddressEng = 1 AND [AddressEng] IS NULL) OR ([AddressEng] = @Original_AddressEng)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_TelPhoneEng = 1 AND [TelPhoneEng] IS NULL) OR ([TelPhoneEng] = @Original_TelPhoneEng)) AND ((@IsNull_CompActivty = 1 AND [CompActivty] IS NULL) OR ([CompActivty] = @Original_CompActivty)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_FaxEng = 1 AND [FaxEng] IS NULL) OR ([FaxEng] = @Original_FaxEng)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_SalesTakastaccid = 1 AND [SalesTakastaccid] IS NULL) OR ([SalesTakastaccid] = @Original_SalesTakastaccid)) AND ((@IsNull_MovmentProfitsAccid = 1 AND [MovmentProfitsAccid] IS NULL) OR ([MovmentProfitsAccid] = @Original_MovmentProfitsAccid)))







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_setupInsert
(
	@custaccid smallint,
	@suppaccid smallint,
	@changeid int,
	@productid int,
	@orderid int,
	@accountid int,
	@qidid int,
	@salesaccid smallint,
	@salesAgalaccid bigint,
	@purchaseaccid smallint,
	@purchaseAgalaccid bigint,
	@boxaccid bigint,
	@bankaccid bigint,
	@PurReorderaccid bigint,
	@SalReorderaccid bigint,
	@PurReorderAgalaccid bigint,
	@SalReorderAgalaccid bigint,
	@Discountaccid bigint,
	@Paymentsaccid bigint,
	@purchasePayaccid bigint,
	@Mainsalesaccid bigint,
	@MainPurchaseaccid bigint,
	@OsalAccId bigint,
	@DeductAccId bigint,
	@CompanyName nvarchar(150),
	@CompanyNameEng nvarchar(100),
	@Address nvarchar(150),
	@AddressEng nvarchar(150),
	@TelPhone nvarchar(100),
	@TelPhoneEng nvarchar(50),
	@Logo image,
	@CompActivty nvarchar(100),
	@Fax nvarchar(50),
	@FaxEng nvarchar(50),
	@Email nvarchar(100),
	@SalesTakastaccid bigint,
	@MovmentProfitsAccid bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [setup] ([custaccid], [suppaccid], [changeid], [productid], [orderid], [accountid], [qidid], [salesaccid], [salesAgalaccid], [purchaseaccid], [purchaseAgalaccid], [boxaccid], [bankaccid], [PurReorderaccid], [SalReorderaccid], [PurReorderAgalaccid], [SalReorderAgalaccid], [Discountaccid], [Paymentsaccid], [purchasePayaccid], [Mainsalesaccid], [MainPurchaseaccid], [OsalAccId], [DeductAccId], [CompanyName], [CompanyNameEng], [Address], [AddressEng], [TelPhone], [TelPhoneEng], [Logo], [CompActivty], [Fax], [FaxEng], [Email], [SalesTakastaccid], [MovmentProfitsAccid]) VALUES (@custaccid, @suppaccid, @changeid, @productid, @orderid, @accountid, @qidid, @salesaccid, @salesAgalaccid, @purchaseaccid, @purchaseAgalaccid, @boxaccid, @bankaccid, @PurReorderaccid, @SalReorderaccid, @PurReorderAgalaccid, @SalReorderAgalaccid, @Discountaccid, @Paymentsaccid, @purchasePayaccid, @Mainsalesaccid, @MainPurchaseaccid, @OsalAccId, @DeductAccId, @CompanyName, @CompanyNameEng, @Address, @AddressEng, @TelPhone, @TelPhoneEng, @Logo, @CompActivty, @Fax, @FaxEng, @Email, @SalesTakastaccid, @MovmentProfitsAccid);
	
SELECT custaccid, suppaccid, changeid, productid, orderid, accountid, qidid, salesaccid, salesAgalaccid, purchaseaccid, purchaseAgalaccid, boxaccid, bankaccid, PurReorderaccid, SalReorderaccid, PurReorderAgalaccid, SalReorderAgalaccid, Discountaccid, Paymentsaccid, purchasePayaccid, Mainsalesaccid, MainPurchaseaccid, OsalAccId, DeductAccId, Code, CompanyName, CompanyNameEng, Address, AddressEng, TelPhone, TelPhoneEng, Logo, CompActivty, Fax, FaxEng, Email, SalesTakastaccid, MovmentProfitsAccid FROM setup WHERE (Code = SCOPE_IDENTITY())







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_setupSelect
AS
	SET NOCOUNT ON;
SELECT     custaccid, suppaccid, changeid, productid, orderid, accountid, qidid, salesaccid, salesAgalaccid, purchaseaccid, purchaseAgalaccid, boxaccid, 
                      bankaccid, PurReorderaccid, SalReorderaccid, PurReorderAgalaccid, SalReorderAgalaccid, Discountaccid, Paymentsaccid, purchasePayaccid, 
                      Mainsalesaccid, MainPurchaseaccid, OsalAccId, DeductAccId, Code, CompanyName, CompanyNameEng, Address, AddressEng, TelPhone, 
                      TelPhoneEng, Logo, CompActivty, Fax, FaxEng, Email, SalesTakastaccid, MovmentProfitsAccid
FROM         setup







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO








CREATE PROCEDURE dbo.usp_setupUpdate
(
	@custaccid smallint,
	@suppaccid smallint,
	@changeid int,
	@productid int,
	@orderid int,
	@accountid int,
	@qidid int,
	@salesaccid smallint,
	@salesAgalaccid bigint,
	@purchaseaccid smallint,
	@purchaseAgalaccid bigint,
	@boxaccid bigint,
	@bankaccid bigint,
	@PurReorderaccid bigint,
	@SalReorderaccid bigint,
	@PurReorderAgalaccid bigint,
	@SalReorderAgalaccid bigint,
	@Discountaccid bigint,
	@Paymentsaccid bigint,
	@purchasePayaccid bigint,
	@Mainsalesaccid bigint,
	@MainPurchaseaccid bigint,
	@OsalAccId bigint,
	@DeductAccId bigint,
	@CompanyName nvarchar(150),
	@CompanyNameEng nvarchar(100),
	@Address nvarchar(150),
	@AddressEng nvarchar(150),
	@TelPhone nvarchar(100),
	@TelPhoneEng nvarchar(50),
	@Logo image,
	@CompActivty nvarchar(100),
	@Fax nvarchar(50),
	@FaxEng nvarchar(50),
	@Email nvarchar(100),
	@SalesTakastaccid bigint,
	@MovmentProfitsAccid bigint,
	@IsNull_custaccid smallint,
	@Original_custaccid smallint,
	@IsNull_suppaccid smallint,
	@Original_suppaccid smallint,
	@IsNull_changeid int,
	@Original_changeid int,
	@IsNull_productid int,
	@Original_productid int,
	@IsNull_orderid int,
	@Original_orderid int,
	@IsNull_accountid int,
	@Original_accountid int,
	@IsNull_qidid int,
	@Original_qidid int,
	@IsNull_salesaccid smallint,
	@Original_salesaccid smallint,
	@IsNull_salesAgalaccid bigint,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseaccid smallint,
	@Original_purchaseaccid smallint,
	@IsNull_purchaseAgalaccid bigint,
	@Original_purchaseAgalaccid bigint,
	@IsNull_boxaccid bigint,
	@Original_boxaccid bigint,
	@IsNull_bankaccid bigint,
	@Original_bankaccid bigint,
	@IsNull_PurReorderaccid bigint,
	@Original_PurReorderaccid bigint,
	@IsNull_SalReorderaccid bigint,
	@Original_SalReorderaccid bigint,
	@IsNull_PurReorderAgalaccid bigint,
	@Original_PurReorderAgalaccid bigint,
	@IsNull_SalReorderAgalaccid bigint,
	@Original_SalReorderAgalaccid bigint,
	@IsNull_Discountaccid bigint,
	@Original_Discountaccid bigint,
	@IsNull_Paymentsaccid bigint,
	@Original_Paymentsaccid bigint,
	@IsNull_purchasePayaccid bigint,
	@Original_purchasePayaccid bigint,
	@IsNull_Mainsalesaccid bigint,
	@Original_Mainsalesaccid bigint,
	@IsNull_MainPurchaseaccid bigint,
	@Original_MainPurchaseaccid bigint,
	@IsNull_OsalAccId bigint,
	@Original_OsalAccId bigint,
	@IsNull_DeductAccId bigint,
	@Original_DeductAccId bigint,
	@Original_Code bigint,
	@IsNull_CompanyName nvarchar(150),
	@Original_CompanyName nvarchar(150),
	@IsNull_CompanyNameEng nvarchar(100),
	@Original_CompanyNameEng nvarchar(100),
	@IsNull_Address nvarchar(150),
	@Original_Address nvarchar(150),
	@IsNull_AddressEng nvarchar(150),
	@Original_AddressEng nvarchar(150),
	@IsNull_TelPhone nvarchar(100),
	@Original_TelPhone nvarchar(100),
	@IsNull_TelPhoneEng nvarchar(50),
	@Original_TelPhoneEng nvarchar(50),
	@IsNull_CompActivty nvarchar(100),
	@Original_CompActivty nvarchar(100),
	@IsNull_Fax nvarchar(50),
	@Original_Fax nvarchar(50),
	@IsNull_FaxEng nvarchar(50),
	@Original_FaxEng nvarchar(50),
	@IsNull_Email nvarchar(100),
	@Original_Email nvarchar(100),
	@IsNull_SalesTakastaccid bigint,
	@Original_SalesTakastaccid bigint,
	@IsNull_MovmentProfitsAccid bigint,
	@Original_MovmentProfitsAccid bigint,
	@Code bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [setup] SET [custaccid] = @custaccid, [suppaccid] = @suppaccid, [changeid] = @changeid, [productid] = @productid, [orderid] = @orderid, [accountid] = @accountid, [qidid] = @qidid, [salesaccid] = @salesaccid, [salesAgalaccid] = @salesAgalaccid, [purchaseaccid] = @purchaseaccid, [purchaseAgalaccid] = @purchaseAgalaccid, [boxaccid] = @boxaccid, [bankaccid] = @bankaccid, [PurReorderaccid] = @PurReorderaccid, [SalReorderaccid] = @SalReorderaccid, [PurReorderAgalaccid] = @PurReorderAgalaccid, [SalReorderAgalaccid] = @SalReorderAgalaccid, [Discountaccid] = @Discountaccid, [Paymentsaccid] = @Paymentsaccid, [purchasePayaccid] = @purchasePayaccid, [Mainsalesaccid] = @Mainsalesaccid, [MainPurchaseaccid] = @MainPurchaseaccid, [OsalAccId] = @OsalAccId, [DeductAccId] = @DeductAccId, [CompanyName] = @CompanyName, [CompanyNameEng] = @CompanyNameEng, [Address] = @Address, [AddressEng] = @AddressEng, [TelPhone] = @TelPhone, [TelPhoneEng] = @TelPhoneEng, [Logo] = @Logo, [CompActivty] = @CompActivty, [Fax] = @Fax, [FaxEng] = @FaxEng, [Email] = @Email, [SalesTakastaccid] = @SalesTakastaccid, [MovmentProfitsAccid] = @MovmentProfitsAccid WHERE (((@IsNull_custaccid = 1 AND [custaccid] IS NULL) OR ([custaccid] = @Original_custaccid)) AND ((@IsNull_suppaccid = 1 AND [suppaccid] IS NULL) OR ([suppaccid] = @Original_suppaccid)) AND ((@IsNull_changeid = 1 AND [changeid] IS NULL) OR ([changeid] = @Original_changeid)) AND ((@IsNull_productid = 1 AND [productid] IS NULL) OR ([productid] = @Original_productid)) AND ((@IsNull_orderid = 1 AND [orderid] IS NULL) OR ([orderid] = @Original_orderid)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)) AND ((@IsNull_qidid = 1 AND [qidid] IS NULL) OR ([qidid] = @Original_qidid)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_purchaseAgalaccid = 1 AND [purchaseAgalaccid] IS NULL) OR ([purchaseAgalaccid] = @Original_purchaseAgalaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_PurReorderaccid = 1 AND [PurReorderaccid] IS NULL) OR ([PurReorderaccid] = @Original_PurReorderaccid)) AND ((@IsNull_SalReorderaccid = 1 AND [SalReorderaccid] IS NULL) OR ([SalReorderaccid] = @Original_SalReorderaccid)) AND ((@IsNull_PurReorderAgalaccid = 1 AND [PurReorderAgalaccid] IS NULL) OR ([PurReorderAgalaccid] = @Original_PurReorderAgalaccid)) AND ((@IsNull_SalReorderAgalaccid = 1 AND [SalReorderAgalaccid] IS NULL) OR ([SalReorderAgalaccid] = @Original_SalReorderAgalaccid)) AND ((@IsNull_Discountaccid = 1 AND [Discountaccid] IS NULL) OR ([Discountaccid] = @Original_Discountaccid)) AND ((@IsNull_Paymentsaccid = 1 AND [Paymentsaccid] IS NULL) OR ([Paymentsaccid] = @Original_Paymentsaccid)) AND ((@IsNull_purchasePayaccid = 1 AND [purchasePayaccid] IS NULL) OR ([purchasePayaccid] = @Original_purchasePayaccid)) AND ((@IsNull_Mainsalesaccid = 1 AND [Mainsalesaccid] IS NULL) OR ([Mainsalesaccid] = @Original_Mainsalesaccid)) AND ((@IsNull_MainPurchaseaccid = 1 AND [MainPurchaseaccid] IS NULL) OR ([MainPurchaseaccid] = @Original_MainPurchaseaccid)) AND ((@IsNull_OsalAccId = 1 AND [OsalAccId] IS NULL) OR ([OsalAccId] = @Original_OsalAccId)) AND ((@IsNull_DeductAccId = 1 AND [DeductAccId] IS NULL) OR ([DeductAccId] = @Original_DeductAccId)) AND ([Code] = @Original_Code) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_CompanyNameEng = 1 AND [CompanyNameEng] IS NULL) OR ([CompanyNameEng] = @Original_CompanyNameEng)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_AddressEng = 1 AND [AddressEng] IS NULL) OR ([AddressEng] = @Original_AddressEng)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_TelPhoneEng = 1 AND [TelPhoneEng] IS NULL) OR ([TelPhoneEng] = @Original_TelPhoneEng)) AND ((@IsNull_CompActivty = 1 AND [CompActivty] IS NULL) OR ([CompActivty] = @Original_CompActivty)) AND ((@IsNull_Fax = 1 AND [Fax] IS NULL) OR ([Fax] = @Original_Fax)) AND ((@IsNull_FaxEng = 1 AND [FaxEng] IS NULL) OR ([FaxEng] = @Original_FaxEng)) AND ((@IsNull_Email = 1 AND [Email] IS NULL) OR ([Email] = @Original_Email)) AND ((@IsNull_SalesTakastaccid = 1 AND [SalesTakastaccid] IS NULL) OR ([SalesTakastaccid] = @Original_SalesTakastaccid)) AND ((@IsNull_MovmentProfitsAccid = 1 AND [MovmentProfitsAccid] IS NULL) OR ([MovmentProfitsAccid] = @Original_MovmentProfitsAccid)));
	
SELECT custaccid, suppaccid, changeid, productid, orderid, accountid, qidid, salesaccid, salesAgalaccid, purchaseaccid, purchaseAgalaccid, boxaccid, bankaccid, PurReorderaccid, SalReorderaccid, PurReorderAgalaccid, SalReorderAgalaccid, Discountaccid, Paymentsaccid, purchasePayaccid, Mainsalesaccid, MainPurchaseaccid, OsalAccId, DeductAccId, Code, CompanyName, CompanyNameEng, Address, AddressEng, TelPhone, TelPhoneEng, Logo, CompActivty, Fax, FaxEng, Email, SalesTakastaccid, MovmentProfitsAccid FROM setup WHERE (Code = @Code)







GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

