USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[spDisableLogin]    Script Date: 10/28/2018 11:01:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spDisableLogin]
@MANV char(8)
AS
BEGIN
DECLARE @SQLString NVARCHAR(500)
DECLARE @TENLOGIN NVARCHAR(50)
select @TENLOGIN = name from sys.sql_logins where sid = (select sid from sys.sysusers where name = @MANV)
SET @SQLString = 'ALTER LOGIN ' + @TENLOGIN + ' Disable'
EXEC(@SQLString)
select 1
END

