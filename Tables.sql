if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[HomeCustomer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[HomeCustomer]
GO

CREATE TABLE [dbo].[HomeCustomer] (
	[CustId] [bigint] IDENTITY (1, 1) NOT NULL ,
	[CustName] [varchar] (300) COLLATE Arabic_CI_AS NOT NULL ,
	[Address] [varchar] (400) COLLATE Arabic_CI_AS NULL ,
	[CustTel] [varchar] (50) COLLATE Arabic_CI_AS NULL 
) ON [PRIMARY]
GO

