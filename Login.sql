USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 10/28/2018 12:17:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
DECLARE @TENNHOM NVARCHAR(50)
select @TENUSER = name from sys.sysusers where sid = SUSER_SID(@TENLOGIN)
select @TENNHOM = NAME FROM sys.sysusers where UID =(SELECT GROUPUID FROM SYS.SYSMEMBERS
WHERE MEMBERUID =(SELECT UID FROM SYS.SYSUSERS WHERE NAME =@TENUSER))
select USERNAME = @TENUSER,HOTEN =(SELECT HO + ' ' + TEN FROM [dbo].[NHANVIEN] WHERE MANV =@TENUSER),TENNHOM = @TENNHOM
