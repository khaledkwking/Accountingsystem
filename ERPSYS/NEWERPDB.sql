if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_STORES_BRANCHES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[STORES] DROP CONSTRAINT FK_STORES_BRANCHES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CPJD_CPD_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CDE_PER_JOB_DEGREE] DROP CONSTRAINT CPJD_CPD_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CPFD_CPDT_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CDE_PER_FILE_DOC] DROP CONSTRAINT CPFD_CPDT_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PED2_CPDT_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_DOCUMNET] DROP CONSTRAINT PED2_CPDT_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CPRT2_CRD_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CDE_PER_REPORT_TYPE] DROP CONSTRAINT CPRT2_CRD_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CPFD_CPFT_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CDE_PER_FILE_DOC] DROP CONSTRAINT CPFD_CPFT_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEQ_CPG_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_QLF] DROP CONSTRAINT PEQ_CPG_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_CPG_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_REPORT] DROP CONSTRAINT PER_CPG_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEJ1_CPJD_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_JOB] DROP CONSTRAINT PEJ1_CPJD_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PJYB_CPJD_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_JOB_YEAR_BUDGET] DROP CONSTRAINT PJYB_CPJD_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PER_EMP_DISCOUNT_CDE_PER_PENALTY]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_DISCOUNT] DROP CONSTRAINT FK_PER_EMP_DISCOUNT_CDE_PER_PENALTY
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CPQD_CPQ_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[CDE_PER_QLF_DTL] DROP CONSTRAINT CPQD_CPQ_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEQ_CPQD_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_QLF] DROP CONSTRAINT PEQ_CPQD_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEQ_CPQE_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_QLF] DROP CONSTRAINT PEQ_CPQE_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_CPR2_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_RELATIVE] DROP CONSTRAINT PER_EMP_CPR2_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_CPRT2_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_REPORT] DROP CONSTRAINT PER_CPRT2_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEVB_CPVT_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_VAC_BALANCE] DROP CONSTRAINT PEVB_CPVT_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEV_CPVT_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_VACATION] DROP CONSTRAINT PEV_CPVT_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PRL_EMP_BASIC_SAL_CDE_PRL_SAL_CATEGORY]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRL_EMP_BASIC_SAL] DROP CONSTRAINT FK_PRL_EMP_BASIC_SAL_CDE_PRL_SAL_CATEGORY
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PRODUCTS_CDE_PRODUCTTYPES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRODUCTS] DROP CONSTRAINT FK_PRODUCTS_CDE_PRODUCTTYPES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductUnits_CDE_UNIT_TYPES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Product_Units_Prices] DROP CONSTRAINT FK_ProductUnits_CDE_UNIT_TYPES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductOffers_CDE_UNIT_TYPES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ProductOffers] DROP CONSTRAINT FK_ProductOffers_CDE_UNIT_TYPES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_USER_FUNCTION_FUNCTIONS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[USER_FUNCTION] DROP CONSTRAINT FK_USER_FUNCTION_FUNCTIONS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Installment_Distribution_Installment]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Installment_Distribution] DROP CONSTRAINT FK_Installment_Distribution_Installment
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PER_EMP_ABSENCE_PER_EMP_DATA]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_ABSENCE] DROP CONSTRAINT FK_PER_EMP_ABSENCE_PER_EMP_DATA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PER_EMP_DISCOUNT_PER_EMP_DATA]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_DISCOUNT] DROP CONSTRAINT FK_PER_EMP_DISCOUNT_PER_EMP_DATA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PED2_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_DOCUMNET] DROP CONSTRAINT PED2_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEJ1_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_JOB] DROP CONSTRAINT PEJ1_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEQ_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_QLF] DROP CONSTRAINT PEQ_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_RELATIVE] DROP CONSTRAINT PER_EMP_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_REPORT] DROP CONSTRAINT PER_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEVB_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_VAC_BALANCE] DROP CONSTRAINT PEVB_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PEV_PED_FK]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PER_EMP_VACATION] DROP CONSTRAINT PEV_PED_FK
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_PRL_EMP_LOAN_DETAIL_PER_EMP_DATA]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[PRL_EMP_LOAN_DETAIL] DROP CONSTRAINT FK_PRL_EMP_LOAN_DETAIL_PER_EMP_DATA
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductAssemply_PRODUCTS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Product_Assemply] DROP CONSTRAINT FK_ProductAssemply_PRODUCTS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductUnits_PRODUCTS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Product_Units_Prices] DROP CONSTRAINT FK_ProductUnits_PRODUCTS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductOffers_PRODUCTS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ProductOffers] DROP CONSTRAINT FK_ProductOffers_PRODUCTS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductReplacment_PRODUCTS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ProductReplacment] DROP CONSTRAINT FK_ProductReplacment_PRODUCTS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ProductVALIDITY_PRODUCTS]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ProductVALIDITY] DROP CONSTRAINT FK_ProductVALIDITY_PRODUCTS
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_STOCK_Product_Units_Prices]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[STOCK] DROP CONSTRAINT FK_STOCK_Product_Units_Prices
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_STOCK_STORES]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[STOCK] DROP CONSTRAINT FK_STOCK_STORES
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_USER_FUNCTION_USER]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[USER_FUNCTION] DROP CONSTRAINT FK_USER_FUNCTION_USER
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_qidsDetails_accounting]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[qidsDetails] DROP CONSTRAINT FK_qidsDetails_accounting
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Inv_Products_invoices]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Inv_Products] DROP CONSTRAINT FK_Inv_Products_invoices
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_qids_invoices]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[qids] DROP CONSTRAINT FK_qids_invoices
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_qidsDetails_qids]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[qidsDetails] DROP CONSTRAINT FK_qidsDetails_qids
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delProductTrigger]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[delProductTrigger]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Insert_Qty]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Insert_Qty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Update_Qty]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Update_Qty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UP_PER_EMP_JOB_AFTER_INSERT]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[UP_PER_EMP_JOB_AFTER_INSERT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSTEAD_OF_INSERT_ON_PER_EMP_JOB]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[INSTEAD_OF_INSERT_ON_PER_EMP_JOB]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UP_PER_EMP_JOB_AFTER_UPDATE]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[UP_PER_EMP_JOB_AFTER_UPDATE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[INSTEAD_OF_UPDATE_ON_PER_EMP_JOB]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[INSTEAD_OF_UPDATE_ON_PER_EMP_JOB]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Insert_MoveQty]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Insert_MoveQty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Update_MoveQty]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Update_MoveQty]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AcctUpdate]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[AcctUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DelAccountTrg]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[DelAccountTrg]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[delQidDet]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[delQidDet]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Insert_Qid]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Insert_Qid]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Update_Qid]') and OBJECTPROPERTY(id, N'IsTrigger') = 1)
drop trigger [dbo].[Update_Qid]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fn_Select_InvoicePayment]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[fn_Select_InvoicePayment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fn_Select_totalFromValue]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[fn_Select_totalFromValue]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fn_Select_totalFromValueBefore]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[fn_Select_totalFromValueBefore]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fn_Select_totalToValue]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[fn_Select_totalToValue]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[fn_Select_totalToValuebefore]') and xtype in (N'FN', N'IF', N'TF'))
drop function [dbo].[fn_Select_totalToValuebefore]
GO

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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountA3marAlDauan]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountA3marAlDauan]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountA3marAlDauanMonths]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountA3marAlDauanMonths]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewByQidId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewByQidId]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewSelectByParm]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewSelectByParm]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_AccountingViewbyRecitetype]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_AccountingViewbyRecitetype]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckInvCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckInvCode]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CheckInvOrdersCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CheckInvOrdersCode]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_CustomerSalesSelectView]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_CustomerSalesSelectView]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCEDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCEDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCEInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCEInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_ABSENCESelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_ABSENCESelect]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EMP_VACATIONUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EMP_VACATIONUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_EmpSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_EmpSelect]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Inv_ProductsUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Inv_ProductsUpdate]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoicesDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoicesDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoicesInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoicesInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoicesSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoicesSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_InvoicesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_InvoicesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_MonthsSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_MonthsSelect]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PER_EMP_AllowanceUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PER_EMP_AllowanceUpdate]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_PRODUCTUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_PRODUCTUpdate]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplyDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplyDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplyInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplyInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_AssemplySelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_AssemplySelect]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_Product_Units_PricesUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_Product_Units_PricesUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductsSelectQuery]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductsSelectQuery]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_ProductsSelectStock]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_ProductsSelectStock]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_STORESSelectByBranchId]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_STORESSelectByBranchId]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_StockSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_StockSelect]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingDelete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingDelete]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingInsert]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingInsert]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingSelect]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingSelect]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_accountingUpdate]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_accountingUpdate]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[usp_invoicesSelectbyCode]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[usp_invoicesSelectbyCode]
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

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvProductsMoveVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvProductsMoveVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[StockView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[StockView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[AccountingView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[AccountingView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvAllProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvAllProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CustomerInvoicesView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[CustomerInvoicesView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvReorderProductsVIEW]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvReorderProductsVIEW]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvoiceView]') and OBJECTPROPERTY(id, N'IsView') = 1)
drop view [dbo].[InvoiceView]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[BRANCHES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[BRANCHES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_BANKS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_BANKS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_Categories]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_Categories]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_DEPT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_DEPT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_GOVERNORATE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_GOVERNORATE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_GROUPS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_GROUPS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_MONTHS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_MONTHS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_NATIONALITY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_NATIONALITY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_Offer_Types]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_Offer_Types]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_DEGREE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_DEGREE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_DOCUMENT_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_DOCUMENT_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_DURATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_DURATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_FILE_DOC]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_FILE_DOC]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_FILE_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_FILE_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_GRADE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_GRADE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_JOB]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_JOB]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_JOB_CLASS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_JOB_CLASS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_JOB_DEGREE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_JOB_DEGREE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_PENALTY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_PENALTY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_QLF]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_QLF]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_QLF_DTL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_QLF_DTL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_QLF_ENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_QLF_ENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_QLF_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_QLF_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_REC_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_REC_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_RELATIVE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_RELATIVE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_REPORT_TYPE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_REPORT_TYPE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_RETIRE_REASON]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_RETIRE_REASON]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_VACATION_CLASS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_VACATION_CLASS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PER_VAC_SUB_CLASS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PER_VAC_SUB_CLASS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PRL_SAL_CATEGORY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PRL_SAL_CATEGORY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_PRODUCTTYPES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_PRODUCTTYPES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CDE_UNIT_TYPES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CDE_UNIT_TYPES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CREDITS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CREDITS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Category]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Category]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Cde_QidTypes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Cde_QidTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CostCenters]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CostCenters]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Emp_Groups]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Emp_Groups]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FIGURES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FIGURES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FUNCTIONS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[FUNCTIONS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GROUP]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GROUP]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GROUP_FUNCTION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GROUP_FUNCTION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[GROUP_USER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[GROUP_USER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Installment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Installment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Installment_Distribution]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Installment_Distribution]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvOrders]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[InvOrders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[InvOrders_Products]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[InvOrders_Products]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Inv_Products]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Inv_Products]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ORDERDETAILS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ORDERDETAILS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ORDERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ORDERS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMPLOYEE_DATA]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMPLOYEE_DATA]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_ABSENCE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_ABSENCE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_Allowance]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_Allowance]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_DISCOUNT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_DISCOUNT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_DOCUMNET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_DOCUMNET]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_JOB]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_JOB]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_QLF]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_QLF]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_RELATIVE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_RELATIVE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_REPORT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_REPORT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_VACATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_VACATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_EMP_VAC_BALANCE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_EMP_VAC_BALANCE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PER_JOB_YEAR_BUDGET]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PER_JOB_YEAR_BUDGET]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRL_EMP_ATTENDENCE]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRL_EMP_ATTENDENCE]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRL_EMP_BASIC_SAL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRL_EMP_BASIC_SAL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRL_EMP_LOAN_DETAIL]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRL_EMP_LOAN_DETAIL]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRL_EMP_SAL_CALCULATION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRL_EMP_SAL_CALCULATION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRL_EMP_SAL_ELEMENT]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRL_EMP_SAL_ELEMENT]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PRODUCTS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PRODUCTS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[PerEmpLoanDetailsReport]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[PerEmpLoanDetailsReport]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductOffers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductOffers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductReplacment]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductReplacment]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProductVALIDITY]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProductVALIDITY]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Product_Assemply]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Product_Assemply]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Product_Units_Prices]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Product_Units_Prices]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[STOCK]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[STOCK]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[STORES]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[STORES]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SUPPLIERS_CUSTOMERS]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SUPPLIERS_CUSTOMERS]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[SetupCodes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[SetupCodes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[StockMovement]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[StockMovement]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USER]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[USER]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[USER_FUNCTION]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[USER_FUNCTION]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[accounting]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[accounting]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[companyinfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[companyinfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[creditssupp]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[creditssupp]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[custproduct]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[custproduct]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[invoices]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[invoices]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[purchases]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[purchases]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[qids]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[qids]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[qidsDetails]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[qidsDetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[qidsDetailsClosed]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[qidsDetailsClosed]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[setup]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[setup]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[users]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[users]
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS OFF 
GO

CREATE FUNCTION fn_Select_InvoicePayment(@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime)
RETURNS money 

as 

BEGIN


	declare @PaymentValue money
	set @PaymentValue=0
	
	
	SELECT   @PaymentValue=sum(CollectValue) 
	FROM         dbo.invoices
	WHERE     Cust_Sup_Accid = @accountid and  BranchId = @BrachId and  PaymentDate >= @FromDate AND PaymentDate <= @ToDate
	GROUP BY Cust_Sup_Accid
	
	    RETURN ( @PaymentValue )

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

CREATE FUNCTION fn_Select_totalFromValue(@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime)
RETURNS money 
as

BEGIN
DECLARE @NewAccountId bigint
DECLARE @Total money

	declare @totalFromValue money
set @totalFromValue=0
	SELECT     @totalFromValue= SUM(isnull(fromValue,0)) 
	FROM       AccountingView
	WHERE     (ACCOUNTID= @ACCOUNTID )  AND ( BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate  or  @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
	and (repeated =0 or repeated is null )
GROUP BY ACCOUNTID

set @Total=isnull(@totalFromValue,0)
--if (@Total is null )  set @Total=0


DECLARE c1 CURSOR local  FOR
  SELECT accountid
   FROM  accounting
   WHERE AccountparentId = @ACCOUNTID
	
OPEN c1
FETCH NEXT FROM c1 INTO @NewAccountId
WHILE @@fetch_status = 0
BEGIN
  
Set @Total=@Total+dbo.fn_Select_totalFromValue(@NewAccountId,@BrachId,@FromDate,@ToDate)

  FETCH NEXT FROM c1 INTO @NewAccountId
END
CLOSE c1
DEALLOCATE c1


    RETURN ( @Total )

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

CREATE FUNCTION fn_Select_totalFromValueBefore(@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime)
RETURNS money 
as

BEGIN
DECLARE @NewAccountId bigint
DECLARE @Total money

	declare @totalFromValue money
set @totalFromValue=0
	SELECT     @totalFromValue= SUM(isnull(fromValue,0)) 
	FROM       AccountingView
	WHERE   (  (ACCOUNTID= @ACCOUNTID )  AND ( BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate  or  @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
	 and ( repeated is null ) )   or ( ACCOUNTID= @ACCOUNTID and repeated =1) 
GROUP BY ACCOUNTID


set @Total=isnull(@totalFromValue,0)
--if (@Total is null )  set @Total=0


DECLARE c1 CURSOR local  FOR
  SELECT accountid
   FROM  accounting
   WHERE AccountparentId = @ACCOUNTID
	
OPEN c1
FETCH NEXT FROM c1 INTO @NewAccountId
WHILE @@fetch_status = 0
BEGIN
  
Set @Total=@Total+dbo.fn_Select_totalFromValueBefore(@NewAccountId,@BrachId,@FromDate,@ToDate)

  FETCH NEXT FROM c1 INTO @NewAccountId
END
CLOSE c1
DEALLOCATE c1


    RETURN ( @Total )

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

CREATE FUNCTION fn_Select_totalToValue(@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime)
RETURNS money 
as

BEGIN
DECLARE @NewAccountId bigint
DECLARE @Total money

	declare @totalFromValue money
set @totalFromValue=0
	SELECT     @totalFromValue= SUM(isnull(ToValue,0)) 
	FROM       AccountingView
	WHERE     (ACCOUNTID= @ACCOUNTID )  AND ( BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate  or  @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
and (repeated =0 or repeated is null )
GROUP BY ACCOUNTID

set @Total=isnull(@totalFromValue,0)

DECLARE c1 CURSOR local  FOR
  SELECT accountid
   FROM  accounting
   WHERE AccountparentId = @ACCOUNTID
	
OPEN c1
FETCH NEXT FROM c1 INTO @NewAccountId
WHILE @@fetch_status = 0
BEGIN
  
Set @Total=@Total+dbo.fn_Select_totalToValue(@NewAccountId,@BrachId,@FromDate,@ToDate)

  FETCH NEXT FROM c1 INTO @NewAccountId
END
CLOSE c1
DEALLOCATE c1


    RETURN ( @Total )

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

CREATE FUNCTION fn_Select_totalToValuebefore(@ACCOUNTID bigint,
	@BrachId bigint,
	@FromDate smalldatetime,
	@ToDate smalldatetime)
RETURNS money 
as

BEGIN
DECLARE @NewAccountId bigint
DECLARE @Total money
declare @totalFromValue money

set @totalFromValue=0
	SELECT     @totalFromValue= SUM(isnull(ToValue,0)) 
	FROM       AccountingView
	WHERE    ( (ACCOUNTID= @ACCOUNTID )  AND ( BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate  or  @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
 and ( repeated is null  ))   or ( ACCOUNTID= @ACCOUNTID and repeated =1) 
GROUP BY ACCOUNTID

set @Total=isnull(@totalFromValue,0)

DECLARE c1 CURSOR local  FOR
  SELECT accountid
   FROM  accounting
   WHERE AccountparentId = @ACCOUNTID
	
OPEN c1
FETCH NEXT FROM c1 INTO @NewAccountId
WHILE @@fetch_status = 0
BEGIN
  
Set @Total=@Total+dbo.fn_Select_totalToValuebefore(@NewAccountId,@BrachId,@FromDate,@ToDate)

  FETCH NEXT FROM c1 INTO @NewAccountId
END
CLOSE c1
DEALLOCATE c1


    RETURN ( @Total )

END























GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE TABLE [dbo].[BRANCHES] (
	[BRANCHCODE] [bigint] IDENTITY (1, 1) NOT NULL ,
	[BRANCHNAME] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[CompanyName] [nvarchar] (150) COLLATE Arabic_CI_AS NULL ,
	[Address] [nvarchar] (150) COLLATE Arabic_CI_AS NULL ,
	[TelPhone] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[HintName] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[SalInvSerial] [bigint] NULL ,
	[PurchInvSerial] [bigint] NULL ,
	[InvOrderSerial] [bigint] NULL ,
	[OrderSerial] [bigint] NULL ,
	[salesaccid] [smallint] NULL ,
	[purchaseaccid] [smallint] NULL ,
	[boxaccid] [bigint] NULL ,
	[bankaccid] [bigint] NULL ,
	[Visaaccid] [bigint] NULL ,
	[Masteraccid] [bigint] NULL ,
	[KeyNetaccid] [bigint] NULL ,
	[Otheraccid] [bigint] NULL ,
	[VisaComaccid] [bigint] NULL ,
	[MasterComaccid] [bigint] NULL ,
	[KeyNetComaccid] [bigint] NULL ,
	[OtherComaccid] [bigint] NULL ,
	[salesAgalaccid] [bigint] NULL ,
	[purchaseAgalaaccid] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_BANKS] (
	[BNK_CODE] [numeric](5, 0) NOT NULL ,
	[BNK_DESC] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_Categories] (
	[categoryid] [int] NULL ,
	[categoryname] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[categoryparent] [int] NULL ,
	[lastnode] [bit] NOT NULL ,
	[notes] [ntext] COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_DEPT] (
	[DEPT_CODE] [bigint] IDENTITY (1, 1) NOT NULL ,
	[DEPT_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_GOVERNORATE] (
	[GOVER_CODE] [numeric](5, 0) NOT NULL ,
	[GOVER_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_GROUPS] (
	[GROUP_CODE] [bigint] IDENTITY (1, 1) NOT NULL ,
	[GROUP_NAME] [nvarchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[WORK_HOURS_NUM] [numeric](18, 0) NULL ,
	[VAC_NUM] [numeric](18, 0) NULL ,
	[ABSEN_HOURS_NUM] [numeric](18, 0) NULL ,
	[ADD_HOURS_NUM] [numeric](18, 0) NULL ,
	[HOUR_IN_VAC] [numeric](18, 0) NULL ,
	[ABSEN_DAY] [numeric](18, 0) NULL ,
	[TYPE_WORK] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_MONTHS] (
	[MON_CODE] [numeric](5, 0) NOT NULL ,
	[MON_DESC] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_NATIONALITY] (
	[NATIONALITY_CODE] [numeric](5, 0) NOT NULL ,
	[NATIONALITY_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_Offer_Types] (
	[OfferTypeID] [bigint] NOT NULL ,
	[OfferTypeDesc] [nvarchar] (50) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_DEGREE] (
	[DEGREE_CODE] [numeric](5, 0) NOT NULL ,
	[DEGREE_END_SALARY] [numeric](7, 2) NULL ,
	[DEGREE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[RAISE_PERIOD] [numeric](5, 0) NULL ,
	[DEGREE_START_SALARY] [numeric](7, 2) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_DOCUMENT_TYPE] (
	[DOC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[EXP_DATE_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL ,
	[DOC_TYPE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[DOC_M_F_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_DURATION] (
	[DURATION_CODE] [numeric](2, 0) NOT NULL ,
	[DURATION_NUM] [numeric](2, 0) NOT NULL ,
	[DURATION_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_FILE_DOC] (
	[FILE_CODE] [numeric](5, 0) NOT NULL ,
	[DOC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_FILE_TYPE] (
	[FILE_CODE] [numeric](5, 0) NOT NULL ,
	[FILE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_GRADE] (
	[GRAD_CODE] [numeric](5, 0) NOT NULL ,
	[GRAD_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[RANGE_FROM] [numeric](5, 0) NULL ,
	[RANGE_TO] [numeric](5, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_JOB] (
	[JOB_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CLS_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_JOB_CLASS] (
	[JOB_CLS_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CLS_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_JOB_DEGREE] (
	[JOB_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CLS_CODE] [numeric](5, 0) NOT NULL ,
	[DEGREE_CODE] [numeric](5, 0) NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_PENALTY] (
	[PEN_CODE] [numeric](5, 0) NOT NULL ,
	[PEN_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_QLF] (
	[QLF_CODE] [numeric](5, 0) NOT NULL ,
	[QLF_TYP_CODE] [numeric](5, 0) NOT NULL ,
	[QLF_DESC] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[AZHAR_FLAG] [numeric](1, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_QLF_DTL] (
	[QLF_CODE] [numeric](5, 0) NOT NULL ,
	[QLF_TYP_CODE] [numeric](5, 0) NOT NULL ,
	[SPEC_CODE] [numeric](5, 0) NOT NULL ,
	[SPEC_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_QLF_ENT] (
	[QUAL_ENT_CODE] [numeric](5, 0) NOT NULL ,
	[QUAL_ENT_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_QLF_TYPE] (
	[QLF_TYP_CODE] [numeric](5, 0) NOT NULL ,
	[QLF_TYP_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[QLF_ORDER] [numeric](3, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_REC_TYPE] (
	[REC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[REC_TYPE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_RELATIVE] (
	[RELATION_CODE] [numeric](5, 0) NOT NULL ,
	[RELATION_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_REPORT_TYPE] (
	[REPORT_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[REPORT_TYPE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[DURATION_CODE] [numeric](2, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_RETIRE_REASON] (
	[RET_RSN_CODE] [numeric](5, 0) NOT NULL ,
	[RET_RSN_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_VACATION_CLASS] (
	[VACATION_CLASS_CODE] [numeric](5, 0) NOT NULL ,
	[VACATION_CLASS_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PER_VAC_SUB_CLASS] (
	[VAC_TYPE_CODE] [numeric](5, 0) IDENTITY (1, 1) NOT NULL ,
	[VAC_TYPE_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[MAX_NUM] [numeric](6, 0) NULL ,
	[FEM_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL ,
	[CALE_CYCLE] [numeric](3, 0) NULL ,
	[DEC_FLAG] [numeric](1, 0) NULL ,
	[ACCUM_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL ,
	[MAX_DUR_ONCE] [numeric](6, 0) NULL ,
	[MAX_DUR] [numeric](6, 0) NULL ,
	[SAL_DED_PERCENT] [numeric](6, 0) NULL ,
	[BALANCE_FLAG] [numeric](1, 0) NULL ,
	[VACATION_CLASS_CODE] [numeric](5, 0) NULL ,
	[PERIOD_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PRL_SAL_CATEGORY] (
	[SAL_CAT_CODE] [numeric](5, 0) NOT NULL ,
	[SAL_CAT_TYPE] [numeric](1, 0) NOT NULL ,
	[SAL_CAT_DESC] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_PRODUCTTYPES] (
	[TYPEID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[TYPEDESC] [nvarchar] (70) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CDE_UNIT_TYPES] (
	[UINTID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[UNITDESC] [nvarchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CREDITS] (
	[CREDITID] [int] NULL ,
	[CREDITVALUE] [float] NULL ,
	[CREDITDATE] [smalldatetime] NULL ,
	[PAID] [nvarchar] (4) COLLATE Arabic_CI_AS NULL ,
	[PAYDATE] [smalldatetime] NULL ,
	[pay] [bit] NOT NULL ,
	[CREDITNO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Category] (
	[CatID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CatCode] [nvarchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[CatDesc] [nvarchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[Serial] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Cde_QidTypes] (
	[QidTypeId] [int] NOT NULL ,
	[QidTypeDesc] [nvarchar] (50) COLLATE Arabic_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CostCenters] (
	[costid] [bigint] IDENTITY (1, 1) NOT NULL ,
	[costName] [nvarchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[costCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[costSName] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[costparentId] [int] NULL ,
	[root] [bit] NULL ,
	[Totalfromvalue] [money] NULL ,
	[Totaltovalue] [money] NULL ,
	[notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[startbalancefrom] [float] NULL ,
	[startdate] [smalldatetime] NULL ,
	[startbalanceto] [float] NULL ,
	[balance] [bit] NULL ,
	[costType] [int] NULL ,
	[ClosedTo] [bigint] NULL ,
	[MainNode] [bit] NULL ,
	[ProcessFlag] [bit] NULL ,
	[display_Flag] [bit] NULL ,
	[LastSerialNo] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[AccLevel] [int] NULL ,
	[MainParentAccId] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[Emp_Groups] (
	[GroupId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[GroupName] [varchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[NutalAttendance] [int] NULL ,
	[SalaryCul] [int] NULL ,
	[DefDate] [int] NULL ,
	[WorkHour] [float] NULL ,
	[VactionNum] [float] NULL ,
	[AbsenceHourPercentage] [float] NULL ,
	[AdditionPercentage] [float] NULL ,
	[HourInVaction] [float] NULL ,
	[AbsenceDayPercentage] [float] NULL ,
	[ApplyVactionDays] [bit] NULL ,
	[SalaryAccountId] [bigint] NULL ,
	[TaxAccountId] [bigint] NULL ,
	[LoanAccountId] [bigint] NULL ,
	[BoxAccountId] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FIGURES] (
	[Figure] [smallint] NOT NULL ,
	[FigureInWords] [nvarchar] (15) COLLATE Arabic_CI_AS NULL ,
	[EngFigureInWords] [nvarchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[FUNCTIONS] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[TEXT] [varchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[NAME] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[Type] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GROUP] (
	[ID] [int] NOT NULL ,
	[TEXT] [varchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GROUP_FUNCTION] (
	[ID] [int] NOT NULL ,
	[GROUP_ID] [int] NULL ,
	[FUNCTION_ID] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[GROUP_USER] (
	[ID] [int] NOT NULL ,
	[USER_ID] [int] NULL ,
	[GROUP_ID] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Installment] (
	[InstallId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InvId] [bigint] NULL ,
	[CustAccid] [bigint] NULL ,
	[CustID] [bigint] NULL ,
	[InstallmentAccid] [bigint] NULL ,
	[StartDate] [smalldatetime] NULL ,
	[PaymentDate] [smalldatetime] NULL ,
	[InstallmentValue] [money] NULL ,
	[TotalValue] [money] NULL ,
	[AdminName] [varchar] (200) COLLATE Arabic_CI_AS NULL ,
	[AdminAddress] [varchar] (200) COLLATE Arabic_CI_AS NULL ,
	[Notes] [varchar] (300) COLLATE Arabic_CI_AS NULL ,
	[CollectorAccid] [bigint] NULL ,
	[TypeId] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Installment_Distribution] (
	[DistubId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InstallId] [bigint] NOT NULL ,
	[DistValue] [money] NULL ,
	[DistDate] [smalldatetime] NULL ,
	[PayFlag] [bit] NULL ,
	[RequiredFlag] [bit] NULL ,
	[CustAccid] [bigint] NULL ,
	[CollectorAccid] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[InvOrders] (
	[InvId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InvCode] [nvarchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[RecoderCode] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[InvDate] [smalldatetime] NULL ,
	[Cust_Sup_Accid] [bigint] NULL ,
	[InvAccid] [bigint] NULL ,
	[PaymentType] [smallint] NULL ,
	[PaymentAccid] [bigint] NULL ,
	[BranchId] [bigint] NULL ,
	[InvType] [int] NULL ,
	[EmpId] [bigint] NULL ,
	[PaymentValue] [money] NULL ,
	[PaymentDate] [smalldatetime] NULL ,
	[Notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[invTotal] [money] NULL ,
	[Discount] [float] NULL ,
	[InvTotalNet] [money] NULL ,
	[InvPayment] [money] NULL ,
	[InvRemain] [money] NULL ,
	[ReferID] [bigint] NULL ,
	[PaymentCost] [money] NULL ,
	[ChequeNo] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[ChequeFlag] [bit] NULL ,
	[TotalAddCost] [money] NULL ,
	[TotalReoder] [money] NULL ,
	[TotalReoderNet] [money] NULL ,
	[CostId] [bigint] NULL ,
	[SUP_CUST_ID] [bigint] NULL ,
	[PayFinish] [bit] NULL ,
	[CollectValue] [money] NULL ,
	[KeyNetValue] [money] NULL ,
	[VisaValue] [money] NULL ,
	[MasterValue] [money] NULL ,
	[ChequeValue] [money] NULL ,
	[OtherValue] [money] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[InvOrders_Products] (
	[Inv_Product_Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InvId] [bigint] NOT NULL ,
	[ProductId] [bigint] NOT NULL ,
	[UnitId] [bigint] NOT NULL ,
	[Qty] [float] NOT NULL ,
	[ReorderQty] [float] NULL ,
	[Price] [money] NOT NULL ,
	[StoreId] [bigint] NOT NULL ,
	[Discount] [float] NULL ,
	[VaildDate] [datetime] NULL ,
	[TotalPrice] [money] NULL ,
	[ReoderFlag] [bit] NULL ,
	[TotReOderPrice] [money] NULL ,
	[PRODUCTBRAND] [nvarchar] (30) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Inv_Products] (
	[Inv_Product_Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InvId] [bigint] NOT NULL ,
	[ProductId] [bigint] NOT NULL ,
	[UnitId] [bigint] NOT NULL ,
	[Qty] [float] NOT NULL ,
	[ReorderQty] [float] NULL ,
	[Price] [money] NOT NULL ,
	[StoreId] [bigint] NOT NULL ,
	[Discount] [float] NULL ,
	[VaildDate] [datetime] NULL ,
	[TotalPrice] [money] NULL ,
	[ReoderFlag] [bit] NULL ,
	[TotReOderPrice] [money] NULL ,
	[PRODUCTBRAND] [nvarchar] (30) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ORDERDETAILS] (
	[Order_Product_Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[OrderId] [bigint] NULL ,
	[ProductId] [bigint] NULL ,
	[UnitId] [bigint] NULL ,
	[Qty] [float] NULL ,
	[Price] [money] NULL ,
	[StoreId] [bigint] NULL ,
	[VaildDate] [datetime] NULL ,
	[PRODUCTBRAND] [nvarchar] (30) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ORDERS] (
	[OrderId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[OrderCode] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[OrderDate] [smalldatetime] NULL ,
	[Cust_Sup_Accid] [bigint] NULL ,
	[BranchId] [bigint] NULL ,
	[InvType] [int] NULL ,
	[EmpId] [bigint] NULL ,
	[Notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[SUP_CUST_ID] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMPLOYEE_DATA] (
	[EMP_CODE] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CIVILID] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[EMPNAME] [nvarchar] (200) COLLATE Arabic_CI_AS NOT NULL ,
	[EngNAME] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[TITLE] [nvarchar] (30) COLLATE Arabic_CI_AS NULL ,
	[EMP_GENDER] [numeric](1, 0) NULL ,
	[EMP_BIRTH_DATE] [datetime] NULL ,
	[EMP_MOBILE] [varchar] (15) COLLATE Arabic_CI_AS NULL ,
	[DEPTCODE] [bigint] NULL ,
	[ADDRESS] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[EMP_PHONE] [varchar] (15) COLLATE Arabic_CI_AS NULL ,
	[EMP_EMAIL] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[EMP_HIREDATE] [datetime] NULL ,
	[Emp_End_HIREDATE] [smalldatetime] NULL ,
	[EMP_HEALTH_INS_DATE] [datetime] NULL ,
	[EMP_HEALTH_INS_NUM] [varchar] (200) COLLATE Arabic_CI_AS NULL ,
	[JOB_CODE] [numeric](5, 0) NULL ,
	[JOB_CLS_CODE] [numeric](5, 0) NULL ,
	[FILE_NUM] [varchar] (20) COLLATE Arabic_CI_AS NULL ,
	[DEGREE_CODE] [numeric](5, 0) NULL ,
	[REC_TYPE_CODE] [numeric](5, 0) NULL ,
	[MARITAL_STATUS_CODE] [numeric](5, 0) NULL ,
	[NATIONALITY_CODE] [numeric](5, 0) NULL ,
	[GOVER_CODE] [numeric](5, 0) NULL ,
	[EMP_VISA] [bit] NULL ,
	[Emp_VISA_NO] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[EMP_VISA_END_DATE] [datetime] NULL ,
	[BANK_CODE] [numeric](5, 0) NULL ,
	[AccountID] [numeric](38, 0) NULL ,
	[NOTES] [ntext] COLLATE Arabic_CI_AS NULL ,
	[passportNo] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[passtype] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[passdate] [smalldatetime] NULL ,
	[passplace] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[entrydate] [smalldatetime] NULL ,
	[BORROWS] [float] NULL ,
	[SALARY] [money] NULL ,
	[ADDED] [money] NULL ,
	[DEDUCED] [money] NULL ,
	[absence] [money] NULL ,
	[netSalary] [money] NULL ,
	[bank] [bit] NULL ,
	[bankacc] [int] NULL ,
	[BRANCH_CODE] [bigint] NULL ,
	[EMP_PIC] [image] NULL ,
	[SalesAdminFalg] [bit] NULL ,
	[GroupId] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_ABSENCE] (
	[AbsenceID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[START_DATE] [datetime] NOT NULL ,
	[END_DATE] [datetime] NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[YEAR_CODE] [int] NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[DAYS_NUM] [numeric](5, 0) NULL ,
	[HOUR_NUM] [decimal](18, 0) NULL ,
	[HOURVALUE] [money] NULL ,
	[NOTE] [varchar] (2000) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_Allowance] (
	[AllowanceID] [int] IDENTITY (1, 1) NOT NULL ,
	[EMP_CODE] [bigint] NULL ,
	[YEAR_CODE] [int] NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[AMOUNT] [money] NULL ,
	[DISCOUNT_DATE] [smalldatetime] NULL ,
	[DES] [ntext] COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_DISCOUNT] (
	[DISCOUNTID] [int] IDENTITY (1, 1) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[YEAR_CODE] [int] NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[PEN_CODE] [numeric](5, 0) NULL ,
	[DISCOUNT_DATE] [smalldatetime] NULL ,
	[AMOUNT] [money] NULL ,
	[DES] [ntext] COLLATE Arabic_CI_AS NULL ,
	[accountid] [int] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_DOCUMNET] (
	[DOC_SERIAL] [numeric](5, 0) IDENTITY (1, 1) NOT NULL ,
	[DOC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[DOC_END_DATE] [datetime] NULL ,
	[DOC_NUM] [varchar] (20) COLLATE Arabic_CI_AS NULL ,
	[NOTES] [varchar] (2000) COLLATE Arabic_CI_AS NULL ,
	[DOC_DATE] [datetime] NULL ,
	[DOC_DELIVERY_DATE] [datetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_JOB] (
	[EMP_CODE] [bigint] NOT NULL ,
	[EMP_JOB_DATE] [datetime] NOT NULL ,
	[DEGREE_HOLD_FLAG] [numeric](1, 0) NULL ,
	[J_DEC_NO] [numeric](12, 0) NULL ,
	[END_DATE] [datetime] NULL ,
	[J_DEC_DATE] [datetime] NULL ,
	[EMP_DGR_DATE] [datetime] NULL ,
	[EMP_JOB_SALARY] [numeric](8, 2) NULL ,
	[JOB_CLS_CODE] [numeric](5, 0) NOT NULL ,
	[DEGREE_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CODE] [numeric](5, 0) NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_QLF] (
	[QLF_TYP_CODE] [numeric](5, 0) NOT NULL ,
	[SPEC_CODE] [numeric](5, 0) NOT NULL ,
	[QLF_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[EMP_QLF_DATE] [datetime] NULL ,
	[HIRE_QLF_FLAG] [numeric](1, 0) NULL ,
	[QUAL_ENT_CODE] [numeric](5, 0) NULL ,
	[GRAD_CODE] [numeric](5, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_RELATIVE] (
	[REL_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[REL_NAME] [varchar] (100) COLLATE Arabic_CI_AS NULL ,
	[REL_BIRTHDATE] [datetime] NULL ,
	[RELATION_CODE] [numeric](5, 0) NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_REPORT] (
	[INTERVAL_CODE] [numeric](5, 0) NOT NULL ,
	[INTERVAL_TYPE] [numeric](1, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[REPORT_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_REP_YEAR] [numeric](4, 0) NOT NULL ,
	[NOTES] [varchar] (2000) COLLATE Arabic_CI_AS NULL ,
	[EMP_REP_DEGREE] [numeric](5, 0) NOT NULL ,
	[UPDATED_FLAG] [numeric](1, 0) NOT NULL ,
	[ISSUE_DATE] [datetime] NOT NULL ,
	[SESSION_NUM] [float] NULL ,
	[SESSION_DATE] [datetime] NULL ,
	[REP_TEMP_CODE] [numeric](5, 0) NULL ,
	[GRAD_CODE] [numeric](5, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_VACATION] (
	[VACID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[VAC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[VAC_DATE_FRM] [datetime] NOT NULL ,
	[VAC_DATE_TO] [datetime] NOT NULL ,
	[RETURN_DATE] [datetime] NULL ,
	[VAC_PERIOD] [numeric](5, 0) NULL ,
	[NOTE] [varchar] (300) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_EMP_VAC_BALANCE] (
	[VAC_TYPE_CODE] [numeric](5, 0) NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[DATE_FROM] [datetime] NOT NULL ,
	[DATE_TO] [datetime] NOT NULL ,
	[SUBTRACTED_BALANCE] [numeric](5, 0) NULL ,
	[POSTED_BALANCE] [numeric](5, 0) NULL ,
	[VAC_BALANCE] [numeric](5, 0) NOT NULL ,
	[YEAR_CODE] [numeric](5, 0) NULL ,
	[ACCUM_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL ,
	[ACCUM_ORDER_DATE] [datetime] NULL ,
	[POSTED] [float] NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PER_JOB_YEAR_BUDGET] (
	[YEAR_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CODE] [numeric](5, 0) NOT NULL ,
	[JOB_CLS_CODE] [numeric](5, 0) NOT NULL ,
	[DEGREE_CODE] [numeric](5, 0) NOT NULL ,
	[FILLED_VACANCIES] [numeric](8, 0) NOT NULL ,
	[BUDGET] [numeric](8, 2) NULL ,
	[JOBS_NUM] [numeric](8, 0) NOT NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRL_EMP_ATTENDENCE] (
	[YEAR_CODE] [int] NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[DAYS_NUM] [numeric](2, 0) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRL_EMP_BASIC_SAL] (
	[ELEM_DATE] [datetime] NOT NULL ,
	[EMP_CODE] [numeric](38, 0) NOT NULL ,
	[SAL_CAT_CODE] [numeric](5, 0) NOT NULL ,
	[DEC_DATE] [datetime] NULL ,
	[ELEM_AMOUNT] [numeric](9, 3) NOT NULL ,
	[DEC_NUM] [numeric](5, 0) NULL ,
	[ROWID] [uniqueidentifier] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRL_EMP_LOAN_DETAIL] (
	[LoanID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[START_DATE] [datetime] NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[MONTHLY_AMOUNT] [numeric](9, 3) NULL ,
	[TOTAL_AMOUNT] [numeric](9, 3) NOT NULL ,
	[TOT_PAID] [numeric](9, 3) NULL ,
	[TOTAL_MON_NUM] [numeric](5, 0) NULL ,
	[NOTE] [nvarchar] (200) COLLATE Arabic_CI_AS NULL ,
	[STOP_FLAG] [varchar] (1) COLLATE Arabic_CI_AS NULL ,
	[accountid] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRL_EMP_SAL_CALCULATION] (
	[CalID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[YEAR_CODE] [int] NOT NULL ,
	[EMP_CODE] [bigint] NOT NULL ,
	[BasicAmount] [money] NULL ,
	[DiscountAmount] [money] NULL ,
	[AbseneceAmount] [money] NULL ,
	[LoanAmount] [money] NULL ,
	[AllowanceAmount] [money] NULL ,
	[CALCULATION_AMOUNT] [money] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRL_EMP_SAL_ELEMENT] (
	[EMP_CODE] [numeric](38, 0) NULL ,
	[YEAR_CODE] [int] NULL ,
	[MONTH_CODE] [int] NULL ,
	[BasicSalary] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[PRODUCTS] (
	[PRODUCTID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[productname] [nvarchar] (150) COLLATE Arabic_CI_AS NOT NULL ,
	[EnglishName] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[PRODUCTCODE] [nvarchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[ParentProductId] [bigint] NULL ,
	[Root] [bit] NULL ,
	[ProductTypeID] [bigint] NULL ,
	[SERIALNO] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[SUPPLIERID] [bigint] NULL ,
	[CATEGORYID] [int] NULL ,
	[PWeight] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[PSize] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[PColor] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[PVolume] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[picpath] [image] NULL ,
	[VALIDITY] [smalldatetime] NULL ,
	[PDesc] [ntext] COLLATE Arabic_CI_AS NULL ,
	[PriceRule] [nvarchar] (30) COLLATE Arabic_CI_AS NULL ,
	[PriceFromDate] [smalldatetime] NULL ,
	[PriceToDate] [smalldatetime] NULL ,
	[OfferTypeID] [int] NULL ,
	[OfferFromDate] [smalldatetime] NULL ,
	[OfferToDate] [smalldatetime] NULL ,
	[OfferProductId] [bigint] NULL ,
	[OfferUnit] [int] NULL ,
	[UNITPRICECOST] [money] NULL ,
	[UNITPRICESALES] [money] NULL ,
	[BUYDATE] [smalldatetime] NULL ,
	[THRESHOLDINSTOCK] [smallint] NULL ,
	[DISCONTINUED] [bit] NULL ,
	[REORDERLEVEL] [smallint] NULL ,
	[STOCKNO] [bigint] NULL ,
	[RECEIVERID] [int] NULL ,
	[SHAPE] [nvarchar] (10) COLLATE Arabic_CI_AS NULL ,
	[QUANTITYPERUNIT] [real] NULL ,
	[complexproduct] [bit] NULL ,
	[UNITSINSTOCK] [float] NULL ,
	[ACCOUNTID] [int] NULL ,
	[QUANTITYINUNIT] [float] NULL ,
	[initialsmallquantity] [float] NULL ,
	[initialprice] [money] NULL ,
	[initiallargequantity] [float] NULL ,
	[serviceproduct] [bit] NULL ,
	[profit] [real] NULL ,
	[forcurrency] [money] NULL ,
	[minprice] [money] NULL ,
	[shape2] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[SerialCode] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[PerEmpLoanDetailsReport] (
	[LoanDetID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[LoanID] [bigint] NOT NULL ,
	[YEAR_CODE] [int] NOT NULL ,
	[MONTH_CODE] [int] NOT NULL ,
	[LoanAmount] [money] NULL ,
	[LoanDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductOffers] (
	[OffertId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[productid] [bigint] NOT NULL ,
	[UnitID] [bigint] NOT NULL ,
	[BasicQty] [float] NULL ,
	[OfferQty] [float] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductReplacment] (
	[ReplaceId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[ReplaceProductId] [bigint] NOT NULL ,
	[productid] [bigint] NOT NULL ,
	[AvaliableQty] [bigint] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProductVALIDITY] (
	[ValId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[Chargecode] [bigint] NOT NULL ,
	[productid] [bigint] NOT NULL ,
	[Qty] [bit] NULL ,
	[EndDate] [smalldatetime] NULL ,
	[ProductionDate] [smalldatetime] NULL ,
	[ValPeroid] [bigint] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Product_Assemply] (
	[AssemblyId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[AssemblyType] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[productid] [bigint] NOT NULL ,
	[Assproductid] [bigint] NOT NULL ,
	[unit] [bigint] NOT NULL ,
	[Qty] [float] NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Product_Units_Prices] (
	[UitPriceId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[UintId] [bigint] NOT NULL ,
	[productid] [bigint] NOT NULL ,
	[PRODUCTBRAND] [nvarchar] (30) COLLATE Arabic_CI_AS NULL ,
	[ConFactor] [float] NOT NULL ,
	[PriceOnly] [bit] NULL ,
	[Dim] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[DimDesc] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[MainUnit] [bit] NULL ,
	[AvgCostPrice] [money] NULL ,
	[MaxCostPrice] [money] NULL ,
	[MinCostPrice] [money] NULL ,
	[SalePrice] [money] NULL ,
	[MinPrice] [money] NULL ,
	[BuyPrice] [money] NULL ,
	[CostmerPrice] [money] NULL ,
	[PrivatePrice] [money] NULL ,
	[Minprofit] [float] NULL ,
	[MaxProfit] [float] NULL ,
	[MaxSalePrice] [money] NULL ,
	[MinSalePrice] [money] NULL ,
	[LastSalePrice] [money] NULL ,
	[MaxBuyPrice] [money] NULL ,
	[MinBuyPrice] [money] NULL ,
	[LastBuyPrice] [money] NULL ,
	[LastCostPrice] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[STOCK] (
	[StockId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[STOREID] [bigint] NOT NULL ,
	[PRODUCTID] [bigint] NOT NULL ,
	[UnitID] [bigint] NOT NULL ,
	[QUANTITY] [float] NULL ,
	[MovmentQty] [float] NULL ,
	[MaxQty] [float] NULL ,
	[visitationQty] [float] NULL ,
	[Related] [bit] NULL ,
	[OrderQTY] [float] NULL ,
	[QtyInStore] [float] NULL ,
	[QtyINRoad] [float] NULL ,
	[QtynotAmount] [float] NULL ,
	[QtyNotProchuse] [float] NULL ,
	[QtyNotCost] [float] NULL ,
	[QtyNotSale] [float] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[STORES] (
	[STOREID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[STORECODE] [nvarchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[STORNAME] [varchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[BRANCHCODE] [bigint] NULL ,
	[Notes] [varchar] (200) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[SUPPLIERS_CUSTOMERS] (
	[SUP_CUST_ID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[SUP_CUST_CODE] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[SUP_CUST_FNAME] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[SUP_CUST_SNAME] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[SUP_CUST_TYPE] [int] NULL ,
	[ADMIN_NAME] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[ADMIN_TITLE] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[ADDRESS] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[CITY] [nvarchar] (15) COLLATE Arabic_CI_AS NULL ,
	[GOVERNERATE] [nvarchar] (15) COLLATE Arabic_CI_AS NULL ,
	[COUNTRY] [nvarchar] (15) COLLATE Arabic_CI_AS NULL ,
	[PHONE1] [nvarchar] (24) COLLATE Arabic_CI_AS NULL ,
	[PHONE2] [nvarchar] (24) COLLATE Arabic_CI_AS NULL ,
	[FAX] [nvarchar] (24) COLLATE Arabic_CI_AS NULL ,
	[POSTOFFICE] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[EMAIL] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[SUPPLIERACOUNT] [float] NULL ,
	[CONVICT] [float] NULL ,
	[CREDITOR] [float] NULL ,
	[NOTES] [ntext] COLLATE Arabic_CI_AS NULL ,
	[accountid] [bigint] NULL ,
	[WORKHOURS] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[WEEKEND] [nvarchar] (80) COLLATE Arabic_CI_AS NULL ,
	[SALEADMIN] [bigint] NULL ,
	[CREDITLIMIT] [money] NULL ,
	[CREDITPEROID] [numeric](18, 0) NULL ,
	[PAYPEROID] [numeric](18, 0) NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[SetupCodes] (
	[Id] [bigint] IDENTITY (1, 1) NOT NULL ,
	[SupCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[CustCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[invSaleCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[InvpurchasesCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[StoresCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[ACCountCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[Qid] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[QidIn] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[QidOut] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[EmpCode] [varchar] (50) COLLATE Arabic_CI_AS NULL ,
	[SalInvSerial] [bigint] NULL ,
	[PurchInvSerial] [bigint] NULL ,
	[InQidSerial] [bigint] NULL ,
	[OutQidSerial] [bigint] NULL ,
	[QidSeial] [bigint] NULL ,
	[BranchCode] [varchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[StockMovement] (
	[MoveId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[STOREFromID] [bigint] NOT NULL ,
	[STOREToID] [bigint] NOT NULL ,
	[PRODUCTID] [bigint] NOT NULL ,
	[UnitID] [bigint] NOT NULL ,
	[MovmentQty] [float] NOT NULL ,
	[UserId] [bigint] NULL ,
	[EnterDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[USER] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[USER_NAME] [varchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[PASSWORD] [varchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[STATUS] [int] NULL ,
	[USER_TYPE] [int] NULL ,
	[MEMBER_ID] [varchar] (10) COLLATE Arabic_CI_AS NULL ,
	[Branch] [bigint] NULL ,
	[Name] [varchar] (100) COLLATE Arabic_CI_AS NULL ,
	[BackGround] [varchar] (300) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[USER_FUNCTION] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[USER_ID] [int] NOT NULL ,
	[FUNCTION_ID] [int] NOT NULL ,
	[FOpen] [bit] NULL ,
	[FUpdate] [bit] NULL ,
	[FSave] [bit] NULL ,
	[FDel] [bit] NULL ,
	[Type] [int] NULL ,
	[FCommit] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[accounting] (
	[accountid] [bigint] IDENTITY (1, 1) NOT NULL ,
	[AccountCode] [varchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[accountname] [nvarchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[AccountSName] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[AccountparentId] [int] NULL ,
	[root] [bit] NULL ,
	[Totalfromvalue] [money] NULL ,
	[Totaltovalue] [money] NULL ,
	[notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[startbalancefrom] [float] NULL ,
	[startdate] [smalldatetime] NULL ,
	[startbalanceto] [float] NULL ,
	[balance] [bit] NULL ,
	[accountType] [int] NULL ,
	[ClosedTo] [bigint] NULL ,
	[MainNode] [bit] NULL ,
	[ProcessFlag] [bit] NULL ,
	[display_Flag] [bit] NULL ,
	[AccLevel] [int] NULL ,
	[MainParentAccId] [bigint] NULL ,
	[LastSerialNo] [varchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[companyinfo] (
	[companyaddress] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[companytel] [nvarchar] (60) COLLATE Arabic_CI_AS NULL ,
	[companyname] [nvarchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[creditssupp] (
	[CREDITID] [int] NULL ,
	[CREDITVALUE] [float] NULL ,
	[CREDITDATE] [smalldatetime] NULL ,
	[PAID] [nvarchar] (4) COLLATE Arabic_CI_AS NULL ,
	[PAYDATE] [smalldatetime] NULL ,
	[pay] [bit] NOT NULL ,
	[CREDITNO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[custproduct] (
	[productid] [int] NULL ,
	[productname] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[custid] [int] NULL ,
	[price] [money] NULL ,
	[code] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[id] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[invoices] (
	[InvId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[InvCode] [nvarchar] (100) COLLATE Arabic_CI_AS NOT NULL ,
	[RecoderCode] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[InvDate] [smalldatetime] NULL ,
	[Cust_Sup_Accid] [bigint] NULL ,
	[InvAccid] [bigint] NULL ,
	[PaymentType] [smallint] NULL ,
	[PaymentAccid] [bigint] NULL ,
	[BranchId] [bigint] NULL ,
	[InvType] [int] NULL ,
	[EmpId] [bigint] NULL ,
	[PaymentValue] [money] NULL ,
	[PaymentDate] [smalldatetime] NULL ,
	[Notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[invTotal] [money] NULL ,
	[Discount] [float] NULL ,
	[InvTotalNet] [money] NULL ,
	[InvPayment] [money] NULL ,
	[InvRemain] [money] NULL ,
	[ReferID] [bigint] NULL ,
	[PaymentCost] [money] NULL ,
	[ChequeNo] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[ChequeFlag] [bit] NULL ,
	[TotalAddCost] [money] NULL ,
	[TotalReoder] [money] NULL ,
	[TotalReoderNet] [money] NULL ,
	[CostId] [bigint] NULL ,
	[SUP_CUST_ID] [bigint] NULL ,
	[PayFinish] [bit] NULL ,
	[CollectValue] [money] NULL ,
	[KeyNetValue] [money] NULL ,
	[VisaValue] [money] NULL ,
	[MasterValue] [money] NULL ,
	[ChequeValue] [money] NULL ,
	[OtherValue] [money] NULL ,
	[CustId] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[purchases] (
	[CREDITID] [int] NULL ,
	[CREDITVALUE] [float] NULL ,
	[CREDITDATE] [smalldatetime] NULL ,
	[PAID] [nvarchar] (4) COLLATE Arabic_CI_AS NULL ,
	[PAYDATE] [smalldatetime] NULL ,
	[pay] [bit] NOT NULL ,
	[CREDITNO] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[qids] (
	[qidid] [bigint] IDENTITY (1, 1) NOT NULL ,
	[qidcode] [varchar] (50) COLLATE Arabic_CI_AS NOT NULL ,
	[qidDate] [smalldatetime] NULL ,
	[description] [ntext] COLLATE Arabic_CI_AS NULL ,
	[edit] [bit] NULL ,
	[recitetype] [int] NULL ,
	[underupdate] [bit] NULL ,
	[name] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[BrachId] [bigint] NULL ,
	[EmpId] [bigint] NULL ,
	[Notes] [ntext] COLLATE Arabic_CI_AS NULL ,
	[Active] [bit] NULL ,
	[repeated] [bit] NULL ,
	[BankAccId] [bigint] NULL ,
	[ChequeNo] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[InvId] [bigint] NULL ,
	[ReorderInvId] [bigint] NULL ,
	[PaymentType] [bit] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[qidsDetails] (
	[ID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[qidid] [bigint] NOT NULL ,
	[FromValue] [money] NULL ,
	[ToValue] [money] NULL ,
	[ACCOUNTID] [bigint] NOT NULL ,
	[type] [smallint] NULL ,
	[Description] [ntext] COLLATE Arabic_CI_AS NULL ,
	[EnterDate] [datetime] NULL ,
	[Detcode] [int] NULL ,
	[QidType] [int] NULL ,
	[TotalPrice] [money] NULL ,
	[ActionType] [int] NULL ,
	[CostId] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[qidsDetailsClosed] (
	[ID] [bigint] IDENTITY (1, 1) NOT NULL ,
	[qidid] [bigint] NULL ,
	[FromValue] [money] NULL ,
	[ToValue] [money] NULL ,
	[ACCOUNTID] [bigint] NULL ,
	[type] [smallint] NULL ,
	[Description] [ntext] COLLATE Arabic_CI_AS NULL ,
	[EnterDate] [datetime] NULL ,
	[Detcode] [int] NULL ,
	[QidType] [int] NULL ,
	[TotalPrice] [money] NULL ,
	[ActionType] [int] NULL ,
	[CostId] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[setup] (
	[custaccid] [smallint] NULL ,
	[suppaccid] [smallint] NULL ,
	[changeid] [int] NULL ,
	[productid] [int] NULL ,
	[orderid] [int] NULL ,
	[accountid] [int] NULL ,
	[qidid] [int] NULL ,
	[salesaccid] [smallint] NULL ,
	[salesAgalaccid] [bigint] NULL ,
	[purchaseaccid] [smallint] NULL ,
	[purchaseAgalaccid] [bigint] NULL ,
	[boxaccid] [bigint] NULL ,
	[bankaccid] [bigint] NULL ,
	[PurReorderaccid] [bigint] NULL ,
	[SalReorderaccid] [bigint] NULL ,
	[PurReorderAgalaccid] [bigint] NULL ,
	[SalReorderAgalaccid] [bigint] NULL ,
	[Discountaccid] [bigint] NULL ,
	[Paymentsaccid] [bigint] NULL ,
	[purchasePayaccid] [bigint] NULL ,
	[Mainsalesaccid] [bigint] NULL ,
	[MainPurchaseaccid] [bigint] NULL ,
	[OsalAccId] [bigint] NULL ,
	[DeductAccId] [bigint] NULL ,
	[Code] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CompanyName] [nvarchar] (150) COLLATE Arabic_CI_AS NULL ,
	[CompanyNameEng] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[Address] [nvarchar] (150) COLLATE Arabic_CI_AS NULL ,
	[AddressEng] [nvarchar] (150) COLLATE Arabic_CI_AS NULL ,
	[TelPhone] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[TelPhoneEng] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[Logo] [image] NULL ,
	[CompActivty] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[Fax] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[FaxEng] [nvarchar] (50) COLLATE Arabic_CI_AS NULL ,
	[Email] [nvarchar] (100) COLLATE Arabic_CI_AS NULL ,
	[SalesTakastaccid] [bigint] NULL ,
	[MovmentProfitsAccid] [bigint] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[users] (
	[userid] [bigint] IDENTITY (1, 1) NOT NULL ,
	[username] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[pw] [nvarchar] (20) COLLATE Arabic_CI_AS NULL ,
	[sales] [bit] NOT NULL ,
	[prinvoice] [bit] NOT NULL ,
	[productlist] [bit] NOT NULL ,
	[editproduct] [bit] NOT NULL ,
	[newproduct] [bit] NOT NULL ,
	[reorder] [bit] NOT NULL ,
	[deleteinvoice] [bit] NOT NULL ,
	[editreorder] [bit] NOT NULL ,
	[custlist] [bit] NOT NULL ,
	[newcust] [bit] NOT NULL ,
	[editcust] [bit] NOT NULL ,
	[estimate] [bit] NOT NULL ,
	[statement] [bit] NOT NULL ,
	[receivemoney] [bit] NOT NULL ,
	[supplist] [bit] NOT NULL ,
	[editsupp] [bit] NOT NULL ,
	[newsupp] [bit] NOT NULL ,
	[employees] [bit] NOT NULL ,
	[accountlist] [bit] NOT NULL ,
	[neweditaccount] [bit] NOT NULL ,
	[expenselist] [bit] NOT NULL ,
	[neweditexpense] [bit] NOT NULL ,
	[journalreport] [bit] NOT NULL ,
	[productreport] [bit] NOT NULL ,
	[profitreport] [bit] NOT NULL ,
	[opencompany] [bit] NOT NULL ,
	[createcompany] [bit] NOT NULL ,
	[backup] [bit] NOT NULL ,
	[users] [bit] NOT NULL ,
	[companyinfo] [bit] NOT NULL ,
	[editemp] [bit] NOT NULL ,
	[newemp] [bit] NOT NULL ,
	[sec] [bit] NOT NULL ,
	[doc] [bit] NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[BRANCHES] WITH NOCHECK ADD 
	CONSTRAINT [PK_BRANCHES_1] PRIMARY KEY  CLUSTERED 
	(
		[BRANCHCODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_BANKS] WITH NOCHECK ADD 
	CONSTRAINT [CDE_BANKS_PK] PRIMARY KEY  CLUSTERED 
	(
		[BNK_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_DEPT] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_DEPT] PRIMARY KEY  CLUSTERED 
	(
		[DEPT_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_GOVERNORATE] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_GOVERNORATE] PRIMARY KEY  CLUSTERED 
	(
		[GOVER_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_GROUPS] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_GROUPS] PRIMARY KEY  CLUSTERED 
	(
		[GROUP_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_MONTHS] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_MONTHS] PRIMARY KEY  CLUSTERED 
	(
		[MON_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_NATIONALITY] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_NATIONALITY] PRIMARY KEY  CLUSTERED 
	(
		[NATIONALITY_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_Offer_Types] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_Offer_Types] PRIMARY KEY  CLUSTERED 
	(
		[OfferTypeID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_DEGREE] WITH NOCHECK ADD 
	CONSTRAINT [CPD_PK] PRIMARY KEY  CLUSTERED 
	(
		[DEGREE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_DOCUMENT_TYPE] WITH NOCHECK ADD 
	CONSTRAINT [CPDT_PK] PRIMARY KEY  CLUSTERED 
	(
		[DOC_TYPE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_DURATION] WITH NOCHECK ADD 
	CONSTRAINT [CRD_PK] PRIMARY KEY  CLUSTERED 
	(
		[DURATION_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_FILE_DOC] WITH NOCHECK ADD 
	CONSTRAINT [CPFD_PK] PRIMARY KEY  CLUSTERED 
	(
		[FILE_CODE],
		[DOC_TYPE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_FILE_TYPE] WITH NOCHECK ADD 
	CONSTRAINT [CPFT_PK] PRIMARY KEY  CLUSTERED 
	(
		[FILE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_GRADE] WITH NOCHECK ADD 
	CONSTRAINT [CPG_PK] PRIMARY KEY  CLUSTERED 
	(
		[GRAD_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_JOB_DEGREE] WITH NOCHECK ADD 
	CONSTRAINT [CPJD_PK] PRIMARY KEY  CLUSTERED 
	(
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_PENALTY] WITH NOCHECK ADD 
	CONSTRAINT [CPP1_PK] PRIMARY KEY  CLUSTERED 
	(
		[PEN_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_QLF] WITH NOCHECK ADD 
	CONSTRAINT [CPQ_PK] PRIMARY KEY  CLUSTERED 
	(
		[QLF_CODE],
		[QLF_TYP_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_QLF_DTL] WITH NOCHECK ADD 
	CONSTRAINT [CPQD_PK] PRIMARY KEY  CLUSTERED 
	(
		[QLF_CODE],
		[QLF_TYP_CODE],
		[SPEC_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_QLF_ENT] WITH NOCHECK ADD 
	CONSTRAINT [CPQE_PK] PRIMARY KEY  CLUSTERED 
	(
		[QUAL_ENT_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_QLF_TYPE] WITH NOCHECK ADD 
	CONSTRAINT [CPQT_PK] PRIMARY KEY  CLUSTERED 
	(
		[QLF_TYP_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_REC_TYPE] WITH NOCHECK ADD 
	CONSTRAINT [CPRT1_PK] PRIMARY KEY  CLUSTERED 
	(
		[REC_TYPE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_RELATIVE] WITH NOCHECK ADD 
	CONSTRAINT [CPR2_PK] PRIMARY KEY  CLUSTERED 
	(
		[RELATION_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_REPORT_TYPE] WITH NOCHECK ADD 
	CONSTRAINT [CPRT2_PK] PRIMARY KEY  CLUSTERED 
	(
		[REPORT_TYPE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_RETIRE_REASON] WITH NOCHECK ADD 
	CONSTRAINT [CPRR_PK] PRIMARY KEY  CLUSTERED 
	(
		[RET_RSN_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_VACATION_CLASS] WITH NOCHECK ADD 
	CONSTRAINT [CPVC_PK] PRIMARY KEY  CLUSTERED 
	(
		[VACATION_CLASS_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_VAC_SUB_CLASS] WITH NOCHECK ADD 
	CONSTRAINT [CPVT_PK] PRIMARY KEY  CLUSTERED 
	(
		[VAC_TYPE_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PRL_SAL_CATEGORY] WITH NOCHECK ADD 
	CONSTRAINT [CPSC_PK] PRIMARY KEY  CLUSTERED 
	(
		[SAL_CAT_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PRODUCTTYPES] WITH NOCHECK ADD 
	CONSTRAINT [PK_Table1] PRIMARY KEY  CLUSTERED 
	(
		[TYPEID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_UNIT_TYPES] WITH NOCHECK ADD 
	CONSTRAINT [PK_CDE_UNIT_TYPES] PRIMARY KEY  CLUSTERED 
	(
		[UINTID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Category] WITH NOCHECK ADD 
	CONSTRAINT [PK_Category] PRIMARY KEY  CLUSTERED 
	(
		[CatID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Emp_Groups] WITH NOCHECK ADD 
	CONSTRAINT [PK_Emp_Groups] PRIMARY KEY  CLUSTERED 
	(
		[GroupId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FIGURES] WITH NOCHECK ADD 
	CONSTRAINT [PK_FIGURES] PRIMARY KEY  CLUSTERED 
	(
		[Figure]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[FUNCTIONS] WITH NOCHECK ADD 
	CONSTRAINT [PK_FUNCTIONS] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Installment] WITH NOCHECK ADD 
	CONSTRAINT [PK_Installment_Customer] PRIMARY KEY  CLUSTERED 
	(
		[InstallId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Installment_Distribution] WITH NOCHECK ADD 
	CONSTRAINT [PK_Installment_Distribution] PRIMARY KEY  CLUSTERED 
	(
		[DistubId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[InvOrders] WITH NOCHECK ADD 
	CONSTRAINT [PK_InvOder] PRIMARY KEY  CLUSTERED 
	(
		[InvId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[InvOrders_Products] WITH NOCHECK ADD 
	CONSTRAINT [PK_InvOrders_Products] PRIMARY KEY  CLUSTERED 
	(
		[Inv_Product_Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Inv_Products] WITH NOCHECK ADD 
	CONSTRAINT [PK_Inv_Products] PRIMARY KEY  CLUSTERED 
	(
		[Inv_Product_Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ORDERDETAILS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ORDERDETAILS] PRIMARY KEY  CLUSTERED 
	(
		[Order_Product_Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ORDERS] WITH NOCHECK ADD 
	CONSTRAINT [PK_ORDERS] PRIMARY KEY  CLUSTERED 
	(
		[OrderId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMPLOYEE_DATA] WITH NOCHECK ADD 
	CONSTRAINT [PED_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_ABSENCE] WITH NOCHECK ADD 
	CONSTRAINT [PK_PER_EMP_ABSENCE] PRIMARY KEY  CLUSTERED 
	(
		[AbsenceID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_Allowance] WITH NOCHECK ADD 
	CONSTRAINT [PK_PER_EMP_Allowance] PRIMARY KEY  CLUSTERED 
	(
		[AllowanceID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_DISCOUNT] WITH NOCHECK ADD 
	CONSTRAINT [PK_PER_EMP_DISCOUNT] PRIMARY KEY  CLUSTERED 
	(
		[DISCOUNTID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_DOCUMNET] WITH NOCHECK ADD 
	CONSTRAINT [PED2_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[DOC_TYPE_CODE],
		[DOC_SERIAL]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_JOB] WITH NOCHECK ADD 
	CONSTRAINT [PEJ1_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[EMP_JOB_DATE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_QLF] WITH NOCHECK ADD 
	CONSTRAINT [PEQ_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[QLF_TYP_CODE],
		[SPEC_CODE],
		[QLF_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_RELATIVE] WITH NOCHECK ADD 
	CONSTRAINT [PER_EMP_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[REL_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_REPORT] WITH NOCHECK ADD 
	CONSTRAINT [PER_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[REPORT_TYPE_CODE],
		[EMP_REP_YEAR],
		[INTERVAL_TYPE],
		[INTERVAL_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_VACATION] WITH NOCHECK ADD 
	CONSTRAINT [PK_PER_EMP_VACATION] PRIMARY KEY  CLUSTERED 
	(
		[VACID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_EMP_VAC_BALANCE] WITH NOCHECK ADD 
	CONSTRAINT [PEVB_PK] PRIMARY KEY  CLUSTERED 
	(
		[DATE_FROM],
		[VAC_TYPE_CODE],
		[DATE_TO],
		[EMP_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PER_JOB_YEAR_BUDGET] WITH NOCHECK ADD 
	CONSTRAINT [PJYB_PK] PRIMARY KEY  CLUSTERED 
	(
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE],
		[YEAR_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRL_EMP_ATTENDENCE] WITH NOCHECK ADD 
	CONSTRAINT [PEA2_PK] PRIMARY KEY  CLUSTERED 
	(
		[EMP_CODE],
		[YEAR_CODE],
		[MONTH_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRL_EMP_BASIC_SAL] WITH NOCHECK ADD 
	CONSTRAINT [PK_PRL_EMP_BASIC_SAL] PRIMARY KEY  CLUSTERED 
	(
		[ELEM_DATE],
		[EMP_CODE],
		[SAL_CAT_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRL_EMP_LOAN_DETAIL] WITH NOCHECK ADD 
	CONSTRAINT [PK_PRL_EMP_LOAN_DETAIL] PRIMARY KEY  CLUSTERED 
	(
		[LoanID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRL_EMP_SAL_CALCULATION] WITH NOCHECK ADD 
	CONSTRAINT [PK_PRL_EMP_SAL_CALCULATION] PRIMARY KEY  CLUSTERED 
	(
		[CalID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PRODUCTS] WITH NOCHECK ADD 
	CONSTRAINT [PK_PRODUCTS] PRIMARY KEY  CLUSTERED 
	(
		[PRODUCTID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[PerEmpLoanDetailsReport] WITH NOCHECK ADD 
	CONSTRAINT [PK_PerEmpLoanDetailsReport] PRIMARY KEY  CLUSTERED 
	(
		[LoanDetID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductOffers] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductOffers] PRIMARY KEY  CLUSTERED 
	(
		[OffertId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductReplacment] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductReplacment] PRIMARY KEY  CLUSTERED 
	(
		[ReplaceId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductVALIDITY] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductVALIDITY] PRIMARY KEY  CLUSTERED 
	(
		[ValId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Product_Assemply] WITH NOCHECK ADD 
	CONSTRAINT [PK_ProductAssemply] PRIMARY KEY  CLUSTERED 
	(
		[AssemblyId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Product_Units_Prices] WITH NOCHECK ADD 
	CONSTRAINT [PK_Product_Units_Prices] PRIMARY KEY  CLUSTERED 
	(
		[UitPriceId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[STOCK] WITH NOCHECK ADD 
	CONSTRAINT [PK_STOCK] PRIMARY KEY  CLUSTERED 
	(
		[STOREID],
		[PRODUCTID],
		[UnitID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[STORES] WITH NOCHECK ADD 
	CONSTRAINT [PK_BRANCHES] PRIMARY KEY  CLUSTERED 
	(
		[STOREID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SUPPLIERS_CUSTOMERS] WITH NOCHECK ADD 
	CONSTRAINT [PK_SUPPLIERS] PRIMARY KEY  CLUSTERED 
	(
		[SUP_CUST_ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SetupCodes] WITH NOCHECK ADD 
	CONSTRAINT [PK_SetupCodes] PRIMARY KEY  CLUSTERED 
	(
		[Id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[StockMovement] WITH NOCHECK ADD 
	CONSTRAINT [PK_StockMovement] PRIMARY KEY  CLUSTERED 
	(
		[MoveId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[USER] WITH NOCHECK ADD 
	CONSTRAINT [PK_USER] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[USER_FUNCTION] WITH NOCHECK ADD 
	CONSTRAINT [PK_USER_FUNCTION] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[accounting] WITH NOCHECK ADD 
	CONSTRAINT [PK_accounting] PRIMARY KEY  CLUSTERED 
	(
		[accountid]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[invoices] WITH NOCHECK ADD 
	CONSTRAINT [PK_invoices] PRIMARY KEY  CLUSTERED 
	(
		[InvId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[qids] WITH NOCHECK ADD 
	CONSTRAINT [PK_qids] PRIMARY KEY  CLUSTERED 
	(
		[qidid]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[qidsDetails] WITH NOCHECK ADD 
	CONSTRAINT [PK_qidsDetails] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[qidsDetailsClosed] WITH NOCHECK ADD 
	CONSTRAINT [PK_qidsDetailsClosed] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[setup] WITH NOCHECK ADD 
	CONSTRAINT [PK_setup] PRIMARY KEY  CLUSTERED 
	(
		[Code]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[users] WITH NOCHECK ADD 
	CONSTRAINT [PK_users] PRIMARY KEY  CLUSTERED 
	(
		[userid]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_BANKS] ADD 
	CONSTRAINT [DF__CDE_BANKS__ROWID__2B2A60FE] DEFAULT (newid()) FOR [ROWID],
	CONSTRAINT [PRL_UQ_BNK_DESC] UNIQUE  NONCLUSTERED 
	(
		[BNK_DESC]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_DEGREE] ADD 
	CONSTRAINT [DF__CDE_PER_D__ROWID__395884C4] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_DURATION] ADD 
	CONSTRAINT [DF__CDE_PER_D__ROWID__66603565] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_FILE_DOC] ADD 
	CONSTRAINT [DF__CDE_PER_F__ROWID__6CD828CA] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPFD_CPFT_FK_I] ON [dbo].[CDE_PER_FILE_DOC]([FILE_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [CPFD_CPDT_FK_I] ON [dbo].[CDE_PER_FILE_DOC]([DOC_TYPE_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PER_FILE_TYPE] ADD 
	CONSTRAINT [DF__CDE_PER_F__ROWID__731B1205] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_GRADE] ADD 
	CONSTRAINT [DF__CDE_PER_G__ROWID__21D600EE] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_JOB_DEGREE] ADD 
	CONSTRAINT [DF__CDE_PER_J__ROWID__76818E95] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPJD_CPJ_FK_I] ON [dbo].[CDE_PER_JOB_DEGREE]([JOB_CLS_CODE], [JOB_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [CPJD_CPD_FK_I] ON [dbo].[CDE_PER_JOB_DEGREE]([DEGREE_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PER_QLF] ADD 
	CONSTRAINT [DF__CDE_PER_Q__ROWID__670A40DB] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPQ_CPQT_FK_I] ON [dbo].[CDE_PER_QLF]([QLF_TYP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PER_QLF_DTL] ADD 
	CONSTRAINT [DF__CDE_PER_Q__ROWID__3B2BBE9D] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPQD_CPQ_FK_I] ON [dbo].[CDE_PER_QLF_DTL]([QLF_CODE], [QLF_TYP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PER_QLF_ENT] ADD 
	CONSTRAINT [DF__CDE_PER_Q__ROWID__1411F17C] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_QLF_TYPE] ADD 
	CONSTRAINT [DF__CDE_PER_Q__ROWID__30592A6F] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_REC_TYPE] ADD 
	CONSTRAINT [DF__CDE_PER_R__ROWID__75A278F5] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_RELATIVE] ADD 
	CONSTRAINT [DF__CDE_PER_R__ROWID__24B26D99] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_REPORT_TYPE] ADD 
	CONSTRAINT [DF__CDE_PER_R__ROWID__65370702] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPRT2_CRD_FK_I] ON [dbo].[CDE_PER_REPORT_TYPE]([DURATION_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PER_RETIRE_REASON] ADD 
	CONSTRAINT [DF__CDE_PER_R__ROWID__147C05D0] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[CDE_PER_VACATION_CLASS] ADD 
	CONSTRAINT [DF__CDE_PER_V__ROWID__34C8D9D1] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [CPVT_CPVC_FK_I] ON [dbo].[CDE_PER_VAC_SUB_CLASS]([VACATION_CLASS_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CDE_PRL_SAL_CATEGORY] ADD 
	CONSTRAINT [DF__CDE_PRL_S__ROWID__7E02B4CC] DEFAULT (newid()) FOR [ROWID]
GO

ALTER TABLE [dbo].[Category] ADD 
	CONSTRAINT [DF_Category_Serial] DEFAULT (0) FOR [Serial]
GO

ALTER TABLE [dbo].[CostCenters] ADD 
	CONSTRAINT [DF_CostCenters_LastSerialNo_1] DEFAULT (0) FOR [LastSerialNo]
GO

ALTER TABLE [dbo].[InvOrders] ADD 
	CONSTRAINT [DF_InvOder_CollectValue] DEFAULT (0) FOR [CollectValue]
GO

ALTER TABLE [dbo].[PER_EMPLOYEE_DATA] ADD 
	CONSTRAINT [DF__PER_EMP_D__EMP_G__3C54ED00] DEFAULT (1) FOR [EMP_GENDER],
	CONSTRAINT [DF__PER_EMP_D__EMP_I__3D491139] DEFAULT (1) FOR [EMP_VISA]
GO

ALTER TABLE [dbo].[PER_EMP_ABSENCE] ADD 
	CONSTRAINT [IX_PER_EMP_ABSENCE] UNIQUE  NONCLUSTERED 
	(
		[START_DATE],
		[END_DATE],
		[EMP_CODE]
	)  ON [PRIMARY] 
GO

 CREATE  INDEX [PED2_PED_FK_I] ON [dbo].[PER_EMP_DOCUMNET]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PED2_CPDT_FK_I] ON [dbo].[PER_EMP_DOCUMNET]([DOC_TYPE_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_EMP_JOB] ADD 
	CONSTRAINT [DF__PER_EMP_J__DEGRE__1881A0DE] DEFAULT (1) FOR [DEGREE_HOLD_FLAG],
	CONSTRAINT [DF__PER_EMP_J__ROWID__1975C517] DEFAULT (newid()) FOR [ROWID],
	CONSTRAINT [AVCON_1060418943_DEGRE_000] CHECK ([DEGREE_HOLD_FLAG] = 3 or ([DEGREE_HOLD_FLAG] = 2 or [DEGREE_HOLD_FLAG] = 1))
GO

 CREATE  INDEX [PEJ1_CPJD_FK_I] ON [dbo].[PER_EMP_JOB]([JOB_CODE], [JOB_CLS_CODE], [DEGREE_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEJ1_PED_FK_I] ON [dbo].[PER_EMP_JOB]([EMP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_EMP_QLF] ADD 
	CONSTRAINT [DF_PER_EMP_QLF_HIRE_QLF_FLAG] DEFAULT (1) FOR [HIRE_QLF_FLAG],
	CONSTRAINT [DF__PER_EMP_Q__ROWID__2A4B4B5E] DEFAULT (newid()) FOR [ROWID],
	CONSTRAINT [AVCON_1060418943_HIRE__000] CHECK ([HIRE_QLF_FLAG] = 2 or [HIRE_QLF_FLAG] = 1)
GO

 CREATE  INDEX [PEQ_CPQE_FK_I] ON [dbo].[PER_EMP_QLF]([QUAL_ENT_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEQ_CPQD_FK_I] ON [dbo].[PER_EMP_QLF]([QLF_CODE], [QLF_TYP_CODE], [SPEC_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEQ_PED_FK_I] ON [dbo].[PER_EMP_QLF]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEQ_CPG_FK_I] ON [dbo].[PER_EMP_QLF]([GRAD_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_EMP_RELATIVE] ADD 
	CONSTRAINT [DF__PER_EMP_R__ROWID__114A936A] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [PER_EMP_CPR2_FK_I] ON [dbo].[PER_EMP_RELATIVE]([RELATION_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PER_EMP_PED_FK_I] ON [dbo].[PER_EMP_RELATIVE]([EMP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_EMP_REPORT] ADD 
	CONSTRAINT [DF__PER_EMP_R__ROWID__4D94879B] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [PER_CPG_FK_I] ON [dbo].[PER_EMP_REPORT]([GRAD_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PER_CPRT3_FK_I] ON [dbo].[PER_EMP_REPORT]([REP_TEMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PER_CPRT2_FK_I] ON [dbo].[PER_EMP_REPORT]([REPORT_TYPE_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PER_PED_FK_I] ON [dbo].[PER_EMP_REPORT]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PER_CI3_FK_I] ON [dbo].[PER_EMP_REPORT]([INTERVAL_CODE], [INTERVAL_TYPE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_EMP_VAC_BALANCE] ADD 
	CONSTRAINT [DF__PER_EMP_V__ACCUM__10216507] DEFAULT (0) FOR [ACCUM_FLAG],
	CONSTRAINT [DF__PER_EMP_V__ROWID__11158940] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [PEVB_PED_FK_I] ON [dbo].[PER_EMP_VAC_BALANCE]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEVB_CPVT_FK_I] ON [dbo].[PER_EMP_VAC_BALANCE]([VAC_TYPE_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PER_JOB_YEAR_BUDGET] ADD 
	CONSTRAINT [DF__PER_JOB_Y__ROWID__6C040022] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [PJYB_CPJD_FK_I] ON [dbo].[PER_JOB_YEAR_BUDGET]([JOB_CODE], [JOB_CLS_CODE], [DEGREE_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PJYB_CFY_FK_I] ON [dbo].[PER_JOB_YEAR_BUDGET]([YEAR_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEA2_PED_FK_I] ON [dbo].[PRL_EMP_ATTENDENCE]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEA2_CM3_FK_I] ON [dbo].[PRL_EMP_ATTENDENCE]([MONTH_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PEA2_CFY_FK_I] ON [dbo].[PRL_EMP_ATTENDENCE]([YEAR_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PRL_EMP_BASIC_SAL] ADD 
	CONSTRAINT [DF__PRL_EMP_B__ROWID__08D548FA] DEFAULT (newid()) FOR [ROWID]
GO

 CREATE  INDEX [PEBS_PED_FK_I] ON [dbo].[PRL_EMP_BASIC_SAL]([EMP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PRL_EMP_LOAN_DETAIL] ADD 
	CONSTRAINT [IX_PRL_EMP_LOAN_DETAIL] UNIQUE  NONCLUSTERED 
	(
		[START_DATE],
		[EMP_CODE]
	)  ON [PRIMARY] 
GO

 CREATE  INDEX [PESD_PED_FK_I] ON [dbo].[PRL_EMP_LOAN_DETAIL]([EMP_CODE]) ON [PRIMARY]
GO

 CREATE  INDEX [PESE_PED_FK_I] ON [dbo].[PRL_EMP_SAL_ELEMENT]([EMP_CODE]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PRODUCTS] ADD 
	CONSTRAINT [IX_PRODUCTS] UNIQUE  NONCLUSTERED 
	(
		[PRODUCTCODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ProductReplacment] ADD 
	CONSTRAINT [DF_ProductReplacment_AvaliableQty] DEFAULT (1) FOR [AvaliableQty]
GO

ALTER TABLE [dbo].[Product_Units_Prices] ADD 
	CONSTRAINT [DF_Product_Units_Prices_ConFactor] DEFAULT (1) FOR [ConFactor],
	CONSTRAINT [IX_Product_Units_Prices] UNIQUE  NONCLUSTERED 
	(
		[productid],
		[UintId]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[STOCK] ADD 
	CONSTRAINT [IX_STOCK] UNIQUE  NONCLUSTERED 
	(
		[PRODUCTID],
		[STOREID],
		[UnitID]
	)  ON [PRIMARY] ,
	CONSTRAINT [IX_STOCK_1] UNIQUE  NONCLUSTERED 
	(
		[STOREID],
		[PRODUCTID],
		[UnitID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[SUPPLIERS_CUSTOMERS] ADD 
	CONSTRAINT [DF_SUPPLIERS_CUSTOMERS_CREDITLIMIT] DEFAULT (0) FOR [CREDITLIMIT],
	CONSTRAINT [DF_SUPPLIERS_CUSTOMERS_CREDITPEROID] DEFAULT (0) FOR [CREDITPEROID],
	CONSTRAINT [DF_SUPPLIERS_CUSTOMERS_PAYPEROID] DEFAULT (0) FOR [PAYPEROID],
	CONSTRAINT [IX_SUPPLIERS_CUSTOMERS] UNIQUE  NONCLUSTERED 
	(
		[SUP_CUST_CODE]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[USER] ADD 
	CONSTRAINT [DF_USER_USER_TYPE] DEFAULT (2) FOR [USER_TYPE],
	CONSTRAINT [IX_USER] UNIQUE  NONCLUSTERED 
	(
		[USER_NAME]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[accounting] ADD 
	CONSTRAINT [DF_accounting_fromvalue] DEFAULT (0) FOR [Totalfromvalue],
	CONSTRAINT [DF_accounting_tovalue] DEFAULT (0) FOR [Totaltovalue],
	CONSTRAINT [DF_accounting_ProcessFlag] DEFAULT (0) FOR [ProcessFlag],
	CONSTRAINT [DF_accounting_display_Flag] DEFAULT (0) FOR [display_Flag],
	CONSTRAINT [IX_accounting] UNIQUE  NONCLUSTERED 
	(
		[AccountCode]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[invoices] ADD 
	CONSTRAINT [DF_invoices_CollectValue] DEFAULT (0) FOR [CollectValue]
GO

ALTER TABLE [dbo].[users] ADD 
	CONSTRAINT [IX_users] UNIQUE  NONCLUSTERED 
	(
		[username]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[CDE_PER_FILE_DOC] ADD 
	CONSTRAINT [CPFD_CPDT_FK] FOREIGN KEY 
	(
		[DOC_TYPE_CODE]
	) REFERENCES [dbo].[CDE_PER_DOCUMENT_TYPE] (
		[DOC_TYPE_CODE]
	),
	CONSTRAINT [CPFD_CPFT_FK] FOREIGN KEY 
	(
		[FILE_CODE]
	) REFERENCES [dbo].[CDE_PER_FILE_TYPE] (
		[FILE_CODE]
	)
GO

ALTER TABLE [dbo].[CDE_PER_JOB_DEGREE] ADD 
	CONSTRAINT [CPJD_CPD_FK] FOREIGN KEY 
	(
		[DEGREE_CODE]
	) REFERENCES [dbo].[CDE_PER_DEGREE] (
		[DEGREE_CODE]
	)
GO

ALTER TABLE [dbo].[CDE_PER_QLF_DTL] ADD 
	CONSTRAINT [CPQD_CPQ_FK] FOREIGN KEY 
	(
		[QLF_CODE],
		[QLF_TYP_CODE]
	) REFERENCES [dbo].[CDE_PER_QLF] (
		[QLF_CODE],
		[QLF_TYP_CODE]
	)
GO

ALTER TABLE [dbo].[CDE_PER_REPORT_TYPE] ADD 
	CONSTRAINT [CPRT2_CRD_FK] FOREIGN KEY 
	(
		[DURATION_CODE]
	) REFERENCES [dbo].[CDE_PER_DURATION] (
		[DURATION_CODE]
	)
GO

ALTER TABLE [dbo].[Installment_Distribution] ADD 
	CONSTRAINT [FK_Installment_Distribution_Installment] FOREIGN KEY 
	(
		[InstallId]
	) REFERENCES [dbo].[Installment] (
		[InstallId]
	)
GO

ALTER TABLE [dbo].[Inv_Products] ADD 
	CONSTRAINT [FK_Inv_Products_invoices] FOREIGN KEY 
	(
		[InvId]
	) REFERENCES [dbo].[invoices] (
		[InvId]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[PER_EMP_ABSENCE] ADD 
	CONSTRAINT [FK_PER_EMP_ABSENCE_PER_EMP_DATA] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_DISCOUNT] ADD 
	CONSTRAINT [FK_PER_EMP_DISCOUNT_CDE_PER_PENALTY] FOREIGN KEY 
	(
		[PEN_CODE]
	) REFERENCES [dbo].[CDE_PER_PENALTY] (
		[PEN_CODE]
	),
	CONSTRAINT [FK_PER_EMP_DISCOUNT_PER_EMP_DATA] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_DOCUMNET] ADD 
	CONSTRAINT [PED2_CPDT_FK] FOREIGN KEY 
	(
		[DOC_TYPE_CODE]
	) REFERENCES [dbo].[CDE_PER_DOCUMENT_TYPE] (
		[DOC_TYPE_CODE]
	),
	CONSTRAINT [PED2_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_JOB] ADD 
	CONSTRAINT [PEJ1_CPJD_FK] FOREIGN KEY 
	(
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE]
	) REFERENCES [dbo].[CDE_PER_JOB_DEGREE] (
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE]
	),
	CONSTRAINT [PEJ1_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_QLF] ADD 
	CONSTRAINT [PEQ_CPG_FK] FOREIGN KEY 
	(
		[GRAD_CODE]
	) REFERENCES [dbo].[CDE_PER_GRADE] (
		[GRAD_CODE]
	),
	CONSTRAINT [PEQ_CPQD_FK] FOREIGN KEY 
	(
		[QLF_CODE],
		[QLF_TYP_CODE],
		[SPEC_CODE]
	) REFERENCES [dbo].[CDE_PER_QLF_DTL] (
		[QLF_CODE],
		[QLF_TYP_CODE],
		[SPEC_CODE]
	),
	CONSTRAINT [PEQ_CPQE_FK] FOREIGN KEY 
	(
		[QUAL_ENT_CODE]
	) REFERENCES [dbo].[CDE_PER_QLF_ENT] (
		[QUAL_ENT_CODE]
	),
	CONSTRAINT [PEQ_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_RELATIVE] ADD 
	CONSTRAINT [PER_EMP_CPR2_FK] FOREIGN KEY 
	(
		[RELATION_CODE]
	) REFERENCES [dbo].[CDE_PER_RELATIVE] (
		[RELATION_CODE]
	),
	CONSTRAINT [PER_EMP_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_REPORT] ADD 
	CONSTRAINT [PER_CPG_FK] FOREIGN KEY 
	(
		[GRAD_CODE]
	) REFERENCES [dbo].[CDE_PER_GRADE] (
		[GRAD_CODE]
	),
	CONSTRAINT [PER_CPRT2_FK] FOREIGN KEY 
	(
		[REPORT_TYPE_CODE]
	) REFERENCES [dbo].[CDE_PER_REPORT_TYPE] (
		[REPORT_TYPE_CODE]
	),
	CONSTRAINT [PER_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_VACATION] ADD 
	CONSTRAINT [PEV_CPVT_FK] FOREIGN KEY 
	(
		[VAC_TYPE_CODE]
	) REFERENCES [dbo].[CDE_PER_VAC_SUB_CLASS] (
		[VAC_TYPE_CODE]
	),
	CONSTRAINT [PEV_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_EMP_VAC_BALANCE] ADD 
	CONSTRAINT [PEVB_CPVT_FK] FOREIGN KEY 
	(
		[VAC_TYPE_CODE]
	) REFERENCES [dbo].[CDE_PER_VAC_SUB_CLASS] (
		[VAC_TYPE_CODE]
	),
	CONSTRAINT [PEVB_PED_FK] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PER_JOB_YEAR_BUDGET] ADD 
	CONSTRAINT [PJYB_CPJD_FK] FOREIGN KEY 
	(
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE]
	) REFERENCES [dbo].[CDE_PER_JOB_DEGREE] (
		[JOB_CODE],
		[JOB_CLS_CODE],
		[DEGREE_CODE]
	)
GO

ALTER TABLE [dbo].[PRL_EMP_BASIC_SAL] ADD 
	CONSTRAINT [FK_PRL_EMP_BASIC_SAL_CDE_PRL_SAL_CATEGORY] FOREIGN KEY 
	(
		[SAL_CAT_CODE]
	) REFERENCES [dbo].[CDE_PRL_SAL_CATEGORY] (
		[SAL_CAT_CODE]
	)
GO

ALTER TABLE [dbo].[PRL_EMP_LOAN_DETAIL] ADD 
	CONSTRAINT [FK_PRL_EMP_LOAN_DETAIL_PER_EMP_DATA] FOREIGN KEY 
	(
		[EMP_CODE]
	) REFERENCES [dbo].[PER_EMPLOYEE_DATA] (
		[EMP_CODE]
	)
GO

ALTER TABLE [dbo].[PRODUCTS] ADD 
	CONSTRAINT [FK_PRODUCTS_CDE_PRODUCTTYPES] FOREIGN KEY 
	(
		[ProductTypeID]
	) REFERENCES [dbo].[CDE_PRODUCTTYPES] (
		[TYPEID]
	)
GO

ALTER TABLE [dbo].[ProductOffers] ADD 
	CONSTRAINT [FK_ProductOffers_CDE_UNIT_TYPES] FOREIGN KEY 
	(
		[UnitID]
	) REFERENCES [dbo].[CDE_UNIT_TYPES] (
		[UINTID]
	),
	CONSTRAINT [FK_ProductOffers_PRODUCTS] FOREIGN KEY 
	(
		[productid]
	) REFERENCES [dbo].[PRODUCTS] (
		[PRODUCTID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[ProductReplacment] ADD 
	CONSTRAINT [FK_ProductReplacment_PRODUCTS] FOREIGN KEY 
	(
		[productid]
	) REFERENCES [dbo].[PRODUCTS] (
		[PRODUCTID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[ProductVALIDITY] ADD 
	CONSTRAINT [FK_ProductVALIDITY_PRODUCTS] FOREIGN KEY 
	(
		[productid]
	) REFERENCES [dbo].[PRODUCTS] (
		[PRODUCTID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[Product_Assemply] ADD 
	CONSTRAINT [FK_ProductAssemply_PRODUCTS] FOREIGN KEY 
	(
		[productid]
	) REFERENCES [dbo].[PRODUCTS] (
		[PRODUCTID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[Product_Units_Prices] ADD 
	CONSTRAINT [FK_ProductUnits_CDE_UNIT_TYPES] FOREIGN KEY 
	(
		[UintId]
	) REFERENCES [dbo].[CDE_UNIT_TYPES] (
		[UINTID]
	),
	CONSTRAINT [FK_ProductUnits_PRODUCTS] FOREIGN KEY 
	(
		[productid]
	) REFERENCES [dbo].[PRODUCTS] (
		[PRODUCTID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[STOCK] ADD 
	CONSTRAINT [FK_STOCK_Product_Units_Prices] FOREIGN KEY 
	(
		[PRODUCTID],
		[UnitID]
	) REFERENCES [dbo].[Product_Units_Prices] (
		[productid],
		[UintId]
	),
	CONSTRAINT [FK_STOCK_STORES] FOREIGN KEY 
	(
		[STOREID]
	) REFERENCES [dbo].[STORES] (
		[STOREID]
	)
GO

ALTER TABLE [dbo].[STORES] ADD 
	CONSTRAINT [FK_STORES_BRANCHES] FOREIGN KEY 
	(
		[BRANCHCODE]
	) REFERENCES [dbo].[BRANCHES] (
		[BRANCHCODE]
	)
GO

ALTER TABLE [dbo].[USER_FUNCTION] ADD 
	CONSTRAINT [FK_USER_FUNCTION_FUNCTIONS] FOREIGN KEY 
	(
		[FUNCTION_ID]
	) REFERENCES [dbo].[FUNCTIONS] (
		[ID]
	),
	CONSTRAINT [FK_USER_FUNCTION_USER] FOREIGN KEY 
	(
		[USER_ID]
	) REFERENCES [dbo].[USER] (
		[ID]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[qids] ADD 
	CONSTRAINT [FK_qids_invoices] FOREIGN KEY 
	(
		[InvId]
	) REFERENCES [dbo].[invoices] (
		[InvId]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[qidsDetails] ADD 
	CONSTRAINT [FK_qidsDetails_accounting] FOREIGN KEY 
	(
		[ACCOUNTID]
	) REFERENCES [dbo].[accounting] (
		[accountid]
	),
	CONSTRAINT [FK_qidsDetails_qids] FOREIGN KEY 
	(
		[qidid]
	) REFERENCES [dbo].[qids] (
		[qidid]
	) ON DELETE CASCADE 
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

CREATE VIEW dbo.CustomerInvoicesView
AS
SELECT     dbo.invoices.InvId, dbo.invoices.InvCode, dbo.invoices.RecoderCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, dbo.invoices.InvAccid, 
                      dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, dbo.invoices.InvType, dbo.invoices.EmpId, 
                      dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.Notes, dbo.invoices.invTotal, dbo.invoices.Discount, dbo.invoices.InvTotalNet, 
                      dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, 
                      dbo.invoices.ChequeFlag, dbo.invoices.TotalAddCost, dbo.invoices.TotalReoder, dbo.invoices.TotalReoderNet, dbo.invoices.CostId, 
                      dbo.invoices.SUP_CUST_ID, dbo.invoices.PayFinish, dbo.invoices.CollectValue, dbo.Inv_Products.TotalPrice, dbo.Inv_Products.ReoderFlag, 
                      dbo.Inv_Products.TotReOderPrice, dbo.Inv_Products.StoreId, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME, dbo.Inv_Products.ProductId, 
                      dbo.PRODUCTS.productname, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_TYPE
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


CREATE VIEW dbo.InvProductsVIEW
AS
SELECT     dbo.Inv_Products.Inv_Product_Id, dbo.Inv_Products.InvId, dbo.Inv_Products.ProductId, dbo.Inv_Products.UnitId, dbo.Inv_Products.StoreId, 
                      dbo.Inv_Products.Discount, dbo.Inv_Products.ReoderFlag, dbo.invoices.InvCode, dbo.invoices.InvDate, dbo.invoices.Cust_Sup_Accid, 
                      dbo.invoices.InvAccid, dbo.invoices.PaymentType, dbo.invoices.PaymentAccid, dbo.invoices.BranchId, dbo.invoices.InvType, dbo.invoices.EmpId, 
                      dbo.invoices.PaymentValue, dbo.invoices.PaymentDate, dbo.invoices.InvPayment, dbo.invoices.InvRemain, dbo.invoices.ReferID, 
                      dbo.invoices.PaymentCost, dbo.invoices.ChequeNo, dbo.Inv_Products.Qty, dbo.Inv_Products.Price, dbo.Inv_Products.TotalPrice, 
                      dbo.Inv_Products.VaildDate, dbo.invoices.CostId, dbo.invoices.ChequeFlag, dbo.invoices.SUP_CUST_ID
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
                      dbo.Inv_Products.VaildDate, dbo.invoices.CostId, dbo.invoices.ChequeFlag, dbo.invoices.SUP_CUST_ID
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

CREATE VIEW dbo.AccountingView
AS
SELECT     dbo.qidsDetails.ID, dbo.qidsDetails.qidid, dbo.qidsDetails.FromValue, dbo.qidsDetails.ToValue, dbo.qidsDetails.ACCOUNTID, dbo.qidsDetails.type, 
                      dbo.qidsDetails.Description, dbo.qidsDetails.EnterDate, dbo.qidsDetails.Detcode, dbo.qidsDetails.QidType, dbo.qidsDetails.TotalPrice, 
                      dbo.qidsDetails.ActionType, dbo.accounting.accountname, dbo.qids.BrachId, dbo.qids.EmpId, dbo.qids.InvId, dbo.accounting.Totalfromvalue, 
                      dbo.accounting.Totaltovalue, dbo.qids.qidcode, dbo.qids.qidDate, dbo.Cde_QidTypes.QidTypeDesc, dbo.accounting.AccountparentId, 
                      dbo.accounting.AccountCode, dbo.invoices.PaymentType, dbo.qids.recitetype, dbo.invoices.Cust_Sup_Accid, dbo.invoices.SUP_CUST_ID, 
                      dbo.qids.ChequeNo, dbo.qids.PaymentType AS QidPaymentType, dbo.qidsDetails.CostId, dbo.qids.repeated
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


CREATE VIEW dbo.InvAllProductsVIEW
AS
SELECT     dbo.InvProductsVIEW.*
FROM         dbo.InvProductsVIEW
UNION all
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

CREATE VIEW dbo.InvProductsMoveVIEW
AS
SELECT DISTINCT 
                      dbo.InvAllProductsVIEW.*, dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_FNAME AS SUP_CUST_FNAME, 
                      dbo.CDE_UNIT_TYPES.UNITDESC AS UNITDESC, dbo.PRODUCTS.productname AS ProductName, 
                      dbo.Product_Units_Prices.LastSalePrice AS LastSalePrice, dbo.Product_Units_Prices.LastBuyPrice AS LastBuyPrice, 
                      dbo.Product_Units_Prices.LastCostPrice AS LastCostPrice, dbo.STOCK.QUANTITY AS QUANTITY, dbo.PRODUCTS.PRODUCTCODE AS PRODUCTCODE, 
                      dbo.SUPPLIERS_CUSTOMERS.PHONE1 AS PHONE1
FROM         dbo.InvAllProductsVIEW INNER JOIN
                      dbo.PRODUCTS INNER JOIN
                      dbo.Product_Units_Prices ON dbo.PRODUCTS.PRODUCTID = dbo.Product_Units_Prices.productid INNER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Product_Units_Prices.UintId = dbo.CDE_UNIT_TYPES.UINTID ON 
                      dbo.InvAllProductsVIEW.UnitId = dbo.Product_Units_Prices.UintId AND 
                      dbo.InvAllProductsVIEW.ProductId = dbo.Product_Units_Prices.productid LEFT OUTER JOIN
                      dbo.STOCK ON dbo.InvAllProductsVIEW.UnitId = dbo.STOCK.UnitID AND dbo.InvAllProductsVIEW.ProductId = dbo.STOCK.PRODUCTID AND 
                      dbo.InvAllProductsVIEW.StoreId = dbo.STOCK.STOREID LEFT OUTER JOIN
                      dbo.SUPPLIERS_CUSTOMERS ON dbo.InvAllProductsVIEW.SUP_CUST_ID = dbo.SUPPLIERS_CUSTOMERS.SUP_CUST_ID

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
                      dbo.CDE_UNIT_TYPES.UNITDESC, dbo.STORES.BRANCHCODE
FROM         dbo.Product_Units_Prices INNER JOIN
                      dbo.PRODUCTS ON dbo.Product_Units_Prices.productid = dbo.PRODUCTS.PRODUCTID INNER JOIN
                      dbo.STOCK ON dbo.Product_Units_Prices.productid = dbo.STOCK.PRODUCTID AND dbo.Product_Units_Prices.UintId = dbo.STOCK.UnitID INNER JOIN
                      dbo.STORES ON dbo.STOCK.STOREID = dbo.STORES.STOREID INNER JOIN
                      dbo.BRANCHES ON dbo.STORES.BRANCHCODE = dbo.BRANCHES.BRANCHCODE INNER JOIN
                      dbo.CDE_UNIT_TYPES ON dbo.Product_Units_Prices.UintId = dbo.CDE_UNIT_TYPES.UINTID
ORDER BY dbo.PRODUCTS.PRODUCTCODE


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
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

SET QUOTED_IDENTIFIER OFF 
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
DBCC CHECKIDENT (qids, RESEED, 0)
DBCC CHECKIDENT (qidsDetails, RESEED, 0)
DBCC CHECKIDENT (invoices, RESEED, 0)
DBCC CHECKIDENT (Inv_Products, RESEED, 0)
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
	ABS(isnull(dbo.fn_Select_totalToValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate) ,0) - isnull(dbo.fn_Select_totalFromValue(dbo.accounting.accountid,@BrachId,@FromDate,@ToDate),0) ) AS  TotalBalance
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


CREATE PROCEDURE dbo.usp_AccountingViewByQidId
(
	@QidId bigint
)
AS
	SET NOCOUNT ON;
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate, QidTypeDesc, AccountparentId, AccountCode, PaymentType, recitetype, 
                      Cust_Sup_Accid, SUP_CUST_ID, ChequeNo, QidPaymentType
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
                      SUP_CUST_ID, ChequeNo, QidPaymentType, CostId, repeated
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
@CostID bigint
)
AS
	SET NOCOUNT ON;
SELECT   ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, accountname, BrachId, EmpId, 
                      InvId, Totalfromvalue, Totaltovalue, qidcode, qidDate,AccountparentId, AccountCode,QidTypeDesc,(isnull(FromValue,0 )-isnull(ToValue,0 )) as Total, CostId
FROM         AccountingView
WHERE     (ACCOUNTID = @ACCOUNTID or @ACCOUNTID  IS NULL ) AND (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)
  and  ( invId in (select InvId from dbo.Inv_Products where ProductId=@ProductId)  or @ProductId is null ) and   (CostID = @CostID or @CostID  IS NULL ) 
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
                      Cust_Sup_Accid, SUP_CUST_ID, ChequeNo, QidPaymentType
FROM         AccountingView
WHERE     (BrachId = @BrachId or @BrachId is null ) AND (qidDate >= @FromDate or @FromDate is null ) AND (qidDate <= @ToDate or @ToDate is null)and (recitetype = @recitetype)


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
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
                      SUM(OtherValue) AS totalOther, isnull(SUM(PaymentValue),0) AS totalPayment, isnull(SUM(InvTotalNet),0) AS totalSalNet,
                         isnull( (SELECT     SUM(FromValue)
                             FROM         AccountingView
                             WHERE    (EmpId=@EmpId) and  (QidType = 7) AND (BrachId = @branchId) and QidDate>=@StartDate and QidDate<=@EndDate  ) ,0 ) AS totalGetQidvalue,
 isnull((SELECT     SUM(FromValue)
                             FROM         AccountingView
                             WHERE    (EmpId=@EmpId) and  (QidType = 6) AND (BrachId = @branchId) and QidDate>=@StartDate and QidDate<=@EndDate) ,0) AS totalOutQidvalue

,isnull((select   SUM(InvTotalNet)   FROM dbo.InvoiceView WHERE (InvType = 1) AND (BranchId = @branchId) and InvDate>=@StartDate and InvDate<=@EndDate ),0)AS totalPurNet
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
	@IsNull_CompanyName Int,
	@Original_CompanyName nvarchar(150),
	@IsNull_Address Int,
	@Original_Address nvarchar(150),
	@IsNull_TelPhone Int,
	@Original_TelPhone nvarchar(100),
	@IsNull_HintName Int,
	@Original_HintName varchar(50),
	@IsNull_SalInvSerial Int,
	@Original_SalInvSerial bigint,
	@IsNull_PurchInvSerial Int,
	@Original_PurchInvSerial bigint,
	@IsNull_InvOrderSerial Int,
	@Original_InvOrderSerial bigint,
	@IsNull_OrderSerial Int,
	@Original_OrderSerial bigint,
	@IsNull_salesaccid Int,
	@Original_salesaccid smallint,
	@IsNull_purchaseaccid Int,
	@Original_purchaseaccid smallint,
	@IsNull_boxaccid Int,
	@Original_boxaccid bigint,
	@IsNull_bankaccid Int,
	@Original_bankaccid bigint,
	@IsNull_Visaaccid Int,
	@Original_Visaaccid bigint,
	@IsNull_Masteraccid Int,
	@Original_Masteraccid bigint,
	@IsNull_KeyNetaccid Int,
	@Original_KeyNetaccid bigint,
	@IsNull_Otheraccid Int,
	@Original_Otheraccid bigint,
	@IsNull_VisaComaccid Int,
	@Original_VisaComaccid bigint,
	@IsNull_MasterComaccid Int,
	@Original_MasterComaccid bigint,
	@IsNull_KeyNetComaccid Int,
	@Original_KeyNetComaccid bigint,
	@IsNull_OtherComaccid Int,
	@Original_OtherComaccid bigint,
	@IsNull_salesAgalaccid Int,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseAgalaaccid Int,
	@Original_purchaseAgalaaccid bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [BRANCHES] WHERE (([BRANCHCODE] = @Original_BRANCHCODE) AND ([BRANCHNAME] = @Original_BRANCHNAME) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_HintName = 1 AND [HintName] IS NULL) OR ([HintName] = @Original_HintName)) AND ((@IsNull_SalInvSerial = 1 AND [SalInvSerial] IS NULL) OR ([SalInvSerial] = @Original_SalInvSerial)) AND ((@IsNull_PurchInvSerial = 1 AND [PurchInvSerial] IS NULL) OR ([PurchInvSerial] = @Original_PurchInvSerial)) AND ((@IsNull_InvOrderSerial = 1 AND [InvOrderSerial] IS NULL) OR ([InvOrderSerial] = @Original_InvOrderSerial)) AND ((@IsNull_OrderSerial = 1 AND [OrderSerial] IS NULL) OR ([OrderSerial] = @Original_OrderSerial)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_Visaaccid = 1 AND [Visaaccid] IS NULL) OR ([Visaaccid] = @Original_Visaaccid)) AND ((@IsNull_Masteraccid = 1 AND [Masteraccid] IS NULL) OR ([Masteraccid] = @Original_Masteraccid)) AND ((@IsNull_KeyNetaccid = 1 AND [KeyNetaccid] IS NULL) OR ([KeyNetaccid] = @Original_KeyNetaccid)) AND ((@IsNull_Otheraccid = 1 AND [Otheraccid] IS NULL) OR ([Otheraccid] = @Original_Otheraccid)) AND ((@IsNull_VisaComaccid = 1 AND [VisaComaccid] IS NULL) OR ([VisaComaccid] = @Original_VisaComaccid)) AND ((@IsNull_MasterComaccid = 1 AND [MasterComaccid] IS NULL) OR ([MasterComaccid] = @Original_MasterComaccid)) AND ((@IsNull_KeyNetComaccid = 1 AND [KeyNetComaccid] IS NULL) OR ([KeyNetComaccid] = @Original_KeyNetComaccid)) AND ((@IsNull_OtherComaccid = 1 AND [OtherComaccid] IS NULL) OR ([OtherComaccid] = @Original_OtherComaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseAgalaaccid = 1 AND [purchaseAgalaaccid] IS NULL) OR ([purchaseAgalaaccid] = @Original_purchaseAgalaaccid)))
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
INSERT INTO [BRANCHES] ([BRANCHNAME], [CompanyName], [Address], [TelPhone], [HintName], [SalInvSerial], [PurchInvSerial], [InvOrderSerial], [OrderSerial], [salesaccid], [purchaseaccid], [boxaccid], [bankaccid], [Visaaccid], [Masteraccid], [KeyNetaccid], [Otheraccid], [VisaComaccid], [MasterComaccid], [KeyNetComaccid], [OtherComaccid], [salesAgalaccid], [purchaseAgalaaccid]) VALUES (@BRANCHNAME, @CompanyName, @Address, @TelPhone, @HintName, @SalInvSerial, @PurchInvSerial, @InvOrderSerial, @OrderSerial, @salesaccid, @purchaseaccid, @boxaccid, @bankaccid, @Visaaccid, @Masteraccid, @KeyNetaccid, @Otheraccid, @VisaComaccid, @MasterComaccid, @KeyNetComaccid, @OtherComaccid, @salesAgalaccid, @purchaseAgalaaccid);
	
SELECT BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, salesaccid, purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, OtherComaccid, salesAgalaccid, purchaseAgalaaccid FROM BRANCHES WHERE (BRANCHCODE = SCOPE_IDENTITY())
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
SELECT     BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, salesaccid, 
                      purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, 
                      OtherComaccid, salesAgalaccid, purchaseAgalaaccid
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
	@IsNull_CompanyName Int,
	@Original_CompanyName nvarchar(150),
	@IsNull_Address Int,
	@Original_Address nvarchar(150),
	@IsNull_TelPhone Int,
	@Original_TelPhone nvarchar(100),
	@IsNull_HintName Int,
	@Original_HintName varchar(50),
	@IsNull_SalInvSerial Int,
	@Original_SalInvSerial bigint,
	@IsNull_PurchInvSerial Int,
	@Original_PurchInvSerial bigint,
	@IsNull_InvOrderSerial Int,
	@Original_InvOrderSerial bigint,
	@IsNull_OrderSerial Int,
	@Original_OrderSerial bigint,
	@IsNull_salesaccid Int,
	@Original_salesaccid smallint,
	@IsNull_purchaseaccid Int,
	@Original_purchaseaccid smallint,
	@IsNull_boxaccid Int,
	@Original_boxaccid bigint,
	@IsNull_bankaccid Int,
	@Original_bankaccid bigint,
	@IsNull_Visaaccid Int,
	@Original_Visaaccid bigint,
	@IsNull_Masteraccid Int,
	@Original_Masteraccid bigint,
	@IsNull_KeyNetaccid Int,
	@Original_KeyNetaccid bigint,
	@IsNull_Otheraccid Int,
	@Original_Otheraccid bigint,
	@IsNull_VisaComaccid Int,
	@Original_VisaComaccid bigint,
	@IsNull_MasterComaccid Int,
	@Original_MasterComaccid bigint,
	@IsNull_KeyNetComaccid Int,
	@Original_KeyNetComaccid bigint,
	@IsNull_OtherComaccid Int,
	@Original_OtherComaccid bigint,
	@IsNull_salesAgalaccid Int,
	@Original_salesAgalaccid bigint,
	@IsNull_purchaseAgalaaccid Int,
	@Original_purchaseAgalaaccid bigint,
	@BRANCHCODE bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [BRANCHES] SET [BRANCHNAME] = @BRANCHNAME, [CompanyName] = @CompanyName, [Address] = @Address, [TelPhone] = @TelPhone, [HintName] = @HintName, [SalInvSerial] = @SalInvSerial, [PurchInvSerial] = @PurchInvSerial, [InvOrderSerial] = @InvOrderSerial, [OrderSerial] = @OrderSerial, [salesaccid] = @salesaccid, [purchaseaccid] = @purchaseaccid, [boxaccid] = @boxaccid, [bankaccid] = @bankaccid, [Visaaccid] = @Visaaccid, [Masteraccid] = @Masteraccid, [KeyNetaccid] = @KeyNetaccid, [Otheraccid] = @Otheraccid, [VisaComaccid] = @VisaComaccid, [MasterComaccid] = @MasterComaccid, [KeyNetComaccid] = @KeyNetComaccid, [OtherComaccid] = @OtherComaccid, [salesAgalaccid] = @salesAgalaccid, [purchaseAgalaaccid] = @purchaseAgalaaccid WHERE (([BRANCHCODE] = @Original_BRANCHCODE) AND ([BRANCHNAME] = @Original_BRANCHNAME) AND ((@IsNull_CompanyName = 1 AND [CompanyName] IS NULL) OR ([CompanyName] = @Original_CompanyName)) AND ((@IsNull_Address = 1 AND [Address] IS NULL) OR ([Address] = @Original_Address)) AND ((@IsNull_TelPhone = 1 AND [TelPhone] IS NULL) OR ([TelPhone] = @Original_TelPhone)) AND ((@IsNull_HintName = 1 AND [HintName] IS NULL) OR ([HintName] = @Original_HintName)) AND ((@IsNull_SalInvSerial = 1 AND [SalInvSerial] IS NULL) OR ([SalInvSerial] = @Original_SalInvSerial)) AND ((@IsNull_PurchInvSerial = 1 AND [PurchInvSerial] IS NULL) OR ([PurchInvSerial] = @Original_PurchInvSerial)) AND ((@IsNull_InvOrderSerial = 1 AND [InvOrderSerial] IS NULL) OR ([InvOrderSerial] = @Original_InvOrderSerial)) AND ((@IsNull_OrderSerial = 1 AND [OrderSerial] IS NULL) OR ([OrderSerial] = @Original_OrderSerial)) AND ((@IsNull_salesaccid = 1 AND [salesaccid] IS NULL) OR ([salesaccid] = @Original_salesaccid)) AND ((@IsNull_purchaseaccid = 1 AND [purchaseaccid] IS NULL) OR ([purchaseaccid] = @Original_purchaseaccid)) AND ((@IsNull_boxaccid = 1 AND [boxaccid] IS NULL) OR ([boxaccid] = @Original_boxaccid)) AND ((@IsNull_bankaccid = 1 AND [bankaccid] IS NULL) OR ([bankaccid] = @Original_bankaccid)) AND ((@IsNull_Visaaccid = 1 AND [Visaaccid] IS NULL) OR ([Visaaccid] = @Original_Visaaccid)) AND ((@IsNull_Masteraccid = 1 AND [Masteraccid] IS NULL) OR ([Masteraccid] = @Original_Masteraccid)) AND ((@IsNull_KeyNetaccid = 1 AND [KeyNetaccid] IS NULL) OR ([KeyNetaccid] = @Original_KeyNetaccid)) AND ((@IsNull_Otheraccid = 1 AND [Otheraccid] IS NULL) OR ([Otheraccid] = @Original_Otheraccid)) AND ((@IsNull_VisaComaccid = 1 AND [VisaComaccid] IS NULL) OR ([VisaComaccid] = @Original_VisaComaccid)) AND ((@IsNull_MasterComaccid = 1 AND [MasterComaccid] IS NULL) OR ([MasterComaccid] = @Original_MasterComaccid)) AND ((@IsNull_KeyNetComaccid = 1 AND [KeyNetComaccid] IS NULL) OR ([KeyNetComaccid] = @Original_KeyNetComaccid)) AND ((@IsNull_OtherComaccid = 1 AND [OtherComaccid] IS NULL) OR ([OtherComaccid] = @Original_OtherComaccid)) AND ((@IsNull_salesAgalaccid = 1 AND [salesAgalaccid] IS NULL) OR ([salesAgalaccid] = @Original_salesAgalaccid)) AND ((@IsNull_purchaseAgalaaccid = 1 AND [purchaseAgalaaccid] IS NULL) OR ([purchaseAgalaaccid] = @Original_purchaseAgalaaccid)));
	
SELECT BRANCHCODE, BRANCHNAME, CompanyName, Address, TelPhone, HintName, SalInvSerial, PurchInvSerial, InvOrderSerial, OrderSerial, salesaccid, purchaseaccid, boxaccid, bankaccid, Visaaccid, Masteraccid, KeyNetaccid, Otheraccid, VisaComaccid, MasterComaccid, KeyNetComaccid, OtherComaccid, salesAgalaccid, purchaseAgalaaccid FROM BRANCHES WHERE (BRANCHCODE = @BRANCHCODE)
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
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 0  THEN  isnull(TotalPrice, 0)  end END) AS CashVaule, 
SUM(CASE PaymentType WHEN 1 THEN 
CASE ReoderFlag WHEN 0  THEN isnull(TotalPrice, 0)  else 0 end END) AS AgalValue, 
SUM(CASE PaymentType WHEN 1 THEN CASE ReoderFlag WHEN 1 THEN   isnull(TotReoderPrice, 0) else 0 end  END) AS AgalreorderValue, 
SUM(CASE PaymentType WHEN 2 THEN CASE ReoderFlag WHEN 1 then isnull(TotReoderPrice, 0) else 0 end END) AS ChashReordervalue,
                        
  (SELECT     SUM(isnull(collectValue, 0) + isnull(PaymentValue, 0))
                             FROM         invoices
                             WHERE     (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
					--AND (StoreId = @StoreId or @StoreId is null )
					AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
					--AND (ProductId = @ProductId or @ProductId is null )
                           --  GROUP BY SUP_CUST_ID, invId
) AS CashColValue
FROM         dbo.CustomerInvoicesView
where  (SUP_CUST_ID = @SUP_CUST_ID or @SUP_CUST_ID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) 
AND (StoreId = @StoreId or @StoreId is null )
AND (InvDate >= @FromDate or @FromDate is null ) AND (InvDate <= @ToDate or @ToDate is null)
AND (ProductId = @ProductId or @ProductId is null ) and (SUP_CUST_TYPE=2 or SUP_CUST_TYPE=3)
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

CREATE PROCEDURE dbo.usp_EMP_ABSENCEDelete
(
	@Original_AbsenceID bigint,
	@Original_START_DATE datetime,
	@Original_END_DATE datetime,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@Original_DAYS_NUM numeric(5, 0),
	@IsNull_HOUR_NUM Int,
	@Original_HOUR_NUM decimal(18, 0),
	@IsNull_HOURVALUE Int,
	@Original_HOURVALUE money,
	@IsNull_NOTE Int,
	@Original_NOTE varchar(2000)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_ABSENCE] WHERE (([AbsenceID] = @Original_AbsenceID) AND ([START_DATE] = @Original_START_DATE) AND ([END_DATE] = @Original_END_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([DAYS_NUM] = @Original_DAYS_NUM) AND ((@IsNull_HOUR_NUM = 1 AND [HOUR_NUM] IS NULL) OR ([HOUR_NUM] = @Original_HOUR_NUM)) AND ((@IsNull_HOURVALUE = 1 AND [HOURVALUE] IS NULL) OR ([HOURVALUE] = @Original_HOURVALUE)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)))
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
	@NOTE varchar(2000)
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
	@NOTE varchar(2000),
	@Original_AbsenceID bigint,
	@Original_START_DATE datetime,
	@Original_END_DATE datetime,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@Original_DAYS_NUM numeric(5, 0),
	@IsNull_HOUR_NUM Int,
	@Original_HOUR_NUM decimal(18, 0),
	@IsNull_HOURVALUE Int,
	@Original_HOURVALUE money,
	@IsNull_NOTE Int,
	@Original_NOTE varchar(2000),
	@AbsenceID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_ABSENCE] SET [START_DATE] = @START_DATE, [END_DATE] = @END_DATE, [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [DAYS_NUM] = @DAYS_NUM, [HOUR_NUM] = @HOUR_NUM, [HOURVALUE] = @HOURVALUE, [NOTE] = @NOTE WHERE (([AbsenceID] = @Original_AbsenceID) AND ([START_DATE] = @Original_START_DATE) AND ([END_DATE] = @Original_END_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([DAYS_NUM] = @Original_DAYS_NUM) AND ((@IsNull_HOUR_NUM = 1 AND [HOUR_NUM] IS NULL) OR ([HOUR_NUM] = @Original_HOUR_NUM)) AND ((@IsNull_HOURVALUE = 1 AND [HOURVALUE] IS NULL) OR ([HOURVALUE] = @Original_HOURVALUE)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)));
	
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
	@IsNull_PEN_CODE numeric(5, 0),
	@Original_PEN_CODE numeric(5, 0),
	@IsNull_DISCOUNT_DATE smalldatetime,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_AMOUNT money,
	@Original_AMOUNT money,
	@IsNull_accountid int,
	@Original_accountid int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_DISCOUNT] WHERE (([DISCOUNTID] = @Original_DISCOUNTID) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_PEN_CODE = 1 AND [PEN_CODE] IS NULL) OR ([PEN_CODE] = @Original_PEN_CODE)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)))
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
	@DES ntext,
	@accountid int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_DISCOUNT] ([EMP_CODE], [YEAR_CODE], [MONTH_CODE], [PEN_CODE], [DISCOUNT_DATE], [AMOUNT], [DES], [accountid]) VALUES (@EMP_CODE, @YEAR_CODE, @MONTH_CODE, @PEN_CODE, @DISCOUNT_DATE, @AMOUNT, @DES, @accountid);
	
SELECT DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid FROM PER_EMP_DISCOUNT WHERE (DISCOUNTID = SCOPE_IDENTITY())
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
SELECT     DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid
FROM         PER_EMP_DISCOUNT
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
	@DES ntext,
	@accountid int,
	@Original_DISCOUNTID int,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_PEN_CODE numeric(5, 0),
	@Original_PEN_CODE numeric(5, 0),
	@IsNull_DISCOUNT_DATE smalldatetime,
	@Original_DISCOUNT_DATE smalldatetime,
	@IsNull_AMOUNT money,
	@Original_AMOUNT money,
	@IsNull_accountid int,
	@Original_accountid int,
	@DISCOUNTID int
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_DISCOUNT] SET [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [PEN_CODE] = @PEN_CODE, [DISCOUNT_DATE] = @DISCOUNT_DATE, [AMOUNT] = @AMOUNT, [DES] = @DES, [accountid] = @accountid WHERE (([DISCOUNTID] = @Original_DISCOUNTID) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_PEN_CODE = 1 AND [PEN_CODE] IS NULL) OR ([PEN_CODE] = @Original_PEN_CODE)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)));
	
SELECT DISCOUNTID, EMP_CODE, YEAR_CODE, MONTH_CODE, PEN_CODE, DISCOUNT_DATE, AMOUNT, DES, accountid FROM PER_EMP_DISCOUNT WHERE (DISCOUNTID = @DISCOUNTID)
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
	@IsNull_STOP_FLAG varchar(1),
	@Original_STOP_FLAG varchar(1),
	@IsNull_accountid int,
	@Original_accountid int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRL_EMP_LOAN_DETAIL] WHERE (([LoanID] = @Original_LoanID) AND ([START_DATE] = @Original_START_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_MONTHLY_AMOUNT = 1 AND [MONTHLY_AMOUNT] IS NULL) OR ([MONTHLY_AMOUNT] = @Original_MONTHLY_AMOUNT)) AND ([TOTAL_AMOUNT] = @Original_TOTAL_AMOUNT) AND ((@IsNull_TOT_PAID = 1 AND [TOT_PAID] IS NULL) OR ([TOT_PAID] = @Original_TOT_PAID)) AND ((@IsNull_TOTAL_MON_NUM = 1 AND [TOTAL_MON_NUM] IS NULL) OR ([TOTAL_MON_NUM] = @Original_TOTAL_MON_NUM)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_STOP_FLAG = 1 AND [STOP_FLAG] IS NULL) OR ([STOP_FLAG] = @Original_STOP_FLAG)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)))
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
	@STOP_FLAG varchar(1),
	@accountid int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRL_EMP_LOAN_DETAIL] ([START_DATE], [EMP_CODE], [MONTHLY_AMOUNT], [TOTAL_AMOUNT], [TOT_PAID], [TOTAL_MON_NUM], [NOTE], [STOP_FLAG], [accountid]) VALUES (@START_DATE, @EMP_CODE, @MONTHLY_AMOUNT, @TOTAL_AMOUNT, @TOT_PAID, @TOTAL_MON_NUM, @NOTE, @STOP_FLAG, @accountid);
	
SELECT LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid FROM PRL_EMP_LOAN_DETAIL WHERE (LoanID = SCOPE_IDENTITY())
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
SELECT     LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid
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
SELECT     LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid
FROM         PRL_EMP_LOAN_DETAIL
WHERE     (LoanID = @LoanId)
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
	@STOP_FLAG varchar(1),
	@accountid int,
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
	@IsNull_STOP_FLAG varchar(1),
	@Original_STOP_FLAG varchar(1),
	@IsNull_accountid int,
	@Original_accountid int,
	@LoanID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRL_EMP_LOAN_DETAIL] SET [START_DATE] = @START_DATE, [EMP_CODE] = @EMP_CODE, [MONTHLY_AMOUNT] = @MONTHLY_AMOUNT, [TOTAL_AMOUNT] = @TOTAL_AMOUNT, [TOT_PAID] = @TOT_PAID, [TOTAL_MON_NUM] = @TOTAL_MON_NUM, [NOTE] = @NOTE, [STOP_FLAG] = @STOP_FLAG, [accountid] = @accountid WHERE (([LoanID] = @Original_LoanID) AND ([START_DATE] = @Original_START_DATE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_MONTHLY_AMOUNT = 1 AND [MONTHLY_AMOUNT] IS NULL) OR ([MONTHLY_AMOUNT] = @Original_MONTHLY_AMOUNT)) AND ([TOTAL_AMOUNT] = @Original_TOTAL_AMOUNT) AND ((@IsNull_TOT_PAID = 1 AND [TOT_PAID] IS NULL) OR ([TOT_PAID] = @Original_TOT_PAID)) AND ((@IsNull_TOTAL_MON_NUM = 1 AND [TOTAL_MON_NUM] IS NULL) OR ([TOTAL_MON_NUM] = @Original_TOTAL_MON_NUM)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)) AND ((@IsNull_STOP_FLAG = 1 AND [STOP_FLAG] IS NULL) OR ([STOP_FLAG] = @Original_STOP_FLAG)) AND ((@IsNull_accountid = 1 AND [accountid] IS NULL) OR ([accountid] = @Original_accountid)));
	
SELECT LoanID, START_DATE, EMP_CODE, MONTHLY_AMOUNT, TOTAL_AMOUNT, TOT_PAID, TOTAL_MON_NUM, NOTE, STOP_FLAG, accountid FROM PRL_EMP_LOAN_DETAIL WHERE (LoanID = @LoanID)
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
	@IsNull_RETURN_DATE Int,
	@Original_RETURN_DATE datetime,
	@IsNull_VAC_PERIOD Int,
	@Original_VAC_PERIOD numeric(5, 0),
	@IsNull_NOTE Int,
	@Original_NOTE varchar(300)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_VACATION] WHERE (([VACID] = @Original_VACID) AND ([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([VAC_DATE_FRM] = @Original_VAC_DATE_FRM) AND ([VAC_DATE_TO] = @Original_VAC_DATE_TO) AND ((@IsNull_RETURN_DATE = 1 AND [RETURN_DATE] IS NULL) OR ([RETURN_DATE] = @Original_RETURN_DATE)) AND ((@IsNull_VAC_PERIOD = 1 AND [VAC_PERIOD] IS NULL) OR ([VAC_PERIOD] = @Original_VAC_PERIOD)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)))
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
	@NOTE varchar(300)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_VACATION] ([VAC_TYPE_CODE], [EMP_CODE], [VAC_DATE_FRM], [VAC_DATE_TO], [RETURN_DATE], [VAC_PERIOD], [NOTE]) VALUES (@VAC_TYPE_CODE, @EMP_CODE, @VAC_DATE_FRM, @VAC_DATE_TO, @RETURN_DATE, @VAC_PERIOD, @NOTE);
	
SELECT VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE FROM PER_EMP_VACATION WHERE (VACID = SCOPE_IDENTITY())
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
SELECT     VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE
FROM         PER_EMP_VACATION
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
	@Original_VACID bigint,
	@Original_VAC_TYPE_CODE numeric(5, 0),
	@Original_EMP_CODE bigint,
	@Original_VAC_DATE_FRM datetime,
	@Original_VAC_DATE_TO datetime,
	@IsNull_RETURN_DATE Int,
	@Original_RETURN_DATE datetime,
	@IsNull_VAC_PERIOD Int,
	@Original_VAC_PERIOD numeric(5, 0),
	@IsNull_NOTE Int,
	@Original_NOTE varchar(300),
	@VACID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_VACATION] SET [VAC_TYPE_CODE] = @VAC_TYPE_CODE, [EMP_CODE] = @EMP_CODE, [VAC_DATE_FRM] = @VAC_DATE_FRM, [VAC_DATE_TO] = @VAC_DATE_TO, [RETURN_DATE] = @RETURN_DATE, [VAC_PERIOD] = @VAC_PERIOD, [NOTE] = @NOTE WHERE (([VACID] = @Original_VACID) AND ([VAC_TYPE_CODE] = @Original_VAC_TYPE_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ([VAC_DATE_FRM] = @Original_VAC_DATE_FRM) AND ([VAC_DATE_TO] = @Original_VAC_DATE_TO) AND ((@IsNull_RETURN_DATE = 1 AND [RETURN_DATE] IS NULL) OR ([RETURN_DATE] = @Original_RETURN_DATE)) AND ((@IsNull_VAC_PERIOD = 1 AND [VAC_PERIOD] IS NULL) OR ([VAC_PERIOD] = @Original_VAC_PERIOD)) AND ((@IsNull_NOTE = 1 AND [NOTE] IS NULL) OR ([NOTE] = @Original_NOTE)));
	
SELECT VACID, VAC_TYPE_CODE, EMP_CODE, VAC_DATE_FRM, VAC_DATE_TO, RETURN_DATE, VAC_PERIOD, NOTE FROM PER_EMP_VACATION WHERE (VACID = @VACID)
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
	@IsNull_CIVILID nvarchar(50),
	@Original_CIVILID nvarchar(50),
	@Original_EMPNAME nvarchar(200),
	@IsNull_EngNAME nvarchar(50),
	@Original_EngNAME nvarchar(50),
	@IsNull_TITLE nvarchar(30),
	@Original_TITLE nvarchar(30),
	@IsNull_EMP_GENDER numeric(1, 0),
	@Original_EMP_GENDER numeric(1, 0),
	@IsNull_EMP_BIRTH_DATE datetime,
	@Original_EMP_BIRTH_DATE datetime,
	@IsNull_EMP_MOBILE varchar(15),
	@Original_EMP_MOBILE varchar(15),
	@IsNull_DEPTCODE bigint,
	@Original_DEPTCODE bigint,
	@IsNull_ADDRESS nvarchar(60),
	@Original_ADDRESS nvarchar(60),
	@IsNull_EMP_PHONE varchar(15),
	@Original_EMP_PHONE varchar(15),
	@IsNull_EMP_EMAIL varchar(50),
	@Original_EMP_EMAIL varchar(50),
	@IsNull_EMP_HIREDATE datetime,
	@Original_EMP_HIREDATE datetime,
	@IsNull_Emp_End_HIREDATE smalldatetime,
	@Original_Emp_End_HIREDATE smalldatetime,
	@IsNull_EMP_HEALTH_INS_DATE datetime,
	@Original_EMP_HEALTH_INS_DATE datetime,
	@IsNull_EMP_HEALTH_INS_NUM varchar(200),
	@Original_EMP_HEALTH_INS_NUM varchar(200),
	@IsNull_JOB_CODE numeric(5, 0),
	@Original_JOB_CODE numeric(5, 0),
	@IsNull_JOB_CLS_CODE numeric(5, 0),
	@Original_JOB_CLS_CODE numeric(5, 0),
	@IsNull_FILE_NUM varchar(20),
	@Original_FILE_NUM varchar(20),
	@IsNull_DEGREE_CODE numeric(5, 0),
	@Original_DEGREE_CODE numeric(5, 0),
	@IsNull_REC_TYPE_CODE numeric(5, 0),
	@Original_REC_TYPE_CODE numeric(5, 0),
	@IsNull_MARITAL_STATUS_CODE numeric(5, 0),
	@Original_MARITAL_STATUS_CODE numeric(5, 0),
	@IsNull_NATIONALITY_CODE numeric(5, 0),
	@Original_NATIONALITY_CODE numeric(5, 0),
	@IsNull_GOVER_CODE numeric(5, 0),
	@Original_GOVER_CODE numeric(5, 0),
	@IsNull_EMP_VISA bit,
	@Original_EMP_VISA bit,
	@IsNull_Emp_VISA_NO nvarchar(50),
	@Original_Emp_VISA_NO nvarchar(50),
	@IsNull_EMP_VISA_END_DATE datetime,
	@Original_EMP_VISA_END_DATE datetime,
	@IsNull_BANK_CODE numeric(5, 0),
	@Original_BANK_CODE numeric(5, 0),
	@IsNull_AccountID numeric(38, 0),
	@Original_AccountID numeric(38, 0),
	@IsNull_passportNo nvarchar(50),
	@Original_passportNo nvarchar(50),
	@IsNull_passtype nvarchar(50),
	@Original_passtype nvarchar(50),
	@IsNull_passdate smalldatetime,
	@Original_passdate smalldatetime,
	@IsNull_passplace nvarchar(50),
	@Original_passplace nvarchar(50),
	@IsNull_entrydate smalldatetime,
	@Original_entrydate smalldatetime,
	@IsNull_BORROWS float,
	@Original_BORROWS float,
	@IsNull_SALARY money,
	@Original_SALARY money,
	@IsNull_ADDED money,
	@Original_ADDED money,
	@IsNull_DEDUCED money,
	@Original_DEDUCED money,
	@IsNull_absence money,
	@Original_absence money,
	@IsNull_netSalary money,
	@Original_netSalary money,
	@IsNull_bank bit,
	@Original_bank bit,
	@IsNull_bankacc int,
	@Original_bankacc int,
	@IsNull_BRANCH_CODE bigint,
	@Original_BRANCH_CODE bigint,
	@IsNull_SalesAdminFalg bit,
	@Original_SalesAdminFalg bit,
	@IsNull_GroupId bigint,
	@Original_GroupId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMPLOYEE_DATA] WHERE (([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_CIVILID = 1 AND [CIVILID] IS NULL) OR ([CIVILID] = @Original_CIVILID)) AND ([EMPNAME] = @Original_EMPNAME) AND ((@IsNull_EngNAME = 1 AND [EngNAME] IS NULL) OR ([EngNAME] = @Original_EngNAME)) AND ((@IsNull_TITLE = 1 AND [TITLE] IS NULL) OR ([TITLE] = @Original_TITLE)) AND ((@IsNull_EMP_GENDER = 1 AND [EMP_GENDER] IS NULL) OR ([EMP_GENDER] = @Original_EMP_GENDER)) AND ((@IsNull_EMP_BIRTH_DATE = 1 AND [EMP_BIRTH_DATE] IS NULL) OR ([EMP_BIRTH_DATE] = @Original_EMP_BIRTH_DATE)) AND ((@IsNull_EMP_MOBILE = 1 AND [EMP_MOBILE] IS NULL) OR ([EMP_MOBILE] = @Original_EMP_MOBILE)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_EMP_PHONE = 1 AND [EMP_PHONE] IS NULL) OR ([EMP_PHONE] = @Original_EMP_PHONE)) AND ((@IsNull_EMP_EMAIL = 1 AND [EMP_EMAIL] IS NULL) OR ([EMP_EMAIL] = @Original_EMP_EMAIL)) AND ((@IsNull_EMP_HIREDATE = 1 AND [EMP_HIREDATE] IS NULL) OR ([EMP_HIREDATE] = @Original_EMP_HIREDATE)) AND ((@IsNull_Emp_End_HIREDATE = 1 AND [Emp_End_HIREDATE] IS NULL) OR ([Emp_End_HIREDATE] = @Original_Emp_End_HIREDATE)) AND ((@IsNull_EMP_HEALTH_INS_DATE = 1 AND [EMP_HEALTH_INS_DATE] IS NULL) OR ([EMP_HEALTH_INS_DATE] = @Original_EMP_HEALTH_INS_DATE)) AND ((@IsNull_EMP_HEALTH_INS_NUM = 1 AND [EMP_HEALTH_INS_NUM] IS NULL) OR ([EMP_HEALTH_INS_NUM] = @Original_EMP_HEALTH_INS_NUM)) AND ((@IsNull_JOB_CODE = 1 AND [JOB_CODE] IS NULL) OR ([JOB_CODE] = @Original_JOB_CODE)) AND ((@IsNull_JOB_CLS_CODE = 1 AND [JOB_CLS_CODE] IS NULL) OR ([JOB_CLS_CODE] = @Original_JOB_CLS_CODE)) AND ((@IsNull_FILE_NUM = 1 AND [FILE_NUM] IS NULL) OR ([FILE_NUM] = @Original_FILE_NUM)) AND ((@IsNull_DEGREE_CODE = 1 AND [DEGREE_CODE] IS NULL) OR ([DEGREE_CODE] = @Original_DEGREE_CODE)) AND ((@IsNull_REC_TYPE_CODE = 1 AND [REC_TYPE_CODE] IS NULL) OR ([REC_TYPE_CODE] = @Original_REC_TYPE_CODE)) AND ((@IsNull_MARITAL_STATUS_CODE = 1 AND [MARITAL_STATUS_CODE] IS NULL) OR ([MARITAL_STATUS_CODE] = @Original_MARITAL_STATUS_CODE)) AND ((@IsNull_NATIONALITY_CODE = 1 AND [NATIONALITY_CODE] IS NULL) OR ([NATIONALITY_CODE] = @Original_NATIONALITY_CODE)) AND ((@IsNull_GOVER_CODE = 1 AND [GOVER_CODE] IS NULL) OR ([GOVER_CODE] = @Original_GOVER_CODE)) AND ((@IsNull_EMP_VISA = 1 AND [EMP_VISA] IS NULL) OR ([EMP_VISA] = @Original_EMP_VISA)) AND ((@IsNull_Emp_VISA_NO = 1 AND [Emp_VISA_NO] IS NULL) OR ([Emp_VISA_NO] = @Original_Emp_VISA_NO)) AND ((@IsNull_EMP_VISA_END_DATE = 1 AND [EMP_VISA_END_DATE] IS NULL) OR ([EMP_VISA_END_DATE] = @Original_EMP_VISA_END_DATE)) AND ((@IsNull_BANK_CODE = 1 AND [BANK_CODE] IS NULL) OR ([BANK_CODE] = @Original_BANK_CODE)) AND ((@IsNull_AccountID = 1 AND [AccountID] IS NULL) OR ([AccountID] = @Original_AccountID)) AND ((@IsNull_passportNo = 1 AND [passportNo] IS NULL) OR ([passportNo] = @Original_passportNo)) AND ((@IsNull_passtype = 1 AND [passtype] IS NULL) OR ([passtype] = @Original_passtype)) AND ((@IsNull_passdate = 1 AND [passdate] IS NULL) OR ([passdate] = @Original_passdate)) AND ((@IsNull_passplace = 1 AND [passplace] IS NULL) OR ([passplace] = @Original_passplace)) AND ((@IsNull_entrydate = 1 AND [entrydate] IS NULL) OR ([entrydate] = @Original_entrydate)) AND ((@IsNull_BORROWS = 1 AND [BORROWS] IS NULL) OR ([BORROWS] = @Original_BORROWS)) AND ((@IsNull_SALARY = 1 AND [SALARY] IS NULL) OR ([SALARY] = @Original_SALARY)) AND ((@IsNull_ADDED = 1 AND [ADDED] IS NULL) OR ([ADDED] = @Original_ADDED)) AND ((@IsNull_DEDUCED = 1 AND [DEDUCED] IS NULL) OR ([DEDUCED] = @Original_DEDUCED)) AND ((@IsNull_absence = 1 AND [absence] IS NULL) OR ([absence] = @Original_absence)) AND ((@IsNull_netSalary = 1 AND [netSalary] IS NULL) OR ([netSalary] = @Original_netSalary)) AND ((@IsNull_bank = 1 AND [bank] IS NULL) OR ([bank] = @Original_bank)) AND ((@IsNull_bankacc = 1 AND [bankacc] IS NULL) OR ([bankacc] = @Original_bankacc)) AND ((@IsNull_BRANCH_CODE = 1 AND [BRANCH_CODE] IS NULL) OR ([BRANCH_CODE] = @Original_BRANCH_CODE)) AND ((@IsNull_SalesAdminFalg = 1 AND [SalesAdminFalg] IS NULL) OR ([SalesAdminFalg] = @Original_SalesAdminFalg)) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)))
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
	@CIVILID nvarchar(50),
	@EMPNAME nvarchar(200),
	@EngNAME nvarchar(50),
	@TITLE nvarchar(30),
	@EMP_GENDER numeric(1, 0),
	@EMP_BIRTH_DATE datetime,
	@EMP_MOBILE varchar(15),
	@DEPTCODE bigint,
	@ADDRESS nvarchar(60),
	@EMP_PHONE varchar(15),
	@EMP_EMAIL varchar(50),
	@EMP_HIREDATE datetime,
	@Emp_End_HIREDATE smalldatetime,
	@EMP_HEALTH_INS_DATE datetime,
	@EMP_HEALTH_INS_NUM varchar(200),
	@JOB_CODE numeric(5, 0),
	@JOB_CLS_CODE numeric(5, 0),
	@FILE_NUM varchar(20),
	@DEGREE_CODE numeric(5, 0),
	@REC_TYPE_CODE numeric(5, 0),
	@MARITAL_STATUS_CODE numeric(5, 0),
	@NATIONALITY_CODE numeric(5, 0),
	@GOVER_CODE numeric(5, 0),
	@EMP_VISA bit,
	@Emp_VISA_NO nvarchar(50),
	@EMP_VISA_END_DATE datetime,
	@BANK_CODE numeric(5, 0),
	@AccountID numeric(38, 0),
	@NOTES ntext,
	@passportNo nvarchar(50),
	@passtype nvarchar(50),
	@passdate smalldatetime,
	@passplace nvarchar(50),
	@entrydate smalldatetime,
	@BORROWS float,
	@SALARY money,
	@ADDED money,
	@DEDUCED money,
	@absence money,
	@netSalary money,
	@bank bit,
	@bankacc int,
	@BRANCH_CODE bigint,
	@EMP_PIC image,
	@SalesAdminFalg bit,
	@GroupId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMPLOYEE_DATA] ([CIVILID], [EMPNAME], [EngNAME], [TITLE], [EMP_GENDER], [EMP_BIRTH_DATE], [EMP_MOBILE], [DEPTCODE], [ADDRESS], [EMP_PHONE], [EMP_EMAIL], [EMP_HIREDATE], [Emp_End_HIREDATE], [EMP_HEALTH_INS_DATE], [EMP_HEALTH_INS_NUM], [JOB_CODE], [JOB_CLS_CODE], [FILE_NUM], [DEGREE_CODE], [REC_TYPE_CODE], [MARITAL_STATUS_CODE], [NATIONALITY_CODE], [GOVER_CODE], [EMP_VISA], [Emp_VISA_NO], [EMP_VISA_END_DATE], [BANK_CODE], [AccountID], [NOTES], [passportNo], [passtype], [passdate], [passplace], [entrydate], [BORROWS], [SALARY], [ADDED], [DEDUCED], [absence], [netSalary], [bank], [bankacc], [BRANCH_CODE], [EMP_PIC], [SalesAdminFalg], [GroupId]) VALUES (@CIVILID, @EMPNAME, @EngNAME, @TITLE, @EMP_GENDER, @EMP_BIRTH_DATE, @EMP_MOBILE, @DEPTCODE, @ADDRESS, @EMP_PHONE, @EMP_EMAIL, @EMP_HIREDATE, @Emp_End_HIREDATE, @EMP_HEALTH_INS_DATE, @EMP_HEALTH_INS_NUM, @JOB_CODE, @JOB_CLS_CODE, @FILE_NUM, @DEGREE_CODE, @REC_TYPE_CODE, @MARITAL_STATUS_CODE, @NATIONALITY_CODE, @GOVER_CODE, @EMP_VISA, @Emp_VISA_NO, @EMP_VISA_END_DATE, @BANK_CODE, @AccountID, @NOTES, @passportNo, @passtype, @passdate, @passplace, @entrydate, @BORROWS, @SALARY, @ADDED, @DEDUCED, @absence, @netSalary, @bank, @bankacc, @BRANCH_CODE, @EMP_PIC, @SalesAdminFalg, @GroupId);
	
SELECT EMP_CODE, CIVILID, EMPNAME, EngNAME, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_MOBILE, DEPTCODE, ADDRESS, EMP_PHONE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JOB_CODE, JOB_CLS_CODE, FILE_NUM, DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, Emp_VISA_NO, EMP_VISA_END_DATE, BANK_CODE, AccountID, NOTES, passportNo, passtype, passdate, passplace, entrydate, BORROWS, SALARY, ADDED, DEDUCED, absence, netSalary, bank, bankacc, BRANCH_CODE, EMP_PIC, SalesAdminFalg, GroupId FROM PER_EMPLOYEE_DATA WHERE (EMP_CODE = SCOPE_IDENTITY())
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
SELECT     EMP_CODE, CIVILID, EMPNAME, EngNAME, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_MOBILE, DEPTCODE, ADDRESS, EMP_PHONE, 
                      EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JOB_CODE, JOB_CLS_CODE, FILE_NUM, 
                      DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, Emp_VISA_NO, EMP_VISA_END_DATE, 
                      BANK_CODE, AccountID, NOTES, passportNo, passtype, passdate, passplace, entrydate, BORROWS, SALARY, ADDED, DEDUCED, absence, netSalary,
                       bank, bankacc, BRANCH_CODE, EMP_PIC, SalesAdminFalg, GroupId
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

CREATE PROCEDURE dbo.usp_EmpUpdate
(
	@CIVILID nvarchar(50),
	@EMPNAME nvarchar(200),
	@EngNAME nvarchar(50),
	@TITLE nvarchar(30),
	@EMP_GENDER numeric(1, 0),
	@EMP_BIRTH_DATE datetime,
	@EMP_MOBILE varchar(15),
	@DEPTCODE bigint,
	@ADDRESS nvarchar(60),
	@EMP_PHONE varchar(15),
	@EMP_EMAIL varchar(50),
	@EMP_HIREDATE datetime,
	@Emp_End_HIREDATE smalldatetime,
	@EMP_HEALTH_INS_DATE datetime,
	@EMP_HEALTH_INS_NUM varchar(200),
	@JOB_CODE numeric(5, 0),
	@JOB_CLS_CODE numeric(5, 0),
	@FILE_NUM varchar(20),
	@DEGREE_CODE numeric(5, 0),
	@REC_TYPE_CODE numeric(5, 0),
	@MARITAL_STATUS_CODE numeric(5, 0),
	@NATIONALITY_CODE numeric(5, 0),
	@GOVER_CODE numeric(5, 0),
	@EMP_VISA bit,
	@Emp_VISA_NO nvarchar(50),
	@EMP_VISA_END_DATE datetime,
	@BANK_CODE numeric(5, 0),
	@AccountID numeric(38, 0),
	@NOTES ntext,
	@passportNo nvarchar(50),
	@passtype nvarchar(50),
	@passdate smalldatetime,
	@passplace nvarchar(50),
	@entrydate smalldatetime,
	@BORROWS float,
	@SALARY money,
	@ADDED money,
	@DEDUCED money,
	@absence money,
	@netSalary money,
	@bank bit,
	@bankacc int,
	@BRANCH_CODE bigint,
	@EMP_PIC image,
	@SalesAdminFalg bit,
	@GroupId bigint,
	@Original_EMP_CODE bigint,
	@IsNull_CIVILID nvarchar(50),
	@Original_CIVILID nvarchar(50),
	@Original_EMPNAME nvarchar(200),
	@IsNull_EngNAME nvarchar(50),
	@Original_EngNAME nvarchar(50),
	@IsNull_TITLE nvarchar(30),
	@Original_TITLE nvarchar(30),
	@IsNull_EMP_GENDER numeric(1, 0),
	@Original_EMP_GENDER numeric(1, 0),
	@IsNull_EMP_BIRTH_DATE datetime,
	@Original_EMP_BIRTH_DATE datetime,
	@IsNull_EMP_MOBILE varchar(15),
	@Original_EMP_MOBILE varchar(15),
	@IsNull_DEPTCODE bigint,
	@Original_DEPTCODE bigint,
	@IsNull_ADDRESS nvarchar(60),
	@Original_ADDRESS nvarchar(60),
	@IsNull_EMP_PHONE varchar(15),
	@Original_EMP_PHONE varchar(15),
	@IsNull_EMP_EMAIL varchar(50),
	@Original_EMP_EMAIL varchar(50),
	@IsNull_EMP_HIREDATE datetime,
	@Original_EMP_HIREDATE datetime,
	@IsNull_Emp_End_HIREDATE smalldatetime,
	@Original_Emp_End_HIREDATE smalldatetime,
	@IsNull_EMP_HEALTH_INS_DATE datetime,
	@Original_EMP_HEALTH_INS_DATE datetime,
	@IsNull_EMP_HEALTH_INS_NUM varchar(200),
	@Original_EMP_HEALTH_INS_NUM varchar(200),
	@IsNull_JOB_CODE numeric(5, 0),
	@Original_JOB_CODE numeric(5, 0),
	@IsNull_JOB_CLS_CODE numeric(5, 0),
	@Original_JOB_CLS_CODE numeric(5, 0),
	@IsNull_FILE_NUM varchar(20),
	@Original_FILE_NUM varchar(20),
	@IsNull_DEGREE_CODE numeric(5, 0),
	@Original_DEGREE_CODE numeric(5, 0),
	@IsNull_REC_TYPE_CODE numeric(5, 0),
	@Original_REC_TYPE_CODE numeric(5, 0),
	@IsNull_MARITAL_STATUS_CODE numeric(5, 0),
	@Original_MARITAL_STATUS_CODE numeric(5, 0),
	@IsNull_NATIONALITY_CODE numeric(5, 0),
	@Original_NATIONALITY_CODE numeric(5, 0),
	@IsNull_GOVER_CODE numeric(5, 0),
	@Original_GOVER_CODE numeric(5, 0),
	@IsNull_EMP_VISA bit,
	@Original_EMP_VISA bit,
	@IsNull_Emp_VISA_NO nvarchar(50),
	@Original_Emp_VISA_NO nvarchar(50),
	@IsNull_EMP_VISA_END_DATE datetime,
	@Original_EMP_VISA_END_DATE datetime,
	@IsNull_BANK_CODE numeric(5, 0),
	@Original_BANK_CODE numeric(5, 0),
	@IsNull_AccountID numeric(38, 0),
	@Original_AccountID numeric(38, 0),
	@IsNull_passportNo nvarchar(50),
	@Original_passportNo nvarchar(50),
	@IsNull_passtype nvarchar(50),
	@Original_passtype nvarchar(50),
	@IsNull_passdate smalldatetime,
	@Original_passdate smalldatetime,
	@IsNull_passplace nvarchar(50),
	@Original_passplace nvarchar(50),
	@IsNull_entrydate smalldatetime,
	@Original_entrydate smalldatetime,
	@IsNull_BORROWS float,
	@Original_BORROWS float,
	@IsNull_SALARY money,
	@Original_SALARY money,
	@IsNull_ADDED money,
	@Original_ADDED money,
	@IsNull_DEDUCED money,
	@Original_DEDUCED money,
	@IsNull_absence money,
	@Original_absence money,
	@IsNull_netSalary money,
	@Original_netSalary money,
	@IsNull_bank bit,
	@Original_bank bit,
	@IsNull_bankacc int,
	@Original_bankacc int,
	@IsNull_BRANCH_CODE bigint,
	@Original_BRANCH_CODE bigint,
	@IsNull_SalesAdminFalg bit,
	@Original_SalesAdminFalg bit,
	@IsNull_GroupId bigint,
	@Original_GroupId bigint,
	@EMP_CODE bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMPLOYEE_DATA] SET [CIVILID] = @CIVILID, [EMPNAME] = @EMPNAME, [EngNAME] = @EngNAME, [TITLE] = @TITLE, [EMP_GENDER] = @EMP_GENDER, [EMP_BIRTH_DATE] = @EMP_BIRTH_DATE, [EMP_MOBILE] = @EMP_MOBILE, [DEPTCODE] = @DEPTCODE, [ADDRESS] = @ADDRESS, [EMP_PHONE] = @EMP_PHONE, [EMP_EMAIL] = @EMP_EMAIL, [EMP_HIREDATE] = @EMP_HIREDATE, [Emp_End_HIREDATE] = @Emp_End_HIREDATE, [EMP_HEALTH_INS_DATE] = @EMP_HEALTH_INS_DATE, [EMP_HEALTH_INS_NUM] = @EMP_HEALTH_INS_NUM, [JOB_CODE] = @JOB_CODE, [JOB_CLS_CODE] = @JOB_CLS_CODE, [FILE_NUM] = @FILE_NUM, [DEGREE_CODE] = @DEGREE_CODE, [REC_TYPE_CODE] = @REC_TYPE_CODE, [MARITAL_STATUS_CODE] = @MARITAL_STATUS_CODE, [NATIONALITY_CODE] = @NATIONALITY_CODE, [GOVER_CODE] = @GOVER_CODE, [EMP_VISA] = @EMP_VISA, [Emp_VISA_NO] = @Emp_VISA_NO, [EMP_VISA_END_DATE] = @EMP_VISA_END_DATE, [BANK_CODE] = @BANK_CODE, [AccountID] = @AccountID, [NOTES] = @NOTES, [passportNo] = @passportNo, [passtype] = @passtype, [passdate] = @passdate, [passplace] = @passplace, [entrydate] = @entrydate, [BORROWS] = @BORROWS, [SALARY] = @SALARY, [ADDED] = @ADDED, [DEDUCED] = @DEDUCED, [absence] = @absence, [netSalary] = @netSalary, [bank] = @bank, [bankacc] = @bankacc, [BRANCH_CODE] = @BRANCH_CODE, [EMP_PIC] = @EMP_PIC, [SalesAdminFalg] = @SalesAdminFalg, [GroupId] = @GroupId WHERE (([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_CIVILID = 1 AND [CIVILID] IS NULL) OR ([CIVILID] = @Original_CIVILID)) AND ([EMPNAME] = @Original_EMPNAME) AND ((@IsNull_EngNAME = 1 AND [EngNAME] IS NULL) OR ([EngNAME] = @Original_EngNAME)) AND ((@IsNull_TITLE = 1 AND [TITLE] IS NULL) OR ([TITLE] = @Original_TITLE)) AND ((@IsNull_EMP_GENDER = 1 AND [EMP_GENDER] IS NULL) OR ([EMP_GENDER] = @Original_EMP_GENDER)) AND ((@IsNull_EMP_BIRTH_DATE = 1 AND [EMP_BIRTH_DATE] IS NULL) OR ([EMP_BIRTH_DATE] = @Original_EMP_BIRTH_DATE)) AND ((@IsNull_EMP_MOBILE = 1 AND [EMP_MOBILE] IS NULL) OR ([EMP_MOBILE] = @Original_EMP_MOBILE)) AND ((@IsNull_DEPTCODE = 1 AND [DEPTCODE] IS NULL) OR ([DEPTCODE] = @Original_DEPTCODE)) AND ((@IsNull_ADDRESS = 1 AND [ADDRESS] IS NULL) OR ([ADDRESS] = @Original_ADDRESS)) AND ((@IsNull_EMP_PHONE = 1 AND [EMP_PHONE] IS NULL) OR ([EMP_PHONE] = @Original_EMP_PHONE)) AND ((@IsNull_EMP_EMAIL = 1 AND [EMP_EMAIL] IS NULL) OR ([EMP_EMAIL] = @Original_EMP_EMAIL)) AND ((@IsNull_EMP_HIREDATE = 1 AND [EMP_HIREDATE] IS NULL) OR ([EMP_HIREDATE] = @Original_EMP_HIREDATE)) AND ((@IsNull_Emp_End_HIREDATE = 1 AND [Emp_End_HIREDATE] IS NULL) OR ([Emp_End_HIREDATE] = @Original_Emp_End_HIREDATE)) AND ((@IsNull_EMP_HEALTH_INS_DATE = 1 AND [EMP_HEALTH_INS_DATE] IS NULL) OR ([EMP_HEALTH_INS_DATE] = @Original_EMP_HEALTH_INS_DATE)) AND ((@IsNull_EMP_HEALTH_INS_NUM = 1 AND [EMP_HEALTH_INS_NUM] IS NULL) OR ([EMP_HEALTH_INS_NUM] = @Original_EMP_HEALTH_INS_NUM)) AND ((@IsNull_JOB_CODE = 1 AND [JOB_CODE] IS NULL) OR ([JOB_CODE] = @Original_JOB_CODE)) AND ((@IsNull_JOB_CLS_CODE = 1 AND [JOB_CLS_CODE] IS NULL) OR ([JOB_CLS_CODE] = @Original_JOB_CLS_CODE)) AND ((@IsNull_FILE_NUM = 1 AND [FILE_NUM] IS NULL) OR ([FILE_NUM] = @Original_FILE_NUM)) AND ((@IsNull_DEGREE_CODE = 1 AND [DEGREE_CODE] IS NULL) OR ([DEGREE_CODE] = @Original_DEGREE_CODE)) AND ((@IsNull_REC_TYPE_CODE = 1 AND [REC_TYPE_CODE] IS NULL) OR ([REC_TYPE_CODE] = @Original_REC_TYPE_CODE)) AND ((@IsNull_MARITAL_STATUS_CODE = 1 AND [MARITAL_STATUS_CODE] IS NULL) OR ([MARITAL_STATUS_CODE] = @Original_MARITAL_STATUS_CODE)) AND ((@IsNull_NATIONALITY_CODE = 1 AND [NATIONALITY_CODE] IS NULL) OR ([NATIONALITY_CODE] = @Original_NATIONALITY_CODE)) AND ((@IsNull_GOVER_CODE = 1 AND [GOVER_CODE] IS NULL) OR ([GOVER_CODE] = @Original_GOVER_CODE)) AND ((@IsNull_EMP_VISA = 1 AND [EMP_VISA] IS NULL) OR ([EMP_VISA] = @Original_EMP_VISA)) AND ((@IsNull_Emp_VISA_NO = 1 AND [Emp_VISA_NO] IS NULL) OR ([Emp_VISA_NO] = @Original_Emp_VISA_NO)) AND ((@IsNull_EMP_VISA_END_DATE = 1 AND [EMP_VISA_END_DATE] IS NULL) OR ([EMP_VISA_END_DATE] = @Original_EMP_VISA_END_DATE)) AND ((@IsNull_BANK_CODE = 1 AND [BANK_CODE] IS NULL) OR ([BANK_CODE] = @Original_BANK_CODE)) AND ((@IsNull_AccountID = 1 AND [AccountID] IS NULL) OR ([AccountID] = @Original_AccountID)) AND ((@IsNull_passportNo = 1 AND [passportNo] IS NULL) OR ([passportNo] = @Original_passportNo)) AND ((@IsNull_passtype = 1 AND [passtype] IS NULL) OR ([passtype] = @Original_passtype)) AND ((@IsNull_passdate = 1 AND [passdate] IS NULL) OR ([passdate] = @Original_passdate)) AND ((@IsNull_passplace = 1 AND [passplace] IS NULL) OR ([passplace] = @Original_passplace)) AND ((@IsNull_entrydate = 1 AND [entrydate] IS NULL) OR ([entrydate] = @Original_entrydate)) AND ((@IsNull_BORROWS = 1 AND [BORROWS] IS NULL) OR ([BORROWS] = @Original_BORROWS)) AND ((@IsNull_SALARY = 1 AND [SALARY] IS NULL) OR ([SALARY] = @Original_SALARY)) AND ((@IsNull_ADDED = 1 AND [ADDED] IS NULL) OR ([ADDED] = @Original_ADDED)) AND ((@IsNull_DEDUCED = 1 AND [DEDUCED] IS NULL) OR ([DEDUCED] = @Original_DEDUCED)) AND ((@IsNull_absence = 1 AND [absence] IS NULL) OR ([absence] = @Original_absence)) AND ((@IsNull_netSalary = 1 AND [netSalary] IS NULL) OR ([netSalary] = @Original_netSalary)) AND ((@IsNull_bank = 1 AND [bank] IS NULL) OR ([bank] = @Original_bank)) AND ((@IsNull_bankacc = 1 AND [bankacc] IS NULL) OR ([bankacc] = @Original_bankacc)) AND ((@IsNull_BRANCH_CODE = 1 AND [BRANCH_CODE] IS NULL) OR ([BRANCH_CODE] = @Original_BRANCH_CODE)) AND ((@IsNull_SalesAdminFalg = 1 AND [SalesAdminFalg] IS NULL) OR ([SalesAdminFalg] = @Original_SalesAdminFalg)) AND ((@IsNull_GroupId = 1 AND [GroupId] IS NULL) OR ([GroupId] = @Original_GroupId)));
	
SELECT EMP_CODE, CIVILID, EMPNAME, EngNAME, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_MOBILE, DEPTCODE, ADDRESS, EMP_PHONE, EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JOB_CODE, JOB_CLS_CODE, FILE_NUM, DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, Emp_VISA_NO, EMP_VISA_END_DATE, BANK_CODE, AccountID, NOTES, passportNo, passtype, passdate, passplace, entrydate, BORROWS, SALARY, ADDED, DEDUCED, absence, netSalary, bank, bankacc, BRANCH_CODE, EMP_PIC, SalesAdminFalg, GroupId FROM PER_EMPLOYEE_DATA WHERE (EMP_CODE = @EMP_CODE)
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
	@Original_BoxAccountId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Emp_Groups] WHERE (([GroupId] = @Original_GroupId) AND ([GroupName] = @Original_GroupName) AND ((@IsNull_NutalAttendance = 1 AND [NutalAttendance] IS NULL) OR ([NutalAttendance] = @Original_NutalAttendance)) AND ((@IsNull_SalaryCul = 1 AND [SalaryCul] IS NULL) OR ([SalaryCul] = @Original_SalaryCul)) AND ((@IsNull_DefDate = 1 AND [DefDate] IS NULL) OR ([DefDate] = @Original_DefDate)) AND ((@IsNull_WorkHour = 1 AND [WorkHour] IS NULL) OR ([WorkHour] = @Original_WorkHour)) AND ((@IsNull_VactionNum = 1 AND [VactionNum] IS NULL) OR ([VactionNum] = @Original_VactionNum)) AND ((@IsNull_AbsenceHourPercentage = 1 AND [AbsenceHourPercentage] IS NULL) OR ([AbsenceHourPercentage] = @Original_AbsenceHourPercentage)) AND ((@IsNull_AdditionPercentage = 1 AND [AdditionPercentage] IS NULL) OR ([AdditionPercentage] = @Original_AdditionPercentage)) AND ((@IsNull_HourInVaction = 1 AND [HourInVaction] IS NULL) OR ([HourInVaction] = @Original_HourInVaction)) AND ((@IsNull_AbsenceDayPercentage = 1 AND [AbsenceDayPercentage] IS NULL) OR ([AbsenceDayPercentage] = @Original_AbsenceDayPercentage)) AND ((@IsNull_ApplyVactionDays = 1 AND [ApplyVactionDays] IS NULL) OR ([ApplyVactionDays] = @Original_ApplyVactionDays)) AND ((@IsNull_SalaryAccountId = 1 AND [SalaryAccountId] IS NULL) OR ([SalaryAccountId] = @Original_SalaryAccountId)) AND ((@IsNull_TaxAccountId = 1 AND [TaxAccountId] IS NULL) OR ([TaxAccountId] = @Original_TaxAccountId)) AND ((@IsNull_LoanAccountId = 1 AND [LoanAccountId] IS NULL) OR ([LoanAccountId] = @Original_LoanAccountId)) AND ((@IsNull_BoxAccountId = 1 AND [BoxAccountId] IS NULL) OR ([BoxAccountId] = @Original_BoxAccountId)))
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
	@BoxAccountId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Emp_Groups] ([GroupName], [NutalAttendance], [SalaryCul], [DefDate], [WorkHour], [VactionNum], [AbsenceHourPercentage], [AdditionPercentage], [HourInVaction], [AbsenceDayPercentage], [ApplyVactionDays], [SalaryAccountId], [TaxAccountId], [LoanAccountId], [BoxAccountId]) VALUES (@GroupName, @NutalAttendance, @SalaryCul, @DefDate, @WorkHour, @VactionNum, @AbsenceHourPercentage, @AdditionPercentage, @HourInVaction, @AbsenceDayPercentage, @ApplyVactionDays, @SalaryAccountId, @TaxAccountId, @LoanAccountId, @BoxAccountId);
	
SELECT GroupId, GroupName, NutalAttendance, SalaryCul, DefDate, WorkHour, VactionNum, AbsenceHourPercentage, AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId FROM Emp_Groups WHERE (GroupId = SCOPE_IDENTITY())
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
                      AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId
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
	@GroupId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Emp_Groups] SET [GroupName] = @GroupName, [NutalAttendance] = @NutalAttendance, [SalaryCul] = @SalaryCul, [DefDate] = @DefDate, [WorkHour] = @WorkHour, [VactionNum] = @VactionNum, [AbsenceHourPercentage] = @AbsenceHourPercentage, [AdditionPercentage] = @AdditionPercentage, [HourInVaction] = @HourInVaction, [AbsenceDayPercentage] = @AbsenceDayPercentage, [ApplyVactionDays] = @ApplyVactionDays, [SalaryAccountId] = @SalaryAccountId, [TaxAccountId] = @TaxAccountId, [LoanAccountId] = @LoanAccountId, [BoxAccountId] = @BoxAccountId WHERE (([GroupId] = @Original_GroupId) AND ([GroupName] = @Original_GroupName) AND ((@IsNull_NutalAttendance = 1 AND [NutalAttendance] IS NULL) OR ([NutalAttendance] = @Original_NutalAttendance)) AND ((@IsNull_SalaryCul = 1 AND [SalaryCul] IS NULL) OR ([SalaryCul] = @Original_SalaryCul)) AND ((@IsNull_DefDate = 1 AND [DefDate] IS NULL) OR ([DefDate] = @Original_DefDate)) AND ((@IsNull_WorkHour = 1 AND [WorkHour] IS NULL) OR ([WorkHour] = @Original_WorkHour)) AND ((@IsNull_VactionNum = 1 AND [VactionNum] IS NULL) OR ([VactionNum] = @Original_VactionNum)) AND ((@IsNull_AbsenceHourPercentage = 1 AND [AbsenceHourPercentage] IS NULL) OR ([AbsenceHourPercentage] = @Original_AbsenceHourPercentage)) AND ((@IsNull_AdditionPercentage = 1 AND [AdditionPercentage] IS NULL) OR ([AdditionPercentage] = @Original_AdditionPercentage)) AND ((@IsNull_HourInVaction = 1 AND [HourInVaction] IS NULL) OR ([HourInVaction] = @Original_HourInVaction)) AND ((@IsNull_AbsenceDayPercentage = 1 AND [AbsenceDayPercentage] IS NULL) OR ([AbsenceDayPercentage] = @Original_AbsenceDayPercentage)) AND ((@IsNull_ApplyVactionDays = 1 AND [ApplyVactionDays] IS NULL) OR ([ApplyVactionDays] = @Original_ApplyVactionDays)) AND ((@IsNull_SalaryAccountId = 1 AND [SalaryAccountId] IS NULL) OR ([SalaryAccountId] = @Original_SalaryAccountId)) AND ((@IsNull_TaxAccountId = 1 AND [TaxAccountId] IS NULL) OR ([TaxAccountId] = @Original_TaxAccountId)) AND ((@IsNull_LoanAccountId = 1 AND [LoanAccountId] IS NULL) OR ([LoanAccountId] = @Original_LoanAccountId)) AND ((@IsNull_BoxAccountId = 1 AND [BoxAccountId] IS NULL) OR ([BoxAccountId] = @Original_BoxAccountId)));
	
SELECT GroupId, GroupName, NutalAttendance, SalaryCul, DefDate, WorkHour, VactionNum, AbsenceHourPercentage, AdditionPercentage, HourInVaction, AbsenceDayPercentage, ApplyVactionDays, SalaryAccountId, TaxAccountId, LoanAccountId, BoxAccountId FROM Emp_Groups WHERE (GroupId = @GroupId)
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


CREATE PROCEDURE dbo.usp_InvProductsByInvId
(
	@InvId bigint
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, 
                      PRODUCTBRAND
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
                      CostId, ChequeFlag, SUP_CUST_ID, SUP_CUST_FNAME, UNITDESC, ProductName,  LastSalePrice, LastBuyPrice,QUANTITY,PRODUCTCODE,PHONE1
FROM         InvProductsMoveVIEW
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
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
Qty*Price as totPrice
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
	@ToDate datetime
)
AS
	SET NOCOUNT ON;
SELECT     Inv_Product_Id, InvId, ProductId, UnitId, StoreId, Discount, ReoderFlag, InvCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, 
                      BranchId, InvType, EmpId, PaymentValue, PaymentDate, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, Qty, Price, TotalPrice, VaildDate, 
                      CostId, ChequeFlag, SUP_CUST_ID, SUP_CUST_FNAME, UNITDESC, ProductName,  LastSalePrice, LastBuyPrice, LastCostPrice,QUANTITY
FROM         InvProductsMoveVIEW
where  (ProductId= @ProductId OR @ProductId IS NULL) AND  (BranchId= @BranchId OR @BranchId IS NULL) and  (StoreId= @StoreId OR @StoreId IS NULL)  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)
 and  (InvDate<= @ToDate OR @ToDate IS NULL)
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
	@Original_PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Inv_Products] WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)))
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
	@PRODUCTBRAND nvarchar(30)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Inv_Products] ([InvId], [ProductId], [UnitId], [Qty], [ReorderQty], [Price], [StoreId], [Discount], [VaildDate], [TotalPrice], [ReoderFlag], [TotReOderPrice], [PRODUCTBRAND]) VALUES (@InvId, @ProductId, @UnitId, @Qty, @ReorderQty, @Price, @StoreId, @Discount, @VaildDate, @TotalPrice, @ReoderFlag, @TotReOderPrice, @PRODUCTBRAND);
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND FROM Inv_Products WHERE (Inv_Product_Id = SCOPE_IDENTITY())
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
                      PRODUCTBRAND
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
UPDATE [Inv_Products] SET [InvId] = @InvId, [ProductId] = @ProductId, [UnitId] = @UnitId, [Qty] = @Qty, [ReorderQty] = @ReorderQty, [Price] = @Price, [StoreId] = @StoreId, [Discount] = @Discount, [VaildDate] = @VaildDate, [TotalPrice] = @TotalPrice, [ReoderFlag] = @ReoderFlag, [TotReOderPrice] = @TotReOderPrice, [PRODUCTBRAND] = @PRODUCTBRAND WHERE (([Inv_Product_Id] = @Original_Inv_Product_Id) AND ([InvId] = @Original_InvId) AND ([ProductId] = @Original_ProductId) AND ([UnitId] = @Original_UnitId) AND ([Qty] = @Original_Qty) AND ((@IsNull_ReorderQty = 1 AND [ReorderQty] IS NULL) OR ([ReorderQty] = @Original_ReorderQty)) AND ([Price] = @Original_Price) AND ([StoreId] = @Original_StoreId) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_VaildDate = 1 AND [VaildDate] IS NULL) OR ([VaildDate] = @Original_VaildDate)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ReoderFlag = 1 AND [ReoderFlag] IS NULL) OR ([ReoderFlag] = @Original_ReoderFlag)) AND ((@IsNull_TotReOderPrice = 1 AND [TotReOderPrice] IS NULL) OR ([TotReOderPrice] = @Original_TotReOderPrice)) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)));
	
SELECT Inv_Product_Id, InvId, ProductId, UnitId, Qty, ReorderQty, Price, StoreId, Discount, VaildDate, TotalPrice, ReoderFlag, TotReOderPrice, PRODUCTBRAND FROM Inv_Products WHERE (Inv_Product_Id = @Inv_Product_Id)
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
	@ToDate datetime
)
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID,SUP_CUST_FNAME, InvoiceView.CollectValue
FROM         InvoiceView
WHERE      (BranchId= @BranchId OR @BranchId IS NULL)  and  (SUP_CUST_ID= @SUP_CUST_ID OR @SUP_CUST_ID IS NULL)  
and  (InvDate>= @FromDate OR @FromDate IS NULL)  and  (InvDate<= @ToDate OR @ToDate IS NULL)


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
WHERE     (Cust_Sup_accid = @ACCOUNTID or @ACCOUNTID  IS NULL ) AND (BranchId = @BranchId or @BranchId is null ) AND (invDate >= @FromDate or @FromDate is null ) AND (invDate <= @ToDate or @ToDate is null)
and    invdate =          (SELECT     MAX(invdate)
                             FROM         InvProductsVIEW d
                             WHERE     d .cust_sup_Accid =InvoiceView.cust_sup_Accid
  and (ProductId = @ProductId or @ProductId  IS NULL) and (StoreId = @StoreId or @StoreId  IS NULL)  group by d .cust_sup_Accid) or invdate is null and ACCOUNTID>4
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

CREATE PROCEDURE dbo.usp_InvoicesDelete
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
	@Original_CustId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [invoices] WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)))
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.usp_InvoicesInsert
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
	@CustId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [invoices] ([InvCode], [RecoderCode], [InvDate], [Cust_Sup_Accid], [InvAccid], [PaymentType], [PaymentAccid], [BranchId], [InvType], [EmpId], [PaymentValue], [PaymentDate], [Notes], [invTotal], [Discount], [InvTotalNet], [InvPayment], [InvRemain], [ReferID], [PaymentCost], [ChequeNo], [ChequeFlag], [TotalAddCost], [TotalReoder], [TotalReoderNet], [CostId], [SUP_CUST_ID], [PayFinish], [CollectValue], [KeyNetValue], [VisaValue], [MasterValue], [ChequeValue], [OtherValue], [CustId]) VALUES (@InvCode, @RecoderCode, @InvDate, @Cust_Sup_Accid, @InvAccid, @PaymentType, @PaymentAccid, @BranchId, @InvType, @EmpId, @PaymentValue, @PaymentDate, @Notes, @invTotal, @Discount, @InvTotalNet, @InvPayment, @InvRemain, @ReferID, @PaymentCost, @ChequeNo, @ChequeFlag, @TotalAddCost, @TotalReoder, @TotalReoderNet, @CostId, @SUP_CUST_ID, @PayFinish, @CollectValue, @KeyNetValue, @VisaValue, @MasterValue, @ChequeValue, @OtherValue, @CustId);
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId FROM invoices WHERE (InvId = SCOPE_IDENTITY())
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.usp_InvoicesSelect
AS
	SET NOCOUNT ON;
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, 
                      CustId
FROM         invoices
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.usp_InvoicesUpdate
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
	@InvId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [invoices] SET [InvCode] = @InvCode, [RecoderCode] = @RecoderCode, [InvDate] = @InvDate, [Cust_Sup_Accid] = @Cust_Sup_Accid, [InvAccid] = @InvAccid, [PaymentType] = @PaymentType, [PaymentAccid] = @PaymentAccid, [BranchId] = @BranchId, [InvType] = @InvType, [EmpId] = @EmpId, [PaymentValue] = @PaymentValue, [PaymentDate] = @PaymentDate, [Notes] = @Notes, [invTotal] = @invTotal, [Discount] = @Discount, [InvTotalNet] = @InvTotalNet, [InvPayment] = @InvPayment, [InvRemain] = @InvRemain, [ReferID] = @ReferID, [PaymentCost] = @PaymentCost, [ChequeNo] = @ChequeNo, [ChequeFlag] = @ChequeFlag, [TotalAddCost] = @TotalAddCost, [TotalReoder] = @TotalReoder, [TotalReoderNet] = @TotalReoderNet, [CostId] = @CostId, [SUP_CUST_ID] = @SUP_CUST_ID, [PayFinish] = @PayFinish, [CollectValue] = @CollectValue, [KeyNetValue] = @KeyNetValue, [VisaValue] = @VisaValue, [MasterValue] = @MasterValue, [ChequeValue] = @ChequeValue, [OtherValue] = @OtherValue, [CustId] = @CustId WHERE (([InvId] = @Original_InvId) AND ([InvCode] = @Original_InvCode) AND ((@IsNull_RecoderCode = 1 AND [RecoderCode] IS NULL) OR ([RecoderCode] = @Original_RecoderCode)) AND ((@IsNull_InvDate = 1 AND [InvDate] IS NULL) OR ([InvDate] = @Original_InvDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_InvAccid = 1 AND [InvAccid] IS NULL) OR ([InvAccid] = @Original_InvAccid)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)) AND ((@IsNull_PaymentAccid = 1 AND [PaymentAccid] IS NULL) OR ([PaymentAccid] = @Original_PaymentAccid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_PaymentValue = 1 AND [PaymentValue] IS NULL) OR ([PaymentValue] = @Original_PaymentValue)) AND ((@IsNull_PaymentDate = 1 AND [PaymentDate] IS NULL) OR ([PaymentDate] = @Original_PaymentDate)) AND ((@IsNull_invTotal = 1 AND [invTotal] IS NULL) OR ([invTotal] = @Original_invTotal)) AND ((@IsNull_Discount = 1 AND [Discount] IS NULL) OR ([Discount] = @Original_Discount)) AND ((@IsNull_InvTotalNet = 1 AND [InvTotalNet] IS NULL) OR ([InvTotalNet] = @Original_InvTotalNet)) AND ((@IsNull_InvPayment = 1 AND [InvPayment] IS NULL) OR ([InvPayment] = @Original_InvPayment)) AND ((@IsNull_InvRemain = 1 AND [InvRemain] IS NULL) OR ([InvRemain] = @Original_InvRemain)) AND ((@IsNull_ReferID = 1 AND [ReferID] IS NULL) OR ([ReferID] = @Original_ReferID)) AND ((@IsNull_PaymentCost = 1 AND [PaymentCost] IS NULL) OR ([PaymentCost] = @Original_PaymentCost)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_ChequeFlag = 1 AND [ChequeFlag] IS NULL) OR ([ChequeFlag] = @Original_ChequeFlag)) AND ((@IsNull_TotalAddCost = 1 AND [TotalAddCost] IS NULL) OR ([TotalAddCost] = @Original_TotalAddCost)) AND ((@IsNull_TotalReoder = 1 AND [TotalReoder] IS NULL) OR ([TotalReoder] = @Original_TotalReoder)) AND ((@IsNull_TotalReoderNet = 1 AND [TotalReoderNet] IS NULL) OR ([TotalReoderNet] = @Original_TotalReoderNet)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)) AND ((@IsNull_PayFinish = 1 AND [PayFinish] IS NULL) OR ([PayFinish] = @Original_PayFinish)) AND ((@IsNull_CollectValue = 1 AND [CollectValue] IS NULL) OR ([CollectValue] = @Original_CollectValue)) AND ((@IsNull_KeyNetValue = 1 AND [KeyNetValue] IS NULL) OR ([KeyNetValue] = @Original_KeyNetValue)) AND ((@IsNull_VisaValue = 1 AND [VisaValue] IS NULL) OR ([VisaValue] = @Original_VisaValue)) AND ((@IsNull_MasterValue = 1 AND [MasterValue] IS NULL) OR ([MasterValue] = @Original_MasterValue)) AND ((@IsNull_ChequeValue = 1 AND [ChequeValue] IS NULL) OR ([ChequeValue] = @Original_ChequeValue)) AND ((@IsNull_OtherValue = 1 AND [OtherValue] IS NULL) OR ([OtherValue] = @Original_OtherValue)) AND ((@IsNull_CustId = 1 AND [CustId] IS NULL) OR ([CustId] = @Original_CustId)));
	
SELECT InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue, KeyNetValue, VisaValue, MasterValue, ChequeValue, OtherValue, CustId FROM invoices WHERE (InvId = @InvId)
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
	@Original_SUP_CUST_ID bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [ORDERS] WHERE (([OrderId] = @Original_OrderId) AND ((@IsNull_OrderCode = 1 AND [OrderCode] IS NULL) OR ([OrderCode] = @Original_OrderCode)) AND ((@IsNull_OrderDate = 1 AND [OrderDate] IS NULL) OR ([OrderDate] = @Original_OrderDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)))
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
	@SUP_CUST_ID bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [ORDERS] ([OrderCode], [OrderDate], [Cust_Sup_Accid], [BranchId], [InvType], [EmpId], [Notes], [SUP_CUST_ID]) VALUES (@OrderCode, @OrderDate, @Cust_Sup_Accid, @BranchId, @InvType, @EmpId, @Notes, @SUP_CUST_ID);
	
SELECT OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID FROM ORDERS WHERE (OrderId = SCOPE_IDENTITY())
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
SELECT     OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID
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
	@OrderId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [ORDERS] SET [OrderCode] = @OrderCode, [OrderDate] = @OrderDate, [Cust_Sup_Accid] = @Cust_Sup_Accid, [BranchId] = @BranchId, [InvType] = @InvType, [EmpId] = @EmpId, [Notes] = @Notes, [SUP_CUST_ID] = @SUP_CUST_ID WHERE (([OrderId] = @Original_OrderId) AND ((@IsNull_OrderCode = 1 AND [OrderCode] IS NULL) OR ([OrderCode] = @Original_OrderCode)) AND ((@IsNull_OrderDate = 1 AND [OrderDate] IS NULL) OR ([OrderDate] = @Original_OrderDate)) AND ((@IsNull_Cust_Sup_Accid = 1 AND [Cust_Sup_Accid] IS NULL) OR ([Cust_Sup_Accid] = @Original_Cust_Sup_Accid)) AND ((@IsNull_BranchId = 1 AND [BranchId] IS NULL) OR ([BranchId] = @Original_BranchId)) AND ((@IsNull_InvType = 1 AND [InvType] IS NULL) OR ([InvType] = @Original_InvType)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_SUP_CUST_ID = 1 AND [SUP_CUST_ID] IS NULL) OR ([SUP_CUST_ID] = @Original_SUP_CUST_ID)));
	
SELECT OrderId, OrderCode, OrderDate, Cust_Sup_Accid, BranchId, InvType, EmpId, Notes, SUP_CUST_ID FROM ORDERS WHERE (OrderId = @OrderId)
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
	@Original_PEN_CODE numeric(5, 0),
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
	@PEN_CODE numeric(5, 0),
	@PEN_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [CDE_PER_PENALTY] ([PEN_CODE], [PEN_DESC]) VALUES (@PEN_CODE, @PEN_DESC);
	
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
	@PEN_CODE numeric(5, 0),
	@PEN_DESC varchar(200),
	@Original_PEN_CODE numeric(5, 0),
	@Original_PEN_DESC varchar(200)
)
AS
	SET NOCOUNT OFF;
UPDATE [CDE_PER_PENALTY] SET [PEN_CODE] = @PEN_CODE, [PEN_DESC] = @PEN_DESC WHERE (([PEN_CODE] = @Original_PEN_CODE) AND ([PEN_DESC] = @Original_PEN_DESC));
	
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
	@IsNull_EMP_CODE bigint,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_AMOUNT money,
	@Original_AMOUNT money,
	@IsNull_DISCOUNT_DATE smalldatetime,
	@Original_DISCOUNT_DATE smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PER_EMP_Allowance] WHERE (([AllowanceID] = @Original_AllowanceID) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)))
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
	@DES ntext
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PER_EMP_Allowance] ([EMP_CODE], [YEAR_CODE], [MONTH_CODE], [AMOUNT], [DISCOUNT_DATE], [DES]) VALUES (@EMP_CODE, @YEAR_CODE, @MONTH_CODE, @AMOUNT, @DISCOUNT_DATE, @DES);
	
SELECT AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES FROM PER_EMP_Allowance WHERE (AllowanceID = SCOPE_IDENTITY())
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
SELECT     AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES
FROM         PER_EMP_Allowance
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
	@DES ntext,
	@Original_AllowanceID int,
	@IsNull_EMP_CODE bigint,
	@Original_EMP_CODE bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_AMOUNT money,
	@Original_AMOUNT money,
	@IsNull_DISCOUNT_DATE smalldatetime,
	@Original_DISCOUNT_DATE smalldatetime,
	@AllowanceID int
)
AS
	SET NOCOUNT OFF;
UPDATE [PER_EMP_Allowance] SET [EMP_CODE] = @EMP_CODE, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [AMOUNT] = @AMOUNT, [DISCOUNT_DATE] = @DISCOUNT_DATE, [DES] = @DES WHERE (([AllowanceID] = @Original_AllowanceID) AND ((@IsNull_EMP_CODE = 1 AND [EMP_CODE] IS NULL) OR ([EMP_CODE] = @Original_EMP_CODE)) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_AMOUNT = 1 AND [AMOUNT] IS NULL) OR ([AMOUNT] = @Original_AMOUNT)) AND ((@IsNull_DISCOUNT_DATE = 1 AND [DISCOUNT_DATE] IS NULL) OR ([DISCOUNT_DATE] = @Original_DISCOUNT_DATE)));
	
SELECT AllowanceID, EMP_CODE, YEAR_CODE, MONTH_CODE, AMOUNT, DISCOUNT_DATE, DES FROM PER_EMP_Allowance WHERE (AllowanceID = @AllowanceID)
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
	@Original_MONTH_CODE bigint,
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
	@Original_CALCULATION_AMOUNT money
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRL_EMP_SAL_CALCULATION] WHERE (([CalID] = @Original_CalID) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_BasicAmount = 1 AND [BasicAmount] IS NULL) OR ([BasicAmount] = @Original_BasicAmount)) AND ((@IsNull_DiscountAmount = 1 AND [DiscountAmount] IS NULL) OR ([DiscountAmount] = @Original_DiscountAmount)) AND ((@IsNull_AbseneceAmount = 1 AND [AbseneceAmount] IS NULL) OR ([AbseneceAmount] = @Original_AbseneceAmount)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_AllowanceAmount = 1 AND [AllowanceAmount] IS NULL) OR ([AllowanceAmount] = @Original_AllowanceAmount)) AND ([CALCULATION_AMOUNT] = @Original_CALCULATION_AMOUNT))
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
	@MONTH_CODE bigint,
	@YEAR_CODE int,
	@EMP_CODE bigint,
	@BasicAmount money,
	@DiscountAmount money,
	@AbseneceAmount money,
	@LoanAmount money,
	@AllowanceAmount money,
	@CALCULATION_AMOUNT money
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRL_EMP_SAL_CALCULATION] ([MONTH_CODE], [YEAR_CODE], [EMP_CODE], [BasicAmount], [DiscountAmount], [AbseneceAmount], [LoanAmount], [AllowanceAmount], [CALCULATION_AMOUNT]) VALUES (@MONTH_CODE, @YEAR_CODE, @EMP_CODE, @BasicAmount, @DiscountAmount, @AbseneceAmount, @LoanAmount, @AllowanceAmount, @CALCULATION_AMOUNT);
	
SELECT CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, CALCULATION_AMOUNT FROM PRL_EMP_SAL_CALCULATION WHERE (CalID = SCOPE_IDENTITY())
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
SELECT     CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, 
                      CALCULATION_AMOUNT
FROM         PRL_EMP_SAL_CALCULATION
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
	@MONTH_CODE bigint,
	@YEAR_CODE int,
	@EMP_CODE bigint,
	@BasicAmount money,
	@DiscountAmount money,
	@AbseneceAmount money,
	@LoanAmount money,
	@AllowanceAmount money,
	@CALCULATION_AMOUNT money,
	@Original_CalID bigint,
	@Original_MONTH_CODE bigint,
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
	@Original_CALCULATION_AMOUNT money,
	@CalID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRL_EMP_SAL_CALCULATION] SET [MONTH_CODE] = @MONTH_CODE, [YEAR_CODE] = @YEAR_CODE, [EMP_CODE] = @EMP_CODE, [BasicAmount] = @BasicAmount, [DiscountAmount] = @DiscountAmount, [AbseneceAmount] = @AbseneceAmount, [LoanAmount] = @LoanAmount, [AllowanceAmount] = @AllowanceAmount, [CALCULATION_AMOUNT] = @CALCULATION_AMOUNT WHERE (([CalID] = @Original_CalID) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([EMP_CODE] = @Original_EMP_CODE) AND ((@IsNull_BasicAmount = 1 AND [BasicAmount] IS NULL) OR ([BasicAmount] = @Original_BasicAmount)) AND ((@IsNull_DiscountAmount = 1 AND [DiscountAmount] IS NULL) OR ([DiscountAmount] = @Original_DiscountAmount)) AND ((@IsNull_AbseneceAmount = 1 AND [AbseneceAmount] IS NULL) OR ([AbseneceAmount] = @Original_AbseneceAmount)) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_AllowanceAmount = 1 AND [AllowanceAmount] IS NULL) OR ([AllowanceAmount] = @Original_AllowanceAmount)) AND ([CALCULATION_AMOUNT] = @Original_CALCULATION_AMOUNT));
	
SELECT CalID, MONTH_CODE, YEAR_CODE, EMP_CODE, BasicAmount, DiscountAmount, AbseneceAmount, LoanAmount, AllowanceAmount, CALCULATION_AMOUNT FROM PRL_EMP_SAL_CALCULATION WHERE (CalID = @CalID)
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
	@IsNull_EnglishName nvarchar(50),
	@Original_EnglishName nvarchar(50),
	@Original_PRODUCTCODE nvarchar(50),
	@IsNull_ParentProductId bigint,
	@Original_ParentProductId bigint,
	@IsNull_Root bit,
	@Original_Root bit,
	@IsNull_ProductTypeID bigint,
	@Original_ProductTypeID bigint,
	@IsNull_SERIALNO nvarchar(20),
	@Original_SERIALNO nvarchar(20),
	@IsNull_SUPPLIERID bigint,
	@Original_SUPPLIERID bigint,
	@IsNull_CATEGORYID int,
	@Original_CATEGORYID int,
	@IsNull_PWeight nvarchar(50),
	@Original_PWeight nvarchar(50),
	@IsNull_PSize nvarchar(50),
	@Original_PSize nvarchar(50),
	@IsNull_PColor nvarchar(50),
	@Original_PColor nvarchar(50),
	@IsNull_PVolume nvarchar(50),
	@Original_PVolume nvarchar(50),
	@IsNull_VALIDITY smalldatetime,
	@Original_VALIDITY smalldatetime,
	@IsNull_PriceRule nvarchar(30),
	@Original_PriceRule nvarchar(30),
	@IsNull_PriceFromDate smalldatetime,
	@Original_PriceFromDate smalldatetime,
	@IsNull_PriceToDate smalldatetime,
	@Original_PriceToDate smalldatetime,
	@IsNull_OfferTypeID int,
	@Original_OfferTypeID int,
	@IsNull_OfferFromDate smalldatetime,
	@Original_OfferFromDate smalldatetime,
	@IsNull_OfferToDate smalldatetime,
	@Original_OfferToDate smalldatetime,
	@IsNull_OfferProductId bigint,
	@Original_OfferProductId bigint,
	@IsNull_OfferUnit int,
	@Original_OfferUnit int,
	@IsNull_UNITPRICECOST money,
	@Original_UNITPRICECOST money,
	@IsNull_UNITPRICESALES money,
	@Original_UNITPRICESALES money,
	@IsNull_BUYDATE smalldatetime,
	@Original_BUYDATE smalldatetime,
	@IsNull_THRESHOLDINSTOCK smallint,
	@Original_THRESHOLDINSTOCK smallint,
	@IsNull_DISCONTINUED bit,
	@Original_DISCONTINUED bit,
	@IsNull_REORDERLEVEL smallint,
	@Original_REORDERLEVEL smallint,
	@IsNull_STOCKNO bigint,
	@Original_STOCKNO bigint,
	@IsNull_RECEIVERID int,
	@Original_RECEIVERID int,
	@IsNull_SHAPE nvarchar(10),
	@Original_SHAPE nvarchar(10),
	@IsNull_QUANTITYPERUNIT real,
	@Original_QUANTITYPERUNIT real,
	@IsNull_complexproduct bit,
	@Original_complexproduct bit,
	@IsNull_UNITSINSTOCK float,
	@Original_UNITSINSTOCK float,
	@IsNull_ACCOUNTID int,
	@Original_ACCOUNTID int,
	@IsNull_QUANTITYINUNIT float,
	@Original_QUANTITYINUNIT float,
	@IsNull_initialsmallquantity float,
	@Original_initialsmallquantity float,
	@IsNull_initialprice money,
	@Original_initialprice money,
	@IsNull_initiallargequantity float,
	@Original_initiallargequantity float,
	@IsNull_serviceproduct bit,
	@Original_serviceproduct bit,
	@IsNull_profit real,
	@Original_profit real,
	@IsNull_forcurrency money,
	@Original_forcurrency money,
	@IsNull_minprice money,
	@Original_minprice money,
	@IsNull_shape2 nvarchar(20),
	@Original_shape2 nvarchar(20),
	@IsNull_SerialCode bigint,
	@Original_SerialCode bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PRODUCTS] WHERE (([PRODUCTID] = @Original_PRODUCTID) AND ([productname] = @Original_productname) AND ((@IsNull_EnglishName = 1 AND [EnglishName] IS NULL) OR ([EnglishName] = @Original_EnglishName)) AND ([PRODUCTCODE] = @Original_PRODUCTCODE) AND ((@IsNull_ParentProductId = 1 AND [ParentProductId] IS NULL) OR ([ParentProductId] = @Original_ParentProductId)) AND ((@IsNull_Root = 1 AND [Root] IS NULL) OR ([Root] = @Original_Root)) AND ((@IsNull_ProductTypeID = 1 AND [ProductTypeID] IS NULL) OR ([ProductTypeID] = @Original_ProductTypeID)) AND ((@IsNull_SERIALNO = 1 AND [SERIALNO] IS NULL) OR ([SERIALNO] = @Original_SERIALNO)) AND ((@IsNull_SUPPLIERID = 1 AND [SUPPLIERID] IS NULL) OR ([SUPPLIERID] = @Original_SUPPLIERID)) AND ((@IsNull_CATEGORYID = 1 AND [CATEGORYID] IS NULL) OR ([CATEGORYID] = @Original_CATEGORYID)) AND ((@IsNull_PWeight = 1 AND [PWeight] IS NULL) OR ([PWeight] = @Original_PWeight)) AND ((@IsNull_PSize = 1 AND [PSize] IS NULL) OR ([PSize] = @Original_PSize)) AND ((@IsNull_PColor = 1 AND [PColor] IS NULL) OR ([PColor] = @Original_PColor)) AND ((@IsNull_PVolume = 1 AND [PVolume] IS NULL) OR ([PVolume] = @Original_PVolume)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_PriceRule = 1 AND [PriceRule] IS NULL) OR ([PriceRule] = @Original_PriceRule)) AND ((@IsNull_PriceFromDate = 1 AND [PriceFromDate] IS NULL) OR ([PriceFromDate] = @Original_PriceFromDate)) AND ((@IsNull_PriceToDate = 1 AND [PriceToDate] IS NULL) OR ([PriceToDate] = @Original_PriceToDate)) AND ((@IsNull_OfferTypeID = 1 AND [OfferTypeID] IS NULL) OR ([OfferTypeID] = @Original_OfferTypeID)) AND ((@IsNull_OfferFromDate = 1 AND [OfferFromDate] IS NULL) OR ([OfferFromDate] = @Original_OfferFromDate)) AND ((@IsNull_OfferToDate = 1 AND [OfferToDate] IS NULL) OR ([OfferToDate] = @Original_OfferToDate)) AND ((@IsNull_OfferProductId = 1 AND [OfferProductId] IS NULL) OR ([OfferProductId] = @Original_OfferProductId)) AND ((@IsNull_OfferUnit = 1 AND [OfferUnit] IS NULL) OR ([OfferUnit] = @Original_OfferUnit)) AND ((@IsNull_UNITPRICECOST = 1 AND [UNITPRICECOST] IS NULL) OR ([UNITPRICECOST] = @Original_UNITPRICECOST)) AND ((@IsNull_UNITPRICESALES = 1 AND [UNITPRICESALES] IS NULL) OR ([UNITPRICESALES] = @Original_UNITPRICESALES)) AND ((@IsNull_BUYDATE = 1 AND [BUYDATE] IS NULL) OR ([BUYDATE] = @Original_BUYDATE)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_DISCONTINUED = 1 AND [DISCONTINUED] IS NULL) OR ([DISCONTINUED] = @Original_DISCONTINUED)) AND ((@IsNull_REORDERLEVEL = 1 AND [REORDERLEVEL] IS NULL) OR ([REORDERLEVEL] = @Original_REORDERLEVEL)) AND ((@IsNull_STOCKNO = 1 AND [STOCKNO] IS NULL) OR ([STOCKNO] = @Original_STOCKNO)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_SHAPE = 1 AND [SHAPE] IS NULL) OR ([SHAPE] = @Original_SHAPE)) AND ((@IsNull_QUANTITYPERUNIT = 1 AND [QUANTITYPERUNIT] IS NULL) OR ([QUANTITYPERUNIT] = @Original_QUANTITYPERUNIT)) AND ((@IsNull_complexproduct = 1 AND [complexproduct] IS NULL) OR ([complexproduct] = @Original_complexproduct)) AND ((@IsNull_UNITSINSTOCK = 1 AND [UNITSINSTOCK] IS NULL) OR ([UNITSINSTOCK] = @Original_UNITSINSTOCK)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_QUANTITYINUNIT = 1 AND [QUANTITYINUNIT] IS NULL) OR ([QUANTITYINUNIT] = @Original_QUANTITYINUNIT)) AND ((@IsNull_initialsmallquantity = 1 AND [initialsmallquantity] IS NULL) OR ([initialsmallquantity] = @Original_initialsmallquantity)) AND ((@IsNull_initialprice = 1 AND [initialprice] IS NULL) OR ([initialprice] = @Original_initialprice)) AND ((@IsNull_initiallargequantity = 1 AND [initiallargequantity] IS NULL) OR ([initiallargequantity] = @Original_initiallargequantity)) AND ((@IsNull_serviceproduct = 1 AND [serviceproduct] IS NULL) OR ([serviceproduct] = @Original_serviceproduct)) AND ((@IsNull_profit = 1 AND [profit] IS NULL) OR ([profit] = @Original_profit)) AND ((@IsNull_forcurrency = 1 AND [forcurrency] IS NULL) OR ([forcurrency] = @Original_forcurrency)) AND ((@IsNull_minprice = 1 AND [minprice] IS NULL) OR ([minprice] = @Original_minprice)) AND ((@IsNull_shape2 = 1 AND [shape2] IS NULL) OR ([shape2] = @Original_shape2)) AND ((@IsNull_SerialCode = 1 AND [SerialCode] IS NULL) OR ([SerialCode] = @Original_SerialCode)))


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
	@ProductTypeID bigint,
	@SERIALNO nvarchar(20),
	@SUPPLIERID bigint,
	@CATEGORYID int,
	@PWeight nvarchar(50),
	@PSize nvarchar(50),
	@PColor nvarchar(50),
	@PVolume nvarchar(50),
	@picpath image,
	@VALIDITY smalldatetime,
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
	@THRESHOLDINSTOCK smallint,
	@DISCONTINUED bit,
	@REORDERLEVEL smallint,
	@STOCKNO bigint,
	@RECEIVERID int,
	@SHAPE nvarchar(10),
	@QUANTITYPERUNIT real,
	@complexproduct bit,
	@UNITSINSTOCK float,
	@ACCOUNTID int,
	@QUANTITYINUNIT float,
	@initialsmallquantity float,
	@initialprice money,
	@initiallargequantity float,
	@serviceproduct bit,
	@profit real,
	@forcurrency money,
	@minprice money,
	@shape2 nvarchar(20),
	@SerialCode bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PRODUCTS] ([productname], [EnglishName], [PRODUCTCODE], [ParentProductId], [Root], [ProductTypeID], [SERIALNO], [SUPPLIERID], [CATEGORYID], [PWeight], [PSize], [PColor], [PVolume], [picpath], [VALIDITY], [PDesc], [PriceRule], [PriceFromDate], [PriceToDate], [OfferTypeID], [OfferFromDate], [OfferToDate], [OfferProductId], [OfferUnit], [UNITPRICECOST], [UNITPRICESALES], [BUYDATE], [THRESHOLDINSTOCK], [DISCONTINUED], [REORDERLEVEL], [STOCKNO], [RECEIVERID], [SHAPE], [QUANTITYPERUNIT], [complexproduct], [UNITSINSTOCK], [ACCOUNTID], [QUANTITYINUNIT], [initialsmallquantity], [initialprice], [initiallargequantity], [serviceproduct], [profit], [forcurrency], [minprice], [shape2], [SerialCode]) VALUES (@productname, @EnglishName, @PRODUCTCODE, @ParentProductId, @Root, @ProductTypeID, @SERIALNO, @SUPPLIERID, @CATEGORYID, @PWeight, @PSize, @PColor, @PVolume, @picpath, @VALIDITY, @PDesc, @PriceRule, @PriceFromDate, @PriceToDate, @OfferTypeID, @OfferFromDate, @OfferToDate, @OfferProductId, @OfferUnit, @UNITPRICECOST, @UNITPRICESALES, @BUYDATE, @THRESHOLDINSTOCK, @DISCONTINUED, @REORDERLEVEL, @STOCKNO, @RECEIVERID, @SHAPE, @QUANTITYPERUNIT, @complexproduct, @UNITSINSTOCK, @ACCOUNTID, @QUANTITYINUNIT, @initialsmallquantity, @initialprice, @initiallargequantity, @serviceproduct, @profit, @forcurrency, @minprice, @shape2, @SerialCode);
	
SELECT PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProductTypeID, SERIALNO, SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, VALIDITY, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, THRESHOLDINSTOCK, DISCONTINUED, REORDERLEVEL, STOCKNO, RECEIVERID, SHAPE, QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initialprice, initiallargequantity, serviceproduct, profit, forcurrency, minprice, shape2, SerialCode FROM PRODUCTS WHERE (PRODUCTID = SCOPE_IDENTITY())


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
SELECT     PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProductTypeID, SERIALNO, SUPPLIERID, CATEGORYID, PWeight, 
                      PSize, PColor, PVolume, picpath, VALIDITY, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, OfferToDate, OfferProductId, 
                      OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, THRESHOLDINSTOCK, DISCONTINUED, REORDERLEVEL, STOCKNO, RECEIVERID, SHAPE, 
                      QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initialprice, initiallargequantity, 
                      serviceproduct, profit, forcurrency, minprice, shape2, SerialCode
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


CREATE PROCEDURE dbo.usp_PRODUCTUpdate
(
	@productname nvarchar(150),
	@EnglishName nvarchar(50),
	@PRODUCTCODE nvarchar(50),
	@ParentProductId bigint,
	@Root bit,
	@ProductTypeID bigint,
	@SERIALNO nvarchar(20),
	@SUPPLIERID bigint,
	@CATEGORYID int,
	@PWeight nvarchar(50),
	@PSize nvarchar(50),
	@PColor nvarchar(50),
	@PVolume nvarchar(50),
	@picpath image,
	@VALIDITY smalldatetime,
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
	@THRESHOLDINSTOCK smallint,
	@DISCONTINUED bit,
	@REORDERLEVEL smallint,
	@STOCKNO bigint,
	@RECEIVERID int,
	@SHAPE nvarchar(10),
	@QUANTITYPERUNIT real,
	@complexproduct bit,
	@UNITSINSTOCK float,
	@ACCOUNTID int,
	@QUANTITYINUNIT float,
	@initialsmallquantity float,
	@initialprice money,
	@initiallargequantity float,
	@serviceproduct bit,
	@profit real,
	@forcurrency money,
	@minprice money,
	@shape2 nvarchar(20),
	@SerialCode bigint,
	@Original_PRODUCTID bigint,
	@Original_productname nvarchar(150),
	@IsNull_EnglishName nvarchar(50),
	@Original_EnglishName nvarchar(50),
	@Original_PRODUCTCODE nvarchar(50),
	@IsNull_ParentProductId bigint,
	@Original_ParentProductId bigint,
	@IsNull_Root bit,
	@Original_Root bit,
	@IsNull_ProductTypeID bigint,
	@Original_ProductTypeID bigint,
	@IsNull_SERIALNO nvarchar(20),
	@Original_SERIALNO nvarchar(20),
	@IsNull_SUPPLIERID bigint,
	@Original_SUPPLIERID bigint,
	@IsNull_CATEGORYID int,
	@Original_CATEGORYID int,
	@IsNull_PWeight nvarchar(50),
	@Original_PWeight nvarchar(50),
	@IsNull_PSize nvarchar(50),
	@Original_PSize nvarchar(50),
	@IsNull_PColor nvarchar(50),
	@Original_PColor nvarchar(50),
	@IsNull_PVolume nvarchar(50),
	@Original_PVolume nvarchar(50),
	@IsNull_VALIDITY smalldatetime,
	@Original_VALIDITY smalldatetime,
	@IsNull_PriceRule nvarchar(30),
	@Original_PriceRule nvarchar(30),
	@IsNull_PriceFromDate smalldatetime,
	@Original_PriceFromDate smalldatetime,
	@IsNull_PriceToDate smalldatetime,
	@Original_PriceToDate smalldatetime,
	@IsNull_OfferTypeID int,
	@Original_OfferTypeID int,
	@IsNull_OfferFromDate smalldatetime,
	@Original_OfferFromDate smalldatetime,
	@IsNull_OfferToDate smalldatetime,
	@Original_OfferToDate smalldatetime,
	@IsNull_OfferProductId bigint,
	@Original_OfferProductId bigint,
	@IsNull_OfferUnit int,
	@Original_OfferUnit int,
	@IsNull_UNITPRICECOST money,
	@Original_UNITPRICECOST money,
	@IsNull_UNITPRICESALES money,
	@Original_UNITPRICESALES money,
	@IsNull_BUYDATE smalldatetime,
	@Original_BUYDATE smalldatetime,
	@IsNull_THRESHOLDINSTOCK smallint,
	@Original_THRESHOLDINSTOCK smallint,
	@IsNull_DISCONTINUED bit,
	@Original_DISCONTINUED bit,
	@IsNull_REORDERLEVEL smallint,
	@Original_REORDERLEVEL smallint,
	@IsNull_STOCKNO bigint,
	@Original_STOCKNO bigint,
	@IsNull_RECEIVERID int,
	@Original_RECEIVERID int,
	@IsNull_SHAPE nvarchar(10),
	@Original_SHAPE nvarchar(10),
	@IsNull_QUANTITYPERUNIT real,
	@Original_QUANTITYPERUNIT real,
	@IsNull_complexproduct bit,
	@Original_complexproduct bit,
	@IsNull_UNITSINSTOCK float,
	@Original_UNITSINSTOCK float,
	@IsNull_ACCOUNTID int,
	@Original_ACCOUNTID int,
	@IsNull_QUANTITYINUNIT float,
	@Original_QUANTITYINUNIT float,
	@IsNull_initialsmallquantity float,
	@Original_initialsmallquantity float,
	@IsNull_initialprice money,
	@Original_initialprice money,
	@IsNull_initiallargequantity float,
	@Original_initiallargequantity float,
	@IsNull_serviceproduct bit,
	@Original_serviceproduct bit,
	@IsNull_profit real,
	@Original_profit real,
	@IsNull_forcurrency money,
	@Original_forcurrency money,
	@IsNull_minprice money,
	@Original_minprice money,
	@IsNull_shape2 nvarchar(20),
	@Original_shape2 nvarchar(20),
	@IsNull_SerialCode bigint,
	@Original_SerialCode bigint,
	@PRODUCTID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PRODUCTS] SET [productname] = @productname, [EnglishName] = @EnglishName, [PRODUCTCODE] = @PRODUCTCODE, [ParentProductId] = @ParentProductId, [Root] = @Root, [ProductTypeID] = @ProductTypeID, [SERIALNO] = @SERIALNO, [SUPPLIERID] = @SUPPLIERID, [CATEGORYID] = @CATEGORYID, [PWeight] = @PWeight, [PSize] = @PSize, [PColor] = @PColor, [PVolume] = @PVolume, [picpath] = @picpath, [VALIDITY] = @VALIDITY, [PDesc] = @PDesc, [PriceRule] = @PriceRule, [PriceFromDate] = @PriceFromDate, [PriceToDate] = @PriceToDate, [OfferTypeID] = @OfferTypeID, [OfferFromDate] = @OfferFromDate, [OfferToDate] = @OfferToDate, [OfferProductId] = @OfferProductId, [OfferUnit] = @OfferUnit, [UNITPRICECOST] = @UNITPRICECOST, [UNITPRICESALES] = @UNITPRICESALES, [BUYDATE] = @BUYDATE, [THRESHOLDINSTOCK] = @THRESHOLDINSTOCK, [DISCONTINUED] = @DISCONTINUED, [REORDERLEVEL] = @REORDERLEVEL, [STOCKNO] = @STOCKNO, [RECEIVERID] = @RECEIVERID, [SHAPE] = @SHAPE, [QUANTITYPERUNIT] = @QUANTITYPERUNIT, [complexproduct] = @complexproduct, [UNITSINSTOCK] = @UNITSINSTOCK, [ACCOUNTID] = @ACCOUNTID, [QUANTITYINUNIT] = @QUANTITYINUNIT, [initialsmallquantity] = @initialsmallquantity, [initialprice] = @initialprice, [initiallargequantity] = @initiallargequantity, [serviceproduct] = @serviceproduct, [profit] = @profit, [forcurrency] = @forcurrency, [minprice] = @minprice, [shape2] = @shape2, [SerialCode] = @SerialCode WHERE (([PRODUCTID] = @Original_PRODUCTID) AND ([productname] = @Original_productname) AND ((@IsNull_EnglishName = 1 AND [EnglishName] IS NULL) OR ([EnglishName] = @Original_EnglishName)) AND ([PRODUCTCODE] = @Original_PRODUCTCODE) AND ((@IsNull_ParentProductId = 1 AND [ParentProductId] IS NULL) OR ([ParentProductId] = @Original_ParentProductId)) AND ((@IsNull_Root = 1 AND [Root] IS NULL) OR ([Root] = @Original_Root)) AND ((@IsNull_ProductTypeID = 1 AND [ProductTypeID] IS NULL) OR ([ProductTypeID] = @Original_ProductTypeID)) AND ((@IsNull_SERIALNO = 1 AND [SERIALNO] IS NULL) OR ([SERIALNO] = @Original_SERIALNO)) AND ((@IsNull_SUPPLIERID = 1 AND [SUPPLIERID] IS NULL) OR ([SUPPLIERID] = @Original_SUPPLIERID)) AND ((@IsNull_CATEGORYID = 1 AND [CATEGORYID] IS NULL) OR ([CATEGORYID] = @Original_CATEGORYID)) AND ((@IsNull_PWeight = 1 AND [PWeight] IS NULL) OR ([PWeight] = @Original_PWeight)) AND ((@IsNull_PSize = 1 AND [PSize] IS NULL) OR ([PSize] = @Original_PSize)) AND ((@IsNull_PColor = 1 AND [PColor] IS NULL) OR ([PColor] = @Original_PColor)) AND ((@IsNull_PVolume = 1 AND [PVolume] IS NULL) OR ([PVolume] = @Original_PVolume)) AND ((@IsNull_VALIDITY = 1 AND [VALIDITY] IS NULL) OR ([VALIDITY] = @Original_VALIDITY)) AND ((@IsNull_PriceRule = 1 AND [PriceRule] IS NULL) OR ([PriceRule] = @Original_PriceRule)) AND ((@IsNull_PriceFromDate = 1 AND [PriceFromDate] IS NULL) OR ([PriceFromDate] = @Original_PriceFromDate)) AND ((@IsNull_PriceToDate = 1 AND [PriceToDate] IS NULL) OR ([PriceToDate] = @Original_PriceToDate)) AND ((@IsNull_OfferTypeID = 1 AND [OfferTypeID] IS NULL) OR ([OfferTypeID] = @Original_OfferTypeID)) AND ((@IsNull_OfferFromDate = 1 AND [OfferFromDate] IS NULL) OR ([OfferFromDate] = @Original_OfferFromDate)) AND ((@IsNull_OfferToDate = 1 AND [OfferToDate] IS NULL) OR ([OfferToDate] = @Original_OfferToDate)) AND ((@IsNull_OfferProductId = 1 AND [OfferProductId] IS NULL) OR ([OfferProductId] = @Original_OfferProductId)) AND ((@IsNull_OfferUnit = 1 AND [OfferUnit] IS NULL) OR ([OfferUnit] = @Original_OfferUnit)) AND ((@IsNull_UNITPRICECOST = 1 AND [UNITPRICECOST] IS NULL) OR ([UNITPRICECOST] = @Original_UNITPRICECOST)) AND ((@IsNull_UNITPRICESALES = 1 AND [UNITPRICESALES] IS NULL) OR ([UNITPRICESALES] = @Original_UNITPRICESALES)) AND ((@IsNull_BUYDATE = 1 AND [BUYDATE] IS NULL) OR ([BUYDATE] = @Original_BUYDATE)) AND ((@IsNull_THRESHOLDINSTOCK = 1 AND [THRESHOLDINSTOCK] IS NULL) OR ([THRESHOLDINSTOCK] = @Original_THRESHOLDINSTOCK)) AND ((@IsNull_DISCONTINUED = 1 AND [DISCONTINUED] IS NULL) OR ([DISCONTINUED] = @Original_DISCONTINUED)) AND ((@IsNull_REORDERLEVEL = 1 AND [REORDERLEVEL] IS NULL) OR ([REORDERLEVEL] = @Original_REORDERLEVEL)) AND ((@IsNull_STOCKNO = 1 AND [STOCKNO] IS NULL) OR ([STOCKNO] = @Original_STOCKNO)) AND ((@IsNull_RECEIVERID = 1 AND [RECEIVERID] IS NULL) OR ([RECEIVERID] = @Original_RECEIVERID)) AND ((@IsNull_SHAPE = 1 AND [SHAPE] IS NULL) OR ([SHAPE] = @Original_SHAPE)) AND ((@IsNull_QUANTITYPERUNIT = 1 AND [QUANTITYPERUNIT] IS NULL) OR ([QUANTITYPERUNIT] = @Original_QUANTITYPERUNIT)) AND ((@IsNull_complexproduct = 1 AND [complexproduct] IS NULL) OR ([complexproduct] = @Original_complexproduct)) AND ((@IsNull_UNITSINSTOCK = 1 AND [UNITSINSTOCK] IS NULL) OR ([UNITSINSTOCK] = @Original_UNITSINSTOCK)) AND ((@IsNull_ACCOUNTID = 1 AND [ACCOUNTID] IS NULL) OR ([ACCOUNTID] = @Original_ACCOUNTID)) AND ((@IsNull_QUANTITYINUNIT = 1 AND [QUANTITYINUNIT] IS NULL) OR ([QUANTITYINUNIT] = @Original_QUANTITYINUNIT)) AND ((@IsNull_initialsmallquantity = 1 AND [initialsmallquantity] IS NULL) OR ([initialsmallquantity] = @Original_initialsmallquantity)) AND ((@IsNull_initialprice = 1 AND [initialprice] IS NULL) OR ([initialprice] = @Original_initialprice)) AND ((@IsNull_initiallargequantity = 1 AND [initiallargequantity] IS NULL) OR ([initiallargequantity] = @Original_initiallargequantity)) AND ((@IsNull_serviceproduct = 1 AND [serviceproduct] IS NULL) OR ([serviceproduct] = @Original_serviceproduct)) AND ((@IsNull_profit = 1 AND [profit] IS NULL) OR ([profit] = @Original_profit)) AND ((@IsNull_forcurrency = 1 AND [forcurrency] IS NULL) OR ([forcurrency] = @Original_forcurrency)) AND ((@IsNull_minprice = 1 AND [minprice] IS NULL) OR ([minprice] = @Original_minprice)) AND ((@IsNull_shape2 = 1 AND [shape2] IS NULL) OR ([shape2] = @Original_shape2)) AND ((@IsNull_SerialCode = 1 AND [SerialCode] IS NULL) OR ([SerialCode] = @Original_SerialCode)));
	
SELECT PRODUCTID, productname, EnglishName, PRODUCTCODE, ParentProductId, Root, ProductTypeID, SERIALNO, SUPPLIERID, CATEGORYID, PWeight, PSize, PColor, PVolume, picpath, VALIDITY, PDesc, PriceRule, PriceFromDate, PriceToDate, OfferTypeID, OfferFromDate, OfferToDate, OfferProductId, OfferUnit, UNITPRICECOST, UNITPRICESALES, BUYDATE, THRESHOLDINSTOCK, DISCONTINUED, REORDERLEVEL, STOCKNO, RECEIVERID, SHAPE, QUANTITYPERUNIT, complexproduct, UNITSINSTOCK, ACCOUNTID, QUANTITYINUNIT, initialsmallquantity, initialprice, initiallargequantity, serviceproduct, profit, forcurrency, minprice, shape2, SerialCode FROM PRODUCTS WHERE (PRODUCTID = @PRODUCTID)


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
	@Original_LoanID bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [PerEmpLoanDetailsReport] WHERE (([LoanDetID] = @Original_LoanDetID) AND ([LoanID] = @Original_LoanID) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)))
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
	@LoanID bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@LoanAmount money,
	@LoanDate smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [PerEmpLoanDetailsReport] ([LoanID], [YEAR_CODE], [MONTH_CODE], [LoanAmount], [LoanDate]) VALUES (@LoanID, @YEAR_CODE, @MONTH_CODE, @LoanAmount, @LoanDate);
	
SELECT LoanDetID, LoanID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate FROM PerEmpLoanDetailsReport WHERE (LoanDetID = SCOPE_IDENTITY())
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
SELECT     LoanDetID, LoanID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate
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
	@LoanID bigint,
	@YEAR_CODE int,
	@MONTH_CODE int,
	@LoanAmount money,
	@LoanDate smalldatetime,
	@Original_LoanDetID bigint,
	@Original_LoanID bigint,
	@Original_YEAR_CODE int,
	@Original_MONTH_CODE int,
	@IsNull_LoanAmount money,
	@Original_LoanAmount money,
	@IsNull_LoanDate smalldatetime,
	@Original_LoanDate smalldatetime,
	@LoanDetID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [PerEmpLoanDetailsReport] SET [LoanID] = @LoanID, [YEAR_CODE] = @YEAR_CODE, [MONTH_CODE] = @MONTH_CODE, [LoanAmount] = @LoanAmount, [LoanDate] = @LoanDate WHERE (([LoanDetID] = @Original_LoanDetID) AND ([LoanID] = @Original_LoanID) AND ([YEAR_CODE] = @Original_YEAR_CODE) AND ([MONTH_CODE] = @Original_MONTH_CODE) AND ((@IsNull_LoanAmount = 1 AND [LoanAmount] IS NULL) OR ([LoanAmount] = @Original_LoanAmount)) AND ((@IsNull_LoanDate = 1 AND [LoanDate] IS NULL) OR ([LoanDate] = @Original_LoanDate)));
	
SELECT LoanDetID, LoanID, YEAR_CODE, MONTH_CODE, LoanAmount, LoanDate FROM PerEmpLoanDetailsReport WHERE (LoanDetID = @LoanDetID)
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
	@Emp_code numeric
)
AS
	SET NOCOUNT ON;
SELECT     EMP_CODE, CIVILID, EMPNAME, EngNAME, TITLE, EMP_GENDER, EMP_BIRTH_DATE, EMP_MOBILE, DEPTCODE, ADDRESS, EMP_PHONE, 
                      EMP_EMAIL, EMP_HIREDATE, Emp_End_HIREDATE, EMP_HEALTH_INS_DATE, EMP_HEALTH_INS_NUM, JOB_CODE, JOB_CLS_CODE, FILE_NUM, 
                      DEGREE_CODE, REC_TYPE_CODE, MARITAL_STATUS_CODE, NATIONALITY_CODE, GOVER_CODE, EMP_VISA, Emp_VISA_NO, EMP_VISA_END_DATE, 
                      BANK_CODE, AccountID, NOTES, passportNo, passtype, passdate, passplace, entrydate, BORROWS, SALARY, ADDED, DEDUCED, absence, netSalary,
                       bank, bankacc, BRANCH_CODE, EMP_PIC, SalesAdminFalg
FROM         PER_EMPLOYEE_DATA
WHERE     (EMP_CODE = @Emp_code)


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
	@Original_LastCostPrice money
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Product_Units_Prices] WHERE (([UitPriceId] = @Original_UitPriceId) AND ([UintId] = @Original_UintId) AND ([productid] = @Original_productid) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ([ConFactor] = @Original_ConFactor) AND ((@IsNull_PriceOnly = 1 AND [PriceOnly] IS NULL) OR ([PriceOnly] = @Original_PriceOnly)) AND ((@IsNull_Dim = 1 AND [Dim] IS NULL) OR ([Dim] = @Original_Dim)) AND ((@IsNull_DimDesc = 1 AND [DimDesc] IS NULL) OR ([DimDesc] = @Original_DimDesc)) AND ((@IsNull_MainUnit = 1 AND [MainUnit] IS NULL) OR ([MainUnit] = @Original_MainUnit)) AND ((@IsNull_AvgCostPrice = 1 AND [AvgCostPrice] IS NULL) OR ([AvgCostPrice] = @Original_AvgCostPrice)) AND ((@IsNull_MaxCostPrice = 1 AND [MaxCostPrice] IS NULL) OR ([MaxCostPrice] = @Original_MaxCostPrice)) AND ((@IsNull_MinCostPrice = 1 AND [MinCostPrice] IS NULL) OR ([MinCostPrice] = @Original_MinCostPrice)) AND ((@IsNull_SalePrice = 1 AND [SalePrice] IS NULL) OR ([SalePrice] = @Original_SalePrice)) AND ((@IsNull_MinPrice = 1 AND [MinPrice] IS NULL) OR ([MinPrice] = @Original_MinPrice)) AND ((@IsNull_BuyPrice = 1 AND [BuyPrice] IS NULL) OR ([BuyPrice] = @Original_BuyPrice)) AND ((@IsNull_CostmerPrice = 1 AND [CostmerPrice] IS NULL) OR ([CostmerPrice] = @Original_CostmerPrice)) AND ((@IsNull_PrivatePrice = 1 AND [PrivatePrice] IS NULL) OR ([PrivatePrice] = @Original_PrivatePrice)) AND ((@IsNull_Minprofit = 1 AND [Minprofit] IS NULL) OR ([Minprofit] = @Original_Minprofit)) AND ((@IsNull_MaxProfit = 1 AND [MaxProfit] IS NULL) OR ([MaxProfit] = @Original_MaxProfit)) AND ((@IsNull_MaxSalePrice = 1 AND [MaxSalePrice] IS NULL) OR ([MaxSalePrice] = @Original_MaxSalePrice)) AND ((@IsNull_MinSalePrice = 1 AND [MinSalePrice] IS NULL) OR ([MinSalePrice] = @Original_MinSalePrice)) AND ((@IsNull_LastSalePrice = 1 AND [LastSalePrice] IS NULL) OR ([LastSalePrice] = @Original_LastSalePrice)) AND ((@IsNull_MaxBuyPrice = 1 AND [MaxBuyPrice] IS NULL) OR ([MaxBuyPrice] = @Original_MaxBuyPrice)) AND ((@IsNull_MinBuyPrice = 1 AND [MinBuyPrice] IS NULL) OR ([MinBuyPrice] = @Original_MinBuyPrice)) AND ((@IsNull_LastBuyPrice = 1 AND [LastBuyPrice] IS NULL) OR ([LastBuyPrice] = @Original_LastBuyPrice)) AND ((@IsNull_LastCostPrice = 1 AND [LastCostPrice] IS NULL) OR ([LastCostPrice] = @Original_LastCostPrice)))
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
	@LastCostPrice money
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Product_Units_Prices] ([UintId], [productid], [PRODUCTBRAND], [ConFactor], [PriceOnly], [Dim], [DimDesc], [MainUnit], [AvgCostPrice], [MaxCostPrice], [MinCostPrice], [SalePrice], [MinPrice], [BuyPrice], [CostmerPrice], [PrivatePrice], [Minprofit], [MaxProfit], [MaxSalePrice], [MinSalePrice], [LastSalePrice], [MaxBuyPrice], [MinBuyPrice], [LastBuyPrice], [LastCostPrice]) VALUES (@UintId, @productid, @PRODUCTBRAND, @ConFactor, @PriceOnly, @Dim, @DimDesc, @MainUnit, @AvgCostPrice, @MaxCostPrice, @MinCostPrice, @SalePrice, @MinPrice, @BuyPrice, @CostmerPrice, @PrivatePrice, @Minprofit, @MaxProfit, @MaxSalePrice, @MinSalePrice, @LastSalePrice, @MaxBuyPrice, @MinBuyPrice, @LastBuyPrice, @LastCostPrice);
	
SELECT UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, LastBuyPrice, LastCostPrice FROM Product_Units_Prices WHERE (UitPriceId = SCOPE_IDENTITY())
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
                      LastBuyPrice, LastCostPrice
FROM         Product_Units_Prices
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
	@UitPriceId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Product_Units_Prices] SET [UintId] = @UintId, [productid] = @productid, [PRODUCTBRAND] = @PRODUCTBRAND, [ConFactor] = @ConFactor, [PriceOnly] = @PriceOnly, [Dim] = @Dim, [DimDesc] = @DimDesc, [MainUnit] = @MainUnit, [AvgCostPrice] = @AvgCostPrice, [MaxCostPrice] = @MaxCostPrice, [MinCostPrice] = @MinCostPrice, [SalePrice] = @SalePrice, [MinPrice] = @MinPrice, [BuyPrice] = @BuyPrice, [CostmerPrice] = @CostmerPrice, [PrivatePrice] = @PrivatePrice, [Minprofit] = @Minprofit, [MaxProfit] = @MaxProfit, [MaxSalePrice] = @MaxSalePrice, [MinSalePrice] = @MinSalePrice, [LastSalePrice] = @LastSalePrice, [MaxBuyPrice] = @MaxBuyPrice, [MinBuyPrice] = @MinBuyPrice, [LastBuyPrice] = @LastBuyPrice, [LastCostPrice] = @LastCostPrice WHERE (([UitPriceId] = @Original_UitPriceId) AND ([UintId] = @Original_UintId) AND ([productid] = @Original_productid) AND ((@IsNull_PRODUCTBRAND = 1 AND [PRODUCTBRAND] IS NULL) OR ([PRODUCTBRAND] = @Original_PRODUCTBRAND)) AND ([ConFactor] = @Original_ConFactor) AND ((@IsNull_PriceOnly = 1 AND [PriceOnly] IS NULL) OR ([PriceOnly] = @Original_PriceOnly)) AND ((@IsNull_Dim = 1 AND [Dim] IS NULL) OR ([Dim] = @Original_Dim)) AND ((@IsNull_DimDesc = 1 AND [DimDesc] IS NULL) OR ([DimDesc] = @Original_DimDesc)) AND ((@IsNull_MainUnit = 1 AND [MainUnit] IS NULL) OR ([MainUnit] = @Original_MainUnit)) AND ((@IsNull_AvgCostPrice = 1 AND [AvgCostPrice] IS NULL) OR ([AvgCostPrice] = @Original_AvgCostPrice)) AND ((@IsNull_MaxCostPrice = 1 AND [MaxCostPrice] IS NULL) OR ([MaxCostPrice] = @Original_MaxCostPrice)) AND ((@IsNull_MinCostPrice = 1 AND [MinCostPrice] IS NULL) OR ([MinCostPrice] = @Original_MinCostPrice)) AND ((@IsNull_SalePrice = 1 AND [SalePrice] IS NULL) OR ([SalePrice] = @Original_SalePrice)) AND ((@IsNull_MinPrice = 1 AND [MinPrice] IS NULL) OR ([MinPrice] = @Original_MinPrice)) AND ((@IsNull_BuyPrice = 1 AND [BuyPrice] IS NULL) OR ([BuyPrice] = @Original_BuyPrice)) AND ((@IsNull_CostmerPrice = 1 AND [CostmerPrice] IS NULL) OR ([CostmerPrice] = @Original_CostmerPrice)) AND ((@IsNull_PrivatePrice = 1 AND [PrivatePrice] IS NULL) OR ([PrivatePrice] = @Original_PrivatePrice)) AND ((@IsNull_Minprofit = 1 AND [Minprofit] IS NULL) OR ([Minprofit] = @Original_Minprofit)) AND ((@IsNull_MaxProfit = 1 AND [MaxProfit] IS NULL) OR ([MaxProfit] = @Original_MaxProfit)) AND ((@IsNull_MaxSalePrice = 1 AND [MaxSalePrice] IS NULL) OR ([MaxSalePrice] = @Original_MaxSalePrice)) AND ((@IsNull_MinSalePrice = 1 AND [MinSalePrice] IS NULL) OR ([MinSalePrice] = @Original_MinSalePrice)) AND ((@IsNull_LastSalePrice = 1 AND [LastSalePrice] IS NULL) OR ([LastSalePrice] = @Original_LastSalePrice)) AND ((@IsNull_MaxBuyPrice = 1 AND [MaxBuyPrice] IS NULL) OR ([MaxBuyPrice] = @Original_MaxBuyPrice)) AND ((@IsNull_MinBuyPrice = 1 AND [MinBuyPrice] IS NULL) OR ([MinBuyPrice] = @Original_MinBuyPrice)) AND ((@IsNull_LastBuyPrice = 1 AND [LastBuyPrice] IS NULL) OR ([LastBuyPrice] = @Original_LastBuyPrice)) AND ((@IsNull_LastCostPrice = 1 AND [LastCostPrice] IS NULL) OR ([LastCostPrice] = @Original_LastCostPrice)));
	
SELECT UitPriceId, UintId, productid, PRODUCTBRAND, ConFactor, PriceOnly, Dim, DimDesc, MainUnit, AvgCostPrice, MaxCostPrice, MinCostPrice, SalePrice, MinPrice, BuyPrice, CostmerPrice, PrivatePrice, Minprofit, MaxProfit, MaxSalePrice, MinSalePrice, LastSalePrice, MaxBuyPrice, MinBuyPrice, LastBuyPrice, LastCostPrice FROM Product_Units_Prices WHERE (UitPriceId = @UitPriceId)
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
                      PRODUCTS.forcurrency, PRODUCTS.minprice, PRODUCTS.shape2, CDE_PRODUCTTYPES.TYPEDESC
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
                      dbo.PRODUCTS.SerialCode
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
                      ReorderInvId, PaymentType
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
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId
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
	SET NOCOUNT ON;
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
	@Original_STOREFromID bigint,
	@Original_STOREToID bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_MovmentQty float,
	@IsNull_UserId bigint,
	@Original_UserId bigint,
	@IsNull_EnterDate smalldatetime,
	@Original_EnterDate smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM [StockMovement] WHERE (([MoveId] = @Original_MoveId) AND ([STOREFromID] = @Original_STOREFromID) AND ([STOREToID] = @Original_STOREToID) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([MovmentQty] = @Original_MovmentQty) AND ((@IsNull_UserId = 1 AND [UserId] IS NULL) OR ([UserId] = @Original_UserId)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)))
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
	@STOREFromID bigint,
	@STOREToID bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@MovmentQty float,
	@UserId bigint,
	@EnterDate smalldatetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [StockMovement] ([STOREFromID], [STOREToID], [PRODUCTID], [UnitID], [MovmentQty], [UserId], [EnterDate]) VALUES (@STOREFromID, @STOREToID, @PRODUCTID, @UnitID, @MovmentQty, @UserId, @EnterDate);
	
SELECT MoveId, STOREFromID, STOREToID, PRODUCTID, UnitID, MovmentQty, UserId, EnterDate FROM StockMovement WHERE (MoveId = SCOPE_IDENTITY())
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
SELECT     MoveId, STOREFromID, STOREToID, PRODUCTID, UnitID, MovmentQty, UserId, EnterDate
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
	@STOREFromID bigint,
	@STOREToID bigint,
	@PRODUCTID bigint,
	@UnitID bigint,
	@MovmentQty float,
	@UserId bigint,
	@EnterDate smalldatetime,
	@Original_MoveId bigint,
	@Original_STOREFromID bigint,
	@Original_STOREToID bigint,
	@Original_PRODUCTID bigint,
	@Original_UnitID bigint,
	@Original_MovmentQty float,
	@IsNull_UserId bigint,
	@Original_UserId bigint,
	@IsNull_EnterDate smalldatetime,
	@Original_EnterDate smalldatetime,
	@MoveId bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [StockMovement] SET [STOREFromID] = @STOREFromID, [STOREToID] = @STOREToID, [PRODUCTID] = @PRODUCTID, [UnitID] = @UnitID, [MovmentQty] = @MovmentQty, [UserId] = @UserId, [EnterDate] = @EnterDate WHERE (([MoveId] = @Original_MoveId) AND ([STOREFromID] = @Original_STOREFromID) AND ([STOREToID] = @Original_STOREToID) AND ([PRODUCTID] = @Original_PRODUCTID) AND ([UnitID] = @Original_UnitID) AND ([MovmentQty] = @Original_MovmentQty) AND ((@IsNull_UserId = 1 AND [UserId] IS NULL) OR ([UserId] = @Original_UserId)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)));
	
SELECT MoveId, STOREFromID, STOREToID, PRODUCTID, UnitID, MovmentQty, UserId, EnterDate FROM StockMovement WHERE (MoveId = @MoveId)
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

SET QUOTED_IDENTIFIER OFF 
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
                      OrderQTY, QtyINRoad, QtyInStore, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale, UNITDESC
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

SET QUOTED_IDENTIFIER OFF 
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
                      OrderQTY, QtyINRoad, QtyInStore, QtynotAmount, QtyNotProchuse, QtyNotCost, QtyNotSale, UNITDESC
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

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO


CREATE PROCEDURE dbo.usp_StoresDelete
(
	@Original_STOREID bigint,
	@IsNull_STORECODE nvarchar(50),
	@Original_STORECODE nvarchar(50),
	@Original_STORNAME varchar(100),
	@IsNull_BRANCHCODE bigint,
	@Original_BRANCHCODE bigint,
	@IsNull_Notes varchar(200),
	@Original_Notes varchar(200)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [STORES] WHERE (([STOREID] = @Original_STOREID) AND ((@IsNull_STORECODE = 1 AND [STORECODE] IS NULL) OR ([STORECODE] = @Original_STORECODE)) AND ([STORNAME] = @Original_STORNAME) AND ((@IsNull_BRANCHCODE = 1 AND [BRANCHCODE] IS NULL) OR ([BRANCHCODE] = @Original_BRANCHCODE)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)))


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
	@IsNull_STORECODE nvarchar(50),
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
UPDATE [STORES] SET [STORECODE] = @STORECODE, [STORNAME] = @STORNAME, [BRANCHCODE] = @BRANCHCODE, [Notes] = @Notes WHERE (([STOREID] = @Original_STOREID) AND ((@IsNull_STORECODE = 1 AND [STORECODE] IS NULL) OR ([STORECODE] = @Original_STORECODE)) AND ([STORNAME] = @Original_STORNAME) AND ((@IsNull_BRANCHCODE = 1 AND [BRANCHCODE] IS NULL) OR ([BRANCHCODE] = @Original_BRANCHCODE)) AND ((@IsNull_Notes = 1 AND [Notes] IS NULL) OR ([Notes] = @Original_Notes)));
	
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
	@IsNull_MAX_NUM numeric(6, 0),
	@Original_MAX_NUM numeric(6, 0),
	@IsNull_FEM_FLAG varchar(1),
	@Original_FEM_FLAG varchar(1),
	@IsNull_CALE_CYCLE numeric(3, 0),
	@Original_CALE_CYCLE numeric(3, 0),
	@IsNull_DEC_FLAG numeric(1, 0),
	@Original_DEC_FLAG numeric(1, 0),
	@IsNull_ACCUM_FLAG varchar(1),
	@Original_ACCUM_FLAG varchar(1),
	@IsNull_MAX_DUR_ONCE numeric(6, 0),
	@Original_MAX_DUR_ONCE numeric(6, 0),
	@IsNull_MAX_DUR numeric(6, 0),
	@Original_MAX_DUR numeric(6, 0),
	@IsNull_SAL_DED_PERCENT numeric(6, 0),
	@Original_SAL_DED_PERCENT numeric(6, 0),
	@IsNull_BALANCE_FLAG numeric(1, 0),
	@Original_BALANCE_FLAG numeric(1, 0),
	@IsNull_VACATION_CLASS_CODE numeric(5, 0),
	@Original_VACATION_CLASS_CODE numeric(5, 0),
	@IsNull_PERIOD_FLAG varchar(1),
	@Original_PERIOD_FLAG varchar(1)
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
	@DEC_FLAG numeric(1, 0),
	@ACCUM_FLAG varchar(1),
	@MAX_DUR_ONCE numeric(6, 0),
	@MAX_DUR numeric(6, 0),
	@SAL_DED_PERCENT numeric(6, 0),
	@BALANCE_FLAG numeric(1, 0),
	@VACATION_CLASS_CODE numeric(5, 0),
	@PERIOD_FLAG varchar(1)
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
	@DEC_FLAG numeric(1, 0),
	@ACCUM_FLAG varchar(1),
	@MAX_DUR_ONCE numeric(6, 0),
	@MAX_DUR numeric(6, 0),
	@SAL_DED_PERCENT numeric(6, 0),
	@BALANCE_FLAG numeric(1, 0),
	@VACATION_CLASS_CODE numeric(5, 0),
	@PERIOD_FLAG varchar(1),
	@Original_VAC_TYPE_CODE numeric,
	@Original_VAC_TYPE_DESC varchar(200),
	@IsNull_MAX_NUM numeric(6, 0),
	@Original_MAX_NUM numeric(6, 0),
	@IsNull_FEM_FLAG varchar(1),
	@Original_FEM_FLAG varchar(1),
	@IsNull_CALE_CYCLE numeric(3, 0),
	@Original_CALE_CYCLE numeric(3, 0),
	@IsNull_DEC_FLAG numeric(1, 0),
	@Original_DEC_FLAG numeric(1, 0),
	@IsNull_ACCUM_FLAG varchar(1),
	@Original_ACCUM_FLAG varchar(1),
	@IsNull_MAX_DUR_ONCE numeric(6, 0),
	@Original_MAX_DUR_ONCE numeric(6, 0),
	@IsNull_MAX_DUR numeric(6, 0),
	@Original_MAX_DUR numeric(6, 0),
	@IsNull_SAL_DED_PERCENT numeric(6, 0),
	@Original_SAL_DED_PERCENT numeric(6, 0),
	@IsNull_BALANCE_FLAG numeric(1, 0),
	@Original_BALANCE_FLAG numeric(1, 0),
	@IsNull_VACATION_CLASS_CODE numeric(5, 0),
	@Original_VACATION_CLASS_CODE numeric(5, 0),
	@IsNull_PERIOD_FLAG varchar(1),
	@Original_PERIOD_FLAG varchar(1),
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
	@Original_LastSerialNo varchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [accounting] WHERE (([accountid] = @Original_accountid) AND ([AccountCode] = @Original_AccountCode) AND ([accountname] = @Original_accountname) AND ((@IsNull_AccountSName = 1 AND [AccountSName] IS NULL) OR ([AccountSName] = @Original_AccountSName)) AND ((@IsNull_AccountparentId = 1 AND [AccountparentId] IS NULL) OR ([AccountparentId] = @Original_AccountparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_accountType = 1 AND [accountType] IS NULL) OR ([accountType] = @Original_accountType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)))


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
	@LastSerialNo varchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [accounting] ([AccountCode], [accountname], [AccountSName], [AccountparentId], [root], [Totalfromvalue], [Totaltovalue], [notes], [startbalancefrom], [startdate], [startbalanceto], [balance], [accountType], [ClosedTo], [MainNode], [ProcessFlag], [display_Flag], [AccLevel], [MainParentAccId], [LastSerialNo]) VALUES (@AccountCode, @accountname, @AccountSName, @AccountparentId, @root, @Totalfromvalue, @Totaltovalue, @notes, @startbalancefrom, @startdate, @startbalanceto, @balance, @accountType, @ClosedTo, @MainNode, @ProcessFlag, @display_Flag, @AccLevel, @MainParentAccId, @LastSerialNo);
	
SELECT accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo FROM accounting WHERE (accountid = SCOPE_IDENTITY())


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
                      startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo
FROM         accounting
where accountid>4


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
	@accountid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [accounting] SET [AccountCode] = @AccountCode, [accountname] = @accountname, [AccountSName] = @AccountSName, [AccountparentId] = @AccountparentId, [root] = @root, [Totalfromvalue] = @Totalfromvalue, [Totaltovalue] = @Totaltovalue, [notes] = @notes, [startbalancefrom] = @startbalancefrom, [startdate] = @startdate, [startbalanceto] = @startbalanceto, [balance] = @balance, [accountType] = @accountType, [ClosedTo] = @ClosedTo, [MainNode] = @MainNode, [ProcessFlag] = @ProcessFlag, [display_Flag] = @display_Flag, [AccLevel] = @AccLevel, [MainParentAccId] = @MainParentAccId, [LastSerialNo] = @LastSerialNo WHERE (([accountid] = @Original_accountid) AND ([AccountCode] = @Original_AccountCode) AND ([accountname] = @Original_accountname) AND ((@IsNull_AccountSName = 1 AND [AccountSName] IS NULL) OR ([AccountSName] = @Original_AccountSName)) AND ((@IsNull_AccountparentId = 1 AND [AccountparentId] IS NULL) OR ([AccountparentId] = @Original_AccountparentId)) AND ((@IsNull_root = 1 AND [root] IS NULL) OR ([root] = @Original_root)) AND ((@IsNull_Totalfromvalue = 1 AND [Totalfromvalue] IS NULL) OR ([Totalfromvalue] = @Original_Totalfromvalue)) AND ((@IsNull_Totaltovalue = 1 AND [Totaltovalue] IS NULL) OR ([Totaltovalue] = @Original_Totaltovalue)) AND ((@IsNull_startbalancefrom = 1 AND [startbalancefrom] IS NULL) OR ([startbalancefrom] = @Original_startbalancefrom)) AND ((@IsNull_startdate = 1 AND [startdate] IS NULL) OR ([startdate] = @Original_startdate)) AND ((@IsNull_startbalanceto = 1 AND [startbalanceto] IS NULL) OR ([startbalanceto] = @Original_startbalanceto)) AND ((@IsNull_balance = 1 AND [balance] IS NULL) OR ([balance] = @Original_balance)) AND ((@IsNull_accountType = 1 AND [accountType] IS NULL) OR ([accountType] = @Original_accountType)) AND ((@IsNull_ClosedTo = 1 AND [ClosedTo] IS NULL) OR ([ClosedTo] = @Original_ClosedTo)) AND ((@IsNull_MainNode = 1 AND [MainNode] IS NULL) OR ([MainNode] = @Original_MainNode)) AND ((@IsNull_ProcessFlag = 1 AND [ProcessFlag] IS NULL) OR ([ProcessFlag] = @Original_ProcessFlag)) AND ((@IsNull_display_Flag = 1 AND [display_Flag] IS NULL) OR ([display_Flag] = @Original_display_Flag)) AND ((@IsNull_AccLevel = 1 AND [AccLevel] IS NULL) OR ([AccLevel] = @Original_AccLevel)) AND ((@IsNull_MainParentAccId = 1 AND [MainParentAccId] IS NULL) OR ([MainParentAccId] = @Original_MainParentAccId)) AND ((@IsNull_LastSerialNo = 1 AND [LastSerialNo] IS NULL) OR ([LastSerialNo] = @Original_LastSerialNo)));
	
SELECT accountid, AccountCode, accountname, AccountSName, AccountparentId, root, Totalfromvalue, Totaltovalue, notes, startbalancefrom, startdate, startbalanceto, balance, accountType, ClosedTo, MainNode, ProcessFlag, display_Flag, AccLevel, MainParentAccId, LastSerialNo FROM accounting WHERE (accountid = @accountid)


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
SELECT     InvId, InvCode, RecoderCode, InvDate, Cust_Sup_Accid, InvAccid, PaymentType, PaymentAccid, BranchId, InvType, EmpId, PaymentValue, 
                      PaymentDate, Notes, invTotal, Discount, InvTotalNet, InvPayment, InvRemain, ReferID, PaymentCost, ChequeNo, ChequeFlag, TotalAddCost, 
                      TotalReoder, TotalReoderNet, CostId, SUP_CUST_ID, PayFinish, CollectValue
FROM         invoices
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
	@Original_PaymentType bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM [qids] WHERE (([qidid] = @Original_qidid) AND ([qidcode] = @Original_qidcode) AND ((@IsNull_qidDate = 1 AND [qidDate] IS NULL) OR ([qidDate] = @Original_qidDate)) AND ((@IsNull_edit = 1 AND [edit] IS NULL) OR ([edit] = @Original_edit)) AND ((@IsNull_recitetype = 1 AND [recitetype] IS NULL) OR ([recitetype] = @Original_recitetype)) AND ((@IsNull_underupdate = 1 AND [underupdate] IS NULL) OR ([underupdate] = @Original_underupdate)) AND ((@IsNull_name = 1 AND [name] IS NULL) OR ([name] = @Original_name)) AND ((@IsNull_BrachId = 1 AND [BrachId] IS NULL) OR ([BrachId] = @Original_BrachId)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_repeated = 1 AND [repeated] IS NULL) OR ([repeated] = @Original_repeated)) AND ((@IsNull_BankAccId = 1 AND [BankAccId] IS NULL) OR ([BankAccId] = @Original_BankAccId)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderInvId = 1 AND [ReorderInvId] IS NULL) OR ([ReorderInvId] = @Original_ReorderInvId)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)))


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
	@Original_CostId bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [qidsDetails] WHERE (([ID] = @Original_ID) AND ([qidid] = @Original_qidid) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ([ACCOUNTID] = @Original_ACCOUNTID) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)))


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
	@CostId bigint
)
AS
	SET NOCOUNT OFF;
INSERT INTO [qidsDetails] ([qidid], [FromValue], [ToValue], [ACCOUNTID], [type], [Description], [EnterDate], [Detcode], [QidType], [TotalPrice], [ActionType], [CostId]) VALUES (@qidid, @FromValue, @ToValue, @ACCOUNTID, @type, @Description, @EnterDate, @Detcode, @QidType, @TotalPrice, @ActionType, @CostId);
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId FROM qidsDetails WHERE (ID = SCOPE_IDENTITY())


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
SELECT     ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId
FROM         qidsDetails


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
	@ID bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [qidsDetails] SET [qidid] = @qidid, [FromValue] = @FromValue, [ToValue] = @ToValue, [ACCOUNTID] = @ACCOUNTID, [type] = @type, [Description] = @Description, [EnterDate] = @EnterDate, [Detcode] = @Detcode, [QidType] = @QidType, [TotalPrice] = @TotalPrice, [ActionType] = @ActionType, [CostId] = @CostId WHERE (([ID] = @Original_ID) AND ([qidid] = @Original_qidid) AND ((@IsNull_FromValue = 1 AND [FromValue] IS NULL) OR ([FromValue] = @Original_FromValue)) AND ((@IsNull_ToValue = 1 AND [ToValue] IS NULL) OR ([ToValue] = @Original_ToValue)) AND ([ACCOUNTID] = @Original_ACCOUNTID) AND ((@IsNull_type = 1 AND [type] IS NULL) OR ([type] = @Original_type)) AND ((@IsNull_EnterDate = 1 AND [EnterDate] IS NULL) OR ([EnterDate] = @Original_EnterDate)) AND ((@IsNull_Detcode = 1 AND [Detcode] IS NULL) OR ([Detcode] = @Original_Detcode)) AND ((@IsNull_QidType = 1 AND [QidType] IS NULL) OR ([QidType] = @Original_QidType)) AND ((@IsNull_TotalPrice = 1 AND [TotalPrice] IS NULL) OR ([TotalPrice] = @Original_TotalPrice)) AND ((@IsNull_ActionType = 1 AND [ActionType] IS NULL) OR ([ActionType] = @Original_ActionType)) AND ((@IsNull_CostId = 1 AND [CostId] IS NULL) OR ([CostId] = @Original_CostId)));
	
SELECT ID, qidid, FromValue, ToValue, ACCOUNTID, type, Description, EnterDate, Detcode, QidType, TotalPrice, ActionType, CostId FROM qidsDetails WHERE (ID = @ID)


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
	@PaymentType bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO [qids] ([qidcode], [qidDate], [description], [edit], [recitetype], [underupdate], [name], [BrachId], [EmpId], [Notes], [Active], [repeated], [BankAccId], [ChequeNo], [InvId], [ReorderInvId], [PaymentType]) VALUES (@qidcode, @qidDate, @description, @edit, @recitetype, @underupdate, @name, @BrachId, @EmpId, @Notes, @Active, @repeated, @BankAccId, @ChequeNo, @InvId, @ReorderInvId, @PaymentType);
	
SELECT qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, ReorderInvId, PaymentType FROM qids WHERE (qidid = SCOPE_IDENTITY())


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
                      ReorderInvId, PaymentType
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
	@qidid bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [qids] SET [qidcode] = @qidcode, [qidDate] = @qidDate, [description] = @description, [edit] = @edit, [recitetype] = @recitetype, [underupdate] = @underupdate, [name] = @name, [BrachId] = @BrachId, [EmpId] = @EmpId, [Notes] = @Notes, [Active] = @Active, [repeated] = @repeated, [BankAccId] = @BankAccId, [ChequeNo] = @ChequeNo, [InvId] = @InvId, [ReorderInvId] = @ReorderInvId, [PaymentType] = @PaymentType WHERE (([qidid] = @Original_qidid) AND ([qidcode] = @Original_qidcode) AND ((@IsNull_qidDate = 1 AND [qidDate] IS NULL) OR ([qidDate] = @Original_qidDate)) AND ((@IsNull_edit = 1 AND [edit] IS NULL) OR ([edit] = @Original_edit)) AND ((@IsNull_recitetype = 1 AND [recitetype] IS NULL) OR ([recitetype] = @Original_recitetype)) AND ((@IsNull_underupdate = 1 AND [underupdate] IS NULL) OR ([underupdate] = @Original_underupdate)) AND ((@IsNull_name = 1 AND [name] IS NULL) OR ([name] = @Original_name)) AND ((@IsNull_BrachId = 1 AND [BrachId] IS NULL) OR ([BrachId] = @Original_BrachId)) AND ((@IsNull_EmpId = 1 AND [EmpId] IS NULL) OR ([EmpId] = @Original_EmpId)) AND ((@IsNull_Active = 1 AND [Active] IS NULL) OR ([Active] = @Original_Active)) AND ((@IsNull_repeated = 1 AND [repeated] IS NULL) OR ([repeated] = @Original_repeated)) AND ((@IsNull_BankAccId = 1 AND [BankAccId] IS NULL) OR ([BankAccId] = @Original_BankAccId)) AND ((@IsNull_ChequeNo = 1 AND [ChequeNo] IS NULL) OR ([ChequeNo] = @Original_ChequeNo)) AND ((@IsNull_InvId = 1 AND [InvId] IS NULL) OR ([InvId] = @Original_InvId)) AND ((@IsNull_ReorderInvId = 1 AND [ReorderInvId] IS NULL) OR ([ReorderInvId] = @Original_ReorderInvId)) AND ((@IsNull_PaymentType = 1 AND [PaymentType] IS NULL) OR ([PaymentType] = @Original_PaymentType)));
	
SELECT qidid, qidcode, qidDate, description, edit, recitetype, underupdate, name, BrachId, EmpId, Notes, Active, repeated, BankAccId, ChequeNo, InvId, ReorderInvId, PaymentType FROM qids WHERE (qidid = @qidid)


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

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE TRIGGER delProductTrigger  ON [dbo].[Inv_Products] 
FOR  DELETE 
AS

declare @InvId as bigint
declare @ProductId as bigint
declare @UnitId as bigint
declare @StoreId as bigint
declare @NewQty as float
declare @OldQty as float
declare @InvType as int

declare @TotalAddCost as money 
declare @invTotal as money
declare @InvCostPer as float
declare @CostPrice as money

declare @NewReoderFlag as bit
declare @OldReoderFlag as bit

declare @price as money
declare @ProductTypeID bigint 

select  @ProductId =ProductId from deleted
select  @UnitId =UnitId from deleted
select  @StoreId  =StoreId  from deleted
select  @InvId  =InvId  from deleted
select @NewQty= ISNULL(Qty , 0) from inserted
select @price = ISNULL(price , 0) from deleted
select @OldQty= ISNULL(Qty, 0) from deleted

select @NewReoderFlag = ReoderFlag  from deleted
select @OldReoderFlag = ReoderFlag  from deleted

select @InvType=InvType from invoices where InvId=@InvId
select @invTotal=invTotal from invoices where InvId=@InvId
select @TotalAddCost=TotalAddCost from invoices where InvId=@InvId

select @ProductTypeID=ProductTypeID from Products where ProductId=@ProductId 

--print @InvType
if (@InvType=1)   --purchases
	--begin
	--update STOCK set QUANTITY = QUANTITY+@NewQty  where STOREID = @StoreId and PRODUCTID=@ProductId
	--and  UnitID=@UnitId
	--update STOCK set QUANTITY = QUANTITY-@OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId
	--and  UnitID=@UnitId

	--if (@NewReoderFlag=1 and @OldReoderFlag=0)
	begin
		update STOCK set QUANTITY = QUANTITY- @OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId

		--update STOCK set QUANTITY = QUANTITY +@OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId


	end 

	

if (@InvType=2) --Sales
	--begin
	--update STOCK set QUANTITY = QUANTITY-@NewQty  where STOREID = @StoreId and PRODUCTID=@ProductId
		--and  UnitID=@UnitId

	--update STOCK set QUANTITY = QUANTITY+@oldQty  where STOREID = @StoreId and PRODUCTID=@ProductId
		--and  UnitID=@UnitId

	--if (@NewReoderFlag=1 and @OldReoderFlag=0)
	begin
		update STOCK set QUANTITY = QUANTITY+ @OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId

	if (@ProductTypeID=2)
	begin
		set @OldQty= -@OldQty*-1
		exec UpdateAssembly_QtyValue  @ProductId,@StoreId ,@OldQty,0
	
	end 

		--update STOCK set QUANTITY = QUANTITY -@OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId
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

CREATE TRIGGER Insert_Qty ON dbo.Inv_Products 
FOR INSERT
AS
declare @InvId as bigint
declare @ProductId as bigint
declare @UnitId as bigint
declare @StoreId as bigint
declare @Qty as float
declare @InvType as int
declare @price as money
declare @TotalAddCost as money 
declare @invTotal as money
declare @InvCostPer as float
declare @CostPrice as money
declare @InvProductId as bigint
declare @TotalPrice as money

declare @MaxSalePrice as money
declare @MinSalePrice as money
declare @LastSalePrice as money

declare @MaxBuyPrice as money
declare @MinBuyPrice as money
declare @LastBuyPrice as money

declare @MaxCostPrice as money
declare @MinCostPrice as money
declare @AvgCostPrice as money
declare @inv_Product_Id bigint
declare @ProductCount bigint
declare @ProductTypeID bigint 

declare @MainUnitId as bigint
declare @ConFactor as int 

select @inv_Product_Id=inv_Product_Id from inserted

select  @ProductId =ProductId from inserted
select  @UnitId =UnitId from inserted
select  @StoreId  =StoreId  from inserted
select  @InvId  =InvId  from inserted
select @Qty= ISNULL(Qty , 0) from inserted
select @price =price  from inserted
select @InvProductId =Inv_Product_Id from inserted 
select @TotalPrice=TotalPrice from inserted

select @InvType=InvType from invoices where InvId=@InvId
select @invTotal=invTotal from invoices where InvId=@InvId
select @TotalAddCost=TotalAddCost from invoices where InvId=@InvId

select @ProductTypeID=ProductTypeID from Products where ProductId=@ProductId 

if (@Qty<>0)
begin
select @MainUnitId = UintId from Product_Units_Prices where MainUnit=1 and   productid=@ProductId --and  UintId=@UnitId
select @ConFactor=ConFactor from  Product_Units_Prices where   productid=@ProductId and  UintId=@UnitId
if (@InvType=1) --purchases
	begin
	set @ProductCount=0 
	select @ProductCount=  count(*) from STOCK where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId--@UnitId
	if (@ProductCount=0)
	begin
		insert into  Product_Units_Prices(ProductId,UintId,PRODUCTBRAND ) values(@ProductId,@MainUnitId,CAST( @ProductId AS varchar(10))+CAST( @MainUnitId AS varchar(10)))
		insert into STOCK (ProductId,STOREID,UnitID,QUANTITY) values (@ProductId,@StoreId,@MainUnitId,(@Qty*@ConFactor))
	end
	else	
	begin
		
		update STOCK set QUANTITY = QUANTITY+(@Qty*@ConFactor)  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId --=@UnitId
	end
	
	select  @MaxBuyPrice=  isnull(MaxBuyPrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinBuyPrice =  isnull(MinBuyPrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	Select  @LastBuyPrice=  isnull(LastBuyPrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	
	select  @MaxCostPrice=  isnull(MaxCostPrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinCostPrice =  isnull(MinCostPrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	Select  @AvgCostPrice=  isnull(AvgCostPrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId


	if (@price<=@MinBuyPrice or ISNULL(@MinBuyPrice, 0 ) = 0 ) 
	begin
	update  Product_Units_Prices set  MinBuyPrice=@price where productId=@ProductId and UintId=@UnitId
	end
	if (@price>=@MaxBuyPrice or ISNULL(@MaxBuyPrice, 0 ) = 0) 
	begin
		update  Product_Units_Prices set  MaxBuyPrice=@price where productId=@ProductId and UintId=@UnitId
	end

	update  Product_Units_Prices set  LastBuyPrice=@price where productId=@ProductId and UintId=@UnitId

	if( ISNULL(@TotalAddCost, 0 ) > 0)
	begin
		set @InvCostPer=@TotalAddCost/@invTotal
		set @CostPrice=@price * (@InvCostPer+1)
		
		update  Product_Units_Prices set  LastCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId

		if (@CostPrice<=@MinCostPrice or ISNULL(@MinCostPrice, 0 ) = 0 ) 
		begin
			update  Product_Units_Prices set  MinCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId
		end
		if (@CostPrice>=@MaxCostPrice or ISNULL(@MaxCostPrice, 0 ) = 0) 
		begin
			update  Product_Units_Prices set  MaxCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId
		end
	end
 end --- اخر المشتريات


if (@InvType=2) --Sales
	begin

	if (@ProductTypeID=2)
	begin
		exec UpdateAssembly_QtyValue  @ProductId,@StoreId, @Qty,0 
	
		--Update STOCK set QUANTITY = QUANTITY- @Qty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId
	end 
	--else
	--begin
			
			update STOCK set QUANTITY = QUANTITY- (@Qty*@ConFactor)  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId --@UnitId
	--end 
	
	Select  @MaxSalePrice=  isnull(MaxSalePrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinSalePrice =  isnull(MinSalePrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @LastSalePrice=  isnull(LastSalePrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	
	if (@price<=@MinSalePrice or  ISNULL(@MinSalePrice, 0 ) = 0) 
	begin
		update  Product_Units_Prices set  MinSalePrice=@price where productId=@ProductId and UintId=@UnitId
	end
	if (@price>=@MaxSalePrice  or  ISNULL(@MaxSalePrice , 0 ) = 0) 
	begin
		update  Product_Units_Prices set  MaxSalePrice=@price where productId=@ProductId and UintId=@UnitId
	end

	update  Product_Units_Prices set  LastSalePrice=@price where productId=@ProductId and UintId=@UnitId
	
end 


update Inv_Products set ReorderQty=@Qty where Inv_Product_Id=@InvProductId 
update Inv_Products set TotReoderPrice=@TotalPrice where Inv_Product_Id=@InvProductId

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

CREATE TRIGGER Update_Qty ON dbo.Inv_Products 
FOR UPDATE
AS
declare @InvId as bigint
declare @ProductId as bigint
declare @OldProductId as bigint 
declare @UnitId as bigint
declare @StoreId as bigint
declare @NewQty as float
declare @OldQty as float
declare @InvType as int

declare @TotalAddCost as money 
declare @invTotal as money
declare @InvCostPer as float
declare @CostPrice as money

declare @MinBuyPrice as money
declare @MaxBuyPrice as money
declare @LastBuyPrice as money

declare @MinSalePrice as money
declare @MaxSalePrice as money
declare @LastSalePrice as money

declare @MaxCostPrice as money
declare @MinCostPrice as money
declare @AvgCostPrice as money
declare @NewReoderFlag as bit
declare @OldReoderFlag as bit

declare @price as money
declare  @ProductTypeID bigint 

declare @MainUnitId as bigint
declare @ConFactor as int 

select  @ProductId =ProductId from inserted
select  @OldProductId =ProductId from deleted

select  @UnitId =UnitId from inserted
select  @StoreId  =StoreId  from inserted
select  @InvId  =InvId  from inserted
select @NewQty= ISNULL(Qty , 0) from inserted
select @price = ISNULL(price , 0) from inserted
select @OldQty= ISNULL(Qty, 0) from deleted

select @NewReoderFlag = ReoderFlag  from inserted
select @OldReoderFlag = ReoderFlag  from deleted

select @InvType=InvType from invoices where InvId=@InvId
select @invTotal=invTotal from invoices where InvId=@InvId
select @TotalAddCost=TotalAddCost from invoices where InvId=@InvId

select @ProductTypeID=ProductTypeID from Products where ProductId=@ProductId 

select @MainUnitId = UintId from Product_Units_Prices where MainUnit=1 and   productid=@ProductId --and  UintId=@UnitId
select @ConFactor=ConFactor from  Product_Units_Prices where   productid=@ProductId and  UintId=@UnitId

if (@InvType=1)   --purchases
	begin
	update STOCK set QUANTITY = QUANTITY+(@NewQty*@ConFactor)  where STOREID = @StoreId and PRODUCTID=@ProductId
	and  UnitID=@MainUnitId --@UnitId
	update STOCK set QUANTITY = QUANTITY-(@OldQty*@ConFactor)  where STOREID = @StoreId and PRODUCTID=@OldProductId
	and  UnitID=@MainUnitId--@UnitId

	if (@NewReoderFlag=1 and @OldReoderFlag=0)
	begin
		update STOCK set QUANTITY = QUANTITY- (@NewQty*@ConFactor)  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId--@UnitId

		--update STOCK set QUANTITY = QUANTITY +@OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@UnitId


	end 

	if (@NewReoderFlag=0 and @OldReoderFlag=1)
	begin
		update STOCK set QUANTITY = QUANTITY +@OldQty  where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId--@UnitId
	end
	select  @MaxBuyPrice=  isnull(MaxBuyPrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinBuyPrice =  isnull(MinBuyPrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @LastBuyPrice=  isnull(LastBuyPrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	
	select  @MaxCostPrice=  isnull(MaxCostPrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinCostPrice =  isnull(MinCostPrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @AvgCostPrice=  isnull(AvgCostPrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId

	if (@price<=@MinBuyPrice) 
	begin
		update  Product_Units_Prices set  MinBuyPrice=@price where productId=@ProductId and UintId=@UnitId
	end
	if (@price>=@MaxBuyPrice) 
	begin
		update  Product_Units_Prices set  MaxBuyPrice=@price where productId=@ProductId and UintId=@UnitId
	end

	update  Product_Units_Prices set  LastBuyPrice=@price where productId=@ProductId and UintId=@UnitId

	if( ISNULL(@TotalAddCost, 0 ) > 0)
	begin
		set @InvCostPer=@TotalAddCost/@invTotal
		set @CostPrice=@price * (@InvCostPer+1)

		update  Product_Units_Prices set  LastCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId

		if (@CostPrice<=@MinCostPrice or ISNULL(@MinCostPrice, 0 ) = 0 ) 
		begin
			update  Product_Units_Prices set  MinCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId
		end
		if (@CostPrice>=@MaxCostPrice or ISNULL(@MaxCostPrice, 0 ) = 0) 
		begin
			update  Product_Units_Prices set  MaxCostPrice=@CostPrice where productId=@ProductId and UintId=@UnitId
		end
	end

	 end
if (@InvType=2) --Sales
	begin
	update STOCK set QUANTITY = QUANTITY-@NewQty*@ConFactor   where STOREID = @StoreId and PRODUCTID=@ProductId
		and  UnitID=@MainUnitId --@UnitId
	
	

	update STOCK set QUANTITY = QUANTITY+@oldQty*@ConFactor   where STOREID = @StoreId and PRODUCTID=@OldProductId
		and  UnitID=@MainUnitId --@UnitId

	if (@ProductTypeID=2)
	begin
		exec UpdateAssembly_QtyValue  @ProductId,@StoreId ,@NewQty,@oldQty
	
	end 


	if (@NewReoderFlag=1 and @OldReoderFlag=0)
	begin
		update STOCK set QUANTITY = QUANTITY+ @NewQty*@ConFactor   where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId--@UnitId

	end 
	if (@NewReoderFlag=0 and @OldReoderFlag=1)
	begin
		update STOCK set QUANTITY = QUANTITY -@OldQty*@ConFactor   where STOREID = @StoreId and PRODUCTID=@ProductId and  UnitID=@MainUnitId--@UnitId
	end 

	select  @MaxSalePrice=  isnull(MaxSalePrice,0)  from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @MinSalePrice = isnull( MinSalePrice,0)   from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	select  @LastSalePrice=  isnull(LastSalePrice,0) from Product_Units_Prices where productId=@ProductId and UintId=@UnitId
	
	if (@price<=@MinSalePrice) 
	begin
		update  Product_Units_Prices set  MinSalePrice=@price where productId=@ProductId and UintId=@UnitId
	end
	if (@price>=@MaxSalePrice) 
	begin
		update  Product_Units_Prices set  MaxSalePrice=@price where productId=@ProductId and UintId=@UnitId
	end

	update  Product_Units_Prices set  LastSalePrice=@price where productId=@ProductId and UintId=@UnitId


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

CREATE 
    TRIGGER DBO.UP_PER_EMP_JOB_AFTER_INSERT ON dbo.PER_EMP_JOB
      AFTER INSERT
      AS 
        /*  begin of trigger implementation */
        SET NOCOUNT ON
        
        --  Temporary variable to store @@ERROR value
        DECLARE @error_store int
        /* column variables declaration */
        DECLARE
          @column_new_value____8 numeric(38),
          @column_new_value____9 numeric(5),
          @column_new_value____10 numeric(5),
          @column_new_value____11 numeric(5)
        /* iterate for each for from inserted/updated table(s) */
        DECLARE ForEachInsertedRowTriggerCursor CURSOR LOCAL FORWARD_ONLY READ_ONLY FOR
        SELECT EMP_CODE, JOB_CLS_CODE, DEGREE_CODE, JOB_CODE FROM inserted
        
        OPEN ForEachInsertedRowTriggerCursor
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        
        WHILE @@fetch_status = 0
        BEGIN
--------------------------------------------------------------------------------------------------------
          /* Oracle-trigger DBO.UP_PER_EMP_JOB implementation: begin */
          BEGIN
            UPDATE DBO.PER_EMP_DATA
              SET DBO.PER_EMP_DATA.JOB_CLS_CODE = @column_new_value____9, DBO.PER_EMP_DATA.JOB_CODE = @column_new_value____11, DBO.PER_EMP_DATA.DEGREE_CODE = @column_new_value____10
              WHERE (DBO.PER_EMP_DATA.EMP_CODE = @column_new_value____8)
            -- Store @@ERROR value to the temporary variable 
            SET @error_store = @@ERROR
            -- Emulation of SYS.STANDARD.DUP_VAL_ON_INDEX exception
            IF (@error_store = 2627)
            BEGIN
              EXEC SYSDB.SYS.DB_ERROR_SET_EXCEPTION_INFO 'SYS.STANDARD.DUP_VAL_ON_INDEX'
              GOTO exception_handler_2
            END
          exception_handler_2:
            BEGIN
              -- Emulation of handler of OTHERS exception(s)
              IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not null)
              BEGIN
                EXEC SYSDB.SYS.DB_ERROR_RESET_EXCEPTION_INFO
                  declare @db_null_statement_1 int
              END
            END
            -- Processing unhandled exceptions
            IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not NULL)
              GOTO trigger_end_1
          END
          /* Oracle-trigger DBO.UP_PER_EMP_JOB implementation: end */
--------------------------------------------------------------------------------------------------------
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        END
        
        CLOSE ForEachInsertedRowTriggerCursor
        DEALLOCATE ForEachInsertedRowTriggerCursor
      trigger_end_1:
        /*  end of trigger implementation */

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE 
    TRIGGER DBO.INSTEAD_OF_INSERT_ON_PER_EMP_JOB ON dbo.PER_EMP_JOB
      INSTEAD OF INSERT
      AS 
        /*  begin of trigger implementation */
        SET NOCOUNT ON
        
        --  Temporary variable to store @@ERROR value
        DECLARE @error_store int
        /* column variables declaration */
        DECLARE
          @column_new_value____1 numeric(1),
          @column_new_value____2 numeric(12),
          @column_new_value____3 datetime,
          @column_new_value____4 datetime,
          @column_new_value____5 datetime,
          @column_new_value____6 datetime,
          @column_new_value____7 numeric(8, 2),
          @column_new_value____8 numeric(38),
          @column_new_value____9 numeric(5),
          @column_new_value____10 numeric(5),
          @column_new_value____11 numeric(5)
        /* iterate for each for from inserted/updated table(s) */
        DECLARE ForEachInsertedRowTriggerCursor CURSOR LOCAL FORWARD_ONLY READ_ONLY FOR
        SELECT DEGREE_HOLD_FLAG, J_DEC_NO, END_DATE, J_DEC_DATE, EMP_JOB_DATE, EMP_DGR_DATE, EMP_JOB_SALARY, EMP_CODE, JOB_CLS_CODE, DEGREE_CODE, JOB_CODE FROM inserted
        
        OPEN ForEachInsertedRowTriggerCursor
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____1, @column_new_value____2, @column_new_value____3, @column_new_value____4, @column_new_value____5, @column_new_value____6, @column_new_value____7, @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        
        WHILE @@fetch_status = 0
        BEGIN
--------------------------------------------------------------------------------------------------------
          /* Oracle-trigger DBO.TIU_PER_EMP_JOB implementation: begin */
          BEGIN
            UPDATE DBO.PER_EMP_DATA
              SET DBO.PER_EMP_DATA.JOB_CLS_CODE = @column_new_value____9, DBO.PER_EMP_DATA.JOB_CODE = @column_new_value____11, DBO.PER_EMP_DATA.DEGREE_CODE = @column_new_value____10
              WHERE (DBO.PER_EMP_DATA.EMP_CODE = @column_new_value____8)
            -- Store @@ERROR value to the temporary variable 
            SET @error_store = @@ERROR
            -- Emulation of SYS.STANDARD.DUP_VAL_ON_INDEX exception
            IF (@error_store = 2627)
            BEGIN
              EXEC SYSDB.SYS.DB_ERROR_SET_EXCEPTION_INFO 'SYS.STANDARD.DUP_VAL_ON_INDEX'
              GOTO exception_handler_2
            END
          exception_handler_2:
            BEGIN
              -- Emulation of handler of OTHERS exception(s)
              IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not null)
              BEGIN
                EXEC SYSDB.SYS.DB_ERROR_RESET_EXCEPTION_INFO
                  declare @db_null_statement_3 int
              END
            END
            -- Processing unhandled exceptions
            IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not NULL)
              GOTO trigger_end_1
          END
          /* Oracle-trigger DBO.TIU_PER_EMP_JOB implementation: end */
--------------------------------------------------------------------------------------------------------
          /* DML-operation emulation */
          INSERT INTO DBO.PER_EMP_JOB (DEGREE_HOLD_FLAG, J_DEC_NO, END_DATE, J_DEC_DATE, EMP_JOB_DATE, EMP_DGR_DATE, EMP_JOB_SALARY, EMP_CODE, JOB_CLS_CODE, DEGREE_CODE, JOB_CODE)
          VALUES (@column_new_value____1, @column_new_value____2, @column_new_value____3, @column_new_value____4, @column_new_value____5, @column_new_value____6, @column_new_value____7, @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11)
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____1, @column_new_value____2, @column_new_value____3, @column_new_value____4, @column_new_value____5, @column_new_value____6, @column_new_value____7, @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        END
        
        CLOSE ForEachInsertedRowTriggerCursor
        DEALLOCATE ForEachInsertedRowTriggerCursor
      trigger_end_1:
        /*  end of trigger implementation */

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE 
    TRIGGER DBO.UP_PER_EMP_JOB_AFTER_UPDATE ON dbo.PER_EMP_JOB
      AFTER UPDATE
      AS 
        /*  begin of trigger implementation */
        SET NOCOUNT ON
        
        --  Temporary variable to store @@ERROR value
        DECLARE @error_store int
        /* column variables declaration */
        DECLARE
          @column_new_value____8 numeric(38),
          @column_new_value____9 numeric(5),
          @column_new_value____10 numeric(5),
          @column_new_value____11 numeric(5)
        /* iterate for each for from inserted/updated table(s) */
        DECLARE ForEachInsertedRowTriggerCursor CURSOR LOCAL FORWARD_ONLY READ_ONLY FOR
        SELECT EMP_CODE, JOB_CLS_CODE, DEGREE_CODE, JOB_CODE FROM inserted
        
        OPEN ForEachInsertedRowTriggerCursor
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        
        WHILE @@fetch_status = 0
        BEGIN
--------------------------------------------------------------------------------------------------------
          /* Oracle-trigger DBO.UP_PER_EMP_JOB implementation: begin */
          BEGIN
            IF ((UPDATE("JOB_CODE")) OR (UPDATE("JOB_CLS_CODE")) OR (UPDATE("DEGREE_CODE")))
              BEGIN
                UPDATE DBO.PER_EMP_DATA
                  SET DBO.PER_EMP_DATA.JOB_CLS_CODE = @column_new_value____9, DBO.PER_EMP_DATA.JOB_CODE = @column_new_value____11, DBO.PER_EMP_DATA.DEGREE_CODE = @column_new_value____10
                  WHERE (DBO.PER_EMP_DATA.EMP_CODE = @column_new_value____8)
                -- Store @@ERROR value to the temporary variable 
                SET @error_store = @@ERROR
                -- Emulation of SYS.STANDARD.DUP_VAL_ON_INDEX exception
                IF (@error_store = 2627)
                BEGIN
                  EXEC SYSDB.SYS.DB_ERROR_SET_EXCEPTION_INFO 'SYS.STANDARD.DUP_VAL_ON_INDEX'
                  GOTO block_end_2
                END
                BEGIN
                  -- Emulation of handler of OTHERS exception(s)
                  IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not null)
                  BEGIN
                    EXEC SYSDB.SYS.DB_ERROR_RESET_EXCEPTION_INFO
                      declare @db_null_statement_2 int
                  END
                END
              END
          block_end_2:
            -- Processing unhandled exceptions
            IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not NULL)
              GOTO trigger_end_1
          END
          /* Oracle-trigger DBO.UP_PER_EMP_JOB implementation: end */
--------------------------------------------------------------------------------------------------------
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        END
        
        CLOSE ForEachInsertedRowTriggerCursor
        DEALLOCATE ForEachInsertedRowTriggerCursor
      trigger_end_1:
        /*  end of trigger implementation */

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE 
    TRIGGER DBO.INSTEAD_OF_UPDATE_ON_PER_EMP_JOB ON dbo.PER_EMP_JOB
      INSTEAD OF UPDATE
      AS 
        /*  begin of trigger implementation */
        SET NOCOUNT ON
        
        --  Temporary variable to store @@ERROR value
        DECLARE @error_store int
        /* column variables declaration */
        DECLARE
          @column_new_value____0 uniqueidentifier,
          @column_new_value____1 numeric(1),
          @column_new_value____2 numeric(12),
          @column_new_value____3 datetime,
          @column_new_value____4 datetime,
          @column_new_value____5 datetime,
          @column_new_value____6 datetime,
          @column_new_value____7 numeric(8, 2),
          @column_new_value____8 numeric(38),
          @column_new_value____9 numeric(5),
          @column_new_value____10 numeric(5),
          @column_new_value____11 numeric(5)
        /* iterate for each for from inserted/updated table(s) */
        DECLARE ForEachInsertedRowTriggerCursor CURSOR LOCAL FORWARD_ONLY READ_ONLY FOR
        SELECT ROWID, DEGREE_HOLD_FLAG, J_DEC_NO, END_DATE, J_DEC_DATE, EMP_JOB_DATE, EMP_DGR_DATE, EMP_JOB_SALARY, EMP_CODE, JOB_CLS_CODE, DEGREE_CODE, JOB_CODE FROM inserted
        
        OPEN ForEachInsertedRowTriggerCursor
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____0, @column_new_value____1, @column_new_value____2, @column_new_value____3, @column_new_value____4, @column_new_value____5, @column_new_value____6, @column_new_value____7, @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        
        WHILE @@fetch_status = 0
        BEGIN
--------------------------------------------------------------------------------------------------------
          /* Oracle-trigger DBO.TIU_PER_EMP_JOB implementation: begin */
          BEGIN
            UPDATE DBO.PER_EMP_DATA
              SET DBO.PER_EMP_DATA.JOB_CLS_CODE = @column_new_value____9, DBO.PER_EMP_DATA.JOB_CODE = @column_new_value____11, DBO.PER_EMP_DATA.DEGREE_CODE = @column_new_value____10
              WHERE (DBO.PER_EMP_DATA.EMP_CODE = @column_new_value____8)
            -- Store @@ERROR value to the temporary variable 
            SET @error_store = @@ERROR
            -- Emulation of SYS.STANDARD.DUP_VAL_ON_INDEX exception
            IF (@error_store = 2627)
            BEGIN
              EXEC SYSDB.SYS.DB_ERROR_SET_EXCEPTION_INFO 'SYS.STANDARD.DUP_VAL_ON_INDEX'
              GOTO exception_handler_2
            END
          exception_handler_2:
            BEGIN
              -- Emulation of handler of OTHERS exception(s)
              IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not null)
              BEGIN
                EXEC SYSDB.SYS.DB_ERROR_RESET_EXCEPTION_INFO
                  declare @db_null_statement_4 int
              END
            END
            -- Processing unhandled exceptions
            IF (SYSDB.SYS.DB_ERROR_GET_EXCEPTION_INFO() is not NULL)
              GOTO trigger_end_1
          END
          /* Oracle-trigger DBO.TIU_PER_EMP_JOB implementation: end */
--------------------------------------------------------------------------------------------------------
          /* DML-operation emulation */
          UPDATE DBO.PER_EMP_JOB
          SET
          DEGREE_HOLD_FLAG = @column_new_value____1,
          J_DEC_NO = @column_new_value____2,
          END_DATE = @column_new_value____3,
          J_DEC_DATE = @column_new_value____4,
          EMP_JOB_DATE = @column_new_value____5,
          EMP_DGR_DATE = @column_new_value____6,
          EMP_JOB_SALARY = @column_new_value____7,
          EMP_CODE = @column_new_value____8,
          JOB_CLS_CODE = @column_new_value____9,
          DEGREE_CODE = @column_new_value____10,
          JOB_CODE = @column_new_value____11
          WHERE
          ROWID = @column_new_value____0
        FETCH NEXT FROM ForEachInsertedRowTriggerCursor INTO @column_new_value____0, @column_new_value____1, @column_new_value____2, @column_new_value____3, @column_new_value____4, @column_new_value____5, @column_new_value____6, @column_new_value____7, @column_new_value____8, @column_new_value____9, @column_new_value____10, @column_new_value____11
        END
        
        CLOSE ForEachInsertedRowTriggerCursor
        DEALLOCATE ForEachInsertedRowTriggerCursor
      trigger_end_1:
        /*  end of trigger implementation */

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE TRIGGER Insert_MoveQty ON dbo.StockMovement
FOR INSERT
AS
declare @InvId as bigint
declare @ProductId as bigint
declare @UnitId as bigint
declare @StoreFromId as bigint
declare @StoreToId as bigint
declare @Qty as float



select  @ProductId =ProductId from inserted
select  @UnitId =UnitID from inserted
select  @StoreFromId  =STOREFromID  from inserted
select  @StoreToId  =STOREToID  from inserted
select @Qty= ISNULL(MovmentQty , 0) from inserted


if (@Qty<>0)
begin

	
	
	
		update STOCK set QUANTITY = QUANTITY+@Qty  where STOREID = @StoreToId and PRODUCTID=@ProductId and  UnitID=@UnitId

		update STOCK set QUANTITY = QUANTITY-@Qty  where STOREID = @STOREFromID and PRODUCTID=@ProductId and  UnitID=@UnitId

	

end



GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE TRIGGER Update_MoveQty ON dbo.StockMovement
FOR update
AS

declare @OldProductId as bigint
declare @OldUnitId as bigint
declare @OldStoreFromId as bigint
declare @OldStoreToId as bigint
declare @OldQty as float

declare @ProductId as bigint
declare @UnitId as bigint
declare @StoreFromId as bigint
declare @StoreToId as bigint
declare @Qty as float


select  @ProductId =ProductId from inserted
select  @UnitId =UnitID from inserted
select  @StoreFromId  =STOREFromID  from inserted
select  @StoreToId  =STOREToID  from inserted
select @Qty= ISNULL(MovmentQty , 0) from inserted

select  @OldProductId =ProductId from deleted
select  @OldUnitId =UnitID from deleted
select  @OldStoreFromId  =STOREFromID  from deleted
select  @OldStoreToId  =STOREToID  from deleted
select @OldQty= ISNULL(MovmentQty , 0) from deleted

if (@Qty<>0)
begin

		update STOCK set QUANTITY = QUANTITY-@Qty  where STOREID = @OldStoreToId and PRODUCTID=@OldProductId and  UnitID=@OldUnitId

		update STOCK set QUANTITY = QUANTITY+@Qty  where STOREID = @OldSTOREFromID and PRODUCTID=@OldProductId and  UnitID=@OldUnitId

	
		
		update STOCK set QUANTITY = QUANTITY+@Qty  where STOREID = @StoreToId and PRODUCTID=@ProductId and  UnitID=@UnitId

		update STOCK set QUANTITY = QUANTITY-@Qty  where STOREID = @STOREFromID and PRODUCTID=@ProductId and  UnitID=@UnitId


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

CREATE TRIGGER AcctUpdate ON dbo.accounting 
after  UPDATE
AS
Declare @accountId bigint
Declare @accountParentId bigint
declare @OldClosedTo as bigint
declare @NewClosedTo as int
declare @TotalFromvalue as money
declare @TotalTovalue as money

declare @OldTotalFromvalue as money
declare @OldTotalTovalue as money

declare @DifTotalTovalue as money
declare @DifTotalFromvalue as money

select @NewClosedTo= ClosedTo from Inserted
select @OldClosedTo= ClosedTo from deleted

select @accountId =accountId from inserted 
select @TotalFromvalue =TotalFromvalue from inserted 
select @TotalTovalue =TotalTovalue from inserted 
select @OldTotalFromvalue =TotalFromvalue from deleted 
select @OldTotalTovalue =TotalTovalue from deleted 

select @accountParentId=accountParentId from inserted

set @DifTotalFromvalue= ISNULL(@Totalfromvalue, 0)- ISNULL(@OldTotalFromvalue,0)

-- accounting set Totalfromvalue = ISNULL(Totalfromvalue, 0)+ISNULL(@DifTotalFromvalue,0) where accountId = @accountId 
--update accounting set Totalfromvalue = ISNULL(Totalfromvalue, 0)+ISNULL(@DifTotalFromvalue,0) where accountId = @accountParentId 

set @DifTotalTovalue=ISNULL(@TotalTovalue, 0)- ISNULL(@OldTotalTovalue,0) 
--update accounting set TotalTovalue = ISNULL(TotalTovalue, 0)- ISNULL(@OldTotalTovalue,0) where accountId = @accountParentId 
--update accounting set TotalTovalue = ISNULL(TotalTovalue, 0)+ISNULL(@DifTotalTovalue,0) where accountId = @accountId 
--update accounting set TotalTovalue = ISNULL(TotalTovalue, 0)+ISNULL(@DifTotalTovalue,0) where accountId = @accountParentId 

exec  usp_AccountUpdateBalance @accountParentId,@DifTotalFromvalue,@DifTotalTovalue


--if (@OldClosedTo <> @NewClosedTo)
--begin
	exec usp_AccountUpdateClosedTo @accountId,@NewClosedTo
	--update accounting set ClosedTo= @NewClosedTo where AccountParentId = @accountId

--end

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE TRIGGER DelAccountTrg ON dbo.accounting 
FOR DELETE 
AS

declare @AccountId as bigint

select  @AccountId =accountid from deleted
delete from accounting where AccountParentId=@Accountid

GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

CREATE TRIGGER delQidDet  ON [dbo].[qidsDetails] 
FOR DELETE 
AS

declare @AccountId as bigint
declare @ToValue as money
declare @fromValue as money
declare @OldToValue as money
declare @OldfromValue as money
declare @Detcode as int 

select  @AccountId =accountId from deleted
select  @OldToValue =ISNULL(Tovalue, 0) from deleted
select @OldfromValue= ISNULL(FromValue , 0) from deleted
select @Detcode = ISNULL(Detcode , 0) from deleted

if (@ToValue<>0)
	begin
	update accounting set Totaltovalue = ISNULL(Totaltovalue, 0)-@OldToValue where accountId = @AccountId 
	delete from qidsDetails where  Detcode=@Detcode
	end 
else
	begin
	update accounting set TotalFromvalue = ISNULL(TotalFromvalue, 0)-@OldFromValue where accountId = @AccountId 
	delete from qidsDetails where  Detcode=@Detcode
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

CREATE TRIGGER Insert_Qid ON dbo.qidsDetails 
FOR INSERT
AS
declare @AccountId as bigint
declare @ToValue as money
declare @fromValue as money

select  @AccountId =accountId from inserted
select  @ToValue =ISNULL(Tovalue, 0.00) from inserted
select @fromValue= ISNULL(FromValue , 0.00) from inserted
if (@ToValue<>0)
begin
update accounting set Totaltovalue = ISNULL(Totaltovalue, 0.00)+@ToValue  , ProcessFlag=1 where accountId = @AccountId 
end 
if (@fromValue<>0)
begin
update accounting set Totalfromvalue = ISNULL(Totalfromvalue, 0.00)+@FromValue ,ProcessFlag=1 where accountId = @AccountId 
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

CREATE TRIGGER Update_Qid ON dbo.qidsDetails 
after  UPDATE
AS
declare @AccountId as bigint
declare @OldAccountId as bigint

declare @ToValue as money
declare @fromValue as money
declare @OldToValue as money
declare @OldfromValue as money

select  @AccountId =accountId from inserted
select  @OldToValue =ISNULL(Tovalue, 0) from deleted
select @OldfromValue= ISNULL(FromValue , 0) from deleted
select @OldAccountId =accountId from deleted

select  @ToValue =ISNULL(Tovalue, 0) from inserted
select @fromValue= ISNULL(FromValue , 0) from inserted
if (@ToValue<>0)
begin
update accounting set Totaltovalue = ISNULL(Totaltovalue, 0)-@OldToValue where accountId = @OldAccountId 
update accounting set Totaltovalue = ISNULL(Totaltovalue, 0)+@ToValue where accountId = @AccountId 
end 
else
begin
update accounting set TotalFromvalue = ISNULL(TotalFromvalue, 0)-@OldFromValue where accountId = @OldAccountId 
update accounting set TotalFromvalue = ISNULL(TotalFromvalue, 0)+@FromValue where accountId = @AccountId 
end


GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

