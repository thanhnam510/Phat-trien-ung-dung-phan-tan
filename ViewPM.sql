USE [QLVT]
GO

/****** Object:  View [dbo].[v_ds_phanmanh]    Script Date: 10/28/2018 12:17:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create View [dbo].[v_ds_phanmanh]
As
SELECT       PUBS.description AS CHINHANH, SUBS.subscriber_server AS TENSERVER
FROM            dbo.sysmergepublications AS PUBS INNER JOIN
                         dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server
GO


